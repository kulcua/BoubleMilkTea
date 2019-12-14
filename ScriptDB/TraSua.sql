create database  TraSua
use TraSua
set dateformat mdy
create table NHANVIEN
(
	MANV int identity primary key,
	TENNV nvarchar(50),
	CHUCVU nvarchar(50),
	TENDN varchar(100),
)

create table HOADON
(
	MAHOADON int identity primary key,
	MANV int,
	TENKH varchar(100),
	TGBD datetime,
	TONGTIEN INT,
)
CREATE TABLE CTHD
(
	MACTHD INT IDENTITY PRIMARY KEY,
	MATHUCUONG INT,
	MATOPPING INT,
	MAKM INT,
	MAHOADON INT,
	DUONG INT,
	DA INT,
	GHICHU VARCHAR(100)
)
CREATE TABLE THUCUONG
(
	MATHUCUONG INT IDENTITY PRIMARY KEY,
	TENTHUCUONG NVARCHAR(50),
	GIATHUCUONG FLOAT,
)

CREATE TABLE TOPPING
(
	MATOPPING INT IDENTITY PRIMARY KEY,
	TENTOPPONG NVARCHAR(50),
	GIATOPPING FLOAT,
)

CREATE TABLE KHUYENMAI
(
	MAKM INT IDENTITY PRIMARY KEY,
	TENKM NVARCHAR(50),
	TGBD DATETIME,
	TGKT DATETIME,
	MUCGIAMGIA INT,
)

-- thêm khóa ngoại manv cho bảng hóa đơn
 alter table hoadon add CONSTRAINT FK_nhanvien
 FOREIGN KEY (manv) REFERENCES nhanvien(manv) on update cascade

 -- thêm các khóa ngoại cho bảng chi tiết hóa đơn
  alter table cthd add CONSTRAINT FK_hoadon
 FOREIGN KEY (mahoadon) REFERENCES hoadon(mahoadon) on update cascade

  alter table cthd add CONSTRAINT FK_thucuong
 FOREIGN KEY (mathucuong) REFERENCES thucuong(mathucuong) on update cascade

  alter table cthd add CONSTRAINT FK_topping
 FOREIGN KEY (matopping) REFERENCES topping(matopping) on update cascade

  alter table cthd add CONSTRAINT FK_khuyenmai
 FOREIGN KEY (makm) REFERENCES khuyenmai(makm) on update cascade

 -- thay đổi tổng tiền từ hóa đơn sang chi tiết hóa đơn 
