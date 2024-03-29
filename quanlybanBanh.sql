USE [master]
GO
/****** Object:  Database [quanlybanBanh]    Script Date: 05/16/2023 8:19:45 PM ******/
CREATE DATABASE [quanlybanBanh]
-- CONTAINMENT = NONE
-- ON  PRIMARY 
--( NAME = N'quanlybanBanh', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\quanlybanBanh.mdf' , SIZE = 3264KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
-- LOG ON 
--( NAME = N'quanlybanBanh_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\quanlybanBanh_log.ldf' , SIZE = 832KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [quanlybanBanh] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [quanlybanBanh].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [quanlybanBanh] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [quanlybanBanh] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [quanlybanBanh] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [quanlybanBanh] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [quanlybanBanh] SET ARITHABORT OFF 
GO
ALTER DATABASE [quanlybanBanh] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [quanlybanBanh] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [quanlybanBanh] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [quanlybanBanh] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [quanlybanBanh] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [quanlybanBanh] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [quanlybanBanh] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [quanlybanBanh] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [quanlybanBanh] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [quanlybanBanh] SET  ENABLE_BROKER 
GO
ALTER DATABASE [quanlybanBanh] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [quanlybanBanh] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [quanlybanBanh] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [quanlybanBanh] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [quanlybanBanh] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [quanlybanBanh] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [quanlybanBanh] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [quanlybanBanh] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [quanlybanBanh] SET  MULTI_USER 
GO
ALTER DATABASE [quanlybanBanh] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [quanlybanBanh] SET DB_CHAINING OFF 
GO
ALTER DATABASE [quanlybanBanh] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [quanlybanBanh] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [quanlybanBanh] SET DELAYED_DURABILITY = DISABLED 
GO
USE [quanlybanBanh]
GO
/****** Object:  Table [dbo].[CTHDBan]    Script Date: 05/16/2023 8:19:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CTHDBan](
	[MaHD] [varchar](20) NOT NULL,
	[MaSP] [varchar](20) NOT NULL,
	[SoLuong] [int] NULL,
	[DonGia] [float] NULL,
	[ChietKhau] [float] NULL,
	[thanhTien] [float] NULL,
	[size] [char](2) NOT NULL,
	[trangthai] [int] NULL DEFAULT ((0)),
PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC,
	[MaSP] ASC,
	[size] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CTHDNhap]    Script Date: 05/16/2023 8:19:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CTHDNhap](
	[MaHDNhap] [varchar](20) NOT NULL,
	[MaSP] [varchar](20) NOT NULL,
	[SoLuong] [int] NULL,
	[DonGia] [float] NULL,
	[thanhTien] [float] NULL,
	[size] [char](2) NOT NULL,
	[trangthai] [int] NULL DEFAULT ((0)),
PRIMARY KEY CLUSTERED 
(
	[MaHDNhap] ASC,
	[MaSP] ASC,
	[size] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HoaDonBan]    Script Date: 05/16/2023 8:19:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HoaDonBan](
	[MaHDBan] [varchar](20) NOT NULL,
	[MaNV] [varchar](20) NULL,
	[NgayLapHD] [datetime] NULL,
	[MaKH] [varchar](20) NULL,
	[Tongtien] [float] NULL,
	[trangthai] [int] NULL DEFAULT ((0)),
PRIMARY KEY CLUSTERED 
(
	[MaHDBan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HoaDonNhap]    Script Date: 05/16/2023 8:19:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HoaDonNhap](
	[MaHDNhap] [varchar](20) NOT NULL,
	[MaNCC] [varchar](20) NULL,
	[MaNV] [varchar](20) NULL,
	[NgayNhap] [datetime] NULL,
	[TongTien] [float] NULL,
	[trangthai] [int] NULL DEFAULT ((0)),
PRIMARY KEY CLUSTERED 
(
	[MaHDNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 05/16/2023 8:19:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKh] [varchar](20) NOT NULL,
	[TenKh] [nvarchar](100) NULL,
	[Phai] [int] NULL DEFAULT ((0)),
	[DiaChi] [nvarchar](100) NULL,
	[Email] [varchar](100) NULL,
	[Phone] [varchar](24) NULL,
	[trangthai] [int] NULL DEFAULT ((0)),
PRIMARY KEY CLUSTERED 
(
	[MaKh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LoaiSP]    Script Date: 05/16/2023 8:19:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LoaiSP](
	[MaLoai] [varchar](20) NOT NULL,
	[TenLoai] [nvarchar](100) NULL,
	[trangthai] [int] NULL DEFAULT ((0)),
PRIMARY KEY CLUSTERED 
(
	[MaLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 05/16/2023 8:19:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhaCungCap](
	[MaNCC] [varchar](20) NOT NULL,
	[TenNCC] [nvarchar](100) NULL,
	[DiaChi] [nvarchar](100) NULL,
	[Phone] [varchar](24) NULL,
	[Email] [varchar](100) NULL,
	[MaLoai] [varchar](20) NULL,
	[trangthai] [int] NULL DEFAULT ((0)),
PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 05/16/2023 8:19:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [varchar](20) NOT NULL,
	[Hoten] [nvarchar](100) NULL,
	[Phai] [int] NULL DEFAULT ((0)),
	[NgaySinh] [datetime] NULL,
	[DiaChi] [nvarchar](100) NULL,
	[Phone] [varchar](24) NULL,
	[trangthai] [int] NULL DEFAULT ((0)),
PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 05/16/2023 8:19:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SanPham](
	[MaSP] [varchar](20) NOT NULL,
	[TenSP] [nvarchar](100) NULL,
	[MaNCC] [varchar](20) NULL,
	[SoLuongM] [int] NULL,
	[SoLuongL] [int] NULL,
	[SoLuongXL] [int] NULL,
	[GiaNhap] [float] NULL,
	[GiaSizeM] [float] NULL,
	[GiaSizeL] [float] NULL,
	[GiaSizeXL] [float] NULL,
	[MaHinh] [varchar](20) NULL,
	[Mota] [nvarchar](200) NULL,
	[MaLoai] [varchar](20) NULL,
	[trangthai] [int] NULL DEFAULT ((0)),
PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[CTHDBan] ([MaHD], [MaSP], [SoLuong], [DonGia], [ChietKhau], [thanhTien], [size], [trangthai]) VALUES (N'HDB01', N'NCC0101.ML01', 1, 30000, 1000, 29000, N'L ', 0)
INSERT [dbo].[CTHDBan] ([MaHD], [MaSP], [SoLuong], [DonGia], [ChietKhau], [thanhTien], [size], [trangthai]) VALUES (N'HDB01', N'NCC0101.ML01', 1, 20000, 1000, 19000, N'M ', 0)
INSERT [dbo].[CTHDNhap] ([MaHDNhap], [MaSP], [SoLuong], [DonGia], [thanhTien], [size], [trangthai]) VALUES (N'HDN01', N'NCC0101.ML01', 3, 10000, 30000, N'L ', 0)
INSERT [dbo].[CTHDNhap] ([MaHDNhap], [MaSP], [SoLuong], [DonGia], [thanhTien], [size], [trangthai]) VALUES (N'HDN01', N'NCC0101.ML01', 3, 10000, 30000, N'M ', 0)
INSERT [dbo].[HoaDonBan] ([MaHDBan], [MaNV], [NgayLapHD], [MaKH], [Tongtien], [trangthai]) VALUES (N'HDB01', N'NV01', CAST(N'2023-05-16 00:00:00.000' AS DateTime), N'KH01', 48000, 0)
INSERT [dbo].[HoaDonNhap] ([MaHDNhap], [MaNCC], [MaNV], [NgayNhap], [TongTien], [trangthai]) VALUES (N'HDN01', N'NCC01', N'NV01', CAST(N'2023-05-16 00:00:00.000' AS DateTime), 60000, 0)
INSERT [dbo].[KhachHang] ([MaKh], [TenKh], [Phai], [DiaChi], [Email], [Phone], [trangthai]) VALUES (N'KH01', N'Phạm Viết Tường', 0, N'Thủ Đức', N'viettuong@gmail.com', N'0355303026', 0)
INSERT [dbo].[LoaiSP] ([MaLoai], [TenLoai], [trangthai]) VALUES (N'ML01', N'Bánh kem', 0)
INSERT [dbo].[LoaiSP] ([MaLoai], [TenLoai], [trangthai]) VALUES (N'ML02', N'Bánh ngọt', 0)
INSERT [dbo].[LoaiSP] ([MaLoai], [TenLoai], [trangthai]) VALUES (N'ML03', N'Bánh mặn', 0)
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DiaChi], [Phone], [Email], [MaLoai], [trangthai]) VALUES (N'NCC01', N'Givral Bakery', N'Q.12, TP HCM', N'01111111111', N'ncc01@gmail.com', N'ML01', 0)
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DiaChi], [Phone], [Email], [MaLoai], [trangthai]) VALUES (N'NCC02', N'ABC Bakery', N'Q.11, Tp HCM', N'0222222222', N'nccc02@gmail.com', N'ML01', 0)
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DiaChi], [Phone], [Email], [MaLoai], [trangthai]) VALUES (N'NCC03', N'Monkey Bakery', N'Q.10, Tp HCM', N'0333333333', N'ncc03@gmail.com', N'ML03', 0)
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DiaChi], [Phone], [Email], [MaLoai], [trangthai]) VALUES (N'NCC04', N'Cookie Encounter', N'Q.9, Tp HCM', N'0444444444', N'ncc04@gmail.com', N'ML02', 0)
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DiaChi], [Phone], [Email], [MaLoai], [trangthai]) VALUES (N'NCC05', N'Angel Cakes', N'Q. Bình Thạnh', N'0555555555', N'ncc05@gmail.com', N'ML02', 0)
INSERT [dbo].[NhanVien] ([MaNV], [Hoten], [Phai], [NgaySinh], [DiaChi], [Phone], [trangthai]) VALUES (N'NV01', N'Nguyễn Dương Vĩ Hào', 0, CAST(N'2003-08-23 00:00:00.000' AS DateTime), N'An Giang', N'0355303024', 0)
INSERT [dbo].[NhanVien] ([MaNV], [Hoten], [Phai], [NgaySinh], [DiaChi], [Phone], [trangthai]) VALUES (N'NV02', N'Nguyễn Nhật Huy', 0, CAST(N'2003-03-12 00:00:00.000' AS DateTime), N'Bình Tân', N'0355303025', 0)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaNCC], [SoLuongM], [SoLuongL], [SoLuongXL], [GiaNhap], [GiaSizeM], [GiaSizeL], [GiaSizeXL], [MaHinh], [Mota], [MaLoai], [trangthai]) VALUES (N'NCC0101.ML01', N'Tiramisu', N'NCC01', 9, 9, 10, 10000, 20000, 30000, 40000, N'banh_kem\2.jpg', N'bánh được làm từ creamcheese và whipping cream', N'ML01', 0)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaNCC], [SoLuongM], [SoLuongL], [SoLuongXL], [GiaNhap], [GiaSizeM], [GiaSizeL], [GiaSizeXL], [MaHinh], [Mota], [MaLoai], [trangthai]) VALUES (N'NCC0201.ML01', N'Cheesecake', N'NCC02', 10, 10, 10, 11000, 22000, 33000, 44000, N'banh_kem\1.jpg', N'Bánh là sự kết hợp của vị giòn, ngọt của bánh Lady Finger', N'ML01', 0)
ALTER TABLE [dbo].[CTHDBan]  WITH CHECK ADD  CONSTRAINT [FK_MaHD_of_CTHDBan] FOREIGN KEY([MaHD])
REFERENCES [dbo].[HoaDonBan] ([MaHDBan])
GO
ALTER TABLE [dbo].[CTHDBan] CHECK CONSTRAINT [FK_MaHD_of_CTHDBan]
GO
ALTER TABLE [dbo].[CTHDBan]  WITH CHECK ADD  CONSTRAINT [FK_MaSP_of_CTHDBan] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[CTHDBan] CHECK CONSTRAINT [FK_MaSP_of_CTHDBan]
GO
ALTER TABLE [dbo].[CTHDNhap]  WITH CHECK ADD  CONSTRAINT [FK_MaHDNhap_of_CTHDNhap] FOREIGN KEY([MaHDNhap])
REFERENCES [dbo].[HoaDonNhap] ([MaHDNhap])
GO
ALTER TABLE [dbo].[CTHDNhap] CHECK CONSTRAINT [FK_MaHDNhap_of_CTHDNhap]
GO
ALTER TABLE [dbo].[CTHDNhap]  WITH CHECK ADD  CONSTRAINT [FK_MaSP_of_CTHDNhap] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[CTHDNhap] CHECK CONSTRAINT [FK_MaSP_of_CTHDNhap]
GO
ALTER TABLE [dbo].[HoaDonBan]  WITH CHECK ADD  CONSTRAINT [FK_MaKH_of_HoaDonBan] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKh])
GO
ALTER TABLE [dbo].[HoaDonBan] CHECK CONSTRAINT [FK_MaKH_of_HoaDonBan]
GO
ALTER TABLE [dbo].[HoaDonBan]  WITH CHECK ADD  CONSTRAINT [FK_MaNV_of_HoaDonBan] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[HoaDonBan] CHECK CONSTRAINT [FK_MaNV_of_HoaDonBan]
GO
ALTER TABLE [dbo].[HoaDonNhap]  WITH CHECK ADD  CONSTRAINT [FK_MaNCC_of_HDNhap] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NhaCungCap] ([MaNCC])
GO
ALTER TABLE [dbo].[HoaDonNhap] CHECK CONSTRAINT [FK_MaNCC_of_HDNhap]
GO
ALTER TABLE [dbo].[HoaDonNhap]  WITH CHECK ADD  CONSTRAINT [FK_MaNV_of_HDNhap] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[HoaDonNhap] CHECK CONSTRAINT [FK_MaNV_of_HDNhap]
GO
ALTER TABLE [dbo].[NhaCungCap]  WITH CHECK ADD  CONSTRAINT [FK_MaLoai_of_NhaCungCap] FOREIGN KEY([MaLoai])
REFERENCES [dbo].[LoaiSP] ([MaLoai])
GO
ALTER TABLE [dbo].[NhaCungCap] CHECK CONSTRAINT [FK_MaLoai_of_NhaCungCap]
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [FK_MaLoai_of_SanPham] FOREIGN KEY([MaLoai])
REFERENCES [dbo].[LoaiSP] ([MaLoai])
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [FK_MaLoai_of_SanPham]
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [FK_MaNCC_of_SanPham] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NhaCungCap] ([MaNCC])
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [FK_MaNCC_of_SanPham]
GO
USE [master]
GO
ALTER DATABASE [quanlybanBanh] SET  READ_WRITE 
GO
