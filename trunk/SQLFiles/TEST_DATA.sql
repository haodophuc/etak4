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


insert into KHACH_HANG (MA_QUOC_GIA, HO_KHACH_HANG, TEN_KHACH_HANG, CMND, HO_CHIEU, DIEN_THOAI) values (15, 'Zinedine', 'Zidane', '', 'UH-73828765 ', '0908756431')
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

insert into PHIEU_THUE_PHONG (MA_KHACH_HANG, MA_DOAN_KHACH, MA_PHONG, NGAY_NHAN_PHONG, NGAY_TRA_PHONG, GHI_CHU, THANH_TOAN_TIEN_PHONG, THANH_TOAN_DICH_VU, DA_TRA_PHONG) values
							 (16, 13, 1, '1753-01-01 00:00:00', '1753-01-01 00:00:00', 'LRWO0FEW9QYHGJMB6 XLVWM70RMH3SCTGEYEIWYI2MC84EXBDF', 0, 19, 1)
go

insert into PHIEU_THUE_PHONG (MA_KHACH_HANG, MA_DOAN_KHACH, MA_PHONG, NGAY_NHAN_PHONG, GHI_CHU, THANH_TOAN_TIEN_PHONG, THANH_TOAN_DICH_VU, DA_TRA_PHONG) values
							 (10, 19, 1, '1753-01-01 00:00:00', '47GMSP2H553BK689HARKTJWRAT A5NGUO3OGPVD8W7UWU533JI', 19, 4, 1)
go

insert into PHIEU_THUE_PHONG (MA_KHACH_HANG, MA_DOAN_KHACH, MA_PHONG, NGAY_NHAN_PHONG, NGAY_TRA_PHONG, GHI_CHU, THANH_TOAN_TIEN_PHONG, THANH_TOAN_DICH_VU, DA_TRA_PHONG) values 
							 (2, 3, 2, '1753-01-01 00:00:00', '1753-01-01 00:00:00', 'EKSPS7PMBSPAKYPYIQLAKLH1CSF38JDFPHHDU V4SYS YBOQF7', 7, 11, 1)
go

insert into PHIEU_THUE_PHONG (MA_KHACH_HANG, MA_DOAN_KHACH, MA_PHONG, NGAY_NHAN_PHONG, GHI_CHU, THANH_TOAN_TIEN_PHONG, THANH_TOAN_DICH_VU, DA_TRA_PHONG) values
							 (7, 10, 3, '1753-01-01 00:00:00', 'F76YSA2RE0V5LJG8CN5 AYQ7C VGBHH00GWQ N3YOKBD2GW6I7', 8, 8, 0)
go

insert into PHIEU_THUE_PHONG (MA_KHACH_HANG, MA_DOAN_KHACH, MA_PHONG, NGAY_NHAN_PHONG, NGAY_TRA_PHONG, GHI_CHU, THANH_TOAN_TIEN_PHONG, THANH_TOAN_DICH_VU, DA_TRA_PHONG) values 
							 (18, 12, 2, '1753-01-01 00:00:00', '1753-01-01 00:00:00', 'V1S WD5CKTMH8QYKC5H0YUU2SLY0W3 D6UG5OOQOEOV2SBKR8F', 9, 6, 1)
go

insert into PHIEU_THUE_PHONG (MA_KHACH_HANG, MA_DOAN_KHACH, MA_PHONG, NGAY_NHAN_PHONG, NGAY_TRA_PHONG, GHI_CHU, THANH_TOAN_TIEN_PHONG, THANH_TOAN_DICH_VU, DA_TRA_PHONG) values 
							 (19, 4, 10, '1753-01-01 00:00:00', '1753-01-01 00:00:00', 'ST9LDKDDGK27XL2PVSE43N7EWEYI842Q0MC7DRCL82KVI5YIAF', 9, 8, 1)
go


insert into PHIEU_THUE_PHONG (MA_KHACH_HANG, MA_DOAN_KHACH, MA_PHONG, NGAY_NHAN_PHONG, NGAY_TRA_PHONG, GHI_CHU, THANH_TOAN_TIEN_PHONG, THANH_TOAN_DICH_VU, DA_TRA_PHONG) values 
							 (5, 20, 17, '1753-01-01 00:00:00', '1753-01-01 00:00:00', 'QSJRPBQ129RLBBCOSPXLH3JC7A7KY3 G13COWK8PQ8YPBGPKX8', 19, 9, 1)
go

insert into PHIEU_THUE_PHONG (MA_KHACH_HANG, MA_DOAN_KHACH, MA_PHONG, NGAY_NHAN_PHONG, NGAY_TRA_PHONG, GHI_CHU, THANH_TOAN_TIEN_PHONG, THANH_TOAN_DICH_VU, DA_TRA_PHONG) values 
							 (11, 16, 2, '1753-01-01 00:00:00', '1753-01-01 00:00:00', 'MWCFIYVA271BC0D0OUQXS8A4AJYKJ20WU4GWRO0FMFTBXAIMTO', 7, 7, 1)
go


insert into PHIEU_THUE_PHONG (MA_KHACH_HANG, MA_DOAN_KHACH, MA_PHONG, NGAY_NHAN_PHONG, NGAY_TRA_PHONG, GHI_CHU, THANH_TOAN_TIEN_PHONG, THANH_TOAN_DICH_VU, DA_TRA_PHONG) values 
							 (1, 7, 5, '1753-01-01 00:00:00', '1753-01-01 00:00:00', '1Y2S857FF9T67RUJH8VIUB29X7COYHG6WGFF11VXC52FOP B75', 8, 16, 1)
go


insert into PHIEU_THUE_PHONG (MA_KHACH_HANG, MA_DOAN_KHACH, MA_PHONG, NGAY_NHAN_PHONG, GHI_CHU, THANH_TOAN_TIEN_PHONG, THANH_TOAN_DICH_VU, DA_TRA_PHONG) values 
							 (4, 1, 17, '1753-01-01 00:00:00', 'TPWRE2ADQT 4BCOOHG196SMKN2WGE8JDWO7X9 X1KIDGYSPP6E', 15, 13, 0)
go


insert into PHIEU_THUE_PHONG (MA_KHACH_HANG, MA_DOAN_KHACH, MA_PHONG, NGAY_NHAN_PHONG, NGAY_TRA_PHONG, GHI_CHU, THANH_TOAN_TIEN_PHONG, THANH_TOAN_DICH_VU, DA_TRA_PHONG) values 
							 (2, 16, 12, '1753-01-01 00:00:00', '1753-01-01 00:00:00', 'YPPEBQ5JY32QBFOY9D8QWENSFQQSFKPW5MVTGQICE5MXJR0A84', 11, 19, 1)
