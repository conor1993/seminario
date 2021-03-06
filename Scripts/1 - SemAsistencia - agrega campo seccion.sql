/*
   viernes, 15 de marzo de 201306:10:39 p.m.
   Usuario: integra
   Servidor: integrasrv2
   Base de datos: bdsemprovoc
   Aplicación: 
*/

/* Para evitar posibles problemas de pérdida de datos, debe revisar este script detalladamente antes de ejecutarlo fuera del contexto del diseñador de base de datos.*/
BEGIN TRANSACTION
SET QUOTED_IDENTIFIER ON
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.Tmp_SemAsistencia
	(
	IdParticipante int NOT NULL,
	IdEvento varchar(50) NOT NULL,
	Domicilio varchar(100) NULL,
	IdCiudad tinyint NULL,
	Telefono nchar(20) NULL,
	Celular nchar(20) NULL,
	RedesSociales varchar(100) NULL,
	GradoEscolar varchar(30) NULL,
	CodParroqia int NOT NULL,
	CodSacerdote int NOT NULL,
	IdEquipo int NOT NULL,
	Seccion int NULL,
	Observaciones text NULL,
	Foto image NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE dbo.Tmp_SemAsistencia SET (LOCK_ESCALATION = TABLE)
GO
IF EXISTS(SELECT * FROM dbo.SemAsistencia)
	 EXEC('INSERT INTO dbo.Tmp_SemAsistencia (IdParticipante, IdEvento, Domicilio, IdCiudad, Telefono, Celular, RedesSociales, GradoEscolar, CodParroqia, CodSacerdote, IdEquipo, Observaciones, Foto)
		SELECT IdParticipante, IdEvento, Domicilio, IdCiudad, Telefono, Celular, RedesSociales, GradoEscolar, CodParroqia, CodSacerdote, IdEquipo, Observaciones, Foto FROM dbo.SemAsistencia WITH (HOLDLOCK TABLOCKX)')
GO
DROP TABLE dbo.SemAsistencia
GO
EXECUTE sp_rename N'dbo.Tmp_SemAsistencia', N'SemAsistencia', 'OBJECT' 
GO
ALTER TABLE dbo.SemAsistencia ADD CONSTRAINT
	PK_SemAsistencia PRIMARY KEY CLUSTERED 
	(
	IdParticipante,
	IdEvento
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
COMMIT
