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
	/// Entity class which represents the entity 'Tematica'. <br/><br/>
	/// 
	/// </summary>
#if CF
	[SD.LLBLGen.Pro.ORMSupportClasses.Serializable]
#else
	[Serializable]
#endif
	public partial class TematicaEntity : EntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END
			
	{
		#region Class Member Declarations
		private ORMDiocesis.CollectionClasses.LibroCollection	_libros;
		private bool	_alwaysFetchLibros, _alreadyFetchedLibros;





		private RamaEntity _rama;
		private bool	_alwaysFetchRama, _alreadyFetchedRama, _ramaReturnsNewIfNotFound;
		private SeccionEntity _seccion;
		private bool	_alwaysFetchSeccion, _alreadyFetchedSeccion, _seccionReturnsNewIfNotFound;


		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;
		
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static TematicaEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public TematicaEntity()
		{
			InitClassEmpty(CreateValidator());
		}


		/// <summary>CTor</summary>
		/// <param name="id">PK value for Tematica which data should be fetched into this Tematica object</param>
		public TematicaEntity(System.Int32 id)
		{
			InitClassFetch(id, CreateValidator(), null);
		}

		/// <summary>CTor</summary>
		/// <param name="id">PK value for Tematica which data should be fetched into this Tematica object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public TematicaEntity(System.Int32 id, IPrefetchPath prefetchPathToUse)
		{
			InitClassFetch(id, CreateValidator(), prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="id">PK value for Tematica which data should be fetched into this Tematica object</param>
		/// <param name="validator">The custom validator object for this TematicaEntity</param>
		public TematicaEntity(System.Int32 id, IValidator validator)
		{
			InitClassFetch(id, validator, null);
		}


		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected TematicaEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_libros = (ORMDiocesis.CollectionClasses.LibroCollection)info.GetValue("_libros", typeof(ORMDiocesis.CollectionClasses.LibroCollection));
			_alwaysFetchLibros = info.GetBoolean("_alwaysFetchLibros");
			_alreadyFetchedLibros = info.GetBoolean("_alreadyFetchedLibros");





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

			base.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
			
		}

		
		/// <summary> Will perform post-ReadXml actions</summary>
		protected override void PostReadXmlFixups()
		{
			_alreadyFetchedLibros = (_libros.Count > 0);





			_alreadyFetchedRama = (_rama != null);
			_alreadyFetchedSeccion = (_seccion != null);

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
			info.AddValue("_libros", _libros);
			info.AddValue("_alwaysFetchLibros", _alwaysFetchLibros);
			info.AddValue("_alreadyFetchedLibros", _alreadyFetchedLibros);





			info.AddValue("_rama", _rama);
			info.AddValue("_ramaReturnsNewIfNotFound", _ramaReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchRama", _alwaysFetchRama);
			info.AddValue("_alreadyFetchedRama", _alreadyFetchedRama);
			info.AddValue("_seccion", _seccion);
			info.AddValue("_seccionReturnsNewIfNotFound", _seccionReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchSeccion", _alwaysFetchSeccion);
			info.AddValue("_alreadyFetchedSeccion", _alreadyFetchedSeccion);

			
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
				case "Rama":
					_alreadyFetchedRama = true;
					this.Rama = (RamaEntity)entity;
					break;
				case "Seccion":
					_alreadyFetchedSeccion = true;
					this.Seccion = (SeccionEntity)entity;
					break;
				case "Libros":
					_alreadyFetchedLibros = true;
					if(entity!=null)
					{
						this.Libros.Add((LibroEntity)entity);
					}
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
				case "Rama":
					SetupSyncRama(relatedEntity);
					OnRelatedEntitySet(relatedEntity, fieldName);
					break;
				case "Seccion":
					SetupSyncSeccion(relatedEntity);
					OnRelatedEntitySet(relatedEntity, fieldName);
					break;
				case "Libros":
					_libros.Add((LibroEntity)relatedEntity);
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
				case "Rama":
					DesetupSyncRama(false, true);
					OnRelatedEntityUnset(relatedEntity, fieldName);
					break;
				case "Seccion":
					DesetupSyncSeccion(false, true);
					OnRelatedEntityUnset(relatedEntity, fieldName);
					break;
				case "Libros":
					base.PerformRelatedEntityRemoval(_libros, relatedEntity, signalRelatedEntityManyToOne);
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
			if(_rama!=null)
			{
				toReturn.Add(_rama);
			}
			if(_seccion!=null)
			{
				toReturn.Add(_seccion);
			}


			return toReturn;
		}
		
		/// <summary> Gets a List of all entity collections stored as member variables in this entity. The contents of the ArrayList is
		/// used by the DataAccessAdapter to perform recursive saves. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		public override List<IEntityCollection> GetMemberEntityCollections()
		{
			List<IEntityCollection> toReturn = new List<IEntityCollection>();
			toReturn.Add(_libros);

			return toReturn;
		}

		

		

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="id">PK value for Tematica which data should be fetched into this Tematica object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 id)
		{
			return FetchUsingPK(id, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="id">PK value for Tematica which data should be fetched into this Tematica object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 id, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(id, prefetchPathToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="id">PK value for Tematica which data should be fetched into this Tematica object</param>
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
		public bool TestOriginalFieldValueForNull(TematicaFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}
		
		/// <summary>Returns true if the current value for the field with the fieldIndex passed in represents null/not defined, false otherwise.
		/// Should not be used for testing if the original value (read from the db) is NULL</summary>
		/// <param name="fieldIndex">Index of the field to test if its currentvalue is null/undefined</param>
		/// <returns>true if the field's value isn't defined yet, false otherwise</returns>
		public bool TestCurrentFieldValueForNull(TematicaFieldIndex fieldIndex)
		{
			return base.CheckIfCurrentFieldValueIsNull((int)fieldIndex);
		}



		/// <summary> Retrieves all related entities of type 'LibroEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'LibroEntity'</returns>
		public ORMDiocesis.CollectionClasses.LibroCollection GetMultiLibros(bool forceFetch)
		{
			return GetMultiLibros(forceFetch, _libros.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'LibroEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'LibroEntity'</returns>
		public ORMDiocesis.CollectionClasses.LibroCollection GetMultiLibros(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiLibros(forceFetch, _libros.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'LibroEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public ORMDiocesis.CollectionClasses.LibroCollection GetMultiLibros(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiLibros(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'LibroEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual ORMDiocesis.CollectionClasses.LibroCollection GetMultiLibros(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedLibros || forceFetch || _alwaysFetchLibros) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_libros.ParticipatesInTransaction)
					{
						base.Transaction.Add(_libros);
					}
				}
				_libros.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_libros.EntityFactoryToUse = entityFactoryToUse;
				}
				_libros.GetMultiManyToOne(null, null, null, null, this, null, filter);
				_libros.SuppressClearInGetMulti=false;
				_alreadyFetchedLibros = true;
			}
			return _libros;
		}

		/// <summary> Sets the collection parameters for the collection for 'Libros'. These settings will be taken into account
		/// when the property Libros is requested or GetMultiLibros is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersLibros(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_libros.SortClauses=sortClauses;
			_libros.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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
				if(base.CheckIfLazyLoadingShouldOccur(TematicaEntity.Relations.RamaEntityUsingIdRama))
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
				if(base.CheckIfLazyLoadingShouldOccur(TematicaEntity.Relations.SeccionEntityUsingIdSeccion))
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
			if(toReturn && Enum.IsDefined(typeof(TematicaFieldIndex), fieldIndex))
			{
				switch((TematicaFieldIndex)fieldIndex)
				{
					case TematicaFieldIndex.IdSeccion:
						DesetupSyncSeccion(true, false);
						_alreadyFetchedSeccion = false;
						break;
					case TematicaFieldIndex.IdRama:
						DesetupSyncRama(true, false);
						_alreadyFetchedRama = false;
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
			TematicaDAO dao = (TematicaDAO)CreateDAOInstance();
			return dao.AddNew(base.Fields, base.Transaction);
		}
		
		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{
			_libros.ActiveContext = base.ActiveContext;





			if(_rama!=null)
			{
				_rama.ActiveContext = base.ActiveContext;
			}
			if(_seccion!=null)
			{
				_seccion.ActiveContext = base.ActiveContext;
			}


		}


		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity()
		{
			TematicaDAO dao = (TematicaDAO)CreateDAOInstance();
			return dao.UpdateExisting(base.Fields, base.Transaction);
		}
		
		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			TematicaDAO dao = (TematicaDAO)CreateDAOInstance();
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
			return EntityFieldsFactory.CreateEntityFieldsObject(ORMDiocesis.EntityType.TematicaEntity);
		}


		/// <summary> Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		/// <param name="id">PK value for Tematica which data should be fetched into this Tematica object</param>
		/// <param name="validator">The validator object for this TematicaEntity</param>
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
			_libros = new ORMDiocesis.CollectionClasses.LibroCollection(new LibroEntityFactory());
			_libros.SetContainingEntityInfo(this, "Tematica");
			_alwaysFetchLibros = false;
			_alreadyFetchedLibros = false;





			_rama = null;
			_ramaReturnsNewIfNotFound = true;
			_alwaysFetchRama = false;
			_alreadyFetchedRama = false;
			_seccion = null;
			_seccionReturnsNewIfNotFound = true;
			_alwaysFetchSeccion = false;
			_alreadyFetchedSeccion = false;

			
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

			_fieldsCustomProperties.Add("IdSeccion", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("IdRama", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Id", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Nombre", fieldHashtable);
		}
		#endregion


		/// <summary> Removes the sync logic for member _rama</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncRama(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _rama, new PropertyChangedEventHandler( OnRamaPropertyChanged ), "Rama", TematicaEntity.Relations.RamaEntityUsingIdRama, true, signalRelatedEntity, "Tematicas", resetFKFields, new int[] { (int)TematicaFieldIndex.IdRama } );		
			_rama = null;
		}
		
		/// <summary> setups the sync logic for member _rama</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncRama(IEntity relatedEntity)
		{
			DesetupSyncRama(true, true);
			_rama = (RamaEntity)relatedEntity;
			base.PerformSetupSyncRelatedEntity( _rama, new PropertyChangedEventHandler( OnRamaPropertyChanged ), "Rama", TematicaEntity.Relations.RamaEntityUsingIdRama, true, ref _alreadyFetchedRama, new string[] {  } );
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
			base.PerformDesetupSyncRelatedEntity( _seccion, new PropertyChangedEventHandler( OnSeccionPropertyChanged ), "Seccion", TematicaEntity.Relations.SeccionEntityUsingIdSeccion, true, signalRelatedEntity, "", resetFKFields, new int[] { (int)TematicaFieldIndex.IdSeccion } );		
			_seccion = null;
		}
		
		/// <summary> setups the sync logic for member _seccion</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncSeccion(IEntity relatedEntity)
		{
			DesetupSyncSeccion(true, true);
			_seccion = (SeccionEntity)relatedEntity;
			base.PerformSetupSyncRelatedEntity( _seccion, new PropertyChangedEventHandler( OnSeccionPropertyChanged ), "Seccion", TematicaEntity.Relations.SeccionEntityUsingIdSeccion, true, ref _alreadyFetchedSeccion, new string[] {  } );
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


		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="id">PK value for Tematica which data should be fetched into this Tematica object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 id, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			try
			{
				OnFetch();
				IDao dao = this.CreateDAOInstance();
				base.Fields[(int)TematicaFieldIndex.Id].ForcedCurrentValueWrite(id);
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
			return DAOFactory.CreateTematicaDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new TematicaEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static TematicaRelations Relations
		{
			get	{ return new TematicaRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}


		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Libro' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathLibros
		{
			get
			{
				return new PrefetchPathElement(new ORMDiocesis.CollectionClasses.LibroCollection(),
					TematicaEntity.Relations.LibroEntityUsingIdTematica, 
					(int)ORMDiocesis.EntityType.TematicaEntity, (int)ORMDiocesis.EntityType.LibroEntity, 0, null, null, null, "Libros", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
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
					TematicaEntity.Relations.RamaEntityUsingIdRama, 
					(int)ORMDiocesis.EntityType.TematicaEntity, (int)ORMDiocesis.EntityType.RamaEntity, 0, null, null, null, "Rama", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
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
					TematicaEntity.Relations.SeccionEntityUsingIdSeccion, 
					(int)ORMDiocesis.EntityType.TematicaEntity, (int)ORMDiocesis.EntityType.SeccionEntity, 0, null, null, null, "Seccion", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}


		/// <summary>Returns the full name for this entity, which is important for the DAO to find back persistence info for this entity.</summary>
		[Browsable(false), XmlIgnore]
		public override string LLBLGenProEntityName
		{
			get { return "TematicaEntity";}
		}

		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public virtual Dictionary<string, string> CustomPropertiesOfType
		{
			get { return TematicaEntity.CustomProperties;}
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
			get { return TematicaEntity.FieldsCustomProperties;}
		}

		/// <summary> The IdSeccion property of the Entity Tematica<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "BCatTematicas"."IdSeccion"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 IdSeccion
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)TematicaFieldIndex.IdSeccion);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.Int32));
				}
				return (System.Int32)valueToReturn;
			}
			set	{ SetNewFieldValue((int)TematicaFieldIndex.IdSeccion, value); }
		}
		/// <summary> The IdRama property of the Entity Tematica<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "BCatTematicas"."IdRama"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 IdRama
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)TematicaFieldIndex.IdRama);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.Int32));
				}
				return (System.Int32)valueToReturn;
			}
			set	{ SetNewFieldValue((int)TematicaFieldIndex.IdRama, value); }
		}
		/// <summary> The Id property of the Entity Tematica<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "BCatTematicas"."Id"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Int32 Id
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)TematicaFieldIndex.Id);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.Int32));
				}
				return (System.Int32)valueToReturn;
			}
			set	{ SetNewFieldValue((int)TematicaFieldIndex.Id, value); }
		}
		/// <summary> The Nombre property of the Entity Tematica<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "BCatTematicas"."Nombre"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 20<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Nombre
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)TematicaFieldIndex.Nombre);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
				return (System.String)valueToReturn;
			}
			set	{ SetNewFieldValue((int)TematicaFieldIndex.Nombre, value); }
		}

		/// <summary> Retrieves all related entities of type 'LibroEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiLibros()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual ORMDiocesis.CollectionClasses.LibroCollection Libros
		{
			get	{ return GetMultiLibros(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for Libros. When set to true, Libros is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Libros is accessed. You can always execute
		/// a forced fetch by calling GetMultiLibros(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchLibros
		{
			get	{ return _alwaysFetchLibros; }
			set	{ _alwaysFetchLibros = value; }	
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
							_rama.UnsetRelatedEntity(this, "Tematicas");
						}
					}
					else
					{
						((IEntity)value).SetRelatedEntity(this, "Tematicas");
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
							UnsetRelatedEntity(_seccion, "Seccion");
						}
					}
					else
					{
						SetRelatedEntity((IEntity)value, "Seccion");
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
			get { return (int)ORMDiocesis.EntityType.TematicaEntity; }
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
