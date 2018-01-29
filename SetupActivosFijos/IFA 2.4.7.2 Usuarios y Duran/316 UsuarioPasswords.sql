
/****** Object:  Table [dbo].[UsuarioPasswords]    Script Date: 12/28/2017 10:30:01 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[UsuarioPasswords](
	[Usuari_Codigo] [char](18) NOT NULL,
	[Histor_Fecha] [datetime] NOT NULL,
	[Histor_Password] [varbinary](255) NULL,
 CONSTRAINT [PK_UsuarioPasswords] PRIMARY KEY CLUSTERED 
(
	[Usuari_Codigo] ASC,
	[Histor_Fecha] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


