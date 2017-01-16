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
	/// Implements the static Relations variant for the entity: Parroco.
	/// This class is generated. Do not modify.
	/// </summary>
	public partial class ParrocoRelations
	{
		/// <summary>
		/// CTor
		/// </summary>
		public ParrocoRelations()
		{
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between ParrocoEntity and AsistenciaEntity over the 1:n relation they have, using the relation between the fields:
		/// Parroco.Id - Asistencia.CodParroco
		/// </summary>
		public virtual IEntityRelation AsistenciaEntityUsingCodParroco
		{
			get
			{

				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
				relation.StartEntityIsPkSide = true;
				relation.AddEntityFieldPair(EntityFieldFactory.Create(ParrocoFieldIndex.Id), EntityFieldFactory.Create(AsistenciaFieldIndex.CodParroco));
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ParrocoEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AsistenciaEntity", false);
				return relation;
			}
		}
	
	
	
		/// <summary>Returns a new IEntityRelation object, between ParrocoEntity and ParroquiaEntity over the m:1 relation they have, using the relation between the fields:
		/// Parroco.IdParroquia - Parroquia.Id
		/// </summary>
		public virtual IEntityRelation ParroquiaEntityUsingIdParroquia
		{
			get
			{

				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
				relation.StartEntityIsPkSide = false;
				relation.AddEntityFieldPair(EntityFieldFactory.Create(ParroquiaFieldIndex.Id), EntityFieldFactory.Create(ParrocoFieldIndex.IdParroquia));
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ParroquiaEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ParrocoEntity", true);
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
