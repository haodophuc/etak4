USE QLKS;

-- delete all old data
EXEC SP_EMPTY_ALL_TABLES 1;

insert into QUOC_GIA (TEN_QUOC_GIA) values (N'Việt Nam')
go


insert into QUOC_GIA (TEN_QUOC_GIA) values (N'USA')
go


insert into QUOC_GIA (TEN_QUOC_GIA) values (N'Ý')
go


insert into QUOC_GIA (TEN_QUOC_GIA) values (N'Áo')
go


insert into QUOC_GIA (TEN_QUOC_GIA) values (N'Slovakia')
go


insert into QUOC_GIA (TEN_QUOC_GIA) values (N'Lào')
go


insert into QUOC_GIA (TEN_QUOC_GIA) values (N'Campuchia')
go


insert into QUOC_GIA (TEN_QUOC_GIA) values (N'Mexico')
go


insert into QUOC_GIA (TEN_QUOC_GIA) values (N'Pháp')
go


insert into QUOC_GIA (TEN_QUOC_GIA) values (N'Anh')
go


insert into QUOC_GIA (TEN_QUOC_GIA) values (N'NaUy')
go


insert into QUOC_GIA (TEN_QUOC_GIA) values (N'Hà Lan')
go


insert into QUOC_GIA (TEN_QUOC_GIA) values (N'Brazil')
go


insert into QUOC_GIA (TEN_QUOC_GIA) values (N'Mexico')
go


insert into QUOC_GIA (TEN_QUOC_GIA) values (N'Nam Phi')
go


insert into QUOC_GIA (TEN_QUOC_GIA) values (N'Singapore')
go


insert into QUOC_GIA (TEN_QUOC_GIA) values (N'Myanmar')
go


insert into QUOC_GIA (TEN_QUOC_GIA) values (N'Thái Lan')
go


insert into QUOC_GIA (TEN_QUOC_GIA) values (N'Nam Phi')
go


insert into QUOC_GIA (TEN_QUOC_GIA) values (N'Ấn Độ')
go


insert into TIEN_NGHI (TIEN_NGHI) values (N'Hệ thống điều hòa')
go


insert into TIEN_NGHI (TIEN_NGHI) values (N'Quạt Máy')
go


insert into TIEN_NGHI (TIEN_NGHI) values (N'Lò Sưởi')
go


insert into TIEN_NGHI (TIEN_NGHI) values (N'Tivi')
go


insert into TIEN_NGHI (TIEN_NGHI) values (N'Tủ Lạnh')
go


insert into TIEN_NGHI (TIEN_NGHI) values (N'Bàn trang điểm')
go


insert into TIEN_NGHI (TIEN_NGHI) values (N'Bàn Ti vi')
go


insert into TIEN_NGHI (TIEN_NGHI) values (N'Đầu Đĩa DVD')
go


insert into TIEN_NGHI (TIEN_NGHI) values (N'Điện Thoại')
go


insert into TIEN_NGHI (TIEN_NGHI) values (N'Quạt Trần')
go


insert into TIEN_NGHI (TIEN_NGHI) values (N'Truyền hình cáp')
go


insert into TIEN_NGHI (TIEN_NGHI) values (N'Điện thọai quốc tế')
go


insert into TIEN_NGHI (TIEN_NGHI) values (N'Minibar')
go


insert into TIEN_NGHI (TIEN_NGHI) values (N'Tủ két sắt')
go


insert into TIEN_NGHI (TIEN_NGHI) values (N'Điện thọai trong phòng tắm')
go


insert into TIEN_NGHI (TIEN_NGHI) values (N'Máy sấy tóc')
go


insert into TIEN_NGHI (TIEN_NGHI) values (N'Hệ thống báo cháy')
go


insert into TIEN_NGHI (TIEN_NGHI) values (N'Ban công')
go


insert into TIEN_NGHI (TIEN_NGHI) values (N'Laptop')
go


insert into TIEN_NGHI (TIEN_NGHI) values (N'Internet')
go


insert into LOAI_PHONG (TEN_LOAI_PHONG, SO_GIUONG, SO_LUONG_PHONG, GIA_THAM_KHAO) values (N'Phòng Đơn', 1, 10, 500000)
go


insert into LOAI_PHONG (TEN_LOAI_PHONG, SO_GIUONG, SO_LUONG_PHONG, GIA_THAM_KHAO) values (N'Phòng Đôi', 2, 8, 800000)
go


insert into LOAI_PHONG (TEN_LOAI_PHONG, SO_GIUONG, SO_LUONG_PHONG, GIA_THAM_KHAO) values (N'Phòng Ba', 3, 6, 1200000)
go


insert into LOAI_PHONG (TEN_LOAI_PHONG, SO_GIUONG, SO_LUONG_PHONG, GIA_THAM_KHAO) values (N'Phòng Bốn', 4, 4, 1500000)
go


insert into LOAI_PHONG (TEN_LOAI_PHONG, SO_GIUONG, SO_LUONG_PHONG, GIA_THAM_KHAO) values (N'Phòng Thượng Hạng', 2, 2, 2500000)
go


insert into DICH_VU (TEN_DICH_VU, DON_GIA, HIEU_LUC) values (N'Chuối', 1, 8)
go


insert into DICH_VU (TEN_DICH_VU, DON_GIA, HIEU_LUC) values (N'Chè', 17, 10)
go


insert into DICH_VU (TEN_DICH_VU, DON_GIA, HIEU_LUC) values (N'Cơm sườn', 15, 7)
go


insert into DICH_VU (TEN_DICH_VU, DON_GIA, HIEU_LUC) values (N'Cocacola', 13, 6)
go


insert into DICH_VU (TEN_DICH_VU, DON_GIA, HIEU_LUC) values (N'Heineken', 12, 1)
go


insert into DICH_VU (TEN_DICH_VU, DON_GIA, HIEU_LUC) values (N'Phở bò', 8, 17)
go


insert into DICH_VU (TEN_DICH_VU, DON_GIA, HIEU_LUC) values (N'Nước cam', 14, 14)
go


insert into DICH_VU (TEN_DICH_VU, DON_GIA, HIEU_LUC) values (N'Cà phê', 6, 11)
go


insert into DICH_VU (TEN_DICH_VU, DON_GIA, HIEU_LUC) values (N'Yaourt', 11, 16)
go


insert into DICH_VU (TEN_DICH_VU, DON_GIA, HIEU_LUC) values (N'Phá lấu', 4, 9)
go


insert into DICH_VU (TEN_DICH_VU, DON_GIA, HIEU_LUC) values (N'Bò kho', 19, 19)
go


insert into DICH_VU (TEN_DICH_VU, DON_GIA, HIEU_LUC) values (N'Cà ri gà', 18, 5)
go


insert into DICH_VU (TEN_DICH_VU, DON_GIA, HIEU_LUC) values (N'Mì gói', 16, 12)
go


insert into DICH_VU (TEN_DICH_VU, DON_GIA, HIEU_LUC) values (N'Trà sữa trân châu', 7, 4)
go


insert into DICH_VU (TEN_DICH_VU, DON_GIA, HIEU_LUC) values (N'Thịt heo nguyên tảng', 10, 15)
go


insert into DICH_VU (TEN_DICH_VU, DON_GIA, HIEU_LUC) values (N'3MCPD', 5, 2)
go


insert into DICH_VU (TEN_DICH_VU, DON_GIA, HIEU_LUC) values (N'Dr. Thanh', 3, 13)
go


insert into DICH_VU (TEN_DICH_VU, DON_GIA, HIEU_LUC) values (N'Tôm hùm', 0, 0)
go


insert into DICH_VU (TEN_DICH_VU, DON_GIA, HIEU_LUC) values (N'Dồi', 9, 18)
go


insert into DICH_VU (TEN_DICH_VU, DON_GIA, HIEU_LUC) values (N'Tuyệt cú mèo', 2, 3)
go


insert into TINH_TRANG (TINH_TRANG) values (N'Phòng Trống')
go


insert into TINH_TRANG (TINH_TRANG) values (N'Phòng Bận')
go


insert into TINH_TRANG (TINH_TRANG) values (N'Phòng chưa dọn dẹp')
go


insert into PHONG (MA_LOAI_PHONG, MA_TINH_TRANG, SO_PHONG) values (1, 1, '')
go


insert into PHONG (MA_LOAI_PHONG, MA_TINH_TRANG, SO_PHONG) values (1, 2, '')
go


insert into PHONG (MA_LOAI_PHONG, MA_TINH_TRANG, SO_PHONG) values (1, 3, '')
go


insert into PHONG (MA_LOAI_PHONG, MA_TINH_TRANG, SO_PHONG) values (1, 3, '')
go


insert into PHONG (MA_LOAI_PHONG, MA_TINH_TRANG, SO_PHONG) values (1, 2, '')
go


insert into PHONG (MA_LOAI_PHONG, MA_TINH_TRANG, SO_PHONG) values (1, 1, '')
go


insert into PHONG (MA_LOAI_PHONG, MA_TINH_TRANG, SO_PHONG) values (1, 2, '')
go


insert into PHONG (MA_LOAI_PHONG, MA_TINH_TRANG, SO_PHONG) values (1, 3, '')
go


insert into PHONG (MA_LOAI_PHONG, MA_TINH_TRANG, SO_PHONG) values (1, 1, '')
go


insert into PHONG (MA_LOAI_PHONG, MA_TINH_TRANG, SO_PHONG) values (1, 3, '')
go


insert into PHONG (MA_LOAI_PHONG, MA_TINH_TRANG, SO_PHONG) values (2, 1, '')
go


insert into PHONG (MA_LOAI_PHONG, MA_TINH_TRANG, SO_PHONG) values (2, 2, '')
go


insert into PHONG (MA_LOAI_PHONG, MA_TINH_TRANG, SO_PHONG) values (2, 3, '')
go


insert into PHONG (MA_LOAI_PHONG, MA_TINH_TRANG, SO_PHONG) values (2, 2, '')
go


insert into PHONG (MA_LOAI_PHONG, MA_TINH_TRANG, SO_PHONG) values (2, 1, '')
go


insert into PHONG (MA_LOAI_PHONG, MA_TINH_TRANG, SO_PHONG) values (2, 2, '')
go


insert into PHONG (MA_LOAI_PHONG, MA_TINH_TRANG, SO_PHONG) values (2, 3, '')
go


insert into PHONG (MA_LOAI_PHONG, MA_TINH_TRANG, SO_PHONG) values (2, 1, '')
go


insert into PHONG (MA_LOAI_PHONG, MA_TINH_TRANG, SO_PHONG) values (3, 1, '')
go


insert into PHONG (MA_LOAI_PHONG, MA_TINH_TRANG, SO_PHONG) values (3, 1, '')
go

insert into PHONG (MA_LOAI_PHONG, MA_TINH_TRANG, SO_PHONG) values (3, 2, '')
go

insert into PHONG (MA_LOAI_PHONG, MA_TINH_TRANG, SO_PHONG) values (3, 3, '')
go

insert into PHONG (MA_LOAI_PHONG, MA_TINH_TRANG, SO_PHONG) values (3, 1, '')
go

insert into PHONG (MA_LOAI_PHONG, MA_TINH_TRANG, SO_PHONG) values (3, 1, '')
go

insert into PHONG (MA_LOAI_PHONG, MA_TINH_TRANG, SO_PHONG) values (4, 1, '')
go

insert into PHONG (MA_LOAI_PHONG, MA_TINH_TRANG, SO_PHONG) values (4, 3, '')
go

insert into PHONG (MA_LOAI_PHONG, MA_TINH_TRANG, SO_PHONG) values (4, 1, '')
go

insert into PHONG (MA_LOAI_PHONG, MA_TINH_TRANG, SO_PHONG) values (4, 2, '')
go

insert into PHONG (MA_LOAI_PHONG, MA_TINH_TRANG, SO_PHONG) values (5, 1, '')
go

insert into PHONG (MA_LOAI_PHONG, MA_TINH_TRANG, SO_PHONG) values (5, 1, '')
go

insert into TIEN_NGHI_LOAI_PHONG (MA_TIEN_NGHI, MA_LOAI_PHONG) values (1, 1)
go


