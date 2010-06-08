USE QLKS;

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
@NGAY_NHAN_PHONG DATETIME,
@NGAY_TRA_PHONG DATETIME
AS
BEGIN
INSERT INTO PHIEU_THUE_PHONG(MA_KHACH_HANG,MA_DOAN_KHACH, MA_PHONG, NGAY_NHAN_PHONG,NGAY_TRA_PHONG)
VALUES(@MA_KHACH_HANG,@MA_DOAN_KHACH,@MA_PHONG,@NGAY_NHAN_PHONG,@NGAY_TRA_PHONG)
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
SET @TIEN =DateDiff(day,@NGAY_NHAN,@NGAY_TRA)*@DON_GIA;
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


