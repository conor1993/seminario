﻿///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 2.0.0.0
// Code is generated on: jueves, 07 de julio de 2016 11:14:01 a.m.
// Code is generated using templates: SD.TemplateBindings.SharedTemplates.NET20
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.Data;
using ORMDiocesis;
using ORMDiocesis.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace ORMDiocesis.FactoryClasses
{
	/// <summary>
	/// Generates IEntityFields instances for different kind of Entities. 
	/// This class is generated. Do not modify.
	/// </summary>
	public partial class EntityFieldsFactory
	{
		/// <summary>
		/// Private CTor, no instantiation possible.
		/// </summary>
		private EntityFieldsFactory()
		{
		}


		/// <summary>General factory entrance method which will return an EntityFields object with the format generated by the factory specified</summary>
		/// <param name="relatedEntityType">The type of entity the fields are for</param>
		/// <returns>The IEntityFields instance requested</returns>
		public static IEntityFields CreateEntityFieldsObject(EntityType relatedEntityType)
		{
			IEntityFields fieldsToReturn=null;
			IInheritanceInfoProvider inheritanceProvider = InheritanceInfoProviderSingleton.GetInstance();
			IFieldInfoProvider fieldProvider = FieldInfoProviderSingleton.GetInstance();
			switch(relatedEntityType)
			{
				case ORMDiocesis.EntityType.AsistenciaEntity:
					fieldsToReturn = new EntityFields((int)AsistenciaFieldIndex.AmountOfFields, inheritanceProvider, fieldProvider.GetFieldIndexes("AsistenciaEntity"));
					CreateAsistenciaEntityFields(ref fieldsToReturn);
					break;
				case ORMDiocesis.EntityType.AutorEntity:
					fieldsToReturn = new EntityFields((int)AutorFieldIndex.AmountOfFields, inheritanceProvider, fieldProvider.GetFieldIndexes("AutorEntity"));
					CreateAutorEntityFields(ref fieldsToReturn);
					break;
				case ORMDiocesis.EntityType.CiudadEntity:
					fieldsToReturn = new EntityFields((int)CiudadFieldIndex.AmountOfFields, inheritanceProvider, fieldProvider.GetFieldIndexes("CiudadEntity"));
					CreateCiudadEntityFields(ref fieldsToReturn);
					break;
				case ORMDiocesis.EntityType.CiudadesEntity:
					fieldsToReturn = new EntityFields((int)CiudadesFieldIndex.AmountOfFields, inheritanceProvider, fieldProvider.GetFieldIndexes("CiudadesEntity"));
					CreateCiudadesEntityFields(ref fieldsToReturn);
					break;
				case ORMDiocesis.EntityType.EditorialEntity:
					fieldsToReturn = new EntityFields((int)EditorialFieldIndex.AmountOfFields, inheritanceProvider, fieldProvider.GetFieldIndexes("EditorialEntity"));
					CreateEditorialEntityFields(ref fieldsToReturn);
					break;
				case ORMDiocesis.EntityType.EquipoDeTrabajoEntity:
					fieldsToReturn = new EntityFields((int)EquipoDeTrabajoFieldIndex.AmountOfFields, inheritanceProvider, fieldProvider.GetFieldIndexes("EquipoDeTrabajoEntity"));
					CreateEquipoDeTrabajoEntityFields(ref fieldsToReturn);
					break;
				case ORMDiocesis.EntityType.EventoEntity:
					fieldsToReturn = new EntityFields((int)EventoFieldIndex.AmountOfFields, inheritanceProvider, fieldProvider.GetFieldIndexes("EventoEntity"));
					CreateEventoEntityFields(ref fieldsToReturn);
					break;
				case ORMDiocesis.EntityType.LibroEntity:
					fieldsToReturn = new EntityFields((int)LibroFieldIndex.AmountOfFields, inheritanceProvider, fieldProvider.GetFieldIndexes("LibroEntity"));
					CreateLibroEntityFields(ref fieldsToReturn);
					break;
				case ORMDiocesis.EntityType.PaisEntity:
					fieldsToReturn = new EntityFields((int)PaisFieldIndex.AmountOfFields, inheritanceProvider, fieldProvider.GetFieldIndexes("PaisEntity"));
					CreatePaisEntityFields(ref fieldsToReturn);
					break;
				case ORMDiocesis.EntityType.ParrocoEntity:
					fieldsToReturn = new EntityFields((int)ParrocoFieldIndex.AmountOfFields, inheritanceProvider, fieldProvider.GetFieldIndexes("ParrocoEntity"));
					CreateParrocoEntityFields(ref fieldsToReturn);
					break;
				case ORMDiocesis.EntityType.ParroquiaEntity:
					fieldsToReturn = new EntityFields((int)ParroquiaFieldIndex.AmountOfFields, inheritanceProvider, fieldProvider.GetFieldIndexes("ParroquiaEntity"));
					CreateParroquiaEntityFields(ref fieldsToReturn);
					break;
				case ORMDiocesis.EntityType.ParticipanteEntity:
					fieldsToReturn = new EntityFields((int)ParticipanteFieldIndex.AmountOfFields, inheritanceProvider, fieldProvider.GetFieldIndexes("ParticipanteEntity"));
					CreateParticipanteEntityFields(ref fieldsToReturn);
					break;
				case ORMDiocesis.EntityType.RamaEntity:
					fieldsToReturn = new EntityFields((int)RamaFieldIndex.AmountOfFields, inheritanceProvider, fieldProvider.GetFieldIndexes("RamaEntity"));
					CreateRamaEntityFields(ref fieldsToReturn);
					break;
				case ORMDiocesis.EntityType.SeccionEntity:
					fieldsToReturn = new EntityFields((int)SeccionFieldIndex.AmountOfFields, inheritanceProvider, fieldProvider.GetFieldIndexes("SeccionEntity"));
					CreateSeccionEntityFields(ref fieldsToReturn);
					break;
				case ORMDiocesis.EntityType.TematicaEntity:
					fieldsToReturn = new EntityFields((int)TematicaFieldIndex.AmountOfFields, inheritanceProvider, fieldProvider.GetFieldIndexes("TematicaEntity"));
					CreateTematicaEntityFields(ref fieldsToReturn);
					break;
				case ORMDiocesis.EntityType.TipoParroquiaEntity:
					fieldsToReturn = new EntityFields((int)TipoParroquiaFieldIndex.AmountOfFields, inheritanceProvider, fieldProvider.GetFieldIndexes("TipoParroquiaEntity"));
					CreateTipoParroquiaEntityFields(ref fieldsToReturn);
					break;
				case ORMDiocesis.EntityType.VwListasEntity:
					fieldsToReturn = new EntityFields((int)VwListasFieldIndex.AmountOfFields, inheritanceProvider, fieldProvider.GetFieldIndexes("VwListasEntity"));
					CreateVwListasEntityFields(ref fieldsToReturn);
					break;
				case ORMDiocesis.EntityType.VwparroquiasEntity:
					fieldsToReturn = new EntityFields((int)VwparroquiasFieldIndex.AmountOfFields, inheritanceProvider, fieldProvider.GetFieldIndexes("VwparroquiasEntity"));
					CreateVwparroquiasEntityFields(ref fieldsToReturn);
					break;
				case ORMDiocesis.EntityType.ZonaPastoralEntity:
					fieldsToReturn = new EntityFields((int)ZonaPastoralFieldIndex.AmountOfFields, inheritanceProvider, fieldProvider.GetFieldIndexes("ZonaPastoralEntity"));
					CreateZonaPastoralEntityFields(ref fieldsToReturn);
					break;
			}
			return fieldsToReturn;
		}
		
		/// <summary>General method which will return an array of IEntityFieldCore objects, used by the InheritanceInfoProvider. Only the fields defined in the entity are returned, no inherited fields.</summary>
		/// <param name="entityName">the name of the entity to get the fields for. Example: "CustomerEntity"</param>
		/// <returns>array of IEntityFieldCore fields, defined in the entity with the name specified</returns>
		internal static IEntityFieldCore[] CreateFields(string entityName)
		{
			IEntityFieldCore[] toReturn = null;
			switch(entityName)
			{
				default:
					break;
			}
			return toReturn;
		}


		/// <summary>Creates a complete EntityFields instance for the AsistenciaEntity.</summary>
		/// <param name="fieldsToFill">the fields object to fill</param>
		private static void CreateAsistenciaEntityFields(ref IEntityFields fieldsToFill)
		{
			for(int i=0;i<(int)AsistenciaFieldIndex.AmountOfFields;i++)
			{
				fieldsToFill[i] = EntityFieldFactory.Create((AsistenciaFieldIndex)i);
			}
		}
	

		/// <summary>Creates a complete EntityFields instance for the AutorEntity.</summary>
		/// <param name="fieldsToFill">the fields object to fill</param>
		private static void CreateAutorEntityFields(ref IEntityFields fieldsToFill)
		{
			for(int i=0;i<(int)AutorFieldIndex.AmountOfFields;i++)
			{
				fieldsToFill[i] = EntityFieldFactory.Create((AutorFieldIndex)i);
			}
		}
	

		/// <summary>Creates a complete EntityFields instance for the CiudadEntity.</summary>
		/// <param name="fieldsToFill">the fields object to fill</param>
		private static void CreateCiudadEntityFields(ref IEntityFields fieldsToFill)
		{
			for(int i=0;i<(int)CiudadFieldIndex.AmountOfFields;i++)
			{
				fieldsToFill[i] = EntityFieldFactory.Create((CiudadFieldIndex)i);
			}
		}
	

		/// <summary>Creates a complete EntityFields instance for the CiudadesEntity.</summary>
		/// <param name="fieldsToFill">the fields object to fill</param>
		private static void CreateCiudadesEntityFields(ref IEntityFields fieldsToFill)
		{
			for(int i=0;i<(int)CiudadesFieldIndex.AmountOfFields;i++)
			{
				fieldsToFill[i] = EntityFieldFactory.Create((CiudadesFieldIndex)i);
			}
		}
	

		/// <summary>Creates a complete EntityFields instance for the EditorialEntity.</summary>
		/// <param name="fieldsToFill">the fields object to fill</param>
		private static void CreateEditorialEntityFields(ref IEntityFields fieldsToFill)
		{
			for(int i=0;i<(int)EditorialFieldIndex.AmountOfFields;i++)
			{
				fieldsToFill[i] = EntityFieldFactory.Create((EditorialFieldIndex)i);
			}
		}
	

		/// <summary>Creates a complete EntityFields instance for the EquipoDeTrabajoEntity.</summary>
		/// <param name="fieldsToFill">the fields object to fill</param>
		private static void CreateEquipoDeTrabajoEntityFields(ref IEntityFields fieldsToFill)
		{
			for(int i=0;i<(int)EquipoDeTrabajoFieldIndex.AmountOfFields;i++)
			{
				fieldsToFill[i] = EntityFieldFactory.Create((EquipoDeTrabajoFieldIndex)i);
			}
		}
	

		/// <summary>Creates a complete EntityFields instance for the EventoEntity.</summary>
		/// <param name="fieldsToFill">the fields object to fill</param>
		private static void CreateEventoEntityFields(ref IEntityFields fieldsToFill)
		{
			for(int i=0;i<(int)EventoFieldIndex.AmountOfFields;i++)
			{
				fieldsToFill[i] = EntityFieldFactory.Create((EventoFieldIndex)i);
			}
		}
	

		/// <summary>Creates a complete EntityFields instance for the LibroEntity.</summary>
		/// <param name="fieldsToFill">the fields object to fill</param>
		private static void CreateLibroEntityFields(ref IEntityFields fieldsToFill)
		{
			for(int i=0;i<(int)LibroFieldIndex.AmountOfFields;i++)
			{
				fieldsToFill[i] = EntityFieldFactory.Create((LibroFieldIndex)i);
			}
		}
	

		/// <summary>Creates a complete EntityFields instance for the PaisEntity.</summary>
		/// <param name="fieldsToFill">the fields object to fill</param>
		private static void CreatePaisEntityFields(ref IEntityFields fieldsToFill)
		{
			for(int i=0;i<(int)PaisFieldIndex.AmountOfFields;i++)
			{
				fieldsToFill[i] = EntityFieldFactory.Create((PaisFieldIndex)i);
			}
		}
	

		/// <summary>Creates a complete EntityFields instance for the ParrocoEntity.</summary>
		/// <param name="fieldsToFill">the fields object to fill</param>
		private static void CreateParrocoEntityFields(ref IEntityFields fieldsToFill)
		{
			for(int i=0;i<(int)ParrocoFieldIndex.AmountOfFields;i++)
			{
				fieldsToFill[i] = EntityFieldFactory.Create((ParrocoFieldIndex)i);
			}
		}
	

		/// <summary>Creates a complete EntityFields instance for the ParroquiaEntity.</summary>
		/// <param name="fieldsToFill">the fields object to fill</param>
		private static void CreateParroquiaEntityFields(ref IEntityFields fieldsToFill)
		{
			for(int i=0;i<(int)ParroquiaFieldIndex.AmountOfFields;i++)
			{
				fieldsToFill[i] = EntityFieldFactory.Create((ParroquiaFieldIndex)i);
			}
		}
	

		/// <summary>Creates a complete EntityFields instance for the ParticipanteEntity.</summary>
		/// <param name="fieldsToFill">the fields object to fill</param>
		private static void CreateParticipanteEntityFields(ref IEntityFields fieldsToFill)
		{
			for(int i=0;i<(int)ParticipanteFieldIndex.AmountOfFields;i++)
			{
				fieldsToFill[i] = EntityFieldFactory.Create((ParticipanteFieldIndex)i);
			}
		}
	

		/// <summary>Creates a complete EntityFields instance for the RamaEntity.</summary>
		/// <param name="fieldsToFill">the fields object to fill</param>
		private static void CreateRamaEntityFields(ref IEntityFields fieldsToFill)
		{
			for(int i=0;i<(int)RamaFieldIndex.AmountOfFields;i++)
			{
				fieldsToFill[i] = EntityFieldFactory.Create((RamaFieldIndex)i);
			}
		}
	

		/// <summary>Creates a complete EntityFields instance for the SeccionEntity.</summary>
		/// <param name="fieldsToFill">the fields object to fill</param>
		private static void CreateSeccionEntityFields(ref IEntityFields fieldsToFill)
		{
			for(int i=0;i<(int)SeccionFieldIndex.AmountOfFields;i++)
			{
				fieldsToFill[i] = EntityFieldFactory.Create((SeccionFieldIndex)i);
			}
		}
	

		/// <summary>Creates a complete EntityFields instance for the TematicaEntity.</summary>
		/// <param name="fieldsToFill">the fields object to fill</param>
		private static void CreateTematicaEntityFields(ref IEntityFields fieldsToFill)
		{
			for(int i=0;i<(int)TematicaFieldIndex.AmountOfFields;i++)
			{
				fieldsToFill[i] = EntityFieldFactory.Create((TematicaFieldIndex)i);
			}
		}
	

		/// <summary>Creates a complete EntityFields instance for the TipoParroquiaEntity.</summary>
		/// <param name="fieldsToFill">the fields object to fill</param>
		private static void CreateTipoParroquiaEntityFields(ref IEntityFields fieldsToFill)
		{
			for(int i=0;i<(int)TipoParroquiaFieldIndex.AmountOfFields;i++)
			{
				fieldsToFill[i] = EntityFieldFactory.Create((TipoParroquiaFieldIndex)i);
			}
		}
	

		/// <summary>Creates a complete EntityFields instance for the VwListasEntity.</summary>
		/// <param name="fieldsToFill">the fields object to fill</param>
		private static void CreateVwListasEntityFields(ref IEntityFields fieldsToFill)
		{
			for(int i=0;i<(int)VwListasFieldIndex.AmountOfFields;i++)
			{
				fieldsToFill[i] = EntityFieldFactory.Create((VwListasFieldIndex)i);
			}
		}
	

		/// <summary>Creates a complete EntityFields instance for the VwparroquiasEntity.</summary>
		/// <param name="fieldsToFill">the fields object to fill</param>
		private static void CreateVwparroquiasEntityFields(ref IEntityFields fieldsToFill)
		{
			for(int i=0;i<(int)VwparroquiasFieldIndex.AmountOfFields;i++)
			{
				fieldsToFill[i] = EntityFieldFactory.Create((VwparroquiasFieldIndex)i);
			}
		}
	

		/// <summary>Creates a complete EntityFields instance for the ZonaPastoralEntity.</summary>
		/// <param name="fieldsToFill">the fields object to fill</param>
		private static void CreateZonaPastoralEntityFields(ref IEntityFields fieldsToFill)
		{
			for(int i=0;i<(int)ZonaPastoralFieldIndex.AmountOfFields;i++)
			{
				fieldsToFill[i] = EntityFieldFactory.Create((ZonaPastoralFieldIndex)i);
			}
		}
	


		#region Included Code

		#endregion
	}
}