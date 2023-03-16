USE [ql_Sinhvien]
GO
/****** Object:  Table [dbo].[Sinhvien]    Script Date: 3/16/2023 10:45:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sinhvien](
	[Masv] [int] NOT NULL,
	[sHoten] [nchar](10) NOT NULL,
	[dNgaysinh] [date] NOT NULL,
	[sGioitinh] [nchar](10) NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[Sinhvien] ([Masv], [sHoten], [dNgaysinh], [sGioitinh]) VALUES (1, N'truong    ', CAST(N'2002-10-10' AS Date), N'nam       ')
INSERT [dbo].[Sinhvien] ([Masv], [sHoten], [dNgaysinh], [sGioitinh]) VALUES (2, N'son       ', CAST(N'2002-01-01' AS Date), N'nam       ')
GO
