﻿///////////////////////////////////////////////////////////////
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

	/// <summary>Collection class for storing and retrieving collections of LibroEntity objects. </summary>
#if CF
	[SD.LLBLGen.Pro.ORMSupportClasses.Serializable]
#else
	[Serializable]
#endif
	public partial class LibroCollection : EntityCollectionBase<LibroEntity>
	{
		/// <summary> CTor</summary>
		public LibroCollection():base(new LibroEntityFactory())
		{
		}

		/// <summary> CTor</summary>
		/// <param name="initialContents">The initial contents of this collection.</param>
		public LibroCollection(IList<LibroEntity> initialContents):base(new LibroEntityFactory())
		{
		}

		/// <summary> CTor</summary>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		public LibroCollection(IEntityFactory entityFactoryToUse):base(entityFactoryToUse)
		{
		}

		/// <summary> Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected LibroCollection(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}


		/// <summary> Retrieves in this LibroCollection object all LibroEntity objects which have data in common with the specified related Entities.
		/// If one is omitted, that entity is not used as a filter. All current elements in the collection are removed from the collection.</summary>
		/// <param name="autorInstance">AutorEntity instance to use as a filter for the LibroEntity objects to return</param>
		/// <param name="editorialInstance">EditorialEntity instance to use as a filter for the LibroEntity objects to return</param>
		/// <param name="bcatEstatusInstance">LibroEstatusEntity instance to use as a filter for the LibroEntity objects to return</param>
		/// <param name="bcatFormatoInstance">LibroFormatoEntity instance to use as a filter for the LibroEntity objects to return</param>
		/// <param name="ramaInstance">RamaEntity instance to use as a filter for the LibroEntity objects to return</param>
		/// <param name="seccionInstance">SeccionEntity instance to use as a filter for the LibroEntity objects to return</param>
		/// <param name="tematicaInstance">TematicaEntity instance to use as a filter for the LibroEntity objects to return</param>
		/// <param name="paisInstance">PaisEntity instance to use as a filter for the LibroEntity objects to return</param>
		/// <returns>true if succeeded, false otherwise</returns>
		public bool GetMultiManyToOne(IEntity autorInstance, IEntity editorialInstance, IEntity bcatEstatusInstance, IEntity bcatFormatoInstance, IEntity ramaInstance, IEntity seccionInstance, IEntity tematicaInstance, IEntity paisInstance)
		{
			return GetMultiManyToOne(autorInstance, editorialInstance, bcatEstatusInstance, bcatFormatoInstance, ramaInstance, seccionInstance, tematicaInstance, paisInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, null, 0, 0);
		}

		/// <summary> Retrieves in this LibroCollection object all LibroEntity objects which have data in common with the specified related Entities.
		/// If one is omitted, that entity is not used as a filter. All current elements in the collection are removed from the collection.</summary>
		/// <param name="autorInstance">AutorEntity instance to use as a filter for the LibroEntity objects to return</param>
		/// <param name="editorialInstance">EditorialEntity instance to use as a filter for the LibroEntity objects to return</param>
		/// <param name="bcatEstatusInstance">LibroEstatusEntity instance to use as a filter for the LibroEntity objects to return</param>
		/// <param name="bcatFormatoInstance">LibroFormatoEntity instance to use as a filter for the LibroEntity objects to return</param>
		/// <param name="ramaInstance">RamaEntity instance to use as a filter for the LibroEntity objects to return</param>
		/// <param name="seccionInstance">SeccionEntity instance to use as a filter for the LibroEntity objects to return</param>
		/// <param name="tematicaInstance">TematicaEntity instance to use as a filter for the LibroEntity objects to return</param>
		/// <param name="paisInstance">PaisEntity instance to use as a filter for the LibroEntity objects to return</param>
		/// <param name="filter">Extra filter to limit the resultset. Predicate expression can be null, in which case it will be ignored.</param>
		/// <returns>true if succeeded, false otherwise</returns>
		public bool GetMultiManyToOne(IEntity autorInstance, IEntity editorialInstance, IEntity bcatEstatusInstance, IEntity bcatFormatoInstance, IEntity ramaInstance, IEntity seccionInstance, IEntity tematicaInstance, IEntity paisInstance, IPredicateExpression filter)
		{
			return GetMultiManyToOne(autorInstance, editorialInstance, bcatEstatusInstance, bcatFormatoInstance, ramaInstance, seccionInstance, tematicaInstance, paisInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, filter, 0, 0);
		}

		/// <summary> Retrieves in this LibroCollection object all LibroEntity objects which have data in common with the specified related Entities.
		/// If one is omitted, that entity is not used as a filter. All current elements in the collection are removed from the collection.</summary>
		/// <param name="autorInstance">AutorEntity instance to use as a filter for the LibroEntity objects to return</param>
		/// <param name="editorialInstance">EditorialEntity instance to use as a filter for the LibroEntity objects to return</param>
		/// <param name="bcatEstatusInstance">LibroEstatusEntity instance to use as a filter for the LibroEntity objects to return</param>
		/// <param name="bcatFormatoInstance">LibroFormatoEntity instance to use as a filter for the LibroEntity objects to return</param>
		/// <param name="ramaInstance">RamaEntity instance to use as a filter for the LibroEntity objects to return</param>
		/// <param name="seccionInstance">SeccionEntity instance to use as a filter for the LibroEntity objects to return</param>
		/// <param name="tematicaInstance">TematicaEntity instance to use as a filter for the LibroEntity objects to return</param>
		/// <param name="paisInstance">PaisEntity instance to use as a filter for the LibroEntity objects to return</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="filter">Extra filter to limit the resultset. Predicate expression can be null, in which case it will be ignored.</param>
		/// <returns>true if succeeded, false otherwise</returns>
		public bool GetMultiManyToOne(IEntity autorInstance, IEntity editorialInstance, IEntity bcatEstatusInstance, IEntity bcatFormatoInstance, IEntity ramaInstance, IEntity seccionInstance, IEntity tematicaInstance, IEntity paisInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPredicateExpression filter)
		{
			return GetMultiManyToOne(autorInstance, editorialInstance, bcatEstatusInstance, bcatFormatoInstance, ramaInstance, seccionInstance, tematicaInstance, paisInstance, maxNumberOfItemsToReturn, sortClauses, filter, 0, 0);
		}

		/// <summary> Retrieves in this LibroCollection object all LibroEntity objects which have data in common with the specified related Entities.
		/// If one is omitted, that entity is not used as a filter. All current elements in the collection are removed from the collection.</summary>
		/// <param name="autorInstance">AutorEntity instance to use as a filter for the LibroEntity objects to return</param>
		/// <param name="editorialInstance">EditorialEntity instance to use as a filter for the LibroEntity objects to return</param>
		/// <param name="bcatEstatusInstance">LibroEstatusEntity instance to use as a filter for the LibroEntity objects to return</param>
		/// <param name="bcatFormatoInstance">LibroFormatoEntity instance to use as a filter for the LibroEntity objects to return</param>
		/// <param name="ramaInstance">RamaEntity instance to use as a filter for the LibroEntity objects to return</param>
		/// <param name="seccionInstance">SeccionEntity instance to use as a filter for the LibroEntity objects to return</param>
		/// <param name="tematicaInstance">TematicaEntity instance to use as a filter for the LibroEntity objects to return</param>
		/// <param name="paisInstance">PaisEntity instance to use as a filter for the LibroEntity objects to return</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="filter">Extra filter to limit the resultset. Predicate expression can be null, in which case it will be ignored.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToOne(IEntity autorInstance, IEntity editorialInstance, IEntity bcatEstatusInstance, IEntity bcatFormatoInstance, IEntity ramaInstance, IEntity seccionInstance, IEntity tematicaInstance, IEntity paisInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPredicateExpression filter, int pageNumber, int pageSize)
		{
			bool validParameters = false;
			validParameters |= (autorInstance!=null);
			validParameters |= (editorialInstance!=null);
			validParameters |= (bcatEstatusInstance!=null);
			validParameters |= (bcatFormatoInstance!=null);
			validParameters |= (ramaInstance!=null);
			validParameters |= (seccionInstance!=null);
			validParameters |= (tematicaInstance!=null);
			validParameters |= (paisInstance!=null);
			if(!validParameters)
			{
				return GetMulti(filter, maxNumberOfItemsToReturn, sortClauses, null, pageNumber, pageSize);
			}
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			LibroDAO dao = DAOFactory.CreateLibroDAO();
			return dao.GetMulti(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, filter, autorInstance, editorialInstance, bcatEstatusInstance, bcatFormatoInstance, ramaInstance, seccionInstance, tematicaInstance, paisInstance, pageNumber, pageSize);
		}

		/// <summary> Deletes from the persistent storage all Libro entities which have data in common with the specified related Entities. If one is omitted, that entity is not used as a filter.</summary>
		/// <remarks>Runs directly on the persistent storage. It will not delete entity objects from the current collection.</remarks>
		/// <param name="autorInstance">AutorEntity instance to use as a filter for the LibroEntity objects to return</param>
		/// <param name="editorialInstance">EditorialEntity instance to use as a filter for the LibroEntity objects to return</param>
		/// <param name="bcatEstatusInstance">LibroEstatusEntity instance to use as a filter for the LibroEntity objects to return</param>
		/// <param name="bcatFormatoInstance">LibroFormatoEntity instance to use as a filter for the LibroEntity objects to return</param>
		/// <param name="ramaInstance">RamaEntity instance to use as a filter for the LibroEntity objects to return</param>
		/// <param name="seccionInstance">SeccionEntity instance to use as a filter for the LibroEntity objects to return</param>
		/// <param name="tematicaInstance">TematicaEntity instance to use as a filter for the LibroEntity objects to return</param>
		/// <param name="paisInstance">PaisEntity instance to use as a filter for the LibroEntity objects to return</param>
		/// <returns>Amount of entities affected, if the used persistent storage has rowcounting enabled.</returns>
		public int DeleteMultiManyToOne(IEntity autorInstance, IEntity editorialInstance, IEntity bcatEstatusInstance, IEntity bcatFormatoInstance, IEntity ramaInstance, IEntity seccionInstance, IEntity tematicaInstance, IEntity paisInstance)
		{
			LibroDAO dao = DAOFactory.CreateLibroDAO();
			return dao.DeleteMulti(base.Transaction, autorInstance, editorialInstance, bcatEstatusInstance, bcatFormatoInstance, ramaInstance, seccionInstance, tematicaInstance, paisInstance);
		}

		/// <summary> Updates in the persistent storage all Libro entities which have data in common with the specified related Entities. If one is omitted, that entity is not used as a filter.
		/// Which fields are updated in those matching entities depends on which fields are <i>changed</i> in the passed in entity entityWithNewValues. The new values of these fields are read from entityWithNewValues. </summary>
		/// <param name="entityWithNewValues">LibroEntity instance which holds the new values for the matching entities to update. Only changed fields are taken into account</param>
		/// <param name="autorInstance">AutorEntity instance to use as a filter for the LibroEntity objects to return</param>
		/// <param name="editorialInstance">EditorialEntity instance to use as a filter for the LibroEntity objects to return</param>
		/// <param name="bcatEstatusInstance">LibroEstatusEntity instance to use as a filter for the LibroEntity objects to return</param>
		/// <param name="bcatFormatoInstance">LibroFormatoEntity instance to use as a filter for the LibroEntity objects to return</param>
		/// <param name="ramaInstance">RamaEntity instance to use as a filter for the LibroEntity objects to return</param>
		/// <param name="seccionInstance">SeccionEntity instance to use as a filter for the LibroEntity objects to return</param>
		/// <param name="tematicaInstance">TematicaEntity instance to use as a filter for the LibroEntity objects to return</param>
		/// <param name="paisInstance">PaisEntity instance to use as a filter for the LibroEntity objects to return</param>
		/// <returns>Amount of entities affected, if the used persistent storage has rowcounting enabled.</returns>
		public int UpdateMultiManyToOne(LibroEntity entityWithNewValues, IEntity autorInstance, IEntity editorialInstance, IEntity bcatEstatusInstance, IEntity bcatFormatoInstance, IEntity ramaInstance, IEntity seccionInstance, IEntity tematicaInstance, IEntity paisInstance)
		{
			LibroDAO dao = DAOFactory.CreateLibroDAO();
			return dao.UpdateMulti(entityWithNewValues, base.Transaction, autorInstance, editorialInstance, bcatEstatusInstance, bcatFormatoInstance, ramaInstance, seccionInstance, tematicaInstance, paisInstance);
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
			LibroDAO dao = DAOFactory.CreateLibroDAO();
			return dao.GetMultiAsDataTable(maxNumberOfItemsToReturn, sortClauses, selectFilter, relations, pageNumber, pageSize);
		}


		/// <summary> Deletes from the persistent storage all Libro entities which match with the specified filter, formulated in the predicate or predicate expression definition.</summary>
		/// <param name="deleteFilter">A predicate or predicate expression which should be used as filter for the entities to delete. Can be null, which will result in a query removing all Libro entities from the persistent storage</param>
		/// <returns>Amount of entities affected, if the used persistent storage has rowcounting enabled.</returns>
		public virtual int DeleteMulti(IPredicate deleteFilter)
		{
			LibroDAO dao = DAOFactory.CreateLibroDAO();
			return dao.DeleteMulti(base.Transaction, deleteFilter);
		}

		/// <summary> Deletes from the persistent storage all Libro entities which match with the specified filter, formulated in the predicate or predicate expression definition.</summary>
		/// <param name="deleteFilter">A predicate or predicate expression which should be used as filter for the entities to delete.</param>
		/// <param name="relations">The set of relations to walk to construct the total query.</param>
		/// <returns>Amount of entities affected, if the used persistent storage has rowcounting enabled.</returns>
		public virtual int DeleteMulti(IPredicate deleteFilter, IRelationCollection relations)
		{
			LibroDAO dao = DAOFactory.CreateLibroDAO();
			return dao.DeleteMulti(base.Transaction, deleteFilter, relations);
		}

		/// <summary> Updates in the persistent storage all entities which have data in common with the specified LibroEntity. If one is omitted that entity is not used as a filter. Which fields are updated in those matching entities depends on which fields are
		/// <i>changed</i> in entityWithNewValues. The new values of these fields are read from entityWithNewValues. </summary>
		/// <param name="entityWithNewValues">LibroEntity instance which holds the new values for the matching entities to update. Only changed fields are taken into account</param>
		/// <param name="updateFilter">A predicate or predicate expression which should be used as filter for the entities to update. Can be null, which
		/// will result in an update action which will affect all Libro entities.</param>
		/// <returns>Amount of entities affected, if the used persistent storage has rowcounting enabled.</returns>
		public int UpdateMulti(LibroEntity entityWithNewValues, IPredicate updateFilter)
		{
			LibroDAO dao = DAOFactory.CreateLibroDAO();
			return dao.UpdateMulti(entityWithNewValues, base.Transaction, updateFilter);
		}

		/// <summary> Updates in the persistent storage all entities which have data in common with the specified LibroEntity. If one is omitted that entity is not used as a filter. Which fields are updated in those matching entities depends on which fields are
		/// <i>changed</i> in entityWithNewValues. The new values of these fields are read from entityWithNewValues. </summary>
		/// <param name="entityWithNewValues">LibroEntity instance which holds the new values for the matching entities to update. Only changed fields are taken into account</param>
		/// <param name="updateFilter">A predicate or predicate expression which should be used as filter for the entities to update.</param>
		/// <param name="relations">The set of relations to walk to construct the total query.</param>
		/// <returns>Amount of entities affected, if the used persistent storage has rowcounting enabled.</returns>
		public int UpdateMulti(LibroEntity entityWithNewValues, IPredicate updateFilter, IRelationCollection relations)
		{
			LibroDAO dao = DAOFactory.CreateLibroDAO();
			return dao.UpdateMulti(entityWithNewValues, base.Transaction, updateFilter, relations);
		}

		
		/// <summary> Gets a scalar value, calculated with the aggregate. the field index specified is the field the aggregate are applied on.</summary>
		/// <param name="fieldIndex">Field index of field to which to apply the aggregate function and expression</param>
		/// <param name="aggregateToApply">Aggregate function to apply. </param>
		/// <returns>the scalar value requested</returns>
		public object GetScalar(LibroFieldIndex fieldIndex, AggregateFunction aggregateToApply)
		{
			return GetScalar(fieldIndex, null, aggregateToApply, null, null, null);
		}

		/// <summary> Gets a scalar value, calculated with the aggregate and expression specified. the field index specified is the field the expression and aggregate are applied on.</summary>
		/// <param name="fieldIndex">Field index of field to which to apply the aggregate function and expression</param>
		/// <param name="expressionToExecute">The expression to execute. Can be null</param>
		/// <param name="aggregateToApply">Aggregate function to apply. </param>
		/// <returns>the scalar value requested</returns>
		public object GetScalar(LibroFieldIndex fieldIndex, IExpression expressionToExecute, AggregateFunction aggregateToApply)
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
		public object GetScalar(LibroFieldIndex fieldIndex, IExpression expressionToExecute, AggregateFunction aggregateToApply, IPredicate filter)
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
		public object GetScalar(LibroFieldIndex fieldIndex, IExpression expressionToExecute, AggregateFunction aggregateToApply, IPredicate filter, IGroupByCollection groupByClause)
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
		public virtual object GetScalar(LibroFieldIndex fieldIndex, IExpression expressionToExecute, AggregateFunction aggregateToApply, IPredicate filter, IRelationCollection relations, IGroupByCollection groupByClause)
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
			LibroDAO dao = DAOFactory.CreateLibroDAO();
			return dao.GetScalar(fields, base.Transaction, filter, relations, groupByClause);
		}
		
		/// <summary>Creats a new DAO instance so code which is in the base class can still use the proper DAO object.</summary>
		protected override IDao CreateDAOInstance()
		{
			return DAOFactory.CreateLibroDAO();
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