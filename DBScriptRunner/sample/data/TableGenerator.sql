USE [SampleDB]
GO

/****** Object:  Table [dbo].[Customer]    Script Date: 11/16/2021 1:15:50 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Customer](
	[CustId] [int] NOT NULL,
	[FirstName] [varchar](50) NULL,
	[LastName] [varchar](50) NULL,
	[City] [varchar](50) NULL,
	[Country] [varchar](50) NULL,
	[EmailId] [varchar](50) NULL,
	[CreatedDttm] [datetime] NOT NULL,
	[CreatedBy] [varbinary](50) NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[CustId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Customer] ADD  CONSTRAINT [DF_Customer_CreatedDttm]  DEFAULT (getdate()) FOR [CreatedDttm]
GO


