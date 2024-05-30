-- tao csdl 
CREATE DATABASE DoAnQuanLiChuoiCuaHangHighLandCoffee
GO
-- kich hoat csdl
USE DoAnQuanLiChuoiCuaHangHighLandCoffee
GO
--Table data
CREATE TABLE BAN(
	MaBan char(10) Primary key, 
	TenBan nvarchar(50) NULL,
	MaKhuVuc char(10) NULL,)

GO
CREATE TABLE CA(
	MaCa char(10) Primary key,
	TenCa nvarchar(50) NULL,
	MaKhuVuc char(10) NULL,
	MaNV char(10) NULL,
	SoTien int NULL,
	Ngay date NULL,)


GO
CREATE TABLE HANGHOA(
	MaHangHoa char(10) Primary key,
	TenHangHoa nvarchar(50) NULL,
	MaNCC char(10) NULL,
	Gia decimal(18, 0) NULL,
	DonVi nvarchar(10) NULL,)

GO
CREATE TABLE HOADON(
	MaHD char(10) Primary key,
	MaKH char(10) NOT NULL,
	TenKH nvarchar(50) NULL,
	DiaChi nvarchar(50) NULL,
	DienThoai nvarchar(10) NULL,
	MaNV char(10) NOT NULL,
	TenNV nvarchar(50) NULL,
	NgayThanhToan datetime NULL,
	ThanhTien decimal(18, 0) NULL,)

GO
CREATE TABLE KHACHHANG(
	MaKH char(10) Primary key,
	TenKH nvarchar(50) NULL,
	DiaChi nvarchar(50) NULL,
	SDT nvarchar(10) NULL,
	Email nvarchar(50) NULL,
	MaLKH char(10) NULL,)

GO
CREATE TABLE KHO(
	MaKho char(10) Primary key,
	TenKho nvarchar(50) NULL,)

GO
CREATE TABLE KHUVUC(
	MaKhuVuc char(10) Primary key,
	TenKhuVuc nvarchar(50) NULL,)

GO
CREATE TABLE KHUYENMAI(
	MaKM char(10) Primary key,
	TenKM nvarchar(50) NULL,
	NgayBD date NULL,
	NgayKT date NULL,
	NoiDung nvarchar(50) NULL,
	GiaTri int NULL,)

GO
CREATE TABLE LOAIKHACHHANG(
	MaLKH char(10) Primary key,
	TenLKH nvarchar(50) NULL,)

GO
CREATE TABLE LUONG(
	MaNV char(10) Primary key,
	TenNV nvarchar(50) NULL,
	SoCa int NULL,
	TongTien int NULL,
	NgayNhan datetime NULL,

)
GO
CREATE TABLE NHACUNGCAP(
	MaNCC char(10) Primary key,
	TenNCC nvarchar(50) NULL,
	DiaChi nvarchar(50) NULL,
	SDT nvarchar(10) NULL,
	Email nvarchar(50) NULL,
	LoaiHang_NCC nvarchar(250) NOT NULL,)

GO
CREATE TABLE NHANVIEN(
	MaNV char(10) Primary key,
	TenNV nvarchar(50) NULL,
	GioiTinh nvarchar(3)NULL,
	DiaChi nvarchar(50) NULL,
	SDT nvarchar(10) NULL,
	Email nvarchar(50) NULL,
	TenDangNhap nvarchar(50) NULL,
	MatKhau nvarchar(50) NULL,
	MaQuyen nvarchar(10) NULL,)

GO
CREATE TABLE PHIEUNHAP(
	MaPN char(10) Primary key,
	NgayNhap date NULL,
	MaNV char(10) NULL,
	MaNCC char(10) NULL,
	TongTien int NULL,)

GO
CREATE TABLE PHIEUXUAT(
	MaPX char(10) Primary key,
	NgayXuat date NULL,
	MaNV char(10) NULL,
	MaKH char(10) NULL,
	TongTien int NULL,)

GO
CREATE TABLE MENU(
	MaThucDon char(10) Primary key,
	TenThucDon nvarchar(50) NULL,
	Gia decimal(18, 0) NULL,)



