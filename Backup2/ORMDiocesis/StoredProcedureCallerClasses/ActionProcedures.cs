///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 2.0.0.0
// Code is generated on: martes, 29 de noviembre de 2016 05:10:45 p.m.
// Code is generated using templates: SD.TemplateBindings.SqlServerSpecific.NET20
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.Data;
using System.Data.SqlClient;

using ORMDiocesis.HelperClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace ORMDiocesis.StoredProcedureCallerClasses
{
	/// <summary>
	/// Class which contains the static logic to execute action stored procedures in the database.
	/// </summary>
	public partial class ActionProcedures
	{
		/// <summary>
		/// private CTor so no instance can be created.
		/// </summary>
		private ActionProcedures()
		{
		}

	
		/// <summary>
		/// Delegate definition for stored procedure 'UPIM_SemAsistencia' to be used in combination of a UnitOfWork object.
		/// </summary>
		public delegate int UpimSemAsistenciaCallBack(System.String apellidoPaterno, System.String apellidoMaterno, System.String nombre, System.DateTime fechaNacim, System.Int16 aceptado, System.String idEvento, System.String domicilio, System.Byte idCiudad, System.String telefono, System.String celular, System.String redesSociales,  
System.String eMail, System.String gradoEscolar, System.Int32 codParroqia, System.Int32 codSacerdote, System.Int32 idEquipo, System.Int32 seccion, System.String observaciones, System.Byte[] foto, ref System.Int32 codParticipante, ref System.Int32 error,  ITransaction transactionToUse);

		/// <summary>
		/// Calls stored procedure 'UPIM_SemAsistencia'.<br/><br/>
		/// 
		/// </summary>
		/// <param name="codParticipante">InputOutput parameter of stored procedure</param>
		/// <param name="apellidoPaterno">Input parameter of stored procedure</param>
		/// <param name="apellidoMaterno">Input parameter of stored procedure</param>
		/// <param name="nombre">Input parameter of stored procedure</param>
		/// <param name="fechaNacim">Input parameter of stored procedure</param>
		/// <param name="aceptado">Input parameter of stored procedure</param>
		/// <param name="idEvento">Input parameter of stored procedure</param>
		/// <param name="domicilio">Input parameter of stored procedure</param>
		/// <param name="idCiudad">Input parameter of stored procedure</param>
		/// <param name="telefono">Input parameter of stored procedure</param>
		/// <param name="celular">Input parameter of stored procedure</param>
		/// <param name="redesSociales">Input parameter of stored procedure</param>
		/// <param name="eMail">Input parameter of stored procedure</param>
		/// <param name="gradoEscolar">Input parameter of stored procedure</param>
		/// <param name="codParroqia">Input parameter of stored procedure</param>
		/// <param name="codSacerdote">Input parameter of stored procedure</param>
		/// <param name="idEquipo">Input parameter of stored procedure</param>
		/// <param name="seccion">Input parameter of stored procedure</param>
		/// <param name="observaciones">Input parameter of stored procedure</param>
		/// <param name="foto">Input parameter of stored procedure</param>
		/// <param name="error">InputOutput parameter of stored procedure</param>
		/// <returns>Amount of rows affected, if the database / routine doesn't surpress rowcounting.</returns>
		public static int UpimSemAsistencia(System.String apellidoPaterno, System.String apellidoMaterno, System.String nombre, System.DateTime fechaNacim, System.Int16 aceptado, System.String idEvento, System.String domicilio, System.Byte idCiudad, System.String telefono, System.String celular, System.String redesSociales,  
System.String eMail, System.String gradoEscolar, System.Int32 codParroqia, System.Int32 codSacerdote, System.Int32 idEquipo, System.Int32 seccion, System.String observaciones, System.Byte[] foto, ref System.Int32 codParticipante, ref System.Int32 error)
		{
			// create parameters
			SqlParameter[] parameters = new SqlParameter[21];
			parameters[1] = new SqlParameter("@ApellidoPaterno", SqlDbType.VarChar, 50, ParameterDirection.Input, true, 0, 0, "",  DataRowVersion.Current, apellidoPaterno);
			parameters[2] = new SqlParameter("@ApellidoMaterno", SqlDbType.VarChar, 50, ParameterDirection.Input, true, 0, 0, "",  DataRowVersion.Current, apellidoMaterno);
			parameters[3] = new SqlParameter("@Nombre", SqlDbType.VarChar, 50, ParameterDirection.Input, true, 0, 0, "",  DataRowVersion.Current, nombre);
			parameters[4] = new SqlParameter("@FechaNacim", SqlDbType.DateTime, 0, ParameterDirection.Input, true, 0, 0, "",  DataRowVersion.Current, fechaNacim);
			parameters[5] = new SqlParameter("@Aceptado", SqlDbType.SmallInt, 0, ParameterDirection.Input, true, 5, 0, "",  DataRowVersion.Current, aceptado);
			parameters[6] = new SqlParameter("@IdEvento", SqlDbType.VarChar, 50, ParameterDirection.Input, true, 0, 0, "",  DataRowVersion.Current, idEvento);
			parameters[7] = new SqlParameter("@Domicilio", SqlDbType.VarChar, 100, ParameterDirection.Input, true, 0, 0, "",  DataRowVersion.Current, domicilio);
			parameters[8] = new SqlParameter("@IdCiudad", SqlDbType.TinyInt, 0, ParameterDirection.Input, true, 3, 0, "",  DataRowVersion.Current, idCiudad);
			parameters[9] = new SqlParameter("@Telefono", SqlDbType.NChar, 20, ParameterDirection.Input, true, 0, 0, "",  DataRowVersion.Current, telefono);
			parameters[10] = new SqlParameter("@Celular", SqlDbType.NChar, 20, ParameterDirection.Input, true, 0, 0, "",  DataRowVersion.Current, celular);
			parameters[11] = new SqlParameter("@RedesSociales", SqlDbType.VarChar, 100, ParameterDirection.Input, true, 0, 0, "",  DataRowVersion.Current, redesSociales);
			parameters[12] = new SqlParameter("@eMail", SqlDbType.VarChar, 30, ParameterDirection.Input, true, 0, 0, "",  DataRowVersion.Current, eMail);
			parameters[13] = new SqlParameter("@GradoEscolar", SqlDbType.VarChar, 30, ParameterDirection.Input, true, 0, 0, "",  DataRowVersion.Current, gradoEscolar);
			parameters[14] = new SqlParameter("@CodParroqia", SqlDbType.Int, 0, ParameterDirection.Input, true, 10, 0, "",  DataRowVersion.Current, codParroqia);
			parameters[15] = new SqlParameter("@CodSacerdote", SqlDbType.Int, 0, ParameterDirection.Input, true, 10, 0, "",  DataRowVersion.Current, codSacerdote);
			parameters[16] = new SqlParameter("@IdEquipo", SqlDbType.Int, 0, ParameterDirection.Input, true, 10, 0, "",  DataRowVersion.Current, idEquipo);
			parameters[17] = new SqlParameter("@Seccion", SqlDbType.Int, 0, ParameterDirection.Input, true, 10, 0, "",  DataRowVersion.Current, seccion);
			parameters[18] = new SqlParameter("@Observaciones", SqlDbType.Text, 2147483647, ParameterDirection.Input, true, 0, 0, "",  DataRowVersion.Current, observaciones);
			parameters[19] = new SqlParameter("@Foto", SqlDbType.Image, 2147483647, ParameterDirection.Input, true, 0, 0, "",  DataRowVersion.Current, foto);
			parameters[0] = new SqlParameter("@CodParticipante", SqlDbType.Int, 0, ParameterDirection.InputOutput, true, 10, 0, "",  DataRowVersion.Current, codParticipante);
			parameters[20] = new SqlParameter("@Error", SqlDbType.Int, 0, ParameterDirection.InputOutput, true, 10, 0, "",  DataRowVersion.Current, error);
			// Call the stored proc.
			int toReturn = DbUtils.CallActionStoredProcedure("[dbo].[UPIM_SemAsistencia]", parameters, null);
			if(parameters[0].Value!=System.DBNull.Value)
			{
				codParticipante = (System.Int32)parameters[0].Value;
			}
			if(parameters[20].Value!=System.DBNull.Value)
			{
				error = (System.Int32)parameters[20].Value;
			}
			return toReturn;
		}
		
		
		/// <summary>
		/// Calls stored procedure 'UPIM_SemAsistencia'.<br/><br/>
		/// 
		/// </summary>
		/// <param name="codParticipante">InputOutput parameter of stored procedure</param>
		/// <param name="apellidoPaterno">Input parameter of stored procedure</param>
		/// <param name="apellidoMaterno">Input parameter of stored procedure</param>
		/// <param name="nombre">Input parameter of stored procedure</param>
		/// <param name="fechaNacim">Input parameter of stored procedure</param>
		/// <param name="aceptado">Input parameter of stored procedure</param>
		/// <param name="idEvento">Input parameter of stored procedure</param>
		/// <param name="domicilio">Input parameter of stored procedure</param>
		/// <param name="idCiudad">Input parameter of stored procedure</param>
		/// <param name="telefono">Input parameter of stored procedure</param>
		/// <param name="celular">Input parameter of stored procedure</param>
		/// <param name="redesSociales">Input parameter of stored procedure</param>
		/// <param name="eMail">Input parameter of stored procedure</param>
		/// <param name="gradoEscolar">Input parameter of stored procedure</param>
		/// <param name="codParroqia">Input parameter of stored procedure</param>
		/// <param name="codSacerdote">Input parameter of stored procedure</param>
		/// <param name="idEquipo">Input parameter of stored procedure</param>
		/// <param name="seccion">Input parameter of stored procedure</param>
		/// <param name="observaciones">Input parameter of stored procedure</param>
		/// <param name="foto">Input parameter of stored procedure</param>
		/// <param name="error">InputOutput parameter of stored procedure</param>
		/// <param name="returnValue">Return value of the stored procedure</param>
		/// <returns>Amount of rows affected, if the database / routine doesn't surpress rowcounting.</returns>
		public static int UpimSemAsistencia(System.String apellidoPaterno, System.String apellidoMaterno, System.String nombre, System.DateTime fechaNacim, System.Int16 aceptado, System.String idEvento, System.String domicilio, System.Byte idCiudad, System.String telefono, System.String celular, System.String redesSociales,  
System.String eMail, System.String gradoEscolar, System.Int32 codParroqia, System.Int32 codSacerdote, System.Int32 idEquipo, System.Int32 seccion, System.String observaciones, System.Byte[] foto, ref System.Int32 codParticipante, ref System.Int32 error, ref System.Int32 returnValue)
		{
			// create parameters. Add 1 to make room for the return value parameter.
			SqlParameter[] parameters = new SqlParameter[21 + 1];
			parameters[1] = new SqlParameter("@ApellidoPaterno", SqlDbType.VarChar, 50, ParameterDirection.Input, true, 0, 0, "",  DataRowVersion.Current, apellidoPaterno);
			parameters[2] = new SqlParameter("@ApellidoMaterno", SqlDbType.VarChar, 50, ParameterDirection.Input, true, 0, 0, "",  DataRowVersion.Current, apellidoMaterno);
			parameters[3] = new SqlParameter("@Nombre", SqlDbType.VarChar, 50, ParameterDirection.Input, true, 0, 0, "",  DataRowVersion.Current, nombre);
			parameters[4] = new SqlParameter("@FechaNacim", SqlDbType.DateTime, 0, ParameterDirection.Input, true, 0, 0, "",  DataRowVersion.Current, fechaNacim);
			parameters[5] = new SqlParameter("@Aceptado", SqlDbType.SmallInt, 0, ParameterDirection.Input, true, 5, 0, "",  DataRowVersion.Current, aceptado);
			parameters[6] = new SqlParameter("@IdEvento", SqlDbType.VarChar, 50, ParameterDirection.Input, true, 0, 0, "",  DataRowVersion.Current, idEvento);
			parameters[7] = new SqlParameter("@Domicilio", SqlDbType.VarChar, 100, ParameterDirection.Input, true, 0, 0, "",  DataRowVersion.Current, domicilio);
			parameters[8] = new SqlParameter("@IdCiudad", SqlDbType.TinyInt, 0, ParameterDirection.Input, true, 3, 0, "",  DataRowVersion.Current, idCiudad);
			parameters[9] = new SqlParameter("@Telefono", SqlDbType.NChar, 20, ParameterDirection.Input, true, 0, 0, "",  DataRowVersion.Current, telefono);
			parameters[10] = new SqlParameter("@Celular", SqlDbType.NChar, 20, ParameterDirection.Input, true, 0, 0, "",  DataRowVersion.Current, celular);
			parameters[11] = new SqlParameter("@RedesSociales", SqlDbType.VarChar, 100, ParameterDirection.Input, true, 0, 0, "",  DataRowVersion.Current, redesSociales);
			parameters[12] = new SqlParameter("@eMail", SqlDbType.VarChar, 30, ParameterDirection.Input, true, 0, 0, "",  DataRowVersion.Current, eMail);
			parameters[13] = new SqlParameter("@GradoEscolar", SqlDbType.VarChar, 30, ParameterDirection.Input, true, 0, 0, "",  DataRowVersion.Current, gradoEscolar);
			parameters[14] = new SqlParameter("@CodParroqia", SqlDbType.Int, 0, ParameterDirection.Input, true, 10, 0, "",  DataRowVersion.Current, codParroqia);
			parameters[15] = new SqlParameter("@CodSacerdote", SqlDbType.Int, 0, ParameterDirection.Input, true, 10, 0, "",  DataRowVersion.Current, codSacerdote);
			parameters[16] = new SqlParameter("@IdEquipo", SqlDbType.Int, 0, ParameterDirection.Input, true, 10, 0, "",  DataRowVersion.Current, idEquipo);
			parameters[17] = new SqlParameter("@Seccion", SqlDbType.Int, 0, ParameterDirection.Input, true, 10, 0, "",  DataRowVersion.Current, seccion);
			parameters[18] = new SqlParameter("@Observaciones", SqlDbType.Text, 2147483647, ParameterDirection.Input, true, 0, 0, "",  DataRowVersion.Current, observaciones);
			parameters[19] = new SqlParameter("@Foto", SqlDbType.Image, 2147483647, ParameterDirection.Input, true, 0, 0, "",  DataRowVersion.Current, foto);
			parameters[0] = new SqlParameter("@CodParticipante", SqlDbType.Int, 0, ParameterDirection.InputOutput, true, 10, 0, "",  DataRowVersion.Current, codParticipante);
			parameters[20] = new SqlParameter("@Error", SqlDbType.Int, 0, ParameterDirection.InputOutput, true, 10, 0, "",  DataRowVersion.Current, error);
			// return value parameter
			parameters[21] = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, true, 10, 0, "",  DataRowVersion.Current, returnValue);

			// Call the stored proc.
			int toReturn = DbUtils.CallActionStoredProcedure("[dbo].[UPIM_SemAsistencia]", parameters, null);
			if(parameters[0].Value!=System.DBNull.Value)
			{
				codParticipante = (System.Int32)parameters[0].Value;
			}
			if(parameters[20].Value!=System.DBNull.Value)
			{
				error = (System.Int32)parameters[20].Value;
			}
			returnValue = (int)parameters[21].Value;
			return toReturn;
		}


		/// <summary>
		/// Calls stored procedure 'UPIM_SemAsistencia'.<br/><br/>
		/// 
		/// </summary>
		/// <param name="codParticipante">InputOutput parameter of stored procedure</param>
		/// <param name="apellidoPaterno">Input parameter of stored procedure</param>
		/// <param name="apellidoMaterno">Input parameter of stored procedure</param>
		/// <param name="nombre">Input parameter of stored procedure</param>
		/// <param name="fechaNacim">Input parameter of stored procedure</param>
		/// <param name="aceptado">Input parameter of stored procedure</param>
		/// <param name="idEvento">Input parameter of stored procedure</param>
		/// <param name="domicilio">Input parameter of stored procedure</param>
		/// <param name="idCiudad">Input parameter of stored procedure</param>
		/// <param name="telefono">Input parameter of stored procedure</param>
		/// <param name="celular">Input parameter of stored procedure</param>
		/// <param name="redesSociales">Input parameter of stored procedure</param>
		/// <param name="eMail">Input parameter of stored procedure</param>
		/// <param name="gradoEscolar">Input parameter of stored procedure</param>
		/// <param name="codParroqia">Input parameter of stored procedure</param>
		/// <param name="codSacerdote">Input parameter of stored procedure</param>
		/// <param name="idEquipo">Input parameter of stored procedure</param>
		/// <param name="seccion">Input parameter of stored procedure</param>
		/// <param name="observaciones">Input parameter of stored procedure</param>
		/// <param name="foto">Input parameter of stored procedure</param>
		/// <param name="error">InputOutput parameter of stored procedure</param>
		/// <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		/// <returns>Amount of rows affected, if the database / routine doesn't surpress rowcounting.</returns>
		public static int UpimSemAsistencia(System.String apellidoPaterno, System.String apellidoMaterno, System.String nombre, System.DateTime fechaNacim, System.Int16 aceptado, System.String idEvento, System.String domicilio, System.Byte idCiudad, System.String telefono, System.String celular, System.String redesSociales,  
System.String eMail, System.String gradoEscolar, System.Int32 codParroqia, System.Int32 codSacerdote, System.Int32 idEquipo, System.Int32 seccion, System.String observaciones, System.Byte[] foto, ref System.Int32 codParticipante, ref System.Int32 error,  ITransaction transactionToUse)
		{
			// create parameters
			SqlParameter[] parameters = new SqlParameter[21];
			parameters[1] = new SqlParameter("@ApellidoPaterno", SqlDbType.VarChar, 50, ParameterDirection.Input, true, 0, 0, "",  DataRowVersion.Current, apellidoPaterno);
			parameters[2] = new SqlParameter("@ApellidoMaterno", SqlDbType.VarChar, 50, ParameterDirection.Input, true, 0, 0, "",  DataRowVersion.Current, apellidoMaterno);
			parameters[3] = new SqlParameter("@Nombre", SqlDbType.VarChar, 50, ParameterDirection.Input, true, 0, 0, "",  DataRowVersion.Current, nombre);
			parameters[4] = new SqlParameter("@FechaNacim", SqlDbType.DateTime, 0, ParameterDirection.Input, true, 0, 0, "",  DataRowVersion.Current, fechaNacim);
			parameters[5] = new SqlParameter("@Aceptado", SqlDbType.SmallInt, 0, ParameterDirection.Input, true, 5, 0, "",  DataRowVersion.Current, aceptado);
			parameters[6] = new SqlParameter("@IdEvento", SqlDbType.VarChar, 50, ParameterDirection.Input, true, 0, 0, "",  DataRowVersion.Current, idEvento);
			parameters[7] = new SqlParameter("@Domicilio", SqlDbType.VarChar, 100, ParameterDirection.Input, true, 0, 0, "",  DataRowVersion.Current, domicilio);
			parameters[8] = new SqlParameter("@IdCiudad", SqlDbType.TinyInt, 0, ParameterDirection.Input, true, 3, 0, "",  DataRowVersion.Current, idCiudad);
			parameters[9] = new SqlParameter("@Telefono", SqlDbType.NChar, 20, ParameterDirection.Input, true, 0, 0, "",  DataRowVersion.Current, telefono);
			parameters[10] = new SqlParameter("@Celular", SqlDbType.NChar, 20, ParameterDirection.Input, true, 0, 0, "",  DataRowVersion.Current, celular);
			parameters[11] = new SqlParameter("@RedesSociales", SqlDbType.VarChar, 100, ParameterDirection.Input, true, 0, 0, "",  DataRowVersion.Current, redesSociales);
			parameters[12] = new SqlParameter("@eMail", SqlDbType.VarChar, 30, ParameterDirection.Input, true, 0, 0, "",  DataRowVersion.Current, eMail);
			parameters[13] = new SqlParameter("@GradoEscolar", SqlDbType.VarChar, 30, ParameterDirection.Input, true, 0, 0, "",  DataRowVersion.Current, gradoEscolar);
			parameters[14] = new SqlParameter("@CodParroqia", SqlDbType.Int, 0, ParameterDirection.Input, true, 10, 0, "",  DataRowVersion.Current, codParroqia);
			parameters[15] = new SqlParameter("@CodSacerdote", SqlDbType.Int, 0, ParameterDirection.Input, true, 10, 0, "",  DataRowVersion.Current, codSacerdote);
			parameters[16] = new SqlParameter("@IdEquipo", SqlDbType.Int, 0, ParameterDirection.Input, true, 10, 0, "",  DataRowVersion.Current, idEquipo);
			parameters[17] = new SqlParameter("@Seccion", SqlDbType.Int, 0, ParameterDirection.Input, true, 10, 0, "",  DataRowVersion.Current, seccion);
			parameters[18] = new SqlParameter("@Observaciones", SqlDbType.Text, 2147483647, ParameterDirection.Input, true, 0, 0, "",  DataRowVersion.Current, observaciones);
			parameters[19] = new SqlParameter("@Foto", SqlDbType.Image, 2147483647, ParameterDirection.Input, true, 0, 0, "",  DataRowVersion.Current, foto);
			parameters[0] = new SqlParameter("@CodParticipante", SqlDbType.Int, 0, ParameterDirection.InputOutput, true, 10, 0, "",  DataRowVersion.Current, codParticipante);
			parameters[20] = new SqlParameter("@Error", SqlDbType.Int, 0, ParameterDirection.InputOutput, true, 10, 0, "",  DataRowVersion.Current, error);
			// Call the stored proc.
			int toReturn = DbUtils.CallActionStoredProcedure("[dbo].[UPIM_SemAsistencia]", parameters, transactionToUse);
			if(parameters[0].Value!=System.DBNull.Value)
			{
				codParticipante = (System.Int32)parameters[0].Value;
			}
			if(parameters[20].Value!=System.DBNull.Value)
			{
				error = (System.Int32)parameters[20].Value;
			}
			return toReturn;
		}
		
		
		/// <summary>
		/// Calls stored procedure 'UPIM_SemAsistencia'.<br/><br/>
		/// 
		/// </summary>
		/// <param name="codParticipante">InputOutput parameter of stored procedure</param>
		/// <param name="apellidoPaterno">Input parameter of stored procedure</param>
		/// <param name="apellidoMaterno">Input parameter of stored procedure</param>
		/// <param name="nombre">Input parameter of stored procedure</param>
		/// <param name="fechaNacim">Input parameter of stored procedure</param>
		/// <param name="aceptado">Input parameter of stored procedure</param>
		/// <param name="idEvento">Input parameter of stored procedure</param>
		/// <param name="domicilio">Input parameter of stored procedure</param>
		/// <param name="idCiudad">Input parameter of stored procedure</param>
		/// <param name="telefono">Input parameter of stored procedure</param>
		/// <param name="celular">Input parameter of stored procedure</param>
		/// <param name="redesSociales">Input parameter of stored procedure</param>
		/// <param name="eMail">Input parameter of stored procedure</param>
		/// <param name="gradoEscolar">Input parameter of stored procedure</param>
		/// <param name="codParroqia">Input parameter of stored procedure</param>
		/// <param name="codSacerdote">Input parameter of stored procedure</param>
		/// <param name="idEquipo">Input parameter of stored procedure</param>
		/// <param name="seccion">Input parameter of stored procedure</param>
		/// <param name="observaciones">Input parameter of stored procedure</param>
		/// <param name="foto">Input parameter of stored procedure</param>
		/// <param name="error">InputOutput parameter of stored procedure</param>
		/// <param name="returnValue">Return value of the stored procedure</param>
		/// <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		/// <returns>Amount of rows affected, if the database / routine doesn't surpress rowcounting.</returns>
		public static int UpimSemAsistencia(System.String apellidoPaterno, System.String apellidoMaterno, System.String nombre, System.DateTime fechaNacim, System.Int16 aceptado, System.String idEvento, System.String domicilio, System.Byte idCiudad, System.String telefono, System.String celular, System.String redesSociales,  
System.String eMail, System.String gradoEscolar, System.Int32 codParroqia, System.Int32 codSacerdote, System.Int32 idEquipo, System.Int32 seccion, System.String observaciones, System.Byte[] foto, ref System.Int32 codParticipante, ref System.Int32 error, ref System.Int32 returnValue, ITransaction transactionToUse)
		{
			// create parameters. Add 1 to make room for the return value parameter.
			SqlParameter[] parameters = new SqlParameter[21 + 1];
			parameters[1] = new SqlParameter("@ApellidoPaterno", SqlDbType.VarChar, 50, ParameterDirection.Input, true, 0, 0, "",  DataRowVersion.Current, apellidoPaterno);
			parameters[2] = new SqlParameter("@ApellidoMaterno", SqlDbType.VarChar, 50, ParameterDirection.Input, true, 0, 0, "",  DataRowVersion.Current, apellidoMaterno);
			parameters[3] = new SqlParameter("@Nombre", SqlDbType.VarChar, 50, ParameterDirection.Input, true, 0, 0, "",  DataRowVersion.Current, nombre);
			parameters[4] = new SqlParameter("@FechaNacim", SqlDbType.DateTime, 0, ParameterDirection.Input, true, 0, 0, "",  DataRowVersion.Current, fechaNacim);
			parameters[5] = new SqlParameter("@Aceptado", SqlDbType.SmallInt, 0, ParameterDirection.Input, true, 5, 0, "",  DataRowVersion.Current, aceptado);
			parameters[6] = new SqlParameter("@IdEvento", SqlDbType.VarChar, 50, ParameterDirection.Input, true, 0, 0, "",  DataRowVersion.Current, idEvento);
			parameters[7] = new SqlParameter("@Domicilio", SqlDbType.VarChar, 100, ParameterDirection.Input, true, 0, 0, "",  DataRowVersion.Current, domicilio);
			parameters[8] = new SqlParameter("@IdCiudad", SqlDbType.TinyInt, 0, ParameterDirection.Input, true, 3, 0, "",  DataRowVersion.Current, idCiudad);
			parameters[9] = new SqlParameter("@Telefono", SqlDbType.NChar, 20, ParameterDirection.Input, true, 0, 0, "",  DataRowVersion.Current, telefono);
			parameters[10] = new SqlParameter("@Celular", SqlDbType.NChar, 20, ParameterDirection.Input, true, 0, 0, "",  DataRowVersion.Current, celular);
			parameters[11] = new SqlParameter("@RedesSociales", SqlDbType.VarChar, 100, ParameterDirection.Input, true, 0, 0, "",  DataRowVersion.Current, redesSociales);
			parameters[12] = new SqlParameter("@eMail", SqlDbType.VarChar, 30, ParameterDirection.Input, true, 0, 0, "",  DataRowVersion.Current, eMail);
			parameters[13] = new SqlParameter("@GradoEscolar", SqlDbType.VarChar, 30, ParameterDirection.Input, true, 0, 0, "",  DataRowVersion.Current, gradoEscolar);
			parameters[14] = new SqlParameter("@CodParroqia", SqlDbType.Int, 0, ParameterDirection.Input, true, 10, 0, "",  DataRowVersion.Current, codParroqia);
			parameters[15] = new SqlParameter("@CodSacerdote", SqlDbType.Int, 0, ParameterDirection.Input, true, 10, 0, "",  DataRowVersion.Current, codSacerdote);
			parameters[16] = new SqlParameter("@IdEquipo", SqlDbType.Int, 0, ParameterDirection.Input, true, 10, 0, "",  DataRowVersion.Current, idEquipo);
			parameters[17] = new SqlParameter("@Seccion", SqlDbType.Int, 0, ParameterDirection.Input, true, 10, 0, "",  DataRowVersion.Current, seccion);
			parameters[18] = new SqlParameter("@Observaciones", SqlDbType.Text, 2147483647, ParameterDirection.Input, true, 0, 0, "",  DataRowVersion.Current, observaciones);
			parameters[19] = new SqlParameter("@Foto", SqlDbType.Image, 2147483647, ParameterDirection.Input, true, 0, 0, "",  DataRowVersion.Current, foto);
			parameters[0] = new SqlParameter("@CodParticipante", SqlDbType.Int, 0, ParameterDirection.InputOutput, true, 10, 0, "",  DataRowVersion.Current, codParticipante);
			parameters[20] = new SqlParameter("@Error", SqlDbType.Int, 0, ParameterDirection.InputOutput, true, 10, 0, "",  DataRowVersion.Current, error);
			// return value parameter
			parameters[21] = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, true, 10, 0, "",  DataRowVersion.Current, returnValue);

			// Call the stored proc.
			int toReturn = DbUtils.CallActionStoredProcedure("[dbo].[UPIM_SemAsistencia]", parameters, transactionToUse);
			if(parameters[0].Value!=System.DBNull.Value)
			{
				codParticipante = (System.Int32)parameters[0].Value;
			}
			if(parameters[20].Value!=System.DBNull.Value)
			{
				error = (System.Int32)parameters[20].Value;
			}
			returnValue = (int)parameters[21].Value;
			return toReturn;
		}
	
	
		#region Included Code

		#endregion
	}
}
