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
	/// Entity class which represents the entity 'ZonaPastoral'. <br/><br/>
	/// 
	/// </summary>
#if CF
	[SD.LLBLGen.Pro.ORMSupportClasses.Serializable]
#else
	[Serializable]
#endif
	public partial class ZonaPastoralEntity : EntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END
			
	{
		#region Class Member Declarations
		private ORMDiocesis.CollectionClasses.ParroquiaCollection	_catParroquias;
		private bool	_alwaysFetchCatParroquias, _alreadyFetchedCatParroquias;
		private ORMDiocesis.CollectionClasses.CiudadCollection _catCiudadesCollectionViaCatParroquias;
		private bool	_alwaysFetchCatCiudadesCollectionViaCatParroquias, _alreadyFetchedCatCiudadesCollectionViaCatParroquias;
		private ORMDiocesis.CollectionClasses.TipoParroquiaCollection _catTipoParroquiaCollectionViaCatParroquias;
		private bool	_alwaysFetchCatTipoParroquiaCollectionViaCatParroquias, _alreadyFetchedCatTipoParroquiaCollectionViaCatParroquias;



		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;
		
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static ZonaPastoralEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public ZonaPastoralEntity()
		{
			InitClassEmpty(CreateValidator());
		}


		/// <summary>CTor</summary>
		/// <param name="id">PK value for ZonaPastoral which data should be fetched into this ZonaPastoral object</param>
		public ZonaPastoralEntity(System.Byte id)
		{
			InitClassFetch(id, CreateValidator(), null);
		}

		/// <summary>CTor</summary>
		/// <param name="id">PK value for ZonaPastoral which data should be fetched into this ZonaPastoral object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public ZonaPastoralEntity(System.Byte id, IPrefetchPath prefetchPathToUse)
		{
			InitClassFetch(id, CreateValidator(), prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="id">PK value for ZonaPastoral which data should be fetched into this ZonaPastoral object</param>
		/// <param name="validator">The custom validator object for this ZonaPastoralEntity</param>
		public ZonaPastoralEntity(System.Byte id, IValidator validator)
		{
			InitClassFetch(id, validator, null);
		}


		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected ZonaPastoralEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_catParroquias = (ORMDiocesis.CollectionClasses.ParroquiaCollection)info.GetValue("_catParroquias", typeof(ORMDiocesis.CollectionClasses.ParroquiaCollection));
			_alwaysFetchCatParroquias = info.GetBoolean("_alwaysFetchCatParroquias");
			_alreadyFetchedCatParroquias = info.GetBoolean("_alreadyFetchedCatParroquias");
			_catCiudadesCollectionViaCatParroquias = (ORMDiocesis.CollectionClasses.CiudadCollection)info.GetValue("_catCiudadesCollectionViaCatParroquias", typeof(ORMDiocesis.CollectionClasses.CiudadCollection));
			_alwaysFetchCatCiudadesCollectionViaCatParroquias = info.GetBoolean("_alwaysFetchCatCiudadesCollectionViaCatParroquias");
			_alreadyFetchedCatCiudadesCollectionViaCatParroquias = info.GetBoolean("_alreadyFetchedCatCiudadesCollectionViaCatParroquias");
			_catTipoParroquiaCollectionViaCatParroquias = (ORMDiocesis.CollectionClasses.TipoParroquiaCollection)info.GetValue("_catTipoParroquiaCollectionViaCatParroquias", typeof(ORMDiocesis.CollectionClasses.TipoParroquiaCollection));
			_alwaysFetchCatTipoParroquiaCollectionViaCatParroquias = info.GetBoolean("_alwaysFetchCatTipoParroquiaCollectionViaCatParroquias");
			_alreadyFetchedCatTipoParroquiaCollectionViaCatParroquias = info.GetBoolean("_alreadyFetchedCatTipoParroquiaCollectionViaCatParroquias");


			base.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
			
		}

		
		/// <summary> Will perform post-ReadXml actions</summary>
		protected override void PostReadXmlFixups()
		{
			_alreadyFetchedCatParroquias = (_catParroquias.Count > 0);
			_alreadyFetchedCatCiudadesCollectionViaCatParroquias = (_catCiudadesCollectionViaCatParroquias.Count > 0);
			_alreadyFetchedCatTipoParroquiaCollectionViaCatParroquias = (_catTipoParroquiaCollectionViaCatParroquias.Count > 0);


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
			info.AddValue("_catParroquias", _catParroquias);
			info.AddValue("_alwaysFetchCatParroquias", _alwaysFetchCatParroquias);
			info.AddValue("_alreadyFetchedCatParroquias", _alreadyFetchedCatParroquias);
			info.AddValue("_catCiudadesCollectionViaCatParroquias", _catCiudadesCollectionViaCatParroquias);
			info.AddValue("_alwaysFetchCatCiudadesCollectionViaCatParroquias", _alwaysFetchCatCiudadesCollectionViaCatParroquias);
			info.AddValue("_alreadyFetchedCatCiudadesCollectionViaCatParroquias", _alreadyFetchedCatCiudadesCollectionViaCatParroquias);
			info.AddValue("_catTipoParroquiaCollectionViaCatParroquias", _catTipoParroquiaCollectionViaCatParroquias);
			info.AddValue("_alwaysFetchCatTipoParroquiaCollectionViaCatParroquias", _alwaysFetchCatTipoParroquiaCollectionViaCatParroquias);
			info.AddValue("_alreadyFetchedCatTipoParroquiaCollectionViaCatParroquias", _alreadyFetchedCatTipoParroquiaCollectionViaCatParroquias);


			
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

				case "CatParroquias":
					_alreadyFetchedCatParroquias = true;
					if(entity!=null)
					{
						this.CatParroquias.Add((ParroquiaEntity)entity);
					}
					break;
				case "CatCiudadesCollectionViaCatParroquias":
					_alreadyFetchedCatCiudadesCollectionViaCatParroquias = true;
					if(entity!=null)
					{
						this.CatCiudadesCollectionViaCatParroquias.Add((CiudadEntity)entity);
					}
					break;
				case "CatTipoParroquiaCollectionViaCatParroquias":
					_alreadyFetchedCatTipoParroquiaCollectionViaCatParroquias = true;
					if(entity!=null)
					{
						this.CatTipoParroquiaCollectionViaCatParroquias.Add((TipoParroquiaEntity)entity);
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

				case "CatParroquias":
					_catParroquias.Add((ParroquiaEntity)relatedEntity);
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

				case "CatParroquias":
					base.PerformRelatedEntityRemoval(_catParroquias, relatedEntity, signalRelatedEntityManyToOne);
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



			return toReturn;
		}
		
		/// <summary> Gets a List of all entity collections stored as member variables in this entity. The contents of the ArrayList is
		/// used by the DataAccessAdapter to perform recursive saves. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		public override List<IEntityCollection> GetMemberEntityCollections()
		{
			List<IEntityCollection> toReturn = new List<IEntityCollection>();
			toReturn.Add(_catParroquias);

			return toReturn;
		}

		

		

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="id">PK value for ZonaPastoral which data should be fetched into this ZonaPastoral object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Byte id)
		{
			return FetchUsingPK(id, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="id">PK value for ZonaPastoral which data should be fetched into this ZonaPastoral object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Byte id, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(id, prefetchPathToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="id">PK value for ZonaPastoral which data should be fetched into this ZonaPastoral object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Byte id, IPrefetchPath prefetchPathToUse, Context contextToUse)
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
		public bool TestOriginalFieldValueForNull(ZonaPastoralFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}
		
		/// <summary>Returns true if the current value for the field with the fieldIndex passed in represents null/not defined, false otherwise.
		/// Should not be used for testing if the original value (read from the db) is NULL</summary>
		/// <param name="fieldIndex">Index of the field to test if its currentvalue is null/undefined</param>
		/// <returns>true if the field's value isn't defined yet, false otherwise</returns>
		public bool TestCurrentFieldValueForNull(ZonaPastoralFieldIndex fieldIndex)
		{
			return base.CheckIfCurrentFieldValueIsNull((int)fieldIndex);
		}



		/// <summary> Retrieves all related entities of type 'ParroquiaEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ParroquiaEntity'</returns>
		public ORMDiocesis.CollectionClasses.ParroquiaCollection GetMultiCatParroquias(bool forceFetch)
		{
			return GetMultiCatParroquias(forceFetch, _catParroquias.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ParroquiaEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'ParroquiaEntity'</returns>
		public ORMDiocesis.CollectionClasses.ParroquiaCollection GetMultiCatParroquias(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiCatParroquias(forceFetch, _catParroquias.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'ParroquiaEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public ORMDiocesis.CollectionClasses.ParroquiaCollection GetMultiCatParroquias(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiCatParroquias(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ParroquiaEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual ORMDiocesis.CollectionClasses.ParroquiaCollection GetMultiCatParroquias(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedCatParroquias || forceFetch || _alwaysFetchCatParroquias) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_catParroquias.ParticipatesInTransaction)
					{
						base.Transaction.Add(_catParroquias);
					}
				}
				_catParroquias.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_catParroquias.EntityFactoryToUse = entityFactoryToUse;
				}
				_catParroquias.GetMultiManyToOne(null, null, this, filter);
				_catParroquias.SuppressClearInGetMulti=false;
				_alreadyFetchedCatParroquias = true;
			}
			return _catParroquias;
		}

		/// <summary> Sets the collection parameters for the collection for 'CatParroquias'. These settings will be taken into account
		/// when the property CatParroquias is requested or GetMultiCatParroquias is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersCatParroquias(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_catParroquias.SortClauses=sortClauses;
			_catParroquias.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'CiudadEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'CiudadEntity'</returns>
		public ORMDiocesis.CollectionClasses.CiudadCollection GetMultiCatCiudadesCollectionViaCatParroquias(bool forceFetch)
		{
			return GetMultiCatCiudadesCollectionViaCatParroquias(forceFetch, _catCiudadesCollectionViaCatParroquias.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'CiudadEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public ORMDiocesis.CollectionClasses.CiudadCollection GetMultiCatCiudadesCollectionViaCatParroquias(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedCatCiudadesCollectionViaCatParroquias || forceFetch || _alwaysFetchCatCiudadesCollectionViaCatParroquias) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_catCiudadesCollectionViaCatParroquias.ParticipatesInTransaction)
					{
						base.Transaction.Add(_catCiudadesCollectionViaCatParroquias);
					}
				}
				IRelationCollection relations = new RelationCollection();
				IPredicateExpression filter = new PredicateExpression();
				relations.Add(ZonaPastoralEntity.Relations.ParroquiaEntityUsingIdZonaPastoral, "__ZonaPastoralEntity__", "Parroquia_", JoinHint.None);
				relations.Add(ParroquiaEntity.Relations.CiudadEntityUsingIdCiudad, "Parroquia_", string.Empty, JoinHint.None);
				filter.Add(new FieldCompareValuePredicate(EntityFieldFactory.Create(ZonaPastoralFieldIndex.Id), ComparisonOperator.Equal, this.Id));
				_catCiudadesCollectionViaCatParroquias.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_catCiudadesCollectionViaCatParroquias.EntityFactoryToUse = entityFactoryToUse;
				}
				_catCiudadesCollectionViaCatParroquias.GetMulti(filter, relations);
				_catCiudadesCollectionViaCatParroquias.SuppressClearInGetMulti=false;
				_alreadyFetchedCatCiudadesCollectionViaCatParroquias = true;
			}
			return _catCiudadesCollectionViaCatParroquias;
		}

		/// <summary> Sets the collection parameters for the collection for 'CatCiudadesCollectionViaCatParroquias'. These settings will be taken into account
		/// when the property CatCiudadesCollectionViaCatParroquias is requested or GetMultiCatCiudadesCollectionViaCatParroquias is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersCatCiudadesCollectionViaCatParroquias(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_catCiudadesCollectionViaCatParroquias.SortClauses=sortClauses;
			_catCiudadesCollectionViaCatParroquias.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'TipoParroquiaEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'TipoParroquiaEntity'</returns>
		public ORMDiocesis.CollectionClasses.TipoParroquiaCollection GetMultiCatTipoParroquiaCollectionViaCatParroquias(bool forceFetch)
		{
			return GetMultiCatTipoParroquiaCollectionViaCatParroquias(forceFetch, _catTipoParroquiaCollectionViaCatParroquias.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'TipoParroquiaEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public ORMDiocesis.CollectionClasses.TipoParroquiaCollection GetMultiCatTipoParroquiaCollectionViaCatParroquias(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedCatTipoParroquiaCollectionViaCatParroquias || forceFetch || _alwaysFetchCatTipoParroquiaCollectionViaCatParroquias) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_catTipoParroquiaCollectionViaCatParroquias.ParticipatesInTransaction)
					{
						base.Transaction.Add(_catTipoParroquiaCollectionViaCatParroquias);
					}
				}
				IRelationCollection relations = new RelationCollection();
				IPredicateExpression filter = new PredicateExpression();
				relations.Add(ZonaPastoralEntity.Relations.ParroquiaEntityUsingIdZonaPastoral, "__ZonaPastoralEntity__", "Parroquia_", JoinHint.None);
				relations.Add(ParroquiaEntity.Relations.TipoParroquiaEntityUsingIdTipoParroquia, "Parroquia_", string.Empty, JoinHint.None);
				filter.Add(new FieldCompareValuePredicate(EntityFieldFactory.Create(ZonaPastoralFieldIndex.Id), ComparisonOperator.Equal, this.Id));
				_catTipoParroquiaCollectionViaCatParroquias.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_catTipoParroquiaCollectionViaCatParroquias.EntityFactoryToUse = entityFactoryToUse;
				}
				_catTipoParroquiaCollectionViaCatParroquias.GetMulti(filter, relations);
				_catTipoParroquiaCollectionViaCatParroquias.SuppressClearInGetMulti=false;
				_alreadyFetchedCatTipoParroquiaCollectionViaCatParroquias = true;
			}
			return _catTipoParroquiaCollectionViaCatParroquias;
		}

		/// <summary> Sets the collection parameters for the collection for 'CatTipoParroquiaCollectionViaCatParroquias'. These settings will be taken into account
		/// when the property CatTipoParroquiaCollectionViaCatParroquias is requested or GetMultiCatTipoParroquiaCollectionViaCatParroquias is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersCatTipoParroquiaCollectionViaCatParroquias(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_catTipoParroquiaCollectionViaCatParroquias.SortClauses=sortClauses;
			_catTipoParroquiaCollectionViaCatParroquias.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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
			if(toReturn && Enum.IsDefined(typeof(ZonaPastoralFieldIndex), fieldIndex))
			{
				switch((ZonaPastoralFieldIndex)fieldIndex)
				{
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
			ZonaPastoralDAO dao = (ZonaPastoralDAO)CreateDAOInstance();
			return dao.AddNew(base.Fields, base.Transaction);
		}
		
		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{
			_catParroquias.ActiveContext = base.ActiveContext;
			_catCiudadesCollectionViaCatParroquias.ActiveContext = base.ActiveContext;
			_catTipoParroquiaCollectionViaCatParroquias.ActiveContext = base.ActiveContext;



		}


		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity()
		{
			ZonaPastoralDAO dao = (ZonaPastoralDAO)CreateDAOInstance();
			return dao.UpdateExisting(base.Fields, base.Transaction);
		}
		
		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			ZonaPastoralDAO dao = (ZonaPastoralDAO)CreateDAOInstance();
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
			return EntityFieldsFactory.CreateEntityFieldsObject(ORMDiocesis.EntityType.ZonaPastoralEntity);
		}


		/// <summary> Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		/// <param name="id">PK value for ZonaPastoral which data should be fetched into this ZonaPastoral object</param>
		/// <param name="validator">The validator object for this ZonaPastoralEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		protected virtual void InitClassFetch(System.Byte id, IValidator validator, IPrefetchPath prefetchPathToUse)
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
			_catParroquias = new ORMDiocesis.CollectionClasses.ParroquiaCollection(new ParroquiaEntityFactory());
			_catParroquias.SetContainingEntityInfo(this, "ZonaPastoral");
			_alwaysFetchCatParroquias = false;
			_alreadyFetchedCatParroquias = false;
			_catCiudadesCollectionViaCatParroquias = new ORMDiocesis.CollectionClasses.CiudadCollection(new CiudadEntityFactory());
			_alwaysFetchCatCiudadesCollectionViaCatParroquias = false;
			_alreadyFetchedCatCiudadesCollectionViaCatParroquias = false;
			_catTipoParroquiaCollectionViaCatParroquias = new ORMDiocesis.CollectionClasses.TipoParroquiaCollection(new TipoParroquiaEntityFactory());
			_alwaysFetchCatTipoParroquiaCollectionViaCatParroquias = false;
			_alreadyFetchedCatTipoParroquiaCollectionViaCatParroquias = false;


			
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

			_fieldsCustomProperties.Add("Nombre", fieldHashtable);
		}
		#endregion




		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="id">PK value for ZonaPastoral which data should be fetched into this ZonaPastoral object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Byte id, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			try
			{
				OnFetch();
				IDao dao = this.CreateDAOInstance();
				base.Fields[(int)ZonaPastoralFieldIndex.Id].ForcedCurrentValueWrite(id);
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
			return DAOFactory.CreateZonaPastoralDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new ZonaPastoralEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static ZonaPastoralRelations Relations
		{
			get	{ return new ZonaPastoralRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}


		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Parroquia' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathCatParroquias
		{
			get
			{
				return new PrefetchPathElement(new ORMDiocesis.CollectionClasses.ParroquiaCollection(),
					ZonaPastoralEntity.Relations.ParroquiaEntityUsingIdZonaPastoral, 
					(int)ORMDiocesis.EntityType.ZonaPastoralEntity, (int)ORMDiocesis.EntityType.ParroquiaEntity, 0, null, null, null, "CatParroquias", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Ciudad' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathCatCiudadesCollectionViaCatParroquias
		{
			get
			{
				IRelationCollection relations = new RelationCollection();
				relations.Add(ZonaPastoralEntity.Relations.ParroquiaEntityUsingIdZonaPastoral, "__ZonaPastoralEntity__", string.Empty, JoinHint.None);
				relations.Add(ParroquiaEntity.Relations.CiudadEntityUsingIdCiudad);
				return new PrefetchPathElement(new ORMDiocesis.CollectionClasses.CiudadCollection(),
					ZonaPastoralEntity.Relations.ParroquiaEntityUsingIdZonaPastoral,
					(int)ORMDiocesis.EntityType.ZonaPastoralEntity, (int)ORMDiocesis.EntityType.CiudadEntity, 0, null, null, relations, "CatCiudadesCollectionViaCatParroquias", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'TipoParroquia' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathCatTipoParroquiaCollectionViaCatParroquias
		{
			get
			{
				IRelationCollection relations = new RelationCollection();
				relations.Add(ZonaPastoralEntity.Relations.ParroquiaEntityUsingIdZonaPastoral, "__ZonaPastoralEntity__", string.Empty, JoinHint.None);
				relations.Add(ParroquiaEntity.Relations.TipoParroquiaEntityUsingIdTipoParroquia);
				return new PrefetchPathElement(new ORMDiocesis.CollectionClasses.TipoParroquiaCollection(),
					ZonaPastoralEntity.Relations.ParroquiaEntityUsingIdZonaPastoral,
					(int)ORMDiocesis.EntityType.ZonaPastoralEntity, (int)ORMDiocesis.EntityType.TipoParroquiaEntity, 0, null, null, relations, "CatTipoParroquiaCollectionViaCatParroquias", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}



		/// <summary>Returns the full name for this entity, which is important for the DAO to find back persistence info for this entity.</summary>
		[Browsable(false), XmlIgnore]
		public override string LLBLGenProEntityName
		{
			get { return "ZonaPastoralEntity";}
		}

		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public virtual Dictionary<string, string> CustomPropertiesOfType
		{
			get { return ZonaPastoralEntity.CustomProperties;}
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
			get { return ZonaPastoralEntity.FieldsCustomProperties;}
		}

		/// <summary> The Id property of the Entity ZonaPastoral<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "CatZonaPastoral"."Idzonapastoral"<br/>
		/// Table field type characteristics (type, precision, scale, length): TinyInt, 3, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Byte Id
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ZonaPastoralFieldIndex.Id);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.Byte));
				}
				return (System.Byte)valueToReturn;
			}
			set	{ SetNewFieldValue((int)ZonaPastoralFieldIndex.Id, value); }
		}
		/// <summary> The Nombre property of the Entity ZonaPastoral<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "CatZonaPastoral"."Nomzonapastoral"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 100<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Nombre
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ZonaPastoralFieldIndex.Nombre);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
				return (System.String)valueToReturn;
			}
			set	{ SetNewFieldValue((int)ZonaPastoralFieldIndex.Nombre, value); }
		}

		/// <summary> Retrieves all related entities of type 'ParroquiaEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCatParroquias()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual ORMDiocesis.CollectionClasses.ParroquiaCollection CatParroquias
		{
			get	{ return GetMultiCatParroquias(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for CatParroquias. When set to true, CatParroquias is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time CatParroquias is accessed. You can always execute
		/// a forced fetch by calling GetMultiCatParroquias(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchCatParroquias
		{
			get	{ return _alwaysFetchCatParroquias; }
			set	{ _alwaysFetchCatParroquias = value; }	
		}

		/// <summary> Retrieves all related entities of type 'CiudadEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCatCiudadesCollectionViaCatParroquias()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual ORMDiocesis.CollectionClasses.CiudadCollection CatCiudadesCollectionViaCatParroquias
		{
			get { return GetMultiCatCiudadesCollectionViaCatParroquias(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for CatCiudadesCollectionViaCatParroquias. When set to true, CatCiudadesCollectionViaCatParroquias is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time CatCiudadesCollectionViaCatParroquias is accessed. You can always execute
		/// a forced fetch by calling GetMultiCatCiudadesCollectionViaCatParroquias(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchCatCiudadesCollectionViaCatParroquias
		{
			get	{ return _alwaysFetchCatCiudadesCollectionViaCatParroquias; }
			set	{ _alwaysFetchCatCiudadesCollectionViaCatParroquias = value; }	
		}
		/// <summary> Retrieves all related entities of type 'TipoParroquiaEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCatTipoParroquiaCollectionViaCatParroquias()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual ORMDiocesis.CollectionClasses.TipoParroquiaCollection CatTipoParroquiaCollectionViaCatParroquias
		{
			get { return GetMultiCatTipoParroquiaCollectionViaCatParroquias(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for CatTipoParroquiaCollectionViaCatParroquias. When set to true, CatTipoParroquiaCollectionViaCatParroquias is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time CatTipoParroquiaCollectionViaCatParroquias is accessed. You can always execute
		/// a forced fetch by calling GetMultiCatTipoParroquiaCollectionViaCatParroquias(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchCatTipoParroquiaCollectionViaCatParroquias
		{
			get	{ return _alwaysFetchCatTipoParroquiaCollectionViaCatParroquias; }
			set	{ _alwaysFetchCatTipoParroquiaCollectionViaCatParroquias = value; }	
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
			get { return (int)ORMDiocesis.EntityType.ZonaPastoralEntity; }
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
