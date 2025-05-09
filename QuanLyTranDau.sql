USE [QuanLyTranDau]
GO
/****** Object:  Table [dbo].[CauThu]    Script Date: 07/12/2022 10:30:38 SA ******/
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
/****** Object:  Table [dbo].[ChiTietTranDau]    Script Date: 07/12/2022 10:30:38 SA ******/
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
/****** Object:  Table [dbo].[DoiBong]    Script Date: 07/12/2022 10:30:38 SA ******/
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
/****** Object:  Table [dbo].[TranDau]    Script Date: 07/12/2022 10:30:38 SA ******/
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
/****** Object:  Table [dbo].[ViTri]    Script Date: 07/12/2022 10:30:38 SA ******/
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
SET IDENTITY_INSERT [dbo].[CauThu] ON 

INSERT [dbo].[CauThu] ([Id], [TenCauThu], [SoAo], [IdViTri], [IdDoiBong]) VALUES (1, N'Trần Hạo', 3, 4, 2)
INSERT [dbo].[CauThu] ([Id], [TenCauThu], [SoAo], [IdViTri], [IdDoiBong]) VALUES (2, N'Nguyễn khanh', 7, 1, 2)
INSERT [dbo].[CauThu] ([Id], [TenCauThu], [SoAo], [IdViTri], [IdDoiBong]) VALUES (3, N'Thiên Hoàng', 10, 2, 2)
INSERT [dbo].[CauThu] ([Id], [TenCauThu], [SoAo], [IdViTri], [IdDoiBong]) VALUES (4, N'Hoàng Công', 11, 3, 2)
INSERT [dbo].[CauThu] ([Id], [TenCauThu], [SoAo], [IdViTri], [IdDoiBong]) VALUES (5, N'Kim Soon Hee', 12, 1, 1)
INSERT [dbo].[CauThu] ([Id], [TenCauThu], [SoAo], [IdViTri], [IdDoiBong]) VALUES (6, N'Lee Sung', 13, 2, 1)
INSERT [dbo].[CauThu] ([Id], [TenCauThu], [SoAo], [IdViTri], [IdDoiBong]) VALUES (7, N'Bak Sun', 1, 3, 1)
INSERT [dbo].[CauThu] ([Id], [TenCauThu], [SoAo], [IdViTri], [IdDoiBong]) VALUES (8, N'Min Ho', 22, 4, 1)
INSERT [dbo].[CauThu] ([Id], [TenCauThu], [SoAo], [IdViTri], [IdDoiBong]) VALUES (9, N'Alex', 4, 1, 3)
INSERT [dbo].[CauThu] ([Id], [TenCauThu], [SoAo], [IdViTri], [IdDoiBong]) VALUES (10, N'bansa', 55, 3, 3)
INSERT [dbo].[CauThu] ([Id], [TenCauThu], [SoAo], [IdViTri], [IdDoiBong]) VALUES (11, N'aseer', 64, 2, 3)
INSERT [dbo].[CauThu] ([Id], [TenCauThu], [SoAo], [IdViTri], [IdDoiBong]) VALUES (12, N'tiias', 76, 4, 3)
INSERT [dbo].[CauThu] ([Id], [TenCauThu], [SoAo], [IdViTri], [IdDoiBong]) VALUES (13, N'isaa', 35, 2, 9)
INSERT [dbo].[CauThu] ([Id], [TenCauThu], [SoAo], [IdViTri], [IdDoiBong]) VALUES (14, N'trreew', 76, 4, 11)
INSERT [dbo].[CauThu] ([Id], [TenCauThu], [SoAo], [IdViTri], [IdDoiBong]) VALUES (15, N'nayse', 64, 4, 11)
INSERT [dbo].[CauThu] ([Id], [TenCauThu], [SoAo], [IdViTri], [IdDoiBong]) VALUES (16, N'liiivaa', 56, 2, 11)
INSERT [dbo].[CauThu] ([Id], [TenCauThu], [SoAo], [IdViTri], [IdDoiBong]) VALUES (17, N'ronaldo', 7, 4, 12)
INSERT [dbo].[CauThu] ([Id], [TenCauThu], [SoAo], [IdViTri], [IdDoiBong]) VALUES (18, N'messi', 10, 4, 15)
INSERT [dbo].[CauThu] ([Id], [TenCauThu], [SoAo], [IdViTri], [IdDoiBong]) VALUES (19, N'neymar', 11, 4, 10)
SET IDENTITY_INSERT [dbo].[CauThu] OFF
GO
SET IDENTITY_INSERT [dbo].[DoiBong] ON 

