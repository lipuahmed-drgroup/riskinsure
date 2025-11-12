USE [RI_Prospects]
GO

/****** Object:  Table [dbo].[Prospects_MonthlyContacts]    Script Date: 04/19/2012 12:52:50 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Prospects_MonthlyContacts](
	[mcID] [int] IDENTITY(1,1) NOT NULL,
	[mID] [int] NOT NULL,
	[cID] [int] NOT NULL,
	[rbID] [int] NOT NULL,
	[complete] [int] NOT NULL,
	[year] [int] NOT NULL,
	[CompByrbID] [int] NULL,
	[compDate] [date] NULL,
 CONSTRAINT [PK_Prospects_MonthlyContacts] PRIMARY KEY CLUSTERED 
(
	[mcID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

