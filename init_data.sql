USE [master]
GO
/****** Object:  Database [QLNV]    Script Date: 5/28/2022 3:21:42 PM ******/
CREATE DATABASE [QLNV]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLNV', FILENAME = N'/var/opt/mssql/data/QLNV.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QLNV_log', FILENAME = N'/var/opt/mssql/data/QLNV_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [QLNV] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLNV].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLNV] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLNV] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLNV] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLNV] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLNV] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLNV] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLNV] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLNV] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLNV] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLNV] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLNV] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLNV] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLNV] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLNV] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLNV] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QLNV] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLNV] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLNV] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLNV] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLNV] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLNV] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLNV] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLNV] SET RECOVERY FULL 
GO
ALTER DATABASE [QLNV] SET  MULTI_USER 
GO
ALTER DATABASE [QLNV] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLNV] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLNV] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLNV] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QLNV] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QLNV] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'QLNV', N'ON'
GO
ALTER DATABASE [QLNV] SET QUERY_STORE = OFF
GO
USE [QLNV]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 5/28/2022 3:21:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[account_name] [varchar](255) NULL,
	[password] [varchar](255) NULL,
	[account_type_id] [int] NULL,
	[group_type_id] [int] NULL,
	[validated] [bit] NULL,
	[blocked] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 5/28/2022 3:21:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[code] [varchar](255) NULL,
	[name] [nvarchar](max) NULL,
	[is_system_category] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CategoryDetail]    Script Date: 5/28/2022 3:21:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CategoryDetail](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[code] [varchar](255) NULL,
	[name] [nvarchar](max) NULL,
	[category_id] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SalaryProcess]    Script Date: 5/28/2022 3:21:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SalaryProcess](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[staff_info_id] [int] NULL,
	[title] [varchar](25) NULL,
	[is_paid] [bit] NULL,
	[payment_date] [varchar](25) NULL,
	[salary] [decimal](18, 0) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StaffInfo]    Script Date: 5/28/2022 3:21:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StaffInfo](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[code] [varchar](255) NULL,
	[name] [nvarchar](255) NULL,
	[birth_date] [varchar](25) NULL,
	[birth_place] [nvarchar](255) NULL,
	[email] [varchar](255) NULL,
	[start_working_date] [varchar](25) NULL,
	[working_status] [bit] NULL,
	[end_working_date] [varchar](25) NULL,
	[basic_salary_amount] [decimal](18, 0) NULL,
	[insurance_amount] [decimal](18, 0) NULL,
	[allowance_amount] [decimal](18, 0) NULL,
	[department_id] [int] NULL,
	[position_id] [int] NULL,
	[account_id] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TimekeepingProcess]    Script Date: 5/28/2022 3:21:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TimekeepingProcess](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[staff_info_id] [int] NULL,
	[timekeeping_date] [varchar](25) NULL,
	[timekeeping_status] [bit] NULL,
	[evaluated_by_id] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Account] ON 

INSERT [dbo].[Account] ([id], [account_name], [password], [account_type_id], [group_type_id], [validated], [blocked]) VALUES (3, N'admin@gmail.com', N'$2a$11$sKKkRXeOBoguah9XoiXI.ODieGpEfiwEzLkmBZ1lhxS/GGQzsW8Cu', 1, 3, 1, 0)
INSERT [dbo].[Account] ([id], [account_name], [password], [account_type_id], [group_type_id], [validated], [blocked]) VALUES (2002, N'balebom@gmail.com', N'$2a$11$cAj.78KuZc75V9QPlNMr.eN52zx3WGXkR.H2VDPeFy2.GJcE7SP/S', 2, 4, 1, 0)
INSERT [dbo].[Account] ([id], [account_name], [password], [account_type_id], [group_type_id], [validated], [blocked]) VALUES (3002, N'bombeo@gmail.com', N'$2a$11$vNfeK0UPVXEoIEq9eVfz3emQMaieS1Sb0PDIArVB0LEHNQBXDvSMa', 2, 5, 0, 0)
SET IDENTITY_INSERT [dbo].[Account] OFF
GO
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([id], [code], [name], [is_system_category]) VALUES (1, N'01', N'Danh mục Loại tài khoản', 1)
INSERT [dbo].[Category] ([id], [code], [name], [is_system_category]) VALUES (2, N'02', N'Danh mục Nhóm tài khoản', 1)
INSERT [dbo].[Category] ([id], [code], [name], [is_system_category]) VALUES (3, N'03', N'Danh mục Phòng ban', 1)
INSERT [dbo].[Category] ([id], [code], [name], [is_system_category]) VALUES (4, N'04', N'Danh mục Chức vụ', 1)
SET IDENTITY_INSERT [dbo].[Category] OFF
GO
SET IDENTITY_INSERT [dbo].[CategoryDetail] ON 

