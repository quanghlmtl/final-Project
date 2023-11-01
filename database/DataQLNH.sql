use master
go 
create database QLNH
USE [QLNH]
go
GO
/****** Object:  Table [dbo].[Bank]    Script Date: Wed, 1 Nov 2023 09:06:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bank](
	[IDBank] [int] NOT NULL,
	[NameBank] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IDBank] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[GiaoDich]    Script Date: Wed, 1 Nov 2023 09:06:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GiaoDich](
	[IDGD] [int] NOT NULL,
	[ID] [int] NOT NULL,
	[IDLoaiGD] [int] NOT NULL,
	[SoTien] [decimal](18, 2) NOT NULL,
	[DateGD] [datetime] NOT NULL,
	[Notes] [nvarchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[IDGD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LaiSuat]    Script Date: Wed, 1 Nov 2023 09:06:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LaiSuat](
	[IDls] [int] NOT NULL,
	[ID] [int] NOT NULL,
	[IDLoaiLS] [int] NOT NULL,
	[MuCLS] [decimal](18, 2) NULL,
	[DateStart] [smalldatetime] NOT NULL,
	[DateEnd] [smalldatetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IDls] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LoaiGD]    Script Date: Wed, 1 Nov 2023 09:06:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiGD](
	[IDLoaiGD] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IDLoaiGD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LoaiLS]    Script Date: Wed, 1 Nov 2023 09:06:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiLS](
	[IDLoaiLS] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IDLoaiLS] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Login]    Script Date: Wed, 1 Nov 2023 09:06:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Login](
	[Username] [char](50) NOT NULL,
	[Pass] [char](50) NOT NULL,
	[ID] [int] NOT NULL,
	[loaitk] [int] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: Wed, 1 Nov 2023 09:06:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[ID] [int] NOT NULL,
	[Sotk] [int] NOT NULL,
	[NameTK] [nvarchar](50) NOT NULL,
	[SoDuTK] [decimal](18, 2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ThongTin]    Script Date: Wed, 1 Nov 2023 09:06:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ThongTin](
	[ID] [int] NOT NULL,
	[IDBank] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[DiaChi] [nvarchar](100) NULL,
	[Phone] [char](10) NOT NULL,
	[CCCD] [char](12) NOT NULL,
	[Date] [smalldatetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Bank] ([IDBank], [NameBank]) VALUES (1210001, N'DNQT Bank')
INSERT [dbo].[Bank] ([IDBank], [NameBank]) VALUES (1210002, N'DQ Bank')
INSERT [dbo].[Bank] ([IDBank], [NameBank]) VALUES (1210003, N'VietNam Bank ')
INSERT [dbo].[Bank] ([IDBank], [NameBank]) VALUES (1210004, N'MC Bank')
INSERT [dbo].[Login] ([Username], [Pass], [ID], [loaitk]) VALUES (N'trinhdangquang                                    ', N'123                                               ', 20001, 1)
INSERT [dbo].[Login] ([Username], [Pass], [ID], [loaitk]) VALUES (N'buithiphuongvy                                    ', N'123                                               ', 20002, 1)
INSERT [dbo].[Login] ([Username], [Pass], [ID], [loaitk]) VALUES (N'quang                                             ', N'123                                               ', 10001, 0)
INSERT [dbo].[TaiKhoan] ([ID], [Sotk], [NameTK], [SoDuTK]) VALUES (20001, 123453246, N'TRINH DANG QUANG', CAST(5000000.00 AS Decimal(18, 2)))
INSERT [dbo].[TaiKhoan] ([ID], [Sotk], [NameTK], [SoDuTK]) VALUES (20002, 987654321, N'BUI THI PHUONG VY', CAST(100000000000.00 AS Decimal(18, 2)))
INSERT [dbo].[ThongTin] ([ID], [IDBank], [Name], [DiaChi], [Phone], [CCCD], [Date]) VALUES (10001, 1210001, N'Trịnh Đăng Quang', NULL, N'0843123654', N'040203013420', CAST(N'2003-12-26 00:00:00' AS SmallDateTime))
INSERT [dbo].[ThongTin] ([ID], [IDBank], [Name], [DiaChi], [Phone], [CCCD], [Date]) VALUES (20001, 1210001, N'Trịnh Đăng Quang', NULL, N'0843345868', N'040203010919', CAST(N'2003-12-26 00:00:00' AS SmallDateTime))
INSERT [dbo].[ThongTin] ([ID], [IDBank], [Name], [DiaChi], [Phone], [CCCD], [Date]) VALUES (20002, 1210001, N'Bùi Thị Phương Vy', N'Dĩ An, Bình Dương', N'0986318750', N'030101562343', CAST(N'2002-11-18 00:00:00' AS SmallDateTime))
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__ThongTin__5C7E359EC91BE053]    Script Date: Wed, 1 Nov 2023 09:06:28 AM ******/
ALTER TABLE [dbo].[ThongTin] ADD UNIQUE NONCLUSTERED 
(
	[Phone] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__ThongTin__A955A0AA2C156C32]    Script Date: Wed, 1 Nov 2023 09:06:28 AM ******/
