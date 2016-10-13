///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 2.0.0.0
// Code is generated on: jueves, 07 de julio de 2016 11:14:01 a.m.
// Code is generated using templates: SD.TemplateBindings.SharedTemplates.NET20
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.Data;

using ORMDiocesis;
using ORMDiocesis.HelperClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace ORMDiocesis.FactoryClasses
{
	/// <summary>
	/// Factory class for IEntityField instances, used in IEntityFields instances.
	/// </summary>
	public partial class EntityFieldFactory
	{
		/// <summary>
		/// Private CTor, no instantiation possible.
		/// </summary>
		private EntityFieldFactory()
		{
		}

	
		/// <summary>
		/// Creates a new IEntityField instance for usage in the EntityFields object for the AsistenciaEntity. 
		/// Which EntityField is created is specified by fieldIndex
		/// </summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in fieldIndex</returns>
		public static IEntityField Create(AsistenciaFieldIndex fieldIndex)
		{
			IEntityField fieldToReturn = null;
			IFieldInfoProvider fieldProvider = FieldInfoProviderSingleton.GetInstance();
			IPersistenceInfoProvider persistenceProvider = PersistenceInfoProviderSingleton.GetInstance();
			switch(fieldIndex)
			{
				case AsistenciaFieldIndex.IdParticipante:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("AsistenciaEntity", "IdParticipante"), persistenceProvider.GetFieldPersistenceInfo("AsistenciaEntity", "IdParticipante"));
					break;
				case AsistenciaFieldIndex.IdEvento:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("AsistenciaEntity", "IdEvento"), persistenceProvider.GetFieldPersistenceInfo("AsistenciaEntity", "IdEvento"));
					break;
				case AsistenciaFieldIndex.Domicilio:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("AsistenciaEntity", "Domicilio"), persistenceProvider.GetFieldPersistenceInfo("AsistenciaEntity", "Domicilio"));
					break;
				case AsistenciaFieldIndex.IdCiudad:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("AsistenciaEntity", "IdCiudad"), persistenceProvider.GetFieldPersistenceInfo("AsistenciaEntity", "IdCiudad"));
					break;
				case AsistenciaFieldIndex.Telefono:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("AsistenciaEntity", "Telefono"), persistenceProvider.GetFieldPersistenceInfo("AsistenciaEntity", "Telefono"));
					break;
				case AsistenciaFieldIndex.Celular:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("AsistenciaEntity", "Celular"), persistenceProvider.GetFieldPersistenceInfo("AsistenciaEntity", "Celular"));
					break;
				case AsistenciaFieldIndex.RedesSociales:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("AsistenciaEntity", "RedesSociales"), persistenceProvider.GetFieldPersistenceInfo("AsistenciaEntity", "RedesSociales"));
					break;
				case AsistenciaFieldIndex.GradoEscolar:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("AsistenciaEntity", "GradoEscolar"), persistenceProvider.GetFieldPersistenceInfo("AsistenciaEntity", "GradoEscolar"));
					break;
				case AsistenciaFieldIndex.CodParroquia:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("AsistenciaEntity", "CodParroquia"), persistenceProvider.GetFieldPersistenceInfo("AsistenciaEntity", "CodParroquia"));
					break;
				case AsistenciaFieldIndex.CodParroco:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("AsistenciaEntity", "CodParroco"), persistenceProvider.GetFieldPersistenceInfo("AsistenciaEntity", "CodParroco"));
					break;
				case AsistenciaFieldIndex.IdEquipo:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("AsistenciaEntity", "IdEquipo"), persistenceProvider.GetFieldPersistenceInfo("AsistenciaEntity", "IdEquipo"));
					break;
				case AsistenciaFieldIndex.Seccion:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("AsistenciaEntity", "Seccion"), persistenceProvider.GetFieldPersistenceInfo("AsistenciaEntity", "Seccion"));
					break;
				case AsistenciaFieldIndex.Observaciones:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("AsistenciaEntity", "Observaciones"), persistenceProvider.GetFieldPersistenceInfo("AsistenciaEntity", "Observaciones"));
					break;
				case AsistenciaFieldIndex.Foto:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("AsistenciaEntity", "Foto"), persistenceProvider.GetFieldPersistenceInfo("AsistenciaEntity", "Foto"));
					break;
				case AsistenciaFieldIndex.EMail:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("AsistenciaEntity", "EMail"), persistenceProvider.GetFieldPersistenceInfo("AsistenciaEntity", "EMail"));
					break;
					
			}
			return fieldToReturn;
		}
	
		/// <summary>
		/// Creates a new IEntityField instance for usage in the EntityFields object for the AutorEntity. 
		/// Which EntityField is created is specified by fieldIndex
		/// </summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in fieldIndex</returns>
		public static IEntityField Create(AutorFieldIndex fieldIndex)
		{
			IEntityField fieldToReturn = null;
			IFieldInfoProvider fieldProvider = FieldInfoProviderSingleton.GetInstance();
			IPersistenceInfoProvider persistenceProvider = PersistenceInfoProviderSingleton.GetInstance();
			switch(fieldIndex)
			{
				case AutorFieldIndex.Id:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("AutorEntity", "Id"), persistenceProvider.GetFieldPersistenceInfo("AutorEntity", "Id"));
					break;
				case AutorFieldIndex.Nombre:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("AutorEntity", "Nombre"), persistenceProvider.GetFieldPersistenceInfo("AutorEntity", "Nombre"));
					break;
				case AutorFieldIndex.IdPais:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("AutorEntity", "IdPais"), persistenceProvider.GetFieldPersistenceInfo("AutorEntity", "IdPais"));
					break;
					
			}
			return fieldToReturn;
		}
	
		/// <summary>
		/// Creates a new IEntityField instance for usage in the EntityFields object for the CiudadEntity. 
		/// Which EntityField is created is specified by fieldIndex
		/// </summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in fieldIndex</returns>
		public static IEntityField Create(CiudadFieldIndex fieldIndex)
		{
			IEntityField fieldToReturn = null;
			IFieldInfoProvider fieldProvider = FieldInfoProviderSingleton.GetInstance();
			IPersistenceInfoProvider persistenceProvider = PersistenceInfoProviderSingleton.GetInstance();
			switch(fieldIndex)
			{
				case CiudadFieldIndex.Id:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("CiudadEntity", "Id"), persistenceProvider.GetFieldPersistenceInfo("CiudadEntity", "Id"));
					break;
				case CiudadFieldIndex.Nombre:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("CiudadEntity", "Nombre"), persistenceProvider.GetFieldPersistenceInfo("CiudadEntity", "Nombre"));
					break;
					
			}
			return fieldToReturn;
		}
	
		/// <summary>
		/// Creates a new IEntityField instance for usage in the EntityFields object for the CiudadesEntity. 
		/// Which EntityField is created is specified by fieldIndex
		/// </summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in fieldIndex</returns>
		public static IEntityField Create(CiudadesFieldIndex fieldIndex)
		{
			IEntityField fieldToReturn = null;
			IFieldInfoProvider fieldProvider = FieldInfoProviderSingleton.GetInstance();
			IPersistenceInfoProvider persistenceProvider = PersistenceInfoProviderSingleton.GetInstance();
			switch(fieldIndex)
			{
				case CiudadesFieldIndex.Nomciudad:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("CiudadesEntity", "Nomciudad"), persistenceProvider.GetFieldPersistenceInfo("CiudadesEntity", "Nomciudad"));
					break;
				case CiudadesFieldIndex.Idciudad:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("CiudadesEntity", "Idciudad"), persistenceProvider.GetFieldPersistenceInfo("CiudadesEntity", "Idciudad"));
					break;
					
			}
			return fieldToReturn;
		}
	
		/// <summary>
		/// Creates a new IEntityField instance for usage in the EntityFields object for the EditorialEntity. 
		/// Which EntityField is created is specified by fieldIndex
		/// </summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in fieldIndex</returns>
		public static IEntityField Create(EditorialFieldIndex fieldIndex)
		{
			IEntityField fieldToReturn = null;
			IFieldInfoProvider fieldProvider = FieldInfoProviderSingleton.GetInstance();
			IPersistenceInfoProvider persistenceProvider = PersistenceInfoProviderSingleton.GetInstance();
			switch(fieldIndex)
			{
				case EditorialFieldIndex.Id:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("EditorialEntity", "Id"), persistenceProvider.GetFieldPersistenceInfo("EditorialEntity", "Id"));
					break;
				case EditorialFieldIndex.Nombre:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("EditorialEntity", "Nombre"), persistenceProvider.GetFieldPersistenceInfo("EditorialEntity", "Nombre"));
					break;
					
			}
			return fieldToReturn;
		}
	
		/// <summary>
		/// Creates a new IEntityField instance for usage in the EntityFields object for the EquipoDeTrabajoEntity. 
		/// Which EntityField is created is specified by fieldIndex
		/// </summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in fieldIndex</returns>
		public static IEntityField Create(EquipoDeTrabajoFieldIndex fieldIndex)
		{
			IEntityField fieldToReturn = null;
			IFieldInfoProvider fieldProvider = FieldInfoProviderSingleton.GetInstance();
			IPersistenceInfoProvider persistenceProvider = PersistenceInfoProviderSingleton.GetInstance();
			switch(fieldIndex)
			{
				case EquipoDeTrabajoFieldIndex.Id:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("EquipoDeTrabajoEntity", "Id"), persistenceProvider.GetFieldPersistenceInfo("EquipoDeTrabajoEntity", "Id"));
					break;
				case EquipoDeTrabajoFieldIndex.IdEvento:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("EquipoDeTrabajoEntity", "IdEvento"), persistenceProvider.GetFieldPersistenceInfo("EquipoDeTrabajoEntity", "IdEvento"));
					break;
				case EquipoDeTrabajoFieldIndex.Nombre:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("EquipoDeTrabajoEntity", "Nombre"), persistenceProvider.GetFieldPersistenceInfo("EquipoDeTrabajoEntity", "Nombre"));
					break;
				case EquipoDeTrabajoFieldIndex.Encargado:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("EquipoDeTrabajoEntity", "Encargado"), persistenceProvider.GetFieldPersistenceInfo("EquipoDeTrabajoEntity", "Encargado"));
					break;
					
			}
			return fieldToReturn;
		}
	
		/// <summary>
		/// Creates a new IEntityField instance for usage in the EntityFields object for the EventoEntity. 
		/// Which EntityField is created is specified by fieldIndex
		/// </summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in fieldIndex</returns>
		public static IEntityField Create(EventoFieldIndex fieldIndex)
		{
			IEntityField fieldToReturn = null;
			IFieldInfoProvider fieldProvider = FieldInfoProviderSingleton.GetInstance();
			IPersistenceInfoProvider persistenceProvider = PersistenceInfoProviderSingleton.GetInstance();
			switch(fieldIndex)
			{
				case EventoFieldIndex.Id:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("EventoEntity", "Id"), persistenceProvider.GetFieldPersistenceInfo("EventoEntity", "Id"));
					break;
				case EventoFieldIndex.Ano:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("EventoEntity", "Ano"), persistenceProvider.GetFieldPersistenceInfo("EventoEntity", "Ano"));
					break;
				case EventoFieldIndex.FechaInicio:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("EventoEntity", "FechaInicio"), persistenceProvider.GetFieldPersistenceInfo("EventoEntity", "FechaInicio"));
					break;
				case EventoFieldIndex.FechaFin:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("EventoEntity", "FechaFin"), persistenceProvider.GetFieldPersistenceInfo("EventoEntity", "FechaFin"));
					break;
				case EventoFieldIndex.Nombre:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("EventoEntity", "Nombre"), persistenceProvider.GetFieldPersistenceInfo("EventoEntity", "Nombre"));
					break;
				case EventoFieldIndex.Seccion:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("EventoEntity", "Seccion"), persistenceProvider.GetFieldPersistenceInfo("EventoEntity", "Seccion"));
					break;
				case EventoFieldIndex.Estatus:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("EventoEntity", "Estatus"), persistenceProvider.GetFieldPersistenceInfo("EventoEntity", "Estatus"));
					break;
				case EventoFieldIndex.LugarEvento:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("EventoEntity", "LugarEvento"), persistenceProvider.GetFieldPersistenceInfo("EventoEntity", "LugarEvento"));
					break;
					
			}
			return fieldToReturn;
		}
	
		/// <summary>
		/// Creates a new IEntityField instance for usage in the EntityFields object for the LibroEntity. 
		/// Which EntityField is created is specified by fieldIndex
		/// </summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in fieldIndex</returns>
		public static IEntityField Create(LibroFieldIndex fieldIndex)
		{
			IEntityField fieldToReturn = null;
			IFieldInfoProvider fieldProvider = FieldInfoProviderSingleton.GetInstance();
			IPersistenceInfoProvider persistenceProvider = PersistenceInfoProviderSingleton.GetInstance();
			switch(fieldIndex)
			{
				case LibroFieldIndex.Id:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("LibroEntity", "Id"), persistenceProvider.GetFieldPersistenceInfo("LibroEntity", "Id"));
					break;
				case LibroFieldIndex.Titulo:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("LibroEntity", "Titulo"), persistenceProvider.GetFieldPersistenceInfo("LibroEntity", "Titulo"));
					break;
				case LibroFieldIndex.IdAutor:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("LibroEntity", "IdAutor"), persistenceProvider.GetFieldPersistenceInfo("LibroEntity", "IdAutor"));
					break;
				case LibroFieldIndex.Edicion:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("LibroEntity", "Edicion"), persistenceProvider.GetFieldPersistenceInfo("LibroEntity", "Edicion"));
					break;
				case LibroFieldIndex.IdEditorial:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("LibroEntity", "IdEditorial"), persistenceProvider.GetFieldPersistenceInfo("LibroEntity", "IdEditorial"));
					break;
				case LibroFieldIndex.IdSeccion:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("LibroEntity", "IdSeccion"), persistenceProvider.GetFieldPersistenceInfo("LibroEntity", "IdSeccion"));
					break;
				case LibroFieldIndex.IdRama:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("LibroEntity", "IdRama"), persistenceProvider.GetFieldPersistenceInfo("LibroEntity", "IdRama"));
					break;
				case LibroFieldIndex.IdTematica:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("LibroEntity", "IdTematica"), persistenceProvider.GetFieldPersistenceInfo("LibroEntity", "IdTematica"));
					break;
				case LibroFieldIndex.IdPais:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("LibroEntity", "IdPais"), persistenceProvider.GetFieldPersistenceInfo("LibroEntity", "IdPais"));
					break;
				case LibroFieldIndex.Año:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("LibroEntity", "Año"), persistenceProvider.GetFieldPersistenceInfo("LibroEntity", "Año"));
					break;
				case LibroFieldIndex.NumEjemplares:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("LibroEntity", "NumEjemplares"), persistenceProvider.GetFieldPersistenceInfo("LibroEntity", "NumEjemplares"));
					break;
				case LibroFieldIndex.ExclusivoConsulta:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("LibroEntity", "ExclusivoConsulta"), persistenceProvider.GetFieldPersistenceInfo("LibroEntity", "ExclusivoConsulta"));
					break;
				case LibroFieldIndex.Pasillo:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("LibroEntity", "Pasillo"), persistenceProvider.GetFieldPersistenceInfo("LibroEntity", "Pasillo"));
					break;
				case LibroFieldIndex.Estante:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("LibroEntity", "Estante"), persistenceProvider.GetFieldPersistenceInfo("LibroEntity", "Estante"));
					break;
				case LibroFieldIndex.Nivel:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("LibroEntity", "Nivel"), persistenceProvider.GetFieldPersistenceInfo("LibroEntity", "Nivel"));
					break;
				case LibroFieldIndex.Isbn:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("LibroEntity", "Isbn"), persistenceProvider.GetFieldPersistenceInfo("LibroEntity", "Isbn"));
					break;
				case LibroFieldIndex.Ddc:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("LibroEntity", "Ddc"), persistenceProvider.GetFieldPersistenceInfo("LibroEntity", "Ddc"));
					break;
				case LibroFieldIndex.Cdu:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("LibroEntity", "Cdu"), persistenceProvider.GetFieldPersistenceInfo("LibroEntity", "Cdu"));
					break;
				case LibroFieldIndex.Ilustrado:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("LibroEntity", "Ilustrado"), persistenceProvider.GetFieldPersistenceInfo("LibroEntity", "Ilustrado"));
					break;
				case LibroFieldIndex.Busqueda:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("LibroEntity", "Busqueda"), persistenceProvider.GetFieldPersistenceInfo("LibroEntity", "Busqueda"));
					break;
					
			}
			return fieldToReturn;
		}
	
		/// <summary>
		/// Creates a new IEntityField instance for usage in the EntityFields object for the PaisEntity. 
		/// Which EntityField is created is specified by fieldIndex
		/// </summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in fieldIndex</returns>
		public static IEntityField Create(PaisFieldIndex fieldIndex)
		{
			IEntityField fieldToReturn = null;
			IFieldInfoProvider fieldProvider = FieldInfoProviderSingleton.GetInstance();
			IPersistenceInfoProvider persistenceProvider = PersistenceInfoProviderSingleton.GetInstance();
			switch(fieldIndex)
			{
				case PaisFieldIndex.Id:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("PaisEntity", "Id"), persistenceProvider.GetFieldPersistenceInfo("PaisEntity", "Id"));
					break;
				case PaisFieldIndex.Nombre:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("PaisEntity", "Nombre"), persistenceProvider.GetFieldPersistenceInfo("PaisEntity", "Nombre"));
					break;
					
			}
			return fieldToReturn;
		}
	
		/// <summary>
		/// Creates a new IEntityField instance for usage in the EntityFields object for the ParrocoEntity. 
		/// Which EntityField is created is specified by fieldIndex
		/// </summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in fieldIndex</returns>
		public static IEntityField Create(ParrocoFieldIndex fieldIndex)
		{
			IEntityField fieldToReturn = null;
			IFieldInfoProvider fieldProvider = FieldInfoProviderSingleton.GetInstance();
			IPersistenceInfoProvider persistenceProvider = PersistenceInfoProviderSingleton.GetInstance();
			switch(fieldIndex)
			{
				case ParrocoFieldIndex.Id:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("ParrocoEntity", "Id"), persistenceProvider.GetFieldPersistenceInfo("ParrocoEntity", "Id"));
					break;
				case ParrocoFieldIndex.Titulo:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("ParrocoEntity", "Titulo"), persistenceProvider.GetFieldPersistenceInfo("ParrocoEntity", "Titulo"));
					break;
				case ParrocoFieldIndex.Nombre:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("ParrocoEntity", "Nombre"), persistenceProvider.GetFieldPersistenceInfo("ParrocoEntity", "Nombre"));
					break;
				case ParrocoFieldIndex.Apellidos:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("ParrocoEntity", "Apellidos"), persistenceProvider.GetFieldPersistenceInfo("ParrocoEntity", "Apellidos"));
					break;
				case ParrocoFieldIndex.Cargo:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("ParrocoEntity", "Cargo"), persistenceProvider.GetFieldPersistenceInfo("ParrocoEntity", "Cargo"));
					break;
				case ParrocoFieldIndex.EMail:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("ParrocoEntity", "EMail"), persistenceProvider.GetFieldPersistenceInfo("ParrocoEntity", "EMail"));
					break;
				case ParrocoFieldIndex.IdParroquia:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("ParrocoEntity", "IdParroquia"), persistenceProvider.GetFieldPersistenceInfo("ParrocoEntity", "IdParroquia"));
					break;
				case ParrocoFieldIndex.NombreParroquia:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("ParrocoEntity", "NombreParroquia"), persistenceProvider.GetFieldPersistenceInfo("ParrocoEntity", "NombreParroquia"));
					break;
				case ParrocoFieldIndex.Telefono1:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("ParrocoEntity", "Telefono1"), persistenceProvider.GetFieldPersistenceInfo("ParrocoEntity", "Telefono1"));
					break;
				case ParrocoFieldIndex.Telefono2:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("ParrocoEntity", "Telefono2"), persistenceProvider.GetFieldPersistenceInfo("ParrocoEntity", "Telefono2"));
					break;
				case ParrocoFieldIndex.TelCural:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("ParrocoEntity", "TelCural"), persistenceProvider.GetFieldPersistenceInfo("ParrocoEntity", "TelCural"));
					break;
				case ParrocoFieldIndex.Fecnac:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("ParrocoEntity", "Fecnac"), persistenceProvider.GetFieldPersistenceInfo("ParrocoEntity", "Fecnac"));
					break;
				case ParrocoFieldIndex.FecOrdenacion:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("ParrocoEntity", "FecOrdenacion"), persistenceProvider.GetFieldPersistenceInfo("ParrocoEntity", "FecOrdenacion"));
					break;
				case ParrocoFieldIndex.FechaNac:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("ParrocoEntity", "FechaNac"), persistenceProvider.GetFieldPersistenceInfo("ParrocoEntity", "FechaNac"));
					break;
				case ParrocoFieldIndex.FechaOrdenac:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("ParrocoEntity", "FechaOrdenac"), persistenceProvider.GetFieldPersistenceInfo("ParrocoEntity", "FechaOrdenac"));
					break;
					
			}
			return fieldToReturn;
		}
	
		/// <summary>
		/// Creates a new IEntityField instance for usage in the EntityFields object for the ParroquiaEntity. 
		/// Which EntityField is created is specified by fieldIndex
		/// </summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in fieldIndex</returns>
		public static IEntityField Create(ParroquiaFieldIndex fieldIndex)
		{
			IEntityField fieldToReturn = null;
			IFieldInfoProvider fieldProvider = FieldInfoProviderSingleton.GetInstance();
			IPersistenceInfoProvider persistenceProvider = PersistenceInfoProviderSingleton.GetInstance();
			switch(fieldIndex)
			{
				case ParroquiaFieldIndex.Id:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("ParroquiaEntity", "Id"), persistenceProvider.GetFieldPersistenceInfo("ParroquiaEntity", "Id"));
					break;
				case ParroquiaFieldIndex.IdTipoParroquia:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("ParroquiaEntity", "IdTipoParroquia"), persistenceProvider.GetFieldPersistenceInfo("ParroquiaEntity", "IdTipoParroquia"));
					break;
				case ParroquiaFieldIndex.Nombre:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("ParroquiaEntity", "Nombre"), persistenceProvider.GetFieldPersistenceInfo("ParroquiaEntity", "Nombre"));
					break;
				case ParroquiaFieldIndex.IdZonaPastoral:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("ParroquiaEntity", "IdZonaPastoral"), persistenceProvider.GetFieldPersistenceInfo("ParroquiaEntity", "IdZonaPastoral"));
					break;
				case ParroquiaFieldIndex.IdCiudad:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("ParroquiaEntity", "IdCiudad"), persistenceProvider.GetFieldPersistenceInfo("ParroquiaEntity", "IdCiudad"));
					break;
				case ParroquiaFieldIndex.Tel1:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("ParroquiaEntity", "Tel1"), persistenceProvider.GetFieldPersistenceInfo("ParroquiaEntity", "Tel1"));
					break;
				case ParroquiaFieldIndex.Tel2:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("ParroquiaEntity", "Tel2"), persistenceProvider.GetFieldPersistenceInfo("ParroquiaEntity", "Tel2"));
					break;
				case ParroquiaFieldIndex.Telcural:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("ParroquiaEntity", "Telcural"), persistenceProvider.GetFieldPersistenceInfo("ParroquiaEntity", "Telcural"));
					break;
				case ParroquiaFieldIndex.Fax:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("ParroquiaEntity", "Fax"), persistenceProvider.GetFieldPersistenceInfo("ParroquiaEntity", "Fax"));
					break;
				case ParroquiaFieldIndex.EmailComunidad:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("ParroquiaEntity", "EmailComunidad"), persistenceProvider.GetFieldPersistenceInfo("ParroquiaEntity", "EmailComunidad"));
					break;
				case ParroquiaFieldIndex.Calle:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("ParroquiaEntity", "Calle"), persistenceProvider.GetFieldPersistenceInfo("ParroquiaEntity", "Calle"));
					break;
				case ParroquiaFieldIndex.NoExt:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("ParroquiaEntity", "NoExt"), persistenceProvider.GetFieldPersistenceInfo("ParroquiaEntity", "NoExt"));
					break;
				case ParroquiaFieldIndex.Colonia:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("ParroquiaEntity", "Colonia"), persistenceProvider.GetFieldPersistenceInfo("ParroquiaEntity", "Colonia"));
					break;
				case ParroquiaFieldIndex.Cp:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("ParroquiaEntity", "Cp"), persistenceProvider.GetFieldPersistenceInfo("ParroquiaEntity", "Cp"));
					break;
				case ParroquiaFieldIndex.ApartadoPostal:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("ParroquiaEntity", "ApartadoPostal"), persistenceProvider.GetFieldPersistenceInfo("ParroquiaEntity", "ApartadoPostal"));
					break;
					
			}
			return fieldToReturn;
		}
	
		/// <summary>
		/// Creates a new IEntityField instance for usage in the EntityFields object for the ParticipanteEntity. 
		/// Which EntityField is created is specified by fieldIndex
		/// </summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in fieldIndex</returns>
		public static IEntityField Create(ParticipanteFieldIndex fieldIndex)
		{
			IEntityField fieldToReturn = null;
			IFieldInfoProvider fieldProvider = FieldInfoProviderSingleton.GetInstance();
			IPersistenceInfoProvider persistenceProvider = PersistenceInfoProviderSingleton.GetInstance();
			switch(fieldIndex)
			{
				case ParticipanteFieldIndex.Id:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("ParticipanteEntity", "Id"), persistenceProvider.GetFieldPersistenceInfo("ParticipanteEntity", "Id"));
					break;
				case ParticipanteFieldIndex.ApellidoPaterno:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("ParticipanteEntity", "ApellidoPaterno"), persistenceProvider.GetFieldPersistenceInfo("ParticipanteEntity", "ApellidoPaterno"));
					break;
				case ParticipanteFieldIndex.ApellidoMaterno:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("ParticipanteEntity", "ApellidoMaterno"), persistenceProvider.GetFieldPersistenceInfo("ParticipanteEntity", "ApellidoMaterno"));
					break;
				case ParticipanteFieldIndex.Nombre:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("ParticipanteEntity", "Nombre"), persistenceProvider.GetFieldPersistenceInfo("ParticipanteEntity", "Nombre"));
					break;
				case ParticipanteFieldIndex.FechaNacim:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("ParticipanteEntity", "FechaNacim"), persistenceProvider.GetFieldPersistenceInfo("ParticipanteEntity", "FechaNacim"));
					break;
				case ParticipanteFieldIndex.Aceptado:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("ParticipanteEntity", "Aceptado"), persistenceProvider.GetFieldPersistenceInfo("ParticipanteEntity", "Aceptado"));
					break;
				case ParticipanteFieldIndex.NombrePadre:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("ParticipanteEntity", "NombrePadre"), persistenceProvider.GetFieldPersistenceInfo("ParticipanteEntity", "NombrePadre"));
					break;
				case ParticipanteFieldIndex.NombreMadre:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("ParticipanteEntity", "NombreMadre"), persistenceProvider.GetFieldPersistenceInfo("ParticipanteEntity", "NombreMadre"));
					break;
				case ParticipanteFieldIndex.VivePadre:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("ParticipanteEntity", "VivePadre"), persistenceProvider.GetFieldPersistenceInfo("ParticipanteEntity", "VivePadre"));
					break;
				case ParticipanteFieldIndex.ViveMadre:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("ParticipanteEntity", "ViveMadre"), persistenceProvider.GetFieldPersistenceInfo("ParticipanteEntity", "ViveMadre"));
					break;
				case ParticipanteFieldIndex.EdoCivilPadres:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("ParticipanteEntity", "EdoCivilPadres"), persistenceProvider.GetFieldPersistenceInfo("ParticipanteEntity", "EdoCivilPadres"));
					break;
				case ParticipanteFieldIndex.Hermanos:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("ParticipanteEntity", "Hermanos"), persistenceProvider.GetFieldPersistenceInfo("ParticipanteEntity", "Hermanos"));
					break;
				case ParticipanteFieldIndex.Hermanas:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("ParticipanteEntity", "Hermanas"), persistenceProvider.GetFieldPersistenceInfo("ParticipanteEntity", "Hermanas"));
					break;
				case ParticipanteFieldIndex.OrdenNacimiento:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("ParticipanteEntity", "OrdenNacimiento"), persistenceProvider.GetFieldPersistenceInfo("ParticipanteEntity", "OrdenNacimiento"));
					break;
				case ParticipanteFieldIndex.Confirmacion:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("ParticipanteEntity", "Confirmacion"), persistenceProvider.GetFieldPersistenceInfo("ParticipanteEntity", "Confirmacion"));
					break;
				case ParticipanteFieldIndex.PrimeraComunion:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("ParticipanteEntity", "PrimeraComunion"), persistenceProvider.GetFieldPersistenceInfo("ParticipanteEntity", "PrimeraComunion"));
					break;
				case ParticipanteFieldIndex.Deportes:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("ParticipanteEntity", "Deportes"), persistenceProvider.GetFieldPersistenceInfo("ParticipanteEntity", "Deportes"));
					break;
				case ParticipanteFieldIndex.Instrumentos:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("ParticipanteEntity", "Instrumentos"), persistenceProvider.GetFieldPersistenceInfo("ParticipanteEntity", "Instrumentos"));
					break;
					
			}
			return fieldToReturn;
		}
	
		/// <summary>
		/// Creates a new IEntityField instance for usage in the EntityFields object for the RamaEntity. 
		/// Which EntityField is created is specified by fieldIndex
		/// </summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in fieldIndex</returns>
		public static IEntityField Create(RamaFieldIndex fieldIndex)
		{
			IEntityField fieldToReturn = null;
			IFieldInfoProvider fieldProvider = FieldInfoProviderSingleton.GetInstance();
			IPersistenceInfoProvider persistenceProvider = PersistenceInfoProviderSingleton.GetInstance();
			switch(fieldIndex)
			{
				case RamaFieldIndex.IdSeccion:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("RamaEntity", "IdSeccion"), persistenceProvider.GetFieldPersistenceInfo("RamaEntity", "IdSeccion"));
					break;
				case RamaFieldIndex.Id:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("RamaEntity", "Id"), persistenceProvider.GetFieldPersistenceInfo("RamaEntity", "Id"));
					break;
				case RamaFieldIndex.Nombre:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("RamaEntity", "Nombre"), persistenceProvider.GetFieldPersistenceInfo("RamaEntity", "Nombre"));
					break;
					
			}
			return fieldToReturn;
		}
	
		/// <summary>
		/// Creates a new IEntityField instance for usage in the EntityFields object for the SeccionEntity. 
		/// Which EntityField is created is specified by fieldIndex
		/// </summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in fieldIndex</returns>
		public static IEntityField Create(SeccionFieldIndex fieldIndex)
		{
			IEntityField fieldToReturn = null;
			IFieldInfoProvider fieldProvider = FieldInfoProviderSingleton.GetInstance();
			IPersistenceInfoProvider persistenceProvider = PersistenceInfoProviderSingleton.GetInstance();
			switch(fieldIndex)
			{
				case SeccionFieldIndex.Id:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("SeccionEntity", "Id"), persistenceProvider.GetFieldPersistenceInfo("SeccionEntity", "Id"));
					break;
				case SeccionFieldIndex.Nombre:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("SeccionEntity", "Nombre"), persistenceProvider.GetFieldPersistenceInfo("SeccionEntity", "Nombre"));
					break;
					
			}
			return fieldToReturn;
		}
	
		/// <summary>
		/// Creates a new IEntityField instance for usage in the EntityFields object for the TematicaEntity. 
		/// Which EntityField is created is specified by fieldIndex
		/// </summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in fieldIndex</returns>
		public static IEntityField Create(TematicaFieldIndex fieldIndex)
		{
			IEntityField fieldToReturn = null;
			IFieldInfoProvider fieldProvider = FieldInfoProviderSingleton.GetInstance();
			IPersistenceInfoProvider persistenceProvider = PersistenceInfoProviderSingleton.GetInstance();
			switch(fieldIndex)
			{
				case TematicaFieldIndex.IdSeccion:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("TematicaEntity", "IdSeccion"), persistenceProvider.GetFieldPersistenceInfo("TematicaEntity", "IdSeccion"));
					break;
				case TematicaFieldIndex.IdRama:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("TematicaEntity", "IdRama"), persistenceProvider.GetFieldPersistenceInfo("TematicaEntity", "IdRama"));
					break;
				case TematicaFieldIndex.Id:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("TematicaEntity", "Id"), persistenceProvider.GetFieldPersistenceInfo("TematicaEntity", "Id"));
					break;
				case TematicaFieldIndex.Nombre:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("TematicaEntity", "Nombre"), persistenceProvider.GetFieldPersistenceInfo("TematicaEntity", "Nombre"));
					break;
					
			}
			return fieldToReturn;
		}
	
		/// <summary>
		/// Creates a new IEntityField instance for usage in the EntityFields object for the TipoParroquiaEntity. 
		/// Which EntityField is created is specified by fieldIndex
		/// </summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in fieldIndex</returns>
		public static IEntityField Create(TipoParroquiaFieldIndex fieldIndex)
		{
			IEntityField fieldToReturn = null;
			IFieldInfoProvider fieldProvider = FieldInfoProviderSingleton.GetInstance();
			IPersistenceInfoProvider persistenceProvider = PersistenceInfoProviderSingleton.GetInstance();
			switch(fieldIndex)
			{
				case TipoParroquiaFieldIndex.Id:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("TipoParroquiaEntity", "Id"), persistenceProvider.GetFieldPersistenceInfo("TipoParroquiaEntity", "Id"));
					break;
				case TipoParroquiaFieldIndex.Descripcion:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("TipoParroquiaEntity", "Descripcion"), persistenceProvider.GetFieldPersistenceInfo("TipoParroquiaEntity", "Descripcion"));
					break;
					
			}
			return fieldToReturn;
		}
	
		/// <summary>
		/// Creates a new IEntityField instance for usage in the EntityFields object for the VwListasEntity. 
		/// Which EntityField is created is specified by fieldIndex
		/// </summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in fieldIndex</returns>
		public static IEntityField Create(VwListasFieldIndex fieldIndex)
		{
			IEntityField fieldToReturn = null;
			IFieldInfoProvider fieldProvider = FieldInfoProviderSingleton.GetInstance();
			IPersistenceInfoProvider persistenceProvider = PersistenceInfoProviderSingleton.GetInstance();
			switch(fieldIndex)
			{
				case VwListasFieldIndex.Nombreequipo:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("VwListasEntity", "Nombreequipo"), persistenceProvider.GetFieldPersistenceInfo("VwListasEntity", "Nombreequipo"));
					break;
				case VwListasFieldIndex.Nombreevento:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("VwListasEntity", "Nombreevento"), persistenceProvider.GetFieldPersistenceInfo("VwListasEntity", "Nombreevento"));
					break;
				case VwListasFieldIndex.ApellidoPaterno:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("VwListasEntity", "ApellidoPaterno"), persistenceProvider.GetFieldPersistenceInfo("VwListasEntity", "ApellidoPaterno"));
					break;
				case VwListasFieldIndex.ApellidoMaterno:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("VwListasEntity", "ApellidoMaterno"), persistenceProvider.GetFieldPersistenceInfo("VwListasEntity", "ApellidoMaterno"));
					break;
				case VwListasFieldIndex.Nombre:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("VwListasEntity", "Nombre"), persistenceProvider.GetFieldPersistenceInfo("VwListasEntity", "Nombre"));
					break;
				case VwListasFieldIndex.Seccion:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("VwListasEntity", "Seccion"), persistenceProvider.GetFieldPersistenceInfo("VwListasEntity", "Seccion"));
					break;
					
			}
			return fieldToReturn;
		}
	
		/// <summary>
		/// Creates a new IEntityField instance for usage in the EntityFields object for the VwparroquiasEntity. 
		/// Which EntityField is created is specified by fieldIndex
		/// </summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in fieldIndex</returns>
		public static IEntityField Create(VwparroquiasFieldIndex fieldIndex)
		{
			IEntityField fieldToReturn = null;
			IFieldInfoProvider fieldProvider = FieldInfoProviderSingleton.GetInstance();
			IPersistenceInfoProvider persistenceProvider = PersistenceInfoProviderSingleton.GetInstance();
			switch(fieldIndex)
			{
				case VwparroquiasFieldIndex.Parroquia:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("VwparroquiasEntity", "Parroquia"), persistenceProvider.GetFieldPersistenceInfo("VwparroquiasEntity", "Parroquia"));
					break;
				case VwparroquiasFieldIndex.Telefono:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("VwparroquiasEntity", "Telefono"), persistenceProvider.GetFieldPersistenceInfo("VwparroquiasEntity", "Telefono"));
					break;
				case VwparroquiasFieldIndex.OtroTelefono:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("VwparroquiasEntity", "OtroTelefono"), persistenceProvider.GetFieldPersistenceInfo("VwparroquiasEntity", "OtroTelefono"));
					break;
				case VwparroquiasFieldIndex.TelefonoCural:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("VwparroquiasEntity", "TelefonoCural"), persistenceProvider.GetFieldPersistenceInfo("VwparroquiasEntity", "TelefonoCural"));
					break;
				case VwparroquiasFieldIndex.Fax:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("VwparroquiasEntity", "Fax"), persistenceProvider.GetFieldPersistenceInfo("VwparroquiasEntity", "Fax"));
					break;
				case VwparroquiasFieldIndex.CorreoElectrónico:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("VwparroquiasEntity", "CorreoElectrónico"), persistenceProvider.GetFieldPersistenceInfo("VwparroquiasEntity", "CorreoElectrónico"));
					break;
				case VwparroquiasFieldIndex.Calle:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("VwparroquiasEntity", "Calle"), persistenceProvider.GetFieldPersistenceInfo("VwparroquiasEntity", "Calle"));
					break;
				case VwparroquiasFieldIndex.Numero:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("VwparroquiasEntity", "Numero"), persistenceProvider.GetFieldPersistenceInfo("VwparroquiasEntity", "Numero"));
					break;
				case VwparroquiasFieldIndex.Colonia:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("VwparroquiasEntity", "Colonia"), persistenceProvider.GetFieldPersistenceInfo("VwparroquiasEntity", "Colonia"));
					break;
				case VwparroquiasFieldIndex.CodigoPostal:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("VwparroquiasEntity", "CodigoPostal"), persistenceProvider.GetFieldPersistenceInfo("VwparroquiasEntity", "CodigoPostal"));
					break;
				case VwparroquiasFieldIndex.ApartadoPostal:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("VwparroquiasEntity", "ApartadoPostal"), persistenceProvider.GetFieldPersistenceInfo("VwparroquiasEntity", "ApartadoPostal"));
					break;
				case VwparroquiasFieldIndex.Ciudad:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("VwparroquiasEntity", "Ciudad"), persistenceProvider.GetFieldPersistenceInfo("VwparroquiasEntity", "Ciudad"));
					break;
				case VwparroquiasFieldIndex.Zona:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("VwparroquiasEntity", "Zona"), persistenceProvider.GetFieldPersistenceInfo("VwparroquiasEntity", "Zona"));
					break;
				case VwparroquiasFieldIndex.Tipo:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("VwparroquiasEntity", "Tipo"), persistenceProvider.GetFieldPersistenceInfo("VwparroquiasEntity", "Tipo"));
					break;
					
			}
			return fieldToReturn;
		}
	
		/// <summary>
		/// Creates a new IEntityField instance for usage in the EntityFields object for the ZonaPastoralEntity. 
		/// Which EntityField is created is specified by fieldIndex
		/// </summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in fieldIndex</returns>
		public static IEntityField Create(ZonaPastoralFieldIndex fieldIndex)
		{
			IEntityField fieldToReturn = null;
			IFieldInfoProvider fieldProvider = FieldInfoProviderSingleton.GetInstance();
			IPersistenceInfoProvider persistenceProvider = PersistenceInfoProviderSingleton.GetInstance();
			switch(fieldIndex)
			{
				case ZonaPastoralFieldIndex.Id:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("ZonaPastoralEntity", "Id"), persistenceProvider.GetFieldPersistenceInfo("ZonaPastoralEntity", "Id"));
					break;
				case ZonaPastoralFieldIndex.Nombre:
					fieldToReturn = new EntityField(fieldProvider.GetFieldInfo("ZonaPastoralEntity", "Nombre"), persistenceProvider.GetFieldPersistenceInfo("ZonaPastoralEntity", "Nombre"));
					break;
					
			}
			return fieldToReturn;
		}
	
	

		/// <summary>
		/// Creates a new IEntityField instance, which represents the field objectName.fieldName
		/// </summary>
		/// <param name="objectName">the name of the object the field belongs to, like CustomerEntity or OrdersTypedView</param>
		/// <param name="fieldName">the name of the field to create</param>
		public static IEntityField Create(string objectName, string fieldName)
        {
            IFieldInfoProvider fieldProvider = FieldInfoProviderSingleton.GetInstance();
			IPersistenceInfoProvider persistenceProvider = PersistenceInfoProviderSingleton.GetInstance();
			return new EntityField(fieldProvider.GetFieldInfo(objectName, fieldName), persistenceProvider.GetFieldPersistenceInfo(objectName, fieldName));
        }

		#region Included Code

		#endregion
	}
}
