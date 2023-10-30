 USE master;
GO

CREATE DATABASE quanly
  use quanly
set dateformat DMY
go

go
   CREATE TABLE [dbo].[Bank](
	[IDbank] [int] IDENTITY(1,1) NOT NULL primary key,
	[namebank] [nvarchar](50) NOT NULL,
	[Diachi] [nvarchar](150) NULL,
	[Phone] [char](12) NULL,
) ON [PRIMARY]
go
CREATE TABLE [dbo].[KhachHang](
	[IDkh] [int] IDENTITY(1,1) NOT NULL primary key,
	[IDbank] [int]	 NOT NULL references dbo.Bank(IDbank),
	[Name] [nvarchar](100) NOT NULL,
	[DiaChi] [nvarchar](50) NULL,
	[Email] [varchar](100) NULL,
	[Phone] [char](12) NULL,
	[CCCD] [varchar](50) NOT NULL unique,
	[Date] [smalldatetime] NOT NULL,
	)on [PRIMARY]
 go
 CREATE TABLE [dbo].[Loaitk](
	[IDloaitk] [int] IDENTITY(1,1) NOT NULL primary key,
	[name] [nvarchar](100) NOT NULL,
	)
 go
 CREATE TABLE [dbo].[Taikhoan](
	[IDtk] [int] IDENTITY(1,1) NOT NULL primary key,
	[IDkh] [int] NOT NULL references dbo.KhachHang(IDkh),
	[tentk] [nvarchar](100) NOT NULL,
	[sodutk] [decimal](18, 2) NOT NULL,
	[loaitk] [int] NOT NULL  references dbo.Loaitk(IDloaitk),
	[sotk] [varchar](10) NULL,
	[Datestart] [smalldatetime] NOT NULL,
	)on [PRIMARY]
go
  CREATE TABLE [dbo].[Loaigd](
	[IDloaigd] [int] IDENTITY(1,1) NOT NULL primary key,
	[Name] [nvarchar](50) NOT NULL,
	)on [PRIMARY]
go
CREATE TABLE [dbo].[GiaoDich](
	[IDgd] [int] IDENTITY(1,1) NOT NULL primary key,
	[IDtk] [int] NOT NULL references [dbo].[Taikhoan]([IDtk]),
	[IDloaigd] [int] NOT NULL references dbo.Loaigd(IDloaigd),
	[sotien] [decimal](18, 2) NOT NULL,
	[Dategd] [datetime] NOT NULL,
	[Notes] [nvarchar](100) NULL,
	)on [PRIMARY]
go
 CREATE TABLE [dbo].[Loails](
	[IDloails] [int] IDENTITY(1,1) NOT NULL primary key,
	[Name] [nvarchar](50) NOT NULL,
	)on [PRIMARY]
	go
 CREATE TABLE [dbo].[Laisuat](
	[IDls] [int] IDENTITY(1,1) NOT NULL primary key,
	[IDtk] [int] NOT NULL references dbo.Taikhoan(IDtk),
	[IDloails] [int] NOT NULL references dbo.Loails(IDloails),
	[mucls] [decimal](18, 2) NULL,
	[Datestart] [smalldatetime] NOT NULL,
	[Datend] [smalldatetime] NOT NULL,
	)on [PRIMARY]
go
go
CREATE TABLE [dbo].[tk_login](
	[Username] [nvarchar](50) NOT NULL,
	[Pass] [nvarchar](50) not NULL,
	[namebank] [nchar](10) NULL,
	[Ten] [nvarchar](50) NULL,
) ON [PRIMARY]
go
ALTER TABLE dbo.Taikhoan ADD CONSTRAINT DF_taikhoan_datestart DEFAULT GETDATE() for [Datestart];
ALTER TABLE dbo.Giaodich ADD CONSTRAINT DF_Giaodich_date DEFAULT GETDATE() for [Dategd];

ALTER TABLE dbo.Laisuat ADD CONSTRAINT DF_Laisuat_dates DEFAULT GETDATE() for [Datestart];
ALTER TABLE [dbo].[Taikhoan] ADD  CONSTRAINT [DF_Taikhoan_sodu]  DEFAULT ((0)) FOR [sodutk];
go

/*CREATE TRIGGER UpdateIDbank
ON [dbo].[KhachHang]
AFTER INSERT
AS
BEGIN
    -- Cập nhật trường IDbank trong bảng KhachHang với giá trị từ bảng Bank
    UPDATE KhachHang
    SET KhachHang.IDbank = Bank.IDbank
    FROM KhachHang
    INNER JOIN Bank ON KhachHang.IDbank = Bank.IDbank;
END;*/
go
/*CREATE TRIGGER UpdateIDkh
ON TaiKhoan
AFTER INSERT
AS
BEGIN
    UPDATE Taikhoan
    SET IDkh = inserted.IDkh 
    FROM KhachHang
    INNER JOIN inserted ON KhachHang.IDkh = inserted.IDtk;
END; */
go
/*CREATE TRIGGER UpdateIDloaitk
ON TaiKhoan
AFTER INSERT
AS
BEGIN
    UPDATE Taikhoan
    SET loaitk = inserted.loaitk
    FROM Loaitk
    INNER JOIN inserted ON Loaitk.IDloaitk = inserted.loaitk;
END;	   */

 go
