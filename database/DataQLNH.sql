use master
go
Create database [QLNH]
go
USE [QLNH]
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
CREATE TABLE [dbo].[GiaoDich] (
    [IDGD] [int] NOT NULL,
    [IDFrom] [int] NOT NULL,
    [IDTo] [int] NOT NULL,
    [SoTien] [int] NOT NULL,
    [DateGD] [smalldatetime] NOT NULL,
    [Notes] [nvarchar](200) NULL,
    PRIMARY KEY CLUSTERED 
    (
        [IDGD] ASC
    ) WITH (
        PAD_INDEX = OFF,
        STATISTICS_NORECOMPUTE = OFF,
        IGNORE_DUP_KEY = OFF,
        ALLOW_ROW_LOCKS = ON,
        ALLOW_PAGE_LOCKS = ON
    ) ON [PRIMARY]
) ON [PRIMARY];
GO
--[dbo].[Card]
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cards] (
    CardID INT,
    [ID] INT NOT NULL,
    CardNumber NVARCHAR(19) NOT NULL,
    [SoDuCard] INT NOT NULL,
    IssueDate SMALLDATETIME NOT NULL,
    ExpirationDate SMALLDATETIME NOT NULL,
    CVV NVARCHAR(3) NOT NULL,
    IsActive BIT NOT NULL DEFAULT 1,
    CONSTRAINT UQ_CardID_ID UNIQUE (CardID, ID)
);
GO

