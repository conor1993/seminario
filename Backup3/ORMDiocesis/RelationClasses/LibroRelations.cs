///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 2.0.0.0
// Code is generated using templates: SD.TemplateBindings.SharedTemplates.NET20
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;

using ORMDiocesis;
using ORMDiocesis.FactoryClasses;
using ORMDiocesis.HelperClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace ORMDiocesis.RelationClasses
{
	/// <summary>
	/// Implements the static Relations variant for the entity: Libro.
	/// This class is generated. Do not modify.
	/// </summary>
	public partial class LibroRelations
	{
		/// <summary>
		/// CTor
		/// </summary>
		public LibroRelations()
		{
		}

		#region Class Property Declarations

	
	
		/// <summary>Returns a new IEntityRelation object, between LibroEntity and AutorEntity over the m:1 relation they have, using the relation between the fields:
		/// Libro.IdAutor - Autor.Id
		/// </summary>
		public virtual IEntityRelation AutorEntityUsingIdAutor
		{
			get
			{

				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
				relation.StartEntityIsPkSide = false;
				relation.AddEntityFieldPair(EntityFieldFactory.Create(AutorFieldIndex.Id), EntityFieldFactory.Create(LibroFieldIndex.IdAutor));
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AutorEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("LibroEntity", true);
				return relation;
			}
		}
	
		/// <summary>Returns a new IEntityRelation object, between LibroEntity and EditorialEntity over the m:1 relation they have, using the relation between the fields:
		/// Libro.IdEditorial - Editorial.Id
		/// </summary>
		public virtual IEntityRelation EditorialEntityUsingIdEditorial
		{
			get
			{

				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
				relation.StartEntityIsPkSide = false;
				relation.AddEntityFieldPair(EntityFieldFactory.Create(EditorialFieldIndex.Id), EntityFieldFactory.Create(LibroFieldIndex.IdEditorial));
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EditorialEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("LibroEntity", true);
				return relation;
			}
		}
	
		/// <summary>Returns a new IEntityRelation object, between LibroEntity and LibroEstatusEntity over the m:1 relation they have, using the relation between the fields:
		/// Libro.Estatus - LibroEstatus.Id
		/// </summary>
		public virtual IEntityRelation LibroEstatusEntityUsingEstatus
		{
			get
			{

				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
				relation.StartEntityIsPkSide = false;
				relation.AddEntityFieldPair(EntityFieldFactory.Create(LibroEstatusFieldIndex.Id), EntityFieldFactory.Create(LibroFieldIndex.Estatus));
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("LibroEstatusEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("LibroEntity", true);
				return relation;
			}
		}
	
		/// <summary>Returns a new IEntityRelation object, between LibroEntity and LibroFormatoEntity over the m:1 relation they have, using the relation between the fields:
		/// Libro.Formato - LibroFormato.Id
		/// </summary>
		public virtual IEntityRelation LibroFormatoEntityUsingFormato
		{
			get
			{

				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
				relation.StartEntityIsPkSide = false;
				relation.AddEntityFieldPair(EntityFieldFactory.Create(LibroFormatoFieldIndex.Id), EntityFieldFactory.Create(LibroFieldIndex.Formato));
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("LibroFormatoEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("LibroEntity", true);
				return relation;
			}
		}
	
		/// <summary>Returns a new IEntityRelation object, between LibroEntity and RamaEntity over the m:1 relation they have, using the relation between the fields:
		/// Libro.IdRama - Rama.Id
		/// </summary>
		public virtual IEntityRelation RamaEntityUsingIdRama
		{
			get
			{

				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
				relation.StartEntityIsPkSide = false;
				relation.AddEntityFieldPair(EntityFieldFactory.Create(RamaFieldIndex.Id), EntityFieldFactory.Create(LibroFieldIndex.IdRama));
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("RamaEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("LibroEntity", true);
				return relation;
			}
		}
	
		/// <summary>Returns a new IEntityRelation object, between LibroEntity and SeccionEntity over the m:1 relation they have, using the relation between the fields:
		/// Libro.IdSeccion - Seccion.Id
		/// </summary>
		public virtual IEntityRelation SeccionEntityUsingIdSeccion
		{
			get
			{

				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
				relation.StartEntityIsPkSide = false;
				relation.AddEntityFieldPair(EntityFieldFactory.Create(SeccionFieldIndex.Id), EntityFieldFactory.Create(LibroFieldIndex.IdSeccion));
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SeccionEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("LibroEntity", true);
				return relation;
			}
		}
	
		/// <summary>Returns a new IEntityRelation object, between LibroEntity and TematicaEntity over the m:1 relation they have, using the relation between the fields:
		/// Libro.IdTematica - Tematica.Id
		/// </summary>
		public virtual IEntityRelation TematicaEntityUsingIdTematica
		{
			get
			{

				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
				relation.StartEntityIsPkSide = false;
				relation.AddEntityFieldPair(EntityFieldFactory.Create(TematicaFieldIndex.Id), EntityFieldFactory.Create(LibroFieldIndex.IdTematica));
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("TematicaEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("LibroEntity", true);
				return relation;
			}
		}
	
		/// <summary>Returns a new IEntityRelation object, between LibroEntity and PaisEntity over the m:1 relation they have, using the relation between the fields:
		/// Libro.IdPais - Pais.Id
		/// </summary>
		public virtual IEntityRelation PaisEntityUsingIdPais
		{
			get
			{

				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
				relation.StartEntityIsPkSide = false;
				relation.AddEntityFieldPair(EntityFieldFactory.Create(PaisFieldIndex.Id), EntityFieldFactory.Create(LibroFieldIndex.IdPais));
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PaisEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("LibroEntity", true);
				return relation;
			}
		}
	

		/// <summary>stub, not used in this entity, only for TargetPerEntity entities.</summary>
		public virtual IEntityRelation GetSubTypeRelation(string subTypeEntityName) { return null; }
		/// <summary>stub, not used in this entity, only for TargetPerEntity entities.</summary>
		public virtual IEntityRelation GetSuperTypeRelation() { return null;}

		#endregion

		#region Included Code

		#endregion
	}
}
