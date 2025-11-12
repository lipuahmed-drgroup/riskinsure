USE [RI_Prospects]
GO

/****** Object:  Table [dbo].[Prospects_AccessRestrictions]    Script Date: 04/19/2012 12:49:49 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Prospects_AccessRestrictions](
	[arID] [int] IDENTITY(1,1) NOT NULL,
	[rbID] [int] NOT NULL,
	[addC] [int] NOT NULL,
	[eddC] [int] NOT NULL,
	[viwC] [int] NOT NULL,
	[viwB] [int] NOT NULL,
	[addB] [int] NOT NULL,
	[eddB] [int] NOT NULL,
	[addP] [int] NOT NULL,
	[eddP] [int] NOT NULL,
	[addPC] [int] NOT NULL,
	[eddPC] [int] NOT NULL,
	[expED] [int] NOT NULL,
	[expCL] [int] NOT NULL,
	[doMCN] [int] NOT NULL,
	[assMC] [int] NOT NULL,
	[addIN] [int] NOT NULL,
	[eddIN] [int] NOT NULL,
	[delIN] [int] NOT NULL,
	[addFU] [int] NOT NULL,
	[comFU] [int] NOT NULL,
	[addDN] [int] NOT NULL,
	[eddDN] [int] NOT NULL,
	[assPC] [int] NOT NULL,
	[vAsPC] [int] NOT NULL,
	[dAsPC] [int] NOT NULL,
	[viwSA] [int] NOT NULL,
	[addSA] [int] NOT NULL,
	[eddSA] [int] NOT NULL,
	[sama] [int] NOT NULL,
	[bra] [int] NOT NULL,
 CONSTRAINT [PK_Prospects_AccessRestrictions] PRIMARY KEY CLUSTERED 
(
	[arID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