GO
CREATE TABLE LoginAdmin(
    ID char(10),
    userNameID nchar(20) NOT NULL,
	passWordID nChar(20) NOT NULL,
	MaQuyen int Null)


GO
CREATE TABLE LoginUser(
    ID char(10),
    userNameID nchar(20) NOT NULL,
	passWordID nChar(20) NOT NULL,
	MaQuyen int Null)

GO
CREATE TABLE ODER(
	ThucUong nvarchar(30) Not Null PRIMARY KEY,
	MaHD char(10) NULL,
	SoLuong int NULL,
	GiaTien int NULL,
	);

GO
CREATE TABLE QUANLICA
(MaCa char(10) primary key,
 MaNV char(10) NULL,
 TenNV nvarchar(30)NULL,
 Ngay date NULL,
 CaLam nvarchar(20) NULL,
 TenCa nvarchar(30) NULL);


-- Foreign Key Constraints
GO
Alter table CA
add constraint FK_Ca_NV
Foreign Key (MaNV)
References NHANVIEN(MaNV);

Alter table BAN
add constraint FK_BAN_KHUVUC
Foreign Key (MaKhuVuc)
References KHUVUC(MaKhuVuc);

Alter table CA
add constraint FK_Ca_KHUVUC
Foreign Key (MaKhuVuc)
References KhuVuc(MaKhuVuc);

Alter table HOADON
add constraint FK_HOADON_MaKH
Foreign Key (MaKH)
References KHACHHANG(MaKH);

Alter table HOADON
add constraint FK_HOADON_MaNV
Foreign Key (MaNV)
References NHANVIEN(MaNV);

Alter table KHACHHANG
add constraint FK_KHACHHANG_MaLKH
Foreign Key (MaLKH)
References LOAIKHACHHANG(MaLKH);

Alter table LUONG
add constraint FK_LUONG_MaNV
Foreign Key (MaNV)
References NHANVIEN(MaNV);

Alter table PHIEUNHAP
add constraint FK_PHIEUNHAP_MaNV
Foreign Key (MaNV)
References NHANVIEN(MaNV);

Alter table PHIEUNHAP
add constraint FK_PHIEUNHAP_MaNCC
Foreign Key (MaNCC)
References NHACUNGCAP(MaNCC);

Alter table PHIEUXUAT
add constraint FK_PHIEUXUAT_MaNV
Foreign Key (MaNV)
References NHANVIEN(MaNV);

Alter table PHIEUXUAT
add constraint FK_PHIEUXUAT_MaKH
Foreign Key (MaKH)
References KHACHHANG(MaKH);

Alter table ODER
add constraint FK_ODER_MaHD
Foreign Key (MaHD)
References HOADON(MaHD);

set dateformat dmy
-- thêm d? li?u


--insert Them Login
GO
INSERT INTO LoginAdmin
(ID,userNameID,passWordID,MaQuyen) Values
('001','admin','admin',0),
('002','admin1','admin1',0);
GO
INSERT INTO LoginUser
(ID,userNameID,passWordID,MaQuyen) Values
('003','User','User',1),
('004','User1','User1',1);



--insert CaLamViec
GO
INSERT INTO QUANLICA
(MaCa,MaNV,TenNV,Ngay,CaLam,TenCa) VALUES
('CA01','NV01',N'Phan Long Khánh','14/06/2000',N'FullTime',N'Ca Sáng'),
('CA02','NV02',N'Nhật Tuấn','18/09/2004',N'8h',N'Ca Tối'),
('CA03','NV03',N'Diễm Trang','17/06/2003',N'8h',N'Ca Chiều'),
('CA04','NV04',N'Long Khánh','14/06/2000',N'4h',N'Ca Tối');

--insert Khu Vuc
GO 
INSERT INTO KHUVUC
(MaKhuVuc,TenKhuVuc) VALUES
('KV01',N'Tang tret'),
('KV02',N'Lau 1'),
('KV03',N'Lau 2');

--insert Ban
GO
INSERT INTO BAN
(MaBan,TenBan,MaKhuVuc) VALUES
('B01',N'Ban 1','KV01'),
('B02',N'Ban 2','KV01'),
('B03',N'Ban 3','KV02'),
('B04',N'Ban 4','KV03');

