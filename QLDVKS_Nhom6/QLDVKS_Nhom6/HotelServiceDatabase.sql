USE [HotelServiceDB]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 11/13/2025 8:24:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[Username] [nvarchar](50) NOT NULL,
	[DisplayName] [nvarchar](100) NOT NULL,
	[Password] [varbinary](64) NOT NULL,
	[RoleID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bill]    Script Date: 11/13/2025 8:24:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bill](
	[BillID] [int] IDENTITY(1,1) NOT NULL,
	[RoomID] [int] NULL,
	[CustomerID] [int] NOT NULL,
	[CheckInDate] [datetime] NOT NULL,
	[CheckOutDate] [datetime] NULL,
	[TotalServiceAmount] [money] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[BillID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BillDetail]    Script Date: 11/13/2025 8:24:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BillDetail](
	[BillDetailID] [int] IDENTITY(1,1) NOT NULL,
	[BillID] [int] NOT NULL,
	[ServiceID] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
	[Amount] [money] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[BillDetailID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 11/13/2025 8:24:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[CustomerID] [int] IDENTITY(1,1) NOT NULL,
	[FullName] [nvarchar](100) NOT NULL,
	[Phone] [nvarchar](15) NULL,
	[Address] [nvarchar](200) NULL,
	[RoomID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 11/13/2025 8:24:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[RoleID] [int] IDENTITY(1,1) NOT NULL,
	[RoleName] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[RoleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Room]    Script Date: 11/13/2025 8:24:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Room](
	[RoomID] [int] IDENTITY(1,1) NOT NULL,
	[RoomName] [nvarchar](50) NOT NULL,
	[StatusID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[RoomID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Service]    Script Date: 11/13/2025 8:24:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Service](
	[ServiceID] [int] IDENTITY(1,1) NOT NULL,
	[ServiceName] [nvarchar](100) NOT NULL,
	[Price] [money] NOT NULL,
	[ServiceTypeID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ServiceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ServiceType]    Script Date: 11/13/2025 8:24:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ServiceType](
	[ServiceTypeID] [int] IDENTITY(1,1) NOT NULL,
	[TypeName] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ServiceTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Account] ([Username], [DisplayName], [Password], [RoleID]) VALUES (N'admin', N'Quản Lý', 0x26D6A8AD97C75FFC548F6873E5E93CE475479E3E1A1097381E54221FB53EC1D2, 1)
GO
INSERT [dbo].[Account] ([Username], [DisplayName], [Password], [RoleID]) VALUES (N'staff1', N'Nhân Viên 1', 0x26D6A8AD97C75FFC548F6873E5E93CE475479E3E1A1097381E54221FB53EC1D2, 2)
GO
SET IDENTITY_INSERT [dbo].[Bill] ON 
GO
INSERT [dbo].[Bill] ([BillID], [RoomID], [CustomerID], [CheckInDate], [CheckOutDate], [TotalServiceAmount]) VALUES (1, 1, 1, CAST(N'2025-11-12T21:51:43.410' AS DateTime), CAST(N'2025-11-13T01:09:12.943' AS DateTime), 390000.0000)
GO
INSERT [dbo].[Bill] ([BillID], [RoomID], [CustomerID], [CheckInDate], [CheckOutDate], [TotalServiceAmount]) VALUES (2, NULL, 2, CAST(N'2025-11-12T21:51:43.460' AS DateTime), CAST(N'2025-11-13T08:08:07.250' AS DateTime), 50000.0000)
GO
INSERT [dbo].[Bill] ([BillID], [RoomID], [CustomerID], [CheckInDate], [CheckOutDate], [TotalServiceAmount]) VALUES (3, 1, 3, CAST(N'2025-11-13T08:11:16.060' AS DateTime), NULL, 0.0000)
GO
INSERT [dbo].[Bill] ([BillID], [RoomID], [CustomerID], [CheckInDate], [CheckOutDate], [TotalServiceAmount]) VALUES (4, 4, 4, CAST(N'2025-11-13T08:11:16.093' AS DateTime), NULL, 0.0000)
GO
INSERT [dbo].[Bill] ([BillID], [RoomID], [CustomerID], [CheckInDate], [CheckOutDate], [TotalServiceAmount]) VALUES (5, NULL, 5, CAST(N'2025-11-13T08:11:16.103' AS DateTime), CAST(N'2025-11-13T08:18:47.493' AS DateTime), 150000.0000)
GO
INSERT [dbo].[Bill] ([BillID], [RoomID], [CustomerID], [CheckInDate], [CheckOutDate], [TotalServiceAmount]) VALUES (6, NULL, 6, CAST(N'2025-11-13T08:11:16.110' AS DateTime), NULL, 0.0000)
GO
INSERT [dbo].[Bill] ([BillID], [RoomID], [CustomerID], [CheckInDate], [CheckOutDate], [TotalServiceAmount]) VALUES (7, NULL, 7, CAST(N'2025-11-13T08:11:16.123' AS DateTime), NULL, 0.0000)
GO
INSERT [dbo].[Bill] ([BillID], [RoomID], [CustomerID], [CheckInDate], [CheckOutDate], [TotalServiceAmount]) VALUES (8, 2, 8, CAST(N'2025-11-10T08:11:16.127' AS DateTime), CAST(N'2025-11-12T08:11:16.127' AS DateTime), 175000.0000)
GO
INSERT [dbo].[Bill] ([BillID], [RoomID], [CustomerID], [CheckInDate], [CheckOutDate], [TotalServiceAmount]) VALUES (9, 3, 9, CAST(N'2025-11-09T08:11:16.133' AS DateTime), CAST(N'2025-11-11T08:11:16.133' AS DateTime), 700000.0000)
GO
INSERT [dbo].[Bill] ([BillID], [RoomID], [CustomerID], [CheckInDate], [CheckOutDate], [TotalServiceAmount]) VALUES (10, 1, 10, CAST(N'2025-11-08T08:11:16.143' AS DateTime), CAST(N'2025-11-10T08:11:16.143' AS DateTime), 150000.0000)
GO
INSERT [dbo].[Bill] ([BillID], [RoomID], [CustomerID], [CheckInDate], [CheckOutDate], [TotalServiceAmount]) VALUES (11, NULL, 11, CAST(N'2025-11-09T08:11:16.150' AS DateTime), CAST(N'2025-11-09T08:11:16.150' AS DateTime), 135000.0000)
GO
INSERT [dbo].[Bill] ([BillID], [RoomID], [CustomerID], [CheckInDate], [CheckOutDate], [TotalServiceAmount]) VALUES (12, NULL, 12, CAST(N'2025-11-08T08:11:16.160' AS DateTime), CAST(N'2025-11-08T08:11:16.160' AS DateTime), 100000.0000)
GO
SET IDENTITY_INSERT [dbo].[Bill] OFF
GO
SET IDENTITY_INSERT [dbo].[BillDetail] ON 
GO
INSERT [dbo].[BillDetail] ([BillDetailID], [BillID], [ServiceID], [Quantity], [Amount]) VALUES (1, 1, 3, 4, 40000.0000)
GO
INSERT [dbo].[BillDetail] ([BillDetailID], [BillID], [ServiceID], [Quantity], [Amount]) VALUES (2, 1, 5, 1, 350000.0000)
GO
INSERT [dbo].[BillDetail] ([BillDetailID], [BillID], [ServiceID], [Quantity], [Amount]) VALUES (3, 2, 1, 2, 50000.0000)
GO
INSERT [dbo].[BillDetail] ([BillDetailID], [BillID], [ServiceID], [Quantity], [Amount]) VALUES (4, 3, 1, 2, 50000.0000)
GO
INSERT [dbo].[BillDetail] ([BillDetailID], [BillID], [ServiceID], [Quantity], [Amount]) VALUES (5, 3, 3, 5, 50000.0000)
GO
INSERT [dbo].[BillDetail] ([BillDetailID], [BillID], [ServiceID], [Quantity], [Amount]) VALUES (6, 4, 5, 2, 700000.0000)
GO
INSERT [dbo].[BillDetail] ([BillDetailID], [BillID], [ServiceID], [Quantity], [Amount]) VALUES (7, 5, 6, 1, 150000.0000)
GO
INSERT [dbo].[BillDetail] ([BillDetailID], [BillID], [ServiceID], [Quantity], [Amount]) VALUES (8, 6, 1, 1, 25000.0000)
GO
INSERT [dbo].[BillDetail] ([BillDetailID], [BillID], [ServiceID], [Quantity], [Amount]) VALUES (9, 6, 2, 2, 60000.0000)
GO
INSERT [dbo].[BillDetail] ([BillDetailID], [BillID], [ServiceID], [Quantity], [Amount]) VALUES (10, 6, 4, 3, 45000.0000)
GO
INSERT [dbo].[BillDetail] ([BillDetailID], [BillID], [ServiceID], [Quantity], [Amount]) VALUES (11, 7, 5, 1, 350000.0000)
GO
INSERT [dbo].[BillDetail] ([BillDetailID], [BillID], [ServiceID], [Quantity], [Amount]) VALUES (12, 8, 1, 5, 125000.0000)
GO
INSERT [dbo].[BillDetail] ([BillDetailID], [BillID], [ServiceID], [Quantity], [Amount]) VALUES (13, 8, 3, 5, 50000.0000)
GO
INSERT [dbo].[BillDetail] ([BillDetailID], [BillID], [ServiceID], [Quantity], [Amount]) VALUES (14, 9, 5, 2, 700000.0000)
GO
INSERT [dbo].[BillDetail] ([BillDetailID], [BillID], [ServiceID], [Quantity], [Amount]) VALUES (15, 10, 6, 1, 150000.0000)
GO
INSERT [dbo].[BillDetail] ([BillDetailID], [BillID], [ServiceID], [Quantity], [Amount]) VALUES (16, 11, 2, 3, 90000.0000)
GO
INSERT [dbo].[BillDetail] ([BillDetailID], [BillID], [ServiceID], [Quantity], [Amount]) VALUES (17, 11, 4, 3, 45000.0000)
GO
INSERT [dbo].[BillDetail] ([BillDetailID], [BillID], [ServiceID], [Quantity], [Amount]) VALUES (18, 12, 3, 10, 100000.0000)
GO
SET IDENTITY_INSERT [dbo].[BillDetail] OFF
GO
SET IDENTITY_INSERT [dbo].[Customer] ON 
GO
INSERT [dbo].[Customer] ([CustomerID], [FullName], [Phone], [Address], [RoomID]) VALUES (1, N'Nguyễn Văn A', N'0909123456', N'123 Đường ABC, Q1, TPHCM', 1)
GO
INSERT [dbo].[Customer] ([CustomerID], [FullName], [Phone], [Address], [RoomID]) VALUES (2, N'Trần Thị B', N'0988111222', N'456 Đường XYZ, Hà Nội', NULL)
GO
INSERT [dbo].[Customer] ([CustomerID], [FullName], [Phone], [Address], [RoomID]) VALUES (3, N'Mai Văn An', N'090111222', N'111 Bình Dương', 1)
GO
INSERT [dbo].[Customer] ([CustomerID], [FullName], [Phone], [Address], [RoomID]) VALUES (4, N'Vũ Thị Hoa', N'090222333', N'222 Đồng Nai', 4)
GO
INSERT [dbo].[Customer] ([CustomerID], [FullName], [Phone], [Address], [RoomID]) VALUES (5, N'Đặng Tuấn Tú', N'090333444', N'333 Long An', NULL)
GO
INSERT [dbo].[Customer] ([CustomerID], [FullName], [Phone], [Address], [RoomID]) VALUES (6, N'Hồ Minh Tâm', N'090444555', N'444 Tiền Giang', NULL)
GO
INSERT [dbo].[Customer] ([CustomerID], [FullName], [Phone], [Address], [RoomID]) VALUES (7, N'Lý Bích Hạnh', N'090555666', N'555 Vũng Tàu', NULL)
GO
INSERT [dbo].[Customer] ([CustomerID], [FullName], [Phone], [Address], [RoomID]) VALUES (8, N'Hoàng Kim Long', N'091666777', N'666 Tây Ninh', NULL)
GO
INSERT [dbo].[Customer] ([CustomerID], [FullName], [Phone], [Address], [RoomID]) VALUES (9, N'Ngô Thanh Vân', N'091777888', N'777 Lâm Đồng', NULL)
GO
INSERT [dbo].[Customer] ([CustomerID], [FullName], [Phone], [Address], [RoomID]) VALUES (10, N'Bùi Văn Nam', N'091888999', N'888 Kiên Giang', NULL)
GO
INSERT [dbo].[Customer] ([CustomerID], [FullName], [Phone], [Address], [RoomID]) VALUES (11, N'Dương Ánh Nguyệt', N'091999000', N'999 Cà Mau', NULL)
GO
INSERT [dbo].[Customer] ([CustomerID], [FullName], [Phone], [Address], [RoomID]) VALUES (12, N'Phan Hùng Dũng', N'091234567', N'123 An Giang', NULL)
GO
SET IDENTITY_INSERT [dbo].[Customer] OFF
GO
SET IDENTITY_INSERT [dbo].[Role] ON 
GO
INSERT [dbo].[Role] ([RoleID], [RoleName]) VALUES (1, N'Quản lý')
GO
INSERT [dbo].[Role] ([RoleID], [RoleName]) VALUES (2, N'Nhân viên')
GO
SET IDENTITY_INSERT [dbo].[Role] OFF
GO
SET IDENTITY_INSERT [dbo].[Room] ON 
GO
INSERT [dbo].[Room] ([RoomID], [RoomName], [StatusID]) VALUES (1, N'P101', 2)
GO
INSERT [dbo].[Room] ([RoomID], [RoomName], [StatusID]) VALUES (2, N'P102', 2)
GO
INSERT [dbo].[Room] ([RoomID], [RoomName], [StatusID]) VALUES (3, N'P103', 1)
GO
INSERT [dbo].[Room] ([RoomID], [RoomName], [StatusID]) VALUES (4, N'P201', 2)
GO
SET IDENTITY_INSERT [dbo].[Room] OFF
GO
SET IDENTITY_INSERT [dbo].[Service] ON 
GO
INSERT [dbo].[Service] ([ServiceID], [ServiceName], [Price], [ServiceTypeID]) VALUES (1, N'Giặt áo sơ mi', 25000.0000, 1)
GO
INSERT [dbo].[Service] ([ServiceID], [ServiceName], [Price], [ServiceTypeID]) VALUES (2, N'Giặt quần tây', 30000.0000, 1)
GO
INSERT [dbo].[Service] ([ServiceID], [ServiceName], [Price], [ServiceTypeID]) VALUES (3, N'Nước suối', 10000.0000, 2)
GO
INSERT [dbo].[Service] ([ServiceID], [ServiceName], [Price], [ServiceTypeID]) VALUES (4, N'Nước ngọt', 15000.0000, 2)
GO
INSERT [dbo].[Service] ([ServiceID], [ServiceName], [Price], [ServiceTypeID]) VALUES (5, N'Massage 60 phút', 350000.0000, 3)
GO
INSERT [dbo].[Service] ([ServiceID], [ServiceName], [Price], [ServiceTypeID]) VALUES (6, N'Tắm hơi 30 phút', 150000.0000, 4)
GO
INSERT [dbo].[Service] ([ServiceID], [ServiceName], [Price], [ServiceTypeID]) VALUES (7, N'Giặt áo sơ mi', 25000.0000, 1)
GO
INSERT [dbo].[Service] ([ServiceID], [ServiceName], [Price], [ServiceTypeID]) VALUES (8, N'Nước cam', 15000.0000, 2)
GO
SET IDENTITY_INSERT [dbo].[Service] OFF
GO
SET IDENTITY_INSERT [dbo].[ServiceType] ON 
GO
INSERT [dbo].[ServiceType] ([ServiceTypeID], [TypeName]) VALUES (1, N'Giặt ủi')
GO
INSERT [dbo].[ServiceType] ([ServiceTypeID], [TypeName]) VALUES (2, N'Nước uống')
GO
INSERT [dbo].[ServiceType] ([ServiceTypeID], [TypeName]) VALUES (3, N'Massage')
GO
INSERT [dbo].[ServiceType] ([ServiceTypeID], [TypeName]) VALUES (4, N'Tắm hơi')
GO
SET IDENTITY_INSERT [dbo].[ServiceType] OFF
GO
ALTER TABLE [dbo].[Bill] ADD  DEFAULT (getdate()) FOR [CheckInDate]
GO
ALTER TABLE [dbo].[Bill] ADD  DEFAULT ((0)) FOR [TotalServiceAmount]
GO
ALTER TABLE [dbo].[Room] ADD  DEFAULT ((1)) FOR [StatusID]
GO
ALTER TABLE [dbo].[Account]  WITH CHECK ADD FOREIGN KEY([RoleID])
REFERENCES [dbo].[Role] ([RoleID])
GO
ALTER TABLE [dbo].[Bill]  WITH CHECK ADD FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Customer] ([CustomerID])
GO
ALTER TABLE [dbo].[Bill]  WITH CHECK ADD FOREIGN KEY([RoomID])
REFERENCES [dbo].[Room] ([RoomID])
GO
ALTER TABLE [dbo].[Bill]  WITH CHECK ADD FOREIGN KEY([RoomID])
REFERENCES [dbo].[Room] ([RoomID])
GO
ALTER TABLE [dbo].[BillDetail]  WITH CHECK ADD FOREIGN KEY([BillID])
REFERENCES [dbo].[Bill] ([BillID])
GO
ALTER TABLE [dbo].[BillDetail]  WITH CHECK ADD FOREIGN KEY([ServiceID])
REFERENCES [dbo].[Service] ([ServiceID])
GO
ALTER TABLE [dbo].[Customer]  WITH CHECK ADD FOREIGN KEY([RoomID])
REFERENCES [dbo].[Room] ([RoomID])
GO
ALTER TABLE [dbo].[Service]  WITH CHECK ADD FOREIGN KEY([ServiceTypeID])
REFERENCES [dbo].[ServiceType] ([ServiceTypeID])
GO
ALTER TABLE [dbo].[BillDetail]  WITH CHECK ADD CHECK  (([Quantity]>(0)))
GO
ALTER TABLE [dbo].[Room]  WITH CHECK ADD CHECK  (([StatusID]=(3) OR [StatusID]=(2) OR [StatusID]=(1)))
GO
ALTER TABLE [dbo].[Service]  WITH CHECK ADD CHECK  (([Price]>=(0)))
GO
/****** Object:  StoredProcedure [dbo].[Account_GetAll]    Script Date: 11/13/2025 8:24:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- 1. SP Lấy tất cả tài khoản
CREATE PROCEDURE [dbo].[Account_GetAll]
AS
BEGIN
    SELECT a.Username, a.DisplayName, a.RoleID, r.RoleName
    FROM Account a
    JOIN Role r ON a.RoleID = r.RoleID
END
GO
/****** Object:  StoredProcedure [dbo].[Account_InsertUpdateDelete]    Script Date: 11/13/2025 8:24:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- 2. SP Thêm, Sửa, Xóa tài khoản
CREATE PROCEDURE [dbo].[Account_InsertUpdateDelete]
    @Username NVARCHAR(50),
    @DisplayName NVARCHAR(100) = NULL,
    @RoleID INT = NULL,
    @Action INT -- 0:Insert, 1:Update, 2:Delete
AS
BEGIN
    IF @Action = 0 -- Insert
    BEGIN
        -- Mật khẩu mặc định khi tạo tài khoản mới là '123'
        -- Người dùng sẽ đổi sau, hoặc admin có thể reset
        INSERT INTO Account (Username, DisplayName, Password, RoleID)
        VALUES (@Username, @DisplayName, HASHBYTES('SHA2_256', N'123'), @RoleID)
    END
    ELSE IF @Action = 1 -- Update
    BEGIN
        -- Chỉ cập nhật Tên hiển thị và Quyền
        UPDATE Account
        SET DisplayName = @DisplayName, RoleID = @RoleID
        WHERE Username = @Username
    END
    ELSE IF @Action = 2 -- Delete
    BEGIN
        DELETE FROM Account WHERE Username = @Username
    END
END
GO
/****** Object:  StoredProcedure [dbo].[Account_Login]    Script Date: 11/13/2025 8:24:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- SỬA: So sánh mật khẩu bằng HASHBYTES
CREATE PROCEDURE [dbo].[Account_Login]
    @Username NVARCHAR(50),
    @Password NVARCHAR(64)
AS
BEGIN
    SELECT a.DisplayName, r.RoleName 
    FROM Account a
    JOIN Role r ON a.RoleID = r.RoleID
    WHERE a.Username = @Username 
      AND a.Password = HASHBYTES('SHA2_256', @Password) -- So sánh hash
END
GO
/****** Object:  StoredProcedure [dbo].[Account_ResetPassword]    Script Date: 11/13/2025 8:24:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- 3. SP Đặt lại mật khẩu (Reset Password)
CREATE PROCEDURE [dbo].[Account_ResetPassword]
    @Username NVARCHAR(50),
    @NewPassword NVARCHAR(64)
AS
BEGIN
    -- Cập nhật mật khẩu về một giá trị mới (đã hash)
    UPDATE Account
    SET Password = HASHBYTES('SHA2_256', @NewPassword)
    WHERE Username = @Username
END
GO
/****** Object:  StoredProcedure [dbo].[Bill_CheckOut]    Script Date: 11/13/2025 8:24:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Bill_CheckOut]
    @BillID INT,
    @TotalServiceAmount MONEY
AS
BEGIN
    UPDATE Bill 
    SET CheckOutDate = GETDATE(), 
        TotalServiceAmount = @TotalServiceAmount
    WHERE BillID = @BillID
END
GO
/****** Object:  StoredProcedure [dbo].[Bill_GetByRoom]    Script Date: 11/13/2025 8:24:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Bill_GetByRoom]
    @RoomID INT
AS
BEGIN
    SELECT 
        b.BillID, b.RoomID, r.RoomName, b.CheckInDate, b.CheckOutDate, 
        b.TotalServiceAmount, b.CustomerID
    FROM Bill b
    JOIN Room r ON b.RoomID = r.RoomID
    WHERE b.RoomID = @RoomID AND b.CheckOutDate IS NULL
END
GO
/****** Object:  StoredProcedure [dbo].[Bill_GetDetailsByID]    Script Date: 11/13/2025 8:24:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Thêm SP mới
CREATE PROCEDURE [dbo].[Bill_GetDetailsByID]
    @BillID INT
AS
BEGIN
    SELECT 
        b.BillID,
        b.RoomID,
        ISNULL(r.RoomName, ' (Khách vãng lai)') AS RoomName, -- Xử lý khách vãng lai
        b.CustomerID,
        c.FullName,
        b.CheckInDate,
        b.CheckOutDate,
        b.TotalServiceAmount
    FROM Bill b
    JOIN Customer c ON b.CustomerID = c.CustomerID
    LEFT JOIN Room r ON b.RoomID = r.RoomID -- LEFT JOIN để lấy cả khách vãng lai
    WHERE b.BillID = @BillID
END
GO
/****** Object:  StoredProcedure [dbo].[Bill_Insert]    Script Date: 11/13/2025 8:24:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Sửa SP Bill_Insert
CREATE PROCEDURE [dbo].[Bill_Insert]
    @RoomID INT = NULL, -- SỬA: Thêm = NULL để chấp nhận giá trị tùy chọn
    @CustomerID INT,
    @BillID INT OUTPUT
AS
BEGIN
    INSERT INTO Bill (RoomID, CustomerID) 
    VALUES (@RoomID, @CustomerID) -- RoomID có thể là NULL
    
    SET @BillID = SCOPE_IDENTITY()
END
GO
/****** Object:  StoredProcedure [dbo].[BillDetail_Delete]    Script Date: 11/13/2025 8:24:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Thêm SP mới
CREATE PROCEDURE [dbo].[BillDetail_Delete]
    @BillDetailID INT
AS
BEGIN
    DELETE FROM BillDetail
    WHERE BillDetailID = @BillDetailID
END
GO
/****** Object:  StoredProcedure [dbo].[BillDetail_GetByBillID]    Script Date: 11/13/2025 8:24:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BillDetail_GetByBillID]
    @BillID INT
AS
BEGIN
    SELECT 
        bd.BillDetailID, bd.BillID, bd.ServiceID, s.ServiceName, bd.Quantity, bd.Amount
    FROM BillDetail bd
    JOIN Service s ON bd.ServiceID = s.ServiceID
    WHERE bd.BillID = @BillID
END
GO
/****** Object:  StoredProcedure [dbo].[BillDetail_Insert]    Script Date: 11/13/2025 8:24:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Sửa SP BillDetail_Insert
CREATE PROCEDURE [dbo].[BillDetail_Insert]
    @BillID INT,
    @ServiceID INT,
    @Quantity INT
AS
BEGIN
    DECLARE @Amount MONEY
    
    -- Tự động tra giá từ bảng Service
    SELECT @Amount = Price * @Quantity 
    FROM Service
    WHERE ServiceID = @ServiceID

    -- Thêm vào chi tiết hóa đơn
    INSERT INTO BillDetail (BillID, ServiceID, Quantity, Amount)
    VALUES (@BillID, @ServiceID, @Quantity, @Amount)
END
GO
/****** Object:  StoredProcedure [dbo].[Customer_GetAll]    Script Date: 11/13/2025 8:24:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Customer_GetAll]
AS
BEGIN
    SELECT 
        c.CustomerID, c.FullName, c.Phone, c.Address, 
        c.RoomID, -- <== THÊM CỘT NÀY VÀO
        r.RoomName
    FROM Customer c
    LEFT JOIN Room r ON c.RoomID = r.RoomID
END
GO
/****** Object:  StoredProcedure [dbo].[Customer_InsertUpdateDelete]    Script Date: 11/13/2025 8:24:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Customer_InsertUpdateDelete]
    @CustomerID INT = NULL OUTPUT,
    @FullName NVARCHAR(100),
    @Phone NVARCHAR(15),
    @Address NVARCHAR(200),
    @RoomID INT = NULL,
    @Action INT
AS
BEGIN
    IF @Action = 0
    BEGIN
        INSERT INTO Customer (FullName, Phone, Address, RoomID)
        VALUES (@FullName, @Phone, @Address, @RoomID)
        SET @CustomerID = SCOPE_IDENTITY()
    END
    ELSE IF @Action = 1
    BEGIN
        UPDATE Customer SET FullName = @FullName, Phone = @Phone, Address = @Address, RoomID = @RoomID
        WHERE CustomerID = @CustomerID
    END
    ELSE IF @Action = 2
    BEGIN
        DELETE FROM Customer WHERE CustomerID = @CustomerID
    END
END
GO
/****** Object:  StoredProcedure [dbo].[Report_GetActiveServiceUsage]    Script Date: 11/13/2025 8:24:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Report_GetActiveServiceUsage]
AS
BEGIN
    SELECT 
        b.BillID, -- Đây là cột đang bị thiếu
        c.CustomerID,
        c.FullName,
        st.TypeName,
        s.ServiceName,
        bd.Quantity,
        s.Price,
        b.CheckInDate,
        bd.Amount
    FROM BillDetail bd
    JOIN Bill b ON bd.BillID = b.BillID
    JOIN Customer c ON b.CustomerID = c.CustomerID
    JOIN Service s ON bd.ServiceID = s.ServiceID
    JOIN ServiceType st ON s.ServiceTypeID = st.ServiceTypeID
    WHERE b.CheckOutDate IS NULL
    ORDER BY c.FullName, b.CheckInDate
END
GO
/****** Object:  StoredProcedure [dbo].[Report_GetRevenueByRange]    Script Date: 11/13/2025 8:24:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Report_GetRevenueByRange]
    @TuNgay DATE,
    @DenNgay DATE,
    @GroupByType INT -- 0: Theo Ngày, 1: Theo Tháng, 2: Theo Năm
AS
BEGIN
    -- Xử lý ngày kết thúc (để bao gồm cả ngày)
    -- SỬA LỖI: Phải CAST @DenNgay sang DATETIME trước khi thêm/bớt thời gian
    DECLARE @DenNgayTime DATETIME = DATEADD(SECOND, -1, DATEADD(DAY, 1, CAST(@DenNgay AS DATETIME)))

    IF @GroupByType = 0 -- Theo Ngày
    BEGIN
        SELECT 
            FORMAT(MIN(CheckOutDate), 'dd/MM/yyyy') AS NgayThangNam,
            COUNT(BillID) AS SoHoaDon,
            SUM(TotalServiceAmount) AS DoanhThu
        FROM Bill
        WHERE CheckOutDate BETWEEN @TuNgay AND @DenNgayTime
        GROUP BY CONVERT(date, CheckOutDate)
        ORDER BY CONVERT(date, CheckOutDate)
    END
    ELSE IF @GroupByType = 1 -- Theo Tháng
    BEGIN
        SELECT 
            FORMAT(MIN(CheckOutDate), 'MM/yyyy') AS NgayThangNam,
            COUNT(BillID) AS SoHoaDon,
            SUM(TotalServiceAmount) AS DoanhThu
        FROM Bill
        WHERE CheckOutDate BETWEEN @TuNgay AND @DenNgayTime
        GROUP BY YEAR(CheckOutDate), MONTH(CheckOutDate)
        ORDER BY YEAR(CheckOutDate), MONTH(CheckOutDate)
    END
    ELSE IF @GroupByType = 2 -- Theo Năm
    BEGIN
        SELECT 
            CAST(YEAR(CheckOutDate) AS VARCHAR(4)) AS NgayThangNam,
            COUNT(BillID) AS SoHoaDon,
            SUM(TotalServiceAmount) AS DoanhThu
        FROM Bill
        WHERE CheckOutDate BETWEEN @TuNgay AND @DenNgayTime
        GROUP BY YEAR(CheckOutDate)
        ORDER BY YEAR(CheckOutDate)
    END
END
GO
/****** Object:  StoredProcedure [dbo].[Report_RoomsUsingService]    Script Date: 11/13/2025 8:24:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Report_RoomsUsingService]
    @ServiceID INT
AS
BEGIN
    SELECT DISTINCT 
        r.RoomID, r.RoomName
    FROM BillDetail bd
    JOIN Bill b ON bd.BillID = b.BillID
    JOIN Room r ON b.RoomID = r.RoomID
    WHERE bd.ServiceID = @ServiceID
END
GO
/****** Object:  StoredProcedure [dbo].[Role_GetAll]    Script Date: 11/13/2025 8:24:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Role_GetAll]
AS
BEGIN
    SELECT RoleID, RoleName FROM Role
END
GO
/****** Object:  StoredProcedure [dbo].[Room_GetAll]    Script Date: 11/13/2025 8:24:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- SỬA: Chọn StatusID (int) thay vì Status (nvarchar)
CREATE PROCEDURE [dbo].[Room_GetAll]
AS
BEGIN
    SELECT RoomID, RoomName, StatusID FROM Room ORDER BY RoomName
END
GO
/****** Object:  StoredProcedure [dbo].[Room_InsertUpdateDelete]    Script Date: 11/13/2025 8:24:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- SỬA: Dùng @StatusID (int)
CREATE PROCEDURE [dbo].[Room_InsertUpdateDelete]
    @RoomID INT = NULL OUTPUT,
    @RoomName NVARCHAR(50),
    @StatusID INT, -- SỬA: Đổi sang INT
    @Action INT -- 0: Insert, 1: Update, 2: Delete
AS
BEGIN
    IF @Action = 0 -- Insert
    BEGIN
        INSERT INTO Room (RoomName, StatusID) VALUES (@RoomName, @StatusID) -- SỬA
        SET @RoomID = SCOPE_IDENTITY()
    END
    ELSE IF @Action = 1 -- Update
    BEGIN
        UPDATE Room SET RoomName = @RoomName, StatusID = @StatusID WHERE RoomID = @RoomID -- SỬA
    END
    ELSE IF @Action = 2 -- Delete
    BEGIN
        DELETE FROM Room WHERE RoomID = @RoomID
    END
END
GO
/****** Object:  StoredProcedure [dbo].[Service_GetAll]    Script Date: 11/13/2025 8:24:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Service_GetAll]
AS
BEGIN
    SELECT 
        s.ServiceID, s.ServiceName, s.Price, s.ServiceTypeID, t.TypeName
    FROM Service s
    JOIN ServiceType t ON s.ServiceTypeID = t.ServiceTypeID
    ORDER BY s.ServiceName
END
GO
/****** Object:  StoredProcedure [dbo].[Service_InsertUpdateDelete]    Script Date: 11/13/2025 8:24:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Service_InsertUpdateDelete]
    @ServiceID INT = NULL OUTPUT,
    @ServiceName NVARCHAR(100),
    @Price MONEY,
    @ServiceTypeID INT,
    @Action INT
AS
BEGIN
    IF @Action = 0
    BEGIN
        INSERT INTO Service (ServiceName, Price, ServiceTypeID) 
        VALUES (@ServiceName, @Price, @ServiceTypeID)
        SET @ServiceID = SCOPE_IDENTITY()
    END
    ELSE IF @Action = 1
    BEGIN
        UPDATE Service SET ServiceName = @ServiceName, Price = @Price, ServiceTypeID = @ServiceTypeID
        WHERE ServiceID = @ServiceID
    END
    ELSE IF @Action = 2
    BEGIN
        DELETE FROM Service WHERE ServiceID = @ServiceID
    END
END
GO
/****** Object:  StoredProcedure [dbo].[ServiceType_GetAll]    Script Date: 11/13/2025 8:24:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ServiceType_GetAll]
AS
BEGIN
    SELECT ServiceTypeID, TypeName FROM ServiceType ORDER BY TypeName
END
GO
/****** Object:  StoredProcedure [dbo].[ServiceType_InsertUpdateDelete]    Script Date: 11/13/2025 8:24:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ServiceType_InsertUpdateDelete]
    @ServiceTypeID INT = NULL OUTPUT,
    @TypeName NVARCHAR(50),
    @Action INT
AS
BEGIN
    IF @Action = 0
    BEGIN
        INSERT INTO ServiceType (TypeName) VALUES (@TypeName)
        SET @ServiceTypeID = SCOPE_IDENTITY()
    END
    ELSE IF @Action = 1
    BEGIN
        UPDATE ServiceType SET TypeName = @TypeName WHERE ServiceTypeID = @ServiceTypeID
    END
    ELSE IF @Action = 2
    BEGIN
        DELETE FROM ServiceType WHERE ServiceTypeID = @ServiceTypeID
    END
END
GO
