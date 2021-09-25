USE [Hospital]
GO
/****** Object:  Table [dbo].[Appointment]    Script Date: 9/25/2021 6:56:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Appointment](
	[DoctorID] [int] NOT NULL,
	[PatientID] [int] NOT NULL,
	[AppointmentDate] [date] NULL,
	[Description] [varchar](256) NULL,
 CONSTRAINT [pk_Appointment] PRIMARY KEY CLUSTERED 
(
	[DoctorID] ASC,
	[PatientID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Doctor]    Script Date: 9/25/2021 6:56:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Doctor](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](45) NOT NULL,
	[LastName] [varchar](45) NOT NULL,
	[BirthDate] [date] NULL,
	[Gender] [varchar](45) NULL,
	[Phone] [varchar](45) NOT NULL,
	[Email] [varchar](45) NOT NULL,
	[YearsExperience] [int] NULL,
	[Image] [varchar](100) NULL,
	[MedicalID] [int] NOT NULL,
	[UserID] [int] NULL,
 CONSTRAINT [PK__Doctor] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Drug]    Script Date: 9/25/2021 6:56:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Drug](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[UnitPrice] [nvarchar](50) NULL,
	[Quantity] [int] NULL,
	[Expiry] [date] NULL,
	[Manufacturer] [date] NULL,
 CONSTRAINT [PK__Drug] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DrugDetail]    Script Date: 9/25/2021 6:56:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DrugDetail](
	[PrescriptionID] [int] NOT NULL,
	[DrugID] [int] NOT NULL,
	[Quantity] [int] NULL,
	[UserGuide] [nvarchar](max) NULL,
 CONSTRAINT [pk_DrugDetail] PRIMARY KEY CLUSTERED 
(
	[PrescriptionID] ASC,
	[DrugID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Invoice]    Script Date: 9/25/2021 6:56:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Invoice](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CreatedDate] [datetime] NULL,
	[Fee] [int] NULL,
	[PrescriptionID] [int] NULL,
	[PatientID] [int] NULL,
	[NurseID] [int] NULL,
 CONSTRAINT [PK__Invoice] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Medical]    Script Date: 9/25/2021 6:56:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Medical](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Description] [nvarchar](4000) NULL,
 CONSTRAINT [PK__Medical] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MedicalExaminationCard]    Script Date: 9/25/2021 6:56:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MedicalExaminationCard](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Num] [int] NULL,
	[Date] [date] NOT NULL,
	[Fee] [decimal](18, 3) NULL,
	[Symptom] [nvarchar](max) NULL,
	[Diagnosis] [nvarchar](max) NULL,
	[PatientID] [int] NULL,
	[NurseID] [int] NULL,
 CONSTRAINT [PK__Medical_Examination_Card] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Nurse]    Script Date: 9/25/2021 6:56:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nurse](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[BirthDate] [date] NOT NULL,
	[Gender] [nvarchar](50) NULL,
	[Phone] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Image] [nvarchar](100) NULL,
	[MedicalID] [int] NOT NULL,
	[UserID] [int] NULL,
 CONSTRAINT [PK__Nurse] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Patient]    Script Date: 9/25/2021 6:56:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Patient](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [varchar](45) NULL,
	[BirthDate] [date] NOT NULL,
	[Gender] [nvarchar](50) NOT NULL,
	[Phone] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK__Patient] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Prescription]    Script Date: 9/25/2021 6:56:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Prescription](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CreatedDate] [date] NULL,
	[DoctorID] [int] NULL,
	[PatientID] [int] NULL,
 CONSTRAINT [PK__Prescription] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Service]    Script Date: 9/25/2021 6:56:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Service](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[MedicalID] [int] NULL,
 CONSTRAINT [PK__Service] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ServiceInvoice]    Script Date: 9/25/2021 6:56:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ServiceInvoice](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Fee] [decimal](18, 3) NULL,
	[CreatedDate] [date] NULL,
	[ServiceID] [int] NULL,
	[PatientID] [int] NULL,
	[NurseID] [int] NULL,
 CONSTRAINT [PK_ServiceInvoice] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 9/25/2021 6:56:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[ID] [int] NOT NULL,
	[Name] [varchar](45) NOT NULL,
	[Password] [varchar](100) NOT NULL,
	[Role_User] [nchar](10) NOT NULL,
 CONSTRAINT [PK__Users__3214EC27B2452FEA] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Doctor] ON 

INSERT [dbo].[Doctor] ([ID], [FirstName], [LastName], [BirthDate], [Gender], [Phone], [Email], [YearsExperience], [Image], [MedicalID], [UserID]) VALUES (1, N'Lê', N'Le', CAST(N'2021-09-25' AS Date), N'nam', N'049300', N'sad@gmail.com', NULL, NULL, 1, NULL)
INSERT [dbo].[Doctor] ([ID], [FirstName], [LastName], [BirthDate], [Gender], [Phone], [Email], [YearsExperience], [Image], [MedicalID], [UserID]) VALUES (2, N'dsa', N'ád', CAST(N'2021-09-25' AS Date), N'sda', N'sad', N'ád', NULL, NULL, 1, NULL)
INSERT [dbo].[Doctor] ([ID], [FirstName], [LastName], [BirthDate], [Gender], [Phone], [Email], [YearsExperience], [Image], [MedicalID], [UserID]) VALUES (3, N'Lê lai', N'Le', CAST(N'2021-09-25' AS Date), N'nam', N'049300', N'sad@gmail.com', NULL, NULL, 2, NULL)
INSERT [dbo].[Doctor] ([ID], [FirstName], [LastName], [BirthDate], [Gender], [Phone], [Email], [YearsExperience], [Image], [MedicalID], [UserID]) VALUES (4, N'á', N'á', CAST(N'2021-09-25' AS Date), N'sad', N'á', N'sad', NULL, NULL, 1, NULL)
INSERT [dbo].[Doctor] ([ID], [FirstName], [LastName], [BirthDate], [Gender], [Phone], [Email], [YearsExperience], [Image], [MedicalID], [UserID]) VALUES (5, N'á', N'á', CAST(N'2021-09-23' AS Date), N'sad', N'á', N'sad', NULL, NULL, 1, NULL)
SET IDENTITY_INSERT [dbo].[Doctor] OFF
GO
SET IDENTITY_INSERT [dbo].[Medical] ON 

INSERT [dbo].[Medical] ([ID], [Name], [Description]) VALUES (1, N'Tai mũi hong', N'Chuyên khoa về tai mũi họng')
INSERT [dbo].[Medical] ([ID], [Name], [Description]) VALUES (2, N'Tim mạch', N'nghiên cứu
tim của con người
khám chữa các ')
SET IDENTITY_INSERT [dbo].[Medical] OFF
GO
ALTER TABLE [dbo].[Appointment]  WITH CHECK ADD  CONSTRAINT [FK_Appointment_Doctor] FOREIGN KEY([DoctorID])
REFERENCES [dbo].[Doctor] ([ID])
GO
ALTER TABLE [dbo].[Appointment] CHECK CONSTRAINT [FK_Appointment_Doctor]
GO
ALTER TABLE [dbo].[Appointment]  WITH CHECK ADD  CONSTRAINT [FK_Appointment_Patient] FOREIGN KEY([PatientID])
REFERENCES [dbo].[Patient] ([ID])
GO
ALTER TABLE [dbo].[Appointment] CHECK CONSTRAINT [FK_Appointment_Patient]
GO
ALTER TABLE [dbo].[Doctor]  WITH CHECK ADD  CONSTRAINT [FK_Doctor_Medical] FOREIGN KEY([MedicalID])
REFERENCES [dbo].[Medical] ([ID])
GO
ALTER TABLE [dbo].[Doctor] CHECK CONSTRAINT [FK_Doctor_Medical]
GO
ALTER TABLE [dbo].[Doctor]  WITH CHECK ADD  CONSTRAINT [FK_Doctor_Users] FOREIGN KEY([UserID])
REFERENCES [dbo].[Users] ([ID])
GO
ALTER TABLE [dbo].[Doctor] CHECK CONSTRAINT [FK_Doctor_Users]
GO
ALTER TABLE [dbo].[DrugDetail]  WITH CHECK ADD  CONSTRAINT [FK_DrugDetail_Drug] FOREIGN KEY([DrugID])
REFERENCES [dbo].[Drug] ([ID])
GO
ALTER TABLE [dbo].[DrugDetail] CHECK CONSTRAINT [FK_DrugDetail_Drug]
GO
ALTER TABLE [dbo].[DrugDetail]  WITH CHECK ADD  CONSTRAINT [FK_DrugDetail_Prescription] FOREIGN KEY([PrescriptionID])
REFERENCES [dbo].[Prescription] ([ID])
GO
ALTER TABLE [dbo].[DrugDetail] CHECK CONSTRAINT [FK_DrugDetail_Prescription]
GO
ALTER TABLE [dbo].[Invoice]  WITH CHECK ADD  CONSTRAINT [FK_Invoice_Nurse] FOREIGN KEY([NurseID])
REFERENCES [dbo].[Nurse] ([ID])
GO
ALTER TABLE [dbo].[Invoice] CHECK CONSTRAINT [FK_Invoice_Nurse]
GO
ALTER TABLE [dbo].[Invoice]  WITH CHECK ADD  CONSTRAINT [FK_Invoice_Patient] FOREIGN KEY([PatientID])
REFERENCES [dbo].[Patient] ([ID])
GO
ALTER TABLE [dbo].[Invoice] CHECK CONSTRAINT [FK_Invoice_Patient]
GO
ALTER TABLE [dbo].[Invoice]  WITH CHECK ADD  CONSTRAINT [FK_Invoice_Prescription] FOREIGN KEY([PrescriptionID])
REFERENCES [dbo].[Prescription] ([ID])
GO
ALTER TABLE [dbo].[Invoice] CHECK CONSTRAINT [FK_Invoice_Prescription]
GO
ALTER TABLE [dbo].[MedicalExaminationCard]  WITH CHECK ADD  CONSTRAINT [FK_MedicalExaminationCard_Nurse] FOREIGN KEY([NurseID])
REFERENCES [dbo].[Nurse] ([ID])
GO
ALTER TABLE [dbo].[MedicalExaminationCard] CHECK CONSTRAINT [FK_MedicalExaminationCard_Nurse]
GO
ALTER TABLE [dbo].[MedicalExaminationCard]  WITH CHECK ADD  CONSTRAINT [FK_MedicalExaminationCard_Patient] FOREIGN KEY([PatientID])
REFERENCES [dbo].[Patient] ([ID])
GO
ALTER TABLE [dbo].[MedicalExaminationCard] CHECK CONSTRAINT [FK_MedicalExaminationCard_Patient]
GO
ALTER TABLE [dbo].[Nurse]  WITH CHECK ADD  CONSTRAINT [FK_Nurse_Medical] FOREIGN KEY([MedicalID])
REFERENCES [dbo].[Medical] ([ID])
GO
ALTER TABLE [dbo].[Nurse] CHECK CONSTRAINT [FK_Nurse_Medical]
GO
ALTER TABLE [dbo].[Nurse]  WITH CHECK ADD  CONSTRAINT [FK_Nurse_Users] FOREIGN KEY([UserID])
REFERENCES [dbo].[Users] ([ID])
GO
ALTER TABLE [dbo].[Nurse] CHECK CONSTRAINT [FK_Nurse_Users]
GO
ALTER TABLE [dbo].[Prescription]  WITH CHECK ADD  CONSTRAINT [FK_Prescription_Doctor] FOREIGN KEY([DoctorID])
REFERENCES [dbo].[Doctor] ([ID])
GO
ALTER TABLE [dbo].[Prescription] CHECK CONSTRAINT [FK_Prescription_Doctor]
GO
ALTER TABLE [dbo].[Prescription]  WITH CHECK ADD  CONSTRAINT [FK_Prescription_Patient] FOREIGN KEY([PatientID])
REFERENCES [dbo].[Patient] ([ID])
GO
ALTER TABLE [dbo].[Prescription] CHECK CONSTRAINT [FK_Prescription_Patient]
GO
ALTER TABLE [dbo].[Service]  WITH CHECK ADD  CONSTRAINT [FK_Service_Medical] FOREIGN KEY([MedicalID])
REFERENCES [dbo].[Medical] ([ID])
GO
ALTER TABLE [dbo].[Service] CHECK CONSTRAINT [FK_Service_Medical]
GO
ALTER TABLE [dbo].[ServiceInvoice]  WITH CHECK ADD  CONSTRAINT [FK_ServiceInvoice_Nurse] FOREIGN KEY([NurseID])
REFERENCES [dbo].[Nurse] ([ID])
GO
ALTER TABLE [dbo].[ServiceInvoice] CHECK CONSTRAINT [FK_ServiceInvoice_Nurse]
GO
ALTER TABLE [dbo].[ServiceInvoice]  WITH CHECK ADD  CONSTRAINT [FK_ServiceInvoice_Patient] FOREIGN KEY([PatientID])
REFERENCES [dbo].[Patient] ([ID])
GO
ALTER TABLE [dbo].[ServiceInvoice] CHECK CONSTRAINT [FK_ServiceInvoice_Patient]
GO
ALTER TABLE [dbo].[ServiceInvoice]  WITH CHECK ADD  CONSTRAINT [FK_ServiceInvoice_Service] FOREIGN KEY([ServiceID])
REFERENCES [dbo].[Service] ([ID])
GO
ALTER TABLE [dbo].[ServiceInvoice] CHECK CONSTRAINT [FK_ServiceInvoice_Service]
GO