go


insert into PHIEU_THUE_PHONG (MA_KHACH_HANG, MA_DOAN_KHACH, MA_PHONG, NGAY_NHAN_PHONG, NGAY_TRA_PHONG, GHI_CHU, THANH_TOAN_TIEN_PHONG, THANH_TOAN_DICH_VU, DA_TRA_PHONG) values 
							 (1, 5, 10, '1753-01-01 00:00:00', '1753-01-01 00:00:00', 'KP7I Q POAA7JQGQTS5MU7DJNK3S JOKA YCWOFIRWQEGVA4IP', 16, 12, 1)
go


insert into PHIEU_THUE_PHONG (MA_KHACH_HANG, MA_DOAN_KHACH, MA_PHONG, NGAY_NHAN_PHONG, NGAY_TRA_PHONG, GHI_CHU, THANH_TOAN_TIEN_PHONG, THANH_TOAN_DICH_VU, DA_TRA_PHONG) values 
							 (2, 16, 11, '1753-01-01 00:00:00', '1753-01-01 00:00:00', 'GBN0HKD30S1RSHB8AR 2PNKTAWHEJAPLJMOSX ULAXU5838UCM', 6, 6, 1)
go


insert into PHIEU_THUE_PHONG (MA_KHACH_HANG, MA_DOAN_KHACH, MA_PHONG, NGAY_NHAN_PHONG, NGAY_TRA_PHONG, GHI_CHU, THANH_TOAN_TIEN_PHONG, THANH_TOAN_DICH_VU, DA_TRA_PHONG) values 
							 (17, 18, 12, '1753-01-01 00:00:00', '1753-01-01 00:00:00', '5G62M ID MN6W5JCYPEWXR0AC070HVBJJOV33YXCJYL2EPP3R4', 5, 15, 1)
go


insert into PHIEU_THUE_PHONG (MA_KHACH_HANG, MA_DOAN_KHACH, MA_PHONG, NGAY_NHAN_PHONG, NGAY_TRA_PHONG, GHI_CHU, THANH_TOAN_TIEN_PHONG, THANH_TOAN_DICH_VU, DA_TRA_PHONG) values 
							 (16, 12, 13, '1753-01-01 00:00:00', '1753-01-01 00:00:00', '4W918XUVG87XE6LKAH1Y6A0YWPAA8FOHWX6E2PTD98FDV019FE', 17, 0, 1)
go


insert into PHIEU_THUE_PHONG (MA_KHACH_HANG, MA_DOAN_KHACH, MA_PHONG, NGAY_NHAN_PHONG, GHI_CHU, THANH_TOAN_TIEN_PHONG, THANH_TOAN_DICH_VU, DA_TRA_PHONG) values 
							 (5, 17, 15, '1753-01-01 00:00:00', '7UUJNDL7FKESLH BXMOF4DFTU70GV WE75MDU494HTILNX9TG0', 14, 17, 0)
go


insert into PHIEU_THUE_PHONG (MA_KHACH_HANG, MA_DOAN_KHACH, MA_PHONG, NGAY_NHAN_PHONG, NGAY_TRA_PHONG, GHI_CHU, THANH_TOAN_TIEN_PHONG, THANH_TOAN_DICH_VU, DA_TRA_PHONG) values 
							 (5, 6, 8, '1753-01-01 00:00:00', '1753-01-01 00:00:00', '8UUTB7133UF2QED27YC70CU2U29R1NHLYKBTQ2BAHE84MUUFAD', 2, 18, 1)
go


insert into PHIEU_THUE_PHONG (MA_KHACH_HANG, MA_DOAN_KHACH, MA_PHONG, NGAY_NHAN_PHONG, NGAY_TRA_PHONG, GHI_CHU, THANH_TOAN_TIEN_PHONG, THANH_TOAN_DICH_VU, DA_TRA_PHONG) values 
							 (19, 12, 5, '1753-01-01 00:00:00', '1753-01-01 00:00:00', '6VFAQWTF548BK1149N5GRSK95SOGKQOMMGQO5NSQB99V0OTYJS', 12, 2, 1)
go


insert into PHIEU_THUE_PHONG (MA_KHACH_HANG, MA_DOAN_KHACH, MA_PHONG, NGAY_NHAN_PHONG, NGAY_TRA_PHONG, GHI_CHU, THANH_TOAN_TIEN_PHONG, THANH_TOAN_DICH_VU, DA_TRA_PHONG) values 
							 (13, 8, 8, '1753-01-01 00:00:00', '1753-01-01 00:00:00', 'GT97PHAYLG653K9IMOU8600M3NWIKEFU50HSDY4LMF7HE0YN9T', 4, 5, 1)
go


insert into PHIEU_THUE_PHONG (MA_KHACH_HANG, MA_DOAN_KHACH, MA_PHONG, NGAY_NHAN_PHONG, NGAY_TRA_PHONG, GHI_CHU, THANH_TOAN_TIEN_PHONG, THANH_TOAN_DICH_VU, DA_TRA_PHONG) values 
							 (16, 14, 14, '1753-01-01 00:00:00', '1753-02-02 00:00:00', 'D8F3ST6G35LPEI6BUH0KAXHCX6GOURH52Y1VIJKI8WA29Q2FKV', 0, 0, 1)
go


insert into PHIEU_THU_DOAN_KHACH (MA_DOAN_KHACH, MA_CA_TRUC, NGAY_PHIEU, SO_TIEN, NOI_DUNG_THU, HINH_THUC_THU) values (7, 2, '1753-01-01 00:00:00', 18, 'JIVYHQR3 FHJCP MLA6O9W9IXDDF3V EANXQMCMXQ8492VRD05', ' X29VJI9DSWA9QGMEP3FUCGJOBT17PTV8H2X23XK4RI65RFSME')
go


insert into PHIEU_THU_DOAN_KHACH (MA_DOAN_KHACH, MA_CA_TRUC, NGAY_PHIEU, SO_TIEN, NOI_DUNG_THU, HINH_THUC_THU) values (5, 2, '1753-01-01 00:00:00', 19, 'WWN3HYR 6TDKJNN558RD W J1PT3PM04L58Q91PXYFDYK5IQMK', 'DB71QF90EE8LOG1T2HSM3STNRUCLRPTCATYKB473B7T4A6U11B')
go


