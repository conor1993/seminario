/*
   jueves, 30 de mayo de 201304:01:30 p.m.
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
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.SemAsistencia
	DROP CONSTRAINT FK_SemAsistencia_CatEquiposTrabajo
GO
ALTER TABLE dbo.CatEquiposTrabajo ADD CONSTRAINT
	FK_CatEquiposTrabajo_CatEquiposTrabajo FOREIGN KEY
	(
	Idequipo
	) REFERENCES dbo.CatEquiposTrabajo
	(
	Idequipo
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
COMMIT
BEGIN TRANSACTION
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
