USE [RI_Prospects]
GO

/****** Object:  Table [dbo].[Prospects_SalesApproach]    Script Date: 04/19/2012 12:53:58 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Prospects_SalesApproach](
	[saID] [int] IDENTITY(1,1) NOT NULL,
	[cID] [int] NOT NULL,
	[rbID] [int] NOT NULL,
	[createDate] [date] NOT NULL,
	[updtDate] [date] NULL,
	[s1_pct_date] [text] NULL,
	[s1_pct_note] [text] NULL,
	[s1_ini_date] [text] NULL,
	[s1_ctacdAmt] [text] NULL,
	[s1_Contactd] [int] NULL,
	[s1_ifIntMtg] [int] NULL,
	[s1_mtg_date] [text] NULL,
	[s1_mtg_note] [text] NULL,
	[s2_ten_date] [text] NULL,
	[s2_den_brok] [text] NULL,
	[s2_ini_date] [text] NULL,
	[s2_ifBrTend] [int] NULL,
	[s2_TendNote] [text] NULL,
	[s2_DiscDate] [text] NULL,
	[s2_DiscName] [text] NULL,
	[s3_MtngObta] [int] NULL,
	[s3_MtngDate] [text] NULL,
	[s3_PresDate] [text] NULL,
	[s3_ifBordRm] [int] NULL,
	[s3_InDscDte] [text] NULL,
	[s3_InDsName] [text] NULL,
	[s3_SlipDate] [text] NULL,
	[s4_BrokPres] [text] NULL,
	[s4_IfOutWin] [int] NULL,
	[s4_WinTNote] [text] NULL,
	[s4_LiveClos] [text] NULL,
	[furtherNote] [text] NULL,
 CONSTRAINT [PK_Prospects_SalesApproach] PRIMARY KEY CLUSTERED 
(
	[saID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
