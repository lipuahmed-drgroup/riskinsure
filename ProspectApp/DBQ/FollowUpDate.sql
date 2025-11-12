USE [RI_Prospects]
GO

/****** Object:  Table [dbo].[Prospects_FollowUpDate]    Script Date: 04/19/2012 12:51:10 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Prospects_FollowUpDate](
	[fudID] [int] IDENTITY(1,1) NOT NULL,
	[cID] [int] NOT NULL,
	[folDate] [date] NOT NULL,
	[isDone] [int] NOT NULL,
	[doneDate] [date] NULL,
 CONSTRAINT [PK_Prospects_FollowUpDate] PRIMARY KEY CLUSTERED 
(
	[fudID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
