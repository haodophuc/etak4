/*==============================================================*/
/* Nom de SGBD :  Microsoft SQL Server 2005                     */
/* Date de création :  6/6/2010 3:09:54 PM                      */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CA_TRUC') and o.name = 'FK_CA_TRUC_CTTN_THU_NGAN')
alter table CA_TRUC
   drop constraint FK_CA_TRUC_CTTN_THU_NGAN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CHI_TIET_DAT_PHONG') and o.name = 'FK_CHI_TIET_CTDP_LOAI_PHO')
alter table CHI_TIET_DAT_PHONG
   drop constraint FK_CHI_TIET_CTDP_LOAI_PHO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CHI_TIET_DAT_PHONG') and o.name = 'FK_CHI_TIET_CTDP_PHIEU_DA')
alter table CHI_TIET_DAT_PHONG
   drop constraint FK_CHI_TIET_CTDP_PHIEU_DA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CONG_TY') and o.name = 'FK_CONG_TY_CONG_TY_C_KHACH_HA')
alter table CONG_TY
   drop constraint FK_CONG_TY_CONG_TY_C_KHACH_HA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CONG_TY') and o.name = 'FK_CONG_TY_CONG_TY_T_QUOC_GIA')
alter table CONG_TY
   drop constraint FK_CONG_TY_CONG_TY_T_QUOC_GIA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('DOAN_KHACH') and o.name = 'FK_DOAN_KHA_THUOC_CON_CONG_TY')
alter table DOAN_KHACH
   drop constraint FK_DOAN_KHA_THUOC_CON_CONG_TY
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('KHACH_HANG') and o.name = 'FK_KHACH_HA_KHACH_HAN_QUOC_GIA')
alter table KHACH_HANG
   drop constraint FK_KHACH_HA_KHACH_HAN_QUOC_GIA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('KHACH_TRO') and o.name = 'FK_KHACH_TR_TRO_KHACH_HA')
alter table KHACH_TRO
   drop constraint FK_KHACH_TR_TRO_KHACH_HA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('KHACH_TRO') and o.name = 'FK_KHACH_TR_TRO_PHIEU_TH')
alter table KHACH_TRO
   drop constraint FK_KHACH_TR_TRO_PHIEU_TH
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PHIEU_DANG_KY_DICH_VU') and o.name = 'FK_PHIEU_DA_DANG_KY_D_PHIEU_TH')
alter table PHIEU_DANG_KY_DICH_VU
   drop constraint FK_PHIEU_DA_DANG_KY_D_PHIEU_TH
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PHIEU_DANG_KY_DICH_VU') and o.name = 'FK_PHIEU_DA_DANG_KY_D_DICH_VU')
alter table PHIEU_DANG_KY_DICH_VU
   drop constraint FK_PHIEU_DA_DANG_KY_D_DICH_VU
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PHIEU_DAT_PHONG') and o.name = 'FK_PHIEU_DA_PHIEU_DAT_KHACH_HA')
alter table PHIEU_DAT_PHONG
   drop constraint FK_PHIEU_DA_PHIEU_DAT_KHACH_HA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PHIEU_DAT_PHONG') and o.name = 'FK_PHIEU_DA_PHIEU_DAT_DOAN_KHA')
alter table PHIEU_DAT_PHONG
   drop constraint FK_PHIEU_DA_PHIEU_DAT_DOAN_KHA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PHIEU_THUE_PHONG') and o.name = 'FK_PHIEU_TH_PHIEU_THU_KHACH_HA')
alter table PHIEU_THUE_PHONG
   drop constraint FK_PHIEU_TH_PHIEU_THU_KHACH_HA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PHIEU_THUE_PHONG') and o.name = 'FK_PHIEU_TH_PHIEU_THU_DOAN_KHA')
alter table PHIEU_THUE_PHONG
   drop constraint FK_PHIEU_TH_PHIEU_THU_DOAN_KHA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PHIEU_THUE_PHONG') and o.name = 'FK_PHIEU_TH_THUE_PHON_PHONG')
alter table PHIEU_THUE_PHONG
   drop constraint FK_PHIEU_TH_THUE_PHON_PHONG
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PHIEU_THU_DOAN_KHACH') and o.name = 'FK_PHIEU_TH_THU_DOAN__DOAN_KHA')
alter table PHIEU_THU_DOAN_KHACH
   drop constraint FK_PHIEU_TH_THU_DOAN__DOAN_KHA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PHIEU_THU_DOAN_KHACH') and o.name = 'FK_PHIEU_TH_THU_DOAN__CA_TRUC')
