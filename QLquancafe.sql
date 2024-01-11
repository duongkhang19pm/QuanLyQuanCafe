CREATE DATABASE QuanLyQuanCafe
GO
USE QuanLyQuanCafe
GO
-- Food (m�n ?n)
-- Table (B�n)
-- FoodCategory (Danh m?c)
-- Account (
-- Bill
-- BillInfo 

CREATE TABLE BanAn 
(
	Id INT IDENTITY PRIMARY KEY,
	TenBan NVARCHAR(100) NOT NULL DEFAULT N'B�n ch?a c� t�n',
	TrangThai NVARCHAR(100) NOT NULL DEFAULT N'Tr?ng'	-- Tr?ng || C� ng??i
)
GO
CREATE TABLE taikhoan 
(
	Id INT IDENTITY PRIMARY KEY,
	TenDangNhap NVARCHAR(100),	
	TenHienThi NVARCHAR(100) NOT NULL DEFAULT N'Ch?a C� T�n',
	MatKhau NVARCHAR(1000) NOT NULL DEFAULT 0,
	Quyen INT NOT NULL  DEFAULT 0 -- 1: admin && 0: staff
)
GO
CREATE TABLE DanhMuc
(
	Id INT IDENTITY PRIMARY KEY,
	TenDanhMuc NVARCHAR(100) NOT NULL DEFAULT N'Ch?a c� t�n',
)
GO
CREATE TABLE MonAn
(
	Id INT IDENTITY PRIMARY KEY,
	TenMonAn NVARCHAR(100) NOT NULL DEFAULT N'Ch?a c� t�n',
	IdDanhMuc INT NOT NULL,
	Gia FLOAT NOT NULL DEFAULT 0
	
	FOREIGN KEY (IdDanhMuc) REFERENCES dbo.DanhMuc(Id)

)
GO
CREATE TABLE HOADON 
(
	Id INT IDENTITY PRIMARY KEY,
	ThoiGianVao DATE,
	ThoiGianRa Date,
	IdBanan INT NOT NULL,
	TrangThai INT NOT NULL DEFAULT 0 -- 1: ?� thanh to�n && 0: ch?a thanh to�n
	
	FOREIGN KEY (IdBanan) REFERENCES dbo.BanAn(Id)
)
GO
CREATE TABLE ChiTietHoaDon
(
	Id INT IDENTITY PRIMARY KEY,
	IdHoaDon INT NOT NULL,
	IdMonAn INT NOT NULL,
	SoLuong INT NOT NULL DEFAULT 0
	
	FOREIGN KEY (IdHoaDon) REFERENCES dbo.HoaDon(Id),
	FOREIGN KEY (IdMonAn) REFERENCES dbo.MonAn(Id)
)
GO