insert into PHIEU_THU_DOAN_KHACH (MA_DOAN_KHACH, MA_CA_TRUC, NGAY_PHIEU, SO_TIEN, NOI_DUNG_THU, HINH_THUC_THU) values (7, 2, '1753-01-01 00:00:00', 13, 'V62N6EFKT5SOTTS L9J43JXWEC9FGSDP69M6GFHHHYICFF3VO8', '31FR5RXRWHVF5EPOASS3E47OH2R5JMPG57PKAV3 RLH68Q88AI')
go


insert into PHIEU_THU_DOAN_KHACH (MA_DOAN_KHACH, MA_CA_TRUC, NGAY_PHIEU, SO_TIEN, NOI_DUNG_THU, HINH_THUC_THU) values (14, 2, '1753-01-01 00:00:00', 6, 'VW SBT28FEWCKL89XXU1HXIJWPOU56LE9I9EFL69DH05C1U0QP', '1XB1JQR3FNJJMM3UXCX32712I8DYAI7F8FW5IY8OU3V0246MEG')
go


insert into PHIEU_THU_DOAN_KHACH (MA_DOAN_KHACH, MA_CA_TRUC, NGAY_PHIEU, SO_TIEN, NOI_DUNG_THU, HINH_THUC_THU) values (1, 2, '1753-01-01 00:00:00', 15, '35OBY5JD3KM4UOAHJNIMY9WERJVR3HGSPGE037H91S6X523R9J', '9 IVSU85832664UGO86IHCX21U4 K2QD5GS04V6J4KJLI4J4NE')
go


insert into PHIEU_THU_DOAN_KHACH (MA_DOAN_KHACH, MA_CA_TRUC, NGAY_PHIEU, SO_TIEN, NOI_DUNG_THU, HINH_THUC_THU) values (11, 2, '1753-01-01 00:00:00', 14, 'W6R6DBWICCDSXS09 6G7DSODKNIS9OMNYGC5OUYR1DC7JR4HT0', 'AB4EVA25NWLNRSSX2B7 59U8GQHUDNE9GWV43OIF95IRNG33D5')
go


insert into PHIEU_THU_DOAN_KHACH (MA_DOAN_KHACH, MA_CA_TRUC, NGAY_PHIEU, SO_TIEN, NOI_DUNG_THU, HINH_THUC_THU) values (12, 2, '1753-01-01 00:00:00', 0, 'XVEQWSJ988Y0MB2IPF9X7L69W776VR9HN188F8VOWVXX0HND2F', '6U99RBC9DKME0Q0FCPCAINGPNNTDD5EIA3UPOHJGILTY472QC8')
go


insert into PHIEU_THU_DOAN_KHACH (MA_DOAN_KHACH, MA_CA_TRUC, NGAY_PHIEU, SO_TIEN, NOI_DUNG_THU, HINH_THUC_THU) values (15, 2, '1753-01-01 00:00:00', 4, '2YS 3CBDGW DSL0R2WQGEPDEDYCQ5W1SKPJM4W2F76U9U6Q5OR', 'NAO6D7DH NJPO3RBLT1Q4AC V VHLCKN926Q0Y1D4K0OJ7VVG2')
go


insert into PHIEU_THU_DOAN_KHACH (MA_DOAN_KHACH, MA_CA_TRUC, NGAY_PHIEU, SO_TIEN, NOI_DUNG_THU, HINH_THUC_THU) values (17, 2, '1753-01-01 00:00:00', 3, '2 Y0RO03 B2WF8SF5QM1WC1PP X0RJC6GWF7IN7Q05W4CNAP B', 'SJ E6TWB P9ETVT4PH6W4BJJQH2UX5L1DTR0J0A0MIJQXP55H ')
go


insert into PHIEU_THU_DOAN_KHACH (MA_DOAN_KHACH, MA_CA_TRUC, NGAY_PHIEU, SO_TIEN, NOI_DUNG_THU, HINH_THUC_THU) values (5, 2, '1753-01-01 00:00:00', 11, 'YVX4YKJRKPDFV R PUCHQMBT75735JB MCG0L96JCV3FMEKPRB', 'EL17R66X4N8DKIRRW2TGQ8LUQRPUD B9 C9TM8F7DW6Q3DH3N6')
go


insert into PHIEU_THU_DOAN_KHACH (MA_DOAN_KHACH, MA_CA_TRUC, NGAY_PHIEU, SO_TIEN, NOI_DUNG_THU, HINH_THUC_THU) values (15, 2, '1753-01-01 00:00:00', 5, '7GY LIJIOTYC4 0C5D2N5UT RDG085KYD1RFA5INQ4VY67NNVR', 'KV8965TN3VXKFM22CW9KYX7J5ABONW0J9Y1M57O5YCJ3OWK9R2')
go


insert into PHIEU_THU_DOAN_KHACH (MA_DOAN_KHACH, MA_CA_TRUC, NGAY_PHIEU, SO_TIEN, NOI_DUNG_THU, HINH_THUC_THU) values (5, 2, '1753-01-01 00:00:00', 9, '01TWNFG5SV 030DUJWN9RWLMJM1A1XUVL5BJGHKXKFQRFL3NAV', '29W2W7K IOSNQ3J9PWV8VQ8O6UFA386TPJT3E5XPBQ09EDW90X')
go


insert into PHIEU_THU_DOAN_KHACH (MA_DOAN_KHACH, MA_CA_TRUC, NGAY_PHIEU, SO_TIEN, NOI_DUNG_THU, HINH_THUC_THU) values (16, 2, '1753-01-01 00:00:00', 12, 'O1 ITW7Y2EQSIIJ4IBXCQW9H8FLSLCG46BUL5VL CHCQMQ3F5E', '7VTGY629JD6T4L5RVSIAO8ND1 DL1C3NL5O323T F4 K9QNFRF')
go


insert into PHIEU_THU_DOAN_KHACH (MA_DOAN_KHACH, MA_CA_TRUC, NGAY_PHIEU, SO_TIEN, NOI_DUNG_THU, HINH_THUC_THU) values (11, 2, '1753-01-01 00:00:00', 8, 'T4YJUBYRQJ911WQL38QIY7S2G57N00OMTTFDVJ82XOSYKTQ2IE', 'S7C9OA KRLKSA5 HD1LK7R10LOAHP9OLK5HDWBK5GY6TBPSPOC')
go


