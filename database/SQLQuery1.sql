 USE master;
GO

CREATE DATABASE QLNH
go
  use QLNH
set dateformat DMY
go

CREATE TABLE [dbo].[Bank](
    [IDBank] [int] NOT NULL PRIMARY KEY,
    [NameBank] [nvarchar](50) NOT NULL
);
go
CREATE TABLE [dbo].[ThongTin](
    [ID] [int] NOT NULL PRIMARY KEY,
    [IDBank] [int] NOT NULL,
    [Name] [nvarchar](50) NOT NULL,
    [DiaChi] [nvarchar](100) NULL,
    [Phone] [char](10) NOT NULL UNIQUE,
    [CCCD] [char](12) NOT NULL UNIQUE,
    [Date] [smalldatetime] NOT NULL,
    FOREIGN KEY (IDBank) REFERENCES [dbo].[Bank]([IDBank])
);
go
CREATE TABLE [dbo].[TaiKhoan](
    [ID] [int] NOT NULL PRIMARY KEY,
    [Sotk] [int] NOT NULL,
    [NameTK] [nvarchar](50) NOT NULL,
    [SoDuTK] [decimal](18, 2) NOT NULL,
    FOREIGN KEY (ID) REFERENCES [dbo].[ThongTin]([ID])
);
go
CREATE TABLE [dbo].[LoaiGD](
    [IDLoaiGD] [int] NOT NULL PRIMARY KEY,
    [Name] [nvarchar](50) NOT NULL
);
go
CREATE TABLE [dbo].[GiaoDich](
    [IDGD] [int] NOT NULL PRIMARY KEY,
    [ID] [int] NOT NULL,
    [IDLoaiGD] [int] NOT NULL,
    [SoTien] [decimal](18, 2) NOT NULL,
    [DateGD] [datetime] NOT NULL,
    [Notes] [nvarchar](200) NULL,
    FOREIGN KEY (ID) REFERENCES [dbo].[TaiKhoan]([ID]),
    FOREIGN KEY (IDLoaiGD) REFERENCES [dbo].[LoaiGD]([IDLoaiGD])
);
go
CREATE TABLE [dbo].[LoaiLS](
    [IDLoaiLS] [int] NOT NULL PRIMARY KEY,
    [Name] [nvarchar](50) NOT NULL
);
go
CREATE TABLE [dbo].[LaiSuat](
    [IDls] [int] NOT NULL PRIMARY KEY,
    [ID] [int] NOT NULL,
    [IDLoaiLS] [int] NOT NULL,
    [MuCLS] [decimal](18, 2) NULL,
    [DateStart] [smalldatetime] NOT NULL,
    [DateEnd] [smalldatetime] NOT NULL,
    FOREIGN KEY (ID) REFERENCES [dbo].[TaiKhoan]([ID]),
    FOREIGN KEY (IDLoaiLS) REFERENCES [dbo].[LoaiLS]([IDLoaiLS])
);
go
CREATE TABLE [dbo].[Login](
    [Username] [char](50) NOT NULL,
    [Pass] [char](50) NOT NULL,
    [ID] [int] NOT NULL,
    [loaitk] [int] NOT NULL,
    FOREIGN KEY (ID) REFERENCES [dbo].[ThongTin]([ID])
);
go

CREATE PROC CHECK_LOGIN
@userName nvarchar(100),
@passWord nvarchar(100)
AS 
BEGIN
	SELECT * FROM dbo.Login, dbo.ThongTin
	WHERE Username =@userName AND Pass = @passWord
END
GO
	