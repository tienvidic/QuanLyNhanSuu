create database QuanLyNhanSu
go
use QuanLyNhanSu

go
create table ChucVu(
MaChucVu VARCHAR(10) primary key,
TenChucVu nvarchar(50))

go
create table Luong(
BacLuong VARCHAR(10) primary key,
LuongCoBan INT ,
HeSoLuong int,
HeSoPhuCap int)
GO
create table PhongBan(
MaPB VARCHAR(10) primary key,
TenPB nvarchar(50),
MaTP VARCHAR(10),
DiaChi nvarchar(50),
SDT char(15))

go
create table TrinhDoHocVan(
MaTDHV VARCHAR(10) primary key,
TenTrinhDo nvarchar(50),
ChuyenNganh nvarchar(50))

go
create table NhanVien(
MaNV varchar(10) primary key,
HoTen nvarchar(50),
DanToc nvarchar(50),
GioiTinh NVARCHAR(5) CHECK(GioiTinh IN (N'Nam',N'Nữ')),
SDT CHAR(15),
QueQuan nvarchar(50),
NgaySinh date,
MaTDHV VARCHAR(10) REFERENCES TrinhDoHocVan(MaTDHV),
MaPB VARCHAR(10) references PhongBan(MaPB),
BacLuong VARCHAR(10) references Luong(BacLuong)
)

GO
CREATE TABLE ThoiGianCongTac(
MaNV VARCHAR(10) REFERENCES NhanVien(MaNV),
MaCV VARCHAR(10) REFERENCES ChucVu(MaChucVu),
NgayNhanChuc DATE,
PRIMARY KEY (MaNV,MaCV))

GO
CREATE TABLE NguoiDung
(
	TaiKhoan NVARCHAR(30),
	MatKhau NVARCHAR(30)
)

GO
INSERT dbo.NguoiDung
        ( TaiKhoan, MatKhau )
VALUES  ( N'admin', -- TaiKhoan - nvarchar(30)
          N'admin'  -- MatKhau - nvarchar(30)
          )
INSERT dbo.NguoiDung
        ( TaiKhoan, MatKhau )
VALUES  ( N'user1', -- TaiKhoan - nvarchar(30)
          N'1'  -- MatKhau - nvarchar(30)
          )

go
insert into NhanVien(MaNV,HoTen,DanToc,GioiTinh,SDT,QueQuan,NgaySinh)
values ('NV01',N'Hoàng Thị Minh',N'kinh',N'Nữ','0976986543',N'Hà Nội','09-08-1990')
insert into NhanVien(MaNV,HoTen,DanToc,GioiTinh,SDT,QueQuan,NgaySinh)
values ('NV02',N'Nguyễn Quang Huy','kinh',N'Nam','0973686583',N'Vĩnh Phúc','10-19-1990')
insert into NhanVien(MaNV,HoTen,DanToc,GioiTinh,SDT,QueQuan,NgaySinh)
values ('NV03',N'Ngô Hữu Huy','kinh',N'Nam','0976639201',N'Hà Nam','03-20-1993')
insert into NhanVien(MaNV,HoTen,DanToc,GioiTinh,SDT,QueQuan,NgaySinh)
values ('NV04',N'Bùi Trung Kiên','kinh',N'Nữ','0976863496',N'Hà Nội','12-08-1992')
insert into NhanVien(MaNV,HoTen,DanToc,GioiTinh,SDT,QueQuan,NgaySinh)
values ('NV05',N'Nguyễn Thị Ngọc','kinh',N'Nam','01647386289',N'Phú Thọ','02-08-1991')
insert into NhanVien(MaNV,HoTen,DanToc,GioiTinh,SDT,QueQuan,NgaySinh)
values ('NV06',N'Lê Bá Lộc','kinh',N'Nam','0976963984',N'Ha Noi','01-08-1995')

INSERT dbo.ThoiGianCongTac
        ( MaNV, MaCV, NgayNhanChuc )
VALUES  ( 'NV01','CV01','09/06/2013')
INSERT dbo.ThoiGianCongTac
        ( MaNV, MaCV, NgayNhanChuc )
VALUES  ( 'NV02','CV05','02/21/2014')
INSERT dbo.ThoiGianCongTac
        ( MaNV, MaCV, NgayNhanChuc )
VALUES  ( 'NV03','CV06','11/19/2012')
INSERT dbo.ThoiGianCongTac
        ( MaNV, MaCV, NgayNhanChuc )