insert into PHIEU_THU_DOAN_KHACH (MA_DOAN_KHACH, MA_CA_TRUC, NGAY_PHIEU, SO_TIEN, NOI_DUNG_THU, HINH_THUC_THU) values (8, 2, '1753-01-01 00:00:00', 1, 'XX3F3CQELLN7CHQCN6E94FD04I6XAJUXCHCYP5TND2SR74EIFS', 'OMDHVTS V 42BDXYO21H267SLI3P122RC9PBWR4 RA0U07U7KR')
go


insert into PHIEU_THU_DOAN_KHACH (MA_DOAN_KHACH, MA_CA_TRUC, NGAY_PHIEU, SO_TIEN, NOI_DUNG_THU, HINH_THUC_THU) values (5, 2, '1753-01-01 00:00:00', 2, '0XGJ85H8EMBGYMXMKFV1G2ENTS1BM2TAVEXPRQETETJ0O5WY5W', '5X8MFYKVVR99ULSAVFPH VPEPSHXY3RSJ DUEYVT3KJA3Y3IS7')
go


insert into PHIEU_THU_DOAN_KHACH (MA_DOAN_KHACH, MA_CA_TRUC, NGAY_PHIEU, SO_TIEN, NOI_DUNG_THU, HINH_THUC_THU) values (2, 2, '1753-01-01 00:00:00', 10, 'G4GN0 RPRUCOQ897 R6YGYFGUDWUE4M4689J3C2FLHN9HUS8G7', 'C1JGH4V55UQIYBR4CI5XB7M1GNNGJLQ9EUN7 9FESKFWUIQXHT')
go


insert into PHIEU_THU_DOAN_KHACH (MA_DOAN_KHACH, MA_CA_TRUC, NGAY_PHIEU, SO_TIEN, NOI_DUNG_THU, HINH_THUC_THU) values (16, 2, '1753-01-01 00:00:00', 17, '94I0UOVF3JNSCITLJHNF2YFVI2C2QAET5VKTQWH0I1CMW76X9S', 'N6EMU4NVHK9N6UL VX78O4VQGXX3QA0WTDDB5HPYV 9S5UEBKW')
go


insert into PHIEU_THU_DOAN_KHACH (MA_DOAN_KHACH, MA_CA_TRUC, NGAY_PHIEU, SO_TIEN, NOI_DUNG_THU, HINH_THUC_THU) values (13, 2, '1753-01-01 00:00:00', 7, '0E90ESQPKB1IJPVG39XY9SHFF431VPGOTPPNHO9RP6CHCJH2T9', 'U1D7Y1CPLY8IMAY46 0RYFEBJWMR IYW0FV7ES7EN4EPYDGJPC')
go


insert into PHIEU_THU_DOAN_KHACH (MA_DOAN_KHACH, MA_CA_TRUC, NGAY_PHIEU, SO_TIEN, NOI_DUNG_THU, HINH_THUC_THU) values (16, 2, '1753-01-01 00:00:00', 16, 'P8I1GQ2X8CBX58XV ECO QNCP75R SS YFBOVVRV5SOCFIJN67', 'G9V0002ES9M3SW0LRGHGWS2WM6IUGGR2RCIXE4TH573XNIAP1H')
go


insert into PHIEU_DAT_PHONG (MA_KHACH_HANG, MA_DOAN_KHACH, TIEN_COC, DA_GIAI_QUYET) values (14, 11, 11, 0)
go


insert into PHIEU_DAT_PHONG (MA_KHACH_HANG, MA_DOAN_KHACH, TIEN_COC, DA_GIAI_QUYET) values (1, 3, 0, 0)
go


insert into PHIEU_DAT_PHONG (MA_KHACH_HANG, MA_DOAN_KHACH, TIEN_COC, DA_GIAI_QUYET) values (1, 15, 17, 0)
go


insert into PHIEU_DAT_PHONG (MA_KHACH_HANG, MA_DOAN_KHACH, TIEN_COC, DA_GIAI_QUYET) values (14, 14, 13, 0)
go


insert into PHIEU_DAT_PHONG (MA_KHACH_HANG, MA_DOAN_KHACH, TIEN_COC, DA_GIAI_QUYET) values (17, 17, 14, 0)
go


insert into PHIEU_DAT_PHONG (MA_KHACH_HANG, MA_DOAN_KHACH, TIEN_COC, DA_GIAI_QUYET) values (13, 18, 10, 0)
go


insert into PHIEU_DAT_PHONG (MA_KHACH_HANG, MA_DOAN_KHACH, TIEN_COC, DA_GIAI_QUYET) values (19, 8, 2, 1)
go


insert into PHIEU_DAT_PHONG (MA_KHACH_HANG, MA_DOAN_KHACH, TIEN_COC, DA_GIAI_QUYET) values (1, 18, 16, 1)
go


insert into PHIEU_DAT_PHONG (MA_KHACH_HANG, MA_DOAN_KHACH, TIEN_COC, DA_GIAI_QUYET) values (12, 18, 0, 1)
go


insert into PHIEU_DAT_PHONG (MA_KHACH_HANG, MA_DOAN_KHACH, TIEN_COC, DA_GIAI_QUYET) values (5, 6, 0, 1)
go


insert into PHIEU_DAT_PHONG (MA_KHACH_HANG, MA_DOAN_KHACH, TIEN_COC, DA_GIAI_QUYET) values (8, 12, 0, 0)
go


insert into PHIEU_DAT_PHONG (MA_KHACH_HANG, MA_DOAN_KHACH, TIEN_COC, DA_GIAI_QUYET) values (6, 8, 0, 0)
go


insert into PHIEU_DAT_PHONG (MA_KHACH_HANG, MA_DOAN_KHACH, TIEN_COC, DA_GIAI_QUYET) values (2, 2, 9, 0)
go


insert into PHIEU_DAT_PHONG (MA_KHACH_HANG, MA_DOAN_KHACH, TIEN_COC, DA_GIAI_QUYET) values (1, 6, 8, 0)
go


insert into PHIEU_DAT_PHONG (MA_KHACH_HANG, MA_DOAN_KHACH, TIEN_COC, DA_GIAI_QUYET) values (19, 11, 3, 0)
go


insert into PHIEU_DAT_PHONG (MA_KHACH_HANG, MA_DOAN_KHACH, TIEN_COC, DA_GIAI_QUYET) values (8, 8, 18, 0)
go


insert into PHIEU_DAT_PHONG (MA_KHACH_HANG, MA_DOAN_KHACH, TIEN_COC, DA_GIAI_QUYET) values (7, 18, 5, 1)
go


