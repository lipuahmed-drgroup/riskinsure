USE [RI_Prospects]
GO

/****** Object:  Table [dbo].[Prospects_RiskBrokers]    Script Date: 04/19/2012 12:53:48 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Prospects_RiskBrokers](
	[rbID] [int] IDENTITY(1,1) NOT NULL,
	[BrokerName] [text] NULL,
	[BrokerLogin] [varchar](50) NULL,
	[BrokerPass] [varchar](50) NULL,
	[isActive] [int] NOT NULL,
 CONSTRAINT [PK_Prospects_RiskBrokers] PRIMARY KEY CLUSTERED 
(
	[rbID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


