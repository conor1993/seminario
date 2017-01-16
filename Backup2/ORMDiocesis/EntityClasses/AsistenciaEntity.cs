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
	/// Entity class which represents the entity 'Asistencia'. <br/><br/>
	/// 
	/// </summary>
#if CF
	[SD.LLBLGen.Pro.ORMSupportClasses.Serializable]
#else
	[Serializable]
#endif
	public partial class AsistenciaEntity : EntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END
			
	{
		#region Class Member Declarations


		private EventoEntity _evento;
		private bool	_alwaysFetchEvento, _alreadyFetchedEvento, _eventoReturnsNewIfNotFound;
		private ParrocoEntity _catParrocos;
		private bool	_alwaysFetchCatParrocos, _alreadyFetchedCatParrocos, _catParrocosReturnsNewIfNotFound;
		private ParroquiaEntity _catParroquias;
		private bool	_alwaysFetchCatParroquias, _alreadyFetchedCatParroquias, _catParroquiasReturnsNewIfNotFound;
		private ParticipanteEntity _participante;
		private bool	_alwaysFetchParticipante, _alreadyFetchedParticipante, _participanteReturnsNewIfNotFound;


		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;
		
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static AsistenciaEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public AsistenciaEntity()
		{
			InitClassEmpty(CreateValidator());
		}


		/// <summary>CTor</summary>
		/// <param name="idParticipante">PK value for Asistencia which data should be fetched into this Asistencia object</param>
		/// <param name="idEvento">PK value for Asistencia which data should be fetched into this Asistencia object</param>
		public AsistenciaEntity(System.Int32 idParticipante, System.String idEvento)
		{
			InitClassFetch(idParticipante, idEvento, CreateValidator(), null);
		}

		/// <summary>CTor</summary>
		/// <param name="idParticipante">PK value for Asistencia which data should be fetched into this Asistencia object</param>
		/// <param name="idEvento">PK value for Asistencia which data should be fetched into this Asistencia object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public AsistenciaEntity(System.Int32 idParticipante, System.String idEvento, IPrefetchPath prefetchPathToUse)
		{
			InitClassFetch(idParticipante, idEvento, CreateValidator(), prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="idParticipante">PK value for Asistencia which data should be fetched into this Asistencia object</param>
		/// <param name="idEvento">PK value for Asistencia which data should be fetched into this Asistencia object</param>
		/// <param name="validator">The custom validator object for this AsistenciaEntity</param>
		public AsistenciaEntity(System.Int32 idParticipante, System.String idEvento, IValidator validator)
		{
			InitClassFetch(idParticipante, idEvento, validator, null);
		}


		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected AsistenciaEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{


			_evento = (EventoEntity)info.GetValue("_evento", typeof(EventoEntity));
			if(_evento!=null)
			{
				_evento.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_eventoReturnsNewIfNotFound = info.GetBoolean("_eventoReturnsNewIfNotFound");
			_alwaysFetchEvento = info.GetBoolean("_alwaysFetchEvento");
			_alreadyFetchedEvento = info.GetBoolean("_alreadyFetchedEvento");
			_catParrocos = (ParrocoEntity)info.GetValue("_catParrocos", typeof(ParrocoEntity));
			if(_catParrocos!=null)
			{
				_catParrocos.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_catParrocosReturnsNewIfNotFound = info.GetBoolean("_catParrocosReturnsNewIfNotFound");
			_alwaysFetchCatParrocos = info.GetBoolean("_alwaysFetchCatParrocos");
			_alreadyFetchedCatParrocos = info.GetBoolean("_alreadyFetchedCatParrocos");
			_catParroquias = (ParroquiaEntity)info.GetValue("_catParroquias", typeof(ParroquiaEntity));
			if(_catParroquias!=null)
			{
				_catParroquias.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_catParroquiasReturnsNewIfNotFound = info.GetBoolean("_catParroquiasReturnsNewIfNotFound");
			_alwaysFetchCatParroquias = info.GetBoolean("_alwaysFetchCatParroquias");
			_alreadyFetchedCatParroquias = info.GetBoolean("_alreadyFetchedCatParroquias");
			_participante = (ParticipanteEntity)info.GetValue("_participante", typeof(ParticipanteEntity));
			if(_participante!=null)
			{
				_participante.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_participanteReturnsNewIfNotFound = info.GetBoolean("_participanteReturnsNewIfNotFound");
			_alwaysFetchParticipante = info.GetBoolean("_alwaysFetchParticipante");
			_alreadyFetchedParticipante = info.GetBoolean("_alreadyFetchedParticipante");

			base.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
			
		}

		
		/// <summary> Will perform post-ReadXml actions</summary>
		protected override void PostReadXmlFixups()
		{


			_alreadyFetchedEvento = (_evento != null);
			_alreadyFetchedCatParrocos = (_catParrocos != null);
			_alreadyFetchedCatParroquias = (_catParroquias != null);
			_alreadyFetchedParticipante = (_participante != null);

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


			info.AddValue("_evento", _evento);
			info.AddValue("_eventoReturnsNewIfNotFound", _eventoReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchEvento", _alwaysFetchEvento);
			info.AddValue("_alreadyFetchedEvento", _alreadyFetchedEvento);
			info.AddValue("_catParrocos", _catParrocos);
			info.AddValue("_catParrocosReturnsNewIfNotFound", _catParrocosReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchCatParrocos", _alwaysFetchCatParrocos);
			info.AddValue("_alreadyFetchedCatParrocos", _alreadyFetchedCatParrocos);
			info.AddValue("_catParroquias", _catParroquias);
			info.AddValue("_catParroquiasReturnsNewIfNotFound", _catParroquiasReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchCatParroquias", _alwaysFetchCatParroquias);
			info.AddValue("_alreadyFetchedCatParroquias", _alreadyFetchedCatParroquias);
			info.AddValue("_participante", _participante);
			info.AddValue("_participanteReturnsNewIfNotFound", _participanteReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchParticipante", _alwaysFetchParticipante);
			info.AddValue("_alreadyFetchedParticipante", _alreadyFetchedParticipante);

			
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
				case "Evento":
					_alreadyFetchedEvento = true;
					this.Evento = (EventoEntity)entity;
					break;
				case "CatParrocos":
					_alreadyFetchedCatParrocos = true;
					this.CatParrocos = (ParrocoEntity)entity;
					break;
				case "CatParroquias":
					_alreadyFetchedCatParroquias = true;
					this.CatParroquias = (ParroquiaEntity)entity;
					break;
				case "Participante":
					_alreadyFetchedParticipante = true;
					this.Participante = (ParticipanteEntity)entity;
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
				case "Evento":
					SetupSyncEvento(relatedEntity);
					OnRelatedEntitySet(relatedEntity, fieldName);
					break;
				case "CatParrocos":
					SetupSyncCatParrocos(relatedEntity);
					OnRelatedEntitySet(relatedEntity, fieldName);
					break;
				case "CatParroquias":
					SetupSyncCatParroquias(relatedEntity);
					OnRelatedEntitySet(relatedEntity, fieldName);
					break;
				case "Participante":
					SetupSyncParticipante(relatedEntity);
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
				case "Evento":
					DesetupSyncEvento(false, true);
					OnRelatedEntityUnset(relatedEntity, fieldName);
					break;
				case "CatParrocos":
					DesetupSyncCatParrocos(false, true);
					OnRelatedEntityUnset(relatedEntity, fieldName);
					break;
				case "CatParroquias":
					DesetupSyncCatParroquias(false, true);
					OnRelatedEntityUnset(relatedEntity, fieldName);
					break;
				case "Participante":
					DesetupSyncParticipante(false, true);
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
			if(_evento!=null)
			{
				toReturn.Add(_evento);
			}
			if(_catParrocos!=null)
			{
				toReturn.Add(_catParrocos);
			}
			if(_catParroquias!=null)
			{
				toReturn.Add(_catParroquias);
			}
			if(_participante!=null)
			{
				toReturn.Add(_participante);
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
		/// <param name="idParticipante">PK value for Asistencia which data should be fetched into this Asistencia object</param>
		/// <param name="idEvento">PK value for Asistencia which data should be fetched into this Asistencia object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 idParticipante, System.String idEvento)
		{
			return FetchUsingPK(idParticipante, idEvento, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="idParticipante">PK value for Asistencia which data should be fetched into this Asistencia object</param>
		/// <param name="idEvento">PK value for Asistencia which data should be fetched into this Asistencia object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 idParticipante, System.String idEvento, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(idParticipante, idEvento, prefetchPathToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="idParticipante">PK value for Asistencia which data should be fetched into this Asistencia object</param>
		/// <param name="idEvento">PK value for Asistencia which data should be fetched into this Asistencia object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 idParticipante, System.String idEvento, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return Fetch(idParticipante, idEvento, prefetchPathToUse, contextToUse);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. 
		/// Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.IdParticipante, this.IdEvento, null, null);
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
		public bool TestOriginalFieldValueForNull(AsistenciaFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}
		
		/// <summary>Returns true if the current value for the field with the fieldIndex passed in represents null/not defined, false otherwise.
		/// Should not be used for testing if the original value (read from the db) is NULL</summary>
		/// <param name="fieldIndex">Index of the field to test if its currentvalue is null/undefined</param>
		/// <returns>true if the field's value isn't defined yet, false otherwise</returns>
		public bool TestCurrentFieldValueForNull(AsistenciaFieldIndex fieldIndex)
		{
			return base.CheckIfCurrentFieldValueIsNull((int)fieldIndex);
		}





		/// <summary> Retrieves the related entity of type 'EventoEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'EventoEntity' which is related to this entity.</returns>
		public EventoEntity GetSingleEvento()
		{
			return GetSingleEvento(false);
		}

		/// <summary> Retrieves the related entity of type 'EventoEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'EventoEntity' which is related to this entity.</returns>
		public virtual EventoEntity GetSingleEvento(bool forceFetch)
		{
			if( ( !_alreadyFetchedEvento || forceFetch || _alwaysFetchEvento) && !base.IsSerializing && !base.IsDeserializing )			
			{

				EventoEntity newEntity = new EventoEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = false;
				if(base.CheckIfLazyLoadingShouldOccur(AsistenciaEntity.Relations.EventoEntityUsingIdEvento))
				{
					fetchResult = newEntity.FetchUsingPK(this.IdEvento);
				}
				if(!_eventoReturnsNewIfNotFound && !fetchResult)
				{
					this.Evento = null;
				}
				else
				{
					if((base.ActiveContext!=null)&&fetchResult)
					{
						newEntity = (EventoEntity)base.ActiveContext.Get(newEntity);
					}
					this.Evento = newEntity;
					_alreadyFetchedEvento = fetchResult;
				}
				if(base.ParticipatesInTransaction && !fetchResult)
				{
					base.Transaction.Remove(newEntity);
				}
			}
			return _evento;
		}

		/// <summary> Retrieves the related entity of type 'ParrocoEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'ParrocoEntity' which is related to this entity.</returns>
		public ParrocoEntity GetSingleCatParrocos()
		{
			return GetSingleCatParrocos(false);
		}

		/// <summary> Retrieves the related entity of type 'ParrocoEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'ParrocoEntity' which is related to this entity.</returns>
		public virtual ParrocoEntity GetSingleCatParrocos(bool forceFetch)
		{
			if( ( !_alreadyFetchedCatParrocos || forceFetch || _alwaysFetchCatParrocos) && !base.IsSerializing && !base.IsDeserializing )			
			{

				ParrocoEntity newEntity = new ParrocoEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = false;
				if(base.CheckIfLazyLoadingShouldOccur(AsistenciaEntity.Relations.ParrocoEntityUsingCodParroco))
				{
					fetchResult = newEntity.FetchUsingPK(this.CodParroco);
				}
				if(!_catParrocosReturnsNewIfNotFound && !fetchResult)
				{
					this.CatParrocos = null;
				}
				else
				{
					if((base.ActiveContext!=null)&&fetchResult)
					{
						newEntity = (ParrocoEntity)base.ActiveContext.Get(newEntity);
					}
					this.CatParrocos = newEntity;
					_alreadyFetchedCatParrocos = fetchResult;
				}
				if(base.ParticipatesInTransaction && !fetchResult)
				{
					base.Transaction.Remove(newEntity);
				}
			}
			return _catParrocos;
		}

		/// <summary> Retrieves the related entity of type 'ParroquiaEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'ParroquiaEntity' which is related to this entity.</returns>
		public ParroquiaEntity GetSingleCatParroquias()
		{
			return GetSingleCatParroquias(false);
		}

		/// <summary> Retrieves the related entity of type 'ParroquiaEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'ParroquiaEntity' which is related to this entity.</returns>
		public virtual ParroquiaEntity GetSingleCatParroquias(bool forceFetch)
		{
			if( ( !_alreadyFetchedCatParroquias || forceFetch || _alwaysFetchCatParroquias) && !base.IsSerializing && !base.IsDeserializing )			
			{

				ParroquiaEntity newEntity = new ParroquiaEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = false;
				if(base.CheckIfLazyLoadingShouldOccur(AsistenciaEntity.Relations.ParroquiaEntityUsingCodParroquia))
				{
					fetchResult = newEntity.FetchUsingPK(this.CodParroquia);
				}
				if(!_catParroquiasReturnsNewIfNotFound && !fetchResult)
				{
					this.CatParroquias = null;
				}
				else
				{
					if((base.ActiveContext!=null)&&fetchResult)
					{
						newEntity = (ParroquiaEntity)base.ActiveContext.Get(newEntity);
					}
					this.CatParroquias = newEntity;
					_alreadyFetchedCatParroquias = fetchResult;
				}
				if(base.ParticipatesInTransaction && !fetchResult)
				{
					base.Transaction.Remove(newEntity);
				}
			}
			return _catParroquias;
		}

		/// <summary> Retrieves the related entity of type 'ParticipanteEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'ParticipanteEntity' which is related to this entity.</returns>
		public ParticipanteEntity GetSingleParticipante()
		{
			return GetSingleParticipante(false);
		}

		/// <summary> Retrieves the related entity of type 'ParticipanteEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'ParticipanteEntity' which is related to this entity.</returns>
		public virtual ParticipanteEntity GetSingleParticipante(bool forceFetch)
		{
			if( ( !_alreadyFetchedParticipante || forceFetch || _alwaysFetchParticipante) && !base.IsSerializing && !base.IsDeserializing )			
			{

				ParticipanteEntity newEntity = new ParticipanteEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = false;
				if(base.CheckIfLazyLoadingShouldOccur(AsistenciaEntity.Relations.ParticipanteEntityUsingIdParticipante))
				{
					fetchResult = newEntity.FetchUsingPK(this.IdParticipante);
				}
				if(!_participanteReturnsNewIfNotFound && !fetchResult)
				{
					this.Participante = null;
				}
				else
				{
					if((base.ActiveContext!=null)&&fetchResult)
					{
						newEntity = (ParticipanteEntity)base.ActiveContext.Get(newEntity);
					}
					this.Participante = newEntity;
					_alreadyFetchedParticipante = fetchResult;
				}
				if(base.ParticipatesInTransaction && !fetchResult)
				{
					base.Transaction.Remove(newEntity);
				}
			}
			return _participante;
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
			if(toReturn && Enum.IsDefined(typeof(AsistenciaFieldIndex), fieldIndex))
			{
				switch((AsistenciaFieldIndex)fieldIndex)
				{
					case AsistenciaFieldIndex.IdParticipante:
						DesetupSyncParticipante(true, false);
						_alreadyFetchedParticipante = false;
						break;
					case AsistenciaFieldIndex.IdEvento:
						DesetupSyncEvento(true, false);
						_alreadyFetchedEvento = false;
						break;
					case AsistenciaFieldIndex.CodParroquia:
						DesetupSyncCatParroquias(true, false);
						_alreadyFetchedCatParroquias = false;
						break;
					case AsistenciaFieldIndex.CodParroco:
						DesetupSyncCatParrocos(true, false);
						_alreadyFetchedCatParrocos = false;
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
			AsistenciaDAO dao = (AsistenciaDAO)CreateDAOInstance();
			return dao.AddNew(base.Fields, base.Transaction);
		}
		
		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{


			if(_evento!=null)
			{
				_evento.ActiveContext = base.ActiveContext;
			}
			if(_catParrocos!=null)
			{
				_catParrocos.ActiveContext = base.ActiveContext;
			}
			if(_catParroquias!=null)
			{
				_catParroquias.ActiveContext = base.ActiveContext;
			}
			if(_participante!=null)
			{
				_participante.ActiveContext = base.ActiveContext;
			}


		}


		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity()
		{
			AsistenciaDAO dao = (AsistenciaDAO)CreateDAOInstance();
			return dao.UpdateExisting(base.Fields, base.Transaction);
		}
		
		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			AsistenciaDAO dao = (AsistenciaDAO)CreateDAOInstance();
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
			return EntityFieldsFactory.CreateEntityFieldsObject(ORMDiocesis.EntityType.AsistenciaEntity);
		}


		/// <summary> Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		/// <param name="idParticipante">PK value for Asistencia which data should be fetched into this Asistencia object</param>
		/// <param name="idEvento">PK value for Asistencia which data should be fetched into this Asistencia object</param>
		/// <param name="validator">The validator object for this AsistenciaEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		protected virtual void InitClassFetch(System.Int32 idParticipante, System.String idEvento, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			InitClassMembers();

			base.Fields = CreateFields();
			bool wasSuccesful = Fetch(idParticipante, idEvento, prefetchPathToUse, null);
			base.IsNew = !wasSuccesful;
			base.Validator = validator;

			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END
			

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{


			_evento = null;
			_eventoReturnsNewIfNotFound = true;
			_alwaysFetchEvento = false;
			_alreadyFetchedEvento = false;
			_catParrocos = null;
			_catParrocosReturnsNewIfNotFound = true;
			_alwaysFetchCatParrocos = false;
			_alreadyFetchedCatParrocos = false;
			_catParroquias = null;
			_catParroquiasReturnsNewIfNotFound = true;
			_alwaysFetchCatParroquias = false;
			_alreadyFetchedCatParroquias = false;
			_participante = null;
			_participanteReturnsNewIfNotFound = true;
			_alwaysFetchParticipante = false;
			_alreadyFetchedParticipante = false;

			
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

			_fieldsCustomProperties.Add("IdParticipante", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("IdEvento", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Domicilio", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("IdCiudad", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Telefono", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Celular", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("RedesSociales", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("GradoEscolar", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("CodParroquia", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("CodParroco", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("IdEquipo", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Seccion", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Observaciones", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Foto", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("EMail", fieldHashtable);
		}
		#endregion


		/// <summary> Removes the sync logic for member _evento</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncEvento(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _evento, new PropertyChangedEventHandler( OnEventoPropertyChanged ), "Evento", AsistenciaEntity.Relations.EventoEntityUsingIdEvento, true, signalRelatedEntity, "Asistencias", resetFKFields, new int[] { (int)AsistenciaFieldIndex.IdEvento } );		
			_evento = null;
		}
		
		/// <summary> setups the sync logic for member _evento</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncEvento(IEntity relatedEntity)
		{
			DesetupSyncEvento(true, true);
			_evento = (EventoEntity)relatedEntity;
			base.PerformSetupSyncRelatedEntity( _evento, new PropertyChangedEventHandler( OnEventoPropertyChanged ), "Evento", AsistenciaEntity.Relations.EventoEntityUsingIdEvento, true, ref _alreadyFetchedEvento, new string[] {  } );
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnEventoPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _catParrocos</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncCatParrocos(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _catParrocos, new PropertyChangedEventHandler( OnCatParrocosPropertyChanged ), "CatParrocos", AsistenciaEntity.Relations.ParrocoEntityUsingCodParroco, true, signalRelatedEntity, "Asistencias", resetFKFields, new int[] { (int)AsistenciaFieldIndex.CodParroco } );		
			_catParrocos = null;
		}
		
		/// <summary> setups the sync logic for member _catParrocos</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncCatParrocos(IEntity relatedEntity)
		{
			DesetupSyncCatParrocos(true, true);
			_catParrocos = (ParrocoEntity)relatedEntity;
			base.PerformSetupSyncRelatedEntity( _catParrocos, new PropertyChangedEventHandler( OnCatParrocosPropertyChanged ), "CatParrocos", AsistenciaEntity.Relations.ParrocoEntityUsingCodParroco, true, ref _alreadyFetchedCatParrocos, new string[] {  } );
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnCatParrocosPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _catParroquias</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncCatParroquias(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _catParroquias, new PropertyChangedEventHandler( OnCatParroquiasPropertyChanged ), "CatParroquias", AsistenciaEntity.Relations.ParroquiaEntityUsingCodParroquia, true, signalRelatedEntity, "", resetFKFields, new int[] { (int)AsistenciaFieldIndex.CodParroquia } );		
			_catParroquias = null;
		}
		
		/// <summary> setups the sync logic for member _catParroquias</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncCatParroquias(IEntity relatedEntity)
		{
			DesetupSyncCatParroquias(true, true);
			_catParroquias = (ParroquiaEntity)relatedEntity;
			base.PerformSetupSyncRelatedEntity( _catParroquias, new PropertyChangedEventHandler( OnCatParroquiasPropertyChanged ), "CatParroquias", AsistenciaEntity.Relations.ParroquiaEntityUsingCodParroquia, true, ref _alreadyFetchedCatParroquias, new string[] {  } );
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnCatParroquiasPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _participante</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncParticipante(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _participante, new PropertyChangedEventHandler( OnParticipantePropertyChanged ), "Participante", AsistenciaEntity.Relations.ParticipanteEntityUsingIdParticipante, true, signalRelatedEntity, "Asistencias", resetFKFields, new int[] { (int)AsistenciaFieldIndex.IdParticipante } );		
			_participante = null;
		}
		
		/// <summary> setups the sync logic for member _participante</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncParticipante(IEntity relatedEntity)
		{
			DesetupSyncParticipante(true, true);
			_participante = (ParticipanteEntity)relatedEntity;
			base.PerformSetupSyncRelatedEntity( _participante, new PropertyChangedEventHandler( OnParticipantePropertyChanged ), "Participante", AsistenciaEntity.Relations.ParticipanteEntityUsingIdParticipante, true, ref _alreadyFetchedParticipante, new string[] {  } );
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnParticipantePropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}


		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="idParticipante">PK value for Asistencia which data should be fetched into this Asistencia object</param>
		/// <param name="idEvento">PK value for Asistencia which data should be fetched into this Asistencia object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 idParticipante, System.String idEvento, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			try
			{
				OnFetch();
				IDao dao = this.CreateDAOInstance();
				base.Fields[(int)AsistenciaFieldIndex.IdParticipante].ForcedCurrentValueWrite(idParticipante);
				base.Fields[(int)AsistenciaFieldIndex.IdEvento].ForcedCurrentValueWrite(idEvento);
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
			return DAOFactory.CreateAsistenciaDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new AsistenciaEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static AsistenciaRelations Relations
		{
			get	{ return new AsistenciaRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}




		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Evento' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathEvento
		{
			get
			{
				return new PrefetchPathElement(new ORMDiocesis.CollectionClasses.EventoCollection(),
					AsistenciaEntity.Relations.EventoEntityUsingIdEvento, 
					(int)ORMDiocesis.EntityType.AsistenciaEntity, (int)ORMDiocesis.EntityType.EventoEntity, 0, null, null, null, "Evento", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Parroco' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathCatParrocos
		{
			get
			{
				return new PrefetchPathElement(new ORMDiocesis.CollectionClasses.ParrocoCollection(),
					AsistenciaEntity.Relations.ParrocoEntityUsingCodParroco, 
					(int)ORMDiocesis.EntityType.AsistenciaEntity, (int)ORMDiocesis.EntityType.ParrocoEntity, 0, null, null, null, "CatParrocos", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Parroquia' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathCatParroquias
		{
			get
			{
				return new PrefetchPathElement(new ORMDiocesis.CollectionClasses.ParroquiaCollection(),
					AsistenciaEntity.Relations.ParroquiaEntityUsingCodParroquia, 
					(int)ORMDiocesis.EntityType.AsistenciaEntity, (int)ORMDiocesis.EntityType.ParroquiaEntity, 0, null, null, null, "CatParroquias", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Participante' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathParticipante
		{
			get
			{
				return new PrefetchPathElement(new ORMDiocesis.CollectionClasses.ParticipanteCollection(),
					AsistenciaEntity.Relations.ParticipanteEntityUsingIdParticipante, 
					(int)ORMDiocesis.EntityType.AsistenciaEntity, (int)ORMDiocesis.EntityType.ParticipanteEntity, 0, null, null, null, "Participante", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}


		/// <summary>Returns the full name for this entity, which is important for the DAO to find back persistence info for this entity.</summary>
		[Browsable(false), XmlIgnore]
		public override string LLBLGenProEntityName
		{
			get { return "AsistenciaEntity";}
		}

		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public virtual Dictionary<string, string> CustomPropertiesOfType
		{
			get { return AsistenciaEntity.CustomProperties;}
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
			get { return AsistenciaEntity.FieldsCustomProperties;}
		}

		/// <summary> The IdParticipante property of the Entity Asistencia<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "SemAsistencia"."IdParticipante"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Int32 IdParticipante
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)AsistenciaFieldIndex.IdParticipante);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.Int32));
				}
				return (System.Int32)valueToReturn;
			}
			set	{ SetNewFieldValue((int)AsistenciaFieldIndex.IdParticipante, value); }
		}
		/// <summary> The IdEvento property of the Entity Asistencia<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "SemAsistencia"."IdEvento"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.String IdEvento
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)AsistenciaFieldIndex.IdEvento);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
				return (System.String)valueToReturn;
			}
			set	{ SetNewFieldValue((int)AsistenciaFieldIndex.IdEvento, value); }
		}
		/// <summary> The Domicilio property of the Entity Asistencia<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "SemAsistencia"."Domicilio"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 100<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Domicilio
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)AsistenciaFieldIndex.Domicilio);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
				return (System.String)valueToReturn;
			}
			set	{ SetNewFieldValue((int)AsistenciaFieldIndex.Domicilio, value); }
		}
		/// <summary> The IdCiudad property of the Entity Asistencia<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "SemAsistencia"."IdCiudad"<br/>
		/// Table field type characteristics (type, precision, scale, length): TinyInt, 3, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Byte> IdCiudad
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)AsistenciaFieldIndex.IdCiudad);

				return (Nullable<System.Byte>)valueToReturn;
			}
			set	{ SetNewFieldValue((int)AsistenciaFieldIndex.IdCiudad, value); }
		}
		/// <summary> The Telefono property of the Entity Asistencia<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "SemAsistencia"."Telefono"<br/>
		/// Table field type characteristics (type, precision, scale, length): NChar, 0, 0, 20<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Telefono
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)AsistenciaFieldIndex.Telefono);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
				return (System.String)valueToReturn;
			}
			set	{ SetNewFieldValue((int)AsistenciaFieldIndex.Telefono, value); }
		}
		/// <summary> The Celular property of the Entity Asistencia<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "SemAsistencia"."Celular"<br/>
		/// Table field type characteristics (type, precision, scale, length): NChar, 0, 0, 20<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Celular
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)AsistenciaFieldIndex.Celular);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
				return (System.String)valueToReturn;
			}
			set	{ SetNewFieldValue((int)AsistenciaFieldIndex.Celular, value); }
		}
		/// <summary> The RedesSociales property of the Entity Asistencia<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "SemAsistencia"."RedesSociales"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 100<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String RedesSociales
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)AsistenciaFieldIndex.RedesSociales);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
				return (System.String)valueToReturn;
			}
			set	{ SetNewFieldValue((int)AsistenciaFieldIndex.RedesSociales, value); }
		}
		/// <summary> The GradoEscolar property of the Entity Asistencia<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "SemAsistencia"."GradoEscolar"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 30<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String GradoEscolar
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)AsistenciaFieldIndex.GradoEscolar);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
				return (System.String)valueToReturn;
			}
			set	{ SetNewFieldValue((int)AsistenciaFieldIndex.GradoEscolar, value); }
		}
		/// <summary> The CodParroquia property of the Entity Asistencia<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "SemAsistencia"."CodParroqia"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 CodParroquia
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)AsistenciaFieldIndex.CodParroquia);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.Int32));
				}
				return (System.Int32)valueToReturn;
			}
			set	{ SetNewFieldValue((int)AsistenciaFieldIndex.CodParroquia, value); }
		}
		/// <summary> The CodParroco property of the Entity Asistencia<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "SemAsistencia"."CodSacerdote"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 CodParroco
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)AsistenciaFieldIndex.CodParroco);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.Int32));
				}
				return (System.Int32)valueToReturn;
			}
			set	{ SetNewFieldValue((int)AsistenciaFieldIndex.CodParroco, value); }
		}
		/// <summary> The IdEquipo property of the Entity Asistencia<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "SemAsistencia"."IdEquipo"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 IdEquipo
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)AsistenciaFieldIndex.IdEquipo);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.Int32));
				}
				return (System.Int32)valueToReturn;
			}
			set	{ SetNewFieldValue((int)AsistenciaFieldIndex.IdEquipo, value); }
		}
		/// <summary> The Seccion property of the Entity Asistencia<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "SemAsistencia"."Seccion"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> Seccion
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)AsistenciaFieldIndex.Seccion);

				return (Nullable<System.Int32>)valueToReturn;
			}
			set	{ SetNewFieldValue((int)AsistenciaFieldIndex.Seccion, value); }
		}
		/// <summary> The Observaciones property of the Entity Asistencia<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "SemAsistencia"."Observaciones"<br/>
		/// Table field type characteristics (type, precision, scale, length): Text, 0, 0, 2147483647<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Observaciones
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)AsistenciaFieldIndex.Observaciones);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
				return (System.String)valueToReturn;
			}
			set	{ SetNewFieldValue((int)AsistenciaFieldIndex.Observaciones, value); }
		}
		/// <summary> The Foto property of the Entity Asistencia<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "SemAsistencia"."Foto"<br/>
		/// Table field type characteristics (type, precision, scale, length): Image, 0, 0, 2147483647<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.Byte[] Foto
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)AsistenciaFieldIndex.Foto);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.Byte[]));
				}
				return (System.Byte[])valueToReturn;
			}
			set	{ SetNewFieldValue((int)AsistenciaFieldIndex.Foto, value); }
		}
		/// <summary> The EMail property of the Entity Asistencia<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "SemAsistencia"."eMail"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 30<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String EMail
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)AsistenciaFieldIndex.EMail);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
				return (System.String)valueToReturn;
			}
			set	{ SetNewFieldValue((int)AsistenciaFieldIndex.EMail, value); }
		}



		/// <summary> Gets / sets related entity of type 'EventoEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleEvento()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual EventoEntity Evento
		{
			get	{ return GetSingleEvento(false); }
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncEvento(value);
				}
				else
				{
					if(value==null)
					{
						if(_evento != null)
						{
							_evento.UnsetRelatedEntity(this, "Asistencias");
						}
					}
					else
					{
						((IEntity)value).SetRelatedEntity(this, "Asistencias");
					}
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for Evento. When set to true, Evento is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Evento is accessed. You can always execute
		/// a forced fetch by calling GetSingleEvento(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchEvento
		{
			get	{ return _alwaysFetchEvento; }
			set	{ _alwaysFetchEvento = value; }	
		}
		
		/// <summary> Gets / sets the flag for what to do if the related entity available through the property Evento is not found
		/// in the database. When set to true, Evento will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool EventoReturnsNewIfNotFound
		{
			get	{ return _eventoReturnsNewIfNotFound; }
			set { _eventoReturnsNewIfNotFound = value; }	
		}
		/// <summary> Gets / sets related entity of type 'ParrocoEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleCatParrocos()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual ParrocoEntity CatParrocos
		{
			get	{ return GetSingleCatParrocos(false); }
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncCatParrocos(value);
				}
				else
				{
					if(value==null)
					{
						if(_catParrocos != null)
						{
							_catParrocos.UnsetRelatedEntity(this, "Asistencias");
						}
					}
					else
					{
						((IEntity)value).SetRelatedEntity(this, "Asistencias");
					}
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for CatParrocos. When set to true, CatParrocos is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time CatParrocos is accessed. You can always execute
		/// a forced fetch by calling GetSingleCatParrocos(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchCatParrocos
		{
			get	{ return _alwaysFetchCatParrocos; }
			set	{ _alwaysFetchCatParrocos = value; }	
		}
		
		/// <summary> Gets / sets the flag for what to do if the related entity available through the property CatParrocos is not found
		/// in the database. When set to true, CatParrocos will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool CatParrocosReturnsNewIfNotFound
		{
			get	{ return _catParrocosReturnsNewIfNotFound; }
			set { _catParrocosReturnsNewIfNotFound = value; }	
		}
		/// <summary> Gets / sets related entity of type 'ParroquiaEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleCatParroquias()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual ParroquiaEntity CatParroquias
		{
			get	{ return GetSingleCatParroquias(false); }
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncCatParroquias(value);
				}
				else
				{
					if(value==null)
					{
						if(_catParroquias != null)
						{
							UnsetRelatedEntity(_catParroquias, "CatParroquias");
						}
					}
					else
					{
						SetRelatedEntity((IEntity)value, "CatParroquias");
					}
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for CatParroquias. When set to true, CatParroquias is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time CatParroquias is accessed. You can always execute
		/// a forced fetch by calling GetSingleCatParroquias(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchCatParroquias
		{
			get	{ return _alwaysFetchCatParroquias; }
			set	{ _alwaysFetchCatParroquias = value; }	
		}
		
		/// <summary> Gets / sets the flag for what to do if the related entity available through the property CatParroquias is not found
		/// in the database. When set to true, CatParroquias will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool CatParroquiasReturnsNewIfNotFound
		{
			get	{ return _catParroquiasReturnsNewIfNotFound; }
			set { _catParroquiasReturnsNewIfNotFound = value; }	
		}
		/// <summary> Gets / sets related entity of type 'ParticipanteEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleParticipante()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual ParticipanteEntity Participante
		{
			get	{ return GetSingleParticipante(false); }
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncParticipante(value);
				}
				else
				{
					if(value==null)
					{
						if(_participante != null)
						{
							_participante.UnsetRelatedEntity(this, "Asistencias");
						}
					}
					else
					{
						((IEntity)value).SetRelatedEntity(this, "Asistencias");
					}
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for Participante. When set to true, Participante is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Participante is accessed. You can always execute
		/// a forced fetch by calling GetSingleParticipante(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchParticipante
		{
			get	{ return _alwaysFetchParticipante; }
			set	{ _alwaysFetchParticipante = value; }	
		}
		
		/// <summary> Gets / sets the flag for what to do if the related entity available through the property Participante is not found
		/// in the database. When set to true, Participante will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool ParticipanteReturnsNewIfNotFound
		{
			get	{ return _participanteReturnsNewIfNotFound; }
			set { _participanteReturnsNewIfNotFound = value; }	
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
			get { return (int)ORMDiocesis.EntityType.AsistenciaEntity; }
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
