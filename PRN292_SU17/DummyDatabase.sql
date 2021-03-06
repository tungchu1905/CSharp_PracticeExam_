USE [PRN292_SU17_1]
GO
/****** Object:  Table [dbo].[DummyMaster]    Script Date: 06/24/2017 20:57:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DummyMaster](
	[master_id] [int] NOT NULL,
	[master_name] [varchar](150) NOT NULL,
 CONSTRAINT [PK_DummyMaster] PRIMARY KEY CLUSTERED 
(
	[master_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[DummyMaster] ([master_id], [master_name]) VALUES (1, N'A')
INSERT [dbo].[DummyMaster] ([master_id], [master_name]) VALUES (2, N'B')
INSERT [dbo].[DummyMaster] ([master_id], [master_name]) VALUES (3, N'C')
INSERT [dbo].[DummyMaster] ([master_id], [master_name]) VALUES (4, N'D')
/****** Object:  Table [dbo].[DummyDetail]    Script Date: 06/24/2017 20:57:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DummyDetail](
	[detail_id] [int] NOT NULL,
	[detail_name] [varchar](150) NOT NULL,
	[master_id] [int] NOT NULL,
 CONSTRAINT [PK_DummyDetail] PRIMARY KEY CLUSTERED 
(
	[detail_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[DummyDetail] ([detail_id], [detail_name], [master_id]) VALUES (1, N'AA', 1)
INSERT [dbo].[DummyDetail] ([detail_id], [detail_name], [master_id]) VALUES (2, N'AB', 1)
INSERT [dbo].[DummyDetail] ([detail_id], [detail_name], [master_id]) VALUES (3, N'BA', 2)
INSERT [dbo].[DummyDetail] ([detail_id], [detail_name], [master_id]) VALUES (4, N'BB', 2)
INSERT [dbo].[DummyDetail] ([detail_id], [detail_name], [master_id]) VALUES (5, N'BC', 3)
/****** Object:  ForeignKey [FK_DummyDetail_DummyMaster]    Script Date: 06/24/2017 20:57:06 ******/
ALTER TABLE [dbo].[DummyDetail]  WITH CHECK ADD  CONSTRAINT [FK_DummyDetail_DummyMaster] FOREIGN KEY([master_id])
REFERENCES [dbo].[DummyMaster] ([master_id])
GO
ALTER TABLE [dbo].[DummyDetail] CHECK CONSTRAINT [FK_DummyDetail_DummyMaster]
GO
