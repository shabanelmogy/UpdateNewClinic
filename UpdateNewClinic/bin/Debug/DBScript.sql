USE [Clinic]

CREATE TABLE [dbo].[ClinicDays](
	[VisitDate] [date] NULL,
	[PatientID] [int] NULL,
	[PatientName] [nvarchar](300) NULL,
	[VisitType] [smallint] NULL,
	[VisitCost] [decimal](6, 2) NULL,
	[NewWeight] [nvarchar](50) NULL,
	[NewWaist] [nvarchar](50) NULL,
	[PlanOfTreatment] [nvarchar](1000) NULL,
	[EatingHabits] [nvarchar](1000) NULL,
	[Notes] [nvarchar](1000) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PatientsDetail]    Script Date: 08/04/2022 19:33:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PatientsDetail](
	[PatientNum] [int] NOT NULL,
	[PatientName] [nvarchar](250) NULL,
	[Code] [nvarchar](30) NULL,
	[Age] [varchar](10) NULL,
	[Occupation] [nvarchar](50) NULL,
	[PhoneNumber] [nvarchar](11) NULL,
	[FirstDate] [date] NULL,
	[Height] [nvarchar](10) NULL,
	[StartWeight] [nvarchar](10) NULL,
 CONSTRAINT [PK_PatientsDetail_1] PRIMARY KEY CLUSTERED 
(
	[PatientNum] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reservation]    Script Date: 08/04/2022 19:33:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reservation](
	[ReservID] [int] IDENTITY(1,1) NOT NULL,
	[PatientID] [int] NOT NULL,
	[PatientName] [nvarchar](50) NOT NULL,
	[ReserveDate] [date] NOT NULL,
	[ReserveType] [smallint] NOT NULL,
	[ReserveName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Reservation_1] PRIMARY KEY CLUSTERED 
(
	[ReservID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VisitsTypes]    Script Date: 08/04/2022 19:33:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VisitsTypes](
	[Num] [int] NOT NULL,
	[VisitKind] [nvarchar](50) NULL,
	[Amount] [float] NULL,
 CONSTRAINT [PK_VisitsTypes] PRIMARY KEY CLUSTERED 
(
	[Num] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[Patientdata]    Script Date: 08/04/2022 19:33:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create View [dbo].[Patientdata] as 
SELECT   ClinicDays.PatientID, ClinicDays.PatientName, PatientsDetail.Code, PatientsDetail.Age, PatientsDetail.Occupation, PatientsDetail.PhoneNumber, PatientsDetail.FirstDate, PatientsDetail.Height, PatientsDetail.StartWeight, 
                         ClinicDays.VisitType, ClinicDays.VisitCost, ClinicDays.NewWeight, ClinicDays.NewWaist, ClinicDays.PlanOfTreatment, ClinicDays.EatingHabits, ClinicDays.Notes, VisitsTypes.VisitKind
FROM            VisitsTypes INNER JOIN
                         ClinicDays INNER JOIN
                         PatientsDetail ON ClinicDays.PatientID = PatientsDetail.PatientNum ON VisitsTypes.Num = ClinicDays.VisitType
GO
ALTER TABLE [dbo].[ClinicDays] ADD  CONSTRAINT [DF_ClinicDays_PatientID]  DEFAULT ((0)) FOR [PatientID]
GO
ALTER TABLE [dbo].[ClinicDays] ADD  CONSTRAINT [DF_ClinicDays_PatientName]  DEFAULT ('') FOR [PatientName]
GO
ALTER TABLE [dbo].[ClinicDays] ADD  CONSTRAINT [DF_ClinicDays_KindTheVisit]  DEFAULT ((0)) FOR [VisitType]
GO
ALTER TABLE [dbo].[ClinicDays] ADD  CONSTRAINT [DF_ClinicDays_NewWeight_1]  DEFAULT ((0)) FOR [NewWeight]
GO
ALTER TABLE [dbo].[ClinicDays] ADD  CONSTRAINT [DF_ClinicDays_NewWaist]  DEFAULT ((0)) FOR [NewWaist]
GO
ALTER TABLE [dbo].[ClinicDays] ADD  CONSTRAINT [DF_ClinicDays_PlanOfTreatment]  DEFAULT ('') FOR [PlanOfTreatment]
GO
ALTER TABLE [dbo].[ClinicDays] ADD  CONSTRAINT [DF_ClinicDays_EatingHabits]  DEFAULT ('') FOR [EatingHabits]
GO
ALTER TABLE [dbo].[ClinicDays] ADD  CONSTRAINT [DF_ClinicDays_Notes]  DEFAULT ('') FOR [Notes]
GO
ALTER TABLE [dbo].[PatientsDetail] ADD  CONSTRAINT [DF_PatientsDetail_PatientName]  DEFAULT ('') FOR [PatientName]
GO
ALTER TABLE [dbo].[PatientsDetail] ADD  CONSTRAINT [DF_PatientsDetail_Code]  DEFAULT ((0)) FOR [Code]
GO
ALTER TABLE [dbo].[PatientsDetail] ADD  CONSTRAINT [DF_PatientsDetail_Age]  DEFAULT ((0)) FOR [Age]
GO
ALTER TABLE [dbo].[PatientsDetail] ADD  CONSTRAINT [DF_PatientsDetail_Occupation]  DEFAULT ('') FOR [Occupation]
GO
ALTER TABLE [dbo].[PatientsDetail] ADD  CONSTRAINT [DF_PatientsDetail_PhoneNumber]  DEFAULT ('') FOR [PhoneNumber]
GO
ALTER TABLE [dbo].[PatientsDetail] ADD  CONSTRAINT [DF_PatientsDetail_Height]  DEFAULT ((0)) FOR [Height]
GO
ALTER TABLE [dbo].[PatientsDetail] ADD  CONSTRAINT [DF_PatientsDetail_StartWeight]  DEFAULT ((0)) FOR [StartWeight]
GO
ALTER TABLE [dbo].[Reservation] ADD  CONSTRAINT [DF_Reservation_PatientID]  DEFAULT ((0)) FOR [PatientID]
GO
ALTER TABLE [dbo].[Reservation] ADD  CONSTRAINT [DF_Reservation_PatientName]  DEFAULT ('') FOR [PatientName]
GO
ALTER TABLE [dbo].[Reservation] ADD  CONSTRAINT [DF_Reservation_ReserveName]  DEFAULT ('') FOR [ReserveName]
GO
ALTER TABLE [dbo].[VisitsTypes] ADD  CONSTRAINT [DF_VisitsTypes_Num]  DEFAULT ((0)) FOR [Num]
GO
ALTER TABLE [dbo].[VisitsTypes] ADD  CONSTRAINT [DF_VisitsTypes_KindTheVisit]  DEFAULT ('') FOR [VisitKind]
GO
ALTER TABLE [dbo].[VisitsTypes] ADD  CONSTRAINT [DF_VisitsTypes_Amount]  DEFAULT ((0)) FOR [Amount]
GO
