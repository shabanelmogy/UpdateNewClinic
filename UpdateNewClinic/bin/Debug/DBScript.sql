USE [Clinic]
GO
/****** Object:  Table [dbo].[ClinicDays]    Script Date: 14/04/2022 13:05:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ClinicDays](
	[VisitDate] [date] NOT NULL,
	[PatientID] [int] NOT NULL,
	[PatientName] [nvarchar](100) NOT NULL,
	[VisitType] [smallint] NOT NULL,
	[VisitCost] [decimal](6, 2) NOT NULL,
	[NewWeight] [nvarchar](20) NOT NULL,
	[NewWaist] [nvarchar](20) NOT NULL,
	[PlanOfTreatment] [nvarchar](200) NOT NULL,
	[EatingHabits] [nvarchar](200) NOT NULL,
	[Notes] [nvarchar](200) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PatientsDetail]    Script Date: 14/04/2022 13:05:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PatientsDetail](
	[PatientNum] [int] NOT NULL,
	[PatientName] [nvarchar](100) NOT NULL,
	[Code] [nvarchar](20) NOT NULL,
	[Age] [nvarchar](20) NOT NULL,
	[Occupation] [nvarchar](50) NOT NULL,
	[PhoneNumber] [nvarchar](11) NOT NULL,
	[FirstDate] [date] NOT NULL,
	[Height] [nvarchar](10) NOT NULL,
	[StartWeight] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_PatientsDetail_1] PRIMARY KEY CLUSTERED 
(
	[PatientNum] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reservation]    Script Date: 14/04/2022 13:05:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reservation](
	[ReservID] [int] IDENTITY(1,1) NOT NULL,
	[PatientID] [int] NOT NULL,
	[PatientName] [nvarchar](50) NOT NULL,
	[ReserveDate] [date] NOT NULL,
	[VisitType] [smallint] NOT NULL,
	[VisitName] [nvarchar](50) NOT NULL,
	[VisitCost] [decimal](6, 2) NOT NULL,
 CONSTRAINT [PK_Reservation_1] PRIMARY KEY CLUSTERED 
(
	[ReservID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VisitsTypes]    Script Date: 14/04/2022 13:05:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VisitsTypes](
	[Num] [int] NOT NULL,
	[VisitKind] [nvarchar](50) NOT NULL,
	[Amount] [decimal](6, 2) NOT NULL,
 CONSTRAINT [PK_VisitsTypes] PRIMARY KEY CLUSTERED 
(
	[Num] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ClinicDays] ADD  CONSTRAINT [DF_ClinicDays_PatientID]  DEFAULT ((0)) FOR [PatientID]
GO
ALTER TABLE [dbo].[ClinicDays] ADD  CONSTRAINT [DF_ClinicDays_PatientName]  DEFAULT ('') FOR [PatientName]
GO
ALTER TABLE [dbo].[ClinicDays] ADD  CONSTRAINT [DF_ClinicDays_KindTheVisit]  DEFAULT ((0)) FOR [VisitType]
GO
ALTER TABLE [dbo].[ClinicDays] ADD  CONSTRAINT [DF_ClinicDays_VisitCost]  DEFAULT ((0)) FOR [VisitCost]
GO
ALTER TABLE [dbo].[ClinicDays] ADD  CONSTRAINT [DF_ClinicDays_NewWeight_1]  DEFAULT ('') FOR [NewWeight]
GO
ALTER TABLE [dbo].[ClinicDays] ADD  CONSTRAINT [DF_ClinicDays_NewWaist]  DEFAULT ('') FOR [NewWaist]
GO
ALTER TABLE [dbo].[ClinicDays] ADD  CONSTRAINT [DF_ClinicDays_PlanOfTreatment]  DEFAULT ('') FOR [PlanOfTreatment]
GO
ALTER TABLE [dbo].[ClinicDays] ADD  CONSTRAINT [DF_ClinicDays_EatingHabits]  DEFAULT ('') FOR [EatingHabits]
GO
ALTER TABLE [dbo].[ClinicDays] ADD  CONSTRAINT [DF_ClinicDays_Notes]  DEFAULT ('') FOR [Notes]
GO
ALTER TABLE [dbo].[PatientsDetail] ADD  CONSTRAINT [DF_PatientsDetail_PatientName]  DEFAULT ('') FOR [PatientName]
GO
ALTER TABLE [dbo].[PatientsDetail] ADD  CONSTRAINT [DF_PatientsDetail_Code]  DEFAULT ('') FOR [Code]
GO
ALTER TABLE [dbo].[PatientsDetail] ADD  CONSTRAINT [DF_PatientsDetail_Age]  DEFAULT ('') FOR [Age]
GO
ALTER TABLE [dbo].[PatientsDetail] ADD  CONSTRAINT [DF_PatientsDetail_Occupation]  DEFAULT ('') FOR [Occupation]
GO
ALTER TABLE [dbo].[PatientsDetail] ADD  CONSTRAINT [DF_PatientsDetail_PhoneNumber]  DEFAULT ('') FOR [PhoneNumber]
GO
ALTER TABLE [dbo].[PatientsDetail] ADD  CONSTRAINT [DF_PatientsDetail_Height]  DEFAULT ('') FOR [Height]
GO
ALTER TABLE [dbo].[PatientsDetail] ADD  CONSTRAINT [DF_PatientsDetail_StartWeight]  DEFAULT ('') FOR [StartWeight]
GO
ALTER TABLE [dbo].[Reservation] ADD  CONSTRAINT [DF_Reservation_PatientID]  DEFAULT ((0)) FOR [PatientID]
GO
ALTER TABLE [dbo].[Reservation] ADD  CONSTRAINT [DF_Reservation_PatientName]  DEFAULT ('') FOR [PatientName]
GO
ALTER TABLE [dbo].[Reservation] ADD  CONSTRAINT [DF_Reservation_ReserveType]  DEFAULT ((0)) FOR [VisitType]
GO
ALTER TABLE [dbo].[Reservation] ADD  CONSTRAINT [DF_Reservation_ReserveName]  DEFAULT ('') FOR [VisitName]
GO
ALTER TABLE [dbo].[Reservation] ADD  CONSTRAINT [DF_Reservation_VisitCost]  DEFAULT ((0)) FOR [VisitCost]
GO
ALTER TABLE [dbo].[VisitsTypes] ADD  CONSTRAINT [DF_VisitsTypes_Num]  DEFAULT ((0)) FOR [Num]
GO
ALTER TABLE [dbo].[VisitsTypes] ADD  CONSTRAINT [DF_VisitsTypes_KindTheVisit]  DEFAULT ('') FOR [VisitKind]
GO
ALTER TABLE [dbo].[VisitsTypes] ADD  CONSTRAINT [DF_VisitsTypes_Amount]  DEFAULT ((0)) FOR [Amount]
GO