ALTER TABLE [dbo].[ThongTin] ADD UNIQUE NONCLUSTERED 
(
	[CCCD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[GiaoDich]  WITH CHECK ADD FOREIGN KEY([ID])
REFERENCES [dbo].[TaiKhoan] ([ID])
GO
ALTER TABLE [dbo].[GiaoDich]  WITH CHECK ADD FOREIGN KEY([IDLoaiGD])
REFERENCES [dbo].[LoaiGD] ([IDLoaiGD])
GO
ALTER TABLE [dbo].[LaiSuat]  WITH CHECK ADD FOREIGN KEY([ID])
REFERENCES [dbo].[TaiKhoan] ([ID])
GO
ALTER TABLE [dbo].[LaiSuat]  WITH CHECK ADD FOREIGN KEY([IDLoaiLS])
REFERENCES [dbo].[LoaiLS] ([IDLoaiLS])
GO
ALTER TABLE [dbo].[Login]  WITH CHECK ADD FOREIGN KEY([ID])
REFERENCES [dbo].[ThongTin] ([ID])
GO
ALTER TABLE [dbo].[TaiKhoan]  WITH CHECK ADD FOREIGN KEY([ID])
REFERENCES [dbo].[ThongTin] ([ID])
GO
ALTER TABLE [dbo].[ThongTin]  WITH CHECK ADD FOREIGN KEY([IDBank])
REFERENCES [dbo].[Bank] ([IDBank])
GO
/****** Object:  StoredProcedure [dbo].[CHECK_LOGIN]    Script Date: Wed, 1 Nov 2023 09:06:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[CHECK_LOGIN]
@userName nvarchar(100),
@passWord nvarchar(100)
AS 
BEGIN
	SELECT * FROM dbo.Login, dbo.ThongTin
	WHERE Username =@userName AND Pass = @passWord
END

GO
create proc [dbo].[GET_NAME]
@userName nvarchar(100)
as
begin
	select * from dbo.Login inner join dbo.ThongTin on Login.ID = ThongTin.ID
	where Username = @userName 
end
GO
SELECT * FROM ThongTin INNER JOIN Login ON ThongTin.ID = Login.ID
select*from Login
go
alter proc forgotpass
	@name nvarchar(100),
	@cccd char(12),
	@Phone char(10),
	@Username nvarchar(100)
	as 
	begin
	select*from ThongTin join Login on ThongTin.ID=Login.ID 
	where ThongTin.Name=@name and ThongTin.CCCD=@cccd
		and ThongTin.Phone=@Phone and Login.Username=@Username
	end
go

select*from ThongTin tt join Login lg on tt.ID=lg.ID 
	where tt.Name=N'Bùi Thị Phương Vy' and tt.CCCD='030101562343'
		and tt.Phone='0986318750' and  lg.Username='buithiphuongvy'
select*from ThongTin tt where tt.Phone='0986318750'	
select*from Login where Username='buithiphuongvy'											
