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
	/// Entity class which represents the entity 'Pais'. <br/><br/>
	/// 
	/// </summary>
#if CF
	[SD.LLBLGen.Pro.ORMSupportClasses.Serializable]
#else
	[Serializable]
#endif
	public partial class PaisEntity : EntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END
			
	{
		#region Class Member Declarations
		private ORMDiocesis.CollectionClasses.AutorCollection	_autores;
		private bool	_alwaysFetchAutores, _alreadyFetchedAutores;
		private ORMDiocesis.CollectionClasses.LibroCollection	_libros;
		private bool	_alwaysFetchLibros, _alreadyFetchedLibros;
		private ORMDiocesis.CollectionClasses.LibroEstatusCollection _bcatEstatusCollectionViaLibro;
		private bool	_alwaysFetchBcatEstatusCollectionViaLibro, _alreadyFetchedBcatEstatusCollectionViaLibro;
		private ORMDiocesis.CollectionClasses.LibroFormatoCollection _bcatFormatoCollectionViaLibro;
		private bool	_alwaysFetchBcatFormatoCollectionViaLibro, _alreadyFetchedBcatFormatoCollectionViaLibro;
		private ORMDiocesis.CollectionClasses.RamaCollection _ramaCollectionViaLibro;
		private bool	_alwaysFetchRamaCollectionViaLibro, _alreadyFetchedRamaCollectionViaLibro;
		private ORMDiocesis.CollectionClasses.SeccionCollection _seccionCollectionViaLibro;
		private bool	_alwaysFetchSeccionCollectionViaLibro, _alreadyFetchedSeccionCollectionViaLibro;
		private ORMDiocesis.CollectionClasses.TematicaCollection _tematicaCollectionViaLibro;
		private bool	_alwaysFetchTematicaCollectionViaLibro, _alreadyFetchedTematicaCollectionViaLibro;



		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;
		
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static PaisEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public PaisEntity()
		{
			InitClassEmpty(CreateValidator());
		}


		/// <summary>CTor</summary>
		/// <param name="id">PK value for Pais which data should be fetched into this Pais object</param>
		public PaisEntity(System.Int32 id)
		{
			InitClassFetch(id, CreateValidator(), null);
		}

		/// <summary>CTor</summary>
		/// <param name="id">PK value for Pais which data should be fetched into this Pais object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public PaisEntity(System.Int32 id, IPrefetchPath prefetchPathToUse)
		{
			InitClassFetch(id, CreateValidator(), prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="id">PK value for Pais which data should be fetched into this Pais object</param>
		/// <param name="validator">The custom validator object for this PaisEntity</param>
		public PaisEntity(System.Int32 id, IValidator validator)
		{
			InitClassFetch(id, validator, null);
		}


		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected PaisEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_autores = (ORMDiocesis.CollectionClasses.AutorCollection)info.GetValue("_autores", typeof(ORMDiocesis.CollectionClasses.AutorCollection));
			_alwaysFetchAutores = info.GetBoolean("_alwaysFetchAutores");
			_alreadyFetchedAutores = info.GetBoolean("_alreadyFetchedAutores");
			_libros = (ORMDiocesis.CollectionClasses.LibroCollection)info.GetValue("_libros", typeof(ORMDiocesis.CollectionClasses.LibroCollection));
			_alwaysFetchLibros = info.GetBoolean("_alwaysFetchLibros");
			_alreadyFetchedLibros = info.GetBoolean("_alreadyFetchedLibros");
			_bcatEstatusCollectionViaLibro = (ORMDiocesis.CollectionClasses.LibroEstatusCollection)info.GetValue("_bcatEstatusCollectionViaLibro", typeof(ORMDiocesis.CollectionClasses.LibroEstatusCollection));
			_alwaysFetchBcatEstatusCollectionViaLibro = info.GetBoolean("_alwaysFetchBcatEstatusCollectionViaLibro");
			_alreadyFetchedBcatEstatusCollectionViaLibro = info.GetBoolean("_alreadyFetchedBcatEstatusCollectionViaLibro");
			_bcatFormatoCollectionViaLibro = (ORMDiocesis.CollectionClasses.LibroFormatoCollection)info.GetValue("_bcatFormatoCollectionViaLibro", typeof(ORMDiocesis.CollectionClasses.LibroFormatoCollection));
			_alwaysFetchBcatFormatoCollectionViaLibro = info.GetBoolean("_alwaysFetchBcatFormatoCollectionViaLibro");
			_alreadyFetchedBcatFormatoCollectionViaLibro = info.GetBoolean("_alreadyFetchedBcatFormatoCollectionViaLibro");
			_ramaCollectionViaLibro = (ORMDiocesis.CollectionClasses.RamaCollection)info.GetValue("_ramaCollectionViaLibro", typeof(ORMDiocesis.CollectionClasses.RamaCollection));
			_alwaysFetchRamaCollectionViaLibro = info.GetBoolean("_alwaysFetchRamaCollectionViaLibro");
			_alreadyFetchedRamaCollectionViaLibro = info.GetBoolean("_alreadyFetchedRamaCollectionViaLibro");
			_seccionCollectionViaLibro = (ORMDiocesis.CollectionClasses.SeccionCollection)info.GetValue("_seccionCollectionViaLibro", typeof(ORMDiocesis.CollectionClasses.SeccionCollection));
			_alwaysFetchSeccionCollectionViaLibro = info.GetBoolean("_alwaysFetchSeccionCollectionViaLibro");
			_alreadyFetchedSeccionCollectionViaLibro = info.GetBoolean("_alreadyFetchedSeccionCollectionViaLibro");
			_tematicaCollectionViaLibro = (ORMDiocesis.CollectionClasses.TematicaCollection)info.GetValue("_tematicaCollectionViaLibro", typeof(ORMDiocesis.CollectionClasses.TematicaCollection));
			_alwaysFetchTematicaCollectionViaLibro = info.GetBoolean("_alwaysFetchTematicaCollectionViaLibro");
			_alreadyFetchedTematicaCollectionViaLibro = info.GetBoolean("_alreadyFetchedTematicaCollectionViaLibro");


			base.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
			
		}

		
		/// <summary> Will perform post-ReadXml actions</summary>
		protected override void PostReadXmlFixups()
		{
			_alreadyFetchedAutores = (_autores.Count > 0);
			_alreadyFetchedLibros = (_libros.Count > 0);
			_alreadyFetchedBcatEstatusCollectionViaLibro = (_bcatEstatusCollectionViaLibro.Count > 0);
			_alreadyFetchedBcatFormatoCollectionViaLibro = (_bcatFormatoCollectionViaLibro.Count > 0);
			_alreadyFetchedRamaCollectionViaLibro = (_ramaCollectionViaLibro.Count > 0);
			_alreadyFetchedSeccionCollectionViaLibro = (_seccionCollectionViaLibro.Count > 0);
			_alreadyFetchedTematicaCollectionViaLibro = (_tematicaCollectionViaLibro.Count > 0);


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
			info.AddValue("_autores", _autores);
			info.AddValue("_alwaysFetchAutores", _alwaysFetchAutores);
			info.AddValue("_alreadyFetchedAutores", _alreadyFetchedAutores);
			info.AddValue("_libros", _libros);
			info.AddValue("_alwaysFetchLibros", _alwaysFetchLibros);
			info.AddValue("_alreadyFetchedLibros", _alreadyFetchedLibros);
			info.AddValue("_bcatEstatusCollectionViaLibro", _bcatEstatusCollectionViaLibro);
			info.AddValue("_alwaysFetchBcatEstatusCollectionViaLibro", _alwaysFetchBcatEstatusCollectionViaLibro);
			info.AddValue("_alreadyFetchedBcatEstatusCollectionViaLibro", _alreadyFetchedBcatEstatusCollectionViaLibro);
			info.AddValue("_bcatFormatoCollectionViaLibro", _bcatFormatoCollectionViaLibro);
			info.AddValue("_alwaysFetchBcatFormatoCollectionViaLibro", _alwaysFetchBcatFormatoCollectionViaLibro);
			info.AddValue("_alreadyFetchedBcatFormatoCollectionViaLibro", _alreadyFetchedBcatFormatoCollectionViaLibro);
			info.AddValue("_ramaCollectionViaLibro", _ramaCollectionViaLibro);
			info.AddValue("_alwaysFetchRamaCollectionViaLibro", _alwaysFetchRamaCollectionViaLibro);
			info.AddValue("_alreadyFetchedRamaCollectionViaLibro", _alreadyFetchedRamaCollectionViaLibro);
			info.AddValue("_seccionCollectionViaLibro", _seccionCollectionViaLibro);
			info.AddValue("_alwaysFetchSeccionCollectionViaLibro", _alwaysFetchSeccionCollectionViaLibro);
			info.AddValue("_alreadyFetchedSeccionCollectionViaLibro", _alreadyFetchedSeccionCollectionViaLibro);
			info.AddValue("_tematicaCollectionViaLibro", _tematicaCollectionViaLibro);
			info.AddValue("_alwaysFetchTematicaCollectionViaLibro", _alwaysFetchTematicaCollectionViaLibro);
			info.AddValue("_alreadyFetchedTematicaCollectionViaLibro", _alreadyFetchedTematicaCollectionViaLibro);


			
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

				case "Autores":
					_alreadyFetchedAutores = true;
					if(entity!=null)
					{
						this.Autores.Add((AutorEntity)entity);
					}
					break;
				case "Libros":
					_alreadyFetchedLibros = true;
					if(entity!=null)
					{
						this.Libros.Add((LibroEntity)entity);
					}
					break;
				case "BcatEstatusCollectionViaLibro":
					_alreadyFetchedBcatEstatusCollectionViaLibro = true;
					if(entity!=null)
					{
						this.BcatEstatusCollectionViaLibro.Add((LibroEstatusEntity)entity);
					}
					break;
				case "BcatFormatoCollectionViaLibro":
					_alreadyFetchedBcatFormatoCollectionViaLibro = true;
					if(entity!=null)
					{
						this.BcatFormatoCollectionViaLibro.Add((LibroFormatoEntity)entity);
					}
					break;
				case "RamaCollectionViaLibro":
					_alreadyFetchedRamaCollectionViaLibro = true;
					if(entity!=null)
					{
						this.RamaCollectionViaLibro.Add((RamaEntity)entity);
					}
					break;
				case "SeccionCollectionViaLibro":
					_alreadyFetchedSeccionCollectionViaLibro = true;
					if(entity!=null)
					{
						this.SeccionCollectionViaLibro.Add((SeccionEntity)entity);
					}
					break;
				case "TematicaCollectionViaLibro":
					_alreadyFetchedTematicaCollectionViaLibro = true;
					if(entity!=null)
					{
						this.TematicaCollectionViaLibro.Add((TematicaEntity)entity);
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

				case "Autores":
					_autores.Add((AutorEntity)relatedEntity);
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

				case "Autores":
					base.PerformRelatedEntityRemoval(_autores, relatedEntity, signalRelatedEntityManyToOne);
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



			return toReturn;
		}
		
		/// <summary> Gets a List of all entity collections stored as member variables in this entity. The contents of the ArrayList is
		/// used by the DataAccessAdapter to perform recursive saves. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		public override List<IEntityCollection> GetMemberEntityCollections()
		{
			List<IEntityCollection> toReturn = new List<IEntityCollection>();
			toReturn.Add(_autores);
			toReturn.Add(_libros);

			return toReturn;
		}

		

		

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="id">PK value for Pais which data should be fetched into this Pais object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 id)
		{
			return FetchUsingPK(id, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="id">PK value for Pais which data should be fetched into this Pais object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 id, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(id, prefetchPathToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="id">PK value for Pais which data should be fetched into this Pais object</param>
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
		public bool TestOriginalFieldValueForNull(PaisFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}
		
		/// <summary>Returns true if the current value for the field with the fieldIndex passed in represents null/not defined, false otherwise.
		/// Should not be used for testing if the original value (read from the db) is NULL</summary>
		/// <param name="fieldIndex">Index of the field to test if its currentvalue is null/undefined</param>
		/// <returns>true if the field's value isn't defined yet, false otherwise</returns>
		public bool TestCurrentFieldValueForNull(PaisFieldIndex fieldIndex)
		{
			return base.CheckIfCurrentFieldValueIsNull((int)fieldIndex);
		}



		/// <summary> Retrieves all related entities of type 'AutorEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'AutorEntity'</returns>
		public ORMDiocesis.CollectionClasses.AutorCollection GetMultiAutores(bool forceFetch)
		{
			return GetMultiAutores(forceFetch, _autores.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'AutorEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'AutorEntity'</returns>
		public ORMDiocesis.CollectionClasses.AutorCollection GetMultiAutores(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiAutores(forceFetch, _autores.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'AutorEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public ORMDiocesis.CollectionClasses.AutorCollection GetMultiAutores(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiAutores(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'AutorEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual ORMDiocesis.CollectionClasses.AutorCollection GetMultiAutores(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedAutores || forceFetch || _alwaysFetchAutores) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_autores.ParticipatesInTransaction)
					{
						base.Transaction.Add(_autores);
					}
				}
				_autores.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_autores.EntityFactoryToUse = entityFactoryToUse;
				}
				_autores.GetMultiManyToOne(this, filter);
				_autores.SuppressClearInGetMulti=false;
				_alreadyFetchedAutores = true;
			}
			return _autores;
		}

		/// <summary> Sets the collection parameters for the collection for 'Autores'. These settings will be taken into account
		/// when the property Autores is requested or GetMultiAutores is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersAutores(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_autores.SortClauses=sortClauses;
			_autores.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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
				_libros.GetMultiManyToOne(null, null, null, null, null, null, null, this, filter);
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

		/// <summary> Retrieves all related entities of type 'LibroEstatusEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'LibroEstatusEntity'</returns>
		public ORMDiocesis.CollectionClasses.LibroEstatusCollection GetMultiBcatEstatusCollectionViaLibro(bool forceFetch)
		{
			return GetMultiBcatEstatusCollectionViaLibro(forceFetch, _bcatEstatusCollectionViaLibro.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'LibroEstatusEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public ORMDiocesis.CollectionClasses.LibroEstatusCollection GetMultiBcatEstatusCollectionViaLibro(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedBcatEstatusCollectionViaLibro || forceFetch || _alwaysFetchBcatEstatusCollectionViaLibro) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_bcatEstatusCollectionViaLibro.ParticipatesInTransaction)
					{
						base.Transaction.Add(_bcatEstatusCollectionViaLibro);
					}
				}
				IRelationCollection relations = new RelationCollection();
				IPredicateExpression filter = new PredicateExpression();
				relations.Add(PaisEntity.Relations.LibroEntityUsingIdPais, "__PaisEntity__", "Libro_", JoinHint.None);
				relations.Add(LibroEntity.Relations.LibroEstatusEntityUsingEstatus, "Libro_", string.Empty, JoinHint.None);
				filter.Add(new FieldCompareValuePredicate(EntityFieldFactory.Create(PaisFieldIndex.Id), ComparisonOperator.Equal, this.Id));
				_bcatEstatusCollectionViaLibro.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_bcatEstatusCollectionViaLibro.EntityFactoryToUse = entityFactoryToUse;
				}
				_bcatEstatusCollectionViaLibro.GetMulti(filter, relations);
				_bcatEstatusCollectionViaLibro.SuppressClearInGetMulti=false;
				_alreadyFetchedBcatEstatusCollectionViaLibro = true;
			}
			return _bcatEstatusCollectionViaLibro;
		}

		/// <summary> Sets the collection parameters for the collection for 'BcatEstatusCollectionViaLibro'. These settings will be taken into account
		/// when the property BcatEstatusCollectionViaLibro is requested or GetMultiBcatEstatusCollectionViaLibro is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersBcatEstatusCollectionViaLibro(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_bcatEstatusCollectionViaLibro.SortClauses=sortClauses;
			_bcatEstatusCollectionViaLibro.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'LibroFormatoEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'LibroFormatoEntity'</returns>
		public ORMDiocesis.CollectionClasses.LibroFormatoCollection GetMultiBcatFormatoCollectionViaLibro(bool forceFetch)
		{
			return GetMultiBcatFormatoCollectionViaLibro(forceFetch, _bcatFormatoCollectionViaLibro.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'LibroFormatoEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public ORMDiocesis.CollectionClasses.LibroFormatoCollection GetMultiBcatFormatoCollectionViaLibro(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedBcatFormatoCollectionViaLibro || forceFetch || _alwaysFetchBcatFormatoCollectionViaLibro) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_bcatFormatoCollectionViaLibro.ParticipatesInTransaction)
					{
						base.Transaction.Add(_bcatFormatoCollectionViaLibro);
					}
				}
				IRelationCollection relations = new RelationCollection();
				IPredicateExpression filter = new PredicateExpression();
				relations.Add(PaisEntity.Relations.LibroEntityUsingIdPais, "__PaisEntity__", "Libro_", JoinHint.None);
				relations.Add(LibroEntity.Relations.LibroFormatoEntityUsingFormato, "Libro_", string.Empty, JoinHint.None);
				filter.Add(new FieldCompareValuePredicate(EntityFieldFactory.Create(PaisFieldIndex.Id), ComparisonOperator.Equal, this.Id));
				_bcatFormatoCollectionViaLibro.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_bcatFormatoCollectionViaLibro.EntityFactoryToUse = entityFactoryToUse;
				}
				_bcatFormatoCollectionViaLibro.GetMulti(filter, relations);
				_bcatFormatoCollectionViaLibro.SuppressClearInGetMulti=false;
				_alreadyFetchedBcatFormatoCollectionViaLibro = true;
			}
			return _bcatFormatoCollectionViaLibro;
		}

		/// <summary> Sets the collection parameters for the collection for 'BcatFormatoCollectionViaLibro'. These settings will be taken into account
		/// when the property BcatFormatoCollectionViaLibro is requested or GetMultiBcatFormatoCollectionViaLibro is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersBcatFormatoCollectionViaLibro(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_bcatFormatoCollectionViaLibro.SortClauses=sortClauses;
			_bcatFormatoCollectionViaLibro.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'RamaEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'RamaEntity'</returns>
		public ORMDiocesis.CollectionClasses.RamaCollection GetMultiRamaCollectionViaLibro(bool forceFetch)
		{
			return GetMultiRamaCollectionViaLibro(forceFetch, _ramaCollectionViaLibro.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'RamaEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public ORMDiocesis.CollectionClasses.RamaCollection GetMultiRamaCollectionViaLibro(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedRamaCollectionViaLibro || forceFetch || _alwaysFetchRamaCollectionViaLibro) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_ramaCollectionViaLibro.ParticipatesInTransaction)
					{
						base.Transaction.Add(_ramaCollectionViaLibro);
					}
				}
				IRelationCollection relations = new RelationCollection();
				IPredicateExpression filter = new PredicateExpression();
				relations.Add(PaisEntity.Relations.LibroEntityUsingIdPais, "__PaisEntity__", "Libro_", JoinHint.None);
				relations.Add(LibroEntity.Relations.RamaEntityUsingIdRama, "Libro_", string.Empty, JoinHint.None);
				filter.Add(new FieldCompareValuePredicate(EntityFieldFactory.Create(PaisFieldIndex.Id), ComparisonOperator.Equal, this.Id));
				_ramaCollectionViaLibro.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_ramaCollectionViaLibro.EntityFactoryToUse = entityFactoryToUse;
				}
				_ramaCollectionViaLibro.GetMulti(filter, relations);
				_ramaCollectionViaLibro.SuppressClearInGetMulti=false;
				_alreadyFetchedRamaCollectionViaLibro = true;
			}
			return _ramaCollectionViaLibro;
		}

		/// <summary> Sets the collection parameters for the collection for 'RamaCollectionViaLibro'. These settings will be taken into account
		/// when the property RamaCollectionViaLibro is requested or GetMultiRamaCollectionViaLibro is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersRamaCollectionViaLibro(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_ramaCollectionViaLibro.SortClauses=sortClauses;
			_ramaCollectionViaLibro.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'SeccionEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'SeccionEntity'</returns>
		public ORMDiocesis.CollectionClasses.SeccionCollection GetMultiSeccionCollectionViaLibro(bool forceFetch)
		{
			return GetMultiSeccionCollectionViaLibro(forceFetch, _seccionCollectionViaLibro.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'SeccionEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public ORMDiocesis.CollectionClasses.SeccionCollection GetMultiSeccionCollectionViaLibro(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedSeccionCollectionViaLibro || forceFetch || _alwaysFetchSeccionCollectionViaLibro) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_seccionCollectionViaLibro.ParticipatesInTransaction)
					{
						base.Transaction.Add(_seccionCollectionViaLibro);
					}
				}
				IRelationCollection relations = new RelationCollection();
				IPredicateExpression filter = new PredicateExpression();
				relations.Add(PaisEntity.Relations.LibroEntityUsingIdPais, "__PaisEntity__", "Libro_", JoinHint.None);
				relations.Add(LibroEntity.Relations.SeccionEntityUsingIdSeccion, "Libro_", string.Empty, JoinHint.None);
				filter.Add(new FieldCompareValuePredicate(EntityFieldFactory.Create(PaisFieldIndex.Id), ComparisonOperator.Equal, this.Id));
				_seccionCollectionViaLibro.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_seccionCollectionViaLibro.EntityFactoryToUse = entityFactoryToUse;
				}
				_seccionCollectionViaLibro.GetMulti(filter, relations);
				_seccionCollectionViaLibro.SuppressClearInGetMulti=false;
				_alreadyFetchedSeccionCollectionViaLibro = true;
			}
			return _seccionCollectionViaLibro;
		}

		/// <summary> Sets the collection parameters for the collection for 'SeccionCollectionViaLibro'. These settings will be taken into account
		/// when the property SeccionCollectionViaLibro is requested or GetMultiSeccionCollectionViaLibro is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersSeccionCollectionViaLibro(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_seccionCollectionViaLibro.SortClauses=sortClauses;
			_seccionCollectionViaLibro.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'TematicaEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'TematicaEntity'</returns>
		public ORMDiocesis.CollectionClasses.TematicaCollection GetMultiTematicaCollectionViaLibro(bool forceFetch)
		{
			return GetMultiTematicaCollectionViaLibro(forceFetch, _tematicaCollectionViaLibro.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'TematicaEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public ORMDiocesis.CollectionClasses.TematicaCollection GetMultiTematicaCollectionViaLibro(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedTematicaCollectionViaLibro || forceFetch || _alwaysFetchTematicaCollectionViaLibro) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_tematicaCollectionViaLibro.ParticipatesInTransaction)
					{
						base.Transaction.Add(_tematicaCollectionViaLibro);
					}
				}
				IRelationCollection relations = new RelationCollection();
				IPredicateExpression filter = new PredicateExpression();
				relations.Add(PaisEntity.Relations.LibroEntityUsingIdPais, "__PaisEntity__", "Libro_", JoinHint.None);
				relations.Add(LibroEntity.Relations.TematicaEntityUsingIdTematica, "Libro_", string.Empty, JoinHint.None);
				filter.Add(new FieldCompareValuePredicate(EntityFieldFactory.Create(PaisFieldIndex.Id), ComparisonOperator.Equal, this.Id));
				_tematicaCollectionViaLibro.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_tematicaCollectionViaLibro.EntityFactoryToUse = entityFactoryToUse;
				}
				_tematicaCollectionViaLibro.GetMulti(filter, relations);
				_tematicaCollectionViaLibro.SuppressClearInGetMulti=false;
				_alreadyFetchedTematicaCollectionViaLibro = true;
			}
			return _tematicaCollectionViaLibro;
		}

		/// <summary> Sets the collection parameters for the collection for 'TematicaCollectionViaLibro'. These settings will be taken into account
		/// when the property TematicaCollectionViaLibro is requested or GetMultiTematicaCollectionViaLibro is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersTematicaCollectionViaLibro(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_tematicaCollectionViaLibro.SortClauses=sortClauses;
			_tematicaCollectionViaLibro.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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
			if(toReturn && Enum.IsDefined(typeof(PaisFieldIndex), fieldIndex))
			{
				switch((PaisFieldIndex)fieldIndex)
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
			PaisDAO dao = (PaisDAO)CreateDAOInstance();
			return dao.AddNew(base.Fields, base.Transaction);
		}
		
		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{
			_autores.ActiveContext = base.ActiveContext;
			_libros.ActiveContext = base.ActiveContext;
			_bcatEstatusCollectionViaLibro.ActiveContext = base.ActiveContext;
			_bcatFormatoCollectionViaLibro.ActiveContext = base.ActiveContext;
			_ramaCollectionViaLibro.ActiveContext = base.ActiveContext;
			_seccionCollectionViaLibro.ActiveContext = base.ActiveContext;
			_tematicaCollectionViaLibro.ActiveContext = base.ActiveContext;



		}


		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity()
		{
			PaisDAO dao = (PaisDAO)CreateDAOInstance();
			return dao.UpdateExisting(base.Fields, base.Transaction);
		}
		
		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			PaisDAO dao = (PaisDAO)CreateDAOInstance();
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
			return EntityFieldsFactory.CreateEntityFieldsObject(ORMDiocesis.EntityType.PaisEntity);
		}


		/// <summary> Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		/// <param name="id">PK value for Pais which data should be fetched into this Pais object</param>
		/// <param name="validator">The validator object for this PaisEntity</param>
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
			_autores = new ORMDiocesis.CollectionClasses.AutorCollection(new AutorEntityFactory());
			_autores.SetContainingEntityInfo(this, "Pais");
			_alwaysFetchAutores = false;
			_alreadyFetchedAutores = false;
			_libros = new ORMDiocesis.CollectionClasses.LibroCollection(new LibroEntityFactory());
			_libros.SetContainingEntityInfo(this, "Pais");
			_alwaysFetchLibros = false;
			_alreadyFetchedLibros = false;
			_bcatEstatusCollectionViaLibro = new ORMDiocesis.CollectionClasses.LibroEstatusCollection(new LibroEstatusEntityFactory());
			_alwaysFetchBcatEstatusCollectionViaLibro = false;
			_alreadyFetchedBcatEstatusCollectionViaLibro = false;
			_bcatFormatoCollectionViaLibro = new ORMDiocesis.CollectionClasses.LibroFormatoCollection(new LibroFormatoEntityFactory());
			_alwaysFetchBcatFormatoCollectionViaLibro = false;
			_alreadyFetchedBcatFormatoCollectionViaLibro = false;
			_ramaCollectionViaLibro = new ORMDiocesis.CollectionClasses.RamaCollection(new RamaEntityFactory());
			_alwaysFetchRamaCollectionViaLibro = false;
			_alreadyFetchedRamaCollectionViaLibro = false;
			_seccionCollectionViaLibro = new ORMDiocesis.CollectionClasses.SeccionCollection(new SeccionEntityFactory());
			_alwaysFetchSeccionCollectionViaLibro = false;
			_alreadyFetchedSeccionCollectionViaLibro = false;
			_tematicaCollectionViaLibro = new ORMDiocesis.CollectionClasses.TematicaCollection(new TematicaEntityFactory());
			_alwaysFetchTematicaCollectionViaLibro = false;
			_alreadyFetchedTematicaCollectionViaLibro = false;


			
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
		/// <param name="id">PK value for Pais which data should be fetched into this Pais object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 id, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			try
			{
				OnFetch();
				IDao dao = this.CreateDAOInstance();
				base.Fields[(int)PaisFieldIndex.Id].ForcedCurrentValueWrite(id);
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
			return DAOFactory.CreatePaisDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new PaisEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static PaisRelations Relations
		{
			get	{ return new PaisRelations(); }
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
		public static IPrefetchPathElement PrefetchPathAutores
		{
			get
			{
				return new PrefetchPathElement(new ORMDiocesis.CollectionClasses.AutorCollection(),
					PaisEntity.Relations.AutorEntityUsingIdPais, 
					(int)ORMDiocesis.EntityType.PaisEntity, (int)ORMDiocesis.EntityType.AutorEntity, 0, null, null, null, "Autores", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Libro' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathLibros
		{
			get
			{
				return new PrefetchPathElement(new ORMDiocesis.CollectionClasses.LibroCollection(),
					PaisEntity.Relations.LibroEntityUsingIdPais, 
					(int)ORMDiocesis.EntityType.PaisEntity, (int)ORMDiocesis.EntityType.LibroEntity, 0, null, null, null, "Libros", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'LibroEstatus' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathBcatEstatusCollectionViaLibro
		{
			get
			{
				IRelationCollection relations = new RelationCollection();
				relations.Add(PaisEntity.Relations.LibroEntityUsingIdPais, "__PaisEntity__", string.Empty, JoinHint.None);
				relations.Add(LibroEntity.Relations.LibroEstatusEntityUsingEstatus);
				return new PrefetchPathElement(new ORMDiocesis.CollectionClasses.LibroEstatusCollection(),
					PaisEntity.Relations.LibroEntityUsingIdPais,
					(int)ORMDiocesis.EntityType.PaisEntity, (int)ORMDiocesis.EntityType.LibroEstatusEntity, 0, null, null, relations, "BcatEstatusCollectionViaLibro", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'LibroFormato' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathBcatFormatoCollectionViaLibro
		{
			get
			{
				IRelationCollection relations = new RelationCollection();
				relations.Add(PaisEntity.Relations.LibroEntityUsingIdPais, "__PaisEntity__", string.Empty, JoinHint.None);
				relations.Add(LibroEntity.Relations.LibroFormatoEntityUsingFormato);
				return new PrefetchPathElement(new ORMDiocesis.CollectionClasses.LibroFormatoCollection(),
					PaisEntity.Relations.LibroEntityUsingIdPais,
					(int)ORMDiocesis.EntityType.PaisEntity, (int)ORMDiocesis.EntityType.LibroFormatoEntity, 0, null, null, relations, "BcatFormatoCollectionViaLibro", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Rama' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathRamaCollectionViaLibro
		{
			get
			{
				IRelationCollection relations = new RelationCollection();
				relations.Add(PaisEntity.Relations.LibroEntityUsingIdPais, "__PaisEntity__", string.Empty, JoinHint.None);
				relations.Add(LibroEntity.Relations.RamaEntityUsingIdRama);
				return new PrefetchPathElement(new ORMDiocesis.CollectionClasses.RamaCollection(),
					PaisEntity.Relations.LibroEntityUsingIdPais,
					(int)ORMDiocesis.EntityType.PaisEntity, (int)ORMDiocesis.EntityType.RamaEntity, 0, null, null, relations, "RamaCollectionViaLibro", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Seccion' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathSeccionCollectionViaLibro
		{
			get
			{
				IRelationCollection relations = new RelationCollection();
				relations.Add(PaisEntity.Relations.LibroEntityUsingIdPais, "__PaisEntity__", string.Empty, JoinHint.None);
				relations.Add(LibroEntity.Relations.SeccionEntityUsingIdSeccion);
				return new PrefetchPathElement(new ORMDiocesis.CollectionClasses.SeccionCollection(),
					PaisEntity.Relations.LibroEntityUsingIdPais,
					(int)ORMDiocesis.EntityType.PaisEntity, (int)ORMDiocesis.EntityType.SeccionEntity, 0, null, null, relations, "SeccionCollectionViaLibro", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Tematica' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathTematicaCollectionViaLibro
		{
			get
			{
				IRelationCollection relations = new RelationCollection();
				relations.Add(PaisEntity.Relations.LibroEntityUsingIdPais, "__PaisEntity__", string.Empty, JoinHint.None);
				relations.Add(LibroEntity.Relations.TematicaEntityUsingIdTematica);
				return new PrefetchPathElement(new ORMDiocesis.CollectionClasses.TematicaCollection(),
					PaisEntity.Relations.LibroEntityUsingIdPais,
					(int)ORMDiocesis.EntityType.PaisEntity, (int)ORMDiocesis.EntityType.TematicaEntity, 0, null, null, relations, "TematicaCollectionViaLibro", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}



		/// <summary>Returns the full name for this entity, which is important for the DAO to find back persistence info for this entity.</summary>
		[Browsable(false), XmlIgnore]
		public override string LLBLGenProEntityName
		{
			get { return "PaisEntity";}
		}

		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public virtual Dictionary<string, string> CustomPropertiesOfType
		{
			get { return PaisEntity.CustomProperties;}
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
			get { return PaisEntity.FieldsCustomProperties;}
		}

		/// <summary> The Id property of the Entity Pais<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "CatPaises"."Id"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 Id
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)PaisFieldIndex.Id);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.Int32));
				}
				return (System.Int32)valueToReturn;
			}
			set	{ SetNewFieldValue((int)PaisFieldIndex.Id, value); }
		}
		/// <summary> The Nombre property of the Entity Pais<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "CatPaises"."Nombre"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 30<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Nombre
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)PaisFieldIndex.Nombre);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
				return (System.String)valueToReturn;
			}
			set	{ SetNewFieldValue((int)PaisFieldIndex.Nombre, value); }
		}

		/// <summary> Retrieves all related entities of type 'AutorEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiAutores()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual ORMDiocesis.CollectionClasses.AutorCollection Autores
		{
			get	{ return GetMultiAutores(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for Autores. When set to true, Autores is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Autores is accessed. You can always execute
		/// a forced fetch by calling GetMultiAutores(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchAutores
		{
			get	{ return _alwaysFetchAutores; }
			set	{ _alwaysFetchAutores = value; }	
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

		/// <summary> Retrieves all related entities of type 'LibroEstatusEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiBcatEstatusCollectionViaLibro()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual ORMDiocesis.CollectionClasses.LibroEstatusCollection BcatEstatusCollectionViaLibro
		{
			get { return GetMultiBcatEstatusCollectionViaLibro(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for BcatEstatusCollectionViaLibro. When set to true, BcatEstatusCollectionViaLibro is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time BcatEstatusCollectionViaLibro is accessed. You can always execute
		/// a forced fetch by calling GetMultiBcatEstatusCollectionViaLibro(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchBcatEstatusCollectionViaLibro
		{
			get	{ return _alwaysFetchBcatEstatusCollectionViaLibro; }
			set	{ _alwaysFetchBcatEstatusCollectionViaLibro = value; }	
		}
		/// <summary> Retrieves all related entities of type 'LibroFormatoEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiBcatFormatoCollectionViaLibro()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual ORMDiocesis.CollectionClasses.LibroFormatoCollection BcatFormatoCollectionViaLibro
		{
			get { return GetMultiBcatFormatoCollectionViaLibro(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for BcatFormatoCollectionViaLibro. When set to true, BcatFormatoCollectionViaLibro is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time BcatFormatoCollectionViaLibro is accessed. You can always execute
		/// a forced fetch by calling GetMultiBcatFormatoCollectionViaLibro(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchBcatFormatoCollectionViaLibro
		{
			get	{ return _alwaysFetchBcatFormatoCollectionViaLibro; }
			set	{ _alwaysFetchBcatFormatoCollectionViaLibro = value; }	
		}
		/// <summary> Retrieves all related entities of type 'RamaEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiRamaCollectionViaLibro()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual ORMDiocesis.CollectionClasses.RamaCollection RamaCollectionViaLibro
		{
			get { return GetMultiRamaCollectionViaLibro(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for RamaCollectionViaLibro. When set to true, RamaCollectionViaLibro is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time RamaCollectionViaLibro is accessed. You can always execute
		/// a forced fetch by calling GetMultiRamaCollectionViaLibro(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchRamaCollectionViaLibro
		{
			get	{ return _alwaysFetchRamaCollectionViaLibro; }
			set	{ _alwaysFetchRamaCollectionViaLibro = value; }	
		}
		/// <summary> Retrieves all related entities of type 'SeccionEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiSeccionCollectionViaLibro()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual ORMDiocesis.CollectionClasses.SeccionCollection SeccionCollectionViaLibro
		{
			get { return GetMultiSeccionCollectionViaLibro(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for SeccionCollectionViaLibro. When set to true, SeccionCollectionViaLibro is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time SeccionCollectionViaLibro is accessed. You can always execute
		/// a forced fetch by calling GetMultiSeccionCollectionViaLibro(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchSeccionCollectionViaLibro
		{
			get	{ return _alwaysFetchSeccionCollectionViaLibro; }
			set	{ _alwaysFetchSeccionCollectionViaLibro = value; }	
		}
		/// <summary> Retrieves all related entities of type 'TematicaEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiTematicaCollectionViaLibro()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual ORMDiocesis.CollectionClasses.TematicaCollection TematicaCollectionViaLibro
		{
			get { return GetMultiTematicaCollectionViaLibro(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for TematicaCollectionViaLibro. When set to true, TematicaCollectionViaLibro is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time TematicaCollectionViaLibro is accessed. You can always execute
		/// a forced fetch by calling GetMultiTematicaCollectionViaLibro(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchTematicaCollectionViaLibro
		{
			get	{ return _alwaysFetchTematicaCollectionViaLibro; }
			set	{ _alwaysFetchTematicaCollectionViaLibro = value; }	
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
			get { return (int)ORMDiocesis.EntityType.PaisEntity; }
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
