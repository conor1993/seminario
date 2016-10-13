///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 2.0.0.0
// Code is generated using templates: SD.TemplateBindings.SharedTemplates.NET20
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.ComponentModel;
using System.Collections.Generic;
#if !CF
using System.Runtime.Serialization;
#endif
using System.Data;
using System.Xml.Serialization;
using ORMDiocesis;
using ORMDiocesis.FactoryClasses;
using ORMDiocesis.DaoClasses;
using ORMDiocesis.RelationClasses;
using ORMDiocesis.HelperClasses;
using ORMDiocesis.CollectionClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace ORMDiocesis.EntityClasses
{
	
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	

	/// <summary>
	/// Entity class which represents the entity 'Libro'. <br/><br/>
	/// 
	/// </summary>
#if CF
	[SD.LLBLGen.Pro.ORMSupportClasses.Serializable]
#else
	[Serializable]
#endif
	public partial class LibroEntity : EntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END
			
	{
		#region Class Member Declarations


		private AutorEntity _autor;
		private bool	_alwaysFetchAutor, _alreadyFetchedAutor, _autorReturnsNewIfNotFound;
		private EditorialEntity _editorial;
		private bool	_alwaysFetchEditorial, _alreadyFetchedEditorial, _editorialReturnsNewIfNotFound;
		private RamaEntity _rama;
		private bool	_alwaysFetchRama, _alreadyFetchedRama, _ramaReturnsNewIfNotFound;
		private SeccionEntity _seccion;
		private bool	_alwaysFetchSeccion, _alreadyFetchedSeccion, _seccionReturnsNewIfNotFound;
		private TematicaEntity _tematica;
		private bool	_alwaysFetchTematica, _alreadyFetchedTematica, _tematicaReturnsNewIfNotFound;
		private PaisEntity _pais;
		private bool	_alwaysFetchPais, _alreadyFetchedPais, _paisReturnsNewIfNotFound;


		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;
		
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static LibroEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public LibroEntity()
		{
			InitClassEmpty(CreateValidator());
		}


		/// <summary>CTor</summary>
		/// <param name="id">PK value for Libro which data should be fetched into this Libro object</param>
		public LibroEntity(System.Int32 id)
		{
			InitClassFetch(id, CreateValidator(), null);
		}

		/// <summary>CTor</summary>
		/// <param name="id">PK value for Libro which data should be fetched into this Libro object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public LibroEntity(System.Int32 id, IPrefetchPath prefetchPathToUse)
		{
			InitClassFetch(id, CreateValidator(), prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="id">PK value for Libro which data should be fetched into this Libro object</param>
		/// <param name="validator">The custom validator object for this LibroEntity</param>
		public LibroEntity(System.Int32 id, IValidator validator)
		{
			InitClassFetch(id, validator, null);
		}


		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected LibroEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{


			_autor = (AutorEntity)info.GetValue("_autor", typeof(AutorEntity));
			if(_autor!=null)
			{
				_autor.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_autorReturnsNewIfNotFound = info.GetBoolean("_autorReturnsNewIfNotFound");
			_alwaysFetchAutor = info.GetBoolean("_alwaysFetchAutor");
			_alreadyFetchedAutor = info.GetBoolean("_alreadyFetchedAutor");
			_editorial = (EditorialEntity)info.GetValue("_editorial", typeof(EditorialEntity));
			if(_editorial!=null)
			{
				_editorial.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_editorialReturnsNewIfNotFound = info.GetBoolean("_editorialReturnsNewIfNotFound");
			_alwaysFetchEditorial = info.GetBoolean("_alwaysFetchEditorial");
			_alreadyFetchedEditorial = info.GetBoolean("_alreadyFetchedEditorial");
			_rama = (RamaEntity)info.GetValue("_rama", typeof(RamaEntity));
			if(_rama!=null)
			{
				_rama.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_ramaReturnsNewIfNotFound = info.GetBoolean("_ramaReturnsNewIfNotFound");
			_alwaysFetchRama = info.GetBoolean("_alwaysFetchRama");
			_alreadyFetchedRama = info.GetBoolean("_alreadyFetchedRama");
			_seccion = (SeccionEntity)info.GetValue("_seccion", typeof(SeccionEntity));
			if(_seccion!=null)
			{
				_seccion.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_seccionReturnsNewIfNotFound = info.GetBoolean("_seccionReturnsNewIfNotFound");
			_alwaysFetchSeccion = info.GetBoolean("_alwaysFetchSeccion");
			_alreadyFetchedSeccion = info.GetBoolean("_alreadyFetchedSeccion");
			_tematica = (TematicaEntity)info.GetValue("_tematica", typeof(TematicaEntity));
			if(_tematica!=null)
			{
				_tematica.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_tematicaReturnsNewIfNotFound = info.GetBoolean("_tematicaReturnsNewIfNotFound");
			_alwaysFetchTematica = info.GetBoolean("_alwaysFetchTematica");
			_alreadyFetchedTematica = info.GetBoolean("_alreadyFetchedTematica");
			_pais = (PaisEntity)info.GetValue("_pais", typeof(PaisEntity));
			if(_pais!=null)
			{
				_pais.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_paisReturnsNewIfNotFound = info.GetBoolean("_paisReturnsNewIfNotFound");
			_alwaysFetchPais = info.GetBoolean("_alwaysFetchPais");
			_alreadyFetchedPais = info.GetBoolean("_alreadyFetchedPais");

			base.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
			
		}

		
		/// <summary> Will perform post-ReadXml actions</summary>
		protected override void PostReadXmlFixups()
		{


			_alreadyFetchedAutor = (_autor != null);
			_alreadyFetchedEditorial = (_editorial != null);
			_alreadyFetchedRama = (_rama != null);
			_alreadyFetchedSeccion = (_seccion != null);
			_alreadyFetchedTematica = (_tematica != null);
			_alreadyFetchedPais = (_pais != null);

		}


		/// <summary> Saves the Entity class to the persistent storage. It updates or inserts the entity, which depends if the entity was originally read from the 
		/// database. If the entity is new, an insert is done and the updateRestriction is ignored. If the entity is not new, the updateRestriction
		/// predicate is used to create an additional where clause (it will be added with AND) for the update query. This predicate can be used for
		/// concurrency checks, like checks on timestamp column values.</summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query. Will be ignored when the entity is new </param>
		/// <param name="recurse">When true, it will save all dirty objects referenced (directly or indirectly) by this entity also.</param>
		/// <returns>true if Save succeeded, false otherwise</returns>
		/// <exception cref="ORMQueryExecutionException">When an exception is caught during the save process. The caught exception is set as the
		/// inner exception. Encapsulation of database-related exceptions is necessary since these exceptions do not have a common exception framework implemented.</exception>
		public override bool Save(IPredicate updateRestriction, bool recurse)
		{
			bool transactionStartedInThisScope = false;
			Transaction transactionManager = null;

			if(recurse || ((this.LLBLGenProIsInHierarchyOfType==InheritanceHierarchyType.TargetPerEntity) && this.LLBLGenProIsSubType))
			{
				if(!base.ParticipatesInTransaction)
				{
					transactionManager = new Transaction(IsolationLevel.ReadCommitted, "SaveRecursively");
					transactionManager.Add(this);
					transactionStartedInThisScope=true;
				}
			}
			try
			{
				bool result = base.Save(updateRestriction, recurse);
				if(transactionStartedInThisScope)
				{
					transactionManager.Commit();
				}
				return result;
			}
			catch
			{
				if(transactionStartedInThisScope)
				{
					transactionManager.Rollback();
				}
				throw;
			}
			finally
			{
				if(transactionStartedInThisScope)
				{
					transactionManager.Dispose();
				}
			}
		}
		


		/// <summary> ISerializable member. Does custom serialization so event handlers do not get serialized.
		/// Serializes members of this entity class and uses the base class' implementation to serialize the rest.</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{


			info.AddValue("_autor", _autor);
			info.AddValue("_autorReturnsNewIfNotFound", _autorReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchAutor", _alwaysFetchAutor);
			info.AddValue("_alreadyFetchedAutor", _alreadyFetchedAutor);
			info.AddValue("_editorial", _editorial);
			info.AddValue("_editorialReturnsNewIfNotFound", _editorialReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchEditorial", _alwaysFetchEditorial);
			info.AddValue("_alreadyFetchedEditorial", _alreadyFetchedEditorial);
			info.AddValue("_rama", _rama);
			info.AddValue("_ramaReturnsNewIfNotFound", _ramaReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchRama", _alwaysFetchRama);
			info.AddValue("_alreadyFetchedRama", _alreadyFetchedRama);
			info.AddValue("_seccion", _seccion);
			info.AddValue("_seccionReturnsNewIfNotFound", _seccionReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchSeccion", _alwaysFetchSeccion);
			info.AddValue("_alreadyFetchedSeccion", _alreadyFetchedSeccion);
			info.AddValue("_tematica", _tematica);
			info.AddValue("_tematicaReturnsNewIfNotFound", _tematicaReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchTematica", _alwaysFetchTematica);
			info.AddValue("_alreadyFetchedTematica", _alreadyFetchedTematica);
			info.AddValue("_pais", _pais);
			info.AddValue("_paisReturnsNewIfNotFound", _paisReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchPais", _alwaysFetchPais);
			info.AddValue("_alreadyFetchedPais", _alreadyFetchedPais);

			
			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			base.GetObjectData(info, context);
		}
		
		/// <summary> Sets the related entity property to the entity specified. If the property is a collection, it will add the entity specified to that collection.</summary>
		/// <param name="propertyName">Name of the property.</param>
		/// <param name="entity">Entity to set as an related entity</param>
		/// <remarks>Used by prefetch path logic.</remarks>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override void SetRelatedEntityProperty(string propertyName, IEntity entity)
		{
			switch(propertyName)
			{
				case "Autor":
					_alreadyFetchedAutor = true;
					this.Autor = (AutorEntity)entity;
					break;
				case "Editorial":
					_alreadyFetchedEditorial = true;
					this.Editorial = (EditorialEntity)entity;
					break;
				case "Rama":
					_alreadyFetchedRama = true;
					this.Rama = (RamaEntity)entity;
					break;
				case "Seccion":
					_alreadyFetchedSeccion = true;
					this.Seccion = (SeccionEntity)entity;
					break;
				case "Tematica":
					_alreadyFetchedTematica = true;
					this.Tematica = (TematicaEntity)entity;
					break;
				case "Pais":
					_alreadyFetchedPais = true;
					this.Pais = (PaisEntity)entity;
					break;



				default:

					break;
			}
		}

		/// <summary> Sets the internal parameter related to the fieldname passed to the instance relatedEntity. </summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		/// <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override void SetRelatedEntity(IEntity relatedEntity, string fieldName)
		{
			switch(fieldName)
			{
				case "Autor":
					SetupSyncAutor(relatedEntity);
					OnRelatedEntitySet(relatedEntity, fieldName);
					break;
				case "Editorial":
					SetupSyncEditorial(relatedEntity);
					OnRelatedEntitySet(relatedEntity, fieldName);
					break;
				case "Rama":
					SetupSyncRama(relatedEntity);
					OnRelatedEntitySet(relatedEntity, fieldName);
					break;
				case "Seccion":
					SetupSyncSeccion(relatedEntity);
					OnRelatedEntitySet(relatedEntity, fieldName);
					break;
				case "Tematica":
					SetupSyncTematica(relatedEntity);
					OnRelatedEntitySet(relatedEntity, fieldName);
					break;
				case "Pais":
					SetupSyncPais(relatedEntity);
					OnRelatedEntitySet(relatedEntity, fieldName);
					break;


				default:

					break;
			}
		}
		
		/// <summary> Unsets the internal parameter related to the fieldname passed to the instance relatedEntity. Reverses the actions taken by SetRelatedEntity() </summary>
		/// <param name="relatedEntity">Instance to unset as the related entity of type entityType</param>
		/// <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		/// <param name="signalRelatedEntityManyToOne">if set to true it will notify the manytoone side, if applicable.</param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override void UnsetRelatedEntity(IEntity relatedEntity, string fieldName, bool signalRelatedEntityManyToOne)
		{
			switch(fieldName)
			{
				case "Autor":
					DesetupSyncAutor(false, true);
					OnRelatedEntityUnset(relatedEntity, fieldName);
					break;
				case "Editorial":
					DesetupSyncEditorial(false, true);
					OnRelatedEntityUnset(relatedEntity, fieldName);
					break;
				case "Rama":
					DesetupSyncRama(false, true);
					OnRelatedEntityUnset(relatedEntity, fieldName);
					break;
				case "Seccion":
					DesetupSyncSeccion(false, true);
					OnRelatedEntityUnset(relatedEntity, fieldName);
					break;
				case "Tematica":
					DesetupSyncTematica(false, true);
					OnRelatedEntityUnset(relatedEntity, fieldName);
					break;
				case "Pais":
					DesetupSyncPais(false, true);
					OnRelatedEntityUnset(relatedEntity, fieldName);
					break;


				default:

					break;
			}
		}

		/// <summary> Gets a collection of related entities referenced by this entity which depend on this entity (this entity is the PK side of their FK fields). These
		/// entities will have to be persisted after this entity during a recursive save.</summary>
		/// <returns>Collection with 0 or more IEntity objects, referenced by this entity</returns>
		public override List<IEntity> GetDependingRelatedEntities()
		{
			List<IEntity> toReturn = new List<IEntity>();


			return toReturn;
		}
		
		/// <summary> Gets a collection of related entities referenced by this entity which this entity depends on (this entity is the FK side of their PK fields). These
		/// entities will have to be persisted before this entity during a recursive save.</summary>
		/// <returns>Collection with 0 or more IEntity objects, referenced by this entity</returns>
		public override List<IEntity> GetDependentRelatedEntities()
		{
			List<IEntity> toReturn = new List<IEntity>();
			if(_autor!=null)
			{
				toReturn.Add(_autor);
			}
			if(_editorial!=null)
			{
				toReturn.Add(_editorial);
			}
			if(_rama!=null)
			{
				toReturn.Add(_rama);
			}
			if(_seccion!=null)
			{
				toReturn.Add(_seccion);
			}
			if(_tematica!=null)
			{
				toReturn.Add(_tematica);
			}
			if(_pais!=null)
			{
				toReturn.Add(_pais);
			}


			return toReturn;
		}
		
		/// <summary> Gets a List of all entity collections stored as member variables in this entity. The contents of the ArrayList is
		/// used by the DataAccessAdapter to perform recursive saves. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		public override List<IEntityCollection> GetMemberEntityCollections()
		{
			List<IEntityCollection> toReturn = new List<IEntityCollection>();


			return toReturn;
		}

		

		

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="id">PK value for Libro which data should be fetched into this Libro object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 id)
		{
			return FetchUsingPK(id, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="id">PK value for Libro which data should be fetched into this Libro object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 id, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(id, prefetchPathToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="id">PK value for Libro which data should be fetched into this Libro object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 id, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return Fetch(id, prefetchPathToUse, contextToUse);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. 
		/// Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.Id, null, null);
		}


		/// <summary> Deletes the Entity from the persistent storage. This method succeeds also when the Entity is not present.</summary>
		/// <param name="deleteRestriction">Predicate expression, meant for concurrency checks in a delete query. Overrules the predicate returned by a set ConcurrencyPredicateFactory object.</param>
		/// <returns>true if Delete succeeded, false otherwise</returns>
		public override bool Delete(IPredicate deleteRestriction)
		{
			bool transactionStartedInThisScope = false;
			Transaction transactionManager = null;
			if((this.LLBLGenProIsInHierarchyOfType==InheritanceHierarchyType.TargetPerEntity) && this.LLBLGenProIsSubType)
			{
				if(!base.ParticipatesInTransaction)
				{
					transactionManager = new Transaction(IsolationLevel.ReadCommitted, "DeleteEntity");
					transactionManager.Add(this);
					transactionStartedInThisScope=true;
				}
			}
			try
			{
				OnValidateEntityBeforeDelete();
				OnDelete();
				IDao dao = CreateDAOInstance();
				bool wasSuccesful = dao.DeleteExisting(base.Fields, base.Transaction, deleteRestriction);
				if(wasSuccesful)
				{
					base.Delete(deleteRestriction);
				}
				else
				{
					if(deleteRestriction!=null)
					{
						throw new ORMConcurrencyException("The delete action of an entity failed, probably due to the set delete restriction provided. The entity which failed is enclosed.", this);
					}
				}
				if(transactionStartedInThisScope)
				{
					transactionManager.Commit();
				}
				return wasSuccesful;
			}
			catch
			{
				if(transactionStartedInThisScope)
				{
					transactionManager.Rollback();
				}
				throw;
			}
			finally
			{
				if(transactionStartedInThisScope)
				{
					transactionManager.Dispose();
				}
				OnDeleteComplete();
			}
		}

		/// <summary> Returns true if the original value for the field with the fieldIndex passed in, read from the persistent storage was NULL, false otherwise.
		/// Should not be used for testing if the current value is NULL, use <see cref="TestCurrentFieldValueForNull"/> for that.</summary>
		/// <param name="fieldIndex">Index of the field to test if that field was NULL in the persistent storage</param>
		/// <returns>true if the field with the passed in index was NULL in the persistent storage, false otherwise</returns>
		public bool TestOriginalFieldValueForNull(LibroFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}
		
		/// <summary>Returns true if the current value for the field with the fieldIndex passed in represents null/not defined, false otherwise.
		/// Should not be used for testing if the original value (read from the db) is NULL</summary>
		/// <param name="fieldIndex">Index of the field to test if its currentvalue is null/undefined</param>
		/// <returns>true if the field's value isn't defined yet, false otherwise</returns>
		public bool TestCurrentFieldValueForNull(LibroFieldIndex fieldIndex)
		{
			return base.CheckIfCurrentFieldValueIsNull((int)fieldIndex);
		}





		/// <summary> Retrieves the related entity of type 'AutorEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'AutorEntity' which is related to this entity.</returns>
		public AutorEntity GetSingleAutor()
		{
			return GetSingleAutor(false);
		}

		/// <summary> Retrieves the related entity of type 'AutorEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'AutorEntity' which is related to this entity.</returns>
		public virtual AutorEntity GetSingleAutor(bool forceFetch)
		{
			if( ( !_alreadyFetchedAutor || forceFetch || _alwaysFetchAutor) && !base.IsSerializing && !base.IsDeserializing )			
			{

				AutorEntity newEntity = new AutorEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = false;
				if(base.CheckIfLazyLoadingShouldOccur(LibroEntity.Relations.AutorEntityUsingIdAutor))
				{
					fetchResult = newEntity.FetchUsingPK(this.IdAutor);
				}
				if(!_autorReturnsNewIfNotFound && !fetchResult)
				{
					this.Autor = null;
				}
				else
				{
					if((base.ActiveContext!=null)&&fetchResult)
					{
						newEntity = (AutorEntity)base.ActiveContext.Get(newEntity);
					}
					this.Autor = newEntity;
					_alreadyFetchedAutor = fetchResult;
				}
				if(base.ParticipatesInTransaction && !fetchResult)
				{
					base.Transaction.Remove(newEntity);
				}
			}
			return _autor;
		}

		/// <summary> Retrieves the related entity of type 'EditorialEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'EditorialEntity' which is related to this entity.</returns>
		public EditorialEntity GetSingleEditorial()
		{
			return GetSingleEditorial(false);
		}

		/// <summary> Retrieves the related entity of type 'EditorialEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'EditorialEntity' which is related to this entity.</returns>
		public virtual EditorialEntity GetSingleEditorial(bool forceFetch)
		{
			if( ( !_alreadyFetchedEditorial || forceFetch || _alwaysFetchEditorial) && !base.IsSerializing && !base.IsDeserializing )			
			{

				EditorialEntity newEntity = new EditorialEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = false;
				if(base.CheckIfLazyLoadingShouldOccur(LibroEntity.Relations.EditorialEntityUsingIdEditorial))
				{
					fetchResult = newEntity.FetchUsingPK(this.IdEditorial);
				}
				if(!_editorialReturnsNewIfNotFound && !fetchResult)
				{
					this.Editorial = null;
				}
				else
				{
					if((base.ActiveContext!=null)&&fetchResult)
					{
						newEntity = (EditorialEntity)base.ActiveContext.Get(newEntity);
					}
					this.Editorial = newEntity;
					_alreadyFetchedEditorial = fetchResult;
				}
				if(base.ParticipatesInTransaction && !fetchResult)
				{
					base.Transaction.Remove(newEntity);
				}
			}
			return _editorial;
		}

		/// <summary> Retrieves the related entity of type 'RamaEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'RamaEntity' which is related to this entity.</returns>
		public RamaEntity GetSingleRama()
		{
			return GetSingleRama(false);
		}

		/// <summary> Retrieves the related entity of type 'RamaEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'RamaEntity' which is related to this entity.</returns>
		public virtual RamaEntity GetSingleRama(bool forceFetch)
		{
			if( ( !_alreadyFetchedRama || forceFetch || _alwaysFetchRama) && !base.IsSerializing && !base.IsDeserializing )			
			{

				RamaEntity newEntity = new RamaEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = false;
				if(base.CheckIfLazyLoadingShouldOccur(LibroEntity.Relations.RamaEntityUsingIdRama))
				{
					fetchResult = newEntity.FetchUsingPK(this.IdRama);
				}
				if(!_ramaReturnsNewIfNotFound && !fetchResult)
				{
					this.Rama = null;
				}
				else
				{
					if((base.ActiveContext!=null)&&fetchResult)
					{
						newEntity = (RamaEntity)base.ActiveContext.Get(newEntity);
					}
					this.Rama = newEntity;
					_alreadyFetchedRama = fetchResult;
				}
				if(base.ParticipatesInTransaction && !fetchResult)
				{
					base.Transaction.Remove(newEntity);
				}
			}
			return _rama;
		}

		/// <summary> Retrieves the related entity of type 'SeccionEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'SeccionEntity' which is related to this entity.</returns>
		public SeccionEntity GetSingleSeccion()
		{
			return GetSingleSeccion(false);
		}

		/// <summary> Retrieves the related entity of type 'SeccionEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'SeccionEntity' which is related to this entity.</returns>
		public virtual SeccionEntity GetSingleSeccion(bool forceFetch)
		{
			if( ( !_alreadyFetchedSeccion || forceFetch || _alwaysFetchSeccion) && !base.IsSerializing && !base.IsDeserializing )			
			{

				SeccionEntity newEntity = new SeccionEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = false;
				if(base.CheckIfLazyLoadingShouldOccur(LibroEntity.Relations.SeccionEntityUsingIdSeccion))
				{
					fetchResult = newEntity.FetchUsingPK(this.IdSeccion);
				}
				if(!_seccionReturnsNewIfNotFound && !fetchResult)
				{
					this.Seccion = null;
				}
				else
				{
					if((base.ActiveContext!=null)&&fetchResult)
					{
						newEntity = (SeccionEntity)base.ActiveContext.Get(newEntity);
					}
					this.Seccion = newEntity;
					_alreadyFetchedSeccion = fetchResult;
				}
				if(base.ParticipatesInTransaction && !fetchResult)
				{
					base.Transaction.Remove(newEntity);
				}
			}
			return _seccion;
		}

		/// <summary> Retrieves the related entity of type 'TematicaEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'TematicaEntity' which is related to this entity.</returns>
		public TematicaEntity GetSingleTematica()
		{
			return GetSingleTematica(false);
		}

		/// <summary> Retrieves the related entity of type 'TematicaEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'TematicaEntity' which is related to this entity.</returns>
		public virtual TematicaEntity GetSingleTematica(bool forceFetch)
		{
			if( ( !_alreadyFetchedTematica || forceFetch || _alwaysFetchTematica) && !base.IsSerializing && !base.IsDeserializing )			
			{

				TematicaEntity newEntity = new TematicaEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = false;
				if(base.CheckIfLazyLoadingShouldOccur(LibroEntity.Relations.TematicaEntityUsingIdTematica))
				{
					fetchResult = newEntity.FetchUsingPK(this.IdTematica);
				}
				if(!_tematicaReturnsNewIfNotFound && !fetchResult)
				{
					this.Tematica = null;
				}
				else
				{
					if((base.ActiveContext!=null)&&fetchResult)
					{
						newEntity = (TematicaEntity)base.ActiveContext.Get(newEntity);
					}
					this.Tematica = newEntity;
					_alreadyFetchedTematica = fetchResult;
				}
				if(base.ParticipatesInTransaction && !fetchResult)
				{
					base.Transaction.Remove(newEntity);
				}
			}
			return _tematica;
		}

		/// <summary> Retrieves the related entity of type 'PaisEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'PaisEntity' which is related to this entity.</returns>
		public PaisEntity GetSinglePais()
		{
			return GetSinglePais(false);
		}

		/// <summary> Retrieves the related entity of type 'PaisEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'PaisEntity' which is related to this entity.</returns>
		public virtual PaisEntity GetSinglePais(bool forceFetch)
		{
			if( ( !_alreadyFetchedPais || forceFetch || _alwaysFetchPais) && !base.IsSerializing && !base.IsDeserializing )			
			{

				PaisEntity newEntity = new PaisEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = false;
				if(base.CheckIfLazyLoadingShouldOccur(LibroEntity.Relations.PaisEntityUsingIdPais))
				{
					fetchResult = newEntity.FetchUsingPK(this.IdPais.GetValueOrDefault());
				}
				if(!_paisReturnsNewIfNotFound && !fetchResult)
				{
					this.Pais = null;
				}
				else
				{
					if((base.ActiveContext!=null)&&fetchResult)
					{
						newEntity = (PaisEntity)base.ActiveContext.Get(newEntity);
					}
					this.Pais = newEntity;
					_alreadyFetchedPais = fetchResult;
				}
				if(base.ParticipatesInTransaction && !fetchResult)
				{
					base.Transaction.Remove(newEntity);
				}
			}
			return _pais;
		}


		
		/// <summary> Sets the field on index fieldIndex to the new value value. Marks also the fields object as dirty. </summary>
		/// <param name="fieldIndex">Index of field to set the new value of</param>
		/// <param name="value">Value to set</param>
		/// <param name="checkForRefetch">If set to true, it will check if this entity is out of sync and will refetch it first if it is. Use true in normal behavior, false for framework specific code.</param>
		/// <returns>true if the value is actually set, false otherwise.</returns>
		/// <remarks>Dereferences a related object in an 1:1/m:1 relation if the field is an FK field and responsible for the reference of that particular related object.</remarks>
		/// <exception cref="ArgumentOutOfRangeException">When fieldIndex is smaller than 0 or bigger than the number of fields in the fields collection.</exception>
		protected override bool SetNewFieldValue(int fieldIndex, object value, bool checkForRefetch)
		{
			bool toReturn = base.SetNewFieldValue (fieldIndex, value, checkForRefetch, false);
			if(toReturn && Enum.IsDefined(typeof(LibroFieldIndex), fieldIndex))
			{
				switch((LibroFieldIndex)fieldIndex)
				{
					case LibroFieldIndex.IdAutor:
						DesetupSyncAutor(true, false);
						_alreadyFetchedAutor = false;
						break;
					case LibroFieldIndex.IdEditorial:
						DesetupSyncEditorial(true, false);
						_alreadyFetchedEditorial = false;
						break;
					case LibroFieldIndex.IdSeccion:
						DesetupSyncSeccion(true, false);
						_alreadyFetchedSeccion = false;
						break;
					case LibroFieldIndex.IdRama:
						DesetupSyncRama(true, false);
						_alreadyFetchedRama = false;
						break;
					case LibroFieldIndex.IdTematica:
						DesetupSyncTematica(true, false);
						_alreadyFetchedTematica = false;
						break;
					case LibroFieldIndex.IdPais:
						DesetupSyncPais(true, false);
						_alreadyFetchedPais = false;
						break;
					default:
						break;
				}
				base.PostFieldValueSetAction(toReturn, this.Fields[fieldIndex].Name);
			}
			return toReturn;
		}

		/// <summary> Performs the insert action of a new Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool InsertEntity()
		{
			LibroDAO dao = (LibroDAO)CreateDAOInstance();
			return dao.AddNew(base.Fields, base.Transaction);
		}
		
		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{


			if(_autor!=null)
			{
				_autor.ActiveContext = base.ActiveContext;
			}
			if(_editorial!=null)
			{
				_editorial.ActiveContext = base.ActiveContext;
			}
			if(_rama!=null)
			{
				_rama.ActiveContext = base.ActiveContext;
			}
			if(_seccion!=null)
			{
				_seccion.ActiveContext = base.ActiveContext;
			}
			if(_tematica!=null)
			{
				_tematica.ActiveContext = base.ActiveContext;
			}
			if(_pais!=null)
			{
				_pais.ActiveContext = base.ActiveContext;
			}


		}


		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity()
		{
			LibroDAO dao = (LibroDAO)CreateDAOInstance();
			return dao.UpdateExisting(base.Fields, base.Transaction);
		}
		
		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			LibroDAO dao = (LibroDAO)CreateDAOInstance();
			return dao.UpdateExisting(base.Fields, base.Transaction, updateRestriction);
		}
	
		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validatorToUse">Validator to use.</param>
		protected virtual void InitClassEmpty(IValidator validatorToUse)
		{
			OnInitializing();
			base.Fields = CreateFields();
			base.IsNew=true;
			base.Validator = validatorToUse;

			InitClassMembers();
			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassEmpty
			// __LLBLGENPRO_USER_CODE_REGION_END
			

			OnInitialized();
		}
		
		/// <summary>Creates entity fields object for this entity. Used in constructor to setup this entity in a polymorphic scenario.</summary>
		protected virtual IEntityFields CreateFields()
		{
			return EntityFieldsFactory.CreateEntityFieldsObject(ORMDiocesis.EntityType.LibroEntity);
		}


		/// <summary> Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		/// <param name="id">PK value for Libro which data should be fetched into this Libro object</param>
		/// <param name="validator">The validator object for this LibroEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		protected virtual void InitClassFetch(System.Int32 id, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			InitClassMembers();

			base.Fields = CreateFields();
			bool wasSuccesful = Fetch(id, prefetchPathToUse, null);
			base.IsNew = !wasSuccesful;
			base.Validator = validator;

			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END
			

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{


			_autor = null;
			_autorReturnsNewIfNotFound = true;
			_alwaysFetchAutor = false;
			_alreadyFetchedAutor = false;
			_editorial = null;
			_editorialReturnsNewIfNotFound = true;
			_alwaysFetchEditorial = false;
			_alreadyFetchedEditorial = false;
			_rama = null;
			_ramaReturnsNewIfNotFound = true;
			_alwaysFetchRama = false;
			_alreadyFetchedRama = false;
			_seccion = null;
			_seccionReturnsNewIfNotFound = true;
			_alwaysFetchSeccion = false;
			_alreadyFetchedSeccion = false;
			_tematica = null;
			_tematicaReturnsNewIfNotFound = true;
			_alwaysFetchTematica = false;
			_alreadyFetchedTematica = false;
			_pais = null;
			_paisReturnsNewIfNotFound = true;
			_alwaysFetchPais = false;
			_alreadyFetchedPais = false;

			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			// __LLBLGENPRO_USER_CODE_REGION_END
			
		}

		#region Custom Property Hashtable Setup
		/// <summary> Initializes the hashtables for the entity type and entity field custom properties. </summary>
		private static void SetupCustomPropertyHashtables()
		{
			_customProperties = new Dictionary<string, string>();
			_fieldsCustomProperties = new Dictionary<string, Dictionary<string, string>>();

			Dictionary<string, string> fieldHashtable = null;
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Id", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Titulo", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("IdAutor", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Edicion", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("IdEditorial", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("IdSeccion", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("IdRama", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("IdTematica", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("IdPais", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Año", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("NumEjemplares", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("ExclusivoConsulta", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Pasillo", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Estante", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Nivel", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Isbn", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Ddc", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Cdu", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Ilustrado", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Busqueda", fieldHashtable);
		}
		#endregion


		/// <summary> Removes the sync logic for member _autor</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncAutor(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _autor, new PropertyChangedEventHandler( OnAutorPropertyChanged ), "Autor", LibroEntity.Relations.AutorEntityUsingIdAutor, true, signalRelatedEntity, "Libros", resetFKFields, new int[] { (int)LibroFieldIndex.IdAutor } );		
			_autor = null;
		}
		
		/// <summary> setups the sync logic for member _autor</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncAutor(IEntity relatedEntity)
		{
			DesetupSyncAutor(true, true);
			_autor = (AutorEntity)relatedEntity;
			base.PerformSetupSyncRelatedEntity( _autor, new PropertyChangedEventHandler( OnAutorPropertyChanged ), "Autor", LibroEntity.Relations.AutorEntityUsingIdAutor, true, ref _alreadyFetchedAutor, new string[] {  } );
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnAutorPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _editorial</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncEditorial(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _editorial, new PropertyChangedEventHandler( OnEditorialPropertyChanged ), "Editorial", LibroEntity.Relations.EditorialEntityUsingIdEditorial, true, signalRelatedEntity, "Libros", resetFKFields, new int[] { (int)LibroFieldIndex.IdEditorial } );		
			_editorial = null;
		}
		
		/// <summary> setups the sync logic for member _editorial</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncEditorial(IEntity relatedEntity)
		{
			DesetupSyncEditorial(true, true);
			_editorial = (EditorialEntity)relatedEntity;
			base.PerformSetupSyncRelatedEntity( _editorial, new PropertyChangedEventHandler( OnEditorialPropertyChanged ), "Editorial", LibroEntity.Relations.EditorialEntityUsingIdEditorial, true, ref _alreadyFetchedEditorial, new string[] {  } );
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnEditorialPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _rama</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncRama(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _rama, new PropertyChangedEventHandler( OnRamaPropertyChanged ), "Rama", LibroEntity.Relations.RamaEntityUsingIdRama, true, signalRelatedEntity, "", resetFKFields, new int[] { (int)LibroFieldIndex.IdRama } );		
			_rama = null;
		}
		
		/// <summary> setups the sync logic for member _rama</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncRama(IEntity relatedEntity)
		{
			DesetupSyncRama(true, true);
			_rama = (RamaEntity)relatedEntity;
			base.PerformSetupSyncRelatedEntity( _rama, new PropertyChangedEventHandler( OnRamaPropertyChanged ), "Rama", LibroEntity.Relations.RamaEntityUsingIdRama, true, ref _alreadyFetchedRama, new string[] {  } );
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnRamaPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _seccion</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncSeccion(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _seccion, new PropertyChangedEventHandler( OnSeccionPropertyChanged ), "Seccion", LibroEntity.Relations.SeccionEntityUsingIdSeccion, true, signalRelatedEntity, "Libros", resetFKFields, new int[] { (int)LibroFieldIndex.IdSeccion } );		
			_seccion = null;
		}
		
		/// <summary> setups the sync logic for member _seccion</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncSeccion(IEntity relatedEntity)
		{
			DesetupSyncSeccion(true, true);
			_seccion = (SeccionEntity)relatedEntity;
			base.PerformSetupSyncRelatedEntity( _seccion, new PropertyChangedEventHandler( OnSeccionPropertyChanged ), "Seccion", LibroEntity.Relations.SeccionEntityUsingIdSeccion, true, ref _alreadyFetchedSeccion, new string[] {  } );
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnSeccionPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _tematica</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncTematica(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _tematica, new PropertyChangedEventHandler( OnTematicaPropertyChanged ), "Tematica", LibroEntity.Relations.TematicaEntityUsingIdTematica, true, signalRelatedEntity, "Libros", resetFKFields, new int[] { (int)LibroFieldIndex.IdTematica } );		
			_tematica = null;
		}
		
		/// <summary> setups the sync logic for member _tematica</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncTematica(IEntity relatedEntity)
		{
			DesetupSyncTematica(true, true);
			_tematica = (TematicaEntity)relatedEntity;
			base.PerformSetupSyncRelatedEntity( _tematica, new PropertyChangedEventHandler( OnTematicaPropertyChanged ), "Tematica", LibroEntity.Relations.TematicaEntityUsingIdTematica, true, ref _alreadyFetchedTematica, new string[] {  } );
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnTematicaPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _pais</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncPais(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _pais, new PropertyChangedEventHandler( OnPaisPropertyChanged ), "Pais", LibroEntity.Relations.PaisEntityUsingIdPais, true, signalRelatedEntity, "Libros", resetFKFields, new int[] { (int)LibroFieldIndex.IdPais } );		
			_pais = null;
		}
		
		/// <summary> setups the sync logic for member _pais</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncPais(IEntity relatedEntity)
		{
			DesetupSyncPais(true, true);
			_pais = (PaisEntity)relatedEntity;
			base.PerformSetupSyncRelatedEntity( _pais, new PropertyChangedEventHandler( OnPaisPropertyChanged ), "Pais", LibroEntity.Relations.PaisEntityUsingIdPais, true, ref _alreadyFetchedPais, new string[] {  } );
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnPaisPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}


		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="id">PK value for Libro which data should be fetched into this Libro object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 id, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			try
			{
				OnFetch();
				IDao dao = this.CreateDAOInstance();
				base.Fields[(int)LibroFieldIndex.Id].ForcedCurrentValueWrite(id);
				dao.FetchExisting(this, base.Transaction, prefetchPathToUse, contextToUse);
				return (base.Fields.State == EntityState.Fetched);
			}
			finally
			{
				OnFetchComplete();
			}
		}


		/// <summary> Creates the DAO instance for this type</summary>
		/// <returns></returns>
		protected override IDao CreateDAOInstance()
		{
			return DAOFactory.CreateLibroDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new LibroEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static LibroRelations Relations
		{
			get	{ return new LibroRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}




		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Autor' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathAutor
		{
			get
			{
				return new PrefetchPathElement(new ORMDiocesis.CollectionClasses.AutorCollection(),
					LibroEntity.Relations.AutorEntityUsingIdAutor, 
					(int)ORMDiocesis.EntityType.LibroEntity, (int)ORMDiocesis.EntityType.AutorEntity, 0, null, null, null, "Autor", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Editorial' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathEditorial
		{
			get
			{
				return new PrefetchPathElement(new ORMDiocesis.CollectionClasses.EditorialCollection(),
					LibroEntity.Relations.EditorialEntityUsingIdEditorial, 
					(int)ORMDiocesis.EntityType.LibroEntity, (int)ORMDiocesis.EntityType.EditorialEntity, 0, null, null, null, "Editorial", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Rama' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathRama
		{
			get
			{
				return new PrefetchPathElement(new ORMDiocesis.CollectionClasses.RamaCollection(),
					LibroEntity.Relations.RamaEntityUsingIdRama, 
					(int)ORMDiocesis.EntityType.LibroEntity, (int)ORMDiocesis.EntityType.RamaEntity, 0, null, null, null, "Rama", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Seccion' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathSeccion
		{
			get
			{
				return new PrefetchPathElement(new ORMDiocesis.CollectionClasses.SeccionCollection(),
					LibroEntity.Relations.SeccionEntityUsingIdSeccion, 
					(int)ORMDiocesis.EntityType.LibroEntity, (int)ORMDiocesis.EntityType.SeccionEntity, 0, null, null, null, "Seccion", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Tematica' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathTematica
		{
			get
			{
				return new PrefetchPathElement(new ORMDiocesis.CollectionClasses.TematicaCollection(),
					LibroEntity.Relations.TematicaEntityUsingIdTematica, 
					(int)ORMDiocesis.EntityType.LibroEntity, (int)ORMDiocesis.EntityType.TematicaEntity, 0, null, null, null, "Tematica", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Pais' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathPais
		{
			get
			{
				return new PrefetchPathElement(new ORMDiocesis.CollectionClasses.PaisCollection(),
					LibroEntity.Relations.PaisEntityUsingIdPais, 
					(int)ORMDiocesis.EntityType.LibroEntity, (int)ORMDiocesis.EntityType.PaisEntity, 0, null, null, null, "Pais", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}


		/// <summary>Returns the full name for this entity, which is important for the DAO to find back persistence info for this entity.</summary>
		[Browsable(false), XmlIgnore]
		public override string LLBLGenProEntityName
		{
			get { return "LibroEntity";}
		}

		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public virtual Dictionary<string, string> CustomPropertiesOfType
		{
			get { return LibroEntity.CustomProperties;}
		}

		/// <summary> The custom properties for the fields of this entity type. The returned Hashtable contains per fieldname a hashtable of name-value pairs. </summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, Dictionary<string, string>> FieldsCustomProperties
		{
			get { return _fieldsCustomProperties;}
		}

		/// <summary> The custom properties for the fields of the type of this entity instance. The returned Hashtable contains per fieldname a hashtable of name-value pairs. </summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public virtual Dictionary<string, Dictionary<string, string>> FieldsCustomPropertiesOfType
		{
			get { return LibroEntity.FieldsCustomProperties;}
		}

		/// <summary> The Id property of the Entity Libro<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "BInvLibros"."Id"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Int32 Id
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)LibroFieldIndex.Id);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.Int32));
				}
				return (System.Int32)valueToReturn;
			}
			set	{ SetNewFieldValue((int)LibroFieldIndex.Id, value); }
		}
		/// <summary> The Titulo property of the Entity Libro<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "BInvLibros"."Titulo"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 250<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Titulo
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)LibroFieldIndex.Titulo);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
				return (System.String)valueToReturn;
			}
			set	{ SetNewFieldValue((int)LibroFieldIndex.Titulo, value); }
		}
		/// <summary> The IdAutor property of the Entity Libro<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "BInvLibros"."IdAutor"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 IdAutor
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)LibroFieldIndex.IdAutor);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.Int32));
				}
				return (System.Int32)valueToReturn;
			}
			set	{ SetNewFieldValue((int)LibroFieldIndex.IdAutor, value); }
		}
		/// <summary> The Edicion property of the Entity Libro<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "BInvLibros"."Edicion"<br/>
		/// Table field type characteristics (type, precision, scale, length): Char, 0, 0, 10<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Edicion
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)LibroFieldIndex.Edicion);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
				return (System.String)valueToReturn;
			}
			set	{ SetNewFieldValue((int)LibroFieldIndex.Edicion, value); }
		}
		/// <summary> The IdEditorial property of the Entity Libro<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "BInvLibros"."IdEditorial"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 IdEditorial
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)LibroFieldIndex.IdEditorial);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.Int32));
				}
				return (System.Int32)valueToReturn;
			}
			set	{ SetNewFieldValue((int)LibroFieldIndex.IdEditorial, value); }
		}
		/// <summary> The IdSeccion property of the Entity Libro<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "BInvLibros"."IdSeccion"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 IdSeccion
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)LibroFieldIndex.IdSeccion);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.Int32));
				}
				return (System.Int32)valueToReturn;
			}
			set	{ SetNewFieldValue((int)LibroFieldIndex.IdSeccion, value); }
		}
		/// <summary> The IdRama property of the Entity Libro<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "BInvLibros"."IdRama"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 IdRama
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)LibroFieldIndex.IdRama);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.Int32));
				}
				return (System.Int32)valueToReturn;
			}
			set	{ SetNewFieldValue((int)LibroFieldIndex.IdRama, value); }
		}
		/// <summary> The IdTematica property of the Entity Libro<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "BInvLibros"."IdTematica"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 IdTematica
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)LibroFieldIndex.IdTematica);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.Int32));
				}
				return (System.Int32)valueToReturn;
			}
			set	{ SetNewFieldValue((int)LibroFieldIndex.IdTematica, value); }
		}
		/// <summary> The IdPais property of the Entity Libro<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "BInvLibros"."IdPais"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> IdPais
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)LibroFieldIndex.IdPais);

				return (Nullable<System.Int32>)valueToReturn;
			}
			set	{ SetNewFieldValue((int)LibroFieldIndex.IdPais, value); }
		}
		/// <summary> The Año property of the Entity Libro<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "BInvLibros"."Año"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> Año
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)LibroFieldIndex.Año);

				return (Nullable<System.Int32>)valueToReturn;
			}
			set	{ SetNewFieldValue((int)LibroFieldIndex.Año, value); }
		}
		/// <summary> The NumEjemplares property of the Entity Libro<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "BInvLibros"."NumEjemplares"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 NumEjemplares
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)LibroFieldIndex.NumEjemplares);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.Int32));
				}
				return (System.Int32)valueToReturn;
			}
			set	{ SetNewFieldValue((int)LibroFieldIndex.NumEjemplares, value); }
		}
		/// <summary> The ExclusivoConsulta property of the Entity Libro<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "BInvLibros"."ExclusivoConsulta"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean ExclusivoConsulta
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)LibroFieldIndex.ExclusivoConsulta);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.Boolean));
				}
				return (System.Boolean)valueToReturn;
			}
			set	{ SetNewFieldValue((int)LibroFieldIndex.ExclusivoConsulta, value); }
		}
		/// <summary> The Pasillo property of the Entity Libro<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "BInvLibros"."Pasillo"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> Pasillo
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)LibroFieldIndex.Pasillo);

				return (Nullable<System.Int32>)valueToReturn;
			}
			set	{ SetNewFieldValue((int)LibroFieldIndex.Pasillo, value); }
		}
		/// <summary> The Estante property of the Entity Libro<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "BInvLibros"."Estante"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> Estante
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)LibroFieldIndex.Estante);

				return (Nullable<System.Int32>)valueToReturn;
			}
			set	{ SetNewFieldValue((int)LibroFieldIndex.Estante, value); }
		}
		/// <summary> The Nivel property of the Entity Libro<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "BInvLibros"."Nivel"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> Nivel
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)LibroFieldIndex.Nivel);

				return (Nullable<System.Int32>)valueToReturn;
			}
			set	{ SetNewFieldValue((int)LibroFieldIndex.Nivel, value); }
		}
		/// <summary> The Isbn property of the Entity Libro<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "BInvLibros"."ISBN"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 20<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Isbn
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)LibroFieldIndex.Isbn);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
				return (System.String)valueToReturn;
			}
			set	{ SetNewFieldValue((int)LibroFieldIndex.Isbn, value); }
		}
		/// <summary> The Ddc property of the Entity Libro<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "BInvLibros"."DDC"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 20<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Ddc
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)LibroFieldIndex.Ddc);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
				return (System.String)valueToReturn;
			}
			set	{ SetNewFieldValue((int)LibroFieldIndex.Ddc, value); }
		}
		/// <summary> The Cdu property of the Entity Libro<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "BInvLibros"."CDU"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 20<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Cdu
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)LibroFieldIndex.Cdu);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
				return (System.String)valueToReturn;
			}
			set	{ SetNewFieldValue((int)LibroFieldIndex.Cdu, value); }
		}
		/// <summary> The Ilustrado property of the Entity Libro<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "BInvLibros"."Ilustrado"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Boolean> Ilustrado
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)LibroFieldIndex.Ilustrado);

				return (Nullable<System.Boolean>)valueToReturn;
			}
			set	{ SetNewFieldValue((int)LibroFieldIndex.Ilustrado, value); }
		}
		/// <summary> The Busqueda property of the Entity Libro<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "BInvLibros"."Busqueda"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 500<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Busqueda
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)LibroFieldIndex.Busqueda);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
				return (System.String)valueToReturn;
			}
			set	{ SetNewFieldValue((int)LibroFieldIndex.Busqueda, value); }
		}



		/// <summary> Gets / sets related entity of type 'AutorEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleAutor()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual AutorEntity Autor
		{
			get	{ return GetSingleAutor(false); }
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncAutor(value);
				}
				else
				{
					if(value==null)
					{
						if(_autor != null)
						{
							_autor.UnsetRelatedEntity(this, "Libros");
						}
					}
					else
					{
						((IEntity)value).SetRelatedEntity(this, "Libros");
					}
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for Autor. When set to true, Autor is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Autor is accessed. You can always execute
		/// a forced fetch by calling GetSingleAutor(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchAutor
		{
			get	{ return _alwaysFetchAutor; }
			set	{ _alwaysFetchAutor = value; }	
		}
		
		/// <summary> Gets / sets the flag for what to do if the related entity available through the property Autor is not found
		/// in the database. When set to true, Autor will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool AutorReturnsNewIfNotFound
		{
			get	{ return _autorReturnsNewIfNotFound; }
			set { _autorReturnsNewIfNotFound = value; }	
		}
		/// <summary> Gets / sets related entity of type 'EditorialEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleEditorial()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual EditorialEntity Editorial
		{
			get	{ return GetSingleEditorial(false); }
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncEditorial(value);
				}
				else
				{
					if(value==null)
					{
						if(_editorial != null)
						{
							_editorial.UnsetRelatedEntity(this, "Libros");
						}
					}
					else
					{
						((IEntity)value).SetRelatedEntity(this, "Libros");
					}
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for Editorial. When set to true, Editorial is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Editorial is accessed. You can always execute
		/// a forced fetch by calling GetSingleEditorial(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchEditorial
		{
			get	{ return _alwaysFetchEditorial; }
			set	{ _alwaysFetchEditorial = value; }	
		}
		
		/// <summary> Gets / sets the flag for what to do if the related entity available through the property Editorial is not found
		/// in the database. When set to true, Editorial will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool EditorialReturnsNewIfNotFound
		{
			get	{ return _editorialReturnsNewIfNotFound; }
			set { _editorialReturnsNewIfNotFound = value; }	
		}
		/// <summary> Gets / sets related entity of type 'RamaEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleRama()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual RamaEntity Rama
		{
			get	{ return GetSingleRama(false); }
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncRama(value);
				}
				else
				{
					if(value==null)
					{
						if(_rama != null)
						{
							UnsetRelatedEntity(_rama, "Rama");
						}
					}
					else
					{
						SetRelatedEntity((IEntity)value, "Rama");
					}
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for Rama. When set to true, Rama is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Rama is accessed. You can always execute
		/// a forced fetch by calling GetSingleRama(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchRama
		{
			get	{ return _alwaysFetchRama; }
			set	{ _alwaysFetchRama = value; }	
		}
		
		/// <summary> Gets / sets the flag for what to do if the related entity available through the property Rama is not found
		/// in the database. When set to true, Rama will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool RamaReturnsNewIfNotFound
		{
			get	{ return _ramaReturnsNewIfNotFound; }
			set { _ramaReturnsNewIfNotFound = value; }	
		}
		/// <summary> Gets / sets related entity of type 'SeccionEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleSeccion()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual SeccionEntity Seccion
		{
			get	{ return GetSingleSeccion(false); }
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncSeccion(value);
				}
				else
				{
					if(value==null)
					{
						if(_seccion != null)
						{
							_seccion.UnsetRelatedEntity(this, "Libros");
						}
					}
					else
					{
						((IEntity)value).SetRelatedEntity(this, "Libros");
					}
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for Seccion. When set to true, Seccion is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Seccion is accessed. You can always execute
		/// a forced fetch by calling GetSingleSeccion(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchSeccion
		{
			get	{ return _alwaysFetchSeccion; }
			set	{ _alwaysFetchSeccion = value; }	
		}
		
		/// <summary> Gets / sets the flag for what to do if the related entity available through the property Seccion is not found
		/// in the database. When set to true, Seccion will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool SeccionReturnsNewIfNotFound
		{
			get	{ return _seccionReturnsNewIfNotFound; }
			set { _seccionReturnsNewIfNotFound = value; }	
		}
		/// <summary> Gets / sets related entity of type 'TematicaEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleTematica()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual TematicaEntity Tematica
		{
			get	{ return GetSingleTematica(false); }
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncTematica(value);
				}
				else
				{
					if(value==null)
					{
						if(_tematica != null)
						{
							_tematica.UnsetRelatedEntity(this, "Libros");
						}
					}
					else
					{
						((IEntity)value).SetRelatedEntity(this, "Libros");
					}
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for Tematica. When set to true, Tematica is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Tematica is accessed. You can always execute
		/// a forced fetch by calling GetSingleTematica(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchTematica
		{
			get	{ return _alwaysFetchTematica; }
			set	{ _alwaysFetchTematica = value; }	
		}
		
		/// <summary> Gets / sets the flag for what to do if the related entity available through the property Tematica is not found
		/// in the database. When set to true, Tematica will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool TematicaReturnsNewIfNotFound
		{
			get	{ return _tematicaReturnsNewIfNotFound; }
			set { _tematicaReturnsNewIfNotFound = value; }	
		}
		/// <summary> Gets / sets related entity of type 'PaisEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSinglePais()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual PaisEntity Pais
		{
			get	{ return GetSinglePais(false); }
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncPais(value);
				}
				else
				{
					if(value==null)
					{
						if(_pais != null)
						{
							_pais.UnsetRelatedEntity(this, "Libros");
						}
					}
					else
					{
						((IEntity)value).SetRelatedEntity(this, "Libros");
					}
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for Pais. When set to true, Pais is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Pais is accessed. You can always execute
		/// a forced fetch by calling GetSinglePais(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchPais
		{
			get	{ return _alwaysFetchPais; }
			set	{ _alwaysFetchPais = value; }	
		}
		
		/// <summary> Gets / sets the flag for what to do if the related entity available through the property Pais is not found
		/// in the database. When set to true, Pais will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool PaisReturnsNewIfNotFound
		{
			get	{ return _paisReturnsNewIfNotFound; }
			set { _paisReturnsNewIfNotFound = value; }	
		}



		/// <summary> Gets or sets a value indicating whether this entity is a subtype</summary>
		protected override bool LLBLGenProIsSubType
		{
			get { return false;}
		}

		/// <summary> Gets the type of the hierarchy this entity is in. </summary>
		[System.ComponentModel.Browsable(false), XmlIgnore]
		protected override InheritanceHierarchyType LLBLGenProIsInHierarchyOfType
		{
			get { return InheritanceHierarchyType.None;}
		}
		
		/// <summary>Returns the EntityType enum value for this entity.</summary>
		[Browsable(false), XmlIgnore]
		public override int LLBLGenProEntityTypeValue 
		{ 
			get { return (int)ORMDiocesis.EntityType.LibroEntity; }
		}
		#endregion


		#region Custom Entity code
		
		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END
		
		#endregion

		#region Included code

		#endregion
	}
}
