/*
   viernes, 31 de mayo de 201305:07:51 p.m.
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
ALTER TABLE dbo.CatEventos ADD
	LugarEvento varchar(50) NULL
GO
ALTER TABLE dbo.CatEventos SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
