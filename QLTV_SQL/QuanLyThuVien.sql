USE [QuanLyThuVien]
GO
/****** Object:  Table [dbo].[QuyDinhPhat]    Script Date: 11/18/2018 17:19:42 ******/
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
/****** Object:  Table [dbo].[PhieuNhap]    Script Date: 11/18/2018 17:19:42 ******/
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
/****** Object:  Table [dbo].[PhieuGiao]    Script Date: 11/18/2018 17:19:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuGiao](
	[MaPhieuGiao] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_PhieuGiao] PRIMARY KEY CLUSTERED 
(
	[MaPhieuGiao] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 11/18/2018 17:19:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNhanVien] [int] IDENTITY(1,1) NOT NULL,
	[MatKhau] [varchar](255) NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNhanVien] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DauSachLoai]    Script Date: 11/18/2018 17:19:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DauSachLoai](
	[MaLoai] [int] NOT NULL,
	[TenLoai] [nvarchar](255) NULL,
 CONSTRAINT [PK_DauSachLoai] PRIMARY KEY CLUSTERED 
(
	[MaLoai] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NCC]    Script Date: 11/18/2018 17:19:42 ******/
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
/****** Object:  Table [dbo].[DocGiaLoai]    Script Date: 11/18/2018 17:19:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DocGiaLoai](
	[MaLoai] [int] IDENTITY(1,1) NOT NULL,
	[TenLoai] [nvarchar](255) NULL,
	[SoSachToiDa] [int] NULL,
 CONSTRAINT [PK_DocGiaLoai] PRIMARY KEY CLUSTERED 
(
	[MaLoai] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DocGia]    Script Date: 11/18/2018 17:19:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DocGia](
	[MaDocGia] [int] IDENTITY(1,1) NOT NULL,
	[MaLoai] [int] NULL,
 CONSTRAINT [PK_DocGia] PRIMARY KEY CLUSTERED 
(
	[MaDocGia] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DauSach]    Script Date: 11/18/2018 17:19:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DauSach](
	[MaDauSach] [int] IDENTITY(1,1) NOT NULL,
	[MaLoai] [int] NULL,
	[TenDauSach] [nvarchar](255) NULL,
	[SoLuongQuyDinh] [int] NULL,
	[GiaTien] [int] NULL,
 CONSTRAINT [PK_DauSach] PRIMARY KEY CLUSTERED 
(
	[MaDauSach] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuNhapChiTiet]    Script Date: 11/18/2018 17:19:42 ******/
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
/****** Object:  Table [dbo].[Sach]    Script Date: 11/18/2018 17:19:42 ******/
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
/****** Object:  Table [dbo].[NguoiDung]    Script Date: 11/18/2018 17:19:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NguoiDung](
	[MaNguoiDung] [int] NOT NULL,
	[HoVaTen] [nvarchar](255) NULL,
	[GioiTinh] [bit] NULL,
	[MatKhau] [char](32) NULL,
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
/****** Object:  Table [dbo].[PhieuMuon]    Script Date: 11/18/2018 17:19:42 ******/
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
/****** Object:  Table [dbo].[PhieuGiaoChiTiet]    Script Date: 11/18/2018 17:19:42 ******/
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
/****** Object:  Table [dbo].[Phieu]    Script Date: 11/18/2018 17:19:42 ******/
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
/****** Object:  Table [dbo].[PhieuMuonChiTiet]    Script Date: 11/18/2018 17:19:42 ******/
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
/****** Object:  Table [dbo].[PhieuTra]    Script Date: 11/18/2018 17:19:42 ******/
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
/****** Object:  Table [dbo].[PhieuTraChiTiet]    Script Date: 11/18/2018 17:19:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuTraChiTiet](
	[MaSach] [int] NOT NULL,
	[MaDauSach] [int] NOT NULL,
	[MaPhieuTra] [int] NOT NULL,
	[MaNhanVienKiemTra] [int] NULL,
	[NgayTra] [datetime] NULL,
	[MaQuyDinh] [int] NULL,
	[TienPhat] [int] NULL,
 CONSTRAINT [PK_PhieuTraChiTiet] PRIMARY KEY CLUSTERED 
(
	[MaSach] ASC,
	[MaDauSach] ASC,
	[MaPhieuTra] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  ForeignKey [FK_DauSach_DauSachLoai]    Script Date: 11/18/2018 17:19:42 ******/
