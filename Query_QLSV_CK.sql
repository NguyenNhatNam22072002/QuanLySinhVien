
Create Table MonHoc
 (
   MaMH char(10) primary key,
   TenMH nvarchar(30) not null,
   SoTinChi int not null check ( (SoTinChi>0)and (SoTinChi<10) )
 )
Create Table HeDT
 (
   MaHeDT char(10) primary key,
   TenHeDT nvarchar(40) not null
 )
Create Table KhoaHoc
 ( 
   MaKhoaHoc char(10) primary key,
   TenKhoaHoc nvarchar(20) not null 
 )
Create Table Khoa
 (
   MaKhoa char(10) primary key,
   TenKhoa nvarchar(30) not null,
   DiaChi nvarchar(100) not null,
   DienThoai varchar(20) not null
 )
Create Table Lop
 (
   MaLop char(10) primary key,
   TenLop nvarchar(30) not null,
   MaKhoa char(10) foreign key references Khoa (MaKhoa),
   MaHeDT char(10) foreign key references HeDT (MaHeDT),
   MaKhoaHoc char(10) foreign key references KhoaHoc (MaKhoaHoc),
 )
Create Table SinhVien
 (
   MaSV char(15) primary key,
   TenSV nvarchar(30) ,
   GioiTinh bit ,
   NgaySinh date ,
   QueQuan nvarchar(50) ,
   SoDienThoai int,
   MaLop char(10) foreign key references Lop(MaLop)
 )
Create Table Diem
 (
   MaSV char(15) foreign key references SinhVien(MaSV),
   MaMH char(10) foreign key references MonHoc (MaMH),
   HocKy int check((HocKy>0) and (HocKy<4)) not null,
   DiemQuaTrinhLan1 real ,
   DiemQuaTrinhLan2 real ,
   DiemCuoiKi real
)
-- thêm thông tin cho bảng môn học --
insert into MonHoc values('INPR130285', N'Nhập Môn Lập Trình', 3) 
insert into MonHoc values('INIT130185', N'Nhập Môn CNTT', 3)
insert into MonHoc values('MATH132401', N'Toán 1', 3) 
insert into MonHoc values('MPRO232103', N'Các Quá Trình Cơ Học', 4) 
insert into MonHoc values('GCHE130103', N'Hoá Đại Cương', 3)
insert into MonHoc values('DBMS330284', N'Hệ quản trị cơ sở dữ liệu', 3)
insert into MonHoc values('EEEN231780', N'Điện tử cơ bản', 3)
	select * from MonHoc
--thêm thông tin cho bảng hệ đào tạo--
insert into HeDT values ('DT', N'Đại Trà')
insert into HeDT values ('CLC', N'Chất Lượng Cao')
	select * from HeDT
-- thêm thông tin cho khoá học --
insert into KhoaHoc values ('K19', N'Khoá 2019')
insert into KhoaHoc values ('K20', N'Khoá 2020')
insert into KhoaHoc values ('K21', N'Khoá 2021')
	select * from KhoaHoc
	-- thêm thông tin cho khoa --
insert into Khoa values('CNTT',N'Công nghệ thông tin',N'Tầng 3 - Toà Trung Tâm','0348971214')
insert into Khoa values('CK',N'Cơ khí',N'Tầng 2 - Khu A','0479532145')
insert into Khoa values('CNTP',N'Công nghệ thực phẩm',N'Tầng 3 - Khu C','0359489712')
	select * from Khoa
-- nhập dữ liệu cho bảng lớp --
insert into Lop values('IT1',N'Công Nghệ Thông Tin 1','CNTT','CLC','K20')
insert into Lop values('CNTP1',N'Công Nghệ Thực Phẩm','CNTP','DT','K19')
insert into Lop values('CK1',N'Cơ Khí','CK','CLC','K21')
insert into Lop values('IT2',N'Công Nghệ Thông Tin 2','CNTT','CLC','K20')
	select * from Lop
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
	select * from SinhVien
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
	select * from  Diem

	------------------------------PROCEDURE------------------------------
		-- TẠO PROCEDURE SINH VIEN--
