USE [RI_Prospects]
GO

ALTER TABLE [dbo].[Prospects_AccessRestrictions]  WITH CHECK ADD  CONSTRAINT [FK_Prospects_AccessRestrictions_Prospects_RiskBrokers] FOREIGN KEY([rbID])
REFERENCES [dbo].[Prospects_RiskBrokers] ([rbID])
GO

ALTER TABLE [dbo].[Prospects_AccessRestrictions] CHECK CONSTRAINT [FK_Prospects_AccessRestrictions_Prospects_RiskBrokers]
GO

USE [RI_Prospects]
GO

ALTER TABLE [dbo].[Prospects_ClientInfo]  WITH CHECK ADD  CONSTRAINT [FK_Prospects_ClientInfo_Prospects_RiskBrokers] FOREIGN KEY([rbID])
REFERENCES [dbo].[Prospects_RiskBrokers] ([rbID])
GO

ALTER TABLE [dbo].[Prospects_ClientInfo] CHECK CONSTRAINT [FK_Prospects_ClientInfo_Prospects_RiskBrokers]
GO

USE [RI_Prospects]
GO

ALTER TABLE [dbo].[Prospects_CustProsCode]  WITH CHECK ADD  CONSTRAINT [FK_Prospects_CustProsCode_Prospects_ClientInfo] FOREIGN KEY([cID])
REFERENCES [dbo].[Prospects_ClientInfo] ([cID])
GO

ALTER TABLE [dbo].[Prospects_CustProsCode] CHECK CONSTRAINT [FK_Prospects_CustProsCode_Prospects_ClientInfo]
GO

USE [RI_Prospects]
GO

ALTER TABLE [dbo].[Prospects_CustProsCode]  WITH CHECK ADD  CONSTRAINT [FK_Prospects_CustProsCode_Prospects_ProsCodes] FOREIGN KEY([cID])
REFERENCES [dbo].[Prospects_ProsCodes] ([pcID])
GO

ALTER TABLE [dbo].[Prospects_CustProsCode] CHECK CONSTRAINT [FK_Prospects_CustProsCode_Prospects_ProsCodes]
GO

USE [RI_Prospects]
GO

ALTER TABLE [dbo].[Prospects_DiscNotes]  WITH CHECK ADD  CONSTRAINT [FK_Prospects_DiscNotes_Prospects_ClientInfo] FOREIGN KEY([cID])
REFERENCES [dbo].[Prospects_ClientInfo] ([cID])
GO

ALTER TABLE [dbo].[Prospects_DiscNotes] CHECK CONSTRAINT [FK_Prospects_DiscNotes_Prospects_ClientInfo]
GO

USE [RI_Prospects]
GO

ALTER TABLE [dbo].[Prospects_DiscNotes]  WITH CHECK ADD  CONSTRAINT [FK_Prospects_DiscNotes_Prospects_RiskBrokers] FOREIGN KEY([rbID])
REFERENCES [dbo].[Prospects_RiskBrokers] ([rbID])
GO

ALTER TABLE [dbo].[Prospects_DiscNotes] CHECK CONSTRAINT [FK_Prospects_DiscNotes_Prospects_RiskBrokers]
GO

USE [RI_Prospects]
GO

ALTER TABLE [dbo].[Prospects_Followup]  WITH CHECK ADD  CONSTRAINT [FK_Prospects_Followup_Prospects_ClientInfo] FOREIGN KEY([cID])
REFERENCES [dbo].[Prospects_ClientInfo] ([cID])
GO

ALTER TABLE [dbo].[Prospects_Followup] CHECK CONSTRAINT [FK_Prospects_Followup_Prospects_ClientInfo]
GO

USE [RI_Prospects]
GO

ALTER TABLE [dbo].[Prospects_FollowUpDate]  WITH CHECK ADD  CONSTRAINT [FK_Prospects_FollowUpDate_Prospects_ClientInfo] FOREIGN KEY([cID])
REFERENCES [dbo].[Prospects_ClientInfo] ([cID])
GO

ALTER TABLE [dbo].[Prospects_FollowUpDate] CHECK CONSTRAINT [FK_Prospects_FollowUpDate_Prospects_ClientInfo]
GO

USE [RI_Prospects]
GO

ALTER TABLE [dbo].[Prospects_InsuranceDetails]  WITH CHECK ADD  CONSTRAINT [FK_Prospects_InsuranceDetails_Prospects_ClientInfo] FOREIGN KEY([cID])
REFERENCES [dbo].[Prospects_ClientInfo] ([cID])
GO

ALTER TABLE [dbo].[Prospects_InsuranceDetails] CHECK CONSTRAINT [FK_Prospects_InsuranceDetails_Prospects_ClientInfo]
GO

USE [RI_Prospects]
GO

ALTER TABLE [dbo].[Prospects_InsuranceDetails]  WITH CHECK ADD  CONSTRAINT [FK_Prospects_InsuranceDetails_Prospects_Months] FOREIGN KEY([mID])
REFERENCES [dbo].[Prospects_Months] ([mID])
GO

ALTER TABLE [dbo].[Prospects_InsuranceDetails] CHECK CONSTRAINT [FK_Prospects_InsuranceDetails_Prospects_Months]
GO

USE [RI_Prospects]
GO

