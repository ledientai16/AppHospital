USE [master]
GO
/****** Object:  Database [Hospital]    Script Date: 10/2/2021 10:31:29 PM ******/
CREATE DATABASE [Hospital]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Hospital', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLSERVER2017\MSSQL\DATA\Hospital.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Hospital_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLSERVER2017\MSSQL\DATA\Hospital_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Hospital] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Hospital].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Hospital] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Hospital] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Hospital] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Hospital] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Hospital] SET ARITHABORT OFF 
GO
ALTER DATABASE [Hospital] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Hospital] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Hospital] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Hospital] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Hospital] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Hospital] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Hospital] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Hospital] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Hospital] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Hospital] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Hospital] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Hospital] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Hospital] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Hospital] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Hospital] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Hospital] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Hospital] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Hospital] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Hospital] SET  MULTI_USER 
GO
ALTER DATABASE [Hospital] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Hospital] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Hospital] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Hospital] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Hospital] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Hospital] SET QUERY_STORE = OFF
GO
USE [Hospital]
GO
/****** Object:  Table [dbo].[Appointment]    Script Date: 10/2/2021 10:31:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Appointment](
	[DoctorID] [int] NOT NULL,
	[PatientID] [int] NOT NULL,
	[AppointmentDate] [datetime] NULL,
	[Description] [varchar](256) NULL,
 CONSTRAINT [pk_Appointment] PRIMARY KEY CLUSTERED 
(
	[DoctorID] ASC,
	[PatientID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Doctor]    Script Date: 10/2/2021 10:31:29 PM ******/
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
/****** Object:  Table [dbo].[Drug]    Script Date: 10/2/2021 10:31:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Drug](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[UnitPrice] [decimal](18, 0) NULL,
	[Quantity] [int] NULL,
	[Expiry] [date] NULL,
	[Manufacturer] [date] NULL,
	[Type] [nvarchar](50) NULL,
 CONSTRAINT [PK__Drug] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DrugDetail]    Script Date: 10/2/2021 10:31:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DrugDetail](
	[PrescriptionID] [int] NOT NULL,
	[DrugID] [int] NOT NULL,
	[Quantity] [int] NULL,
	[UserGuide] [nvarchar](max) NULL,
	[UnitPrice] [decimal](18, 0) NULL,
 CONSTRAINT [pk_DrugDetail] PRIMARY KEY CLUSTERED 
(
	[PrescriptionID] ASC,
	[DrugID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Invoice]    Script Date: 10/2/2021 10:31:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Invoice](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CreatedDate] [datetime] NULL,
	[Fee] [decimal](18, 0) NULL,
	[PrescriptionID] [int] NULL,
	[NurseID] [int] NULL,
 CONSTRAINT [PK__Invoice] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Medical]    Script Date: 10/2/2021 10:31:29 PM ******/
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
/****** Object:  Table [dbo].[Nurse]    Script Date: 10/2/2021 10:31:29 PM ******/
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
/****** Object:  Table [dbo].[Patient]    Script Date: 10/2/2021 10:31:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Patient](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](100) NULL,
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
/****** Object:  Table [dbo].[Prescription]    Script Date: 10/2/2021 10:31:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Prescription](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CreatedDate] [datetime] NULL,
	[DoctorID] [int] NULL,
	[PatientID] [int] NULL,
	[Amount] [decimal](18, 0) NULL,
	[Diagnosis] [nvarchar](max) NULL,
	[Appointment] [datetime] NULL,
 CONSTRAINT [PK__Prescription] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Service]    Script Date: 10/2/2021 10:31:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Service](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[MedicalID] [int] NULL,
	[Description] [nvarchar](max) NULL,
	[Fee] [decimal](18, 0) NULL,
 CONSTRAINT [PK__Service] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ServiceInvoice]    Script Date: 10/2/2021 10:31:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ServiceInvoice](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Fee] [decimal](18, 0) NULL,
	[CreatedDate] [datetime] NULL,
	[ServiceID] [int] NULL,
	[PatientID] [int] NULL,
	[NurseID] [int] NULL,
 CONSTRAINT [PK_ServiceInvoice] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 10/2/2021 10:31:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [varchar](45) NOT NULL,
	[Password] [varchar](100) NOT NULL,
	[Role_User] [nchar](15) NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[Active] [bit] NOT NULL,
 CONSTRAINT [PK__Users__3214EC27B2452FEA] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Doctor] ON 

INSERT [dbo].[Doctor] ([ID], [FirstName], [LastName], [BirthDate], [Gender], [Phone], [Email], [YearsExperience], [Image], [MedicalID], [UserID]) VALUES (12, N'Lê', N'Bác Si', CAST(N'2021-10-02' AS Date), N'nam', N'0898797952', N'123@gmail.com', NULL, NULL, 2, 2)
SET IDENTITY_INSERT [dbo].[Doctor] OFF
GO
SET IDENTITY_INSERT [dbo].[Drug] ON 

INSERT [dbo].[Drug] ([ID], [Name], [UnitPrice], [Quantity], [Expiry], [Manufacturer], [Type]) VALUES (1, N'paresolamin', CAST(100 AS Decimal(18, 0)), 111, CAST(N'2021-10-01' AS Date), CAST(N'2021-10-14' AS Date), N'vỉ')
INSERT [dbo].[Drug] ([ID], [Name], [UnitPrice], [Quantity], [Expiry], [Manufacturer], [Type]) VALUES (2, N'Adrenalin', CAST(1112 AS Decimal(18, 0)), 314214214, CAST(N'2021-10-02' AS Date), CAST(N'2021-10-02' AS Date), N'viên')
SET IDENTITY_INSERT [dbo].[Drug] OFF
GO
INSERT [dbo].[DrugDetail] ([PrescriptionID], [DrugID], [Quantity], [UserGuide], [UnitPrice]) VALUES (8, 1, 11, N'ngày 2 viên sáng chiều', CAST(100 AS Decimal(18, 0)))
INSERT [dbo].[DrugDetail] ([PrescriptionID], [DrugID], [Quantity], [UserGuide], [UnitPrice]) VALUES (8, 2, 11, N'ngày 2 viên sáng chiều', CAST(1112 AS Decimal(18, 0)))
INSERT [dbo].[DrugDetail] ([PrescriptionID], [DrugID], [Quantity], [UserGuide], [UnitPrice]) VALUES (9, 1, 3, N'55555555', CAST(100 AS Decimal(18, 0)))
INSERT [dbo].[DrugDetail] ([PrescriptionID], [DrugID], [Quantity], [UserGuide], [UnitPrice]) VALUES (9, 2, 1, N'', CAST(1112 AS Decimal(18, 0)))
INSERT [dbo].[DrugDetail] ([PrescriptionID], [DrugID], [Quantity], [UserGuide], [UnitPrice]) VALUES (10, 1, 1, N'', CAST(100 AS Decimal(18, 0)))
INSERT [dbo].[DrugDetail] ([PrescriptionID], [DrugID], [Quantity], [UserGuide], [UnitPrice]) VALUES (12, 2, 1, N'Khó tiêu và buồn ngủ', CAST(1112 AS Decimal(18, 0)))
GO
SET IDENTITY_INSERT [dbo].[Medical] ON 

INSERT [dbo].[Medical] ([ID], [Name], [Description]) VALUES (1, N'Tai mũi hong', N'Chuyên khoa về tai mũi họng')
INSERT [dbo].[Medical] ([ID], [Name], [Description]) VALUES (2, N'Tim mạch', N'nghiên cứu
tim của con người
khám chữa các ')
INSERT [dbo].[Medical] ([ID], [Name], [Description]) VALUES (4, N'ád', N'ád')
SET IDENTITY_INSERT [dbo].[Medical] OFF
GO
SET IDENTITY_INSERT [dbo].[Nurse] ON 

INSERT [dbo].[Nurse] ([ID], [FirstName], [LastName], [BirthDate], [Gender], [Phone], [Email], [Image], [MedicalID], [UserID]) VALUES (1, N',fsf', N'kmfdfád', CAST(N'2021-10-01' AS Date), N'nữ', N'sadsd', N'dá', NULL, 1, NULL)
INSERT [dbo].[Nurse] ([ID], [FirstName], [LastName], [BirthDate], [Gender], [Phone], [Email], [Image], [MedicalID], [UserID]) VALUES (2, N'Nguyên', N'Y tá', CAST(N'2021-10-02' AS Date), N'nữ', N'012345678', N'ohgk@gmail.com', NULL, 2, 4)
SET IDENTITY_INSERT [dbo].[Nurse] OFF
GO
SET IDENTITY_INSERT [dbo].[Patient] ON 

INSERT [dbo].[Patient] ([ID], [FirstName], [LastName], [BirthDate], [Gender], [Phone], [Email]) VALUES (1, N'Lê', N'Th? A', CAST(N'2021-10-02' AS Date), N'nữ', N'0123456789', N'123@gmail.com')
INSERT [dbo].[Patient] ([ID], [FirstName], [LastName], [BirthDate], [Gender], [Phone], [Email]) VALUES (2, N'Nguyễn văn ', N'C', CAST(N'2000-10-12' AS Date), N'nam', N'1223213', N'gkfk@gmail.com')
SET IDENTITY_INSERT [dbo].[Patient] OFF
GO
SET IDENTITY_INSERT [dbo].[Prescription] ON 

INSERT [dbo].[Prescription] ([ID], [CreatedDate], [DoctorID], [PatientID], [Amount], [Diagnosis], [Appointment]) VALUES (5, CAST(N'2021-10-02T19:23:04.190' AS DateTime), 12, 1, NULL, N'', CAST(N'2021-10-02T19:22:59.773' AS DateTime))
INSERT [dbo].[Prescription] ([ID], [CreatedDate], [DoctorID], [PatientID], [Amount], [Diagnosis], [Appointment]) VALUES (6, CAST(N'2021-10-02T19:24:18.203' AS DateTime), 12, 1, NULL, N'', CAST(N'2021-10-02T19:24:02.070' AS DateTime))
INSERT [dbo].[Prescription] ([ID], [CreatedDate], [DoctorID], [PatientID], [Amount], [Diagnosis], [Appointment]) VALUES (7, CAST(N'2021-10-02T19:24:31.163' AS DateTime), 12, 1, NULL, N'', CAST(N'2021-10-02T19:24:02.070' AS DateTime))
INSERT [dbo].[Prescription] ([ID], [CreatedDate], [DoctorID], [PatientID], [Amount], [Diagnosis], [Appointment]) VALUES (8, CAST(N'2021-10-02T19:24:36.563' AS DateTime), 12, 2, NULL, N'', CAST(N'2021-10-02T19:24:02.070' AS DateTime))
INSERT [dbo].[Prescription] ([ID], [CreatedDate], [DoctorID], [PatientID], [Amount], [Diagnosis], [Appointment]) VALUES (9, CAST(N'2021-10-02T19:36:42.787' AS DateTime), 12, 2, NULL, N'', CAST(N'2021-10-02T19:24:02.070' AS DateTime))
INSERT [dbo].[Prescription] ([ID], [CreatedDate], [DoctorID], [PatientID], [Amount], [Diagnosis], [Appointment]) VALUES (10, NULL, NULL, NULL, NULL, N'covid 12', CAST(N'2021-10-02T19:24:02.070' AS DateTime))
INSERT [dbo].[Prescription] ([ID], [CreatedDate], [DoctorID], [PatientID], [Amount], [Diagnosis], [Appointment]) VALUES (12, CAST(N'2021-10-02T21:11:52.543' AS DateTime), 12, 2, NULL, N'covid 12', CAST(N'2021-10-02T19:24:02.070' AS DateTime))
SET IDENTITY_INSERT [dbo].[Prescription] OFF
GO
SET IDENTITY_INSERT [dbo].[Service] ON 

INSERT [dbo].[Service] ([ID], [Name], [MedicalID], [Description], [Fee]) VALUES (2, N'Mát xa mũi', 1, N'mát xa mũi đầy tê tái', CAST(100000 AS Decimal(18, 0)))
INSERT [dbo].[Service] ([ID], [Name], [MedicalID], [Description], [Fee]) VALUES (3, N'Nội sôi', 2, N'Dịch vụ sôi nội tạng ', CAST(100000 AS Decimal(18, 0)))
SET IDENTITY_INSERT [dbo].[Service] OFF
GO
SET IDENTITY_INSERT [dbo].[ServiceInvoice] ON 

INSERT [dbo].[ServiceInvoice] ([ID], [Fee], [CreatedDate], [ServiceID], [PatientID], [NurseID]) VALUES (1, CAST(100000 AS Decimal(18, 0)), CAST(N'2021-10-02T08:03:47.967' AS DateTime), 2, 1, 2)
INSERT [dbo].[ServiceInvoice] ([ID], [Fee], [CreatedDate], [ServiceID], [PatientID], [NurseID]) VALUES (2, CAST(100000 AS Decimal(18, 0)), CAST(N'2021-10-02T08:18:44.403' AS DateTime), 2, 1, 2)
INSERT [dbo].[ServiceInvoice] ([ID], [Fee], [CreatedDate], [ServiceID], [PatientID], [NurseID]) VALUES (3, CAST(100000 AS Decimal(18, 0)), CAST(N'2021-10-02T08:21:14.747' AS DateTime), 2, 1, 2)
SET IDENTITY_INSERT [dbo].[ServiceInvoice] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([ID], [UserName], [Password], [Role_User], [CreatedDate], [Active]) VALUES (1, N'admin', N'123456', N'ROLE_ADMIN     ', CAST(N'2021-10-02T01:20:26.847' AS DateTime), 1)
INSERT [dbo].[Users] ([ID], [UserName], [Password], [Role_User], [CreatedDate], [Active]) VALUES (2, N'doctor1', N'123456', N'ROLE_DOCTOR    ', CAST(N'2021-10-02T01:34:26.587' AS DateTime), 1)
INSERT [dbo].[Users] ([ID], [UserName], [Password], [Role_User], [CreatedDate], [Active]) VALUES (3, N'doctor2', N'123456', N'ROLE_DOCTOR    ', CAST(N'2021-10-02T01:34:37.633' AS DateTime), 1)
INSERT [dbo].[Users] ([ID], [UserName], [Password], [Role_User], [CreatedDate], [Active]) VALUES (4, N'nurse2', N'123456', N'ROLE_NURSE     ', CAST(N'2021-10-02T14:56:16.990' AS DateTime), 1)
SET IDENTITY_INSERT [dbo].[Users] OFF
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
ALTER TABLE [dbo].[Invoice]  WITH CHECK ADD  CONSTRAINT [FK_Invoice_Prescription] FOREIGN KEY([PrescriptionID])
REFERENCES [dbo].[Prescription] ([ID])
GO
ALTER TABLE [dbo].[Invoice] CHECK CONSTRAINT [FK_Invoice_Prescription]
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
/****** Object:  StoredProcedure [dbo].[userLogin]    Script Date: 10/2/2021 10:31:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[userLogin] @username NVARCHAR(50),  @password NVARCHAR(50)
AS

BEGIN
SET NOCOUNT ON
declare @sl int 
SELECT   @sl = count(*)
FROM dbo.Users
WHERE UserName=@username AND [Password]=@password 
select @sl as alias 
end
GO
USE [master]
GO
ALTER DATABASE [Hospital] SET  READ_WRITE 
GO
