USE [stajyer]
GO
/****** Object:  Table [dbo].[tbl_baslangicBitisTarih]    Script Date: 12.07.2021 10:13:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_baslangicBitisTarih](
	[IND] [int] IDENTITY(1,1) NOT NULL,
	[FIRMANO] [int] NULL,
	[BASLANGICTARİH] [date] NULL,
	[BİTİSTARİH] [date] NULL,
 CONSTRAINT [PK_tbl_baslangicBitisTarih] PRIMARY KEY CLUSTERED 
(
	[IND] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_firmaTipi]    Script Date: 12.07.2021 10:13:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_firmaTipi](
	[IND] [int] IDENTITY(1,1) NOT NULL,
	[FIRMANO] [int] NULL,
	[FIRMATİPİ] [nvarchar](50) NULL,
 CONSTRAINT [PK_tbl_firmaTipi] PRIMARY KEY CLUSTERED 
(
	[IND] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_hizmetturu]    Script Date: 12.07.2021 10:13:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_hizmetturu](
	[IND] [int] IDENTITY(1,1) NOT NULL,
	[FIRMANO] [int] NULL,
	[HIZMETTURU] [nvarchar](50) NULL,
 CONSTRAINT [PK_tbl_hizmettürü] PRIMARY KEY CLUSTERED 
(
	[IND] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_marka]    Script Date: 12.07.2021 10:13:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_marka](
	[IND] [int] IDENTITY(1,1) NOT NULL,
	[FIRMANO] [int] NULL,
	[MARKAADI] [nvarchar](50) NULL,
 CONSTRAINT [PK_tbl_marka] PRIMARY KEY CLUSTERED 
(
	[IND] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_sektor]    Script Date: 12.07.2021 10:13:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_sektor](
	[IND] [int] IDENTITY(1,1) NOT NULL,
	[FIRMANO] [int] NULL,
	[SEKTORADI] [nvarchar](50) NULL,
 CONSTRAINT [PK_tbl_sektor] PRIMARY KEY CLUSTERED 
(
	[IND] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_status]    Script Date: 12.07.2021 10:13:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_status](
	[IND] [int] IDENTITY(1,1) NOT NULL,
	[STATUS] [bit] NULL,
 CONSTRAINT [PK_tbl_status] PRIMARY KEY CLUSTERED 
(
	[IND] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Yetkili]    Script Date: 12.07.2021 10:13:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Yetkili](
	[IND] [int] IDENTITY(1,1) NOT NULL,
	[FIRMANO] [int] NULL,
	[AD] [nvarchar](50) NULL,
	[SOYAD] [nvarchar](50) NULL,
	[TELEFON] [nvarchar](50) NULL,
	[MAIL] [nvarchar](50) NULL,
	[DGMTARİH] [date] NULL,
	[KOD1] [nvarchar](50) NULL,
	[KOD2] [nvarchar](50) NULL,
	[KOD3] [nvarchar](50) NULL,
	[KOD4] [nvarchar](50) NULL,
	[KOD5] [nvarchar](50) NULL,
 CONSTRAINT [PK_tbl_Yetkili] PRIMARY KEY CLUSTERED 
(
	[IND] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_cari]    Script Date: 12.07.2021 10:13:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_cari](
	[IND] [int] IDENTITY(1,1) NOT NULL,
	[FIRMAKODU] [nvarchar](50) NULL,
	[FIRMAADI] [nvarchar](50) NULL,
	[YETKILI] [int] NULL,
	[VERGIDAIRESI] [nvarchar](50) NULL,
	[VERGINO] [nvarchar](15) NULL,
	[KAYITTARIHI] [date] NULL,
	[ISKONTO] [decimal](28, 8) NULL,
	[FIRMATIPI] [int] NULL,
	[KOD1] [nvarchar](50) NULL,
	[KOD2] [nvarchar](50) NULL,
	[KOD3] [nvarchar](50) NULL,
	[KOD4] [nvarchar](50) NULL,
	[KOD5] [nvarchar](50) NULL,
	[ADI] [nvarchar](40) NULL,
	[SOYAD] [nvarchar](40) NULL,
	[UNVAN] [nvarchar](255) NULL,
	[SEKTOR] [int] NULL,
	[MARKA] [int] NULL,
	[EMAIL] [nvarchar](100) NULL,
	[URL] [nvarchar](30) NULL,
	[TELEFON1] [nvarchar](20) NULL,
	[TELEFON2] [nvarchar](20) NULL,
	[ADRESFATURA] [ntext] NULL,
	[ADRESSEVK] [ntext] NULL,
	[PARABIRIMI] [nvarchar](3) NULL,
	[IL] [nvarchar](60) NULL,
	[SEHIR] [nvarchar](25) NULL,
	[PERSONELNO] [int] NULL,
	[STATUS] [int] NULL,
	[YETKİLİDGMTARİH] [date] NULL,
	[HIZMETTURU] [int] NULL,
	[BASBITTAR] [int] NULL,
	[PersonelYorum] [int] NULL,
 CONSTRAINT [PK_tbl_cari] PRIMARY KEY CLUSTERED 
(
	[IND] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  View [dbo].[ViewCari]    Script Date: 12.07.2021 10:13:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[ViewCari]
AS
SELECT dbo.tbl_Yetkili.FIRMANO AS Expr3, dbo.tbl_Yetkili.AD, dbo.tbl_Yetkili.IND AS Expr4, dbo.tbl_Yetkili.SOYAD AS Expr14, dbo.tbl_Yetkili.TELEFON, dbo.tbl_Yetkili.MAIL, dbo.tbl_Yetkili.DGMTARİH, dbo.tbl_baslangicBitisTarih.BİTİSTARİH, 
                  dbo.tbl_baslangicBitisTarih.BASLANGICTARİH, dbo.tbl_baslangicBitisTarih.FIRMANO AS Expr1, dbo.tbl_baslangicBitisTarih.IND AS Expr2, dbo.tbl_status.IND AS Expr5, dbo.tbl_status.FIRMANO AS Expr6, dbo.tbl_status.STATUS AS Expr15, 
                  dbo.tbl_hizmetturu.IND AS Expr7, dbo.tbl_hizmetturu.FIRMANO AS Expr8, dbo.tbl_hizmetturu.HIZMETTURU AS Expr16, dbo.tbl_sektor.IND AS Expr9, dbo.tbl_sektor.FIRMANO AS Expr10, dbo.tbl_sektor.SEKTORADI AS Expr11, 
                  dbo.tbl_firmaTipi.IND AS Expr17, dbo.tbl_firmaTipi.FIRMANO, dbo.tbl_firmaTipi.FIRMATİPİ, dbo.tbl_marka.IND AS Expr12, dbo.tbl_marka.FIRMANO AS Expr13, dbo.tbl_marka.MARKAADI, dbo.tbl_cari.*
FROM     dbo.tbl_Yetkili INNER JOIN
                  dbo.tbl_status ON dbo.tbl_Yetkili.IND = dbo.tbl_status.IND INNER JOIN
                  dbo.tbl_sektor ON dbo.tbl_Yetkili.IND = dbo.tbl_sektor.IND INNER JOIN
                  dbo.tbl_marka ON dbo.tbl_Yetkili.IND = dbo.tbl_marka.IND INNER JOIN
                  dbo.tbl_hizmetturu ON dbo.tbl_Yetkili.IND = dbo.tbl_hizmetturu.IND INNER JOIN
                  dbo.tbl_firmaTipi ON dbo.tbl_Yetkili.IND = dbo.tbl_firmaTipi.IND INNER JOIN
                  dbo.tbl_cari ON dbo.tbl_Yetkili.IND = dbo.tbl_cari.IND INNER JOIN
                  dbo.tbl_baslangicBitisTarih ON dbo.tbl_Yetkili.IND = dbo.tbl_baslangicBitisTarih.IND
GO
/****** Object:  Table [dbo].[tbl_personel]    Script Date: 12.07.2021 10:13:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_personel](
	[IND] [int] IDENTITY(1,1) NOT NULL,
	[PERSONELAD] [nvarchar](50) NULL,
	[PERSONELSOYAD] [nvarchar](50) NULL,
	[PERSONELMAİL] [nvarchar](45) NULL,
	[PERSONELTC] [nvarchar](11) NULL,
	[PERSONELTEL] [nvarchar](15) NULL,
	[PERSONELADRES] [nvarchar](250) NULL,
	[PERSONELDURUM] [bit] NULL,
 CONSTRAINT [PK_tbl_personel] PRIMARY KEY CLUSTERED 
(
	[IND] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_user]    Script Date: 12.07.2021 10:13:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_user](
	[IND] [int] IDENTITY(1,1) NOT NULL,
	[AD] [nvarchar](50) NULL,
	[SOYAD] [nvarchar](50) NULL,
	[KULLANICIADI] [nvarchar](50) NULL,
	[PASSWORD] [nvarchar](50) NULL,
 CONSTRAINT [PK_tbl_user] PRIMARY KEY CLUSTERED 
(
	[IND] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_yorum]    Script Date: 12.07.2021 10:13:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_yorum](
	[IND] [int] IDENTITY(1,1) NOT NULL,
	[YORUM] [varchar](250) NULL,
	[PersonelNo] [int] NULL,
 CONSTRAINT [PK_tbl_yorum] PRIMARY KEY CLUSTERED 
(
	[IND] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tbl_baslangicBitisTarih] ON 

INSERT [dbo].[tbl_baslangicBitisTarih] ([IND], [FIRMANO], [BASLANGICTARİH], [BİTİSTARİH]) VALUES (1, 1, CAST(N'2021-06-20' AS Date), CAST(N'2021-07-19' AS Date))
INSERT [dbo].[tbl_baslangicBitisTarih] ([IND], [FIRMANO], [BASLANGICTARİH], [BİTİSTARİH]) VALUES (2, 2, CAST(N'2019-06-20' AS Date), CAST(N'2021-07-19' AS Date))
INSERT [dbo].[tbl_baslangicBitisTarih] ([IND], [FIRMANO], [BASLANGICTARİH], [BİTİSTARİH]) VALUES (3, 3, CAST(N'2021-07-01' AS Date), CAST(N'2021-07-29' AS Date))
INSERT [dbo].[tbl_baslangicBitisTarih] ([IND], [FIRMANO], [BASLANGICTARİH], [BİTİSTARİH]) VALUES (49, 49, CAST(N'2021-07-06' AS Date), CAST(N'2021-07-19' AS Date))
INSERT [dbo].[tbl_baslangicBitisTarih] ([IND], [FIRMANO], [BASLANGICTARİH], [BİTİSTARİH]) VALUES (51, NULL, CAST(N'2021-07-08' AS Date), CAST(N'2021-07-13' AS Date))
INSERT [dbo].[tbl_baslangicBitisTarih] ([IND], [FIRMANO], [BASLANGICTARİH], [BİTİSTARİH]) VALUES (56, NULL, CAST(N'2021-07-08' AS Date), CAST(N'2021-07-08' AS Date))
INSERT [dbo].[tbl_baslangicBitisTarih] ([IND], [FIRMANO], [BASLANGICTARİH], [BİTİSTARİH]) VALUES (58, NULL, CAST(N'2021-07-08' AS Date), CAST(N'2021-07-08' AS Date))
INSERT [dbo].[tbl_baslangicBitisTarih] ([IND], [FIRMANO], [BASLANGICTARİH], [BİTİSTARİH]) VALUES (1059, NULL, CAST(N'2021-07-08' AS Date), CAST(N'2021-07-08' AS Date))
INSERT [dbo].[tbl_baslangicBitisTarih] ([IND], [FIRMANO], [BASLANGICTARİH], [BİTİSTARİH]) VALUES (1060, NULL, CAST(N'2021-07-08' AS Date), CAST(N'2021-07-08' AS Date))
INSERT [dbo].[tbl_baslangicBitisTarih] ([IND], [FIRMANO], [BASLANGICTARİH], [BİTİSTARİH]) VALUES (1061, NULL, CAST(N'2021-07-08' AS Date), CAST(N'2021-07-08' AS Date))
INSERT [dbo].[tbl_baslangicBitisTarih] ([IND], [FIRMANO], [BASLANGICTARİH], [BİTİSTARİH]) VALUES (1062, NULL, CAST(N'2021-07-08' AS Date), CAST(N'2022-07-08' AS Date))
INSERT [dbo].[tbl_baslangicBitisTarih] ([IND], [FIRMANO], [BASLANGICTARİH], [BİTİSTARİH]) VALUES (1063, NULL, CAST(N'2021-07-09' AS Date), CAST(N'2021-07-09' AS Date))
INSERT [dbo].[tbl_baslangicBitisTarih] ([IND], [FIRMANO], [BASLANGICTARİH], [BİTİSTARİH]) VALUES (1064, NULL, CAST(N'2021-07-09' AS Date), CAST(N'2021-07-09' AS Date))
INSERT [dbo].[tbl_baslangicBitisTarih] ([IND], [FIRMANO], [BASLANGICTARİH], [BİTİSTARİH]) VALUES (1065, NULL, CAST(N'2021-07-09' AS Date), CAST(N'2021-07-09' AS Date))
INSERT [dbo].[tbl_baslangicBitisTarih] ([IND], [FIRMANO], [BASLANGICTARİH], [BİTİSTARİH]) VALUES (1066, NULL, CAST(N'2021-07-09' AS Date), CAST(N'2021-07-09' AS Date))
SET IDENTITY_INSERT [dbo].[tbl_baslangicBitisTarih] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_cari] ON 

INSERT [dbo].[tbl_cari] ([IND], [FIRMAKODU], [FIRMAADI], [YETKILI], [VERGIDAIRESI], [VERGINO], [KAYITTARIHI], [ISKONTO], [FIRMATIPI], [KOD1], [KOD2], [KOD3], [KOD4], [KOD5], [ADI], [SOYAD], [UNVAN], [SEKTOR], [MARKA], [EMAIL], [URL], [TELEFON1], [TELEFON2], [ADRESFATURA], [ADRESSEVK], [PARABIRIMI], [IL], [SEHIR], [PERSONELNO], [STATUS], [YETKİLİDGMTARİH], [HIZMETTURU], [BASBITTAR], [PersonelYorum]) VALUES (2, N'F100D200', N'Samsung', 2, N'Ankara VD', N'2', CAST(N'2021-02-14' AS Date), CAST(1.00000000 AS Decimal(28, 8)), 3, NULL, NULL, NULL, NULL, NULL, N'Mahmut', N'Demir', N'Unvan1', 3, 2, N'mahmut@gmail.com', N'https://google.com', N'1234567', N'23245654', N'2', N'2', N'USD', N'Ankara', N'Ankara', 4, 2, CAST(N'1888-05-02' AS Date), 2, 1, 1)
INSERT [dbo].[tbl_cari] ([IND], [FIRMAKODU], [FIRMAADI], [YETKILI], [VERGIDAIRESI], [VERGINO], [KAYITTARIHI], [ISKONTO], [FIRMATIPI], [KOD1], [KOD2], [KOD3], [KOD4], [KOD5], [ADI], [SOYAD], [UNVAN], [SEKTOR], [MARKA], [EMAIL], [URL], [TELEFON1], [TELEFON2], [ADRESFATURA], [ADRESSEVK], [PARABIRIMI], [IL], [SEHIR], [PERSONELNO], [STATUS], [YETKİLİDGMTARİH], [HIZMETTURU], [BASBITTAR], [PersonelYorum]) VALUES (3, N'F100D300', N'Logitech', 3, N'Düzce VD', N'2', CAST(N'2021-02-16' AS Date), CAST(1.00000000 AS Decimal(28, 8)), 3, NULL, NULL, NULL, NULL, NULL, N'Ali', N'Gümüş', N'Unvan2', 2, 3, N'ali@gmail.com', N'https://google.com', N'0987654321', N'53252324234', N'3', N'3', N'EUR', N'Sivas', N'İstanbul', 5, 1, CAST(N'1888-05-02' AS Date), 3, 2, 2)
INSERT [dbo].[tbl_cari] ([IND], [FIRMAKODU], [FIRMAADI], [YETKILI], [VERGIDAIRESI], [VERGINO], [KAYITTARIHI], [ISKONTO], [FIRMATIPI], [KOD1], [KOD2], [KOD3], [KOD4], [KOD5], [ADI], [SOYAD], [UNVAN], [SEKTOR], [MARKA], [EMAIL], [URL], [TELEFON1], [TELEFON2], [ADRESFATURA], [ADRESSEVK], [PARABIRIMI], [IL], [SEHIR], [PERSONELNO], [STATUS], [YETKİLİDGMTARİH], [HIZMETTURU], [BASBITTAR], [PersonelYorum]) VALUES (5, N'F35D850', N'Asus', 19, N'Sivas VD', N'v182094567', CAST(N'2021-07-01' AS Date), CAST(25.00000000 AS Decimal(28, 8)), 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 3, NULL, N'oley@gmail.com', N'www.bombabomba.com', N'4233213221', N'4412321312', N'İş', N'Ev', N'TL', NULL, N'Sivas', 1, 1, NULL, 3, 3, 3)
INSERT [dbo].[tbl_cari] ([IND], [FIRMAKODU], [FIRMAADI], [YETKILI], [VERGIDAIRESI], [VERGINO], [KAYITTARIHI], [ISKONTO], [FIRMATIPI], [KOD1], [KOD2], [KOD3], [KOD4], [KOD5], [ADI], [SOYAD], [UNVAN], [SEKTOR], [MARKA], [EMAIL], [URL], [TELEFON1], [TELEFON2], [ADRESFATURA], [ADRESSEVK], [PARABIRIMI], [IL], [SEHIR], [PERSONELNO], [STATUS], [YETKİLİDGMTARİH], [HIZMETTURU], [BASBITTAR], [PersonelYorum]) VALUES (15, N'F5644520', N'HP', 1, N'Düzce Merkez', N'1', CAST(N'2021-07-08' AS Date), CAST(1.00000000 AS Decimal(28, 8)), 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'Hp@gmail.com', N'www.hp.com', N'03805244546', N'1236548996', N'2', N'', N'TL', N'Düzce', N'Düzce', 1, 1, NULL, 1, 51, 1004)
INSERT [dbo].[tbl_cari] ([IND], [FIRMAKODU], [FIRMAADI], [YETKILI], [VERGIDAIRESI], [VERGINO], [KAYITTARIHI], [ISKONTO], [FIRMATIPI], [KOD1], [KOD2], [KOD3], [KOD4], [KOD5], [ADI], [SOYAD], [UNVAN], [SEKTOR], [MARKA], [EMAIL], [URL], [TELEFON1], [TELEFON2], [ADRESFATURA], [ADRESSEVK], [PARABIRIMI], [IL], [SEHIR], [PERSONELNO], [STATUS], [YETKİLİDGMTARİH], [HIZMETTURU], [BASBITTAR], [PersonelYorum]) VALUES (18, N'', N'Siemens', 35, N'', N'', CAST(N'2021-07-08' AS Date), CAST(0.00000000 AS Decimal(28, 8)), 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'', 2, NULL, N'', N'', N'', N'', N'', N'', N'USD', N'', N'', 2, 1, NULL, 1, 56, 1005)
INSERT [dbo].[tbl_cari] ([IND], [FIRMAKODU], [FIRMAADI], [YETKILI], [VERGIDAIRESI], [VERGINO], [KAYITTARIHI], [ISKONTO], [FIRMATIPI], [KOD1], [KOD2], [KOD3], [KOD4], [KOD5], [ADI], [SOYAD], [UNVAN], [SEKTOR], [MARKA], [EMAIL], [URL], [TELEFON1], [TELEFON2], [ADRESFATURA], [ADRESSEVK], [PARABIRIMI], [IL], [SEHIR], [PERSONELNO], [STATUS], [YETKİLİDGMTARİH], [HIZMETTURU], [BASBITTAR], [PersonelYorum]) VALUES (20, N'', N'Beko', 37, N'', N'', CAST(N'2021-07-08' AS Date), CAST(0.00000000 AS Decimal(28, 8)), 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'', 1, NULL, N'', N'', N'', N'', N'', N'', N'TL', N'', N'', 2, 1, NULL, 2, 1062, 4)
INSERT [dbo].[tbl_cari] ([IND], [FIRMAKODU], [FIRMAADI], [YETKILI], [VERGIDAIRESI], [VERGINO], [KAYITTARIHI], [ISKONTO], [FIRMATIPI], [KOD1], [KOD2], [KOD3], [KOD4], [KOD5], [ADI], [SOYAD], [UNVAN], [SEKTOR], [MARKA], [EMAIL], [URL], [TELEFON1], [TELEFON2], [ADRESFATURA], [ADRESSEVK], [PARABIRIMI], [IL], [SEHIR], [PERSONELNO], [STATUS], [YETKİLİDGMTARİH], [HIZMETTURU], [BASBITTAR], [PersonelYorum]) VALUES (1024, N'', N'Casper', 1039, N'', N'', CAST(N'2021-07-08' AS Date), CAST(0.00000000 AS Decimal(28, 8)), 3, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'', 3, NULL, N'', N'', N'', N'', N'', N'', N'USD', N'', N'', 1, 1, NULL, 2, 1061, 1009)
INSERT [dbo].[tbl_cari] ([IND], [FIRMAKODU], [FIRMAADI], [YETKILI], [VERGIDAIRESI], [VERGINO], [KAYITTARIHI], [ISKONTO], [FIRMATIPI], [KOD1], [KOD2], [KOD3], [KOD4], [KOD5], [ADI], [SOYAD], [UNVAN], [SEKTOR], [MARKA], [EMAIL], [URL], [TELEFON1], [TELEFON2], [ADRESFATURA], [ADRESSEVK], [PARABIRIMI], [IL], [SEHIR], [PERSONELNO], [STATUS], [YETKİLİDGMTARİH], [HIZMETTURU], [BASBITTAR], [PersonelYorum]) VALUES (1025, N'F680D110', N'TGM', 1040, N'VD81340658', N'81340658', CAST(N'2021-07-09' AS Date), CAST(15.00000000 AS Decimal(28, 8)), 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'Boss', 1, NULL, N'tgmkulevinc@gmail.com', N'www.tgmkulevinc.com', N'6544567687', N'6544569030', N'ORGANİZE SANAYİ', N'ORGANİZE SANAYİ', N'EUR', N'Düzce', NULL, 3, 1, NULL, 2, 1063, 1010)
INSERT [dbo].[tbl_cari] ([IND], [FIRMAKODU], [FIRMAADI], [YETKILI], [VERGIDAIRESI], [VERGINO], [KAYITTARIHI], [ISKONTO], [FIRMATIPI], [KOD1], [KOD2], [KOD3], [KOD4], [KOD5], [ADI], [SOYAD], [UNVAN], [SEKTOR], [MARKA], [EMAIL], [URL], [TELEFON1], [TELEFON2], [ADRESFATURA], [ADRESSEVK], [PARABIRIMI], [IL], [SEHIR], [PERSONELNO], [STATUS], [YETKİLİDGMTARİH], [HIZMETTURU], [BASBITTAR], [PersonelYorum]) VALUES (1026, N'', N'', 1041, N'', N'', CAST(N'2021-07-09' AS Date), CAST(0.00000000 AS Decimal(28, 8)), NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'', NULL, NULL, N'', N'', N'', N'', N'', N'', N'', N'', NULL, 1, NULL, NULL, NULL, 1064, 1012)
INSERT [dbo].[tbl_cari] ([IND], [FIRMAKODU], [FIRMAADI], [YETKILI], [VERGIDAIRESI], [VERGINO], [KAYITTARIHI], [ISKONTO], [FIRMATIPI], [KOD1], [KOD2], [KOD3], [KOD4], [KOD5], [ADI], [SOYAD], [UNVAN], [SEKTOR], [MARKA], [EMAIL], [URL], [TELEFON1], [TELEFON2], [ADRESFATURA], [ADRESSEVK], [PARABIRIMI], [IL], [SEHIR], [PERSONELNO], [STATUS], [YETKİLİDGMTARİH], [HIZMETTURU], [BASBITTAR], [PersonelYorum]) VALUES (1027, N'', N'', 1042, N'', N'', CAST(N'2021-07-09' AS Date), CAST(0.00000000 AS Decimal(28, 8)), NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'', NULL, NULL, N'', N'', N'', N'', N'', N'', N'', N'', NULL, 1, NULL, NULL, NULL, 1065, 1013)
INSERT [dbo].[tbl_cari] ([IND], [FIRMAKODU], [FIRMAADI], [YETKILI], [VERGIDAIRESI], [VERGINO], [KAYITTARIHI], [ISKONTO], [FIRMATIPI], [KOD1], [KOD2], [KOD3], [KOD4], [KOD5], [ADI], [SOYAD], [UNVAN], [SEKTOR], [MARKA], [EMAIL], [URL], [TELEFON1], [TELEFON2], [ADRESFATURA], [ADRESSEVK], [PARABIRIMI], [IL], [SEHIR], [PERSONELNO], [STATUS], [YETKİLİDGMTARİH], [HIZMETTURU], [BASBITTAR], [PersonelYorum]) VALUES (1028, N'', N'', 1043, N'', N'', CAST(N'2021-07-09' AS Date), CAST(0.00000000 AS Decimal(28, 8)), NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'', NULL, NULL, N'', N'', N'', N'', N'', N'', N'', N'', NULL, 5, NULL, NULL, NULL, 1066, 1014)
SET IDENTITY_INSERT [dbo].[tbl_cari] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_firmaTipi] ON 

INSERT [dbo].[tbl_firmaTipi] ([IND], [FIRMANO], [FIRMATİPİ]) VALUES (1, 1, N'Limited')
INSERT [dbo].[tbl_firmaTipi] ([IND], [FIRMANO], [FIRMATİPİ]) VALUES (2, 2, N'Tüzel')
INSERT [dbo].[tbl_firmaTipi] ([IND], [FIRMANO], [FIRMATİPİ]) VALUES (3, 3, N'Anonim')
SET IDENTITY_INSERT [dbo].[tbl_firmaTipi] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_hizmetturu] ON 

INSERT [dbo].[tbl_hizmetturu] ([IND], [FIRMANO], [HIZMETTURU]) VALUES (1, 1, N'Yazılım')
INSERT [dbo].[tbl_hizmetturu] ([IND], [FIRMANO], [HIZMETTURU]) VALUES (2, 2, N'Donanım')
INSERT [dbo].[tbl_hizmetturu] ([IND], [FIRMANO], [HIZMETTURU]) VALUES (3, 3, N'Servis')
SET IDENTITY_INSERT [dbo].[tbl_hizmetturu] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_marka] ON 

INSERT [dbo].[tbl_marka] ([IND], [FIRMANO], [MARKAADI]) VALUES (2, NULL, N'Marka1')
INSERT [dbo].[tbl_marka] ([IND], [FIRMANO], [MARKAADI]) VALUES (3, NULL, N'Marka2')
SET IDENTITY_INSERT [dbo].[tbl_marka] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_personel] ON 

INSERT [dbo].[tbl_personel] ([IND], [PERSONELAD], [PERSONELSOYAD], [PERSONELMAİL], [PERSONELTC], [PERSONELTEL], [PERSONELADRES], [PERSONELDURUM]) VALUES (1, N'Murat', N'Coşkun', N'murat@gmail.com', N'11111111111', N'(123) 123-1254', N'Merkez/Düzce', 1)
INSERT [dbo].[tbl_personel] ([IND], [PERSONELAD], [PERSONELSOYAD], [PERSONELMAİL], [PERSONELTC], [PERSONELTEL], [PERSONELADRES], [PERSONELDURUM]) VALUES (2, N'Kenan', N'Demir', N'kenan@gmail.com', N'22222222222', N'(444) 456-8888', N'Merkez/Düzce', 1)
INSERT [dbo].[tbl_personel] ([IND], [PERSONELAD], [PERSONELSOYAD], [PERSONELMAİL], [PERSONELTC], [PERSONELTEL], [PERSONELADRES], [PERSONELDURUM]) VALUES (3, N'Ali', N'Biçim', N'ali@gmail.com', N'33333333333', N'(457) 098-8888', N'Merkez/Düzce', 1)
INSERT [dbo].[tbl_personel] ([IND], [PERSONELAD], [PERSONELSOYAD], [PERSONELMAİL], [PERSONELTC], [PERSONELTEL], [PERSONELADRES], [PERSONELDURUM]) VALUES (4, N'Mehmet', N'Yıldız', N'ahmet@gmail.com', N'11111111111', N'(543) 435-6737', N'Merkez/Düzce', 1)
INSERT [dbo].[tbl_personel] ([IND], [PERSONELAD], [PERSONELSOYAD], [PERSONELMAİL], [PERSONELTC], [PERSONELTEL], [PERSONELADRES], [PERSONELDURUM]) VALUES (5, N'Ayşe', N'Yılmaz', N'ayse@gmail.com', N'42599997330', N'(576) 437-1432', N'Merkez/Düzce', 1)
SET IDENTITY_INSERT [dbo].[tbl_personel] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_sektor] ON 

INSERT [dbo].[tbl_sektor] ([IND], [FIRMANO], [SEKTORADI]) VALUES (1, 1, N'İnşaat')
INSERT [dbo].[tbl_sektor] ([IND], [FIRMANO], [SEKTORADI]) VALUES (2, 2, N'Yemek')
INSERT [dbo].[tbl_sektor] ([IND], [FIRMANO], [SEKTORADI]) VALUES (3, 3, N'Elektronik')
SET IDENTITY_INSERT [dbo].[tbl_sektor] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_status] ON 

INSERT [dbo].[tbl_status] ([IND], [STATUS]) VALUES (1, 1)
INSERT [dbo].[tbl_status] ([IND], [STATUS]) VALUES (2, 0)
SET IDENTITY_INSERT [dbo].[tbl_status] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_user] ON 

INSERT [dbo].[tbl_user] ([IND], [AD], [SOYAD], [KULLANICIADI], [PASSWORD]) VALUES (1, N'Yusuf', N'Kesici', N'yusuf', N'EAAAAGSZRBkpRDu2HxB51GE5+fPac/SztHR7iqrZjPkxW9Wu')
SET IDENTITY_INSERT [dbo].[tbl_user] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_Yetkili] ON 

INSERT [dbo].[tbl_Yetkili] ([IND], [FIRMANO], [AD], [SOYAD], [TELEFON], [MAIL], [DGMTARİH], [KOD1], [KOD2], [KOD3], [KOD4], [KOD5]) VALUES (1, 1, N'Yusuf', N'Kesici', N'(540) 876-3156', N'yusuf@gmail.com', CAST(N'1999-07-01' AS Date), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[tbl_Yetkili] ([IND], [FIRMANO], [AD], [SOYAD], [TELEFON], [MAIL], [DGMTARİH], [KOD1], [KOD2], [KOD3], [KOD4], [KOD5]) VALUES (2, 2, N'Taner', N'Acar', N'(547) 111-5643', N'computer190781@gmail.com', CAST(N'2001-07-09' AS Date), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[tbl_Yetkili] ([IND], [FIRMANO], [AD], [SOYAD], [TELEFON], [MAIL], [DGMTARİH], [KOD1], [KOD2], [KOD3], [KOD4], [KOD5]) VALUES (3, 3, N'Işılay', N'Hasanoğlu', N'(570) 876-5643', N'computerr0022@gmail.com', CAST(N'1990-09-03' AS Date), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[tbl_Yetkili] ([IND], [FIRMANO], [AD], [SOYAD], [TELEFON], [MAIL], [DGMTARİH], [KOD1], [KOD2], [KOD3], [KOD4], [KOD5]) VALUES (18, NULL, N'AHMET', N'UUUUU', N'(540) 050-5643', N'DDGSDFSDFSDF', CAST(N'2021-07-24' AS Date), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[tbl_Yetkili] ([IND], [FIRMANO], [AD], [SOYAD], [TELEFON], [MAIL], [DGMTARİH], [KOD1], [KOD2], [KOD3], [KOD4], [KOD5]) VALUES (19, NULL, N'Ben', N'O', N'(958) 876-5643', N'oley@gmail.com', CAST(N'1988-12-26' AS Date), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[tbl_Yetkili] ([IND], [FIRMANO], [AD], [SOYAD], [TELEFON], [MAIL], [DGMTARİH], [KOD1], [KOD2], [KOD3], [KOD4], [KOD5]) VALUES (24, NULL, N'ALİ', N'MURAT', N'(540) 876-5643', N'computer190781@gmail.com', CAST(N'2001-07-09' AS Date), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[tbl_Yetkili] ([IND], [FIRMANO], [AD], [SOYAD], [TELEFON], [MAIL], [DGMTARİH], [KOD1], [KOD2], [KOD3], [KOD4], [KOD5]) VALUES (35, NULL, N'DSADSA', N'DSADAS', N'(111) 333-2222', N'oley@gmail.com', CAST(N'2021-07-09' AS Date), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[tbl_Yetkili] ([IND], [FIRMANO], [AD], [SOYAD], [TELEFON], [MAIL], [DGMTARİH], [KOD1], [KOD2], [KOD3], [KOD4], [KOD5]) VALUES (36, NULL, N'ASDSADSADSA', N'DASDSAD', N'(123) 123-2131', N'', CAST(N'2021-07-08' AS Date), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[tbl_Yetkili] ([IND], [FIRMANO], [AD], [SOYAD], [TELEFON], [MAIL], [DGMTARİH], [KOD1], [KOD2], [KOD3], [KOD4], [KOD5]) VALUES (37, NULL, N'SADSAD', N'DASDSA', N'(111) 132-3232', N'', CAST(N'2021-07-08' AS Date), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[tbl_Yetkili] ([IND], [FIRMANO], [AD], [SOYAD], [TELEFON], [MAIL], [DGMTARİH], [KOD1], [KOD2], [KOD3], [KOD4], [KOD5]) VALUES (1036, NULL, N'AAAAAAAAAA', N'AAAAAAAAAA', N'(111) 122-2222', N'', CAST(N'2021-07-08' AS Date), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[tbl_Yetkili] ([IND], [FIRMANO], [AD], [SOYAD], [TELEFON], [MAIL], [DGMTARİH], [KOD1], [KOD2], [KOD3], [KOD4], [KOD5]) VALUES (1037, NULL, N'DSADSAD', N'DASDASD', N'(111) 232-3111', N'oley@gmail.com', CAST(N'2021-07-08' AS Date), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[tbl_Yetkili] ([IND], [FIRMANO], [AD], [SOYAD], [TELEFON], [MAIL], [DGMTARİH], [KOD1], [KOD2], [KOD3], [KOD4], [KOD5]) VALUES (1038, NULL, N'ALİ', N'ALİM', N'(222) 222-2222', N'', CAST(N'2021-07-08' AS Date), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[tbl_Yetkili] ([IND], [FIRMANO], [AD], [SOYAD], [TELEFON], [MAIL], [DGMTARİH], [KOD1], [KOD2], [KOD3], [KOD4], [KOD5]) VALUES (1039, NULL, N'KENAN', N'KOMUTAN', N'(212) 121-2121', N'', CAST(N'2021-07-08' AS Date), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[tbl_Yetkili] ([IND], [FIRMANO], [AD], [SOYAD], [TELEFON], [MAIL], [DGMTARİH], [KOD1], [KOD2], [KOD3], [KOD4], [KOD5]) VALUES (1040, NULL, N'İBRAHİM', N'KESİCİ', N'(555) 454-2222', N'isilay.hasanoglu@hotmail.com', CAST(N'1975-03-04' AS Date), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[tbl_Yetkili] ([IND], [FIRMANO], [AD], [SOYAD], [TELEFON], [MAIL], [DGMTARİH], [KOD1], [KOD2], [KOD3], [KOD4], [KOD5]) VALUES (1041, NULL, N'AAAAAAAAAAA', N'AAAAAAAAAAAAAAAAA', N'(123) 321-3231', N'', CAST(N'2021-07-09' AS Date), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[tbl_Yetkili] ([IND], [FIRMANO], [AD], [SOYAD], [TELEFON], [MAIL], [DGMTARİH], [KOD1], [KOD2], [KOD3], [KOD4], [KOD5]) VALUES (1042, NULL, N'DSADAS', N'DASDASDA', N'(323) 123-2141', N'', CAST(N'2021-07-09' AS Date), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[tbl_Yetkili] ([IND], [FIRMANO], [AD], [SOYAD], [TELEFON], [MAIL], [DGMTARİH], [KOD1], [KOD2], [KOD3], [KOD4], [KOD5]) VALUES (1043, NULL, N'DSADAS', N'DSADAS', N'(111) 111-1111', N'', CAST(N'2021-07-09' AS Date), NULL, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[tbl_Yetkili] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_yorum] ON 

INSERT [dbo].[tbl_yorum] ([IND], [YORUM], [PersonelNo]) VALUES (1, N'kenan bey mükemmeldi', 1)
INSERT [dbo].[tbl_yorum] ([IND], [YORUM], [PersonelNo]) VALUES (2, N'Halledildi.', 2)
INSERT [dbo].[tbl_yorum] ([IND], [YORUM], [PersonelNo]) VALUES (3, N'yorummm', NULL)
INSERT [dbo].[tbl_yorum] ([IND], [YORUM], [PersonelNo]) VALUES (4, N'yorum yaptım 09/07/2021', NULL)
INSERT [dbo].[tbl_yorum] ([IND], [YORUM], [PersonelNo]) VALUES (1004, N'Bu bir yorumdur', NULL)
INSERT [dbo].[tbl_yorum] ([IND], [YORUM], [PersonelNo]) VALUES (1005, N'çok iyi', NULL)
INSERT [dbo].[tbl_yorum] ([IND], [YORUM], [PersonelNo]) VALUES (1006, NULL, NULL)
INSERT [dbo].[tbl_yorum] ([IND], [YORUM], [PersonelNo]) VALUES (1007, NULL, NULL)
INSERT [dbo].[tbl_yorum] ([IND], [YORUM], [PersonelNo]) VALUES (1008, NULL, NULL)
INSERT [dbo].[tbl_yorum] ([IND], [YORUM], [PersonelNo]) VALUES (1009, N'çoh ii', NULL)
INSERT [dbo].[tbl_yorum] ([IND], [YORUM], [PersonelNo]) VALUES (1010, N'DAHA  İYİSİ   YOK', NULL)
INSERT [dbo].[tbl_yorum] ([IND], [YORUM], [PersonelNo]) VALUES (1011, NULL, NULL)
INSERT [dbo].[tbl_yorum] ([IND], [YORUM], [PersonelNo]) VALUES (1012, NULL, NULL)
INSERT [dbo].[tbl_yorum] ([IND], [YORUM], [PersonelNo]) VALUES (1013, NULL, NULL)
INSERT [dbo].[tbl_yorum] ([IND], [YORUM], [PersonelNo]) VALUES (1014, NULL, NULL)
SET IDENTITY_INSERT [dbo].[tbl_yorum] OFF
GO
ALTER TABLE [dbo].[tbl_cari]  WITH CHECK ADD  CONSTRAINT [FK_tbl_cari_tbl_baslangicBitisTarih] FOREIGN KEY([BASBITTAR])
REFERENCES [dbo].[tbl_baslangicBitisTarih] ([IND])
GO
ALTER TABLE [dbo].[tbl_cari] CHECK CONSTRAINT [FK_tbl_cari_tbl_baslangicBitisTarih]
GO
ALTER TABLE [dbo].[tbl_cari]  WITH CHECK ADD  CONSTRAINT [FK_tbl_cari_tbl_firmaTipi] FOREIGN KEY([FIRMATIPI])
REFERENCES [dbo].[tbl_firmaTipi] ([IND])
GO
ALTER TABLE [dbo].[tbl_cari] CHECK CONSTRAINT [FK_tbl_cari_tbl_firmaTipi]
GO
ALTER TABLE [dbo].[tbl_cari]  WITH CHECK ADD  CONSTRAINT [FK_tbl_cari_tbl_hizmetturu] FOREIGN KEY([HIZMETTURU])
REFERENCES [dbo].[tbl_hizmetturu] ([IND])
GO
ALTER TABLE [dbo].[tbl_cari] CHECK CONSTRAINT [FK_tbl_cari_tbl_hizmetturu]
GO
ALTER TABLE [dbo].[tbl_cari]  WITH CHECK ADD  CONSTRAINT [FK_tbl_cari_tbl_personel] FOREIGN KEY([PERSONELNO])
REFERENCES [dbo].[tbl_personel] ([IND])
GO
ALTER TABLE [dbo].[tbl_cari] CHECK CONSTRAINT [FK_tbl_cari_tbl_personel]
GO
ALTER TABLE [dbo].[tbl_cari]  WITH CHECK ADD  CONSTRAINT [FK_tbl_cari_tbl_sektor1] FOREIGN KEY([SEKTOR])
REFERENCES [dbo].[tbl_sektor] ([IND])
GO
ALTER TABLE [dbo].[tbl_cari] CHECK CONSTRAINT [FK_tbl_cari_tbl_sektor1]
GO
ALTER TABLE [dbo].[tbl_cari]  WITH CHECK ADD  CONSTRAINT [FK_tbl_cari_tbl_status] FOREIGN KEY([STATUS])
REFERENCES [dbo].[tbl_status] ([IND])
GO
ALTER TABLE [dbo].[tbl_cari] CHECK CONSTRAINT [FK_tbl_cari_tbl_status]
GO
ALTER TABLE [dbo].[tbl_cari]  WITH CHECK ADD  CONSTRAINT [FK_tbl_cari_tbl_Yetkili] FOREIGN KEY([YETKILI])
REFERENCES [dbo].[tbl_Yetkili] ([IND])
GO
ALTER TABLE [dbo].[tbl_cari] CHECK CONSTRAINT [FK_tbl_cari_tbl_Yetkili]
GO
ALTER TABLE [dbo].[tbl_cari]  WITH CHECK ADD  CONSTRAINT [FK_tbl_cari_tbl_yorum] FOREIGN KEY([PersonelYorum])
REFERENCES [dbo].[tbl_yorum] ([IND])
GO
ALTER TABLE [dbo].[tbl_cari] CHECK CONSTRAINT [FK_tbl_cari_tbl_yorum]
GO
ALTER TABLE [dbo].[tbl_marka]  WITH CHECK ADD  CONSTRAINT [FK_tbl_marka_tbl_cari] FOREIGN KEY([FIRMANO])
REFERENCES [dbo].[tbl_cari] ([IND])
GO
ALTER TABLE [dbo].[tbl_marka] CHECK CONSTRAINT [FK_tbl_marka_tbl_cari]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "tbl_Yetkili"
            Begin Extent = 
               Top = 3
               Left = 22
               Bottom = 166
               Right = 216
            End
            DisplayFlags = 280
            TopColumn = 7
         End
         Begin Table = "tbl_status"
            Begin Extent = 
               Top = 7
               Left = 290
               Bottom = 148
               Right = 484
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tbl_sektor"
            Begin Extent = 
               Top = 7
               Left = 532
               Bottom = 148
               Right = 726
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tbl_marka"
            Begin Extent = 
               Top = 7
               Left = 774
               Bottom = 148
               Right = 968
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tbl_hizmetturu"
            Begin Extent = 
               Top = 154
               Left = 290
               Bottom = 295
               Right = 484
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tbl_firmaTipi"
            Begin Extent = 
               Top = 154
               Left = 532
               Bottom = 295
               Right = 726
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tbl_cari"
            Begin Extent = 
               Top = 154
               Left = 774
               Bottom = 317
               Right = 993
            End
       ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ViewCari'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'     DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tbl_baslangicBitisTarih"
            Begin Extent = 
               Top = 130
               Left = 36
               Bottom = 293
               Right = 251
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ViewCari'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ViewCari'
GO
