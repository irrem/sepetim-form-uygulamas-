USE [master]
GO
/****** Object:  Database [Sepetim]    Script Date: 19.03.2021 01:07:13 ******/
CREATE DATABASE [Sepetim]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Sepetim', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Sepetim.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Sepetim_log', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Sepetim_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Sepetim] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Sepetim].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Sepetim] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Sepetim] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Sepetim] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Sepetim] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Sepetim] SET ARITHABORT OFF 
GO
ALTER DATABASE [Sepetim] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Sepetim] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Sepetim] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Sepetim] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Sepetim] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Sepetim] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Sepetim] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Sepetim] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Sepetim] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Sepetim] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Sepetim] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Sepetim] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Sepetim] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Sepetim] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Sepetim] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Sepetim] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Sepetim] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Sepetim] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Sepetim] SET  MULTI_USER 
GO
ALTER DATABASE [Sepetim] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Sepetim] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Sepetim] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Sepetim] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Sepetim] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Sepetim] SET QUERY_STORE = OFF
GO
USE [Sepetim]
GO
/****** Object:  Table [dbo].[Admin]    Script Date: 19.03.2021 01:07:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admin](
	[adminId] [int] IDENTITY(1,1) NOT NULL,
	[adminUserName] [varchar](10) NULL,
	[adminPassword] [varchar](10) NULL,
 CONSTRAINT [PK_Admin] PRIMARY KEY CLUSTERED 
(
	[adminId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kategori]    Script Date: 19.03.2021 01:07:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kategori](
	[kategoriId] [int] IDENTITY(1,1) NOT NULL,
	[kategoriAd] [varchar](30) NULL,
	[kategoriKodAd] [varchar](10) NULL,
 CONSTRAINT [PK_Kategori] PRIMARY KEY CLUSTERED 
(
	[kategoriId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KuryeIsYuku]    Script Date: 19.03.2021 01:07:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KuryeIsYuku](
	[personelId] [int] NULL,
	[durum] [varchar](10) NULL,
	[calismaSaati] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Musteri]    Script Date: 19.03.2021 01:07:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Musteri](
	[musteriId] [int] IDENTITY(1,1) NOT NULL,
	[musteriAd] [varchar](30) NULL,
	[musteriSoyad] [varchar](30) NULL,
	[musteriTelefon] [varchar](30) NULL,
	[musteriAdres] [varchar](30) NULL,
	[musteriIl] [varchar](30) NULL,
	[musteriIlce] [varchar](30) NULL,
	[musteriEnlemBoylam] [varchar](30) NULL,
	[musteriMail] [varchar](30) NULL,
	[musteriSanalSepetPuan] [int] NULL,
 CONSTRAINT [PK_Musteri] PRIMARY KEY CLUSTERED 
(
	[musteriId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Personel]    Script Date: 19.03.2021 01:07:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Personel](
	[personelId] [int] IDENTITY(1,1) NOT NULL,
	[personelAdSoyad] [varchar](50) NULL,
	[personelTelefon] [varchar](20) NULL,
	[personelMail] [varchar](20) NULL,
	[personelAdres] [varchar](20) NULL,
	[personelIsBaslangic] [varchar](20) NULL,
	[personelKategori] [int] NULL,
	[subeId] [int] NULL,
 CONSTRAINT [PK_Personel] PRIMARY KEY CLUSTERED 
(
	[personelId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PersonelKategori]    Script Date: 19.03.2021 01:07:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PersonelKategori](
	[kategoriId] [int] IDENTITY(1,1) NOT NULL,
	[kategori] [varchar](25) NULL,
 CONSTRAINT [PK_PersonelKategori] PRIMARY KEY CLUSTERED 
(
	[kategoriId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Siparis]    Script Date: 19.03.2021 01:07:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Siparis](
	[siparisId] [int] IDENTITY(1,1) NOT NULL,
	[urunId] [int] NULL,
	[subeId] [int] NULL,
	[musteriId] [int] NULL,
	[siparisTutar] [varchar](10) NULL,
 CONSTRAINT [PK_Siparis] PRIMARY KEY CLUSTERED 
(
	[siparisId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SubeGirisAdmin]    Script Date: 19.03.2021 01:07:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SubeGirisAdmin](
	[subeGirisAdminId] [int] IDENTITY(1,1) NOT NULL,
	[subeGirisAdminAd] [varchar](10) NULL,
	[subeGirisAdminSifre] [varchar](10) NULL,
	[personelId] [int] NULL,
 CONSTRAINT [PK_SeriGirisAdmin] PRIMARY KEY CLUSTERED 
(
	[subeGirisAdminId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Subeler]    Script Date: 19.03.2021 01:07:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Subeler](
	[subeId] [int] IDENTITY(1,1) NOT NULL,
	[subeAd] [varchar](20) NULL,
	[subeAdres] [text] NULL,
	[subeTelefon] [varchar](12) NULL,
	[subeMail] [varchar](30) NULL,
	[personelId] [int] NULL,
 CONSTRAINT [PK_Subeler] PRIMARY KEY CLUSTERED 
(
	[subeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Teslimat]    Script Date: 19.03.2021 01:07:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teslimat](
	[teslimatId] [int] IDENTITY(1,1) NOT NULL,
	[personelId] [int] NULL,
	[siparisId] [int] NULL,
	[teslimatSaatiMin] [datetime] NULL,
	[teslimatSaatiMax] [datetime] NULL,
	[teslimatDurumu] [varchar](50) NULL,
 CONSTRAINT [PK_Teslimat] PRIMARY KEY CLUSTERED 
(
	[teslimatId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Urunler]    Script Date: 19.03.2021 01:07:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Urunler](
	[urunId] [int] IDENTITY(1,1) NOT NULL,
	[urunAd] [varchar](30) NULL,
	[urunStok] [int] NULL,
	[urunBirimFiyat] [int] NULL,
	[urunKdvYuzdeOran] [int] NULL,
	[urunSatisFiyat] [int] NULL,
	[subeId] [int] NULL,
	[kategoriId] [int] NULL,
 CONSTRAINT [PK_Urunler] PRIMARY KEY CLUSTERED 
(
	[urunId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VeriGirisAdmin]    Script Date: 19.03.2021 01:07:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VeriGirisAdmin](
	[veriGirisAdminId] [int] IDENTITY(1,1) NOT NULL,
	[veriGirisAdminAd] [varchar](10) NULL,
	[veriGirisAdminSifre] [varchar](10) NULL,
	[personelId] [int] NULL,
 CONSTRAINT [PK_VeriGirisAdmin] PRIMARY KEY CLUSTERED 
(
	[veriGirisAdminId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Admin] ON 

INSERT [dbo].[Admin] ([adminId], [adminUserName], [adminPassword]) VALUES (1, N'irem', N'12345')
SET IDENTITY_INSERT [dbo].[Admin] OFF
SET IDENTITY_INSERT [dbo].[Kategori] ON 

INSERT [dbo].[Kategori] ([kategoriId], [kategoriAd], [kategoriKodAd]) VALUES (1, N'Yiyecek', N'Y01')
INSERT [dbo].[Kategori] ([kategoriId], [kategoriAd], [kategoriKodAd]) VALUES (3, N'Bakım Ürünleri', N'B08')
INSERT [dbo].[Kategori] ([kategoriId], [kategoriAd], [kategoriKodAd]) VALUES (4, N'İçecek', N'I03')
INSERT [dbo].[Kategori] ([kategoriId], [kategoriAd], [kategoriKodAd]) VALUES (5, N'Saç Bakım', N'S22')
INSERT [dbo].[Kategori] ([kategoriId], [kategoriAd], [kategoriKodAd]) VALUES (6, N'Diş Bakım', N'D1S')
INSERT [dbo].[Kategori] ([kategoriId], [kategoriAd], [kategoriKodAd]) VALUES (9, N'Temizlik', N'T02')
INSERT [dbo].[Kategori] ([kategoriId], [kategoriAd], [kategoriKodAd]) VALUES (10, N'Elektronik', N'E30')
INSERT [dbo].[Kategori] ([kategoriId], [kategoriAd], [kategoriKodAd]) VALUES (11, N'Bebek', N'B11')
INSERT [dbo].[Kategori] ([kategoriId], [kategoriAd], [kategoriKodAd]) VALUES (12, N'Oyuncak', N'O20')
SET IDENTITY_INSERT [dbo].[Kategori] OFF
INSERT [dbo].[KuryeIsYuku] ([personelId], [durum], [calismaSaati]) VALUES (6, N'Dolu', CAST(N'2021-03-18T23:50:57.557' AS DateTime))
INSERT [dbo].[KuryeIsYuku] ([personelId], [durum], [calismaSaati]) VALUES (7, N'Dolu', CAST(N'2021-03-18T23:52:04.417' AS DateTime))
INSERT [dbo].[KuryeIsYuku] ([personelId], [durum], [calismaSaati]) VALUES (8, N'Dolu', CAST(N'2021-03-19T02:03:07.287' AS DateTime))
INSERT [dbo].[KuryeIsYuku] ([personelId], [durum], [calismaSaati]) VALUES (9, N'Dolu', CAST(N'2021-03-19T02:03:18.050' AS DateTime))
INSERT [dbo].[KuryeIsYuku] ([personelId], [durum], [calismaSaati]) VALUES (1, N'Dolu', CAST(N'2021-03-19T02:03:42.457' AS DateTime))
SET IDENTITY_INSERT [dbo].[Musteri] ON 

INSERT [dbo].[Musteri] ([musteriId], [musteriAd], [musteriSoyad], [musteriTelefon], [musteriAdres], [musteriIl], [musteriIlce], [musteriEnlemBoylam], [musteriMail], [musteriSanalSepetPuan]) VALUES (1, N'Mahmut', N'Tuncer', N'507052320', N'İzmir', N'İzmir', N'Göztepe', N'35,5246/24,452', N'ir@gmail.com', 15)
INSERT [dbo].[Musteri] ([musteriId], [musteriAd], [musteriSoyad], [musteriTelefon], [musteriAdres], [musteriIl], [musteriIlce], [musteriEnlemBoylam], [musteriMail], [musteriSanalSepetPuan]) VALUES (3, N'Ayten', N'Hafif', N'507052320', N'İzmir', N'İzmir', N'Göztepe', N'35,5246/24,452', N'aysun@gmail.com', 15)
INSERT [dbo].[Musteri] ([musteriId], [musteriAd], [musteriSoyad], [musteriTelefon], [musteriAdres], [musteriIl], [musteriIlce], [musteriEnlemBoylam], [musteriMail], [musteriSanalSepetPuan]) VALUES (4, N'Mahsun', N'Kırmızıgül', N'5070456336', N'İzmir', N'İzmir', N'Bornova', N'36,54358/25,5789', N'mahsn@gmail.com', 800)
SET IDENTITY_INSERT [dbo].[Musteri] OFF
SET IDENTITY_INSERT [dbo].[Personel] ON 

INSERT [dbo].[Personel] ([personelId], [personelAdSoyad], [personelTelefon], [personelMail], [personelAdres], [personelIsBaslangic], [personelKategori], [subeId]) VALUES (1, N'Hayrettin Bektaş', N'5036563230', N'hyrtns@gmail.com', N'İzmir', N'12/2/2020', 3, 1)
INSERT [dbo].[Personel] ([personelId], [personelAdSoyad], [personelTelefon], [personelMail], [personelAdres], [personelIsBaslangic], [personelKategori], [subeId]) VALUES (2, N'İrem Sarısoy', N'5036563230', N'xfs@gmail.com', N'İzmir', N'12/2/2020', 2, 2)
INSERT [dbo].[Personel] ([personelId], [personelAdSoyad], [personelTelefon], [personelMail], [personelAdres], [personelIsBaslangic], [personelKategori], [subeId]) VALUES (4, N'İrem Sarısoy', N'5036563230', N'xfs@gmail.com', N'İzmir', N'12/2/2020', 1, 1)
INSERT [dbo].[Personel] ([personelId], [personelAdSoyad], [personelTelefon], [personelMail], [personelAdres], [personelIsBaslangic], [personelKategori], [subeId]) VALUES (6, N'Zeynep Karakuş', N'5214023545', N'zeynep@gmail.com', N'İzmir', N'29/01/2017', 3, 1)
INSERT [dbo].[Personel] ([personelId], [personelAdSoyad], [personelTelefon], [personelMail], [personelAdres], [personelIsBaslangic], [personelKategori], [subeId]) VALUES (7, N'Ahmet Karakuş', N'5075468920', N'ahmet@gmail.com', N'İzmir', N'12/2/2020', 3, 1)
INSERT [dbo].[Personel] ([personelId], [personelAdSoyad], [personelTelefon], [personelMail], [personelAdres], [personelIsBaslangic], [personelKategori], [subeId]) VALUES (8, N'İsmet Sert', N'5074023545', N'ismet@gmail.com', N'İzmir', N'29/01/2017', 3, 1)
INSERT [dbo].[Personel] ([personelId], [personelAdSoyad], [personelTelefon], [personelMail], [personelAdres], [personelIsBaslangic], [personelKategori], [subeId]) VALUES (9, N'Rukiye Kurt', N'532023545', N'rkyt@gmail.com', N'İzmir', N'29/01/2018', 3, 1)
SET IDENTITY_INSERT [dbo].[Personel] OFF
SET IDENTITY_INSERT [dbo].[PersonelKategori] ON 

INSERT [dbo].[PersonelKategori] ([kategoriId], [kategori]) VALUES (1, N'Şube Sorumlusu')
INSERT [dbo].[PersonelKategori] ([kategoriId], [kategori]) VALUES (2, N'Veri Giriş Elemanı')
INSERT [dbo].[PersonelKategori] ([kategoriId], [kategori]) VALUES (3, N'Kurye')
SET IDENTITY_INSERT [dbo].[PersonelKategori] OFF
SET IDENTITY_INSERT [dbo].[Siparis] ON 

INSERT [dbo].[Siparis] ([siparisId], [urunId], [subeId], [musteriId], [siparisTutar]) VALUES (1, 1, 2, 1, N'20')
INSERT [dbo].[Siparis] ([siparisId], [urunId], [subeId], [musteriId], [siparisTutar]) VALUES (2, 2, 1, 3, N'150')
SET IDENTITY_INSERT [dbo].[Siparis] OFF
SET IDENTITY_INSERT [dbo].[SubeGirisAdmin] ON 

INSERT [dbo].[SubeGirisAdmin] ([subeGirisAdminId], [subeGirisAdminAd], [subeGirisAdminSifre], [personelId]) VALUES (1, N'a', N'1', NULL)
INSERT [dbo].[SubeGirisAdmin] ([subeGirisAdminId], [subeGirisAdminAd], [subeGirisAdminSifre], [personelId]) VALUES (2, N'c', N'c', 1)
SET IDENTITY_INSERT [dbo].[SubeGirisAdmin] OFF
SET IDENTITY_INSERT [dbo].[Subeler] ON 

INSERT [dbo].[Subeler] ([subeId], [subeAd], [subeAdres], [subeTelefon], [subeMail], [personelId]) VALUES (1, N'Bornova', N'Bornova/İzmir', N' 420352032', N'bornov@gmail.com', 1)
INSERT [dbo].[Subeler] ([subeId], [subeAd], [subeAdres], [subeTelefon], [subeMail], [personelId]) VALUES (2, N'Buca', N'Buca/İzmir', N'568625452', N'buca@gmail.com', 3)
SET IDENTITY_INSERT [dbo].[Subeler] OFF
SET IDENTITY_INSERT [dbo].[Teslimat] ON 

INSERT [dbo].[Teslimat] ([teslimatId], [personelId], [siparisId], [teslimatSaatiMin], [teslimatSaatiMax], [teslimatDurumu]) VALUES (1, 6, 1, CAST(N'2021-03-17T21:47:42.523' AS DateTime), CAST(N'2021-03-17T23:47:42.523' AS DateTime), N'Teslim edildi!')
INSERT [dbo].[Teslimat] ([teslimatId], [personelId], [siparisId], [teslimatSaatiMin], [teslimatSaatiMax], [teslimatDurumu]) VALUES (8, 6, 1, CAST(N'2021-03-18T14:02:25.223' AS DateTime), CAST(N'2021-03-18T16:02:25.223' AS DateTime), N'Teslim edildi!')
INSERT [dbo].[Teslimat] ([teslimatId], [personelId], [siparisId], [teslimatSaatiMin], [teslimatSaatiMax], [teslimatDurumu]) VALUES (9, 1, 1, CAST(N'2021-03-18T14:32:50.997' AS DateTime), CAST(N'2021-03-18T16:32:50.997' AS DateTime), N'İptal edildi!')
INSERT [dbo].[Teslimat] ([teslimatId], [personelId], [siparisId], [teslimatSaatiMin], [teslimatSaatiMax], [teslimatDurumu]) VALUES (17, 6, 1, CAST(N'2021-03-18T21:50:57.550' AS DateTime), CAST(N'2021-03-18T23:50:57.550' AS DateTime), N'Teslimat Bekleniyor')
INSERT [dbo].[Teslimat] ([teslimatId], [personelId], [siparisId], [teslimatSaatiMin], [teslimatSaatiMax], [teslimatDurumu]) VALUES (18, 7, 1, CAST(N'2021-03-18T21:52:04.410' AS DateTime), CAST(N'2021-03-18T23:52:04.410' AS DateTime), N'Teslimat Bekleniyor')
INSERT [dbo].[Teslimat] ([teslimatId], [personelId], [siparisId], [teslimatSaatiMin], [teslimatSaatiMax], [teslimatDurumu]) VALUES (19, 8, 2, CAST(N'2021-03-19T00:03:06.570' AS DateTime), CAST(N'2021-03-19T02:03:06.570' AS DateTime), N'Teslimat Bekleniyor')
INSERT [dbo].[Teslimat] ([teslimatId], [personelId], [siparisId], [teslimatSaatiMin], [teslimatSaatiMax], [teslimatDurumu]) VALUES (20, 9, 3, CAST(N'2021-03-19T00:03:18.050' AS DateTime), CAST(N'2021-03-19T02:03:18.050' AS DateTime), N'Teslimat Bekleniyor')
INSERT [dbo].[Teslimat] ([teslimatId], [personelId], [siparisId], [teslimatSaatiMin], [teslimatSaatiMax], [teslimatDurumu]) VALUES (21, 1, 3, CAST(N'2021-03-19T00:03:42.457' AS DateTime), CAST(N'2021-03-19T02:03:42.457' AS DateTime), N'Teslimat Bekleniyor')
SET IDENTITY_INSERT [dbo].[Teslimat] OFF
SET IDENTITY_INSERT [dbo].[Urunler] ON 

INSERT [dbo].[Urunler] ([urunId], [urunAd], [urunStok], [urunBirimFiyat], [urunKdvYuzdeOran], [urunSatisFiyat], [subeId], [kategoriId]) VALUES (6, N'Bephanten', 200, 20, 10, 22, 2, 3)
INSERT [dbo].[Urunler] ([urunId], [urunAd], [urunStok], [urunBirimFiyat], [urunKdvYuzdeOran], [urunSatisFiyat], [subeId], [kategoriId]) VALUES (7, N'Benri El Kremi', 200, 30, 10, 33, 2, 3)
INSERT [dbo].[Urunler] ([urunId], [urunAd], [urunStok], [urunBirimFiyat], [urunKdvYuzdeOran], [urunSatisFiyat], [subeId], [kategoriId]) VALUES (8, N'Bebek Bezi', 1000, 100, 10, 110, 1, 11)
INSERT [dbo].[Urunler] ([urunId], [urunAd], [urunStok], [urunBirimFiyat], [urunKdvYuzdeOran], [urunSatisFiyat], [subeId], [kategoriId]) VALUES (9, N'Bebek Biberon', 1000, 40, 10, 44, 1, 11)
INSERT [dbo].[Urunler] ([urunId], [urunAd], [urunStok], [urunBirimFiyat], [urunKdvYuzdeOran], [urunSatisFiyat], [subeId], [kategoriId]) VALUES (10, N'Signal Diş Macunu', 600, 20, 20, 25, 1, 6)
SET IDENTITY_INSERT [dbo].[Urunler] OFF
SET IDENTITY_INSERT [dbo].[VeriGirisAdmin] ON 

INSERT [dbo].[VeriGirisAdmin] ([veriGirisAdminId], [veriGirisAdminAd], [veriGirisAdminSifre], [personelId]) VALUES (1, N'x', N'x', NULL)
SET IDENTITY_INSERT [dbo].[VeriGirisAdmin] OFF
ALTER TABLE [dbo].[Personel]  WITH CHECK ADD  CONSTRAINT [FK_Personel_PersonelKategori] FOREIGN KEY([personelKategori])
REFERENCES [dbo].[PersonelKategori] ([kategoriId])
GO
ALTER TABLE [dbo].[Personel] CHECK CONSTRAINT [FK_Personel_PersonelKategori]
GO
ALTER TABLE [dbo].[Personel]  WITH CHECK ADD  CONSTRAINT [FK_Personel_Subeler] FOREIGN KEY([subeId])
REFERENCES [dbo].[Subeler] ([subeId])
GO
ALTER TABLE [dbo].[Personel] CHECK CONSTRAINT [FK_Personel_Subeler]
GO
ALTER TABLE [dbo].[Siparis]  WITH CHECK ADD  CONSTRAINT [FK_Siparis_Musteri] FOREIGN KEY([musteriId])
REFERENCES [dbo].[Musteri] ([musteriId])
GO
ALTER TABLE [dbo].[Siparis] CHECK CONSTRAINT [FK_Siparis_Musteri]
GO
ALTER TABLE [dbo].[Siparis]  WITH CHECK ADD  CONSTRAINT [FK_Siparis_Subeler] FOREIGN KEY([subeId])
REFERENCES [dbo].[Subeler] ([subeId])
GO
ALTER TABLE [dbo].[Siparis] CHECK CONSTRAINT [FK_Siparis_Subeler]
GO
ALTER TABLE [dbo].[SubeGirisAdmin]  WITH CHECK ADD  CONSTRAINT [FK_SubeGirisAdmin_Personel] FOREIGN KEY([personelId])
REFERENCES [dbo].[Personel] ([personelId])
GO
ALTER TABLE [dbo].[SubeGirisAdmin] CHECK CONSTRAINT [FK_SubeGirisAdmin_Personel]
GO
ALTER TABLE [dbo].[Urunler]  WITH CHECK ADD  CONSTRAINT [FK_Urunler_Kategori] FOREIGN KEY([kategoriId])
REFERENCES [dbo].[Kategori] ([kategoriId])
GO
ALTER TABLE [dbo].[Urunler] CHECK CONSTRAINT [FK_Urunler_Kategori]
GO
ALTER TABLE [dbo].[Urunler]  WITH CHECK ADD  CONSTRAINT [FK_Urunler_Subeler] FOREIGN KEY([subeId])
REFERENCES [dbo].[Subeler] ([subeId])
GO
ALTER TABLE [dbo].[Urunler] CHECK CONSTRAINT [FK_Urunler_Subeler]
GO
ALTER TABLE [dbo].[VeriGirisAdmin]  WITH CHECK ADD  CONSTRAINT [FK_VeriGirisAdmin_Personel] FOREIGN KEY([personelId])
REFERENCES [dbo].[Personel] ([personelId])
GO
ALTER TABLE [dbo].[VeriGirisAdmin] CHECK CONSTRAINT [FK_VeriGirisAdmin_Personel]
GO
USE [master]
GO
ALTER DATABASE [Sepetim] SET  READ_WRITE 
GO
