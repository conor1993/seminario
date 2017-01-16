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
	/// Implements the static Relations variant for the entity: Rama.
	/// This class is generated. Do not modify.
	/// </summary>
	public partial class RamaRelations
	{
		/// <summary>
		/// CTor
		/// </summary>
		public RamaRelations()
		{
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between RamaEntity and LibroEntity over the 1:n relation they have, using the relation between the fields:
		/// Rama.Id - Libro.IdRama
		/// </summary>
		public virtual IEntityRelation LibroEntityUsingIdRama
		{
			get
			{

				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
				relation.StartEntityIsPkSide = true;
				relation.AddEntityFieldPair(EntityFieldFactory.Create(RamaFieldIndex.Id), EntityFieldFactory.Create(LibroFieldIndex.IdRama));
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("RamaEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("LibroEntity", false);
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