insert into TIEN_NGHI_LOAI_PHONG (MA_TIEN_NGHI, MA_LOAI_PHONG) values (2, 1)
go


insert into TIEN_NGHI_LOAI_PHONG (MA_TIEN_NGHI, MA_LOAI_PHONG) values (3, 1)
go


insert into TIEN_NGHI_LOAI_PHONG (MA_TIEN_NGHI, MA_LOAI_PHONG) values (4, 1)
go


insert into TIEN_NGHI_LOAI_PHONG (MA_TIEN_NGHI, MA_LOAI_PHONG) values (5, 1)
go


insert into TIEN_NGHI_LOAI_PHONG (MA_TIEN_NGHI, MA_LOAI_PHONG) values (6, 2)
go


insert into TIEN_NGHI_LOAI_PHONG (MA_TIEN_NGHI, MA_LOAI_PHONG) values (7, 2)
go


insert into TIEN_NGHI_LOAI_PHONG (MA_TIEN_NGHI, MA_LOAI_PHONG) values (8, 2)
go


insert into TIEN_NGHI_LOAI_PHONG (MA_TIEN_NGHI, MA_LOAI_PHONG) values (9, 3)
go


insert into TIEN_NGHI_LOAI_PHONG (MA_TIEN_NGHI, MA_LOAI_PHONG) values (10, 3)
go


insert into TIEN_NGHI_LOAI_PHONG (MA_TIEN_NGHI, MA_LOAI_PHONG) values (11, 3)
go


insert into TIEN_NGHI_LOAI_PHONG (MA_TIEN_NGHI, MA_LOAI_PHONG) values (12, 4)
go


insert into TIEN_NGHI_LOAI_PHONG (MA_TIEN_NGHI, MA_LOAI_PHONG) values (13, 4)
go


insert into TIEN_NGHI_LOAI_PHONG (MA_TIEN_NGHI, MA_LOAI_PHONG) values (14, 5)
go


insert into TIEN_NGHI_LOAI_PHONG (MA_TIEN_NGHI, MA_LOAI_PHONG) values (15, 5)
go


insert into TIEN_NGHI_LOAI_PHONG (MA_TIEN_NGHI, MA_LOAI_PHONG) values (16, 5)
go


insert into TIEN_NGHI_LOAI_PHONG (MA_TIEN_NGHI, MA_LOAI_PHONG) values (17, 5)
go


insert into TIEN_NGHI_LOAI_PHONG (MA_TIEN_NGHI, MA_LOAI_PHONG) values (18, 5)
go


insert into TIEN_NGHI_LOAI_PHONG (MA_TIEN_NGHI, MA_LOAI_PHONG) values (19, 5)
go


insert into TIEN_NGHI_LOAI_PHONG (MA_TIEN_NGHI, MA_LOAI_PHONG) values (20, 5)
go

insert into ROLES (ROLE_NAME, DETAILS) values (N'Quản trị ứng dụng', N'Quản trị ứng dụng có toàn quyền có toàn quyền trên các module')
go


insert into ROLES (ROLE_NAME, DETAILS) values (N'Cán bộ phòng kế hoạch và thị trường', N'Cán bộ được quyền in báo cáo để báo cáo lên cấp trên')
go


insert into ROLES (ROLE_NAME, DETAILS) values (N'Quản trị người dùng', N'Quản trị người dùng có quyền thêm bớt người dùng')
go


insert into ROLES (ROLE_NAME, DETAILS) values (N'Tổng giám đốc', N'Tổng giám đốc điều hành khách sạn có toàn quyền trên các module')
go


insert into ROLES (ROLE_NAME, DETAILS) values (N'Lễ tân', N'Lễ tân nhận đặt phòng')
go


insert into ROLES (ROLE_NAME, DETAILS) values (N'Thu ngân', N'Thu ngân thanh toán tiền phòng và tiền dịch vụ')
go


insert into ROLES (ROLE_NAME, DETAILS) values (N'Bộ phận dịch vụ', N'Bộ phận dịch vụ phòng quản lý phòng và cung cấp dịch vụ trong phòng')
go


-- warning: deleting "admin" is not allowed
-- tuyệt đối không được xóa admin, xóa là không log vào dc
insert into USERS (USER_NAME, USER_PASSWORD, FIRST_NAME, LAST_NAME, IS_ADMIN, ADDRESS_STREET, PHONE, EMAIL, DETAILS, DELETED) values ('admin', '33354741122871651676713774147412831195', N'admin', N'admin', 1, N'admin house', '1234567890', 'admin@yahoo.com', N'NO DELETE', 0)
go

insert into USERS (USER_NAME, USER_PASSWORD, FIRST_NAME, LAST_NAME, IS_ADMIN, ADDRESS_STREET, PHONE, EMAIL, DETAILS, DELETED) values ('emerald214', '1292201552198220877194054219216496220885', N'Hiếu', N'Nguyễn Đức', 1, N'A8 Cống Quỳnh', '090538497234', 'hieuvui214@yahoo.com', N'Hiếu thông minh', 0)
go

insert into USERS (USER_NAME, USER_PASSWORD, FIRST_NAME, LAST_NAME, IS_ADMIN, ADDRESS_STREET, PHONE, EMAIL, DETAILS, DELETED) values ('genzer', '1292201552198220877194054219216496220885', N'Hậu', N'Trần Phúc Hậu', 0, N'Biên Hòa', '0909343432', 'how2kizz@yahoo.com', N'Hậu', 0)
go

insert into USERS (USER_NAME, USER_PASSWORD, FIRST_NAME, LAST_NAME, IS_ADMIN, ADDRESS_STREET, PHONE, EMAIL, DETAILS, DELETED) values ('cddthdcondon', '1292201552198220877194054219216496220885', N'Hiếu', N'Đinh Hoàng Dâng', 0, N'Nguyễn Văn Đậu', '12043748932', 'cddthdcodon@yahoo.com', N'Dâng', 0)
go

insert into USERS (USER_NAME, USER_PASSWORD, FIRST_NAME, LAST_NAME, IS_ADMIN, ADDRESS_STREET, PHONE, EMAIL, DETAILS, DELETED) values ('cuop', '1292201552198220877194054219216496220885', N'Vũ', N'Hoàng Vũ Thanh Vũ', 0, N'Lê Quang Định', '090237489347', 'cuop@yahoo.com', N'Vũ', 0)
go

insert into USERS (USER_NAME, USER_PASSWORD, FIRST_NAME, LAST_NAME, IS_ADMIN, ADDRESS_STREET, PHONE, EMAIL, DETAILS, DELETED) values ('byunghun', '1292201552198220877194054219216496220885', N'Byung Hun', N'Lee ', 0, N'Hàn Quốc', '0904324343', 'byunghun@gmail.com', N'IRIS', 0)
go

insert into USERS (USER_NAME, USER_PASSWORD, FIRST_NAME, LAST_NAME, IS_ADMIN, ADDRESS_STREET, PHONE, EMAIL, DETAILS, DELETED) values ('taehee', '1292201552198220877194054219216496220885', N'Tae Hee', N'Kim', 0, N'Hàn Quốc', '849348934', 'taehee@gmail.com', N'IRIS', 0)
go

insert into USERS (USER_NAME, USER_PASSWORD, FIRST_NAME, LAST_NAME, IS_ADMIN, ADDRESS_STREET, PHONE, EMAIL, DETAILS, DELETED) values ('sangmi', '1292201552198220877194054219216496220885', N'Sang Mi', N'Nam', 0, N'Hàn Quốc', '68567645', 'sangmi@yahoo.com', N'Nữ hoàng phim kinh dị', 0)
go

insert into USERS (USER_NAME, USER_PASSWORD, FIRST_NAME, LAST_NAME, IS_ADMIN, ADDRESS_STREET, PHONE, EMAIL, DETAILS, DELETED) values ('gain', '1292201552198220877194054219216496220885', N'Ga In', N'Han', 0, N'Hàn Quốc', '324324354', 'gain@gmail.com', N'Đóng Lối sống sai lầm + Bad Guy', 0)
go

insert into USERS (USER_NAME, USER_PASSWORD, FIRST_NAME, LAST_NAME, IS_ADMIN, ADDRESS_STREET, PHONE, EMAIL, DETAILS, DELETED) values ('chaeyeon', '1292201552198220877194054219216496220885', N'Chae Yeon', N'Han', 0, N'Hàn Quốc', '987967546', 'chaeyeon@gmail.com', N'Ca sĩ', 0)
go

insert into USERS (USER_NAME, USER_PASSWORD, FIRST_NAME, LAST_NAME, IS_ADMIN, ADDRESS_STREET, PHONE, EMAIL, DETAILS, DELETED) values ('gyuri', '1292201552198220877194054219216496220885', N'Gyu Ri', N'Nam', 0, N'Hàn Quốc', '0903545456', 'gyuri@gmail.com', N'Ca sĩ nhóm SeeYa', 0)
go

insert into USERS (USER_NAME, USER_PASSWORD, FIRST_NAME, LAST_NAME, IS_ADMIN, ADDRESS_STREET, PHONE, EMAIL, DETAILS, DELETED) values ('sooyoung', '1292201552198220877194054219216496220885', N'Soo Young', N'Lee', 0, N'Hàn Quốc', '09450405943', 'sooyoung@gmail.com', N'Nữ hoàng ballad', 0)
go

insert into USERS (USER_NAME, USER_PASSWORD, FIRST_NAME, LAST_NAME, IS_ADMIN, ADDRESS_STREET, PHONE, EMAIL, DETAILS, DELETED) values ('hyekyo', '1292201552198220877194054219216496220885', N'Hye Kyo', N'Song', 0, N'Hàn Quốc', '32432432', 'hyekyo@gmail.com', N'Diễn viên', 0)
go

insert into USERS (USER_NAME, USER_PASSWORD, FIRST_NAME, LAST_NAME, IS_ADMIN, ADDRESS_STREET, PHONE, EMAIL, DETAILS, DELETED) values ('daehee', '1292201552198220877194054219216496220885', N'Dae Hee', N'Lee', 0, N'Hàn Quốc', '090465765', 'daehee@gmail.com', N'Đóng Chuno', 0)
go

insert into USERS (USER_NAME, USER_PASSWORD, FIRST_NAME, LAST_NAME, IS_ADMIN, ADDRESS_STREET, PHONE, EMAIL, DETAILS, DELETED) values ('soyeon', '1292201552198220877194054219216496220885', N'So Yeon', N'Kim', 0, N'Hàn Quốc', '090932432', 'soyeon@gmail.com', N'Kim Sul Hwa trong IRIS, đóng Procecutor Princess', 0)
go

insert into USERS (USER_NAME, USER_PASSWORD, FIRST_NAME, LAST_NAME, IS_ADMIN, ADDRESS_STREET, PHONE, EMAIL, DETAILS, DELETED) values ('god', '1292201552198220877194054219216496220885', N'god', N'god', 0, N'Vũ trụ', '090932432', 'god@gmail.com', N'Thượng đế, Chúa trời, Phật tổ, Allah', 0)
go

insert into USERS (USER_NAME, USER_PASSWORD, FIRST_NAME, LAST_NAME, IS_ADMIN, ADDRESS_STREET, PHONE, EMAIL, DETAILS, DELETED) values ('wtf', '1292201552198220877194054219216496220885', N'Fuck', N'What the', 0, N'wtf', '090932432', 'wtf@gmail.com', N'wtf!', 0)
go

insert into USERS (USER_NAME, USER_PASSWORD, FIRST_NAME, LAST_NAME, IS_ADMIN, ADDRESS_STREET, PHONE, EMAIL, DETAILS, DELETED) values ('snsd', '1292201552198220877194054219216496220885', N'SNSD', N'Girl generation', 0, N'SM Entertainment', '090932432', 'snsd@gmail.com', N'Gee, Geenie, Run Devil Run là những bài mới nhất', 0)
go


insert into USER2ROLE (USERID, ROLEID) values (1, 1)
go

insert into USER2ROLE (USERID, ROLEID) values (1, 2)
go

insert into USER2ROLE (USERID, ROLEID) values (2, 3)
go

insert into USER2ROLE (USERID, ROLEID) values (2, 5)
go

