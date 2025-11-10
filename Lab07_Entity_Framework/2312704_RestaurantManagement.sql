USE [Restaurant Management]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 11/6/2025 3:36:28 PM ******/
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
/****** Object:  Table [dbo].[BillDetails]    Script Date: 11/6/2025 3:36:29 PM ******/
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
/****** Object:  Table [dbo].[Bills]    Script Date: 11/6/2025 3:36:29 PM ******/
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
/****** Object:  Table [dbo].[Category]    Script Date: 11/6/2025 3:36:29 PM ******/
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
/****** Object:  Table [dbo].[Food]    Script Date: 11/6/2025 3:36:29 PM ******/
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
/****** Object:  Table [dbo].[Role]    Script Date: 11/6/2025 3:36:29 PM ******/
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
/****** Object:  Table [dbo].[RoleAccount]    Script Date: 11/6/2025 3:36:29 PM ******/
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
/****** Object:  Table [dbo].[Table]    Script Date: 11/6/2025 3:36:29 PM ******/
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
INSERT [dbo].[Food] ([ID], [FoodName], [Unit], [FoodCategoryID], [Price], [Notes]) VALUES (11, N'Mocktail', N'Ly', 4, 30, N'Non-acohol cocktail')
GO
SET IDENTITY_INSERT [dbo].[Food] OFF
GO
SET IDENTITY_INSERT [dbo].[Role] ON 
GO
INSERT [dbo].[Role] ([ID], [RoleName], [Path], [Notes]) VALUES (1, N'Quản trị viên', N'/admin', N'Quyền truy cập đầy đủ vào hệ thống')
GO
INSERT [dbo].[Role] ([ID], [RoleName], [Path], [Notes]) VALUES (2, N'Nhân viên', N'/staff', N'Quyền truy cập giới hạn cho nhân viên nhà hàng')
GO
INSERT [dbo].[Role] ([ID], [RoleName], [Path], [Notes]) VALUES (3, N'Quản lý', N'/manager', N'Quản lý - quyền quản lý dữ liệu')
GO
INSERT [dbo].[Role] ([ID], [RoleName], [Path], [Notes]) VALUES (4, N'Kế toán', N'/accountant', N'Kế toán - quyền hóa đơn, báo cáo')
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
