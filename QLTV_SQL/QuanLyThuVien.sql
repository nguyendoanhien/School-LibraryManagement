USE [QLTV]
GO
/****** Object:  Table [dbo].[QuyDinhPhat]    Script Date: 11/27/2018 11:02:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuyDinhPhat](
	[MaPhat] [int] IDENTITY(1,1) NOT NULL,
	[TenPhat] [nvarchar](250) NULL,
	[PhanTramPhat] [float] NULL,
 CONSTRAINT [PK_QuyDinhPhat] PRIMARY KEY CLUSTERED 
(
	[MaPhat] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NguoiDung]    Script Date: 11/27/2018 11:02:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NguoiDung](
	[MaNguoiDung] [int] IDENTITY(1,1) NOT NULL,
	[HoVaTen] [nvarchar](255) NULL,
	[GioiTinh] [bit] NULL,
	[Email] [varchar](255) NULL,
	[NgayTao] [datetime] NULL,
 CONSTRAINT [PK_NguoiDung] PRIMARY KEY CLUSTERED 
(
	[MaNguoiDung] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[NguoiDung] ON
INSERT [dbo].[NguoiDung] ([MaNguoiDung], [HoVaTen], [GioiTinh], [Email], [NgayTao]) VALUES (7, N'Hùng', 1, N'hung@gmail.com', CAST(0x0000A9A300000000 AS DateTime))
INSERT [dbo].[NguoiDung] ([MaNguoiDung], [HoVaTen], [GioiTinh], [Email], [NgayTao]) VALUES (8, N'Hào', 1, N'hao@gmail.com', CAST(0x0000A9A300000000 AS DateTime))
INSERT [dbo].[NguoiDung] ([MaNguoiDung], [HoVaTen], [GioiTinh], [Email], [NgayTao]) VALUES (9, N'Hân', 0, N'han@gmail.com', CAST(0x0000A9A300000000 AS DateTime))
INSERT [dbo].[NguoiDung] ([MaNguoiDung], [HoVaTen], [GioiTinh], [Email], [NgayTao]) VALUES (10, N'Hiên', 0, N'hien@gmail.com', CAST(0x0000A9A100000000 AS DateTime))
INSERT [dbo].[NguoiDung] ([MaNguoiDung], [HoVaTen], [GioiTinh], [Email], [NgayTao]) VALUES (11, N'Giao', 0, N'giao@gmail.com', CAST(0x0000A99E00000000 AS DateTime))
INSERT [dbo].[NguoiDung] ([MaNguoiDung], [HoVaTen], [GioiTinh], [Email], [NgayTao]) VALUES (12, N'Truc', 0, N'truc@gmail.com', CAST(0x0000A9A30176CFF4 AS DateTime))
INSERT [dbo].[NguoiDung] ([MaNguoiDung], [HoVaTen], [GioiTinh], [Email], [NgayTao]) VALUES (19, N'00', 0, N'00', CAST(0x0000A9A301871302 AS DateTime))
INSERT [dbo].[NguoiDung] ([MaNguoiDung], [HoVaTen], [GioiTinh], [Email], [NgayTao]) VALUES (20, N'hi', 1, N'hiasfa', CAST(0x0000A9A400B82357 AS DateTime))
INSERT [dbo].[NguoiDung] ([MaNguoiDung], [HoVaTen], [GioiTinh], [Email], [NgayTao]) VALUES (21, N'hi', 1, N'ihh', CAST(0x0000A9A400BB39DD AS DateTime))
INSERT [dbo].[NguoiDung] ([MaNguoiDung], [HoVaTen], [GioiTinh], [Email], [NgayTao]) VALUES (22, N's', 1, N's', CAST(0x0000A9A400BBA20D AS DateTime))
INSERT [dbo].[NguoiDung] ([MaNguoiDung], [HoVaTen], [GioiTinh], [Email], [NgayTao]) VALUES (23, N'1', 1, N'1', CAST(0x0000A9A400BCD3C4 AS DateTime))
INSERT [dbo].[NguoiDung] ([MaNguoiDung], [HoVaTen], [GioiTinh], [Email], [NgayTao]) VALUES (24, N'1', 1, N'1', CAST(0x0000A9A400BCD3C4 AS DateTime))
INSERT [dbo].[NguoiDung] ([MaNguoiDung], [HoVaTen], [GioiTinh], [Email], [NgayTao]) VALUES (25, N'2', 1, N'2', CAST(0x0000A9A400BD46D9 AS DateTime))
INSERT [dbo].[NguoiDung] ([MaNguoiDung], [HoVaTen], [GioiTinh], [Email], [NgayTao]) VALUES (26, N'4', 1, N'4', CAST(0x0000A9A400BF309E AS DateTime))
INSERT [dbo].[NguoiDung] ([MaNguoiDung], [HoVaTen], [GioiTinh], [Email], [NgayTao]) VALUES (27, N'5', 1, N'5', CAST(0x0000A9A400C0A549 AS DateTime))
INSERT [dbo].[NguoiDung] ([MaNguoiDung], [HoVaTen], [GioiTinh], [Email], [NgayTao]) VALUES (28, N'6', 0, N'6', CAST(0x0000A9A400C141B2 AS DateTime))
INSERT [dbo].[NguoiDung] ([MaNguoiDung], [HoVaTen], [GioiTinh], [Email], [NgayTao]) VALUES (32, N'hele', 0, N'ffff', CAST(0x0000A9A400D2CED7 AS DateTime))
INSERT [dbo].[NguoiDung] ([MaNguoiDung], [HoVaTen], [GioiTinh], [Email], [NgayTao]) VALUES (33, N'hienchymbe', 1, N'hienchymbe', CAST(0x0000A9A400EDCDBE AS DateTime))
INSERT [dbo].[NguoiDung] ([MaNguoiDung], [HoVaTen], [GioiTinh], [Email], [NgayTao]) VALUES (34, N'ssssssss', 1, N'ssssssssssssss', CAST(0x0000A9A400EEFF6B AS DateTime))
INSERT [dbo].[NguoiDung] ([MaNguoiDung], [HoVaTen], [GioiTinh], [Email], [NgayTao]) VALUES (35, N'aaa', 1, N'sssdsada', CAST(0x0000A9A400EFD166 AS DateTime))
INSERT [dbo].[NguoiDung] ([MaNguoiDung], [HoVaTen], [GioiTinh], [Email], [NgayTao]) VALUES (36, N'232323232', 0, N'2222222222222222', CAST(0x0000A9A400F1FA11 AS DateTime))
INSERT [dbo].[NguoiDung] ([MaNguoiDung], [HoVaTen], [GioiTinh], [Email], [NgayTao]) VALUES (37, N'á', 1, N'á', CAST(0x0000A9A400F2A5EE AS DateTime))
INSERT [dbo].[NguoiDung] ([MaNguoiDung], [HoVaTen], [GioiTinh], [Email], [NgayTao]) VALUES (38, N'89', 0, N'9', CAST(0x0000A9A400F2FE4F AS DateTime))
INSERT [dbo].[NguoiDung] ([MaNguoiDung], [HoVaTen], [GioiTinh], [Email], [NgayTao]) VALUES (39, N'thim', 1, N'thim', CAST(0x0000A9A400F40DB7 AS DateTime))
INSERT [dbo].[NguoiDung] ([MaNguoiDung], [HoVaTen], [GioiTinh], [Email], [NgayTao]) VALUES (40, N'HienBeChum', 1, N'HienBeChum', CAST(0x0000A9A4011F22E0 AS DateTime))
INSERT [dbo].[NguoiDung] ([MaNguoiDung], [HoVaTen], [GioiTinh], [Email], [NgayTao]) VALUES (41, N'HienDuBu', 1, N'HienDuBu', CAST(0x0000A9A4011FE9F3 AS DateTime))
INSERT [dbo].[NguoiDung] ([MaNguoiDung], [HoVaTen], [GioiTinh], [Email], [NgayTao]) VALUES (42, N'aaaaaaaaaaaaaaaaaaa', 1, N'aaaaaaaaaaaaaaaaaa', CAST(0x0000A9A401207AEF AS DateTime))
SET IDENTITY_INSERT [dbo].[NguoiDung] OFF
/****** Object:  Table [dbo].[NCC]    Script Date: 11/27/2018 11:02:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NCC](
	[MaNCC] [int] IDENTITY(1,1) NOT NULL,
	[TenNCC] [nvarchar](255) NULL,
	[Email] [varchar](255) NULL,
	[Fax] [varchar](255) NULL,
 CONSTRAINT [PK_NCC] PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[NCC] ON
INSERT [dbo].[NCC] ([MaNCC], [TenNCC], [Email], [Fax]) VALUES (1, N'1', N'1A', NULL)
INSERT [dbo].[NCC] ([MaNCC], [TenNCC], [Email], [Fax]) VALUES (2, N'2', N'2A', NULL)
INSERT [dbo].[NCC] ([MaNCC], [TenNCC], [Email], [Fax]) VALUES (3, N'3', N'3a', NULL)
INSERT [dbo].[NCC] ([MaNCC], [TenNCC], [Email], [Fax]) VALUES (4, N'4', N'4A', NULL)
INSERT [dbo].[NCC] ([MaNCC], [TenNCC], [Email], [Fax]) VALUES (5, N'5', NULL, NULL)
INSERT [dbo].[NCC] ([MaNCC], [TenNCC], [Email], [Fax]) VALUES (6, N'NXB Giáo dục Việt Nam', N'nxbgiaoducvn@gmail.com', N'0938648234')
INSERT [dbo].[NCC] ([MaNCC], [TenNCC], [Email], [Fax]) VALUES (7, N'NXB Kim Đồng', N'nxbkimdongvn@gmail.com', N'0705401302')
INSERT [dbo].[NCC] ([MaNCC], [TenNCC], [Email], [Fax]) VALUES (8, N'Fahasa', N'fahasa@gmail.com', N'0587995416')
INSERT [dbo].[NCC] ([MaNCC], [TenNCC], [Email], [Fax]) VALUES (9, N'NXB Trẻ', N'nxbtre@gmail.com', N'0984753613')
INSERT [dbo].[NCC] ([MaNCC], [TenNCC], [Email], [Fax]) VALUES (10, N'Nhà sách Minh Khai', N'nhasachminhkhai@gmail.com', N'0845692323')
INSERT [dbo].[NCC] ([MaNCC], [TenNCC], [Email], [Fax]) VALUES (11, N'Nhà sách Hoa Hồng', N'nhasachhoahong@gmail.com', N'0704581223')
INSERT [dbo].[NCC] ([MaNCC], [TenNCC], [Email], [Fax]) VALUES (12, N'Công ty Đức Trí', N'ctyductri@gmail.com', N'0877779999')
SET IDENTITY_INSERT [dbo].[NCC] OFF
/****** Object:  Table [dbo].[DocGiaLoai]    Script Date: 11/27/2018 11:02:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DocGiaLoai](
	[MaLoaiDocGia] [int] IDENTITY(1,1) NOT NULL,
	[TenLoaiDocGia] [nvarchar](255) NULL,
	[SoSachToiDa] [int] NULL,
 CONSTRAINT [PK_DocGiaLoai] PRIMARY KEY CLUSTERED 
(
	[MaLoaiDocGia] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[DocGiaLoai] ON
INSERT [dbo].[DocGiaLoai] ([MaLoaiDocGia], [TenLoaiDocGia], [SoSachToiDa]) VALUES (1, N'Ty1', 1)
INSERT [dbo].[DocGiaLoai] ([MaLoaiDocGia], [TenLoaiDocGia], [SoSachToiDa]) VALUES (2, N'Ty', NULL)
INSERT [dbo].[DocGiaLoai] ([MaLoaiDocGia], [TenLoaiDocGia], [SoSachToiDa]) VALUES (3, N'Ty', NULL)
INSERT [dbo].[DocGiaLoai] ([MaLoaiDocGia], [TenLoaiDocGia], [SoSachToiDa]) VALUES (4, N'Ty', NULL)
INSERT [dbo].[DocGiaLoai] ([MaLoaiDocGia], [TenLoaiDocGia], [SoSachToiDa]) VALUES (5, N'Ty', NULL)
INSERT [dbo].[DocGiaLoai] ([MaLoaiDocGia], [TenLoaiDocGia], [SoSachToiDa]) VALUES (6, N'Ty', NULL)
INSERT [dbo].[DocGiaLoai] ([MaLoaiDocGia], [TenLoaiDocGia], [SoSachToiDa]) VALUES (8, N'Ty2', 2)
INSERT [dbo].[DocGiaLoai] ([MaLoaiDocGia], [TenLoaiDocGia], [SoSachToiDa]) VALUES (9, N'Giảng viên', 5)
INSERT [dbo].[DocGiaLoai] ([MaLoaiDocGia], [TenLoaiDocGia], [SoSachToiDa]) VALUES (10, N'Nhân viên khối văn phòng', 4)
INSERT [dbo].[DocGiaLoai] ([MaLoaiDocGia], [TenLoaiDocGia], [SoSachToiDa]) VALUES (11, N'Sinh viên', 3)
SET IDENTITY_INSERT [dbo].[DocGiaLoai] OFF
/****** Object:  Table [dbo].[DauSachLoai]    Script Date: 11/27/2018 11:02:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DauSachLoai](
	[MaLoaiDauSach] [int] NOT NULL,
	[TenLoaiDauSach] [nvarchar](100) NULL,
 CONSTRAINT [PK_DauSachLoai] PRIMARY KEY CLUSTERED 
(
	[MaLoaiDauSach] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[DauSachLoai] ([MaLoaiDauSach], [TenLoaiDauSach]) VALUES (1, N'Khoa học viễn tưởng')
INSERT [dbo].[DauSachLoai] ([MaLoaiDauSach], [TenLoaiDauSach]) VALUES (2, N'Văn học')
INSERT [dbo].[DauSachLoai] ([MaLoaiDauSach], [TenLoaiDauSach]) VALUES (3, N'Toán học')
INSERT [dbo].[DauSachLoai] ([MaLoaiDauSach], [TenLoaiDauSach]) VALUES (4, N'Công nghệ')
INSERT [dbo].[DauSachLoai] ([MaLoaiDauSach], [TenLoaiDauSach]) VALUES (5, N'Lịch sử ')
INSERT [dbo].[DauSachLoai] ([MaLoaiDauSach], [TenLoaiDauSach]) VALUES (6, N'Hoá học ')
/****** Object:  Table [dbo].[DocGia_deleted]    Script Date: 11/27/2018 11:02:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DocGia_deleted](
	[MaDocGia] [int] NOT NULL,
	[MaLoaiDocGia] [int] NULL
) ON [PRIMARY]
GO
INSERT [dbo].[DocGia_deleted] ([MaDocGia], [MaLoaiDocGia]) VALUES (6, 1)
INSERT [dbo].[DocGia_deleted] ([MaDocGia], [MaLoaiDocGia]) VALUES (15, 11)
/****** Object:  Table [dbo].[DocGia]    Script Date: 11/27/2018 11:02:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DocGia](
	[MaDocGia] [int] NOT NULL,
	[MaLoaiDocGia] [int] NULL,
 CONSTRAINT [PK_DocGia] PRIMARY KEY CLUSTERED 
(
	[MaDocGia] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[DocGia] ([MaDocGia], [MaLoaiDocGia]) VALUES (40, 9)
INSERT [dbo].[DocGia] ([MaDocGia], [MaLoaiDocGia]) VALUES (41, 11)
INSERT [dbo].[DocGia] ([MaDocGia], [MaLoaiDocGia]) VALUES (42, 9)
/****** Object:  Table [dbo].[DauSach]    Script Date: 11/27/2018 11:02:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DauSach](
	[MaDauSach] [int] IDENTITY(1,1) NOT NULL,
	[MaLoaiDauSach] [int] NULL,
	[TenDauSach] [nvarchar](255) NULL,
	[SoLuongQuyDinh] [int] NULL,
	[SoNgayMuonToiDa] [int] NULL,
	[GiaTien] [int] NULL,
 CONSTRAINT [PK_DauSach] PRIMARY KEY CLUSTERED 
(
	[MaDauSach] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 11/27/2018 11:02:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNhanVien] [int] NOT NULL,
	[MatKhau] [varchar](255) NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNhanVien] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[NhanVien] ([MaNhanVien], [MatKhau]) VALUES (7, N'hienmup')
/****** Object:  Table [dbo].[Sach]    Script Date: 11/27/2018 11:02:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sach](
	[STT] [int] IDENTITY(1,1) NOT NULL,
	[MaDauSach] [int] NOT NULL,
 CONSTRAINT [PK_Sach] PRIMARY KEY CLUSTERED 
(
	[STT] ASC,
	[MaDauSach] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[DocGia_Xoa]    Script Date: 11/27/2018 11:02:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DocGia_Xoa] @maCanXoa int 
AS
BEGIN
DELETE FROM DocGia where MaDocGia = @maCanXoa
END
GO
/****** Object:  StoredProcedure [dbo].[InsertDocGia]    Script Date: 11/27/2018 11:02:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertDocGia] @maDG int, @maLoaiDG int 
AS
BEGIN
	INSERT DocGia(MaDocGia,MaLoaiDocGia) VALUES (@maDG,@maLoaiDG);
END
GO
/****** Object:  Table [dbo].[Phieu]    Script Date: 11/27/2018 11:02:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Phieu](
	[MaPhieu] [int] NOT NULL,
	[MaNguoiLap] [int] NULL,
	[NgayLap] [datetime] NULL,
 CONSTRAINT [PK_Phieu] PRIMARY KEY CLUSTERED 
(
	[MaPhieu] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuMuon]    Script Date: 11/27/2018 11:02:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuMuon](
	[MaPhieuMuon] [int] IDENTITY(1,1) NOT NULL,
	[MaDocGia] [int] NULL,
 CONSTRAINT [PK_PhieuMuon] PRIMARY KEY CLUSTERED 
(
	[MaPhieuMuon] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[PhieuNhap_Them]    Script Date: 11/27/2018 11:02:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PhieuNhap_Them] @maPhieu int, @maNguoiLap int, @ngayLap datetime
AS
BEGIN
	INSERT INTO Phieu (MaPhieu,MaNguoiLap,NgayLap) VALUES (@maPhieu,@maNguoiLap,@ngayLap);
END
GO
/****** Object:  Table [dbo].[PhieuNhap]    Script Date: 11/27/2018 11:02:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuNhap](
	[MaPhieuNhap] [int] NOT NULL,
	[TrangThai] [bit] NULL,
 CONSTRAINT [PK_PhieuNhap] PRIMARY KEY CLUSTERED 
(
	[MaPhieuNhap] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuTra]    Script Date: 11/27/2018 11:02:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuTra](
	[MaPhieuTra] [int] IDENTITY(1,1) NOT NULL,
	[MaPhieuMuon] [int] NULL,
	[MaDocGia] [int] NULL,
 CONSTRAINT [PK_PhieuTra] PRIMARY KEY CLUSTERED 
(
	[MaPhieuTra] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuNhapChiTiet]    Script Date: 11/27/2018 11:02:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuNhapChiTiet](
	[MaDauSach] [int] NOT NULL,
	[MaPhieuNhap] [int] NOT NULL,
	[MaNCC] [int] NULL,
	[SoLuong] [int] NULL,
	[DonGia] [int] NULL,
	[NgayDuKienGiao] [datetime] NULL,
 CONSTRAINT [PK_PhieuNhapChiTiet] PRIMARY KEY CLUSTERED 
(
	[MaDauSach] ASC,
	[MaPhieuNhap] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuGiao]    Script Date: 11/27/2018 11:02:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuGiao](
	[MaPhieuGiao] [int] IDENTITY(1,1) NOT NULL,
	[MaPhieuNhap] [int] NULL,
 CONSTRAINT [PK_PhieuGiao] PRIMARY KEY CLUSTERED 
(
	[MaPhieuGiao] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuMuonChiTiet]    Script Date: 11/27/2018 11:02:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuMuonChiTiet](
	[MaSach] [int] NOT NULL,
	[MaPhieuMuon] [int] NOT NULL,
	[MaDauSach] [int] NOT NULL,
	[NgayHenTra] [datetime] NULL,
 CONSTRAINT [PK_PhieuMuonChiTiet] PRIMARY KEY CLUSTERED 
(
	[MaSach] ASC,
	[MaPhieuMuon] ASC,
	[MaDauSach] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuTraChiTiet]    Script Date: 11/27/2018 11:02:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuTraChiTiet](
	[MaSach] [int] NOT NULL,
	[MaDauSach] [int] NOT NULL,
	[MaPhieuTra] [int] NOT NULL,
	[MaNhanVienKiemTra] [int] NULL,
	[MaQuyDinh] [int] NULL,
	[NgayTra] [datetime] NULL,
	[TienPhat] [int] NULL,
 CONSTRAINT [PK_PhieuTraChiTiet] PRIMARY KEY CLUSTERED 
(
	[MaSach] ASC,
	[MaDauSach] ASC,
	[MaPhieuTra] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuGiaoChiTiet]    Script Date: 11/27/2018 11:02:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuGiaoChiTiet](
	[MaDauSach] [int] NOT NULL,
	[MaPhieuGiao] [int] NOT NULL,
 CONSTRAINT [PK_PhieuGiaoChiTiet] PRIMARY KEY CLUSTERED 
(
	[MaDauSach] ASC,
	[MaPhieuGiao] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  ForeignKey [FK_DauSach_DauSachLoai]    Script Date: 11/27/2018 11:02:07 ******/
