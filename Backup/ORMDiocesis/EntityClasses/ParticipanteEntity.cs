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
	/// Entity class which represents the entity 'Participante'. <br/><br/>
	/// 
	/// </summary>
#if CF
	[SD.LLBLGen.Pro.ORMSupportClasses.Serializable]
#else
	[Serializable]
#endif
	public partial class ParticipanteEntity : EntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private ORMDiocesis.CollectionClasses.AsistenciaCollection	_asistencias;
		private bool	_alwaysFetchAsistencias, _alreadyFetchedAsistencias;
		private ORMDiocesis.CollectionClasses.EventoCollection _eventosQueAsistio;
		private bool	_alwaysFetchEventosQueAsistio, _alreadyFetchedEventosQueAsistio;
		private ORMDiocesis.CollectionClasses.ParrocoCollection _parrocosQueLoRecomiendan;
		private bool	_alwaysFetchParrocosQueLoRecomiendan, _alreadyFetchedParrocosQueLoRecomiendan;
		private ORMDiocesis.CollectionClasses.ParroquiaCollection _parroquiasQueLoEnvian;
		private bool	_alwaysFetchParroquiasQueLoEnvian, _alreadyFetchedParroquiasQueLoEnvian;



		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;
		
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static ParticipanteEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public ParticipanteEntity()
		{
			InitClassEmpty(CreateValidator());
		}


		/// <summary>CTor</summary>
		/// <param name="id">PK value for Participante which data should be fetched into this Participante object</param>
		public ParticipanteEntity(System.Int32 id)
		{
			InitClassFetch(id, CreateValidator(), null);
		}

		/// <summary>CTor</summary>
		/// <param name="id">PK value for Participante which data should be fetched into this Participante object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public ParticipanteEntity(System.Int32 id, IPrefetchPath prefetchPathToUse)
		{
			InitClassFetch(id, CreateValidator(), prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="id">PK value for Participante which data should be fetched into this Participante object</param>
		/// <param name="validator">The custom validator object for this ParticipanteEntity</param>
		public ParticipanteEntity(System.Int32 id, IValidator validator)
		{
			InitClassFetch(id, validator, null);
		}


		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected ParticipanteEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_asistencias = (ORMDiocesis.CollectionClasses.AsistenciaCollection)info.GetValue("_asistencias", typeof(ORMDiocesis.CollectionClasses.AsistenciaCollection));
			_alwaysFetchAsistencias = info.GetBoolean("_alwaysFetchAsistencias");
			_alreadyFetchedAsistencias = info.GetBoolean("_alreadyFetchedAsistencias");
			_eventosQueAsistio = (ORMDiocesis.CollectionClasses.EventoCollection)info.GetValue("_eventosQueAsistio", typeof(ORMDiocesis.CollectionClasses.EventoCollection));
			_alwaysFetchEventosQueAsistio = info.GetBoolean("_alwaysFetchEventosQueAsistio");
			_alreadyFetchedEventosQueAsistio = info.GetBoolean("_alreadyFetchedEventosQueAsistio");
			_parrocosQueLoRecomiendan = (ORMDiocesis.CollectionClasses.ParrocoCollection)info.GetValue("_parrocosQueLoRecomiendan", typeof(ORMDiocesis.CollectionClasses.ParrocoCollection));
			_alwaysFetchParrocosQueLoRecomiendan = info.GetBoolean("_alwaysFetchParrocosQueLoRecomiendan");
			_alreadyFetchedParrocosQueLoRecomiendan = info.GetBoolean("_alreadyFetchedParrocosQueLoRecomiendan");
			_parroquiasQueLoEnvian = (ORMDiocesis.CollectionClasses.ParroquiaCollection)info.GetValue("_parroquiasQueLoEnvian", typeof(ORMDiocesis.CollectionClasses.ParroquiaCollection));
			_alwaysFetchParroquiasQueLoEnvian = info.GetBoolean("_alwaysFetchParroquiasQueLoEnvian");
			_alreadyFetchedParroquiasQueLoEnvian = info.GetBoolean("_alreadyFetchedParroquiasQueLoEnvian");


			base.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		
		/// <summary> Will perform post-ReadXml actions</summary>
		protected override void PostReadXmlFixups()
		{
			_alreadyFetchedAsistencias = (_asistencias.Count > 0);
			_alreadyFetchedEventosQueAsistio = (_eventosQueAsistio.Count > 0);
			_alreadyFetchedParrocosQueLoRecomiendan = (_parrocosQueLoRecomiendan.Count > 0);
			_alreadyFetchedParroquiasQueLoEnvian = (_parroquiasQueLoEnvian.Count > 0);


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
			info.AddValue("_asistencias", _asistencias);
			info.AddValue("_alwaysFetchAsistencias", _alwaysFetchAsistencias);
			info.AddValue("_alreadyFetchedAsistencias", _alreadyFetchedAsistencias);
			info.AddValue("_eventosQueAsistio", _eventosQueAsistio);
			info.AddValue("_alwaysFetchEventosQueAsistio", _alwaysFetchEventosQueAsistio);
			info.AddValue("_alreadyFetchedEventosQueAsistio", _alreadyFetchedEventosQueAsistio);
			info.AddValue("_parrocosQueLoRecomiendan", _parrocosQueLoRecomiendan);
			info.AddValue("_alwaysFetchParrocosQueLoRecomiendan", _alwaysFetchParrocosQueLoRecomiendan);
			info.AddValue("_alreadyFetchedParrocosQueLoRecomiendan", _alreadyFetchedParrocosQueLoRecomiendan);
			info.AddValue("_parroquiasQueLoEnvian", _parroquiasQueLoEnvian);
			info.AddValue("_alwaysFetchParroquiasQueLoEnvian", _alwaysFetchParroquiasQueLoEnvian);
			info.AddValue("_alreadyFetchedParroquiasQueLoEnvian", _alreadyFetchedParroquiasQueLoEnvian);


			
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

				case "Asistencias":
					_alreadyFetchedAsistencias = true;
					if(entity!=null)
					{
						this.Asistencias.Add((AsistenciaEntity)entity);
					}
					break;
				case "EventosQueAsistio":
					_alreadyFetchedEventosQueAsistio = true;
					if(entity!=null)
					{
						this.EventosQueAsistio.Add((EventoEntity)entity);
					}
					break;
				case "ParrocosQueLoRecomiendan":
					_alreadyFetchedParrocosQueLoRecomiendan = true;
					if(entity!=null)
					{
						this.ParrocosQueLoRecomiendan.Add((ParrocoEntity)entity);
					}
					break;
				case "ParroquiasQueLoEnvian":
					_alreadyFetchedParroquiasQueLoEnvian = true;
					if(entity!=null)
					{
						this.ParroquiasQueLoEnvian.Add((ParroquiaEntity)entity);
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

				case "Asistencias":
					_asistencias.Add((AsistenciaEntity)relatedEntity);
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

				case "Asistencias":
					base.PerformRelatedEntityRemoval(_asistencias, relatedEntity, signalRelatedEntityManyToOne);
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
			toReturn.Add(_asistencias);

			return toReturn;
		}

		

		

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="id">PK value for Participante which data should be fetched into this Participante object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 id)
		{
			return FetchUsingPK(id, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="id">PK value for Participante which data should be fetched into this Participante object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 id, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(id, prefetchPathToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="id">PK value for Participante which data should be fetched into this Participante object</param>
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
		public bool TestOriginalFieldValueForNull(ParticipanteFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}
		
		/// <summary>Returns true if the current value for the field with the fieldIndex passed in represents null/not defined, false otherwise.
		/// Should not be used for testing if the original value (read from the db) is NULL</summary>
		/// <param name="fieldIndex">Index of the field to test if its currentvalue is null/undefined</param>
		/// <returns>true if the field's value isn't defined yet, false otherwise</returns>
		public bool TestCurrentFieldValueForNull(ParticipanteFieldIndex fieldIndex)
		{
			return base.CheckIfCurrentFieldValueIsNull((int)fieldIndex);
		}



		/// <summary> Retrieves all related entities of type 'AsistenciaEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'AsistenciaEntity'</returns>
		public ORMDiocesis.CollectionClasses.AsistenciaCollection GetMultiAsistencias(bool forceFetch)
		{
			return GetMultiAsistencias(forceFetch, _asistencias.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'AsistenciaEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'AsistenciaEntity'</returns>
		public ORMDiocesis.CollectionClasses.AsistenciaCollection GetMultiAsistencias(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiAsistencias(forceFetch, _asistencias.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'AsistenciaEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public ORMDiocesis.CollectionClasses.AsistenciaCollection GetMultiAsistencias(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiAsistencias(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'AsistenciaEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual ORMDiocesis.CollectionClasses.AsistenciaCollection GetMultiAsistencias(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedAsistencias || forceFetch || _alwaysFetchAsistencias) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_asistencias.ParticipatesInTransaction)
					{
						base.Transaction.Add(_asistencias);
					}
				}
				_asistencias.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_asistencias.EntityFactoryToUse = entityFactoryToUse;
				}
				_asistencias.GetMultiManyToOne(null, null, null, this, filter);
				_asistencias.SuppressClearInGetMulti=false;
				_alreadyFetchedAsistencias = true;
			}
			return _asistencias;
		}

		/// <summary> Sets the collection parameters for the collection for 'Asistencias'. These settings will be taken into account
		/// when the property Asistencias is requested or GetMultiAsistencias is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersAsistencias(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_asistencias.SortClauses=sortClauses;
			_asistencias.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'EventoEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'EventoEntity'</returns>
		public ORMDiocesis.CollectionClasses.EventoCollection GetMultiEventosQueAsistio(bool forceFetch)
		{
			return GetMultiEventosQueAsistio(forceFetch, _eventosQueAsistio.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'EventoEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public ORMDiocesis.CollectionClasses.EventoCollection GetMultiEventosQueAsistio(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedEventosQueAsistio || forceFetch || _alwaysFetchEventosQueAsistio) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_eventosQueAsistio.ParticipatesInTransaction)
					{
						base.Transaction.Add(_eventosQueAsistio);
					}
				}
				IRelationCollection relations = new RelationCollection();
				IPredicateExpression filter = new PredicateExpression();
				relations.Add(ParticipanteEntity.Relations.AsistenciaEntityUsingIdParticipante, "__ParticipanteEntity__", "Asistencia_", JoinHint.None);
				relations.Add(AsistenciaEntity.Relations.EventoEntityUsingIdEvento, "Asistencia_", string.Empty, JoinHint.None);
				filter.Add(new FieldCompareValuePredicate(EntityFieldFactory.Create(ParticipanteFieldIndex.Id), ComparisonOperator.Equal, this.Id));
				_eventosQueAsistio.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_eventosQueAsistio.EntityFactoryToUse = entityFactoryToUse;
				}
				_eventosQueAsistio.GetMulti(filter, relations);
				_eventosQueAsistio.SuppressClearInGetMulti=false;
				_alreadyFetchedEventosQueAsistio = true;
			}
			return _eventosQueAsistio;
		}

		/// <summary> Sets the collection parameters for the collection for 'EventosQueAsistio'. These settings will be taken into account
		/// when the property EventosQueAsistio is requested or GetMultiEventosQueAsistio is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersEventosQueAsistio(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_eventosQueAsistio.SortClauses=sortClauses;
			_eventosQueAsistio.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'ParrocoEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ParrocoEntity'</returns>
		public ORMDiocesis.CollectionClasses.ParrocoCollection GetMultiParrocosQueLoRecomiendan(bool forceFetch)
		{
			return GetMultiParrocosQueLoRecomiendan(forceFetch, _parrocosQueLoRecomiendan.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'ParrocoEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public ORMDiocesis.CollectionClasses.ParrocoCollection GetMultiParrocosQueLoRecomiendan(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedParrocosQueLoRecomiendan || forceFetch || _alwaysFetchParrocosQueLoRecomiendan) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_parrocosQueLoRecomiendan.ParticipatesInTransaction)
					{
						base.Transaction.Add(_parrocosQueLoRecomiendan);
					}
				}
				IRelationCollection relations = new RelationCollection();
				IPredicateExpression filter = new PredicateExpression();
				relations.Add(ParticipanteEntity.Relations.AsistenciaEntityUsingIdParticipante, "__ParticipanteEntity__", "Asistencia_", JoinHint.None);
				relations.Add(AsistenciaEntity.Relations.ParrocoEntityUsingCodParroco, "Asistencia_", string.Empty, JoinHint.None);
				filter.Add(new FieldCompareValuePredicate(EntityFieldFactory.Create(ParticipanteFieldIndex.Id), ComparisonOperator.Equal, this.Id));
				_parrocosQueLoRecomiendan.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_parrocosQueLoRecomiendan.EntityFactoryToUse = entityFactoryToUse;
				}
				_parrocosQueLoRecomiendan.GetMulti(filter, relations);
				_parrocosQueLoRecomiendan.SuppressClearInGetMulti=false;
				_alreadyFetchedParrocosQueLoRecomiendan = true;
			}
			return _parrocosQueLoRecomiendan;
		}

		/// <summary> Sets the collection parameters for the collection for 'ParrocosQueLoRecomiendan'. These settings will be taken into account
		/// when the property ParrocosQueLoRecomiendan is requested or GetMultiParrocosQueLoRecomiendan is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersParrocosQueLoRecomiendan(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_parrocosQueLoRecomiendan.SortClauses=sortClauses;
			_parrocosQueLoRecomiendan.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'ParroquiaEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ParroquiaEntity'</returns>
		public ORMDiocesis.CollectionClasses.ParroquiaCollection GetMultiParroquiasQueLoEnvian(bool forceFetch)
		{
			return GetMultiParroquiasQueLoEnvian(forceFetch, _parroquiasQueLoEnvian.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'ParroquiaEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public ORMDiocesis.CollectionClasses.ParroquiaCollection GetMultiParroquiasQueLoEnvian(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedParroquiasQueLoEnvian || forceFetch || _alwaysFetchParroquiasQueLoEnvian) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_parroquiasQueLoEnvian.ParticipatesInTransaction)
					{
						base.Transaction.Add(_parroquiasQueLoEnvian);
					}
				}
				IRelationCollection relations = new RelationCollection();
				IPredicateExpression filter = new PredicateExpression();
				relations.Add(ParticipanteEntity.Relations.AsistenciaEntityUsingIdParticipante, "__ParticipanteEntity__", "Asistencia_", JoinHint.None);
				relations.Add(AsistenciaEntity.Relations.ParroquiaEntityUsingCodParroquia, "Asistencia_", string.Empty, JoinHint.None);
				filter.Add(new FieldCompareValuePredicate(EntityFieldFactory.Create(ParticipanteFieldIndex.Id), ComparisonOperator.Equal, this.Id));
				_parroquiasQueLoEnvian.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_parroquiasQueLoEnvian.EntityFactoryToUse = entityFactoryToUse;
				}
				_parroquiasQueLoEnvian.GetMulti(filter, relations);
				_parroquiasQueLoEnvian.SuppressClearInGetMulti=false;
				_alreadyFetchedParroquiasQueLoEnvian = true;
			}
			return _parroquiasQueLoEnvian;
		}

		/// <summary> Sets the collection parameters for the collection for 'ParroquiasQueLoEnvian'. These settings will be taken into account
		/// when the property ParroquiasQueLoEnvian is requested or GetMultiParroquiasQueLoEnvian is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersParroquiasQueLoEnvian(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_parroquiasQueLoEnvian.SortClauses=sortClauses;
			_parroquiasQueLoEnvian.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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
			if(toReturn && Enum.IsDefined(typeof(ParticipanteFieldIndex), fieldIndex))
			{
				switch((ParticipanteFieldIndex)fieldIndex)
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
			ParticipanteDAO dao = (ParticipanteDAO)CreateDAOInstance();
			return dao.AddNew(base.Fields, base.Transaction);
		}
		
		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{
			_asistencias.ActiveContext = base.ActiveContext;
			_eventosQueAsistio.ActiveContext = base.ActiveContext;
			_parrocosQueLoRecomiendan.ActiveContext = base.ActiveContext;
			_parroquiasQueLoEnvian.ActiveContext = base.ActiveContext;



		}


		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity()
		{
			ParticipanteDAO dao = (ParticipanteDAO)CreateDAOInstance();
			return dao.UpdateExisting(base.Fields, base.Transaction);
		}
		
		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			ParticipanteDAO dao = (ParticipanteDAO)CreateDAOInstance();
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
			return EntityFieldsFactory.CreateEntityFieldsObject(ORMDiocesis.EntityType.ParticipanteEntity);
		}


		/// <summary> Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		/// <param name="id">PK value for Participante which data should be fetched into this Participante object</param>
		/// <param name="validator">The validator object for this ParticipanteEntity</param>
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
			_asistencias = new ORMDiocesis.CollectionClasses.AsistenciaCollection(new AsistenciaEntityFactory());
			_asistencias.SetContainingEntityInfo(this, "Participante");
			_alwaysFetchAsistencias = false;
			_alreadyFetchedAsistencias = false;
			_eventosQueAsistio = new ORMDiocesis.CollectionClasses.EventoCollection(new EventoEntityFactory());
			_alwaysFetchEventosQueAsistio = false;
			_alreadyFetchedEventosQueAsistio = false;
			_parrocosQueLoRecomiendan = new ORMDiocesis.CollectionClasses.ParrocoCollection(new ParrocoEntityFactory());
			_alwaysFetchParrocosQueLoRecomiendan = false;
			_alreadyFetchedParrocosQueLoRecomiendan = false;
			_parroquiasQueLoEnvian = new ORMDiocesis.CollectionClasses.ParroquiaCollection(new ParroquiaEntityFactory());
			_alwaysFetchParroquiasQueLoEnvian = false;
			_alreadyFetchedParroquiasQueLoEnvian = false;


			
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

			_fieldsCustomProperties.Add("ApellidoPaterno", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("ApellidoMaterno", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Nombre", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("FechaNacim", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Aceptado", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("NombrePadre", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("NombreMadre", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("VivePadre", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("ViveMadre", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("EdoCivilPadres", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Hermanos", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Hermanas", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("OrdenNacimiento", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Confirmacion", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("PrimeraComunion", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Deportes", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Instrumentos", fieldHashtable);
		}
		#endregion




		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="id">PK value for Participante which data should be fetched into this Participante object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 id, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			try
			{
				OnFetch();
				IDao dao = this.CreateDAOInstance();
				base.Fields[(int)ParticipanteFieldIndex.Id].ForcedCurrentValueWrite(id);
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
			return DAOFactory.CreateParticipanteDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new ParticipanteEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static ParticipanteRelations Relations
		{
			get	{ return new ParticipanteRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}


		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Asistencia' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathAsistencias
		{
			get
			{
				return new PrefetchPathElement(new ORMDiocesis.CollectionClasses.AsistenciaCollection(),
					ParticipanteEntity.Relations.AsistenciaEntityUsingIdParticipante, 
					(int)ORMDiocesis.EntityType.ParticipanteEntity, (int)ORMDiocesis.EntityType.AsistenciaEntity, 0, null, null, null, "Asistencias", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Evento' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathEventosQueAsistio
		{
			get
			{
				IRelationCollection relations = new RelationCollection();
				relations.Add(ParticipanteEntity.Relations.AsistenciaEntityUsingIdParticipante, "__ParticipanteEntity__", string.Empty, JoinHint.None);
				relations.Add(AsistenciaEntity.Relations.EventoEntityUsingIdEvento);
				return new PrefetchPathElement(new ORMDiocesis.CollectionClasses.EventoCollection(),
					ParticipanteEntity.Relations.AsistenciaEntityUsingIdParticipante,
					(int)ORMDiocesis.EntityType.ParticipanteEntity, (int)ORMDiocesis.EntityType.EventoEntity, 0, null, null, relations, "EventosQueAsistio", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Parroco' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathParrocosQueLoRecomiendan
		{
			get
			{
				IRelationCollection relations = new RelationCollection();
				relations.Add(ParticipanteEntity.Relations.AsistenciaEntityUsingIdParticipante, "__ParticipanteEntity__", string.Empty, JoinHint.None);
				relations.Add(AsistenciaEntity.Relations.ParrocoEntityUsingCodParroco);
				return new PrefetchPathElement(new ORMDiocesis.CollectionClasses.ParrocoCollection(),
					ParticipanteEntity.Relations.AsistenciaEntityUsingIdParticipante,
					(int)ORMDiocesis.EntityType.ParticipanteEntity, (int)ORMDiocesis.EntityType.ParrocoEntity, 0, null, null, relations, "ParrocosQueLoRecomiendan", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Parroquia' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathParroquiasQueLoEnvian
		{
			get
			{
				IRelationCollection relations = new RelationCollection();
				relations.Add(ParticipanteEntity.Relations.AsistenciaEntityUsingIdParticipante, "__ParticipanteEntity__", string.Empty, JoinHint.None);
				relations.Add(AsistenciaEntity.Relations.ParroquiaEntityUsingCodParroquia);
				return new PrefetchPathElement(new ORMDiocesis.CollectionClasses.ParroquiaCollection(),
					ParticipanteEntity.Relations.AsistenciaEntityUsingIdParticipante,
					(int)ORMDiocesis.EntityType.ParticipanteEntity, (int)ORMDiocesis.EntityType.ParroquiaEntity, 0, null, null, relations, "ParroquiasQueLoEnvian", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}



		/// <summary>Returns the full name for this entity, which is important for the DAO to find back persistence info for this entity.</summary>
		[Browsable(false), XmlIgnore]
		public override string LLBLGenProEntityName
		{
			get { return "ParticipanteEntity";}
		}

		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public virtual Dictionary<string, string> CustomPropertiesOfType
		{
			get { return ParticipanteEntity.CustomProperties;}
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
			get { return ParticipanteEntity.FieldsCustomProperties;}
		}

		/// <summary> The Id property of the Entity Participante<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "CatParticipantes"."IdParticipante"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 Id
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ParticipanteFieldIndex.Id);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.Int32));
				}
				return (System.Int32)valueToReturn;
			}
			set	{ SetNewFieldValue((int)ParticipanteFieldIndex.Id, value); }
		}
		/// <summary> The ApellidoPaterno property of the Entity Participante<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "CatParticipantes"."ApellidoPaterno"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String ApellidoPaterno
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ParticipanteFieldIndex.ApellidoPaterno);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
				return (System.String)valueToReturn;
			}
			set	{ SetNewFieldValue((int)ParticipanteFieldIndex.ApellidoPaterno, value); }
		}
		/// <summary> The ApellidoMaterno property of the Entity Participante<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "CatParticipantes"."ApellidoMaterno"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String ApellidoMaterno
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ParticipanteFieldIndex.ApellidoMaterno);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
				return (System.String)valueToReturn;
			}
			set	{ SetNewFieldValue((int)ParticipanteFieldIndex.ApellidoMaterno, value); }
		}
		/// <summary> The Nombre property of the Entity Participante<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "CatParticipantes"."Nombre"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Nombre
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ParticipanteFieldIndex.Nombre);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
				return (System.String)valueToReturn;
			}
			set	{ SetNewFieldValue((int)ParticipanteFieldIndex.Nombre, value); }
		}
		/// <summary> The FechaNacim property of the Entity Participante<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "CatParticipantes"."FechaNacim"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime FechaNacim
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ParticipanteFieldIndex.FechaNacim);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.DateTime));
				}
				return (System.DateTime)valueToReturn;
			}
			set	{ SetNewFieldValue((int)ParticipanteFieldIndex.FechaNacim, value); }
		}
		/// <summary> The Aceptado property of the Entity Participante<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "CatParticipantes"."Aceptado"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int16 Aceptado
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ParticipanteFieldIndex.Aceptado);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.Int16));
				}
				return (System.Int16)valueToReturn;
			}
			set	{ SetNewFieldValue((int)ParticipanteFieldIndex.Aceptado, value); }
		}
		/// <summary> The NombrePadre property of the Entity Participante<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "CatParticipantes"."NombrePadre"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String NombrePadre
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ParticipanteFieldIndex.NombrePadre);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
				return (System.String)valueToReturn;
			}
			set	{ SetNewFieldValue((int)ParticipanteFieldIndex.NombrePadre, value); }
		}
		/// <summary> The NombreMadre property of the Entity Participante<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "CatParticipantes"."NombreMadre"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String NombreMadre
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ParticipanteFieldIndex.NombreMadre);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
				return (System.String)valueToReturn;
			}
			set	{ SetNewFieldValue((int)ParticipanteFieldIndex.NombreMadre, value); }
		}
		/// <summary> The VivePadre property of the Entity Participante<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "CatParticipantes"."VivePadre"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Boolean> VivePadre
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ParticipanteFieldIndex.VivePadre);

				return (Nullable<System.Boolean>)valueToReturn;
			}
			set	{ SetNewFieldValue((int)ParticipanteFieldIndex.VivePadre, value); }
		}
		/// <summary> The ViveMadre property of the Entity Participante<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "CatParticipantes"."ViveMadre"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Boolean> ViveMadre
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ParticipanteFieldIndex.ViveMadre);

				return (Nullable<System.Boolean>)valueToReturn;
			}
			set	{ SetNewFieldValue((int)ParticipanteFieldIndex.ViveMadre, value); }
		}
		/// <summary> The EdoCivilPadres property of the Entity Participante<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "CatParticipantes"."EdoCivilPadres"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> EdoCivilPadres
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ParticipanteFieldIndex.EdoCivilPadres);

				return (Nullable<System.Int32>)valueToReturn;
			}
			set	{ SetNewFieldValue((int)ParticipanteFieldIndex.EdoCivilPadres, value); }
		}
		/// <summary> The Hermanos property of the Entity Participante<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "CatParticipantes"."Hermanos"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> Hermanos
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ParticipanteFieldIndex.Hermanos);

				return (Nullable<System.Int32>)valueToReturn;
			}
			set	{ SetNewFieldValue((int)ParticipanteFieldIndex.Hermanos, value); }
		}
		/// <summary> The Hermanas property of the Entity Participante<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "CatParticipantes"."Hermanas"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> Hermanas
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ParticipanteFieldIndex.Hermanas);

				return (Nullable<System.Int32>)valueToReturn;
			}
			set	{ SetNewFieldValue((int)ParticipanteFieldIndex.Hermanas, value); }
		}
		/// <summary> The OrdenNacimiento property of the Entity Participante<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "CatParticipantes"."OrdenNacimiento"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> OrdenNacimiento
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ParticipanteFieldIndex.OrdenNacimiento);

				return (Nullable<System.Int32>)valueToReturn;
			}
			set	{ SetNewFieldValue((int)ParticipanteFieldIndex.OrdenNacimiento, value); }
		}
		/// <summary> The Confirmacion property of the Entity Participante<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "CatParticipantes"."Confirmacion"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Boolean> Confirmacion
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ParticipanteFieldIndex.Confirmacion);

				return (Nullable<System.Boolean>)valueToReturn;
			}
			set	{ SetNewFieldValue((int)ParticipanteFieldIndex.Confirmacion, value); }
		}
		/// <summary> The PrimeraComunion property of the Entity Participante<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "CatParticipantes"."PrimeraComunion"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Boolean> PrimeraComunion
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ParticipanteFieldIndex.PrimeraComunion);

				return (Nullable<System.Boolean>)valueToReturn;
			}
			set	{ SetNewFieldValue((int)ParticipanteFieldIndex.PrimeraComunion, value); }
		}
		/// <summary> The Deportes property of the Entity Participante<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "CatParticipantes"."Deportes"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Deportes
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ParticipanteFieldIndex.Deportes);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
				return (System.String)valueToReturn;
			}
			set	{ SetNewFieldValue((int)ParticipanteFieldIndex.Deportes, value); }
		}
		/// <summary> The Instrumentos property of the Entity Participante<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "CatParticipantes"."Instrumentos"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Instrumentos
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ParticipanteFieldIndex.Instrumentos);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
				return (System.String)valueToReturn;
			}
			set	{ SetNewFieldValue((int)ParticipanteFieldIndex.Instrumentos, value); }
		}

		/// <summary> Retrieves all related entities of type 'AsistenciaEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiAsistencias()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual ORMDiocesis.CollectionClasses.AsistenciaCollection Asistencias
		{
			get	{ return GetMultiAsistencias(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for Asistencias. When set to true, Asistencias is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Asistencias is accessed. You can always execute
		/// a forced fetch by calling GetMultiAsistencias(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchAsistencias
		{
			get	{ return _alwaysFetchAsistencias; }
			set	{ _alwaysFetchAsistencias = value; }	
		}

		/// <summary> Retrieves all related entities of type 'EventoEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiEventosQueAsistio()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual ORMDiocesis.CollectionClasses.EventoCollection EventosQueAsistio
		{
			get { return GetMultiEventosQueAsistio(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for EventosQueAsistio. When set to true, EventosQueAsistio is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time EventosQueAsistio is accessed. You can always execute
		/// a forced fetch by calling GetMultiEventosQueAsistio(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchEventosQueAsistio
		{
			get	{ return _alwaysFetchEventosQueAsistio; }
			set	{ _alwaysFetchEventosQueAsistio = value; }	
		}
		/// <summary> Retrieves all related entities of type 'ParrocoEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiParrocosQueLoRecomiendan()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual ORMDiocesis.CollectionClasses.ParrocoCollection ParrocosQueLoRecomiendan
		{
			get { return GetMultiParrocosQueLoRecomiendan(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ParrocosQueLoRecomiendan. When set to true, ParrocosQueLoRecomiendan is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ParrocosQueLoRecomiendan is accessed. You can always execute
		/// a forced fetch by calling GetMultiParrocosQueLoRecomiendan(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchParrocosQueLoRecomiendan
		{
			get	{ return _alwaysFetchParrocosQueLoRecomiendan; }
			set	{ _alwaysFetchParrocosQueLoRecomiendan = value; }	
		}
		/// <summary> Retrieves all related entities of type 'ParroquiaEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiParroquiasQueLoEnvian()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual ORMDiocesis.CollectionClasses.ParroquiaCollection ParroquiasQueLoEnvian
		{
			get { return GetMultiParroquiasQueLoEnvian(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ParroquiasQueLoEnvian. When set to true, ParroquiasQueLoEnvian is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ParroquiasQueLoEnvian is accessed. You can always execute
		/// a forced fetch by calling GetMultiParroquiasQueLoEnvian(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchParroquiasQueLoEnvian
		{
			get	{ return _alwaysFetchParroquiasQueLoEnvian; }
			set	{ _alwaysFetchParroquiasQueLoEnvian = value; }	
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
			get { return (int)ORMDiocesis.EntityType.ParticipanteEntity; }
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