insert into PHIEU_DAT_PHONG (MA_KHACH_HANG, MA_DOAN_KHACH, TIEN_COC, DA_GIAI_QUYET) values (17, 19, 1, 1)
go


insert into PHIEU_DAT_PHONG (MA_KHACH_HANG, MA_DOAN_KHACH, TIEN_COC, DA_GIAI_QUYET) values (8, 2, 6, 0)
go


insert into PHIEU_DAT_PHONG (MA_KHACH_HANG, MA_DOAN_KHACH, TIEN_COC, DA_GIAI_QUYET) values (2, 1, 19, 0)
go


insert into CHI_TIET_DAT_PHONG (MA_PHIEU, MA_LOAI_PHONG, NGAY_DEN, NGAY_DI, SO_LUONG) values (8, 3, '1753-01-01 00:00:00', '1753-01-01 00:00:00', 12)
go


insert into CHI_TIET_DAT_PHONG (MA_PHIEU, MA_LOAI_PHONG, NGAY_DEN, NGAY_DI, SO_LUONG) values (6, 4, '1753-01-01 00:00:00', '1753-01-01 00:00:00', 6)
go


insert into CHI_TIET_DAT_PHONG (MA_PHIEU, MA_LOAI_PHONG, NGAY_DEN, NGAY_DI, SO_LUONG) values (3, 5, '1753-01-01 00:00:00', '1753-01-01 00:00:00', 13)
go


insert into CHI_TIET_DAT_PHONG (MA_PHIEU, MA_LOAI_PHONG, NGAY_DEN, NGAY_DI, SO_LUONG) values (4, 16, '1753-01-01 00:00:00', '1753-01-01 00:00:00', 0)
go


insert into CHI_TIET_DAT_PHONG (MA_PHIEU, MA_LOAI_PHONG, NGAY_DEN, NGAY_DI, SO_LUONG) values (2, 11, '1753-01-01 00:00:00', '1753-01-01 00:00:00', 9)
go


insert into CHI_TIET_DAT_PHONG (MA_PHIEU, MA_LOAI_PHONG, NGAY_DEN, NGAY_DI, SO_LUONG) values (19, 15, '1753-01-01 00:00:00', '1753-01-01 00:00:00', 16)
go


insert into CHI_TIET_DAT_PHONG (MA_PHIEU, MA_LOAI_PHONG, NGAY_DEN, NGAY_DI, SO_LUONG) values (13, 13, '1753-01-01 00:00:00', '1753-01-01 00:00:00', 7)
go


insert into CHI_TIET_DAT_PHONG (MA_PHIEU, MA_LOAI_PHONG, NGAY_DEN, NGAY_DI, SO_LUONG) values (17, 13, '1753-01-01 00:00:00', '1753-01-01 00:00:00', 4)
go


insert into CHI_TIET_DAT_PHONG (MA_PHIEU, MA_LOAI_PHONG, NGAY_DEN, NGAY_DI, SO_LUONG) values (9, 1, '1753-01-01 00:00:00', '1753-01-01 00:00:00', 1)
go


insert into CHI_TIET_DAT_PHONG (MA_PHIEU, MA_LOAI_PHONG, NGAY_DEN, NGAY_DI, SO_LUONG) values (11, 2, '1753-01-01 00:00:00', '1753-01-01 00:00:00', 19)
go


insert into CHI_TIET_DAT_PHONG (MA_PHIEU, MA_LOAI_PHONG, NGAY_DEN, NGAY_DI, SO_LUONG) values (7, 19, '1753-01-01 00:00:00', '1753-01-01 00:00:00', 2)
go


insert into CHI_TIET_DAT_PHONG (MA_PHIEU, MA_LOAI_PHONG, NGAY_DEN, NGAY_DI, SO_LUONG) values (15, 12, '1753-01-01 00:00:00', '1753-01-01 00:00:00', 15)
go


insert into CHI_TIET_DAT_PHONG (MA_PHIEU, MA_LOAI_PHONG, NGAY_DEN, NGAY_DI, SO_LUONG) values (14, 17, '1753-01-01 00:00:00', '1753-01-01 00:00:00', 11)
go


insert into CHI_TIET_DAT_PHONG (MA_PHIEU, MA_LOAI_PHONG, NGAY_DEN, NGAY_DI, SO_LUONG) values (18, 6, '1753-01-01 00:00:00', '1753-01-01 00:00:00', 14)
go


insert into CHI_TIET_DAT_PHONG (MA_PHIEU, MA_LOAI_PHONG, NGAY_DEN, NGAY_DI, SO_LUONG) values (16, 8, '1753-01-01 00:00:00', '1753-01-01 00:00:00', 5)
go


insert into CHI_TIET_DAT_PHONG (MA_PHIEU, MA_LOAI_PHONG, NGAY_DEN, NGAY_DI, SO_LUONG) values (10, 9, '1753-01-01 00:00:00', '1753-01-01 00:00:00', 8)
go


insert into CHI_TIET_DAT_PHONG (MA_PHIEU, MA_LOAI_PHONG, NGAY_DEN, NGAY_DI, SO_LUONG) values (1, 7, '1753-01-01 00:00:00', '1753-01-01 00:00:00', 18)
go


insert into CHI_TIET_DAT_PHONG (MA_PHIEU, MA_LOAI_PHONG, NGAY_DEN, NGAY_DI, SO_LUONG) values (5, 14, '1753-01-01 00:00:00', '1753-01-01 00:00:00', 17)
go


insert into CHI_TIET_DAT_PHONG (MA_PHIEU, MA_LOAI_PHONG, NGAY_DEN, NGAY_DI, SO_LUONG) values (1, 10, '1753-01-01 00:00:00', '1753-01-01 00:00:00', 3)
go


insert into CHI_TIET_DAT_PHONG (MA_PHIEU, MA_LOAI_PHONG, NGAY_DEN, NGAY_DI, SO_LUONG) values (12, 1, '1753-01-01 00:00:00', '1753-01-01 00:00:00', 10)
go


insert into PHIEU_DANG_KY_DICH_VU (MA_PHIEU, MA_DICH_VU, NGAY_PHUC_VU, SO_LUONG, GHI_CHU) values (10, 18, '1753-01-01 00:00:00', 3, 'WPLNT41R0LCKADH403SHE9KGEP MNWVG9KN75W0LGEINW5LW9 ')
go


insert into PHIEU_DANG_KY_DICH_VU (MA_PHIEU, MA_DICH_VU, NGAY_PHUC_VU, SO_LUONG, GHI_CHU) values (2, 5, '1753-01-01 00:00:00', 15, 'LGG1YVVCWJKNHC6KVFW4NUM7AV5 FM8634W2P6OOI0VUWMJ80C')
go


insert into PHIEU_DANG_KY_DICH_VU (MA_PHIEU, MA_DICH_VU, NGAY_PHUC_VU, SO_LUONG, GHI_CHU) values (2, 15, '1753-01-01 00:00:00', 11, '8KNKNQR923OHKYXWU3O0AN8Y32FLTGKOA02W86RLQKBTHVHTIT')
go


insert into PHIEU_DANG_KY_DICH_VU (MA_PHIEU, MA_DICH_VU, NGAY_PHUC_VU, SO_LUONG, GHI_CHU) values (13, 17, '1753-01-01 00:00:00', 5, '14MLCYUXPM0JURB476N0W86DM5Q0 H3U9F8AT6PVLBL8YLHEMY')
go


insert into PHIEU_DANG_KY_DICH_VU (MA_PHIEU, MA_DICH_VU, NGAY_PHUC_VU, SO_LUONG, GHI_CHU) values (2, 17, '1753-01-01 00:00:00', 16, 'N8L8JF33LQCBUP1 4TGKB79FMNQT2C7TI60A KJIVWD92SE1VT')
go


insert into PHIEU_DANG_KY_DICH_VU (MA_PHIEU, MA_DICH_VU, NGAY_PHUC_VU, SO_LUONG, GHI_CHU) values (10, 8, '1753-01-01 00:00:00', 8, 'ULB97UNBUTEB3M3M4RNI2DVRLY1EL K6BGE64LS7OHSLPAQQOO')
go


insert into PHIEU_DANG_KY_DICH_VU (MA_PHIEU, MA_DICH_VU, NGAY_PHUC_VU, SO_LUONG, GHI_CHU) values (12, 13, '1753-01-01 00:00:00', 7, 'SU2RIXAQ3T9DTC00B10WPMGILCSYC27OL55 5HLIN47UT1VQST')
go


insert into PHIEU_DANG_KY_DICH_VU (MA_PHIEU, MA_DICH_VU, NGAY_PHUC_VU, SO_LUONG, GHI_CHU) values (13, 5, '1753-01-01 00:00:00', 10, '73ID766OBWBL04DT9HQVDY2DJB7GKSNE9QXKME JJKNR6YF8OV')
go


insert into PHIEU_DANG_KY_DICH_VU (MA_PHIEU, MA_DICH_VU, NGAY_PHUC_VU, SO_LUONG, GHI_CHU) values (2, 7, '1753-01-01 00:00:00', 13, 'Q ABTJQQ97L0NM2H6SBTGV1ISAKU2MTV51SIBFFCPA7UP5P611')
go


insert into PHIEU_DANG_KY_DICH_VU (MA_PHIEU, MA_DICH_VU, NGAY_PHUC_VU, SO_LUONG, GHI_CHU) values (19, 13, '1753-01-01 00:00:00', 19, '5HHC MAMXMTJM6K91 PMXHKFV3N6SM NTO6WM3IITMN2MDU BW')
go


insert into PHIEU_DANG_KY_DICH_VU (MA_PHIEU, MA_DICH_VU, NGAY_PHUC_VU, SO_LUONG, GHI_CHU) values (2, 1, '1753-01-01 00:00:00', 17, '5S1UGIXOMVMFXLNCYC9U16W3CGOG5GS2PH8TQKK650UT1H3MTY')
go


insert into PHIEU_DANG_KY_DICH_VU (MA_PHIEU, MA_DICH_VU, NGAY_PHUC_VU, SO_LUONG, GHI_CHU) values (5, 1, '1753-01-01 00:00:00', 18, '6CO4LVJ4RSMI7CSHEY2V2TU JPQFB9Q V7XF5ITE4XYC4D ISX')
go


insert into PHIEU_DANG_KY_DICH_VU (MA_PHIEU, MA_DICH_VU, NGAY_PHUC_VU, SO_LUONG, GHI_CHU) values (3, 11, '1753-01-01 00:00:00', 1, 'N7LGC346YS8NRK87OHK7WK9JCMWBT4TM5L2LCI8J5FLU RB9F2')
go


insert into PHIEU_DANG_KY_DICH_VU (MA_PHIEU, MA_DICH_VU, NGAY_PHUC_VU, SO_LUONG, GHI_CHU) values (11, 9, '1753-01-01 00:00:00', 4, 'OSFQ0FIEN4VU8 TM5FJDT6BLVLHJJF6G1S7 GNR39BR147H7CT')
go


insert into PHIEU_DANG_KY_DICH_VU (MA_PHIEU, MA_DICH_VU, NGAY_PHUC_VU, SO_LUONG, GHI_CHU) values (7, 5, '1753-01-01 00:00:00', 14, 'QN3O0YF7DPK H81CX8XBUKF353QMENV7NBMRAKASU3CAEHTAGE')
go


insert into PHIEU_DANG_KY_DICH_VU (MA_PHIEU, MA_DICH_VU, NGAY_PHUC_VU, SO_LUONG, GHI_CHU) values (15, 15, '1753-01-01 00:00:00', 9, '3Q53MBO5ONEQSR544BQVB 2B4WJL94J8VDHC2H3EUYWKWB0TOE')
go


insert into PHIEU_DANG_KY_DICH_VU (MA_PHIEU, MA_DICH_VU, NGAY_PHUC_VU, SO_LUONG, GHI_CHU) values (1, 6, '1753-01-01 00:00:00', 12, 'HR5490EJ1G4X3EIU9ETS3TDBRPS952O67I68PL 1KAUI JHYEP')
go


insert into PHIEU_DANG_KY_DICH_VU (MA_PHIEU, MA_DICH_VU, NGAY_PHUC_VU, SO_LUONG, GHI_CHU) values (12, 1, '1753-01-01 00:00:00', 6, 'O2HDQOE3VSHDQ02SNYOIYGASRB52JLC67R2WL3U5ALW6QFSPJL')
go


insert into PHIEU_DANG_KY_DICH_VU (MA_PHIEU, MA_DICH_VU, NGAY_PHUC_VU, SO_LUONG, GHI_CHU) values (10, 1, '1753-01-01 00:00:00', 0, 'I1NXY0UGIGQV33S1N5 VIK 6DVX2NRK5IDQSUE O2YF166LO4S')
go