VALUES  ( 'NV04','CV02','05/11/2016')
INSERT dbo.ThoiGianCongTac
        ( MaNV, MaCV, NgayNhanChuc )
VALUES  ( 'NV05','CV03','07/28/2015')
INSERT dbo.ThoiGianCongTac
        ( MaNV, MaCV, NgayNhanChuc )
VALUES  ( 'NV06','CV04','04/20/2013')

INSERT INTO dbo.TrinhDoHocVan
        ( MaTDHV, TenTrinhDo, ChuyenNganh )
VALUES  ( 'TD01', -- MaTDHV - varchar(10)
          N'Đại Học ', -- TenTrinhDo - nvarchar(50)
          N'CNTT')
INSERT INTO dbo.ChucVu
        ( MaChucVu, TenChucVu )
VALUES  ('CV01',N'Giám Đốc')
INSERT dbo.ChucVu
        ( MaChucVu, TenChucVu )
VALUES  ('CV02',N'Trường Phòng')
INSERT dbo.ChucVu
        ( MaChucVu, TenChucVu )
VALUES  ('CV03',N'Phó Giám Đốc')
INSERT dbo.ChucVu
        ( MaChucVu, TenChucVu )
VALUES  ('CV04',N'Phó Phòng')
INSERT dbo.ChucVu
        ( MaChucVu, TenChucVu )
VALUES  ('CV05',N'Trường Nhóm')
INSERT dbo.ChucVu
        ( MaChucVu, TenChucVu )
VALUES  ('CV06',N'Phó Nhóm')
INSERT dbo.ChucVu
        ( MaChucVu, TenChucVu )
VALUES  ('CV07',N'Nhân Viên')
INSERT dbo.ChucVu
        ( MaChucVu, TenChucVu )
VALUES  ('CV08',N'Thư Ký')

GO
CREATE PROC SP_DangKi(@taikhoan NVARCHAR(30),@matkhau NVARCHAR(30))
AS
BEGIN
INSERT dbo.NguoiDung
        ( TaiKhoan, MatKhau )
VALUES  ( @taikhoan, -- TaiKhoan - nvarchar(30)
          @matkhau  -- MatKhau - nvarchar(30)
          )
END

GO
INSERT INTO dbo.PhongBan 
        ( MaPB, TenPB, DiaChi, SDT, MaTP )
VALUES  ( 'PB01', -- MaPB - varchar(10)
          N'Hành Chính', -- TenPB - nvarchar(50)
          N'hà Nội', -- DiaChi - nvarchar(50)
          '111111111111111', -- SDT - char(15)
          'NV01'  -- MaTP - varchar(10)
          )


-- 2/4: Sửa CSDL bảng Nhân Viên: trường Giới Tính
ALTER TABLE dbo.NhanVien 
ALTER COLUMN GioiTinh NVARCHAR(5)

--Thêm Phòng Ban
create PROC Them_PB (@MaPb varchar(10), @TenPB nvarchar(30), @MaTP varchar(10),@DiaChi Nvarchar(30), @Sdt Char(11))
AS
BEGIN
	INSERT INTO dbo.PhongBan( MaPB, TenPB,MaTP, DiaChi, SDT )
	VALUES  (@MaPb,@TenPB,@MaTP,@DiaChi,@Sdt )
END

GO
--Sửa Phòng ban
create PROC Sua_PB (@MaPb varchar(10), @TenPB nvarchar(30), @MaTP varchar(10),@DiaChi Nvarchar(30), @Sdt Char(11))
AS
BEGIN
	UPDATE dbo.PhongBan
	SET TenPB = @TenPB,MaTP = @MaTP,DiaChi = @DiaChi,SDT=@Sdt
	WHERE MaPB = @MaPb
END

GO 
--xóa Phòng Ban
create PROC Xoa_PB (@Ma varchar(10))
AS
BEGIN
		DELETE dbo.PhongBan WHERE MaPB = @Ma
END

GO
--Hiển Thị dữ liệu
ALTER PROC PB_SelectAll 
AS
BEGIN
		SELECT dbo.PhongBan.MaPB,TenPB,MaTP,DiaChi,dbo.PhongBan.SDT,COUNT(MaNV) AS SoLuong FROM dbo.PhongBan, dbo.NhanVien
		WHERE NhanVien.MaPB = PhongBan.MaPB
		GROUP BY  dbo.PhongBan.MaPB,TenPB,MaTP,DiaChi,dbo.PhongBan.SDT
END

