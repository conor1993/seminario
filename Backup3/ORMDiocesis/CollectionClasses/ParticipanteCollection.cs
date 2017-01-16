///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 2.0.0.0
// Code is generated using templates: SD.TemplateBindings.SharedTemplates.NET20
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml;
#if !CF
using System.Runtime.Serialization;
#endif

using ORMDiocesis.EntityClasses;
using ORMDiocesis.FactoryClasses;
using ORMDiocesis.DaoClasses;
using ORMDiocesis.HelperClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace ORMDiocesis.CollectionClasses
{
	
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	

	/// <summary>Collection class for storing and retrieving collections of ParticipanteEntity objects. </summary>
#if CF
	[SD.LLBLGen.Pro.ORMSupportClasses.Serializable]
#else
	[Serializable]
#endif
	public partial class ParticipanteCollection : EntityCollectionBase<ParticipanteEntity>
	{
		/// <summary> CTor</summary>
		public ParticipanteCollection():base(new ParticipanteEntityFactory())
		{
		}

		/// <summary> CTor</summary>
		/// <param name="initialContents">The initial contents of this collection.</param>
		public ParticipanteCollection(IList<ParticipanteEntity> initialContents):base(new ParticipanteEntityFactory())
		{
		}

		/// <summary> CTor</summary>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		public ParticipanteCollection(IEntityFactory entityFactoryToUse):base(entityFactoryToUse)
		{
		}

		/// <summary> Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected ParticipanteCollection(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}



		/// <summary> Retrieves in this ParticipanteCollection object all ParticipanteEntity objects which are related via a  Relation of type 'm:n' with the passed in EventoEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="eventoInstance">EventoEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingEventosQueAsistio(IEntity eventoInstance)
		{
			return GetMultiManyToManyUsingEventosQueAsistio(eventoInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this ParticipanteCollection object all ParticipanteEntity objects which are related via a  relation of type 'm:n' with the passed in EventoEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="eventoInstance">EventoEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingEventosQueAsistio(IEntity eventoInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingEventosQueAsistio(eventoInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this ParticipanteCollection object all ParticipanteEntity objects which are related via a  relation of type 'm:n' with the passed in EventoEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="eventoInstance">EventoEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToManyUsingEventosQueAsistio(IEntity eventoInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, int pageNumber, int pageSize)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			ParticipanteDAO dao = DAOFactory.CreateParticipanteDAO();
			return dao.GetMultiUsingEventosQueAsistio(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, eventoInstance, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this ParticipanteCollection object all ParticipanteEntity objects which are related via a Relation of type 'm:n' with the passed in EventoEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="eventoInstance">EventoEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingEventosQueAsistio(IEntity eventoInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingEventosQueAsistio(eventoInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, prefetchPathToUse);
		}

		/// <summary> Retrieves in this ParticipanteCollection object all ParticipanteEntity objects which are related via a  relation of type 'm:n' with the passed in EventoEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="eventoInstance">EventoEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingEventosQueAsistio(IEntity eventoInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath prefetchPathToUse)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			ParticipanteDAO dao = DAOFactory.CreateParticipanteDAO();
			return dao.GetMultiUsingEventosQueAsistio(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, eventoInstance, prefetchPathToUse);
		}

		/// <summary> Retrieves in this ParticipanteCollection object all ParticipanteEntity objects which are related via a  Relation of type 'm:n' with the passed in ParrocoEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="parrocoInstance">ParrocoEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingParrocosQueLoRecomiendan(IEntity parrocoInstance)
		{
			return GetMultiManyToManyUsingParrocosQueLoRecomiendan(parrocoInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this ParticipanteCollection object all ParticipanteEntity objects which are related via a  relation of type 'm:n' with the passed in ParrocoEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="parrocoInstance">ParrocoEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingParrocosQueLoRecomiendan(IEntity parrocoInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingParrocosQueLoRecomiendan(parrocoInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this ParticipanteCollection object all ParticipanteEntity objects which are related via a  relation of type 'm:n' with the passed in ParrocoEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="parrocoInstance">ParrocoEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToManyUsingParrocosQueLoRecomiendan(IEntity parrocoInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, int pageNumber, int pageSize)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			ParticipanteDAO dao = DAOFactory.CreateParticipanteDAO();
			return dao.GetMultiUsingParrocosQueLoRecomiendan(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, parrocoInstance, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this ParticipanteCollection object all ParticipanteEntity objects which are related via a Relation of type 'm:n' with the passed in ParrocoEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="parrocoInstance">ParrocoEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingParrocosQueLoRecomiendan(IEntity parrocoInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingParrocosQueLoRecomiendan(parrocoInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, prefetchPathToUse);
		}

		/// <summary> Retrieves in this ParticipanteCollection object all ParticipanteEntity objects which are related via a  relation of type 'm:n' with the passed in ParrocoEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="parrocoInstance">ParrocoEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingParrocosQueLoRecomiendan(IEntity parrocoInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath prefetchPathToUse)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			ParticipanteDAO dao = DAOFactory.CreateParticipanteDAO();
			return dao.GetMultiUsingParrocosQueLoRecomiendan(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, parrocoInstance, prefetchPathToUse);
		}

		/// <summary> Retrieves in this ParticipanteCollection object all ParticipanteEntity objects which are related via a  Relation of type 'm:n' with the passed in ParroquiaEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="parroquiaInstance">ParroquiaEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingParroquiasQueLoEnvian(IEntity parroquiaInstance)
		{
			return GetMultiManyToManyUsingParroquiasQueLoEnvian(parroquiaInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this ParticipanteCollection object all ParticipanteEntity objects which are related via a  relation of type 'm:n' with the passed in ParroquiaEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="parroquiaInstance">ParroquiaEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingParroquiasQueLoEnvian(IEntity parroquiaInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingParroquiasQueLoEnvian(parroquiaInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this ParticipanteCollection object all ParticipanteEntity objects which are related via a  relation of type 'm:n' with the passed in ParroquiaEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="parroquiaInstance">ParroquiaEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToManyUsingParroquiasQueLoEnvian(IEntity parroquiaInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, int pageNumber, int pageSize)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			ParticipanteDAO dao = DAOFactory.CreateParticipanteDAO();
			return dao.GetMultiUsingParroquiasQueLoEnvian(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, parroquiaInstance, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this ParticipanteCollection object all ParticipanteEntity objects which are related via a Relation of type 'm:n' with the passed in ParroquiaEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="parroquiaInstance">ParroquiaEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingParroquiasQueLoEnvian(IEntity parroquiaInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingParroquiasQueLoEnvian(parroquiaInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, prefetchPathToUse);
		}

		/// <summary> Retrieves in this ParticipanteCollection object all ParticipanteEntity objects which are related via a  relation of type 'm:n' with the passed in ParroquiaEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="parroquiaInstance">ParroquiaEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingParroquiasQueLoEnvian(IEntity parroquiaInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath prefetchPathToUse)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			ParticipanteDAO dao = DAOFactory.CreateParticipanteDAO();
			return dao.GetMultiUsingParroquiasQueLoEnvian(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, parroquiaInstance, prefetchPathToUse);
		}


		/// <summary> Retrieves Entity rows in a datatable which match the specified filter. It will always create a new connection to the database.</summary>
		/// <param name="selectFilter">A predicate or predicate expression which should be used as filter for the entities to retrieve.</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>DataTable with the rows requested.</returns>
		public static DataTable GetMultiAsDataTable(IPredicate selectFilter, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiAsDataTable(selectFilter, maxNumberOfItemsToReturn, sortClauses, null, 0, 0);
		}

		/// <summary> Retrieves Entity rows in a datatable which match the specified filter. It will always create a new connection to the database.</summary>
		/// <param name="selectFilter">A predicate or predicate expression which should be used as filter for the entities to retrieve.</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="relations">The set of relations to walk to construct to total query.</param>
		/// <returns>DataTable with the rows requested.</returns>
		public static DataTable GetMultiAsDataTable(IPredicate selectFilter, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IRelationCollection relations)
		{
			return GetMultiAsDataTable(selectFilter, maxNumberOfItemsToReturn, sortClauses, relations, 0, 0);
		}
		
		/// <summary> Retrieves Entity rows in a datatable which match the specified filter. It will always create a new connection to the database.</summary>
		/// <param name="selectFilter">A predicate or predicate expression which should be used as filter for the entities to retrieve.</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="relations">The set of relations to walk to construct to total query.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>DataTable with the rows requested.</returns>
		public static DataTable GetMultiAsDataTable(IPredicate selectFilter, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IRelationCollection relations, int pageNumber, int pageSize)
		{
			ParticipanteDAO dao = DAOFactory.CreateParticipanteDAO();
			return dao.GetMultiAsDataTable(maxNumberOfItemsToReturn, sortClauses, selectFilter, relations, pageNumber, pageSize);
		}


		/// <summary> Deletes from the persistent storage all Participante entities which match with the specified filter, formulated in the predicate or predicate expression definition.</summary>
		/// <param name="deleteFilter">A predicate or predicate expression which should be used as filter for the entities to delete. Can be null, which will result in a query removing all Participante entities from the persistent storage</param>
		/// <returns>Amount of entities affected, if the used persistent storage has rowcounting enabled.</returns>
		public virtual int DeleteMulti(IPredicate deleteFilter)
		{
			ParticipanteDAO dao = DAOFactory.CreateParticipanteDAO();
			return dao.DeleteMulti(base.Transaction, deleteFilter);
		}

		/// <summary> Deletes from the persistent storage all Participante entities which match with the specified filter, formulated in the predicate or predicate expression definition.</summary>
		/// <param name="deleteFilter">A predicate or predicate expression which should be used as filter for the entities to delete.</param>
		/// <param name="relations">The set of relations to walk to construct the total query.</param>
		/// <returns>Amount of entities affected, if the used persistent storage has rowcounting enabled.</returns>
		public virtual int DeleteMulti(IPredicate deleteFilter, IRelationCollection relations)
		{
			ParticipanteDAO dao = DAOFactory.CreateParticipanteDAO();
			return dao.DeleteMulti(base.Transaction, deleteFilter, relations);
		}

		/// <summary> Updates in the persistent storage all entities which have data in common with the specified ParticipanteEntity. If one is omitted that entity is not used as a filter. Which fields are updated in those matching entities depends on which fields are
		/// <i>changed</i> in entityWithNewValues. The new values of these fields are read from entityWithNewValues. </summary>
		/// <param name="entityWithNewValues">ParticipanteEntity instance which holds the new values for the matching entities to update. Only changed fields are taken into account</param>
		/// <param name="updateFilter">A predicate or predicate expression which should be used as filter for the entities to update. Can be null, which
		/// will result in an update action which will affect all Participante entities.</param>
		/// <returns>Amount of entities affected, if the used persistent storage has rowcounting enabled.</returns>
		public int UpdateMulti(ParticipanteEntity entityWithNewValues, IPredicate updateFilter)
		{
			ParticipanteDAO dao = DAOFactory.CreateParticipanteDAO();
			return dao.UpdateMulti(entityWithNewValues, base.Transaction, updateFilter);
		}

		/// <summary> Updates in the persistent storage all entities which have data in common with the specified ParticipanteEntity. If one is omitted that entity is not used as a filter. Which fields are updated in those matching entities depends on which fields are
		/// <i>changed</i> in entityWithNewValues. The new values of these fields are read from entityWithNewValues. </summary>
		/// <param name="entityWithNewValues">ParticipanteEntity instance which holds the new values for the matching entities to update. Only changed fields are taken into account</param>
		/// <param name="updateFilter">A predicate or predicate expression which should be used as filter for the entities to update.</param>
		/// <param name="relations">The set of relations to walk to construct the total query.</param>
		/// <returns>Amount of entities affected, if the used persistent storage has rowcounting enabled.</returns>
		public int UpdateMulti(ParticipanteEntity entityWithNewValues, IPredicate updateFilter, IRelationCollection relations)
		{
			ParticipanteDAO dao = DAOFactory.CreateParticipanteDAO();
			return dao.UpdateMulti(entityWithNewValues, base.Transaction, updateFilter, relations);
		}

		
		/// <summary> Gets a scalar value, calculated with the aggregate. the field index specified is the field the aggregate are applied on.</summary>
		/// <param name="fieldIndex">Field index of field to which to apply the aggregate function and expression</param>
		/// <param name="aggregateToApply">Aggregate function to apply. </param>
		/// <returns>the scalar value requested</returns>
		public object GetScalar(ParticipanteFieldIndex fieldIndex, AggregateFunction aggregateToApply)
		{
			return GetScalar(fieldIndex, null, aggregateToApply, null, null, null);
		}

		/// <summary> Gets a scalar value, calculated with the aggregate and expression specified. the field index specified is the field the expression and aggregate are applied on.</summary>
		/// <param name="fieldIndex">Field index of field to which to apply the aggregate function and expression</param>
		/// <param name="expressionToExecute">The expression to execute. Can be null</param>
		/// <param name="aggregateToApply">Aggregate function to apply. </param>
		/// <returns>the scalar value requested</returns>
		public object GetScalar(ParticipanteFieldIndex fieldIndex, IExpression expressionToExecute, AggregateFunction aggregateToApply)
		{
			return GetScalar(fieldIndex, expressionToExecute, aggregateToApply, null, null, null);
		}

		/// <summary> Gets a scalar value, calculated with the aggregate and expression specified. the field index specified is the field the expression and aggregate are
		/// applied on.</summary>
		/// <param name="fieldIndex">Field index of field to which to apply the aggregate function and expression</param>
		/// <param name="expressionToExecute">The expression to execute. Can be null</param>
		/// <param name="aggregateToApply">Aggregate function to apply. </param>
		/// <param name="filter">The filter to apply to retrieve the scalar</param>
		/// <returns>the scalar value requested</returns>
		public object GetScalar(ParticipanteFieldIndex fieldIndex, IExpression expressionToExecute, AggregateFunction aggregateToApply, IPredicate filter)
		{
			return GetScalar(fieldIndex, expressionToExecute, aggregateToApply, filter, null, null);
		}

		/// <summary> Gets a scalar value, calculated with the aggregate and expression specified. the field index specified is the field the expression and aggregate are applied on.</summary>
		/// <param name="fieldIndex">Field index of field to which to apply the aggregate function and expression</param>
		/// <param name="expressionToExecute">The expression to execute. Can be null</param>
		/// <param name="aggregateToApply">Aggregate function to apply. </param>
		/// <param name="filter">The filter to apply to retrieve the scalar</param>
		/// <param name="groupByClause">The groupby clause to apply to retrieve the scalar</param>
		/// <returns>the scalar value requested</returns>
		public object GetScalar(ParticipanteFieldIndex fieldIndex, IExpression expressionToExecute, AggregateFunction aggregateToApply, IPredicate filter, IGroupByCollection groupByClause)
		{
			return GetScalar(fieldIndex, expressionToExecute, aggregateToApply, filter, null, groupByClause);
		}

		/// <summary> Gets a scalar value, calculated with the aggregate and expression specified. the field index specified is the field the expression and aggregate are applied on.</summary>
		/// <param name="fieldIndex">Field index of field to which to apply the aggregate function and expression</param>
		/// <param name="expressionToExecute">The expression to execute. Can be null</param>
		/// <param name="aggregateToApply">Aggregate function to apply. </param>
		/// <param name="filter">The filter to apply to retrieve the scalar</param>
		/// <param name="relations">The relations to walk</param>
		/// <param name="groupByClause">The groupby clause to apply to retrieve the scalar</param>
		/// <returns>the scalar value requested</returns>
		public virtual object GetScalar(ParticipanteFieldIndex fieldIndex, IExpression expressionToExecute, AggregateFunction aggregateToApply, IPredicate filter, IRelationCollection relations, IGroupByCollection groupByClause)
		{
			EntityFields fields = new EntityFields(1);
			fields[0] = EntityFieldFactory.Create(fieldIndex);
			if((fields[0].ExpressionToApply == null) || (expressionToExecute != null))
			{
				fields[0].ExpressionToApply = expressionToExecute;
			}
			if((fields[0].AggregateFunctionToApply == AggregateFunction.None) || (aggregateToApply != AggregateFunction.None))
			{
				fields[0].AggregateFunctionToApply = aggregateToApply;
			}
			ParticipanteDAO dao = DAOFactory.CreateParticipanteDAO();
			return dao.GetScalar(fields, base.Transaction, filter, relations, groupByClause);
		}
		
		/// <summary>Creats a new DAO instance so code which is in the base class can still use the proper DAO object.</summary>
		protected override IDao CreateDAOInstance()
		{
			return DAOFactory.CreateParticipanteDAO();
		}
		
		/// <summary>Creates a new transaction object</summary>
		/// <param name="levelOfIsolation">The level of isolation.</param>
		/// <param name="name">The name.</param>
		protected override ITransaction CreateTransaction( IsolationLevel levelOfIsolation, string name )
		{
			return new Transaction(levelOfIsolation, name);
		}


		#region Custom EntityCollection code
		
		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCollectionCode
		// __LLBLGENPRO_USER_CODE_REGION_END
		
		#endregion
		
		#region Included Code

		#endregion
	}
}
