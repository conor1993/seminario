﻿///////////////////////////////////////////////////////////////
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
	/// Implements the static Relations variant for the entity: Tematica.
	/// This class is generated. Do not modify.
	/// </summary>
	public partial class TematicaRelations
	{
		/// <summary>
		/// CTor
		/// </summary>
		public TematicaRelations()
		{
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between TematicaEntity and LibroEntity over the 1:n relation they have, using the relation between the fields:
		/// Tematica.Id - Libro.IdTematica
		/// </summary>
		public virtual IEntityRelation LibroEntityUsingIdTematica
		{
			get
			{

				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
				relation.StartEntityIsPkSide = true;
				relation.AddEntityFieldPair(EntityFieldFactory.Create(TematicaFieldIndex.Id), EntityFieldFactory.Create(LibroFieldIndex.IdTematica));
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("TematicaEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("LibroEntity", false);
				return relation;
			}
		}
	
	
	
		/// <summary>Returns a new IEntityRelation object, between TematicaEntity and RamaEntity over the m:1 relation they have, using the relation between the fields:
		/// Tematica.IdRama - Rama.Id
		/// </summary>
		public virtual IEntityRelation RamaEntityUsingIdRama
		{
			get
			{

				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
				relation.StartEntityIsPkSide = false;
				relation.AddEntityFieldPair(EntityFieldFactory.Create(RamaFieldIndex.Id), EntityFieldFactory.Create(TematicaFieldIndex.IdRama));
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("RamaEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("TematicaEntity", true);
				return relation;
			}
		}
	
		/// <summary>Returns a new IEntityRelation object, between TematicaEntity and SeccionEntity over the m:1 relation they have, using the relation between the fields:
		/// Tematica.IdSeccion - Seccion.Id
		/// </summary>
		public virtual IEntityRelation SeccionEntityUsingIdSeccion
		{
			get
			{

				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
				relation.StartEntityIsPkSide = false;
				relation.AddEntityFieldPair(EntityFieldFactory.Create(SeccionFieldIndex.Id), EntityFieldFactory.Create(TematicaFieldIndex.IdSeccion));
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SeccionEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("TematicaEntity", true);
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
