use master
go
create database QLNH
go
USE [QLNH]
GO
/****** Object:  Table [dbo].[Bank]    Script Date: Tue, 21 Nov 2023 05:00:21 PM ******/
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
/****** Object:  Table [dbo].[Cards]    Script Date: Tue, 21 Nov 2023 05:00:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Cards](
	[CardID] [int] NULL,
	[ID] [int] NOT NULL,
	[CardNumber] [varchar](19) NOT NULL,
	[SoDuCard] [int] NOT NULL,
	[IssueDate] [smalldatetime] NOT NULL,
	[ExpirationDate] [smalldatetime] NOT NULL,
	[CVV] [nvarchar](3) NOT NULL,
	[IsActive] [bit] NOT NULL DEFAULT ((1))
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DichVu]    Script Date: Tue, 21 Nov 2023 05:00:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DichVu](
	[IDDichVu] [int] IDENTITY(1,1) NOT NULL,
	[ID] [int] NOT NULL,
	[MucLS] [float] NOT NULL,
	[LoaiDichVu] [nvarchar](50) NOT NULL,
	[MoneyStart] [int] NOT NULL,
	[MoneyEnd] [int] NOT NULL,
	[DateStart] [smalldatetime] NOT NULL,
	[DateEnd] [smalldatetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IDDichVu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[GiaoDich]    Script Date: Tue, 21 Nov 2023 05:00:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GiaoDich](
	[IDGD] [int] NOT NULL,
	[IDFrom] [int] NOT NULL,
	[IDTo] [int] NOT NULL,
	[SoTien] [int] NOT NULL,
	[DateGD] [smalldatetime] NOT NULL,
	[Notes] [nvarchar](200) NULL,
 CONSTRAINT [PK_GiaoDich] PRIMARY KEY CLUSTERED 
(
	[IDGD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = ON, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Login]    Script Date: Tue, 21 Nov 2023 05:00:21 PM ******/
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
	[loaitk] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: Tue, 21 Nov 2023 05:00:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[ID] [int] NOT NULL,
	[IDBank] [int] NOT NULL,
	[Sotk] [int] NOT NULL,
	[NameTK] [nvarchar](50) NOT NULL,
	[SoDuTK] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ThongTin]    Script Date: Tue, 21 Nov 2023 05:00:21 PM ******/
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
INSERT [dbo].[Cards] ([CardID], [ID], [CardNumber], [SoDuCard], [IssueDate], [ExpirationDate], [CVV], [IsActive]) VALUES (1, 20001, N'1234 5678 9012 3456', 1000, CAST(N'2023-01-01 00:00:00' AS SmallDateTime), CAST(N'2025-12-31 00:00:00' AS SmallDateTime), N'561', 1)
INSERT [dbo].[Cards] ([CardID], [ID], [CardNumber], [SoDuCard], [IssueDate], [ExpirationDate], [CVV], [IsActive]) VALUES (2, 20001, N'9876 5432 1098 7654', 1500, CAST(N'2023-02-01 00:00:00' AS SmallDateTime), CAST(N'2026-01-31 00:00:00' AS SmallDateTime), N'371', 1)
INSERT [dbo].[Cards] ([CardID], [ID], [CardNumber], [SoDuCard], [IssueDate], [ExpirationDate], [CVV], [IsActive]) VALUES (1, 20002, N'1111 2222 3333 4444', 0, CAST(N'2023-03-01 00:00:00' AS SmallDateTime), CAST(N'2026-02-28 00:00:00' AS SmallDateTime), N'393', 1)
INSERT [dbo].[Cards] ([CardID], [ID], [CardNumber], [SoDuCard], [IssueDate], [ExpirationDate], [CVV], [IsActive]) VALUES (2, 20002, N'5555 6666 7777 8888', 0, CAST(N'2023-04-01 00:00:00' AS SmallDateTime), CAST(N'2026-03-31 00:00:00' AS SmallDateTime), N'666', 1)
INSERT [dbo].[Cards] ([CardID], [ID], [CardNumber], [SoDuCard], [IssueDate], [ExpirationDate], [CVV], [IsActive]) VALUES (1, 20003, N'3333 9999 5555 3333', 0, CAST(N'2023-03-01 00:00:00' AS SmallDateTime), CAST(N'2026-02-28 00:00:00' AS SmallDateTime), N'422', 1)
INSERT [dbo].[Cards] ([CardID], [ID], [CardNumber], [SoDuCard], [IssueDate], [ExpirationDate], [CVV], [IsActive]) VALUES (2, 20003, N'3333 3333 1111 1111', 0, CAST(N'2023-04-01 00:00:00' AS SmallDateTime), CAST(N'2026-03-31 00:00:00' AS SmallDateTime), N'538', 1)
INSERT [dbo].[Cards] ([CardID], [ID], [CardNumber], [SoDuCard], [IssueDate], [ExpirationDate], [CVV], [IsActive]) VALUES (3, 20003, N'1234 1234 1234 4444', 0, CAST(N'2023-03-01 00:00:00' AS SmallDateTime), CAST(N'2026-02-28 00:00:00' AS SmallDateTime), N'934', 1)
INSERT [dbo].[Cards] ([CardID], [ID], [CardNumber], [SoDuCard], [IssueDate], [ExpirationDate], [CVV], [IsActive]) VALUES (4, 20003, N'4321 4321 4321 8888', 0, CAST(N'2023-04-01 00:00:00' AS SmallDateTime), CAST(N'2026-03-31 00:00:00' AS SmallDateTime), N'812', 1)
INSERT [dbo].[Cards] ([CardID], [ID], [CardNumber], [SoDuCard], [IssueDate], [ExpirationDate], [CVV], [IsActive]) VALUES (3, 20002, N'3233 9199 6655 1133', 0, CAST(N'2023-03-01 00:00:00' AS SmallDateTime), CAST(N'2026-02-28 00:00:00' AS SmallDateTime), N'696', 1)
INSERT [dbo].[Cards] ([CardID], [ID], [CardNumber], [SoDuCard], [IssueDate], [ExpirationDate], [CVV], [IsActive]) VALUES (4, 20002, N'6783 3453 2211 1331', 0, CAST(N'2023-04-01 00:00:00' AS SmallDateTime), CAST(N'2026-03-31 00:00:00' AS SmallDateTime), N'747', 1)
SET IDENTITY_INSERT [dbo].[DichVu] ON 
INSERT [dbo].[DichVu] ([IDDichVu], [ID], [MucLS], [LoaiDichVu], [MoneyStart], [MoneyEnd], [DateStart], [DateEnd]) VALUES (11, 20003, 0.07, N'Sổ tiết kiệm', 50000000, 53500000, CAST(N'2023-11-21 00:00:00' AS SmallDateTime), CAST(N'2026-11-21 00:00:00' AS SmallDateTime))
INSERT [dbo].[DichVu] ([IDDichVu], [ID], [MucLS], [LoaiDichVu], [MoneyStart], [MoneyEnd], [DateStart], [DateEnd]) VALUES (12, 20003, 0.07, N'Sổ tiết kiệm', 20000000, 21400000, CAST(N'2023-11-21 00:00:00' AS SmallDateTime), CAST(N'2024-11-21 00:00:00' AS SmallDateTime))
SET IDENTITY_INSERT [dbo].[DichVu] OFF
INSERT [dbo].[GiaoDich] ([IDGD], [IDFrom], [IDTo], [SoTien], [DateGD], [Notes]) VALUES (11101, 20003, 20002, 111111111, CAST(N'2023-11-13 00:00:00' AS SmallDateTime), N'Trịnh Đăng Quang chuyen tien')
INSERT [dbo].[GiaoDich] ([IDGD], [IDFrom], [IDTo], [SoTien], [DateGD], [Notes]) VALUES (11102, 20003, 20002, 20000000, CAST(N'2023-11-21 00:00:00' AS SmallDateTime), N'Trịnh Đăng Quang chuyen tien')
INSERT [dbo].[GiaoDich] ([IDGD], [IDFrom], [IDTo], [SoTien], [DateGD], [Notes]) VALUES (11103, 20003, 20009, 120000000, CAST(N'2023-11-21 00:00:00' AS SmallDateTime), N'Trịnh Đăng Quang Chuyển tiền')
INSERT [dbo].[GiaoDich] ([IDGD], [IDFrom], [IDTo], [SoTien], [DateGD], [Notes]) VALUES (11107, 20003, 20002, 111111, CAST(N'2023-11-13 00:00:00' AS SmallDateTime), N'Trịnh Đăng Quang chuyen tien')
INSERT [dbo].[GiaoDich] ([IDGD], [IDFrom], [IDTo], [SoTien], [DateGD], [Notes]) VALUES (11108, 20003, 20002, 1111111, CAST(N'2023-11-13 00:00:00' AS SmallDateTime), N'Trịnh Đăng Quang chuyen tien')
INSERT [dbo].[Login] ([Username], [Pass], [ID], [loaitk]) VALUES (N'quang                                             ', N'123                                               ', 10001, 0)
INSERT [dbo].[Login] ([Username], [Pass], [ID], [loaitk]) VALUES (N'trinhdangquang                                    ', N'123                                               ', 20001, 1)
INSERT [dbo].[Login] ([Username], [Pass], [ID], [loaitk]) VALUES (N'buithiphuongvy                                    ', N'123                                               ', 20002, 1)
INSERT [dbo].[Login] ([Username], [Pass], [ID], [loaitk]) VALUES (N'1                                                 ', N'1                                                 ', 20003, 1)
INSERT [dbo].[Login] ([Username], [Pass], [ID], [loaitk]) VALUES (N'2                                                 ', N'2                                                 ', 20006, 1)
INSERT [dbo].[Login] ([Username], [Pass], [ID], [loaitk]) VALUES (N'nhudinhbui                                        ', N'123                                               ', 20007, 1)
INSERT [dbo].[Login] ([Username], [Pass], [ID], [loaitk]) VALUES (N'tule                                              ', N'123                                               ', 20008, 1)
INSERT [dbo].[Login] ([Username], [Pass], [ID], [loaitk]) VALUES (N'my                                                ', N'1                                                 ', 20009, 1)
INSERT [dbo].[Login] ([Username], [Pass], [ID], [loaitk]) VALUES (N'raucon                                            ', N'1                                                 ', 20011, 1)
INSERT [dbo].[TaiKhoan] ([ID], [IDBank], [Sotk], [NameTK], [SoDuTK]) VALUES (20001, 1210001, 123453246, N'TRINH DANG QUANG', 5000000)
INSERT [dbo].[TaiKhoan] ([ID], [IDBank], [Sotk], [NameTK], [SoDuTK]) VALUES (20002, 1210001, 7983246, N'BUI THI PHUONG VY', 1000000000)
INSERT [dbo].[TaiKhoan] ([ID], [IDBank], [Sotk], [NameTK], [SoDuTK]) VALUES (20003, 1210003, 999654111, N'TRINH DANG QUANG', 55000000)
INSERT [dbo].[TaiKhoan] ([ID], [IDBank], [Sotk], [NameTK], [SoDuTK]) VALUES (20004, 1210002, 988888812, N'TRINH DANG QUANG', 40000000)
INSERT [dbo].[TaiKhoan] ([ID], [IDBank], [Sotk], [NameTK], [SoDuTK]) VALUES (20005, 1210004, 988555821, N'BUI DINH NHU', 20000000)
INSERT [dbo].[TaiKhoan] ([ID], [IDBank], [Sotk], [NameTK], [SoDuTK]) VALUES (20006, 1210001, 123453246, N'DUONG KIM NGUYEN', 5000000)
INSERT [dbo].[TaiKhoan] ([ID], [IDBank], [Sotk], [NameTK], [SoDuTK]) VALUES (20007, 1210001, 343873212, N'BUI DINH NHU', 1000000)
INSERT [dbo].[TaiKhoan] ([ID], [IDBank], [Sotk], [NameTK], [SoDuTK]) VALUES (20008, 1210001, 123453246, N'LE NGUYEN THANH TU', 500000)
INSERT [dbo].[TaiKhoan] ([ID], [IDBank], [Sotk], [NameTK], [SoDuTK]) VALUES (20009, 1210001, 653183187, N'DANG HUYEN MY', 175000000)
INSERT [dbo].[TaiKhoan] ([ID], [IDBank], [Sotk], [NameTK], [SoDuTK]) VALUES (20011, 1210001, 653183186, N'MESSI', 0)
INSERT [dbo].[ThongTin] ([ID], [IDBank], [Name], [DiaChi], [Phone], [CCCD], [Date]) VALUES (10001, 1210001, N'Trịnh Đăng Quang', NULL, N'0843123654', N'040203013420', CAST(N'2003-12-26 00:00:00' AS SmallDateTime))
INSERT [dbo].[ThongTin] ([ID], [IDBank], [Name], [DiaChi], [Phone], [CCCD], [Date]) VALUES (20001, 1210001, N'Trịnh Đăng Quang', NULL, N'0843345868', N'040203010919', CAST(N'2003-12-26 00:00:00' AS SmallDateTime))
INSERT [dbo].[ThongTin] ([ID], [IDBank], [Name], [DiaChi], [Phone], [CCCD], [Date]) VALUES (20002, 1210001, N'Bùi Thị Phương Vy', N'Dĩ An, Bình Dương', N'0986318750', N'030101562343', CAST(N'2002-11-18 00:00:00' AS SmallDateTime))
INSERT [dbo].[ThongTin] ([ID], [IDBank], [Name], [DiaChi], [Phone], [CCCD], [Date]) VALUES (20003, 1210003, N'Trịnh Đăng Quang', NULL, N'0843345869', N'040203010916', CAST(N'2003-12-26 00:00:00' AS SmallDateTime))
INSERT [dbo].[ThongTin] ([ID], [IDBank], [Name], [DiaChi], [Phone], [CCCD], [Date]) VALUES (20004, 1210002, N'Trịnh Đăng Quang', NULL, N'0843341869', N'040444410916', CAST(N'2003-12-26 00:00:00' AS SmallDateTime))
INSERT [dbo].[ThongTin] ([ID], [IDBank], [Name], [DiaChi], [Phone], [CCCD], [Date]) VALUES (20005, 1210004, N'Bùi Đình Nhu', NULL, N'0982762877', N'040203567843', CAST(N'2003-02-06 00:00:00' AS SmallDateTime))
INSERT [dbo].[ThongTin] ([ID], [IDBank], [Name], [DiaChi], [Phone], [CCCD], [Date]) VALUES (20006, 1210001, N'Dương Kim Nguyên', NULL, N'0943543651', N'040203343321', CAST(N'2003-11-08 00:00:00' AS SmallDateTime))
INSERT [dbo].[ThongTin] ([ID], [IDBank], [Name], [DiaChi], [Phone], [CCCD], [Date]) VALUES (20007, 1210001, N'Bùi Đình Nhu', NULL, N'0978546432', N'1234567321  ', CAST(N'2023-11-21 10:52:00' AS SmallDateTime))
INSERT [dbo].[ThongTin] ([ID], [IDBank], [Name], [DiaChi], [Phone], [CCCD], [Date]) VALUES (20008, 1210001, N'Lê Nguyễn Thanh Tú', NULL, N'0364345765', N'75433212343 ', CAST(N'2023-11-21 10:52:00' AS SmallDateTime))
INSERT [dbo].[ThongTin] ([ID], [IDBank], [Name], [DiaChi], [Phone], [CCCD], [Date]) VALUES (20009, 1210001, N'Đặng Huyền My', NULL, N'0987654321', N'1123452324  ', CAST(N'2023-11-21 10:50:00' AS SmallDateTime))
INSERT [dbo].[ThongTin] ([ID], [IDBank], [Name], [DiaChi], [Phone], [CCCD], [Date]) VALUES (20011, 1210001, N'messi', NULL, N'0999999999', N'444444444   ', CAST(N'2023-11-21 11:10:00' AS SmallDateTime))
/****** Object:  Index [UQ_CardID_ID]    Script Date: Tue, 21 Nov 2023 05:00:21 PM ******/
ALTER TABLE [dbo].[Cards] ADD  CONSTRAINT [UQ_CardID_ID] UNIQUE NONCLUSTERED 
(
	[CardID] ASC,
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__ThongTin__5C7E359EEBF33560]    Script Date: Tue, 21 Nov 2023 05:00:21 PM ******/
ALTER TABLE [dbo].[ThongTin] ADD UNIQUE NONCLUSTERED 
(
	[Phone] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__ThongTin__A955A0AA3FF80D51]    Script Date: Tue, 21 Nov 2023 05:00:21 PM ******/
