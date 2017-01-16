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
	/// Implements the static Relations variant for the entity: Parroquia.
	/// This class is generated. Do not modify.
	/// </summary>
	public partial class ParroquiaRelations
	{
		/// <summary>
		/// CTor
		/// </summary>
		public ParroquiaRelations()
		{
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between ParroquiaEntity and ParrocoEntity over the 1:n relation they have, using the relation between the fields:
		/// Parroquia.Id - Parroco.IdParroquia
		/// </summary>
		public virtual IEntityRelation ParrocoEntityUsingIdParroquia
		{
			get
			{

				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
				relation.StartEntityIsPkSide = true;
				relation.AddEntityFieldPair(EntityFieldFactory.Create(ParroquiaFieldIndex.Id), EntityFieldFactory.Create(ParrocoFieldIndex.IdParroquia));
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ParroquiaEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ParrocoEntity", false);
				return relation;
			}
		}
	
		/// <summary>Returns a new IEntityRelation object, between ParroquiaEntity and AsistenciaEntity over the 1:n relation they have, using the relation between the fields:
		/// Parroquia.Id - Asistencia.CodParroquia
		/// </summary>
		public virtual IEntityRelation AsistenciaEntityUsingCodParroquia
		{
			get
			{

				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
				relation.StartEntityIsPkSide = true;
				relation.AddEntityFieldPair(EntityFieldFactory.Create(ParroquiaFieldIndex.Id), EntityFieldFactory.Create(AsistenciaFieldIndex.CodParroquia));
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ParroquiaEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AsistenciaEntity", false);
				return relation;
			}
		}
	
	
	
		/// <summary>Returns a new IEntityRelation object, between ParroquiaEntity and CiudadEntity over the m:1 relation they have, using the relation between the fields:
		/// Parroquia.IdCiudad - Ciudad.Id
		/// </summary>
		public virtual IEntityRelation CiudadEntityUsingIdCiudad
		{
			get
			{

				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
				relation.StartEntityIsPkSide = false;
				relation.AddEntityFieldPair(EntityFieldFactory.Create(CiudadFieldIndex.Id), EntityFieldFactory.Create(ParroquiaFieldIndex.IdCiudad));
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CiudadEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ParroquiaEntity", true);
				return relation;
			}
		}
	
		/// <summary>Returns a new IEntityRelation object, between ParroquiaEntity and TipoParroquiaEntity over the m:1 relation they have, using the relation between the fields:
		/// Parroquia.IdTipoParroquia - TipoParroquia.Id
		/// </summary>
		public virtual IEntityRelation TipoParroquiaEntityUsingIdTipoParroquia
		{
			get
			{

				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
				relation.StartEntityIsPkSide = false;
				relation.AddEntityFieldPair(EntityFieldFactory.Create(TipoParroquiaFieldIndex.Id), EntityFieldFactory.Create(ParroquiaFieldIndex.IdTipoParroquia));
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("TipoParroquiaEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ParroquiaEntity", true);
				return relation;
			}
		}
	
		/// <summary>Returns a new IEntityRelation object, between ParroquiaEntity and ZonaPastoralEntity over the m:1 relation they have, using the relation between the fields:
		/// Parroquia.IdZonaPastoral - ZonaPastoral.Id
		/// </summary>
		public virtual IEntityRelation ZonaPastoralEntityUsingIdZonaPastoral
		{
			get
			{

				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
				relation.StartEntityIsPkSide = false;
				relation.AddEntityFieldPair(EntityFieldFactory.Create(ZonaPastoralFieldIndex.Id), EntityFieldFactory.Create(ParroquiaFieldIndex.IdZonaPastoral));
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ZonaPastoralEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ParroquiaEntity", true);
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