insert into USER2ROLE (USERID, ROLEID) values (3, 1)
go

insert into USER2ROLE (USERID, ROLEID) values (3, 3)
go

insert into USER2ROLE (USERID, ROLEID) values (4, 1)
go

insert into USER2ROLE (USERID, ROLEID) values (4, 5)
go

insert into USER2ROLE (USERID, ROLEID) values (4, 7)
go

insert into USER2ROLE (USERID, ROLEID) values (5, 2)
go

insert into USER2ROLE (USERID, ROLEID) values (5, 4)
go

insert into USER2ROLE (USERID, ROLEID) values (5, 6)
go

------- khi test quyền cho cô xem thì test từ số 6 (Lee Byung Hun) đến số 11 (Nam Gyu Ri) -----
insert into USER2ROLE (USERID, ROLEID) values (6, 1) -- byunghun - Quản trị ứng dụng
go

insert into USER2ROLE (USERID, ROLEID) values (7, 2) -- taehee - Cán bộ phòng kế hoạch và thị trường
go

insert into USER2ROLE (USERID, ROLEID) values (8, 3) -- sangmi - Quản trị người dùng
go

insert into USER2ROLE (USERID, ROLEID) values (9, 4) -- gain - Tổng giám đốc
go

insert into USER2ROLE (USERID, ROLEID) values (10, 5) -- chaeyeon - Lễ tân
go

insert into USER2ROLE (USERID, ROLEID) values (11, 7) -- gyuri - Bộ phận dịch vụ
go
------------------------------------------------------------------------------------------------

insert into USER2ROLE (USERID, ROLEID) values (12, 6)
go

insert into USER2ROLE (USERID, ROLEID) values (13, 7)
go

insert into USER2ROLE (USERID, ROLEID) values (14, 7)
go

insert into USER2ROLE (USERID, ROLEID) values (15, 1)
go

insert into USER2ROLE (USERID, ROLEID) values (16, 2)
go

insert into USER2ROLE (USERID, ROLEID) values (17, 3)
go

insert into USER2ROLE (USERID, ROLEID) values (17, 7)
go

insert into USER2ROLE (USERID, ROLEID) values (18, 5)
go

insert into USER2ROLE (USERID, ROLEID) values (18, 6)
go

insert into CA_TRUC (USERID, GIO_VAO_CA, GIO_XUONG_CA, DA_KET_TOAN) values (2, '1753-01-01 00:00:00', '1753-01-01 00:00:00', 1)
go


insert into CA_TRUC (USERID, GIO_VAO_CA, GIO_XUONG_CA, DA_KET_TOAN) values (2, '1753-01-01 00:00:00', '1753-01-01 00:00:00', 1)
go


insert into KHACH_HANG (MA_QUOC_GIA, HO_KHACH_HANG, TEN_KHACH_HANG, CMND, HO_CHIEU, DIEN_THOAI) values (19, 'Carlos', 'Alberto', '7385938859', '', '0964364757')
go


insert into KHACH_HANG (MA_QUOC_GIA, HO_KHACH_HANG, TEN_KHACH_HANG, CMND, HO_CHIEU, DIEN_THOAI) values (10, 'Roberto', 'Carlos', '', 'HG-64838594', '0964759375')
go


insert into KHACH_HANG (MA_QUOC_GIA, HO_KHACH_HANG, TEN_KHACH_HANG, CMND, HO_CHIEU, DIEN_THOAI) values (9, 'Djalma', 'Santos', '6385919574', '', '0953759954')
go


insert into KHACH_HANG (MA_QUOC_GIA, HO_KHACH_HANG, TEN_KHACH_HANG, CMND, HO_CHIEU, DIEN_THOAI) values (9, 'Nilton', 'Santos', '', 'JH-73837289', '09552784938')
go


insert into KHACH_HANG (MA_QUOC_GIA, HO_KHACH_HANG, TEN_KHACH_HANG, CMND, HO_CHIEU, DIEN_THOAI) values (4, 'Gabriel', 'Batistuta', '', 'HH-7283028493', '0927984930')
go


insert into KHACH_HANG (MA_QUOC_GIA, HO_KHACH_HANG, TEN_KHACH_HANG, CMND, HO_CHIEU, DIEN_THOAI) values (4, 'Hernan', 'Crespo', '', 'HJ-73859876', '0943678964')
go


insert into KHACH_HANG (MA_QUOC_GIA, HO_KHACH_HANG, TEN_KHACH_HANG, CMND, HO_CHIEU, DIEN_THOAI) values (11, 'Diego', 'Maradona', '7465754824', '', '0923456971')
go


insert into KHACH_HANG (MA_QUOC_GIA, HO_KHACH_HANG, TEN_KHACH_HANG, CMND, HO_CHIEU, DIEN_THOAI) values (11, 'David', 'Beckham', '7365873658', '', '0948647983')
go


insert into KHACH_HANG (MA_QUOC_GIA, HO_KHACH_HANG, TEN_KHACH_HANG, CMND, HO_CHIEU, DIEN_THOAI) values (4, 'Michael', 'Owen', '6395905830', '', '0935758632')
go


insert into KHACH_HANG (MA_QUOC_GIA, HO_KHACH_HANG, TEN_KHACH_HANG, CMND, HO_CHIEU, DIEN_THOAI) values (5, 'Thierry', 'Henry', '7395854547', '', '0917489763')
go


insert into KHACH_HANG (MA_QUOC_GIA, HO_KHACH_HANG, TEN_KHACH_HANG, CMND, HO_CHIEU, DIEN_THOAI) values (19, 'David', 'Trezeguet', '', 'BG-63789053', '0964876432')
go


insert into KHACH_HANG (MA_QUOC_GIA, HO_KHACH_HANG, TEN_KHACH_HANG, CMND, HO_CHIEU, DIEN_THOAI) values (8, 'Michael', 'Ballack', '7485738593', '', '0935756398')
go


insert into KHACH_HANG (MA_QUOC_GIA, HO_KHACH_HANG, TEN_KHACH_HANG, CMND, HO_CHIEU, DIEN_THOAI) values (3, 'Abedi', 'Pele', '73648690', '', '0952774890')
go


insert into KHACH_HANG (MA_QUOC_GIA, HO_KHACH_HANG, TEN_KHACH_HANG, CMND, HO_CHIEU, DIEN_THOAI) values (12, 'Roberto', 'Baggio', '63874858', '', '0978237654')
go


insert into KHACH_HANG (MA_QUOC_GIA, HO_KHACH_HANG, TEN_KHACH_HANG, CMND, HO_CHIEU, DIEN_THOAI) values (17, 'Alessandro', 'Del Piero', '', 'HD-73840986', '0916875984')
go


insert into KHACH_HANG (MA_QUOC_GIA, HO_KHACH_HANG, TEN_KHACH_HANG, CMND, HO_CHIEU, DIEN_THOAI) values (15, 'Francesco', 'Totti', '', 'YH-62734983', '0953747398')
go


insert into KHACH_HANG (MA_QUOC_GIA, HO_KHACH_HANG, TEN_KHACH_HANG, CMND, HO_CHIEU, DIEN_THOAI) values (18, 'Luis', 'Figo', '6385712875', '', '0967354875')
go


insert into KHACH_HANG (MA_QUOC_GIA, HO_KHACH_HANG, TEN_KHACH_HANG, CMND, HO_CHIEU, DIEN_THOAI) values (6, 'Michel', 'Platini', '7384963859', '', '0912657894')
go


insert into KHACH_HANG (MA_QUOC_GIA, HO_KHACH_HANG, TEN_KHACH_HANG, CMND, HO_CHIEU, DIEN_THOAI) values (14, 'Marius', 'Tresor', '7865309876', '', '0974647363')
go


insert into KHACH_HANG (MA_QUOC_GIA, HO_KHACH_HANG, TEN_KHACH_HANG, CMND, HO_CHIEU, DIEN_THOAI) values (15, ' Hawker', 'Genzer', '', 'UH-73828765 ', '0908756431')
go

insert into KHACH_HANG (MA_QUOC_GIA, HO_KHACH_HANG, TEN_KHACH_HANG, CMND, HO_CHIEU, DIEN_THOAI) values (15, 'Kenichi', 'Zidane', '', 'UH-73828765 ', '0908756431')
go

insert into KHACH_HANG (MA_QUOC_GIA, HO_KHACH_HANG, TEN_KHACH_HANG, CMND, HO_CHIEU, DIEN_THOAI) values (15, 'Mamadurk', 'Zidane', '', 'UH-73828765 ', '0908756431')
go

insert into KHACH_HANG (MA_QUOC_GIA, HO_KHACH_HANG, TEN_KHACH_HANG, CMND, HO_CHIEU, DIEN_THOAI) values (15, 'Lucas', 'Zidane', '', 'UH-73828765 ', '0908756431')
go

insert into KHACH_HANG (MA_QUOC_GIA, HO_KHACH_HANG, TEN_KHACH_HANG, CMND, HO_CHIEU, DIEN_THOAI) values (15, 'Satan', 'Zidane', '', 'UH-73828765 ', '0908756431')
go

insert into KHACH_HANG (MA_QUOC_GIA, HO_KHACH_HANG, TEN_KHACH_HANG, CMND, HO_CHIEU, DIEN_THOAI) values (15, 'Gras', 'Zidane', '', 'UH-73828765 ', '0908756431')
go

insert into KHACH_HANG (MA_QUOC_GIA, HO_KHACH_HANG, TEN_KHACH_HANG, CMND, HO_CHIEU, DIEN_THOAI) values (15, 'Muta', 'Lasspr', '', 'UH-73828765 ', '0908756431')
go

insert into KHACH_HANG (MA_QUOC_GIA, HO_KHACH_HANG, TEN_KHACH_HANG, CMND, HO_CHIEU, DIEN_THOAI) values (15, 'Pucca', 'Poo', '', 'UH-73828765 ', '0908756431')
go

insert into KHACH_HANG (MA_QUOC_GIA, HO_KHACH_HANG, TEN_KHACH_HANG, CMND, HO_CHIEU, DIEN_THOAI) values (15, 'Garu', 'Ninja', '', 'UH-73828765 ', '0908756431')
go

insert into KHACH_HANG (MA_QUOC_GIA, HO_KHACH_HANG, TEN_KHACH_HANG, CMND, HO_CHIEU, DIEN_THOAI) values (15, 'Lotus', 'Kelly', '', 'UH-73828765 ', '0908756431')
go

insert into KHACH_HANG (MA_QUOC_GIA, HO_KHACH_HANG, TEN_KHACH_HANG, CMND, HO_CHIEU, DIEN_THOAI) values (15, 'Conan', 'Doyle', '', 'UH-73828765 ', '0908756431')
go

insert into KHACH_HANG (MA_QUOC_GIA, HO_KHACH_HANG, TEN_KHACH_HANG, CMND, HO_CHIEU, DIEN_THOAI) values (15, 'Fixit', 'Test it', '', 'UH-73828765 ', '0908756431')
go

insert into KHACH_HANG (MA_QUOC_GIA, HO_KHACH_HANG, TEN_KHACH_HANG, CMND, HO_CHIEU, DIEN_THOAI) values (15, 'Moveup', 'Movedown', '', 'UH-73828765 ', '0908756431')
go

insert into KHACH_HANG (MA_QUOC_GIA, HO_KHACH_HANG, TEN_KHACH_HANG, CMND, HO_CHIEU, DIEN_THOAI) values (15, 'Manga', 'Kane', '', 'UH-73828765 ', '0908756431')
go

insert into KHACH_HANG (MA_QUOC_GIA, HO_KHACH_HANG, TEN_KHACH_HANG, CMND, HO_CHIEU, DIEN_THOAI) values (15, 'Cena', 'John', '', 'UH-73828765 ', '0908756431')
go

insert into KHACH_HANG (MA_QUOC_GIA, HO_KHACH_HANG, TEN_KHACH_HANG, CMND, HO_CHIEU, DIEN_THOAI) values (15, 'Jericho', 'Chris', '', 'UH-73828765 ', '0908756431')
go

insert into KHACH_HANG (MA_QUOC_GIA, HO_KHACH_HANG, TEN_KHACH_HANG, CMND, HO_CHIEU, DIEN_THOAI) values (15, 'Maser', 'Maria', '', 'UH-73828765 ', '0908756431')
go

