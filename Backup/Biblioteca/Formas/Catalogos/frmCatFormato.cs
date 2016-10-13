using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using CN = ClasesNegocio;
using EC = ORMDiocesis.EntityClasses;
using CC = ORMDiocesis.CollectionClasses;

namespace ClasesBiblioteca
{
    public partial class frmCatFormato : Form, CN.iForm
    {
        private DataSet dtsFormato;
        private DataTable dttFormato;
        private DataView dvwFormato;

        public frmCatFormato()
        {
            InitializeComponent();
        }

        bool[] CN.iForm.ToolBarStatus
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        void CN.iForm.Guardar()
        {
            int id;

            try {
               id = Convert.ToInt32(txtCodigo.Text);
            }
            catch(Exception ex ){
                id = 0;
            }

            try
            {
                if (!Validar())
                    return;

                if (CN.DBU.Cnn.State == ConnectionState.Closed)
                    CN.DBU.Cnn.Open();

                SqlCommand _SQLComm = new SqlCommand();

                _SQLComm.CommandText = "CbGuardarFormato";
                _SQLComm.CommandType = CommandType.StoredProcedure;
                _SQLComm.Connection = CN.DBU.Cnn;

                string formato = txtFormato.Text;


                _SQLComm.Parameters.Add(new SqlParameter("formato", formato));
                _SQLComm.Parameters.Add(new SqlParameter("id", id));

                _SQLComm.Parameters.Add(new SqlParameter("Error", SqlDbType.Int, 4));
                _SQLComm.Parameters["Error"].Direction = ParameterDirection.Output;

                _SQLComm.Parameters.Add(new SqlParameter("guardo", SqlDbType.Int, 4));
                _SQLComm.Parameters["guardo"].Direction = ParameterDirection.Output;

                _SQLComm.ExecuteNonQuery();

                
                if (int.Parse(_SQLComm.Parameters["guardo"].Value.ToString()) > 0)
                    throw new Exception("El formato ya ha sido guardado.");


               ((CN.iForm)this).Nuevo();


                
                CN.DBU.Cnn.Close();


               
            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message, "Avisos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
     
        }

        private bool Validar()
        {
            Boolean Validado = true;
            String Mensaje = "";

            if (txtFormato.Text.Trim() == "")
                Mensaje = Mensaje + "   * No se ha capturado el nombre del formato.\n";

            if (Mensaje != "")
            {
                Validado = false;
                Mensaje = "Antes de guardar debe corregir lo siguiente:\n\n" + Mensaje;
                MessageBox.Show(Mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return Validado;
        }

        private bool validar()
        {

            Boolean Validado = true;


            return Validado;
        }

        void CN.iForm.Imprimir()
        {
            throw new NotImplementedException();
        }

        void CN.iForm.Nuevo()
        {
            txtFormato.Text = "";
            txtCodigo.Text = "";
            obtenerFormato();
        }

        void CN.iForm.Cancelar()
        {
            throw new NotImplementedException();
        }

        void CN.iForm.Borrar()
        {
            throw new NotImplementedException();
        }

        void CN.iForm.Buscar()
        {
            throw new NotImplementedException();
        }

        #region load
        private void frmCatFormato_Load(object sender, EventArgs e)
        {
            obtenerFormato();
        }

     
        public void obtenerFormato(){

            try
            {
                if (CN.DBU.Cnn.State == ConnectionState.Closed)
                    CN.DBU.Cnn.Open();

                SqlCommand _SQLComm = new SqlCommand();
                SqlDataAdapter _DataAdap;

                _SQLComm.CommandText = "CbObtenerFormato";
                _SQLComm.CommandType = CommandType.StoredProcedure;
                _SQLComm.Connection = CN.DBU.Cnn;



                _SQLComm.ExecuteNonQuery();
                _DataAdap = new SqlDataAdapter(_SQLComm);
                 dtsFormato = new DataSet();
                _DataAdap.Fill(dtsFormato);
                _DataAdap = null;

                dttFormato = dtsFormato.Tables[0];
                dvwFormato = new DataView(dttFormato);

                dataFormato.DataSource = null;
                dataFormato.DataSource = dvwFormato;

                CN.DBU.Cnn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        
        }
        #endregion

        private void dataFormato_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (CN.DBU.Cnn.State == ConnectionState.Closed)
                    CN.DBU.Cnn.Open();

                SqlCommand _SQLComm = new SqlCommand();
                SqlDataAdapter _DataAdap;

                _SQLComm.CommandText = "CbObtenerFormatoFiltro";
                _SQLComm.CommandType = CommandType.StoredProcedure;
                _SQLComm.Connection = CN.DBU.Cnn;

                int idd = Convert.ToInt32(dataFormato.SelectedRows[0].Cells[0].Value);

                _SQLComm.Parameters.Add(new SqlParameter("id", idd));

                _SQLComm.ExecuteNonQuery();
                _DataAdap = new SqlDataAdapter(_SQLComm);
                dtsFormato = new DataSet();
                _DataAdap.Fill(dtsFormato);
                _DataAdap = null;

                if (dtsFormato.Tables[0].Rows.Count > 0)
                {   
                    int id = (int)dtsFormato.Tables[0].Rows[0].ItemArray[0];
                    txtFormato.Text = (string)dtsFormato.Tables[0].Rows[0].ItemArray[1];
                    txtCodigo.Text = id.ToString();
                }
                CN.DBU.Cnn.Close();
            }

            catch (Exception ex){
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

           

        }
    }
}
