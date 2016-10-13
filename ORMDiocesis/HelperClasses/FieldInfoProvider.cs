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
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace ORMDiocesis.HelperClasses
{
	
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	
	/// <summary>
	/// Singleton implementation of the FieldInfoProvider. This class is the singleton wrapper through which the actual instance is retrieved.
	/// </summary>
	/// <remarks>It uses a single instance of an internal class. The access isn't marked with locks as the FieldInfoProviderBase class is threadsafe.</remarks>
	internal sealed class FieldInfoProviderSingleton
	{
		#region Class Member Declarations
		private static readonly IFieldInfoProvider _providerInstance = new FieldInfoProviderCore();
		#endregion
		
		/// <summary>private ctor to prevent instances of this class.</summary>
		private FieldInfoProviderSingleton()
		{
		}

		/// <summary>Dummy static constructor to make sure threadsafe initialization is performed.</summary>
		static FieldInfoProviderSingleton()
		{
		}

		/// <summary>Gets the singleton instance of the FieldInfoProviderCore</summary>
		/// <returns>Instance of the FieldInfoProvider.</returns>
		public static IFieldInfoProvider GetInstance()
		{
			return _providerInstance;
		}
	}

	/// <summary>Actual implementation of the FieldInfoProvider. Used by singleton wrapper.</summary>
	internal class FieldInfoProviderCore : FieldInfoProviderBase
	{
		/// <summary>Initializes a new instance of the <see cref="FieldInfoProviderCore"/> class.</summary>
		internal FieldInfoProviderCore()
		{
			Init();
		}

		/// <summary>Method which initializes the internal datastores.</summary>
		private void Init()
		{
			base.InitClass( (23 + 0));
			InitAsistenciaEntityInfos();
			InitAutorEntityInfos();
			InitCargoEntityInfos();
			InitCiudadEntityInfos();
			InitCiudadesEntityInfos();
			InitEditorialEntityInfos();
			InitEquipoDeTrabajoEntityInfos();
			InitEventoEntityInfos();
			InitLectoresEntityInfos();
			InitLibroEntityInfos();
			InitLibroEstatusEntityInfos();
			InitLibroFormatoEntityInfos();
			InitPaisEntityInfos();
			InitParrocoEntityInfos();
			InitParroquiaEntityInfos();
			InitParticipanteEntityInfos();
			InitRamaEntityInfos();
			InitSeccionEntityInfos();
			InitTematicaEntityInfos();
			InitTipoParroquiaEntityInfos();
			InitVwListasEntityInfos();
			InitVwparroquiasEntityInfos();
			InitZonaPastoralEntityInfos();

			base.ConstructElementFieldIndexesObjects(InheritanceInfoProviderSingleton.GetInstance());
		}

		/// <summary>Inits AsistenciaEntity's FieldInfo objects</summary>
		private void InitAsistenciaEntityInfos()
		{
			base.AddElementFieldInfo("AsistenciaEntity", "IdParticipante", typeof(System.Int32), true, true, false, false,  (int)AsistenciaFieldIndex.IdParticipante, 0, 0, 10);
			base.AddElementFieldInfo("AsistenciaEntity", "IdEvento", typeof(System.String), true, true, false, false,  (int)AsistenciaFieldIndex.IdEvento, 50, 0, 0);
			base.AddElementFieldInfo("AsistenciaEntity", "Domicilio", typeof(System.String), false, false, false, true,  (int)AsistenciaFieldIndex.Domicilio, 100, 0, 0);
			base.AddElementFieldInfo("AsistenciaEntity", "IdCiudad", typeof(Nullable<System.Byte>), false, false, false, true,  (int)AsistenciaFieldIndex.IdCiudad, 0, 0, 3);
			base.AddElementFieldInfo("AsistenciaEntity", "Telefono", typeof(System.String), false, false, false, true,  (int)AsistenciaFieldIndex.Telefono, 20, 0, 0);
			base.AddElementFieldInfo("AsistenciaEntity", "Celular", typeof(System.String), false, false, false, true,  (int)AsistenciaFieldIndex.Celular, 20, 0, 0);
			base.AddElementFieldInfo("AsistenciaEntity", "RedesSociales", typeof(System.String), false, false, false, true,  (int)AsistenciaFieldIndex.RedesSociales, 100, 0, 0);
			base.AddElementFieldInfo("AsistenciaEntity", "GradoEscolar", typeof(System.String), false, false, false, true,  (int)AsistenciaFieldIndex.GradoEscolar, 30, 0, 0);
			base.AddElementFieldInfo("AsistenciaEntity", "CodParroquia", typeof(System.Int32), false, true, false, false,  (int)AsistenciaFieldIndex.CodParroquia, 0, 0, 10);
			base.AddElementFieldInfo("AsistenciaEntity", "CodParroco", typeof(System.Int32), false, true, false, false,  (int)AsistenciaFieldIndex.CodParroco, 0, 0, 10);
			base.AddElementFieldInfo("AsistenciaEntity", "IdEquipo", typeof(System.Int32), false, false, false, false,  (int)AsistenciaFieldIndex.IdEquipo, 0, 0, 10);
			base.AddElementFieldInfo("AsistenciaEntity", "Seccion", typeof(Nullable<System.Int32>), false, false, false, true,  (int)AsistenciaFieldIndex.Seccion, 0, 0, 10);
			base.AddElementFieldInfo("AsistenciaEntity", "Observaciones", typeof(System.String), false, false, false, true,  (int)AsistenciaFieldIndex.Observaciones, 2147483647, 0, 0);
			base.AddElementFieldInfo("AsistenciaEntity", "Foto", typeof(System.Byte[]), false, false, false, true,  (int)AsistenciaFieldIndex.Foto, 2147483647, 0, 0);
			base.AddElementFieldInfo("AsistenciaEntity", "EMail", typeof(System.String), false, false, false, true,  (int)AsistenciaFieldIndex.EMail, 30, 0, 0);
		}
		/// <summary>Inits AutorEntity's FieldInfo objects</summary>
		private void InitAutorEntityInfos()
		{
			base.AddElementFieldInfo("AutorEntity", "Id", typeof(System.Int32), true, false, true, false,  (int)AutorFieldIndex.Id, 0, 0, 10);
			base.AddElementFieldInfo("AutorEntity", "Nombre", typeof(System.String), false, false, false, false,  (int)AutorFieldIndex.Nombre, 50, 0, 0);
			base.AddElementFieldInfo("AutorEntity", "IdPais", typeof(Nullable<System.Int32>), false, true, false, true,  (int)AutorFieldIndex.IdPais, 0, 0, 10);
		}
		/// <summary>Inits CargoEntity's FieldInfo objects</summary>
		private void InitCargoEntityInfos()
		{
			base.AddElementFieldInfo("CargoEntity", "Id", typeof(System.Int32), true, false, true, false,  (int)CargoFieldIndex.Id, 0, 0, 10);
			base.AddElementFieldInfo("CargoEntity", "Cargo", typeof(System.String), false, false, false, true,  (int)CargoFieldIndex.Cargo, 250, 0, 0);
		}
		/// <summary>Inits CiudadEntity's FieldInfo objects</summary>
		private void InitCiudadEntityInfos()
		{
			base.AddElementFieldInfo("CiudadEntity", "Id", typeof(System.Byte), true, false, true, false,  (int)CiudadFieldIndex.Id, 0, 0, 3);
			base.AddElementFieldInfo("CiudadEntity", "Nombre", typeof(System.String), false, false, false, false,  (int)CiudadFieldIndex.Nombre, 100, 0, 0);
		}
		/// <summary>Inits CiudadesEntity's FieldInfo objects</summary>
		private void InitCiudadesEntityInfos()
		{
			base.AddElementFieldInfo("CiudadesEntity", "Nomciudad", typeof(System.String), false, false, false, false,  (int)CiudadesFieldIndex.Nomciudad, 100, 0, 0);
			base.AddElementFieldInfo("CiudadesEntity", "Idciudad", typeof(System.Byte), false, false, false, false,  (int)CiudadesFieldIndex.Idciudad, 0, 0, 3);
		}
		/// <summary>Inits EditorialEntity's FieldInfo objects</summary>
		private void InitEditorialEntityInfos()
		{
			base.AddElementFieldInfo("EditorialEntity", "Id", typeof(System.Int32), true, false, true, false,  (int)EditorialFieldIndex.Id, 0, 0, 10);
			base.AddElementFieldInfo("EditorialEntity", "Nombre", typeof(System.String), false, false, false, false,  (int)EditorialFieldIndex.Nombre, 50, 0, 0);
		}
		/// <summary>Inits EquipoDeTrabajoEntity's FieldInfo objects</summary>
		private void InitEquipoDeTrabajoEntityInfos()
		{
			base.AddElementFieldInfo("EquipoDeTrabajoEntity", "Id", typeof(System.Int32), true, false, true, false,  (int)EquipoDeTrabajoFieldIndex.Id, 0, 0, 10);
			base.AddElementFieldInfo("EquipoDeTrabajoEntity", "IdEvento", typeof(System.String), false, true, false, false,  (int)EquipoDeTrabajoFieldIndex.IdEvento, 50, 0, 0);
			base.AddElementFieldInfo("EquipoDeTrabajoEntity", "Nombre", typeof(System.String), false, false, false, false,  (int)EquipoDeTrabajoFieldIndex.Nombre, 100, 0, 0);
			base.AddElementFieldInfo("EquipoDeTrabajoEntity", "Encargado", typeof(System.String), false, false, false, true,  (int)EquipoDeTrabajoFieldIndex.Encargado, 150, 0, 0);
		}
		/// <summary>Inits EventoEntity's FieldInfo objects</summary>
		private void InitEventoEntityInfos()
		{
			base.AddElementFieldInfo("EventoEntity", "Id", typeof(System.String), true, false, false, false,  (int)EventoFieldIndex.Id, 50, 0, 0);
			base.AddElementFieldInfo("EventoEntity", "Ano", typeof(System.Int32), false, false, false, false,  (int)EventoFieldIndex.Ano, 0, 0, 10);
			base.AddElementFieldInfo("EventoEntity", "FechaInicio", typeof(System.DateTime), false, false, false, false,  (int)EventoFieldIndex.FechaInicio, 0, 0, 0);
			base.AddElementFieldInfo("EventoEntity", "FechaFin", typeof(System.DateTime), false, false, false, false,  (int)EventoFieldIndex.FechaFin, 0, 0, 0);
			base.AddElementFieldInfo("EventoEntity", "Nombre", typeof(System.String), false, false, false, true,  (int)EventoFieldIndex.Nombre, 50, 0, 0);
			base.AddElementFieldInfo("EventoEntity", "Seccion", typeof(Nullable<System.Boolean>), false, false, false, true,  (int)EventoFieldIndex.Seccion, 0, 0, 0);
			base.AddElementFieldInfo("EventoEntity", "Estatus", typeof(System.Int32), false, false, false, false,  (int)EventoFieldIndex.Estatus, 0, 0, 10);
			base.AddElementFieldInfo("EventoEntity", "LugarEvento", typeof(System.String), false, false, false, true,  (int)EventoFieldIndex.LugarEvento, 50, 0, 0);
		}
		/// <summary>Inits LectoresEntity's FieldInfo objects</summary>
		private void InitLectoresEntityInfos()
		{
			base.AddElementFieldInfo("LectoresEntity", "IdLectores", typeof(System.Int32), true, false, false, false,  (int)LectoresFieldIndex.IdLectores, 0, 0, 10);
			base.AddElementFieldInfo("LectoresEntity", "Matricula", typeof(System.String), false, false, false, true,  (int)LectoresFieldIndex.Matricula, 255, 0, 0);
			base.AddElementFieldInfo("LectoresEntity", "Nombre", typeof(System.String), false, false, false, true,  (int)LectoresFieldIndex.Nombre, 255, 0, 0);
			base.AddElementFieldInfo("LectoresEntity", "ApellidoPaterno", typeof(System.String), false, false, false, true,  (int)LectoresFieldIndex.ApellidoPaterno, 255, 0, 0);
			base.AddElementFieldInfo("LectoresEntity", "ApellidoMaterno", typeof(System.String), false, false, false, true,  (int)LectoresFieldIndex.ApellidoMaterno, 255, 0, 0);
			base.AddElementFieldInfo("LectoresEntity", "Sexo", typeof(System.String), false, false, false, true,  (int)LectoresFieldIndex.Sexo, 255, 0, 0);
			base.AddElementFieldInfo("LectoresEntity", "Grupo", typeof(System.String), false, false, false, true,  (int)LectoresFieldIndex.Grupo, 255, 0, 0);
			base.AddElementFieldInfo("LectoresEntity", "FechaNacimiento", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)LectoresFieldIndex.FechaNacimiento, 0, 0, 0);
			base.AddElementFieldInfo("LectoresEntity", "CalleNumero", typeof(System.String), false, false, false, true,  (int)LectoresFieldIndex.CalleNumero, 255, 0, 0);
			base.AddElementFieldInfo("LectoresEntity", "Ciudad", typeof(System.String), false, false, false, true,  (int)LectoresFieldIndex.Ciudad, 255, 0, 0);
			base.AddElementFieldInfo("LectoresEntity", "Estado", typeof(System.String), false, false, false, true,  (int)LectoresFieldIndex.Estado, 255, 0, 0);
			base.AddElementFieldInfo("LectoresEntity", "Telefono", typeof(System.String), false, false, false, true,  (int)LectoresFieldIndex.Telefono, 255, 0, 0);
			base.AddElementFieldInfo("LectoresEntity", "Celular", typeof(System.String), false, false, false, true,  (int)LectoresFieldIndex.Celular, 255, 0, 0);
			base.AddElementFieldInfo("LectoresEntity", "Facultad", typeof(System.String), false, false, false, true,  (int)LectoresFieldIndex.Facultad, 255, 0, 0);
			base.AddElementFieldInfo("LectoresEntity", "FechaAlta", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)LectoresFieldIndex.FechaAlta, 0, 0, 0);
			base.AddElementFieldInfo("LectoresEntity", "FechaVigencia", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)LectoresFieldIndex.FechaVigencia, 0, 0, 0);
			base.AddElementFieldInfo("LectoresEntity", "Baja", typeof(Nullable<System.Boolean>), false, false, false, true,  (int)LectoresFieldIndex.Baja, 0, 0, 0);
			base.AddElementFieldInfo("LectoresEntity", "Suspendido", typeof(Nullable<System.Boolean>), false, false, false, true,  (int)LectoresFieldIndex.Suspendido, 0, 0, 0);
			base.AddElementFieldInfo("LectoresEntity", "FechaBaja", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)LectoresFieldIndex.FechaBaja, 0, 0, 0);
			base.AddElementFieldInfo("LectoresEntity", "MotivoBaja", typeof(System.String), false, false, false, true,  (int)LectoresFieldIndex.MotivoBaja, 255, 0, 0);
			base.AddElementFieldInfo("LectoresEntity", "MotivoSuspendido", typeof(System.String), false, false, false, true,  (int)LectoresFieldIndex.MotivoSuspendido, 255, 0, 0);
			base.AddElementFieldInfo("LectoresEntity", "InicioSuspension", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)LectoresFieldIndex.InicioSuspension, 0, 0, 0);
			base.AddElementFieldInfo("LectoresEntity", "DiasSuspension", typeof(Nullable<System.Int32>), false, false, false, true,  (int)LectoresFieldIndex.DiasSuspension, 0, 0, 10);
			base.AddElementFieldInfo("LectoresEntity", "Observaciones", typeof(System.String), false, false, false, true,  (int)LectoresFieldIndex.Observaciones, 255, 0, 0);
			base.AddElementFieldInfo("LectoresEntity", "Cp", typeof(Nullable<System.Int32>), false, false, false, true,  (int)LectoresFieldIndex.Cp, 0, 0, 10);
			base.AddElementFieldInfo("LectoresEntity", "Facebook", typeof(System.String), false, false, false, true,  (int)LectoresFieldIndex.Facebook, 50, 0, 0);
			base.AddElementFieldInfo("LectoresEntity", "Numero", typeof(Nullable<System.Int32>), false, false, false, true,  (int)LectoresFieldIndex.Numero, 0, 0, 10);
			base.AddElementFieldInfo("LectoresEntity", "Colonia", typeof(System.String), false, false, false, true,  (int)LectoresFieldIndex.Colonia, 50, 0, 0);
			base.AddElementFieldInfo("LectoresEntity", "Email", typeof(System.String), false, false, false, true,  (int)LectoresFieldIndex.Email, 50, 0, 0);
		}
		/// <summary>Inits LibroEntity's FieldInfo objects</summary>
		private void InitLibroEntityInfos()
		{
			base.AddElementFieldInfo("LibroEntity", "Id", typeof(System.Int32), true, false, true, false,  (int)LibroFieldIndex.Id, 0, 0, 10);
			base.AddElementFieldInfo("LibroEntity", "Titulo", typeof(System.String), false, false, false, false,  (int)LibroFieldIndex.Titulo, 250, 0, 0);
			base.AddElementFieldInfo("LibroEntity", "IdAutor", typeof(System.Int32), false, true, false, false,  (int)LibroFieldIndex.IdAutor, 0, 0, 10);
			base.AddElementFieldInfo("LibroEntity", "Edicion", typeof(System.String), false, false, false, true,  (int)LibroFieldIndex.Edicion, 10, 0, 0);
			base.AddElementFieldInfo("LibroEntity", "IdEditorial", typeof(System.Int32), false, true, false, false,  (int)LibroFieldIndex.IdEditorial, 0, 0, 10);
			base.AddElementFieldInfo("LibroEntity", "IdSeccion", typeof(System.Int32), false, true, false, false,  (int)LibroFieldIndex.IdSeccion, 0, 0, 10);
			base.AddElementFieldInfo("LibroEntity", "IdRama", typeof(System.Int32), false, true, false, false,  (int)LibroFieldIndex.IdRama, 0, 0, 10);
			base.AddElementFieldInfo("LibroEntity", "IdTematica", typeof(System.Int32), false, true, false, false,  (int)LibroFieldIndex.IdTematica, 0, 0, 10);
			base.AddElementFieldInfo("LibroEntity", "IdPais", typeof(Nullable<System.Int32>), false, true, false, true,  (int)LibroFieldIndex.IdPais, 0, 0, 10);
			base.AddElementFieldInfo("LibroEntity", "Año", typeof(Nullable<System.Int32>), false, false, false, true,  (int)LibroFieldIndex.Año, 0, 0, 10);
			base.AddElementFieldInfo("LibroEntity", "NumEjemplares", typeof(System.Int32), false, false, false, false,  (int)LibroFieldIndex.NumEjemplares, 0, 0, 10);
			base.AddElementFieldInfo("LibroEntity", "ExclusivoConsulta", typeof(System.Boolean), false, false, false, false,  (int)LibroFieldIndex.ExclusivoConsulta, 0, 0, 0);
			base.AddElementFieldInfo("LibroEntity", "Pasillo", typeof(Nullable<System.Int32>), false, false, false, true,  (int)LibroFieldIndex.Pasillo, 0, 0, 10);
			base.AddElementFieldInfo("LibroEntity", "Estante", typeof(Nullable<System.Int32>), false, false, false, true,  (int)LibroFieldIndex.Estante, 0, 0, 10);
			base.AddElementFieldInfo("LibroEntity", "Nivel", typeof(Nullable<System.Int32>), false, false, false, true,  (int)LibroFieldIndex.Nivel, 0, 0, 10);
			base.AddElementFieldInfo("LibroEntity", "Isbn", typeof(System.String), false, false, false, true,  (int)LibroFieldIndex.Isbn, 20, 0, 0);
			base.AddElementFieldInfo("LibroEntity", "Ddc", typeof(System.String), false, false, false, true,  (int)LibroFieldIndex.Ddc, 20, 0, 0);
			base.AddElementFieldInfo("LibroEntity", "Cdu", typeof(System.String), false, false, false, true,  (int)LibroFieldIndex.Cdu, 20, 0, 0);
			base.AddElementFieldInfo("LibroEntity", "Ilustrado", typeof(Nullable<System.Boolean>), false, false, false, true,  (int)LibroFieldIndex.Ilustrado, 0, 0, 0);
			base.AddElementFieldInfo("LibroEntity", "Busqueda", typeof(System.String), false, false, false, true,  (int)LibroFieldIndex.Busqueda, 500, 0, 0);
			base.AddElementFieldInfo("LibroEntity", "Portada", typeof(System.Byte[]), false, false, false, true,  (int)LibroFieldIndex.Portada, 2147483647, 0, 0);
			base.AddElementFieldInfo("LibroEntity", "ContraPortada", typeof(System.Byte[]), false, false, false, true,  (int)LibroFieldIndex.ContraPortada, 2147483647, 0, 0);
			base.AddElementFieldInfo("LibroEntity", "Materia", typeof(System.String), false, false, false, true,  (int)LibroFieldIndex.Materia, 200, 0, 0);
			base.AddElementFieldInfo("LibroEntity", "Formato", typeof(Nullable<System.Int32>), false, true, false, true,  (int)LibroFieldIndex.Formato, 0, 0, 10);
			base.AddElementFieldInfo("LibroEntity", "Estatus", typeof(Nullable<System.Int32>), false, true, false, true,  (int)LibroFieldIndex.Estatus, 0, 0, 10);
			base.AddElementFieldInfo("LibroEntity", "Numero", typeof(System.String), false, false, false, true,  (int)LibroFieldIndex.Numero, 50, 0, 0);
		}
		/// <summary>Inits LibroEstatusEntity's FieldInfo objects</summary>
		private void InitLibroEstatusEntityInfos()
		{
			base.AddElementFieldInfo("LibroEstatusEntity", "Id", typeof(System.Int32), true, false, true, false,  (int)LibroEstatusFieldIndex.Id, 0, 0, 10);
			base.AddElementFieldInfo("LibroEstatusEntity", "Estado", typeof(System.String), false, false, false, true,  (int)LibroEstatusFieldIndex.Estado, 100, 0, 0);
		}
		/// <summary>Inits LibroFormatoEntity's FieldInfo objects</summary>
		private void InitLibroFormatoEntityInfos()
		{
			base.AddElementFieldInfo("LibroFormatoEntity", "Id", typeof(System.Int32), true, false, true, false,  (int)LibroFormatoFieldIndex.Id, 0, 0, 10);
			base.AddElementFieldInfo("LibroFormatoEntity", "Formato", typeof(System.String), false, false, false, true,  (int)LibroFormatoFieldIndex.Formato, 100, 0, 0);
		}
		/// <summary>Inits PaisEntity's FieldInfo objects</summary>
		private void InitPaisEntityInfos()
		{
			base.AddElementFieldInfo("PaisEntity", "Id", typeof(System.Int32), true, false, true, false,  (int)PaisFieldIndex.Id, 0, 0, 10);
			base.AddElementFieldInfo("PaisEntity", "Nombre", typeof(System.String), false, false, false, false,  (int)PaisFieldIndex.Nombre, 30, 0, 0);
		}
		/// <summary>Inits ParrocoEntity's FieldInfo objects</summary>
		private void InitParrocoEntityInfos()
		{
			base.AddElementFieldInfo("ParrocoEntity", "Id", typeof(System.Int32), true, false, true, false,  (int)ParrocoFieldIndex.Id, 0, 0, 10);
			base.AddElementFieldInfo("ParrocoEntity", "Titulo", typeof(System.String), false, false, false, true,  (int)ParrocoFieldIndex.Titulo, 30, 0, 0);
			base.AddElementFieldInfo("ParrocoEntity", "Nombre", typeof(System.String), false, false, false, false,  (int)ParrocoFieldIndex.Nombre, 50, 0, 0);
			base.AddElementFieldInfo("ParrocoEntity", "Apellidos", typeof(System.String), false, false, false, false,  (int)ParrocoFieldIndex.Apellidos, 50, 0, 0);
			base.AddElementFieldInfo("ParrocoEntity", "Cargo", typeof(System.String), false, false, false, true,  (int)ParrocoFieldIndex.Cargo, 255, 0, 0);
			base.AddElementFieldInfo("ParrocoEntity", "EMail", typeof(System.String), false, false, false, true,  (int)ParrocoFieldIndex.EMail, 255, 0, 0);
			base.AddElementFieldInfo("ParrocoEntity", "IdParroquia", typeof(Nullable<System.Int32>), false, true, false, true,  (int)ParrocoFieldIndex.IdParroquia, 0, 0, 10);
			base.AddElementFieldInfo("ParrocoEntity", "NombreParroquia", typeof(System.String), false, false, false, true,  (int)ParrocoFieldIndex.NombreParroquia, 255, 0, 0);
			base.AddElementFieldInfo("ParrocoEntity", "Telefono1", typeof(System.String), false, false, false, true,  (int)ParrocoFieldIndex.Telefono1, 30, 0, 0);
			base.AddElementFieldInfo("ParrocoEntity", "Telefono2", typeof(System.String), false, false, false, true,  (int)ParrocoFieldIndex.Telefono2, 30, 0, 0);
			base.AddElementFieldInfo("ParrocoEntity", "TelCural", typeof(System.String), false, false, false, true,  (int)ParrocoFieldIndex.TelCural, 30, 0, 0);
			base.AddElementFieldInfo("ParrocoEntity", "Fecnac", typeof(System.String), false, false, false, true,  (int)ParrocoFieldIndex.Fecnac, 255, 0, 0);
			base.AddElementFieldInfo("ParrocoEntity", "FecOrdenacion", typeof(System.String), false, false, false, true,  (int)ParrocoFieldIndex.FecOrdenacion, 255, 0, 0);
			base.AddElementFieldInfo("ParrocoEntity", "FechaNac", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)ParrocoFieldIndex.FechaNac, 0, 0, 0);
			base.AddElementFieldInfo("ParrocoEntity", "FechaOrdenac", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)ParrocoFieldIndex.FechaOrdenac, 0, 0, 0);
		}
		/// <summary>Inits ParroquiaEntity's FieldInfo objects</summary>
		private void InitParroquiaEntityInfos()
		{
			base.AddElementFieldInfo("ParroquiaEntity", "Id", typeof(System.Int32), true, false, false, false,  (int)ParroquiaFieldIndex.Id, 0, 0, 10);
			base.AddElementFieldInfo("ParroquiaEntity", "IdTipoParroquia", typeof(System.Byte), false, true, false, false,  (int)ParroquiaFieldIndex.IdTipoParroquia, 0, 0, 3);
			base.AddElementFieldInfo("ParroquiaEntity", "Nombre", typeof(System.String), false, false, false, false,  (int)ParroquiaFieldIndex.Nombre, 255, 0, 0);
			base.AddElementFieldInfo("ParroquiaEntity", "IdZonaPastoral", typeof(System.Byte), false, true, false, false,  (int)ParroquiaFieldIndex.IdZonaPastoral, 0, 0, 3);
			base.AddElementFieldInfo("ParroquiaEntity", "IdCiudad", typeof(System.Byte), false, true, false, false,  (int)ParroquiaFieldIndex.IdCiudad, 0, 0, 3);
			base.AddElementFieldInfo("ParroquiaEntity", "Tel1", typeof(System.String), false, false, false, false,  (int)ParroquiaFieldIndex.Tel1, 255, 0, 0);
			base.AddElementFieldInfo("ParroquiaEntity", "Tel2", typeof(System.String), false, false, false, true,  (int)ParroquiaFieldIndex.Tel2, 255, 0, 0);
			base.AddElementFieldInfo("ParroquiaEntity", "Telcural", typeof(System.String), false, false, false, true,  (int)ParroquiaFieldIndex.Telcural, 255, 0, 0);
			base.AddElementFieldInfo("ParroquiaEntity", "Fax", typeof(System.String), false, false, false, true,  (int)ParroquiaFieldIndex.Fax, 255, 0, 0);
			base.AddElementFieldInfo("ParroquiaEntity", "EmailComunidad", typeof(System.String), false, false, false, true,  (int)ParroquiaFieldIndex.EmailComunidad, 255, 0, 0);
			base.AddElementFieldInfo("ParroquiaEntity", "Calle", typeof(System.String), false, false, false, true,  (int)ParroquiaFieldIndex.Calle, 255, 0, 0);
			base.AddElementFieldInfo("ParroquiaEntity", "NoExt", typeof(System.String), false, false, false, true,  (int)ParroquiaFieldIndex.NoExt, 255, 0, 0);
			base.AddElementFieldInfo("ParroquiaEntity", "Colonia", typeof(System.String), false, false, false, true,  (int)ParroquiaFieldIndex.Colonia, 255, 0, 0);
			base.AddElementFieldInfo("ParroquiaEntity", "Cp", typeof(System.String), false, false, false, true,  (int)ParroquiaFieldIndex.Cp, 255, 0, 0);
			base.AddElementFieldInfo("ParroquiaEntity", "ApartadoPostal", typeof(System.String), false, false, false, true,  (int)ParroquiaFieldIndex.ApartadoPostal, 255, 0, 0);
		}
		/// <summary>Inits ParticipanteEntity's FieldInfo objects</summary>
		private void InitParticipanteEntityInfos()
		{
			base.AddElementFieldInfo("ParticipanteEntity", "Id", typeof(System.Int32), true, false, true, false,  (int)ParticipanteFieldIndex.Id, 0, 0, 10);
			base.AddElementFieldInfo("ParticipanteEntity", "ApellidoPaterno", typeof(System.String), false, false, false, false,  (int)ParticipanteFieldIndex.ApellidoPaterno, 50, 0, 0);
			base.AddElementFieldInfo("ParticipanteEntity", "ApellidoMaterno", typeof(System.String), false, false, false, false,  (int)ParticipanteFieldIndex.ApellidoMaterno, 50, 0, 0);
			base.AddElementFieldInfo("ParticipanteEntity", "Nombre", typeof(System.String), false, false, false, false,  (int)ParticipanteFieldIndex.Nombre, 50, 0, 0);
			base.AddElementFieldInfo("ParticipanteEntity", "FechaNacim", typeof(System.DateTime), false, false, false, false,  (int)ParticipanteFieldIndex.FechaNacim, 0, 0, 0);
			base.AddElementFieldInfo("ParticipanteEntity", "Aceptado", typeof(System.Int16), false, false, false, false,  (int)ParticipanteFieldIndex.Aceptado, 0, 0, 5);
			base.AddElementFieldInfo("ParticipanteEntity", "NombrePadre", typeof(System.String), false, false, false, true,  (int)ParticipanteFieldIndex.NombrePadre, 50, 0, 0);
			base.AddElementFieldInfo("ParticipanteEntity", "NombreMadre", typeof(System.String), false, false, false, true,  (int)ParticipanteFieldIndex.NombreMadre, 50, 0, 0);
			base.AddElementFieldInfo("ParticipanteEntity", "VivePadre", typeof(Nullable<System.Boolean>), false, false, false, true,  (int)ParticipanteFieldIndex.VivePadre, 0, 0, 0);
			base.AddElementFieldInfo("ParticipanteEntity", "ViveMadre", typeof(Nullable<System.Boolean>), false, false, false, true,  (int)ParticipanteFieldIndex.ViveMadre, 0, 0, 0);
			base.AddElementFieldInfo("ParticipanteEntity", "EdoCivilPadres", typeof(Nullable<System.Int32>), false, false, false, true,  (int)ParticipanteFieldIndex.EdoCivilPadres, 0, 0, 10);
			base.AddElementFieldInfo("ParticipanteEntity", "Hermanos", typeof(Nullable<System.Int32>), false, false, false, true,  (int)ParticipanteFieldIndex.Hermanos, 0, 0, 10);
			base.AddElementFieldInfo("ParticipanteEntity", "Hermanas", typeof(Nullable<System.Int32>), false, false, false, true,  (int)ParticipanteFieldIndex.Hermanas, 0, 0, 10);
			base.AddElementFieldInfo("ParticipanteEntity", "OrdenNacimiento", typeof(Nullable<System.Int32>), false, false, false, true,  (int)ParticipanteFieldIndex.OrdenNacimiento, 0, 0, 10);
			base.AddElementFieldInfo("ParticipanteEntity", "Confirmacion", typeof(Nullable<System.Boolean>), false, false, false, true,  (int)ParticipanteFieldIndex.Confirmacion, 0, 0, 0);
			base.AddElementFieldInfo("ParticipanteEntity", "PrimeraComunion", typeof(Nullable<System.Boolean>), false, false, false, true,  (int)ParticipanteFieldIndex.PrimeraComunion, 0, 0, 0);
			base.AddElementFieldInfo("ParticipanteEntity", "Deportes", typeof(System.String), false, false, false, true,  (int)ParticipanteFieldIndex.Deportes, 50, 0, 0);
			base.AddElementFieldInfo("ParticipanteEntity", "Instrumentos", typeof(System.String), false, false, false, true,  (int)ParticipanteFieldIndex.Instrumentos, 50, 0, 0);
		}
		/// <summary>Inits RamaEntity's FieldInfo objects</summary>
		private void InitRamaEntityInfos()
		{
			base.AddElementFieldInfo("RamaEntity", "Id", typeof(System.Int32), true, false, true, false,  (int)RamaFieldIndex.Id, 0, 0, 10);
			base.AddElementFieldInfo("RamaEntity", "Nombre", typeof(System.String), false, false, false, false,  (int)RamaFieldIndex.Nombre, 50, 0, 0);
		}
		/// <summary>Inits SeccionEntity's FieldInfo objects</summary>
		private void InitSeccionEntityInfos()
		{
			base.AddElementFieldInfo("SeccionEntity", "Id", typeof(System.Int32), true, false, true, false,  (int)SeccionFieldIndex.Id, 0, 0, 10);
			base.AddElementFieldInfo("SeccionEntity", "Nombre", typeof(System.String), false, false, false, false,  (int)SeccionFieldIndex.Nombre, 50, 0, 0);
		}
		/// <summary>Inits TematicaEntity's FieldInfo objects</summary>
		private void InitTematicaEntityInfos()
		{
			base.AddElementFieldInfo("TematicaEntity", "Id", typeof(System.Int32), true, false, true, false,  (int)TematicaFieldIndex.Id, 0, 0, 10);
			base.AddElementFieldInfo("TematicaEntity", "Nombre", typeof(System.String), false, false, false, false,  (int)TematicaFieldIndex.Nombre, 20, 0, 0);
		}
		/// <summary>Inits TipoParroquiaEntity's FieldInfo objects</summary>
		private void InitTipoParroquiaEntityInfos()
		{
			base.AddElementFieldInfo("TipoParroquiaEntity", "Id", typeof(System.Byte), true, false, true, false,  (int)TipoParroquiaFieldIndex.Id, 0, 0, 3);
			base.AddElementFieldInfo("TipoParroquiaEntity", "Descripcion", typeof(System.String), false, false, false, false,  (int)TipoParroquiaFieldIndex.Descripcion, 50, 0, 0);
		}
		/// <summary>Inits VwListasEntity's FieldInfo objects</summary>
		private void InitVwListasEntityInfos()
		{
			base.AddElementFieldInfo("VwListasEntity", "Nombreequipo", typeof(System.String), false, false, false, false,  (int)VwListasFieldIndex.Nombreequipo, 100, 0, 0);
			base.AddElementFieldInfo("VwListasEntity", "Nombreevento", typeof(System.String), false, false, false, false,  (int)VwListasFieldIndex.Nombreevento, 50, 0, 0);
			base.AddElementFieldInfo("VwListasEntity", "ApellidoPaterno", typeof(System.String), false, false, false, false,  (int)VwListasFieldIndex.ApellidoPaterno, 50, 0, 0);
			base.AddElementFieldInfo("VwListasEntity", "ApellidoMaterno", typeof(System.String), false, false, false, false,  (int)VwListasFieldIndex.ApellidoMaterno, 50, 0, 0);
			base.AddElementFieldInfo("VwListasEntity", "Nombre", typeof(System.String), false, false, false, false,  (int)VwListasFieldIndex.Nombre, 50, 0, 0);
			base.AddElementFieldInfo("VwListasEntity", "Seccion", typeof(System.Int32), false, false, false, false,  (int)VwListasFieldIndex.Seccion, 0, 0, 10);
		}
		/// <summary>Inits VwparroquiasEntity's FieldInfo objects</summary>
		private void InitVwparroquiasEntityInfos()
		{
			base.AddElementFieldInfo("VwparroquiasEntity", "Parroquia", typeof(System.String), false, false, false, false,  (int)VwparroquiasFieldIndex.Parroquia, 255, 0, 0);
			base.AddElementFieldInfo("VwparroquiasEntity", "Telefono", typeof(System.String), false, false, false, false,  (int)VwparroquiasFieldIndex.Telefono, 255, 0, 0);
			base.AddElementFieldInfo("VwparroquiasEntity", "OtroTelefono", typeof(System.String), false, false, false, false,  (int)VwparroquiasFieldIndex.OtroTelefono, 255, 0, 0);
			base.AddElementFieldInfo("VwparroquiasEntity", "TelefonoCural", typeof(System.String), false, false, false, false,  (int)VwparroquiasFieldIndex.TelefonoCural, 255, 0, 0);
			base.AddElementFieldInfo("VwparroquiasEntity", "Fax", typeof(System.String), false, false, false, false,  (int)VwparroquiasFieldIndex.Fax, 255, 0, 0);
			base.AddElementFieldInfo("VwparroquiasEntity", "CorreoElectrónico", typeof(System.String), false, false, false, false,  (int)VwparroquiasFieldIndex.CorreoElectrónico, 255, 0, 0);
			base.AddElementFieldInfo("VwparroquiasEntity", "Calle", typeof(System.String), false, false, false, false,  (int)VwparroquiasFieldIndex.Calle, 255, 0, 0);
			base.AddElementFieldInfo("VwparroquiasEntity", "Numero", typeof(System.String), false, false, false, false,  (int)VwparroquiasFieldIndex.Numero, 255, 0, 0);
			base.AddElementFieldInfo("VwparroquiasEntity", "Colonia", typeof(System.String), false, false, false, false,  (int)VwparroquiasFieldIndex.Colonia, 255, 0, 0);
			base.AddElementFieldInfo("VwparroquiasEntity", "CodigoPostal", typeof(System.String), false, false, false, false,  (int)VwparroquiasFieldIndex.CodigoPostal, 255, 0, 0);
			base.AddElementFieldInfo("VwparroquiasEntity", "ApartadoPostal", typeof(System.String), false, false, false, false,  (int)VwparroquiasFieldIndex.ApartadoPostal, 255, 0, 0);
			base.AddElementFieldInfo("VwparroquiasEntity", "Ciudad", typeof(System.String), false, false, false, false,  (int)VwparroquiasFieldIndex.Ciudad, 100, 0, 0);
			base.AddElementFieldInfo("VwparroquiasEntity", "Zona", typeof(System.String), false, false, false, false,  (int)VwparroquiasFieldIndex.Zona, 100, 0, 0);
			base.AddElementFieldInfo("VwparroquiasEntity", "Tipo", typeof(System.String), false, false, false, false,  (int)VwparroquiasFieldIndex.Tipo, 50, 0, 0);
		}
		/// <summary>Inits ZonaPastoralEntity's FieldInfo objects</summary>
		private void InitZonaPastoralEntityInfos()
		{
			base.AddElementFieldInfo("ZonaPastoralEntity", "Id", typeof(System.Byte), true, false, true, false,  (int)ZonaPastoralFieldIndex.Id, 0, 0, 3);
			base.AddElementFieldInfo("ZonaPastoralEntity", "Nombre", typeof(System.String), false, false, false, false,  (int)ZonaPastoralFieldIndex.Nombre, 100, 0, 0);
		}
		
	}
}