insert into KHACH_HANG (MA_QUOC_GIA, HO_KHACH_HANG, TEN_KHACH_HANG, CMND, HO_CHIEU, DIEN_THOAI) values (15, 'Kozvov', 'Rahata', '', 'UH-73828765 ', '0908756431')
go

insert into KHACH_HANG (MA_QUOC_GIA, HO_KHACH_HANG, TEN_KHACH_HANG, CMND, HO_CHIEU, DIEN_THOAI) values (15, 'Sunbut', 'Koiucho', '', 'UH-73828765 ', '0908756431')
go

insert into KHACH_HANG (MA_QUOC_GIA, HO_KHACH_HANG, TEN_KHACH_HANG, CMND, HO_CHIEU, DIEN_THOAI) values (15, 'Lala', 'Lili', '', 'UH-73828765 ', '0908756431')
go

insert into KHACH_HANG (MA_QUOC_GIA, HO_KHACH_HANG, TEN_KHACH_HANG, CMND, HO_CHIEU, DIEN_THOAI) values (15, 'Odan', 'Yahos', '', 'UH-73828765 ', '0908756431')
go

insert into KHACH_HANG (MA_QUOC_GIA, HO_KHACH_HANG, TEN_KHACH_HANG, CMND, HO_CHIEU, DIEN_THOAI) values (15, 'Soved', 'Luna', '', 'UH-73828765 ', '0908756431')
go

insert into KHACH_HANG (MA_QUOC_GIA, HO_KHACH_HANG, TEN_KHACH_HANG, CMND, HO_CHIEU, DIEN_THOAI) values (15, 'King', 'Lary', '', 'UH-73828765 ', '0908756431')
go

insert into KHACH_HANG (MA_QUOC_GIA, HO_KHACH_HANG, TEN_KHACH_HANG, CMND, HO_CHIEU, DIEN_THOAI) values (15, 'Sophia', 'Did', '', 'UH-73828765 ', '0908756431')
go

insert into KHACH_HANG (MA_QUOC_GIA, HO_KHACH_HANG, TEN_KHACH_HANG, CMND, HO_CHIEU, DIEN_THOAI) values (15, 'Lakas', 'Bobos', '', 'UH-73828765 ', '0908756431')
go

insert into KHACH_HANG (MA_QUOC_GIA, HO_KHACH_HANG, TEN_KHACH_HANG, CMND, HO_CHIEU, DIEN_THOAI) values (15, 'Liyyos', 'Santa', '', 'UH-73828765 ', '0908756431')
go

insert into KHACH_HANG (MA_QUOC_GIA, HO_KHACH_HANG, TEN_KHACH_HANG, CMND, HO_CHIEU, DIEN_THOAI) values (15, 'Claus', 'Stanta', '', 'UH-73828765 ', '0908756431')
go

insert into KHACH_HANG (MA_QUOC_GIA, HO_KHACH_HANG, TEN_KHACH_HANG, CMND, HO_CHIEU, DIEN_THOAI) values (15, 'Thats', 'Thats', '', 'UH-73828765 ', '0908756431')
go

insert into KHACH_HANG (MA_QUOC_GIA, HO_KHACH_HANG, TEN_KHACH_HANG, CMND, HO_CHIEU, DIEN_THOAI) values (15, 'Lucifer', 'Satan', '', 'UH-73828765 ', '0908756431')
go

insert into KHACH_HANG (MA_QUOC_GIA, HO_KHACH_HANG, TEN_KHACH_HANG, CMND, HO_CHIEU, DIEN_THOAI) values (15, 'Common', 'Zidane', '', 'UH-73828765 ', '0908756431')
go

insert into KHACH_HANG (MA_QUOC_GIA, HO_KHACH_HANG, TEN_KHACH_HANG, CMND, HO_CHIEU, DIEN_THOAI) values (15, 'Zuzu', 'Kanes', '', 'UH-73828765 ', '0908756431')
go

insert into KHACH_HANG (MA_QUOC_GIA, HO_KHACH_HANG, TEN_KHACH_HANG, CMND, HO_CHIEU, DIEN_THOAI) values (15, 'Undertaker', 'The', '', 'UH-73828765 ', '0908756431')
go

insert into KHACH_HANG (MA_QUOC_GIA, HO_KHACH_HANG, TEN_KHACH_HANG, CMND, HO_CHIEU, DIEN_THOAI) values (15, 'Morrison', 'John', '', 'UH-73828765 ', '0908756431')
go

insert into KHACH_HANG (MA_QUOC_GIA, HO_KHACH_HANG, TEN_KHACH_HANG, CMND, HO_CHIEU, DIEN_THOAI) values (15, 'Micheal', 'Shawns', '', 'UH-73828765 ', '0908756431')
go

insert into KHACH_HANG (MA_QUOC_GIA, HO_KHACH_HANG, TEN_KHACH_HANG, CMND, HO_CHIEU, DIEN_THOAI) values (15, 'H', 'Triple', '', 'UH-73828765 ', '0908756431')
go

insert into KHACH_HANG (MA_QUOC_GIA, HO_KHACH_HANG, TEN_KHACH_HANG, CMND, HO_CHIEU, DIEN_THOAI) values (15, 'R', 'Truth', '', 'UH-73828765 ', '0908756431')
go

insert into KHACH_HANG (MA_QUOC_GIA, HO_KHACH_HANG, TEN_KHACH_HANG, CMND, HO_CHIEU, DIEN_THOAI) values (15, 'Bourne', 'Even', '', 'UH-73828765 ', '0908756431')
go

insert into KHACH_HANG (MA_QUOC_GIA, HO_KHACH_HANG, TEN_KHACH_HANG, CMND, HO_CHIEU, DIEN_THOAI) values (15, 'Kelly', 'Kelly', '', 'UH-73828765 ', '0908756431')
go

insert into KHACH_HANG (MA_QUOC_GIA, HO_KHACH_HANG, TEN_KHACH_HANG, CMND, HO_CHIEU, DIEN_THOAI) values (15, 'dogg', 'Snoop', '', 'UH-73828765 ', '0908756431')
go

insert into KHACH_HANG (MA_QUOC_GIA, HO_KHACH_HANG, TEN_KHACH_HANG, CMND, HO_CHIEU, DIEN_THOAI) values (15, 'Diddy', 'Puff', '', 'UH-73828765 ', '0908756431')
go

insert into KHACH_HANG (MA_QUOC_GIA, HO_KHACH_HANG, TEN_KHACH_HANG, CMND, HO_CHIEU, DIEN_THOAI) values (15, 'Gomez', 'Salina', '', 'UH-73828765 ', '0908756431')
go

insert into KHACH_HANG (MA_QUOC_GIA, HO_KHACH_HANG, TEN_KHACH_HANG, CMND, HO_CHIEU, DIEN_THOAI) values (15, 'Montana', 'Hannah', '', 'UH-73828765 ', '0908756431')
go

insert into KHACH_HANG (MA_QUOC_GIA, HO_KHACH_HANG, TEN_KHACH_HANG, CMND, HO_CHIEU, DIEN_THOAI) values (15, 'Suite', 'Zack', '', 'UH-73828765 ', '0908756431')
go

insert into KHACH_HANG (MA_QUOC_GIA, HO_KHACH_HANG, TEN_KHACH_HANG, CMND, HO_CHIEU, DIEN_THOAI) values (15, 'suite', 'Cody', '', 'UH-73828765 ', '0908756431')
go

insert into KHACH_HANG (MA_QUOC_GIA, HO_KHACH_HANG, TEN_KHACH_HANG, CMND, HO_CHIEU, DIEN_THOAI) values (15, 'Song', 'Wendy', '', 'UH-73828765 ', '0908756431')
go

insert into KHACH_HANG (MA_QUOC_GIA, HO_KHACH_HANG, TEN_KHACH_HANG, CMND, HO_CHIEU, DIEN_THOAI) values (15, 'Kenedy', 'John', '', 'UH-73828765 ', '0908756431')
go

insert into KHACH_HANG (MA_QUOC_GIA, HO_KHACH_HANG, TEN_KHACH_HANG, CMND, HO_CHIEU, DIEN_THOAI) values (15, 'Shark', 'G', '', 'UH-73828765 ', '0908756431')
go

insert into KHACH_HANG (MA_QUOC_GIA, HO_KHACH_HANG, TEN_KHACH_HANG, CMND, HO_CHIEU, DIEN_THOAI) values (15, 'Nokia', 'Ngage', '', 'UH-73828765 ', '0908756431')
go

insert into KHACH_HANG (MA_QUOC_GIA, HO_KHACH_HANG, TEN_KHACH_HANG, CMND, HO_CHIEU, DIEN_THOAI) values (15, 'Myterio', 'Rey', '', 'UH-73828765 ', '0908756431')
go

insert into KHACH_HANG (MA_QUOC_GIA, HO_KHACH_HANG, TEN_KHACH_HANG, CMND, HO_CHIEU, DIEN_THOAI) values (15, 'Dida', 'Maclus', '', 'UH-73828765 ', '0908756431')
go

insert into KHACH_HANG (MA_QUOC_GIA, HO_KHACH_HANG, TEN_KHACH_HANG, CMND, HO_CHIEU, DIEN_THOAI) values (15, 'Naus', 'Shown', '', 'UH-73828765 ', '0908756431')
go

insert into KHACH_HANG (MA_QUOC_GIA, HO_KHACH_HANG, TEN_KHACH_HANG, CMND, HO_CHIEU, DIEN_THOAI) values (15, 'Yankee', 'Daddy', '', 'UH-73828765 ', '0908756431')
go

insert into CONG_TY (TEN_CONG_TY, MA_QUOC_GIA, MA_NGUOI_DAI_DIEN, DIA_CHI, DIEN_THOAI, EMAIL, FAX, SO_TAI_KHOAN, MA_SO_THUE) values (N'Tường An', 4, 8, N'116 Đinh Tiên Hoàng', '0976647264', 'ta@gmail.com', '87-8397-4635', 'GH-2738', '85-7289')
go


insert into CONG_TY (TEN_CONG_TY, MA_QUOC_GIA, MA_NGUOI_DAI_DIEN, DIA_CHI, DIEN_THOAI, EMAIL, FAX, SO_TAI_KHOAN, MA_SO_THUE) values (N'Anh và em', 12, 16, N'12 Cách Mạng Tháng Tám', '0965897643', 'a&e@gmail.com', '76-8745-1234', 'HJ-7393', '23-9857')
go


insert into CONG_TY (TEN_CONG_TY, MA_QUOC_GIA, MA_NGUOI_DAI_DIEN, DIA_CHI, DIEN_THOAI, EMAIL, FAX, SO_TAI_KHOAN, MA_SO_THUE) values (N'Cháu yêu ông', 10, 9, N'11 Mai Thị Lựu', '0976345987', 'co@yahoo.com', '56-9087-1234', 'KJ-9012', '23-9087')
go


insert into CONG_TY (TEN_CONG_TY, MA_QUOC_GIA, MA_NGUOI_DAI_DIEN, DIA_CHI, DIEN_THOAI, EMAIL, FAX, SO_TAI_KHOAN, MA_SO_THUE) values (N'Unilever', 13, 19, N'67 Võ Văn Tần', '0945876234', 'unilever@hello.com', '12-3456-9583', 'UI-6483', '12-8956')
go


insert into CONG_TY (TEN_CONG_TY, MA_QUOC_GIA, MA_NGUOI_DAI_DIEN, DIA_CHI, DIEN_THOAI, EMAIL, FAX, SO_TAI_KHOAN, MA_SO_THUE) values (N'Cocacola', 17, 4, N'874 Bạch Đằng', '0945789635', 'coca@coca.com', '12-5678-4859', 'KL-1234', '34-8745')
go


insert into CONG_TY (TEN_CONG_TY, MA_QUOC_GIA, MA_NGUOI_DAI_DIEN, DIA_CHI, DIEN_THOAI, EMAIL, FAX, SO_TAI_KHOAN, MA_SO_THUE) values (N'FPT', 7, 6, N'67 Phan Xích Long', '09384894834', 'fpt@yahoo.com.vn', '57-8745-3859', 'RT-7383', '34-9820')
go


