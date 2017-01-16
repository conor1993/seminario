///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 2.0.0.0
// Code is generated on: jueves, 01 de diciembre de 2016 05:21:23 p.m.
// Code is generated using templates: SD.TemplateBindings.SharedTemplates.BackwardsCompatibility.NET20
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
#if !CF
using System.Runtime.Serialization;
#endif
using System.Collections;
using ORMDiocesis.FactoryClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace ORMDiocesis.HelperClasses
{
	/// <summary>
	/// Helper class which will eases the creation of custom made resultsets. Usable in typed lists
	/// and dynamic lists created using the dynamic query engine.
	/// </summary>
#if CF
	[SD.LLBLGen.Pro.ORMSupportClasses.Serializable]
#else
	[Serializable]
#endif
	public partial class ResultsetFields : EntityFields, ISerializable
	{
		/// <summary>CTor</summary>
		public ResultsetFields(int amountFields) : base(amountFields, InheritanceInfoProviderSingleton.GetInstance(), null)
		{
		}
		
		/// <summary>Deserialization constructor</summary>
		/// <param name="info">Info.</param>
		/// <param name="context">Context.</param>
		protected ResultsetFields(SerializationInfo info, StreamingContext context):base((int)info.GetInt32("_amountFields"), InheritanceInfoProviderSingleton.GetInstance(), null)
		{
			ArrayList fields = (ArrayList)info.GetValue("_fields", typeof(ArrayList));
			for (int i = 0; i < fields.Count; i++)
			{
				this[i] = (IEntityField)fields[i];
			}
		}

		/// <summary>Populates a <see cref="T:System.Runtime.Serialization.SerializationInfo"/> with the data needed to serialize the target object.</summary>
		/// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo"/> to populate with data.</param>
		/// <param name="context">The destination (see <see cref="T:System.Runtime.Serialization.StreamingContext"/>) for this serialization.</param>
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("_amountFields", this.Count);
			ArrayList fields = new ArrayList(this.Count);
			for (int i = 0; i < this.Count; i++)
			{
				fields.Add(this[i]);
			}
			info.AddValue("_fields", fields, typeof(ArrayList));
		}

		/// <summary>Creates the specified field on the position indexInResultset in the resultset.</summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		public void DefineField(AsistenciaFieldIndex fieldToDefine, int indexInResultset, string alias)
		{
			DefineField(fieldToDefine, indexInResultset, alias, string.Empty, AggregateFunction.None);
		}

		/// <summary>Creates the specified field on the position indexInResultset in the resultset.</summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		/// <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		public void DefineField(AsistenciaFieldIndex fieldToDefine, int indexInResultset, string alias, string entityAlias)
		{
			DefineField(fieldToDefine, indexInResultset, alias, entityAlias, AggregateFunction.None);
		}

		/// <summary>Creates the specified field on the position indexInResultset in the resultset.</summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		/// <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		/// <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		public void DefineField(AsistenciaFieldIndex fieldToDefine, int indexInResultset, string alias, string entityAlias, AggregateFunction aggregateFunctionToApply)
		{
			base.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, alias, entityAlias, aggregateFunctionToApply);
		}
		/// <summary>Creates the specified field on the position indexInResultset in the resultset.</summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		public void DefineField(AutorFieldIndex fieldToDefine, int indexInResultset, string alias)
		{
			DefineField(fieldToDefine, indexInResultset, alias, string.Empty, AggregateFunction.None);
		}

		/// <summary>Creates the specified field on the position indexInResultset in the resultset.</summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		/// <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		public void DefineField(AutorFieldIndex fieldToDefine, int indexInResultset, string alias, string entityAlias)
		{
			DefineField(fieldToDefine, indexInResultset, alias, entityAlias, AggregateFunction.None);
		}

		/// <summary>Creates the specified field on the position indexInResultset in the resultset.</summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		/// <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		/// <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		public void DefineField(AutorFieldIndex fieldToDefine, int indexInResultset, string alias, string entityAlias, AggregateFunction aggregateFunctionToApply)
		{
			base.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, alias, entityAlias, aggregateFunctionToApply);
		}
		/// <summary>Creates the specified field on the position indexInResultset in the resultset.</summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		public void DefineField(CargoFieldIndex fieldToDefine, int indexInResultset, string alias)
		{
			DefineField(fieldToDefine, indexInResultset, alias, string.Empty, AggregateFunction.None);
		}

		/// <summary>Creates the specified field on the position indexInResultset in the resultset.</summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		/// <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		public void DefineField(CargoFieldIndex fieldToDefine, int indexInResultset, string alias, string entityAlias)
		{
			DefineField(fieldToDefine, indexInResultset, alias, entityAlias, AggregateFunction.None);
		}

		/// <summary>Creates the specified field on the position indexInResultset in the resultset.</summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		/// <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		/// <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		public void DefineField(CargoFieldIndex fieldToDefine, int indexInResultset, string alias, string entityAlias, AggregateFunction aggregateFunctionToApply)
		{
			base.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, alias, entityAlias, aggregateFunctionToApply);
		}
		/// <summary>Creates the specified field on the position indexInResultset in the resultset.</summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		public void DefineField(CiudadFieldIndex fieldToDefine, int indexInResultset, string alias)
		{
			DefineField(fieldToDefine, indexInResultset, alias, string.Empty, AggregateFunction.None);
		}

		/// <summary>Creates the specified field on the position indexInResultset in the resultset.</summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		/// <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		public void DefineField(CiudadFieldIndex fieldToDefine, int indexInResultset, string alias, string entityAlias)
		{
			DefineField(fieldToDefine, indexInResultset, alias, entityAlias, AggregateFunction.None);
		}

		/// <summary>Creates the specified field on the position indexInResultset in the resultset.</summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		/// <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		/// <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		public void DefineField(CiudadFieldIndex fieldToDefine, int indexInResultset, string alias, string entityAlias, AggregateFunction aggregateFunctionToApply)
		{
			base.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, alias, entityAlias, aggregateFunctionToApply);
		}
		/// <summary>Creates the specified field on the position indexInResultset in the resultset.</summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		public void DefineField(CiudadesFieldIndex fieldToDefine, int indexInResultset, string alias)
		{
			DefineField(fieldToDefine, indexInResultset, alias, string.Empty, AggregateFunction.None);
		}

		/// <summary>Creates the specified field on the position indexInResultset in the resultset.</summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		/// <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		public void DefineField(CiudadesFieldIndex fieldToDefine, int indexInResultset, string alias, string entityAlias)
		{
			DefineField(fieldToDefine, indexInResultset, alias, entityAlias, AggregateFunction.None);
		}

		/// <summary>Creates the specified field on the position indexInResultset in the resultset.</summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		/// <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		/// <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		public void DefineField(CiudadesFieldIndex fieldToDefine, int indexInResultset, string alias, string entityAlias, AggregateFunction aggregateFunctionToApply)
		{
			base.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, alias, entityAlias, aggregateFunctionToApply);
		}
		/// <summary>Creates the specified field on the position indexInResultset in the resultset.</summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		public void DefineField(EditorialFieldIndex fieldToDefine, int indexInResultset, string alias)
		{
			DefineField(fieldToDefine, indexInResultset, alias, string.Empty, AggregateFunction.None);
		}

		/// <summary>Creates the specified field on the position indexInResultset in the resultset.</summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		/// <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		public void DefineField(EditorialFieldIndex fieldToDefine, int indexInResultset, string alias, string entityAlias)
		{
			DefineField(fieldToDefine, indexInResultset, alias, entityAlias, AggregateFunction.None);
		}

		/// <summary>Creates the specified field on the position indexInResultset in the resultset.</summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		/// <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		/// <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		public void DefineField(EditorialFieldIndex fieldToDefine, int indexInResultset, string alias, string entityAlias, AggregateFunction aggregateFunctionToApply)
		{
			base.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, alias, entityAlias, aggregateFunctionToApply);
		}
		/// <summary>Creates the specified field on the position indexInResultset in the resultset.</summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		public void DefineField(EquipoDeTrabajoFieldIndex fieldToDefine, int indexInResultset, string alias)
		{
			DefineField(fieldToDefine, indexInResultset, alias, string.Empty, AggregateFunction.None);
		}

		/// <summary>Creates the specified field on the position indexInResultset in the resultset.</summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		/// <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		public void DefineField(EquipoDeTrabajoFieldIndex fieldToDefine, int indexInResultset, string alias, string entityAlias)
		{
			DefineField(fieldToDefine, indexInResultset, alias, entityAlias, AggregateFunction.None);
		}

		/// <summary>Creates the specified field on the position indexInResultset in the resultset.</summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		/// <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		/// <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		public void DefineField(EquipoDeTrabajoFieldIndex fieldToDefine, int indexInResultset, string alias, string entityAlias, AggregateFunction aggregateFunctionToApply)
		{
			base.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, alias, entityAlias, aggregateFunctionToApply);
		}
		/// <summary>Creates the specified field on the position indexInResultset in the resultset.</summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		public void DefineField(EventoFieldIndex fieldToDefine, int indexInResultset, string alias)
		{
			DefineField(fieldToDefine, indexInResultset, alias, string.Empty, AggregateFunction.None);
		}

		/// <summary>Creates the specified field on the position indexInResultset in the resultset.</summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		/// <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		public void DefineField(EventoFieldIndex fieldToDefine, int indexInResultset, string alias, string entityAlias)
		{
			DefineField(fieldToDefine, indexInResultset, alias, entityAlias, AggregateFunction.None);
		}

		/// <summary>Creates the specified field on the position indexInResultset in the resultset.</summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		/// <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		/// <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		public void DefineField(EventoFieldIndex fieldToDefine, int indexInResultset, string alias, string entityAlias, AggregateFunction aggregateFunctionToApply)
		{
			base.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, alias, entityAlias, aggregateFunctionToApply);
		}
		/// <summary>Creates the specified field on the position indexInResultset in the resultset.</summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		public void DefineField(LectoresFieldIndex fieldToDefine, int indexInResultset, string alias)
		{
			DefineField(fieldToDefine, indexInResultset, alias, string.Empty, AggregateFunction.None);
		}

		/// <summary>Creates the specified field on the position indexInResultset in the resultset.</summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		/// <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		public void DefineField(LectoresFieldIndex fieldToDefine, int indexInResultset, string alias, string entityAlias)
		{
			DefineField(fieldToDefine, indexInResultset, alias, entityAlias, AggregateFunction.None);
		}

		/// <summary>Creates the specified field on the position indexInResultset in the resultset.</summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		/// <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		/// <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		public void DefineField(LectoresFieldIndex fieldToDefine, int indexInResultset, string alias, string entityAlias, AggregateFunction aggregateFunctionToApply)
		{
			base.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, alias, entityAlias, aggregateFunctionToApply);
		}
		/// <summary>Creates the specified field on the position indexInResultset in the resultset.</summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		public void DefineField(LibroFieldIndex fieldToDefine, int indexInResultset, string alias)
		{
			DefineField(fieldToDefine, indexInResultset, alias, string.Empty, AggregateFunction.None);
		}

		/// <summary>Creates the specified field on the position indexInResultset in the resultset.</summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		/// <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		public void DefineField(LibroFieldIndex fieldToDefine, int indexInResultset, string alias, string entityAlias)
		{
			DefineField(fieldToDefine, indexInResultset, alias, entityAlias, AggregateFunction.None);
		}

		/// <summary>Creates the specified field on the position indexInResultset in the resultset.</summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		/// <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		/// <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		public void DefineField(LibroFieldIndex fieldToDefine, int indexInResultset, string alias, string entityAlias, AggregateFunction aggregateFunctionToApply)
		{
			base.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, alias, entityAlias, aggregateFunctionToApply);
		}
		/// <summary>Creates the specified field on the position indexInResultset in the resultset.</summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		public void DefineField(LibroEstatusFieldIndex fieldToDefine, int indexInResultset, string alias)
		{
			DefineField(fieldToDefine, indexInResultset, alias, string.Empty, AggregateFunction.None);
		}

		/// <summary>Creates the specified field on the position indexInResultset in the resultset.</summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		/// <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		public void DefineField(LibroEstatusFieldIndex fieldToDefine, int indexInResultset, string alias, string entityAlias)
		{
			DefineField(fieldToDefine, indexInResultset, alias, entityAlias, AggregateFunction.None);
		}

		/// <summary>Creates the specified field on the position indexInResultset in the resultset.</summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		/// <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		/// <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		public void DefineField(LibroEstatusFieldIndex fieldToDefine, int indexInResultset, string alias, string entityAlias, AggregateFunction aggregateFunctionToApply)
		{
			base.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, alias, entityAlias, aggregateFunctionToApply);
		}
		/// <summary>Creates the specified field on the position indexInResultset in the resultset.</summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		public void DefineField(LibroFormatoFieldIndex fieldToDefine, int indexInResultset, string alias)
		{
			DefineField(fieldToDefine, indexInResultset, alias, string.Empty, AggregateFunction.None);
		}

		/// <summary>Creates the specified field on the position indexInResultset in the resultset.</summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		/// <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		public void DefineField(LibroFormatoFieldIndex fieldToDefine, int indexInResultset, string alias, string entityAlias)
		{
			DefineField(fieldToDefine, indexInResultset, alias, entityAlias, AggregateFunction.None);
		}

		/// <summary>Creates the specified field on the position indexInResultset in the resultset.</summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		/// <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		/// <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		public void DefineField(LibroFormatoFieldIndex fieldToDefine, int indexInResultset, string alias, string entityAlias, AggregateFunction aggregateFunctionToApply)
		{
			base.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, alias, entityAlias, aggregateFunctionToApply);
		}
		/// <summary>Creates the specified field on the position indexInResultset in the resultset.</summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		public void DefineField(PaisFieldIndex fieldToDefine, int indexInResultset, string alias)
		{
			DefineField(fieldToDefine, indexInResultset, alias, string.Empty, AggregateFunction.None);
		}

		/// <summary>Creates the specified field on the position indexInResultset in the resultset.</summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		/// <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		public void DefineField(PaisFieldIndex fieldToDefine, int indexInResultset, string alias, string entityAlias)
		{
			DefineField(fieldToDefine, indexInResultset, alias, entityAlias, AggregateFunction.None);
		}

		/// <summary>Creates the specified field on the position indexInResultset in the resultset.</summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		/// <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		/// <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		public void DefineField(PaisFieldIndex fieldToDefine, int indexInResultset, string alias, string entityAlias, AggregateFunction aggregateFunctionToApply)
		{
			base.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, alias, entityAlias, aggregateFunctionToApply);
		}
		/// <summary>Creates the specified field on the position indexInResultset in the resultset.</summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		public void DefineField(ParrocoFieldIndex fieldToDefine, int indexInResultset, string alias)
		{
			DefineField(fieldToDefine, indexInResultset, alias, string.Empty, AggregateFunction.None);
		}

		/// <summary>Creates the specified field on the position indexInResultset in the resultset.</summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		/// <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		public void DefineField(ParrocoFieldIndex fieldToDefine, int indexInResultset, string alias, string entityAlias)
		{
			DefineField(fieldToDefine, indexInResultset, alias, entityAlias, AggregateFunction.None);
		}

		/// <summary>Creates the specified field on the position indexInResultset in the resultset.</summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		/// <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		/// <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		public void DefineField(ParrocoFieldIndex fieldToDefine, int indexInResultset, string alias, string entityAlias, AggregateFunction aggregateFunctionToApply)
		{
			base.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, alias, entityAlias, aggregateFunctionToApply);
		}
		/// <summary>Creates the specified field on the position indexInResultset in the resultset.</summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		public void DefineField(ParroquiaFieldIndex fieldToDefine, int indexInResultset, string alias)
		{
			DefineField(fieldToDefine, indexInResultset, alias, string.Empty, AggregateFunction.None);
		}

		/// <summary>Creates the specified field on the position indexInResultset in the resultset.</summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		/// <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		public void DefineField(ParroquiaFieldIndex fieldToDefine, int indexInResultset, string alias, string entityAlias)
		{
			DefineField(fieldToDefine, indexInResultset, alias, entityAlias, AggregateFunction.None);
		}

		/// <summary>Creates the specified field on the position indexInResultset in the resultset.</summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		/// <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		/// <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		public void DefineField(ParroquiaFieldIndex fieldToDefine, int indexInResultset, string alias, string entityAlias, AggregateFunction aggregateFunctionToApply)
		{
			base.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, alias, entityAlias, aggregateFunctionToApply);
		}
		/// <summary>Creates the specified field on the position indexInResultset in the resultset.</summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		public void DefineField(ParticipanteFieldIndex fieldToDefine, int indexInResultset, string alias)
		{
			DefineField(fieldToDefine, indexInResultset, alias, string.Empty, AggregateFunction.None);
		}

		/// <summary>Creates the specified field on the position indexInResultset in the resultset.</summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		/// <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		public void DefineField(ParticipanteFieldIndex fieldToDefine, int indexInResultset, string alias, string entityAlias)
		{
			DefineField(fieldToDefine, indexInResultset, alias, entityAlias, AggregateFunction.None);
		}

		/// <summary>Creates the specified field on the position indexInResultset in the resultset.</summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		/// <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		/// <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		public void DefineField(ParticipanteFieldIndex fieldToDefine, int indexInResultset, string alias, string entityAlias, AggregateFunction aggregateFunctionToApply)
		{
			base.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, alias, entityAlias, aggregateFunctionToApply);
		}
		/// <summary>Creates the specified field on the position indexInResultset in the resultset.</summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		public void DefineField(RamaFieldIndex fieldToDefine, int indexInResultset, string alias)
		{
			DefineField(fieldToDefine, indexInResultset, alias, string.Empty, AggregateFunction.None);
		}

		/// <summary>Creates the specified field on the position indexInResultset in the resultset.</summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		/// <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		public void DefineField(RamaFieldIndex fieldToDefine, int indexInResultset, string alias, string entityAlias)
		{
			DefineField(fieldToDefine, indexInResultset, alias, entityAlias, AggregateFunction.None);
		}

		/// <summary>Creates the specified field on the position indexInResultset in the resultset.</summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		/// <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		/// <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		public void DefineField(RamaFieldIndex fieldToDefine, int indexInResultset, string alias, string entityAlias, AggregateFunction aggregateFunctionToApply)
		{
			base.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, alias, entityAlias, aggregateFunctionToApply);
		}
		/// <summary>Creates the specified field on the position indexInResultset in the resultset.</summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		public void DefineField(SeccionFieldIndex fieldToDefine, int indexInResultset, string alias)
		{
			DefineField(fieldToDefine, indexInResultset, alias, string.Empty, AggregateFunction.None);
		}

		/// <summary>Creates the specified field on the position indexInResultset in the resultset.</summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		/// <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		public void DefineField(SeccionFieldIndex fieldToDefine, int indexInResultset, string alias, string entityAlias)
		{
			DefineField(fieldToDefine, indexInResultset, alias, entityAlias, AggregateFunction.None);
		}

		/// <summary>Creates the specified field on the position indexInResultset in the resultset.</summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		/// <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		/// <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		public void DefineField(SeccionFieldIndex fieldToDefine, int indexInResultset, string alias, string entityAlias, AggregateFunction aggregateFunctionToApply)
		{
			base.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, alias, entityAlias, aggregateFunctionToApply);
		}
		/// <summary>Creates the specified field on the position indexInResultset in the resultset.</summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		public void DefineField(TematicaFieldIndex fieldToDefine, int indexInResultset, string alias)
		{
			DefineField(fieldToDefine, indexInResultset, alias, string.Empty, AggregateFunction.None);
		}

		/// <summary>Creates the specified field on the position indexInResultset in the resultset.</summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		/// <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		public void DefineField(TematicaFieldIndex fieldToDefine, int indexInResultset, string alias, string entityAlias)
		{
			DefineField(fieldToDefine, indexInResultset, alias, entityAlias, AggregateFunction.None);
		}

		/// <summary>Creates the specified field on the position indexInResultset in the resultset.</summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		/// <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		/// <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		public void DefineField(TematicaFieldIndex fieldToDefine, int indexInResultset, string alias, string entityAlias, AggregateFunction aggregateFunctionToApply)
		{
			base.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, alias, entityAlias, aggregateFunctionToApply);
		}
		/// <summary>Creates the specified field on the position indexInResultset in the resultset.</summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		public void DefineField(TipoParroquiaFieldIndex fieldToDefine, int indexInResultset, string alias)
		{
			DefineField(fieldToDefine, indexInResultset, alias, string.Empty, AggregateFunction.None);
		}

		/// <summary>Creates the specified field on the position indexInResultset in the resultset.</summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		/// <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		public void DefineField(TipoParroquiaFieldIndex fieldToDefine, int indexInResultset, string alias, string entityAlias)
		{
			DefineField(fieldToDefine, indexInResultset, alias, entityAlias, AggregateFunction.None);
		}

		/// <summary>Creates the specified field on the position indexInResultset in the resultset.</summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		/// <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		/// <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		public void DefineField(TipoParroquiaFieldIndex fieldToDefine, int indexInResultset, string alias, string entityAlias, AggregateFunction aggregateFunctionToApply)
		{
			base.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, alias, entityAlias, aggregateFunctionToApply);
		}
		/// <summary>Creates the specified field on the position indexInResultset in the resultset.</summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		public void DefineField(VwListasFieldIndex fieldToDefine, int indexInResultset, string alias)
		{
			DefineField(fieldToDefine, indexInResultset, alias, string.Empty, AggregateFunction.None);
		}

		/// <summary>Creates the specified field on the position indexInResultset in the resultset.</summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		/// <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		public void DefineField(VwListasFieldIndex fieldToDefine, int indexInResultset, string alias, string entityAlias)
		{
			DefineField(fieldToDefine, indexInResultset, alias, entityAlias, AggregateFunction.None);
		}

		/// <summary>Creates the specified field on the position indexInResultset in the resultset.</summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		/// <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		/// <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		public void DefineField(VwListasFieldIndex fieldToDefine, int indexInResultset, string alias, string entityAlias, AggregateFunction aggregateFunctionToApply)
		{
			base.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, alias, entityAlias, aggregateFunctionToApply);
		}
		/// <summary>Creates the specified field on the position indexInResultset in the resultset.</summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		public void DefineField(VwparroquiasFieldIndex fieldToDefine, int indexInResultset, string alias)
		{
			DefineField(fieldToDefine, indexInResultset, alias, string.Empty, AggregateFunction.None);
		}

		/// <summary>Creates the specified field on the position indexInResultset in the resultset.</summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		/// <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		public void DefineField(VwparroquiasFieldIndex fieldToDefine, int indexInResultset, string alias, string entityAlias)
		{
			DefineField(fieldToDefine, indexInResultset, alias, entityAlias, AggregateFunction.None);
		}

		/// <summary>Creates the specified field on the position indexInResultset in the resultset.</summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		/// <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		/// <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		public void DefineField(VwparroquiasFieldIndex fieldToDefine, int indexInResultset, string alias, string entityAlias, AggregateFunction aggregateFunctionToApply)
		{
			base.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, alias, entityAlias, aggregateFunctionToApply);
		}
		/// <summary>Creates the specified field on the position indexInResultset in the resultset.</summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		public void DefineField(ZonaPastoralFieldIndex fieldToDefine, int indexInResultset, string alias)
		{
			DefineField(fieldToDefine, indexInResultset, alias, string.Empty, AggregateFunction.None);
		}

		/// <summary>Creates the specified field on the position indexInResultset in the resultset.</summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		/// <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		public void DefineField(ZonaPastoralFieldIndex fieldToDefine, int indexInResultset, string alias, string entityAlias)
		{
			DefineField(fieldToDefine, indexInResultset, alias, entityAlias, AggregateFunction.None);
		}

		/// <summary>Creates the specified field on the position indexInResultset in the resultset.</summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		/// <param name="entityAlias">The alias to use for the entity this field belongs to. Required to specify multiple times the same entity in a typed list</param>
		/// <param name="aggregateFunctionToApply">the aggregate function to apply to this field.</param>
		public void DefineField(ZonaPastoralFieldIndex fieldToDefine, int indexInResultset, string alias, string entityAlias, AggregateFunction aggregateFunctionToApply)
		{
			base.DefineField(EntityFieldFactory.Create(fieldToDefine), indexInResultset, alias, entityAlias, aggregateFunctionToApply);
		}


		#region Included Code

		#endregion
	}
}
