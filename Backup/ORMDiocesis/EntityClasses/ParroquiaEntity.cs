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
	/// Entity class which represents the entity 'Parroquia'. <br/><br/>
	/// 
	/// </summary>
#if CF
	[SD.LLBLGen.Pro.ORMSupportClasses.Serializable]
#else
	[Serializable]
#endif
	public partial class ParroquiaEntity : EntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private ORMDiocesis.CollectionClasses.ParrocoCollection	_parrocos;
		private bool	_alwaysFetchParrocos, _alreadyFetchedParrocos;



		private CiudadEntity _ciudad;
		private bool	_alwaysFetchCiudad, _alreadyFetchedCiudad, _ciudadReturnsNewIfNotFound;
		private TipoParroquiaEntity _tipoParroquia;
		private bool	_alwaysFetchTipoParroquia, _alreadyFetchedTipoParroquia, _tipoParroquiaReturnsNewIfNotFound;
		private ZonaPastoralEntity _zonaPastoral;
		private bool	_alwaysFetchZonaPastoral, _alreadyFetchedZonaPastoral, _zonaPastoralReturnsNewIfNotFound;


		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;
		
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static ParroquiaEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public ParroquiaEntity()
		{
			InitClassEmpty(CreateValidator());
		}


		/// <summary>CTor</summary>
		/// <param name="id">PK value for Parroquia which data should be fetched into this Parroquia object</param>
		public ParroquiaEntity(System.Int32 id)
		{
			InitClassFetch(id, CreateValidator(), null);
		}

		/// <summary>CTor</summary>
		/// <param name="id">PK value for Parroquia which data should be fetched into this Parroquia object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public ParroquiaEntity(System.Int32 id, IPrefetchPath prefetchPathToUse)
		{
			InitClassFetch(id, CreateValidator(), prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="id">PK value for Parroquia which data should be fetched into this Parroquia object</param>
		/// <param name="validator">The custom validator object for this ParroquiaEntity</param>
		public ParroquiaEntity(System.Int32 id, IValidator validator)
		{
			InitClassFetch(id, validator, null);
		}


		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected ParroquiaEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_parrocos = (ORMDiocesis.CollectionClasses.ParrocoCollection)info.GetValue("_parrocos", typeof(ORMDiocesis.CollectionClasses.ParrocoCollection));
			_alwaysFetchParrocos = info.GetBoolean("_alwaysFetchParrocos");
			_alreadyFetchedParrocos = info.GetBoolean("_alreadyFetchedParrocos");



			_ciudad = (CiudadEntity)info.GetValue("_ciudad", typeof(CiudadEntity));
			if(_ciudad!=null)
			{
				_ciudad.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_ciudadReturnsNewIfNotFound = info.GetBoolean("_ciudadReturnsNewIfNotFound");
			_alwaysFetchCiudad = info.GetBoolean("_alwaysFetchCiudad");
			_alreadyFetchedCiudad = info.GetBoolean("_alreadyFetchedCiudad");
			_tipoParroquia = (TipoParroquiaEntity)info.GetValue("_tipoParroquia", typeof(TipoParroquiaEntity));
			if(_tipoParroquia!=null)
			{
				_tipoParroquia.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_tipoParroquiaReturnsNewIfNotFound = info.GetBoolean("_tipoParroquiaReturnsNewIfNotFound");
			_alwaysFetchTipoParroquia = info.GetBoolean("_alwaysFetchTipoParroquia");
			_alreadyFetchedTipoParroquia = info.GetBoolean("_alreadyFetchedTipoParroquia");
			_zonaPastoral = (ZonaPastoralEntity)info.GetValue("_zonaPastoral", typeof(ZonaPastoralEntity));
			if(_zonaPastoral!=null)
			{
				_zonaPastoral.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_zonaPastoralReturnsNewIfNotFound = info.GetBoolean("_zonaPastoralReturnsNewIfNotFound");
			_alwaysFetchZonaPastoral = info.GetBoolean("_alwaysFetchZonaPastoral");
			_alreadyFetchedZonaPastoral = info.GetBoolean("_alreadyFetchedZonaPastoral");

			base.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		
		/// <summary> Will perform post-ReadXml actions</summary>
		protected override void PostReadXmlFixups()
		{
			_alreadyFetchedParrocos = (_parrocos.Count > 0);



			_alreadyFetchedCiudad = (_ciudad != null);
			_alreadyFetchedTipoParroquia = (_tipoParroquia != null);
			_alreadyFetchedZonaPastoral = (_zonaPastoral != null);

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
			info.AddValue("_parrocos", _parrocos);
			info.AddValue("_alwaysFetchParrocos", _alwaysFetchParrocos);
			info.AddValue("_alreadyFetchedParrocos", _alreadyFetchedParrocos);



			info.AddValue("_ciudad", _ciudad);
			info.AddValue("_ciudadReturnsNewIfNotFound", _ciudadReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchCiudad", _alwaysFetchCiudad);
			info.AddValue("_alreadyFetchedCiudad", _alreadyFetchedCiudad);
			info.AddValue("_tipoParroquia", _tipoParroquia);
			info.AddValue("_tipoParroquiaReturnsNewIfNotFound", _tipoParroquiaReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchTipoParroquia", _alwaysFetchTipoParroquia);
			info.AddValue("_alreadyFetchedTipoParroquia", _alreadyFetchedTipoParroquia);
			info.AddValue("_zonaPastoral", _zonaPastoral);
			info.AddValue("_zonaPastoralReturnsNewIfNotFound", _zonaPastoralReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchZonaPastoral", _alwaysFetchZonaPastoral);
			info.AddValue("_alreadyFetchedZonaPastoral", _alreadyFetchedZonaPastoral);

			
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
				case "Ciudad":
					_alreadyFetchedCiudad = true;
					this.Ciudad = (CiudadEntity)entity;
					break;
				case "TipoParroquia":
					_alreadyFetchedTipoParroquia = true;
					this.TipoParroquia = (TipoParroquiaEntity)entity;
					break;
				case "ZonaPastoral":
					_alreadyFetchedZonaPastoral = true;
					this.ZonaPastoral = (ZonaPastoralEntity)entity;
					break;
				case "Parrocos":
					_alreadyFetchedParrocos = true;
					if(entity!=null)
					{
						this.Parrocos.Add((ParrocoEntity)entity);
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
				case "Ciudad":
					SetupSyncCiudad(relatedEntity);
					OnRelatedEntitySet(relatedEntity, fieldName);
					break;
				case "TipoParroquia":
					SetupSyncTipoParroquia(relatedEntity);
					OnRelatedEntitySet(relatedEntity, fieldName);
					break;
				case "ZonaPastoral":
					SetupSyncZonaPastoral(relatedEntity);
					OnRelatedEntitySet(relatedEntity, fieldName);
					break;
				case "Parrocos":
					_parrocos.Add((ParrocoEntity)relatedEntity);
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
				case "Ciudad":
					DesetupSyncCiudad(false, true);
					OnRelatedEntityUnset(relatedEntity, fieldName);
					break;
				case "TipoParroquia":
					DesetupSyncTipoParroquia(false, true);
					OnRelatedEntityUnset(relatedEntity, fieldName);
					break;
				case "ZonaPastoral":
					DesetupSyncZonaPastoral(false, true);
					OnRelatedEntityUnset(relatedEntity, fieldName);
					break;
				case "Parrocos":
					base.PerformRelatedEntityRemoval(_parrocos, relatedEntity, signalRelatedEntityManyToOne);
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
			if(_ciudad!=null)
			{
				toReturn.Add(_ciudad);
			}
			if(_tipoParroquia!=null)
			{
				toReturn.Add(_tipoParroquia);
			}
			if(_zonaPastoral!=null)
			{
				toReturn.Add(_zonaPastoral);
			}


			return toReturn;
		}
		
		/// <summary> Gets a List of all entity collections stored as member variables in this entity. The contents of the ArrayList is
		/// used by the DataAccessAdapter to perform recursive saves. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		public override List<IEntityCollection> GetMemberEntityCollections()
		{
			List<IEntityCollection> toReturn = new List<IEntityCollection>();
			toReturn.Add(_parrocos);


			return toReturn;
		}

		

		

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="id">PK value for Parroquia which data should be fetched into this Parroquia object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 id)
		{
			return FetchUsingPK(id, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="id">PK value for Parroquia which data should be fetched into this Parroquia object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 id, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(id, prefetchPathToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="id">PK value for Parroquia which data should be fetched into this Parroquia object</param>
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
		public bool TestOriginalFieldValueForNull(ParroquiaFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}
		
		/// <summary>Returns true if the current value for the field with the fieldIndex passed in represents null/not defined, false otherwise.
		/// Should not be used for testing if the original value (read from the db) is NULL</summary>
		/// <param name="fieldIndex">Index of the field to test if its currentvalue is null/undefined</param>
		/// <returns>true if the field's value isn't defined yet, false otherwise</returns>
		public bool TestCurrentFieldValueForNull(ParroquiaFieldIndex fieldIndex)
		{
			return base.CheckIfCurrentFieldValueIsNull((int)fieldIndex);
		}



		/// <summary> Retrieves all related entities of type 'ParrocoEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ParrocoEntity'</returns>
		public ORMDiocesis.CollectionClasses.ParrocoCollection GetMultiParrocos(bool forceFetch)
		{
			return GetMultiParrocos(forceFetch, _parrocos.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ParrocoEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'ParrocoEntity'</returns>
		public ORMDiocesis.CollectionClasses.ParrocoCollection GetMultiParrocos(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiParrocos(forceFetch, _parrocos.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'ParrocoEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public ORMDiocesis.CollectionClasses.ParrocoCollection GetMultiParrocos(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiParrocos(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ParrocoEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual ORMDiocesis.CollectionClasses.ParrocoCollection GetMultiParrocos(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedParrocos || forceFetch || _alwaysFetchParrocos) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_parrocos.ParticipatesInTransaction)
					{
						base.Transaction.Add(_parrocos);
					}
				}
				_parrocos.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_parrocos.EntityFactoryToUse = entityFactoryToUse;
				}
				_parrocos.GetMultiManyToOne(this, filter);
				_parrocos.SuppressClearInGetMulti=false;
				_alreadyFetchedParrocos = true;
			}
			return _parrocos;
		}

		/// <summary> Sets the collection parameters for the collection for 'Parrocos'. These settings will be taken into account
		/// when the property Parrocos is requested or GetMultiParrocos is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersParrocos(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_parrocos.SortClauses=sortClauses;
			_parrocos.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}




		/// <summary> Retrieves the related entity of type 'CiudadEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'CiudadEntity' which is related to this entity.</returns>
		public CiudadEntity GetSingleCiudad()
		{
			return GetSingleCiudad(false);
		}

		/// <summary> Retrieves the related entity of type 'CiudadEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'CiudadEntity' which is related to this entity.</returns>
		public virtual CiudadEntity GetSingleCiudad(bool forceFetch)
		{
			if( ( !_alreadyFetchedCiudad || forceFetch || _alwaysFetchCiudad) && !base.IsSerializing && !base.IsDeserializing )			
			{

				CiudadEntity newEntity = new CiudadEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = false;
				if(base.CheckIfLazyLoadingShouldOccur(ParroquiaEntity.Relations.CiudadEntityUsingIdCiudad))
				{
					fetchResult = newEntity.FetchUsingPK(this.IdCiudad);
				}
				if(!_ciudadReturnsNewIfNotFound && !fetchResult)
				{
					this.Ciudad = null;
				}
				else
				{
					if((base.ActiveContext!=null)&&fetchResult)
					{
						newEntity = (CiudadEntity)base.ActiveContext.Get(newEntity);
					}
					this.Ciudad = newEntity;
					_alreadyFetchedCiudad = fetchResult;
				}
				if(base.ParticipatesInTransaction && !fetchResult)
				{
					base.Transaction.Remove(newEntity);
				}
			}
			return _ciudad;
		}

		/// <summary> Retrieves the related entity of type 'TipoParroquiaEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'TipoParroquiaEntity' which is related to this entity.</returns>
		public TipoParroquiaEntity GetSingleTipoParroquia()
		{
			return GetSingleTipoParroquia(false);
		}

		/// <summary> Retrieves the related entity of type 'TipoParroquiaEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'TipoParroquiaEntity' which is related to this entity.</returns>
		public virtual TipoParroquiaEntity GetSingleTipoParroquia(bool forceFetch)
		{
			if( ( !_alreadyFetchedTipoParroquia || forceFetch || _alwaysFetchTipoParroquia) && !base.IsSerializing && !base.IsDeserializing )			
			{

				TipoParroquiaEntity newEntity = new TipoParroquiaEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = false;
				if(base.CheckIfLazyLoadingShouldOccur(ParroquiaEntity.Relations.TipoParroquiaEntityUsingIdTipoParroquia))
				{
					fetchResult = newEntity.FetchUsingPK(this.IdTipoParroquia);
				}
				if(!_tipoParroquiaReturnsNewIfNotFound && !fetchResult)
				{
					this.TipoParroquia = null;
				}
				else
				{
					if((base.ActiveContext!=null)&&fetchResult)
					{
						newEntity = (TipoParroquiaEntity)base.ActiveContext.Get(newEntity);
					}
					this.TipoParroquia = newEntity;
					_alreadyFetchedTipoParroquia = fetchResult;
				}
				if(base.ParticipatesInTransaction && !fetchResult)
				{
					base.Transaction.Remove(newEntity);
				}
			}
			return _tipoParroquia;
		}

		/// <summary> Retrieves the related entity of type 'ZonaPastoralEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'ZonaPastoralEntity' which is related to this entity.</returns>
		public ZonaPastoralEntity GetSingleZonaPastoral()
		{
			return GetSingleZonaPastoral(false);
		}

		/// <summary> Retrieves the related entity of type 'ZonaPastoralEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'ZonaPastoralEntity' which is related to this entity.</returns>
		public virtual ZonaPastoralEntity GetSingleZonaPastoral(bool forceFetch)
		{
			if( ( !_alreadyFetchedZonaPastoral || forceFetch || _alwaysFetchZonaPastoral) && !base.IsSerializing && !base.IsDeserializing )			
			{

				ZonaPastoralEntity newEntity = new ZonaPastoralEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = false;
				if(base.CheckIfLazyLoadingShouldOccur(ParroquiaEntity.Relations.ZonaPastoralEntityUsingIdZonaPastoral))
				{
					fetchResult = newEntity.FetchUsingPK(this.IdZonaPastoral);
				}
				if(!_zonaPastoralReturnsNewIfNotFound && !fetchResult)
				{
					this.ZonaPastoral = null;
				}
				else
				{
					if((base.ActiveContext!=null)&&fetchResult)
					{
						newEntity = (ZonaPastoralEntity)base.ActiveContext.Get(newEntity);
					}
					this.ZonaPastoral = newEntity;
					_alreadyFetchedZonaPastoral = fetchResult;
				}
				if(base.ParticipatesInTransaction && !fetchResult)
				{
					base.Transaction.Remove(newEntity);
				}
			}
			return _zonaPastoral;
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
			if(toReturn && Enum.IsDefined(typeof(ParroquiaFieldIndex), fieldIndex))
			{
				switch((ParroquiaFieldIndex)fieldIndex)
				{
					case ParroquiaFieldIndex.IdTipoParroquia:
						DesetupSyncTipoParroquia(true, false);
						_alreadyFetchedTipoParroquia = false;
						break;
					case ParroquiaFieldIndex.IdZonaPastoral:
						DesetupSyncZonaPastoral(true, false);
						_alreadyFetchedZonaPastoral = false;
						break;
					case ParroquiaFieldIndex.IdCiudad:
						DesetupSyncCiudad(true, false);
						_alreadyFetchedCiudad = false;
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
			ParroquiaDAO dao = (ParroquiaDAO)CreateDAOInstance();
			return dao.AddNew(base.Fields, base.Transaction);
		}
		
		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{
			_parrocos.ActiveContext = base.ActiveContext;



			if(_ciudad!=null)
			{
				_ciudad.ActiveContext = base.ActiveContext;
			}
			if(_tipoParroquia!=null)
			{
				_tipoParroquia.ActiveContext = base.ActiveContext;
			}
			if(_zonaPastoral!=null)
			{
				_zonaPastoral.ActiveContext = base.ActiveContext;
			}


		}


		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity()
		{
			ParroquiaDAO dao = (ParroquiaDAO)CreateDAOInstance();
			return dao.UpdateExisting(base.Fields, base.Transaction);
		}
		
		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			ParroquiaDAO dao = (ParroquiaDAO)CreateDAOInstance();
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
			return EntityFieldsFactory.CreateEntityFieldsObject(ORMDiocesis.EntityType.ParroquiaEntity);
		}


		/// <summary> Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		/// <param name="id">PK value for Parroquia which data should be fetched into this Parroquia object</param>
		/// <param name="validator">The validator object for this ParroquiaEntity</param>
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
			_parrocos = new ORMDiocesis.CollectionClasses.ParrocoCollection(new ParrocoEntityFactory());
			_parrocos.SetContainingEntityInfo(this, "Parroquia");
			_alwaysFetchParrocos = false;
			_alreadyFetchedParrocos = false;



			_ciudad = null;
			_ciudadReturnsNewIfNotFound = true;
			_alwaysFetchCiudad = false;
			_alreadyFetchedCiudad = false;
			_tipoParroquia = null;
			_tipoParroquiaReturnsNewIfNotFound = true;
			_alwaysFetchTipoParroquia = false;
			_alreadyFetchedTipoParroquia = false;
			_zonaPastoral = null;
			_zonaPastoralReturnsNewIfNotFound = true;
			_alwaysFetchZonaPastoral = false;
			_alreadyFetchedZonaPastoral = false;

			
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

			_fieldsCustomProperties.Add("IdTipoParroquia", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Nombre", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("IdZonaPastoral", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("IdCiudad", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Tel1", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Tel2", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Telcural", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Fax", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("EmailComunidad", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Calle", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("NoExt", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Colonia", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Cp", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("ApartadoPostal", fieldHashtable);
		}
		#endregion


		/// <summary> Removes the sync logic for member _ciudad</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncCiudad(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _ciudad, new PropertyChangedEventHandler( OnCiudadPropertyChanged ), "Ciudad", ParroquiaEntity.Relations.CiudadEntityUsingIdCiudad, true, signalRelatedEntity, "Parroquias", resetFKFields, new int[] { (int)ParroquiaFieldIndex.IdCiudad } );		
			_ciudad = null;
		}
		
		/// <summary> setups the sync logic for member _ciudad</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncCiudad(IEntity relatedEntity)
		{
			DesetupSyncCiudad(true, true);
			_ciudad = (CiudadEntity)relatedEntity;
			base.PerformSetupSyncRelatedEntity( _ciudad, new PropertyChangedEventHandler( OnCiudadPropertyChanged ), "Ciudad", ParroquiaEntity.Relations.CiudadEntityUsingIdCiudad, true, ref _alreadyFetchedCiudad, new string[] {  } );
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnCiudadPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _tipoParroquia</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncTipoParroquia(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _tipoParroquia, new PropertyChangedEventHandler( OnTipoParroquiaPropertyChanged ), "TipoParroquia", ParroquiaEntity.Relations.TipoParroquiaEntityUsingIdTipoParroquia, true, signalRelatedEntity, "CatParroquias", resetFKFields, new int[] { (int)ParroquiaFieldIndex.IdTipoParroquia } );		
			_tipoParroquia = null;
		}
		
		/// <summary> setups the sync logic for member _tipoParroquia</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncTipoParroquia(IEntity relatedEntity)
		{
			DesetupSyncTipoParroquia(true, true);
			_tipoParroquia = (TipoParroquiaEntity)relatedEntity;
			base.PerformSetupSyncRelatedEntity( _tipoParroquia, new PropertyChangedEventHandler( OnTipoParroquiaPropertyChanged ), "TipoParroquia", ParroquiaEntity.Relations.TipoParroquiaEntityUsingIdTipoParroquia, true, ref _alreadyFetchedTipoParroquia, new string[] {  } );
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnTipoParroquiaPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _zonaPastoral</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncZonaPastoral(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _zonaPastoral, new PropertyChangedEventHandler( OnZonaPastoralPropertyChanged ), "ZonaPastoral", ParroquiaEntity.Relations.ZonaPastoralEntityUsingIdZonaPastoral, true, signalRelatedEntity, "CatParroquias", resetFKFields, new int[] { (int)ParroquiaFieldIndex.IdZonaPastoral } );		
			_zonaPastoral = null;
		}
		
		/// <summary> setups the sync logic for member _zonaPastoral</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncZonaPastoral(IEntity relatedEntity)
		{
			DesetupSyncZonaPastoral(true, true);
			_zonaPastoral = (ZonaPastoralEntity)relatedEntity;
			base.PerformSetupSyncRelatedEntity( _zonaPastoral, new PropertyChangedEventHandler( OnZonaPastoralPropertyChanged ), "ZonaPastoral", ParroquiaEntity.Relations.ZonaPastoralEntityUsingIdZonaPastoral, true, ref _alreadyFetchedZonaPastoral, new string[] {  } );
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnZonaPastoralPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}


		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="id">PK value for Parroquia which data should be fetched into this Parroquia object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 id, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			try
			{
				OnFetch();
				IDao dao = this.CreateDAOInstance();
				base.Fields[(int)ParroquiaFieldIndex.Id].ForcedCurrentValueWrite(id);
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
			return DAOFactory.CreateParroquiaDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new ParroquiaEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static ParroquiaRelations Relations
		{
			get	{ return new ParroquiaRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}


		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Parroco' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathParrocos
		{
			get
			{
				return new PrefetchPathElement(new ORMDiocesis.CollectionClasses.ParrocoCollection(),
					ParroquiaEntity.Relations.ParrocoEntityUsingIdParroquia, 
					(int)ORMDiocesis.EntityType.ParroquiaEntity, (int)ORMDiocesis.EntityType.ParrocoEntity, 0, null, null, null, "Parrocos", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}




		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Ciudad' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathCiudad
		{
			get
			{
				return new PrefetchPathElement(new ORMDiocesis.CollectionClasses.CiudadCollection(),
					ParroquiaEntity.Relations.CiudadEntityUsingIdCiudad, 
					(int)ORMDiocesis.EntityType.ParroquiaEntity, (int)ORMDiocesis.EntityType.CiudadEntity, 0, null, null, null, "Ciudad", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'TipoParroquia' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathTipoParroquia
		{
			get
			{
				return new PrefetchPathElement(new ORMDiocesis.CollectionClasses.TipoParroquiaCollection(),
					ParroquiaEntity.Relations.TipoParroquiaEntityUsingIdTipoParroquia, 
					(int)ORMDiocesis.EntityType.ParroquiaEntity, (int)ORMDiocesis.EntityType.TipoParroquiaEntity, 0, null, null, null, "TipoParroquia", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ZonaPastoral' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathZonaPastoral
		{
			get
			{
				return new PrefetchPathElement(new ORMDiocesis.CollectionClasses.ZonaPastoralCollection(),
					ParroquiaEntity.Relations.ZonaPastoralEntityUsingIdZonaPastoral, 
					(int)ORMDiocesis.EntityType.ParroquiaEntity, (int)ORMDiocesis.EntityType.ZonaPastoralEntity, 0, null, null, null, "ZonaPastoral", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}


		/// <summary>Returns the full name for this entity, which is important for the DAO to find back persistence info for this entity.</summary>
		[Browsable(false), XmlIgnore]
		public override string LLBLGenProEntityName
		{
			get { return "ParroquiaEntity";}
		}

		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public virtual Dictionary<string, string> CustomPropertiesOfType
		{
			get { return ParroquiaEntity.CustomProperties;}
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
			get { return ParroquiaEntity.FieldsCustomProperties;}
		}

		/// <summary> The Id property of the Entity Parroquia<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "CatParroquias"."Idparroquia"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Int32 Id
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ParroquiaFieldIndex.Id);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.Int32));
				}
				return (System.Int32)valueToReturn;
			}
			set	{ SetNewFieldValue((int)ParroquiaFieldIndex.Id, value); }
		}
		/// <summary> The IdTipoParroquia property of the Entity Parroquia<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "CatParroquias"."Idtipoparr"<br/>
		/// Table field type characteristics (type, precision, scale, length): TinyInt, 3, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Byte IdTipoParroquia
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ParroquiaFieldIndex.IdTipoParroquia);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.Byte));
				}
				return (System.Byte)valueToReturn;
			}
			set	{ SetNewFieldValue((int)ParroquiaFieldIndex.IdTipoParroquia, value); }
		}
		/// <summary> The Nombre property of the Entity Parroquia<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "CatParroquias"."Nomparr"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 255<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Nombre
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ParroquiaFieldIndex.Nombre);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
				return (System.String)valueToReturn;
			}
			set	{ SetNewFieldValue((int)ParroquiaFieldIndex.Nombre, value); }
		}
		/// <summary> The IdZonaPastoral property of the Entity Parroquia<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "CatParroquias"."Idzonapastoral"<br/>
		/// Table field type characteristics (type, precision, scale, length): TinyInt, 3, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Byte IdZonaPastoral
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ParroquiaFieldIndex.IdZonaPastoral);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.Byte));
				}
				return (System.Byte)valueToReturn;
			}
			set	{ SetNewFieldValue((int)ParroquiaFieldIndex.IdZonaPastoral, value); }
		}
		/// <summary> The IdCiudad property of the Entity Parroquia<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "CatParroquias"."Idciudad"<br/>
		/// Table field type characteristics (type, precision, scale, length): TinyInt, 3, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Byte IdCiudad
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ParroquiaFieldIndex.IdCiudad);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.Byte));
				}
				return (System.Byte)valueToReturn;
			}
			set	{ SetNewFieldValue((int)ParroquiaFieldIndex.IdCiudad, value); }
		}
		/// <summary> The Tel1 property of the Entity Parroquia<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "CatParroquias"."Tel1"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 255<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Tel1
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ParroquiaFieldIndex.Tel1);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
				return (System.String)valueToReturn;
			}
			set	{ SetNewFieldValue((int)ParroquiaFieldIndex.Tel1, value); }
		}
		/// <summary> The Tel2 property of the Entity Parroquia<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "CatParroquias"."Tel2"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 255<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Tel2
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ParroquiaFieldIndex.Tel2);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
				return (System.String)valueToReturn;
			}
			set	{ SetNewFieldValue((int)ParroquiaFieldIndex.Tel2, value); }
		}
		/// <summary> The Telcural property of the Entity Parroquia<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "CatParroquias"."Telcural"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 255<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Telcural
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ParroquiaFieldIndex.Telcural);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
				return (System.String)valueToReturn;
			}
			set	{ SetNewFieldValue((int)ParroquiaFieldIndex.Telcural, value); }
		}
		/// <summary> The Fax property of the Entity Parroquia<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "CatParroquias"."Fax"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 255<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Fax
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ParroquiaFieldIndex.Fax);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
				return (System.String)valueToReturn;
			}
			set	{ SetNewFieldValue((int)ParroquiaFieldIndex.Fax, value); }
		}
		/// <summary> The EmailComunidad property of the Entity Parroquia<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "CatParroquias"."EMAIL_COMUNIDAD"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 255<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String EmailComunidad
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ParroquiaFieldIndex.EmailComunidad);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
				return (System.String)valueToReturn;
			}
			set	{ SetNewFieldValue((int)ParroquiaFieldIndex.EmailComunidad, value); }
		}
		/// <summary> The Calle property of the Entity Parroquia<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "CatParroquias"."Call"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 255<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Calle
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ParroquiaFieldIndex.Calle);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
				return (System.String)valueToReturn;
			}
			set	{ SetNewFieldValue((int)ParroquiaFieldIndex.Calle, value); }
		}
		/// <summary> The NoExt property of the Entity Parroquia<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "CatParroquias"."Numext"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 255<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String NoExt
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ParroquiaFieldIndex.NoExt);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
				return (System.String)valueToReturn;
			}
			set	{ SetNewFieldValue((int)ParroquiaFieldIndex.NoExt, value); }
		}
		/// <summary> The Colonia property of the Entity Parroquia<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "CatParroquias"."Col"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 255<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Colonia
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ParroquiaFieldIndex.Colonia);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
				return (System.String)valueToReturn;
			}
			set	{ SetNewFieldValue((int)ParroquiaFieldIndex.Colonia, value); }
		}
		/// <summary> The Cp property of the Entity Parroquia<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "CatParroquias"."CP"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 255<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Cp
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ParroquiaFieldIndex.Cp);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
				return (System.String)valueToReturn;
			}
			set	{ SetNewFieldValue((int)ParroquiaFieldIndex.Cp, value); }
		}
		/// <summary> The ApartadoPostal property of the Entity Parroquia<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "CatParroquias"."APARTADO_POSTAL"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 255<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String ApartadoPostal
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ParroquiaFieldIndex.ApartadoPostal);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
				return (System.String)valueToReturn;
			}
			set	{ SetNewFieldValue((int)ParroquiaFieldIndex.ApartadoPostal, value); }
		}

		/// <summary> Retrieves all related entities of type 'ParrocoEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiParrocos()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual ORMDiocesis.CollectionClasses.ParrocoCollection Parrocos
		{
			get	{ return GetMultiParrocos(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for Parrocos. When set to true, Parrocos is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Parrocos is accessed. You can always execute
		/// a forced fetch by calling GetMultiParrocos(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchParrocos
		{
			get	{ return _alwaysFetchParrocos; }
			set	{ _alwaysFetchParrocos = value; }	
		}


		/// <summary> Gets / sets related entity of type 'CiudadEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleCiudad()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual CiudadEntity Ciudad
		{
			get	{ return GetSingleCiudad(false); }
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncCiudad(value);
				}
				else
				{
					if(value==null)
					{
						if(_ciudad != null)
						{
							_ciudad.UnsetRelatedEntity(this, "Parroquias");
						}
					}
					else
					{
						((IEntity)value).SetRelatedEntity(this, "Parroquias");
					}
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for Ciudad. When set to true, Ciudad is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Ciudad is accessed. You can always execute
		/// a forced fetch by calling GetSingleCiudad(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchCiudad
		{
			get	{ return _alwaysFetchCiudad; }
			set	{ _alwaysFetchCiudad = value; }	
		}
		
		/// <summary> Gets / sets the flag for what to do if the related entity available through the property Ciudad is not found
		/// in the database. When set to true, Ciudad will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool CiudadReturnsNewIfNotFound
		{
			get	{ return _ciudadReturnsNewIfNotFound; }
			set { _ciudadReturnsNewIfNotFound = value; }	
		}
		/// <summary> Gets / sets related entity of type 'TipoParroquiaEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleTipoParroquia()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual TipoParroquiaEntity TipoParroquia
		{
			get	{ return GetSingleTipoParroquia(false); }
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncTipoParroquia(value);
				}
				else
				{
					if(value==null)
					{
						if(_tipoParroquia != null)
						{
							_tipoParroquia.UnsetRelatedEntity(this, "CatParroquias");
						}
					}
					else
					{
						((IEntity)value).SetRelatedEntity(this, "CatParroquias");
					}
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for TipoParroquia. When set to true, TipoParroquia is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time TipoParroquia is accessed. You can always execute
		/// a forced fetch by calling GetSingleTipoParroquia(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchTipoParroquia
		{
			get	{ return _alwaysFetchTipoParroquia; }
			set	{ _alwaysFetchTipoParroquia = value; }	
		}
		
		/// <summary> Gets / sets the flag for what to do if the related entity available through the property TipoParroquia is not found
		/// in the database. When set to true, TipoParroquia will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool TipoParroquiaReturnsNewIfNotFound
		{
			get	{ return _tipoParroquiaReturnsNewIfNotFound; }
			set { _tipoParroquiaReturnsNewIfNotFound = value; }	
		}
		/// <summary> Gets / sets related entity of type 'ZonaPastoralEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleZonaPastoral()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual ZonaPastoralEntity ZonaPastoral
		{
			get	{ return GetSingleZonaPastoral(false); }
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncZonaPastoral(value);
				}
				else
				{
					if(value==null)
					{
						if(_zonaPastoral != null)
						{
							_zonaPastoral.UnsetRelatedEntity(this, "CatParroquias");
						}
					}
					else
					{
						((IEntity)value).SetRelatedEntity(this, "CatParroquias");
					}
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for ZonaPastoral. When set to true, ZonaPastoral is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ZonaPastoral is accessed. You can always execute
		/// a forced fetch by calling GetSingleZonaPastoral(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchZonaPastoral
		{
			get	{ return _alwaysFetchZonaPastoral; }
			set	{ _alwaysFetchZonaPastoral = value; }	
		}
		
		/// <summary> Gets / sets the flag for what to do if the related entity available through the property ZonaPastoral is not found
		/// in the database. When set to true, ZonaPastoral will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool ZonaPastoralReturnsNewIfNotFound
		{
			get	{ return _zonaPastoralReturnsNewIfNotFound; }
			set { _zonaPastoralReturnsNewIfNotFound = value; }	
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
			get { return (int)ORMDiocesis.EntityType.ParroquiaEntity; }
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
