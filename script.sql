USE [master]
GO
/****** Object:  Database [Nhom5_QLKS]    Script Date: 6/2/2023 13:31:17 ******/
CREATE DATABASE [Nhom5_QLKS]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Nhom5_QLKS', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS01\MSSQL\DATA\Nhom5_QLKS.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Nhom5_QLKS_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS01\MSSQL\DATA\Nhom5_QLKS_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Nhom5_QLKS] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Nhom5_QLKS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Nhom5_QLKS] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Nhom5_QLKS] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Nhom5_QLKS] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Nhom5_QLKS] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Nhom5_QLKS] SET ARITHABORT OFF 
GO
ALTER DATABASE [Nhom5_QLKS] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Nhom5_QLKS] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Nhom5_QLKS] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Nhom5_QLKS] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Nhom5_QLKS] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Nhom5_QLKS] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Nhom5_QLKS] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Nhom5_QLKS] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Nhom5_QLKS] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Nhom5_QLKS] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Nhom5_QLKS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Nhom5_QLKS] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Nhom5_QLKS] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Nhom5_QLKS] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Nhom5_QLKS] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Nhom5_QLKS] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Nhom5_QLKS] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Nhom5_QLKS] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Nhom5_QLKS] SET  MULTI_USER 
GO
ALTER DATABASE [Nhom5_QLKS] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Nhom5_QLKS] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Nhom5_QLKS] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Nhom5_QLKS] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Nhom5_QLKS] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Nhom5_QLKS] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Nhom5_QLKS] SET QUERY_STORE = OFF
GO
USE [Nhom5_QLKS]
GO
/****** Object:  Table [dbo].[calam]    Script Date: 6/2/2023 13:31:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[calam](
	[maCa] [nvarchar](50) NOT NULL,
	[gioBatDau] [nvarchar](50) NULL,
	[gioKetThuc] [nvarchar](50) NULL,
 CONSTRAINT [PK_calam] PRIMARY KEY CLUSTERED 
(
	[maCa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[chucvu]    Script Date: 6/2/2023 13:31:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[chucvu](
	[maCV] [nvarchar](50) NOT NULL,
	[tenCV] [nvarchar](50) NULL,
	[luongTheoCa1Ngay] [float] NULL,
 CONSTRAINT [PK_chucvu] PRIMARY KEY CLUSTERED 
(
	[maCV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[dichvu]    Script Date: 6/2/2023 13:31:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dichvu](
	[maDV] [nvarchar](50) NOT NULL,
	[tenDV] [nvarchar](50) NULL,
	[giaDV] [float] NULL,
	[soLuong] [int] NULL,
	[loaiDV] [nvarchar](50) NULL,
 CONSTRAINT [PK_dichvu] PRIMARY KEY CLUSTERED 
(
	[maDV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[hoadon]    Script Date: 6/2/2023 13:31:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hoadon](
	[maHD] [nvarchar](50) NOT NULL,
	[maKhach] [nvarchar](50) NULL,
	[maNV] [nvarchar](50) NULL,
	[giaPhong] [float] NULL,
	[maPhong] [nvarchar](50) NULL,
	[ngayThue] [datetime] NULL,
	[ngayTra] [datetime] NULL,
	[thanhTien] [float] NULL,
	[trangThaiTT] [bit] NULL,
	[tienDV] [float] NULL,
 CONSTRAINT [PK_hoadon] PRIMARY KEY CLUSTERED 
(
	[maHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[hoadonCT]    Script Date: 6/2/2023 13:31:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hoadonCT](
	[maHD] [nvarchar](50) NOT NULL,
	[maDV] [nvarchar](50) NOT NULL,
	[donGia] [float] NULL,
	[soLuong] [int] NULL,
	[thanhTien] [float] NULL,
 CONSTRAINT [PK_hoadonCT] PRIMARY KEY CLUSTERED 
(
	[maHD] ASC,
	[maDV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[khach]    Script Date: 6/2/2023 13:31:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[khach](
	[maKhach] [nvarchar](50) NOT NULL,
	[tenKhach] [nvarchar](50) NULL,
	[CMT] [nvarchar](20) NULL,
	[quocTich] [nvarchar](50) NULL,
	[gioiTinh] [bit] NULL,
	[SDT] [nvarchar](20) NULL,
 CONSTRAINT [PK_khach] PRIMARY KEY CLUSTERED 
(
	[maKhach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[loaiPhong]    Script Date: 6/2/2023 13:31:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[loaiPhong](
	[loaiPhong] [nvarchar](50) NOT NULL,
	[giaPhong] [float] NULL,
 CONSTRAINT [PK_loaiPhong] PRIMARY KEY CLUSTERED 
(
	[loaiPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[luong]    Script Date: 6/2/2023 13:31:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[luong](
	[phieuLuong] [nvarchar](50) NOT NULL,
	[maNV] [nvarchar](50) NULL,
	[songaylam] [int] NULL,
	[Luong] [float] NULL,
 CONSTRAINT [PK_luong] PRIMARY KEY CLUSTERED 
(
	[phieuLuong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[nhanvien]    Script Date: 6/2/2023 13:31:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nhanvien](
	[maNV] [nvarchar](50) NOT NULL,
	[hoTen] [nvarchar](50) NULL,
	[ngaySinh] [datetime] NULL,
	[gioiTinh] [bit] NULL,
	[maCa] [nvarchar](50) NULL,
	[maCV] [nvarchar](50) NULL,
	[user_name] [nvarchar](50) NULL,
 CONSTRAINT [PK_nhanvien] PRIMARY KEY CLUSTERED 
(
	[maNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[phong]    Script Date: 6/2/2023 13:31:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[phong](
	[maPhong] [nvarchar](50) NOT NULL,
	[loaiPhong] [nvarchar](50) NULL,
	[tinhTrang] [bit] NULL,
	[tenPhong] [nvarchar](50) NULL,
 CONSTRAINT [PK_phong] PRIMARY KEY CLUSTERED 
(
	[maPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 6/2/2023 13:31:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[user_name] [nvarchar](50) NOT NULL,
	[pass_word] [nvarchar](50) NULL,
	[user_au] [nvarchar](50) NULL,
 CONSTRAINT [PK_TaiKhoan] PRIMARY KEY CLUSTERED 
(
	[user_name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[calam] ([maCa], [gioBatDau], [gioKetThuc]) VALUES (N'Ca1', N'6h', N'14h')
INSERT [dbo].[calam] ([maCa], [gioBatDau], [gioKetThuc]) VALUES (N'Ca2', N'14h', N'22h')
INSERT [dbo].[calam] ([maCa], [gioBatDau], [gioKetThuc]) VALUES (N'Ca3', N'22h', N'6h')
GO
INSERT [dbo].[chucvu] ([maCV], [tenCV], [luongTheoCa1Ngay]) VALUES (N'CV01', N'Quản lý', 1000000)
INSERT [dbo].[chucvu] ([maCV], [tenCV], [luongTheoCa1Ngay]) VALUES (N'CV02', N'Bảo vệ', 300000)
INSERT [dbo].[chucvu] ([maCV], [tenCV], [luongTheoCa1Ngay]) VALUES (N'CV03', N'Lễ tân', 350000)
GO
INSERT [dbo].[dichvu] ([maDV], [tenDV], [giaDV], [soLuong], [loaiDV]) VALUES (N'DV01', N'Bóng cười', 300000, 40, N'Giải Trí')
INSERT [dbo].[dichvu] ([maDV], [tenDV], [giaDV], [soLuong], [loaiDV]) VALUES (N'DV02', N'Tôm Hùm', 10000000, 40, N'Đồ Ăn')
INSERT [dbo].[dichvu] ([maDV], [tenDV], [giaDV], [soLuong], [loaiDV]) VALUES (N'DV03', N'Bia', 100000, 1000, N'Đồ Uống')
INSERT [dbo].[dichvu] ([maDV], [tenDV], [giaDV], [soLuong], [loaiDV]) VALUES (N'DV04', N'Rượu', 120000, 1000, N'Đồ Uống')
INSERT [dbo].[dichvu] ([maDV], [tenDV], [giaDV], [soLuong], [loaiDV]) VALUES (N'DV05', N'Cua', 500000, 50, N'Đồ Ăn')
GO
INSERT [dbo].[hoadon] ([maHD], [maKhach], [maNV], [giaPhong], [maPhong], [ngayThue], [ngayTra], [thanhTien], [trangThaiTT], [tienDV]) VALUES (N'HD01', N'K01', N'NV01', 1000000, N'p01', CAST(N'2022-10-21T00:00:00.000' AS DateTime), CAST(N'2022-10-26T18:18:58.000' AS DateTime), 6300000, 1, 300000)
INSERT [dbo].[hoadon] ([maHD], [maKhach], [maNV], [giaPhong], [maPhong], [ngayThue], [ngayTra], [thanhTien], [trangThaiTT], [tienDV]) VALUES (N'HD02', N'K02', N'NV01', 1500000, N'p02', CAST(N'2022-11-13T18:16:33.927' AS DateTime), CAST(N'2022-11-18T12:11:23.837' AS DateTime), 9000000, 1, 1500000)
INSERT [dbo].[hoadon] ([maHD], [maKhach], [maNV], [giaPhong], [maPhong], [ngayThue], [ngayTra], [thanhTien], [trangThaiTT], [tienDV]) VALUES (N'HD03', N'K01', N'NV04', 1000000, N'p01', CAST(N'2022-11-18T12:12:57.280' AS DateTime), CAST(N'2022-11-19T09:53:57.413' AS DateTime), 2500000, 1, 1500000)
INSERT [dbo].[hoadon] ([maHD], [maKhach], [maNV], [giaPhong], [maPhong], [ngayThue], [ngayTra], [thanhTien], [trangThaiTT], [tienDV]) VALUES (N'HD04', N'K01', N'NV01', 1500000, N'p03', CAST(N'2022-11-19T09:46:30.073' AS DateTime), NULL, NULL, 0, NULL)
GO
INSERT [dbo].[hoadonCT] ([maHD], [maDV], [donGia], [soLuong], [thanhTien]) VALUES (N'HD01', N'DV01', 300000, 1, 300000)
INSERT [dbo].[hoadonCT] ([maHD], [maDV], [donGia], [soLuong], [thanhTien]) VALUES (N'HD02', N'DV01', 300000, 5, 1500000)
INSERT [dbo].[hoadonCT] ([maHD], [maDV], [donGia], [soLuong], [thanhTien]) VALUES (N'HD03', N'DV01', 300000, 5, 1500000)
INSERT [dbo].[hoadonCT] ([maHD], [maDV], [donGia], [soLuong], [thanhTien]) VALUES (N'HD04', N'DV02', 10000000, 10, 100000000)
GO
INSERT [dbo].[khach] ([maKhach], [tenKhach], [CMT], [quocTich], [gioiTinh], [SDT]) VALUES (N'K01', N'Tran Thi A', N'012345678910', N'Viet Nam', 0, N'0123456789')
INSERT [dbo].[khach] ([maKhach], [tenKhach], [CMT], [quocTich], [gioiTinh], [SDT]) VALUES (N'K02', N'Phạm Như Thuần', N'022222222222', N'Việt Nam', 1, N'0845484325')
GO
INSERT [dbo].[loaiPhong] ([loaiPhong], [giaPhong]) VALUES (N'1', 1000000)
INSERT [dbo].[loaiPhong] ([loaiPhong], [giaPhong]) VALUES (N'2', 1500000)
INSERT [dbo].[loaiPhong] ([loaiPhong], [giaPhong]) VALUES (N'3', 2000000)
GO
INSERT [dbo].[luong] ([phieuLuong], [maNV], [songaylam], [Luong]) VALUES (N'P01', N'NV01', 20, 20000000)
INSERT [dbo].[luong] ([phieuLuong], [maNV], [songaylam], [Luong]) VALUES (N'P02', N'NV02', 30, 9000000)
GO
INSERT [dbo].[nhanvien] ([maNV], [hoTen], [ngaySinh], [gioiTinh], [maCa], [maCV], [user_name]) VALUES (N'NV01', N'Trần Nhữ Quốc Tuấn', CAST(N'2001-09-08T00:00:00.000' AS DateTime), 1, N'Ca1', N'CV01', N'admin')
INSERT [dbo].[nhanvien] ([maNV], [hoTen], [ngaySinh], [gioiTinh], [maCa], [maCV], [user_name]) VALUES (N'NV02', N'Le Van Luyen', CAST(N'2001-12-05T00:00:00.000' AS DateTime), 1, N'Ca2', N'CV02', N'NhanVien1')
INSERT [dbo].[nhanvien] ([maNV], [hoTen], [ngaySinh], [gioiTinh], [maCa], [maCV], [user_name]) VALUES (N'NV03', N'Tran Thu', CAST(N'2001-02-09T00:00:00.000' AS DateTime), 0, N'Ca3', N'CV03', N'NhanVien2')
INSERT [dbo].[nhanvien] ([maNV], [hoTen], [ngaySinh], [gioiTinh], [maCa], [maCV], [user_name]) VALUES (N'NV04', N'Phạm Như Thuần', CAST(N'2001-01-11T00:00:00.000' AS DateTime), 1, N'Ca4', N'CV04', N'NhanVien3')
GO
INSERT [dbo].[phong] ([maPhong], [loaiPhong], [tinhTrang], [tenPhong]) VALUES (N'p01', N'1', 0, N'01')
INSERT [dbo].[phong] ([maPhong], [loaiPhong], [tinhTrang], [tenPhong]) VALUES (N'p02', N'2', 0, N'02')
INSERT [dbo].[phong] ([maPhong], [loaiPhong], [tinhTrang], [tenPhong]) VALUES (N'p03', N'2', 1, N'03')
INSERT [dbo].[phong] ([maPhong], [loaiPhong], [tinhTrang], [tenPhong]) VALUES (N'p04', N'3', 0, N'04')
GO
INSERT [dbo].[TaiKhoan] ([user_name], [pass_word], [user_au]) VALUES (N'admin', N'nhom5', N'Admin')
INSERT [dbo].[TaiKhoan] ([user_name], [pass_word], [user_au]) VALUES (N'NhanVien1', N'1234', N'Nhân Viên')
INSERT [dbo].[TaiKhoan] ([user_name], [pass_word], [user_au]) VALUES (N'NhanVien2', N'123', N'Nhân Viên')
INSERT [dbo].[TaiKhoan] ([user_name], [pass_word], [user_au]) VALUES (N'NhanVien3', N'123', N'Nhân Viên')
INSERT [dbo].[TaiKhoan] ([user_name], [pass_word], [user_au]) VALUES (N'NhanVien4', N'12345', N'Nhân Viên')
INSERT [dbo].[TaiKhoan] ([user_name], [pass_word], [user_au]) VALUES (N'NhanVien5', N'12345', N'Nhân Viên')
GO
ALTER TABLE [dbo].[hoadon]  WITH CHECK ADD  CONSTRAINT [FK_hoadon_khach] FOREIGN KEY([maKhach])
REFERENCES [dbo].[khach] ([maKhach])
GO
ALTER TABLE [dbo].[hoadon] CHECK CONSTRAINT [FK_hoadon_khach]
GO
ALTER TABLE [dbo].[hoadon]  WITH CHECK ADD  CONSTRAINT [FK_hoadon_nhanvien] FOREIGN KEY([maNV])
REFERENCES [dbo].[nhanvien] ([maNV])
GO
ALTER TABLE [dbo].[hoadon] CHECK CONSTRAINT [FK_hoadon_nhanvien]
GO
ALTER TABLE [dbo].[hoadon]  WITH CHECK ADD  CONSTRAINT [FK_hoadon_phong] FOREIGN KEY([maPhong])
REFERENCES [dbo].[phong] ([maPhong])
GO
ALTER TABLE [dbo].[hoadon] CHECK CONSTRAINT [FK_hoadon_phong]
GO
ALTER TABLE [dbo].[hoadonCT]  WITH CHECK ADD  CONSTRAINT [FK_hoadonCT_dichvu] FOREIGN KEY([maDV])
REFERENCES [dbo].[dichvu] ([maDV])
GO
ALTER TABLE [dbo].[hoadonCT] CHECK CONSTRAINT [FK_hoadonCT_dichvu]
GO
ALTER TABLE [dbo].[hoadonCT]  WITH CHECK ADD  CONSTRAINT [FK_hoadonCT_hoadon] FOREIGN KEY([maHD])
REFERENCES [dbo].[hoadon] ([maHD])
GO
ALTER TABLE [dbo].[hoadonCT] CHECK CONSTRAINT [FK_hoadonCT_hoadon]
GO
ALTER TABLE [dbo].[luong]  WITH CHECK ADD  CONSTRAINT [FK_luong_nhanvien] FOREIGN KEY([maNV])
REFERENCES [dbo].[nhanvien] ([maNV])
GO
ALTER TABLE [dbo].[luong] CHECK CONSTRAINT [FK_luong_nhanvien]
GO
ALTER TABLE [dbo].[phong]  WITH CHECK ADD  CONSTRAINT [FK_phong_loaiPhong] FOREIGN KEY([loaiPhong])
REFERENCES [dbo].[loaiPhong] ([loaiPhong])
GO
ALTER TABLE [dbo].[phong] CHECK CONSTRAINT [FK_phong_loaiPhong]
GO
USE [master]
GO
ALTER DATABASE [Nhom5_QLKS] SET  READ_WRITE 
GO