GO
create PROC PB_Select 
AS
BEGIN
		SELECT * FROM dbo.PhongBan 
END

GO
---- Thanh----Luong
create PROC SP_ThemLuong (@BacLuong VARCHAR(10), @LuongCoBan INT , @HeSoLuong INT , @HeSoPhuCap INT )
AS
BEGIN
	INSERT dbo.Luong( BacLuong ,LuongCoBan ,HeSoLuong ,HeSoPhuCap)
	VALUES  (@BacLuong, @LuongCoBan, @HeSoLuong, @HeSoPhuCap)
END 
GO 
EXEC SP_ThemLuong '1','6000000','1','1'

GO
create PROC SP_SuaLuong (@BacLuong VARCHAR(10), @LuongCoBan INT , @HeSoLuong INT , @HeSoPhuCap INT )
AS
BEGIN
	UPDATE dbo.Luong SET LuongCoBan = @LuongCoBan, HeSoLuong = @HeSoLuong, HeSoPhuCap = @HeSoPhuCap
	WHERE BacLuong = @BacLuong
END
GO 
EXEC SP_SuaLuong '1','6500000','1','1'

GO
create PROC SP_XoaLuong(@BacLuong VARCHAR(10))
AS
BEGIN
	DELETE dbo.Luong WHERE BacLuong = @BacLuong
END 

GO
create PROC SP_Luong_SelectAll 
AS
BEGIN
		SELECT * FROM dbo.Luong
END

GO
create PROC SP_Luong_SelectByID (@BacLuong VARCHAR(10) )
AS
BEGIN
		SELECT * FROM dbo.Luong WHERE BacLuong = @BacLuong
END
GO
--Dương - thu tuc dang nhap
create PROC DangNhap(@TaiKhoan NCHAR(50),@MatKhau NCHAR(50))
AS
BEGIN
SELECT * FROM dbo.NguoiDung WHERE TaiKhoan=@TaiKhoan AND MatKhau=@MatKhau
END
GO

CREATE PROC SP_TDHV_SelectAll
AS
BEGIN
SELECT * FROM dbo.TrinhDoHocVan
END
GO
CREATE PROC SP_TDHV_SelectByID (@MaTDHV INT )
AS
BEGIN
		SELECT * FROM dbo.TrinhDoHocVan WHERE MaTDHV = @MaTDHV
END
GO

CREATE PROC SP_Them_TDHV (@MaTDHV VARCHAR(10),@TenTDHV NVARCHAR(50),@ChuyenNganh NVARCHAR(50))
AS
BEGIN
	INSERT dbo.TrinhDoHocVan
	VALUES  ( @MaTDHV, @TenTDHV,@ChuyenNganh)
END

GO
CREATE PROC SP_Sua_TDHV (@MaTDHV VARCHAR(10),@TenTDHV NVARCHAR(50),@ChuyenNganh NVARCHAR(50))
AS
BEGIN
	UPDATE dbo.TrinhDoHocVan
	SET TenTrinhDo =@TenTDHV,ChuyenNganh=@ChuyenNganh
	WHERE MaTDHV=@MaTDHV
END

GO 
CREATE PROC SP_Xoa_TDHV (@MaTDHV varchar(10))
AS
BEGIN
		DELETE dbo.TrinhDoHocVan WHERE MaTDHV = @MaTDHV
END

GO

-- Hiện ra danh sách Nhân Viên
GO
ALTER PROC NV_SelectAll 
AS
BEGIN
	SELECT dbo.NhanVien.MaNV,HoTen,DanToc,GioiTinh,NhanVien.SDT,QueQuan,NgaySinh,TenTrinhDo,TenPB,TienLuong=(LuongCoBan + LuongCoBan*HeSoLuong +HeSoLuong*100000),TenChucVu 
	FROM dbo.NhanVien, dbo.PhongBan,dbo.TrinhDoHocVan,dbo.Luong,dbo.ChucVu,dbo.ThoiGianCongTac
	WHERE  PhongBan.MaPB = NhanVien.MaPB   
	AND  Luong.BacLuong = NhanVien.BacLuong  
	AND  TrinhDoHocVan.MaTDHV = NhanVien.MaTDHV
	AND MaChucVu = MaCV AND NhanVien.MaNV = ThoiGianCongTac.MaNV
 END

go
EXEC dbo.NV_SelectAll

--
GO
create PROC NV_SelectByID (@MaNV varchar(10))
AS
BEGIN
		SELECT * FROM dbo.NhanVien WHERE MaNV = @MaNV
