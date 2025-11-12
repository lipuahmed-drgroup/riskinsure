USE [RI_Prospects]
GO

/****** Object:  Table [dbo].[Prospects_MonthlyGeneration]    Script Date: 04/19/2012 12:52:59 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Prospects_MonthlyGeneration](
	[mgID] [int] IDENTITY(1,1) NOT NULL,
	[mID] [int] NOT NULL,
	[year] [int] NOT NULL,
	[generated] [int] NOT NULL
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Prospects_MonthlyGeneration]  WITH CHECK ADD  CONSTRAINT [FK_Prospects_MonthlyGeneration_Prospects_Months] FOREIGN KEY([mID])
REFERENCES [dbo].[Prospects_Months] ([mID])
GO

ALTER TABLE [dbo].[Prospects_MonthlyGeneration] CHECK CONSTRAINT [FK_Prospects_MonthlyGeneration_Prospects_Months]
GO


