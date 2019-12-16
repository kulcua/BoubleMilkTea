USE [master]
GO
/****** Object:  Database [TraSua]    Script Date: 15-Dec-19 11:36:21 PM ******/
CREATE DATABASE [TraSua]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TraSua', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\TraSua.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'TraSua_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\TraSua_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [TraSua] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TraSua].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TraSua] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TraSua] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TraSua] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TraSua] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TraSua] SET ARITHABORT OFF 
GO
ALTER DATABASE [TraSua] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [TraSua] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TraSua] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TraSua] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TraSua] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TraSua] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TraSua] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TraSua] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TraSua] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TraSua] SET  ENABLE_BROKER 
GO
ALTER DATABASE [TraSua] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TraSua] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TraSua] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TraSua] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TraSua] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TraSua] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TraSua] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TraSua] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [TraSua] SET  MULTI_USER 
GO
ALTER DATABASE [TraSua] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TraSua] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TraSua] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TraSua] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [TraSua] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [TraSua] SET QUERY_STORE = OFF
GO
USE [TraSua]
GO
/****** Object:  Table [dbo].[CTHD]    Script Date: 15-Dec-19 11:36:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTHD](
	[MACTHD] [int] IDENTITY(1,1) NOT NULL,
	[MATHUCUONG] [int] NOT NULL,
	[MATOPPING] [int] NULL,
	[MAKM] [int] NULL,
	[MAHOADON] [int] NOT NULL,
	[DUONG] [int] NULL,
	[DA] [int] NULL,
	[GHICHU] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[MACTHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HOADON]    Script Date: 15-Dec-19 11:36:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOADON](
	[MAHOADON] [int] IDENTITY(1,1) NOT NULL,
	[MANV] [int] NOT NULL,
	[TENKH] [nvarchar](100) NOT NULL,
	[TGBD] [datetime] NOT NULL,
	[TONGTIEN] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MAHOADON] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KHUYENMAI]    Script Date: 15-Dec-19 11:36:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHUYENMAI](
	[MAKM] [int] IDENTITY(1,1) NOT NULL,
	[TENKM] [nvarchar](50) NOT NULL,
	[TGBD] [datetime] NOT NULL,
	[TGKT] [datetime] NOT NULL,
	[MUCGIAMGIA] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MAKM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 15-Dec-19 11:36:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MANV] [int] IDENTITY(1,1) NOT NULL,
	[TENNV] [nvarchar](50) NOT NULL,
	[CHUCVU] [nvarchar](50) NOT NULL,
	[MATKHAU] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MANV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[THUCUONG]    Script Date: 15-Dec-19 11:36:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[THUCUONG](
	[MATHUCUONG] [int] IDENTITY(1,1) NOT NULL,
	[TENTHUCUONG] [nvarchar](50) NOT NULL,
	[GIATHUCUONG] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MATHUCUONG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TOPPING]    Script Date: 15-Dec-19 11:36:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TOPPING](
	[MATOPPING] [int] IDENTITY(1,1) NOT NULL,
	[TENTOPPING] [nvarchar](50) NOT NULL,
	[GIATOPPING] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MATOPPING] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CTHD]  WITH CHECK ADD  CONSTRAINT [FK_hoadon] FOREIGN KEY([MAHOADON])
REFERENCES [dbo].[HOADON] ([MAHOADON])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[CTHD] CHECK CONSTRAINT [FK_hoadon]
GO
ALTER TABLE [dbo].[CTHD]  WITH CHECK ADD  CONSTRAINT [FK_khuyenmai] FOREIGN KEY([MAKM])
REFERENCES [dbo].[KHUYENMAI] ([MAKM])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[CTHD] CHECK CONSTRAINT [FK_khuyenmai]
GO
ALTER TABLE [dbo].[CTHD]  WITH CHECK ADD  CONSTRAINT [FK_thucuong] FOREIGN KEY([MATHUCUONG])
REFERENCES [dbo].[THUCUONG] ([MATHUCUONG])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[CTHD] CHECK CONSTRAINT [FK_thucuong]
GO
ALTER TABLE [dbo].[CTHD]  WITH CHECK ADD  CONSTRAINT [FK_topping] FOREIGN KEY([MATOPPING])
REFERENCES [dbo].[TOPPING] ([MATOPPING])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[CTHD] CHECK CONSTRAINT [FK_topping]
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [FK_nhanvien] FOREIGN KEY([MANV])
REFERENCES [dbo].[NHANVIEN] ([MANV])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [FK_nhanvien]
GO
USE [master]
GO
ALTER DATABASE [TraSua] SET  READ_WRITE 
GO