go
/****** Object:  Table [dbo].[LaiSuat]    Script Date: Wed, 1 Nov 2023 09:06:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DichVu](
	[IDDichVu] INT IDENTITY(1,1),
	[ID] [int] NOT NULL,
	[MucLS] Float NOT NULL,
	[LoaiDichVu] NVARCHAR(50) NOT NULL, 
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
	[IDBank] [int] Not NUll,
	[Sotk] [int] NOT NULL,
	[NameTK] [nvarchar](50) NOT NULL,
	[SoDuTK] [int] NOT NULL,
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
INSERT [dbo].[Login] ([Username], [Pass], [ID], [loaitk]) VALUES (N'1                                   ', N'1                                            ', 20003, 1)
INSERT [dbo].[Login] ([Username], [Pass], [ID], [loaitk]) VALUES (N'duongkimnguyen                                   ', N'123                                          ', 20006, 1)
INSERT [dbo].[Login] ([Username], [Pass], [ID], [loaitk]) VALUES (N'quang                                             ', N'123                                               ', 10001, 0)
INSERT [dbo].[TaiKhoan] ([ID],[IDBank], [Sotk], [NameTK], [SoDuTK]) VALUES (20001, 1210001, 123453246, N'TRINH DANG QUANG', 5000000)
INSERT [dbo].[TaiKhoan] ([ID],[IDBank], [Sotk], [NameTK], [SoDuTK]) VALUES (20002, 1210001,	7983246	, N'BUI THI PHUONG VY',  1000000000)
INSERT [dbo].[TaiKhoan] ([ID],[IDBank], [Sotk], [NameTK], [SoDuTK]) VALUES (20003, 1210003, 999654111, N'TRINH DANG QUANG', 300000000)
INSERT [dbo].[TaiKhoan] ([ID],[IDBank], [Sotk], [NameTK], [SoDuTK]) VALUES (20004, 1210002, 988888812, N'TRINH DANG QUANG', 40000000)
INSERT [dbo].[TaiKhoan] ([ID],[IDBank], [Sotk], [NameTK], [SoDuTK]) VALUES (20005, 1210004, 988555821, N'BUI DINH NHU', 20000000)
INSERT [dbo].[TaiKhoan] ([ID],[IDBank], [Sotk], [NameTK], [SoDuTK]) VALUES (20006, 1210001, 123453246, N'DUONG KIM NGUYEN', 5000000)
--select * from TaiKhoan
--delete from TaiKhoan	
--delete from Login
--delete from GiaoDich
--select * from GiaoDich
--select * from Login
--select * from DichVu
--delete from DichVu
--select * from login
--delete from ThongTin
delete from cards
select * from ThongTin
select * from Cards where ID = 20001
INSERT [dbo].[ThongTin] ([ID], [IDBank], [Name], [DiaChi], [Phone], [CCCD], [Date]) VALUES (10001, 1210001, N'Trịnh Đăng Quang', NULL, N'0843123654', N'040203013420', CAST(N'2003-12-26 00:00:00' AS SmallDateTime))
INSERT [dbo].[ThongTin] ([ID], [IDBank], [Name], [DiaChi], [Phone], [CCCD], [Date]) VALUES (20001, 1210001, N'Trịnh Đăng Quang', NULL, N'0843345868', N'040203010919', CAST(N'2003-12-26 00:00:00' AS SmallDateTime))
INSERT [dbo].[ThongTin] ([ID], [IDBank], [Name], [DiaChi], [Phone], [CCCD], [Date]) VALUES (20003, 1210003, N'Trịnh Đăng Quang', NULL, N'0843345869', N'040203010916', CAST(N'2003-12-26 00:00:00' AS SmallDateTime))
INSERT [dbo].[ThongTin] ([ID], [IDBank], [Name], [DiaChi], [Phone], [CCCD], [Date]) VALUES (20004, 1210002, N'Trịnh Đăng Quang', NULL, N'0843341869', N'040444410916', CAST(N'2003-12-26 00:00:00' AS SmallDateTime))
INSERT [dbo].[ThongTin] ([ID], [IDBank], [Name], [DiaChi], [Phone], [CCCD], [Date]) VALUES (20002, 1210001, N'Bùi Thị Phương Vy', N'Dĩ An, Bình Dương', N'0986318750', N'030101562343', CAST(N'2002-11-18 00:00:00' AS SmallDateTime))
INSERT [dbo].[ThongTin] ([ID], [IDBank], [Name], [DiaChi], [Phone], [CCCD], [Date]) VALUES (20005, 1210004, N'Bùi Đình Nhu', NULL, N'0982762877', N'040203567843', CAST(N'2003-2-6 00:00:00' AS SmallDateTime))
INSERT [dbo].[ThongTin] ([ID], [IDBank], [Name], [DiaChi], [Phone], [CCCD], [Date]) VALUES (20006, 1210001, N'Dương Kim Nguyên', NULL, N'0943543651', N'040203343321', CAST(N'2003-11-8 00:00:00' AS SmallDateTime))
INSERT INTO Cards (ID,CardNumber, SoDuCard, IssueDate, ExpirationDate) VALUES (20001, '1234 5678 9012 3456', 1000, '2023-01-01', '2025-12-31');
INSERT INTO Cards (ID,CardNumber, SoDuCard, IssueDate, ExpirationDate) VALUES (20001, '9876 5432 1098 7654', 1500, '2023-02-01', '2026-01-31');
INSERT INTO Cards (ID,CardNumber, SoDuCard, IssueDate, ExpirationDate) VALUES (20002, '1111 2222 3333 4444', 800, '2023-03-01', '2026-02-28');
INSERT INTO Cards (ID,CardNumber, SoDuCard, IssueDate, ExpirationDate) VALUES (20002, '5555 6666 7777 8888', 1200, '2023-04-01', '2026-03-31');
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
go
ALTER TABLE Cards  WITH CHECK ADD FOREIGN KEY([ID])
REFERENCES [dbo].[ThongTin] ([ID])
GO
go
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
--GO
--SELECT * FROM ThongTin INNER JOIN Login ON ThongTin.ID = Login.ID
go
--//CheckPass
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
Go

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
go
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
go
create proc [dbo].[add_account]
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
			insert into TaiKhoan(ID,IDBank,Sotk,SoDuTK,NameTK)values(@id,@bank,@stk,@sodutk,@name)
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

go
--//Show GD
create PROCEDURE [dbo].[SelectAllGiaoDich]
    @TuKhoa nvarchar(100),
	@id int
AS
BEGIN
    SET DATEFORMAT DMY;
	begin try
	
	if @id=(select IDFrom from GiaoDich where IDFrom=@id) or @id=(select IDTo from GiaoDich where IDTo=@id)
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
        CAST(IDGD AS nvarchar(100)) LIKE '%' + @TuKhoa + '%'
        OR CAST(IDFrom AS nvarchar(100)) LIKE '%' + @TuKhoa + '%'
        OR CAST(IDTo AS nvarchar(100)) LIKE '%' + @TuKhoa + '%'
        OR CAST(SoTien AS nvarchar(100)) LIKE '%' + @TuKhoa + '%'
        OR CONVERT(nvarchar(10), DateGD, 103) LIKE '%' + @TuKhoa + '%'  -- Tìm kiếm theo ngày (DD/MM/YYYY)
        OR CONVERT(nvarchar(10), DateGD, 120) LIKE '%' + @TuKhoa + '%'  -- Tìm kiếm theo ngày (ISO 8601)
        OR CONVERT(nvarchar(10), DateGD, 103) LIKE '%' + CONVERT(nvarchar(10), CONVERT(datetime, @TuKhoa, 103), 103) + '%' -- Tìm kiếm theo ngày với định dạng DMY
        OR LOWER(Notes) LIKE '%' + LOWER(@TuKhoa) + '%'
    ORDER BY DateGD;
	END TRY
		BEGIN CATCH
			IF @@TRANCOUNT > 0
			BEGIN
				ROLLBACK TRANSACTION;
			END
		END CATCH
END;
	--exec dbo.SelectAllGiaoDich @TuKhoa='',@id=2005
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
go

Go 
CREATE TRIGGER Cards_Insert
ON dbo.Cards
INSTEAD OF INSERT
AS
BEGIN
    SET NOCOUNT ON;

    -- Kiểm tra xem có sự trùng lặp trong CardNumber không
    IF NOT EXISTS (
        SELECT 1
        FROM dbo.Cards c
        JOIN inserted i ON c.CardNumber = i.CardNumber
    )
    BEGIN
        DECLARE @MaxCardID INT;

        -- Tìm giá trị lớn nhất của CardID cho ID được chèn
        SELECT @MaxCardID = MAX(CardID)
        FROM dbo.Cards
        WHERE ID IN (SELECT ID FROM inserted);

        -- Nếu không có bản ghi nào cho ID được chèn, set @MaxCardID = 0
        IF @MaxCardID IS NULL
            SET @MaxCardID = 0;

        -- Chèn dữ liệu mới với CardID tăng dần bắt đầu từ @MaxCardID + 1
        INSERT INTO dbo.Cards (CardID, ID, CardNumber, SoDuCard, IssueDate, ExpirationDate, CVV, IsActive)
        SELECT 
            ROW_NUMBER() OVER (PARTITION BY i.ID ORDER BY i.CardNumber) + @MaxCardID,
            i.ID,
            i.CardNumber,
            i.SoDuCard,
            i.IssueDate,
            i.ExpirationDate,
            CAST((RAND() * (999 - 100 + 1) + 100) AS INT), -- Tạo giá trị ngẫu nhiên cho CVV
            i.IsActive
        FROM inserted i;
    END
END;
--DROP TRIGGER Cards_Insert

Go 
--SELECT 
--    name AS TriggerName,
--    OBJECT_NAME(parent_id) AS TableName,
--    create_date AS CreationDate
--FROM sys.triggers;
