
USE [Login]
GO
/****** Object:  Table [dbo].[Assignments]    Script Date: 12/3/2018 2:19:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Assignments](
	[Assignments] [nchar](10) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Table_1]    Script Date: 12/3/2018 2:19:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Table_1](
	[UserID] [nchar](250) NOT NULL,
	[Email] [varchar](254) NOT NULL,
	[Password] [nvarchar](max) NOT NULL,
	[ConfirmPassword] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Table_1] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