INSERT [dbo].[CategoryDetail] ([id], [code], [name], [category_id]) VALUES (1, N'01', N'Admin', 1)
INSERT [dbo].[CategoryDetail] ([id], [code], [name], [category_id]) VALUES (2, N'02', N'User', 1)
INSERT [dbo].[CategoryDetail] ([id], [code], [name], [category_id]) VALUES (3, N'01', N'Nhóm supper user', 2)
INSERT [dbo].[CategoryDetail] ([id], [code], [name], [category_id]) VALUES (4, N'02', N'Nhóm quản trị', 2)
INSERT [dbo].[CategoryDetail] ([id], [code], [name], [category_id]) VALUES (5, N'03', N'Nhóm người dùng', 2)
INSERT [dbo].[CategoryDetail] ([id], [code], [name], [category_id]) VALUES (6, N'01', N'Phòng nhân sự', 3)
INSERT [dbo].[CategoryDetail] ([id], [code], [name], [category_id]) VALUES (7, N'02', N'Phòng kỹ thuật', 3)
INSERT [dbo].[CategoryDetail] ([id], [code], [name], [category_id]) VALUES (8, N'01', N'Trưởng phòng', 4)
INSERT [dbo].[CategoryDetail] ([id], [code], [name], [category_id]) VALUES (9, N'02', N'Phó phòng', 4)
SET IDENTITY_INSERT [dbo].[CategoryDetail] OFF
GO
SET IDENTITY_INSERT [dbo].[SalaryProcess] ON 

INSERT [dbo].[SalaryProcess] ([id], [staff_info_id], [title], [is_paid], [payment_date], [salary]) VALUES (2, 1002, N'05/2022', 1, N'Thursday, May 26, 2022', CAST(6300000 AS Decimal(18, 0)))
INSERT [dbo].[SalaryProcess] ([id], [staff_info_id], [title], [is_paid], [payment_date], [salary]) VALUES (3, 1002, N'06/2022', 0, N'', CAST(6300000 AS Decimal(18, 0)))
SET IDENTITY_INSERT [dbo].[SalaryProcess] OFF
GO
SET IDENTITY_INSERT [dbo].[StaffInfo] ON 

INSERT [dbo].[StaffInfo] ([id], [code], [name], [birth_date], [birth_place], [email], [start_working_date], [working_status], [end_working_date], [basic_salary_amount], [insurance_amount], [allowance_amount], [department_id], [position_id], [account_id]) VALUES (2002, N'NV00001', N'Balebom', N'1999-05-08', N'An Giang', N'balebom@gmail.com', N'2021-02-26', 1, N'2022-05-26', CAST(4000000 AS Decimal(18, 0)), CAST(300000 AS Decimal(18, 0)), CAST(200000 AS Decimal(18, 0)), 6, 8, 2002)
INSERT [dbo].[StaffInfo] ([id], [code], [name], [birth_date], [birth_place], [email], [start_working_date], [working_status], [end_working_date], [basic_salary_amount], [insurance_amount], [allowance_amount], [department_id], [position_id], [account_id]) VALUES (3002, N'NV000002', N'Bombeo', N'1999-05-08', N'An Giang', N'bombeo@gmail.com', N'2005-05-28', 1, N'2022-05-28', CAST(6000000 AS Decimal(18, 0)), CAST(3000000 AS Decimal(18, 0)), CAST(1000000 AS Decimal(18, 0)), 6, 8, 3002)
SET IDENTITY_INSERT [dbo].[StaffInfo] OFF
GO
SET IDENTITY_INSERT [dbo].[TimekeepingProcess] ON 