insert into PHIEU_DANG_KY_DICH_VU (MA_PHIEU, MA_DICH_VU, NGAY_PHUC_VU, SO_LUONG, GHI_CHU) values (5, 10, '1753-01-01 00:00:00', 2, '6EHLNKXPQSEUB73M4JPVRDTS8HMIJ5DDQ8ARUJLSXJD831OU0U')
go


insert into PHIEU_THU_KHACH_HANG (MA_PHIEU, MA_CA_TRUC, NGAY_PHIEU, SO_TIEN, NOI_DUNG_THU, HINH_THUC_THU) values (12, 1, '1753-01-01 00:00:00', 14, 'KCE0Y48IYUPFWG0 IVB3V2V9RD2CE 5MKADRQ R0JGWLXON6LW', 'WLKFGLURBDORUGF71DKX1LDJQLP5XOMAWCF2SDJ5NGVUUMD88C')
go


insert into PHIEU_THU_KHACH_HANG (MA_PHIEU, MA_CA_TRUC, NGAY_PHIEU, SO_TIEN, NOI_DUNG_THU, HINH_THUC_THU) values (11, 1, '1753-01-01 00:00:00', 14, 'KCE0Y48IYUPFWG0 IVB3V2V9RD2CE 5MKADRQ R0JGWLXON6LW', 'WLKFGLURBDORUGF71DKX1LDJQLP5XOMAWCF2SDJ5NGVUUMD88C')
go


insert into PHIEU_THU_KHACH_HANG (MA_PHIEU, MA_CA_TRUC, NGAY_PHIEU, SO_TIEN, NOI_DUNG_THU, HINH_THUC_THU) values (1, 1, '1753-01-01 00:00:00', 19, '3V7U0E3 2HQQE7B6562O XPXWOW2VG8XLI6CHAWB6HNOQ84R6S', 'Y 9P3LJBKBTJD8Y OOMCPM 6ERTTUQ5DOMC7I431O31AFD2MPC')
go


insert into PHIEU_THU_KHACH_HANG (MA_PHIEU, MA_CA_TRUC, NGAY_PHIEU, SO_TIEN, NOI_DUNG_THU, HINH_THUC_THU) values (4, 1, '1753-01-01 00:00:00', 11, 'L3PYJPSQD841PS08CRCL053O E2NW9XOUMF2TCM6TX55OKAIMR', 'R M1RNULOF0K04BPIWPIXL4DC7WKR2PWXRK599 JSAEN0M5OT4')
go


insert into PHIEU_THU_KHACH_HANG (MA_PHIEU, MA_CA_TRUC, NGAY_PHIEU, SO_TIEN, NOI_DUNG_THU, HINH_THUC_THU) values (3, 1, '1753-01-01 00:00:00', 17, 'TS6OPQ2 67HFGWX3TLQF PG0P 0YMXDGX14W5ET0PEQV5NISAI', 'V7S2XAH5G761QF DRGEL1 B47UXQYCYUCNNOOE3MPKTGCHJ2IB')
go


insert into PHIEU_THU_KHACH_HANG (MA_PHIEU, MA_CA_TRUC, NGAY_PHIEU, SO_TIEN, NOI_DUNG_THU, HINH_THUC_THU) values (10, 1, '1753-01-01 00:00:00', 6, 'KGL6VP89LJIAIAH8LRWMNG CL4MARF1HLTKMAN0HDSPJI63RF3', 'AIXP98KUWF3YHQE5VSFOITESDDN01W4 DXXUCOP99SE6P2DYY ')
go


insert into PHIEU_THU_KHACH_HANG (MA_PHIEU, MA_CA_TRUC, NGAY_PHIEU, SO_TIEN, NOI_DUNG_THU, HINH_THUC_THU) values (12, 1, '1753-01-01 00:00:00', 15, 'MIJO7SYOSCG31U4R87G 3P95BQCE3UFOCB EB6TUUFS81IHKA9', 'UHUL9 W ADPF0MD  Y44VNO5B1QUN6RY2M1G 4NMEAI0HD8 H2')
go


insert into PHIEU_THU_KHACH_HANG (MA_PHIEU, MA_CA_TRUC, NGAY_PHIEU, SO_TIEN, NOI_DUNG_THU, HINH_THUC_THU) values (15, 1, '1753-01-01 00:00:00', 12, 'L4BP9VM4KNO8G5DF U0L4W8EJTL64AL9JYBWD79362REG28F4L', 'UVBG3WR0FMNUGIS9RJE38UQY7J06ABEJNXC QO7XGQSYFP7YJO')
go


insert into PHIEU_THU_KHACH_HANG (MA_PHIEU, MA_CA_TRUC, NGAY_PHIEU, SO_TIEN, NOI_DUNG_THU, HINH_THUC_THU) values (7, 1, '1753-01-01 00:00:00', 2, 'TR  R93312DYEVLSFDNA49R31FAWR1GM 3E7G37TH4QH5VKAVS', 'COHAGWDM1Y1L86DWBI38M2A2IBDO4RLAMMKUD4CJ1IDJY6P5K6')
go


insert into PHIEU_THU_KHACH_HANG (MA_PHIEU, MA_CA_TRUC, NGAY_PHIEU, SO_TIEN, NOI_DUNG_THU, HINH_THUC_THU) values (6, 1, '1753-01-01 00:00:00', 3, '52EAGQ04 143NBMNHIM7B3RYNQN8XLLL0JJ1W8 UGQOPTIJ5CS', 'XGJ537COARR1 J4HVFQ 76JKD2642KI2CE07WFTQEG MJ7ST58')
go


insert into PHIEU_THU_KHACH_HANG (MA_PHIEU, MA_CA_TRUC, NGAY_PHIEU, SO_TIEN, NOI_DUNG_THU, HINH_THUC_THU) values (10, 1, '1753-01-01 00:00:00', 8, 'V2BGLTNEW2I5BSDJAL9D QS850MDEW4U29MUFK959LTWK2CRO2', 'EAU42PF9X2NRK5NBMQILH29C4PUQJ1BJP8 K7I8ATEG16AGKIN')
go


insert into PHIEU_THU_KHACH_HANG (MA_PHIEU, MA_CA_TRUC, NGAY_PHIEU, SO_TIEN, NOI_DUNG_THU, HINH_THUC_THU) values (14, 1, '1753-01-01 00:00:00', 16, '7AUH KHCCIL 1DEJ8LGU0IBBS5OS7W0U0H8H5RY9N0A2BXBUMG', 'H9X3OA0XB6CHPTJD1GKCQJ1YAAV9QOB94NS9S64A2A7CTNAR99')
go


