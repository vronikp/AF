
/****** Object:  Table [dbo].[TransaccionBaja]    Script Date: 03/08/2018 17:01:05 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[TransaccionBaja](
	[TraBaj_Codigo] [int] NOT NULL,
	[Usuari_Codigo] [char](18) NOT NULL,
	[TraBaj_Fecha] [datetime] NOT NULL,
	[TraBaj_Observacion] [nvarchar](350) NULL,
	[Parame_TipoBaja] [int] NOT NULL,
	[Pardet_TipoBaja] [int] NOT NULL,
 CONSTRAINT [PK_TransaccionBaja] PRIMARY KEY CLUSTERED 
(
	[TraBaj_Codigo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[TransaccionBaja]  WITH CHECK ADD  CONSTRAINT [FK_TransaccionBaja_ParametroDet] FOREIGN KEY([Parame_TipoBaja], [Pardet_TipoBaja])
REFERENCES [dbo].[ParametroDet] ([Parame_Codigo], [Pardet_Secuencia])
GO

ALTER TABLE [dbo].[TransaccionBaja] CHECK CONSTRAINT [FK_TransaccionBaja_ParametroDet]
GO


