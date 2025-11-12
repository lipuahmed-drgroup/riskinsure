USE [RI_Prospects]
GO

/****** Object:  Table [dbo].[Prospects_DiscNotesNotAdded]    Script Date: 04/19/2012 12:50:51 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Prospects_DiscNotesNotAdded](
	[notesNotAddedId] [int] IDENTITY(1,1) NOT NULL,
	[cName] [varchar](110) NOT NULL,
	[DiscussionNote] [text] NOT NULL,
	[date] [text] NULL,
 CONSTRAINT [PK_Prospects_DiscNotesNotAdded] PRIMARY KEY CLUSTERED 
(
	[notesNotAddedId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