insert into CONG_TY (TEN_CONG_TY, MA_QUOC_GIA, MA_NGUOI_DAI_DIEN, DIA_CHI, DIEN_THOAI, EMAIL, FAX, SO_TAI_KHOAN, MA_SO_THUE) values (N'Viettel', 2, 19, N'23 Trần Cao Vân', '0973488334', 'viettel@hotmail.com', '87-5693-9684', 'GT-8398', '23-7489')
go


insert into CONG_TY (TEN_CONG_TY, MA_QUOC_GIA, MA_NGUOI_DAI_DIEN, DIA_CHI, DIEN_THOAI, EMAIL, FAX, SO_TAI_KHOAN, MA_SO_THUE) values (N'DKM', 12, 1, N'45 Nguyễn Đình Chiểu', '0956284937', 'dkm@hotmail.com', '34-8694-0986', 'KD-7493', '56-9832')
go


insert into CONG_TY (TEN_CONG_TY, MA_QUOC_GIA, MA_NGUOI_DAI_DIEN, DIA_CHI, DIEN_THOAI, EMAIL, FAX, SO_TAI_KHOAN, MA_SO_THUE) values (N'Pepsi', 16, 18, N'57 Nguyễn Tri Phương', '096745873452', 'pepsi@gmail.com', '37-9834-7423', 'JH-7382', '78-6830')
go


insert into CONG_TY (TEN_CONG_TY, MA_QUOC_GIA, MA_NGUOI_DAI_DIEN, DIA_CHI, DIEN_THOAI, EMAIL, FAX, SO_TAI_KHOAN, MA_SO_THUE) values (N'Lô Hội', 18, 10, N'90 Phan Chu Trinh', '0956128764', 'lohoi@gmail.com', '56-8939-9484', 'KU-9274', '12-8549')
go


insert into CONG_TY (TEN_CONG_TY, MA_QUOC_GIA, MA_NGUOI_DAI_DIEN, DIA_CHI, DIEN_THOAI, EMAIL, FAX, SO_TAI_KHOAN, MA_SO_THUE) values (N'Vinamilk', 4, 1, N'23 Thanh Đa', '0974628738', 'vinamilk@gmail.com', '89-3467-9854', 'KD-7629', '98-6372')
go


insert into CONG_TY (TEN_CONG_TY, MA_QUOC_GIA, MA_NGUOI_DAI_DIEN, DIA_CHI, DIEN_THOAI, EMAIL, FAX, SO_TAI_KHOAN, MA_SO_THUE) values (N'CLGT', 5, 15, N'24 Nguyễn Chí Thanh', '0945786281', 'ldhs@hotmail.com', '34-7483-9844', 'KI-7233', '98-0273')
go


insert into CONG_TY (TEN_CONG_TY, MA_QUOC_GIA, MA_NGUOI_DAI_DIEN, DIA_CHI, DIEN_THOAI, EMAIL, FAX, SO_TAI_KHOAN, MA_SO_THUE) values (N'Vinamilk', 19, 5, N'67 Hai Bà Trưng', '0936874982', 'hdi@yahoo.com', '34-9544-8373', 'KW-8930', '72-8843')
go


insert into CONG_TY (TEN_CONG_TY, MA_QUOC_GIA, MA_NGUOI_DAI_DIEN, DIA_CHI, DIEN_THOAI, EMAIL, FAX, SO_TAI_KHOAN, MA_SO_THUE) values (N'Tuyệt cú mèo', 16, 13, N'23 Phan Văn Trị', '09237549735', 'hdc@yahoo.com', '72-8472-9578', 'UO-7284', '12-7485')
go


insert into CONG_TY (TEN_CONG_TY, MA_QUOC_GIA, MA_NGUOI_DAI_DIEN, DIA_CHI, DIEN_THOAI, EMAIL, FAX, SO_TAI_KHOAN, MA_SO_THUE) values (N'Ponds', 14, 18, N'89 Nguyễn Văn Linh', '0973837028', 'dsc@hotmail.com', '23-6794-9483', 'RT-7638 ', '89-6828')
go


insert into CONG_TY (TEN_CONG_TY, MA_QUOC_GIA, MA_NGUOI_DAI_DIEN, DIA_CHI, DIEN_THOAI, EMAIL, FAX, SO_TAI_KHOAN, MA_SO_THUE) values (N'Gấu đỏ', 12, 3, N'67 Võ Thị Sáu', '0963567972', 'wsxu@hotmail.com', '34-9384-9840', 'JK-8293', '23-4859')
go


insert into CONG_TY (TEN_CONG_TY, MA_QUOC_GIA, MA_NGUOI_DAI_DIEN, DIA_CHI, DIEN_THOAI, EMAIL, FAX, SO_TAI_KHOAN, MA_SO_THUE) values (N'Gấu xanh', 14, 9, N'73 3 tháng 2', '0963783973', 'cdcz@ymail.com', '23-8584-9384', 'KI-8738', '23-8483')
go


insert into CONG_TY (TEN_CONG_TY, MA_QUOC_GIA, MA_NGUOI_DAI_DIEN, DIA_CHI, DIEN_THOAI, EMAIL, FAX, SO_TAI_KHOAN, MA_SO_THUE) values (N'Hoàn Long', 1, 2, N'78 Nguyễn Oanh', '0974827944', 'shf@gmail.com', '12-8483-9272', 'YE-8389', '45-8294')
go


insert into CONG_TY (TEN_CONG_TY, MA_QUOC_GIA, MA_NGUOI_DAI_DIEN, DIA_CHI, DIEN_THOAI, EMAIL, FAX, SO_TAI_KHOAN, MA_SO_THUE) values (N'3MCPD', 13, 11, N'75 Phan Thanh Bình', '0963739527', 'usg@gmail.com', '45-8290-6385', 'WE-7393', '89-3749')
go


insert into CONG_TY (TEN_CONG_TY, MA_QUOC_GIA, MA_NGUOI_DAI_DIEN, DIA_CHI, DIEN_THOAI, EMAIL, FAX, SO_TAI_KHOAN, MA_SO_THUE) values (N'Ponds', 11, 9, N'90 Nguyễn Trường Toản', '09673763489', 'hdu@yahoo.com', '63-7832', 'WG-3832', '93-8393')
go


insert into DOAN_KHACH (MA_CONG_TY, NGAY_DEN) values (18, '2007-01-01 09:34:12')
go


insert into DOAN_KHACH (MA_CONG_TY, NGAY_DEN) values (18, '2007-05-14 10:00:12')
go


insert into DOAN_KHACH (MA_CONG_TY, NGAY_DEN) values (11, '2007-08-11 08:43:23')
go


insert into DOAN_KHACH (MA_CONG_TY, NGAY_DEN) values (2, '2007-10-23 00:00:00')
go

insert into DOAN_KHACH (MA_CONG_TY, NGAY_DEN) values (10, '2007-12-12 00:00:00')
go

insert into DOAN_KHACH (MA_CONG_TY, NGAY_DEN) values (2, '2008-06-30 00:00:00')
go

insert into DOAN_KHACH (MA_CONG_TY, NGAY_DEN) values (5, '2008-02-25 00:00:00')
go

insert into DOAN_KHACH (MA_CONG_TY, NGAY_DEN) values (15, '2008-11-21 00:00:00')
go

insert into DOAN_KHACH (MA_CONG_TY, NGAY_DEN) values (9, '2008-03-08 00:00:00')
go

insert into DOAN_KHACH (MA_CONG_TY, NGAY_DEN) values (4, '2008-09-12 00:00:00')
go

insert into DOAN_KHACH (MA_CONG_TY, NGAY_DEN) values (1, '2009-12-23 00:00:00')
go

insert into DOAN_KHACH (MA_CONG_TY, NGAY_DEN) values (3, '2009-01-01 00:00:00')
go

insert into DOAN_KHACH (MA_CONG_TY, NGAY_DEN) values (10, '2009-05-12 00:00:00')
go

insert into DOAN_KHACH (MA_CONG_TY, NGAY_DEN) values (2, '2009-07-26 00:00:00')
go

insert into DOAN_KHACH (MA_CONG_TY, NGAY_DEN) values (11, '2009-10-12 00:00:00')
go

insert into DOAN_KHACH (MA_CONG_TY, NGAY_DEN) values (5, '2010-01-23 00:00:00')
go


insert into DOAN_KHACH (MA_CONG_TY, NGAY_DEN) values (2, '2010-03-28 00:00:00')
go

insert into DOAN_KHACH (MA_CONG_TY, NGAY_DEN) values (15, '2010-05-30 00:00:00')
go

insert into DOAN_KHACH (MA_CONG_TY, NGAY_DEN) values (6, '2010-06-10 00:00:00')
go

insert into DOAN_KHACH (MA_CONG_TY, NGAY_DEN) values (14, '2010-04-03 00:00:00')
go