alter table PHIEU_THU_DOAN_KHACH
   drop constraint FK_PHIEU_TH_THU_DOAN__CA_TRUC
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PHIEU_THU_KHACH_HANG') and o.name = 'FK_PHIEU_TH_THU_KHACH_CA_TRUC')
alter table PHIEU_THU_KHACH_HANG
   drop constraint FK_PHIEU_TH_THU_KHACH_CA_TRUC
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PHIEU_THU_KHACH_HANG') and o.name = 'FK_PHIEU_TH_THU_KHACH_KHACH_HA')
alter table PHIEU_THU_KHACH_HANG
   drop constraint FK_PHIEU_TH_THU_KHACH_KHACH_HA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PHONG') and o.name = 'FK_PHONG_PHONG_THU_LOAI_PHO')
alter table PHONG
   drop constraint FK_PHONG_PHONG_THU_LOAI_PHO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PHONG') and o.name = 'FK_PHONG_TRONG_TIN_TINH_TRA')
alter table PHONG
   drop constraint FK_PHONG_TRONG_TIN_TINH_TRA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('QUYEN_ADMIN') and o.name = 'FK_QUYEN_AD_REFERENCE_ADMINS')
alter table QUYEN_ADMIN
   drop constraint FK_QUYEN_AD_REFERENCE_ADMINS
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('QUYEN_ADMIN') and o.name = 'FK_QUYEN_AD_REFERENCE_QUYEN')
alter table QUYEN_ADMIN
   drop constraint FK_QUYEN_AD_REFERENCE_QUYEN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('QUYEN_THU_NGAN') and o.name = 'FK_QUYEN_TH_REFERENCE_THU_NGAN')
alter table QUYEN_THU_NGAN
   drop constraint FK_QUYEN_TH_REFERENCE_THU_NGAN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('QUYEN_THU_NGAN') and o.name = 'FK_QUYEN_TH_REFERENCE_QUYEN')
alter table QUYEN_THU_NGAN
   drop constraint FK_QUYEN_TH_REFERENCE_QUYEN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TIEN_NGHI_LOAI_PHONG') and o.name = 'FK_TIEN_NGH_TNLP_LOAI_PHO')
alter table TIEN_NGHI_LOAI_PHONG
   drop constraint FK_TIEN_NGH_TNLP_LOAI_PHO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TIEN_NGHI_LOAI_PHONG') and o.name = 'FK_TIEN_NGH_TNLP_TIEN_NGH')
alter table TIEN_NGHI_LOAI_PHONG
   drop constraint FK_TIEN_NGH_TNLP_TIEN_NGH
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ADMINS')
            and   type = 'U')
   drop table ADMINS
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CA_TRUC')
            and   type = 'U')
   drop table CA_TRUC
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CHI_TIET_DAT_PHONG')
            and   type = 'U')
   drop table CHI_TIET_DAT_PHONG
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CONG_TY')
            and   type = 'U')
   drop table CONG_TY
go

if exists (select 1
            from  sysobjects
           where  id = object_id('DICH_VU')
            and   type = 'U')
   drop table DICH_VU
go

if exists (select 1
            from  sysobjects
           where  id = object_id('DOAN_KHACH')
            and   type = 'U')
   drop table DOAN_KHACH
go

if exists (select 1
            from  sysobjects
           where  id = object_id('KHACH_HANG')
            and   type = 'U')
   drop table KHACH_HANG
go

if exists (select 1
            from  sysobjects
           where  id = object_id('KHACH_TRO')
            and   type = 'U')
   drop table KHACH_TRO
go

if exists (select 1
            from  sysobjects
           where  id = object_id('LOAI_PHONG')
            and   type = 'U')
   drop table LOAI_PHONG
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PHIEU_DANG_KY_DICH_VU')
            and   type = 'U')
   drop table PHIEU_DANG_KY_DICH_VU
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PHIEU_DAT_PHONG')
            and   type = 'U')
   drop table PHIEU_DAT_PHONG
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PHIEU_THUE_PHONG')
            and   type = 'U')
   drop table PHIEU_THUE_PHONG
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PHIEU_THU_DOAN_KHACH')
            and   type = 'U')
   drop table PHIEU_THU_DOAN_KHACH
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PHIEU_THU_KHACH_HANG')
            and   type = 'U')
   drop table PHIEU_THU_KHACH_HANG
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PHONG')
            and   type = 'U')
   drop table PHONG
go

if exists (select 1
            from  sysobjects
           where  id = object_id('QUOC_GIA')
            and   type = 'U')
   drop table QUOC_GIA
go

if exists (select 1
            from  sysobjects
           where  id = object_id('QUYEN')
            and   type = 'U')
   drop table QUYEN
go

if exists (select 1
            from  sysobjects
           where  id = object_id('QUYEN_ADMIN')
            and   type = 'U')
   drop table QUYEN_ADMIN
go

if exists (select 1
            from  sysobjects
           where  id = object_id('QUYEN_THU_NGAN')
            and   type = 'U')
   drop table QUYEN_THU_NGAN
go

if exists (select 1
            from  sysobjects
           where  id = object_id('THU_NGAN')
            and   type = 'U')
   drop table THU_NGAN
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TIEN_NGHI')
            and   type = 'U')
   drop table TIEN_NGHI
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TIEN_NGHI_LOAI_PHONG')
            and   type = 'U')
   drop table TIEN_NGHI_LOAI_PHONG
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TINH_TRANG')
            and   type = 'U')
   drop table TINH_TRANG
go

if exists(select 1 from systypes where name='DIA_CHI')
   drop type DIA_CHI
go

if exists(select 1 from systypes where name='DIEN_THOAI')
   drop type DIEN_THOAI
go

if exists(select 1 from systypes where name='EMAIL')
   drop type EMAIL
go

if exists(select 1 from systypes where name='FAX')
   drop type FAX
go

if exists(select 1 from systypes where name='MAT_KHAU')
   drop type MAT_KHAU
go

if exists(select 1 from systypes where name='TEN')
   drop type TEN
go

if exists(select 1 from systypes where name='TEN_DANG_NHAP')
   drop type TEN_DANG_NHAP
go

if exists(select 1 from systypes where name='TIEN_TE')
   drop type TIEN_TE
go

if exists(select 1 from systypes where name='YES_OR_NO')
   drop type YES_OR_NO
go

/*==============================================================*/
/* Domaine : DIA_CHI                                            */
/*==============================================================*/
create type DIA_CHI
   from nvarchar(50)
go

/*==============================================================*/
/* Domaine : DIEN_THOAI                                         */
/*==============================================================*/
create type DIEN_THOAI
   from nvarchar(50)
go

/*==============================================================*/
/* Domaine : EMAIL                                              */
/*==============================================================*/
create type EMAIL
   from nvarchar(50)
go

/*==============================================================*/
/* Domaine : FAX                                                */
/*==============================================================*/
create type FAX
   from nvarchar(50)
go

/*==============================================================*/
/* Domaine : MAT_KHAU                                           */
/*==============================================================*/
create type MAT_KHAU
   from nvarchar(20) not null
go

/*==============================================================*/
/* Domaine : TEN                                                */
/*==============================================================*/
create type TEN
   from nvarchar(50) not null
go

/*==============================================================*/
/* Domaine : TEN_DANG_NHAP                                      */
/*==============================================================*/
create type TEN_DANG_NHAP
   from nvarchar(50) not null
go

/*==============================================================*/
/* Domaine : TIEN_TE                                            */
/*==============================================================*/
create type TIEN_TE
   from money
go

/*==============================================================*/
/* Domaine : YES_OR_NO                                          */
/*==============================================================*/
create type YES_OR_NO
   from bit not null
go

/*==============================================================*/
/* Table : ADMINS                                               */
/*==============================================================*/
create table ADMINS (
   MA_ADMIN             int                  identity,
   TEN_DANG_NHAP        TEN_DANG_NHAP        not null,
   MAT_KHAU             MAT_KHAU             not null,
   TEN_ADMIN            TEN                  not null,
   DIA_CHI              DIA_CHI              null,
   DIEN_THOAI           DIEN_THOAI           null,
   constraint PK_ADMINS primary key (MA_ADMIN)
)
go

/*==============================================================*/
/* Table : CA_TRUC                                              */
/*==============================================================*/
create table CA_TRUC (
   MA_CA_TRUC           int                  identity,
   MA_THU_NGAN          int                  not null,
   GIO_VAO_CA           datetime             null,
   GIO_XUONG_CA         datetime             null,
   DA_KET_TOAN          YES_OR_NO            not null default 0,
   constraint PK_CA_TRUC primary key (MA_CA_TRUC)
)
go

/*==============================================================*/
/* Table : CHI_TIET_DAT_PHONG                                   */
/*==============================================================*/
create table CHI_TIET_DAT_PHONG (
   MA_PHIEU             int                  not null,
   MA_LOAI_PHONG        int                  not null,
   NGAY_DEN             datetime             null,
   NGAY_DI              datetime             null,
   SO_LUONG             int                  null
      constraint CKC_SO_LUONG_CHI_TIET check (SO_LUONG is null or (SO_LUONG >= 0)),
   constraint PK_CHI_TIET_DAT_PHONG primary key (MA_PHIEU, MA_LOAI_PHONG)
)
go

/*==============================================================*/
/* Table : CONG_TY                                              */
/*==============================================================*/
create table CONG_TY (
   MA_CONG_TY           int                  identity,
   TEN_CONG_TY          TEN                  not null,
   MA_QUOC_GIA          int                  null,
   MA_NGUOI_DAI_DIEN    int                  null,
   DIA_CHI              DIA_CHI              null,
   DIEN_THOAI           DIEN_THOAI           null,
   EMAIL                EMAIL                null,
   FAX                  FAX                  null,
   SO_TAI_KHOAN         nvarchar(20)         null,
   MA_SO_THUE           nvarchar(20)         null,
   HIEU_LUC             YES_OR_NO            not null default 1,
   constraint PK_CONG_TY primary key (MA_CONG_TY)
)
go

/*==============================================================*/
/* Table : DICH_VU                                              */
/*==============================================================*/
create table DICH_VU (
   MA_DICH_VU           int                  identity,
   TEN_DICH_VU          TEN                  not null,
   DON_GIA              TIEN_TE              not null,
   HIEU_LUC             YES_OR_NO            not null default 1,
   constraint PK_DICH_VU primary key (MA_DICH_VU)
)
go

/*==============================================================*/
/* Table : DOAN_KHACH                                           */
/*==============================================================*/
create table DOAN_KHACH (
   MA_DOAN_KHACH        int                  identity,
   MA_CONG_TY           int                  null,
   NGAY_DEN             datetime             null,
   HIEU_LUC             YES_OR_NO            not null default 1,
   constraint PK_DOAN_KHACH primary key (MA_DOAN_KHACH)
)
go

/*==============================================================*/
/* Table : KHACH_HANG                                           */
/*==============================================================*/
create table KHACH_HANG (
   MA_KHACH_HANG        int                  identity,
   MA_QUOC_GIA          int                  null,
   HO_KHACH_HANG        TEN                  not null,
   TEN_KHACH_HANG       TEN                  not null,
   CMND                 nvarchar(20)         null,
   HO_CHIEU             nvarchar(20)         null,
   DIEN_THOAI           DIEN_THOAI           null,
   HIEU_LUC             YES_OR_NO            not null default 1,
   constraint PK_KHACH_HANG primary key (MA_KHACH_HANG)
)
go

/*==============================================================*/
/* Table : KHACH_TRO                                            */
/*==============================================================*/
create table KHACH_TRO (
   MA_KHACH_HANG        int                  not null,
   MA_PHIEU             int                  not null,
   constraint PK_KHACH_TRO primary key (MA_KHACH_HANG, MA_PHIEU)
)
go

/*==============================================================*/
/* Table : LOAI_PHONG                                           */
/*==============================================================*/
create table LOAI_PHONG (
   MA_LOAI_PHONG        int                  identity,
   TEN_LOAI_PHONG       TEN                  not null,
   SO_GIUONG            int                  null
      constraint CKC_SO_GIUONG_LOAI_PHO check (SO_GIUONG is null or (SO_GIUONG >= 0)),
   SO_LUONG_PHONG       int                  null
      constraint CKC_SO_LUONG_PHONG_LOAI_PHO check (SO_LUONG_PHONG is null or (SO_LUONG_PHONG >= 0)),
   GIA_THAM_KHAO        TIEN_TE              null,
   constraint PK_LOAI_PHONG primary key (MA_LOAI_PHONG)
)
go

/*==============================================================*/
/* Table : PHIEU_DANG_KY_DICH_VU                                */
/*==============================================================*/
create table PHIEU_DANG_KY_DICH_VU (
   SO_PHIEU             int                  identity,
   MA_PHIEU             int                  not null,
   MA_DICH_VU           int                  not null,
   NGAY_PHUC_VU         datetime             not null,
   SO_LUONG             int                  not null,
   GHI_CHU              nvarchar(50)         null,
   constraint PK_PHIEU_DANG_KY_DICH_VU primary key (SO_PHIEU)
)
go

/*==============================================================*/
/* Table : PHIEU_DAT_PHONG                                      */
/*==============================================================*/
create table PHIEU_DAT_PHONG (
   MA_PHIEU             int                  identity,
   MA_KHACH_HANG        int                  null,
   MA_DOAN_KHACH        int                  null,
   TIEN_COC             TIEN_TE              null,
   constraint PK_PHIEU_DAT_PHONG primary key (MA_PHIEU)
)
go

/*==============================================================*/
/* Table : PHIEU_THUE_PHONG                                     */
/*==============================================================*/
create table PHIEU_THUE_PHONG (
   MA_PHIEU             int                  identity,
   MA_KHACH_HANG        int                  null,
   MA_DOAN_KHACH        int                  null,
   MA_PHONG             int                  not null,
   NGAY_NHAN_PHONG      datetime             not null,
   NGAY_TRA_PHONG       datetime             null,
   GHI_CHU              nvarchar(50)         null,
   THANH_TOAN_TIEN_PHONG YES_OR_NO            not null default 0,
   THANH_TOAN_DICH_VU   YES_OR_NO            not null default 0,
   DA_TRA_PHONG         YES_OR_NO            not null default 0,
   constraint PK_PHIEU_THUE_PHONG primary key (MA_PHIEU)
)
go

/*==============================================================*/
/* Table : PHIEU_THU_DOAN_KHACH                                 */
/*==============================================================*/
create table PHIEU_THU_DOAN_KHACH (
   SO_PHIEU             int                  identity,
   MA_DOAN_KHACH        int                  null,
   MA_CA_TRUC           int                  null,
   NGAY_PHIEU           datetime             null,
   SO_TIEN              TIEN_TE              null,
   NOI_DUNG_THU         nvarchar(50)         null,
   HINH_THUC_THU        nvarchar(50)         null,
   constraint PK_PHIEU_THU_DOAN_KHACH primary key (SO_PHIEU)
)
go

/*==============================================================*/
/* Table : PHIEU_THU_KHACH_HANG                                 */
/*==============================================================*/
create table PHIEU_THU_KHACH_HANG (
   SO_PHIEU             int                  identity,
   MA_KHACH_HANG        int                  not null,
   MA_CA_TRUC           int                  not null,
   NGAY_PHIEU           datetime             not null,
   SO_TIEN              TIEN_TE              null,
   NOI_DUNG_THU         nvarchar(50)         null,
   HINH_THUC_THU        nvarchar(50)         null,
   constraint PK_PHIEU_THU_KHACH_HANG primary key (SO_PHIEU)
)
go

/*==============================================================*/
/* Table : PHONG                                                */
/*==============================================================*/
create table PHONG (
   MA_PHONG             int                  identity,
   MA_LOAI_PHONG        int                  null,
   MA_TINH_TRANG        int                  null,
   SO_PHONG             nvarchar(10)         null,
   constraint PK_PHONG primary key (MA_PHONG)
)
go

/*==============================================================*/
/* Table : QUOC_GIA                                             */
/*==============================================================*/
create table QUOC_GIA (
   MA_QUOC_GIA          int                  identity,
   TEN_QUOC_GIA         TEN                  not null,
   constraint PK_QUOC_GIA primary key (MA_QUOC_GIA)
)
go

/*==============================================================*/
/* Table : QUYEN                                                */
/*==============================================================*/
create table QUYEN (
   MA_QUYEN             int                  identity,
   TEN_QUYEN            TEN                  not null,
   QUYEN_LUC            TEN                  not null,
   GHI_CHU              nvarchar(50)         null,
   constraint PK_QUYEN primary key (MA_QUYEN)
)
go