-- thủ tục thêm 1 sinh viên mới --
create procedure ThemMoiSinhVien
@MaSV char(15),
@TenSV nvarchar(30),
@GioiTinh bit,
@NgaySinh date,
@QueQuan nvarchar(50),
@SoDienThoai char(20),
@MaLop char(10)
as
begin
	insert into SinhVien values(@MaSV, @TenSV, @GioiTinh, @NgaySinh, @QueQuan, @SoDienThoai, @MaLop)
end
-- kiểm tra --
ThemMoiSinhVien '20110347', N'Nguyễn Hữu Khánh' , 1, '2002/07/26', N'Hưng Yên', '0898423613', 'IT2'
ThemMoiSinhVien '19147180', N'Phạm Thu Hương' , 0, '2001/10/25', N'Vĩnh Long', '0374528443', 'CNTP1'
ThemMoiSinhVien '21136379', N'Phan Văn Thiện' , 1, '2003/12/28', N'Trà Vinh', '0898463214', 'CK1'
select * from dbo.SinhVien
--thủ tục xoá 1 sinh viên trong danh sách --
create procedure XoaSinhVien
@MaSV char(15)
as
begin
	delete from dbo.SinhVien where MaSV = @MaSV
end
--kiểm tra--
XoaSinhVien '19147180'
select * from dbo.SinhVien

-- thủ tục update sinh viên --
create procedure UpdateSinhVien
@MaSV char(15),
@TenSV nvarchar(30),
@GioiTinh bit,
@NgaySinh date,
@QueQuan nvarchar(50),
@SoDienThoai char(20),
@MaLop char(10)
as
begin
	update SinhVien set MaSV = @MaSV, TenSV = @TenSV, GioiTinh= @GioiTinh, NgaySinh= @NgaySinh, QueQuan= @QueQuan, SoDienThoai = @SoDienThoai, MaLop = @MaLop where MaSV = @MaSV
end
-- kiểm tra --
UpdateSinhVien '19147180', N'Phạm Thị Thu Hương' , 0, '2001/10/25', N'Vĩnh Long', '0374528443', 'CNTP1'
UpdateSinhVien '19147038', N'Huỳnh Thị Hồng', 0, '2001/09/17', N'Quãng Ngãi', '0888404031', 'CNTP1'
select * from dbo.SinhVien
	-- TẠO PROCEDURE ĐIỂM CHO SINH VIÊN --
-- thủ tục thêm điểm cho sinh viên --
create procedure ThemDiemSinhVien
@MaSV char(15),
@MaMH char(15),
@HocKy int,
@DiemQuaTrinhLan1 real,
@DiemQuaTrinhLan2 real,
@DiemCuoiKi real
as
begin
	insert into Diem values (@MaSV, @MaMH, @HocKy, @DiemQuaTrinhLan1, @DiemQuaTrinhLan2, @DiemCuoiKi)
end
--kiểm tra--
ThemDiemSinhVien '20110347','DBMS330284', '2','8', '7.5', '6.5'
ThemDiemSinhVien '19147180','GCHE130103', '1','6', '4', '3'
ThemDiemSinhVien '21136379','MATH132401', '2','8', '8', '9'
select * from dbo.Diem
-- thủ tục sửa điểm cho sinh viên -- 
create procedure SuaDiemSinhVien
@MaSV char(15),
@MaMH char(15),
@HocKy int,
@DiemQuaTrinhLan1 real,
@DiemQuaTrinhLan2 real,
@DiemCuoiKi real
as
begin
	update Diem set MaSV = @MaSV, MaMH = @MaMH, HocKy = @HocKy, DiemQuaTrinhLan1 = @DiemQuaTrinhLan1, DiemQuaTrinhLan2 = @DiemQuaTrinhLan2, DiemCuoiKi = @DiemCuoiKi where MaSV = @MaSV
end
-- kiểm tra --
SuaDiemSinhVien '21136379','MATH132401', '2','7', '8', '9'
select * from dbo.Diem
-- thủ tục xoá điểm của sinh viên --
create procedure XoaDiemSinhVien
@MaSV char(15)
as
begin
	delete from dbo.Diem where MaSV=@MaSV
end
-- kiểm tra --
XoaDiemSinhVien '21136379'
select *from Diem
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
		-- TẠO BẢNG ĐĂNG NHẬP --
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

-- tạo procedure cho bảng khoa --
create proc ThemKhoa
@MaKhoa char(10),
@TenKhoa nvarchar(30),
@DiaChi nvarchar(100),
@DienThoai nvarchar(20)
as
begin
	insert into Khoa values (@MaKhoa, @TenKhoa, @DiaChi, @DienThoai)
