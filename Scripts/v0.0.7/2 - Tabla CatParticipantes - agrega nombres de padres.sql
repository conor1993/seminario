/*
   jueves, 11 de julio de 201302:20:52 p.m.
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
ALTER TABLE dbo.CatParticipantes ADD
	NombrePadre varchar(50) NULL,
	NombreMadre varchar(50) NULL,
	VivePadre bit NULL,
	ViveMadre bit NULL,
	EdoCivilPadres int NULL,
	Hermanos int NULL,
	Hermanas int NULL,
	OrdenNacimiento int NULL,
	Confirmacion bit NULL,
	PrimeraComunion bit NULL,
	Deportes varchar(50) NULL,
	Instrumentos varchar(50) NULL	
GO
ALTER TABLE dbo.CatParticipantes SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
