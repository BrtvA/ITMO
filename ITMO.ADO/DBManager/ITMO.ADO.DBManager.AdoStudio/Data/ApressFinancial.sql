USE [master]
GO
/****** Object:  Database [ApressFinancial]    Script Date: 01.02.2023 23:21:52 ******/
CREATE DATABASE [ApressFinancial]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ApressFinancial', FILENAME = N'C:\Users\Apanasevich\ApressFinancial.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB ), 
 FILEGROUP [SECONDARY] 
( NAME = N'ApressFinancial_act', FILENAME = N'C:\Users\Apanasevich\ApressFinancial_act.ndf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'ApessFinancial_log', FILENAME = N'C:\Users\Apanasevich\ApressFinancial_log.ldf' , SIZE = 3072KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [ApressFinancial] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ApressFinancial].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ApressFinancial] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ApressFinancial] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ApressFinancial] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ApressFinancial] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ApressFinancial] SET ARITHABORT OFF 
GO
ALTER DATABASE [ApressFinancial] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [ApressFinancial] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ApressFinancial] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ApressFinancial] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ApressFinancial] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ApressFinancial] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ApressFinancial] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ApressFinancial] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ApressFinancial] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ApressFinancial] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ApressFinancial] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ApressFinancial] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ApressFinancial] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ApressFinancial] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ApressFinancial] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ApressFinancial] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ApressFinancial] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ApressFinancial] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ApressFinancial] SET  MULTI_USER 
GO
ALTER DATABASE [ApressFinancial] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ApressFinancial] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ApressFinancial] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ApressFinancial] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ApressFinancial] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ApressFinancial] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [ApressFinancial] SET QUERY_STORE = OFF
GO
USE [ApressFinancial]
GO
/****** Object:  User [user1]    Script Date: 01.02.2023 23:21:52 ******/
CREATE USER [user1] FOR LOGIN [user1] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Schema [CustomerDetails]    Script Date: 01.02.2023 23:21:52 ******/
CREATE SCHEMA [CustomerDetails]
GO
/****** Object:  Schema [ShareDetails]    Script Date: 01.02.2023 23:21:52 ******/
CREATE SCHEMA [ShareDetails]
GO
/****** Object:  Schema [TransactionDetails]    Script Date: 01.02.2023 23:21:52 ******/
CREATE SCHEMA [TransactionDetails]
GO
/****** Object:  UserDefinedFunction [TransactionDetails].[ufn_IntCalc]    Script Date: 01.02.2023 23:21:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [TransactionDetails].[ufn_IntCalc]
	(@InterestRate decimal(6,3)=10, 
	 @Amount decimal(18,5),
	 @FromDate date, 
	 @ToDate date)
RETURNS decimal(18,5)
WITH EXECUTE AS CALLER
AS
BEGIN
	DECLARE @IntCalculated decimal(18,5)
	SELECT @IntCalculated = @Amount *
							(@InterestRate / 100.00) * 
							( DATEDIFF(d,@FromDate,@ToDate)/365.00)
	RETURN (ISNULL(@IntCalculated,0))
END;
GO
/****** Object:  UserDefinedFunction [TransactionDetails].[ufn_ReturnTransactions]    Script Date: 01.02.2023 23:21:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [TransactionDetails].[ufn_ReturnTransactions] (@CustID bigint)
RETURNS @Trans TABLE (TransactionId bigint,
					  CustomerId bigint,
					  TransactionDescription nvarchar(30),
					  DateEntered datetime,
					  Amount money)
AS
BEGIN
	INSERT INTO @Trans
	SELECT TransactionId
		  ,CustomerId
		  ,TransactionDescription
		  ,DateEntered
		  ,Amount
	FROM TransactionDetails.Transactions AS t
		JOIN TransactionDetails.TransactionTypes AS tt
	ON tt.TransactionTypesId = t.TransactionType
	WHERE CustomerId = @CustID
	RETURN
END;
GO
/****** Object:  Table [ShareDetails].[Shares]    Script Date: 01.02.2023 23:21:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [ShareDetails].[Shares](
	[ShareID] [bigint] IDENTITY(1,1) NOT NULL,
	[ShareDesc] [nvarchar](50) NOT NULL,
	[ShareTickerID] [nvarchar](50) NULL,
	[CurrentPrice] [numeric](18, 5) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  View [ShareDetails].[v_CurrentShares]    Script Date: 01.02.2023 23:21:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [ShareDetails].[v_CurrentShares]
AS
SELECT        TOP (100) PERCENT ShareID, ShareDesc, ShareTickerID, CurrentPrice AS LastPrice
FROM            ShareDetails.Shares
WHERE        (CurrentPrice > 0)
ORDER BY ShareDesc
GO
/****** Object:  Table [ShareDetails].[SharePrices]    Script Date: 01.02.2023 23:21:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [ShareDetails].[SharePrices](
	[SharePriceID] [bigint] IDENTITY(1,1) NOT NULL,
	[ShareID] [bigint] NOT NULL,
	[Price] [numeric](18, 5) NOT NULL,
	[PriceDate] [datetime] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  View [ShareDetails].[v_SharePrices]    Script Date: 01.02.2023 23:21:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [ShareDetails].[v_SharePrices]
AS
SELECT        TOP (100) PERCENT ShareDetails.SharePrices.ShareID, ShareDetails.SharePrices.Price, ShareDetails.SharePrices.PriceDate, ShareDetails.v_CurrentShares.ShareDesc
FROM            ShareDetails.SharePrices INNER JOIN
                         ShareDetails.v_CurrentShares ON ShareDetails.SharePrices.ShareID = ShareDetails.v_CurrentShares.ShareID
ORDER BY ShareDetails.v_CurrentShares.ShareDesc, ShareDetails.SharePrices.PriceDate DESC
GO
/****** Object:  Table [CustomerDetails].[Customers]    Script Date: 01.02.2023 23:21:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [CustomerDetails].[Customers](
	[CustomerId] [bigint] IDENTITY(1,1) NOT NULL,
	[CustomerTitleId] [int] NOT NULL,
	[CustomerFirstName] [nvarchar](50) NOT NULL,
	[CustomerOtherInitials] [nvarchar](10) NULL,
	[CustomerLastName] [nvarchar](50) NOT NULL,
	[AddressId] [bigint] NOT NULL,
	[AccountNumber] [nchar](15) NOT NULL,
	[AccountTypeId] [int] NOT NULL,
	[CleareBalance] [money] NOT NULL,
	[UncleareBalance] [money] NOT NULL,
	[DateAdded] [date] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [TransactionDetails].[Transactions]    Script Date: 01.02.2023 23:21:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [TransactionDetails].[Transactions](
	[TransactionId] [bigint] IDENTITY(1,1) NOT NULL,
	[CustomerId] [bigint] NOT NULL,
	[TransactionType] [int] NOT NULL,
	[DateEntered] [datetime] NOT NULL,
	[Amount] [numeric](18, 5) NOT NULL,
	[ReferenceDetails] [nvarchar](50) NULL,
	[Notes] [nvarchar](max) NULL,
	[RelatedShareId] [bigint] NULL,
	[RelatedProductId] [bigint] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[TransactionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [TransactionDetails].[TransactionTypes]    Script Date: 01.02.2023 23:21:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [TransactionDetails].[TransactionTypes](
	[TransactionTypesId] [int] IDENTITY(1,1) NOT NULL,
	[TransactionDescription] [nvarchar](30) NOT NULL,
	[CreditType] [bit] NOT NULL,
	[AffectCashBalance] [bit] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Index [IX_TransactionTypes]    Script Date: 01.02.2023 23:21:52 ******/