end
-- kiểm tra --
ThemKhoa 'OTO',N'Công nghệ ô tô', N'Tầng 3- Khu B', '03474944216'
select * from Khoa
--tạo procedure sửa thông tin cho khoa --
create proc SuaKhoa
@MaKhoa char(10),
@TenKhoa nvarchar(30),
@DiaChi nvarchar(100),
@DienThoai nvarchar(20)
as
begin 
	update dbo.Khoa set MaKhoa = @MaKhoa, TenKhoa= @TenKhoa, DiaChi = @DiaChi, @DienThoai = @DienThoai where MaKhoa = @MaKhoa
end
-- kiểm tra --
SuaKhoa 'OTO',N'Công nghệ ô tô', N'Tầng 1 - Khu E', '03474944216'
select * from Khoa
-- tạo procedure xoá khoa cho bảng khoa --
create procedure XoaKhoa
@MaKhoa char(10)
as
begin
	delete from dbo.Khoa where MaKhoa = @MaKhoa
end
-- kiểm tra --
XoaKhoa 'OTO'
select * from dbo.Khoa

-- tạo procedure cho bảng lớp --
create proc ThemLop
@MaLop char(10),
@TenLop nvarchar(30),
@MaKhoa char(10),
@MaHeDT char(10),
@MaKhoaHoc char(10)
as
begin
	insert into Lop values( @MaLop, @TenLop, @MaKhoa, @MaHeDT, @MaKhoaHoc)
end
-- kiểm tra --
ThemLop 'OTO1', N'Công Nghệ Ô Tô', 'OTO', 'DT', 'K19'
select * from Khoa
select * from Lop
-- tạo procedure Xoá Lớp cho bảng lớp
create proc XoaLop
@MaLop char(10)
as
begin
	delete from dbo.Lop where MaLop = @MaLop
end
--kiểm tra--
XoaLop 'OTO4'
select *from Lop
-- tạo procedure Sửa Thông Tin cho lớp --
create Proc SuaThongTinLop
@MaLop char(10),
@TenLop nvarchar(30),
@MaKhoa char(10),
@MaHeDT char(10),
@MaKhoaHoc char(10)
as
begin
	update dbo.Lop set MaLop = @MaLop, TenLop = @TenLop, MaKhoa = @MaKhoa, MaHeDT= @MaHeDT, MaKhoaHoc = @MaKhoaHoc where MaLop = @MaLop
end
-- kiểm tra --
SuaThongTinLop 'OTO1', N'Công Nghệ Ô Tô', 'OTO', 'CLC', 'K19'
select *from Lop


-- cập nhật lại procedure Chọn Sinh Viên --
Create proc Show_DSSinhVien
as 
begin 
select * from SinhVien 
end
go

-- TẠO PROCEDURE THÊM XOÁ SỬA MÔN HỌC CHO CÁC LỚP --
create proc ThemMonHoc
@MaMH char(10),
@TenMH nvarchar(30),
@SoTinChi int
as
begin 
	insert into dbo.MonHoc values(@MaMH, @TenMH, @SoTinChi)
end
-- kiểm tra --
ThemMonHoc 'STMA240121', N'Sức bền vật liệu', '4'
select * from Khoa
select * from MonHoc

-- procedure xoá môn học --
create proc XoaMonHoc
@MaMH char(10)
as
begin
	delete from dbo.MonHoc where MaMh = @MaMH
end
XoaMonHoc 'STMA240121'
select * from MonHoc

-- procedure sửa thông tin môn học --
create proc SuaThongTinMonHoc
@MaMH char(10),
@TenMH nvarchar(30),
@SoTinChi int
as
begin
	update MonHoc set MaMH = @MaMH, TenMH = @TenMH, SoTinChi = @SoTinChi where MaMH = @MaMH
end
-- kiểm tra --
SuaThongTinMonHoc 'STMA240121', N'Sức bền vật liệu', '3'
select * from MonHoc
-- thêm procedure Lấy thông tin bảng lớp--
create proc Show_DSlop
as
begin 
select * from Lop
end 
go
--them procedure lay thong tin bang khoa--
create proc DSKhoa
as
begin
select * from Khoa
end 
go
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
