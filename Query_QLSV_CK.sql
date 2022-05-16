Create DataBase [QuanLySinhVien]	
Go
USE [QuanlySinhVien]
GO

--Table query--

-- BẢNG ĐĂNG NHẬP --
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DangNhap](
	[userName] [nvarchar](100) NOT NULL,
	[passWord] [nvarchar](100) NULL,
	[Quyen] [nvarchar](50) NULL,
 CONSTRAINT [PK_DangNhap] PRIMARY KEY CLUSTERED 
(
	[userName] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
--Bang Mon Hoc--
 SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MonHoc](
	[MaMH] [char](10) NOT NULL,
	[TenMH] [nvarchar](30) NOT NULL,
	[SoTinChi] [int] NULL CHECK ( (SoTinChi>0) AND (SoTinChi<10) ),
PRIMARY KEY CLUSTERED 
(
	[MaMH] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
-- Bang He Dao Tao--
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HeDT]
 (
   MaHeDT [char](10),
   TenHeDT [nvarchar](40) NOT NULL,
   PRIMARY KEY CLUSTERED 
(
	[MaHeDT] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
--Bang Khoa Hoc--
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhoaHoc]
 ( 
   MaKhoaHoc [char](10),
   TenKhoaHoc [nvarchar](20) NOT NULL,
   PRIMARY KEY CLUSTERED 
(
	[MaKhoaHoc] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
--Bang Khoa--
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Khoa]
 (
   MaKhoa [char](10),
   TenKhoa [nvarchar](30) NOT NULL,
   DiaChi [nvarchar](100) NOT NULL,
   DienThoai [varchar](20) NOT NULL,
   PRIMARY KEY CLUSTERED 
(
	[MaKhoa] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
--Bang Lop--
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lop]
 (
   MaLop [char](10),
   TenLop [nvarchar](30) not null,
   MaKhoa [char](10) FOREIGN KEY REFERENCES Khoa (MaKhoa),
   MaHeDT [char](10) FOREIGN KEY REFERENCES HeDT (MaHeDT),
   MaKhoaHoc [char](10) FOREIGN KEY REFERENCES KhoaHoc (MaKhoaHoc),
   PRIMARY KEY CLUSTERED 
(
	[Malop] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
--Bang SV--
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SinhVien]
 (
   MaSV [char](15),
   TenSV [nvarchar](30) ,
   GioiTinh [bit] ,
   NgaySinh [date] ,
   QueQuan [nvarchar](50) ,
   SoDienThoai [int],
   MaLop [char](10) FOREIGN KEY REFERENCES Lop(MaLop),
   PRIMARY KEY CLUSTERED 
(
	[MaSV] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
--Bang Diem--
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Table [dbo].[Diem]
 (
   MaSV [char](15) FOREIGN KEY REFERENCES SinhVien(MaSV) on delete cascade,
   MaMH [char](10) FOREIGN KEY REFERENCES MonHoc (MaMH),
   HocKy [int] check((HocKy>0) and (HocKy<4)) NOT NULL,
   DiemQuaTrinhLan1 [real] ,
   DiemQuaTrinhLan2 [real] ,
   DiemCuoiKi [real],
) ON [PRIMARY]
GO

--- tạo bảng giảng viên --
create table GiangVien(
	MaGV nvarchar(15) primary key,
	TenGV nvarchar(50) not null,
	SoDienThoai nvarchar(20),
	TrinhDo nvarchar(20),
	QuocTich nvarchar(20),
	BoMon char(10) foreign key references MonHoc(MaMH),
	MaKhoa char(10) foreign key references Khoa(MaKhoa)
)
drop table GiangVien
-- thêm thôn tin cho bảng giảng viên --
insert into GiangVien values('GV1',N'Nguyễn Thanh Tùng','0363480483',N'Thạc sĩ',N'Việt Nam','INPR130285','CNTT')
insert into GiangVien values('GV2',N'Bùi Nhựt Phong','0394132368',N'Thạc sĩ',N'Việt Nam','INIT130185','CNTT')
insert into GiangVien values('GV3',N'Huỳnh Quốc Tuấn','0379878669',N'Thạc sĩ',N'Việt Nam','MATH132401','CNTP')
insert into GiangVien values('GV4',N' Huỳnh Lê Anh Huy','0338636347',N'Thạc sĩ',N'Việt Nam','MPRO232103','OTO')
insert into GiangVien values('GV5',N'Lâm Thị Ánh Quyên','0399590639',N'Tiến sĩ',N'Việt Nam','GCHE130103','CNTP')
insert into GiangVien values('GV6',N'Trần Thị Thanh Trà','0383277782',N'Thạc sĩ',N'Việt Nam','DBMS330284','CNTT')
insert into GiangVien values('GV7',N'Lê Minh Tiến','0365199950',N'Tiến sĩ',N'Việt Nam','EEEN231780','CK')
-- thêm thông tin cho bảng môn học --
insert into MonHoc values('INPR130285', N'Nhập Môn Lập Trình', 3) 
insert into MonHoc values('INIT130185', N'Nhập Môn CNTT', 3)
insert into MonHoc values('MATH132401', N'Toán 1', 3) 
insert into MonHoc values('MPRO232103', N'Các Quá Trình Cơ Học', 4) 
insert into MonHoc values('GCHE130103', N'Hoá Đại Cương', 3)
insert into MonHoc values('DBMS330284', N'Hệ quản trị cơ sở dữ liệu', 3)
insert into MonHoc values('EEEN231780', N'Điện tử cơ bản', 3)
--thêm thông tin cho bảng hệ đào tạo--
insert into HeDT values ('DT', N'Đại Trà')
insert into HeDT values ('CLC', N'Chất Lượng Cao')
-- thêm thông tin cho khoá học --
insert into KhoaHoc values ('K19', N'Khoá 2019')
insert into KhoaHoc values ('K20', N'Khoá 2020')
insert into KhoaHoc values ('K21', N'Khoá 2021')
	-- thêm thông tin cho khoa --
insert into Khoa values('CNTT',N'Công nghệ thông tin',N'Tầng 3 - Toà Trung Tâm','0348971214')
insert into Khoa values('CK',N'Cơ khí',N'Tầng 2 - Khu A','0479532145')
insert into Khoa values('CNTP',N'Công nghệ thực phẩm',N'Tầng 3 - Khu C','0359489712')
-- nhập dữ liệu cho bảng lớp --
insert into Lop values('IT1',N'Công Nghệ Thông Tin 1','CNTT','CLC','K20')
insert into Lop values('CNTP1',N'Công Nghệ Thực Phẩm','CNTP','DT','K19')
insert into Lop values('CK1',N'Cơ Khí','CK','CLC','K21')
insert into Lop values('IT2',N'Công Nghệ Thông Tin 2','CNTT','CLC','K20')
	-- nhập dữ liệu thông tin sinh viên --
insert into SinhVien values('20110001', N'Nguyễn Văn An', 1, '2002/03/14', N'Hà Tĩnh', '0347129388', 'IT1')
insert into SinhVien values('19147058', N'Nguyễn Thị Anh', 0, '2001/06/19', N'Hồ Chí Minh', '0383801088', 'CNTP1')
insert into SinhVien values('20110341', N'Nguyễn Bảo Tiến', 1, '2002/12/12', N'Nghệ An', '0352440186', 'IT2')
insert into SinhVien values('21136945', N'Trịnh Xuân Huy', 1, '2003/04/23', N'Ninh Bình', '0393514768', 'CK1')
insert into SinhVien values('19147038', N'Huỳnh Thị Hồng', 0, '2001/09/17', N'Quãng Ngãi', '0987404031', 'CNTP1')
insert into SinhVien values('19147637', N'Cao Thanh Tùng', 1, '2001/05/27', N'Hà Nội', '0382748881', 'CNTP1')
insert into SinhVien values('20110743', N'Phạm Long', 1, '2002/10/17', N'Nam Định', '0326817771', 'IT1')
insert into SinhVien values('21136254', N'Nguyễn Văn Long', 1, '2003/10/03', N'Bình Định', '0862691693', 'CK1') 
insert into SinhVien values('19147169', N'Phạm Tiến Nghĩa', 1, '2001/04/26', N'Thái Nguyên', '0337394446', 'CNTP1') 
insert into SinhVien values('21136331', N'Mai Xuân Bảo', 1, '2003/08/09', N'Thanh Hoá', '0329832899', 'CK1')
insert into SinhVien values('21136374', N'Trịnh Thị Quỳnh', 0, '2003/03/17', N'Bắc Giang', '0365674339', 'CK1')
insert into SinhVien values('20110569', N'Nguyễn Đức Nghĩa', 1, '2002/07/10', N'Bắc Ninh', '0349789118', 'IT1')
-- đổi kiểu dữ liệu cho cột SDT trong bảng SinhVien--
alter table SinhVien
alter column SoDienThoai char(20)
-- đổi kiểu dữ liệu cho cột NgaySinh trong bảng SinhVien--
alter table SinhVien
alter column NgaySinh date
-- nhập dữ liệu thông tin cho bảng Điểm --
insert into Diem values('20110001','DBMS330284', '1','8.5', '6.5', '7.25')
insert into Diem values('19147058','GCHE130103', '2','8.25', '7.5', '7.75')
insert into Diem values('20110341','EEEN231780', '2','8', '9', '8.5')
insert into Diem values('21136945','EEEN231780', '3','8.75', '9.25', '8.75')
insert into Diem values('19147038','MATH132401', '1','7.8', '7.8', '8')
insert into Diem values('19147637','MPRO232103', '3','6.5', '7.8', '4')
insert into Diem values('20110743','INPR130285', '1','8', '7.8', '8.25')
insert into Diem values('21136254','MATH132401', '2','9.5', '6.5', '8')
insert into Diem values('19147169','MPRO232103', '3','6.5', '4.5', '4.5')
insert into Diem values('21136331','EEEN231780', '1','4', '4.5', '5')
insert into Diem values('21136374','MATH132401', '1','4.5', '6', '3')
insert into Diem values('20110569','INIT130185', '3','5.5', '6.5', '4.5')
	------------------------------PROCEDURE------------------------------
		-- TẠO PROCEDURE SINH VIEN--
-- thủ tục thêm 1 sinh viên mới --
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ThemMoiSinhVien]
@MaSV char(15),
@TenSV nvarchar(30),
@GioiTinh bit,
@NgaySinh date,
@QueQuan nvarchar(50),
@SoDienThoai char(20),
@MaLop char(10)
AS
BEGIN
	INSERT INTO SinhVien VALUES(@MaSV, @TenSV, @GioiTinh, @NgaySinh, @QueQuan, @SoDienThoai, @MaLop)
END
GO
--thủ tục xoá 1 sinh viên trong danh sách --
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[XoaSinhVien]
@MaSV char(15)
AS
BEGIN
	DELETE FROM dbo.SinhVien WHERE MaSV = @MaSV
END
GO
-- thủ tục update sinh viên --
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[UpdateSinhVien]
@MaSV char(15),
@TenSV nvarchar(30),
@GioiTinh bit,
@NgaySinh date,
@QueQuan nvarchar(50),
@SoDienThoai char(20),
@MaLop char(10)
AS
BEGIN
	UPDATE SinhVien SET MaSV = @MaSV, TenSV = @TenSV, GioiTinh= @GioiTinh, NgaySinh= @NgaySinh, QueQuan= @QueQuan, SoDienThoai = @SoDienThoai, MaLop = @MaLop WHERE MaSV = @MaSV
END 
GO
-- Chọn tất cả sinh viên  --
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC  [dbo].[ChonTatCaSinhVien]
AS
BEGIN
	SELECT * FROM SinhVien
END 
GO
-- cập nhật lại procedure Chọn Sinh Viên --
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Show_DSSinhVien]
AS
BEGIN
	SELECT * FROM SinhVien 
END 
GO
--Procedure lay sinh vien theo ma lop--
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SinhVien_SelectMaLop](
@MaLop char(10)
)
AS
BEGIN
	SELECT *FROM SinhVien WHERE MaLop=@MaLop
END
GO
-- thu tuc tim kiem sinh vien--
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SinhVien_Search](
	@TenSV nvarchar(30),
	@MaLop char(10)
)
AS
BEGIN
	SELECT * FROM SinhVien WHERE TenSV LIKE '%@TenSV%' AND MaLop=@MaLop
END
GO
-- thu tuc lay sinh vien theo id--
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SinhVien_SelectID](
	@MaSV char(15)
)
AS
BEGIN
	SELECT * FROM SinhVien WHERE MaSV=@MaSV
END
GO
	-- TẠO PROCEDURE ĐIỂM CHO SINH VIÊN --
-- thủ tục thêm điểm cho sinh viên --
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ThemDiemSinhVien]
@MaSV char(15),
@MaMH char(15),
@HocKy int,
@DiemQuaTrinhLan1 real,
@DiemQuaTrinhLan2 real,
@DiemCuoiKi real
AS
BEGIN
	INSERT INTO Diem VALUES (@MaSV, @MaMH, @HocKy, @DiemQuaTrinhLan1, @DiemQuaTrinhLan2, @DiemCuoiKi)
END 
GO
-- thủ tục sửa điểm cho sinh viên -- 
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SuaDiemSinhVien]
@MaSV char(15),
@MaMH char(15),
@HocKy int,
@DiemQuaTrinhLan1 real,
@DiemQuaTrinhLan2 real,
@DiemCuoiKi real
AS
BEGIN
	UPDATE Diem SET MaSV = @MaSV, MaMH = @MaMH, HocKy = @HocKy, DiemQuaTrinhLan1 = @DiemQuaTrinhLan1, DiemQuaTrinhLan2 = @DiemQuaTrinhLan2, DiemCuoiKi = @DiemCuoiKi WHERE MaSV = @MaSV
END 
GO
-- thủ tục xoá điểm của sinh viên --
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[XoaDiemSinhVien]
@MaSV char(15)
AS
BEGIN
	DELETE FROM dbo.Diem WHERE MaSV=@MaSV
END 
GO
--thu tuc hien danh sach diem sv--
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Show_DSDiem]
AS
BEGIN
	SELECT * FROM Diem
