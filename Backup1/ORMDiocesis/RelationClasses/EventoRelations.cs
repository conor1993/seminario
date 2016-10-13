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
	/// Implements the static Relations variant for the entity: Evento.
	/// This class is generated. Do not modify.
	/// </summary>
	public partial class EventoRelations
	{
		/// <summary>
		/// CTor
		/// </summary>
		public EventoRelations()
		{
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between EventoEntity and EquipoDeTrabajoEntity over the 1:n relation they have, using the relation between the fields:
		/// Evento.Id - EquipoDeTrabajo.IdEvento
		/// </summary>
		public virtual IEntityRelation EquipoDeTrabajoEntityUsingIdEvento
		{
			get
			{

				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
				relation.StartEntityIsPkSide = true;
				relation.AddEntityFieldPair(EntityFieldFactory.Create(EventoFieldIndex.Id), EntityFieldFactory.Create(EquipoDeTrabajoFieldIndex.IdEvento));
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EventoEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EquipoDeTrabajoEntity", false);
				return relation;
			}
		}
	
		/// <summary>Returns a new IEntityRelation object, between EventoEntity and AsistenciaEntity over the 1:n relation they have, using the relation between the fields:
		/// Evento.Id - Asistencia.IdEvento
		/// </summary>
		public virtual IEntityRelation AsistenciaEntityUsingIdEvento
		{
			get
			{

				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
				relation.StartEntityIsPkSide = true;
				relation.AddEntityFieldPair(EntityFieldFactory.Create(EventoFieldIndex.Id), EntityFieldFactory.Create(AsistenciaFieldIndex.IdEvento));
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EventoEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AsistenciaEntity", false);
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