CREATE UNIQUE CLUSTERED INDEX [IX_TransactionTypes] ON [TransactionDetails].[TransactionTypes]
(
	[TransactionTypesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  View [CustomerDetails].[v_CustTrans]    Script Date: 01.02.2023 23:21:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [CustomerDetails].[v_CustTrans]
	AS SELECT TOP (100) PERCENT
		c.AccountNumber, c.CustomerFirstName, c.CustomerOtherInitials,
		tt.TransactionDescription, t.DateEntered, t.Amount, t.ReferenceDetails
		FROM CustomerDetails.Customers AS c
		JOIN TransactionDetails.Transactions AS t
		ON t.CustomerId = c.CustomerId
		JOIN TransactionDetails.TransactionTypes AS tt
		ON tt.TransactionTypesId = t.TransactionType
		ORDER BY c.AccountNumber ASC, t.DateEntered DESC
GO
/****** Object:  Table [CustomerDetails].[CustomersProducts]    Script Date: 01.02.2023 23:21:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [CustomerDetails].[CustomersProducts](
	[CustomerFinancialProductID] [bigint] IDENTITY(1,1) NOT NULL,
	[CustomerId] [bigint] NOT NULL,
	[FinancialProductID] [bigint] NOT NULL,
	[AmountToCollect] [money] NOT NULL,
	[Frequency] [smallint] NOT NULL,
	[LastCollected] [datetime] NOT NULL,
	[LastCollection] [datetime] NOT NULL,
	[Renewable] [bit] NOT NULL,
 CONSTRAINT [PK_CustomersProducts] PRIMARY KEY CLUSTERED 
(
	[CustomerFinancialProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [CustomerDetails].[FinancialProducts]    Script Date: 01.02.2023 23:21:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [CustomerDetails].[FinancialProducts](
	[ProductID] [bigint] NOT NULL,
	[ProductName] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  View [CustomerDetails].[v_CustFinProducts]    Script Date: 01.02.2023 23:21:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [CustomerDetails].[v_CustFinProducts]
	WITH SCHEMABINDING
	AS
	SELECT c.CustomerFirstName + ' ' + c.CustomerLastName AS CustomerName,
		   c.AccountNumber, fp.ProductName, cp.AmountToCollect,
		   cp.Frequency, cp.LastCollected
	FROM CustomerDetails.Customers AS c
		JOIN CustomerDetails.CustomersProducts AS cp
	ON cp.CustomerId = c.CustomerId
		JOIN CustomerDetails.FinancialProducts AS fp
	ON fp.ProductID = cp.FinancialProductID
GO
SET ARITHABORT ON
SET CONCAT_NULL_YIELDS_NULL ON
SET QUOTED_IDENTIFIER ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
SET NUMERIC_ROUNDABORT OFF
GO
/****** Object:  Index [IX_CustFinProdS]    Script Date: 01.02.2023 23:21:52 ******/
CREATE UNIQUE CLUSTERED INDEX [IX_CustFinProdS] ON [CustomerDetails].[v_CustFinProducts]
(
	[AccountNumber] ASC,
	[ProductName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  View [TransactionDetails].[v_TransCustShares]    Script Date: 01.02.2023 23:21:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [TransactionDetails].[v_TransCustShares]
AS
SELECT TransactionDetails.Transactions.TransactionId,
	   CustomerDetails.Customers.CustomerFirstName,
	   CustomerDetails.Customers.CustomerOtherInitials,
	   CustomerDetails.Customers.CustomerLastName,
	   TransactionDetails.Transactions.TransactionType,
	   TransactionDetails.Transactions.DateEntered,
	   TransactionDetails.Transactions.Amount,
	   TransactionDetails.Transactions.ReferenceDetails,
	   TransactionDetails.Transactions.Notes,
	   ShareDetails.Shares.ShareDesc,
	   ShareDetails.Shares.CurrentPrice
FROM TransactionDetails.Transactions
	LEFT JOIN CustomerDetails.Customers
		ON TransactionDetails.Transactions.CustomerId = CustomerDetails.Customers.CustomerId
	LEFT JOIN ShareDetails.Shares
		ON TransactionDetails.Transactions.RelatedShareId = ShareDetails.Shares.ShareID
GO
/****** Object:  Table [dbo].[T1]    Script Date: 01.02.2023 23:21:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T1](
	[column_1] [int] IDENTITY(1,1) NOT NULL,
	[column_2] [varchar](30) NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [CustomerDetails].[Customers] ON 

INSERT [CustomerDetails].[Customers] ([CustomerId], [CustomerTitleId], [CustomerFirstName], [CustomerOtherInitials], [CustomerLastName], [AddressId], [AccountNumber], [AccountTypeId], [CleareBalance], [UncleareBalance], [DateAdded]) VALUES (1, 1, N'Andrew', N'J.', N'Brust', 133, N'18176111       ', 1, 0.0000, 2.0000, CAST(N'2022-11-25' AS Date))
INSERT [CustomerDetails].[Customers] ([CustomerId], [CustomerTitleId], [CustomerFirstName], [CustomerOtherInitials], [CustomerLastName], [AddressId], [AccountNumber], [AccountTypeId], [CleareBalance], [UncleareBalance], [DateAdded]) VALUES (2, 3, N'Leonard', NULL, N'Lobel', 145, N'53431993       ', 1, 437.9700, -10.5600, CAST(N'2022-11-25' AS Date))
INSERT [CustomerDetails].[Customers] ([CustomerId], [CustomerTitleId], [CustomerFirstName], [CustomerOtherInitials], [CustomerLastName], [AddressId], [AccountNumber], [AccountTypeId], [CleareBalance], [UncleareBalance], [DateAdded]) VALUES (3, 3, N'Bernie', N'I', N'McGee', 314, N'65368765       ', 1, 6653.1100, 0.0000, CAST(N'2022-11-25' AS Date))
INSERT [CustomerDetails].[Customers] ([CustomerId], [CustomerTitleId], [CustomerFirstName], [CustomerOtherInitials], [CustomerLastName], [AddressId], [AccountNumber], [AccountTypeId], [CleareBalance], [UncleareBalance], [DateAdded]) VALUES (4, 2, N'Julie', N'A', N'McGlynn', 2134, N'81625422       ', 1, 4311.2200, 0.0000, CAST(N'2022-11-25' AS Date))
INSERT [CustomerDetails].[Customers] ([CustomerId], [CustomerTitleId], [CustomerFirstName], [CustomerOtherInitials], [CustomerLastName], [AddressId], [AccountNumber], [AccountTypeId], [CleareBalance], [UncleareBalance], [DateAdded]) VALUES (5, 1, N'Kirsty', NULL, N'Hull', 4312, N'96565334       ', 1, 1266.0000, 10.3200, CAST(N'2022-11-25' AS Date))
INSERT [CustomerDetails].[Customers] ([CustomerId], [CustomerTitleId], [CustomerFirstName], [CustomerOtherInitials], [CustomerLastName], [AddressId], [AccountNumber], [AccountTypeId], [CleareBalance], [UncleareBalance], [DateAdded]) VALUES (6, 1, N'Henry', NULL, N'Williams', 431, N'22067531       ', 1, 0.0000, 0.0000, CAST(N'2022-11-29' AS Date))
INSERT [CustomerDetails].[Customers] ([CustomerId], [CustomerTitleId], [CustomerFirstName], [CustomerOtherInitials], [CustomerLastName], [AddressId], [AccountNumber], [AccountTypeId], [CleareBalance], [UncleareBalance], [DateAdded]) VALUES (7, 1, N'Julie', N'A', N'Dewson', 643, N'SS865          ', 7, 0.0000, 0.0000, CAST(N'2022-11-29' AS Date))
SET IDENTITY_INSERT [CustomerDetails].[Customers] OFF
GO
SET IDENTITY_INSERT [CustomerDetails].[CustomersProducts] ON 

INSERT [CustomerDetails].[CustomersProducts] ([CustomerFinancialProductID], [CustomerId], [FinancialProductID], [AmountToCollect], [Frequency], [LastCollected], [LastCollection], [Renewable]) VALUES (1, 1, 1, 200.0000, 1, CAST(N'2008-10-31T00:00:00.000' AS DateTime), CAST(N'2025-10-31T00:00:00.000' AS DateTime), 0)
INSERT [CustomerDetails].[CustomersProducts] ([CustomerFinancialProductID], [CustomerId], [FinancialProductID], [AmountToCollect], [Frequency], [LastCollected], [LastCollection], [Renewable]) VALUES (2, 2, 4, 150.0000, 3, CAST(N'2010-10-20T00:00:00.000' AS DateTime), CAST(N'2010-10-20T00:00:00.000' AS DateTime), 1)
INSERT [CustomerDetails].[CustomersProducts] ([CustomerFinancialProductID], [CustomerId], [FinancialProductID], [AmountToCollect], [Frequency], [LastCollected], [LastCollection], [Renewable]) VALUES (3, 3, 3, 500.0000, 0, CAST(N'2010-10-24T00:00:00.000' AS DateTime), CAST(N'2010-10-24T00:00:00.000' AS DateTime), 0)
SET IDENTITY_INSERT [CustomerDetails].[CustomersProducts] OFF
GO
INSERT [CustomerDetails].[FinancialProducts] ([ProductID], [ProductName]) VALUES (1, N'Regular Savings')
INSERT [CustomerDetails].[FinancialProducts] ([ProductID], [ProductName]) VALUES (2, N'Bonds Account')
INSERT [CustomerDetails].[FinancialProducts] ([ProductID], [ProductName]) VALUES (3, N'Share Account')
INSERT [CustomerDetails].[FinancialProducts] ([ProductID], [ProductName]) VALUES (4, N'Life Insurance')
GO
SET IDENTITY_INSERT [dbo].[T1] ON 

INSERT [dbo].[T1] ([column_1], [column_2]) VALUES (1, N'Row #1')
INSERT [dbo].[T1] ([column_1], [column_2]) VALUES (2, N'Row #2')
INSERT [dbo].[T1] ([column_1], [column_2]) VALUES (-99, N'Explicit identity value')
INSERT [dbo].[T1] ([column_1], [column_2]) VALUES (3, N'What Row?')
INSERT [dbo].[T1] ([column_1], [column_2]) VALUES (100, N'Explicit identity value')
INSERT [dbo].[T1] ([column_1], [column_2]) VALUES (101, N'What Row?')
SET IDENTITY_INSERT [dbo].[T1] OFF
GO
SET IDENTITY_INSERT [ShareDetails].[SharePrices] ON 

INSERT [ShareDetails].[SharePrices] ([SharePriceID], [ShareID], [Price], [PriceDate]) VALUES (1, 1, CAST(2.15500 AS Numeric(18, 5)), CAST(N'2010-08-01T10:10:00.000' AS DateTime))
INSERT [ShareDetails].[SharePrices] ([SharePriceID], [ShareID], [Price], [PriceDate]) VALUES (2, 1, CAST(2.21250 AS Numeric(18, 5)), CAST(N'2010-08-01T10:12:00.000' AS DateTime))
INSERT [ShareDetails].[SharePrices] ([SharePriceID], [ShareID], [Price], [PriceDate]) VALUES (3, 1, CAST(2.41750 AS Numeric(18, 5)), CAST(N'2010-08-01T10:16:00.000' AS DateTime))
INSERT [ShareDetails].[SharePrices] ([SharePriceID], [ShareID], [Price], [PriceDate]) VALUES (4, 1, CAST(2.21000 AS Numeric(18, 5)), CAST(N'2010-08-01T11:22:00.000' AS DateTime))
INSERT [ShareDetails].[SharePrices] ([SharePriceID], [ShareID], [Price], [PriceDate]) VALUES (5, 1, CAST(2.17000 AS Numeric(18, 5)), CAST(N'2010-08-01T14:54:00.000' AS DateTime))
INSERT [ShareDetails].[SharePrices] ([SharePriceID], [ShareID], [Price], [PriceDate]) VALUES (6, 1, CAST(2.34125 AS Numeric(18, 5)), CAST(N'2010-08-01T16:10:00.000' AS DateTime))
INSERT [ShareDetails].[SharePrices] ([SharePriceID], [ShareID], [Price], [PriceDate]) VALUES (7, 2, CAST(41.10000 AS Numeric(18, 5)), CAST(N'2010-08-01T10:10:00.000' AS DateTime))
INSERT [ShareDetails].[SharePrices] ([SharePriceID], [ShareID], [Price], [PriceDate]) VALUES (8, 2, CAST(43.22000 AS Numeric(18, 5)), CAST(N'2010-08-02T10:10:00.000' AS DateTime))
INSERT [ShareDetails].[SharePrices] ([SharePriceID], [ShareID], [Price], [PriceDate]) VALUES (9, 2, CAST(45.20000 AS Numeric(18, 5)), CAST(N'2010-08-03T10:10:00.000' AS DateTime))
SET IDENTITY_INSERT [ShareDetails].[SharePrices] OFF
GO
SET IDENTITY_INSERT [ShareDetails].[Shares] ON 

INSERT [ShareDetails].[Shares] ([ShareID], [ShareDesc], [ShareTickerID], [CurrentPrice]) VALUES (1, N'ACME''S HOMEBAKE COOKIES INC', N'AHCI', CAST(2.34125 AS Numeric(18, 5)))
INSERT [ShareDetails].[Shares] ([ShareID], [ShareDesc], [ShareTickerID], [CurrentPrice]) VALUES (2, N'FAT-BELLY.COM', N'FBC', CAST(45.20000 AS Numeric(18, 5)))
INSERT [ShareDetails].[Shares] ([ShareID], [ShareDesc], [ShareTickerID], [CurrentPrice]) VALUES (3, N'NetRadio Inc', N'NRI', CAST(32.76900 AS Numeric(18, 5)))
INSERT [ShareDetails].[Shares] ([ShareID], [ShareDesc], [ShareTickerID], [CurrentPrice]) VALUES (4, N'Texas Oil Industries', N'TOI', CAST(0.45500 AS Numeric(18, 5)))
INSERT [ShareDetails].[Shares] ([ShareID], [ShareDesc], [ShareTickerID], [CurrentPrice]) VALUES (5, N'London Bridge Club', N'LBC', CAST(1.46000 AS Numeric(18, 5)))
INSERT [ShareDetails].[Shares] ([ShareID], [ShareDesc], [ShareTickerID], [CurrentPrice]) VALUES (6, N'FAT-BELLY.COM', N'FBC', CAST(45.20000 AS Numeric(18, 5)))
SET IDENTITY_INSERT [ShareDetails].[Shares] OFF
GO
SET IDENTITY_INSERT [TransactionDetails].[Transactions] ON 

INSERT [TransactionDetails].[Transactions] ([TransactionId], [CustomerId], [TransactionType], [DateEntered], [Amount], [ReferenceDetails], [Notes], [RelatedShareId], [RelatedProductId]) VALUES (2, 1, 1, CAST(N'2008-08-01T00:00:00.000' AS DateTime), CAST(100.00000 AS Numeric(18, 5)), NULL, NULL, 1, 1)
INSERT [TransactionDetails].[Transactions] ([TransactionId], [CustomerId], [TransactionType], [DateEntered], [Amount], [ReferenceDetails], [Notes], [RelatedShareId], [RelatedProductId]) VALUES (3, 1, 1, CAST(N'2008-08-03T00:00:00.000' AS DateTime), CAST(75.67000 AS Numeric(18, 5)), NULL, NULL, 2, 1)
INSERT [TransactionDetails].[Transactions] ([TransactionId], [CustomerId], [TransactionType], [DateEntered], [Amount], [ReferenceDetails], [Notes], [RelatedShareId], [RelatedProductId]) VALUES (4, 1, 2, CAST(N'2008-08-05T00:00:00.000' AS DateTime), CAST(35.20000 AS Numeric(18, 5)), NULL, NULL, 3, 1)
INSERT [TransactionDetails].[Transactions] ([TransactionId], [CustomerId], [TransactionType], [DateEntered], [Amount], [ReferenceDetails], [Notes], [RelatedShareId], [RelatedProductId]) VALUES (5, 1, 2, CAST(N'2008-08-06T00:00:00.000' AS DateTime), CAST(20.00000 AS Numeric(18, 5)), NULL, NULL, 4, 1)
INSERT [TransactionDetails].[Transactions] ([TransactionId], [CustomerId], [TransactionType], [DateEntered], [Amount], [ReferenceDetails], [Notes], [RelatedShareId], [RelatedProductId]) VALUES (6, 1, 2, CAST(N'2022-11-30T10:27:13.457' AS DateTime), CAST(200.00000 AS Numeric(18, 5)), NULL, NULL, 5, 1)
INSERT [TransactionDetails].[Transactions] ([TransactionId], [CustomerId], [TransactionType], [DateEntered], [Amount], [ReferenceDetails], [Notes], [RelatedShareId], [RelatedProductId]) VALUES (8, 1, 3, CAST(N'2022-11-30T10:33:13.840' AS DateTime), CAST(200.00000 AS Numeric(18, 5)), NULL, NULL, 6, 1)
SET IDENTITY_INSERT [TransactionDetails].[Transactions] OFF
GO
SET IDENTITY_INSERT [TransactionDetails].[TransactionTypes] ON 

INSERT [TransactionDetails].[TransactionTypes] ([TransactionTypesId], [TransactionDescription], [CreditType], [AffectCashBalance]) VALUES (1, N'proc+', 1, 1)
INSERT [TransactionDetails].[TransactionTypes] ([TransactionTypesId], [TransactionDescription], [CreditType], [AffectCashBalance]) VALUES (2, N'proc-', 0, 1)
SET IDENTITY_INSERT [TransactionDetails].[TransactionTypes] OFF
GO
/****** Object:  Index [PK_Customers]    Script Date: 01.02.2023 23:21:53 ******/
ALTER TABLE [CustomerDetails].[Customers] ADD  CONSTRAINT [PK_Customers] PRIMARY KEY NONCLUSTERED 
(
	[CustomerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Customers_CustomerId]    Script Date: 01.02.2023 23:21:53 ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Customers_CustomerId] ON [CustomerDetails].[Customers]
(
	[CustomerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = ON, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_CustomersProducts]    Script Date: 01.02.2023 23:21:53 ******/
CREATE NONCLUSTERED INDEX [IX_CustomersProducts] ON [CustomerDetails].[CustomersProducts]
(
	[CustomerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [PK_Shares]    Script Date: 01.02.2023 23:21:53 ******/
ALTER TABLE [ShareDetails].[Shares] ADD  CONSTRAINT [PK_Shares] PRIMARY KEY NONCLUSTERED 
(
	[ShareID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Transactions_TTypes]    Script Date: 01.02.2023 23:21:53 ******/
CREATE NONCLUSTERED INDEX [IX_Transactions_TTypes] ON [TransactionDetails].[Transactions]
(
	[TransactionType] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [PK_TransactionTypes]    Script Date: 01.02.2023 23:21:53 ******/
ALTER TABLE [TransactionDetails].[TransactionTypes] ADD  CONSTRAINT [PK_TransactionTypes] PRIMARY KEY NONCLUSTERED 
(
	[TransactionTypesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [CustomerDetails].[Customers] ADD  CONSTRAINT [DF_Customers_DateAdded]  DEFAULT (getdate()) FOR [DateAdded]
GO
ALTER TABLE [CustomerDetails].[CustomersProducts] ADD  CONSTRAINT [DF_CustProds_Renewable]  DEFAULT ((0)) FOR [Renewable]
GO
ALTER TABLE [TransactionDetails].[Transactions]  WITH CHECK ADD  CONSTRAINT [FK_Transactions_Customers] FOREIGN KEY([CustomerId])
REFERENCES [CustomerDetails].[Customers] ([CustomerId])
GO
ALTER TABLE [TransactionDetails].[Transactions] CHECK CONSTRAINT [FK_Transactions_Customers]
GO
ALTER TABLE [TransactionDetails].[Transactions]  WITH NOCHECK ADD  CONSTRAINT [FK_Transactions_Shares] FOREIGN KEY([RelatedShareId])
REFERENCES [ShareDetails].[Shares] ([ShareID])
GO
ALTER TABLE [TransactionDetails].[Transactions] CHECK CONSTRAINT [FK_Transactions_Shares]
GO
ALTER TABLE [CustomerDetails].[CustomersProducts]  WITH CHECK ADD  CONSTRAINT [CK_CustProd_LastCollectinCheck] CHECK  (([LastCollection]>=[LastCollected]))
GO
ALTER TABLE [CustomerDetails].[CustomersProducts] CHECK CONSTRAINT [CK_CustProd_LastCollectinCheck]
GO
ALTER TABLE [CustomerDetails].[CustomersProducts]  WITH NOCHECK ADD  CONSTRAINT [CK_CustProds_AmtCheck] CHECK  (([AmountToCollect]>(0)))
GO
ALTER TABLE [CustomerDetails].[CustomersProducts] CHECK CONSTRAINT [CK_CustProds_AmtCheck]
GO
/****** Object:  StoredProcedure [CustomerDetails].[apf_CusMovement]    Script Date: 01.02.2023 23:21:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [CustomerDetails].[apf_CusMovement] 
@CustID bigint,
@FromDate datetime, 
@ToDate datetime
AS
BEGIN
/* нам нужны три внутренние переменные:
 идентификатор транзакции из таблицы будем сохранять в @LastTran
 @StillCalc используется для проверки цикла WHILE */
	DECLARE @RunningBal money, @StillCalc bit, @LastTran bigint
	SELECT @StillCalc = 1, @LastTran = 0, @RunningBal = 0
-- выполнение цикла WHILE продолжается, пока инструкция возвращает строку
-- если строка не получена, значит в диапазоне дат больше нет транзакций
	WHILE @StillCalc = 1
	BEGIN
-- инструкция SELECT возвращает одну строку, в которой ( WHERE ):
-- идентификатор TransactionId больше предыдущего возвращенного идентификатора,
-- транзакция оказывает влияние на баланс клиента и 
-- транзакция находится в переданном диапазоне дат
		SELECT TOP 1 @RunningBal = @RunningBal + CASE
						WHEN tt.CreditType = 1 THEN t.Amount
						ELSE t.Amount* -1 END,
					@LastTran = t.TransactionId
		FROM CustomerDetails.Customers AS c
			JOIN TransactionDetails.Transactions AS t
				ON t.CustomerId = c.CustomerId
			JOIN TransactionDetails.TransactionTypes AS tt
				ON tt.TransactionTypesId = t.TransactionType
		WHERE t.TransactionId > @LastTran AND
			  tt.AffectCashBalance = 1 AND
			  DateEntered BETWEEN @FromDate AND @ToDate
		ORDER BY DateEntered
-- если строка возвращена, то выполнение цикла продолжается
		IF @@ROWCOUNT > 0
-- здесь следует выполнить расчет процента
			CONTINUE
		ELSE
			BREAK
	END
	SELECT @RunningBal AS 'End Balance'
END;
GO
/****** Object:  StoredProcedure [CustomerDetails].[apf_insCustomer]    Script Date: 01.02.2023 23:21:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [CustomerDetails].[apf_insCustomer] 
-- Add the parameters for the stored procedure here
@FirstName varchar(50),
@LastName varchar(50),
@CustTitle int,
@CustInitials varchar(10),
@AddressId int,
@AccountNumber nvarchar(15),
@AccountTypeId int
AS
BEGIN
-- SET NOCOUNT ON added to prevent extra result sets from
-- interfering with SELECT statements.
	SET NOCOUNT ON;
	INSERT INTO CustomerDetails.Customers 
		(CustomerTitleId
		,CustomerFirstName
		,CustomerOtherInitials
		,CustomerLastName
		,AddressId
		,AccountNumber
		,AccountTypeId
		,CleareBalance
		,UncleareBalance)
	VALUES (@CustTitle
		   ,@FirstName
		   ,@CustInitials
		   ,@LastName
		   ,@AddressId
		   ,@AccountNumber
		   ,@AccountTypeId
		   ,0
		   ,0)
END
GO
/****** Object:  StoredProcedure [dbo].[Test1]    Script Date: 01.02.2023 23:21:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Test1]
AS
SELECT 'Hello all';
GO
/****** Object:  StoredProcedure [dbo].[Test2]    Script Date: 01.02.2023 23:21:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Test2]
AS
SELECT 'Hello all';
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Customer information' , @level0type=N'SCHEMA',@level0name=N'CustomerDetails', @level1type=N'TABLE',@level1name=N'Customers'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Shares (ShareDetails)"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'ShareDetails', @level1type=N'VIEW',@level1name=N'v_CurrentShares'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'ShareDetails', @level1type=N'VIEW',@level1name=N'v_CurrentShares'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "SharePrices (ShareDetails)"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "v_CurrentShares (ShareDetails)"
            Begin Extent = 
               Top = 2
               Left = 243
               Bottom = 115
               Right = 413
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'ShareDetails', @level1type=N'VIEW',@level1name=N'v_SharePrices'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'ShareDetails', @level1type=N'VIEW',@level1name=N'v_SharePrices'
GO
USE [master]
GO
ALTER DATABASE [ApressFinancial] SET  READ_WRITE 
GO