END 
GO
				-- TẠO PROCEDURE CHO KHOA --
--thu tuc them khoa--
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ThemKhoa]
@MaKhoa char(10),
@TenKhoa nvarchar(30),
@DiaChi nvarchar(100),
@DienThoai nvarchar(20)
AS
BEGIN
	INSERT INTO Khoa VALUES (@MaKhoa, @TenKhoa, @DiaChi, @DienThoai)
END 
GO
--tạo procedure sửa thông tin cho khoa --
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SuaKhoa]
@MaKhoa char(10),
@TenKhoa nvarchar(30),
@DiaChi nvarchar(100),
@DienThoai nvarchar(20)
AS
BEGIN
	UPDATE [dbo].[Khoa] SET MaKhoa = @MaKhoa, TenKhoa= @TenKhoa, DiaChi = @DiaChi, @DienThoai = @DienThoai WHERE MaKhoa = @MaKhoa
END 
GO
-- tạo procedure xoá khoa cho bảng khoa --
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[XoaKhoa]
@MaKhoa char(10)
AS
BEGIN
	DELETE FROM dbo.Khoa WHERE MaKhoa = @MaKhoa
END 
GO
-- procedure lay thong tin bang khoa--
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DSKhoa]
AS
BEGIN
	select * from Khoa
