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
	/// Implements the static Relations variant for the entity: Asistencia.
	/// This class is generated. Do not modify.
	/// </summary>
	public partial class AsistenciaRelations
	{
		/// <summary>
		/// CTor
		/// </summary>
		public AsistenciaRelations()
		{
		}

		#region Class Property Declarations

	
	
		/// <summary>Returns a new IEntityRelation object, between AsistenciaEntity and EventoEntity over the m:1 relation they have, using the relation between the fields:
		/// Asistencia.IdEvento - Evento.Id
		/// </summary>
		public virtual IEntityRelation EventoEntityUsingIdEvento
		{
			get
			{

				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
				relation.StartEntityIsPkSide = false;
				relation.AddEntityFieldPair(EntityFieldFactory.Create(EventoFieldIndex.Id), EntityFieldFactory.Create(AsistenciaFieldIndex.IdEvento));
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EventoEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AsistenciaEntity", true);
				return relation;
			}
		}
	
		/// <summary>Returns a new IEntityRelation object, between AsistenciaEntity and ParrocoEntity over the m:1 relation they have, using the relation between the fields:
		/// Asistencia.CodParroco - Parroco.Id
		/// </summary>
		public virtual IEntityRelation ParrocoEntityUsingCodParroco
		{
			get
			{

				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
				relation.StartEntityIsPkSide = false;
				relation.AddEntityFieldPair(EntityFieldFactory.Create(ParrocoFieldIndex.Id), EntityFieldFactory.Create(AsistenciaFieldIndex.CodParroco));
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ParrocoEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AsistenciaEntity", true);
				return relation;
			}
		}
	
		/// <summary>Returns a new IEntityRelation object, between AsistenciaEntity and ParroquiaEntity over the m:1 relation they have, using the relation between the fields:
		/// Asistencia.CodParroquia - Parroquia.Id
		/// </summary>
		public virtual IEntityRelation ParroquiaEntityUsingCodParroquia
		{
			get
			{

				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
				relation.StartEntityIsPkSide = false;
				relation.AddEntityFieldPair(EntityFieldFactory.Create(ParroquiaFieldIndex.Id), EntityFieldFactory.Create(AsistenciaFieldIndex.CodParroquia));
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ParroquiaEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AsistenciaEntity", true);
				return relation;
			}
		}
	
		/// <summary>Returns a new IEntityRelation object, between AsistenciaEntity and ParticipanteEntity over the m:1 relation they have, using the relation between the fields:
		/// Asistencia.IdParticipante - Participante.Id
		/// </summary>
		public virtual IEntityRelation ParticipanteEntityUsingIdParticipante
		{
			get
			{

				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
				relation.StartEntityIsPkSide = false;
				relation.AddEntityFieldPair(EntityFieldFactory.Create(ParticipanteFieldIndex.Id), EntityFieldFactory.Create(AsistenciaFieldIndex.IdParticipante));
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ParticipanteEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AsistenciaEntity", true);
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
