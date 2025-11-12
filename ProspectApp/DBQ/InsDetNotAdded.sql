USE [RI_Prospects]
GO

/****** Object:  Table [dbo].[Prospects_insdetailsnotadded]    Script Date: 04/19/2012 12:54:21 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Prospects_insdetailsnotadded](
	[idnaID] [int] IDENTITY(1,1) NOT NULL,
	[cName] [nvarchar](110) NOT NULL,
	[dueMon] [text] NULL,
	[ActDate] [text] NULL,
	[CurrentBro] [text] NULL,
	[BroPerson] [text] NULL,
	[premium] [text] NULL,
 CONSTRAINT [PK_Prospects_insdetailsnotadded] PRIMARY KEY CLUSTERED 
(
	[idnaID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO


