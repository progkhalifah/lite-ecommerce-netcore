USE [FoundationDatabase]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 10/25/2022 8:12:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Foundation_Order]    Script Date: 10/25/2022 8:12:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Foundation_Order](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[OrderNo] [nvarchar](max) NULL,
	[Name] [nvarchar](max) NOT NULL,
	[PhoneNo] [nvarchar](max) NOT NULL,
	[Email] [nvarchar](max) NOT NULL,
	[Address] [nvarchar](max) NOT NULL,
	[OrderDate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_tbl_Foundation_Order] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Foundation_OrderDetails]    Script Date: 10/25/2022 8:12:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Foundation_OrderDetails](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[OrderId] [int] NOT NULL,
	[ProdcutId] [int] NOT NULL,
 CONSTRAINT [PK_tbl_Foundation_OrderDetails] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Foundation_Products]    Script Date: 10/25/2022 8:12:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Foundation_Products](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NameProduct] [nvarchar](max) NOT NULL,
	[PriceProduct] [decimal](18, 2) NOT NULL,
	[ImageProduct] [nvarchar](max) NULL,
	[ProductColor] [nvarchar](max) NULL,
	[IsAvailable] [bit] NOT NULL,
	[ProductTypeId] [int] NOT NULL,
 CONSTRAINT [PK_tbl_Foundation_Products] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Foundation_ProductTypes]    Script Date: 10/25/2022 8:12:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Foundation_ProductTypes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProductType] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_tbl_Foundation_ProductTypes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Foundation_RoleClaims]    Script Date: 10/25/2022 8:12:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Foundation_RoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_tbl_Foundation_RoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Foundation_Roles]    Script Date: 10/25/2022 8:12:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Foundation_Roles](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
 CONSTRAINT [PK_tbl_Foundation_Roles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Foundation_UserClaims]    Script Date: 10/25/2022 8:12:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Foundation_UserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_tbl_Foundation_UserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Foundation_UserLogins]    Script Date: 10/25/2022 8:12:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Foundation_UserLogins](
	[LoginProvider] [nvarchar](450) NOT NULL,
	[ProviderKey] [nvarchar](450) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_tbl_Foundation_UserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Foundation_UserRoles]    Script Date: 10/25/2022 8:12:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Foundation_UserRoles](
	[UserId] [nvarchar](450) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_tbl_Foundation_UserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Foundation_Users]    Script Date: 10/25/2022 8:12:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Foundation_Users](
	[Id] [nvarchar](450) NOT NULL,
	[UserName] [nvarchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[Email] [nvarchar](256) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
	[FirstName] [nvarchar](max) NOT NULL,
	[LastName] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_tbl_Foundation_Users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Foundation_UserTokens]    Script Date: 10/25/2022 8:12:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Foundation_UserTokens](
	[UserId] [nvarchar](450) NOT NULL,
	[LoginProvider] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](450) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_tbl_Foundation_UserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'00000000000000_CreateIdentitySchema', N'3.1.29')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20221010210715_FirstMigrationToDataBase', N'3.1.29')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20221010211647_addProductTypesTableIntoDataBase', N'3.1.29')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20221012004158_addproductmodel', N'3.1.29')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20221019072244_addOrderandOrderDetailsable', N'3.1.29')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20221022055138_addUserToTable', N'3.1.29')
GO
SET IDENTITY_INSERT [dbo].[tbl_Foundation_Order] ON 

