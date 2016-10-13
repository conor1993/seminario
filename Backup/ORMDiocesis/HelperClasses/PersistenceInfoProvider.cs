///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 2.0.0.0
// Code is generated on: miércoles, 06 de julio de 2016 12:30:17 p.m.
// Code is generated using templates: SD.TemplateBindings.SqlServerSpecific.NET20
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.Collections;
using System.Data;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace ORMDiocesis.HelperClasses
{
	/// <summary>
	/// Singleton implementation of the PersistenceInfoProvider. This class is the singleton wrapper through which the actual instance is retrieved.
	/// </summary>
	/// <remarks>It uses a single instance of an internal class. The access isn't marked with locks as the PersistenceInfoProviderBase class is threadsafe.</remarks>
	internal sealed class PersistenceInfoProviderSingleton
	{
		#region Class Member Declarations
		private static readonly IPersistenceInfoProvider _providerInstance = new PersistenceInfoProviderCore();
		#endregion
		
		/// <summary>private ctor to prevent instances of this class.</summary>
		private PersistenceInfoProviderSingleton()
		{
		}

		/// <summary>Dummy static constructor to make sure threadsafe initialization is performed.</summary>
		static PersistenceInfoProviderSingleton()
		{
		}

		/// <summary>Gets the singleton instance of the PersistenceInfoProviderCore</summary>
		/// <returns>Instance of the PersistenceInfoProvider.</returns>
		public static IPersistenceInfoProvider GetInstance()
		{
			return _providerInstance;
		}
	}

	/// <summary>Actual implementation of the PersistenceInfoProvider. Used by singleton wrapper.</summary>
	internal class PersistenceInfoProviderCore : PersistenceInfoProviderBase
	{
		/// <summary>Initializes a new instance of the <see cref="PersistenceInfoProviderCore"/> class.</summary>
		internal PersistenceInfoProviderCore()
		{
			Init();
		}

		/// <summary>Method which initializes the internal datastores with the structure of hierarchical types.</summary>
		private void Init()
		{
			base.InitClass((23 + 0));
			InitAsistenciaEntityMappings();
			InitAutorEntityMappings();
			InitCargoEntityMappings();
			InitCiudadEntityMappings();
			InitCiudadesEntityMappings();
			InitEditorialEntityMappings();
			InitEquipoDeTrabajoEntityMappings();
			InitEventoEntityMappings();
			InitLectoresEntityMappings();
			InitLibroEntityMappings();
			InitLibroEstatusEntityMappings();
			InitLibroFormatoEntityMappings();
			InitPaisEntityMappings();
			InitParrocoEntityMappings();
			InitParroquiaEntityMappings();
			InitParticipanteEntityMappings();
			InitRamaEntityMappings();
			InitSeccionEntityMappings();
			InitTematicaEntityMappings();
			InitTipoParroquiaEntityMappings();
			InitVwListasEntityMappings();
			InitVwparroquiasEntityMappings();
			InitZonaPastoralEntityMappings();

		}


		/// <summary>Inits AsistenciaEntity's mappings</summary>
		private void InitAsistenciaEntityMappings()
		{
			base.AddElementMapping( "AsistenciaEntity", "bdsemprovoc", @"dbo", "SemAsistencia", 15 );
			base.AddElementFieldMapping( "AsistenciaEntity", "IdParticipante", "IdParticipante", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "AsistenciaEntity", "IdEvento", "IdEvento", false, (int)SqlDbType.VarChar, 50, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "AsistenciaEntity", "Domicilio", "Domicilio", true, (int)SqlDbType.VarChar, 100, 0, 0, false, "", null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "AsistenciaEntity", "IdCiudad", "IdCiudad", true, (int)SqlDbType.TinyInt, 0, 0, 3, false, "", null, typeof(System.Byte), 3 );
			base.AddElementFieldMapping( "AsistenciaEntity", "Telefono", "Telefono", true, (int)SqlDbType.NChar, 20, 0, 0, false, "", null, typeof(System.String), 4 );
			base.AddElementFieldMapping( "AsistenciaEntity", "Celular", "Celular", true, (int)SqlDbType.NChar, 20, 0, 0, false, "", null, typeof(System.String), 5 );
			base.AddElementFieldMapping( "AsistenciaEntity", "RedesSociales", "RedesSociales", true, (int)SqlDbType.VarChar, 100, 0, 0, false, "", null, typeof(System.String), 6 );
			base.AddElementFieldMapping( "AsistenciaEntity", "GradoEscolar", "GradoEscolar", true, (int)SqlDbType.VarChar, 30, 0, 0, false, "", null, typeof(System.String), 7 );
			base.AddElementFieldMapping( "AsistenciaEntity", "CodParroquia", "CodParroqia", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 8 );
			base.AddElementFieldMapping( "AsistenciaEntity", "CodParroco", "CodSacerdote", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 9 );
			base.AddElementFieldMapping( "AsistenciaEntity", "IdEquipo", "IdEquipo", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 10 );
			base.AddElementFieldMapping( "AsistenciaEntity", "Seccion", "Seccion", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 11 );
			base.AddElementFieldMapping( "AsistenciaEntity", "Observaciones", "Observaciones", true, (int)SqlDbType.Text, 2147483647, 0, 0, false, "", null, typeof(System.String), 12 );
			base.AddElementFieldMapping( "AsistenciaEntity", "Foto", "Foto", true, (int)SqlDbType.Image, 2147483647, 0, 0, false, "", null, typeof(System.Byte[]), 13 );
			base.AddElementFieldMapping( "AsistenciaEntity", "EMail", "eMail", true, (int)SqlDbType.VarChar, 30, 0, 0, false, "", null, typeof(System.String), 14 );
		}
		/// <summary>Inits AutorEntity's mappings</summary>
		private void InitAutorEntityMappings()
		{
			base.AddElementMapping( "AutorEntity", "bdsemprovoc", @"dbo", "BCatAutores", 3 );
			base.AddElementFieldMapping( "AutorEntity", "Id", "Id", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "AutorEntity", "Nombre", "Nombre", false, (int)SqlDbType.VarChar, 50, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "AutorEntity", "IdPais", "IdPais", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 2 );
		}
		/// <summary>Inits CargoEntity's mappings</summary>
		private void InitCargoEntityMappings()
		{
			base.AddElementMapping( "CargoEntity", "bdsemprovoc", @"dbo", "CatCargo", 2 );
			base.AddElementFieldMapping( "CargoEntity", "Id", "id", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "CargoEntity", "Cargo", "Cargo", true, (int)SqlDbType.VarChar, 250, 0, 0, false, "", null, typeof(System.String), 1 );
		}
		/// <summary>Inits CiudadEntity's mappings</summary>
		private void InitCiudadEntityMappings()
		{
			base.AddElementMapping( "CiudadEntity", "bdsemprovoc", @"dbo", "CatCiudades", 2 );
			base.AddElementFieldMapping( "CiudadEntity", "Id", "Idciudad", false, (int)SqlDbType.TinyInt, 0, 0, 3, true, "SCOPE_IDENTITY()", null, typeof(System.Byte), 0 );
			base.AddElementFieldMapping( "CiudadEntity", "Nombre", "Nomciudad", false, (int)SqlDbType.VarChar, 100, 0, 0, false, "", null, typeof(System.String), 1 );
		}
		/// <summary>Inits CiudadesEntity's mappings</summary>
		private void InitCiudadesEntityMappings()
		{
			base.AddElementMapping( "CiudadesEntity", "bdsemprovoc", @"dbo", "Ciudades", 2 );
			base.AddElementFieldMapping( "CiudadesEntity", "Nomciudad", "Nomciudad", false, (int)SqlDbType.VarChar, 100, 0, 0, false, "", null, typeof(System.String), 0 );
			base.AddElementFieldMapping( "CiudadesEntity", "Idciudad", "Idciudad", false, (int)SqlDbType.TinyInt, 0, 0, 3, false, "", null, typeof(System.Byte), 1 );
		}
		/// <summary>Inits EditorialEntity's mappings</summary>
		private void InitEditorialEntityMappings()
		{
			base.AddElementMapping( "EditorialEntity", "bdsemprovoc", @"dbo", "BCatEditoriales", 2 );
			base.AddElementFieldMapping( "EditorialEntity", "Id", "Id", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "EditorialEntity", "Nombre", "Nombre", false, (int)SqlDbType.VarChar, 50, 0, 0, false, "", null, typeof(System.String), 1 );
		}
		/// <summary>Inits EquipoDeTrabajoEntity's mappings</summary>
		private void InitEquipoDeTrabajoEntityMappings()
		{
			base.AddElementMapping( "EquipoDeTrabajoEntity", "bdsemprovoc", @"dbo", "CatEquiposTrabajo", 4 );
			base.AddElementFieldMapping( "EquipoDeTrabajoEntity", "Id", "Idequipo", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "EquipoDeTrabajoEntity", "IdEvento", "Idevento", false, (int)SqlDbType.VarChar, 50, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "EquipoDeTrabajoEntity", "Nombre", "Nombreequipo", false, (int)SqlDbType.VarChar, 100, 0, 0, false, "", null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "EquipoDeTrabajoEntity", "Encargado", "Encargado", true, (int)SqlDbType.VarChar, 150, 0, 0, false, "", null, typeof(System.String), 3 );
		}
		/// <summary>Inits EventoEntity's mappings</summary>
		private void InitEventoEntityMappings()
		{
			base.AddElementMapping( "EventoEntity", "bdsemprovoc", @"dbo", "CatEventos", 8 );
			base.AddElementFieldMapping( "EventoEntity", "Id", "Idevento", false, (int)SqlDbType.VarChar, 50, 0, 0, false, "", null, typeof(System.String), 0 );
			base.AddElementFieldMapping( "EventoEntity", "Ano", "Yearevento", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 1 );
			base.AddElementFieldMapping( "EventoEntity", "FechaInicio", "Fecinievento", false, (int)SqlDbType.SmallDateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 2 );
			base.AddElementFieldMapping( "EventoEntity", "FechaFin", "Fecfinevento", false, (int)SqlDbType.SmallDateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 3 );
			base.AddElementFieldMapping( "EventoEntity", "Nombre", "Nombreevento", true, (int)SqlDbType.VarChar, 50, 0, 0, false, "", null, typeof(System.String), 4 );
			base.AddElementFieldMapping( "EventoEntity", "Seccion", "Seccionevento", true, (int)SqlDbType.Bit, 0, 0, 0, false, "", null, typeof(System.Boolean), 5 );
			base.AddElementFieldMapping( "EventoEntity", "Estatus", "Estatus", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 6 );
			base.AddElementFieldMapping( "EventoEntity", "LugarEvento", "LugarEvento", true, (int)SqlDbType.VarChar, 50, 0, 0, false, "", null, typeof(System.String), 7 );
		}
		/// <summary>Inits LectoresEntity's mappings</summary>
		private void InitLectoresEntityMappings()
		{
			base.AddElementMapping( "LectoresEntity", "bdsemprovoc", @"dbo", "BCatLectores", 26 );
			base.AddElementFieldMapping( "LectoresEntity", "IdLectores", "IdLectores", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "LectoresEntity", "Matricula", "matricula", true, (int)SqlDbType.VarChar, 255, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "LectoresEntity", "Nombre", "nombre", true, (int)SqlDbType.VarChar, 255, 0, 0, false, "", null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "LectoresEntity", "ApellidoPaterno", "apellido_paterno", true, (int)SqlDbType.VarChar, 255, 0, 0, false, "", null, typeof(System.String), 3 );
			base.AddElementFieldMapping( "LectoresEntity", "ApellidoMaterno", "apellido_materno", true, (int)SqlDbType.VarChar, 255, 0, 0, false, "", null, typeof(System.String), 4 );
			base.AddElementFieldMapping( "LectoresEntity", "Sexo", "sexo", true, (int)SqlDbType.VarChar, 255, 0, 0, false, "", null, typeof(System.String), 5 );
			base.AddElementFieldMapping( "LectoresEntity", "Grupo", "grupo", true, (int)SqlDbType.VarChar, 255, 0, 0, false, "", null, typeof(System.String), 6 );
			base.AddElementFieldMapping( "LectoresEntity", "FechaNacimiento", "fecha_nacimiento", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 7 );
			base.AddElementFieldMapping( "LectoresEntity", "CalleNumero", "calle_numero", true, (int)SqlDbType.VarChar, 255, 0, 0, false, "", null, typeof(System.String), 8 );
			base.AddElementFieldMapping( "LectoresEntity", "Ciudad", "ciudad", true, (int)SqlDbType.VarChar, 255, 0, 0, false, "", null, typeof(System.String), 9 );
			base.AddElementFieldMapping( "LectoresEntity", "Estado", "estado", true, (int)SqlDbType.VarChar, 255, 0, 0, false, "", null, typeof(System.String), 10 );
			base.AddElementFieldMapping( "LectoresEntity", "Telefono", "telefono", true, (int)SqlDbType.VarChar, 255, 0, 0, false, "", null, typeof(System.String), 11 );
			base.AddElementFieldMapping( "LectoresEntity", "Celular", "celular", true, (int)SqlDbType.VarChar, 255, 0, 0, false, "", null, typeof(System.String), 12 );
			base.AddElementFieldMapping( "LectoresEntity", "Facultad", "facultad", true, (int)SqlDbType.VarChar, 255, 0, 0, false, "", null, typeof(System.String), 13 );
			base.AddElementFieldMapping( "LectoresEntity", "FechaAlta", "fecha_alta", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 14 );
			base.AddElementFieldMapping( "LectoresEntity", "FechaVigencia", "fecha_vigencia", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 15 );
			base.AddElementFieldMapping( "LectoresEntity", "Baja", "baja", true, (int)SqlDbType.Bit, 0, 0, 0, false, "", null, typeof(System.Boolean), 16 );
			base.AddElementFieldMapping( "LectoresEntity", "Suspendido", "suspendido", true, (int)SqlDbType.Bit, 0, 0, 0, false, "", null, typeof(System.Boolean), 17 );
			base.AddElementFieldMapping( "LectoresEntity", "FechaBaja", "fecha_baja", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 18 );
			base.AddElementFieldMapping( "LectoresEntity", "MotivoBaja", "motivo_baja", true, (int)SqlDbType.VarChar, 255, 0, 0, false, "", null, typeof(System.String), 19 );
			base.AddElementFieldMapping( "LectoresEntity", "MotivoSuspendido", "motivo_suspendido", true, (int)SqlDbType.VarChar, 255, 0, 0, false, "", null, typeof(System.String), 20 );
			base.AddElementFieldMapping( "LectoresEntity", "InicioSuspension", "inicio_suspension", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 21 );
			base.AddElementFieldMapping( "LectoresEntity", "DiasSuspension", "dias_suspension", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 22 );
			base.AddElementFieldMapping( "LectoresEntity", "Observaciones", "observaciones", true, (int)SqlDbType.VarChar, 255, 0, 0, false, "", null, typeof(System.String), 23 );
			base.AddElementFieldMapping( "LectoresEntity", "Cp", "cp", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 24 );
			base.AddElementFieldMapping( "LectoresEntity", "Facebook", "facebook", true, (int)SqlDbType.VarChar, 50, 0, 0, false, "", null, typeof(System.String), 25 );
		}
		/// <summary>Inits LibroEntity's mappings</summary>
		private void InitLibroEntityMappings()
		{
			base.AddElementMapping( "LibroEntity", "bdsemprovoc", @"dbo", "BInvLibros", 25 );
			base.AddElementFieldMapping( "LibroEntity", "Id", "Id", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "LibroEntity", "Titulo", "Titulo", false, (int)SqlDbType.VarChar, 250, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "LibroEntity", "IdAutor", "IdAutor", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 2 );
			base.AddElementFieldMapping( "LibroEntity", "Edicion", "Edicion", true, (int)SqlDbType.Char, 10, 0, 0, false, "", null, typeof(System.String), 3 );
			base.AddElementFieldMapping( "LibroEntity", "IdEditorial", "IdEditorial", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 4 );
			base.AddElementFieldMapping( "LibroEntity", "IdSeccion", "IdSeccion", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 5 );
			base.AddElementFieldMapping( "LibroEntity", "IdRama", "IdRama", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 6 );
			base.AddElementFieldMapping( "LibroEntity", "IdTematica", "IdTematica", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 7 );
			base.AddElementFieldMapping( "LibroEntity", "IdPais", "IdPais", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 8 );
			base.AddElementFieldMapping( "LibroEntity", "Año", "Año", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 9 );
			base.AddElementFieldMapping( "LibroEntity", "NumEjemplares", "NumEjemplares", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 10 );
			base.AddElementFieldMapping( "LibroEntity", "ExclusivoConsulta", "ExclusivoConsulta", false, (int)SqlDbType.Bit, 0, 0, 0, false, "", null, typeof(System.Boolean), 11 );
			base.AddElementFieldMapping( "LibroEntity", "Pasillo", "Pasillo", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 12 );
			base.AddElementFieldMapping( "LibroEntity", "Estante", "Estante", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 13 );
			base.AddElementFieldMapping( "LibroEntity", "Nivel", "Nivel", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 14 );
			base.AddElementFieldMapping( "LibroEntity", "Isbn", "ISBN", true, (int)SqlDbType.VarChar, 20, 0, 0, false, "", null, typeof(System.String), 15 );
			base.AddElementFieldMapping( "LibroEntity", "Ddc", "DDC", true, (int)SqlDbType.VarChar, 20, 0, 0, false, "", null, typeof(System.String), 16 );
			base.AddElementFieldMapping( "LibroEntity", "Cdu", "CDU", true, (int)SqlDbType.VarChar, 20, 0, 0, false, "", null, typeof(System.String), 17 );
			base.AddElementFieldMapping( "LibroEntity", "Ilustrado", "Ilustrado", true, (int)SqlDbType.Bit, 0, 0, 0, false, "", null, typeof(System.Boolean), 18 );
			base.AddElementFieldMapping( "LibroEntity", "Busqueda", "Busqueda", true, (int)SqlDbType.VarChar, 500, 0, 0, false, "", null, typeof(System.String), 19 );
			base.AddElementFieldMapping( "LibroEntity", "Portada", "Portada", true, (int)SqlDbType.Image, 2147483647, 0, 0, false, "", null, typeof(System.Byte[]), 20 );
			base.AddElementFieldMapping( "LibroEntity", "ContraPortada", "ContraPortada", true, (int)SqlDbType.Image, 2147483647, 0, 0, false, "", null, typeof(System.Byte[]), 21 );
			base.AddElementFieldMapping( "LibroEntity", "Materia", "Materia", true, (int)SqlDbType.VarChar, 200, 0, 0, false, "", null, typeof(System.String), 22 );
			base.AddElementFieldMapping( "LibroEntity", "Formato", "Formato", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 23 );
			base.AddElementFieldMapping( "LibroEntity", "Estatus", "Estatus", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 24 );
		}
		/// <summary>Inits LibroEstatusEntity's mappings</summary>
		private void InitLibroEstatusEntityMappings()
		{
			base.AddElementMapping( "LibroEstatusEntity", "bdsemprovoc", @"dbo", "BCatEstatus", 2 );
			base.AddElementFieldMapping( "LibroEstatusEntity", "Id", "Id", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "LibroEstatusEntity", "Estado", "Estado", true, (int)SqlDbType.VarChar, 100, 0, 0, false, "", null, typeof(System.String), 1 );
		}
		/// <summary>Inits LibroFormatoEntity's mappings</summary>
		private void InitLibroFormatoEntityMappings()
		{
			base.AddElementMapping( "LibroFormatoEntity", "bdsemprovoc", @"dbo", "BCatFormato", 2 );
			base.AddElementFieldMapping( "LibroFormatoEntity", "Id", "Id", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "LibroFormatoEntity", "Formato", "Formato", true, (int)SqlDbType.VarChar, 100, 0, 0, false, "", null, typeof(System.String), 1 );
		}
		/// <summary>Inits PaisEntity's mappings</summary>
		private void InitPaisEntityMappings()
		{
			base.AddElementMapping( "PaisEntity", "bdsemprovoc", @"dbo", "CatPaises", 2 );
			base.AddElementFieldMapping( "PaisEntity", "Id", "Id", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "PaisEntity", "Nombre", "Nombre", false, (int)SqlDbType.VarChar, 30, 0, 0, false, "", null, typeof(System.String), 1 );
		}
		/// <summary>Inits ParrocoEntity's mappings</summary>
		private void InitParrocoEntityMappings()
		{
			base.AddElementMapping( "ParrocoEntity", "bdsemprovoc", @"dbo", "CatParrocos", 15 );
			base.AddElementFieldMapping( "ParrocoEntity", "Id", "IdParroco", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "ParrocoEntity", "Titulo", "Titulo", true, (int)SqlDbType.NVarChar, 30, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "ParrocoEntity", "Nombre", "NomParroco", false, (int)SqlDbType.VarChar, 50, 0, 0, false, "", null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "ParrocoEntity", "Apellidos", "ApellParroco", false, (int)SqlDbType.VarChar, 50, 0, 0, false, "", null, typeof(System.String), 3 );
			base.AddElementFieldMapping( "ParrocoEntity", "Cargo", "Cargo", true, (int)SqlDbType.NVarChar, 255, 0, 0, false, "", null, typeof(System.String), 4 );
			base.AddElementFieldMapping( "ParrocoEntity", "EMail", "eMail", true, (int)SqlDbType.NVarChar, 255, 0, 0, false, "", null, typeof(System.String), 5 );
			base.AddElementFieldMapping( "ParrocoEntity", "IdParroquia", "IdParroquia", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 6 );
			base.AddElementFieldMapping( "ParrocoEntity", "NombreParroquia", "NomParroquia", true, (int)SqlDbType.NVarChar, 255, 0, 0, false, "", null, typeof(System.String), 7 );
			base.AddElementFieldMapping( "ParrocoEntity", "Telefono1", "Telefono1", true, (int)SqlDbType.VarChar, 30, 0, 0, false, "", null, typeof(System.String), 8 );
			base.AddElementFieldMapping( "ParrocoEntity", "Telefono2", "Telefono2", true, (int)SqlDbType.NVarChar, 30, 0, 0, false, "", null, typeof(System.String), 9 );
			base.AddElementFieldMapping( "ParrocoEntity", "TelCural", "TelCural", true, (int)SqlDbType.NVarChar, 30, 0, 0, false, "", null, typeof(System.String), 10 );
			base.AddElementFieldMapping( "ParrocoEntity", "Fecnac", "Fecnac", true, (int)SqlDbType.NVarChar, 255, 0, 0, false, "", null, typeof(System.String), 11 );
			base.AddElementFieldMapping( "ParrocoEntity", "FecOrdenacion", "Fecorden", true, (int)SqlDbType.NVarChar, 255, 0, 0, false, "", null, typeof(System.String), 12 );
			base.AddElementFieldMapping( "ParrocoEntity", "FechaNac", "FechaNac", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 13 );
			base.AddElementFieldMapping( "ParrocoEntity", "FechaOrdenac", "FechaOrdenac", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 14 );
		}
		/// <summary>Inits ParroquiaEntity's mappings</summary>
		private void InitParroquiaEntityMappings()
		{
			base.AddElementMapping( "ParroquiaEntity", "bdsemprovoc", @"dbo", "CatParroquias", 15 );
			base.AddElementFieldMapping( "ParroquiaEntity", "Id", "Idparroquia", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "ParroquiaEntity", "IdTipoParroquia", "Idtipoparr", false, (int)SqlDbType.TinyInt, 0, 0, 3, false, "", null, typeof(System.Byte), 1 );
			base.AddElementFieldMapping( "ParroquiaEntity", "Nombre", "Nomparr", false, (int)SqlDbType.VarChar, 255, 0, 0, false, "", null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "ParroquiaEntity", "IdZonaPastoral", "Idzonapastoral", false, (int)SqlDbType.TinyInt, 0, 0, 3, false, "", null, typeof(System.Byte), 3 );
			base.AddElementFieldMapping( "ParroquiaEntity", "IdCiudad", "Idciudad", false, (int)SqlDbType.TinyInt, 0, 0, 3, false, "", null, typeof(System.Byte), 4 );
			base.AddElementFieldMapping( "ParroquiaEntity", "Tel1", "Tel1", false, (int)SqlDbType.VarChar, 255, 0, 0, false, "", null, typeof(System.String), 5 );
			base.AddElementFieldMapping( "ParroquiaEntity", "Tel2", "Tel2", true, (int)SqlDbType.VarChar, 255, 0, 0, false, "", null, typeof(System.String), 6 );
			base.AddElementFieldMapping( "ParroquiaEntity", "Telcural", "Telcural", true, (int)SqlDbType.VarChar, 255, 0, 0, false, "", null, typeof(System.String), 7 );
			base.AddElementFieldMapping( "ParroquiaEntity", "Fax", "Fax", true, (int)SqlDbType.VarChar, 255, 0, 0, false, "", null, typeof(System.String), 8 );
			base.AddElementFieldMapping( "ParroquiaEntity", "EmailComunidad", "EMAIL_COMUNIDAD", true, (int)SqlDbType.VarChar, 255, 0, 0, false, "", null, typeof(System.String), 9 );
			base.AddElementFieldMapping( "ParroquiaEntity", "Calle", "Call", true, (int)SqlDbType.VarChar, 255, 0, 0, false, "", null, typeof(System.String), 10 );
			base.AddElementFieldMapping( "ParroquiaEntity", "NoExt", "Numext", true, (int)SqlDbType.VarChar, 255, 0, 0, false, "", null, typeof(System.String), 11 );
			base.AddElementFieldMapping( "ParroquiaEntity", "Colonia", "Col", true, (int)SqlDbType.VarChar, 255, 0, 0, false, "", null, typeof(System.String), 12 );
			base.AddElementFieldMapping( "ParroquiaEntity", "Cp", "CP", true, (int)SqlDbType.VarChar, 255, 0, 0, false, "", null, typeof(System.String), 13 );
			base.AddElementFieldMapping( "ParroquiaEntity", "ApartadoPostal", "APARTADO_POSTAL", true, (int)SqlDbType.VarChar, 255, 0, 0, false, "", null, typeof(System.String), 14 );
		}
		/// <summary>Inits ParticipanteEntity's mappings</summary>
		private void InitParticipanteEntityMappings()
		{
			base.AddElementMapping( "ParticipanteEntity", "bdsemprovoc", @"dbo", "CatParticipantes", 18 );
			base.AddElementFieldMapping( "ParticipanteEntity", "Id", "IdParticipante", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "ParticipanteEntity", "ApellidoPaterno", "ApellidoPaterno", false, (int)SqlDbType.VarChar, 50, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "ParticipanteEntity", "ApellidoMaterno", "ApellidoMaterno", false, (int)SqlDbType.VarChar, 50, 0, 0, false, "", null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "ParticipanteEntity", "Nombre", "Nombre", false, (int)SqlDbType.VarChar, 50, 0, 0, false, "", null, typeof(System.String), 3 );
			base.AddElementFieldMapping( "ParticipanteEntity", "FechaNacim", "FechaNacim", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 4 );
			base.AddElementFieldMapping( "ParticipanteEntity", "Aceptado", "Aceptado", false, (int)SqlDbType.SmallInt, 0, 0, 5, false, "", null, typeof(System.Int16), 5 );
			base.AddElementFieldMapping( "ParticipanteEntity", "NombrePadre", "NombrePadre", true, (int)SqlDbType.VarChar, 50, 0, 0, false, "", null, typeof(System.String), 6 );
			base.AddElementFieldMapping( "ParticipanteEntity", "NombreMadre", "NombreMadre", true, (int)SqlDbType.VarChar, 50, 0, 0, false, "", null, typeof(System.String), 7 );
			base.AddElementFieldMapping( "ParticipanteEntity", "VivePadre", "VivePadre", true, (int)SqlDbType.Bit, 0, 0, 0, false, "", null, typeof(System.Boolean), 8 );
			base.AddElementFieldMapping( "ParticipanteEntity", "ViveMadre", "ViveMadre", true, (int)SqlDbType.Bit, 0, 0, 0, false, "", null, typeof(System.Boolean), 9 );
			base.AddElementFieldMapping( "ParticipanteEntity", "EdoCivilPadres", "EdoCivilPadres", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 10 );
			base.AddElementFieldMapping( "ParticipanteEntity", "Hermanos", "Hermanos", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 11 );
			base.AddElementFieldMapping( "ParticipanteEntity", "Hermanas", "Hermanas", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 12 );
			base.AddElementFieldMapping( "ParticipanteEntity", "OrdenNacimiento", "OrdenNacimiento", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 13 );
			base.AddElementFieldMapping( "ParticipanteEntity", "Confirmacion", "Confirmacion", true, (int)SqlDbType.Bit, 0, 0, 0, false, "", null, typeof(System.Boolean), 14 );
			base.AddElementFieldMapping( "ParticipanteEntity", "PrimeraComunion", "PrimeraComunion", true, (int)SqlDbType.Bit, 0, 0, 0, false, "", null, typeof(System.Boolean), 15 );
			base.AddElementFieldMapping( "ParticipanteEntity", "Deportes", "Deportes", true, (int)SqlDbType.VarChar, 50, 0, 0, false, "", null, typeof(System.String), 16 );
			base.AddElementFieldMapping( "ParticipanteEntity", "Instrumentos", "Instrumentos", true, (int)SqlDbType.VarChar, 50, 0, 0, false, "", null, typeof(System.String), 17 );
		}
		/// <summary>Inits RamaEntity's mappings</summary>
		private void InitRamaEntityMappings()
		{
			base.AddElementMapping( "RamaEntity", "bdsemprovoc", @"dbo", "BCatRamas", 2 );
			base.AddElementFieldMapping( "RamaEntity", "Id", "Id", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "RamaEntity", "Nombre", "Nombre", false, (int)SqlDbType.VarChar, 50, 0, 0, false, "", null, typeof(System.String), 1 );
		}
		/// <summary>Inits SeccionEntity's mappings</summary>
		private void InitSeccionEntityMappings()
		{
			base.AddElementMapping( "SeccionEntity", "bdsemprovoc", @"dbo", "BCatSecciones", 2 );
			base.AddElementFieldMapping( "SeccionEntity", "Id", "Id", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "SeccionEntity", "Nombre", "Nombre", false, (int)SqlDbType.VarChar, 50, 0, 0, false, "", null, typeof(System.String), 1 );
		}
		/// <summary>Inits TematicaEntity's mappings</summary>
		private void InitTematicaEntityMappings()
		{
			base.AddElementMapping( "TematicaEntity", "bdsemprovoc", @"dbo", "BCatTematicas", 2 );
			base.AddElementFieldMapping( "TematicaEntity", "Id", "Id", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "TematicaEntity", "Nombre", "Nombre", false, (int)SqlDbType.VarChar, 20, 0, 0, false, "", null, typeof(System.String), 1 );
		}
		/// <summary>Inits TipoParroquiaEntity's mappings</summary>
		private void InitTipoParroquiaEntityMappings()
		{
			base.AddElementMapping( "TipoParroquiaEntity", "bdsemprovoc", @"dbo", "CatTipoParroquia", 2 );
			base.AddElementFieldMapping( "TipoParroquiaEntity", "Id", "Idtipoparr", false, (int)SqlDbType.TinyInt, 0, 0, 3, true, "SCOPE_IDENTITY()", null, typeof(System.Byte), 0 );
			base.AddElementFieldMapping( "TipoParroquiaEntity", "Descripcion", "Desctipoparr", false, (int)SqlDbType.VarChar, 50, 0, 0, false, "", null, typeof(System.String), 1 );
		}
		/// <summary>Inits VwListasEntity's mappings</summary>
		private void InitVwListasEntityMappings()
		{
			base.AddElementMapping( "VwListasEntity", "bdsemprovoc", @"dbo", "VwListas", 6 );
			base.AddElementFieldMapping( "VwListasEntity", "Nombreequipo", "Nombreequipo", false, (int)SqlDbType.VarChar, 100, 0, 0, false, "", null, typeof(System.String), 0 );
			base.AddElementFieldMapping( "VwListasEntity", "Nombreevento", "Nombreevento", false, (int)SqlDbType.VarChar, 50, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "VwListasEntity", "ApellidoPaterno", "ApellidoPaterno", false, (int)SqlDbType.VarChar, 50, 0, 0, false, "", null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "VwListasEntity", "ApellidoMaterno", "ApellidoMaterno", false, (int)SqlDbType.VarChar, 50, 0, 0, false, "", null, typeof(System.String), 3 );
			base.AddElementFieldMapping( "VwListasEntity", "Nombre", "Nombre", false, (int)SqlDbType.VarChar, 50, 0, 0, false, "", null, typeof(System.String), 4 );
			base.AddElementFieldMapping( "VwListasEntity", "Seccion", "Seccion", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 5 );
		}
		/// <summary>Inits VwparroquiasEntity's mappings</summary>
		private void InitVwparroquiasEntityMappings()
		{
			base.AddElementMapping( "VwparroquiasEntity", "bdsemprovoc", @"dbo", "Vwparroquias", 14 );
			base.AddElementFieldMapping( "VwparroquiasEntity", "Parroquia", "Parroquia", false, (int)SqlDbType.VarChar, 255, 0, 0, false, "", null, typeof(System.String), 0 );
			base.AddElementFieldMapping( "VwparroquiasEntity", "Telefono", "Telefono", false, (int)SqlDbType.VarChar, 255, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "VwparroquiasEntity", "OtroTelefono", "Otro Telefono", false, (int)SqlDbType.VarChar, 255, 0, 0, false, "", null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "VwparroquiasEntity", "TelefonoCural", "Telefono cural", false, (int)SqlDbType.VarChar, 255, 0, 0, false, "", null, typeof(System.String), 3 );
			base.AddElementFieldMapping( "VwparroquiasEntity", "Fax", "Fax", false, (int)SqlDbType.VarChar, 255, 0, 0, false, "", null, typeof(System.String), 4 );
			base.AddElementFieldMapping( "VwparroquiasEntity", "CorreoElectrónico", "Correo electrónico", false, (int)SqlDbType.VarChar, 255, 0, 0, false, "", null, typeof(System.String), 5 );
			base.AddElementFieldMapping( "VwparroquiasEntity", "Calle", "Calle", false, (int)SqlDbType.VarChar, 255, 0, 0, false, "", null, typeof(System.String), 6 );
			base.AddElementFieldMapping( "VwparroquiasEntity", "Numero", "Numero", false, (int)SqlDbType.VarChar, 255, 0, 0, false, "", null, typeof(System.String), 7 );
			base.AddElementFieldMapping( "VwparroquiasEntity", "Colonia", "Colonia", false, (int)SqlDbType.VarChar, 255, 0, 0, false, "", null, typeof(System.String), 8 );
			base.AddElementFieldMapping( "VwparroquiasEntity", "CodigoPostal", "Codigo Postal", false, (int)SqlDbType.VarChar, 255, 0, 0, false, "", null, typeof(System.String), 9 );
			base.AddElementFieldMapping( "VwparroquiasEntity", "ApartadoPostal", "Apartado Postal", false, (int)SqlDbType.VarChar, 255, 0, 0, false, "", null, typeof(System.String), 10 );
			base.AddElementFieldMapping( "VwparroquiasEntity", "Ciudad", "Ciudad", false, (int)SqlDbType.VarChar, 100, 0, 0, false, "", null, typeof(System.String), 11 );
			base.AddElementFieldMapping( "VwparroquiasEntity", "Zona", "Zona", false, (int)SqlDbType.VarChar, 100, 0, 0, false, "", null, typeof(System.String), 12 );
			base.AddElementFieldMapping( "VwparroquiasEntity", "Tipo", "Tipo", false, (int)SqlDbType.VarChar, 50, 0, 0, false, "", null, typeof(System.String), 13 );
		}
		/// <summary>Inits ZonaPastoralEntity's mappings</summary>
		private void InitZonaPastoralEntityMappings()
		{
			base.AddElementMapping( "ZonaPastoralEntity", "bdsemprovoc", @"dbo", "CatZonaPastoral", 2 );
			base.AddElementFieldMapping( "ZonaPastoralEntity", "Id", "Idzonapastoral", false, (int)SqlDbType.TinyInt, 0, 0, 3, true, "SCOPE_IDENTITY()", null, typeof(System.Byte), 0 );
			base.AddElementFieldMapping( "ZonaPastoralEntity", "Nombre", "Nomzonapastoral", false, (int)SqlDbType.VarChar, 100, 0, 0, false, "", null, typeof(System.String), 1 );
		}

	}
}