/*==============================================================*/
/* Table : QUYEN_ADMIN                                          */
/*==============================================================*/
create table QUYEN_ADMIN (
   MA_ADMIN             int                  not null,
   MA_QUYEN             int                  not null,
   constraint PK_QUYEN_ADMIN primary key (MA_ADMIN, MA_QUYEN)
)
go

/*==============================================================*/
/* Table : QUYEN_THU_NGAN                                       */
/*==============================================================*/
create table QUYEN_THU_NGAN (
   MA_THU_NGAN          int                  not null,
   MA_QUYEN             int                  not null,
   constraint PK_QUYEN_THU_NGAN primary key (MA_THU_NGAN, MA_QUYEN)
)
go

/*==============================================================*/
/* Table : THU_NGAN                                             */
/*==============================================================*/
create table THU_NGAN (
   MA_THU_NGAN          int                  identity,
   TEN_DANG_NHAP        TEN_DANG_NHAP        not null,
   MAT_KHAU             MAT_KHAU             not null,
   HO_TEN               TEN                  not null,
   DIA_CHI              DIA_CHI              null,
   DIEN_THOAI           DIEN_THOAI           null,
   constraint PK_THU_NGAN primary key (MA_THU_NGAN)
)
go

/*==============================================================*/
/* Table : TIEN_NGHI                                            */
/*==============================================================*/
create table TIEN_NGHI (
   MA_TIEN_NGHI         int                  identity,
   TIEN_NGHI            TEN                  not null,
   constraint PK_TIEN_NGHI primary key (MA_TIEN_NGHI)
)
go

/*==============================================================*/
/* Table : TIEN_NGHI_LOAI_PHONG                                 */
/*==============================================================*/
create table TIEN_NGHI_LOAI_PHONG (
   MA_TIEN_NGHI         int                  not null,
   MA_LOAI_PHONG        int                  not null,
   constraint PK_TIEN_NGHI_LOAI_PHONG primary key (MA_TIEN_NGHI, MA_LOAI_PHONG)
)
go

/*==============================================================*/
/* Table : TINH_TRANG                                           */
/*==============================================================*/
create table TINH_TRANG (
   MA_TINH_TRANG        int                  identity,
   TINH_TRANG           TEN                  not null,
   constraint PK_TINH_TRANG primary key (MA_TINH_TRANG)
)
go

alter table CA_TRUC
   add constraint FK_CA_TRUC_CTTN_THU_NGAN foreign key (MA_THU_NGAN)
      references THU_NGAN (MA_THU_NGAN)
go

alter table CHI_TIET_DAT_PHONG
   add constraint FK_CHI_TIET_CTDP_LOAI_PHO foreign key (MA_LOAI_PHONG)
      references LOAI_PHONG (MA_LOAI_PHONG)
go

alter table CHI_TIET_DAT_PHONG
   add constraint FK_CHI_TIET_CTDP_PHIEU_DA foreign key (MA_PHIEU)
      references PHIEU_DAT_PHONG (MA_PHIEU)
go

alter table CONG_TY
   add constraint FK_CONG_TY_CONG_TY_C_KHACH_HA foreign key (MA_NGUOI_DAI_DIEN)
      references KHACH_HANG (MA_KHACH_HANG)
go

alter table CONG_TY
   add constraint FK_CONG_TY_CONG_TY_T_QUOC_GIA foreign key (MA_QUOC_GIA)
      references QUOC_GIA (MA_QUOC_GIA)
go

alter table DOAN_KHACH
   add constraint FK_DOAN_KHA_THUOC_CON_CONG_TY foreign key (MA_CONG_TY)
      references CONG_TY (MA_CONG_TY)
go

alter table KHACH_HANG
   add constraint FK_KHACH_HA_KHACH_HAN_QUOC_GIA foreign key (MA_QUOC_GIA)
      references QUOC_GIA (MA_QUOC_GIA)
go

alter table KHACH_TRO
   add constraint FK_KHACH_TR_TRO_KHACH_HA foreign key (MA_KHACH_HANG)
      references KHACH_HANG (MA_KHACH_HANG)
go

alter table KHACH_TRO
   add constraint FK_KHACH_TR_TRO_PHIEU_TH foreign key (MA_PHIEU)
      references PHIEU_THUE_PHONG (MA_PHIEU)
go

