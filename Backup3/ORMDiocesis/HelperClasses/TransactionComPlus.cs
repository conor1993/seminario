///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 2.0.0.0
// Code is generated on: jueves, 01 de diciembre de 2016 05:21:22 p.m.
// Code is generated using templates: SD.TemplateBindings.SharedTemplates.NET20
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.Data;
using System.EnterpriseServices;

using ORMDiocesis.HelperClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace ORMDiocesis.HelperClasses
{
	/// <summary>
	/// Specific implementation of the TransactionComPlus class. The constructor will take care of the creation of the physical transaction and the
	/// opening of the connection. It will require a COM+ transaction.
	/// </summary>
	[MustRunInClientContext(true)]
	public partial class TransactionComPlus : TransactionComPlusBase
	{
		/// <summary>
		/// CTor
		/// </summary>
		public TransactionComPlus()
		{
		}



		/// <summary>
		/// Creates a new IDbConnection instance which will be used by all elements using this ITransaction instance. 
		/// Reads connectionstring from .config file. The COM+ transaction will flow to the used method.
		/// </summary>
		/// <returns>new IDbConnection instance</returns>
		protected override System.Data.IDbConnection CreateConnection()
		{
			DbUtilsComPlus dbUtilsToUse = new DbUtilsComPlus();
			return dbUtilsToUse.CreateConnection();
		}


		/// <summary>
		/// Creates a new IDbConnection instance which will be used by all elements using this ITransaction instance
		/// The COM+ transaction will flow to the used method.
		/// </summary>
		/// <param name="connectionString">Connection string to use</param>
		/// <returns>new IDbConnection instance</returns>
		protected override System.Data.IDbConnection CreateConnection(string connectionString)
		{
			DbUtilsComPlus dbUtilsToUse = new DbUtilsComPlus();
			return dbUtilsToUse.CreateConnection(connectionString);
		}


		/// <summary>
		/// Creates a new physical transaction object over the created connection. The connection is assumed to be open.
		/// This method is void in combination of a COM+ transaction. It will always return null.
		/// </summary>
		/// <returns>null</returns>
		protected override System.Data.IDbTransaction CreatePhysicalTransaction()
		{
			return null;
		}

		#region Included Code

		#endregion
	}
}