ALTER TABLE [dbo].[Prospects_InsuranceDetails]  WITH CHECK ADD  CONSTRAINT [FK_Prospects_InsuranceDetails_Prospects_Premiums] FOREIGN KEY([premID])
REFERENCES [dbo].[Prospects_Premiums] ([premID])
GO

ALTER TABLE [dbo].[Prospects_InsuranceDetails] CHECK CONSTRAINT [FK_Prospects_InsuranceDetails_Prospects_Premiums]
GO

USE [RI_Prospects]
GO

ALTER TABLE [dbo].[Prospects_InsuranceDetails]  WITH CHECK ADD  CONSTRAINT [FK_Prospects_InsuranceDetails_Prospects_RiskBrokers] FOREIGN KEY([rbID])
REFERENCES [dbo].[Prospects_RiskBrokers] ([rbID])
GO

ALTER TABLE [dbo].[Prospects_InsuranceDetails] CHECK CONSTRAINT [FK_Prospects_InsuranceDetails_Prospects_RiskBrokers]
GO

USE [RI_Prospects]
GO

ALTER TABLE [dbo].[Prospects_MonthlyContacts]  WITH CHECK ADD  CONSTRAINT [FK_Prospects_MonthlyContacts_Prospects_ClientInfo] FOREIGN KEY([cID])
REFERENCES [dbo].[Prospects_ClientInfo] ([cID])
GO

ALTER TABLE [dbo].[Prospects_MonthlyContacts] CHECK CONSTRAINT [FK_Prospects_MonthlyContacts_Prospects_ClientInfo]
GO

USE [RI_Prospects]
GO

ALTER TABLE [dbo].[Prospects_MonthlyContacts]  WITH CHECK ADD  CONSTRAINT [FK_Prospects_MonthlyContacts_Prospects_Months] FOREIGN KEY([mID])
REFERENCES [dbo].[Prospects_Months] ([mID])
GO

ALTER TABLE [dbo].[Prospects_MonthlyContacts] CHECK CONSTRAINT [FK_Prospects_MonthlyContacts_Prospects_Months]
GO

USE [RI_Prospects]
GO

ALTER TABLE [dbo].[Prospects_MonthlyContacts]  WITH CHECK ADD  CONSTRAINT [FK_Prospects_MonthlyContacts_Prospects_RiskBrokers] FOREIGN KEY([rbID])
REFERENCES [dbo].[Prospects_RiskBrokers] ([rbID])
GO

ALTER TABLE [dbo].[Prospects_MonthlyContacts] CHECK CONSTRAINT [FK_Prospects_MonthlyContacts_Prospects_RiskBrokers]
GO

USE [RI_Prospects]
GO

ALTER TABLE [dbo].[Prospects_MonthlyGeneration]  WITH CHECK ADD  CONSTRAINT [FK_Prospects_MonthlyGeneration_Prospects_Months] FOREIGN KEY([mID])
REFERENCES [dbo].[Prospects_Months] ([mID])
GO

ALTER TABLE [dbo].[Prospects_MonthlyGeneration] CHECK CONSTRAINT [FK_Prospects_MonthlyGeneration_Prospects_Months]
GO

USE [RI_Prospects]
GO

ALTER TABLE [dbo].[Prospects_SalesApproach]  WITH CHECK ADD  CONSTRAINT [FK_Prospects_SalesApproach_Prospects_ClientInfo] FOREIGN KEY([cID])
REFERENCES [dbo].[Prospects_ClientInfo] ([cID])
GO

ALTER TABLE [dbo].[Prospects_SalesApproach] CHECK CONSTRAINT [FK_Prospects_SalesApproach_Prospects_ClientInfo]
GO

USE [RI_Prospects]
GO

ALTER TABLE [dbo].[Prospects_SalesApproach]  WITH CHECK ADD  CONSTRAINT [FK_Prospects_SalesApproach_Prospects_RiskBrokers] FOREIGN KEY([rbID])
REFERENCES [dbo].[Prospects_RiskBrokers] ([rbID])
GO

ALTER TABLE [dbo].[Prospects_SalesApproach] CHECK CONSTRAINT [FK_Prospects_SalesApproach_Prospects_RiskBrokers]
GO

USE [RI_Prospects]
GO

ALTER TABLE [dbo].[Prospects_SalesApproachManagement]  WITH CHECK ADD  CONSTRAINT [FK_Prospects_SalesApproachManagement_Prospects_ClientInfo] FOREIGN KEY([cID])
REFERENCES [dbo].[Prospects_ClientInfo] ([cID])
GO

ALTER TABLE [dbo].[Prospects_SalesApproachManagement] CHECK CONSTRAINT [FK_Prospects_SalesApproachManagement_Prospects_ClientInfo]
GO

USE [RI_Prospects]
GO

ALTER TABLE [dbo].[Prospects_SalesApproachManagement]  WITH CHECK ADD  CONSTRAINT [FK_Prospects_SalesApproachManagement_Prospects_RiskBrokers] FOREIGN KEY([rbID])
REFERENCES [dbo].[Prospects_RiskBrokers] ([rbID])
GO

ALTER TABLE [dbo].[Prospects_SalesApproachManagement] CHECK CONSTRAINT [FK_Prospects_SalesApproachManagement_Prospects_RiskBrokers]
GO

