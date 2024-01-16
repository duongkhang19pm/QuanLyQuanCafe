CREATE DATABASE QuanLyQuanCafe
GO
USE QuanLyQuanCafe
GO
-- Food (món ?n)
-- Table (Bàn)
-- FoodCategory (Danh m?c)
-- Account (
-- Bill
-- BillInfo 

CREATE TABLE BanAn 
(
	Id INT IDENTITY PRIMARY KEY,
	TenBan NVARCHAR(100) NOT NULL DEFAULT N'Bàn ch?a có tên',
	TrangThai NVARCHAR(100) NOT NULL DEFAULT N'Trong'	-- Tr?ng || Có ng??i
)
GO
CREATE TABLE taikhoan 
(
	Id INT IDENTITY PRIMARY KEY,
	TenDangNhap NVARCHAR(100),	
	TenHienThi NVARCHAR(100) NOT NULL DEFAULT N'ch?a Có Tên',
	MatKhau NVARCHAR(1000) NOT NULL DEFAULT 0,
	Quyen INT NOT NULL  DEFAULT 0 -- 1: admin && 0: staff
)
GO
CREATE TABLE DanhMuc
(
	Id INT IDENTITY PRIMARY KEY,
	TenDanhMuc NVARCHAR(100) NOT NULL DEFAULT N'ch?a có tên',
)
GO
CREATE TABLE MonAn
(
	Id INT IDENTITY PRIMARY KEY,
	TenMonAn NVARCHAR(100) NOT NULL DEFAULT N'ch?a có tên',
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
	TrangThai INT NOT NULL DEFAULT 0 -- 1: ?ã thanh toán && 0: ch?a thanh toán
	
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
Declare @i int = 1
while @i <= 10
begin 
	insert dbo.BanAn (TenBan) Values (N'Bàn ' + CAST(@i as nvarchar(100)))
	set @i = @i +1 
end
 
select * from dbo.BanAn 
go
Create Proc USP_GetBanAnList
as select * from dbo.BanAn
go

exec dbo.USP_GetBanAnList
DELETE  from BanAn 
update dbo.BanAn set TrangThai = N'Tr?ng' where TrangThai = N'Tr?ng'
update dbo.BanAn set TrangThai = N'Có ng??i' where id = 25
-- them bill

select * from dbo.HOADON 
Insert dbo.HOADON(ThoiGianVao,ThoiGianRa,IdBanan,TrangThai)values(GETDATE(),null,25,0)
Insert dbo.HOADON(ThoiGianVao,ThoiGianRa,IdBanan,TrangThai)values(GETDATE(),GETDATE(),28,1)
Insert dbo.HOADON(ThoiGianVao,ThoiGianRa,IdBanan,TrangThai)values(GETDATE(),GETDATE(),23,1)
-- them chi tiet bill

Insert dbo.ChiTietHoaDon(IdHoaDon,IdMonAn,SoLuong)values(2,1,4)
Insert dbo.ChiTietHoaDon(IdHoaDon,IdMonAn,SoLuong)values(2,2,1)
Insert dbo.ChiTietHoaDon(IdHoaDon,IdMonAn,SoLuong)values(2,4,2)
Insert dbo.ChiTietHoaDon(IdHoaDon,IdMonAn,SoLuong)values(3,1,4)
Insert dbo.ChiTietHoaDon(IdHoaDon,IdMonAn,SoLuong)values(4,2,4)
select * from dbo.ChiTietHoaDon 

Select * from dbo.HoaDon where IdBanan = 28 and trangthai = 1
Select * from dbo.ChiTietHoaDon where IdHoaDon = 2

Select mon.TenMonAn, ct.SoLuong , mon.Gia ,mon.Gia * ct.SoLuong as thanhtien  from dbo.ChiTietHoaDon as ct, dbo.HoaDon as hd,  dbo.MonAn as mon 
where ct.IdHoaDon = hd.Id and ct.IdMonAn = mon.Id and hd.IdBanan = 25