INSERT INTO [dbo].[Bank] ([namebank]) VALUES (N'DinhNhuBank');
INSERT INTO [dbo].[Bank] ([namebank]) VALUES (N'DangQuangBank');
INSERT INTO [dbo].[Bank] ([namebank]) VALUES (N'KimNguyenBank');
INSERT INTO [dbo].[Bank] ([namebank]) VALUES (N'ThanhTuBank'); 
INSERT INTO [dbo].[Bank] ([namebank]) VALUES (N'HungDinhBank');
 go
DELETE FROM [dbo].[KhachHang];
INSERT INTO [dbo].[KhachHang] (IDbank,[Name], [CCCD], [Date]) VALUES (1,N'Bùi Đình Nhu', '123', '29-01-2003');
INSERT INTO [dbo].[KhachHang] (IDbank,[Name], [CCCD], [Date]) VALUES (2,N'Trịnh Đăng Quang', '1234', '12-3-2003');
INSERT INTO [dbo].[KhachHang] (IDbank,[Name], [CCCD], [Date]) VALUES (3,N'Dương Kim Nguyên', '12345', '12-11-2003');	
INSERT INTO [dbo].[KhachHang] (IDbank,[Name], [CCCD], [Date]) VALUES (4,N'Lê Thanh Tú', '123456', '12-12-2003');
INSERT INTO [dbo].[KhachHang] (IDbank,[Name], [CCCD], [Date]) VALUES (5,N'Nguyễn Hưng Định', '1234567', '11-11-2003');
go
insert into [dbo].[Loaitk] ([name]) values (N'Thường')
insert Loaitk ([name]) values (N'Vip')
go
--ALTER TABLE dbo.Laisuat ALTER COLUMN [mucls] [decimal](18, 2) NULL;
insert Taikhoan (IDkh,tentk,loaitk,sodutk) values ((SELECT IDkh FROM KhachHang WHERE CCCD = '123'),N'DinhNhu',2,100000000)
insert Taikhoan (IDkh,tentk,loaitk,sodutk) values ((SELECT IDkh FROM KhachHang WHERE CCCD = '1234'),N'DangQuang',1,7000000)
insert Taikhoan (IDkh,tentk,loaitk,sodutk) values ((SELECT IDkh FROM KhachHang WHERE CCCD = '12345'),N'KimNguyen',2,4000000)
insert Taikhoan (IDkh,tentk,loaitk,sodutk) values ((SELECT IDkh FROM KhachHang WHERE CCCD = '123456'),N'ThanhTu',1,5500000)
insert Taikhoan (IDkh,tentk,loaitk,sodutk) values ((SELECT IDkh FROM KhachHang WHERE CCCD = '1234567'),N'HungDinh',1,1700000)
go
insert Loaigd([Name]) values (N'Chuyển tiền'),(N'Rút tiền')
go 
insert GiaoDich(IDtk,IDloaigd,sotien) values ((SELECT IDtk FROM Taikhoan join KhachHang on Taikhoan.IDkh=KhachHang.IDkh where CCCD='123'),1,100000)
insert GiaoDich(IDtk,IDloaigd,sotien) values ((SELECT IDtk FROM Taikhoan join KhachHang on Taikhoan.IDkh=KhachHang.IDkh where CCCD='1234'),2,15000)
insert GiaoDich(IDtk,IDloaigd,sotien) values ((SELECT IDtk FROM Taikhoan join KhachHang on Taikhoan.IDkh=KhachHang.IDkh where CCCD='12345'),2,15000)
insert GiaoDich(IDtk,IDloaigd,sotien) values ((SELECT IDtk FROM Taikhoan join KhachHang on Taikhoan.IDkh=KhachHang.IDkh where CCCD='123456'),2,15000)
insert GiaoDich(IDtk,IDloaigd,sotien) values ((SELECT IDtk FROM Taikhoan join KhachHang on Taikhoan.IDkh=KhachHang.IDkh where CCCD='1234567'),1,20000)
go
insert Loails([Name]) values (N'Vay nợ'),(N'Ngân hàng')

go
insert Laisuat(IDtk,IDloails,Datend) values ((SELECT IDtk FROM Taikhoan join KhachHang on Taikhoan.IDkh=KhachHang.IDkh where CCCD='123'),1,'24-11-2023')
insert Laisuat(IDtk,IDloails,Datend) values ((SELECT IDtk FROM Taikhoan join KhachHang on Taikhoan.IDkh=KhachHang.IDkh where CCCD='1234'),2,'24-11-2024')
insert Laisuat(IDtk,IDloails,Datend) values ((SELECT IDtk FROM Taikhoan join KhachHang on Taikhoan.IDkh=KhachHang.IDkh where CCCD='12345'),1,'24-12-2023')
insert Laisuat(IDtk,IDloails,Datend) values ((SELECT IDtk FROM Taikhoan join KhachHang on Taikhoan.IDkh=KhachHang.IDkh where CCCD='123456'),1,'24-5-2024')
insert Laisuat(IDtk,IDloails,Datend) values ((SELECT IDtk FROM Taikhoan join KhachHang on Taikhoan.IDkh=KhachHang.IDkh where CCCD='1234567'),1,'24-2-2024')
 GO
 INSERT tk_login(Username,Pass) values (N'Nhu',1),(N'Quang',1),(N'Tu',1),(N'Nguyen',1),(N'Dinh',1)




select*from Laisuat
select*from Taikhoan
select *from tk_login
 SELECT IDtk FROM Taikhoan join KhachHang on Taikhoan.IDkh=KhachHang.IDkh where CCCD='123'