END 
GO
					-- tạo procedure cho bảng lớp --
--thu tuc them lop--
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ThemLop]
@MaLop char(10),
@TenLop nvarchar(30),
@MaKhoa char(10),
@MaHeDT char(10),
@MaKhoaHoc char(10)
AS
BEGIN
	INSERT INTO Lop VALUES( @MaLop, @TenLop, @MaKhoa, @MaHeDT, @MaKhoaHoc)
END 
GO
-- tạo procedure Xoá Lớp cho bảng lớp
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[XoaLop]
@MaLop char(10)
AS
BEGIN
	DELETE FROM dbo.Lop WHERE MaLop = @MaLop
END 
GO
-- tạo procedure Sửa Thông Tin cho lớp --
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SuaThongTinLop]
@MaLop char(10),
@TenLop nvarchar(30),
@MaKhoa char(10),
@MaHeDT char(10),
@MaKhoaHoc char(10)
AS
BEGIN
	UPDATE dbo.Lop SET MaLop = @MaLop, TenLop = @TenLop, MaKhoa = @MaKhoa, MaHeDT= @MaHeDT, MaKhoaHoc = @MaKhoaHoc WHERE MaLop = @MaLop
END 
GO
-- procedure Lấy thông tin bảng lớp--
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Show_DSlop]
AS
BEGIN
	SELECT * FROM Lop