-- insert Nhân Viên
GO
INSERT INTO NHANVIEN
(MaNV,TenNV,GioiTinh,DiaChi,SDT,Email,TenDangNhap,MatKhau,MaQuyen) VALUES
('NV01',N'Phan Long Khánh',N'Nam',N'TPHCM',N'0777855202',N'phanlongkhanh.tdc223@gmail.com','admin1','012345','0'),
('NV02',N'Nhật Tuấn',N'Nam',N'TPHCM',N'0789456123',N'nhattuan1.tdc223@gmail.com','user1','012345','1'),
('NV03',N'Đức Trung',N'Nam',N'TPHCM',N'0456123789',N'ductrung.tdc223@gmail.com','user2','012345','1'),
('NV04',N'Diễm Trang',N'Nữ',N'TPHCM',N'0783318914',N'thachdiemtrang.tdc223@gmail.com','user3','012345','1'),
('NV05',N'Minh Thái',N'Nữ',N'TPHCM',N'0783318914',N'minhthai.tdc223@gmail.com','user4','012345','1'),
('NV06',N'Hữu Nghĩa',N'Nữ',N'TPHCM',N'0782578914',N'huunghia.tdc223@gmail.com','user5','012345','1'),
('NV07',N'Mỹ Linh',N'Nữ',N'TPHCM',N'0783356914',N'mylinh.tdc223@gmail.com','user6','012345','1'),
('NV08',N'Kim Ngân',N'Nữ',N'TPHCM',N'0783458916',N'kimngan.tdc223@gmail.com','user7','012345','1'),
('NV09',N'Hoài Thương',N'Nữ',N'TPHCM',N'0783318914',N'hoaithuong.tdc223@gmail.com','user8','012345','1');

--insert ca lam viec
GO
INSERT INTO CA
(MaCa,TenCa,MaKhuVuc,MaNV,SoTien,Ngay) VALUES
('CA01', N'Ca 1', 'KV01', 'NV01', NULL, N'17/06/2023'),
('CA02', N'Ca 1', 'KV02', 'NV02', NULL, N'11/09/2023'),
('CA03', N'Ca 1', 'KV03', 'NV03', NULL, N'11/09/2023');


-- insert Thực đơn
GO
INSERT INTO MENU
(MaThucDon,TenThucDon,Gia) VALUES
('TD01',N'Cà Phê Sữa',22000),
('TD02',N'Bạc Xĩu',24000),
('TD03',N'Sữa Tươi Chân Trâu đường đen',29000),
('TD04',N'Trà Sữa Socola',29000),
('TD05',N'Trà đào Cam sã',27000),
('TD06',N'Trà Sữa Việt Quất',28000),
('TD07',N'Hồng Trà',27000),
('TD08',N'Trà Dâu',25000),
('TD09',N'Soda Dâu',23000),
('TD10',N'Trà Sữa Truyền Thống',26000);


--insert khach hang
GO 
INSERT INTO KHACHHANG
(MaKH,TenKH,DiaChi,SDT,Email,MaLKH) VALUES
('KH01',N'Hung Thang',N'Bien Hoa','0111111111',N'Thang4497@gmail.com',null),
('KH02',N'Kim Uyen',N'Dong Nai','0222222222',N'Uyen02@gmail.com',null),
('KH03',N'Thai Tuan',N'Long Phuoc','0333333333',N'Tuant324@gmail.com',null),
('KH04',N'Tran Phuoc',N'Hai Phong','0444444444',N'phuoc656@gmail.com',null);

--insert kho
GO
INSERT INTO KHO
(MaKho,TenKho) VALUES
('K01',N'kho chinh'),
('K02',N'kho phu');

--insert Luong
GO
INSERT INTO LUONG
(MaNV,TenNV,SoCa,TongTien,NgayNhan) VALUES
('NV01',N'Long Khánh',8, 1000000,'15/10/2023'),
('NV02',N'Nhật Tuấn',8, 1000000,'15/10/2023'),
('NV03',N'Đức Trung',10, 1500000,'15/10/2023');

