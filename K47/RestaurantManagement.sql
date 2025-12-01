USE [RestaurantManagement]
GO
/****** Object:  Table [dbo].[Bills]    Script Date: 11/25/2025 11:25:07 AM ******/
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
 CONSTRAINT [PK_Invoice] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Table]    Script Date: 11/25/2025 11:25:08 AM ******/
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
/****** Object:  UserDefinedFunction [dbo].[LayDSNgayLap]    Script Date: 11/25/2025 11:25:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[LayDSNgayLap] (@id INT)
RETURNS TABLE
AS
RETURN
    SELECT CheckoutDate
    FROM Bills b
    JOIN [Table] t ON t.ID = b.TableID
    WHERE t.ID = @id;

GO
/****** Object:  Table [dbo].[Account]    Script Date: 11/25/2025 11:25:08 AM ******/
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
 CONSTRAINT [PK_Account_1] PRIMARY KEY CLUSTERED 
(
	[AccountName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BillDetails]    Script Date: 11/25/2025 11:25:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BillDetails](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[InvoiceID] [int] NOT NULL,
	[FoodID] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
 CONSTRAINT [PK_InvoiceInfo] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 11/25/2025 11:25:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](1000) NOT NULL,
	[Type] [int] NOT NULL,
 CONSTRAINT [PK_FoodCategory] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Food]    Script Date: 11/25/2025 11:25:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Food](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](1000) NOT NULL,
	[Unit] [nvarchar](100) NOT NULL,
	[FoodCategoryID] [int] NOT NULL,
	[Price] [int] NOT NULL,
	[Notes] [nvarchar](3000) NULL,
 CONSTRAINT [PK_FoodStuffs] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 11/25/2025 11:25:08 AM ******/
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
/****** Object:  Table [dbo].[RoleAccount]    Script Date: 11/25/2025 11:25:08 AM ******/
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
INSERT [dbo].[Account] ([AccountName], [Password], [FullName], [Email], [Tell], [DateCreated]) VALUES (N'lgcong', N'legiacong', N'Lê Gia Công', N'conglg@dlu.edu.vn', NULL, NULL)
GO
INSERT [dbo].[Account] ([AccountName], [Password], [FullName], [Email], [Tell], [DateCreated]) VALUES (N'pttnga', N'phanthithanhnga', N'Phan Thị Thanh Nga', N'ngaptt@dlu.edu.vn', NULL, CAST(N'2020-06-04T00:00:00' AS SmallDateTime))
GO
INSERT [dbo].[Account] ([AccountName], [Password], [FullName], [Email], [Tell], [DateCreated]) VALUES (N'tdquy', N'thaiduyquy', N'Thái Duy Quý', N'quytd@dlu.edu.vn', NULL, NULL)
GO
INSERT [dbo].[Account] ([AccountName], [Password], [FullName], [Email], [Tell], [DateCreated]) VALUES (N'ttplinh', N'tranthiphuonglinh', N'Trần Thị Phương Linh', N'linhttp@dlu.edu.vn', NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[BillDetails] ON 
GO
INSERT [dbo].[BillDetails] ([ID], [InvoiceID], [FoodID], [Quantity]) VALUES (3, 2, 1, 1)
GO
INSERT [dbo].[BillDetails] ([ID], [InvoiceID], [FoodID], [Quantity]) VALUES (4, 2, 2, 1)
GO
INSERT [dbo].[BillDetails] ([ID], [InvoiceID], [FoodID], [Quantity]) VALUES (5, 2, 7, 1)
GO
INSERT [dbo].[BillDetails] ([ID], [InvoiceID], [FoodID], [Quantity]) VALUES (6, 3, 5, 1)
GO
INSERT [dbo].[BillDetails] ([ID], [InvoiceID], [FoodID], [Quantity]) VALUES (7, 3, 10, 2)
GO
INSERT [dbo].[BillDetails] ([ID], [InvoiceID], [FoodID], [Quantity]) VALUES (19, 5, 2, 1)
GO
INSERT [dbo].[BillDetails] ([ID], [InvoiceID], [FoodID], [Quantity]) VALUES (20, 5, 3, 1)
GO
INSERT [dbo].[BillDetails] ([ID], [InvoiceID], [FoodID], [Quantity]) VALUES (21, 5, 4, 1)
GO
INSERT [dbo].[BillDetails] ([ID], [InvoiceID], [FoodID], [Quantity]) VALUES (22, 5, 5, 1)
GO
INSERT [dbo].[BillDetails] ([ID], [InvoiceID], [FoodID], [Quantity]) VALUES (23, 5, 7, 1)
GO
INSERT [dbo].[BillDetails] ([ID], [InvoiceID], [FoodID], [Quantity]) VALUES (24, 6, 4, 1)
GO
INSERT [dbo].[BillDetails] ([ID], [InvoiceID], [FoodID], [Quantity]) VALUES (25, 6, 5, 1)
GO
INSERT [dbo].[BillDetails] ([ID], [InvoiceID], [FoodID], [Quantity]) VALUES (26, 6, 9, 2)
GO
INSERT [dbo].[BillDetails] ([ID], [InvoiceID], [FoodID], [Quantity]) VALUES (27, 7, 4, 1)
GO
INSERT [dbo].[BillDetails] ([ID], [InvoiceID], [FoodID], [Quantity]) VALUES (28, 7, 3, 1)
GO
INSERT [dbo].[BillDetails] ([ID], [InvoiceID], [FoodID], [Quantity]) VALUES (29, 8, 8, 1)
GO
INSERT [dbo].[BillDetails] ([ID], [InvoiceID], [FoodID], [Quantity]) VALUES (30, 8, 6, 1)
GO
INSERT [dbo].[BillDetails] ([ID], [InvoiceID], [FoodID], [Quantity]) VALUES (31, 8, 7, 1)
GO
INSERT [dbo].[BillDetails] ([ID], [InvoiceID], [FoodID], [Quantity]) VALUES (32, 9, 1, 5)
GO
INSERT [dbo].[BillDetails] ([ID], [InvoiceID], [FoodID], [Quantity]) VALUES (33, 9, 2, 1)
GO
INSERT [dbo].[BillDetails] ([ID], [InvoiceID], [FoodID], [Quantity]) VALUES (34, 9, 4, 1)
GO
INSERT [dbo].[BillDetails] ([ID], [InvoiceID], [FoodID], [Quantity]) VALUES (35, 9, 11, 5)
GO
INSERT [dbo].[BillDetails] ([ID], [InvoiceID], [FoodID], [Quantity]) VALUES (36, 9, 3, 1)
GO
INSERT [dbo].[BillDetails] ([ID], [InvoiceID], [FoodID], [Quantity]) VALUES (37, 9, 5, 1)
GO
INSERT [dbo].[BillDetails] ([ID], [InvoiceID], [FoodID], [Quantity]) VALUES (38, 10, 9, 10)
GO
INSERT [dbo].[BillDetails] ([ID], [InvoiceID], [FoodID], [Quantity]) VALUES (39, 10, 8, 1)
GO
INSERT [dbo].[BillDetails] ([ID], [InvoiceID], [FoodID], [Quantity]) VALUES (40, 10, 9, 10)
GO
INSERT [dbo].[BillDetails] ([ID], [InvoiceID], [FoodID], [Quantity]) VALUES (41, 10, 6, 1)
GO
INSERT [dbo].[BillDetails] ([ID], [InvoiceID], [FoodID], [Quantity]) VALUES (42, 10, 7, 1)
GO
INSERT [dbo].[BillDetails] ([ID], [InvoiceID], [FoodID], [Quantity]) VALUES (43, 11, 4, 1)
GO
INSERT [dbo].[BillDetails] ([ID], [InvoiceID], [FoodID], [Quantity]) VALUES (44, 11, 5, 1)
GO
INSERT [dbo].[BillDetails] ([ID], [InvoiceID], [FoodID], [Quantity]) VALUES (45, 11, 1, 6)
GO
INSERT [dbo].[BillDetails] ([ID], [InvoiceID], [FoodID], [Quantity]) VALUES (46, 5, 10, 3)
GO
INSERT [dbo].[BillDetails] ([ID], [InvoiceID], [FoodID], [Quantity]) VALUES (47, 12, 8, 2)
GO
INSERT [dbo].[BillDetails] ([ID], [InvoiceID], [FoodID], [Quantity]) VALUES (48, 12, 10, 2)
GO
SET IDENTITY_INSERT [dbo].[BillDetails] OFF
GO
SET IDENTITY_INSERT [dbo].[Bills] ON 
GO
INSERT [dbo].[Bills] ([ID], [Name], [TableID], [Amount], [Discount], [Tax], [Status], [CheckoutDate], [Account]) VALUES (2, N'Hóa đơn mẫu 2', 4, 75000, 0, 0, 0, NULL, N'ttplinh')
GO
INSERT [dbo].[Bills] ([ID], [Name], [TableID], [Amount], [Discount], [Tax], [Status], [CheckoutDate], [Account]) VALUES (3, N'Hóa đơn mẫu 3', 6, 120000, 0.05, 0, 1, CAST(N'2020-06-05T00:00:00' AS SmallDateTime), N'lgcong')
GO
INSERT [dbo].[Bills] ([ID], [Name], [TableID], [Amount], [Discount], [Tax], [Status], [CheckoutDate], [Account]) VALUES (5, N'Hóa đơn mẫu 5', 2, 305000, 0.1, 0.05, 1, CAST(N'2020-06-06T00:00:00' AS SmallDateTime), N'tdquy')
GO
INSERT [dbo].[Bills] ([ID], [Name], [TableID], [Amount], [Discount], [Tax], [Status], [CheckoutDate], [Account]) VALUES (6, N'Hóa đơn mẫu 4', 8, 130000, 0, 0, 0, NULL, N'lgcong')
GO
INSERT [dbo].[Bills] ([ID], [Name], [TableID], [Amount], [Discount], [Tax], [Status], [CheckoutDate], [Account]) VALUES (7, N'Hóa đơn mẫu 5', 1002, 245000, 0.05, 0, 1, CAST(N'2020-06-07T00:00:00' AS SmallDateTime), N'pttnga')
GO
INSERT [dbo].[Bills] ([ID], [Name], [TableID], [Amount], [Discount], [Tax], [Status], [CheckoutDate], [Account]) VALUES (8, N'Hóa đơn mẫu 6', 1003, 172000, 0, 0.1, 0, NULL, N'ttplinh')
GO
INSERT [dbo].[Bills] ([ID], [Name], [TableID], [Amount], [Discount], [Tax], [Status], [CheckoutDate], [Account]) VALUES (9, N'Hóa đơn mẫu 7', 1004, 110000, 0.05, 0, 1, CAST(N'2020-06-08T00:00:00' AS SmallDateTime), N'tdquy')
GO
INSERT [dbo].[Bills] ([ID], [Name], [TableID], [Amount], [Discount], [Tax], [Status], [CheckoutDate], [Account]) VALUES (10, N'Hóa đơn mẫu 8', 1005, 300000, 0.1, 0.05, 1, CAST(N'2020-06-09T00:00:00' AS SmallDateTime), N'lgcong')
GO
INSERT [dbo].[Bills] ([ID], [Name], [TableID], [Amount], [Discount], [Tax], [Status], [CheckoutDate], [Account]) VALUES (11, N'Hóa đơn mẫu 9 - Bàn 2', 2, 195000, 0, 0, 0, NULL, N'ttplinh')
GO
INSERT [dbo].[Bills] ([ID], [Name], [TableID], [Amount], [Discount], [Tax], [Status], [CheckoutDate], [Account]) VALUES (12, N'Hóa đơn mẫu 9 - Bàn 2', 2, 195000, 0.05, 0, 1, CAST(N'2020-06-10T00:00:00' AS SmallDateTime), N'tdquy')
GO
INSERT [dbo].[Bills] ([ID], [Name], [TableID], [Amount], [Discount], [Tax], [Status], [CheckoutDate], [Account]) VALUES (14, N'Hóa đơn mẫu 11 - Bàn 3', 4, 280000, 0.1, 0, 1, CAST(N'2020-06-11T00:00:00' AS SmallDateTime), N'lgcong')
GO
INSERT [dbo].[Bills] ([ID], [Name], [TableID], [Amount], [Discount], [Tax], [Status], [CheckoutDate], [Account]) VALUES (15, N'Hóa đơn mẫu 11 - Bàn 3', 4, 270000, 0.1, 0, 1, CAST(N'2020-06-11T00:00:00' AS SmallDateTime), N'lgcong')
GO
SET IDENTITY_INSERT [dbo].[Bills] OFF
GO
SET IDENTITY_INSERT [dbo].[Category] ON 
GO
INSERT [dbo].[Category] ([ID], [Name], [Type]) VALUES (1, N'Khai vị', 1)
GO
INSERT [dbo].[Category] ([ID], [Name], [Type]) VALUES (2, N'Hải sản', 1)
GO
INSERT [dbo].[Category] ([ID], [Name], [Type]) VALUES (3, N'Gà', 1)
GO
INSERT [dbo].[Category] ([ID], [Name], [Type]) VALUES (4, N'Cơm', 1)
GO
INSERT [dbo].[Category] ([ID], [Name], [Type]) VALUES (5, N'Thịt', 1)
GO
INSERT [dbo].[Category] ([ID], [Name], [Type]) VALUES (6, N'Rau', 1)
GO
INSERT [dbo].[Category] ([ID], [Name], [Type]) VALUES (8, N'Canh', 1)
GO
INSERT [dbo].[Category] ([ID], [Name], [Type]) VALUES (9, N'Lẩu', 1)
GO
INSERT [dbo].[Category] ([ID], [Name], [Type]) VALUES (10, N'Bia', 0)
GO
INSERT [dbo].[Category] ([ID], [Name], [Type]) VALUES (11, N'Nước ngọt', 0)
GO
INSERT [dbo].[Category] ([ID], [Name], [Type]) VALUES (12, N'Cà phê', 0)
GO
INSERT [dbo].[Category] ([ID], [Name], [Type]) VALUES (13, N'Trà đá', 0)
GO
SET IDENTITY_INSERT [dbo].[Category] OFF
GO
SET IDENTITY_INSERT [dbo].[Food] ON 
GO
INSERT [dbo].[Food] ([ID], [Name], [Unit], [FoodCategoryID], [Price], [Notes]) VALUES (1, N'Rau muống xào tỏi', N'Đĩa', 6, 20000, NULL)
GO
INSERT [dbo].[Food] ([ID], [Name], [Unit], [FoodCategoryID], [Price], [Notes]) VALUES (2, N'Cơm chiên Dương châu', N'Đĩa nhỏ', 4, 35000, N'3 người ăn')
GO
INSERT [dbo].[Food] ([ID], [Name], [Unit], [FoodCategoryID], [Price], [Notes]) VALUES (3, N'Cơm chiên Dương châu', N'Đĩa lớn', 4, 40000, N'4 người ăn')
GO
INSERT [dbo].[Food] ([ID], [Name], [Unit], [FoodCategoryID], [Price], [Notes]) VALUES (4, N'Ếch thui rơm', N'Đĩa', 2, 70000, NULL)
GO
INSERT [dbo].[Food] ([ID], [Name], [Unit], [FoodCategoryID], [Price], [Notes]) VALUES (5, N'Sò lông nướng mỡ hành', N'Đĩa', 2, 80000, NULL)
GO
INSERT [dbo].[Food] ([ID], [Name], [Unit], [FoodCategoryID], [Price], [Notes]) VALUES (6, N'Càng cua hấp', N'Đĩa', 2, 100000, NULL)
GO
INSERT [dbo].[Food] ([ID], [Name], [Unit], [FoodCategoryID], [Price], [Notes]) VALUES (7, N'Canh cải', N'Tô', 8, 20000, NULL)
GO
INSERT [dbo].[Food] ([ID], [Name], [Unit], [FoodCategoryID], [Price], [Notes]) VALUES (8, N'Gà nướng muối ớt', N'Con', 3, 180000, NULL)
GO
INSERT [dbo].[Food] ([ID], [Name], [Unit], [FoodCategoryID], [Price], [Notes]) VALUES (9, N'Bia 333', N'Chai', 10, 12000, NULL)
GO
INSERT [dbo].[Food] ([ID], [Name], [Unit], [FoodCategoryID], [Price], [Notes]) VALUES (10, N'Bia Heniken', N'Chai', 10, 20000, NULL)
GO
INSERT [dbo].[Food] ([ID], [Name], [Unit], [FoodCategoryID], [Price], [Notes]) VALUES (11, N'Súp cua', N'Tô', 1, 15000, NULL)
GO
INSERT [dbo].[Food] ([ID], [Name], [Unit], [FoodCategoryID], [Price], [Notes]) VALUES (12, N'Thịt kho', N'Đĩa', 5, 25000, N'Theo thời giá')
GO
SET IDENTITY_INSERT [dbo].[Food] OFF
GO
SET IDENTITY_INSERT [dbo].[Role] ON 
GO
INSERT [dbo].[Role] ([ID], [RoleName], [Path], [Notes]) VALUES (1, N'Adminstrator', NULL, NULL)
GO
INSERT [dbo].[Role] ([ID], [RoleName], [Path], [Notes]) VALUES (2, N'Kế toán', NULL, NULL)
GO
INSERT [dbo].[Role] ([ID], [RoleName], [Path], [Notes]) VALUES (3, N'Nhân viên thanh toán', NULL, NULL)
GO
INSERT [dbo].[Role] ([ID], [RoleName], [Path], [Notes]) VALUES (4, N'Nhân viên phục vụ', NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[Role] OFF
GO
INSERT [dbo].[RoleAccount] ([RoleID], [AccountName], [Actived], [Notes]) VALUES (1, N'lgcong', 1, NULL)
GO
INSERT [dbo].[RoleAccount] ([RoleID], [AccountName], [Actived], [Notes]) VALUES (1, N'pttnga', 1, NULL)
GO
INSERT [dbo].[RoleAccount] ([RoleID], [AccountName], [Actived], [Notes]) VALUES (1, N'tdquy', 1, NULL)
GO
INSERT [dbo].[RoleAccount] ([RoleID], [AccountName], [Actived], [Notes]) VALUES (1, N'ttplinh', 1, NULL)
GO
INSERT [dbo].[RoleAccount] ([RoleID], [AccountName], [Actived], [Notes]) VALUES (3, N'lgcong', 0, NULL)
GO
INSERT [dbo].[RoleAccount] ([RoleID], [AccountName], [Actived], [Notes]) VALUES (3, N'pttnga', 0, NULL)
GO
INSERT [dbo].[RoleAccount] ([RoleID], [AccountName], [Actived], [Notes]) VALUES (3, N'tdquy', 1, NULL)
GO
INSERT [dbo].[RoleAccount] ([RoleID], [AccountName], [Actived], [Notes]) VALUES (3, N'ttplinh', 1, NULL)
GO
SET IDENTITY_INSERT [dbo].[Table] ON 
GO
INSERT [dbo].[Table] ([ID], [Name], [Status], [Capacity]) VALUES (2, N'1', 0, 4)
GO
INSERT [dbo].[Table] ([ID], [Name], [Status], [Capacity]) VALUES (4, N'03', 0, 4)
GO
INSERT [dbo].[Table] ([ID], [Name], [Status], [Capacity]) VALUES (6, N'05', 0, 8)
GO
INSERT [dbo].[Table] ([ID], [Name], [Status], [Capacity]) VALUES (8, N'06', 0, 8)
GO
INSERT [dbo].[Table] ([ID], [Name], [Status], [Capacity]) VALUES (1002, N'07', 0, 8)
GO
INSERT [dbo].[Table] ([ID], [Name], [Status], [Capacity]) VALUES (1003, N'08', 0, 12)
GO
INSERT [dbo].[Table] ([ID], [Name], [Status], [Capacity]) VALUES (1004, N'09', 0, 12)
GO
INSERT [dbo].[Table] ([ID], [Name], [Status], [Capacity]) VALUES (1005, N'10', 0, 15)
GO
INSERT [dbo].[Table] ([ID], [Name], [Status], [Capacity]) VALUES (1007, N'VIP.2', 0, 20)
GO
INSERT [dbo].[Table] ([ID], [Name], [Status], [Capacity]) VALUES (1008, N'VIP.3', 0, 10)
GO
INSERT [dbo].[Table] ([ID], [Name], [Status], [Capacity]) VALUES (1010, N'12', 0, 4)
GO
INSERT [dbo].[Table] ([ID], [Name], [Status], [Capacity]) VALUES (1011, N'13', 0, 0)
GO
INSERT [dbo].[Table] ([ID], [Name], [Status], [Capacity]) VALUES (1012, N'14', 0, 0)
GO
INSERT [dbo].[Table] ([ID], [Name], [Status], [Capacity]) VALUES (1013, N'15', 0, 0)
GO
INSERT [dbo].[Table] ([ID], [Name], [Status], [Capacity]) VALUES (1014, N'15', 0, 0)
GO
INSERT [dbo].[Table] ([ID], [Name], [Status], [Capacity]) VALUES (1015, N'23', 0, 0)
GO
INSERT [dbo].[Table] ([ID], [Name], [Status], [Capacity]) VALUES (1016, N'30', 0, 0)
GO
INSERT [dbo].[Table] ([ID], [Name], [Status], [Capacity]) VALUES (1018, N'31', 0, 2)
GO
INSERT [dbo].[Table] ([ID], [Name], [Status], [Capacity]) VALUES (1019, N'VIP.10', 2, 2)
GO
INSERT [dbo].[Table] ([ID], [Name], [Status], [Capacity]) VALUES (1022, N'VIP.11', 2, 4)
GO
INSERT [dbo].[Table] ([ID], [Name], [Status], [Capacity]) VALUES (1025, N'102', 2, 8)
GO
INSERT [dbo].[Table] ([ID], [Name], [Status], [Capacity]) VALUES (1027, N'VIP.40', 2, 12)
GO
INSERT [dbo].[Table] ([ID], [Name], [Status], [Capacity]) VALUES (1028, N'VIP.40', 2, 12)
GO
INSERT [dbo].[Table] ([ID], [Name], [Status], [Capacity]) VALUES (1029, N'VIP.39', 2, 12)
GO
SET IDENTITY_INSERT [dbo].[Table] OFF
GO
ALTER TABLE [dbo].[BillDetails] ADD  CONSTRAINT [DF_InvoiceDetails_Amount]  DEFAULT ((0)) FOR [Quantity]
GO
ALTER TABLE [dbo].[Food] ADD  CONSTRAINT [DF_Food_Price]  DEFAULT ((0)) FOR [Price]
GO
ALTER TABLE [dbo].[BillDetails]  WITH CHECK ADD  CONSTRAINT [FK_InvoiceInfo_FoodStuffs] FOREIGN KEY([FoodID])
REFERENCES [dbo].[Food] ([ID])
GO
ALTER TABLE [dbo].[BillDetails] CHECK CONSTRAINT [FK_InvoiceInfo_FoodStuffs]
GO
ALTER TABLE [dbo].[BillDetails]  WITH CHECK ADD  CONSTRAINT [FK_InvoiceInfo_Invoice] FOREIGN KEY([InvoiceID])
REFERENCES [dbo].[Bills] ([ID])
GO
ALTER TABLE [dbo].[BillDetails] CHECK CONSTRAINT [FK_InvoiceInfo_Invoice]
GO
ALTER TABLE [dbo].[Bills]  WITH CHECK ADD  CONSTRAINT [FK_Invoice_Table] FOREIGN KEY([TableID])
REFERENCES [dbo].[Table] ([ID])
GO
ALTER TABLE [dbo].[Bills] CHECK CONSTRAINT [FK_Invoice_Table]
GO
ALTER TABLE [dbo].[Food]  WITH CHECK ADD  CONSTRAINT [FK_FoodStuffs_FoodCategory] FOREIGN KEY([FoodCategoryID])
REFERENCES [dbo].[Category] ([ID])
GO
ALTER TABLE [dbo].[Food] CHECK CONSTRAINT [FK_FoodStuffs_FoodCategory]
GO
ALTER TABLE [dbo].[RoleAccount]  WITH CHECK ADD  CONSTRAINT [FK_RoleAccount_Account] FOREIGN KEY([AccountName])
REFERENCES [dbo].[Account] ([AccountName])
GO
ALTER TABLE [dbo].[RoleAccount] CHECK CONSTRAINT [FK_RoleAccount_Account]
GO
ALTER TABLE [dbo].[RoleAccount]  WITH CHECK ADD  CONSTRAINT [FK_RoleAccount_Role] FOREIGN KEY([RoleID])
REFERENCES [dbo].[Role] ([ID])
GO
ALTER TABLE [dbo].[RoleAccount] CHECK CONSTRAINT [FK_RoleAccount_Role]
GO
/****** Object:  StoredProcedure [dbo].[InsertFood]    Script Date: 11/25/2025 11:25:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[InsertFood]
@ID int output,
@Name nvarchar(3000), 
@Unit nvarchar(3000), 
@FoodCategoryID int, 
@Price int,  
@Notes nvarchar(3000)
AS
	INSERT INTO Food (Name, Unit, FoodCategoryID, Price,  Notes)
	VALUES ( @Name, @Unit, @FoodCategoryID, @Price,  @Notes)

	SELECT @ID = SCOPE_IDENTITY()

GO
/****** Object:  StoredProcedure [dbo].[SuaBan]    Script Date: 11/25/2025 11:25:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SuaBan]
	@id int,
	@name nvarchar(1000),
	@status int,
	@capacity int
AS
	BEGIN
		UPDATE	[Table]
		SET		[Name] = @name,
				[Status] = @status,
				[Capacity] = @capacity
		WHERE	ID = @id
	END
GO
/****** Object:  StoredProcedure [dbo].[ThemBan]    Script Date: 11/25/2025 11:25:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ThemBan]
	@id int OUTPUT,
	@name nvarchar(1000),
	@status int,
	@capacity int
AS
	BEGIN
		INSERT INTO [Table]([Name], [Status], [Capacity])
		VALUES (@name, @status, @capacity)
		SET @id = @@IDENTITY
	END
GO
/****** Object:  StoredProcedure [dbo].[ThemXoaSua_Ban]    Script Date: 11/25/2025 11:25:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ThemXoaSua_Ban]
	@id int OUTPUT,
	@name nvarchar(1000),
	@status int,
	@capacity int,
	@action int
AS
	BEGIN
		IF @action = 0
			BEGIN
				INSERT INTO [Table]([Name], [Status], [Capacity]) 
				VALUES (@name, @status, @capacity)
				SET @id = @@IDENTITY
			END

		ELSE IF @action = 1
			BEGIN
				UPDATE	[Table]
				SET		[Name] = @name,
						[Status] = @status,
						[Capacity] = @capacity
				WHERE	[ID] = @id
			END

		ELSE IF @action = 2
			BEGIN
				DELETE	bd
				FROM	[Table] t
				JOIN	Bills b ON t.ID = b.TableID
				JOIN	BillDetails bd ON b.ID = bd.InvoiceID
				WHERE	b.TableID = @id

				DELETE FROM Bills WHERE TableID = @id

				DELETE FROM [Table] WHERE ID = @id
			END
	END
GO
/****** Object:  StoredProcedure [dbo].[XemCTHD]    Script Date: 11/25/2025 11:25:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[XemCTHD]
	@date smalldatetime,
	@id int
AS
	BEGIN
		SELECT	b.[Name] AS TenHD,
				f.[Name] AS TenMon,
				f.[Unit] AS DVT,
				c.[Name] AS TenDanhMuc,
				SUM(Quantity) AS SoLuong,
				f.Price AS DonGia,
				Price * Quantity AS ThanhTien
		FROM	Bills b
		JOIN	BillDetails bd ON b.ID = bd.InvoiceID
		JOIN	Food f ON bd.FoodID = f.ID
		JOIN	Category c ON f.FoodCategoryID = c.ID
		WHERE	CheckoutDate = @date AND
				b.TableID = @id
		GROUP BY b.Name, f.Name, f.Unit, c.Name, Quantity, Price
	END
GO
/****** Object:  StoredProcedure [dbo].[XemHoaDon]    Script Date: 11/25/2025 11:25:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[XemHoaDon]
	@id int
AS
	BEGIN
	SELECT	f.[Name] AS TenMonAn,
		[Unit] AS DVT,
		SUM(Quantity) AS SoLuong,
		Price AS DonGia,
		Price * SUM(Quantity) AS ThanhTien
FROM	Food f
JOIN	BillDetails bd ON f.ID = bd.FoodID
JOIN	Bills b ON bd.InvoiceID = b.ID
JOIN	[Table] t ON b.TableID = t.ID
WHERE	t.ID = @id
GROUP BY f.[Name], [Unit], Price
	END
GO
/****** Object:  StoredProcedure [dbo].[XoaBan]    Script Date: 11/25/2025 11:25:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[XoaBan]
	@id int
AS
	BEGIN
		DELETE	bd
		FROM	BillDetails bd
		JOIN	Bills b ON bd.InvoiceID = b.ID
		JOIN	[Table] t ON b.TableID = t.ID
		WHERE	t.ID = @id

		DELETE FROM Bills WHERE TableID = @id

		DELETE FROM [Table] WHERE ID = @id
	END
GO