END 
GO
			-- TẠO PROCEDURE THÊM XOÁ SỬA GIẢNG VIÊN --
-- procedure thêm giảng viên --
create proc ThemGiangVien
	@MaGV nvarchar(15),
	@TenGV nvarchar(50),
	@SoDienThoai nvarchar(20),
	@TrinhDo nvarchar(20),
	@QuocTich nvarchar(20),
	@BoMon char(10),
	@MaKhoa char(10)
as
begin
	insert into GiangVien values( @MaGV, @TenGV, @SoDienThoai, @TrinhDo, @QuocTich,@BoMon, @MaKhoa) 
end
go

--procdure xoá giảng viên --
create proc XoaGiangVien
	@MaGV nvarchar(15)
as
begin
	delete from dbo.GiangVien where MaGV = @MaGV 
end
go

-- procedure sửa thông tin giảng viên
create proc UpdateGiangVien
	@MaGV nvarchar(15),
	@TenGV nvarchar(50),
	@SoDienThoai nvarchar(20),
	@TrinhDo nvarchar(20),
	@QuocTich nvarchar(20),
	@BoMon char(10),
	@MaKhoa char(10)
as
begin
	update dbo.GiangVien set MaGV = @MaGV, TenGV = @TenGV, SoDienThoai = @SoDienThoai, TrinhDo = @TrinhDo, QuocTich = @QuocTich, BoMon = @BoMon, MaKhoa = @MaKhoa where MaGV = @MaGV
