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
    public partial class frmEstatus : Form, CN.iForm
    {
        CN.Estatus loEstatus;
        private DataSet dtsEstatus;
        CN.ColEstatus loColEstatus = new CN.ColEstatus();

        public frmEstatus()
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
            if (!Validar())
                return;

            if (loEstatus == null) loEstatus = new CN.Estatus();

            try
            {
                loEstatus.Estado = txtEstado.Text;

                if (loEstatus.Guardar())
                {
                    MessageBox.Show("El Estado ha sido guardado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ((CN.iForm)this).Nuevo();
                }
                else
                    MessageBox.Show("Error al intentar guardar el Estado .", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool Validar()
        {
            Boolean Validado = true;
            String Mensaje = "";

            if (txtEstado.Text.Trim() == "")
                Mensaje = Mensaje + "   * No se ha capturado el nombre del estado.\n";

            if (Mensaje != "")
            {
                Validado = false;
                Mensaje = "Antes de guardar debe corregir lo siguiente:\n\n" + Mensaje;
                MessageBox.Show(Mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return Validado;
        }

        void CN.iForm.Imprimir()
        {
            throw new NotImplementedException();
        }

        void CN.iForm.Nuevo()
        {
            txtEstado.Text = "";
            txtCodigo.Text = "";
            loEstatus = null;
            LlenaGrid();
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

        private void frmEstatus_Load(object sender, EventArgs e)
        {
            try
            {
                LlenaGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LlenaGrid()
        {

            loColEstatus.Clear();
            if (loColEstatus.Obtener() > 0)
            {
                dataEstatus.AutoGenerateColumns = false;
                dataEstatus.DataSource = loColEstatus;

            }


        }
        private void Evento_MensajeError(object sender, string mensaje)
        {
            MessageBox.Show(mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void dataEstatus_DoubleClick(object sender, EventArgs e)
        {


           
            try
            {
                if (CN.DBU.Cnn.State == ConnectionState.Closed)
                    CN.DBU.Cnn.Open();

                SqlCommand _SQLComm = new SqlCommand();
                SqlDataAdapter _DataAdap;

                _SQLComm.CommandText = "CbObtenerEstatusFiltro";
                _SQLComm.CommandType = CommandType.StoredProcedure;
                _SQLComm.Connection = CN.DBU.Cnn;

                int idd = Convert.ToInt32(dataEstatus.SelectedRows[0].Cells[0].Value);

                _SQLComm.Parameters.Add(new SqlParameter("id", idd));

                _SQLComm.ExecuteNonQuery();
                _DataAdap = new SqlDataAdapter(_SQLComm);
                dtsEstatus = new DataSet();
                _DataAdap.Fill(dtsEstatus);
                _DataAdap = null;

                if (dtsEstatus.Tables[0].Rows.Count > 0)
                {
                    int id = (int)dtsEstatus.Tables[0].Rows[0].ItemArray[0];
                    txtEstado.Text = (string)dtsEstatus.Tables[0].Rows[0].ItemArray[1];
                    txtCodigo.Text = id.ToString();
                    loEstatus = new CN.Estatus();
                    loEstatus.Estado = (string)dtsEstatus.Tables[0].Rows[0].ItemArray[1];

                }
                CN.DBU.Cnn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            
        }
    }

}

