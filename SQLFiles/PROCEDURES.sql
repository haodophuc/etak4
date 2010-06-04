USE QLKS;

IF EXISTS(SELECT 1 FROM sys.objects WHERE type = 'P')
	DROP PROCEDURE SP_INSERT_SERVICE_ORDER_BILL
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