insert into PHIEU_THU_KHACH_HANG (MA_PHIEU, MA_CA_TRUC, NGAY_PHIEU, SO_TIEN, NOI_DUNG_THU, HINH_THUC_THU) values (16, 1, '1753-01-01 00:00:00', 18, 'PSKY RYNO 4HUEGYISFP1DV8IG53H8VJ BITFOCIG9E 2DT0V3', 'RK7I7YO24RLD88MMPTX4D93I6TITYSO7HG5YJ1 OIDJGXPTPC ')
go


insert into PHIEU_THU_KHACH_HANG (MA_PHIEU, MA_CA_TRUC, NGAY_PHIEU, SO_TIEN, NOI_DUNG_THU, HINH_THUC_THU) values (6, 1, '1753-01-01 00:00:00', 4, 'W9MIS0Y5V8 YHHUXIE2 J8O BRULWH9RS3QNQM7TRO2DK6OUAU', 'W8NNSK JX24XOR6OBBWAHKH4WIDI3FIL1R07M3CF17HFHPRXUH')
go


insert into PHIEU_THU_KHACH_HANG (MA_PHIEU, MA_CA_TRUC, NGAY_PHIEU, SO_TIEN, NOI_DUNG_THU, HINH_THUC_THU) values (14, 1, '1753-01-01 00:00:00', 5, 'OONTP464K03GHTBUSWKPJR5NB0S1KVJ89 ALTAE7 RBK WO2EK', 'YYH8KHOEF85P0FVL7W1196TLIWBH8C3J7BHO8ALORSXB B083H')
go


insert into PHIEU_THU_KHACH_HANG (MA_PHIEU, MA_CA_TRUC, NGAY_PHIEU, SO_TIEN, NOI_DUNG_THU, HINH_THUC_THU) values (14, 1, '1753-01-01 00:00:00', 0, 'QA3XGAKM9TGK1K4AMAYRB323XR4D56K24UPW0MY0PQ20JQT3D3', '0JLM12RV1RTN929UCDC9MT7TNS5DA903DD4HTPF68WPFWR8DTF')
go


insert into PHIEU_THU_KHACH_HANG (MA_PHIEU, MA_CA_TRUC, NGAY_PHIEU, SO_TIEN, NOI_DUNG_THU, HINH_THUC_THU) values (3, 1, '1753-01-01 00:00:00', 9, 'WICT2HXG 72IG17810CMX7BCU1VI73RK75 8KGSFF0RCL60PK5', 'Q3WG6ED99NXHWAR2RDGP43DV54TGT5DO9DYCL1WL22BU60IODV')
go


insert into PHIEU_THU_KHACH_HANG (MA_PHIEU, MA_CA_TRUC, NGAY_PHIEU, SO_TIEN, NOI_DUNG_THU, HINH_THUC_THU) values (2, 1, '1753-01-01 00:00:00', 1, 'T44CVN15XMG2IO7WN6ETIV34KTQF YIX0WJTM1QGINY1YS OXD', 'KE1BNDH5166UAJWLLEWKU9EH5FRNS XD5BXY0NYTY43JM4K6TR')
go


insert into PHIEU_THU_KHACH_HANG (MA_PHIEU, MA_CA_TRUC, NGAY_PHIEU, SO_TIEN, NOI_DUNG_THU, HINH_THUC_THU) values (5, 1, '1753-01-01 00:00:00', 7, 'OFODGHV0YU93TJFKG1EDQPL5F5VPH1AESCC PO5VLOEJCXMREN', '2CID2MHH7XKGEAB3 H8QYA7LRN759E MN14RX6LGI2J4RTKL1S')
go


insert into PHIEU_THU_KHACH_HANG (MA_PHIEU, MA_CA_TRUC, NGAY_PHIEU, SO_TIEN, NOI_DUNG_THU, HINH_THUC_THU) values (3, 1, '1753-01-01 00:00:00', 10, 'KTNC4IUPOMC9DSFT54T T9A8H9LM6X6HY0UH03H46506R K66L', 'V8VQP304M3 HPFOQKVWO U8M7R16ORD78E24OA57A RJWOQ KS')
go


insert into KHACH_TRO (MA_KHACH_HANG, MA_PHIEU) values (3, 8)
go


insert into KHACH_TRO (MA_KHACH_HANG, MA_PHIEU) values (10, 6)
go


insert into KHACH_TRO (MA_KHACH_HANG, MA_PHIEU) values (19, 3)
go


insert into KHACH_TRO (MA_KHACH_HANG, MA_PHIEU) values (16, 4)
go


insert into KHACH_TRO (MA_KHACH_HANG, MA_PHIEU) values (11, 2)
go


insert into KHACH_TRO (MA_KHACH_HANG, MA_PHIEU) values (18, 19)
go


insert into KHACH_TRO (MA_KHACH_HANG, MA_PHIEU) values (2, 13)
go


insert into KHACH_TRO (MA_KHACH_HANG, MA_PHIEU) values (9, 17)
go


insert into KHACH_TRO (MA_KHACH_HANG, MA_PHIEU) values (12, 9)
go


insert into KHACH_TRO (MA_KHACH_HANG, MA_PHIEU) values (5, 11)
go


insert into KHACH_TRO (MA_KHACH_HANG, MA_PHIEU) values (7, 7)
go


insert into KHACH_TRO (MA_KHACH_HANG, MA_PHIEU) values (15, 15)
go


insert into KHACH_TRO (MA_KHACH_HANG, MA_PHIEU) values (17, 14)
go


insert into KHACH_TRO (MA_KHACH_HANG, MA_PHIEU) values (1, 18)
go


insert into KHACH_TRO (MA_KHACH_HANG, MA_PHIEU) values (14, 16)
go


insert into KHACH_TRO (MA_KHACH_HANG, MA_PHIEU) values (13, 10)
go


insert into KHACH_TRO (MA_KHACH_HANG, MA_PHIEU) values (8, 1)
go


insert into KHACH_TRO (MA_KHACH_HANG, MA_PHIEU) values (1, 5)
go


insert into KHACH_TRO (MA_KHACH_HANG, MA_PHIEU) values (6, 1)
go


insert into KHACH_TRO (MA_KHACH_HANG, MA_PHIEU) values (4, 12)
go