end
go

-- show danh sách giảng viên --
create proc Show_DSGiangVien
as
begin 
select * from GiangVien
end 
go

			-- TẠO PROCEDURE THÊM XOÁ SỬA MÔN HỌC CHO CÁC LỚP --
--thu tuc them mon hoc--
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ThemMonHoc]
@MaMH char(10),
@TenMH nvarchar(30),
@SoTinChi int
AS
BEGIN
	INSERT INTO dbo.MonHoc VALUES(@MaMH, @TenMH, @SoTinChi)
END 
GO
-- procedure xoá môn học --
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[XoaMonHoc]
@MaMH char(10)
AS
BEGIN
	DELETE FROM dbo.MonHoc WHERE MaMH = @MaMH
END 
GO
-- procedure sửa thông tin môn học --
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SuaThongTinMonHoc]
@MaMH char(10),
@TenMH nvarchar(30),
@SoTinChi int
AS
BEGIN
	UPDATE MonHoc SET MaMH = @MaMH, TenMH = @TenMH, SoTinChi = @SoTinChi WHERE MaMH = @MaMH
END 
GO
--- show danh sách môn học
create proc Show_DSMonhoc
as
begin
	select * from dbo.MonHoc
end
go
				-- TẠO PROCEDURE THÊM XOÁ SỬA MÔN HỌC CHO HE DAO TAO --
-- thu tuc lay danh sach he dao tao--
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DSChuongtrinhDT]
AS
BEGIN
	SELECT * FROM HeDT
END 
GO
-- thu tuc them he dao tao
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ThemHeDT]
   @MaHeDT char(10),
   @TenHeDT nvarchar(40) 
AS
BEGIN
	INSERT INTO HeDT VALUES (@MaHeDT, @TenHeDT)
END 
GO
-- thu tuc xoa he dao tao--
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[XoaHeDT]
@MaHeDT char(10)
AS
BEGIN
	DELETE FROM dbo.HeDT WHERE MaHeDT = @MaHeDT
END
GO
--thu tuc sua he dao tao--
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SuaThongTinHeDT]
   @MaHeDT char(10),
   @TenHeDT nvarchar(40) 
AS
BEGIN
	UPDATE HeDT SET MaHeDT = @MaHeDT, TenHeDT = @TenHeDT WHERE MaHeDT = @MaHeDT
END
GO
				-- TẠO PROCEDURE THÊM XOÁ SỬA MÔN HỌC CHO DANG NHAP --
-- thu tuc cap nhat cho bang dang nhap--
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DangNhap_Update]
	@userName nvarchar(100),
	@passWord nvarchar(100),
	@Quyen nvarchar(50) 
AS
BEGIN
	UPDATE DangNhap SET passWord=@passWord,Quyen=@Quyen WHERE userName=@userName
END
GO
-- thu tuc chon quyen cho bang dang nhap--
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DangNhap_SelectQuyen]
	@Quyen nvarchar(50) 
AS
BEGIN
	SELECT * FROM DangNhap WHERE Quyen=@Quyen
END
GO
-- thu tuc chon tat ca cho bang dang nhap--
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DangNhap_SelectAll]
AS
BEGIN
	SELECT *FROM DangNhap
END
GO
--thu tuc them du lieu cho bang dang nhap--
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DangNhap_Insert]
	@userName nvarchar(100),
	@passWord nvarchar(100),
	@Quyen nvarchar(50) 
