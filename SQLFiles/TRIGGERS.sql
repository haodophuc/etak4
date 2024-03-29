USE QLKS;

IF EXISTS(SELECT 1 FROM sys.objects WHERE type = 'TR')
	DROP TRIGGER TR_PHIEU_THUE_PHONG_INSERT
GO

IF EXISTS(SELECT 1 FROM sys.objects WHERE type = 'TR')
	DROP TRIGGER TR_PHIEU_THUE_PHONG_UPDATE
GO

IF EXISTS(SELECT 1 FROM sys.objects WHERE type = 'TR')
	DROP TRIGGER TR_PHONG_INSERT
GO

------------------------------------- INSERT TRIGGER ON PHONG ---------------------------------------------
-- This trigger is used to create room number (go with FN_GENERATE_ROOM_NUMBER)
CREATE TRIGGER TR_PHONG_INSERT ON PHONG AFTER INSERT 
AS 
UPDATE PHONG 
SET PHONG.SO_PHONG = dbo.FN_GENERATE_ROOM_NUMBER(PHONG.MA_PHONG) 
FROM PHONG INNER JOIN INSERTED ON PHONG.MA_PHONG = INSERTED.MA_PHONG
GO
-----------------------------------------------------------------------------------------------------------




-------------------------------------- UPDATE TRIGGER ON PHIEU_THUE_PHONG ----------------------------------
CREATE TRIGGER TR_PHIEU_THUE_PHONG_UPDATE ON PHIEU_THUE_PHONG AFTER UPDATE 
AS
BEGIN

-- This trigger snipplet is used to set DA_TRA_PHONG = 1 after fill NGAY_TRA_PHONG
IF EXISTS(SELECT 1 
		  FROM PHIEU_THUE_PHONG A INNER JOIN DELETED B ON A.MA_PHIEU = B.MA_PHIEU
		  WHERE A.NGAY_TRA_PHONG IS NOT NULL)
BEGIN
	UPDATE PHIEU_THUE_PHONG 
	SET PHIEU_THUE_PHONG.DA_TRA_PHONG = 1
	FROM PHIEU_THUE_PHONG A INNER JOIN DELETED B ON A.MA_PHIEU = B.MA_PHIEU
END
ELSE
BEGIN
	UPDATE PHIEU_THUE_PHONG 
	SET PHIEU_THUE_PHONG.DA_TRA_PHONG = 0
	FROM PHIEU_THUE_PHONG A INNER JOIN DELETED B ON A.MA_PHIEU = B.MA_PHIEU
END

-- if there is a row with SO_PHONG = 1 and NGAY_TRA_PHONG is null, updating a row with SO_PHONG = 1 is NOT ALLOWED
-- dịch ra là khi phòng đó chưa được trả thì không được thuê @_@
--IF EXISTS(SELECT 1 
--		  FROM PHIEU_THUE_PHONG A INNER JOIN INSERTED B ON A.MA_PHONG = B.MA_PHONG 
--		  WHERE A.NGAY_TRA_PHONG IS NULL AND A.MA_PHIEU <> B.MA_PHIEU)
--BEGIN	
--	ROLLBACK TRANSACTION
--END
END
GO
-----------------------------------------------------------------------------------------------------------





-------------------------------------- INSERT TRIGGER ON PHIEU_THUE_PHONG ---------------------------------------
CREATE TRIGGER TR_PHIEU_THUE_PHONG_INSERT ON PHIEU_THUE_PHONG AFTER INSERT 
AS
BEGIN

-- This trigger snipplet is used to set DA_TRA_PHONG = 1 after fill NGAY_TRA_PHONG
-- dịch ra là nếu NGAY_TRA_PHONG khác null thì DA_TRA_PHONG là true, và ngược lại @_@
IF EXISTS(SELECT 1 
		  FROM PHIEU_THUE_PHONG A INNER JOIN INSERTED B ON A.MA_PHIEU = B.MA_PHIEU
		  WHERE A.NGAY_TRA_PHONG IS NOT NULL)
BEGIN
	UPDATE PHIEU_THUE_PHONG 
	SET PHIEU_THUE_PHONG.DA_TRA_PHONG = 1
	FROM PHIEU_THUE_PHONG A INNER JOIN INSERTED B ON A.MA_PHIEU = B.MA_PHIEU
END
ELSE
BEGIN
	UPDATE PHIEU_THUE_PHONG 
	SET PHIEU_THUE_PHONG.DA_TRA_PHONG = 0
	FROM PHIEU_THUE_PHONG A INNER JOIN INSERTED B ON A.MA_PHIEU = B.MA_PHIEU
END


-- if there is a row with SO_PHONG = 1 and NGAY_TRA_PHONG is null, inserting a row with SO_PHONG = 1 is NOT ALLOWED
-- dịch ra là khi phòng đó chưa được trả thì không được thuê @_@
DECLARE @last_id INT
DECLARE @restored_id INT

-- save the last identity after inserting
SET @last_id = @@IDENTITY
IF EXISTS(SELECT 1 
		  FROM PHIEU_THUE_PHONG A INNER JOIN INSERTED B ON A.MA_PHONG = B.MA_PHONG 
		  WHERE A.NGAY_TRA_PHONG IS NULL AND A.MA_PHIEU <> B.MA_PHIEU)
BEGIN	
	ROLLBACK TRANSACTION
	
	SET @restored_id = @last_id - 1

	-- reseed identity to @X - 1
	-- nghĩa là sau khi insert thất bại trong đây, identity vẫn tăng lên 1, vì vậy phải reset identity lại trước khi nó tăng
	-- lưu ý là nếu không phải do gặp rollback trong đây mà là do nhập sai cái gì khác thì identity vẫn tăng~_~
	DBCC CHECKIDENT(PHIEU_THUE_PHONG, RESEED, @restored_id)
END

-- đoàn khách thuê phòng mà chưa trả thì không cho thuê nữa
--IF EXISTS(SELECT 1 
--		  FROM PHIEU_THUE_PHONG A INNER JOIN INSERTED B ON A.MA_DOAN_KHACH = B.MA_DOAN_KHACH
--		  WHERE A.NGAY_TRA_PHONG IS NULL AND A.MA_PHIEU <> B.MA_PHIEU)
--BEGIN
--	ROLLBACK TRANSACTION
--	SET @restored_id = @last_id - 1
--	DBCC CHECKIDENT(PHIEU_THUE_PHONG, RESEED, @restored_id)	
--END

-- tương tự với khách hàng
---- .....................

-- còn 1 cái nữa là thuê rồi thì phải cấm đặt =)) ai làm đi, tao ko làm tại thấy nhảm nhảm
---- .....................

END
GO
-----------------------------------------------------------------------------------------------------------