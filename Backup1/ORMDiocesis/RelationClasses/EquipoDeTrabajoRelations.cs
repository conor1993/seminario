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
	/// Implements the static Relations variant for the entity: EquipoDeTrabajo.
	/// This class is generated. Do not modify.
	/// </summary>
	public partial class EquipoDeTrabajoRelations
	{
		/// <summary>
		/// CTor
		/// </summary>
		public EquipoDeTrabajoRelations()
		{
		}

		#region Class Property Declarations

	
	
		/// <summary>Returns a new IEntityRelation object, between EquipoDeTrabajoEntity and EventoEntity over the m:1 relation they have, using the relation between the fields:
		/// EquipoDeTrabajo.IdEvento - Evento.Id
		/// </summary>
		public virtual IEntityRelation EventoEntityUsingIdEvento
		{
			get
			{

				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
				relation.StartEntityIsPkSide = false;
				relation.AddEntityFieldPair(EntityFieldFactory.Create(EventoFieldIndex.Id), EntityFieldFactory.Create(EquipoDeTrabajoFieldIndex.IdEvento));
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EventoEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EquipoDeTrabajoEntity", true);
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