AS
BEGIN
	INSERT INTO DangNhap VALUES (@userName,@passWord,@Quyen)
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--thu tuc xoa cho bang dang nhap
CREATE PROC [dbo].[DangNhap_Delete]
	@userName nvarchar(100) 
AS
BEGIN
	DELETE FROM DangNhap WHERE userName=@userName
END
GO
-------------------------------------TRIGGER------------------------
-- trigger thêm điểm sinh viên --
create trigger trigger_insertDiem
on Diem for insert
as
declare @DiemQuaTrinhLan1 float
declare @DiemQuaTrinhLan2 float
declare @DiemCuoiKi float
select @DiemQuaTrinhLan1 = DiemQuaTrinhLan1, @DiemQuaTrinhLan2 = DiemQuaTrinhLan2, @DiemCuoiKi = DiemCuoiKi 
from inserted
if (@DiemQuaTrinhLan1 < 0) or (@DiemQuaTrinhLan1 > 10) or (@DiemQuaTrinhLan2 < 0) or (@DiemQuaTrinhLan2 > 10) or (@DiemCuoiKi < 0) or (@DiemCuoiKi > 10)
begin 
print N'Điểm phải < 0 hoặc > 10. Vui lòng nhập lại!'
Rollback tran
end
else
begin
print N'Nhập điểm sinh viên thành công!'
end
go
--trigger cap nhat diem--
create trigger trigger_updateDiem
on Diem for update
as
declare @DiemQuaTrinhLan1 float
declare @DiemQuaTrinhLan2 float
declare @DiemCuoiKi float
select @DiemQuaTrinhLan1 = DiemQuaTrinhLan1, @DiemQuaTrinhLan2 = DiemQuaTrinhLan2, @DiemCuoiKi = DiemCuoiKi 
from inserted
if (@DiemQuaTrinhLan1 < 0) or (@DiemQuaTrinhLan1 > 10) or (@DiemQuaTrinhLan2 < 0) or (@DiemQuaTrinhLan2 > 10) or (@DiemCuoiKi < 0) or (@DiemCuoiKi > 10)
begin 
print N'Điểm phải < 0 hoặc > 10. Vui lòng nhập lại!'
Rollback tran
end
else
begin
print N'Sửa điểm của sinh viên thành công!'
end
go
-----trigger insert thêm tuổi sinh viên ----
create trigger trigger_insertTuoi_SinhVien on SinhVien for insert
as
begin
declare @count int = 0
select @count = count (*) from inserted where YEAR(getdate()) - YEAR(inserted.NgaySinh) < 18
	if(@count > 0)
		begin
			print N'Tuổi sinh viên phải trên 18. Vui lòng nhập lại ngày tháng năm sinh!'
			rollback tran
		end
	else
		begin
			print N'Thêm tuổi sinh viên thành công!'
		end
end
go
--trigger sửa tuổi sinh viên --
create trigger trigger_UpdateTuoiSinhVien on SinhVien for update
as
begin
declare @count int = 0
select @count = count (*) from inserted where YEAR(getdate()) - YEAR(inserted.NgaySinh) < 18
	if(@count > 0)
		begin
			print N'Tuổi sinh viên phải trên 18. Vui lòng nhập lại ngày tháng năm sinh!'
			rollback tran
		end
	else
		begin
			print N'Sửa tuổi sinh viên thành công!!'
		end
end
go
--trigger null them sv--
create trigger Null_insertSV on SinhVien for insert
as
begin
  Declare @TenSV nvarchar(20)
  Declare @GioiTinh bit
  Declare @NgaySinh date
  Declare @QueQuan nvarchar(20)
  Declare @SoDienThoai nvarchar(20)
 select @TenSV = TenSV,
		@GioiTinh = GioiTinh,
		@NgaySinh = NgaySinh,
		@QueQuan = QueQuan,
		@SoDienThoai = SoDienThoai from inserted
	if(@TenSV is null) or (@GioiTinh is null) or (@NgaySinh is null) or (@QueQuan is null) or (@SoDienThoai is null)
	begin
		print N'Không được để trống thông tin!'
		rollback tran
	end
	else
	begin
		print N'Nhập dữ liệu thành công!'
	end
end

