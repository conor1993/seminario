/*
   lunes, 10 de junio de 201305:37:17 p.m.
   Usuario: sa
   Servidor: INTEDES01,1922
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
CREATE TABLE dbo.Tmp_CatEventos
	(
	Idevento varchar(50) NOT NULL,
	Yearevento int NOT NULL,
	Fecinievento smalldatetime NOT NULL,
	Fecfinevento smalldatetime NOT NULL,
	Nombreevento varchar(50) NULL,
	Seccionevento bit NULL,
	Estatus int NOT NULL,
	LugarEvento varchar(50) NULL
	)  ON [PRIMARY]
GO
DECLARE @v sql_variant 
SET @v = N'Aqui se debe grabar el criterio de SME seminario menor o SMA seminario mayor SF Seminarista en familia cuando asi corresponda'
EXECUTE sp_addextendedproperty N'MS_Description', @v, N'SCHEMA', N'dbo', N'TABLE', N'Tmp_CatEventos', N'COLUMN', N'Seccionevento'
GO
ALTER TABLE dbo.Tmp_CatEventos ADD CONSTRAINT
	DF_CatEventos_Estatus DEFAULT 0 FOR Estatus
GO
IF EXISTS(SELECT * FROM dbo.CatEventos)
	 EXEC('INSERT INTO dbo.Tmp_CatEventos (Idevento, Yearevento, Fecinievento, Fecfinevento, Nombreevento, Seccionevento, Estatus, LugarEvento)
		SELECT Idevento, Yearevento, Fecinievento, Fecfinevento, Nombreevento, Seccionevento, CONVERT(int, Estatus), LugarEvento FROM dbo.CatEventos WITH (HOLDLOCK TABLOCKX)')
GO
ALTER TABLE dbo.SemAsistencia
	DROP CONSTRAINT FK_SemAsistencia_CatEventos
GO
ALTER TABLE dbo.SemAsistencia
	DROP CONSTRAINT FK_SemAsistencia_CatEquiposTrabajo
GO
ALTER TABLE dbo.CatEquiposTrabajo
	DROP CONSTRAINT FK_CatEquiposTrabajo_CatEventos
GO
DROP TABLE dbo.CatEventos
GO
EXECUTE sp_rename N'dbo.Tmp_CatEventos', N'CatEventos', 'OBJECT' 
GO
ALTER TABLE dbo.CatEventos ADD CONSTRAINT
	PK_Cateventos PRIMARY KEY CLUSTERED 
	(
	Idevento
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.CatEquiposTrabajo ADD CONSTRAINT
	FK_CatEquiposTrabajo_CatEventos FOREIGN KEY
	(
	Idevento
	) REFERENCES dbo.CatEventos
	(
	Idevento
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.SemAsistencia ADD CONSTRAINT
	FK_SemAsistencia_CatEventos FOREIGN KEY
	(
	IdEvento
	) REFERENCES dbo.CatEventos
	(
	Idevento
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.SemAsistencia ADD CONSTRAINT
	FK_SemAsistencia_CatEquiposTrabajo FOREIGN KEY
	(
	IdEvento
	) REFERENCES dbo.CatEventos
	(
	Idevento
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
COMMIT
