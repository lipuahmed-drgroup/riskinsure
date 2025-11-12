USE [RI_Prospects]
GO

/****** Object:  Table [dbo].[Prospects_InsuranceDetails]    Script Date: 04/19/2012 12:52:39 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Prospects_InsuranceDetails](
	[detID] [int] IDENTITY(1,1) NOT NULL,
	[cID] [int] NOT NULL,
	[mID] [int] NULL,
	[actDate] [date] NULL,
	[broPerson] [text] NULL,
	[broCompany] [text] NULL,
	[rbID] [int] NULL,
	[premID] [int] NULL,
 CONSTRAINT [PK_Prospects_InsuranceDetails] PRIMARY KEY CLUSTERED 
(
	[detID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
