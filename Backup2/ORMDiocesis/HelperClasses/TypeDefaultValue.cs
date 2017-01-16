///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 2.0.0.0
// Code is generated on: martes, 29 de noviembre de 2016 05:10:37 p.m.
// Code is generated using templates: SD.TemplateBindings.SharedTemplates.NET20
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace ORMDiocesis.HelperClasses
{
	/// <summary>
	/// Class for the returning of a default value when a type is given. These
	/// Default values are used for EntityFields which have a NULL value in the database.
	/// In Business Logic it's impractical to work with NULL values. If you want different values
	/// as default values for NULL values for a given type, alter the DefaultValue method below.
	/// If you want to keep your values when regenerating the code, make this file read-only, or bind a different
	/// template to the template ID: SD_TypeDefaultValueIncludeTemplate, or alter the template file currently 
	/// bound to that template ID.
	/// </summary>
	public partial class TypeDefaultValue : ITypeDefaultValue
	{
		/// <summary>
		/// Ctor
		/// </summary>
		public TypeDefaultValue()
		{
		}


		/// <summary>
		/// Returns a default value for the type specified
		/// </summary>
		/// <param name="defaultValueType">The type which default value should be returned.</param>
		/// <returns>The default value for the type specified.</returns>
		public object DefaultValue(System.Type defaultValueType)
		{
			return TypeDefaultValue.GetDefaultValue(defaultValueType);
		}


		/// <summary>
		/// Returns a default value for the type specified
		/// </summary>
		/// <param name="defaultValueType">The type which default value should be returned.</param>
		/// <returns>The default value for the type specified.</returns>
		public static object GetDefaultValue(System.Type defaultValueType)
		{
			object valueToReturn=null;

			switch(defaultValueType.UnderlyingSystemType.FullName)
			{
				case "System.String":
					valueToReturn="";
					break;
				case "System.Byte":
					valueToReturn = (byte)0;
					break;
				case "System.Int32":
					valueToReturn = (int)0;
					break;
				case "System.Int16":
					valueToReturn = (short)0;
					break;
				case "System.Int64":
					valueToReturn = (long)0;
					break;
				case "System.DateTime":
					valueToReturn = DateTime.MinValue;
					break;
				case "System.Decimal":
					valueToReturn = 0.0M;
					break;
				case "System.Double":
					valueToReturn = 0.0;
					break;
				case "System.Single":
					valueToReturn = 0.0f;
					break;
				case "System.Boolean":
					valueToReturn = false;
					break;
				case "System.Byte[]":
					valueToReturn = new byte[0];
					break;
				case "System.Guid":
					valueToReturn = Guid.Empty;
					break;
				default:
					// do nothing, return null.
					break;
			}

			return valueToReturn;

		}
		
		#region Included Code

		#endregion
	}
}