-- Start inserting rows into Phieu_Thue_Phong
-- Year : 2007
-------#id = 1
insert into PHIEU_THUE_PHONG (MA_KHACH_HANG, MA_DOAN_KHACH, MA_PHONG, NGAY_NHAN_PHONG, NGAY_TRA_PHONG, GHI_CHU, THANH_TOAN_TIEN_PHONG, THANH_TOAN_DICH_VU, DA_TRA_PHONG)
values ( 1, null, 1, '2007-01-01', '2007-01-03', null, 1, 1, 1)
go
-------#id = 2
insert into PHIEU_THUE_PHONG ( MA_KHACH_HANG, MA_DOAN_KHACH, MA_PHONG, NGAY_NHAN_PHONG, NGAY_TRA_PHONG, GHI_CHU, THANH_TOAN_TIEN_PHONG, THANH_TOAN_DICH_VU, DA_TRA_PHONG)
values ( 2, null, 2, '2007-01-01', '2007-01-03', null, 1, 1, 1)
go
-------#id = 3
insert into PHIEU_THUE_PHONG ( MA_KHACH_HANG, MA_DOAN_KHACH, MA_PHONG, NGAY_NHAN_PHONG, NGAY_TRA_PHONG, GHI_CHU, THANH_TOAN_TIEN_PHONG, THANH_TOAN_DICH_VU, DA_TRA_PHONG)
values ( 3, null, 1, '2007-01-31', '2007-02-04', null, 1, 1, 1)
go
-------#id = 4
insert into PHIEU_THUE_PHONG ( MA_KHACH_HANG, MA_DOAN_KHACH, MA_PHONG, NGAY_NHAN_PHONG, NGAY_TRA_PHONG, GHI_CHU, THANH_TOAN_TIEN_PHONG, THANH_TOAN_DICH_VU, DA_TRA_PHONG)
values ( 4, null, 3, '2007-02-01', '2007-02-03', null, 1, 1, 1)
go
----group #1
-------#id = 5
insert into PHIEU_THUE_PHONG ( MA_KHACH_HANG, MA_DOAN_KHACH, MA_PHONG, NGAY_NHAN_PHONG, NGAY_TRA_PHONG, GHI_CHU, THANH_TOAN_TIEN_PHONG, THANH_TOAN_DICH_VU, DA_TRA_PHONG)
values ( 5, 1, 11, '2007-03-01', '2007-03-03', null, 1, 1, 1)
go
-------#id = 6
insert into PHIEU_THUE_PHONG ( MA_KHACH_HANG, MA_DOAN_KHACH, MA_PHONG, NGAY_NHAN_PHONG, NGAY_TRA_PHONG, GHI_CHU, THANH_TOAN_TIEN_PHONG, THANH_TOAN_DICH_VU, DA_TRA_PHONG)
values ( 6, 1, 12, '2007-03-01', '2007-03-03', null, 1, 1, 1)
go
-------#id = 7
insert into PHIEU_THUE_PHONG ( MA_KHACH_HANG, MA_DOAN_KHACH, MA_PHONG, NGAY_NHAN_PHONG, NGAY_TRA_PHONG, GHI_CHU, THANH_TOAN_TIEN_PHONG, THANH_TOAN_DICH_VU, DA_TRA_PHONG)
values ( 7, 1, 14, '2007-03-01', '2007-03-03', null, 1, 1, 1)
go
-------#id = 8
insert into PHIEU_THUE_PHONG ( MA_KHACH_HANG, MA_DOAN_KHACH, MA_PHONG, NGAY_NHAN_PHONG, NGAY_TRA_PHONG, GHI_CHU, THANH_TOAN_TIEN_PHONG, THANH_TOAN_DICH_VU, DA_TRA_PHONG)
values ( 8, 1, 15, '2007-03-01', '2007-03-03', null, 1, 1, 1)
go
----end group #1
-------#id = 9
insert into PHIEU_THUE_PHONG ( MA_KHACH_HANG, MA_DOAN_KHACH, MA_PHONG, NGAY_NHAN_PHONG, NGAY_TRA_PHONG, GHI_CHU, THANH_TOAN_TIEN_PHONG, THANH_TOAN_DICH_VU, DA_TRA_PHONG)
values ( 13, null, 7, '2007-06-25', '2007-06-30', null, 1, 1, 1)
go
-------#id = 10
insert into PHIEU_THUE_PHONG ( MA_KHACH_HANG, MA_DOAN_KHACH, MA_PHONG, NGAY_NHAN_PHONG, NGAY_TRA_PHONG, GHI_CHU, THANH_TOAN_TIEN_PHONG, THANH_TOAN_DICH_VU, DA_TRA_PHONG)
values ( 14, null, 10, '2007-07-05', '2007-08-03', null, 1, 1, 1)
go
-------#id = 11
insert into PHIEU_THUE_PHONG ( MA_KHACH_HANG, MA_DOAN_KHACH, MA_PHONG, NGAY_NHAN_PHONG, NGAY_TRA_PHONG, GHI_CHU, THANH_TOAN_TIEN_PHONG, THANH_TOAN_DICH_VU, DA_TRA_PHONG)
values ( 15, null, 5, '2007-08-01', '2007-08-03', null, 1, 1, 1)
go
-------#id = 12
insert into PHIEU_THUE_PHONG ( MA_KHACH_HANG, MA_DOAN_KHACH, MA_PHONG, NGAY_NHAN_PHONG, NGAY_TRA_PHONG, GHI_CHU, THANH_TOAN_TIEN_PHONG, THANH_TOAN_DICH_VU, DA_TRA_PHONG)
values ( 16, null, 22, '2007-09-21', '2007-10-03', null, 1, 1, 1)
go
----group #2
-------#id = 13
insert into PHIEU_THUE_PHONG ( MA_KHACH_HANG, MA_DOAN_KHACH, MA_PHONG, NGAY_NHAN_PHONG, NGAY_TRA_PHONG, GHI_CHU, THANH_TOAN_TIEN_PHONG, THANH_TOAN_DICH_VU, DA_TRA_PHONG)
values ( 17, 2, 12, '2007-10-01', '2007-10-15', null, 1, 1, 1)
go
-------#id = 14
insert into PHIEU_THUE_PHONG ( MA_KHACH_HANG, MA_DOAN_KHACH, MA_PHONG, NGAY_NHAN_PHONG, NGAY_TRA_PHONG, GHI_CHU, THANH_TOAN_TIEN_PHONG, THANH_TOAN_DICH_VU, DA_TRA_PHONG)
values ( 18, 2, 13, '2007-10-01', '2007-10-15', null, 1, 1, 1)
go
-------#id = 15
insert into PHIEU_THUE_PHONG ( MA_KHACH_HANG, MA_DOAN_KHACH, MA_PHONG, NGAY_NHAN_PHONG, NGAY_TRA_PHONG, GHI_CHU, THANH_TOAN_TIEN_PHONG, THANH_TOAN_DICH_VU, DA_TRA_PHONG)
values ( 19, 2, 14, '2007-10-01', '2007-10-15', null, 1, 1, 1)
go
----end group #2
--end Year : 2007

-- START INSERTING INTO TABLE KHACH_TRO
-- 2007
insert into KHACH_TRO (MA_KHACH_HANG, MA_PHIEU) values (1, 1)
go
 
insert into KHACH_TRO (MA_KHACH_HANG, MA_PHIEU) values (2, 2)
go

insert into KHACH_TRO (MA_KHACH_HANG, MA_PHIEU) values (3, 3)
go

insert into KHACH_TRO (MA_KHACH_HANG, MA_PHIEU) values (4, 4)
go

insert into KHACH_TRO (MA_KHACH_HANG, MA_PHIEU) values (5, 5)
go

insert into KHACH_TRO (MA_KHACH_HANG, MA_PHIEU) values (9, 5)
go

insert into KHACH_TRO (MA_KHACH_HANG, MA_PHIEU) values (6, 6)
go

insert into KHACH_TRO (MA_KHACH_HANG, MA_PHIEU) values (10, 6)
go

insert into KHACH_TRO (MA_KHACH_HANG, MA_PHIEU) values (7, 7)
go

insert into KHACH_TRO (MA_KHACH_HANG, MA_PHIEU) values (11, 7)
go

insert into KHACH_TRO (MA_KHACH_HANG, MA_PHIEU) values (8, 8)
go

insert into KHACH_TRO (MA_KHACH_HANG, MA_PHIEU) values (12, 8)
go

insert into KHACH_TRO (MA_KHACH_HANG, MA_PHIEU) values (13, 9)
go

insert into KHACH_TRO (MA_KHACH_HANG, MA_PHIEU) values (14, 10)
go

insert into KHACH_TRO (MA_KHACH_HANG, MA_PHIEU) values (15, 11)
go

insert into KHACH_TRO (MA_KHACH_HANG, MA_PHIEU) values (16, 12)
go

insert into KHACH_TRO (MA_KHACH_HANG, MA_PHIEU) values (17, 13)
go

insert into KHACH_TRO (MA_KHACH_HANG, MA_PHIEU) values (18, 14)
go

insert into KHACH_TRO (MA_KHACH_HANG, MA_PHIEU) values (19, 15)
go
--end Year 2007

-- Year : 2008
-------#id = 16
insert into PHIEU_THUE_PHONG ( MA_KHACH_HANG, MA_DOAN_KHACH, MA_PHONG, NGAY_NHAN_PHONG, NGAY_TRA_PHONG, GHI_CHU, THANH_TOAN_TIEN_PHONG, THANH_TOAN_DICH_VU, DA_TRA_PHONG)
values ( 20, null, 11, '2008-01-20', '2008-01-23', null, 1, 1, 1)
go
-------#id = 17
insert into PHIEU_THUE_PHONG ( MA_KHACH_HANG, MA_DOAN_KHACH, MA_PHONG, NGAY_NHAN_PHONG, NGAY_TRA_PHONG, GHI_CHU, THANH_TOAN_TIEN_PHONG, THANH_TOAN_DICH_VU, DA_TRA_PHONG)
values ( 23, null, 22, '2008-01-20', '2008-01-24', null, 1, 1, 1)
go
-------#id = 18
insert into PHIEU_THUE_PHONG ( MA_KHACH_HANG, MA_DOAN_KHACH, MA_PHONG, NGAY_NHAN_PHONG, NGAY_TRA_PHONG, GHI_CHU, THANH_TOAN_TIEN_PHONG, THANH_TOAN_DICH_VU, DA_TRA_PHONG)
values ( 24, null, 10, '2008-01-31', '2008-02-04', null, 1, 1, 1)
go
-------#id = 19
insert into PHIEU_THUE_PHONG ( MA_KHACH_HANG, MA_DOAN_KHACH, MA_PHONG, NGAY_NHAN_PHONG, NGAY_TRA_PHONG, GHI_CHU, THANH_TOAN_TIEN_PHONG, THANH_TOAN_DICH_VU, DA_TRA_PHONG)
values ( 25, null, 3, '2008-02-01', '2008-02-03', null, 1, 1, 1)
go
----group #3
-------#id = 20
insert into PHIEU_THUE_PHONG ( MA_KHACH_HANG, MA_DOAN_KHACH, MA_PHONG, NGAY_NHAN_PHONG, NGAY_TRA_PHONG, GHI_CHU, THANH_TOAN_TIEN_PHONG, THANH_TOAN_DICH_VU, DA_TRA_PHONG)
values ( 26, 3, 12, '2008-03-01', '2008-03-03', null, 1, 1, 1)
go
-------#id = 21
insert into PHIEU_THUE_PHONG ( MA_KHACH_HANG, MA_DOAN_KHACH, MA_PHONG, NGAY_NHAN_PHONG, NGAY_TRA_PHONG, GHI_CHU, THANH_TOAN_TIEN_PHONG, THANH_TOAN_DICH_VU, DA_TRA_PHONG)
values ( 27, 3, 12, '2008-03-01', '2008-03-03', null, 1, 1, 1)
go
-------#id = 22
insert into PHIEU_THUE_PHONG ( MA_KHACH_HANG, MA_DOAN_KHACH, MA_PHONG, NGAY_NHAN_PHONG, NGAY_TRA_PHONG, GHI_CHU, THANH_TOAN_TIEN_PHONG, THANH_TOAN_DICH_VU, DA_TRA_PHONG)
values ( 28, 3, 14, '2008-03-01', '2008-03-03', null, 1, 1, 1)
go
-------#id = 23
insert into PHIEU_THUE_PHONG ( MA_KHACH_HANG, MA_DOAN_KHACH, MA_PHONG, NGAY_NHAN_PHONG, NGAY_TRA_PHONG, GHI_CHU, THANH_TOAN_TIEN_PHONG, THANH_TOAN_DICH_VU, DA_TRA_PHONG)
values ( 29, 3, 15, '2008-03-01', '2008-03-03', null, 1, 1, 1)
go
----end group #3
-------#id = 24
insert into PHIEU_THUE_PHONG ( MA_KHACH_HANG, MA_DOAN_KHACH, MA_PHONG, NGAY_NHAN_PHONG, NGAY_TRA_PHONG, GHI_CHU, THANH_TOAN_TIEN_PHONG, THANH_TOAN_DICH_VU, DA_TRA_PHONG)
values ( 30, null, 17, '2008-06-25', '2008-06-30', null, 1, 1, 1)
go
-------#id = 25
insert into PHIEU_THUE_PHONG ( MA_KHACH_HANG, MA_DOAN_KHACH, MA_PHONG, NGAY_NHAN_PHONG, NGAY_TRA_PHONG, GHI_CHU, THANH_TOAN_TIEN_PHONG, THANH_TOAN_DICH_VU, DA_TRA_PHONG)
values ( 24, null, 10, '2008-07-05', '2008-08-03', null, 1, 1, 1)
go
-------#id = 26
insert into PHIEU_THUE_PHONG ( MA_KHACH_HANG, MA_DOAN_KHACH, MA_PHONG, NGAY_NHAN_PHONG, NGAY_TRA_PHONG, GHI_CHU, THANH_TOAN_TIEN_PHONG, THANH_TOAN_DICH_VU, DA_TRA_PHONG)
values ( 31, null, 23, '2008-08-01', '2008-08-03', null, 1, 1, 1)
go
-------#id = 27
insert into PHIEU_THUE_PHONG ( MA_KHACH_HANG, MA_DOAN_KHACH, MA_PHONG, NGAY_NHAN_PHONG, NGAY_TRA_PHONG, GHI_CHU, THANH_TOAN_TIEN_PHONG, THANH_TOAN_DICH_VU, DA_TRA_PHONG)
values ( 32, null, 26, '2008-09-21', '2008-10-03', null, 1, 1, 1)
go
----group #4
-------#id = 28
insert into PHIEU_THUE_PHONG ( MA_KHACH_HANG, MA_DOAN_KHACH, MA_PHONG, NGAY_NHAN_PHONG, NGAY_TRA_PHONG, GHI_CHU, THANH_TOAN_TIEN_PHONG, THANH_TOAN_DICH_VU,DA_TRA_PHONG)
values ( 33, 4, 22, '2008-10-01', '2008-10-15', null, 1, 1, 1)
go
-------#id = 29
insert into PHIEU_THUE_PHONG ( MA_KHACH_HANG, MA_DOAN_KHACH, MA_PHONG, NGAY_NHAN_PHONG, NGAY_TRA_PHONG, GHI_CHU, THANH_TOAN_TIEN_PHONG, THANH_TOAN_DICH_VU,DA_TRA_PHONG)
values ( 34, 4, 23, '2008-10-01', '2008-10-15', null, 1, 1, 1)
go
-------#id = 30
insert into PHIEU_THUE_PHONG ( MA_KHACH_HANG, MA_DOAN_KHACH, MA_PHONG, NGAY_NHAN_PHONG, NGAY_TRA_PHONG, GHI_CHU, THANH_TOAN_TIEN_PHONG, THANH_TOAN_DICH_VU,DA_TRA_PHONG)
values ( 35, 4, 24, '2008-10-01', '2008-10-15', null, 1, 1, 1)
go
----end group #4
--end Year : 2008