alter table PHIEU_DANG_KY_DICH_VU
   add constraint FK_PHIEU_DA_DANG_KY_D_PHIEU_TH foreign key (MA_PHIEU)
      references PHIEU_THUE_PHONG (MA_PHIEU)
go

alter table PHIEU_DANG_KY_DICH_VU
   add constraint FK_PHIEU_DA_DANG_KY_D_DICH_VU foreign key (MA_DICH_VU)
      references DICH_VU (MA_DICH_VU)
go

alter table PHIEU_DAT_PHONG
   add constraint FK_PHIEU_DA_PHIEU_DAT_KHACH_HA foreign key (MA_KHACH_HANG)
      references KHACH_HANG (MA_KHACH_HANG)
go

alter table PHIEU_DAT_PHONG
   add constraint FK_PHIEU_DA_PHIEU_DAT_DOAN_KHA foreign key (MA_DOAN_KHACH)
      references DOAN_KHACH (MA_DOAN_KHACH)
go

alter table PHIEU_THUE_PHONG
   add constraint FK_PHIEU_TH_PHIEU_THU_KHACH_HA foreign key (MA_KHACH_HANG)
      references KHACH_HANG (MA_KHACH_HANG)
go

alter table PHIEU_THUE_PHONG
   add constraint FK_PHIEU_TH_PHIEU_THU_DOAN_KHA foreign key (MA_DOAN_KHACH)
      references DOAN_KHACH (MA_DOAN_KHACH)
go

alter table PHIEU_THUE_PHONG
   add constraint FK_PHIEU_TH_THUE_PHON_PHONG foreign key (MA_PHONG)
      references PHONG (MA_PHONG)
go

alter table PHIEU_THU_DOAN_KHACH
   add constraint FK_PHIEU_TH_THU_DOAN__DOAN_KHA foreign key (MA_DOAN_KHACH)
      references DOAN_KHACH (MA_DOAN_KHACH)
go

alter table PHIEU_THU_DOAN_KHACH
   add constraint FK_PHIEU_TH_THU_DOAN__CA_TRUC foreign key (MA_CA_TRUC)
      references CA_TRUC (MA_CA_TRUC)
go

alter table PHIEU_THU_KHACH_HANG
   add constraint FK_PHIEU_TH_THU_KHACH_CA_TRUC foreign key (MA_CA_TRUC)
      references CA_TRUC (MA_CA_TRUC)
go

alter table PHIEU_THU_KHACH_HANG
   add constraint FK_PHIEU_TH_THU_KHACH_KHACH_HA foreign key (MA_KHACH_HANG)
      references KHACH_HANG (MA_KHACH_HANG)
go

alter table PHONG
   add constraint FK_PHONG_PHONG_THU_LOAI_PHO foreign key (MA_LOAI_PHONG)
      references LOAI_PHONG (MA_LOAI_PHONG)
go

alter table PHONG
   add constraint FK_PHONG_TRONG_TIN_TINH_TRA foreign key (MA_TINH_TRANG)
      references TINH_TRANG (MA_TINH_TRANG)
go

alter table QUYEN_ADMIN
   add constraint FK_QUYEN_AD_REFERENCE_ADMINS foreign key (MA_ADMIN)
      references ADMINS (MA_ADMIN)
go

alter table QUYEN_ADMIN
   add constraint FK_QUYEN_AD_REFERENCE_QUYEN foreign key (MA_QUYEN)
      references QUYEN (MA_QUYEN)
go

alter table QUYEN_THU_NGAN
   add constraint FK_QUYEN_TH_REFERENCE_THU_NGAN foreign key (MA_THU_NGAN)
      references THU_NGAN (MA_THU_NGAN)
go

alter table QUYEN_THU_NGAN
   add constraint FK_QUYEN_TH_REFERENCE_QUYEN foreign key (MA_QUYEN)
      references QUYEN (MA_QUYEN)
go

alter table TIEN_NGHI_LOAI_PHONG
   add constraint FK_TIEN_NGH_TNLP_LOAI_PHO foreign key (MA_LOAI_PHONG)
      references LOAI_PHONG (MA_LOAI_PHONG)
go

alter table TIEN_NGHI_LOAI_PHONG
   add constraint FK_TIEN_NGH_TNLP_TIEN_NGH foreign key (MA_TIEN_NGHI)
      references TIEN_NGHI (MA_TIEN_NGHI)
go