END

GO
EXEC dbo.NV_SelectByID @MaNV = 'nv01' -- varchar(10)

-- Thêm Nhân Viên

GO
create PROC ThemNV(@MaNV VARCHAR(10), @HoTen NVARCHAR(50), @DanToc NVARCHAR(50), @GioiTinh NVARCHAR(5), @SDT CHAR(15), @QueQuan NVARCHAR(50), @NgaySinh DATE, @MaTDHV VARCHAR(10), @MaPB NVARCHAR(50), @BacLuong VARCHAR(10))
AS
BEGIN
INSERT INTO dbo.NhanVien( MaNV , HoTen ,DanToc ,GioiTinh ,SDT ,QueQuan ,NgaySinh ,MaTDHV ,MaPB ,BacLuong)
VALUES  ( @MaNV,@HoTen,@DanToc,@GioiTinh,@SDT,@QueQuan,@NgaySinh,@MaTDHV,@MaPB,@BacLuong)
END


-- Sửa Nhân Viên
GO
create PROC SuaNV(@MaNV VARCHAR(10), @HoTen NVARCHAR(50), @DanToc NVARCHAR(50), @GioiTinh NVARCHAR(5), @SDT CHAR(15), @QueQuan NVARCHAR(50), @NgaySinh DATE, @MaTDHV VARCHAR(10), @MaPB VARCHAR(10), @BacLuong VARCHAR(10))
AS
BEGIN
UPDATE dbo.NhanVien
SET HoTen=@HoTen,DanToc=@DanToc,GioiTinh=@GioiTinh,SDT=@SDT,QueQuan=@QueQuan,NgaySinh=@NgaySinh,MaTDHV=@MaTDHV,MaPB=@MaPB,BacLuong=@BacLuong
WHERE MaNV=@MaNV
END

-- Xóa Nhân Viên
GO
create PROC XoaNV(@MaNV VARCHAR(10))
AS
BEGIN
DELETE dbo.NhanVien
WHERE MaNV=@MaNV
END


--Cường---
--Thủ tục thời gian công tác--
GO

create PROC SPTGCTSELECTAll1
AS
BEGIN
SELECT MaNV,TenChucVu,NgayNhanChuc FROM dbo.ThoiGianCongTac,dbo.ChucVu
END
GO
CREATE PROC SPTGCTSELECT
AS
BEGIN
		SELECT * FROM dbo.ThoiGianCongTac 
END
GO

CREATE PROC SPTHEMTGCT (@manv VARCHAR(10),@macv VARCHAR(10),@ngaynhanchuc DATE)
AS
BEGIN
	INSERT dbo.ThoiGianCongTac
	        ( MaNV, MaCV, NgayNhanChuc )
	VALUES  ( @manv,@macv,@ngaynhanchuc)
	
END

GO
CREATE PROC SPSUATGCT (@manv VARCHAR(10),@macv VARCHAR(10),@ngaynhanchuc DATE)
AS
BEGIN
	UPDATE dbo.ThoiGianCongTac
	SET MaCV=@macv,NgayNhanChuc=@ngaynhanchuc
	WHERE MaNV=@manv
END

GO 
CREATE PROC SPXOATGCT (@manv varchar(10))
AS
BEGIN
		DELETE dbo.ThoiGianCongTac WHERE MaNV=@manv
END

GO

--Thủ tục chức vụ--
CREATE PROC SPCVSELECTAll
AS
BEGIN
SELECT * FROM dbo.ChucVu
END
GO
CREATE PROC SPCVSELECTBYID (@machucvu VARCHAR(10) )
AS
BEGIN
		SELECT * FROM dbo.ChucVu WHERE MaChucVu = @machucvu
END
GO

CREATE PROC SPTHEMCV (@machucvu VARCHAR(10),@tenchucvu NVARCHAR(50))
AS
BEGIN
	INSERT dbo.ChucVu
	        ( MaChucVu, TenChucVu )
	VALUES  ( @machucvu,@tenchucvu)
	
END

GO
CREATE PROC SPSUACV (@machucvu VARCHAR(10),@tenchucvu NVARCHAR(50))
AS
BEGIN
	UPDATE dbo.ChucVu
	SET TenChucVu=@tenchucvu
	WHERE MaChucVu=@machucvu
END

GO 
CREATE PROC SPXOACV (@machucvu varchar(10))
AS
BEGIN
		DELETE dbo.ChucVu WHERE MaChucVu=@machucvu
END

GO
