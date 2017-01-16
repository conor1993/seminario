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
	

	/// <summary>Collection class for storing and retrieving collections of LibroEstatusEntity objects. </summary>
#if CF
	[SD.LLBLGen.Pro.ORMSupportClasses.Serializable]
#else
	[Serializable]
#endif
	public partial class LibroEstatusCollection : EntityCollectionBase<LibroEstatusEntity>
	{
		/// <summary> CTor</summary>
		public LibroEstatusCollection():base(new LibroEstatusEntityFactory())
		{
		}

		/// <summary> CTor</summary>
		/// <param name="initialContents">The initial contents of this collection.</param>
		public LibroEstatusCollection(IList<LibroEstatusEntity> initialContents):base(new LibroEstatusEntityFactory())
		{
		}

		/// <summary> CTor</summary>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		public LibroEstatusCollection(IEntityFactory entityFactoryToUse):base(entityFactoryToUse)
		{
		}

		/// <summary> Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected LibroEstatusCollection(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}



		/// <summary> Retrieves in this LibroEstatusCollection object all LibroEstatusEntity objects which are related via a  Relation of type 'm:n' with the passed in AutorEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="autorInstance">AutorEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingAutorCollectionViaLibro(IEntity autorInstance)
		{
			return GetMultiManyToManyUsingAutorCollectionViaLibro(autorInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this LibroEstatusCollection object all LibroEstatusEntity objects which are related via a  relation of type 'm:n' with the passed in AutorEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="autorInstance">AutorEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingAutorCollectionViaLibro(IEntity autorInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingAutorCollectionViaLibro(autorInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this LibroEstatusCollection object all LibroEstatusEntity objects which are related via a  relation of type 'm:n' with the passed in AutorEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="autorInstance">AutorEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToManyUsingAutorCollectionViaLibro(IEntity autorInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, int pageNumber, int pageSize)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			LibroEstatusDAO dao = DAOFactory.CreateLibroEstatusDAO();
			return dao.GetMultiUsingAutorCollectionViaLibro(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, autorInstance, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this LibroEstatusCollection object all LibroEstatusEntity objects which are related via a Relation of type 'm:n' with the passed in AutorEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="autorInstance">AutorEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingAutorCollectionViaLibro(IEntity autorInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingAutorCollectionViaLibro(autorInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, prefetchPathToUse);
		}

		/// <summary> Retrieves in this LibroEstatusCollection object all LibroEstatusEntity objects which are related via a  relation of type 'm:n' with the passed in AutorEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="autorInstance">AutorEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingAutorCollectionViaLibro(IEntity autorInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath prefetchPathToUse)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			LibroEstatusDAO dao = DAOFactory.CreateLibroEstatusDAO();
			return dao.GetMultiUsingAutorCollectionViaLibro(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, autorInstance, prefetchPathToUse);
		}

		/// <summary> Retrieves in this LibroEstatusCollection object all LibroEstatusEntity objects which are related via a  Relation of type 'm:n' with the passed in EditorialEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="editorialInstance">EditorialEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingEditorialCollectionViaLibro(IEntity editorialInstance)
		{
			return GetMultiManyToManyUsingEditorialCollectionViaLibro(editorialInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this LibroEstatusCollection object all LibroEstatusEntity objects which are related via a  relation of type 'm:n' with the passed in EditorialEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="editorialInstance">EditorialEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingEditorialCollectionViaLibro(IEntity editorialInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingEditorialCollectionViaLibro(editorialInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this LibroEstatusCollection object all LibroEstatusEntity objects which are related via a  relation of type 'm:n' with the passed in EditorialEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="editorialInstance">EditorialEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToManyUsingEditorialCollectionViaLibro(IEntity editorialInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, int pageNumber, int pageSize)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			LibroEstatusDAO dao = DAOFactory.CreateLibroEstatusDAO();
			return dao.GetMultiUsingEditorialCollectionViaLibro(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, editorialInstance, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this LibroEstatusCollection object all LibroEstatusEntity objects which are related via a Relation of type 'm:n' with the passed in EditorialEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="editorialInstance">EditorialEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingEditorialCollectionViaLibro(IEntity editorialInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingEditorialCollectionViaLibro(editorialInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, prefetchPathToUse);
		}

		/// <summary> Retrieves in this LibroEstatusCollection object all LibroEstatusEntity objects which are related via a  relation of type 'm:n' with the passed in EditorialEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="editorialInstance">EditorialEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingEditorialCollectionViaLibro(IEntity editorialInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath prefetchPathToUse)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			LibroEstatusDAO dao = DAOFactory.CreateLibroEstatusDAO();
			return dao.GetMultiUsingEditorialCollectionViaLibro(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, editorialInstance, prefetchPathToUse);
		}

		/// <summary> Retrieves in this LibroEstatusCollection object all LibroEstatusEntity objects which are related via a  Relation of type 'm:n' with the passed in LibroFormatoEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="libroFormatoInstance">LibroFormatoEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingBcatFormatoCollectionViaLibro(IEntity libroFormatoInstance)
		{
			return GetMultiManyToManyUsingBcatFormatoCollectionViaLibro(libroFormatoInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this LibroEstatusCollection object all LibroEstatusEntity objects which are related via a  relation of type 'm:n' with the passed in LibroFormatoEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="libroFormatoInstance">LibroFormatoEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingBcatFormatoCollectionViaLibro(IEntity libroFormatoInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingBcatFormatoCollectionViaLibro(libroFormatoInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this LibroEstatusCollection object all LibroEstatusEntity objects which are related via a  relation of type 'm:n' with the passed in LibroFormatoEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="libroFormatoInstance">LibroFormatoEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToManyUsingBcatFormatoCollectionViaLibro(IEntity libroFormatoInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, int pageNumber, int pageSize)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			LibroEstatusDAO dao = DAOFactory.CreateLibroEstatusDAO();
			return dao.GetMultiUsingBcatFormatoCollectionViaLibro(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, libroFormatoInstance, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this LibroEstatusCollection object all LibroEstatusEntity objects which are related via a Relation of type 'm:n' with the passed in LibroFormatoEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="libroFormatoInstance">LibroFormatoEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingBcatFormatoCollectionViaLibro(IEntity libroFormatoInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingBcatFormatoCollectionViaLibro(libroFormatoInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, prefetchPathToUse);
		}

		/// <summary> Retrieves in this LibroEstatusCollection object all LibroEstatusEntity objects which are related via a  relation of type 'm:n' with the passed in LibroFormatoEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="libroFormatoInstance">LibroFormatoEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingBcatFormatoCollectionViaLibro(IEntity libroFormatoInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath prefetchPathToUse)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			LibroEstatusDAO dao = DAOFactory.CreateLibroEstatusDAO();
			return dao.GetMultiUsingBcatFormatoCollectionViaLibro(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, libroFormatoInstance, prefetchPathToUse);
		}

		/// <summary> Retrieves in this LibroEstatusCollection object all LibroEstatusEntity objects which are related via a  Relation of type 'm:n' with the passed in RamaEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="ramaInstance">RamaEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingRamaCollectionViaLibro(IEntity ramaInstance)
		{
			return GetMultiManyToManyUsingRamaCollectionViaLibro(ramaInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this LibroEstatusCollection object all LibroEstatusEntity objects which are related via a  relation of type 'm:n' with the passed in RamaEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="ramaInstance">RamaEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingRamaCollectionViaLibro(IEntity ramaInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingRamaCollectionViaLibro(ramaInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this LibroEstatusCollection object all LibroEstatusEntity objects which are related via a  relation of type 'm:n' with the passed in RamaEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="ramaInstance">RamaEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToManyUsingRamaCollectionViaLibro(IEntity ramaInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, int pageNumber, int pageSize)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			LibroEstatusDAO dao = DAOFactory.CreateLibroEstatusDAO();
			return dao.GetMultiUsingRamaCollectionViaLibro(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, ramaInstance, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this LibroEstatusCollection object all LibroEstatusEntity objects which are related via a Relation of type 'm:n' with the passed in RamaEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="ramaInstance">RamaEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingRamaCollectionViaLibro(IEntity ramaInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingRamaCollectionViaLibro(ramaInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, prefetchPathToUse);
		}

		/// <summary> Retrieves in this LibroEstatusCollection object all LibroEstatusEntity objects which are related via a  relation of type 'm:n' with the passed in RamaEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="ramaInstance">RamaEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingRamaCollectionViaLibro(IEntity ramaInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath prefetchPathToUse)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			LibroEstatusDAO dao = DAOFactory.CreateLibroEstatusDAO();
			return dao.GetMultiUsingRamaCollectionViaLibro(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, ramaInstance, prefetchPathToUse);
		}

		/// <summary> Retrieves in this LibroEstatusCollection object all LibroEstatusEntity objects which are related via a  Relation of type 'm:n' with the passed in SeccionEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="seccionInstance">SeccionEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingSeccionCollectionViaLibro(IEntity seccionInstance)
		{
			return GetMultiManyToManyUsingSeccionCollectionViaLibro(seccionInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this LibroEstatusCollection object all LibroEstatusEntity objects which are related via a  relation of type 'm:n' with the passed in SeccionEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="seccionInstance">SeccionEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingSeccionCollectionViaLibro(IEntity seccionInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingSeccionCollectionViaLibro(seccionInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this LibroEstatusCollection object all LibroEstatusEntity objects which are related via a  relation of type 'm:n' with the passed in SeccionEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="seccionInstance">SeccionEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToManyUsingSeccionCollectionViaLibro(IEntity seccionInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, int pageNumber, int pageSize)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			LibroEstatusDAO dao = DAOFactory.CreateLibroEstatusDAO();
			return dao.GetMultiUsingSeccionCollectionViaLibro(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, seccionInstance, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this LibroEstatusCollection object all LibroEstatusEntity objects which are related via a Relation of type 'm:n' with the passed in SeccionEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="seccionInstance">SeccionEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingSeccionCollectionViaLibro(IEntity seccionInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingSeccionCollectionViaLibro(seccionInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, prefetchPathToUse);
		}

		/// <summary> Retrieves in this LibroEstatusCollection object all LibroEstatusEntity objects which are related via a  relation of type 'm:n' with the passed in SeccionEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="seccionInstance">SeccionEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingSeccionCollectionViaLibro(IEntity seccionInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath prefetchPathToUse)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			LibroEstatusDAO dao = DAOFactory.CreateLibroEstatusDAO();
			return dao.GetMultiUsingSeccionCollectionViaLibro(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, seccionInstance, prefetchPathToUse);
		}

		/// <summary> Retrieves in this LibroEstatusCollection object all LibroEstatusEntity objects which are related via a  Relation of type 'm:n' with the passed in TematicaEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="tematicaInstance">TematicaEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingTematicaCollectionViaLibro(IEntity tematicaInstance)
		{
			return GetMultiManyToManyUsingTematicaCollectionViaLibro(tematicaInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this LibroEstatusCollection object all LibroEstatusEntity objects which are related via a  relation of type 'm:n' with the passed in TematicaEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="tematicaInstance">TematicaEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingTematicaCollectionViaLibro(IEntity tematicaInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingTematicaCollectionViaLibro(tematicaInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this LibroEstatusCollection object all LibroEstatusEntity objects which are related via a  relation of type 'm:n' with the passed in TematicaEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="tematicaInstance">TematicaEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToManyUsingTematicaCollectionViaLibro(IEntity tematicaInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, int pageNumber, int pageSize)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			LibroEstatusDAO dao = DAOFactory.CreateLibroEstatusDAO();
			return dao.GetMultiUsingTematicaCollectionViaLibro(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, tematicaInstance, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this LibroEstatusCollection object all LibroEstatusEntity objects which are related via a Relation of type 'm:n' with the passed in TematicaEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="tematicaInstance">TematicaEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingTematicaCollectionViaLibro(IEntity tematicaInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingTematicaCollectionViaLibro(tematicaInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, prefetchPathToUse);
		}

		/// <summary> Retrieves in this LibroEstatusCollection object all LibroEstatusEntity objects which are related via a  relation of type 'm:n' with the passed in TematicaEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="tematicaInstance">TematicaEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingTematicaCollectionViaLibro(IEntity tematicaInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath prefetchPathToUse)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			LibroEstatusDAO dao = DAOFactory.CreateLibroEstatusDAO();
			return dao.GetMultiUsingTematicaCollectionViaLibro(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, tematicaInstance, prefetchPathToUse);
		}

		/// <summary> Retrieves in this LibroEstatusCollection object all LibroEstatusEntity objects which are related via a  Relation of type 'm:n' with the passed in PaisEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="paisInstance">PaisEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingPaisCollectionViaLibro(IEntity paisInstance)
		{
			return GetMultiManyToManyUsingPaisCollectionViaLibro(paisInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this LibroEstatusCollection object all LibroEstatusEntity objects which are related via a  relation of type 'm:n' with the passed in PaisEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="paisInstance">PaisEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingPaisCollectionViaLibro(IEntity paisInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingPaisCollectionViaLibro(paisInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this LibroEstatusCollection object all LibroEstatusEntity objects which are related via a  relation of type 'm:n' with the passed in PaisEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="paisInstance">PaisEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToManyUsingPaisCollectionViaLibro(IEntity paisInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, int pageNumber, int pageSize)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			LibroEstatusDAO dao = DAOFactory.CreateLibroEstatusDAO();
			return dao.GetMultiUsingPaisCollectionViaLibro(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, paisInstance, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this LibroEstatusCollection object all LibroEstatusEntity objects which are related via a Relation of type 'm:n' with the passed in PaisEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="paisInstance">PaisEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingPaisCollectionViaLibro(IEntity paisInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingPaisCollectionViaLibro(paisInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, prefetchPathToUse);
		}

		/// <summary> Retrieves in this LibroEstatusCollection object all LibroEstatusEntity objects which are related via a  relation of type 'm:n' with the passed in PaisEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="paisInstance">PaisEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingPaisCollectionViaLibro(IEntity paisInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath prefetchPathToUse)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			LibroEstatusDAO dao = DAOFactory.CreateLibroEstatusDAO();
			return dao.GetMultiUsingPaisCollectionViaLibro(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, paisInstance, prefetchPathToUse);
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
			LibroEstatusDAO dao = DAOFactory.CreateLibroEstatusDAO();
			return dao.GetMultiAsDataTable(maxNumberOfItemsToReturn, sortClauses, selectFilter, relations, pageNumber, pageSize);
		}


		/// <summary> Deletes from the persistent storage all LibroEstatus entities which match with the specified filter, formulated in the predicate or predicate expression definition.</summary>
		/// <param name="deleteFilter">A predicate or predicate expression which should be used as filter for the entities to delete. Can be null, which will result in a query removing all LibroEstatus entities from the persistent storage</param>
		/// <returns>Amount of entities affected, if the used persistent storage has rowcounting enabled.</returns>
		public virtual int DeleteMulti(IPredicate deleteFilter)
		{
			LibroEstatusDAO dao = DAOFactory.CreateLibroEstatusDAO();
			return dao.DeleteMulti(base.Transaction, deleteFilter);
		}

		/// <summary> Deletes from the persistent storage all LibroEstatus entities which match with the specified filter, formulated in the predicate or predicate expression definition.</summary>
		/// <param name="deleteFilter">A predicate or predicate expression which should be used as filter for the entities to delete.</param>
		/// <param name="relations">The set of relations to walk to construct the total query.</param>
		/// <returns>Amount of entities affected, if the used persistent storage has rowcounting enabled.</returns>
		public virtual int DeleteMulti(IPredicate deleteFilter, IRelationCollection relations)
		{
			LibroEstatusDAO dao = DAOFactory.CreateLibroEstatusDAO();
			return dao.DeleteMulti(base.Transaction, deleteFilter, relations);
		}

		/// <summary> Updates in the persistent storage all entities which have data in common with the specified LibroEstatusEntity. If one is omitted that entity is not used as a filter. Which fields are updated in those matching entities depends on which fields are
		/// <i>changed</i> in entityWithNewValues. The new values of these fields are read from entityWithNewValues. </summary>
		/// <param name="entityWithNewValues">LibroEstatusEntity instance which holds the new values for the matching entities to update. Only changed fields are taken into account</param>
		/// <param name="updateFilter">A predicate or predicate expression which should be used as filter for the entities to update. Can be null, which
		/// will result in an update action which will affect all LibroEstatus entities.</param>
		/// <returns>Amount of entities affected, if the used persistent storage has rowcounting enabled.</returns>
		public int UpdateMulti(LibroEstatusEntity entityWithNewValues, IPredicate updateFilter)
		{
			LibroEstatusDAO dao = DAOFactory.CreateLibroEstatusDAO();
			return dao.UpdateMulti(entityWithNewValues, base.Transaction, updateFilter);
		}

		/// <summary> Updates in the persistent storage all entities which have data in common with the specified LibroEstatusEntity. If one is omitted that entity is not used as a filter. Which fields are updated in those matching entities depends on which fields are
		/// <i>changed</i> in entityWithNewValues. The new values of these fields are read from entityWithNewValues. </summary>
		/// <param name="entityWithNewValues">LibroEstatusEntity instance which holds the new values for the matching entities to update. Only changed fields are taken into account</param>
		/// <param name="updateFilter">A predicate or predicate expression which should be used as filter for the entities to update.</param>
		/// <param name="relations">The set of relations to walk to construct the total query.</param>
		/// <returns>Amount of entities affected, if the used persistent storage has rowcounting enabled.</returns>
		public int UpdateMulti(LibroEstatusEntity entityWithNewValues, IPredicate updateFilter, IRelationCollection relations)
		{
			LibroEstatusDAO dao = DAOFactory.CreateLibroEstatusDAO();
			return dao.UpdateMulti(entityWithNewValues, base.Transaction, updateFilter, relations);
		}

		
		/// <summary> Gets a scalar value, calculated with the aggregate. the field index specified is the field the aggregate are applied on.</summary>
		/// <param name="fieldIndex">Field index of field to which to apply the aggregate function and expression</param>
		/// <param name="aggregateToApply">Aggregate function to apply. </param>
		/// <returns>the scalar value requested</returns>
		public object GetScalar(LibroEstatusFieldIndex fieldIndex, AggregateFunction aggregateToApply)
		{
			return GetScalar(fieldIndex, null, aggregateToApply, null, null, null);
		}

		/// <summary> Gets a scalar value, calculated with the aggregate and expression specified. the field index specified is the field the expression and aggregate are applied on.</summary>
		/// <param name="fieldIndex">Field index of field to which to apply the aggregate function and expression</param>
		/// <param name="expressionToExecute">The expression to execute. Can be null</param>
		/// <param name="aggregateToApply">Aggregate function to apply. </param>
		/// <returns>the scalar value requested</returns>
		public object GetScalar(LibroEstatusFieldIndex fieldIndex, IExpression expressionToExecute, AggregateFunction aggregateToApply)
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
		public object GetScalar(LibroEstatusFieldIndex fieldIndex, IExpression expressionToExecute, AggregateFunction aggregateToApply, IPredicate filter)
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
		public object GetScalar(LibroEstatusFieldIndex fieldIndex, IExpression expressionToExecute, AggregateFunction aggregateToApply, IPredicate filter, IGroupByCollection groupByClause)
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
		public virtual object GetScalar(LibroEstatusFieldIndex fieldIndex, IExpression expressionToExecute, AggregateFunction aggregateToApply, IPredicate filter, IRelationCollection relations, IGroupByCollection groupByClause)
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
			LibroEstatusDAO dao = DAOFactory.CreateLibroEstatusDAO();
			return dao.GetScalar(fields, base.Transaction, filter, relations, groupByClause);
		}
		
		/// <summary>Creats a new DAO instance so code which is in the base class can still use the proper DAO object.</summary>
		protected override IDao CreateDAOInstance()
		{
			return DAOFactory.CreateLibroEstatusDAO();
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
