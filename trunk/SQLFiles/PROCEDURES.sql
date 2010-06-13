USE QLKS;

IF EXISTS(SELECT 1 FROM sys.objects WHERE type = 'P')
	DROP PROCEDURE SP_HE_SO_SU_DUNG_PHONG
GO

IF EXISTS(SELECT 1 FROM sys.objects WHERE type = 'P')
	DROP PROCEDURE SP_DELETE_USER
GO

IF EXISTS(SELECT 1 FROM sys.objects WHERE type = 'P')
	DROP PROCEDURE SP_CHANGE_PASSWORD
GO

IF EXISTS(SELECT 1 FROM sys.objects WHERE type = 'P')
	DROP PROCEDURE SP_INSERT_USER
GO

IF EXISTS(SELECT 1 FROM sys.objects WHERE type = 'P')
	DROP PROCEDURE SP_INSERT_SERVICE_ORDER_BILL
GO

IF EXISTS(SELECT 1 FROM sys.objects WHERE type = 'P')
	DROP PROCEDURE SP_INSERT_CUSTOMER
GO

IF EXISTS(SELECT 1 FROM sys.objects WHERE type = 'P')
	DROP PROCEDURE SP_INSERT_PHIEU_THUE_PHONG
GO

IF EXISTS(SELECT 1 FROM sys.objects WHERE type = 'P')
	DROP PROCEDURE SP_EMPTY_ALL_TABLES
GO

IF EXISTS(SELECT 1 FROM sys.objects WHERE type = 'P')
	DROP PROCEDURE SP_TIENPHONG
GO

IF EXISTS(SELECT 1 FROM sys.objects WHERE type = 'P')
	DROP PROCEDURE SP_TIENDICHVU
GO

IF EXISTS(SELECT 1 FROM sys.objects WHERE type = 'P')
	DROP PROCEDURE SP_TIENCOCKH
GO

IF EXISTS(SELECT 1 FROM sys.objects WHERE type = 'P')
	DROP PROCEDURE SP_TIENCOCDK
GO

CREATE PROC SP_DELETE_USER
@USERID INT
AS
BEGIN
UPDATE USERS SET DELETED = 1 WHERE USERID = @USERID
END
GO

CREATE PROC SP_CHANGE_PASSWORD
@USER_NAME NVARCHAR(255),
@OLD_PASSWORD NVARCHAR(255),
@NEW_PASSWORD NVARCHAR(255)
AS
BEGIN
UPDATE USERS SET USER_PASSWORD = @NEW_PASSWORD WHERE USER_NAME = @USER_NAME AND USER_PASSWORD = @OLD_PASSWORD
END
GO

CREATE PROC SP_INSERT_USER
@IDENTITY INT OUT,
@USER_NAME NVARCHAR(255),
@USER_PASSWORD NVARCHAR(255),
@FIRST_NAME NVARCHAR(50),
@LAST_NAME NVARCHAR(50),
@IS_ADMIN BIT,
@ADDRESS_STREET NVARCHAR(50),
@PHONE NVARCHAR(50),
@EMAIL NVARCHAR(50),
@DETAILS NVARCHAR(25)
AS
BEGIN
INSERT INTO USERS (USER_NAME, USER_PASSWORD, FIRST_NAME, LAST_NAME, IS_ADMIN,
ADDRESS_STREET, PHONE, EMAIL, DETAILS)
VALUES (@USER_NAME, @USER_PASSWORD, @FIRST_NAME, @LAST_NAME, @IS_ADMIN, 
@ADDRESS_STREET, @PHONE, @EMAIL, @DETAILS)
SET @IDENTITY = SCOPE_IDENTITY()
END
GO

CREATE PROCEDURE SP_INSERT_SERVICE_ORDER_BILL
@IDENTITY INT OUT,
@MA_PHIEU INT,
@MA_DICH_VU INT,
@NGAY_PHUC_VU DATETIME,
@SO_LUONG INT,
@GHI_CHU NVARCHAR(50)
AS
BEGIN
INSERT INTO PHIEU_DANG_KY_DICH_VU (MA_PHIEU, MA_DICH_VU, NGAY_PHUC_VU, SO_LUONG, GHI_CHU)
VALUES (@MA_PHIEU, @MA_DICH_VU, @NGAY_PHUC_VU, @SO_LUONG, @GHI_CHU)
SET @IDENTITY = SCOPE_IDENTITY()
END
GO

CREATE PROCEDURE SP_INSERT_CUSTOMER
@IDENTITY INT OUT,
@MA_QUOC_GIA INT, 
@HO_KHACH_HANG NVARCHAR(50),
@TEN_KHACH_HANG NVARCHAR(50),
@CMND NVARCHAR(20),
@HO_CHIEU NVARCHAR(20),
@DIEN_THOAI NVARCHAR(50)
AS
BEGIN
INSERT INTO KHACH_HANG(MA_QUOC_GIA, HO_KHACH_HANG, TEN_KHACH_HANG, CMND, HO_CHIEU, DIEN_THOAI)
VALUES (@MA_QUOC_GIA, @HO_KHACH_HANG, @TEN_KHACH_HANG, @CMND, @HO_CHIEU, @DIEN_THOAI)
SET @IDENTITY = SCOPE_IDENTITY();
END
GO