-------------------------------------FUNCTION-------------------------------------
--function xem all thông tin sinh viên --
create function Show_ThongTinSinhVien(@MaSSV char(10))
returns table as 
return(
select dbo.SinhVien.MaSV,  TenSV, case GioiTinh when 0 then N'Nữ' when 1 then N'Nam' end as 'GioiTinh', NgaySinh, QueQuan, SoDienThoai, MaLop, dbo.MonHoc.MaMH, TenMH, SoTinChi, HocKy, DiemQuaTrinhLan1, DiemQuaTrinhLan2, DiemCuoiKi from dbo.SinhVien, dbo.Diem, dbo.MonHoc
where dbo.SinhVien.MaSV = dbo.Diem.MaSV and dbo.Diem.MaMH = dbo.MonHoc.MaMH and @MaSSV = dbo.SinhVien.MaSV
)
---> DONE
--select * from Show_ThongTinSinhVien(20110743)
--drop function Show_ThongTinSinhVien
--select * from SinhVien
--select * from Diem
--select * from MonHoc
-- fucntion tính điểm trung bình của sinh viên--
create function Tinh_DTB(@MaSV nvarchar(15))
returns nvarchar(20)
as
begin
	declare @QT1 real
	declare @QT2 real
	declare @CK real
	declare @DTB real
	select @QT1= DiemQuaTrinhLan1, @QT2 = DiemQuaTrinhLan2 , @CK = DiemCuoiKi from dbo.Diem where @MaSV = MaSV
	set @DTB = (((@QT1 + @QT2) /2) +@CK) /2
	return @DTB
end
--> DONE
--> câu lệnh xem DiemTongKet với bảng điểm
select *, dbo.Tinh_DTB(MaSV) as DiemTongKet from Diem
select * from Diem
----------------Quy đổi hệ 10 sang 4-----------------------
CREATE FUNCTION Quydoihe()
RETURNS TABLE
AS
return(SELECT [dbo].[Diem].MaSV, MaMH, HocKy, DiemQuaTrinhLan1 = DiemQuaTrinhLan1/10 * 4, DiemQuaTrinhLan2 = DiemQuaTrinhLan2/10 * 4, DiemCuoiKi = DiemCuoiKi/10 * 4
		   FROM [dbo].[Diem])
GO

Select * from [dbo].Quydoihe()
-------------------------------------VIEW-------------------------------------
-- Tạo view bảng sinh viên nam--
CREATE VIEW NamSinhVien AS
SELECT MaSV, TenSV, case GioiTinh when 0 then N'Nữ' when 1 then N'Nam' end as 'GioiTinh' FROM [dbo].SinhVien
WHERE GioiTinh = 1
WITH CHECK OPTION
GO
-- tạo view bảng sinh viên nữ
CREATE VIEW NuSinhVien AS
SELECT MaSV, TenSV, case GioiTinh when 0 then N'Nữ' when 1 then N'Nam' end as 'GioiTinh' FROM [dbo].SinhVien
WHERE GioiTinh = 0
WITH CHECK OPTION
GO
-- Tạo view bảng SV thuộc lớp --
CREATE VIEW SinhVien_Lop AS
SELECT SinhVien.MaSV, SinhVien.TenSV, Lop.MaLop, Lop.TenLop
FROM dbo.SinhVien INNER JOIN dbo.lop ON SinhVien.MaLop=Lop.MaLop
WITH CHECK OPTION
GO
--Tạo view bảng đăng nhập có người dùng là admin--
CREATE VIEW DangNhap_Admin AS
SELECT userName,Quyen FROM [dbo].DangNhap
WHERE Quyen='admin' 
WITH CHECK OPTION
GO
--Tạo view sinh vien thuộc khoa--
CREATE VIEW SinhVien_Khoa AS
SELECT SinhVien.MaSV, SinhVien.TenSV, Lop.MaLop, Lop.TenLop, Khoa.MaKhoa, Khoa.TenKhoa
FROM SinhVien INNER JOIN Lop ON SinhVien.MaLop=Lop.MaLop INNER JOIN Khoa ON Lop.MaKhoa=Khoa.MaKhoa
WITH CHECK OPTION
GO
SELECT * FROM SinhVien_Khoa
--Tạo view bảng diem tong ket--
CREATE VIEW TinhDiemTongKet AS 
SELECT * ,dbo.Tinh_DTB(MaSV) AS [DiemTongKet]
FROM dbo.Diem AS D
WITH CHECK OPTION
GO