--Year 2008
insert into KHACH_TRO (MA_KHACH_HANG, MA_PHIEU) values (20, 16)
go

insert into KHACH_TRO (MA_KHACH_HANG, MA_PHIEU) values (21, 16)
go

insert into KHACH_TRO (MA_KHACH_HANG, MA_PHIEU) values (22, 16)
go

insert into KHACH_TRO (MA_KHACH_HANG, MA_PHIEU) values (23, 17)
go

insert into KHACH_TRO (MA_KHACH_HANG, MA_PHIEU) values (24, 18)
go

insert into KHACH_TRO (MA_KHACH_HANG, MA_PHIEU) values (25, 19)
go

insert into KHACH_TRO (MA_KHACH_HANG, MA_PHIEU) values (26, 20)
go

insert into KHACH_TRO (MA_KHACH_HANG, MA_PHIEU) values (2, 20)
go

insert into KHACH_TRO (MA_KHACH_HANG, MA_PHIEU) values (13, 20)
go

insert into KHACH_TRO (MA_KHACH_HANG, MA_PHIEU) values (27, 21)
go

insert into KHACH_TRO (MA_KHACH_HANG, MA_PHIEU) values (11, 21)
go

insert into KHACH_TRO (MA_KHACH_HANG, MA_PHIEU) values (12, 21)
go

insert into KHACH_TRO (MA_KHACH_HANG, MA_PHIEU) values (28, 22)
go

insert into KHACH_TRO (MA_KHACH_HANG, MA_PHIEU) values (29, 23)
go

insert into KHACH_TRO (MA_KHACH_HANG, MA_PHIEU) values (30, 24)
go

insert into KHACH_TRO (MA_KHACH_HANG, MA_PHIEU) values (24, 25)
go

insert into KHACH_TRO (MA_KHACH_HANG, MA_PHIEU) values (31, 26)
go

insert into KHACH_TRO (MA_KHACH_HANG, MA_PHIEU) values (32, 27)
go

insert into KHACH_TRO (MA_KHACH_HANG, MA_PHIEU) values (33, 28)
go

insert into KHACH_TRO (MA_KHACH_HANG, MA_PHIEU) values (34, 29)
go

insert into KHACH_TRO (MA_KHACH_HANG, MA_PHIEU) values (35, 30)
go

--end Year 2008

--Year 2009
-------#id = 31
insert into PHIEU_THUE_PHONG ( MA_KHACH_HANG, MA_DOAN_KHACH, MA_PHONG, NGAY_NHAN_PHONG, NGAY_TRA_PHONG, GHI_CHU, THANH_TOAN_TIEN_PHONG, THANH_TOAN_DICH_VU, DA_TRA_PHONG)
values ( 36, null, 11, '2009-01-20', '2009-01-23', null, 1, 1, 1)
go
-------#id = 32
insert into PHIEU_THUE_PHONG ( MA_KHACH_HANG, MA_DOAN_KHACH, MA_PHONG, NGAY_NHAN_PHONG, NGAY_TRA_PHONG, GHI_CHU, THANH_TOAN_TIEN_PHONG, THANH_TOAN_DICH_VU, DA_TRA_PHONG)
values ( 38, null, 12, '2009-01-20', '2009-01-24', null, 1, 1, 1)
go
-------#id = 33
insert into PHIEU_THUE_PHONG ( MA_KHACH_HANG, MA_DOAN_KHACH, MA_PHONG, NGAY_NHAN_PHONG, NGAY_TRA_PHONG, GHI_CHU, THANH_TOAN_TIEN_PHONG, THANH_TOAN_DICH_VU, DA_TRA_PHONG)
values ( 39, null, 3, '2009-01-31', '2009-02-04', null, 1, 1, 1)
go
-------#id = 34
insert into PHIEU_THUE_PHONG ( MA_KHACH_HANG, MA_DOAN_KHACH, MA_PHONG, NGAY_NHAN_PHONG, NGAY_TRA_PHONG, GHI_CHU, THANH_TOAN_TIEN_PHONG, THANH_TOAN_DICH_VU, DA_TRA_PHONG)
values ( 40, null, 4, '2009-02-01', '2009-02-03', null, 1, 1, 1)
go
----group #5
-------#id = 35
insert into PHIEU_THUE_PHONG ( MA_KHACH_HANG, MA_DOAN_KHACH, MA_PHONG, NGAY_NHAN_PHONG, NGAY_TRA_PHONG, GHI_CHU, THANH_TOAN_TIEN_PHONG, THANH_TOAN_DICH_VU, DA_TRA_PHONG)
values ( 41, 5, 29, '2009-03-01', '2009-03-03', null, 1, 1, 1)
go
-------#id = 36
insert into PHIEU_THUE_PHONG ( MA_KHACH_HANG, MA_DOAN_KHACH, MA_PHONG, NGAY_NHAN_PHONG, NGAY_TRA_PHONG, GHI_CHU, THANH_TOAN_TIEN_PHONG, THANH_TOAN_DICH_VU, DA_TRA_PHONG)
values ( 42, 5, 30, '2009-03-01', '2009-03-03', null, 1, 1, 1)
-------#id = 37
insert into PHIEU_THUE_PHONG ( MA_KHACH_HANG, MA_DOAN_KHACH, MA_PHONG, NGAY_NHAN_PHONG, NGAY_TRA_PHONG, GHI_CHU, THANH_TOAN_TIEN_PHONG, THANH_TOAN_DICH_VU, DA_TRA_PHONG)
values ( 43, 5, 16, '2009-03-01', '2009-03-03', null, 1, 1, 1)
go
-------#id = 38
insert into PHIEU_THUE_PHONG ( MA_KHACH_HANG, MA_DOAN_KHACH, MA_PHONG, NGAY_NHAN_PHONG, NGAY_TRA_PHONG, GHI_CHU, THANH_TOAN_TIEN_PHONG, THANH_TOAN_DICH_VU, DA_TRA_PHONG)
values ( 44, 5, 18, '2009-03-01', '2009-03-03', null, 1, 1, 1)
go
----end group #5
-------#id = 39
insert into PHIEU_THUE_PHONG ( MA_KHACH_HANG, MA_DOAN_KHACH, MA_PHONG, NGAY_NHAN_PHONG, NGAY_TRA_PHONG, GHI_CHU, THANH_TOAN_TIEN_PHONG, THANH_TOAN_DICH_VU, DA_TRA_PHONG)
values ( 47, null, 17, '2009-06-25', '2009-06-30', null, 1, 1, 1)
go
-------#id = 40
insert into PHIEU_THUE_PHONG ( MA_KHACH_HANG, MA_DOAN_KHACH, MA_PHONG, NGAY_NHAN_PHONG, NGAY_TRA_PHONG, GHI_CHU, THANH_TOAN_TIEN_PHONG, THANH_TOAN_DICH_VU, DA_TRA_PHONG)
values ( 49, null, 10, '2009-07-05', '2009-08-03', null, 1, 1, 1)
go
-------#id = 41
insert into PHIEU_THUE_PHONG ( MA_KHACH_HANG, MA_DOAN_KHACH, MA_PHONG, NGAY_NHAN_PHONG, NGAY_TRA_PHONG, GHI_CHU, THANH_TOAN_TIEN_PHONG, THANH_TOAN_DICH_VU, DA_TRA_PHONG)
values ( 50, null, 1, '2009-08-01', '2009-08-03', null, 1, 1, 1)
go
-------#id = 42
insert into PHIEU_THUE_PHONG ( MA_KHACH_HANG, MA_DOAN_KHACH, MA_PHONG, NGAY_NHAN_PHONG, NGAY_TRA_PHONG, GHI_CHU, THANH_TOAN_TIEN_PHONG, THANH_TOAN_DICH_VU, DA_TRA_PHONG)
values ( 32, null, 26, '2009-09-21', '2009-10-03', null, 1, 1, 1)
go
----group #6
-------#id = 43
insert into PHIEU_THUE_PHONG ( MA_KHACH_HANG, MA_DOAN_KHACH, MA_PHONG, NGAY_NHAN_PHONG, NGAY_TRA_PHONG, GHI_CHU, THANH_TOAN_TIEN_PHONG, THANH_TOAN_DICH_VU,DA_TRA_PHONG)
values ( 51, 6, 22, '2009-10-01', '2009-10-15', null, 1, 1, 1)
go
-------#id = 44
insert into PHIEU_THUE_PHONG ( MA_KHACH_HANG, MA_DOAN_KHACH, MA_PHONG, NGAY_NHAN_PHONG, NGAY_TRA_PHONG, GHI_CHU, THANH_TOAN_TIEN_PHONG, THANH_TOAN_DICH_VU,DA_TRA_PHONG)
values ( 52, 6, 29, '2009-10-01', '2009-10-15', null, 1, 1, 1)
go
-------#id = 45
insert into PHIEU_THUE_PHONG ( MA_KHACH_HANG, MA_DOAN_KHACH, MA_PHONG, NGAY_NHAN_PHONG, NGAY_TRA_PHONG, GHI_CHU, THANH_TOAN_TIEN_PHONG, THANH_TOAN_DICH_VU,DA_TRA_PHONG)
values ( 53, 6, 24, '2009-10-01', '2009-10-15', null, 1, 1, 1)
go
----end group #6
--end Year 2009


--Year 2009
insert into KHACH_TRO (MA_KHACH_HANG, MA_PHIEU) values (36, 31)
go

insert into KHACH_TRO (MA_KHACH_HANG, MA_PHIEU) values (37, 31)
go

insert into KHACH_TRO (MA_KHACH_HANG, MA_PHIEU) values (38, 32)
go

insert into KHACH_TRO (MA_KHACH_HANG, MA_PHIEU) values (39, 33)
go

insert into KHACH_TRO (MA_KHACH_HANG, MA_PHIEU) values (40, 34)
go

insert into KHACH_TRO (MA_KHACH_HANG, MA_PHIEU) values (41, 35)
go

insert into KHACH_TRO (MA_KHACH_HANG, MA_PHIEU) values (45, 35)
go

insert into KHACH_TRO (MA_KHACH_HANG, MA_PHIEU) values (42, 36)
go

insert into KHACH_TRO (MA_KHACH_HANG, MA_PHIEU) values (46, 36)
go

insert into KHACH_TRO (MA_KHACH_HANG, MA_PHIEU) values (43, 37)
go

insert into KHACH_TRO (MA_KHACH_HANG, MA_PHIEU) values (44, 38)
go

insert into KHACH_TRO (MA_KHACH_HANG, MA_PHIEU) values (47, 39)
go

insert into KHACH_TRO (MA_KHACH_HANG, MA_PHIEU) values (48, 39)
go

insert into KHACH_TRO (MA_KHACH_HANG, MA_PHIEU) values (49, 40)
go

insert into KHACH_TRO (MA_KHACH_HANG, MA_PHIEU) values (50, 41)
go

insert into KHACH_TRO (MA_KHACH_HANG, MA_PHIEU) values (32, 42)
go

insert into KHACH_TRO (MA_KHACH_HANG, MA_PHIEU) values (51, 43)
go

insert into KHACH_TRO (MA_KHACH_HANG, MA_PHIEU) values (54, 43)
go

insert into KHACH_TRO (MA_KHACH_HANG, MA_PHIEU) values (55, 43)
go

insert into KHACH_TRO (MA_KHACH_HANG, MA_PHIEU) values (52, 44)
go

insert into KHACH_TRO (MA_KHACH_HANG, MA_PHIEU) values (56, 44)
go