CREATE PROCEDURE SP_INSERT_PHIEU_THUE_PHONG
@IDENTITY INT OUT,
@MA_KHACH_HANG INT,
@MA_DOAN_KHACH INT,
@MA_PHONG INT,
@NGAY_NHAN_PHONG DATETIME
AS
BEGIN
INSERT INTO PHIEU_THUE_PHONG(MA_KHACH_HANG,MA_DOAN_KHACH, MA_PHONG, NGAY_NHAN_PHONG)
VALUES(@MA_KHACH_HANG,@MA_DOAN_KHACH,@MA_PHONG,@NGAY_NHAN_PHONG)
SET @IDENTITY = SCOPE_IDENTITY();
END
GO

-------- This function is used for truncating all data from all tables --------

CREATE PROCEDURE SP_EMPTY_ALL_TABLES (@RESET_IDENTITY BIT)
AS
BEGIN
    DECLARE @SQL VARCHAR(500)
    DECLARE @TABLE_NAME VARCHAR(255)
    DECLARE @CONSTRAINT_NAME VARCHAR(500)

    DECLARE CUR_ALL_FOREIGNER_KEYS SCROLL CURSOR FOR SELECT TABLE_NAME,CONSTRAINT_NAME FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS WHERE CONSTRAINT_TYPE='FOREIGN KEY'
    OPEN CUR_ALL_FOREIGNER_KEYS 

    FETCH NEXT FROM CUR_ALL_FOREIGNER_KEYS INTO @TABLE_NAME,@CONSTRAINT_NAME

    WHILE @@FETCH_STATUS=0
    BEGIN
        SET @SQL = 'ALTER TABLE ' + @TABLE_NAME + ' NOCHECK CONSTRAINT ' + @CONSTRAINT_NAME
        EXECUTE(@SQL)
        FETCH NEXT FROM CUR_ALL_FOREIGNER_KEYS INTO @TABLE_NAME,@CONSTRAINT_NAME
    END  

    DECLARE CUR_ALL_TABLES CURSOR FOR SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE='BASE TABLE'
    OPEN CUR_ALL_TABLES 

    FETCH NEXT FROM CUR_ALL_TABLES INTO @TABLE_NAME

    WHILE @@FETCH_STATUS=0
    BEGIN
        SET @SQL = 'DELETE FROM ' + @TABLE_NAME
            IF @RESET_IDENTITY = 1 AND OBJECTPROPERTY (OBJECT_ID(@TABLE_NAME),'TABLEHASIDENTITY')=1
                  SET @SQL = @SQL + '; DBCC CHECKIDENT(''' + @TABLE_NAME + ''',RESEED,0)'
        EXECUTE(@SQL)
        FETCH NEXT FROM CUR_ALL_TABLES INTO @TABLE_NAME
    END

    FETCH FIRST FROM CUR_ALL_FOREIGNER_KEYS INTO @TABLE_NAME,@CONSTRAINT_NAME

    WHILE @@FETCH_STATUS=0
    BEGIN
        SET @SQL = 'ALTER TABLE ' + @TABLE_NAME + ' CHECK CONSTRAINT ' + @CONSTRAINT_NAME
        EXECUTE(@SQL)
        FETCH NEXT FROM CUR_ALL_FOREIGNER_KEYS INTO @TABLE_NAME,@CONSTRAINT_NAME
    END

    CLOSE CUR_ALL_TABLES
    DEALLOCATE CUR_ALL_TABLES
    CLOSE CUR_ALL_FOREIGNER_KEYS
    DEALLOCATE CUR_ALL_FOREIGNER_KEYS  
END
GO
------------------- TIENPHONG--------------------
CREATE PROC [dbo].[sp_tienphong]
@MA_PHIEU int
AS
DECLARE @TIEN bigint;
DECLARE @NGAY_NHAN datetime;
DECLARE @NGAY_TRA datetime;
DECLARE @DON_GIA real;
DECLARE @THANH_TOAN bit;
DECLARE @NGAYO int;
Select @NGAY_NHAN=NGAY_NHAN_PHONG,@NGAY_TRA=NGAY_TRA_PHONG,@THANH_TOAN=THANH_TOAN_TIEN_PHONG,@DON_GIA=GIA_THAM_KHAO
From PHIEU_THUE_PHONG,PHONG,LOAI_PHONG
WHERE PHIEU_THUE_PHONG.MA_PHONG=PHONG.MA_PHONG AND PHONG.MA_LOAI_PHONG= LOAI_PHONG.MA_LOAI_PHONG
AND MA_PHIEU=@MA_PHIEU
IF(@THANH_TOAN='1')
	SET @TIEN=0;
ELSE 
	BEGIN
		IF @NGAY_TRA is NULL
		SET @NGAY_TRA=GETDate();
		
 SET @NGAYO=DateDiff(day,@NGAY_NHAN,@NGAY_TRA)
		if @NGAYO=0
			SET @NGAYO=1;
		SET @TIEN= @NGAYO*@DON_GIA
	END
SELECT @TIEN
GO
---------------TienDichVu----------------
CREATE PROC sp_tiendichvu
@MA_PHIEU int
AS 
DECLARE @TIEN bigint
DECLARE @THANH_TOAN bit
Select @TIEN=SUM((DON_GIA)*(SO_LUONG)),@THANH_TOAN=THANH_TOAN_DICH_VU
From PHIEU_THUE_PHONG,PHIEU_DANG_KY_DICH_VU,DICH_VU
WHERE PHIEU_THUE_PHONG.MA_PHIEU= PHIEU_DANG_KY_DICH_VU.MA_PHIEU AND PHIEU_DANG_KY_DICH_VU.MA_DICH_VU= DICH_VU.MA_DICH_VU
AND PHIEU_THUE_PHONG.MA_PHIEU=@MA_PHIEU
GROUP BY THANH_TOAN_DICH_VU
IF(@THANH_TOAN=1)
	SET @TIEN=0;
IF @TIEN is null
	SET @TIEN=0;
Select @TIEN
GO
-----TienCocKhachHang-------
CREATE PROC sp_tiencocKH
@MA_KHACH_HANG int
AS
DECLARE @TIEN bigint;
SELECT @TIEN=TIEN_COC
FROM PHIEU_DAT_PHONG
WHERE MA_KHACH_HANG=@MA_KHACH_HANG AND DA_GIAI_QUYET=0
IF @TIEN is NULL 
SET @TIEN=0
SELECT @TIEN
GO
--------TienCocDoanKhach---------
CREATE PROC sp_tiencocDK
@MA_DOAN_KHACH int
AS
DECLARE @TIEN bigint;
SELECT @TIEN=TIEN_COC
FROM PHIEU_DAT_PHONG
WHERE MA_DOAN_KHACH=@MA_DOAN_KHACH AND DA_GIAI_QUYET=0
IF @TIEN is NULL 
SET @TIEN=0
SELECT @TIEN
GO
--------HeSoSuDungPhong---------
CREATE PROC SP_HE_SO_SU_DUNG_PHONG
@FROM_TIME DateTime,
@TO_TIME DateTime
AS

SELECT TEN_LOAI_PHONG,SO_GIUONG,SO_LUONG_PHONG,GIA_THAM_KHAO,ROUND(SUM(SO_LAN_SU_DUNG)/(CAST(SO_LUONG_PHONG AS float)),4) AS HE_SO_SU_DUNG
FROM (SELECT SO_PHONG,TEN_LOAI_PHONG,SO_GIUONG,SO_LUONG_PHONG,GIA_THAM_KHAO,COUNT(MA_PHIEU) AS SO_LAN_SU_DUNG
	  FROM PHONG,PHIEU_THUE_PHONG,LOAI_PHONG
	  WHERE NGAY_NHAN_PHONG BETWEEN @FROM_TIME AND @TO_TIME
	  AND PHIEU_THUE_PHONG.MA_PHONG = PHONG.MA_PHONG
	  AND PHONG.MA_LOAI_PHONG = LOAI_PHONG.MA_LOAI_PHONG
	  GROUP BY SO_PHONG,TEN_LOAI_PHONG,SO_GIUONG,SO_LUONG_PHONG,GIA_THAM_KHAO)A
GROUP BY TEN_LOAI_PHONG,SO_GIUONG,GIA_THAM_KHAO,SO_LUONG_PHONG
ORDER BY TEN_LOAI_PHONG ASC
GO
-------Doanh Thu------------
CREATE PROC SP_DOANH_THU
@YEAR int
AS

SELECT A.THANG,SUM(A.TS_TIEN)AS TONG_SO_TIEN
FROM (SELECT MONTH(NGAY_PHIEU) AS THANG,SUM(SO_TIEN)AS TS_TIEN
	  FROM PHIEU_THU_DOAN_KHACH
	  WHERE YEAR(NGAY_PHIEU) = @YEAR
	  GROUP BY MONTH(NGAY_PHIEU)
	  UNION	  
	  SELECT MONTH(NGAY_PHIEU) AS THANG,SUM(SO_TIEN) AS TS_TIEN
	  FROM PHIEU_THU_KHACH_HANG
	  WHERE YEAR(NGAY_PHIEU) = @YEAR
      GROUP BY MONTH(NGAY_PHIEU))A
GROUP BY A.THANG




