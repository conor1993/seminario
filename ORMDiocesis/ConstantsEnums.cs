///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 2.0.0.0
// Code is generated on: lunes, 25 de julio de 2016 10:31:09 a.m.
// Code is generated using templates: SD.TemplateBindings.SharedTemplates.NET20
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;

namespace ORMDiocesis
{

	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Asistencia.
	/// </summary>
	public enum AsistenciaFieldIndex:int
	{
		///<summary>IdParticipante. </summary>
		IdParticipante,
		///<summary>IdEvento. </summary>
		IdEvento,
		///<summary>Domicilio. </summary>
		Domicilio,
		///<summary>IdCiudad. </summary>
		IdCiudad,
		///<summary>Telefono. </summary>
		Telefono,
		///<summary>Celular. </summary>
		Celular,
		///<summary>RedesSociales. </summary>
		RedesSociales,
		///<summary>GradoEscolar. </summary>
		GradoEscolar,
		///<summary>CodParroquia. </summary>
		CodParroquia,
		///<summary>CodParroco. </summary>
		CodParroco,
		///<summary>IdEquipo. </summary>
		IdEquipo,
		///<summary>Seccion. </summary>
		Seccion,
		///<summary>Observaciones. </summary>
		Observaciones,
		///<summary>Foto. </summary>
		Foto,
		///<summary>EMail. </summary>
		EMail,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Autor.
	/// </summary>
	public enum AutorFieldIndex:int
	{
		///<summary>Id. </summary>
		Id,
		///<summary>Nombre. </summary>
		Nombre,
		///<summary>IdPais. </summary>
		IdPais,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Cargo.
	/// </summary>
	public enum CargoFieldIndex:int
	{
		///<summary>Id. </summary>
		Id,
		///<summary>Cargo. </summary>
		Cargo,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Ciudad.
	/// </summary>
	public enum CiudadFieldIndex:int
	{
		///<summary>Id. </summary>
		Id,
		///<summary>Nombre. </summary>
		Nombre,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Ciudades.
	/// </summary>
	public enum CiudadesFieldIndex:int
	{
		///<summary>Nomciudad. </summary>
		Nomciudad,
		///<summary>Idciudad. </summary>
		Idciudad,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Editorial.
	/// </summary>
	public enum EditorialFieldIndex:int
	{
		///<summary>Id. </summary>
		Id,
		///<summary>Nombre. </summary>
		Nombre,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: EquipoDeTrabajo.
	/// </summary>
	public enum EquipoDeTrabajoFieldIndex:int
	{
		///<summary>Id. </summary>
		Id,
		///<summary>IdEvento. </summary>
		IdEvento,
		///<summary>Nombre. </summary>
		Nombre,
		///<summary>Encargado. </summary>
		Encargado,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Evento.
	/// </summary>
	public enum EventoFieldIndex:int
	{
		///<summary>Id. </summary>
		Id,
		///<summary>Ano. </summary>
		Ano,
		///<summary>FechaInicio. </summary>
		FechaInicio,
		///<summary>FechaFin. </summary>
		FechaFin,
		///<summary>Nombre. </summary>
		Nombre,
		///<summary>Seccion. </summary>
		Seccion,
		///<summary>Estatus. </summary>
		Estatus,
		///<summary>LugarEvento. </summary>
		LugarEvento,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Lectores.
	/// </summary>
	public enum LectoresFieldIndex:int
	{
		///<summary>IdLectores. </summary>
		IdLectores,
		///<summary>Matricula. </summary>
		Matricula,
		///<summary>Nombre. </summary>
		Nombre,
		///<summary>ApellidoPaterno. </summary>
		ApellidoPaterno,
		///<summary>ApellidoMaterno. </summary>
		ApellidoMaterno,
		///<summary>Sexo. </summary>
		Sexo,
		///<summary>Grupo. </summary>
		Grupo,
		///<summary>FechaNacimiento. </summary>
		FechaNacimiento,
		///<summary>CalleNumero. </summary>
		CalleNumero,
		///<summary>Ciudad. </summary>
		Ciudad,
		///<summary>Estado. </summary>
		Estado,
		///<summary>Telefono. </summary>
		Telefono,
		///<summary>Celular. </summary>
		Celular,
		///<summary>Facultad. </summary>
		Facultad,
		///<summary>FechaAlta. </summary>
		FechaAlta,
		///<summary>FechaVigencia. </summary>
		FechaVigencia,
		///<summary>Baja. </summary>
		Baja,
		///<summary>Suspendido. </summary>
		Suspendido,
		///<summary>FechaBaja. </summary>
		FechaBaja,
		///<summary>MotivoBaja. </summary>
		MotivoBaja,
		///<summary>MotivoSuspendido. </summary>
		MotivoSuspendido,
		///<summary>InicioSuspension. </summary>
		InicioSuspension,
		///<summary>DiasSuspension. </summary>
		DiasSuspension,
		///<summary>Observaciones. </summary>
		Observaciones,
		///<summary>Cp. </summary>
		Cp,
		///<summary>Facebook. </summary>
		Facebook,
		///<summary>Numero. </summary>
		Numero,
		///<summary>Colonia. </summary>
		Colonia,
		///<summary>Email. </summary>
		Email,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Libro.
	/// </summary>
	public enum LibroFieldIndex:int
	{
		///<summary>Id. </summary>
		Id,
		///<summary>Titulo. </summary>
		Titulo,
		///<summary>IdAutor. </summary>
		IdAutor,
		///<summary>Edicion. </summary>
		Edicion,
		///<summary>IdEditorial. </summary>
		IdEditorial,
		///<summary>IdSeccion. </summary>
		IdSeccion,
		///<summary>IdRama. </summary>
		IdRama,
		///<summary>IdTematica. </summary>
		IdTematica,
		///<summary>IdPais. </summary>
		IdPais,
		///<summary>Año. </summary>
		Año,
		///<summary>NumEjemplares. </summary>
		NumEjemplares,
		///<summary>ExclusivoConsulta. </summary>
		ExclusivoConsulta,
		///<summary>Pasillo. </summary>
		Pasillo,
		///<summary>Estante. </summary>
		Estante,
		///<summary>Nivel. </summary>
		Nivel,
		///<summary>Isbn. </summary>
		Isbn,
		///<summary>Ddc. </summary>
		Ddc,
		///<summary>Cdu. </summary>
		Cdu,
		///<summary>Ilustrado. </summary>
		Ilustrado,
		///<summary>Busqueda. </summary>
		Busqueda,
		///<summary>Portada. </summary>
		Portada,
		///<summary>ContraPortada. </summary>
		ContraPortada,
		///<summary>Materia. </summary>
		Materia,
		///<summary>Formato. </summary>
		Formato,
		///<summary>Estatus. </summary>
		Estatus,
		///<summary>Numero. </summary>
		Numero,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: LibroEstatus.
	/// </summary>
	public enum LibroEstatusFieldIndex:int
	{
		///<summary>Id. </summary>
		Id,
		///<summary>Estado. </summary>
		Estado,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: LibroFormato.
	/// </summary>
	public enum LibroFormatoFieldIndex:int
	{
		///<summary>Id. </summary>
		Id,
		///<summary>Formato. </summary>
		Formato,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Pais.
	/// </summary>
	public enum PaisFieldIndex:int
	{
		///<summary>Id. </summary>
		Id,
		///<summary>Nombre. </summary>
		Nombre,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Parroco.
	/// </summary>
	public enum ParrocoFieldIndex:int
	{
		///<summary>Id. </summary>
		Id,
		///<summary>Titulo. </summary>
		Titulo,
		///<summary>Nombre. </summary>
		Nombre,
		///<summary>Apellidos. </summary>
		Apellidos,
		///<summary>Cargo. </summary>
		Cargo,
		///<summary>EMail. </summary>
		EMail,
		///<summary>IdParroquia. </summary>
		IdParroquia,
		///<summary>NombreParroquia. </summary>
		NombreParroquia,
		///<summary>Telefono1. </summary>
		Telefono1,
		///<summary>Telefono2. </summary>
		Telefono2,
		///<summary>TelCural. </summary>
		TelCural,
		///<summary>Fecnac. </summary>
		Fecnac,
		///<summary>FecOrdenacion. </summary>
		FecOrdenacion,
		///<summary>FechaNac. </summary>
		FechaNac,
		///<summary>FechaOrdenac. </summary>
		FechaOrdenac,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Parroquia.
	/// </summary>
	public enum ParroquiaFieldIndex:int
	{
		///<summary>Id. </summary>
		Id,
		///<summary>IdTipoParroquia. </summary>
		IdTipoParroquia,
		///<summary>Nombre. </summary>
		Nombre,
		///<summary>IdZonaPastoral. </summary>
		IdZonaPastoral,
		///<summary>IdCiudad. </summary>
		IdCiudad,
		///<summary>Tel1. </summary>
		Tel1,
		///<summary>Tel2. </summary>
		Tel2,
		///<summary>Telcural. </summary>
		Telcural,
		///<summary>Fax. </summary>
		Fax,
		///<summary>EmailComunidad. </summary>
		EmailComunidad,
		///<summary>Calle. </summary>
		Calle,
		///<summary>NoExt. </summary>
		NoExt,
		///<summary>Colonia. </summary>
		Colonia,
		///<summary>Cp. </summary>
		Cp,
		///<summary>ApartadoPostal. </summary>
		ApartadoPostal,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Participante.
	/// </summary>
	public enum ParticipanteFieldIndex:int
	{
		///<summary>Id. </summary>
		Id,
		///<summary>ApellidoPaterno. </summary>
		ApellidoPaterno,
		///<summary>ApellidoMaterno. </summary>
		ApellidoMaterno,
		///<summary>Nombre. </summary>
		Nombre,
		///<summary>FechaNacim. </summary>
		FechaNacim,
		///<summary>Aceptado. </summary>
		Aceptado,
		///<summary>NombrePadre. </summary>
		NombrePadre,
		///<summary>NombreMadre. </summary>
		NombreMadre,
		///<summary>VivePadre. </summary>
		VivePadre,
		///<summary>ViveMadre. </summary>
		ViveMadre,
		///<summary>EdoCivilPadres. </summary>
		EdoCivilPadres,
		///<summary>Hermanos. </summary>
		Hermanos,
		///<summary>Hermanas. </summary>
		Hermanas,
		///<summary>OrdenNacimiento. </summary>
		OrdenNacimiento,
		///<summary>Confirmacion. </summary>
		Confirmacion,
		///<summary>PrimeraComunion. </summary>
		PrimeraComunion,
		///<summary>Deportes. </summary>
		Deportes,
		///<summary>Instrumentos. </summary>
		Instrumentos,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Rama.
	/// </summary>
	public enum RamaFieldIndex:int
	{
		///<summary>Id. </summary>
		Id,
		///<summary>Nombre. </summary>
		Nombre,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Seccion.
	/// </summary>
	public enum SeccionFieldIndex:int
	{
		///<summary>Id. </summary>
		Id,
		///<summary>Nombre. </summary>
		Nombre,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Tematica.
	/// </summary>
	public enum TematicaFieldIndex:int
	{
		///<summary>Id. </summary>
		Id,
		///<summary>Nombre. </summary>
		Nombre,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: TipoParroquia.
	/// </summary>
	public enum TipoParroquiaFieldIndex:int
	{
		///<summary>Id. </summary>
		Id,
		///<summary>Descripcion. </summary>
		Descripcion,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: VwListas.
	/// </summary>
	public enum VwListasFieldIndex:int
	{
		///<summary>Nombreequipo. </summary>
		Nombreequipo,
		///<summary>Nombreevento. </summary>
		Nombreevento,
		///<summary>ApellidoPaterno. </summary>
		ApellidoPaterno,
		///<summary>ApellidoMaterno. </summary>
		ApellidoMaterno,
		///<summary>Nombre. </summary>
		Nombre,
		///<summary>Seccion. </summary>
		Seccion,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Vwparroquias.
	/// </summary>
	public enum VwparroquiasFieldIndex:int
	{
		///<summary>Parroquia. </summary>
		Parroquia,
		///<summary>Telefono. </summary>
		Telefono,
		///<summary>OtroTelefono. </summary>
		OtroTelefono,
		///<summary>TelefonoCural. </summary>
		TelefonoCural,
		///<summary>Fax. </summary>
		Fax,
		///<summary>CorreoElectrónico. </summary>
		CorreoElectrónico,
		///<summary>Calle. </summary>
		Calle,
		///<summary>Numero. </summary>
		Numero,
		///<summary>Colonia. </summary>
		Colonia,
		///<summary>CodigoPostal. </summary>
		CodigoPostal,
		///<summary>ApartadoPostal. </summary>
		ApartadoPostal,
		///<summary>Ciudad. </summary>
		Ciudad,
		///<summary>Zona. </summary>
		Zona,
		///<summary>Tipo. </summary>
		Tipo,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: ZonaPastoral.
	/// </summary>
	public enum ZonaPastoralFieldIndex:int
	{
		///<summary>Id. </summary>
		Id,
		///<summary>Nombre. </summary>
		Nombre,
		/// <summary></summary>
		AmountOfFields
	}





