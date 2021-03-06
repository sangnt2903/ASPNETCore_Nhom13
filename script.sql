USE [QLTT]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 01-12-18 1:51:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NguoiDungs]    Script Date: 01-12-18 1:51:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NguoiDungs](
	[MaNguoiDung] [int] IDENTITY(1,1) NOT NULL,
	[HoTen] [nvarchar](max) NOT NULL,
	[MatKhau] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_NguoiDungs] PRIMARY KEY CLUSTERED 
(
	[MaNguoiDung] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TheLoais]    Script Date: 01-12-18 1:51:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TheLoais](
	[MaTheLoai] [int] IDENTITY(1,1) NOT NULL,
	[TenTheLoai] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_TheLoais] PRIMARY KEY CLUSTERED 
(
	[MaTheLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TinTucs]    Script Date: 01-12-18 1:51:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TinTucs](
	[MaTin] [int] IDENTITY(1,1) NOT NULL,
	[TieuDe] [nvarchar](50) NOT NULL,
	[NoiDung] [nvarchar](max) NOT NULL,
	[Hinh] [nvarchar](max) NOT NULL,
	[NgayDang] [datetime2](7) NOT NULL,
	[MaTheLoai] [int] NOT NULL,
	[MaNguoiDung] [int] NOT NULL,
 CONSTRAINT [PK_TinTucs] PRIMARY KEY CLUSTERED 
(
	[MaTin] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[TinTucs]  WITH CHECK ADD  CONSTRAINT [FK_TinTucs_NguoiDungs_MaNguoiDung] FOREIGN KEY([MaNguoiDung])
REFERENCES [dbo].[NguoiDungs] ([MaNguoiDung])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TinTucs] CHECK CONSTRAINT [FK_TinTucs_NguoiDungs_MaNguoiDung]
GO
ALTER TABLE [dbo].[TinTucs]  WITH CHECK ADD  CONSTRAINT [FK_TinTucs_TheLoais_MaTheLoai] FOREIGN KEY([MaTheLoai])
REFERENCES [dbo].[TheLoais] ([MaTheLoai])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TinTucs] CHECK CONSTRAINT [FK_TinTucs_TheLoais_MaTheLoai]
GO
