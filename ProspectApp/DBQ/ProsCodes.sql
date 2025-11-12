USE [RI_Prospects]
GO

/****** Object:  Table [dbo].[Prospects_ProsCodes]    Script Date: 04/19/2012 12:53:38 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Prospects_ProsCodes](
	[pcID] [int] IDENTITY(1,1) NOT NULL,
	[catCode] [text] NOT NULL,
	[catDesc] [text] NULL,
 CONSTRAINT [PK_Prospects_ProsCodes] PRIMARY KEY CLUSTERED 
(
	[pcID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO


