///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 2.0.0.0
// Code is generated on: jueves, 01 de diciembre de 2016 05:21:22 p.m.
// Code is generated using templates: SD.TemplateBindings.SharedTemplates.NET20
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using ORMDiocesis.EntityClasses;
using ORMDiocesis.HelperClasses;

using ORMDiocesis.CollectionClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace ORMDiocesis.FactoryClasses
{
	
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	

	
	/// <summary>Factory to create new, empty AsistenciaEntity objects.</summary>
#if CF
	[SD.LLBLGen.Pro.ORMSupportClasses.Serializable]
#else
	[Serializable]
#endif
	public partial class AsistenciaEntityFactory : IEntityFactory
	{
		/// <summary>Creates a new, empty AsistenciaEntity object.</summary>
		/// <returns>A new, empty AsistenciaEntity object.</returns>
		public virtual IEntity Create()
		{
			IEntity toReturn = new AsistenciaEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewAsistencia
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;

		}
		
		/// <summary>Creates a new AsistenciaEntity instance but uses a special constructor which will set the Fields object of the new IEntity instance to the passed in fields object. Implement this method to support multi-type in single table inheritance.</summary>
		/// <param name="fields">Populated IEntityFields object for the new IEntity to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields object) IEntity object</returns>
		public virtual IEntity Create(IEntityFields fields)
		{
			IEntity toReturn = Create();
			toReturn.Fields = fields;
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewAsistenciaUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}

		/// <summary>Creates, using the generated EntityFieldsFactory, the IEntityFields object for the entity to create. This method is used by internal code to create the fields object to store fetched data. 
		/// </summary>
		/// <returns>Empty IEntityFields object.</returns>
		public virtual IEntityFields CreateFields()
		{
			return EntityFieldsFactory.CreateEntityFieldsObject(ORMDiocesis.EntityType.AsistenciaEntity);
		}
		
		/// <summary>Creates the hierarchy fields for the entity to which this factory belongs.</summary>
		/// <returns>IEntityFields object with the fields of all the entities in teh hierarchy of this entity or the fields of this entity if the entity isn't in a hierarchy.</returns>
		public virtual IEntityFields CreateHierarchyFields()
		{
			return this.CreateFields();
		}
		
		/// <summary>Creates the relations collection to the entity to join all targets so this entity can be fetched. </summary>
		/// <returns>null if the entity isn't in a hierarchy of type TargetPerEntity, otherwise the relations collection needed to join all targets together to fetch all subtypes of this entity and this entity itself</returns>
		public virtual IRelationCollection CreateHierarchyRelations()
		{
			return null;			
		}

		/// <summary>This method retrieves, using the InheritanceInfoprovider, the factory for the entity represented by the values passed in.</summary>
		/// <param name="fieldValues">Field values read from the db, to determine which factory to return, based on the field values passed in.</param>
		/// <param name="entityFieldStartIndexesPerEntity">indexes into values where per entity type their own fields start.</param>
		/// <returns>the factory for the entity which is represented by the values passed in.</returns>
		public virtual IEntityFactory GetEntityFactory(object[] fieldValues, Dictionary<string, int> entityFieldStartIndexesPerEntity)
		{
			return this;
		}
		
		/// <summary>Creates a new entity collection for the entity of this factory.</summary>
		/// <returns>ready to use new entity collection, typed.</returns>
		public virtual IEntityCollection CreateEntityCollection()
		{
			return new AsistenciaCollection();
		}
		
		/// <summary>returns the name of the entity this factory is for, e.g. "EmployeeEntity"</summary>
		public virtual string ForEntityName 
		{ 
			get { return "AsistenciaEntity"; }
		}

		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty AutorEntity objects.</summary>
#if CF
	[SD.LLBLGen.Pro.ORMSupportClasses.Serializable]
#else
	[Serializable]
#endif
	public partial class AutorEntityFactory : IEntityFactory
	{
		/// <summary>Creates a new, empty AutorEntity object.</summary>
		/// <returns>A new, empty AutorEntity object.</returns>
		public virtual IEntity Create()
		{
			IEntity toReturn = new AutorEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewAutor
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;

		}
		
		/// <summary>Creates a new AutorEntity instance but uses a special constructor which will set the Fields object of the new IEntity instance to the passed in fields object. Implement this method to support multi-type in single table inheritance.</summary>
		/// <param name="fields">Populated IEntityFields object for the new IEntity to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields object) IEntity object</returns>
		public virtual IEntity Create(IEntityFields fields)
		{
			IEntity toReturn = Create();
			toReturn.Fields = fields;
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewAutorUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}

		/// <summary>Creates, using the generated EntityFieldsFactory, the IEntityFields object for the entity to create. This method is used by internal code to create the fields object to store fetched data. 
		/// </summary>
		/// <returns>Empty IEntityFields object.</returns>
		public virtual IEntityFields CreateFields()
		{
			return EntityFieldsFactory.CreateEntityFieldsObject(ORMDiocesis.EntityType.AutorEntity);
		}
		
		/// <summary>Creates the hierarchy fields for the entity to which this factory belongs.</summary>
		/// <returns>IEntityFields object with the fields of all the entities in teh hierarchy of this entity or the fields of this entity if the entity isn't in a hierarchy.</returns>
		public virtual IEntityFields CreateHierarchyFields()
		{
			return this.CreateFields();
		}
		
		/// <summary>Creates the relations collection to the entity to join all targets so this entity can be fetched. </summary>
		/// <returns>null if the entity isn't in a hierarchy of type TargetPerEntity, otherwise the relations collection needed to join all targets together to fetch all subtypes of this entity and this entity itself</returns>
		public virtual IRelationCollection CreateHierarchyRelations()
		{
			return null;			
		}

		/// <summary>This method retrieves, using the InheritanceInfoprovider, the factory for the entity represented by the values passed in.</summary>
		/// <param name="fieldValues">Field values read from the db, to determine which factory to return, based on the field values passed in.</param>
		/// <param name="entityFieldStartIndexesPerEntity">indexes into values where per entity type their own fields start.</param>
		/// <returns>the factory for the entity which is represented by the values passed in.</returns>
		public virtual IEntityFactory GetEntityFactory(object[] fieldValues, Dictionary<string, int> entityFieldStartIndexesPerEntity)
		{
			return this;
		}
		
		/// <summary>Creates a new entity collection for the entity of this factory.</summary>
		/// <returns>ready to use new entity collection, typed.</returns>
		public virtual IEntityCollection CreateEntityCollection()
		{
			return new AutorCollection();
		}
		
		/// <summary>returns the name of the entity this factory is for, e.g. "EmployeeEntity"</summary>
		public virtual string ForEntityName 
		{ 
			get { return "AutorEntity"; }
		}

		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty CargoEntity objects.</summary>
#if CF
	[SD.LLBLGen.Pro.ORMSupportClasses.Serializable]
#else
	[Serializable]
#endif
	public partial class CargoEntityFactory : IEntityFactory
	{
		/// <summary>Creates a new, empty CargoEntity object.</summary>
		/// <returns>A new, empty CargoEntity object.</returns>
		public virtual IEntity Create()
		{
			IEntity toReturn = new CargoEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewCargo
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;

		}
		
		/// <summary>Creates a new CargoEntity instance but uses a special constructor which will set the Fields object of the new IEntity instance to the passed in fields object. Implement this method to support multi-type in single table inheritance.</summary>
		/// <param name="fields">Populated IEntityFields object for the new IEntity to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields object) IEntity object</returns>
		public virtual IEntity Create(IEntityFields fields)
		{
			IEntity toReturn = Create();
			toReturn.Fields = fields;
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewCargoUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}

		/// <summary>Creates, using the generated EntityFieldsFactory, the IEntityFields object for the entity to create. This method is used by internal code to create the fields object to store fetched data. 
		/// </summary>
		/// <returns>Empty IEntityFields object.</returns>
		public virtual IEntityFields CreateFields()
		{
			return EntityFieldsFactory.CreateEntityFieldsObject(ORMDiocesis.EntityType.CargoEntity);
		}
		
		/// <summary>Creates the hierarchy fields for the entity to which this factory belongs.</summary>
		/// <returns>IEntityFields object with the fields of all the entities in teh hierarchy of this entity or the fields of this entity if the entity isn't in a hierarchy.</returns>
		public virtual IEntityFields CreateHierarchyFields()
		{
			return this.CreateFields();
		}
		
		/// <summary>Creates the relations collection to the entity to join all targets so this entity can be fetched. </summary>
		/// <returns>null if the entity isn't in a hierarchy of type TargetPerEntity, otherwise the relations collection needed to join all targets together to fetch all subtypes of this entity and this entity itself</returns>
		public virtual IRelationCollection CreateHierarchyRelations()
		{
			return null;			
		}

		/// <summary>This method retrieves, using the InheritanceInfoprovider, the factory for the entity represented by the values passed in.</summary>
		/// <param name="fieldValues">Field values read from the db, to determine which factory to return, based on the field values passed in.</param>
		/// <param name="entityFieldStartIndexesPerEntity">indexes into values where per entity type their own fields start.</param>
		/// <returns>the factory for the entity which is represented by the values passed in.</returns>
		public virtual IEntityFactory GetEntityFactory(object[] fieldValues, Dictionary<string, int> entityFieldStartIndexesPerEntity)
		{
			return this;
		}
		
		/// <summary>Creates a new entity collection for the entity of this factory.</summary>
		/// <returns>ready to use new entity collection, typed.</returns>
		public virtual IEntityCollection CreateEntityCollection()
		{
			return new CargoCollection();
		}
		
		/// <summary>returns the name of the entity this factory is for, e.g. "EmployeeEntity"</summary>
		public virtual string ForEntityName 
		{ 
			get { return "CargoEntity"; }
		}

		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty CiudadEntity objects.</summary>
#if CF
	[SD.LLBLGen.Pro.ORMSupportClasses.Serializable]
#else
	[Serializable]
#endif
	public partial class CiudadEntityFactory : IEntityFactory
	{
		/// <summary>Creates a new, empty CiudadEntity object.</summary>
		/// <returns>A new, empty CiudadEntity object.</returns>
		public virtual IEntity Create()
		{
			IEntity toReturn = new CiudadEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewCiudad
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;

		}
		
		/// <summary>Creates a new CiudadEntity instance but uses a special constructor which will set the Fields object of the new IEntity instance to the passed in fields object. Implement this method to support multi-type in single table inheritance.</summary>
		/// <param name="fields">Populated IEntityFields object for the new IEntity to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields object) IEntity object</returns>
		public virtual IEntity Create(IEntityFields fields)
		{
			IEntity toReturn = Create();
			toReturn.Fields = fields;
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewCiudadUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}

		/// <summary>Creates, using the generated EntityFieldsFactory, the IEntityFields object for the entity to create. This method is used by internal code to create the fields object to store fetched data. 
		/// </summary>
		/// <returns>Empty IEntityFields object.</returns>
		public virtual IEntityFields CreateFields()
		{
			return EntityFieldsFactory.CreateEntityFieldsObject(ORMDiocesis.EntityType.CiudadEntity);
		}
		
		/// <summary>Creates the hierarchy fields for the entity to which this factory belongs.</summary>
		/// <returns>IEntityFields object with the fields of all the entities in teh hierarchy of this entity or the fields of this entity if the entity isn't in a hierarchy.</returns>
		public virtual IEntityFields CreateHierarchyFields()
		{
			return this.CreateFields();
		}
		
		/// <summary>Creates the relations collection to the entity to join all targets so this entity can be fetched. </summary>
		/// <returns>null if the entity isn't in a hierarchy of type TargetPerEntity, otherwise the relations collection needed to join all targets together to fetch all subtypes of this entity and this entity itself</returns>
		public virtual IRelationCollection CreateHierarchyRelations()
		{
			return null;			
		}

		/// <summary>This method retrieves, using the InheritanceInfoprovider, the factory for the entity represented by the values passed in.</summary>
		/// <param name="fieldValues">Field values read from the db, to determine which factory to return, based on the field values passed in.</param>
		/// <param name="entityFieldStartIndexesPerEntity">indexes into values where per entity type their own fields start.</param>
		/// <returns>the factory for the entity which is represented by the values passed in.</returns>
		public virtual IEntityFactory GetEntityFactory(object[] fieldValues, Dictionary<string, int> entityFieldStartIndexesPerEntity)
		{
			return this;
		}
		
		/// <summary>Creates a new entity collection for the entity of this factory.</summary>
		/// <returns>ready to use new entity collection, typed.</returns>
		public virtual IEntityCollection CreateEntityCollection()
		{
			return new CiudadCollection();
		}
		
		/// <summary>returns the name of the entity this factory is for, e.g. "EmployeeEntity"</summary>
		public virtual string ForEntityName 
		{ 
			get { return "CiudadEntity"; }
		}

		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty CiudadesEntity objects.</summary>
#if CF
	[SD.LLBLGen.Pro.ORMSupportClasses.Serializable]
#else
	[Serializable]
#endif
	public partial class CiudadesEntityFactory : IEntityFactory
	{
		/// <summary>Creates a new, empty CiudadesEntity object.</summary>
		/// <returns>A new, empty CiudadesEntity object.</returns>
		public virtual IEntity Create()
		{
			IEntity toReturn = new CiudadesEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewCiudades
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;

		}
		
		/// <summary>Creates a new CiudadesEntity instance but uses a special constructor which will set the Fields object of the new IEntity instance to the passed in fields object. Implement this method to support multi-type in single table inheritance.</summary>
		/// <param name="fields">Populated IEntityFields object for the new IEntity to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields object) IEntity object</returns>
		public virtual IEntity Create(IEntityFields fields)
		{
			IEntity toReturn = Create();
			toReturn.Fields = fields;
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewCiudadesUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}

		/// <summary>Creates, using the generated EntityFieldsFactory, the IEntityFields object for the entity to create. This method is used by internal code to create the fields object to store fetched data. 
		/// </summary>
		/// <returns>Empty IEntityFields object.</returns>
		public virtual IEntityFields CreateFields()
		{
			return EntityFieldsFactory.CreateEntityFieldsObject(ORMDiocesis.EntityType.CiudadesEntity);
		}
		
		/// <summary>Creates the hierarchy fields for the entity to which this factory belongs.</summary>
		/// <returns>IEntityFields object with the fields of all the entities in teh hierarchy of this entity or the fields of this entity if the entity isn't in a hierarchy.</returns>
		public virtual IEntityFields CreateHierarchyFields()
		{
			return this.CreateFields();
		}
		
		/// <summary>Creates the relations collection to the entity to join all targets so this entity can be fetched. </summary>
		/// <returns>null if the entity isn't in a hierarchy of type TargetPerEntity, otherwise the relations collection needed to join all targets together to fetch all subtypes of this entity and this entity itself</returns>
		public virtual IRelationCollection CreateHierarchyRelations()
		{
			return null;			
		}

		/// <summary>This method retrieves, using the InheritanceInfoprovider, the factory for the entity represented by the values passed in.</summary>
		/// <param name="fieldValues">Field values read from the db, to determine which factory to return, based on the field values passed in.</param>
		/// <param name="entityFieldStartIndexesPerEntity">indexes into values where per entity type their own fields start.</param>
		/// <returns>the factory for the entity which is represented by the values passed in.</returns>
		public virtual IEntityFactory GetEntityFactory(object[] fieldValues, Dictionary<string, int> entityFieldStartIndexesPerEntity)
		{
			return this;
		}
		
		/// <summary>Creates a new entity collection for the entity of this factory.</summary>
		/// <returns>ready to use new entity collection, typed.</returns>
		public virtual IEntityCollection CreateEntityCollection()
		{
			return new CiudadesCollection();
		}
		
		/// <summary>returns the name of the entity this factory is for, e.g. "EmployeeEntity"</summary>
		public virtual string ForEntityName 
		{ 
			get { return "CiudadesEntity"; }
		}

		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty EditorialEntity objects.</summary>
#if CF
	[SD.LLBLGen.Pro.ORMSupportClasses.Serializable]
#else
	[Serializable]
#endif
	public partial class EditorialEntityFactory : IEntityFactory
	{
		/// <summary>Creates a new, empty EditorialEntity object.</summary>
		/// <returns>A new, empty EditorialEntity object.</returns>
		public virtual IEntity Create()
		{
			IEntity toReturn = new EditorialEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewEditorial
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;

		}
		
		/// <summary>Creates a new EditorialEntity instance but uses a special constructor which will set the Fields object of the new IEntity instance to the passed in fields object. Implement this method to support multi-type in single table inheritance.</summary>
		/// <param name="fields">Populated IEntityFields object for the new IEntity to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields object) IEntity object</returns>
		public virtual IEntity Create(IEntityFields fields)
		{
			IEntity toReturn = Create();
			toReturn.Fields = fields;
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewEditorialUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}

		/// <summary>Creates, using the generated EntityFieldsFactory, the IEntityFields object for the entity to create. This method is used by internal code to create the fields object to store fetched data. 
		/// </summary>
		/// <returns>Empty IEntityFields object.</returns>
		public virtual IEntityFields CreateFields()
		{
			return EntityFieldsFactory.CreateEntityFieldsObject(ORMDiocesis.EntityType.EditorialEntity);
		}
		
		/// <summary>Creates the hierarchy fields for the entity to which this factory belongs.</summary>
		/// <returns>IEntityFields object with the fields of all the entities in teh hierarchy of this entity or the fields of this entity if the entity isn't in a hierarchy.</returns>
		public virtual IEntityFields CreateHierarchyFields()
		{
			return this.CreateFields();
		}
		
		/// <summary>Creates the relations collection to the entity to join all targets so this entity can be fetched. </summary>
		/// <returns>null if the entity isn't in a hierarchy of type TargetPerEntity, otherwise the relations collection needed to join all targets together to fetch all subtypes of this entity and this entity itself</returns>
		public virtual IRelationCollection CreateHierarchyRelations()
		{
			return null;			
		}

		/// <summary>This method retrieves, using the InheritanceInfoprovider, the factory for the entity represented by the values passed in.</summary>
		/// <param name="fieldValues">Field values read from the db, to determine which factory to return, based on the field values passed in.</param>
		/// <param name="entityFieldStartIndexesPerEntity">indexes into values where per entity type their own fields start.</param>
		/// <returns>the factory for the entity which is represented by the values passed in.</returns>
		public virtual IEntityFactory GetEntityFactory(object[] fieldValues, Dictionary<string, int> entityFieldStartIndexesPerEntity)
		{
			return this;
		}
		
		/// <summary>Creates a new entity collection for the entity of this factory.</summary>
		/// <returns>ready to use new entity collection, typed.</returns>
		public virtual IEntityCollection CreateEntityCollection()
		{
			return new EditorialCollection();
		}
		
		/// <summary>returns the name of the entity this factory is for, e.g. "EmployeeEntity"</summary>
		public virtual string ForEntityName 
		{ 
			get { return "EditorialEntity"; }
		}

		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty EquipoDeTrabajoEntity objects.</summary>
#if CF
	[SD.LLBLGen.Pro.ORMSupportClasses.Serializable]
#else
	[Serializable]
#endif
	public partial class EquipoDeTrabajoEntityFactory : IEntityFactory
	{
		/// <summary>Creates a new, empty EquipoDeTrabajoEntity object.</summary>
		/// <returns>A new, empty EquipoDeTrabajoEntity object.</returns>
		public virtual IEntity Create()
		{
			IEntity toReturn = new EquipoDeTrabajoEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewEquipoDeTrabajo
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;

		}
		
		/// <summary>Creates a new EquipoDeTrabajoEntity instance but uses a special constructor which will set the Fields object of the new IEntity instance to the passed in fields object. Implement this method to support multi-type in single table inheritance.</summary>
		/// <param name="fields">Populated IEntityFields object for the new IEntity to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields object) IEntity object</returns>
		public virtual IEntity Create(IEntityFields fields)
		{
			IEntity toReturn = Create();
			toReturn.Fields = fields;
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewEquipoDeTrabajoUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}

		/// <summary>Creates, using the generated EntityFieldsFactory, the IEntityFields object for the entity to create. This method is used by internal code to create the fields object to store fetched data. 
		/// </summary>
		/// <returns>Empty IEntityFields object.</returns>
		public virtual IEntityFields CreateFields()
		{
			return EntityFieldsFactory.CreateEntityFieldsObject(ORMDiocesis.EntityType.EquipoDeTrabajoEntity);
		}
		
		/// <summary>Creates the hierarchy fields for the entity to which this factory belongs.</summary>
		/// <returns>IEntityFields object with the fields of all the entities in teh hierarchy of this entity or the fields of this entity if the entity isn't in a hierarchy.</returns>
		public virtual IEntityFields CreateHierarchyFields()
		{
			return this.CreateFields();
		}
		
		/// <summary>Creates the relations collection to the entity to join all targets so this entity can be fetched. </summary>
		/// <returns>null if the entity isn't in a hierarchy of type TargetPerEntity, otherwise the relations collection needed to join all targets together to fetch all subtypes of this entity and this entity itself</returns>
		public virtual IRelationCollection CreateHierarchyRelations()
		{
			return null;			
		}

		/// <summary>This method retrieves, using the InheritanceInfoprovider, the factory for the entity represented by the values passed in.</summary>
		/// <param name="fieldValues">Field values read from the db, to determine which factory to return, based on the field values passed in.</param>
		/// <param name="entityFieldStartIndexesPerEntity">indexes into values where per entity type their own fields start.</param>
		/// <returns>the factory for the entity which is represented by the values passed in.</returns>
		public virtual IEntityFactory GetEntityFactory(object[] fieldValues, Dictionary<string, int> entityFieldStartIndexesPerEntity)
		{
			return this;
		}
		
		/// <summary>Creates a new entity collection for the entity of this factory.</summary>
		/// <returns>ready to use new entity collection, typed.</returns>
		public virtual IEntityCollection CreateEntityCollection()
		{
			return new EquipoDeTrabajoCollection();
		}
		
		/// <summary>returns the name of the entity this factory is for, e.g. "EmployeeEntity"</summary>
		public virtual string ForEntityName 
		{ 
			get { return "EquipoDeTrabajoEntity"; }
		}

		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty EventoEntity objects.</summary>
#if CF
	[SD.LLBLGen.Pro.ORMSupportClasses.Serializable]
#else
	[Serializable]
#endif
	public partial class EventoEntityFactory : IEntityFactory
	{
		/// <summary>Creates a new, empty EventoEntity object.</summary>
		/// <returns>A new, empty EventoEntity object.</returns>
		public virtual IEntity Create()
		{
			IEntity toReturn = new EventoEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewEvento
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;

		}
		
		/// <summary>Creates a new EventoEntity instance but uses a special constructor which will set the Fields object of the new IEntity instance to the passed in fields object. Implement this method to support multi-type in single table inheritance.</summary>
		/// <param name="fields">Populated IEntityFields object for the new IEntity to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields object) IEntity object</returns>
		public virtual IEntity Create(IEntityFields fields)
		{
			IEntity toReturn = Create();
			toReturn.Fields = fields;
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewEventoUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}

		/// <summary>Creates, using the generated EntityFieldsFactory, the IEntityFields object for the entity to create. This method is used by internal code to create the fields object to store fetched data. 
		/// </summary>
		/// <returns>Empty IEntityFields object.</returns>
		public virtual IEntityFields CreateFields()
		{
			return EntityFieldsFactory.CreateEntityFieldsObject(ORMDiocesis.EntityType.EventoEntity);
		}
		
		/// <summary>Creates the hierarchy fields for the entity to which this factory belongs.</summary>
		/// <returns>IEntityFields object with the fields of all the entities in teh hierarchy of this entity or the fields of this entity if the entity isn't in a hierarchy.</returns>
		public virtual IEntityFields CreateHierarchyFields()
		{
			return this.CreateFields();
		}
		
		/// <summary>Creates the relations collection to the entity to join all targets so this entity can be fetched. </summary>
		/// <returns>null if the entity isn't in a hierarchy of type TargetPerEntity, otherwise the relations collection needed to join all targets together to fetch all subtypes of this entity and this entity itself</returns>
		public virtual IRelationCollection CreateHierarchyRelations()
		{
			return null;			
		}

		/// <summary>This method retrieves, using the InheritanceInfoprovider, the factory for the entity represented by the values passed in.</summary>
		/// <param name="fieldValues">Field values read from the db, to determine which factory to return, based on the field values passed in.</param>
		/// <param name="entityFieldStartIndexesPerEntity">indexes into values where per entity type their own fields start.</param>
		/// <returns>the factory for the entity which is represented by the values passed in.</returns>
		public virtual IEntityFactory GetEntityFactory(object[] fieldValues, Dictionary<string, int> entityFieldStartIndexesPerEntity)
		{
			return this;
		}
		
		/// <summary>Creates a new entity collection for the entity of this factory.</summary>
		/// <returns>ready to use new entity collection, typed.</returns>
		public virtual IEntityCollection CreateEntityCollection()
		{
			return new EventoCollection();
		}
		
		/// <summary>returns the name of the entity this factory is for, e.g. "EmployeeEntity"</summary>
		public virtual string ForEntityName 
		{ 
			get { return "EventoEntity"; }
		}

		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty LectoresEntity objects.</summary>
#if CF
	[SD.LLBLGen.Pro.ORMSupportClasses.Serializable]
#else
	[Serializable]
#endif
	public partial class LectoresEntityFactory : IEntityFactory
	{
		/// <summary>Creates a new, empty LectoresEntity object.</summary>
		/// <returns>A new, empty LectoresEntity object.</returns>
		public virtual IEntity Create()
		{
			IEntity toReturn = new LectoresEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewLectores
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;

		}
		
		/// <summary>Creates a new LectoresEntity instance but uses a special constructor which will set the Fields object of the new IEntity instance to the passed in fields object. Implement this method to support multi-type in single table inheritance.</summary>
		/// <param name="fields">Populated IEntityFields object for the new IEntity to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields object) IEntity object</returns>
		public virtual IEntity Create(IEntityFields fields)
		{
			IEntity toReturn = Create();
			toReturn.Fields = fields;
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewLectoresUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}

		/// <summary>Creates, using the generated EntityFieldsFactory, the IEntityFields object for the entity to create. This method is used by internal code to create the fields object to store fetched data. 
		/// </summary>
		/// <returns>Empty IEntityFields object.</returns>
		public virtual IEntityFields CreateFields()
		{
			return EntityFieldsFactory.CreateEntityFieldsObject(ORMDiocesis.EntityType.LectoresEntity);
		}
		
		/// <summary>Creates the hierarchy fields for the entity to which this factory belongs.</summary>
		/// <returns>IEntityFields object with the fields of all the entities in teh hierarchy of this entity or the fields of this entity if the entity isn't in a hierarchy.</returns>
		public virtual IEntityFields CreateHierarchyFields()
		{
			return this.CreateFields();
		}
		
		/// <summary>Creates the relations collection to the entity to join all targets so this entity can be fetched. </summary>
		/// <returns>null if the entity isn't in a hierarchy of type TargetPerEntity, otherwise the relations collection needed to join all targets together to fetch all subtypes of this entity and this entity itself</returns>
		public virtual IRelationCollection CreateHierarchyRelations()
		{
			return null;			
		}

		/// <summary>This method retrieves, using the InheritanceInfoprovider, the factory for the entity represented by the values passed in.</summary>
		/// <param name="fieldValues">Field values read from the db, to determine which factory to return, based on the field values passed in.</param>
		/// <param name="entityFieldStartIndexesPerEntity">indexes into values where per entity type their own fields start.</param>
		/// <returns>the factory for the entity which is represented by the values passed in.</returns>
		public virtual IEntityFactory GetEntityFactory(object[] fieldValues, Dictionary<string, int> entityFieldStartIndexesPerEntity)
		{
			return this;
		}
		
		/// <summary>Creates a new entity collection for the entity of this factory.</summary>
		/// <returns>ready to use new entity collection, typed.</returns>
		public virtual IEntityCollection CreateEntityCollection()
		{
			return new LectoresCollection();
		}
		
		/// <summary>returns the name of the entity this factory is for, e.g. "EmployeeEntity"</summary>
		public virtual string ForEntityName 
		{ 
			get { return "LectoresEntity"; }
		}

		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty LibroEntity objects.</summary>
#if CF
	[SD.LLBLGen.Pro.ORMSupportClasses.Serializable]
#else
	[Serializable]
#endif
	public partial class LibroEntityFactory : IEntityFactory
	{
		/// <summary>Creates a new, empty LibroEntity object.</summary>
		/// <returns>A new, empty LibroEntity object.</returns>
		public virtual IEntity Create()
		{
			IEntity toReturn = new LibroEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewLibro
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;

		}
		
		/// <summary>Creates a new LibroEntity instance but uses a special constructor which will set the Fields object of the new IEntity instance to the passed in fields object. Implement this method to support multi-type in single table inheritance.</summary>
		/// <param name="fields">Populated IEntityFields object for the new IEntity to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields object) IEntity object</returns>
		public virtual IEntity Create(IEntityFields fields)
		{
			IEntity toReturn = Create();
			toReturn.Fields = fields;
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewLibroUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}

		/// <summary>Creates, using the generated EntityFieldsFactory, the IEntityFields object for the entity to create. This method is used by internal code to create the fields object to store fetched data. 
		/// </summary>
		/// <returns>Empty IEntityFields object.</returns>
		public virtual IEntityFields CreateFields()
		{
			return EntityFieldsFactory.CreateEntityFieldsObject(ORMDiocesis.EntityType.LibroEntity);
		}
		
		/// <summary>Creates the hierarchy fields for the entity to which this factory belongs.</summary>
		/// <returns>IEntityFields object with the fields of all the entities in teh hierarchy of this entity or the fields of this entity if the entity isn't in a hierarchy.</returns>
		public virtual IEntityFields CreateHierarchyFields()
		{
			return this.CreateFields();
		}
		
		/// <summary>Creates the relations collection to the entity to join all targets so this entity can be fetched. </summary>
		/// <returns>null if the entity isn't in a hierarchy of type TargetPerEntity, otherwise the relations collection needed to join all targets together to fetch all subtypes of this entity and this entity itself</returns>
		public virtual IRelationCollection CreateHierarchyRelations()
		{
			return null;			
		}

		/// <summary>This method retrieves, using the InheritanceInfoprovider, the factory for the entity represented by the values passed in.</summary>
		/// <param name="fieldValues">Field values read from the db, to determine which factory to return, based on the field values passed in.</param>
		/// <param name="entityFieldStartIndexesPerEntity">indexes into values where per entity type their own fields start.</param>
		/// <returns>the factory for the entity which is represented by the values passed in.</returns>
		public virtual IEntityFactory GetEntityFactory(object[] fieldValues, Dictionary<string, int> entityFieldStartIndexesPerEntity)
		{
			return this;
		}
		
		/// <summary>Creates a new entity collection for the entity of this factory.</summary>
		/// <returns>ready to use new entity collection, typed.</returns>
		public virtual IEntityCollection CreateEntityCollection()
		{
			return new LibroCollection();
		}
		
		/// <summary>returns the name of the entity this factory is for, e.g. "EmployeeEntity"</summary>
		public virtual string ForEntityName 
		{ 
			get { return "LibroEntity"; }
		}

		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty LibroEstatusEntity objects.</summary>
#if CF
	[SD.LLBLGen.Pro.ORMSupportClasses.Serializable]
#else
	[Serializable]
#endif
	public partial class LibroEstatusEntityFactory : IEntityFactory
	{
		/// <summary>Creates a new, empty LibroEstatusEntity object.</summary>
		/// <returns>A new, empty LibroEstatusEntity object.</returns>
		public virtual IEntity Create()
		{
			IEntity toReturn = new LibroEstatusEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewLibroEstatus
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;

		}
		
		/// <summary>Creates a new LibroEstatusEntity instance but uses a special constructor which will set the Fields object of the new IEntity instance to the passed in fields object. Implement this method to support multi-type in single table inheritance.</summary>
		/// <param name="fields">Populated IEntityFields object for the new IEntity to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields object) IEntity object</returns>
		public virtual IEntity Create(IEntityFields fields)
		{
			IEntity toReturn = Create();
			toReturn.Fields = fields;
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewLibroEstatusUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}

		/// <summary>Creates, using the generated EntityFieldsFactory, the IEntityFields object for the entity to create. This method is used by internal code to create the fields object to store fetched data. 
		/// </summary>
		/// <returns>Empty IEntityFields object.</returns>
		public virtual IEntityFields CreateFields()
		{
			return EntityFieldsFactory.CreateEntityFieldsObject(ORMDiocesis.EntityType.LibroEstatusEntity);
		}
		
		/// <summary>Creates the hierarchy fields for the entity to which this factory belongs.</summary>
		/// <returns>IEntityFields object with the fields of all the entities in teh hierarchy of this entity or the fields of this entity if the entity isn't in a hierarchy.</returns>
		public virtual IEntityFields CreateHierarchyFields()
		{
			return this.CreateFields();
		}
		
		/// <summary>Creates the relations collection to the entity to join all targets so this entity can be fetched. </summary>
		/// <returns>null if the entity isn't in a hierarchy of type TargetPerEntity, otherwise the relations collection needed to join all targets together to fetch all subtypes of this entity and this entity itself</returns>
		public virtual IRelationCollection CreateHierarchyRelations()
		{
			return null;			
		}

		/// <summary>This method retrieves, using the InheritanceInfoprovider, the factory for the entity represented by the values passed in.</summary>
		/// <param name="fieldValues">Field values read from the db, to determine which factory to return, based on the field values passed in.</param>
		/// <param name="entityFieldStartIndexesPerEntity">indexes into values where per entity type their own fields start.</param>
		/// <returns>the factory for the entity which is represented by the values passed in.</returns>
		public virtual IEntityFactory GetEntityFactory(object[] fieldValues, Dictionary<string, int> entityFieldStartIndexesPerEntity)
		{
			return this;
		}
		
		/// <summary>Creates a new entity collection for the entity of this factory.</summary>
		/// <returns>ready to use new entity collection, typed.</returns>
		public virtual IEntityCollection CreateEntityCollection()
		{
			return new LibroEstatusCollection();
		}
		
		/// <summary>returns the name of the entity this factory is for, e.g. "EmployeeEntity"</summary>
		public virtual string ForEntityName 
		{ 
			get { return "LibroEstatusEntity"; }
		}

		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty LibroFormatoEntity objects.</summary>
#if CF
	[SD.LLBLGen.Pro.ORMSupportClasses.Serializable]
#else
	[Serializable]
#endif
	public partial class LibroFormatoEntityFactory : IEntityFactory
	{
		/// <summary>Creates a new, empty LibroFormatoEntity object.</summary>
		/// <returns>A new, empty LibroFormatoEntity object.</returns>
		public virtual IEntity Create()
		{
			IEntity toReturn = new LibroFormatoEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewLibroFormato
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;

		}
		
		/// <summary>Creates a new LibroFormatoEntity instance but uses a special constructor which will set the Fields object of the new IEntity instance to the passed in fields object. Implement this method to support multi-type in single table inheritance.</summary>
		/// <param name="fields">Populated IEntityFields object for the new IEntity to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields object) IEntity object</returns>
		public virtual IEntity Create(IEntityFields fields)
		{
			IEntity toReturn = Create();
			toReturn.Fields = fields;
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewLibroFormatoUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}

		/// <summary>Creates, using the generated EntityFieldsFactory, the IEntityFields object for the entity to create. This method is used by internal code to create the fields object to store fetched data. 
		/// </summary>
		/// <returns>Empty IEntityFields object.</returns>
		public virtual IEntityFields CreateFields()
		{
			return EntityFieldsFactory.CreateEntityFieldsObject(ORMDiocesis.EntityType.LibroFormatoEntity);
		}
		
		/// <summary>Creates the hierarchy fields for the entity to which this factory belongs.</summary>
		/// <returns>IEntityFields object with the fields of all the entities in teh hierarchy of this entity or the fields of this entity if the entity isn't in a hierarchy.</returns>
		public virtual IEntityFields CreateHierarchyFields()
		{
			return this.CreateFields();
		}
		
		/// <summary>Creates the relations collection to the entity to join all targets so this entity can be fetched. </summary>
		/// <returns>null if the entity isn't in a hierarchy of type TargetPerEntity, otherwise the relations collection needed to join all targets together to fetch all subtypes of this entity and this entity itself</returns>
		public virtual IRelationCollection CreateHierarchyRelations()
		{
			return null;			
		}

		/// <summary>This method retrieves, using the InheritanceInfoprovider, the factory for the entity represented by the values passed in.</summary>
		/// <param name="fieldValues">Field values read from the db, to determine which factory to return, based on the field values passed in.</param>
		/// <param name="entityFieldStartIndexesPerEntity">indexes into values where per entity type their own fields start.</param>
		/// <returns>the factory for the entity which is represented by the values passed in.</returns>
		public virtual IEntityFactory GetEntityFactory(object[] fieldValues, Dictionary<string, int> entityFieldStartIndexesPerEntity)
		{
			return this;
		}
		
		/// <summary>Creates a new entity collection for the entity of this factory.</summary>
		/// <returns>ready to use new entity collection, typed.</returns>
		public virtual IEntityCollection CreateEntityCollection()
		{
			return new LibroFormatoCollection();
		}
		
		/// <summary>returns the name of the entity this factory is for, e.g. "EmployeeEntity"</summary>
		public virtual string ForEntityName 
		{ 
			get { return "LibroFormatoEntity"; }
		}

		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty PaisEntity objects.</summary>
#if CF
	[SD.LLBLGen.Pro.ORMSupportClasses.Serializable]
#else
	[Serializable]
#endif
	public partial class PaisEntityFactory : IEntityFactory
	{
		/// <summary>Creates a new, empty PaisEntity object.</summary>
		/// <returns>A new, empty PaisEntity object.</returns>
		public virtual IEntity Create()
		{
			IEntity toReturn = new PaisEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewPais
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;

		}
		
		/// <summary>Creates a new PaisEntity instance but uses a special constructor which will set the Fields object of the new IEntity instance to the passed in fields object. Implement this method to support multi-type in single table inheritance.</summary>
		/// <param name="fields">Populated IEntityFields object for the new IEntity to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields object) IEntity object</returns>
		public virtual IEntity Create(IEntityFields fields)
		{
			IEntity toReturn = Create();
			toReturn.Fields = fields;
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewPaisUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}

		/// <summary>Creates, using the generated EntityFieldsFactory, the IEntityFields object for the entity to create. This method is used by internal code to create the fields object to store fetched data. 
		/// </summary>
		/// <returns>Empty IEntityFields object.</returns>
		public virtual IEntityFields CreateFields()
		{
			return EntityFieldsFactory.CreateEntityFieldsObject(ORMDiocesis.EntityType.PaisEntity);
		}
		
		/// <summary>Creates the hierarchy fields for the entity to which this factory belongs.</summary>
		/// <returns>IEntityFields object with the fields of all the entities in teh hierarchy of this entity or the fields of this entity if the entity isn't in a hierarchy.</returns>
		public virtual IEntityFields CreateHierarchyFields()
		{
			return this.CreateFields();
		}
		
		/// <summary>Creates the relations collection to the entity to join all targets so this entity can be fetched. </summary>
		/// <returns>null if the entity isn't in a hierarchy of type TargetPerEntity, otherwise the relations collection needed to join all targets together to fetch all subtypes of this entity and this entity itself</returns>
		public virtual IRelationCollection CreateHierarchyRelations()
		{
			return null;			
		}

		/// <summary>This method retrieves, using the InheritanceInfoprovider, the factory for the entity represented by the values passed in.</summary>
		/// <param name="fieldValues">Field values read from the db, to determine which factory to return, based on the field values passed in.</param>
		/// <param name="entityFieldStartIndexesPerEntity">indexes into values where per entity type their own fields start.</param>
		/// <returns>the factory for the entity which is represented by the values passed in.</returns>
		public virtual IEntityFactory GetEntityFactory(object[] fieldValues, Dictionary<string, int> entityFieldStartIndexesPerEntity)
		{
			return this;
		}
		
		/// <summary>Creates a new entity collection for the entity of this factory.</summary>
		/// <returns>ready to use new entity collection, typed.</returns>
		public virtual IEntityCollection CreateEntityCollection()
		{
			return new PaisCollection();
		}
		
		/// <summary>returns the name of the entity this factory is for, e.g. "EmployeeEntity"</summary>
		public virtual string ForEntityName 
		{ 
			get { return "PaisEntity"; }
		}

		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty ParrocoEntity objects.</summary>
#if CF
	[SD.LLBLGen.Pro.ORMSupportClasses.Serializable]
#else
	[Serializable]
#endif
	public partial class ParrocoEntityFactory : IEntityFactory
	{
		/// <summary>Creates a new, empty ParrocoEntity object.</summary>
		/// <returns>A new, empty ParrocoEntity object.</returns>
		public virtual IEntity Create()
		{
			IEntity toReturn = new ParrocoEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewParroco
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;

		}
		
		/// <summary>Creates a new ParrocoEntity instance but uses a special constructor which will set the Fields object of the new IEntity instance to the passed in fields object. Implement this method to support multi-type in single table inheritance.</summary>
		/// <param name="fields">Populated IEntityFields object for the new IEntity to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields object) IEntity object</returns>
		public virtual IEntity Create(IEntityFields fields)
		{
			IEntity toReturn = Create();
			toReturn.Fields = fields;
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewParrocoUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}

		/// <summary>Creates, using the generated EntityFieldsFactory, the IEntityFields object for the entity to create. This method is used by internal code to create the fields object to store fetched data. 
		/// </summary>
		/// <returns>Empty IEntityFields object.</returns>
		public virtual IEntityFields CreateFields()
		{
			return EntityFieldsFactory.CreateEntityFieldsObject(ORMDiocesis.EntityType.ParrocoEntity);
		}
		
		/// <summary>Creates the hierarchy fields for the entity to which this factory belongs.</summary>
		/// <returns>IEntityFields object with the fields of all the entities in teh hierarchy of this entity or the fields of this entity if the entity isn't in a hierarchy.</returns>
		public virtual IEntityFields CreateHierarchyFields()
		{
			return this.CreateFields();
		}
		
		/// <summary>Creates the relations collection to the entity to join all targets so this entity can be fetched. </summary>
		/// <returns>null if the entity isn't in a hierarchy of type TargetPerEntity, otherwise the relations collection needed to join all targets together to fetch all subtypes of this entity and this entity itself</returns>
		public virtual IRelationCollection CreateHierarchyRelations()
		{
			return null;			
		}

		/// <summary>This method retrieves, using the InheritanceInfoprovider, the factory for the entity represented by the values passed in.</summary>
		/// <param name="fieldValues">Field values read from the db, to determine which factory to return, based on the field values passed in.</param>
		/// <param name="entityFieldStartIndexesPerEntity">indexes into values where per entity type their own fields start.</param>
		/// <returns>the factory for the entity which is represented by the values passed in.</returns>
		public virtual IEntityFactory GetEntityFactory(object[] fieldValues, Dictionary<string, int> entityFieldStartIndexesPerEntity)
		{
			return this;
		}
		
		/// <summary>Creates a new entity collection for the entity of this factory.</summary>
		/// <returns>ready to use new entity collection, typed.</returns>
		public virtual IEntityCollection CreateEntityCollection()
		{
			return new ParrocoCollection();
		}
		
		/// <summary>returns the name of the entity this factory is for, e.g. "EmployeeEntity"</summary>
		public virtual string ForEntityName 
		{ 
			get { return "ParrocoEntity"; }
		}

		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty ParroquiaEntity objects.</summary>
#if CF
	[SD.LLBLGen.Pro.ORMSupportClasses.Serializable]
#else
	[Serializable]
#endif
	public partial class ParroquiaEntityFactory : IEntityFactory
	{
		/// <summary>Creates a new, empty ParroquiaEntity object.</summary>
		/// <returns>A new, empty ParroquiaEntity object.</returns>
		public virtual IEntity Create()
		{
			IEntity toReturn = new ParroquiaEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewParroquia
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;

		}
		
		/// <summary>Creates a new ParroquiaEntity instance but uses a special constructor which will set the Fields object of the new IEntity instance to the passed in fields object. Implement this method to support multi-type in single table inheritance.</summary>
		/// <param name="fields">Populated IEntityFields object for the new IEntity to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields object) IEntity object</returns>
		public virtual IEntity Create(IEntityFields fields)
		{
			IEntity toReturn = Create();
			toReturn.Fields = fields;
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewParroquiaUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}

		/// <summary>Creates, using the generated EntityFieldsFactory, the IEntityFields object for the entity to create. This method is used by internal code to create the fields object to store fetched data. 
		/// </summary>
		/// <returns>Empty IEntityFields object.</returns>
		public virtual IEntityFields CreateFields()
		{
			return EntityFieldsFactory.CreateEntityFieldsObject(ORMDiocesis.EntityType.ParroquiaEntity);
		}
		
		/// <summary>Creates the hierarchy fields for the entity to which this factory belongs.</summary>
		/// <returns>IEntityFields object with the fields of all the entities in teh hierarchy of this entity or the fields of this entity if the entity isn't in a hierarchy.</returns>
		public virtual IEntityFields CreateHierarchyFields()
		{
			return this.CreateFields();
		}
		
		/// <summary>Creates the relations collection to the entity to join all targets so this entity can be fetched. </summary>
		/// <returns>null if the entity isn't in a hierarchy of type TargetPerEntity, otherwise the relations collection needed to join all targets together to fetch all subtypes of this entity and this entity itself</returns>
		public virtual IRelationCollection CreateHierarchyRelations()
		{
			return null;			
		}

		/// <summary>This method retrieves, using the InheritanceInfoprovider, the factory for the entity represented by the values passed in.</summary>
		/// <param name="fieldValues">Field values read from the db, to determine which factory to return, based on the field values passed in.</param>
		/// <param name="entityFieldStartIndexesPerEntity">indexes into values where per entity type their own fields start.</param>
		/// <returns>the factory for the entity which is represented by the values passed in.</returns>
		public virtual IEntityFactory GetEntityFactory(object[] fieldValues, Dictionary<string, int> entityFieldStartIndexesPerEntity)
		{
			return this;
		}
		
		/// <summary>Creates a new entity collection for the entity of this factory.</summary>
		/// <returns>ready to use new entity collection, typed.</returns>
		public virtual IEntityCollection CreateEntityCollection()
		{
			return new ParroquiaCollection();
		}
		
		/// <summary>returns the name of the entity this factory is for, e.g. "EmployeeEntity"</summary>
		public virtual string ForEntityName 
		{ 
			get { return "ParroquiaEntity"; }
		}

		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty ParticipanteEntity objects.</summary>
#if CF
	[SD.LLBLGen.Pro.ORMSupportClasses.Serializable]
#else
	[Serializable]
#endif
	public partial class ParticipanteEntityFactory : IEntityFactory
	{
		/// <summary>Creates a new, empty ParticipanteEntity object.</summary>
		/// <returns>A new, empty ParticipanteEntity object.</returns>
		public virtual IEntity Create()
		{
			IEntity toReturn = new ParticipanteEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewParticipante
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;

		}
		
		/// <summary>Creates a new ParticipanteEntity instance but uses a special constructor which will set the Fields object of the new IEntity instance to the passed in fields object. Implement this method to support multi-type in single table inheritance.</summary>
		/// <param name="fields">Populated IEntityFields object for the new IEntity to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields object) IEntity object</returns>
		public virtual IEntity Create(IEntityFields fields)
		{
			IEntity toReturn = Create();
			toReturn.Fields = fields;
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewParticipanteUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}

		/// <summary>Creates, using the generated EntityFieldsFactory, the IEntityFields object for the entity to create. This method is used by internal code to create the fields object to store fetched data. 
		/// </summary>
		/// <returns>Empty IEntityFields object.</returns>
		public virtual IEntityFields CreateFields()
		{
			return EntityFieldsFactory.CreateEntityFieldsObject(ORMDiocesis.EntityType.ParticipanteEntity);
		}
		
		/// <summary>Creates the hierarchy fields for the entity to which this factory belongs.</summary>
		/// <returns>IEntityFields object with the fields of all the entities in teh hierarchy of this entity or the fields of this entity if the entity isn't in a hierarchy.</returns>
		public virtual IEntityFields CreateHierarchyFields()
		{
			return this.CreateFields();
		}
		
		/// <summary>Creates the relations collection to the entity to join all targets so this entity can be fetched. </summary>
		/// <returns>null if the entity isn't in a hierarchy of type TargetPerEntity, otherwise the relations collection needed to join all targets together to fetch all subtypes of this entity and this entity itself</returns>
		public virtual IRelationCollection CreateHierarchyRelations()
		{
			return null;			
		}

		/// <summary>This method retrieves, using the InheritanceInfoprovider, the factory for the entity represented by the values passed in.</summary>
		/// <param name="fieldValues">Field values read from the db, to determine which factory to return, based on the field values passed in.</param>
		/// <param name="entityFieldStartIndexesPerEntity">indexes into values where per entity type their own fields start.</param>
		/// <returns>the factory for the entity which is represented by the values passed in.</returns>
		public virtual IEntityFactory GetEntityFactory(object[] fieldValues, Dictionary<string, int> entityFieldStartIndexesPerEntity)
		{
			return this;
		}
		
		/// <summary>Creates a new entity collection for the entity of this factory.</summary>
		/// <returns>ready to use new entity collection, typed.</returns>
		public virtual IEntityCollection CreateEntityCollection()
		{
			return new ParticipanteCollection();
		}
		
		/// <summary>returns the name of the entity this factory is for, e.g. "EmployeeEntity"</summary>
		public virtual string ForEntityName 
		{ 
			get { return "ParticipanteEntity"; }
		}

		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty RamaEntity objects.</summary>
#if CF
	[SD.LLBLGen.Pro.ORMSupportClasses.Serializable]
#else
	[Serializable]
#endif
	public partial class RamaEntityFactory : IEntityFactory
	{
		/// <summary>Creates a new, empty RamaEntity object.</summary>
		/// <returns>A new, empty RamaEntity object.</returns>
		public virtual IEntity Create()
		{
			IEntity toReturn = new RamaEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewRama
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;

		}
		
		/// <summary>Creates a new RamaEntity instance but uses a special constructor which will set the Fields object of the new IEntity instance to the passed in fields object. Implement this method to support multi-type in single table inheritance.</summary>
		/// <param name="fields">Populated IEntityFields object for the new IEntity to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields object) IEntity object</returns>
		public virtual IEntity Create(IEntityFields fields)
		{
			IEntity toReturn = Create();
			toReturn.Fields = fields;
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewRamaUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}

		/// <summary>Creates, using the generated EntityFieldsFactory, the IEntityFields object for the entity to create. This method is used by internal code to create the fields object to store fetched data. 
		/// </summary>
		/// <returns>Empty IEntityFields object.</returns>
		public virtual IEntityFields CreateFields()
		{
			return EntityFieldsFactory.CreateEntityFieldsObject(ORMDiocesis.EntityType.RamaEntity);
		}
		
		/// <summary>Creates the hierarchy fields for the entity to which this factory belongs.</summary>
		/// <returns>IEntityFields object with the fields of all the entities in teh hierarchy of this entity or the fields of this entity if the entity isn't in a hierarchy.</returns>
		public virtual IEntityFields CreateHierarchyFields()
		{
			return this.CreateFields();
		}
		
		/// <summary>Creates the relations collection to the entity to join all targets so this entity can be fetched. </summary>
		/// <returns>null if the entity isn't in a hierarchy of type TargetPerEntity, otherwise the relations collection needed to join all targets together to fetch all subtypes of this entity and this entity itself</returns>
		public virtual IRelationCollection CreateHierarchyRelations()
		{
			return null;			
		}

		/// <summary>This method retrieves, using the InheritanceInfoprovider, the factory for the entity represented by the values passed in.</summary>
		/// <param name="fieldValues">Field values read from the db, to determine which factory to return, based on the field values passed in.</param>
		/// <param name="entityFieldStartIndexesPerEntity">indexes into values where per entity type their own fields start.</param>
		/// <returns>the factory for the entity which is represented by the values passed in.</returns>
		public virtual IEntityFactory GetEntityFactory(object[] fieldValues, Dictionary<string, int> entityFieldStartIndexesPerEntity)
		{
			return this;
		}
		
		/// <summary>Creates a new entity collection for the entity of this factory.</summary>
		/// <returns>ready to use new entity collection, typed.</returns>
		public virtual IEntityCollection CreateEntityCollection()
		{
			return new RamaCollection();
		}
		
		/// <summary>returns the name of the entity this factory is for, e.g. "EmployeeEntity"</summary>
		public virtual string ForEntityName 
		{ 
			get { return "RamaEntity"; }
		}

		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty SeccionEntity objects.</summary>
#if CF
	[SD.LLBLGen.Pro.ORMSupportClasses.Serializable]
#else
	[Serializable]
#endif
	public partial class SeccionEntityFactory : IEntityFactory
	{
		/// <summary>Creates a new, empty SeccionEntity object.</summary>
		/// <returns>A new, empty SeccionEntity object.</returns>
		public virtual IEntity Create()
		{
			IEntity toReturn = new SeccionEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewSeccion
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;

		}
		
		/// <summary>Creates a new SeccionEntity instance but uses a special constructor which will set the Fields object of the new IEntity instance to the passed in fields object. Implement this method to support multi-type in single table inheritance.</summary>
		/// <param name="fields">Populated IEntityFields object for the new IEntity to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields object) IEntity object</returns>
		public virtual IEntity Create(IEntityFields fields)
		{
			IEntity toReturn = Create();
			toReturn.Fields = fields;
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewSeccionUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}

		/// <summary>Creates, using the generated EntityFieldsFactory, the IEntityFields object for the entity to create. This method is used by internal code to create the fields object to store fetched data. 
		/// </summary>
		/// <returns>Empty IEntityFields object.</returns>
		public virtual IEntityFields CreateFields()
		{
			return EntityFieldsFactory.CreateEntityFieldsObject(ORMDiocesis.EntityType.SeccionEntity);
		}
		
		/// <summary>Creates the hierarchy fields for the entity to which this factory belongs.</summary>
		/// <returns>IEntityFields object with the fields of all the entities in teh hierarchy of this entity or the fields of this entity if the entity isn't in a hierarchy.</returns>
		public virtual IEntityFields CreateHierarchyFields()
		{
			return this.CreateFields();
		}
		
		/// <summary>Creates the relations collection to the entity to join all targets so this entity can be fetched. </summary>
		/// <returns>null if the entity isn't in a hierarchy of type TargetPerEntity, otherwise the relations collection needed to join all targets together to fetch all subtypes of this entity and this entity itself</returns>
		public virtual IRelationCollection CreateHierarchyRelations()
		{
			return null;			
		}

		/// <summary>This method retrieves, using the InheritanceInfoprovider, the factory for the entity represented by the values passed in.</summary>
		/// <param name="fieldValues">Field values read from the db, to determine which factory to return, based on the field values passed in.</param>
		/// <param name="entityFieldStartIndexesPerEntity">indexes into values where per entity type their own fields start.</param>
		/// <returns>the factory for the entity which is represented by the values passed in.</returns>
		public virtual IEntityFactory GetEntityFactory(object[] fieldValues, Dictionary<string, int> entityFieldStartIndexesPerEntity)
		{
			return this;
		}
		
		/// <summary>Creates a new entity collection for the entity of this factory.</summary>
		/// <returns>ready to use new entity collection, typed.</returns>
		public virtual IEntityCollection CreateEntityCollection()
		{
			return new SeccionCollection();
		}
		
		/// <summary>returns the name of the entity this factory is for, e.g. "EmployeeEntity"</summary>
		public virtual string ForEntityName 
		{ 
			get { return "SeccionEntity"; }
		}

		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty TematicaEntity objects.</summary>
#if CF
	[SD.LLBLGen.Pro.ORMSupportClasses.Serializable]
#else
	[Serializable]
#endif
	public partial class TematicaEntityFactory : IEntityFactory
	{
		/// <summary>Creates a new, empty TematicaEntity object.</summary>
		/// <returns>A new, empty TematicaEntity object.</returns>
		public virtual IEntity Create()
		{
			IEntity toReturn = new TematicaEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewTematica
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;

		}
		
		/// <summary>Creates a new TematicaEntity instance but uses a special constructor which will set the Fields object of the new IEntity instance to the passed in fields object. Implement this method to support multi-type in single table inheritance.</summary>
		/// <param name="fields">Populated IEntityFields object for the new IEntity to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields object) IEntity object</returns>
		public virtual IEntity Create(IEntityFields fields)
		{
			IEntity toReturn = Create();
			toReturn.Fields = fields;
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewTematicaUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}

		/// <summary>Creates, using the generated EntityFieldsFactory, the IEntityFields object for the entity to create. This method is used by internal code to create the fields object to store fetched data. 
		/// </summary>
		/// <returns>Empty IEntityFields object.</returns>
		public virtual IEntityFields CreateFields()
		{
			return EntityFieldsFactory.CreateEntityFieldsObject(ORMDiocesis.EntityType.TematicaEntity);
		}
		
		/// <summary>Creates the hierarchy fields for the entity to which this factory belongs.</summary>
		/// <returns>IEntityFields object with the fields of all the entities in teh hierarchy of this entity or the fields of this entity if the entity isn't in a hierarchy.</returns>
		public virtual IEntityFields CreateHierarchyFields()
		{
			return this.CreateFields();
		}
		
		/// <summary>Creates the relations collection to the entity to join all targets so this entity can be fetched. </summary>
		/// <returns>null if the entity isn't in a hierarchy of type TargetPerEntity, otherwise the relations collection needed to join all targets together to fetch all subtypes of this entity and this entity itself</returns>
		public virtual IRelationCollection CreateHierarchyRelations()
		{
			return null;			
		}

		/// <summary>This method retrieves, using the InheritanceInfoprovider, the factory for the entity represented by the values passed in.</summary>
		/// <param name="fieldValues">Field values read from the db, to determine which factory to return, based on the field values passed in.</param>
		/// <param name="entityFieldStartIndexesPerEntity">indexes into values where per entity type their own fields start.</param>
		/// <returns>the factory for the entity which is represented by the values passed in.</returns>
		public virtual IEntityFactory GetEntityFactory(object[] fieldValues, Dictionary<string, int> entityFieldStartIndexesPerEntity)
		{
			return this;
		}
		
		/// <summary>Creates a new entity collection for the entity of this factory.</summary>
		/// <returns>ready to use new entity collection, typed.</returns>
		public virtual IEntityCollection CreateEntityCollection()
		{
			return new TematicaCollection();
		}
		
		/// <summary>returns the name of the entity this factory is for, e.g. "EmployeeEntity"</summary>
		public virtual string ForEntityName 
		{ 
			get { return "TematicaEntity"; }
		}

		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty TipoParroquiaEntity objects.</summary>
#if CF
	[SD.LLBLGen.Pro.ORMSupportClasses.Serializable]
#else
	[Serializable]
#endif
	public partial class TipoParroquiaEntityFactory : IEntityFactory
	{
		/// <summary>Creates a new, empty TipoParroquiaEntity object.</summary>
		/// <returns>A new, empty TipoParroquiaEntity object.</returns>
		public virtual IEntity Create()
		{
			IEntity toReturn = new TipoParroquiaEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewTipoParroquia
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;

		}
		
		/// <summary>Creates a new TipoParroquiaEntity instance but uses a special constructor which will set the Fields object of the new IEntity instance to the passed in fields object. Implement this method to support multi-type in single table inheritance.</summary>
		/// <param name="fields">Populated IEntityFields object for the new IEntity to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields object) IEntity object</returns>
		public virtual IEntity Create(IEntityFields fields)
		{
			IEntity toReturn = Create();
			toReturn.Fields = fields;
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewTipoParroquiaUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}

		/// <summary>Creates, using the generated EntityFieldsFactory, the IEntityFields object for the entity to create. This method is used by internal code to create the fields object to store fetched data. 
		/// </summary>
		/// <returns>Empty IEntityFields object.</returns>
		public virtual IEntityFields CreateFields()
		{
			return EntityFieldsFactory.CreateEntityFieldsObject(ORMDiocesis.EntityType.TipoParroquiaEntity);
		}
		
		/// <summary>Creates the hierarchy fields for the entity to which this factory belongs.</summary>
		/// <returns>IEntityFields object with the fields of all the entities in teh hierarchy of this entity or the fields of this entity if the entity isn't in a hierarchy.</returns>
		public virtual IEntityFields CreateHierarchyFields()
		{
			return this.CreateFields();
		}
		
		/// <summary>Creates the relations collection to the entity to join all targets so this entity can be fetched. </summary>
		/// <returns>null if the entity isn't in a hierarchy of type TargetPerEntity, otherwise the relations collection needed to join all targets together to fetch all subtypes of this entity and this entity itself</returns>
		public virtual IRelationCollection CreateHierarchyRelations()
		{
			return null;			
		}

		/// <summary>This method retrieves, using the InheritanceInfoprovider, the factory for the entity represented by the values passed in.</summary>
		/// <param name="fieldValues">Field values read from the db, to determine which factory to return, based on the field values passed in.</param>
		/// <param name="entityFieldStartIndexesPerEntity">indexes into values where per entity type their own fields start.</param>
		/// <returns>the factory for the entity which is represented by the values passed in.</returns>
		public virtual IEntityFactory GetEntityFactory(object[] fieldValues, Dictionary<string, int> entityFieldStartIndexesPerEntity)
		{
			return this;
		}
		
		/// <summary>Creates a new entity collection for the entity of this factory.</summary>
		/// <returns>ready to use new entity collection, typed.</returns>
		public virtual IEntityCollection CreateEntityCollection()
		{
			return new TipoParroquiaCollection();
		}
		
		/// <summary>returns the name of the entity this factory is for, e.g. "EmployeeEntity"</summary>
		public virtual string ForEntityName 
		{ 
			get { return "TipoParroquiaEntity"; }
		}

		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty VwListasEntity objects.</summary>
#if CF
	[SD.LLBLGen.Pro.ORMSupportClasses.Serializable]
#else
	[Serializable]
#endif
	public partial class VwListasEntityFactory : IEntityFactory
	{
		/// <summary>Creates a new, empty VwListasEntity object.</summary>
		/// <returns>A new, empty VwListasEntity object.</returns>
		public virtual IEntity Create()
		{
			IEntity toReturn = new VwListasEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewVwListas
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;

		}
		
		/// <summary>Creates a new VwListasEntity instance but uses a special constructor which will set the Fields object of the new IEntity instance to the passed in fields object. Implement this method to support multi-type in single table inheritance.</summary>
		/// <param name="fields">Populated IEntityFields object for the new IEntity to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields object) IEntity object</returns>
		public virtual IEntity Create(IEntityFields fields)
		{
			IEntity toReturn = Create();
			toReturn.Fields = fields;
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewVwListasUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}

		/// <summary>Creates, using the generated EntityFieldsFactory, the IEntityFields object for the entity to create. This method is used by internal code to create the fields object to store fetched data. 
		/// </summary>
		/// <returns>Empty IEntityFields object.</returns>
		public virtual IEntityFields CreateFields()
		{
			return EntityFieldsFactory.CreateEntityFieldsObject(ORMDiocesis.EntityType.VwListasEntity);
		}
		
		/// <summary>Creates the hierarchy fields for the entity to which this factory belongs.</summary>
		/// <returns>IEntityFields object with the fields of all the entities in teh hierarchy of this entity or the fields of this entity if the entity isn't in a hierarchy.</returns>
		public virtual IEntityFields CreateHierarchyFields()
		{
			return this.CreateFields();
		}
		
		/// <summary>Creates the relations collection to the entity to join all targets so this entity can be fetched. </summary>
		/// <returns>null if the entity isn't in a hierarchy of type TargetPerEntity, otherwise the relations collection needed to join all targets together to fetch all subtypes of this entity and this entity itself</returns>
		public virtual IRelationCollection CreateHierarchyRelations()
		{
			return null;			
		}

		/// <summary>This method retrieves, using the InheritanceInfoprovider, the factory for the entity represented by the values passed in.</summary>
		/// <param name="fieldValues">Field values read from the db, to determine which factory to return, based on the field values passed in.</param>
		/// <param name="entityFieldStartIndexesPerEntity">indexes into values where per entity type their own fields start.</param>
		/// <returns>the factory for the entity which is represented by the values passed in.</returns>
		public virtual IEntityFactory GetEntityFactory(object[] fieldValues, Dictionary<string, int> entityFieldStartIndexesPerEntity)
		{
			return this;
		}
		
		/// <summary>Creates a new entity collection for the entity of this factory.</summary>
		/// <returns>ready to use new entity collection, typed.</returns>
		public virtual IEntityCollection CreateEntityCollection()
		{
			return new VwListasCollection();
		}
		
		/// <summary>returns the name of the entity this factory is for, e.g. "EmployeeEntity"</summary>
		public virtual string ForEntityName 
		{ 
			get { return "VwListasEntity"; }
		}

		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty VwparroquiasEntity objects.</summary>
#if CF
	[SD.LLBLGen.Pro.ORMSupportClasses.Serializable]
#else
	[Serializable]
#endif
	public partial class VwparroquiasEntityFactory : IEntityFactory
	{
		/// <summary>Creates a new, empty VwparroquiasEntity object.</summary>
		/// <returns>A new, empty VwparroquiasEntity object.</returns>
		public virtual IEntity Create()
		{
			IEntity toReturn = new VwparroquiasEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewVwparroquias
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;

		}
		
		/// <summary>Creates a new VwparroquiasEntity instance but uses a special constructor which will set the Fields object of the new IEntity instance to the passed in fields object. Implement this method to support multi-type in single table inheritance.</summary>
		/// <param name="fields">Populated IEntityFields object for the new IEntity to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields object) IEntity object</returns>
		public virtual IEntity Create(IEntityFields fields)
		{
			IEntity toReturn = Create();
			toReturn.Fields = fields;
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewVwparroquiasUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}

		/// <summary>Creates, using the generated EntityFieldsFactory, the IEntityFields object for the entity to create. This method is used by internal code to create the fields object to store fetched data. 
		/// </summary>
		/// <returns>Empty IEntityFields object.</returns>
		public virtual IEntityFields CreateFields()
		{
			return EntityFieldsFactory.CreateEntityFieldsObject(ORMDiocesis.EntityType.VwparroquiasEntity);
		}
		
		/// <summary>Creates the hierarchy fields for the entity to which this factory belongs.</summary>
		/// <returns>IEntityFields object with the fields of all the entities in teh hierarchy of this entity or the fields of this entity if the entity isn't in a hierarchy.</returns>
		public virtual IEntityFields CreateHierarchyFields()
		{
			return this.CreateFields();
		}
		
		/// <summary>Creates the relations collection to the entity to join all targets so this entity can be fetched. </summary>
		/// <returns>null if the entity isn't in a hierarchy of type TargetPerEntity, otherwise the relations collection needed to join all targets together to fetch all subtypes of this entity and this entity itself</returns>
		public virtual IRelationCollection CreateHierarchyRelations()
		{
			return null;			
		}

		/// <summary>This method retrieves, using the InheritanceInfoprovider, the factory for the entity represented by the values passed in.</summary>
		/// <param name="fieldValues">Field values read from the db, to determine which factory to return, based on the field values passed in.</param>
		/// <param name="entityFieldStartIndexesPerEntity">indexes into values where per entity type their own fields start.</param>
		/// <returns>the factory for the entity which is represented by the values passed in.</returns>
		public virtual IEntityFactory GetEntityFactory(object[] fieldValues, Dictionary<string, int> entityFieldStartIndexesPerEntity)
		{
			return this;
		}
		
		/// <summary>Creates a new entity collection for the entity of this factory.</summary>
		/// <returns>ready to use new entity collection, typed.</returns>
		public virtual IEntityCollection CreateEntityCollection()
		{
			return new VwparroquiasCollection();
		}
		
		/// <summary>returns the name of the entity this factory is for, e.g. "EmployeeEntity"</summary>
		public virtual string ForEntityName 
		{ 
			get { return "VwparroquiasEntity"; }
		}

		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty ZonaPastoralEntity objects.</summary>
#if CF
	[SD.LLBLGen.Pro.ORMSupportClasses.Serializable]
#else
	[Serializable]
#endif
	public partial class ZonaPastoralEntityFactory : IEntityFactory
	{
		/// <summary>Creates a new, empty ZonaPastoralEntity object.</summary>
		/// <returns>A new, empty ZonaPastoralEntity object.</returns>
		public virtual IEntity Create()
		{
			IEntity toReturn = new ZonaPastoralEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewZonaPastoral
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;

		}
		
		/// <summary>Creates a new ZonaPastoralEntity instance but uses a special constructor which will set the Fields object of the new IEntity instance to the passed in fields object. Implement this method to support multi-type in single table inheritance.</summary>
		/// <param name="fields">Populated IEntityFields object for the new IEntity to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields object) IEntity object</returns>
		public virtual IEntity Create(IEntityFields fields)
		{
			IEntity toReturn = Create();
			toReturn.Fields = fields;
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewZonaPastoralUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}

		/// <summary>Creates, using the generated EntityFieldsFactory, the IEntityFields object for the entity to create. This method is used by internal code to create the fields object to store fetched data. 
		/// </summary>
		/// <returns>Empty IEntityFields object.</returns>
		public virtual IEntityFields CreateFields()
		{
			return EntityFieldsFactory.CreateEntityFieldsObject(ORMDiocesis.EntityType.ZonaPastoralEntity);
		}
		
		/// <summary>Creates the hierarchy fields for the entity to which this factory belongs.</summary>
		/// <returns>IEntityFields object with the fields of all the entities in teh hierarchy of this entity or the fields of this entity if the entity isn't in a hierarchy.</returns>
		public virtual IEntityFields CreateHierarchyFields()
		{
			return this.CreateFields();
		}
		
		/// <summary>Creates the relations collection to the entity to join all targets so this entity can be fetched. </summary>
		/// <returns>null if the entity isn't in a hierarchy of type TargetPerEntity, otherwise the relations collection needed to join all targets together to fetch all subtypes of this entity and this entity itself</returns>
		public virtual IRelationCollection CreateHierarchyRelations()
		{
			return null;			
		}

		/// <summary>This method retrieves, using the InheritanceInfoprovider, the factory for the entity represented by the values passed in.</summary>
		/// <param name="fieldValues">Field values read from the db, to determine which factory to return, based on the field values passed in.</param>
		/// <param name="entityFieldStartIndexesPerEntity">indexes into values where per entity type their own fields start.</param>
		/// <returns>the factory for the entity which is represented by the values passed in.</returns>
		public virtual IEntityFactory GetEntityFactory(object[] fieldValues, Dictionary<string, int> entityFieldStartIndexesPerEntity)
		{
			return this;
		}
		
		/// <summary>Creates a new entity collection for the entity of this factory.</summary>
		/// <returns>ready to use new entity collection, typed.</returns>
		public virtual IEntityCollection CreateEntityCollection()
		{
			return new ZonaPastoralCollection();
		}
		
		/// <summary>returns the name of the entity this factory is for, e.g. "EmployeeEntity"</summary>
		public virtual string ForEntityName 
		{ 
			get { return "ZonaPastoralEntity"; }
		}

		#region Included Code

		#endregion
	}


	/// <summary>Factory to create new, empty Entity objects based on the entity type specified. Uses entity specific factory objects
	/// </summary>
#if CF
	[SD.LLBLGen.Pro.ORMSupportClasses.Serializable]
#else
	[Serializable]
#endif
	public partial class GeneralEntityFactory
	{
		/// <summary>Creates a new, empty Entity object of the type specified</summary>
		/// <param name="entityTypeToCreate">The entity type to create.</param>
		/// <returns>A new, empty Entity object.</returns>
		public static IEntity Create(EntityType entityTypeToCreate)
		{
			IEntityFactory factoryToUse = null;
			switch(entityTypeToCreate)
			{
				case ORMDiocesis.EntityType.AsistenciaEntity:
					factoryToUse = new AsistenciaEntityFactory();
					break;
				case ORMDiocesis.EntityType.AutorEntity:
					factoryToUse = new AutorEntityFactory();
					break;
				case ORMDiocesis.EntityType.CargoEntity:
					factoryToUse = new CargoEntityFactory();
					break;
				case ORMDiocesis.EntityType.CiudadEntity:
					factoryToUse = new CiudadEntityFactory();
					break;
				case ORMDiocesis.EntityType.CiudadesEntity:
					factoryToUse = new CiudadesEntityFactory();
					break;
				case ORMDiocesis.EntityType.EditorialEntity:
					factoryToUse = new EditorialEntityFactory();
					break;
				case ORMDiocesis.EntityType.EquipoDeTrabajoEntity:
					factoryToUse = new EquipoDeTrabajoEntityFactory();
					break;
				case ORMDiocesis.EntityType.EventoEntity:
					factoryToUse = new EventoEntityFactory();
					break;
				case ORMDiocesis.EntityType.LectoresEntity:
					factoryToUse = new LectoresEntityFactory();
					break;
				case ORMDiocesis.EntityType.LibroEntity:
					factoryToUse = new LibroEntityFactory();
					break;
				case ORMDiocesis.EntityType.LibroEstatusEntity:
					factoryToUse = new LibroEstatusEntityFactory();
					break;
				case ORMDiocesis.EntityType.LibroFormatoEntity:
					factoryToUse = new LibroFormatoEntityFactory();
					break;
				case ORMDiocesis.EntityType.PaisEntity:
					factoryToUse = new PaisEntityFactory();
					break;
				case ORMDiocesis.EntityType.ParrocoEntity:
					factoryToUse = new ParrocoEntityFactory();
					break;
				case ORMDiocesis.EntityType.ParroquiaEntity:
					factoryToUse = new ParroquiaEntityFactory();
					break;
				case ORMDiocesis.EntityType.ParticipanteEntity:
					factoryToUse = new ParticipanteEntityFactory();
					break;
				case ORMDiocesis.EntityType.RamaEntity:
					factoryToUse = new RamaEntityFactory();
					break;
				case ORMDiocesis.EntityType.SeccionEntity:
					factoryToUse = new SeccionEntityFactory();
					break;
				case ORMDiocesis.EntityType.TematicaEntity:
					factoryToUse = new TematicaEntityFactory();
					break;
				case ORMDiocesis.EntityType.TipoParroquiaEntity:
					factoryToUse = new TipoParroquiaEntityFactory();
					break;
				case ORMDiocesis.EntityType.VwListasEntity:
					factoryToUse = new VwListasEntityFactory();
					break;
				case ORMDiocesis.EntityType.VwparroquiasEntity:
					factoryToUse = new VwparroquiasEntityFactory();
					break;
				case ORMDiocesis.EntityType.ZonaPastoralEntity:
					factoryToUse = new ZonaPastoralEntityFactory();
					break;
			}
			return factoryToUse.Create();
		}		
	}
}
