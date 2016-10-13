using System;
using System.Data;
using System.Data.SqlClient;

namespace ClasesNegocio
{
    public static class DBU
    {

        private static String _ConnStr;
        private static int _CmdTimeOut = 300;
        private static SqlConnection _cnn = new SqlConnection();

        public static String ConnStr
        {
            get {return _ConnStr;}
            set 
            {
                _ConnStr = value;
                if (_cnn.State==ConnectionState.Open)
                {   _cnn.Close();}
                _cnn.ConnectionString = _ConnStr;
                _cnn.Open();
            }
        }

        public static int CmdTimeOut
        {
            get {return _CmdTimeOut;}
            set {_CmdTimeOut = value;}
        }

        public static SqlConnection Cnn
        {
            get
            {
                if (_cnn.State==ConnectionState.Closed)
                { _cnn.Open(); }
                return _cnn;
            }
        }
    }
}
