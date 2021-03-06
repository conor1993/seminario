/****** Object:  StoredProcedure [dbo].[UPIM_SemAsistencia]    Script Date: 03/15/2013 18:16:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[UPIM_SemAsistencia]
	@CodParticipante int = 0 output, 
	@ApellidoPaterno varchar(50) = '',
	@ApellidoMaterno varchar(50) = '',
	@Nombre varchar(50) = '',
	@FechaNacim datetime = '',
	@Aceptado smallint = 0,
	@IdEvento varchar(50),
	@Domicilio varchar(100),
	@IdCiudad tinyint,
	@Telefono nchar(20),
	@Celular nchar(20),
	@RedesSociales varchar(100),
	@GradoEscolar varchar(30),
	@CodParroqia int,
	@CodSacerdote int,
	@IdEquipo int,
	@Seccion int,
	@Observaciones text,
	@Foto image,
	@Error int=0 output
	
AS
BEGIN

	BEGIN TRANSACTION;
	/* Si el participante no existe agrega el registro */
    IF @CodParticipante=0
    BEGIN
		INSERT INTO CatParticipantes
				   (ApellidoPaterno,ApellidoMaterno,Nombre,FechaNacim,Aceptado)
			 VALUES (@ApellidoPaterno,@ApellidoMaterno,@Nombre,@FechaNacim,@Aceptado)
		Set @Error=@@ERROR
		Set @CodParticipante=SCOPE_IDENTITY()
	END
	ELSE BEGIN
		UPDATE CatParticipantes
		SET ApellidoPaterno=@ApellidoPaterno,
			ApellidoMaterno=@ApellidoMaterno,
			Nombre=@Nombre,
			FechaNacim=@FechaNacim,
			Aceptado=@Aceptado
		WHERE IdParticipante=@CodParticipante 
		Set @Error=@@ERROR
	END
	
	if @Error<>0
	begin
		IF @@TRANCOUNT > 0
			ROLLBACK TRANSACTION;
		Return 0
	end

	
	/* Agrega el registro de asistencia */
	IF (SELECT COUNT(IdParticipante) as Total FROM SemAsistencia WHERE IdParticipante=@CodParticipante And IdEvento=@IdEvento)=0
	BEGIN
		INSERT INTO SemAsistencia
				   (IdParticipante,IdEvento,Domicilio,IdCiudad,Telefono,Celular,RedesSociales,GradoEscolar,CodParroqia,CodSacerdote,IdEquipo,Seccion,Observaciones,Foto)
			 VALUES (@CodParticipante,@IdEvento,@Domicilio,@IdCiudad,@Telefono,@Celular,@RedesSociales,@GradoEscolar,@CodParroqia,@CodSacerdote,@IdEquipo,@Seccion,@Observaciones,@Foto)
			Set @Error=@@ERROR
	END
	ELSE
	BEGIN
		UPDATE SemAsistencia 
			SET Domicilio=@Domicilio,
				IdCiudad=@IdCiudad,
				Telefono=@Telefono,
				Celular=@Celular,
				RedesSociales=@RedesSociales,
				GradoEscolar=@GradoEscolar,
				CodParroqia=@CodParroqia,
				CodSacerdote=@CodSacerdote,
				IdEquipo=@IdEquipo, 
				Seccion=@Seccion,
				Observaciones=@Observaciones,
				Foto=@Foto
			WHERE IdParticipante=@CodParticipante And IdEvento=@IdEvento
			Set @Error=@@ERROR
	END	
		if @Error<>0
		begin
			IF @@TRANCOUNT > 0
				ROLLBACK TRANSACTION;
			Return 0
		end
		else
		begin
			COMMIT TRANSACTION
			Return @CodParticipante
		END
END