INSERT [dbo].[DoiBong] ([Id], [MaDoi], [TenDoi], [TenQuocGia], [SoCauThu]) VALUES (1, N'HQ', N'Hàn Quốc', N'Hàn Quốc', 10)
INSERT [dbo].[DoiBong] ([Id], [MaDoi], [TenDoi], [TenQuocGia], [SoCauThu]) VALUES (2, N'VN', N'Việt Nam', N'Việt Nam', 10)
INSERT [dbo].[DoiBong] ([Id], [MaDoi], [TenDoi], [TenQuocGia], [SoCauThu]) VALUES (3, N'EN', N'Anh', N'Anh', 10)
INSERT [dbo].[DoiBong] ([Id], [MaDoi], [TenDoi], [TenQuocGia], [SoCauThu]) VALUES (5, N'TQ', N'Trung Quốc ', N'Trung Quốc', 10)
INSERT [dbo].[DoiBong] ([Id], [MaDoi], [TenDoi], [TenQuocGia], [SoCauThu]) VALUES (6, N'LA', N'Lào', N'Lào', 10)
INSERT [dbo].[DoiBong] ([Id], [MaDoi], [TenDoi], [TenQuocGia], [SoCauThu]) VALUES (7, N'CA', N'Campuchia', N'Campuchia', 10)
INSERT [dbo].[DoiBong] ([Id], [MaDoi], [TenDoi], [TenQuocGia], [SoCauThu]) VALUES (8, N'NB', N'Nhật Bản', N'Nhật Bản', 10)
INSERT [dbo].[DoiBong] ([Id], [MaDoi], [TenDoi], [TenQuocGia], [SoCauThu]) VALUES (9, N'USA', N'Mỹ', N'Mỹ', 10)
INSERT [dbo].[DoiBong] ([Id], [MaDoi], [TenDoi], [TenQuocGia], [SoCauThu]) VALUES (10, N'BZ', N'Brazil', N'Brazil', 10)
INSERT [dbo].[DoiBong] ([Id], [MaDoi], [TenDoi], [TenQuocGia], [SoCauThu]) VALUES (11, N'TBN', N'Tây Ban Nha', N'Tây Ban Nha', 10)
INSERT [dbo].[DoiBong] ([Id], [MaDoi], [TenDoi], [TenQuocGia], [SoCauThu]) VALUES (12, N'BDN', N'Bồ Đào Nha', N'Bồ Đào Nha', 10)
INSERT [dbo].[DoiBong] ([Id], [MaDoi], [TenDoi], [TenQuocGia], [SoCauThu]) VALUES (13, N'ITA', N'italia', N'italia', 10)
INSERT [dbo].[DoiBong] ([Id], [MaDoi], [TenDoi], [TenQuocGia], [SoCauThu]) VALUES (14, N'SG', N'Singapo', N'Singapo', 10)
INSERT [dbo].[DoiBong] ([Id], [MaDoi], [TenDoi], [TenQuocGia], [SoCauThu]) VALUES (15, N'AG', N'agentina', N'agentina', 10)
INSERT [dbo].[DoiBong] ([Id], [MaDoi], [TenDoi], [TenQuocGia], [SoCauThu]) VALUES (16, N'PL', N'Philipin', N'Philipin', 10)
INSERT [dbo].[DoiBong] ([Id], [MaDoi], [TenDoi], [TenQuocGia], [SoCauThu]) VALUES (17, N'FR', N'Pháp', N'Pháp', 10)
SET IDENTITY_INSERT [dbo].[DoiBong] OFF
GO
SET IDENTITY_INSERT [dbo].[TranDau] ON 

INSERT [dbo].[TranDau] ([Id], [DoiBongA], [DoiBongB], [SoBanThangA], [SoBanThangB], [ThoiGian]) VALUES (2, 2, 1, 2, 1, CAST(N'2022-12-15T09:55:00.000' AS DateTime))
INSERT [dbo].[TranDau] ([Id], [DoiBongA], [DoiBongB], [SoBanThangA], [SoBanThangB], [ThoiGian]) VALUES (3, 3, 2, 1, 3, CAST(N'2022-03-16T12:05:00.000' AS DateTime))
INSERT [dbo].[TranDau] ([Id], [DoiBongA], [DoiBongB], [SoBanThangA], [SoBanThangB], [ThoiGian]) VALUES (4, 11, 3, 1, 2, CAST(N'2022-08-04T10:15:00.000' AS DateTime))
INSERT [dbo].[TranDau] ([Id], [DoiBongA], [DoiBongB], [SoBanThangA], [SoBanThangB], [ThoiGian]) VALUES (5, 11, 3, 1, 4, CAST(N'2022-10-06T10:15:00.000' AS DateTime))
INSERT [dbo].[TranDau] ([Id], [DoiBongA], [DoiBongB], [SoBanThangA], [SoBanThangB], [ThoiGian]) VALUES (6, 12, 7, 1, 5, CAST(N'2022-07-09T10:15:00.000' AS DateTime))
INSERT [dbo].[TranDau] ([Id], [DoiBongA], [DoiBongB], [SoBanThangA], [SoBanThangB], [ThoiGian]) VALUES (7, 10, 8, 4, 1, CAST(N'2022-12-06T10:16:00.000' AS DateTime))
INSERT [dbo].[TranDau] ([Id], [DoiBongA], [DoiBongB], [SoBanThangA], [SoBanThangB], [ThoiGian]) VALUES (8, 8, 8, 1, 6, CAST(N'2022-09-06T10:16:00.000' AS DateTime))
INSERT [dbo].[TranDau] ([Id], [DoiBongA], [DoiBongB], [SoBanThangA], [SoBanThangB], [ThoiGian]) VALUES (9, 8, 6, 2, 5, CAST(N'2022-12-18T10:17:00.000' AS DateTime))
INSERT [dbo].[TranDau] ([Id], [DoiBongA], [DoiBongB], [SoBanThangA], [SoBanThangB], [ThoiGian]) VALUES (10, 3, 9, 2, 5, CAST(N'2022-12-11T10:17:00.000' AS DateTime))
INSERT [dbo].[TranDau] ([Id], [DoiBongA], [DoiBongB], [SoBanThangA], [SoBanThangB], [ThoiGian]) VALUES (11, 14, 13, 5, 3, CAST(N'2022-09-09T01:20:00.000' AS DateTime))
INSERT [dbo].[TranDau] ([Id], [DoiBongA], [DoiBongB], [SoBanThangA], [SoBanThangB], [ThoiGian]) VALUES (12, 16, 15, 21, 4, CAST(N'2022-12-07T10:21:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[TranDau] OFF
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