ALTER TABLE [dbo].[DauSach]  WITH CHECK ADD  CONSTRAINT [FK_DauSach_DauSachLoai] FOREIGN KEY([MaLoaiDauSach])
REFERENCES [dbo].[DauSachLoai] ([MaLoaiDauSach])
GO
ALTER TABLE [dbo].[DauSach] CHECK CONSTRAINT [FK_DauSach_DauSachLoai]
GO
/****** Object:  ForeignKey [FK_DocGia_DocGiaLoai]    Script Date: 11/27/2018 11:02:07 ******/
ALTER TABLE [dbo].[DocGia]  WITH CHECK ADD  CONSTRAINT [FK_DocGia_DocGiaLoai] FOREIGN KEY([MaLoaiDocGia])
REFERENCES [dbo].[DocGiaLoai] ([MaLoaiDocGia])
GO
ALTER TABLE [dbo].[DocGia] CHECK CONSTRAINT [FK_DocGia_DocGiaLoai]
GO
/****** Object:  ForeignKey [FK_DocGia_NguoiDung]    Script Date: 11/27/2018 11:02:07 ******/
ALTER TABLE [dbo].[DocGia]  WITH CHECK ADD  CONSTRAINT [FK_DocGia_NguoiDung] FOREIGN KEY([MaDocGia])
REFERENCES [dbo].[NguoiDung] ([MaNguoiDung])
GO
ALTER TABLE [dbo].[DocGia] CHECK CONSTRAINT [FK_DocGia_NguoiDung]
GO
/****** Object:  ForeignKey [FK_NhanVien_NguoiDung]    Script Date: 11/27/2018 11:02:07 ******/
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_NguoiDung] FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NguoiDung] ([MaNguoiDung])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_NguoiDung]
GO
/****** Object:  ForeignKey [FK_Phieu_NhanVien]    Script Date: 11/27/2018 11:02:07 ******/
ALTER TABLE [dbo].[Phieu]  WITH CHECK ADD  CONSTRAINT [FK_Phieu_NhanVien] FOREIGN KEY([MaNguoiLap])
REFERENCES [dbo].[NhanVien] ([MaNhanVien])
GO
ALTER TABLE [dbo].[Phieu] CHECK CONSTRAINT [FK_Phieu_NhanVien]
GO
/****** Object:  ForeignKey [FK_PhieuGiao_Phieu]    Script Date: 11/27/2018 11:02:07 ******/
ALTER TABLE [dbo].[PhieuGiao]  WITH CHECK ADD  CONSTRAINT [FK_PhieuGiao_Phieu] FOREIGN KEY([MaPhieuGiao])
REFERENCES [dbo].[Phieu] ([MaPhieu])
GO
ALTER TABLE [dbo].[PhieuGiao] CHECK CONSTRAINT [FK_PhieuGiao_Phieu]
GO
/****** Object:  ForeignKey [FK_PhieuGiao_PhieuNhap]    Script Date: 11/27/2018 11:02:07 ******/
ALTER TABLE [dbo].[PhieuGiao]  WITH CHECK ADD  CONSTRAINT [FK_PhieuGiao_PhieuNhap] FOREIGN KEY([MaPhieuNhap])
REFERENCES [dbo].[PhieuNhap] ([MaPhieuNhap])
GO
ALTER TABLE [dbo].[PhieuGiao] CHECK CONSTRAINT [FK_PhieuGiao_PhieuNhap]
GO
/****** Object:  ForeignKey [FK_PhieuGiaoChiTiet_DauSach]    Script Date: 11/27/2018 11:02:07 ******/
ALTER TABLE [dbo].[PhieuGiaoChiTiet]  WITH CHECK ADD  CONSTRAINT [FK_PhieuGiaoChiTiet_DauSach] FOREIGN KEY([MaDauSach])
REFERENCES [dbo].[DauSach] ([MaDauSach])
GO
ALTER TABLE [dbo].[PhieuGiaoChiTiet] CHECK CONSTRAINT [FK_PhieuGiaoChiTiet_DauSach]
GO
/****** Object:  ForeignKey [FK_PhieuGiaoChiTiet_PhieuGiao]    Script Date: 11/27/2018 11:02:07 ******/
ALTER TABLE [dbo].[PhieuGiaoChiTiet]  WITH CHECK ADD  CONSTRAINT [FK_PhieuGiaoChiTiet_PhieuGiao] FOREIGN KEY([MaPhieuGiao])
REFERENCES [dbo].[PhieuGiao] ([MaPhieuGiao])
GO
ALTER TABLE [dbo].[PhieuGiaoChiTiet] CHECK CONSTRAINT [FK_PhieuGiaoChiTiet_PhieuGiao]
GO
/****** Object:  ForeignKey [FK_PhieuMuon_DocGia]    Script Date: 11/27/2018 11:02:07 ******/
ALTER TABLE [dbo].[PhieuMuon]  WITH CHECK ADD  CONSTRAINT [FK_PhieuMuon_DocGia] FOREIGN KEY([MaDocGia])
REFERENCES [dbo].[DocGia] ([MaDocGia])
GO
ALTER TABLE [dbo].[PhieuMuon] CHECK CONSTRAINT [FK_PhieuMuon_DocGia]
GO
/****** Object:  ForeignKey [FK_PhieuMuon_Phieu]    Script Date: 11/27/2018 11:02:07 ******/
ALTER TABLE [dbo].[PhieuMuon]  WITH CHECK ADD  CONSTRAINT [FK_PhieuMuon_Phieu] FOREIGN KEY([MaPhieuMuon])
REFERENCES [dbo].[Phieu] ([MaPhieu])
GO
ALTER TABLE [dbo].[PhieuMuon] CHECK CONSTRAINT [FK_PhieuMuon_Phieu]
GO
/****** Object:  ForeignKey [FK_PhieuMuonChiTiet_PhieuMuon]    Script Date: 11/27/2018 11:02:07 ******/
ALTER TABLE [dbo].[PhieuMuonChiTiet]  WITH CHECK ADD  CONSTRAINT [FK_PhieuMuonChiTiet_PhieuMuon] FOREIGN KEY([MaPhieuMuon])
REFERENCES [dbo].[PhieuMuon] ([MaPhieuMuon])
GO
ALTER TABLE [dbo].[PhieuMuonChiTiet] CHECK CONSTRAINT [FK_PhieuMuonChiTiet_PhieuMuon]
GO
/****** Object:  ForeignKey [FK_PhieuMuonChiTiet_Sach]    Script Date: 11/27/2018 11:02:07 ******/
ALTER TABLE [dbo].[PhieuMuonChiTiet]  WITH CHECK ADD  CONSTRAINT [FK_PhieuMuonChiTiet_Sach] FOREIGN KEY([MaSach], [MaDauSach])
REFERENCES [dbo].[Sach] ([STT], [MaDauSach])
GO
ALTER TABLE [dbo].[PhieuMuonChiTiet] CHECK CONSTRAINT [FK_PhieuMuonChiTiet_Sach]
GO
/****** Object:  ForeignKey [FK_PhieuNhap_Phieu]    Script Date: 11/27/2018 11:02:07 ******/
ALTER TABLE [dbo].[PhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_PhieuNhap_Phieu] FOREIGN KEY([MaPhieuNhap])
REFERENCES [dbo].[Phieu] ([MaPhieu])
GO
ALTER TABLE [dbo].[PhieuNhap] CHECK CONSTRAINT [FK_PhieuNhap_Phieu]
GO
/****** Object:  ForeignKey [FK_PhieuNhapChiTiet_DauSach]    Script Date: 11/27/2018 11:02:07 ******/
ALTER TABLE [dbo].[PhieuNhapChiTiet]  WITH CHECK ADD  CONSTRAINT [FK_PhieuNhapChiTiet_DauSach] FOREIGN KEY([MaDauSach])
REFERENCES [dbo].[DauSach] ([MaDauSach])
GO
ALTER TABLE [dbo].[PhieuNhapChiTiet] CHECK CONSTRAINT [FK_PhieuNhapChiTiet_DauSach]
GO
/****** Object:  ForeignKey [FK_PhieuNhapChiTiet_NCC]    Script Date: 11/27/2018 11:02:07 ******/
ALTER TABLE [dbo].[PhieuNhapChiTiet]  WITH CHECK ADD  CONSTRAINT [FK_PhieuNhapChiTiet_NCC] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NCC] ([MaNCC])
GO
ALTER TABLE [dbo].[PhieuNhapChiTiet] CHECK CONSTRAINT [FK_PhieuNhapChiTiet_NCC]
GO
/****** Object:  ForeignKey [FK_PhieuNhapChiTiet_PhieuNhap]    Script Date: 11/27/2018 11:02:07 ******/
ALTER TABLE [dbo].[PhieuNhapChiTiet]  WITH CHECK ADD  CONSTRAINT [FK_PhieuNhapChiTiet_PhieuNhap] FOREIGN KEY([MaPhieuNhap])
REFERENCES [dbo].[PhieuNhap] ([MaPhieuNhap])
GO
ALTER TABLE [dbo].[PhieuNhapChiTiet] CHECK CONSTRAINT [FK_PhieuNhapChiTiet_PhieuNhap]
GO
/****** Object:  ForeignKey [FK_PhieuTra_DocGia]    Script Date: 11/27/2018 11:02:07 ******/
ALTER TABLE [dbo].[PhieuTra]  WITH CHECK ADD  CONSTRAINT [FK_PhieuTra_DocGia] FOREIGN KEY([MaDocGia])
REFERENCES [dbo].[DocGia] ([MaDocGia])
GO
ALTER TABLE [dbo].[PhieuTra] CHECK CONSTRAINT [FK_PhieuTra_DocGia]
GO
/****** Object:  ForeignKey [FK_PhieuTra_PhieuMuon]    Script Date: 11/27/2018 11:02:07 ******/
ALTER TABLE [dbo].[PhieuTra]  WITH CHECK ADD  CONSTRAINT [FK_PhieuTra_PhieuMuon] FOREIGN KEY([MaPhieuMuon])
REFERENCES [dbo].[PhieuMuon] ([MaPhieuMuon])
GO
ALTER TABLE [dbo].[PhieuTra] CHECK CONSTRAINT [FK_PhieuTra_PhieuMuon]
GO
/****** Object:  ForeignKey [FK_PhieuTraChiTiet_NhanVien]    Script Date: 11/27/2018 11:02:07 ******/
ALTER TABLE [dbo].[PhieuTraChiTiet]  WITH CHECK ADD  CONSTRAINT [FK_PhieuTraChiTiet_NhanVien] FOREIGN KEY([MaNhanVienKiemTra])
REFERENCES [dbo].[NhanVien] ([MaNhanVien])
GO
ALTER TABLE [dbo].[PhieuTraChiTiet] CHECK CONSTRAINT [FK_PhieuTraChiTiet_NhanVien]
GO
/****** Object:  ForeignKey [FK_PhieuTraChiTiet_PhieuTra]    Script Date: 11/27/2018 11:02:07 ******/
ALTER TABLE [dbo].[PhieuTraChiTiet]  WITH CHECK ADD  CONSTRAINT [FK_PhieuTraChiTiet_PhieuTra] FOREIGN KEY([MaPhieuTra])
REFERENCES [dbo].[PhieuTra] ([MaPhieuTra])
GO
ALTER TABLE [dbo].[PhieuTraChiTiet] CHECK CONSTRAINT [FK_PhieuTraChiTiet_PhieuTra]
GO
/****** Object:  ForeignKey [FK_PhieuTraChiTiet_QuyDinhPhat]    Script Date: 11/27/2018 11:02:07 ******/
ALTER TABLE [dbo].[PhieuTraChiTiet]  WITH CHECK ADD  CONSTRAINT [FK_PhieuTraChiTiet_QuyDinhPhat] FOREIGN KEY([MaQuyDinh])
REFERENCES [dbo].[QuyDinhPhat] ([MaPhat])
GO
ALTER TABLE [dbo].[PhieuTraChiTiet] CHECK CONSTRAINT [FK_PhieuTraChiTiet_QuyDinhPhat]
GO
/****** Object:  ForeignKey [FK_PhieuTraChiTiet_Sach]    Script Date: 11/27/2018 11:02:07 ******/
ALTER TABLE [dbo].[PhieuTraChiTiet]  WITH CHECK ADD  CONSTRAINT [FK_PhieuTraChiTiet_Sach] FOREIGN KEY([MaSach], [MaDauSach])
REFERENCES [dbo].[Sach] ([STT], [MaDauSach])
GO
ALTER TABLE [dbo].[PhieuTraChiTiet] CHECK CONSTRAINT [FK_PhieuTraChiTiet_Sach]
GO
/****** Object:  ForeignKey [FK_Sach_DauSach]    Script Date: 11/27/2018 11:02:07 ******/
ALTER TABLE [dbo].[Sach]  WITH CHECK ADD  CONSTRAINT [FK_Sach_DauSach] FOREIGN KEY([MaDauSach])
REFERENCES [dbo].[DauSach] ([MaDauSach])
GO
ALTER TABLE [dbo].[Sach] CHECK CONSTRAINT [FK_Sach_DauSach]
GO
