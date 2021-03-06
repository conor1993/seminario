/****** Object:  UserDefinedFunction [dbo].[CalculaEdad]    Script Date: 07/11/2013 11:27:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Carlos Herrera
-- Create date: 12/03/2013
-- Description:	Calcula la edad en años de una persona
-- =============================================
ALTER FUNCTION [dbo].[CalculaEdad]
(
	@FechaNac DateTime
)
RETURNS int
AS
BEGIN
	DECLARE @Edad int, @Ahora DateTime
	Set @Ahora= GETDATE()
	
	Set @Edad=(CASE WHEN (MONTH(@FechaNac)<MONTH(@Ahora)) Or ((MONTH(@FechaNac)=MONTH(@Ahora)) And (DAY(@FechaNac)<=DAY(@Ahora)))
					THEN (YEAR(@Ahora)-YEAR(@FechaNac))
					ELSE YEAR(@Ahora)-YEAR(@FechaNac)-1 END)

	RETURN @Edad

END
