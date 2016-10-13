/****** Object:  Table [dbo].[BCatSecciones]    Script Date: 07/29/2013 15:14:09 ******/

BEGIN TRY
	BEGIN TRANSACTION
	SET ANSI_NULLS ON

	SET QUOTED_IDENTIFIER ON

	SET ANSI_PADDING ON

	CREATE TABLE [dbo].[BCatSecciones](
		[Id] [int] NOT NULL,
		[Nombre] [varchar](50) NOT NULL,
	 CONSTRAINT [PK_BCatSeccion] PRIMARY KEY CLUSTERED 
	(
		[Id] ASC
	)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
	) ON [PRIMARY]

	SET ANSI_PADDING OFF


	/****** Object:  Table [dbo].[BCatRamas]    Script Date: 07/29/2013 15:14:22 ******/
	SET ANSI_NULLS ON

	SET QUOTED_IDENTIFIER ON

	SET ANSI_PADDING ON

	CREATE TABLE [dbo].[BCatRamas](
		[IdSeccion] [int] NOT NULL,
		[Id] [int] NOT NULL,
		[Nombre] [varchar](50) NOT NULL,
	 CONSTRAINT [PK_BCatRamas] PRIMARY KEY CLUSTERED 
	(
		[IdSeccion] ASC,
		[Id] ASC
	)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
	) ON [PRIMARY]

	SET ANSI_PADDING OFF

	ALTER TABLE [dbo].[BCatRamas]  WITH CHECK ADD  CONSTRAINT [FK_BCatRamas_BCatSecciones] FOREIGN KEY([IdSeccion])
	REFERENCES [dbo].[BCatSecciones] ([Id])

	ALTER TABLE [dbo].[BCatRamas] CHECK CONSTRAINT [FK_BCatRamas_BCatSecciones]


	/****** Object:  Table [dbo].[BCatTematicas]    Script Date: 07/29/2013 15:15:14 ******/
	SET ANSI_NULLS ON

	SET QUOTED_IDENTIFIER ON

	SET ANSI_PADDING ON

	CREATE TABLE [dbo].[BCatTematicas](
		[IdSeccion] [int] NOT NULL,
		[IdRama] [int] NOT NULL,
		[Id] [int] NOT NULL,
		[Nombre] [varchar](20) NOT NULL,
	 CONSTRAINT [PK_BCatTematicas] PRIMARY KEY CLUSTERED 
	(
		[IdSeccion] ASC,
		[IdRama] ASC,
		[Id] ASC
	)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
	) ON [PRIMARY]

	SET ANSI_PADDING OFF

	ALTER TABLE [dbo].[BCatTematicas]  WITH CHECK ADD  CONSTRAINT [FK_BCatTematicas_BCatRamas] FOREIGN KEY([IdSeccion], [IdRama])
	REFERENCES [dbo].[BCatRamas] ([IdSeccion], [Id])

	ALTER TABLE [dbo].[BCatTematicas] CHECK CONSTRAINT [FK_BCatTematicas_BCatRamas]


	/****** Object:  Table [dbo].[CatPaises]    Script Date: 07/29/2013 15:15:48 ******/
	SET ANSI_NULLS ON

	SET QUOTED_IDENTIFIER ON

	SET ANSI_PADDING ON

	CREATE TABLE [dbo].[CatPaises](
		[Id] [int] NOT NULL,
		[Nombre] [varchar](30) NOT NULL,
	 CONSTRAINT [PK_CatPaises] PRIMARY KEY CLUSTERED 
	(
		[Id] ASC
	)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
	) ON [PRIMARY]

	SET ANSI_PADDING OFF


	/****** Object:  Table [dbo].[BCatEditoriales]    Script Date: 07/29/2013 15:16:09 ******/
	SET ANSI_NULLS ON

	SET QUOTED_IDENTIFIER ON

	SET ANSI_PADDING ON

	CREATE TABLE [dbo].[BCatEditoriales](
		[Id] [int] NOT NULL,
		[Nombre] [varchar](50) NOT NULL,
	 CONSTRAINT [PK_BCatEditoriales] PRIMARY KEY CLUSTERED 
	(
		[Id] ASC
	)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
	) ON [PRIMARY]

	SET ANSI_PADDING OFF

	/****** Object:  Table [dbo].[BCatAutores]    Script Date: 07/29/2013 15:17:05 ******/
	SET ANSI_NULLS ON

	SET QUOTED_IDENTIFIER ON

	SET ANSI_PADDING ON

	CREATE TABLE [dbo].[BCatAutores](
		[Id] [int] NOT NULL,
		[Nombre] [varchar](50) NOT NULL,
		[IdPais] [int] NULL,
	 CONSTRAINT [PK_BCatAutores] PRIMARY KEY CLUSTERED 
	(
		[Id] ASC
	)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
	) ON [PRIMARY]

	SET ANSI_PADDING OFF

	ALTER TABLE [dbo].[BCatAutores]  WITH NOCHECK ADD  CONSTRAINT [FK_BCatAutores_CatPaises] FOREIGN KEY([IdPais])
	REFERENCES [dbo].[CatPaises] ([Id])

	ALTER TABLE [dbo].[BCatAutores] NOCHECK CONSTRAINT [FK_BCatAutores_CatPaises]


	/****** Object:  Table [dbo].[BInvLibros]    Script Date: 07/29/2013 17:06:43 ******/
	SET ANSI_NULLS ON

	SET QUOTED_IDENTIFIER ON

	SET ANSI_PADDING ON

	CREATE TABLE [dbo].[BInvLibros](
		[Id] [int] NOT NULL,
		[Titulo] [varchar](250) NOT NULL,
		[IdAutor] [int] NOT NULL,
		[Edicion] [char](10) NULL,
		[IdEditorial] [int] NOT NULL,
		[IdSeccion] [int] NOT NULL,
		[IdRama] [int] NOT NULL,
		[IdTematica] [int] NOT NULL,
		[IdPais] [int] NULL,
		[Año] [int] NULL,
		[NumEjemplares] [int] NOT NULL,
		[ExclusivoConsulta] [bit] NOT NULL,
		[Pasillo] [int] NULL,
		[Estante] [int] NULL,
		[Nivel] [int] NULL,
	 CONSTRAINT [PK_BInvLibros] PRIMARY KEY CLUSTERED 
	(
		[Id] ASC
	)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
	) ON [PRIMARY]

	SET ANSI_PADDING OFF

	ALTER TABLE [dbo].[BInvLibros]  WITH CHECK ADD  CONSTRAINT [FK_BInvLibros_BCatAutores] FOREIGN KEY([IdAutor])
	REFERENCES [dbo].[BCatAutores] ([Id])

	ALTER TABLE [dbo].[BInvLibros] CHECK CONSTRAINT [FK_BInvLibros_BCatAutores]

	ALTER TABLE [dbo].[BInvLibros]  WITH CHECK ADD  CONSTRAINT [FK_BInvLibros_BCatEditoriales] FOREIGN KEY([IdEditorial])
	REFERENCES [dbo].[BCatEditoriales] ([Id])

	ALTER TABLE [dbo].[BInvLibros] CHECK CONSTRAINT [FK_BInvLibros_BCatEditoriales]

	ALTER TABLE [dbo].[BInvLibros]  WITH CHECK ADD  CONSTRAINT [FK_BInvLibros_BCatTematicas] FOREIGN KEY([IdSeccion], [IdRama], [IdTematica])
	REFERENCES [dbo].[BCatTematicas] ([IdSeccion], [IdRama], [Id])

	ALTER TABLE [dbo].[BInvLibros] CHECK CONSTRAINT [FK_BInvLibros_BCatTematicas]

	ALTER TABLE [dbo].[BInvLibros]  WITH NOCHECK ADD  CONSTRAINT [FK_BInvLibros_CatPaises] FOREIGN KEY([IdPais])
	REFERENCES [dbo].[CatPaises] ([Id])

	ALTER TABLE [dbo].[BInvLibros] NOCHECK CONSTRAINT [FK_BInvLibros_CatPaises]

	ALTER TABLE [dbo].[BInvLibros] ADD  CONSTRAINT [DF_BInvLibros_ExclusivoConsulta]  DEFAULT ((0)) FOR [ExclusivoConsulta]

	
	COMMIT
	PRINT 'PROCESO TERMINADO.'
	
END TRY
BEGIN CATCH
	PRINT 'ERROR'
	ROLLBACK
    SELECT
        ERROR_NUMBER() AS ErrorNumber
        ,ERROR_SEVERITY() AS ErrorSeverity
        ,ERROR_STATE() AS ErrorState
        ,ERROR_PROCEDURE() AS ErrorProcedure
        ,ERROR_LINE() AS ErrorLine
        ,ERROR_MESSAGE() AS ErrorMessage;	
END CATCH

