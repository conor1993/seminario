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
	/// Implements the static Relations variant for the entity: Seccion.
	/// This class is generated. Do not modify.
	/// </summary>
	public partial class SeccionRelations
	{
		/// <summary>
		/// CTor
		/// </summary>
		public SeccionRelations()
		{
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between SeccionEntity and RamaEntity over the 1:n relation they have, using the relation between the fields:
		/// Seccion.Id - Rama.IdSeccion
		/// </summary>
		public virtual IEntityRelation RamaEntityUsingIdSeccion
		{
			get
			{

				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
				relation.StartEntityIsPkSide = true;
				relation.AddEntityFieldPair(EntityFieldFactory.Create(SeccionFieldIndex.Id), EntityFieldFactory.Create(RamaFieldIndex.IdSeccion));
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SeccionEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("RamaEntity", false);
				return relation;
			}
		}
	
		/// <summary>Returns a new IEntityRelation object, between SeccionEntity and TematicaEntity over the 1:n relation they have, using the relation between the fields:
		/// Seccion.Id - Tematica.IdSeccion
		/// </summary>
		public virtual IEntityRelation TematicaEntityUsingIdSeccion
		{
			get
			{

				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
				relation.StartEntityIsPkSide = true;
				relation.AddEntityFieldPair(EntityFieldFactory.Create(SeccionFieldIndex.Id), EntityFieldFactory.Create(TematicaFieldIndex.IdSeccion));
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SeccionEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("TematicaEntity", false);
				return relation;
			}
		}
	
		/// <summary>Returns a new IEntityRelation object, between SeccionEntity and LibroEntity over the 1:n relation they have, using the relation between the fields:
		/// Seccion.Id - Libro.IdSeccion
		/// </summary>
		public virtual IEntityRelation LibroEntityUsingIdSeccion
		{
			get
			{

				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
				relation.StartEntityIsPkSide = true;
				relation.AddEntityFieldPair(EntityFieldFactory.Create(SeccionFieldIndex.Id), EntityFieldFactory.Create(LibroFieldIndex.IdSeccion));
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SeccionEntity", true);
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
