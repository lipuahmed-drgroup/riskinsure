USE [RI_Prospects]
GO

/****** Object:  Table [dbo].[Prospects_SalesApproachManagement]    Script Date: 04/19/2012 12:54:11 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Prospects_SalesApproachManagement](
	[samID] [int] IDENTITY(1,1) NOT NULL,
	[cID] [int] NOT NULL,
	[rbID] [int] NOT NULL,
	[year] [int] NOT NULL,
	[isAssigned] [int] NOT NULL,
	[isClosed] [int] NOT NULL,
	[Created] [date] NULL,
	[LastUpdated] [date] NULL,
	[saID] [int] NOT NULL,
 CONSTRAINT [PK_Prospects_SalesApproachManagement] PRIMARY KEY CLUSTERED 
(
	[samID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
