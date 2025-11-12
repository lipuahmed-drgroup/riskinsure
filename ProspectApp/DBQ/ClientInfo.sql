USE [RI_Prospects]
GO

/****** Object:  Table [dbo].[Prospects_ClientInfo]    Script Date: 04/19/2012 12:48:29 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Prospects_ClientInfo](
	[cID] [int] IDENTITY(1,1) NOT NULL,
	[cName] [varchar](120) NULL,
	[cAddress] [text] NULL,
	[cSuburb] [text] NULL,
	[cState] [text] NULL,
	[cPostcode] [text] NULL,
	[cSTD] [text] NULL,
	[cPhone] [text] NULL,
	[cSTDFax] [text] NULL,
	[cFax] [text] NULL,
	[cTitle] [text] NULL,
	[CeoIn] [nchar](10) NULL,
	[Name] [text] NULL,
	[Surname] [text] NULL,
	[Position] [text] NULL,
	[LineOfBusiness] [text] NULL,
	[Employees] [text] NULL,
	[AnnualRevenue] [text] NULL,
	[NoContact] [int] NULL,
	[LOB1] [text] NULL,
	[TimeStamp] [date] NULL,
	[Email] [text] NULL,
	[WebSite] [text] NULL,
	[rbID] [int] NULL,
	[Archive] [int] NULL,
 CONSTRAINT [PK_Prospects_ClientInfo] PRIMARY KEY CLUSTERED 
(
	[cID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