--insert nha cung cap
GO
INSERT INTO NHACUNGCAP
(MaNCC, TenNCC, DiaChi, SDT, Email, LoaiHang_NCC) VALUES
('NCC01', N'Trung Nguyên', N'Thành pho Buôn Ma Thuot', N'0909300096', NULL, N'Cà phê'),
('NCC02', N'CoCaCoLa', N'Thành pho Ho Chí Minh', N'1900555584', NULL, N'Nuoc ngot'),
('NCC03', N'Sua tuoi', N'Thành pho Ho Chí Minh', N'0965435541', NULL, N'Nuoc ngot');

--insert hang hoa
GO
INSERT INTO HANGHOA
(MaHangHoa, TenHangHoa, MaNCC, Gia, DonVi) VALUES
('HH01', N'Cam', NULL, CAST(20000 AS Decimal(18, 0)), N'Kg'),
('HH02', N'Cà phê', N'NCC01', CAST(200000 AS Decimal(18, 0)), N'Kg'),
('HH03', N'Đào', NULL, CAST(20000 AS Decimal(18, 0)), N'Kg'); 


--insert phieu nhap, pheu xuat
GO
INSERT INTO PHIEUNHAP
(MaPN,NgayNhap,MaNV,MaNCC,TongTien) VALUES
('PN01',N'10/04/2023','NV01','NCC01',2000000),
('PN02',N'24/04/2023','NV02','NCC02',4000000),
('PN03',N'07/02/2023','NV03','NCC03',1300000);

GO
INSERT INTO PHIEUXUAT
(MaPX,NgayXuat, MaNV, MaKH, TongTien) VALUES
('PX01',N'26/09/2023' , 'NV01', 'KH01', 100000),
('PX02',N'17/10/2023' , 'NV01', 'KH03', 500000),
('PX03',N'20/08/2023' , 'NV02', 'KH02', 800000);

--insert hoa don
GO
INSERT INTO HOADON
(MaHD,MaKH,TenKH,DiaChi,DienThoai,MaNV,TenNV,NgayThanhToan,ThanhTien) VALUES
('HD01','KH01',N'Hung Thang',N'Bien Hoa','0111111111','NV02',N'Nhat Tuan','05/09/2023', NULL);

--insert oder
GO
INSERT INTO ODER
(ThucUong,MaHD,SoLuong,GiaTien) VALUES
(N'Cà Phê Sua',null,1,22000),
(N'Bac Xiu',null,1,24000),
(N'Sua Tuoii Chân Trâu duong den',null,1,29000),
(N'Trà Sua Socola',null,1,29000),
(N'Trà Dào Cam Xã',null,1,27000),
(N'Trà Sua Viet Quoc',null,1,28000),
(N'Hong Trà',null,1,27000),
(N'Soda Dâu',null,1,23000),
(N'Trà Sua Truyen Thong',null,1,26000);

-- Các PROC
--bao cao doanh thu
GO
CREATE PROC BaoCaoDoanhThu
@TuNgay DATETIME
,@DenNgay DATETIME
AS
BEGIN
	SELECT NgayVao = FORMAT(HOADON.NgayThanhToan, 'dd/MM/yyyy')
	, KHUVUC.TenKhuVuc
	,KHACHHANG.TenKH
	,NHANVIEN.TenNV
	,ODER.ThucUong
	,ODER.GiaTien
	,ODER.SoLuong
	,ThanhTien = (ODER.GiaTien * ODER.SoLuong)
	FROM  HOADON, KHUVUC, KHACHHANG, NHANVIEN, ODER	
	WHERE HOADON.NgayThanhToan BETWEEN @TuNgay AND DATEADD(DAY, 1, @DenNgay)
END

-- Tính tong thanh tien bao cao TK
GO
CREATE PROC TinhTongThanhTien
@TuNgay DATETIME
,@DenNgay DATETIME
AS
BEGIN
	SELECT SUM(ODER.GiaTien * ODER.SoLuong) AS Tong
	FROM HOADON, ODER
	WHERE HOADON.MaHD = ODER.MaHD
	AND dbo.HOADON.NgayThanhToan BETWEEN @TuNgay AND DATEADD(DAY, 1, @DenNgay)