	/// <summary>
	/// Enum definition for all the entity types defined in this namespace. Used by the entityfields factory.
	/// </summary>
	public enum EntityType:int
	{
		///<summary>Asistencia</summary>
		AsistenciaEntity,
		///<summary>Autor</summary>
		AutorEntity,
		///<summary>Cargo</summary>
		CargoEntity,
		///<summary>Ciudad</summary>
		CiudadEntity,
		///<summary>Ciudades</summary>
		CiudadesEntity,
		///<summary>Editorial</summary>
		EditorialEntity,
		///<summary>EquipoDeTrabajo</summary>
		EquipoDeTrabajoEntity,
		///<summary>Evento</summary>
		EventoEntity,
		///<summary>Lectores</summary>
		LectoresEntity,
		///<summary>Libro</summary>
		LibroEntity,
		///<summary>LibroEstatus</summary>
		LibroEstatusEntity,
		///<summary>LibroFormato</summary>
		LibroFormatoEntity,
		///<summary>Pais</summary>
		PaisEntity,
		///<summary>Parroco</summary>
		ParrocoEntity,
		///<summary>Parroquia</summary>
		ParroquiaEntity,
		///<summary>Participante</summary>
		ParticipanteEntity,
		///<summary>Rama</summary>
		RamaEntity,
		///<summary>Seccion</summary>
		SeccionEntity,
		///<summary>Tematica</summary>
		TematicaEntity,
		///<summary>TipoParroquia</summary>
		TipoParroquiaEntity,
		///<summary>VwListas</summary>
		VwListasEntity,
		///<summary>Vwparroquias</summary>
		VwparroquiasEntity,
		///<summary>ZonaPastoral</summary>
		ZonaPastoralEntity
	}




	#region Custom ConstantsEnums Code
	
	// __LLBLGENPRO_USER_CODE_REGION_START CustomUserConstants
	// __LLBLGENPRO_USER_CODE_REGION_END
	#endregion

	#region Included code

	#endregion
}


