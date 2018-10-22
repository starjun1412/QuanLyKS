create database QLKSdemo
go
use QLKSdemo
go
set dateformat dmy
go
create table KHACHHANG
(
	MAKH nvarchar(50) not null,
	TENKH nvarchar(50) not null,
	DIACHI nvarchar(50),
	SDT nvarchar(50) not null,
	CMND nvarchar(50),
	GIOITINH nvarchar(50),
	NGAYDAT datetime,
	NGAYTRA datetime,
	NGAYSINH datetime,
	CHECKIN nvarchar(50)
	primary key (MAKH)
)
go
create table NHANVIEN1
(
	MANV nvarchar(50) not null,
	TENNV nvarchar(50) not null,
	CHUCVU nvarchar(50), 
	SDT nvarchar(50) not null,
	CMND nvarchar(50),
	GIOITINH nvarchar(50),
	NGAYSINH datetime
	primary key (MANV)
)
go
create table TAIKHOAN
(
	TENDN nvarchar(50),
	MATKHAU nvarchar(50)
	primary key (TENDN)
)

go
insert into KHACHHANG (MAKH, TENKH, DIACHI, SDT, CMND, GIOITINH, NGAYDAT, NGAYTRA, NGAYSINH)
values ('001','Nguyen Van Teo','lskdfj','012345689','123jhjhs','Nam','29/12/2017','30/12/2017','30/12/1998')

go
insert into NHANVIEN1 (MANV, TENNV, CHUCVU, SDT, CMND, GIOITINH, NGAYSINH)
values ('001','Mai Phuoc Loc','coder','0123459','8279skjd','Nam','20/12/2017')

go
insert into TAIKHOAN (TENDN, MATKHAU)
values ('admin', '123')


select * from KHACHHANG where CHECKIN like N'%NO'