insert into KHACH_TRO (MA_KHACH_HANG, MA_PHIEU) values (53, 45)
go
--end Year 2009

--Year 2010
-------#id = 46
insert into PHIEU_THUE_PHONG ( MA_KHACH_HANG, MA_DOAN_KHACH, MA_PHONG, NGAY_NHAN_PHONG, NGAY_TRA_PHONG, GHI_CHU, THANH_TOAN_TIEN_PHONG, THANH_TOAN_DICH_VU, DA_TRA_PHONG)
values ( 57, null, 11, '2010-01-20', '2010-01-23', null, 1, 1, 1)
go
-------#id = 47
insert into PHIEU_THUE_PHONG ( MA_KHACH_HANG, MA_DOAN_KHACH, MA_PHONG, NGAY_NHAN_PHONG, NGAY_TRA_PHONG, GHI_CHU, THANH_TOAN_TIEN_PHONG, THANH_TOAN_DICH_VU, DA_TRA_PHONG)
values ( 59, null, 12, '2010-01-20', '2010-01-24', null, 1, 1, 1)
go
-------#id = 48
insert into PHIEU_THUE_PHONG ( MA_KHACH_HANG, MA_DOAN_KHACH, MA_PHONG, NGAY_NHAN_PHONG, NGAY_TRA_PHONG, GHI_CHU, THANH_TOAN_TIEN_PHONG, THANH_TOAN_DICH_VU, DA_TRA_PHONG)
values ( 61, null, 3, '2010-01-31', '2010-02-04', null, 1, 1, 1)
go
-------#id = 49
insert into PHIEU_THUE_PHONG ( MA_KHACH_HANG, MA_DOAN_KHACH, MA_PHONG, NGAY_NHAN_PHONG, NGAY_TRA_PHONG, GHI_CHU, THANH_TOAN_TIEN_PHONG, THANH_TOAN_DICH_VU, DA_TRA_PHONG)
values ( 40, null, 4, '2010-02-01', '2010-02-03', null, 1, 1, 1)
go
----group #7
-------#id = 50
insert into PHIEU_THUE_PHONG ( MA_KHACH_HANG, MA_DOAN_KHACH, MA_PHONG, NGAY_NHAN_PHONG, NGAY_TRA_PHONG, GHI_CHU, THANH_TOAN_TIEN_PHONG, THANH_TOAN_DICH_VU, DA_TRA_PHONG)
values ( 61, 7, 5, '2010-05-31', null, null, 0, 0, 0)
go
-------#id = 51
insert into PHIEU_THUE_PHONG ( MA_KHACH_HANG, MA_DOAN_KHACH, MA_PHONG, NGAY_NHAN_PHONG, NGAY_TRA_PHONG, GHI_CHU, THANH_TOAN_TIEN_PHONG, THANH_TOAN_DICH_VU, DA_TRA_PHONG)
values ( 62, 7, 6, '2010-05-31', null, null, 0, 0, 0)
go
-------#id = 52
insert into PHIEU_THUE_PHONG ( MA_KHACH_HANG, MA_DOAN_KHACH, MA_PHONG, NGAY_NHAN_PHONG, NGAY_TRA_PHONG, GHI_CHU, THANH_TOAN_TIEN_PHONG, THANH_TOAN_DICH_VU, DA_TRA_PHONG)
values ( 63, 7, 7, '2010-05-31', null, null, 0, 0, 0)
go
-------#id = 53
insert into PHIEU_THUE_PHONG ( MA_KHACH_HANG, MA_DOAN_KHACH, MA_PHONG, NGAY_NHAN_PHONG, NGAY_TRA_PHONG, GHI_CHU, THANH_TOAN_TIEN_PHONG, THANH_TOAN_DICH_VU, DA_TRA_PHONG)
values ( 64, 7, 8, '2010-05-31', null, null, 0, 0, 0)
go
----end group #7
-------#id = 54
insert into PHIEU_THUE_PHONG ( MA_KHACH_HANG, MA_DOAN_KHACH, MA_PHONG, NGAY_NHAN_PHONG, NGAY_TRA_PHONG, GHI_CHU, THANH_TOAN_TIEN_PHONG, THANH_TOAN_DICH_VU, DA_TRA_PHONG)
values ( 65, null, 17, '2010-06-01', null, null, 0, 0, 0)
go
-------#id = 55
insert into PHIEU_THUE_PHONG ( MA_KHACH_HANG, MA_DOAN_KHACH, MA_PHONG, NGAY_NHAN_PHONG, NGAY_TRA_PHONG, GHI_CHU, THANH_TOAN_TIEN_PHONG, THANH_TOAN_DICH_VU, DA_TRA_PHONG)
values ( 67, null, 15, '2010-06-03', null, null, 0, 0, 0)
go
-------#id = 56
insert into PHIEU_THUE_PHONG ( MA_KHACH_HANG, MA_DOAN_KHACH, MA_PHONG, NGAY_NHAN_PHONG, NGAY_TRA_PHONG, GHI_CHU, THANH_TOAN_TIEN_PHONG, THANH_TOAN_DICH_VU, DA_TRA_PHONG)
values ( 69, null, 12, '2010-06-03', null, null, 0, 0, 0)
go
-------#id = 57
insert into PHIEU_THUE_PHONG ( MA_KHACH_HANG, MA_DOAN_KHACH, MA_PHONG, NGAY_NHAN_PHONG, NGAY_TRA_PHONG, GHI_CHU, THANH_TOAN_TIEN_PHONG, THANH_TOAN_DICH_VU, DA_TRA_PHONG)
values ( 71, null, 26, '2010-06-03', null, null, 0, 0, 0)
go
----group #8
-------#id = 58
insert into PHIEU_THUE_PHONG ( MA_KHACH_HANG, MA_DOAN_KHACH, MA_PHONG, NGAY_NHAN_PHONG, NGAY_TRA_PHONG, GHI_CHU, THANH_TOAN_TIEN_PHONG, THANH_TOAN_DICH_VU,DA_TRA_PHONG)
values ( 51, 8, 22, '2010-06-05', null, null, 0, 0, 0)
go
-------#id = 59
insert into PHIEU_THUE_PHONG ( MA_KHACH_HANG, MA_DOAN_KHACH, MA_PHONG, NGAY_NHAN_PHONG, NGAY_TRA_PHONG, GHI_CHU, THANH_TOAN_TIEN_PHONG, THANH_TOAN_DICH_VU,DA_TRA_PHONG)
values ( 52, 8, 29, '2010-06-05', null, null, 0, 0, 0)
go
-------#id = 60
insert into PHIEU_THUE_PHONG ( MA_KHACH_HANG, MA_DOAN_KHACH, MA_PHONG, NGAY_NHAN_PHONG, NGAY_TRA_PHONG, GHI_CHU, THANH_TOAN_TIEN_PHONG, THANH_TOAN_DICH_VU,DA_TRA_PHONG)
values ( 53, 8, 24, '2010-06-05', null, null, 0, 0, 0)
go
----end group #8
--end Year 2010

--Year 2010
insert into KHACH_TRO (MA_KHACH_HANG, MA_PHIEU) values (57, 46)
go

insert into KHACH_TRO (MA_KHACH_HANG, MA_PHIEU) values (58, 46)
go

insert into KHACH_TRO (MA_KHACH_HANG, MA_PHIEU) values (59, 47)
go

insert into KHACH_TRO (MA_KHACH_HANG, MA_PHIEU) values (60, 47)
go

insert into KHACH_TRO (MA_KHACH_HANG, MA_PHIEU) values (61, 48)
go

insert into KHACH_TRO (MA_KHACH_HANG, MA_PHIEU) values (40, 49)
go

insert into KHACH_TRO (MA_KHACH_HANG, MA_PHIEU) values (61, 50)
go

insert into KHACH_TRO (MA_KHACH_HANG, MA_PHIEU) values (62, 51)
go

insert into KHACH_TRO (MA_KHACH_HANG, MA_PHIEU) values (63, 52)
go

insert into KHACH_TRO (MA_KHACH_HANG, MA_PHIEU) values (64, 53)
go

insert into KHACH_TRO (MA_KHACH_HANG, MA_PHIEU) values (65, 54)
go

insert into KHACH_TRO (MA_KHACH_HANG, MA_PHIEU) values (66, 54)
go

insert into KHACH_TRO (MA_KHACH_HANG, MA_PHIEU) values (67, 55)
go

insert into KHACH_TRO (MA_KHACH_HANG, MA_PHIEU) values (68, 55)
go

insert into KHACH_TRO (MA_KHACH_HANG, MA_PHIEU) values (69, 56)
go

insert into KHACH_TRO (MA_KHACH_HANG, MA_PHIEU) values (70, 56)
go

insert into KHACH_TRO (MA_KHACH_HANG, MA_PHIEU) values (71, 57)
go

insert into KHACH_TRO (MA_KHACH_HANG, MA_PHIEU) values (51, 58)
go

insert into KHACH_TRO (MA_KHACH_HANG, MA_PHIEU) values (52, 59)
go

insert into KHACH_TRO (MA_KHACH_HANG, MA_PHIEU) values (53, 60)
go
--end Year 2010

insert into PHIEU_THU_KHACH_HANG (MA_CA_TRUC, MA_PHIEU,NGAY_PHIEU,SO_TIEN,NOI_DUNG_THU,HINH_THUC_THU) values ('2', '1','2010-01-01','300000','','')
go

insert into PHIEU_THU_KHACH_HANG (MA_CA_TRUC, MA_PHIEU,NGAY_PHIEU,SO_TIEN,NOI_DUNG_THU,HINH_THUC_THU) values ('2', '2','2010-02-21','250000','','')
go

insert into PHIEU_THU_KHACH_HANG (MA_CA_TRUC, MA_PHIEU,NGAY_PHIEU,SO_TIEN,NOI_DUNG_THU,HINH_THUC_THU) values ('2', '3','2010-03-13','150000','','')
go

insert into PHIEU_THU_KHACH_HANG (MA_CA_TRUC, MA_PHIEU,NGAY_PHIEU,SO_TIEN,NOI_DUNG_THU,HINH_THUC_THU) values ('2', '4','2010-04-01','100000','','')
go

insert into PHIEU_THU_KHACH_HANG (MA_CA_TRUC, MA_PHIEU,NGAY_PHIEU,SO_TIEN,NOI_DUNG_THU,HINH_THUC_THU) values ('2', '5','2010-05-01','600000','','')
go

insert into PHIEU_THU_KHACH_HANG (MA_CA_TRUC, MA_PHIEU,NGAY_PHIEU,SO_TIEN,NOI_DUNG_THU,HINH_THUC_THU) values ('2', '6','2010-06-01','300000','','')
go

insert into PHIEU_THU_KHACH_HANG (MA_CA_TRUC, MA_PHIEU,NGAY_PHIEU,SO_TIEN,NOI_DUNG_THU,HINH_THUC_THU) values ('2', '7','2010-07-01','150000','','')
go

insert into PHIEU_THU_KHACH_HANG (MA_CA_TRUC, MA_PHIEU,NGAY_PHIEU,SO_TIEN,NOI_DUNG_THU,HINH_THUC_THU) values ('2', '8','2010-08-01','180000','','')
go

insert into PHIEU_THU_KHACH_HANG (MA_CA_TRUC, MA_PHIEU,NGAY_PHIEU,SO_TIEN,NOI_DUNG_THU,HINH_THUC_THU) values ('2', '9','2010-09-01','220000','','')
go

insert into PHIEU_THU_KHACH_HANG (MA_CA_TRUC, MA_PHIEU,NGAY_PHIEU,SO_TIEN,NOI_DUNG_THU,HINH_THUC_THU) values ('2', '10','2010-10-01','160000','','')
go

insert into PHIEU_THU_KHACH_HANG (MA_CA_TRUC, MA_PHIEU,NGAY_PHIEU,SO_TIEN,NOI_DUNG_THU,HINH_THUC_THU) values ('2', '11','2010-11-01','460000','','')
go

insert into PHIEU_THU_DOAN_KHACH (MA_DOAN_KHACH,MA_CA_TRUC,NGAY_PHIEU,SO_TIEN,NOI_DUNG_THU,HINH_THUC_THU) values ('1', '2','2010-12-01','240000','','')
go