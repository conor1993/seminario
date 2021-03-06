/*
   jueves, 30 de mayo de 201304:00:15 p.m.
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
	FK_SemAsistencia_CatParticipantes FOREIGN KEY
	(
	IdParticipante
	) REFERENCES dbo.CatParticipantes
	(
	IdParticipante
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.SemAsistencia ADD CONSTRAINT
	FK_SemAsistencia_CatParroquias FOREIGN KEY
	(
	CodParroqia
	) REFERENCES dbo.CatParroquias
	(
	Idparroquia
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.SemAsistencia WITH NOCHECK ADD CONSTRAINT
	FK_SemAsistencia_CatParrocos FOREIGN KEY
	(
	CodSacerdote
	) REFERENCES dbo.CatParrocos
	(
	IdParroco
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.SemAsistencia ADD CONSTRAINT
	FK_SemAsistencia_CatEquiposTrabajo FOREIGN KEY
	(
	IdEquipo
	) REFERENCES dbo.CatEquiposTrabajo
	(
	Idequipo
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
COMMIT
