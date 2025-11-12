USE [RI_Prospects]
GO

/****** Object:  Table [dbo].[Prospects_DiscNotes]    Script Date: 04/19/2012 12:50:39 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Prospects_DiscNotes](
	[dnID] [int] IDENTITY(1,1) NOT NULL,
	[cID] [int] NOT NULL,
	[dDate] [date] NOT NULL,
	[dNote] [text] NOT NULL,
	[rbID] [int] NOT NULL,
 CONSTRAINT [PK_Prospects_DiscNotes] PRIMARY KEY CLUSTERED 
(
	[dnID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