END



--lay all hoa don
GO
CREATE PROC layAllhoadon
AS
SELECT * FROM HOADON
-- Phân Quy?n
GO
CREATE PROC PhanQuyen
@admin bit
As
begin
If @admin = 1
SELECT * FROM NHANVIEN nv , QUANLY ql
WHERE nv.TenDangNhap = ql.taikhoanql and nv.MatKhau = ql.matkhauql;
END;

-- S?a hoa ??n
GO
CREATE PROC SuaHoaDon
@MaHD NVARCHAR(10), @MaKH nvarchar(10), @TenKH nvarchar(50), @DiaChi nvarchar(50), @DienThoai nvarchar(10), @MaNV nvarchar(10), @TenNV nvarchar(10), @NgayThanhToan datetime, @ThanhTien decimal(18, 0)

AS
Begin
UPDATE dbo.HOADON SET MaHD = @MaHD, MaKH = @MaKH, TenKH = @TenKH, MaNV = @MaNV, TenNV = @TenNV, DiaChi = @DiaChi, DienThoai = @DienThoai, NgayThanhToan = @NgayThanhToan, ThanhTien = @ThanhTien WHERE MaHD = @MaHD
END


--them hoa don
GO
CREATE PROC ThemHoaDon
	@MaHD nvarchar(10)
	,@MaKH nvarchar(10) 
	,@TenKH nvarchar(50) 
	,@DiaChi nvarchar(50) 
	,@DienThoai nvarchar(10) 
	,@MaNV nvarchar(10) 
	,@TenNV nvarchar(50) 
	,@NgayThanhToan datetime
	,@ThanhTien decimal(18, 0) 
AS
Begin
INSERT INTO dbo.HOADON 
(MaHD,MaKH,TenKH,DiaChi,DienThoai,MaNV,TenNV,NgayThanhToan,ThanhTien)
OUTPUT Inserted.MaHD
VALUES (@MaHD,@MaKH,@TenKH,@DiaChi,@DienThoai,@MaNV,@TenNV,@NgayThanhToan,@ThanhTien)
END


-- Xóa Hóa Don
GO
CREATE PROC XoaHoaDon
@MaHD NVARCHAR
AS
Begin
	DELETE FROM dbo.HOADON WHERE MaHD = @MaHD
END;



-- Thêm Nhân Viên

GO
CREATE PROC [dbo].[ThemNhanVien]
@MaNV char(10), @TenNV nvarchar(50),@gioiTinh nvarchar(3),@DiaChi nvarchar(50),@SDT nvarchar(10),@TenDangNhap nvarchar(50),
@MatKhau nvarchar(50),@MaQuyen nvarchar(50)
AS
Begin
INSERT INTO NHANVIEN(MaNV,TenNV,GioiTinh,DiaChi,SDT,TenDangNhap,MatKhau,MaQuyen) Values
(@MaNV,@TenNV,@gioiTinh,@DiaChi,@SDT,@TenDangNhap,@MatKhau,@MaQuyen)
END

-- Xóa Nhân Viên
GO
CREATE PROC [dbo].[XoaNhanVien]
@MaNV NVARCHAR
AS
Begin
DELETE FROM NHANVIEN WHERE MaNV = @MaNV
END;

-- S?a Nhân Viên
GO
CREATE PROC [dbo].[SuaNhanVien]
@MaNV char(10), @TenNV nvarchar(50),@gioiTinh nvarchar(3),@DiaChi nvarchar(50),@SDT nvarchar(10),@TenDangNhap nvarchar(50),
@MatKhau nvarchar(50),@MaQuyen nvarchar(50)
AS
BEGIN
  -- S?a d? li?u
  UPDATE NHANVIEN
  SET MaNV = @MaNV , TenNV = @TenNV ,GioiTinh =@gioiTinh , DiaChi = @DiaChi , SDT = @SDT, TenDangNhap =@TenDangNhap
  , MatKhau = @MatKhau , MaQuyen =@MaQuyen
  WHERE @MaNV = MaNV
END;

-- Tìm Ki?m Nhân Viên Theo Mã
GO
CREATE PROC [dbo].[TimNhanVienTheoMa]
@MaNV char(10)
AS
BEGIN
SELECT * FROM dbo.NHANVIEN 
WHERE MaNV like '%'+@MaNV+'%';
END;


--Them Ca Lam Viec
GO
CREATE PROC [dbo].[ThemCaLamViec]
@MaCa nchar(10) , @MaNV nchar(10) , @TenNV nvarchar(30) , @Ngay date , @CaLam nvarchar(20) , @TenCa nvarchar(30)
AS
Begin
INSERT INTO QUANLICA(MaCa,MaNV,TenNV,Ngay,CaLam,TenCa) Values
(@MaCa,@MaNV,@TenNV,@Ngay,@CaLam,@TenCa)
END

-- Xoa Ca Lam Viec
GO
CREATE PROC [dbo].[XoaCaLamViec]
@MaCa NCHAR(10)
AS
Begin
DELETE FROM QUANLICA WHERE MaCa = @MaCa
END;

--Them khách hàng
GO
CREATE PROC ThemKhachHang
@MaKH nvarchar(10),@TenKH nvarchar(50), @DiaChi nvarchar(50) ,@SDT nvarchar(10) ,@Email nvarchar(50) ,@MaLKH nvarchar(10) 
AS
BEGIN
INSERT INTO KHACHHANG(MaKH,TenKH,DiaChi,SDT,Email,MaLKH) VALUES 
(@MaKH,@TenKH,@DiaChi,@SDT,@Email,@MaLKH)
END;


--Sữa Ca Lam Viec
GO
CREATE PROC [dbo].[SuaCaLamViec]
@MaCa nchar(10) , @MaNV nchar(10) , @TenNV nvarchar(30) , @Ngay date , @CaLam nvarchar(20) , @TenCa nvarchar(30)
AS
Begin
 UPDATE QUANLICA
  SET MaCa = @MaCa , MaNV = @MaNV , TenNV = @TenNV , Ngay = @Ngay , CaLam =@CaLam , TenCa = @TenCa
  WHERE @MaCa = MaCa
END

--Xoa khach hang


--Sua khach hang


-- REPORT
-- In Danh Sách Nhân Viên 

-- REPORT
GO
CREATE PROC [dbo].[InDanhSachNhanVien]
AS
BEGIN                   
SELECT * FROM dbo.NHANVIEN
END;

-- Thêm Dữ liệu sinh viên vào combobox 

GO
CREATE PROC [dbo].[ThemDuLieuVaoComboboxNhanVien]
AS
BEGIN
SELECT MaNV
FROM dbo.NHANVIEN
END;


-- Lay Ten NV = combobox
GO
CREATE PROC [dbo].[sp_LayTenNV]
@Manv char(10)
AS
BEGIN
SELECT *
FROM dbo.NHANVIEN
WHERE MaNV = @Manv
END;

-- Them Du lieu vao cbbtennv
GO
CREATE PROC [dbo].[ThemDuLieuVaoComboboxTenNhanVien]
AS
BEGIN
SELECT TenNV
FROM dbo.NHANVIEN
END;

-- Phan Quyen 
GO
CREATE PROC [dbo].[PhanQuyenAdmin]
@username nchar(30) , @password nchar(30)
AS
BEGIN
SELECT * From LoginAdmin
WHERE userNameID = @username and passWordID = @password
END;


GO
CREATE PROC [dbo].[PhanQuyenUser]
@username nchar(30) , @password nchar(30)
AS
BEGIN
SELECT * From LoginUser
WHERE userNameID = @username and passWordID = @password
END;

GO
CREATE PROC [dbo].[ThemVaoHoaDonOder]
@TenThucUong nvarchar(30) , @GiaTien int , @SoLuong int
AS
BEGIN
INSERT INTO ODER
(MaHD,ThucUong,SoLuong,GiaTien) VALUES 
(Null,@TenThucUong,@SoLuong,@GiaTien)
END;


--GO
--USE [master]
--GO
--ALTER DATABASE [QLCoffe] SET  READ_WRITE 
--GO