INSERT [dbo].[tbl_Foundation_Order] ([Id], [OrderNo], [Name], [PhoneNo], [Email], [Address], [OrderDate]) VALUES (1, N'001', N'Raad', N'0550777666', N'raad@gmail.com', N'Jeddah', CAST(N'2022-10-20T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[tbl_Foundation_Order] ([Id], [OrderNo], [Name], [PhoneNo], [Email], [Address], [OrderDate]) VALUES (2, N'002', N'Raad', N'0550777666', N'raad@gmail.com', N'Jeddah', CAST(N'2022-10-20T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[tbl_Foundation_Order] ([Id], [OrderNo], [Name], [PhoneNo], [Email], [Address], [OrderDate]) VALUES (3, N'003', N'Raad', N'0550777666', N'raad@gmail.com', N'Jeddah', CAST(N'2022-10-20T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[tbl_Foundation_Order] ([Id], [OrderNo], [Name], [PhoneNo], [Email], [Address], [OrderDate]) VALUES (4, N'004', N'Raad', N'0550777666', N'raad@gmail.com', N'Jeddah', CAST(N'2022-10-20T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[tbl_Foundation_Order] ([Id], [OrderNo], [Name], [PhoneNo], [Email], [Address], [OrderDate]) VALUES (5, N'005', N'Raad', N'0550777666', N'raad@gmail.com', N'Jeddah', CAST(N'2022-10-20T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[tbl_Foundation_Order] ([Id], [OrderNo], [Name], [PhoneNo], [Email], [Address], [OrderDate]) VALUES (6, N'006', N'Brother''s Raad', N'0550777666', N'brothersraad@gmail.com', N'Jeddah', CAST(N'2022-10-29T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[tbl_Foundation_Order] ([Id], [OrderNo], [Name], [PhoneNo], [Email], [Address], [OrderDate]) VALUES (7, N'007', N'Customer', N'0550777666', N'brothersraad@gmail.com', N'Jeddah', CAST(N'2022-10-20T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[tbl_Foundation_Order] ([Id], [OrderNo], [Name], [PhoneNo], [Email], [Address], [OrderDate]) VALUES (8, N'008', N'new Role', N'0550777666', N'raad@gmail.com', N'Jeddah', CAST(N'2022-10-20T00:00:00.0000000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[tbl_Foundation_Order] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_Foundation_OrderDetails] ON 

INSERT [dbo].[tbl_Foundation_OrderDetails] ([Id], [OrderId], [ProdcutId]) VALUES (1, 1, 1)
INSERT [dbo].[tbl_Foundation_OrderDetails] ([Id], [OrderId], [ProdcutId]) VALUES (2, 1, 2)
INSERT [dbo].[tbl_Foundation_OrderDetails] ([Id], [OrderId], [ProdcutId]) VALUES (3, 2, 1)
INSERT [dbo].[tbl_Foundation_OrderDetails] ([Id], [OrderId], [ProdcutId]) VALUES (4, 3, 1)
INSERT [dbo].[tbl_Foundation_OrderDetails] ([Id], [OrderId], [ProdcutId]) VALUES (5, 3, 2)
INSERT [dbo].[tbl_Foundation_OrderDetails] ([Id], [OrderId], [ProdcutId]) VALUES (6, 4, 1)
INSERT [dbo].[tbl_Foundation_OrderDetails] ([Id], [OrderId], [ProdcutId]) VALUES (7, 4, 2)
INSERT [dbo].[tbl_Foundation_OrderDetails] ([Id], [OrderId], [ProdcutId]) VALUES (8, 5, 1)
INSERT [dbo].[tbl_Foundation_OrderDetails] ([Id], [OrderId], [ProdcutId]) VALUES (9, 7, 1)
INSERT [dbo].[tbl_Foundation_OrderDetails] ([Id], [OrderId], [ProdcutId]) VALUES (10, 7, 4)
INSERT [dbo].[tbl_Foundation_OrderDetails] ([Id], [OrderId], [ProdcutId]) VALUES (11, 8, 4)
INSERT [dbo].[tbl_Foundation_OrderDetails] ([Id], [OrderId], [ProdcutId]) VALUES (12, 8, 1)
INSERT [dbo].[tbl_Foundation_OrderDetails] ([Id], [OrderId], [ProdcutId]) VALUES (13, 8, 2)
SET IDENTITY_INSERT [dbo].[tbl_Foundation_OrderDetails] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_Foundation_Products] ON 

INSERT [dbo].[tbl_Foundation_Products] ([Id], [NameProduct], [PriceProduct], [ImageProduct], [ProductColor], [IsAvailable], [ProductTypeId]) VALUES (1, N'Dell workstation', CAST(3200.00 AS Decimal(18, 2)), N'images/imgdb/Android-VS-Apple.png', N'Silver', 1, 1)
INSERT [dbo].[tbl_Foundation_Products] ([Id], [NameProduct], [PriceProduct], [ImageProduct], [ProductColor], [IsAvailable], [ProductTypeId]) VALUES (2, N'Iphone', CAST(5000.00 AS Decimal(18, 2)), N'images/imgwebsite/notfoundimage.png', N'Pink', 1, 3)
INSERT [dbo].[tbl_Foundation_Products] ([Id], [NameProduct], [PriceProduct], [ImageProduct], [ProductColor], [IsAvailable], [ProductTypeId]) VALUES (3, N'Iphone', CAST(3100.00 AS Decimal(18, 2)), N'images/imgwebsite/notfoundimage.png', NULL, 0, 1)
INSERT [dbo].[tbl_Foundation_Products] ([Id], [NameProduct], [PriceProduct], [ImageProduct], [ProductColor], [IsAvailable], [ProductTypeId]) VALUES (4, N'Iphone', CAST(3200.00 AS Decimal(18, 2)), N'images/imgwebsite/notfoundimage.png', N'Silver', 1, 3)
SET IDENTITY_INSERT [dbo].[tbl_Foundation_Products] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_Foundation_ProductTypes] ON 

INSERT [dbo].[tbl_Foundation_ProductTypes] ([Id], [ProductType]) VALUES (1, N'Computer')
INSERT [dbo].[tbl_Foundation_ProductTypes] ([Id], [ProductType]) VALUES (3, N'Phones')
INSERT [dbo].[tbl_Foundation_ProductTypes] ([Id], [ProductType]) VALUES (5, N'Remote')
INSERT [dbo].[tbl_Foundation_ProductTypes] ([Id], [ProductType]) VALUES (6, N'Airpods')
INSERT [dbo].[tbl_Foundation_ProductTypes] ([Id], [ProductType]) VALUES (7, N'HeadPhones')
SET IDENTITY_INSERT [dbo].[tbl_Foundation_ProductTypes] OFF
GO
INSERT [dbo].[tbl_Foundation_Roles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'4bb304f3-14b6-4cbc-ab75-2befe4ad5c38', N'Manager', N'MANAGER', N'f9162143-23f2-485a-8088-7e89c2ba1987')
INSERT [dbo].[tbl_Foundation_Roles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'4f879ea2-f642-40be-8de7-197d54a60e39', N'Customer', N'CUSTOMER', N'b5e67784-cac1-40ab-b27b-4d528bfa7eb5')
INSERT [dbo].[tbl_Foundation_Roles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'ddc4031c-91fd-43d9-8100-42d14381332f', N'Delivery', N'DELIVERY', N'53f2d73f-20aa-4467-841a-b5b0182d3c08')
GO
ALTER TABLE [dbo].[tbl_Foundation_OrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Foundation_OrderDetails_tbl_Foundation_Order_OrderId] FOREIGN KEY([OrderId])
REFERENCES [dbo].[tbl_Foundation_Order] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbl_Foundation_OrderDetails] CHECK CONSTRAINT [FK_tbl_Foundation_OrderDetails_tbl_Foundation_Order_OrderId]
GO
ALTER TABLE [dbo].[tbl_Foundation_OrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Foundation_OrderDetails_tbl_Foundation_Products_ProdcutId] FOREIGN KEY([ProdcutId])
REFERENCES [dbo].[tbl_Foundation_Products] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbl_Foundation_OrderDetails] CHECK CONSTRAINT [FK_tbl_Foundation_OrderDetails_tbl_Foundation_Products_ProdcutId]
GO
ALTER TABLE [dbo].[tbl_Foundation_Products]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Foundation_Products_tbl_Foundation_ProductTypes_ProductTypeId] FOREIGN KEY([ProductTypeId])
REFERENCES [dbo].[tbl_Foundation_ProductTypes] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbl_Foundation_Products] CHECK CONSTRAINT [FK_tbl_Foundation_Products_tbl_Foundation_ProductTypes_ProductTypeId]
GO
ALTER TABLE [dbo].[tbl_Foundation_RoleClaims]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Foundation_RoleClaims_tbl_Foundation_Roles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[tbl_Foundation_Roles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbl_Foundation_RoleClaims] CHECK CONSTRAINT [FK_tbl_Foundation_RoleClaims_tbl_Foundation_Roles_RoleId]
GO
ALTER TABLE [dbo].[tbl_Foundation_UserClaims]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Foundation_UserClaims_tbl_Foundation_Users_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[tbl_Foundation_Users] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbl_Foundation_UserClaims] CHECK CONSTRAINT [FK_tbl_Foundation_UserClaims_tbl_Foundation_Users_UserId]
GO
ALTER TABLE [dbo].[tbl_Foundation_UserLogins]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Foundation_UserLogins_tbl_Foundation_Users_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[tbl_Foundation_Users] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbl_Foundation_UserLogins] CHECK CONSTRAINT [FK_tbl_Foundation_UserLogins_tbl_Foundation_Users_UserId]
GO
ALTER TABLE [dbo].[tbl_Foundation_UserRoles]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Foundation_UserRoles_tbl_Foundation_Roles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[tbl_Foundation_Roles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbl_Foundation_UserRoles] CHECK CONSTRAINT [FK_tbl_Foundation_UserRoles_tbl_Foundation_Roles_RoleId]
GO
ALTER TABLE [dbo].[tbl_Foundation_UserRoles]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Foundation_UserRoles_tbl_Foundation_Users_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[tbl_Foundation_Users] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbl_Foundation_UserRoles] CHECK CONSTRAINT [FK_tbl_Foundation_UserRoles_tbl_Foundation_Users_UserId]
GO
ALTER TABLE [dbo].[tbl_Foundation_UserTokens]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Foundation_UserTokens_tbl_Foundation_Users_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[tbl_Foundation_Users] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbl_Foundation_UserTokens] CHECK CONSTRAINT [FK_tbl_Foundation_UserTokens_tbl_Foundation_Users_UserId]
GO