ALTER TABLE [dbo].[DauSach]  WITH CHECK ADD  CONSTRAINT [FK_DauSach_DauSachLoai] FOREIGN KEY([MaLoai])
REFERENCES [dbo].[DauSachLoai] ([MaLoai])
GO
ALTER TABLE [dbo].[DauSach] CHECK CONSTRAINT [FK_DauSach_DauSachLoai]
GO
/****** Object:  ForeignKey [FK_DocGia_DocGiaLoai]    Script Date: 11/18/2018 17:19:42 ******/
ALTER TABLE [dbo].[DocGia]  WITH CHECK ADD  CONSTRAINT [FK_DocGia_DocGiaLoai] FOREIGN KEY([MaLoai])
REFERENCES [dbo].[DocGiaLoai] ([MaLoai])
GO
ALTER TABLE [dbo].[DocGia] CHECK CONSTRAINT [FK_DocGia_DocGiaLoai]
GO
/****** Object:  ForeignKey [FK_NguoiDung_DocGia]    Script Date: 11/18/2018 17:19:42 ******/
ALTER TABLE [dbo].[NguoiDung]  WITH CHECK ADD  CONSTRAINT [FK_NguoiDung_DocGia] FOREIGN KEY([MaNguoiDung])
REFERENCES [dbo].[DocGia] ([MaDocGia])
GO
ALTER TABLE [dbo].[NguoiDung] CHECK CONSTRAINT [FK_NguoiDung_DocGia]
GO
/****** Object:  ForeignKey [FK_NguoiDung_NhanVien]    Script Date: 11/18/2018 17:19:42 ******/
ALTER TABLE [dbo].[NguoiDung]  WITH CHECK ADD  CONSTRAINT [FK_NguoiDung_NhanVien] FOREIGN KEY([MaNguoiDung])
REFERENCES [dbo].[NhanVien] ([MaNhanVien])
GO
ALTER TABLE [dbo].[NguoiDung] CHECK CONSTRAINT [FK_NguoiDung_NhanVien]
GO
/****** Object:  ForeignKey [FK_Phieu_NhanVien]    Script Date: 11/18/2018 17:19:42 ******/
ALTER TABLE [dbo].[Phieu]  WITH CHECK ADD  CONSTRAINT [FK_Phieu_NhanVien] FOREIGN KEY([MaNguoiLap])
REFERENCES [dbo].[NhanVien] ([MaNhanVien])
GO
ALTER TABLE [dbo].[Phieu] CHECK CONSTRAINT [FK_Phieu_NhanVien]
GO
/****** Object:  ForeignKey [FK_Phieu_PhieuGiao]    Script Date: 11/18/2018 17:19:42 ******/
ALTER TABLE [dbo].[Phieu]  WITH CHECK ADD  CONSTRAINT [FK_Phieu_PhieuGiao] FOREIGN KEY([MaPhieu])
REFERENCES [dbo].[PhieuGiao] ([MaPhieuGiao])
GO
ALTER TABLE [dbo].[Phieu] CHECK CONSTRAINT [FK_Phieu_PhieuGiao]
GO
/****** Object:  ForeignKey [FK_Phieu_PhieuMuon]    Script Date: 11/18/2018 17:19:42 ******/
ALTER TABLE [dbo].[Phieu]  WITH CHECK ADD  CONSTRAINT [FK_Phieu_PhieuMuon] FOREIGN KEY([MaPhieu])
REFERENCES [dbo].[PhieuMuon] ([MaPhieuMuon])
GO
ALTER TABLE [dbo].[Phieu] CHECK CONSTRAINT [FK_Phieu_PhieuMuon]
GO
/****** Object:  ForeignKey [FK_Phieu_PhieuNhap]    Script Date: 11/18/2018 17:19:42 ******/
ALTER TABLE [dbo].[Phieu]  WITH CHECK ADD  CONSTRAINT [FK_Phieu_PhieuNhap] FOREIGN KEY([MaPhieu])
REFERENCES [dbo].[PhieuNhap] ([MaPhieuNhap])
GO
ALTER TABLE [dbo].[Phieu] CHECK CONSTRAINT [FK_Phieu_PhieuNhap]
GO
/****** Object:  ForeignKey [FK_PhieuGiaoChiTiet_DauSach]    Script Date: 11/18/2018 17:19:42 ******/
ALTER TABLE [dbo].[PhieuGiaoChiTiet]  WITH CHECK ADD  CONSTRAINT [FK_PhieuGiaoChiTiet_DauSach] FOREIGN KEY([MaDauSach])
REFERENCES [dbo].[DauSach] ([MaDauSach])
GO
ALTER TABLE [dbo].[PhieuGiaoChiTiet] CHECK CONSTRAINT [FK_PhieuGiaoChiTiet_DauSach]
GO
/****** Object:  ForeignKey [FK_PhieuGiaoChiTiet_PhieuGiao]    Script Date: 11/18/2018 17:19:42 ******/
ALTER TABLE [dbo].[PhieuGiaoChiTiet]  WITH CHECK ADD  CONSTRAINT [FK_PhieuGiaoChiTiet_PhieuGiao] FOREIGN KEY([MaPhieuGiao])
REFERENCES [dbo].[PhieuGiao] ([MaPhieuGiao])
GO
ALTER TABLE [dbo].[PhieuGiaoChiTiet] CHECK CONSTRAINT [FK_PhieuGiaoChiTiet_PhieuGiao]
GO
/****** Object:  ForeignKey [FK_PhieuMuon_DocGia]    Script Date: 11/18/2018 17:19:42 ******/
ALTER TABLE [dbo].[PhieuMuon]  WITH CHECK ADD  CONSTRAINT [FK_PhieuMuon_DocGia] FOREIGN KEY([MaDocGia])
REFERENCES [dbo].[DocGia] ([MaDocGia])
GO
ALTER TABLE [dbo].[PhieuMuon] CHECK CONSTRAINT [FK_PhieuMuon_DocGia]
GO
/****** Object:  ForeignKey [FK_PhieuMuonChiTiet_PhieuMuon]    Script Date: 11/18/2018 17:19:42 ******/
ALTER TABLE [dbo].[PhieuMuonChiTiet]  WITH CHECK ADD  CONSTRAINT [FK_PhieuMuonChiTiet_PhieuMuon] FOREIGN KEY([MaPhieuMuon])
REFERENCES [dbo].[PhieuMuon] ([MaPhieuMuon])
GO
ALTER TABLE [dbo].[PhieuMuonChiTiet] CHECK CONSTRAINT [FK_PhieuMuonChiTiet_PhieuMuon]
GO
/****** Object:  ForeignKey [FK_PhieuMuonChiTiet_Sach]    Script Date: 11/18/2018 17:19:42 ******/
ALTER TABLE [dbo].[PhieuMuonChiTiet]  WITH CHECK ADD  CONSTRAINT [FK_PhieuMuonChiTiet_Sach] FOREIGN KEY([MaSach], [MaDauSach])
REFERENCES [dbo].[Sach] ([STT], [MaDauSach])
GO
ALTER TABLE [dbo].[PhieuMuonChiTiet] CHECK CONSTRAINT [FK_PhieuMuonChiTiet_Sach]
GO
/****** Object:  ForeignKey [FK_PhieuNhapChiTiet_DauSach]    Script Date: 11/18/2018 17:19:42 ******/
ALTER TABLE [dbo].[PhieuNhapChiTiet]  WITH CHECK ADD  CONSTRAINT [FK_PhieuNhapChiTiet_DauSach] FOREIGN KEY([MaDauSach])
REFERENCES [dbo].[DauSach] ([MaDauSach])
GO
ALTER TABLE [dbo].[PhieuNhapChiTiet] CHECK CONSTRAINT [FK_PhieuNhapChiTiet_DauSach]
GO
/****** Object:  ForeignKey [FK_PhieuNhapChiTiet_NCC]    Script Date: 11/18/2018 17:19:42 ******/
ALTER TABLE [dbo].[PhieuNhapChiTiet]  WITH CHECK ADD  CONSTRAINT [FK_PhieuNhapChiTiet_NCC] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NCC] ([MaNCC])
GO
ALTER TABLE [dbo].[PhieuNhapChiTiet] CHECK CONSTRAINT [FK_PhieuNhapChiTiet_NCC]
GO
/****** Object:  ForeignKey [FK_PhieuNhapChiTiet_PhieuNhap]    Script Date: 11/18/2018 17:19:42 ******/
ALTER TABLE [dbo].[PhieuNhapChiTiet]  WITH CHECK ADD  CONSTRAINT [FK_PhieuNhapChiTiet_PhieuNhap] FOREIGN KEY([MaPhieuNhap])
REFERENCES [dbo].[PhieuNhap] ([MaPhieuNhap])
GO
ALTER TABLE [dbo].[PhieuNhapChiTiet] CHECK CONSTRAINT [FK_PhieuNhapChiTiet_PhieuNhap]
GO
/****** Object:  ForeignKey [FK_PhieuTra_DocGia]    Script Date: 11/18/2018 17:19:42 ******/
ALTER TABLE [dbo].[PhieuTra]  WITH CHECK ADD  CONSTRAINT [FK_PhieuTra_DocGia] FOREIGN KEY([MaDocGia])
REFERENCES [dbo].[DocGia] ([MaDocGia])
GO
ALTER TABLE [dbo].[PhieuTra] CHECK CONSTRAINT [FK_PhieuTra_DocGia]
GO
/****** Object:  ForeignKey [FK_PhieuTra_PhieuMuon]    Script Date: 11/18/2018 17:19:42 ******/
ALTER TABLE [dbo].[PhieuTra]  WITH CHECK ADD  CONSTRAINT [FK_PhieuTra_PhieuMuon] FOREIGN KEY([MaPhieuMuon])
REFERENCES [dbo].[PhieuMuon] ([MaPhieuMuon])
GO
ALTER TABLE [dbo].[PhieuTra] CHECK CONSTRAINT [FK_PhieuTra_PhieuMuon]
GO
/****** Object:  ForeignKey [FK_PhieuTraChiTiet_NhanVien]    Script Date: 11/18/2018 17:19:42 ******/
ALTER TABLE [dbo].[PhieuTraChiTiet]  WITH CHECK ADD  CONSTRAINT [FK_PhieuTraChiTiet_NhanVien] FOREIGN KEY([MaNhanVienKiemTra])
REFERENCES [dbo].[NhanVien] ([MaNhanVien])
GO
ALTER TABLE [dbo].[PhieuTraChiTiet] CHECK CONSTRAINT [FK_PhieuTraChiTiet_NhanVien]
GO
/****** Object:  ForeignKey [FK_PhieuTraChiTiet_PhieuTra]    Script Date: 11/18/2018 17:19:42 ******/
ALTER TABLE [dbo].[PhieuTraChiTiet]  WITH CHECK ADD  CONSTRAINT [FK_PhieuTraChiTiet_PhieuTra] FOREIGN KEY([MaPhieuTra])
REFERENCES [dbo].[PhieuTra] ([MaPhieuTra])
GO
ALTER TABLE [dbo].[PhieuTraChiTiet] CHECK CONSTRAINT [FK_PhieuTraChiTiet_PhieuTra]
GO
/****** Object:  ForeignKey [FK_PhieuTraChiTiet_QuyDinhPhat]    Script Date: 11/18/2018 17:19:42 ******/
ALTER TABLE [dbo].[PhieuTraChiTiet]  WITH CHECK ADD  CONSTRAINT [FK_PhieuTraChiTiet_QuyDinhPhat] FOREIGN KEY([MaQuyDinh])
REFERENCES [dbo].[QuyDinhPhat] ([MaPhat])
GO
ALTER TABLE [dbo].[PhieuTraChiTiet] CHECK CONSTRAINT [FK_PhieuTraChiTiet_QuyDinhPhat]
GO
/****** Object:  ForeignKey [FK_PhieuTraChiTiet_Sach]    Script Date: 11/18/2018 17:19:42 ******/
ALTER TABLE [dbo].[PhieuTraChiTiet]  WITH CHECK ADD  CONSTRAINT [FK_PhieuTraChiTiet_Sach] FOREIGN KEY([MaSach], [MaDauSach])
REFERENCES [dbo].[Sach] ([STT], [MaDauSach])
GO
ALTER TABLE [dbo].[PhieuTraChiTiet] CHECK CONSTRAINT [FK_PhieuTraChiTiet_Sach]
GO
/****** Object:  ForeignKey [FK_Sach_DauSach]    Script Date: 11/18/2018 17:19:42 ******/
ALTER TABLE [dbo].[Sach]  WITH CHECK ADD  CONSTRAINT [FK_Sach_DauSach] FOREIGN KEY([MaDauSach])
REFERENCES [dbo].[DauSach] ([MaDauSach])
GO
ALTER TABLE [dbo].[Sach] CHECK CONSTRAINT [FK_Sach_DauSach]
GO
