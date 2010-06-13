USE QLKS;

IF EXISTS(SELECT 1 FROM sys.server_principals WHERE name = 'ADMIN')
	DROP LOGIN ADMIN

IF EXISTS(SELECT 1 FROM sys.database_principals WHERE name = 'ADMIN')
	DROP USER ADMIN

----------- create user QLKS_ADMIN and grant privileges for QLKS_ADMIN -----------
CREATE LOGIN ADMIN WITH PASSWORD = '1234', DEFAULT_DATABASE = QLKS

-- this login is allowed to create and alter databases
EXEC sp_addsrvrolemember 'ADMIN', 'dbcreator'

CREATE USER ADMIN FOR LOGIN ADMIN
GRANT SELECT, INSERT, UPDATE, DELETE ON OBJECT::PHIEU_DANG_KY_DICH_VU TO ADMIN
GRANT SELECT, INSERT, UPDATE, DELETE ON OBJECT::DICH_VU TO ADMIN
GRANT SELECT, INSERT, UPDATE, DELETE ON OBJECT::PHIEU_THUE_PHONG TO ADMIN
GRANT SELECT, INSERT, UPDATE, DELETE ON OBJECT::PHONG TO ADMIN
GRANT SELECT, INSERT, UPDATE, DELETE ON OBJECT::KHACH_HANG TO ADMIN
GRANT SELECT, INSERT, UPDATE, DELETE ON OBJECT::QUOC_GIA TO ADMIN
GRANT SELECT, INSERT, UPDATE, DELETE ON OBJECT::LOAI_PHONG TO ADMIN
GRANT SELECT, INSERT, UPDATE, DELETE ON OBJECT::TINH_TRANG TO ADMIN
GRANT SELECT, INSERT, UPDATE, DELETE ON OBJECT::CONG_TY TO ADMIN
GRANT SELECT, INSERT, UPDATE, DELETE ON OBJECT::DOAN_KHACH TO ADMIN
GRANT SELECT, INSERT, UPDATE, DELETE ON OBJECT::KHACH_TRO TO ADMIN
GRANT SELECT, INSERT, UPDATE, DELETE ON OBJECT::PHIEU_THU_KHACH_HANG TO ADMIN
GRANT SELECT, INSERT, UPDATE, DELETE ON OBJECT::PHIEU_THU_DOAN_KHACH TO ADMIN
GRANT SELECT, INSERT, UPDATE, DELETE ON OBJECT::PHIEU_DAT_PHONG TO ADMIN
GRANT SELECT, INSERT, UPDATE, DELETE ON OBJECT::CA_TRUC TO ADMIN

GRANT SELECT, INSERT, UPDATE, DELETE ON OBJECT::USERS TO ADMIN
GRANT SELECT, INSERT, UPDATE, DELETE ON OBJECT::ROLES TO ADMIN
GRANT SELECT, INSERT, UPDATE, DELETE ON OBJECT::USER2ROLE TO ADMIN

GRANT EXECUTE ON OBJECT::FN_DID_THIS_USER_EXIST TO ADMIN
GRANT EXECUTE ON OBJECT::FN_DATABASE_CONTAINS_USER TO ADMIN
GRANT EXECUTE ON OBJECT::FN_USER_HAS_ROLE TO ADMIN
GRANT EXECUTE ON OBJECT::FN_IS_ADMIN TO ADMIN

GRANT EXECUTE ON OBJECT::SP_DELETE_USER TO ADMIN
GRANT EXECUTE ON OBJECT::SP_CHANGE_PASSWORD TO ADMIN
GRANT EXECUTE ON OBJECT::SP_INSERT_USER TO ADMIN
GRANT EXECUTE ON OBJECT::SP_INSERT_SERVICE_ORDER_BILL TO ADMIN
GRANT EXECUTE ON OBJECT::SP_INSERT_CUSTOMER TO ADMIN
GRANT EXECUTE ON OBJECT::SP_INSERT_PHIEU_THUE_PHONG TO ADMIN
GRANT EXECUTE ON OBJECT::SP_INSERT_PHIEU_DAT_PHONG TO ADMIN
GRANT EXECUTE ON OBJECT::SP_HE_SO_SU_DUNG_PHONG TO ADMIN
GRANT EXECUTE ON OBJECT::SP_DOANH_THU TO ADMIN 
GRANT EXECUTE ON OBJECT::sp_tienphong TO ADMIN
GRANT EXECUTE ON OBJECT::sp_tiendichvu TO ADMIN
GRANT EXECUTE ON OBJECT::sp_tiencocKH TO ADMIN
GRANT EXECUTE ON OBJECT::sp_tiencocDK TO ADMIN