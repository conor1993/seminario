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
	/// Entity class which represents the entity 'Parroco'. <br/><br/>
	/// 
	/// </summary>
#if CF
	[SD.LLBLGen.Pro.ORMSupportClasses.Serializable]
#else
	[Serializable]
#endif
	public partial class ParrocoEntity : EntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private ORMDiocesis.CollectionClasses.AsistenciaCollection	_asistencias;
		private bool	_alwaysFetchAsistencias, _alreadyFetchedAsistencias;
		private ORMDiocesis.CollectionClasses.ParroquiaCollection _catParroquiasCollectionViaSemAsistencia;
		private bool	_alwaysFetchCatParroquiasCollectionViaSemAsistencia, _alreadyFetchedCatParroquiasCollectionViaSemAsistencia;
		private ORMDiocesis.CollectionClasses.ParticipanteCollection _participantesEnviadosAeventos;
		private bool	_alwaysFetchParticipantesEnviadosAeventos, _alreadyFetchedParticipantesEnviadosAeventos;
		private ParroquiaEntity _parroquia;
		private bool	_alwaysFetchParroquia, _alreadyFetchedParroquia, _parroquiaReturnsNewIfNotFound;


		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;
		
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static ParrocoEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public ParrocoEntity()
		{
			InitClassEmpty(CreateValidator());
		}


		/// <summary>CTor</summary>
		/// <param name="id">PK value for Parroco which data should be fetched into this Parroco object</param>
		public ParrocoEntity(System.Int32 id)
		{
			InitClassFetch(id, CreateValidator(), null);
		}

		/// <summary>CTor</summary>
		/// <param name="id">PK value for Parroco which data should be fetched into this Parroco object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public ParrocoEntity(System.Int32 id, IPrefetchPath prefetchPathToUse)
		{
			InitClassFetch(id, CreateValidator(), prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="id">PK value for Parroco which data should be fetched into this Parroco object</param>
		/// <param name="validator">The custom validator object for this ParrocoEntity</param>
		public ParrocoEntity(System.Int32 id, IValidator validator)
		{
			InitClassFetch(id, validator, null);
		}


		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected ParrocoEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_asistencias = (ORMDiocesis.CollectionClasses.AsistenciaCollection)info.GetValue("_asistencias", typeof(ORMDiocesis.CollectionClasses.AsistenciaCollection));
			_alwaysFetchAsistencias = info.GetBoolean("_alwaysFetchAsistencias");
			_alreadyFetchedAsistencias = info.GetBoolean("_alreadyFetchedAsistencias");
			_catParroquiasCollectionViaSemAsistencia = (ORMDiocesis.CollectionClasses.ParroquiaCollection)info.GetValue("_catParroquiasCollectionViaSemAsistencia", typeof(ORMDiocesis.CollectionClasses.ParroquiaCollection));
			_alwaysFetchCatParroquiasCollectionViaSemAsistencia = info.GetBoolean("_alwaysFetchCatParroquiasCollectionViaSemAsistencia");
			_alreadyFetchedCatParroquiasCollectionViaSemAsistencia = info.GetBoolean("_alreadyFetchedCatParroquiasCollectionViaSemAsistencia");
			_participantesEnviadosAeventos = (ORMDiocesis.CollectionClasses.ParticipanteCollection)info.GetValue("_participantesEnviadosAeventos", typeof(ORMDiocesis.CollectionClasses.ParticipanteCollection));
			_alwaysFetchParticipantesEnviadosAeventos = info.GetBoolean("_alwaysFetchParticipantesEnviadosAeventos");
			_alreadyFetchedParticipantesEnviadosAeventos = info.GetBoolean("_alreadyFetchedParticipantesEnviadosAeventos");
			_parroquia = (ParroquiaEntity)info.GetValue("_parroquia", typeof(ParroquiaEntity));
			if(_parroquia!=null)
			{
				_parroquia.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_parroquiaReturnsNewIfNotFound = info.GetBoolean("_parroquiaReturnsNewIfNotFound");
			_alwaysFetchParroquia = info.GetBoolean("_alwaysFetchParroquia");
			_alreadyFetchedParroquia = info.GetBoolean("_alreadyFetchedParroquia");

			base.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		
		/// <summary> Will perform post-ReadXml actions</summary>
		protected override void PostReadXmlFixups()
		{
			_alreadyFetchedAsistencias = (_asistencias.Count > 0);
			_alreadyFetchedCatParroquiasCollectionViaSemAsistencia = (_catParroquiasCollectionViaSemAsistencia.Count > 0);
			_alreadyFetchedParticipantesEnviadosAeventos = (_participantesEnviadosAeventos.Count > 0);
			_alreadyFetchedParroquia = (_parroquia != null);

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
			info.AddValue("_catParroquiasCollectionViaSemAsistencia", _catParroquiasCollectionViaSemAsistencia);
			info.AddValue("_alwaysFetchCatParroquiasCollectionViaSemAsistencia", _alwaysFetchCatParroquiasCollectionViaSemAsistencia);
			info.AddValue("_alreadyFetchedCatParroquiasCollectionViaSemAsistencia", _alreadyFetchedCatParroquiasCollectionViaSemAsistencia);
			info.AddValue("_participantesEnviadosAeventos", _participantesEnviadosAeventos);
			info.AddValue("_alwaysFetchParticipantesEnviadosAeventos", _alwaysFetchParticipantesEnviadosAeventos);
			info.AddValue("_alreadyFetchedParticipantesEnviadosAeventos", _alreadyFetchedParticipantesEnviadosAeventos);
			info.AddValue("_parroquia", _parroquia);
			info.AddValue("_parroquiaReturnsNewIfNotFound", _parroquiaReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchParroquia", _alwaysFetchParroquia);
			info.AddValue("_alreadyFetchedParroquia", _alreadyFetchedParroquia);

			
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
				case "Parroquia":
					_alreadyFetchedParroquia = true;
					this.Parroquia = (ParroquiaEntity)entity;
					break;
				case "Asistencias":
					_alreadyFetchedAsistencias = true;
					if(entity!=null)
					{
						this.Asistencias.Add((AsistenciaEntity)entity);
					}
					break;
				case "CatParroquiasCollectionViaSemAsistencia":
					_alreadyFetchedCatParroquiasCollectionViaSemAsistencia = true;
					if(entity!=null)
					{
						this.CatParroquiasCollectionViaSemAsistencia.Add((ParroquiaEntity)entity);
					}
					break;
				case "ParticipantesEnviadosAeventos":
					_alreadyFetchedParticipantesEnviadosAeventos = true;
					if(entity!=null)
					{
						this.ParticipantesEnviadosAeventos.Add((ParticipanteEntity)entity);
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
				case "Parroquia":
					SetupSyncParroquia(relatedEntity);
					OnRelatedEntitySet(relatedEntity, fieldName);
					break;
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
				case "Parroquia":
					DesetupSyncParroquia(false, true);
					OnRelatedEntityUnset(relatedEntity, fieldName);
					break;
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
			if(_parroquia!=null)
			{
				toReturn.Add(_parroquia);
			}


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
		/// <param name="id">PK value for Parroco which data should be fetched into this Parroco object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 id)
		{
			return FetchUsingPK(id, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="id">PK value for Parroco which data should be fetched into this Parroco object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 id, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(id, prefetchPathToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="id">PK value for Parroco which data should be fetched into this Parroco object</param>
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
		public bool TestOriginalFieldValueForNull(ParrocoFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}
		
		/// <summary>Returns true if the current value for the field with the fieldIndex passed in represents null/not defined, false otherwise.
		/// Should not be used for testing if the original value (read from the db) is NULL</summary>
		/// <param name="fieldIndex">Index of the field to test if its currentvalue is null/undefined</param>
		/// <returns>true if the field's value isn't defined yet, false otherwise</returns>
		public bool TestCurrentFieldValueForNull(ParrocoFieldIndex fieldIndex)
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
				_asistencias.GetMultiManyToOne(null, this, null, null, filter);
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

		/// <summary> Retrieves all related entities of type 'ParroquiaEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ParroquiaEntity'</returns>
		public ORMDiocesis.CollectionClasses.ParroquiaCollection GetMultiCatParroquiasCollectionViaSemAsistencia(bool forceFetch)
		{
			return GetMultiCatParroquiasCollectionViaSemAsistencia(forceFetch, _catParroquiasCollectionViaSemAsistencia.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'ParroquiaEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public ORMDiocesis.CollectionClasses.ParroquiaCollection GetMultiCatParroquiasCollectionViaSemAsistencia(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedCatParroquiasCollectionViaSemAsistencia || forceFetch || _alwaysFetchCatParroquiasCollectionViaSemAsistencia) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_catParroquiasCollectionViaSemAsistencia.ParticipatesInTransaction)
					{
						base.Transaction.Add(_catParroquiasCollectionViaSemAsistencia);
					}
				}
				IRelationCollection relations = new RelationCollection();
				IPredicateExpression filter = new PredicateExpression();
				relations.Add(ParrocoEntity.Relations.AsistenciaEntityUsingCodParroco, "__ParrocoEntity__", "Asistencia_", JoinHint.None);
				relations.Add(AsistenciaEntity.Relations.ParroquiaEntityUsingCodParroquia, "Asistencia_", string.Empty, JoinHint.None);
				filter.Add(new FieldCompareValuePredicate(EntityFieldFactory.Create(ParrocoFieldIndex.Id), ComparisonOperator.Equal, this.Id));
				_catParroquiasCollectionViaSemAsistencia.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_catParroquiasCollectionViaSemAsistencia.EntityFactoryToUse = entityFactoryToUse;
				}
				_catParroquiasCollectionViaSemAsistencia.GetMulti(filter, relations);
				_catParroquiasCollectionViaSemAsistencia.SuppressClearInGetMulti=false;
				_alreadyFetchedCatParroquiasCollectionViaSemAsistencia = true;
			}
			return _catParroquiasCollectionViaSemAsistencia;
		}

		/// <summary> Sets the collection parameters for the collection for 'CatParroquiasCollectionViaSemAsistencia'. These settings will be taken into account
		/// when the property CatParroquiasCollectionViaSemAsistencia is requested or GetMultiCatParroquiasCollectionViaSemAsistencia is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersCatParroquiasCollectionViaSemAsistencia(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_catParroquiasCollectionViaSemAsistencia.SortClauses=sortClauses;
			_catParroquiasCollectionViaSemAsistencia.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'ParticipanteEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ParticipanteEntity'</returns>
		public ORMDiocesis.CollectionClasses.ParticipanteCollection GetMultiParticipantesEnviadosAeventos(bool forceFetch)
		{
			return GetMultiParticipantesEnviadosAeventos(forceFetch, _participantesEnviadosAeventos.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'ParticipanteEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public ORMDiocesis.CollectionClasses.ParticipanteCollection GetMultiParticipantesEnviadosAeventos(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedParticipantesEnviadosAeventos || forceFetch || _alwaysFetchParticipantesEnviadosAeventos) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_participantesEnviadosAeventos.ParticipatesInTransaction)
					{
						base.Transaction.Add(_participantesEnviadosAeventos);
					}
				}
				IRelationCollection relations = new RelationCollection();
				IPredicateExpression filter = new PredicateExpression();
				relations.Add(ParrocoEntity.Relations.AsistenciaEntityUsingCodParroco, "__ParrocoEntity__", "Asistencia_", JoinHint.None);
				relations.Add(AsistenciaEntity.Relations.ParticipanteEntityUsingIdParticipante, "Asistencia_", string.Empty, JoinHint.None);
				filter.Add(new FieldCompareValuePredicate(EntityFieldFactory.Create(ParrocoFieldIndex.Id), ComparisonOperator.Equal, this.Id));
				_participantesEnviadosAeventos.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_participantesEnviadosAeventos.EntityFactoryToUse = entityFactoryToUse;
				}
				_participantesEnviadosAeventos.GetMulti(filter, relations);
				_participantesEnviadosAeventos.SuppressClearInGetMulti=false;
				_alreadyFetchedParticipantesEnviadosAeventos = true;
			}
			return _participantesEnviadosAeventos;
		}

		/// <summary> Sets the collection parameters for the collection for 'ParticipantesEnviadosAeventos'. These settings will be taken into account
		/// when the property ParticipantesEnviadosAeventos is requested or GetMultiParticipantesEnviadosAeventos is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersParticipantesEnviadosAeventos(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_participantesEnviadosAeventos.SortClauses=sortClauses;
			_participantesEnviadosAeventos.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves the related entity of type 'ParroquiaEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'ParroquiaEntity' which is related to this entity.</returns>
		public ParroquiaEntity GetSingleParroquia()
		{
			return GetSingleParroquia(false);
		}

		/// <summary> Retrieves the related entity of type 'ParroquiaEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'ParroquiaEntity' which is related to this entity.</returns>
		public virtual ParroquiaEntity GetSingleParroquia(bool forceFetch)
		{
			if( ( !_alreadyFetchedParroquia || forceFetch || _alwaysFetchParroquia) && !base.IsSerializing && !base.IsDeserializing )			
			{

				ParroquiaEntity newEntity = new ParroquiaEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = false;
				if(base.CheckIfLazyLoadingShouldOccur(ParrocoEntity.Relations.ParroquiaEntityUsingIdParroquia))
				{
					fetchResult = newEntity.FetchUsingPK(this.IdParroquia.GetValueOrDefault());
				}
				if(!_parroquiaReturnsNewIfNotFound && !fetchResult)
				{
					this.Parroquia = null;
				}
				else
				{
					if((base.ActiveContext!=null)&&fetchResult)
					{
						newEntity = (ParroquiaEntity)base.ActiveContext.Get(newEntity);
					}
					this.Parroquia = newEntity;
					_alreadyFetchedParroquia = fetchResult;
				}
				if(base.ParticipatesInTransaction && !fetchResult)
				{
					base.Transaction.Remove(newEntity);
				}
			}
			return _parroquia;
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
			if(toReturn && Enum.IsDefined(typeof(ParrocoFieldIndex), fieldIndex))
			{
				switch((ParrocoFieldIndex)fieldIndex)
				{
					case ParrocoFieldIndex.IdParroquia:
						DesetupSyncParroquia(true, false);
						_alreadyFetchedParroquia = false;
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
			ParrocoDAO dao = (ParrocoDAO)CreateDAOInstance();
			return dao.AddNew(base.Fields, base.Transaction);
		}
		
		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{
			_asistencias.ActiveContext = base.ActiveContext;
			_catParroquiasCollectionViaSemAsistencia.ActiveContext = base.ActiveContext;
			_participantesEnviadosAeventos.ActiveContext = base.ActiveContext;
			if(_parroquia!=null)
			{
				_parroquia.ActiveContext = base.ActiveContext;
			}


		}


		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity()
		{
			ParrocoDAO dao = (ParrocoDAO)CreateDAOInstance();
			return dao.UpdateExisting(base.Fields, base.Transaction);
		}
		
		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			ParrocoDAO dao = (ParrocoDAO)CreateDAOInstance();
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
			return EntityFieldsFactory.CreateEntityFieldsObject(ORMDiocesis.EntityType.ParrocoEntity);
		}


		/// <summary> Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		/// <param name="id">PK value for Parroco which data should be fetched into this Parroco object</param>
		/// <param name="validator">The validator object for this ParrocoEntity</param>
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
			_asistencias.SetContainingEntityInfo(this, "CatParrocos");
			_alwaysFetchAsistencias = false;
			_alreadyFetchedAsistencias = false;
			_catParroquiasCollectionViaSemAsistencia = new ORMDiocesis.CollectionClasses.ParroquiaCollection(new ParroquiaEntityFactory());
			_alwaysFetchCatParroquiasCollectionViaSemAsistencia = false;
			_alreadyFetchedCatParroquiasCollectionViaSemAsistencia = false;
			_participantesEnviadosAeventos = new ORMDiocesis.CollectionClasses.ParticipanteCollection(new ParticipanteEntityFactory());
			_alwaysFetchParticipantesEnviadosAeventos = false;
			_alreadyFetchedParticipantesEnviadosAeventos = false;
			_parroquia = null;
			_parroquiaReturnsNewIfNotFound = true;
			_alwaysFetchParroquia = false;
			_alreadyFetchedParroquia = false;

			
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

			_fieldsCustomProperties.Add("Nombre", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Apellidos", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Cargo", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("EMail", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("IdParroquia", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("NombreParroquia", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Telefono1", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Telefono2", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("TelCural", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Fecnac", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("FecOrdenacion", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("FechaNac", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("FechaOrdenac", fieldHashtable);
		}
		#endregion


		/// <summary> Removes the sync logic for member _parroquia</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncParroquia(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _parroquia, new PropertyChangedEventHandler( OnParroquiaPropertyChanged ), "Parroquia", ParrocoEntity.Relations.ParroquiaEntityUsingIdParroquia, true, signalRelatedEntity, "Parrocos", resetFKFields, new int[] { (int)ParrocoFieldIndex.IdParroquia } );		
			_parroquia = null;
		}
		
		/// <summary> setups the sync logic for member _parroquia</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncParroquia(IEntity relatedEntity)
		{
			DesetupSyncParroquia(true, true);
			_parroquia = (ParroquiaEntity)relatedEntity;
			base.PerformSetupSyncRelatedEntity( _parroquia, new PropertyChangedEventHandler( OnParroquiaPropertyChanged ), "Parroquia", ParrocoEntity.Relations.ParroquiaEntityUsingIdParroquia, true, ref _alreadyFetchedParroquia, new string[] {  } );
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnParroquiaPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}


		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="id">PK value for Parroco which data should be fetched into this Parroco object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 id, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			try
			{
				OnFetch();
				IDao dao = this.CreateDAOInstance();
				base.Fields[(int)ParrocoFieldIndex.Id].ForcedCurrentValueWrite(id);
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
			return DAOFactory.CreateParrocoDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new ParrocoEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static ParrocoRelations Relations
		{
			get	{ return new ParrocoRelations(); }
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
					ParrocoEntity.Relations.AsistenciaEntityUsingCodParroco, 
					(int)ORMDiocesis.EntityType.ParrocoEntity, (int)ORMDiocesis.EntityType.AsistenciaEntity, 0, null, null, null, "Asistencias", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Parroquia' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathCatParroquiasCollectionViaSemAsistencia
		{
			get
			{
				IRelationCollection relations = new RelationCollection();
				relations.Add(ParrocoEntity.Relations.AsistenciaEntityUsingCodParroco, "__ParrocoEntity__", string.Empty, JoinHint.None);
				relations.Add(AsistenciaEntity.Relations.ParroquiaEntityUsingCodParroquia);
				return new PrefetchPathElement(new ORMDiocesis.CollectionClasses.ParroquiaCollection(),
					ParrocoEntity.Relations.AsistenciaEntityUsingCodParroco,
					(int)ORMDiocesis.EntityType.ParrocoEntity, (int)ORMDiocesis.EntityType.ParroquiaEntity, 0, null, null, relations, "CatParroquiasCollectionViaSemAsistencia", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Participante' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathParticipantesEnviadosAeventos
		{
			get
			{
				IRelationCollection relations = new RelationCollection();
				relations.Add(ParrocoEntity.Relations.AsistenciaEntityUsingCodParroco, "__ParrocoEntity__", string.Empty, JoinHint.None);
				relations.Add(AsistenciaEntity.Relations.ParticipanteEntityUsingIdParticipante);
				return new PrefetchPathElement(new ORMDiocesis.CollectionClasses.ParticipanteCollection(),
					ParrocoEntity.Relations.AsistenciaEntityUsingCodParroco,
					(int)ORMDiocesis.EntityType.ParrocoEntity, (int)ORMDiocesis.EntityType.ParticipanteEntity, 0, null, null, relations, "ParticipantesEnviadosAeventos", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Parroquia' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathParroquia
		{
			get
			{
				return new PrefetchPathElement(new ORMDiocesis.CollectionClasses.ParroquiaCollection(),
					ParrocoEntity.Relations.ParroquiaEntityUsingIdParroquia, 
					(int)ORMDiocesis.EntityType.ParrocoEntity, (int)ORMDiocesis.EntityType.ParroquiaEntity, 0, null, null, null, "Parroquia", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}


		/// <summary>Returns the full name for this entity, which is important for the DAO to find back persistence info for this entity.</summary>
		[Browsable(false), XmlIgnore]
		public override string LLBLGenProEntityName
		{
			get { return "ParrocoEntity";}
		}

		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public virtual Dictionary<string, string> CustomPropertiesOfType
		{
			get { return ParrocoEntity.CustomProperties;}
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
			get { return ParrocoEntity.FieldsCustomProperties;}
		}

		/// <summary> The Id property of the Entity Parroco<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "CatParrocos"."IdParroco"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 Id
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ParrocoFieldIndex.Id);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.Int32));
				}
				return (System.Int32)valueToReturn;
			}
			set	{ SetNewFieldValue((int)ParrocoFieldIndex.Id, value); }
		}
		/// <summary> The Titulo property of the Entity Parroco<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "CatParrocos"."Titulo"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 30<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Titulo
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ParrocoFieldIndex.Titulo);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
				return (System.String)valueToReturn;
			}
			set	{ SetNewFieldValue((int)ParrocoFieldIndex.Titulo, value); }
		}
		/// <summary> The Nombre property of the Entity Parroco<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "CatParrocos"."NomParroco"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Nombre
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ParrocoFieldIndex.Nombre);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
				return (System.String)valueToReturn;
			}
			set	{ SetNewFieldValue((int)ParrocoFieldIndex.Nombre, value); }
		}
		/// <summary> The Apellidos property of the Entity Parroco<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "CatParrocos"."ApellParroco"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Apellidos
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ParrocoFieldIndex.Apellidos);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
				return (System.String)valueToReturn;
			}
			set	{ SetNewFieldValue((int)ParrocoFieldIndex.Apellidos, value); }
		}
		/// <summary> The Cargo property of the Entity Parroco<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "CatParrocos"."Cargo"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 255<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Cargo
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ParrocoFieldIndex.Cargo);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
				return (System.String)valueToReturn;
			}
			set	{ SetNewFieldValue((int)ParrocoFieldIndex.Cargo, value); }
		}
		/// <summary> The EMail property of the Entity Parroco<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "CatParrocos"."eMail"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 255<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String EMail
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ParrocoFieldIndex.EMail);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
				return (System.String)valueToReturn;
			}
			set	{ SetNewFieldValue((int)ParrocoFieldIndex.EMail, value); }
		}
		/// <summary> The IdParroquia property of the Entity Parroco<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "CatParrocos"."IdParroquia"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> IdParroquia
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ParrocoFieldIndex.IdParroquia);

				return (Nullable<System.Int32>)valueToReturn;
			}
			set	{ SetNewFieldValue((int)ParrocoFieldIndex.IdParroquia, value); }
		}
		/// <summary> The NombreParroquia property of the Entity Parroco<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "CatParrocos"."NomParroquia"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 255<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String NombreParroquia
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ParrocoFieldIndex.NombreParroquia);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
				return (System.String)valueToReturn;
			}
			set	{ SetNewFieldValue((int)ParrocoFieldIndex.NombreParroquia, value); }
		}
		/// <summary> The Telefono1 property of the Entity Parroco<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "CatParrocos"."Telefono1"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 30<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Telefono1
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ParrocoFieldIndex.Telefono1);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
				return (System.String)valueToReturn;
			}
			set	{ SetNewFieldValue((int)ParrocoFieldIndex.Telefono1, value); }
		}
		/// <summary> The Telefono2 property of the Entity Parroco<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "CatParrocos"."Telefono2"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 30<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Telefono2
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ParrocoFieldIndex.Telefono2);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
				return (System.String)valueToReturn;
			}
			set	{ SetNewFieldValue((int)ParrocoFieldIndex.Telefono2, value); }
		}
		/// <summary> The TelCural property of the Entity Parroco<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "CatParrocos"."TelCural"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 30<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String TelCural
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ParrocoFieldIndex.TelCural);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
				return (System.String)valueToReturn;
			}
			set	{ SetNewFieldValue((int)ParrocoFieldIndex.TelCural, value); }
		}
		/// <summary> The Fecnac property of the Entity Parroco<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "CatParrocos"."Fecnac"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 255<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Fecnac
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ParrocoFieldIndex.Fecnac);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
				return (System.String)valueToReturn;
			}
			set	{ SetNewFieldValue((int)ParrocoFieldIndex.Fecnac, value); }
		}
		/// <summary> The FecOrdenacion property of the Entity Parroco<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "CatParrocos"."Fecorden"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 255<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String FecOrdenacion
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ParrocoFieldIndex.FecOrdenacion);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
				return (System.String)valueToReturn;
			}
			set	{ SetNewFieldValue((int)ParrocoFieldIndex.FecOrdenacion, value); }
		}
		/// <summary> The FechaNac property of the Entity Parroco<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "CatParrocos"."FechaNac"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> FechaNac
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ParrocoFieldIndex.FechaNac);

				return (Nullable<System.DateTime>)valueToReturn;
			}
			set	{ SetNewFieldValue((int)ParrocoFieldIndex.FechaNac, value); }
		}
		/// <summary> The FechaOrdenac property of the Entity Parroco<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "CatParrocos"."FechaOrdenac"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> FechaOrdenac
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ParrocoFieldIndex.FechaOrdenac);

				return (Nullable<System.DateTime>)valueToReturn;
			}
			set	{ SetNewFieldValue((int)ParrocoFieldIndex.FechaOrdenac, value); }
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

		/// <summary> Retrieves all related entities of type 'ParroquiaEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCatParroquiasCollectionViaSemAsistencia()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual ORMDiocesis.CollectionClasses.ParroquiaCollection CatParroquiasCollectionViaSemAsistencia
		{
			get { return GetMultiCatParroquiasCollectionViaSemAsistencia(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for CatParroquiasCollectionViaSemAsistencia. When set to true, CatParroquiasCollectionViaSemAsistencia is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time CatParroquiasCollectionViaSemAsistencia is accessed. You can always execute
		/// a forced fetch by calling GetMultiCatParroquiasCollectionViaSemAsistencia(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchCatParroquiasCollectionViaSemAsistencia
		{
			get	{ return _alwaysFetchCatParroquiasCollectionViaSemAsistencia; }
			set	{ _alwaysFetchCatParroquiasCollectionViaSemAsistencia = value; }	
		}
		/// <summary> Retrieves all related entities of type 'ParticipanteEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiParticipantesEnviadosAeventos()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual ORMDiocesis.CollectionClasses.ParticipanteCollection ParticipantesEnviadosAeventos
		{
			get { return GetMultiParticipantesEnviadosAeventos(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ParticipantesEnviadosAeventos. When set to true, ParticipantesEnviadosAeventos is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ParticipantesEnviadosAeventos is accessed. You can always execute
		/// a forced fetch by calling GetMultiParticipantesEnviadosAeventos(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchParticipantesEnviadosAeventos
		{
			get	{ return _alwaysFetchParticipantesEnviadosAeventos; }
			set	{ _alwaysFetchParticipantesEnviadosAeventos = value; }	
		}

		/// <summary> Gets / sets related entity of type 'ParroquiaEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleParroquia()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual ParroquiaEntity Parroquia
		{
			get	{ return GetSingleParroquia(false); }
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncParroquia(value);
				}
				else
				{
					if(value==null)
					{
						if(_parroquia != null)
						{
							_parroquia.UnsetRelatedEntity(this, "Parrocos");
						}
					}
					else
					{
						((IEntity)value).SetRelatedEntity(this, "Parrocos");
					}
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for Parroquia. When set to true, Parroquia is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Parroquia is accessed. You can always execute
		/// a forced fetch by calling GetSingleParroquia(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchParroquia
		{
			get	{ return _alwaysFetchParroquia; }
			set	{ _alwaysFetchParroquia = value; }	
		}
		
		/// <summary> Gets / sets the flag for what to do if the related entity available through the property Parroquia is not found
		/// in the database. When set to true, Parroquia will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool ParroquiaReturnsNewIfNotFound
		{
			get	{ return _parroquiaReturnsNewIfNotFound; }
			set { _parroquiaReturnsNewIfNotFound = value; }	
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
			get { return (int)ORMDiocesis.EntityType.ParrocoEntity; }
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