ALTER TABLE [dbo].[ThongTin] ADD UNIQUE NONCLUSTERED 
(
	[CCCD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
ALTER TABLE [dbo].[Cards]  WITH CHECK ADD FOREIGN KEY([ID])
REFERENCES [dbo].[ThongTin] ([ID])
GO
ALTER TABLE [dbo].[DichVu]  WITH CHECK ADD FOREIGN KEY([ID])
REFERENCES [dbo].[TaiKhoan] ([ID])
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
/****** Object:  StoredProcedure [dbo].[ADD_ACCOUNT]    Script Date: Tue, 21 Nov 2023 05:00:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ADD_ACCOUNT]
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
	,@sodutk int
	,@Nametk nvarchar(50)
	AS 
	begin 
		set dateformat DMY
	begin try
	BEGIN TRANSACTION;

        -- Kiểm tra xem tài khoản có tồn tại chưa
        IF NOT EXISTS (SELECT 1 FROM ThongTin tt join Login lg on tt.ID=lg.ID where tt.CCCD=@cccd or tt.Phone=@phone or lg.Username=@user
)
        BEGIN
            -- Thêm tài khoản mới
             INSERT INTO ThongTin (Name, ID, Phone, CCCD,Date,IDBank) VALUES (@name, @id, @phone, @cccd,@date,@bank);
            INSERT INTO Login (Username, Pass,ID,loaitk) VALUES (@user, @pass,@id,@loaitk);
			insert into TaiKhoan(ID,IDBank,Sotk,SoDuTK,NameTK)values(@id,@bank,@stk,@sodutk,@Nametk)
            COMMIT TRANSACTION;
        END
        ELSE
        BEGIN
            ROLLBACK TRANSACTION;
        END
	end try
		BEGIN CATCH
			IF @@TRANCOUNT >0
			BEGIN
				ROLLBACK TRANSACTION;
			END
		END CATCH
END; 

GO
/****** Object:  StoredProcedure [dbo].[CHECK_ACCOUNT_EXISTENCE]    Script Date: Tue, 21 Nov 2023 05:00:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

	CREATE PROCEDURE [dbo].[CHECK_ACCOUNT_EXISTENCE]
		@Sotk INT,
		@nameBank NVARCHAR(50)
	AS
	BEGIN
			SELECT tk.NameTK
			FROM dbo.TaiKhoan tk 
			JOIN dbo.Bank b ON tk.IDBank = b.IDBank 
			WHERE tk.Sotk = @Sotk AND b.NameBank = @nameBank
	END

GO
/****** Object:  StoredProcedure [dbo].[CHECK_FORGOT]    Script Date: Tue, 21 Nov 2023 05:00:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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

GO
/****** Object:  StoredProcedure [dbo].[CHECK_LOGIN]    Script Date: Tue, 21 Nov 2023 05:00:21 PM ******/
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
/****** Object:  StoredProcedure [dbo].[GET_NAME]    Script Date: Tue, 21 Nov 2023 05:00:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GET_NAME]
@userName nvarchar(100)
as
begin
	select * from dbo.Login inner join dbo.ThongTin on Login.ID = ThongTin.ID
	where Username = @userName 
end

GO
/****** Object:  StoredProcedure [dbo].[INSERT_GIAODICH]    Script Date: Tue, 21 Nov 2023 05:00:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[INSERT_GIAODICH]
    @IDGD INT,
    @IDTo INT,
    @IDFrom INT,
    @SoTien INT,
    @DateGD smalldatetime,
    @Notes NVARCHAR(200)
AS
BEGIN
    INSERT INTO [dbo].[GiaoDich] ([IDGD], [IDTo], [IDFrom], [SoTien], [DateGD], [Notes])
    VALUES (@IDGD, @IDTo, @IDFrom, @SoTien, @DateGD, @Notes)
END

GO
/****** Object:  StoredProcedure [dbo].[InsertCard]    Script Date: Tue, 21 Nov 2023 05:00:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertCard]
    @ID INT,
    @CardNumber VARCHAR(19),
    @SoDuCard INT,
    @IssueDate SMALLDATETIME,
    @ExpirationDate SMALLDATETIME
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO Cards (ID, CardNumber, SoDuCard, IssueDate, ExpirationDate)
    VALUES (@ID, @CardNumber, @SoDuCard, @IssueDate, @ExpirationDate);
END;

GO
/****** Object:  StoredProcedure [dbo].[InsertDichVu]    Script Date: Tue, 21 Nov 2023 05:00:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertDichVu]
    @ID INT,
    @MucLS Float,
    @LoaiDichVu NVARCHAR(50),
    @MoneyStart INT,
    @MoneyEnd INT,
    @DateStart SMALLDATETIME,
    @DateEnd SMALLDATETIME
AS
BEGIN
    INSERT INTO [dbo].[DichVu] ([ID], [MucLS], [LoaiDichVu], [MoneyStart], [MoneyEnd], [DateStart], [DateEnd])
    VALUES (@ID, @MucLS, @LoaiDichVu, @MoneyStart, @MoneyEnd, @DateStart, @DateEnd);
END;
GO
/****** Object:  StoredProcedure [dbo].[SelectAllGiaoDich]    Script Date: Tue, 21 Nov 2023 05:00:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[SelectAllGiaoDich]
    @TuKhoa nvarchar(100),
	@id int
AS
BEGIN
    SET DATEFORMAT DMY;
	begin try
	
    SELECT
        gd.IDGD,
        tkFrom.NameTK,
        tkTo.NameTK,
        gd.SoTien,
        gd.DateGD,
        gd.Notes
		FROM GiaoDich gd
		JOIN TaiKhoan tkFrom ON gd.IDFrom = tkFrom.ID
		JOIN TaiKhoan tkTo ON gd.IDTo = tkTo.ID
    WHERE
       ( CAST(IDGD AS nvarchar(100)) LIKE '%' + @TuKhoa + '%'
        OR CAST(IDFrom AS nvarchar(100)) LIKE '%' + @TuKhoa + '%'
        OR CAST(IDTo AS nvarchar(100)) LIKE '%' + @TuKhoa + '%'
        OR CAST(SoTien AS nvarchar(100)) LIKE '%' + @TuKhoa + '%'
        OR CONVERT(nvarchar(10), DateGD, 103) LIKE '%' + @TuKhoa + '%' 
        OR CONVERT(nvarchar(10), DateGD, 120) LIKE '%' + @TuKhoa + '%' 
        OR CONVERT(nvarchar(10), DateGD, 103) LIKE '%' + CONVERT(nvarchar(10), CONVERT(datetime, @TuKhoa, 103), 103) + '%'
        OR LOWER(Notes) LIKE '%' + LOWER(@TuKhoa) + '%') and (tkFrom.ID=@id or tkTo.ID=@id)
    ORDER BY DateGD;
	END TRY
		BEGIN CATCH
			IF @@TRANCOUNT > 0
			BEGIN
				ROLLBACK TRANSACTION;
			END
		END CATCH
END;

GO
CREATE TRIGGER Cards_Insert
ON dbo.Cards
INSTEAD OF INSERT
AS
BEGIN
    SET NOCOUNT ON;
    IF NOT EXISTS (
        SELECT 1
        FROM dbo.Cards c
        JOIN inserted i ON c.CardNumber = i.CardNumber
    )
    BEGIN
        DECLARE @MaxCardID INT;
        SELECT @MaxCardID = MAX(CardID)
        FROM dbo.Cards
        WHERE ID IN (SELECT ID FROM inserted);
        IF @MaxCardID IS NULL
            SET @MaxCardID = 0;
        IF EXISTS (SELECT 1 FROM inserted i WHERE NOT EXISTS (SELECT 1 FROM dbo.Cards c WHERE c.CardNumber = i.CardNumber))
        BEGIN
            INSERT INTO dbo.Cards (CardID, ID, CardNumber, SoDuCard, IssueDate, ExpirationDate, CVV, IsActive)
            SELECT 
                ROW_NUMBER() OVER (PARTITION BY i.ID ORDER BY i.CardNumber) + @MaxCardID,
                i.ID,
                i.CardNumber,
                i.SoDuCard,
                i.IssueDate,
                i.ExpirationDate,
                CAST((RAND() * (999 - 100 + 1) + 100) AS INT),
                i.IsActive
            FROM inserted i;
        END
    END
END;
 