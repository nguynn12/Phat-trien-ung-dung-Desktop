USE [Restaurant Management]
GO
/****** Object:  UserDefinedFunction [dbo].[fn_TongMonAnTheoNgay]    Script Date: 10/27/2025 11:41:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[fn_TongMonAnTheoNgay](@ngay date) returns int
as
	begin
		declare @tong int

		select	@tong = ISNULL(SUM(Quantity), 0)
		from	BillDetails
				join Bills on BillDetails.InvoiceID = Bills.ID
		where	CAST(CheckoutDate as date) = @ngay and
				Status = 1

		return @tong
	end
GO
/****** Object:  UserDefinedFunction [dbo].[fn_TongTienTheoNgay]    Script Date: 10/27/2025 11:41:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[fn_TongTienTheoNgay](@ngay date) returns int
as
	begin
		declare @tong int
		-- Tiền gốc - Tiền giảm giá + Thuế
		select	@tong = ISNULL(SUM(
			Amount - Amount * ISNULL(Discount, 0)
			+ Amount * ISNULL(Tax, 0)), 0)
		from	Bills
		where	CAST(CheckoutDate as date) = @ngay and
				Status = 1
		
		return @tong
	end
GO
/****** Object:  Table [dbo].[Account]    Script Date: 10/27/2025 11:41:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[AccountName] [nvarchar](100) NOT NULL,
	[Password] [nvarchar](200) NOT NULL,
	[FullName] [nvarchar](1000) NOT NULL,
	[Email] [nvarchar](1000) NULL,
	[Tell] [nvarchar](200) NULL,
	[DateCreated] [smalldatetime] NULL,
 CONSTRAINT [PK_Account] PRIMARY KEY CLUSTERED 
(
	[AccountName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BillDetails]    Script Date: 10/27/2025 11:41:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BillDetails](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[InvoiceID] [int] NOT NULL,
	[FoodID] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
 CONSTRAINT [PK_BillDetails] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bills]    Script Date: 10/27/2025 11:41:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bills](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](1000) NOT NULL,
	[TableID] [int] NOT NULL,
	[Amount] [int] NOT NULL,
	[Discount] [float] NULL,
	[Tax] [float] NULL,
	[Status] [bit] NOT NULL,
	[CheckoutDate] [smalldatetime] NULL,
	[Account] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Bills] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 10/27/2025 11:41:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](1000) NOT NULL,
	[Type] [int] NOT NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Food]    Script Date: 10/27/2025 11:41:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Food](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FoodName] [nvarchar](1000) NOT NULL,
	[Unit] [nvarchar](100) NOT NULL,
	[FoodCategoryID] [int] NOT NULL,
	[Price] [int] NOT NULL,
	[Notes] [nvarchar](3000) NULL,
 CONSTRAINT [PK_Food] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 10/27/2025 11:41:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[RoleName] [nvarchar](1000) NOT NULL,
	[Path] [nvarchar](3000) NULL,
	[Notes] [nvarchar](3000) NULL,
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RoleAccount]    Script Date: 10/27/2025 11:41:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RoleAccount](
	[RoleID] [int] NOT NULL,
	[AccountName] [nvarchar](100) NOT NULL,
	[Actived] [bit] NOT NULL,
	[Notes] [nvarchar](3000) NULL,
 CONSTRAINT [PK_RoleAccount] PRIMARY KEY CLUSTERED 
(
	[RoleID] ASC,
	[AccountName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Table]    Script Date: 10/27/2025 11:41:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Table](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](1000) NULL,
	[Status] [int] NOT NULL,
	[Capacity] [int] NULL,
 CONSTRAINT [PK_Table] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Account] ([AccountName], [Password], [FullName], [Email], [Tell], [DateCreated]) VALUES (N'david_clark', N'david2024', N'David Clark', N'daveclark@gmail.com', N'0905678901', CAST(N'2024-05-09T00:00:00' AS SmallDateTime))
GO
INSERT [dbo].[Account] ([AccountName], [Password], [FullName], [Email], [Tell], [DateCreated]) VALUES (N'jane_smith', N'pass456', N'Jane Smith', N'jane.smith@gmail.com', N'0902345678', CAST(N'2024-09-24T00:00:00' AS SmallDateTime))
GO
INSERT [dbo].[Account] ([AccountName], [Password], [FullName], [Email], [Tell], [DateCreated]) VALUES (N'john_doe', N'password123', N'John Doe', N'john.doe@gmail.com', N'0901234567', CAST(N'2025-08-07T00:00:00' AS SmallDateTime))
GO
INSERT [dbo].[Account] ([AccountName], [Password], [FullName], [Email], [Tell], [DateCreated]) VALUES (N'mike_brown', N'MBrwn123', N'Mike Brown', N'browniemikie@gmail.com', N'090345678', CAST(N'2025-01-05T00:00:00' AS SmallDateTime))
GO
INSERT [dbo].[Account] ([AccountName], [Password], [FullName], [Email], [Tell], [DateCreated]) VALUES (N'sarah_wilson', N'mypassword', N'Sarah Wilson', N'srh_wil@gmail.com', N'0904567890', CAST(N'2023-10-28T00:00:00' AS SmallDateTime))
GO
SET IDENTITY_INSERT [dbo].[BillDetails] ON 
GO
INSERT [dbo].[BillDetails] ([ID], [InvoiceID], [FoodID], [Quantity]) VALUES (1, 1, 1, 2)
GO
INSERT [dbo].[BillDetails] ([ID], [InvoiceID], [FoodID], [Quantity]) VALUES (2, 1, 3, 1)
GO
INSERT [dbo].[BillDetails] ([ID], [InvoiceID], [FoodID], [Quantity]) VALUES (3, 1, 8, 2)
GO
INSERT [dbo].[BillDetails] ([ID], [InvoiceID], [FoodID], [Quantity]) VALUES (4, 2, 2, 1)
GO
INSERT [dbo].[BillDetails] ([ID], [InvoiceID], [FoodID], [Quantity]) VALUES (5, 2, 5, 1)
GO
INSERT [dbo].[BillDetails] ([ID], [InvoiceID], [FoodID], [Quantity]) VALUES (6, 2, 9, 2)
GO
INSERT [dbo].[BillDetails] ([ID], [InvoiceID], [FoodID], [Quantity]) VALUES (7, 3, 4, 1)
GO
INSERT [dbo].[BillDetails] ([ID], [InvoiceID], [FoodID], [Quantity]) VALUES (8, 3, 6, 2)
GO
INSERT [dbo].[BillDetails] ([ID], [InvoiceID], [FoodID], [Quantity]) VALUES (9, 3, 10, 1)
GO
INSERT [dbo].[BillDetails] ([ID], [InvoiceID], [FoodID], [Quantity]) VALUES (10, 4, 1, 1)
GO
INSERT [dbo].[BillDetails] ([ID], [InvoiceID], [FoodID], [Quantity]) VALUES (11, 4, 5, 1)
GO
INSERT [dbo].[BillDetails] ([ID], [InvoiceID], [FoodID], [Quantity]) VALUES (12, 4, 8, 2)
GO
INSERT [dbo].[BillDetails] ([ID], [InvoiceID], [FoodID], [Quantity]) VALUES (13, 5, 3, 1)
GO
INSERT [dbo].[BillDetails] ([ID], [InvoiceID], [FoodID], [Quantity]) VALUES (14, 5, 7, 1)
GO
INSERT [dbo].[BillDetails] ([ID], [InvoiceID], [FoodID], [Quantity]) VALUES (15, 5, 10, 2)
GO
SET IDENTITY_INSERT [dbo].[BillDetails] OFF
GO
SET IDENTITY_INSERT [dbo].[Bills] ON 
GO
INSERT [dbo].[Bills] ([ID], [Name], [TableID], [Amount], [Discount], [Tax], [Status], [CheckoutDate], [Account]) VALUES (1, N'Bill 001', 1, 510000, 0.1, 0.1, 1, CAST(N'2025-08-07T12:30:00' AS SmallDateTime), N'john_doe')
GO
INSERT [dbo].[Bills] ([ID], [Name], [TableID], [Amount], [Discount], [Tax], [Status], [CheckoutDate], [Account]) VALUES (2, N'Bill 002', 2, 360000, 0, 0.1, 1, CAST(N'2025-08-07T13:00:00' AS SmallDateTime), N'jane_smith')
GO
INSERT [dbo].[Bills] ([ID], [Name], [TableID], [Amount], [Discount], [Tax], [Status], [CheckoutDate], [Account]) VALUES (3, N'Bill 003', 3, 650000, 0.05, 0.1, 1, CAST(N'2025-08-07T14:15:00' AS SmallDateTime), N'mike_brown')
GO
INSERT [dbo].[Bills] ([ID], [Name], [TableID], [Amount], [Discount], [Tax], [Status], [CheckoutDate], [Account]) VALUES (4, N'Bill 004', 4, 280000, 0, 0.1, 1, CAST(N'2025-08-07T15:00:00' AS SmallDateTime), N'sarah_wilson')
GO
INSERT [dbo].[Bills] ([ID], [Name], [TableID], [Amount], [Discount], [Tax], [Status], [CheckoutDate], [Account]) VALUES (5, N'Bill 005', 5, 450000, 0.1, 0.1, 1, CAST(N'2025-08-07T16:30:00' AS SmallDateTime), N'david_clark')
GO
SET IDENTITY_INSERT [dbo].[Bills] OFF
GO
SET IDENTITY_INSERT [dbo].[Category] ON 
GO
INSERT [dbo].[Category] ([ID], [Name], [Type]) VALUES (1, N'Món khai vị', 1)
GO
INSERT [dbo].[Category] ([ID], [Name], [Type]) VALUES (2, N'Món chính', 1)
GO
INSERT [dbo].[Category] ([ID], [Name], [Type]) VALUES (3, N'Món tráng miệng', 1)
GO
INSERT [dbo].[Category] ([ID], [Name], [Type]) VALUES (4, N'Đồ uống', 0)
GO
SET IDENTITY_INSERT [dbo].[Category] OFF
GO
SET IDENTITY_INSERT [dbo].[Food] ON 
GO
INSERT [dbo].[Food] ([ID], [FoodName], [Unit], [FoodCategoryID], [Price], [Notes]) VALUES (1, N'Salad Caesar', N'Dĩa', 1, 80000, N'Xà lách romaine tươi, bánh mỳ croutons, phô mai parmesan.')
GO
INSERT [dbo].[Food] ([ID], [FoodName], [Unit], [FoodCategoryID], [Price], [Notes]) VALUES (2, N'Bánh mỳ Bruschetta', N'Dĩa', 1, 60000, N'Bánh mỳ nướng với cà chua.')
GO
INSERT [dbo].[Food] ([ID], [FoodName], [Unit], [FoodCategoryID], [Price], [Notes]) VALUES (3, N'Cá hồi nướng', N'Dĩa', 2, 250000, N'Ăn kèm sốt chanh thảo mộc.')
GO
INSERT [dbo].[Food] ([ID], [FoodName], [Unit], [FoodCategoryID], [Price], [Notes]) VALUES (4, N'Bít tết bò', N'Dĩa', 2, 300000, N'Tái vừa, ăn kèm khoai tây nghiền.')
GO
INSERT [dbo].[Food] ([ID], [FoodName], [Unit], [FoodCategoryID], [Price], [Notes]) VALUES (5, N'Mỳ Ý Carbonara', N'Dĩa', 2, 150000, N'Ăn kèm sốt kem với thịt xông khói.')
GO
INSERT [dbo].[Food] ([ID], [FoodName], [Unit], [FoodCategoryID], [Price], [Notes]) VALUES (6, N'Bánh phô mai', N'Miếng', 3, 90000, N'Kiểu New York, ăn kèm sốt trái cây mọng.')
GO
INSERT [dbo].[Food] ([ID], [FoodName], [Unit], [FoodCategoryID], [Price], [Notes]) VALUES (7, N'Bánh Tiramisu', N'Miếng', 3, 95000, N'Món tráng miệng Ý cổ điển.')
GO
INSERT [dbo].[Food] ([ID], [FoodName], [Unit], [FoodCategoryID], [Price], [Notes]) VALUES (8, N'Coca Cola', N'Ly', 4, 30000, NULL)
GO
INSERT [dbo].[Food] ([ID], [FoodName], [Unit], [FoodCategoryID], [Price], [Notes]) VALUES (9, N'Rượu vang đỏ', N'Ly', 4, 120000, N'Merlot, 750ml.')
GO
INSERT [dbo].[Food] ([ID], [FoodName], [Unit], [FoodCategoryID], [Price], [Notes]) VALUES (10, N'Nước cam', N'Ly', 4, 50000, N'Ép tươi.')
GO
INSERT [dbo].[Food] ([ID], [FoodName], [Unit], [FoodCategoryID], [Price], [Notes]) VALUES (11, N'Cocktail', N'Ly', 4, 50, N'Acolhol cocktail')
GO
SET IDENTITY_INSERT [dbo].[Food] OFF
GO
SET IDENTITY_INSERT [dbo].[Role] ON 
GO
INSERT [dbo].[Role] ([ID], [RoleName], [Path], [Notes]) VALUES (1, N'Quản trị viên', N'/admin', N'Quyền truy cập đầy đủ vào hệ thống')
GO
INSERT [dbo].[Role] ([ID], [RoleName], [Path], [Notes]) VALUES (2, N'Nhân viên', N'/staff', N'Quyền truy cập giới hạn cho nhân viên nhà hàng')
GO
SET IDENTITY_INSERT [dbo].[Role] OFF
GO
INSERT [dbo].[RoleAccount] ([RoleID], [AccountName], [Actived], [Notes]) VALUES (1, N'john_doe', 1, N'Admin account')
GO
INSERT [dbo].[RoleAccount] ([RoleID], [AccountName], [Actived], [Notes]) VALUES (2, N'david_clark', 1, N'Staff account')
GO
INSERT [dbo].[RoleAccount] ([RoleID], [AccountName], [Actived], [Notes]) VALUES (2, N'jane_smith', 1, N'Staff account')
GO
INSERT [dbo].[RoleAccount] ([RoleID], [AccountName], [Actived], [Notes]) VALUES (2, N'mike_brown', 1, N'Staff account')
GO
INSERT [dbo].[RoleAccount] ([RoleID], [AccountName], [Actived], [Notes]) VALUES (2, N'sarah_wilson', 1, N'Staff account')
GO
SET IDENTITY_INSERT [dbo].[Table] ON 
GO
INSERT [dbo].[Table] ([ID], [Name], [Status], [Capacity]) VALUES (1, N'Bàn 1', 0, 4)
GO
INSERT [dbo].[Table] ([ID], [Name], [Status], [Capacity]) VALUES (2, N'Bàn 2', 0, 4)
GO
INSERT [dbo].[Table] ([ID], [Name], [Status], [Capacity]) VALUES (3, N'Bàn 3', 0, 6)
GO
INSERT [dbo].[Table] ([ID], [Name], [Status], [Capacity]) VALUES (4, N'Bàn 4', 0, 6)
GO
INSERT [dbo].[Table] ([ID], [Name], [Status], [Capacity]) VALUES (5, N'Bàn 5', 0, 2)
GO
INSERT [dbo].[Table] ([ID], [Name], [Status], [Capacity]) VALUES (6, N'Bàn 6', 0, 2)
GO
INSERT [dbo].[Table] ([ID], [Name], [Status], [Capacity]) VALUES (7, N'Bàn 7', 0, 8)
GO
INSERT [dbo].[Table] ([ID], [Name], [Status], [Capacity]) VALUES (8, N'Bàn 8', 0, 8)
GO
INSERT [dbo].[Table] ([ID], [Name], [Status], [Capacity]) VALUES (9, N'Bàn 9', 0, 4)
GO
INSERT [dbo].[Table] ([ID], [Name], [Status], [Capacity]) VALUES (10, N'Bàn 10', 0, 4)
GO
SET IDENTITY_INSERT [dbo].[Table] OFF
GO
ALTER TABLE [dbo].[BillDetails]  WITH CHECK ADD  CONSTRAINT [FK_BillDetails_Bills] FOREIGN KEY([InvoiceID])
REFERENCES [dbo].[Bills] ([ID])
GO
ALTER TABLE [dbo].[BillDetails] CHECK CONSTRAINT [FK_BillDetails_Bills]
GO
ALTER TABLE [dbo].[BillDetails]  WITH CHECK ADD  CONSTRAINT [FK_BillDetails_Food] FOREIGN KEY([FoodID])
REFERENCES [dbo].[Food] ([ID])
GO
ALTER TABLE [dbo].[BillDetails] CHECK CONSTRAINT [FK_BillDetails_Food]
GO
ALTER TABLE [dbo].[Bills]  WITH CHECK ADD  CONSTRAINT [FK_Bills_Table] FOREIGN KEY([TableID])
REFERENCES [dbo].[Table] ([ID])
GO
ALTER TABLE [dbo].[Bills] CHECK CONSTRAINT [FK_Bills_Table]
GO
ALTER TABLE [dbo].[Food]  WITH CHECK ADD  CONSTRAINT [FK_Food_Category] FOREIGN KEY([FoodCategoryID])
REFERENCES [dbo].[Category] ([ID])
GO
ALTER TABLE [dbo].[Food] CHECK CONSTRAINT [FK_Food_Category]
GO
/****** Object:  StoredProcedure [dbo].[_Delete]    Script Date: 10/27/2025 11:41:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[_Delete]
	@tenbang nvarchar(100),
	@id int
as
	begin
		declare @chuoi nvarchar(MAX)
		set @chuoi = 'delete from ' +
		QUOTENAME(@tenbang) + ' where ID = @id'
		exec sp_executesql @chuoi, '@id INT', @id = @id
	end
GO
/****** Object:  StoredProcedure [dbo].[_GetAll]    Script Date: 10/27/2025 11:41:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[_GetAll]
	@tenbang nvarchar(100)
as
	begin
		declare @chuoi nvarchar(MAX)
		set @chuoi = 'select * from ' + 
		QUOTENAME(@tenbang)
		exec sp_executesql @chuoi
	end
GO
/****** Object:  StoredProcedure [dbo].[_GetByID]    Script Date: 10/27/2025 11:41:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[_GetByID]
	@tenbang nvarchar(100),
	@id int
as
	begin
		declare @chuoi nvarchar(MAX)
		set @chuoi = 'select * from ' +
		QUOTENAME(@tenbang) + ' where ID = @id'
		exec sp_executesql @chuoi, '@id INT', @id = @id
	end
GO
/****** Object:  StoredProcedure [dbo].[Account_Delete]    Script Date: 10/27/2025 11:41:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[Account_Delete]
	@accname nvarchar(100)
as
	begin
		delete from Account
		where AccountName = @accname
	end
GO
/****** Object:  StoredProcedure [dbo].[Account_Insert]    Script Date: 10/27/2025 11:41:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Account_Insert]
	@accname nvarchar(100),
	@password nvarchar(200),
	@fullname nvarchar(1000),
	@email nvarchar(1000),
	@tell nvarchar(200),
	@datecreated smalldatetime
as
	begin
		if not exists(select AccountName from Account where AccountName = @accname)
			insert into Account values(@accname, @password, @fullname,
				@email, @tell, @datecreated)
	end
GO
/****** Object:  StoredProcedure [dbo].[Account_Update]    Script Date: 10/27/2025 11:41:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[Account_Update]
	@accname nvarchar(100),
	@password nvarchar(200),
	@fullname nvarchar(1000),
	@email nvarchar(1000),
	@tell nvarchar(200),
	@datecreated smalldatetime
as
	begin
		update	Account
		set		Password = @password,
				FullName = @fullname,
				Email = @email,
				Tell = @tell,
				DateCreated = @datecreated
		where	AccountName = @accname
	end
GO
/****** Object:  StoredProcedure [dbo].[AddAccount]    Script Date: 10/27/2025 11:41:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddAccount]
    @AccountName NVARCHAR(100),
    @Password NVARCHAR(200),
    @FullName NVARCHAR(1000),
    @Email NVARCHAR(1000),
    @Tell NVARCHAR(200),
    @RoleID INT
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO Account (AccountName, [Password], FullName, Email, Tell, DateCreated)
    VALUES (@AccountName, @Password, @FullName, @Email, @Tell, GETDATE());

    INSERT INTO RoleAccount (RoleID, AccountName, Actived, Notes)
    VALUES (@RoleID, @AccountName, 1, NULL);
END
GO
/****** Object:  StoredProcedure [dbo].[AddRole]    Script Date: 10/27/2025 11:41:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddRole]
    @RoleName NVARCHAR(1000),
    @Path NVARCHAR(3000),
    @Notes NVARCHAR(3000)
AS
BEGIN
    INSERT INTO Role (RoleName, Path, Notes)
    VALUES (@RoleName, @Path, @Notes);
END
GO
/****** Object:  StoredProcedure [dbo].[AddRoleToAccount]    Script Date: 10/27/2025 11:41:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[AddRoleToAccount]
    @AccountName NVARCHAR(100),
    @RoleID INT
AS
BEGIN
    IF NOT EXISTS (SELECT * FROM RoleAccount WHERE AccountName=@AccountName AND RoleID=@RoleID)
        INSERT INTO RoleAccount(RoleID, AccountName, Actived) VALUES (@RoleID, @AccountName, 1)
END
GO
/****** Object:  StoredProcedure [dbo].[BillDetails_Delete]    Script Date: 10/27/2025 11:41:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[BillDetails_Delete]
	@id int
as
	begin
		delete from BillDetails
		where ID = @id
	end
GO
/****** Object:  StoredProcedure [dbo].[BillDetails_Insert]    Script Date: 10/27/2025 11:41:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[BillDetails_Insert]
	@invoiceid int,
	@foodid int,
	@quantity int
as
	begin
		if exists (select ID from Food where ID = @foodid) and
			exists (select ID from Bills where ID = @invoiceid)

			insert into BillDetails values(@invoiceid, @foodid, @quantity)
	end
GO
/****** Object:  StoredProcedure [dbo].[BillDetails_Update]    Script Date: 10/27/2025 11:41:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[BillDetails_Update]
	@id int,
	@invoiceid int,
	@foodid int,
	@quantity int
as
	begin
		update	BillDetails
		set		FoodID = @foodid,
				Quantity = @quantity
		where	ID = @id and 
				InvoiceID = @invoiceid
	end
GO
/****** Object:  StoredProcedure [dbo].[Bills_Delete]    Script Date: 10/27/2025 11:41:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[Bills_Delete]
	@id int
as
	begin
		delete from Bills
		where ID = @id
	end
GO
/****** Object:  StoredProcedure [dbo].[Bills_Insert]    Script Date: 10/27/2025 11:41:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Bills_Insert]
	@name nvarchar(1000),
	@tableid int,
	@amount int,
	@discount float,
	@tax float,
	@status bit,
	@chkdate smalldatetime,
	@account nvarchar(100)
as
	if exists (select ID from [Table] where ID = @tableid)
	
		begin
			if not exists (select Name from Bills where Name = @name)
				insert into Bills values(@name, @tableid, @amount, @discount, 
						@tax, @status, @chkdate, @account)
		end
GO
/****** Object:  StoredProcedure [dbo].[Bills_Update]    Script Date: 10/27/2025 11:41:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Bills_Update]
	@id int,
	@name nvarchar(1000),
	@tableid int,
	@amount int,
	@discount float,
	@tax float,
	@status bit,
	@chkdate smalldatetime,
	@account nvarchar(100)
as
	begin
		update	Bills
		set		Name = @name,
				TableID = @tableid,
				Amount = @amount,
				Discount = @discount,
				Tax = @tax,
				Status = @status,
				CheckoutDate = @chkdate,
				Account = @account
		where	ID = @id
	end
GO
/****** Object:  StoredProcedure [dbo].[Category_Delete]    Script Date: 10/27/2025 11:41:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[Category_Delete]
	@id int
as
	begin
		delete from Category
		where id = @id
	end
GO
/****** Object:  StoredProcedure [dbo].[Category_GetAll]    Script Date: 10/27/2025 11:41:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
------- CATEGORY -------

create proc [dbo].[Category_GetAll]
as
	begin
		select * from dbo.Category
	end
GO
/****** Object:  StoredProcedure [dbo].[Category_GetByID]    Script Date: 10/27/2025 11:41:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[Category_GetByID]
	@id int
as
	begin
		select * from dbo.Category where ID = @id
	end
GO
/****** Object:  StoredProcedure [dbo].[Category_Insert]    Script Date: 10/27/2025 11:41:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[Category_Insert]
	@name nvarchar(1000),
	@type int
as
	begin
		if not exists(select name from dbo.Category where name = @name)
			insert into dbo.Category values(@name, @type)
	end
GO
/****** Object:  StoredProcedure [dbo].[Category_Update]    Script Date: 10/27/2025 11:41:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[Category_Update]
	@id int,
	@name nvarchar(1000),
	@type int
as
	begin
		update Category
		set Name = @name, Type = @type
		where ID = @id
	end
GO
/****** Object:  StoredProcedure [dbo].[Food_Delete]    Script Date: 10/27/2025 11:41:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[Food_Delete]
	@id int
as
	begin
		delete from Food	
		where ID = @id
	end
GO
/****** Object:  StoredProcedure [dbo].[Food_Insert]    Script Date: 10/27/2025 11:41:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Food_Insert]
	@name nvarchar(1000),
	@unit nvarchar(1000),
	@fcid int,
	@price int,
	@notes nvarchar(3000)
as
		if exists (select ID from Category where ID = @fcid)
			
			begin
				if not exists (select FoodName from Food where FoodName = @name)
					insert into Food values(@name, @unit, @fcid, @price, @notes)
			end
GO
/****** Object:  StoredProcedure [dbo].[GetAllAccounts]    Script Date: 10/27/2025 11:41:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetAllAccounts]
AS
BEGIN
	SELECT	r.RoleName,
			a.* 
    FROM	Account a
    JOIN	RoleAccount ra ON a.AccountName = ra.AccountName
	JOIn	Role r ON ra.RoleID = r.ID
END
GO
/****** Object:  StoredProcedure [dbo].[GetAllRoles]    Script Date: 10/27/2025 11:41:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetAllRoles]
AS
	BEGIN
		SELECT ID, RoleName, Notes FROM Role
	END
GO

/****** Object:  StoredProcedure [dbo].[GetOrderDates]    Script Date: 10/27/2025 11:41:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetOrderDates]
AS
BEGIN
    SELECT DISTINCT CAST(CheckoutDate AS DATE) AS NgayLap
    FROM Bills
    WHERE CheckoutDate IS NOT NULL
    ORDER BY NgayLap DESC;
END
GO
/****** Object:  StoredProcedure [dbo].[GetOrderDetails]    Script Date: 10/27/2025 11:41:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetOrderDetails]
	@billID INT
AS
	BEGIN
		SELECT	f.FoodName,
				f.Unit,
				f.Price,
				bd.Quantity,
				(f.Price * bd.Quantity) AS Amount
		FROM	BillDetails bd
		JOIN	Food f ON bd.FoodID = f.ID
		WHERE	bd.InvoiceID = @billID
	END
GO
/****** Object:  StoredProcedure [dbo].[GetOrdersByDate]    Script Date: 10/27/2025 11:41:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetOrdersByDate]
    @Ngay DATE
AS
BEGIN
    SELECT f.FoodName AS TenMon,
           f.Unit AS DonVi,
           f.Price AS DonGia,
           bd.Quantity AS SoLuong,
           (f.Price * bd.Quantity) AS ThanhTien,
           b.ID AS MaHoaDon,
           b.Account AS NguoiLap
    FROM Bills b
        INNER JOIN BillDetails bd ON b.ID = bd.InvoiceID
        INNER JOIN Food f ON bd.FoodID = f.ID
    WHERE CAST(b.CheckoutDate AS DATE) = @Ngay;
END
GO
/****** Object:  StoredProcedure [dbo].[GetOrdersByDateRange]    Script Date: 10/27/2025 11:41:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetOrdersByDateRange]
	@fromDate DATE,
	@toDate DATE
AS
	BEGIN
		SELECT	b.ID AS BillID,
				b.[Name] AS BillName,
				t.[Name] TableName,
				b.Amount AS TotalAmount,
				b.Discount,
				b.Tax,
				b.[Status],
				b.CheckoutDate,
				b.Account
		FROM	Bills b
		JOIN	[Table] t ON b.TableID = t.ID
		WHERE	CheckoutDate BETWEEN @fromDate AND @toDate
	END
GO
/****** Object:  StoredProcedure [dbo].[GetOrderSummary]    Script Date: 10/27/2025 11:41:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetOrderSummary]
	@fromDate DATE,
	@toDate DATE
AS
	BEGIN
		SELECT	SUM(b.Amount) AS TotalAmount,
				SUM(b.Amount * ISNULL(b.Discount, 0)) AS DiscountAmount,
				SUM(b.Amount - (b.Amount * ISNULL(b.Discount, 0))) AS Revenue
		FROM	Bills b
		WHERE	b.CheckoutDate BETWEEN @fromDate AND @toDate
	END
GO
/****** Object:  StoredProcedure [dbo].[GetRolesByAccountName]    Script Date: 10/27/2025 11:41:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetRolesByAccountName]
    @accountName NVARCHAR(100)
AS
BEGIN
    SELECT R.ID
    FROM RoleAccount RA
    JOIN Role R ON RA.RoleID = R.ID
    JOIN Account A ON RA.AccountName = A.AccountName
    WHERE A.AccountName = @accountName
END
GO
/****** Object:  StoredProcedure [dbo].[GetRolesForAccount]    Script Date: 10/27/2025 11:41:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetRolesForAccount]
    @AccountName NVARCHAR(100)
AS
BEGIN
    SELECT 
        r.ID,
        r.RoleName,
        r.Notes,
        CASE WHEN ra.AccountName IS NULL THEN 0 ELSE 1 END AS IsAssigned
    FROM Role r
    LEFT JOIN RoleAccount ra 
        ON r.ID = ra.RoleID AND ra.AccountName = @AccountName
END
GO
/****** Object:  StoredProcedure [dbo].[GetSummaryByDate]    Script Date: 10/27/2025 11:41:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetSummaryByDate]
    @Ngay DATE
AS
BEGIN
    SELECT 
        COUNT(DISTINCT b.ID) AS SoHoaDon,
        SUM(f.Price * bd.Quantity) AS TongTien
    FROM Bills b
        INNER JOIN BillDetails bd ON b.ID = bd.InvoiceID
        INNER JOIN Food f ON bd.FoodID = f.ID
    WHERE CAST(b.CheckoutDate AS DATE) = @Ngay;
END
GO
/****** Object:  StoredProcedure [dbo].[InsertCategory]    Script Date: 10/27/2025 11:41:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertCategory]
	@id INT OUTPUT,
	@name NVARCHAR(100),
	@type INT
AS
	BEGIN
		INSERT INTO Category ([Name], [Type])
		VALUES (@name, @type)
		SET @id = SCOPE_IDENTITY()
	END
GO
/****** Object:  StoredProcedure [dbo].[InsertFood]    Script Date: 10/27/2025 11:41:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[InsertFood]
	@ID int output,
	@Name nvarchar(1000),
	@Unit nvarchar(100),
	@FoodCategoryID int,
	@Price int,
	@Notes nvarchar(3000)
AS
	INSERT INTO [Food]([FoodName], [Unit], [FoodCategoryID], [Price], [Notes])
	VALUES (@Name, @Unit, @FoodCategoryID, @Price, @Notes)

	SELECT @ID = SCOPE_IDENTITY();
GO
/****** Object:  StoredProcedure [dbo].[NhapBan]    Script Date: 10/27/2025 11:41:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[NhapBan]
	@ban1 nvarchar(100),
	@ban2 nvarchar(100),
	@nhapban nvarchar(100)
as
	begin
		declare @chuoi nvarchar(MAX)
		set @chuoi = 'insert into ' + QUOTENAME(@nhapban) +
					' select * from ' + QUOTENAME(@ban1) +
					' union all select * from ' + QUOTENAME(@ban2)
		exec sp_executesql @chuoi
	end
GO
/****** Object:  StoredProcedure [dbo].[RemoveRoleFromAccount]    Script Date: 10/27/2025 11:41:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[RemoveRoleFromAccount]
    @AccountName NVARCHAR(100),
    @RoleID INT
AS
BEGIN
    DELETE FROM RoleAccount WHERE AccountName=@AccountName AND RoleID=@RoleID
END
GO
/****** Object:  StoredProcedure [dbo].[ResetPassword]    Script Date: 10/27/2025 11:41:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ResetPassword]
    @AccountName NVARCHAR(100)
AS
BEGIN
    UPDATE Account
    SET [Password] = N'123456'
    WHERE AccountName = @AccountName;
END
GO
/****** Object:  StoredProcedure [dbo].[Role_Delete]    Script Date: 10/27/2025 11:41:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[Role_Delete]
	@id int
as
	begin
		delete from Role
		where ID = @id
	end
GO
/****** Object:  StoredProcedure [dbo].[Role_Insert]    Script Date: 10/27/2025 11:41:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Role_Insert]
	@rolename nvarchar(1000),
	@path nvarchar(3000),
	@notes nvarchar(3000)
as
	begin
		if not exists (select RoleName from Role where RoleName = @rolename)
			insert into Role values(@rolename, @path, @notes)
	end
GO
/****** Object:  StoredProcedure [dbo].[Role_Update]    Script Date: 10/27/2025 11:41:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[Role_Update]
	@id int,
	@rolename nvarchar(1000),
	@path nvarchar(3000),
	@notes nvarchar(3000)
as	
	begin
		update	Role
		set		RoleName = @rolename,
				Path = @path,
				Notes = @notes
		where	ID = @id
	end
GO
/****** Object:  StoredProcedure [dbo].[RoleAccount_Insert]    Script Date: 10/27/2025 11:41:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[RoleAccount_Insert]
	@roleid int,
	@accname nvarchar(1000),
	@actived bit,
	@notes nvarchar(3000)
as
	begin
		if exists (select ID from Role where ID = @roleid) and
			exists(select AccountName from Account where AccountName = @accname)
			insert into RoleAccount values(@roleid, @accname, @actived, @notes)
	end
GO
/****** Object:  StoredProcedure [dbo].[RoleAccount_Update]    Script Date: 10/27/2025 11:41:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[RoleAccount_Update]
	@roleid int,
	@accname nvarchar(1000),
	@actived bit,
	@notes nvarchar(3000)
as
	begin
		update	RoleAccount
		set		Actived = @actived,
				Notes = @notes
		where	RoleID = @roleid and
				AccountName = @accname
	end
GO
/****** Object:  StoredProcedure [dbo].[Table_Delete]    Script Date: 10/27/2025 11:41:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[Table_Delete]
	@id int
as
	begin
		delete from [Table]
		where ID = @id
	end
GO
/****** Object:  StoredProcedure [dbo].[Table_Insert]    Script Date: 10/27/2025 11:41:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Table_Insert]
	@name nvarchar(1000),
	@status int,
	@capacity int
as
	begin
		if not exists(select Name from [Table] where Name = @name)
			insert into [Table] values(@name, @status, @capacity)
	end
GO
/****** Object:  StoredProcedure [dbo].[Table_Update]    Script Date: 10/27/2025 11:41:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[Table_Update]
	@id int,
	@name nvarchar(1000),
	@status int,
	@capacity int
as
	begin
		update [Table]
		set Name = @name,
			Status = @status,
			Capacity = @capacity
		where ID = @id
	end
GO
/****** Object:  StoredProcedure [dbo].[ThongKeTienTheoMonTheoNgay]    Script Date: 10/27/2025 11:41:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ThongKeTienTheoMonTheoNgay]
	@ngay date
as
	begin
		select	Category.Name as [Ten mon an],
				SUM(Quantity * Price) as TongTien
		from	BillDetails
			join Bills on BillDetails.InvoiceID = Bills.ID
			join Food on BillDetails.FoodID = Food.ID
			join Category on Food.FoodCategoryID = Category.ID
		where	CAST(CheckoutDate as date) = @ngay and
				Bills.Status = 1
		group by Category.Name
	end
GO
/****** Object:  StoredProcedure [dbo].[UpdateAccount]    Script Date: 10/27/2025 11:41:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateAccount]
    @AccountName NVARCHAR(100),
    @FullName NVARCHAR(1000),
    @Email NVARCHAR(1000),
    @Tell NVARCHAR(200),
    @RoleID INT
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE Account
    SET FullName = @FullName,
        Email = @Email,
        Tell = @Tell
    WHERE AccountName = @AccountName;

    UPDATE RoleAccount
    SET RoleID = @RoleID
    WHERE AccountName = @AccountName;
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateFood]    Script Date: 10/27/2025 11:41:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[UpdateFood]
	@ID int,
	@Name nvarchar(1000),
	@Unit nvarchar(100),
	@FoodCategoryID int,
	@Price int,
	@Notes nvarchar(3000)
AS
	UPDATE [Food]
	SET		[FoodName] = @Name,
			[Unit] = @Unit,
			[FoodCategoryID] = @FoodCategoryID,
			[Price] = @Price,
			[Notes] = @Notes
	WHERE	ID = @ID

IF @@ERROR <> 0
RETURN 0
ELSE
RETURN 1
GO
/****** Object:  StoredProcedure [dbo].[UpdateRole]    Script Date: 10/27/2025 11:41:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateRole]
    @ID INT,
    @RoleName NVARCHAR(1000),
    @Path NVARCHAR(3000),
    @Notes NVARCHAR(3000)
AS
BEGIN
    UPDATE Role
    SET RoleName = @RoleName,
        Path = @Path,
        Notes = @Notes
    WHERE ID = @ID;
END
GO