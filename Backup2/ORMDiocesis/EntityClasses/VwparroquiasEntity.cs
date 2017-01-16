///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 2.0.0.0
// Code is generated using templates: SD.TemplateBindings.SharedTemplates.NET20
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.ComponentModel;
using System.Collections.Generic;
#if !CF
using System.Runtime.Serialization;
#endif
using System.Data;
using System.Xml.Serialization;
using ORMDiocesis;
using ORMDiocesis.FactoryClasses;
using ORMDiocesis.DaoClasses;
using ORMDiocesis.RelationClasses;
using ORMDiocesis.HelperClasses;
using ORMDiocesis.CollectionClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace ORMDiocesis.EntityClasses
{
	
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	

	/// <summary>
	/// Entity class which represents the entity 'Vwparroquias'. <br/><br/>
	/// 
	/// </summary>
#if CF
	[SD.LLBLGen.Pro.ORMSupportClasses.Serializable]
#else
	[Serializable]
#endif
	public partial class VwparroquiasEntity : EntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END
			
	{
		#region Class Member Declarations





		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;
		
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static VwparroquiasEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public VwparroquiasEntity()
		{
			InitClassEmpty(CreateValidator());
		}



		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected VwparroquiasEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{




			base.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
			
		}

		
		/// <summary> Will perform post-ReadXml actions</summary>
		protected override void PostReadXmlFixups()
		{




		}


		/// <summary> Saves the Entity class to the persistent storage. It updates or inserts the entity, which depends if the entity was originally read from the 
		/// database. If the entity is new, an insert is done and the updateRestriction is ignored. If the entity is not new, the updateRestriction
		/// predicate is used to create an additional where clause (it will be added with AND) for the update query. This predicate can be used for
		/// concurrency checks, like checks on timestamp column values.</summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query. Will be ignored when the entity is new </param>
		/// <param name="recurse">When true, it will save all dirty objects referenced (directly or indirectly) by this entity also.</param>
		/// <returns>true if Save succeeded, false otherwise</returns>
		/// <exception cref="ORMQueryExecutionException">When an exception is caught during the save process. The caught exception is set as the
		/// inner exception. Encapsulation of database-related exceptions is necessary since these exceptions do not have a common exception framework implemented.</exception>
		public override bool Save(IPredicate updateRestriction, bool recurse)
		{
			bool transactionStartedInThisScope = false;
			Transaction transactionManager = null;

			if(recurse || ((this.LLBLGenProIsInHierarchyOfType==InheritanceHierarchyType.TargetPerEntity) && this.LLBLGenProIsSubType))
			{
				if(!base.ParticipatesInTransaction)
				{
					transactionManager = new Transaction(IsolationLevel.ReadCommitted, "SaveRecursively");
					transactionManager.Add(this);
					transactionStartedInThisScope=true;
				}
			}
			try
			{
				bool result = base.Save(updateRestriction, recurse);
				if(transactionStartedInThisScope)
				{
					transactionManager.Commit();
				}
				return result;
			}
			catch
			{
				if(transactionStartedInThisScope)
				{
					transactionManager.Rollback();
				}
				throw;
			}
			finally
			{
				if(transactionStartedInThisScope)
				{
					transactionManager.Dispose();
				}
			}
		}
		


		/// <summary> ISerializable member. Does custom serialization so event handlers do not get serialized.
		/// Serializes members of this entity class and uses the base class' implementation to serialize the rest.</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{




			
			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			base.GetObjectData(info, context);
		}
		
		/// <summary> Sets the related entity property to the entity specified. If the property is a collection, it will add the entity specified to that collection.</summary>
		/// <param name="propertyName">Name of the property.</param>
		/// <param name="entity">Entity to set as an related entity</param>
		/// <remarks>Used by prefetch path logic.</remarks>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override void SetRelatedEntityProperty(string propertyName, IEntity entity)
		{
			switch(propertyName)
			{




				default:

					break;
			}
		}

		/// <summary> Sets the internal parameter related to the fieldname passed to the instance relatedEntity. </summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		/// <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override void SetRelatedEntity(IEntity relatedEntity, string fieldName)
		{
			switch(fieldName)
			{



				default:

					break;
			}
		}
		
		/// <summary> Unsets the internal parameter related to the fieldname passed to the instance relatedEntity. Reverses the actions taken by SetRelatedEntity() </summary>
		/// <param name="relatedEntity">Instance to unset as the related entity of type entityType</param>
		/// <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		/// <param name="signalRelatedEntityManyToOne">if set to true it will notify the manytoone side, if applicable.</param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override void UnsetRelatedEntity(IEntity relatedEntity, string fieldName, bool signalRelatedEntityManyToOne)
		{
			switch(fieldName)
			{



				default:

					break;
			}
		}

		/// <summary> Gets a collection of related entities referenced by this entity which depend on this entity (this entity is the PK side of their FK fields). These
		/// entities will have to be persisted after this entity during a recursive save.</summary>
		/// <returns>Collection with 0 or more IEntity objects, referenced by this entity</returns>
		public override List<IEntity> GetDependingRelatedEntities()
		{
			List<IEntity> toReturn = new List<IEntity>();


			return toReturn;
		}
		
		/// <summary> Gets a collection of related entities referenced by this entity which this entity depends on (this entity is the FK side of their PK fields). These
		/// entities will have to be persisted before this entity during a recursive save.</summary>
		/// <returns>Collection with 0 or more IEntity objects, referenced by this entity</returns>
		public override List<IEntity> GetDependentRelatedEntities()
		{
			List<IEntity> toReturn = new List<IEntity>();



			return toReturn;
		}
		
		/// <summary> Gets a List of all entity collections stored as member variables in this entity. The contents of the ArrayList is
		/// used by the DataAccessAdapter to perform recursive saves. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		public override List<IEntityCollection> GetMemberEntityCollections()
		{
			List<IEntityCollection> toReturn = new List<IEntityCollection>();


			return toReturn;
		}

		

		


		/// <summary> Returns true if the original value for the field with the fieldIndex passed in, read from the persistent storage was NULL, false otherwise.
		/// Should not be used for testing if the current value is NULL, use <see cref="TestCurrentFieldValueForNull"/> for that.</summary>
		/// <param name="fieldIndex">Index of the field to test if that field was NULL in the persistent storage</param>
		/// <returns>true if the field with the passed in index was NULL in the persistent storage, false otherwise</returns>
		public bool TestOriginalFieldValueForNull(VwparroquiasFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}
		
		/// <summary>Returns true if the current value for the field with the fieldIndex passed in represents null/not defined, false otherwise.
		/// Should not be used for testing if the original value (read from the db) is NULL</summary>
		/// <param name="fieldIndex">Index of the field to test if its currentvalue is null/undefined</param>
		/// <returns>true if the field's value isn't defined yet, false otherwise</returns>
		public bool TestCurrentFieldValueForNull(VwparroquiasFieldIndex fieldIndex)
		{
			return base.CheckIfCurrentFieldValueIsNull((int)fieldIndex);
		}







		
		/// <summary> Sets the field on index fieldIndex to the new value value. Marks also the fields object as dirty. </summary>
		/// <param name="fieldIndex">Index of field to set the new value of</param>
		/// <param name="value">Value to set</param>
		/// <param name="checkForRefetch">If set to true, it will check if this entity is out of sync and will refetch it first if it is. Use true in normal behavior, false for framework specific code.</param>
		/// <returns>true if the value is actually set, false otherwise.</returns>
		/// <remarks>Dereferences a related object in an 1:1/m:1 relation if the field is an FK field and responsible for the reference of that particular related object.</remarks>
		/// <exception cref="ArgumentOutOfRangeException">When fieldIndex is smaller than 0 or bigger than the number of fields in the fields collection.</exception>
		protected override bool SetNewFieldValue(int fieldIndex, object value, bool checkForRefetch)
		{
			bool toReturn = base.SetNewFieldValue (fieldIndex, value, checkForRefetch, false);
			if(toReturn && Enum.IsDefined(typeof(VwparroquiasFieldIndex), fieldIndex))
			{
				switch((VwparroquiasFieldIndex)fieldIndex)
				{
					default:
						break;
				}
				base.PostFieldValueSetAction(toReturn, this.Fields[fieldIndex].Name);
			}
			return toReturn;
		}

		/// <summary> Performs the insert action of a new Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool InsertEntity()
		{
			VwparroquiasDAO dao = (VwparroquiasDAO)CreateDAOInstance();
			return dao.AddNew(base.Fields, base.Transaction);
		}
		
		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{





		}


	
		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validatorToUse">Validator to use.</param>
		protected virtual void InitClassEmpty(IValidator validatorToUse)
		{
			OnInitializing();
			base.Fields = CreateFields();
			base.IsNew=true;
			base.Validator = validatorToUse;

			InitClassMembers();
			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassEmpty
			// __LLBLGENPRO_USER_CODE_REGION_END
			

			OnInitialized();
		}
		
		/// <summary>Creates entity fields object for this entity. Used in constructor to setup this entity in a polymorphic scenario.</summary>
		protected virtual IEntityFields CreateFields()
		{
			return EntityFieldsFactory.CreateEntityFieldsObject(ORMDiocesis.EntityType.VwparroquiasEntity);
		}



		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{




			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			// __LLBLGENPRO_USER_CODE_REGION_END
			
		}

		#region Custom Property Hashtable Setup
		/// <summary> Initializes the hashtables for the entity type and entity field custom properties. </summary>
		private static void SetupCustomPropertyHashtables()
		{
			_customProperties = new Dictionary<string, string>();
			_fieldsCustomProperties = new Dictionary<string, Dictionary<string, string>>();

			Dictionary<string, string> fieldHashtable = null;
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Parroquia", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Telefono", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("OtroTelefono", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("TelefonoCural", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Fax", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("CorreoElectrónico", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Calle", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Numero", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Colonia", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("CodigoPostal", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("ApartadoPostal", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Ciudad", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Zona", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Tipo", fieldHashtable);
		}
		#endregion




		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. 
		/// Because this entity doesn't have a primary key defined, this routine does nothing. </summary>
		/// <returns>true</returns>
		public override bool Refetch()
		{
			return true;
		}
		
		/// <summary> Deletes the Entity from the persistent storage. This method succeeds also when the Entity is not present.</summary>
		/// <param name="deleteRestriction">Predicate expression, meant for concurrency checks in a delete query. Overrules the predicate returned by a set ConcurrencyPredicateFactory object.</param>
		/// <returns>true if Delete succeeded, false otherwise</returns>
		public override bool Delete(IPredicate deleteRestriction)
		{
			return true;
		}
		
		/// <summary> Performs the update action of an existing Entity to the persistent storage. Because this entity doesn't have a primary key defined, this routine does nothing. </summary>
		/// <returns>true</returns>
		protected override bool UpdateEntity()
		{
			return true;
		}
		
		/// <summary> Performs the update action of an existing Entity to the persistent storage. Because this entity doesn't have a primary key defined, this routine does nothing. </summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			return true;
		}

		/// <summary> Creates the DAO instance for this type</summary>
		/// <returns></returns>
		protected override IDao CreateDAOInstance()
		{
			return DAOFactory.CreateVwparroquiasDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new VwparroquiasEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static VwparroquiasRelations Relations
		{
			get	{ return new VwparroquiasRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}






		/// <summary>Returns the full name for this entity, which is important for the DAO to find back persistence info for this entity.</summary>
		[Browsable(false), XmlIgnore]
		public override string LLBLGenProEntityName
		{
			get { return "VwparroquiasEntity";}
		}

		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public virtual Dictionary<string, string> CustomPropertiesOfType
		{
			get { return VwparroquiasEntity.CustomProperties;}
		}

		/// <summary> The custom properties for the fields of this entity type. The returned Hashtable contains per fieldname a hashtable of name-value pairs. </summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, Dictionary<string, string>> FieldsCustomProperties
		{
			get { return _fieldsCustomProperties;}
		}

		/// <summary> The custom properties for the fields of the type of this entity instance. The returned Hashtable contains per fieldname a hashtable of name-value pairs. </summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public virtual Dictionary<string, Dictionary<string, string>> FieldsCustomPropertiesOfType
		{
			get { return VwparroquiasEntity.FieldsCustomProperties;}
		}

		/// <summary> The Parroquia property of the Entity Vwparroquias<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  view field: "Vwparroquias"."Parroquia"<br/>
		/// View field type characteristics (type, precision, scale, length): VarChar, 0, 0, 255<br/>
		/// View field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Parroquia
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)VwparroquiasFieldIndex.Parroquia);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
				return (System.String)valueToReturn;
			}
			set	{ SetNewFieldValue((int)VwparroquiasFieldIndex.Parroquia, value); }
		}
		/// <summary> The Telefono property of the Entity Vwparroquias<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  view field: "Vwparroquias"."Telefono"<br/>
		/// View field type characteristics (type, precision, scale, length): VarChar, 0, 0, 255<br/>
		/// View field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Telefono
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)VwparroquiasFieldIndex.Telefono);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
				return (System.String)valueToReturn;
			}
			set	{ SetNewFieldValue((int)VwparroquiasFieldIndex.Telefono, value); }
		}
		/// <summary> The OtroTelefono property of the Entity Vwparroquias<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  view field: "Vwparroquias"."Otro Telefono"<br/>
		/// View field type characteristics (type, precision, scale, length): VarChar, 0, 0, 255<br/>
		/// View field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String OtroTelefono
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)VwparroquiasFieldIndex.OtroTelefono);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
				return (System.String)valueToReturn;
			}
			set	{ SetNewFieldValue((int)VwparroquiasFieldIndex.OtroTelefono, value); }
		}
		/// <summary> The TelefonoCural property of the Entity Vwparroquias<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  view field: "Vwparroquias"."Telefono cural"<br/>
		/// View field type characteristics (type, precision, scale, length): VarChar, 0, 0, 255<br/>
		/// View field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String TelefonoCural
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)VwparroquiasFieldIndex.TelefonoCural);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
				return (System.String)valueToReturn;
			}
			set	{ SetNewFieldValue((int)VwparroquiasFieldIndex.TelefonoCural, value); }
		}
		/// <summary> The Fax property of the Entity Vwparroquias<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  view field: "Vwparroquias"."Fax"<br/>
		/// View field type characteristics (type, precision, scale, length): VarChar, 0, 0, 255<br/>
		/// View field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Fax
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)VwparroquiasFieldIndex.Fax);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
				return (System.String)valueToReturn;
			}
			set	{ SetNewFieldValue((int)VwparroquiasFieldIndex.Fax, value); }
		}
		/// <summary> The CorreoElectrónico property of the Entity Vwparroquias<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  view field: "Vwparroquias"."Correo electrónico"<br/>
		/// View field type characteristics (type, precision, scale, length): VarChar, 0, 0, 255<br/>
		/// View field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String CorreoElectrónico
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)VwparroquiasFieldIndex.CorreoElectrónico);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
				return (System.String)valueToReturn;
			}
			set	{ SetNewFieldValue((int)VwparroquiasFieldIndex.CorreoElectrónico, value); }
		}
		/// <summary> The Calle property of the Entity Vwparroquias<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  view field: "Vwparroquias"."Calle"<br/>
		/// View field type characteristics (type, precision, scale, length): VarChar, 0, 0, 255<br/>
		/// View field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Calle
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)VwparroquiasFieldIndex.Calle);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
				return (System.String)valueToReturn;
			}
			set	{ SetNewFieldValue((int)VwparroquiasFieldIndex.Calle, value); }
		}
		/// <summary> The Numero property of the Entity Vwparroquias<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  view field: "Vwparroquias"."Numero"<br/>
		/// View field type characteristics (type, precision, scale, length): VarChar, 0, 0, 255<br/>
		/// View field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Numero
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)VwparroquiasFieldIndex.Numero);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
				return (System.String)valueToReturn;
			}
			set	{ SetNewFieldValue((int)VwparroquiasFieldIndex.Numero, value); }
		}
		/// <summary> The Colonia property of the Entity Vwparroquias<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  view field: "Vwparroquias"."Colonia"<br/>
		/// View field type characteristics (type, precision, scale, length): VarChar, 0, 0, 255<br/>
		/// View field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Colonia
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)VwparroquiasFieldIndex.Colonia);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
				return (System.String)valueToReturn;
			}
			set	{ SetNewFieldValue((int)VwparroquiasFieldIndex.Colonia, value); }
		}
		/// <summary> The CodigoPostal property of the Entity Vwparroquias<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  view field: "Vwparroquias"."Codigo Postal"<br/>
		/// View field type characteristics (type, precision, scale, length): VarChar, 0, 0, 255<br/>
		/// View field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String CodigoPostal
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)VwparroquiasFieldIndex.CodigoPostal);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
				return (System.String)valueToReturn;
			}
			set	{ SetNewFieldValue((int)VwparroquiasFieldIndex.CodigoPostal, value); }
		}
		/// <summary> The ApartadoPostal property of the Entity Vwparroquias<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  view field: "Vwparroquias"."Apartado Postal"<br/>
		/// View field type characteristics (type, precision, scale, length): VarChar, 0, 0, 255<br/>
		/// View field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String ApartadoPostal
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)VwparroquiasFieldIndex.ApartadoPostal);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
				return (System.String)valueToReturn;
			}
			set	{ SetNewFieldValue((int)VwparroquiasFieldIndex.ApartadoPostal, value); }
		}
		/// <summary> The Ciudad property of the Entity Vwparroquias<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  view field: "Vwparroquias"."Ciudad"<br/>
		/// View field type characteristics (type, precision, scale, length): VarChar, 0, 0, 100<br/>
		/// View field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Ciudad
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)VwparroquiasFieldIndex.Ciudad);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
				return (System.String)valueToReturn;
			}
			set	{ SetNewFieldValue((int)VwparroquiasFieldIndex.Ciudad, value); }
		}
		/// <summary> The Zona property of the Entity Vwparroquias<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  view field: "Vwparroquias"."Zona"<br/>
		/// View field type characteristics (type, precision, scale, length): VarChar, 0, 0, 100<br/>
		/// View field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Zona
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)VwparroquiasFieldIndex.Zona);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
				return (System.String)valueToReturn;
			}
			set	{ SetNewFieldValue((int)VwparroquiasFieldIndex.Zona, value); }
		}
		/// <summary> The Tipo property of the Entity Vwparroquias<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  view field: "Vwparroquias"."Tipo"<br/>
		/// View field type characteristics (type, precision, scale, length): VarChar, 0, 0, 50<br/>
		/// View field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Tipo
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)VwparroquiasFieldIndex.Tipo);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
				return (System.String)valueToReturn;
			}
			set	{ SetNewFieldValue((int)VwparroquiasFieldIndex.Tipo, value); }
		}






		/// <summary> Gets or sets a value indicating whether this entity is a subtype</summary>
		protected override bool LLBLGenProIsSubType
		{
			get { return false;}
		}

		/// <summary> Gets the type of the hierarchy this entity is in. </summary>
		[System.ComponentModel.Browsable(false), XmlIgnore]
		protected override InheritanceHierarchyType LLBLGenProIsInHierarchyOfType
		{
			get { return InheritanceHierarchyType.None;}
		}
		
		/// <summary>Returns the EntityType enum value for this entity.</summary>
		[Browsable(false), XmlIgnore]
		public override int LLBLGenProEntityTypeValue 
		{ 
			get { return (int)ORMDiocesis.EntityType.VwparroquiasEntity; }
		}
		#endregion


		#region Custom Entity code
		
		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END
		
		#endregion

		#region Included code

		#endregion
	}
}
