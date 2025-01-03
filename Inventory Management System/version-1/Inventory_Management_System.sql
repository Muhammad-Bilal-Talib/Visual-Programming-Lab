USE [master]
GO
/****** Object:  Database [Inventory_Management_System]    Script Date: 12/25/2024 8:10:21 PM ******/
CREATE DATABASE [Inventory_Management_System]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Inventory_Management_System', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\Inventory_Management_System.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Inventory_Management_System_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\Inventory_Management_System_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [Inventory_Management_System] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Inventory_Management_System].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Inventory_Management_System] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Inventory_Management_System] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Inventory_Management_System] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Inventory_Management_System] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Inventory_Management_System] SET ARITHABORT OFF 
GO
ALTER DATABASE [Inventory_Management_System] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Inventory_Management_System] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Inventory_Management_System] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Inventory_Management_System] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Inventory_Management_System] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Inventory_Management_System] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Inventory_Management_System] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Inventory_Management_System] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Inventory_Management_System] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Inventory_Management_System] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Inventory_Management_System] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Inventory_Management_System] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Inventory_Management_System] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Inventory_Management_System] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Inventory_Management_System] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Inventory_Management_System] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Inventory_Management_System] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Inventory_Management_System] SET RECOVERY FULL 
GO
ALTER DATABASE [Inventory_Management_System] SET  MULTI_USER 
GO
ALTER DATABASE [Inventory_Management_System] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Inventory_Management_System] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Inventory_Management_System] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Inventory_Management_System] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Inventory_Management_System] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Inventory_Management_System] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Inventory_Management_System', N'ON'
GO
ALTER DATABASE [Inventory_Management_System] SET QUERY_STORE = ON
GO
ALTER DATABASE [Inventory_Management_System] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [Inventory_Management_System]
GO
/****** Object:  Table [dbo].[AuditLogs]    Script Date: 12/25/2024 8:10:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AuditLogs](
	[LogID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NOT NULL,
	[Action] [nvarchar](100) NOT NULL,
	[TableAffected] [nvarchar](50) NULL,
	[ActionTime] [datetime] NOT NULL,
	[Description] [nvarchar](255) NULL,
 CONSTRAINT [PK_AuditLogs] PRIMARY KEY CLUSTERED 
(
	[LogID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 12/25/2024 8:10:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[CategoryID] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](100) NOT NULL,
	[Description] [nvarchar](100) NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 12/25/2024 8:10:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[ProductID] [int] IDENTITY(1,1) NOT NULL,
	[ProdName] [nvarchar](100) NOT NULL,
	[SKU] [nvarchar](50) NOT NULL,
	[Category] [nvarchar](50) NULL,
	[Quantity] [int] NOT NULL,
	[UnitPrice] [decimal](10, 2) NULL,
	[Barcode] [nvarchar](50) NULL,
	[CreatedAt] [datetime] NOT NULL,
	[UpdatedAt] [datetime] NOT NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PurchaseOrderDetails]    Script Date: 12/25/2024 8:10:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PurchaseOrderDetails](
	[PODetailID] [int] IDENTITY(1,1) NOT NULL,
	[PurchaseOrderID] [int] NOT NULL,
	[ProductID] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
	[UnitPrice] [decimal](10, 2) NOT NULL,
 CONSTRAINT [PK_PurchaseOrderDetails] PRIMARY KEY CLUSTERED 
(
	[PODetailID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PurchaseOrders]    Script Date: 12/25/2024 8:10:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PurchaseOrders](
	[PurchaseOrderID] [int] IDENTITY(1,1) NOT NULL,
	[SupplierID] [int] NOT NULL,
	[OrderDate] [datetime] NOT NULL,
	[Status] [nvarchar](25) NOT NULL,
	[TotalAmount] [decimal](10, 2) NULL,
 CONSTRAINT [PK_PurchaseOrders] PRIMARY KEY CLUSTERED 
(
	[PurchaseOrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SalesOrderDetails]    Script Date: 12/25/2024 8:10:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SalesOrderDetails](
	[SODetailID] [int] IDENTITY(1,1) NOT NULL,
	[SalesOrderID] [int] NOT NULL,
	[ProductID] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
	[UnitPrice] [decimal](10, 2) NOT NULL,
 CONSTRAINT [PK_SalesOrderDetails] PRIMARY KEY CLUSTERED 
(
	[SODetailID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SalesOrders]    Script Date: 12/25/2024 8:10:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SalesOrders](
	[SalesOrderID] [int] IDENTITY(1,1) NOT NULL,
	[CustomerName] [nvarchar](100) NULL,
	[OrderDate] [datetime] NOT NULL,
	[Status] [nvarchar](20) NOT NULL,
	[TotalAmount] [decimal](10, 2) NULL,
 CONSTRAINT [PK_SalesOrders] PRIMARY KEY CLUSTERED 
(
	[SalesOrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StockMovements]    Script Date: 12/25/2024 8:10:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StockMovements](
	[MovementID] [int] IDENTITY(1,1) NOT NULL,
	[ProductID] [int] NOT NULL,
	[MovementType] [nvarchar](20) NOT NULL,
	[Quantity] [int] NOT NULL,
	[MovementDate] [datetime] NOT NULL,
	[Description] [nvarchar](255) NULL,
 CONSTRAINT [PK_StockMovements] PRIMARY KEY CLUSTERED 
(
	[MovementID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Suppliers]    Script Date: 12/25/2024 8:10:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Suppliers](
	[SupplierID] [int] IDENTITY(1,1) NOT NULL,
	[SupplierName] [nvarchar](100) NOT NULL,
	[ContactName] [nvarchar](100) NULL,
	[Phone] [nvarchar](15) NULL,
	[Email] [nvarchar](100) NULL,
	[Address] [nvarchar](255) NULL,
 CONSTRAINT [PK_Suppliers] PRIMARY KEY CLUSTERED 
(
	[SupplierID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 12/25/2024 8:10:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nvarchar](50) NOT NULL,
	[PasswordHash] [nvarchar](255) NOT NULL,
	[Role] [nvarchar](50) NOT NULL,
	[CreatedAt] [datetime] NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[AuditLogs] ON 

INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (4, 1, N'Update', N'SalesOrders', CAST(N'2024-12-22T19:12:23.500' AS DateTime), N'Updated record with SalesOrderID = 2')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (5, 1, N' Login-User', N'Users', CAST(N'2024-12-22T21:27:04.590' AS DateTime), N'Loggned User record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (6, 5, N' Login-User', N'Users', CAST(N'2024-12-22T22:23:22.637' AS DateTime), N'Loggned User record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (7, 1, N' Login-User', N'Users', CAST(N'2024-12-22T22:33:06.947' AS DateTime), N'Loggned User record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (8, 1, N' Login-User', N'Users', CAST(N'2024-12-22T22:40:30.007' AS DateTime), N'Loggned User record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (9, 1, N' Login-User', N'Users', CAST(N'2024-12-22T22:42:14.163' AS DateTime), N'Loggned User record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (10, 1, N' Login-User', N'Users', CAST(N'2024-12-22T22:46:10.057' AS DateTime), N'Loggned User record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (11, 1, N'Added', N'Products', CAST(N'2024-12-22T22:46:45.390' AS DateTime), N'Added record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (12, 5, N' Login-User', N'Users', CAST(N'2024-12-22T22:48:35.267' AS DateTime), N'Loggned User record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (13, 5, N'Delete', N'Products', CAST(N'2024-12-22T22:48:43.200' AS DateTime), N'Deleted record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (14, 5, N'Added', N'Products', CAST(N'2024-12-22T22:48:48.580' AS DateTime), N'Added record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (15, 5, N'Add Category', N'Categories', CAST(N'2024-12-22T22:50:06.397' AS DateTime), N'Add Category record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (16, 1, N' Login-User', N'Users', CAST(N'2024-12-22T22:50:59.913' AS DateTime), N'Loggned User record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (17, 1, N'Delete', N'Categories', CAST(N'2024-12-22T22:51:05.510' AS DateTime), N'Deleted Category record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (18, 1, N'Add Category', N'Categories', CAST(N'2024-12-22T22:51:07.523' AS DateTime), N'Add Category record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (19, 1, N'Added', N'Suppliers', CAST(N'2024-12-22T22:52:23.080' AS DateTime), N'Add Supplier record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (20, 1, N' Movement-Update', N'StockMovements', CAST(N'2024-12-22T22:53:22.500' AS DateTime), N'Updated StockMovements record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (21, 1, N'Create Order', N'PurchaseOrders', CAST(N'2024-12-22T22:53:53.190' AS DateTime), N'Create PurchaseOrders record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (22, 1, N'Update', N'SalesOrders', CAST(N'2024-12-22T22:54:41.617' AS DateTime), N'Updated record with SalesOrderID = 3')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (23, 1, N' Login-User', N'Users', CAST(N'2024-12-22T22:57:45.330' AS DateTime), N'Loggned User record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (24, 1, N'AuditLog', N'AuditLogs', CAST(N'2024-12-22T22:57:46.940' AS DateTime), N'AuditLogs Checking record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (25, 1, N' Login-User', N'Users', CAST(N'2024-12-22T22:58:28.370' AS DateTime), N'Loggned User record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (26, 1, N'AuditLog', N'AuditLogs', CAST(N'2024-12-22T22:58:30.040' AS DateTime), N'AuditLogs Checking record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (27, 1, N'AuditLog', N'AuditLogs', CAST(N'2024-12-22T22:58:34.967' AS DateTime), N'AuditLogs Checking record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (28, 1, N'Added', N'Products', CAST(N'2024-12-22T22:59:32.793' AS DateTime), N'Added record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (29, 1, N'AuditLog', N'AuditLogs', CAST(N'2024-12-22T22:59:50.697' AS DateTime), N'AuditLogs Checking record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (30, 1, N'AuditLog', N'AuditLogs', CAST(N'2024-12-22T22:59:52.580' AS DateTime), N'AuditLogs Checking record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (31, 1, N'AuditLog', N'AuditLogs', CAST(N'2024-12-22T22:59:53.677' AS DateTime), N'AuditLogs Checking record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (32, 1, N'AuditLog', N'AuditLogs', CAST(N'2024-12-22T22:59:56.990' AS DateTime), N'AuditLogs Checking record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (33, 1, N'AuditLog', N'AuditLogs', CAST(N'2024-12-22T22:59:59.177' AS DateTime), N'AuditLogs Checking record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (34, 1, N'AuditLog', N'AuditLogs', CAST(N'2024-12-22T22:59:59.480' AS DateTime), N'AuditLogs Checking record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (35, 1, N'AuditLog', N'AuditLogs', CAST(N'2024-12-22T22:59:59.810' AS DateTime), N'AuditLogs Checking record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (36, 1, N'AuditLog', N'AuditLogs', CAST(N'2024-12-22T23:00:00.023' AS DateTime), N'AuditLogs Checking record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (37, 1, N' Login-User', N'Users', CAST(N'2024-12-22T23:03:36.930' AS DateTime), N'Loggned User record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (38, 1, N'AuditLog', N'AuditLogs', CAST(N'2024-12-22T23:03:38.227' AS DateTime), N'AuditLogs Checking record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (39, 1, N' Login-User', N'Users', CAST(N'2024-12-22T23:05:24.190' AS DateTime), N'Loggned User record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (40, 1, N' Login-User', N'Users', CAST(N'2024-12-23T19:30:50.963' AS DateTime), N'Loggned User record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (41, 1, N' Login-User', N'Users', CAST(N'2024-12-23T19:40:31.040' AS DateTime), N'Loggned User record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (42, 1, N' Login-User', N'Users', CAST(N'2024-12-23T19:48:16.793' AS DateTime), N'Loggned User record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (43, 1, N' Login-User', N'Users', CAST(N'2024-12-23T19:50:24.660' AS DateTime), N'Loggned User record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (44, 1, N' Login-User', N'Users', CAST(N'2024-12-23T20:26:06.497' AS DateTime), N'Loggned User record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (45, 1, N' Login-User', N'Users', CAST(N'2024-12-23T20:29:08.053' AS DateTime), N'Loggned User record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (46, 1, N' Login-User', N'Users', CAST(N'2024-12-23T20:41:27.737' AS DateTime), N'Loggned User record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (47, 1, N'Added', N'Products', CAST(N'2024-12-23T20:42:58.180' AS DateTime), N'Added record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (48, 1, N'Delete', N'Products', CAST(N'2024-12-23T20:43:06.923' AS DateTime), N'Deleted record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (49, 1, N'Delete', N'Products', CAST(N'2024-12-23T20:43:33.537' AS DateTime), N'Deleted record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (50, 1, N' Login-User', N'Users', CAST(N'2024-12-23T20:48:35.740' AS DateTime), N'Loggned User record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (51, 1, N'AuditLog', N'AuditLogs', CAST(N'2024-12-23T20:49:30.347' AS DateTime), N'AuditLogs Checking record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (52, 1, N' Login-User', N'Users', CAST(N'2024-12-23T20:53:24.563' AS DateTime), N'Loggned User record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (53, 1, N'AuditLog', N'AuditLogs', CAST(N'2024-12-23T20:53:31.960' AS DateTime), N'AuditLogs Checking record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (54, 1, N' Login-User', N'Users', CAST(N'2024-12-23T20:56:03.810' AS DateTime), N'Loggned User record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (55, 1, N'AuditLog', N'AuditLogs', CAST(N'2024-12-23T20:58:14.083' AS DateTime), N'AuditLogs Checking record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (56, 1, N' Login-User', N'Users', CAST(N'2024-12-23T20:59:25.637' AS DateTime), N'Loggned User record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (57, 1, N'AuditLog', N'AuditLogs', CAST(N'2024-12-23T21:02:02.230' AS DateTime), N'AuditLogs Checking record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (58, 1, N' Login-User', N'Users', CAST(N'2024-12-23T21:03:14.793' AS DateTime), N'Loggned User record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (59, 1, N'AuditLog', N'AuditLogs', CAST(N'2024-12-23T21:03:17.417' AS DateTime), N'AuditLogs Checking record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (60, 1, N' Login-User', N'Users', CAST(N'2024-12-23T21:04:29.967' AS DateTime), N'Loggned User record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (61, 1, N'AuditLog', N'AuditLogs', CAST(N'2024-12-23T21:04:31.450' AS DateTime), N'AuditLogs Checking record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (62, 1, N' Login-User', N'Users', CAST(N'2024-12-23T21:07:01.607' AS DateTime), N'Loggned User record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (63, 1, N'AuditLog', N'AuditLogs', CAST(N'2024-12-23T21:07:03.370' AS DateTime), N'AuditLogs Checking record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (64, 1, N' Login-User', N'Users', CAST(N'2024-12-23T21:08:48.877' AS DateTime), N'Loggned User record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (65, 1, N' Login-User', N'Users', CAST(N'2024-12-23T21:11:00.130' AS DateTime), N'Loggned User record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (66, 1, N' Login-User', N'Users', CAST(N'2024-12-23T21:11:44.127' AS DateTime), N'Loggned User record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (67, 1, N' Login-User', N'Users', CAST(N'2024-12-23T21:13:46.727' AS DateTime), N'Loggned User record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (68, 1, N' Login-User', N'Users', CAST(N'2024-12-23T21:15:43.073' AS DateTime), N'Loggned User record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (69, 1, N' Login-User', N'Users', CAST(N'2024-12-23T21:18:13.947' AS DateTime), N'Loggned User record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (70, 1, N' Login-User', N'Users', CAST(N'2024-12-23T21:21:08.380' AS DateTime), N'Loggned User record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (71, 1, N' Login-User', N'Users', CAST(N'2024-12-23T21:27:34.533' AS DateTime), N'Loggned User record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (72, 1, N'AuditLog', N'AuditLogs', CAST(N'2024-12-23T21:28:43.247' AS DateTime), N'AuditLogs Checking record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (73, 1, N' Login-User', N'Users', CAST(N'2024-12-23T21:29:53.020' AS DateTime), N'Loggned User record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (74, 1, N' Login-User', N'Users', CAST(N'2024-12-23T21:36:36.717' AS DateTime), N'Loggned User record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (75, 1, N' Login-User', N'Users', CAST(N'2024-12-23T21:38:41.217' AS DateTime), N'Loggned User record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (76, 1, N'Login-User', N'Users', CAST(N'2024-12-23T21:41:35.400' AS DateTime), N'Logged User record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (77, 1, N'AuditLog', N'AuditLogs', CAST(N'2024-12-23T21:41:37.497' AS DateTime), N'AuditLogs Checking record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (78, 1, N'Login-User', N'Users', CAST(N'2024-12-23T21:42:55.927' AS DateTime), N'Logged User record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (79, 1, N'Login-User', N'Users', CAST(N'2024-12-23T21:45:19.580' AS DateTime), N'Logged User record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (80, 1, N'Login-User', N'Users', CAST(N'2024-12-23T21:47:29.140' AS DateTime), N'Logged User record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (81, 1, N'AuditLog', N'AuditLogs', CAST(N'2024-12-23T21:47:31.397' AS DateTime), N'AuditLogs Checking record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (82, 1, N'Login-User', N'Users', CAST(N'2024-12-23T21:48:39.180' AS DateTime), N'Logged User record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (83, 1, N'Login-User', N'Users', CAST(N'2024-12-23T21:49:41.450' AS DateTime), N'Logged User record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (84, 1, N' Login-User', N'Users', CAST(N'2024-12-23T22:16:46.620' AS DateTime), N'Loggned User record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (85, 1, N' Login-User', N'Users', CAST(N'2024-12-23T22:23:40.533' AS DateTime), N'Loggned User record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (86, 1, N' Login-User', N'Users', CAST(N'2024-12-23T22:28:02.537' AS DateTime), N'Loggned User record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (87, 1, N' Login-User', N'Users', CAST(N'2024-12-23T22:29:37.080' AS DateTime), N'Loggned User record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (88, 1, N' Login-User', N'Users', CAST(N'2024-12-23T22:32:28.420' AS DateTime), N'Loggned User record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (89, 1, N' Login-User', N'Users', CAST(N'2024-12-23T22:33:27.817' AS DateTime), N'Loggned User record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (90, 1, N' Login-User', N'Users', CAST(N'2024-12-23T22:56:35.163' AS DateTime), N'Loggned User record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (91, 1, N'AuditLog', N'AuditLogs', CAST(N'2024-12-23T22:56:46.037' AS DateTime), N'AuditLogs Checking record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (92, 1, N' Login-User', N'Users', CAST(N'2024-12-23T22:58:08.727' AS DateTime), N'Loggned User record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (93, 1, N' Login-User', N'Users', CAST(N'2024-12-23T23:00:54.153' AS DateTime), N'Loggned User record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (94, 1, N'AuditLog', N'AuditLogs', CAST(N'2024-12-23T23:01:04.753' AS DateTime), N'AuditLogs Checking record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (95, 1, N' Login-User', N'Users', CAST(N'2024-12-23T23:05:48.443' AS DateTime), N'Loggned User record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (96, 1, N'AuditLog', N'AuditLogs', CAST(N'2024-12-23T23:05:51.343' AS DateTime), N'AuditLogs Checking record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (97, 1, N' Login-User', N'Users', CAST(N'2024-12-23T23:08:28.020' AS DateTime), N'Loggned User record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (98, 1, N'AuditLog', N'AuditLogs', CAST(N'2024-12-23T23:08:35.520' AS DateTime), N'AuditLogs Checking record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (99, 1, N' Login-User', N'Users', CAST(N'2024-12-23T23:13:11.533' AS DateTime), N'Loggned User record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (100, 1, N' Login-User', N'Users', CAST(N'2024-12-23T23:17:53.920' AS DateTime), N'Loggned User record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (101, 1, N'AuditLog', N'AuditLogs', CAST(N'2024-12-23T23:18:01.200' AS DateTime), N'AuditLogs Checking record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (102, 1, N' Login-User', N'Users', CAST(N'2024-12-23T23:21:14.843' AS DateTime), N'Loggned User record in Database')
GO
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (103, 1, N'AuditLog', N'AuditLogs', CAST(N'2024-12-23T23:21:17.640' AS DateTime), N'AuditLogs Checking record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (104, 1, N' Login-User', N'Users', CAST(N'2024-12-23T23:26:34.170' AS DateTime), N'Loggned User record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (105, 1, N'AuditLog', N'AuditLogs', CAST(N'2024-12-23T23:26:36.703' AS DateTime), N'AuditLogs Checking record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (106, 1, N' Login-User', N'Users', CAST(N'2024-12-23T23:31:45.443' AS DateTime), N'Loggned User record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (107, 1, N'AuditLog', N'AuditLogs', CAST(N'2024-12-23T23:31:53.220' AS DateTime), N'AuditLogs Checking record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (108, 1, N' Login-User', N'Users', CAST(N'2024-12-23T23:35:02.573' AS DateTime), N'Loggned User record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (109, 1, N'AuditLog', N'AuditLogs', CAST(N'2024-12-23T23:35:05.060' AS DateTime), N'AuditLogs Checking record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (110, 1, N' Login-User', N'Users', CAST(N'2024-12-23T23:38:10.983' AS DateTime), N'Loggned User record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (111, 1, N'AuditLog', N'AuditLogs', CAST(N'2024-12-23T23:38:13.260' AS DateTime), N'AuditLogs Checking record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (112, 1, N' Login-User', N'Users', CAST(N'2024-12-23T23:41:17.157' AS DateTime), N'Loggned User record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (113, 1, N'AuditLog', N'AuditLogs', CAST(N'2024-12-23T23:41:21.433' AS DateTime), N'AuditLogs Checking record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (114, 1, N' Login-User', N'Users', CAST(N'2024-12-25T15:41:31.340' AS DateTime), N'Loggned User record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (115, 1, N'AuditLog', N'AuditLogs', CAST(N'2024-12-25T15:42:04.510' AS DateTime), N'AuditLogs Checking record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (116, 1, N' Login-User', N'Users', CAST(N'2024-12-25T16:10:27.367' AS DateTime), N'Loggned User record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (117, 1, N' Login-User', N'Users', CAST(N'2024-12-25T16:17:12.213' AS DateTime), N'Loggned User record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (118, 1, N' Login-User', N'Users', CAST(N'2024-12-25T16:21:15.293' AS DateTime), N'Loggned User record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (119, 1, N' Login-User', N'Users', CAST(N'2024-12-25T16:23:45.413' AS DateTime), N'Loggned User record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (120, 1, N' Login-User', N'Users', CAST(N'2024-12-25T16:30:20.090' AS DateTime), N'Loggned User record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (121, 1, N' Login-User', N'Users', CAST(N'2024-12-25T16:34:37.237' AS DateTime), N'Loggned User record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (122, 1, N' Login-User', N'Users', CAST(N'2024-12-25T16:38:20.510' AS DateTime), N'Loggned User record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (123, 1, N' Login-User', N'Users', CAST(N'2024-12-25T16:42:12.537' AS DateTime), N'Loggned User record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (124, 1, N' Login-User', N'Users', CAST(N'2024-12-25T16:45:49.160' AS DateTime), N'Loggned User record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (125, 1, N' Login-User', N'Users', CAST(N'2024-12-25T16:47:38.870' AS DateTime), N'Loggned User record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (126, 1, N' Login-User', N'Users', CAST(N'2024-12-25T16:53:33.460' AS DateTime), N'Loggned User record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (127, 1, N' Login-User', N'Users', CAST(N'2024-12-25T16:58:45.210' AS DateTime), N'Loggned User record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (128, 1, N' Login-User', N'Users', CAST(N'2024-12-25T17:01:24.240' AS DateTime), N'Loggned User record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (129, 1, N' Login-User', N'Users', CAST(N'2024-12-25T17:04:38.093' AS DateTime), N'Loggned User record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (130, 1, N' Login-User', N'Users', CAST(N'2024-12-25T17:09:46.680' AS DateTime), N'Loggned User record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (131, 1, N' Login-User', N'Users', CAST(N'2024-12-25T17:10:56.320' AS DateTime), N'Loggned User record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (132, 1, N' Login-User', N'Users', CAST(N'2024-12-25T17:13:51.160' AS DateTime), N'Loggned User record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (133, 6, N' Login-User', N'Users', CAST(N'2024-12-25T17:18:07.440' AS DateTime), N'Loggned User record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (134, 7, N' Login-User', N'Users', CAST(N'2024-12-25T17:30:53.500' AS DateTime), N'Loggned User record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (135, 7, N' Login-User', N'Users', CAST(N'2024-12-25T17:33:49.857' AS DateTime), N'Loggned User record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (136, 7, N' Login-User', N'Users', CAST(N'2024-12-25T17:58:33.140' AS DateTime), N'Loggned User record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (137, 7, N' Login-User', N'Users', CAST(N'2024-12-25T18:00:48.597' AS DateTime), N'Loggned User record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (138, 7, N' Login-User', N'Users', CAST(N'2024-12-25T18:03:41.667' AS DateTime), N'Loggned User record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (139, 7, N' Login-User', N'Users', CAST(N'2024-12-25T18:06:05.387' AS DateTime), N'Loggned User record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (140, 8, N' Login-User', N'Users', CAST(N'2024-12-25T18:30:45.147' AS DateTime), N'Loggned User record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (141, 8, N'Add Category', N'Categories', CAST(N'2024-12-25T18:32:30.447' AS DateTime), N'Add Category record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (142, 8, N'Delete', N'Categories', CAST(N'2024-12-25T18:32:42.323' AS DateTime), N'Deleted Category record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (143, 8, N'Added', N'Products', CAST(N'2024-12-25T18:33:33.823' AS DateTime), N'Added record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (144, 8, N'Added', N'Suppliers', CAST(N'2024-12-25T18:35:19.400' AS DateTime), N'Add Supplier record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (145, 8, N' Movement-Added', N'StockMovements', CAST(N'2024-12-25T18:36:16.937' AS DateTime), N'Add StockMovements record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (146, 8, N'Create Order', N'PurchaseOrders', CAST(N'2024-12-25T18:37:24.303' AS DateTime), N'Create PurchaseOrders record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (147, 8, N'Update', N'SalesOrders', CAST(N'2024-12-25T18:38:26.567' AS DateTime), N'Updated record with SalesOrderID = 4')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (148, 8, N'AuditLog', N'AuditLogs', CAST(N'2024-12-25T18:39:13.853' AS DateTime), N'AuditLogs Checking record in Database')
INSERT [dbo].[AuditLogs] ([LogID], [UserID], [Action], [TableAffected], [ActionTime], [Description]) VALUES (149, 7, N' Login-User', N'Users', CAST(N'2024-12-25T19:12:45.523' AS DateTime), N'Loggned User record in Database')
SET IDENTITY_INSERT [dbo].[AuditLogs] OFF
GO
SET IDENTITY_INSERT [dbo].[Categories] ON 

INSERT [dbo].[Categories] ([CategoryID], [CategoryName], [Description]) VALUES (1, N'Mobile_Covers', N'back_covers of all smart phones')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName], [Description]) VALUES (2, N'Airbuds', N'All Types of Airbuds')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName], [Description]) VALUES (6, N'Mobile_Saver', N'Protect glasses of mobiles')
SET IDENTITY_INSERT [dbo].[Categories] OFF
GO
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([ProductID], [ProdName], [SKU], [Category], [Quantity], [UnitPrice], [Barcode], [CreatedAt], [UpdatedAt]) VALUES (1, N'iphone_14', N'ip123', N'Mobile_Covers', 4, CAST(1500.00 AS Decimal(10, 2)), N'456576543456', CAST(N'2024-12-15T15:47:46.217' AS DateTime), CAST(N'2024-12-15T15:47:46.217' AS DateTime))
INSERT [dbo].[Products] ([ProductID], [ProdName], [SKU], [Category], [Quantity], [UnitPrice], [Barcode], [CreatedAt], [UpdatedAt]) VALUES (2, N'iphone_13', N'ip321', N'Mobile_Covers', 3, CAST(1400.00 AS Decimal(10, 2)), N'456576543455', CAST(N'2024-12-15T15:51:27.807' AS DateTime), CAST(N'2024-12-15T15:51:27.807' AS DateTime))
INSERT [dbo].[Products] ([ProductID], [ProdName], [SKU], [Category], [Quantity], [UnitPrice], [Barcode], [CreatedAt], [UpdatedAt]) VALUES (3, N'M10', N'M10-S10', N'Airbuds', 10, CAST(1000.00 AS Decimal(10, 2)), N'67566569865', CAST(N'2024-12-22T13:10:58.940' AS DateTime), CAST(N'2024-12-22T13:10:58.940' AS DateTime))
INSERT [dbo].[Products] ([ProductID], [ProdName], [SKU], [Category], [Quantity], [UnitPrice], [Barcode], [CreatedAt], [UpdatedAt]) VALUES (4, N'M60', N'M60-SMS', N'Airbuds', 20, CAST(1100.00 AS Decimal(10, 2)), N'98765434567', CAST(N'2024-12-22T22:24:38.157' AS DateTime), CAST(N'2024-12-22T22:24:38.157' AS DateTime))
INSERT [dbo].[Products] ([ProductID], [ProdName], [SKU], [Category], [Quantity], [UnitPrice], [Barcode], [CreatedAt], [UpdatedAt]) VALUES (7, N'M12', N'SKU-M12', N'Airbuds', 5, CAST(1100.00 AS Decimal(10, 2)), N'65456787656', CAST(N'2024-12-22T22:48:48.570' AS DateTime), CAST(N'2024-12-22T22:48:48.570' AS DateTime))
INSERT [dbo].[Products] ([ProductID], [ProdName], [SKU], [Category], [Quantity], [UnitPrice], [Barcode], [CreatedAt], [UpdatedAt]) VALUES (9, N'Samsung_S23', N'SS-2345', N'Mobile_Covers', 10, CAST(2000.00 AS Decimal(10, 2)), N'764346466766', CAST(N'2024-12-23T20:42:58.133' AS DateTime), CAST(N'2024-12-23T20:42:58.133' AS DateTime))
INSERT [dbo].[Products] ([ProductID], [ProdName], [SKU], [Category], [Quantity], [UnitPrice], [Barcode], [CreatedAt], [UpdatedAt]) VALUES (10, N'SamsungS21', N'S21_1122', N'Mobile_Saver', 5, CAST(1500.00 AS Decimal(10, 2)), N'87654357675', CAST(N'2024-12-25T18:33:33.803' AS DateTime), CAST(N'2024-12-25T18:33:33.803' AS DateTime))
SET IDENTITY_INSERT [dbo].[Products] OFF
GO
SET IDENTITY_INSERT [dbo].[PurchaseOrderDetails] ON 

INSERT [dbo].[PurchaseOrderDetails] ([PODetailID], [PurchaseOrderID], [ProductID], [Quantity], [UnitPrice]) VALUES (1, 1, 1, 3, CAST(1300.00 AS Decimal(10, 2)))
INSERT [dbo].[PurchaseOrderDetails] ([PODetailID], [PurchaseOrderID], [ProductID], [Quantity], [UnitPrice]) VALUES (3, 3, 3, 3, CAST(1500.00 AS Decimal(10, 2)))
INSERT [dbo].[PurchaseOrderDetails] ([PODetailID], [PurchaseOrderID], [ProductID], [Quantity], [UnitPrice]) VALUES (4, 4, 10, 5, CAST(1800.00 AS Decimal(10, 2)))
SET IDENTITY_INSERT [dbo].[PurchaseOrderDetails] OFF
GO
SET IDENTITY_INSERT [dbo].[PurchaseOrders] ON 

INSERT [dbo].[PurchaseOrders] ([PurchaseOrderID], [SupplierID], [OrderDate], [Status], [TotalAmount]) VALUES (1, 1, CAST(N'2024-12-22T14:18:57.447' AS DateTime), N'Completed', CAST(3600.00 AS Decimal(10, 2)))
INSERT [dbo].[PurchaseOrders] ([PurchaseOrderID], [SupplierID], [OrderDate], [Status], [TotalAmount]) VALUES (3, 2, CAST(N'2024-12-22T22:53:51.737' AS DateTime), N'Pending', CAST(4500.00 AS Decimal(10, 2)))
INSERT [dbo].[PurchaseOrders] ([PurchaseOrderID], [SupplierID], [OrderDate], [Status], [TotalAmount]) VALUES (4, 3, CAST(N'2024-12-25T18:37:22.703' AS DateTime), N'Pending', CAST(9000.00 AS Decimal(10, 2)))
SET IDENTITY_INSERT [dbo].[PurchaseOrders] OFF
GO
SET IDENTITY_INSERT [dbo].[SalesOrderDetails] ON 

INSERT [dbo].[SalesOrderDetails] ([SODetailID], [SalesOrderID], [ProductID], [Quantity], [UnitPrice]) VALUES (2, 2, 3, 3, CAST(1300.00 AS Decimal(10, 2)))
INSERT [dbo].[SalesOrderDetails] ([SODetailID], [SalesOrderID], [ProductID], [Quantity], [UnitPrice]) VALUES (3, 3, 2, 3, CAST(4500.00 AS Decimal(10, 2)))
INSERT [dbo].[SalesOrderDetails] ([SODetailID], [SalesOrderID], [ProductID], [Quantity], [UnitPrice]) VALUES (4, 4, 10, 5, CAST(2000.00 AS Decimal(10, 2)))
SET IDENTITY_INSERT [dbo].[SalesOrderDetails] OFF
GO
SET IDENTITY_INSERT [dbo].[SalesOrders] ON 

INSERT [dbo].[SalesOrders] ([SalesOrderID], [CustomerName], [OrderDate], [Status], [TotalAmount]) VALUES (2, N'Usman Ali', CAST(N'2024-12-22T17:33:25.507' AS DateTime), N'Pending', CAST(3900.00 AS Decimal(10, 2)))
INSERT [dbo].[SalesOrders] ([SalesOrderID], [CustomerName], [OrderDate], [Status], [TotalAmount]) VALUES (3, N'Hamza', CAST(N'2024-12-22T18:44:53.447' AS DateTime), N'Shipped', CAST(13500.00 AS Decimal(10, 2)))
INSERT [dbo].[SalesOrders] ([SalesOrderID], [CustomerName], [OrderDate], [Status], [TotalAmount]) VALUES (4, N'Bilal', CAST(N'2024-12-25T18:38:12.180' AS DateTime), N'Shipped', CAST(10000.00 AS Decimal(10, 2)))
SET IDENTITY_INSERT [dbo].[SalesOrders] OFF
GO
SET IDENTITY_INSERT [dbo].[StockMovements] ON 

INSERT [dbo].[StockMovements] ([MovementID], [ProductID], [MovementType], [Quantity], [MovementDate], [Description]) VALUES (3, 1, N'in', 2, CAST(N'2024-12-15T19:42:37.313' AS DateTime), N'Necessary')
INSERT [dbo].[StockMovements] ([MovementID], [ProductID], [MovementType], [Quantity], [MovementDate], [Description]) VALUES (4, 1, N'in', 2, CAST(N'2024-12-15T19:50:23.137' AS DateTime), N'Necessary')
INSERT [dbo].[StockMovements] ([MovementID], [ProductID], [MovementType], [Quantity], [MovementDate], [Description]) VALUES (5, 1, N'out', 2, CAST(N'2024-12-15T19:51:35.700' AS DateTime), N'Necessary')
INSERT [dbo].[StockMovements] ([MovementID], [ProductID], [MovementType], [Quantity], [MovementDate], [Description]) VALUES (7, 2, N'out', 5, CAST(N'2024-12-25T18:36:15.260' AS DateTime), N'good')
SET IDENTITY_INSERT [dbo].[StockMovements] OFF
GO
SET IDENTITY_INSERT [dbo].[Suppliers] ON 

INSERT [dbo].[Suppliers] ([SupplierID], [SupplierName], [ContactName], [Phone], [Email], [Address]) VALUES (1, N'Zain Ali', N'Usman Jutt', N'03456754643', N'zain.ali54@gmail.com', N'Near Nishtar Hospital Multan Pakistan')
INSERT [dbo].[Suppliers] ([SupplierID], [SupplierName], [ContactName], [Phone], [Email], [Address]) VALUES (2, N'Usman Butt', N'Umar Jutt', N'03125436245', N'usmanbutt354@gmail.com', N'Basti Malook Multan')
INSERT [dbo].[Suppliers] ([SupplierID], [SupplierName], [ContactName], [Phone], [Email], [Address]) VALUES (3, N'Ali Hamza', N'Usman Shah', N'03457654345', N'Ali@7658gmail.com', N'Multan Vehari Chowk')
SET IDENTITY_INSERT [dbo].[Suppliers] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([UserID], [Username], [PasswordHash], [Role], [CreatedAt]) VALUES (1, N'Ali', N'dbd0b5699c99a8a9d244d22a61c537ccf3521ed9f77feeeb84335256f5d807bb', N'Manager', CAST(N'2024-12-15T00:24:15.940' AS DateTime))
INSERT [dbo].[Users] ([UserID], [Username], [PasswordHash], [Role], [CreatedAt]) VALUES (2, N'Ahmad', N'TQVYH/K1reOBrcpmHdldSrYX7OMRT/gpfaip5hZh01U=', N'Manager', CAST(N'2024-12-15T00:44:45.737' AS DateTime))
INSERT [dbo].[Users] ([UserID], [Username], [PasswordHash], [Role], [CreatedAt]) VALUES (3, N'Bilal', N'', N'Staff', CAST(N'2024-12-15T01:05:41.123' AS DateTime))
INSERT [dbo].[Users] ([UserID], [Username], [PasswordHash], [Role], [CreatedAt]) VALUES (4, N'AliBro', N'O2Esdae1BIpDX7bsgeUv+S1teVqLWpwXBw9qY8l6U7I=', N'Staff', CAST(N'2024-12-15T01:19:30.013' AS DateTime))
INSERT [dbo].[Users] ([UserID], [Username], [PasswordHash], [Role], [CreatedAt]) VALUES (5, N'Adminbro', N'YP50QG5/NT7ZefNQ8vu2ouhpCl+n0bDDKYPR2LP5X2c=', N'Admin', CAST(N'2024-12-22T22:23:03.520' AS DateTime))
INSERT [dbo].[Users] ([UserID], [Username], [PasswordHash], [Role], [CreatedAt]) VALUES (6, N'hi', N'7d421742e8220be4fd61698494619a5f3c29fe9bd945bd1446ba4c2213efbd60', N'Admin', CAST(N'2024-12-25T17:17:53.060' AS DateTime))
INSERT [dbo].[Users] ([UserID], [Username], [PasswordHash], [Role], [CreatedAt]) VALUES (7, N'Bilalg', N'YP50QG5/NT7ZefNQ8vu2ouhpCl+n0bDDKYPR2LP5X2c=', N'Admin', CAST(N'2024-12-25T17:30:20.503' AS DateTime))
INSERT [dbo].[Users] ([UserID], [Username], [PasswordHash], [Role], [CreatedAt]) VALUES (8, N'hig', N'yaRiXn64Cl6rEl/0krN/dBsb5C1fI5hQzwNf8O5sXsc=', N'Staff', CAST(N'2024-12-25T18:30:21.203' AS DateTime))
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Categories]    Script Date: 12/25/2024 8:10:21 PM ******/
ALTER TABLE [dbo].[Categories] ADD  CONSTRAINT [IX_Categories] UNIQUE NONCLUSTERED 
(
	[CategoryName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Products]    Script Date: 12/25/2024 8:10:21 PM ******/
ALTER TABLE [dbo].[Products] ADD  CONSTRAINT [IX_Products] UNIQUE NONCLUSTERED 
(
	[SKU] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[AuditLogs] ADD  CONSTRAINT [DF_AuditLogs_ActionTime]  DEFAULT (getdate()) FOR [ActionTime]
GO
ALTER TABLE [dbo].[Products] ADD  CONSTRAINT [DF_Products_Quantity]  DEFAULT ((0)) FOR [Quantity]
GO
ALTER TABLE [dbo].[Products] ADD  CONSTRAINT [DF_Products_CreatedAt]  DEFAULT (getdate()) FOR [CreatedAt]
GO
ALTER TABLE [dbo].[Products] ADD  CONSTRAINT [DF_Products_UpdatedAt]  DEFAULT (getdate()) FOR [UpdatedAt]
GO
ALTER TABLE [dbo].[PurchaseOrders] ADD  CONSTRAINT [DF_PurchaseOrders_OrderDate]  DEFAULT (getdate()) FOR [OrderDate]
GO
ALTER TABLE [dbo].[SalesOrders] ADD  CONSTRAINT [DF_SalesOrders_OrderDate]  DEFAULT (getdate()) FOR [OrderDate]
GO
ALTER TABLE [dbo].[StockMovements] ADD  CONSTRAINT [DF_StockMovements_MovementDate]  DEFAULT (getdate()) FOR [MovementDate]
GO
ALTER TABLE [dbo].[Users] ADD  CONSTRAINT [DF_Users_CreatedAt]  DEFAULT (getdate()) FOR [CreatedAt]
GO
ALTER TABLE [dbo].[AuditLogs]  WITH CHECK ADD  CONSTRAINT [FK_AuditLogs_Users] FOREIGN KEY([UserID])
REFERENCES [dbo].[Users] ([UserID])
GO
ALTER TABLE [dbo].[AuditLogs] CHECK CONSTRAINT [FK_AuditLogs_Users]
GO
ALTER TABLE [dbo].[PurchaseOrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_PurchaseOrderDetails_Products] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Products] ([ProductID])
GO
ALTER TABLE [dbo].[PurchaseOrderDetails] CHECK CONSTRAINT [FK_PurchaseOrderDetails_Products]
GO
ALTER TABLE [dbo].[PurchaseOrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_PurchaseOrderDetails_PurchaseOrders] FOREIGN KEY([PurchaseOrderID])
REFERENCES [dbo].[PurchaseOrders] ([PurchaseOrderID])
GO
ALTER TABLE [dbo].[PurchaseOrderDetails] CHECK CONSTRAINT [FK_PurchaseOrderDetails_PurchaseOrders]
GO
ALTER TABLE [dbo].[PurchaseOrders]  WITH CHECK ADD  CONSTRAINT [FK_PurchaseOrders_Suppliers] FOREIGN KEY([SupplierID])
REFERENCES [dbo].[Suppliers] ([SupplierID])
GO
ALTER TABLE [dbo].[PurchaseOrders] CHECK CONSTRAINT [FK_PurchaseOrders_Suppliers]
GO
ALTER TABLE [dbo].[SalesOrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_SalesOrderDetails_Products] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Products] ([ProductID])
GO
ALTER TABLE [dbo].[SalesOrderDetails] CHECK CONSTRAINT [FK_SalesOrderDetails_Products]
GO
ALTER TABLE [dbo].[SalesOrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_SalesOrderDetails_SalesOrders] FOREIGN KEY([SalesOrderID])
REFERENCES [dbo].[SalesOrders] ([SalesOrderID])
GO
ALTER TABLE [dbo].[SalesOrderDetails] CHECK CONSTRAINT [FK_SalesOrderDetails_SalesOrders]
GO
ALTER TABLE [dbo].[StockMovements]  WITH CHECK ADD  CONSTRAINT [FK_StockMovements_Products] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Products] ([ProductID])
GO
ALTER TABLE [dbo].[StockMovements] CHECK CONSTRAINT [FK_StockMovements_Products]
GO
ALTER TABLE [dbo].[PurchaseOrders]  WITH CHECK ADD  CONSTRAINT [CK_PurchaseOrders] CHECK  (([Status]='Cancelled' OR [Status]='Completed' OR [Status]='Pending'))
GO
ALTER TABLE [dbo].[PurchaseOrders] CHECK CONSTRAINT [CK_PurchaseOrders]
GO
ALTER TABLE [dbo].[SalesOrders]  WITH CHECK ADD  CONSTRAINT [CK_SalesOrders] CHECK  (([Status]='Cancelled' OR [Status]='Shipped' OR [Status]='Pending'))
GO
ALTER TABLE [dbo].[SalesOrders] CHECK CONSTRAINT [CK_SalesOrders]
GO
ALTER TABLE [dbo].[StockMovements]  WITH CHECK ADD  CONSTRAINT [CK_StockMovements] CHECK  (([MovementType]='ADJUSTMENT' OR [MovementType]='OUT' OR [MovementType]='IN'))
GO
ALTER TABLE [dbo].[StockMovements] CHECK CONSTRAINT [CK_StockMovements]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [CK_Users] CHECK  (([Role]='Staff' OR [Role]='Manager' OR [Role]='Admin'))
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [CK_Users]
GO
USE [master]
GO
ALTER DATABASE [Inventory_Management_System] SET  READ_WRITE 
GO