INSERT [dbo].[TimekeepingProcess] ([id], [staff_info_id], [timekeeping_date], [timekeeping_status], [evaluated_by_id]) VALUES (1, 1002, N'02/05/2022', 1, 3)
INSERT [dbo].[TimekeepingProcess] ([id], [staff_info_id], [timekeeping_date], [timekeeping_status], [evaluated_by_id]) VALUES (2, 1002, N'03/05/2022', 1, 3)
INSERT [dbo].[TimekeepingProcess] ([id], [staff_info_id], [timekeeping_date], [timekeeping_status], [evaluated_by_id]) VALUES (3, 1002, N'04/05/2022', 1, 3)
INSERT [dbo].[TimekeepingProcess] ([id], [staff_info_id], [timekeeping_date], [timekeeping_status], [evaluated_by_id]) VALUES (4, 1002, N'05/05/2022', 1, 3)
INSERT [dbo].[TimekeepingProcess] ([id], [staff_info_id], [timekeeping_date], [timekeeping_status], [evaluated_by_id]) VALUES (5, 1002, N'01/05/2022', 1, 3)
INSERT [dbo].[TimekeepingProcess] ([id], [staff_info_id], [timekeeping_date], [timekeeping_status], [evaluated_by_id]) VALUES (6, 1002, N'06/05/2022', 1, 3)
INSERT [dbo].[TimekeepingProcess] ([id], [staff_info_id], [timekeeping_date], [timekeeping_status], [evaluated_by_id]) VALUES (7, 1002, N'07/05/2022', 1, 3)
INSERT [dbo].[TimekeepingProcess] ([id], [staff_info_id], [timekeeping_date], [timekeeping_status], [evaluated_by_id]) VALUES (8, 1002, N'14/05/2022', 0, 3)
INSERT [dbo].[TimekeepingProcess] ([id], [staff_info_id], [timekeeping_date], [timekeeping_status], [evaluated_by_id]) VALUES (9, 1002, N'13/05/2022', 0, 3)
INSERT [dbo].[TimekeepingProcess] ([id], [staff_info_id], [timekeeping_date], [timekeeping_status], [evaluated_by_id]) VALUES (10, 1002, N'12/05/2022', 1, 3)
INSERT [dbo].[TimekeepingProcess] ([id], [staff_info_id], [timekeeping_date], [timekeeping_status], [evaluated_by_id]) VALUES (11, 1002, N'11/05/2022', 1, 3)
INSERT [dbo].[TimekeepingProcess] ([id], [staff_info_id], [timekeeping_date], [timekeeping_status], [evaluated_by_id]) VALUES (12, 1002, N'10/05/2022', 1, 3)
INSERT [dbo].[TimekeepingProcess] ([id], [staff_info_id], [timekeeping_date], [timekeeping_status], [evaluated_by_id]) VALUES (13, 1002, N'09/05/2022', 1, 3)
INSERT [dbo].[TimekeepingProcess] ([id], [staff_info_id], [timekeeping_date], [timekeeping_status], [evaluated_by_id]) VALUES (14, 1002, N'08/05/2022', 1, 3)
INSERT [dbo].[TimekeepingProcess] ([id], [staff_info_id], [timekeeping_date], [timekeeping_status], [evaluated_by_id]) VALUES (15, 1002, N'15/05/2022', 1, 3)
INSERT [dbo].[TimekeepingProcess] ([id], [staff_info_id], [timekeeping_date], [timekeeping_status], [evaluated_by_id]) VALUES (16, 1002, N'16/05/2022', 1, 3)
INSERT [dbo].[TimekeepingProcess] ([id], [staff_info_id], [timekeeping_date], [timekeeping_status], [evaluated_by_id]) VALUES (17, 1002, N'17/05/2022', 1, 3)
INSERT [dbo].[TimekeepingProcess] ([id], [staff_info_id], [timekeeping_date], [timekeeping_status], [evaluated_by_id]) VALUES (18, 1002, N'18/05/2022', 1, 3)
INSERT [dbo].[TimekeepingProcess] ([id], [staff_info_id], [timekeeping_date], [timekeeping_status], [evaluated_by_id]) VALUES (19, 1002, N'19/05/2022', 1, 3)
INSERT [dbo].[TimekeepingProcess] ([id], [staff_info_id], [timekeeping_date], [timekeeping_status], [evaluated_by_id]) VALUES (20, 1002, N'20/05/2022', 1, 3)
INSERT [dbo].[TimekeepingProcess] ([id], [staff_info_id], [timekeeping_date], [timekeeping_status], [evaluated_by_id]) VALUES (21, 1002, N'21/05/2022', 1, 3)
INSERT [dbo].[TimekeepingProcess] ([id], [staff_info_id], [timekeeping_date], [timekeeping_status], [evaluated_by_id]) VALUES (22, 1002, N'28/05/2022', 1, 3)
INSERT [dbo].[TimekeepingProcess] ([id], [staff_info_id], [timekeeping_date], [timekeeping_status], [evaluated_by_id]) VALUES (23, 1002, N'27/05/2022', 1, 3)
INSERT [dbo].[TimekeepingProcess] ([id], [staff_info_id], [timekeeping_date], [timekeeping_status], [evaluated_by_id]) VALUES (24, 1002, N'26/05/2022', 1, 3)
INSERT [dbo].[TimekeepingProcess] ([id], [staff_info_id], [timekeeping_date], [timekeeping_status], [evaluated_by_id]) VALUES (25, 1002, N'25/05/2022', 1, 3)
INSERT [dbo].[TimekeepingProcess] ([id], [staff_info_id], [timekeeping_date], [timekeeping_status], [evaluated_by_id]) VALUES (26, 1002, N'24/05/2022', 0, 3)
INSERT [dbo].[TimekeepingProcess] ([id], [staff_info_id], [timekeeping_date], [timekeeping_status], [evaluated_by_id]) VALUES (27, 1002, N'23/05/2022', 0, 3)
INSERT [dbo].[TimekeepingProcess] ([id], [staff_info_id], [timekeeping_date], [timekeeping_status], [evaluated_by_id]) VALUES (28, 1002, N'22/05/2022', 1, 3)
INSERT [dbo].[TimekeepingProcess] ([id], [staff_info_id], [timekeeping_date], [timekeeping_status], [evaluated_by_id]) VALUES (29, 1002, N'29/05/2022', 0, 3)
INSERT [dbo].[TimekeepingProcess] ([id], [staff_info_id], [timekeeping_date], [timekeeping_status], [evaluated_by_id]) VALUES (30, 1002, N'30/05/2022', 1, 3)
INSERT [dbo].[TimekeepingProcess] ([id], [staff_info_id], [timekeeping_date], [timekeeping_status], [evaluated_by_id]) VALUES (31, 1002, N'31/05/2022', 1, 3)
INSERT [dbo].[TimekeepingProcess] ([id], [staff_info_id], [timekeeping_date], [timekeeping_status], [evaluated_by_id]) VALUES (45, 1002, N'01/06/2022', 1, 3)
INSERT [dbo].[TimekeepingProcess] ([id], [staff_info_id], [timekeeping_date], [timekeeping_status], [evaluated_by_id]) VALUES (46, 1002, N'02/06/2022', 1, 3)
INSERT [dbo].[TimekeepingProcess] ([id], [staff_info_id], [timekeeping_date], [timekeeping_status], [evaluated_by_id]) VALUES (47, 1002, N'03/06/2022', 1, 3)
INSERT [dbo].[TimekeepingProcess] ([id], [staff_info_id], [timekeeping_date], [timekeeping_status], [evaluated_by_id]) VALUES (48, 1002, N'04/06/2022', 1, 3)
INSERT [dbo].[TimekeepingProcess] ([id], [staff_info_id], [timekeeping_date], [timekeeping_status], [evaluated_by_id]) VALUES (49, 1002, N'05/06/2022', 1, 3)
INSERT [dbo].[TimekeepingProcess] ([id], [staff_info_id], [timekeeping_date], [timekeeping_status], [evaluated_by_id]) VALUES (50, 1002, N'06/06/2022', 1, 3)
INSERT [dbo].[TimekeepingProcess] ([id], [staff_info_id], [timekeeping_date], [timekeeping_status], [evaluated_by_id]) VALUES (51, 1002, N'07/06/2022', 1, 3)
INSERT [dbo].[TimekeepingProcess] ([id], [staff_info_id], [timekeeping_date], [timekeeping_status], [evaluated_by_id]) VALUES (52, 1002, N'08/06/2022', 1, 3)
INSERT [dbo].[TimekeepingProcess] ([id], [staff_info_id], [timekeeping_date], [timekeeping_status], [evaluated_by_id]) VALUES (53, 1002, N'09/06/2022', 1, 3)
INSERT [dbo].[TimekeepingProcess] ([id], [staff_info_id], [timekeeping_date], [timekeeping_status], [evaluated_by_id]) VALUES (54, 1002, N'10/06/2022', 1, 3)
INSERT [dbo].[TimekeepingProcess] ([id], [staff_info_id], [timekeeping_date], [timekeeping_status], [evaluated_by_id]) VALUES (55, 1002, N'11/06/2022', 1, 3)
INSERT [dbo].[TimekeepingProcess] ([id], [staff_info_id], [timekeeping_date], [timekeeping_status], [evaluated_by_id]) VALUES (56, 1002, N'12/06/2022', 1, 3)
INSERT [dbo].[TimekeepingProcess] ([id], [staff_info_id], [timekeeping_date], [timekeeping_status], [evaluated_by_id]) VALUES (57, 1002, N'13/06/2022', 1, 3)
INSERT [dbo].[TimekeepingProcess] ([id], [staff_info_id], [timekeeping_date], [timekeeping_status], [evaluated_by_id]) VALUES (58, 1002, N'14/06/2022', 1, 3)
INSERT [dbo].[TimekeepingProcess] ([id], [staff_info_id], [timekeeping_date], [timekeeping_status], [evaluated_by_id]) VALUES (59, 1002, N'15/06/2022', 1, 3)
INSERT [dbo].[TimekeepingProcess] ([id], [staff_info_id], [timekeeping_date], [timekeeping_status], [evaluated_by_id]) VALUES (60, 1002, N'17/06/2022', 1, 3)
INSERT [dbo].[TimekeepingProcess] ([id], [staff_info_id], [timekeeping_date], [timekeeping_status], [evaluated_by_id]) VALUES (61, 1002, N'16/06/2022', 1, 3)
INSERT [dbo].[TimekeepingProcess] ([id], [staff_info_id], [timekeeping_date], [timekeeping_status], [evaluated_by_id]) VALUES (62, 1002, N'18/06/2022', 1, 3)
INSERT [dbo].[TimekeepingProcess] ([id], [staff_info_id], [timekeeping_date], [timekeeping_status], [evaluated_by_id]) VALUES (63, 1002, N'19/06/2022', 1, 3)
INSERT [dbo].[TimekeepingProcess] ([id], [staff_info_id], [timekeeping_date], [timekeeping_status], [evaluated_by_id]) VALUES (64, 1002, N'20/06/2022', 1, 3)
INSERT [dbo].[TimekeepingProcess] ([id], [staff_info_id], [timekeeping_date], [timekeeping_status], [evaluated_by_id]) VALUES (65, 1002, N'21/06/2022', 1, 3)
INSERT [dbo].[TimekeepingProcess] ([id], [staff_info_id], [timekeeping_date], [timekeeping_status], [evaluated_by_id]) VALUES (66, 1002, N'22/06/2022', 1, 3)
INSERT [dbo].[TimekeepingProcess] ([id], [staff_info_id], [timekeeping_date], [timekeeping_status], [evaluated_by_id]) VALUES (67, 1002, N'23/06/2022', 1, 3)
INSERT [dbo].[TimekeepingProcess] ([id], [staff_info_id], [timekeeping_date], [timekeeping_status], [evaluated_by_id]) VALUES (68, 1002, N'24/06/2022', 1, 3)
INSERT [dbo].[TimekeepingProcess] ([id], [staff_info_id], [timekeeping_date], [timekeeping_status], [evaluated_by_id]) VALUES (69, 1002, N'25/06/2022', 1, 3)
INSERT [dbo].[TimekeepingProcess] ([id], [staff_info_id], [timekeeping_date], [timekeeping_status], [evaluated_by_id]) VALUES (70, 1002, N'26/06/2022', 1, 3)
INSERT [dbo].[TimekeepingProcess] ([id], [staff_info_id], [timekeeping_date], [timekeeping_status], [evaluated_by_id]) VALUES (71, 1002, N'27/06/2022', 1, 3)
SET IDENTITY_INSERT [dbo].[TimekeepingProcess] OFF
GO
USE [master]
GO
ALTER DATABASE [QLNV] SET  READ_WRITE 
GO
