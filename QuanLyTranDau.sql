USE [QuanLyTranDau]
GO
/****** Object:  Table [dbo].[CauThu]    Script Date: 07/12/2022 8:55:57 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CauThu](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TenCauThu] [nvarchar](250) NULL,
	[SoAo] [int] NULL,
	[IdViTri] [int] NULL,
	[IdDoiBong] [int] NULL,
 CONSTRAINT [PK_CauThu] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietTranDau]    Script Date: 07/12/2022 8:55:57 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietTranDau](
	[IdTranDau] [int] NOT NULL,
	[IdCauThu] [int] NOT NULL,
	[SoBanThang] [int] NULL,
 CONSTRAINT [PK_ChiTietTranDau] PRIMARY KEY CLUSTERED 
(
	[IdTranDau] ASC,
	[IdCauThu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DoiBong]    Script Date: 07/12/2022 8:55:57 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DoiBong](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MaDoi] [nvarchar](100) NULL,
	[TenDoi] [nvarchar](250) NULL,
	[TenQuocGia] [nvarchar](250) NULL,
	[SoCauThu] [int] NULL,
 CONSTRAINT [PK_DoiBong] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TranDau]    Script Date: 07/12/2022 8:55:57 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TranDau](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DoiBongA] [int] NULL,
	[DoiBongB] [int] NULL,
	[SoBanThangA] [int] NULL,
	[SoBanThangB] [int] NULL,
	[ThoiGian] [datetime] NULL,
 CONSTRAINT [PK_TranDau] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ViTri]    Script Date: 07/12/2022 8:55:57 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ViTri](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TenViTri] [nvarchar](100) NULL,
 CONSTRAINT [PK_ViTri] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[DoiBong] ON 

INSERT [dbo].[DoiBong] ([Id], [MaDoi], [TenDoi], [TenQuocGia], [SoCauThu]) VALUES (1, N'HQ', N'Hàn Quốc', N'Hàn Quốc', 10)
INSERT [dbo].[DoiBong] ([Id], [MaDoi], [TenDoi], [TenQuocGia], [SoCauThu]) VALUES (2, N'VN', N'Việt Nam', N'Việt Nam', 10)
INSERT [dbo].[DoiBong] ([Id], [MaDoi], [TenDoi], [TenQuocGia], [SoCauThu]) VALUES (3, N'EN', N'Anh', N'Anh', 10)
SET IDENTITY_INSERT [dbo].[DoiBong] OFF
GO
SET IDENTITY_INSERT [dbo].[ViTri] ON 

INSERT [dbo].[ViTri] ([Id], [TenViTri]) VALUES (1, N'Thủ môn')
INSERT [dbo].[ViTri] ([Id], [TenViTri]) VALUES (2, N'Hậu vệ')
INSERT [dbo].[ViTri] ([Id], [TenViTri]) VALUES (3, N'Tiền vệ')
INSERT [dbo].[ViTri] ([Id], [TenViTri]) VALUES (4, N'Tiền đạo')
SET IDENTITY_INSERT [dbo].[ViTri] OFF
GO
ALTER TABLE [dbo].[CauThu]  WITH CHECK ADD  CONSTRAINT [FK_CauThu_DoiBong] FOREIGN KEY([IdDoiBong])
REFERENCES [dbo].[DoiBong] ([Id])
GO
ALTER TABLE [dbo].[CauThu] CHECK CONSTRAINT [FK_CauThu_DoiBong]
GO
ALTER TABLE [dbo].[CauThu]  WITH CHECK ADD  CONSTRAINT [FK_CauThu_ViTri] FOREIGN KEY([IdViTri])
REFERENCES [dbo].[ViTri] ([Id])
GO
ALTER TABLE [dbo].[CauThu] CHECK CONSTRAINT [FK_CauThu_ViTri]
GO
ALTER TABLE [dbo].[ChiTietTranDau]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietTranDau_CauThu] FOREIGN KEY([IdCauThu])
REFERENCES [dbo].[CauThu] ([Id])
GO
ALTER TABLE [dbo].[ChiTietTranDau] CHECK CONSTRAINT [FK_ChiTietTranDau_CauThu]
GO
ALTER TABLE [dbo].[ChiTietTranDau]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietTranDau_TranDau] FOREIGN KEY([IdTranDau])
REFERENCES [dbo].[TranDau] ([Id])
GO
ALTER TABLE [dbo].[ChiTietTranDau] CHECK CONSTRAINT [FK_ChiTietTranDau_TranDau]
GO
ALTER TABLE [dbo].[TranDau]  WITH CHECK ADD  CONSTRAINT [FK_TranDau_DoiBong] FOREIGN KEY([DoiBongA])
REFERENCES [dbo].[DoiBong] ([Id])
GO
ALTER TABLE [dbo].[TranDau] CHECK CONSTRAINT [FK_TranDau_DoiBong]
GO
ALTER TABLE [dbo].[TranDau]  WITH CHECK ADD  CONSTRAINT [FK_TranDau_DoiBong1] FOREIGN KEY([DoiBongB])
REFERENCES [dbo].[DoiBong] ([Id])
GO
ALTER TABLE [dbo].[TranDau] CHECK CONSTRAINT [FK_TranDau_DoiBong1]
GO
