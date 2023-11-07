use master
go
create database QLNH
go
USE [QLNH]
set dateformat DMY
GO
/****** Object:  Table [dbo].[Bank]    Script Date: Wed, 1 Nov 2023 09:06:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bank](
	[IDBank] INT  NOT NULL,
	[NameBank] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IDBank] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
GO
CREATE TABLE [dbo].[Login](
	[Username] [char](50) NOT NULL,
	[Pass] [char](50) NOT NULL,
	[ID] [INT] NOT NULL,
	[loaitk] [int] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: Wed, 1 Nov 2023 09:06:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
/****** Object:  Table [dbo].[GiaoDich]    Script Date: Wed, 1 Nov 2023 09:06:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GiaoDich](
	[IDGD] [int] NOT NULL,
	[IDgui] [int] NOT NULL,
	[IDLoaiGD] [int] NOT NULL,
	[SoTien] [decimal](18, 2) NOT NULL,
	[DateGD] [datetime] NOT NULL,
	[Notes] [nvarchar](200) NULL,
	[IDnhan] [int] not null,
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
CREATE TABLE [dbo].[TaiKhoan](
	[ID] [int] NOT NULL,
	[Sotk] [int] IDENTITY(12140000, 1) NOT NULL,
	[NameTK] [nvarchar](50) NOT NULL,
	[SoDuTK] [decimal](18, 0) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
go

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
--go
--delete from Login
--go
--delete from TaiKhoan
--go
--delete from ThongTin
GO
INSERT [dbo].[Bank] ([IDBank], [NameBank]) VALUES (1210001, N'DNQT Bank')
INSERT [dbo].[Bank] ([IDBank], [NameBank]) VALUES (1210002, N'DQ Bank')
INSERT [dbo].[Bank] ([IDBank], [NameBank]) VALUES (1210003, N'VietNam Bank ')
INSERT [dbo].[Bank] ([IDBank], [NameBank]) VALUES (1210004, N'MC Bank')
INSERT [dbo].[Login] ([Username], [Pass], [ID], [loaitk]) VALUES (N'trinhdangquang                                    ', N'123                                               ', 20001, 1)
INSERT [dbo].[Login] ([Username], [Pass], [ID], [loaitk]) VALUES (N'buithiphuongvy                                    ', N'123                                               ', 20002, 1)
INSERT [dbo].[Login] ([Username], [Pass], [ID], [loaitk]) VALUES (N'quang                                             ', N'123                                               ', 10001, 0)
INSERT [dbo].[TaiKhoan] ([ID], [NameTK], [SoDuTK]) VALUES (20001, N'TRINH DANG QUANG', CAST(5000000 AS Decimal(18, 0)))
INSERT [dbo].[TaiKhoan] ([ID], [NameTK], [SoDuTK]) VALUES (20002, N'BUI THI PHUONG VY', CAST(100000000000 AS Decimal(18, 0)))
INSERT [dbo].[ThongTin] ([ID], [IDBank], [Name], [DiaChi], [Phone], [CCCD], [Date]) VALUES (10001, 1210001, N'Trịnh Đăng Quang', NULL, N'0843123654', N'040203013420', CAST(N'2003-12-26 00:00:00' AS SmallDateTime))
INSERT [dbo].[ThongTin] ([ID], [IDBank], [Name], [DiaChi], [Phone], [CCCD], [Date]) VALUES (20001, 1210001, N'Trịnh Đăng Quang', NULL, N'0843345868', N'040203010919', CAST(N'2003-12-26 00:00:00' AS SmallDateTime))
INSERT [dbo].[ThongTin] ([ID], [IDBank], [Name], [DiaChi], [Phone], [CCCD], [Date]) VALUES (20002, 1210001, N'Bùi Thị Phương Vy', N'Dĩ An, Bình Dương', N'0986318750', N'030101562343', CAST(N'2002-11-18 00:00:00' AS SmallDateTime))


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
ALTER TABLE [dbo].[GiaoDich]  WITH CHECK ADD FOREIGN KEY([IDgui])
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
go
create proc [dbo].[GET_NAME]
@userName nvarchar(100)
as
begin
	select * from dbo.Login inner join dbo.ThongTin on Login.ID = ThongTin.ID
	where Username = @userName 
end
GO
SELECT * FROM ThongTin INNER JOIN Login ON ThongTin.ID = Login.ID
go
CREATE PROCEDURE [dbo].[CHECK_FORGOT]
    @name NVARCHAR(50),
    @cccd CHAR(12),
    @phone CHAR(10),
    @userName NVARCHAR(100)
AS
BEGIN
    SELECT * 
    FROM dbo.Login 
    INNER JOIN dbo.ThongTin ON Login.ID = ThongTin.ID
    WHERE (Username = @name OR Username = @userName) AND CCCD = @cccd AND Phone = @phone
END
go
alter proc [dbo].[add_account]
	@name nvarchar(50),
	@cccd char(12),
	@phone char(10),
	@user varchar(150),
	@pass varchar(50),
	@id int,
	@date smalldatetime,
	@loaitk int
	,@bank int
	,@stk int
	AS 
	begin 
	begin try
	BEGIN TRANSACTION;

        -- Kiểm tra xem tài khoản có tồn tại chưa
        IF NOT EXISTS (SELECT 1 FROM ThongTin tt join Login lg on tt.ID=lg.ID where tt.CCCD=@cccd or tt.Phone=@phone or lg.Username=@user
)
        BEGIN
            -- Thêm tài khoản mới
             INSERT INTO ThongTin (Name, ID, Phone, CCCD,Date,IDBank) VALUES (@name, @id, @phone, @cccd,@date,@bank);
            INSERT INTO Login (Username, Pass,ID,loaitk) VALUES (@user, @pass,@id,@loaitk);
			insert into TaiKhoan(ID,SoDuTK,NameTK)values(@id,@stk,@name)
            COMMIT TRANSACTION;
        END
        ELSE
        BEGIN
            -- Nếu tài khoản đã tồn tại, có thể xử lý theo ý muốn (ví dụ: thông báo lỗi).
            -- RAISEERROR('Tài khoản đã tồn tại', 16, 1);
            ROLLBACK TRANSACTION;
        END

	end try
		BEGIN CATCH
			IF @@TRANCOUNT >0
			BEGIN
				ROLLBACK TRANSACTION;
			END

			--EXECUTE sp_error 
		END CATCH
END; 
go
exec [dbo].[add_account] @name='abc', @cccd=1, @phone=1, @user='abc', @pass=1, @id=1, @date='29-01-2003', @loaitk=1,@bank=1210001,@stk=0
use QLNH
drop proc add_account


select*from TaiKhoan
select*from Login
select*from ThongTin
select*from Bank
--ALTER TABLE [dbo].[Login]
--DROP CONSTRAINT UC_Username;


--ALTER TABLE [dbo].[Login]
--ADD CONSTRAINT UC_Username UNIQUE ([Username]);

--ALTER TABLE [dbo].[ThongTin]
--ADD CONSTRAINT TT_phone  UNIQUE ([Phone]);

--ALTER TABLE [dbo].[ThongTin]
--ADD CONSTRAINT TT_cccd  UNIQUE ([CCCD]);

--EXEC sp_helpconstraint Taikhoan;
go
ALTER TABLE  DROP COLUMN sotk;