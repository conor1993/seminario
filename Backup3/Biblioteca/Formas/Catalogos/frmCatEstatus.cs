using System;
//using System.Collections.Generic;
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

namespace ClasesBiblioteca.Formas.Catalogos
{
    public partial class frmCatEstatus : Form, CN.iForm
    {   

        CN.Estatus loEstatus;
        CN.EstatusCol loColloEstatus = new CN.EstatusCol();
        public frmCatEstatus()
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
            //if (validar()) return;

            if (loEstatus == null) loEstatus = new CN.Estatus();

            try
            {
                loEstatus.Estado = txtNombre.Text;

                if (loEstatus.Guardar())
                {
                    MessageBox.Show("El estatus ha sido guardado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ((CN.iForm)this).Nuevo();
                }
                else
                    MessageBox.Show("El festatus ha sido guardado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void CN.iForm.Imprimir()
        {
            throw new NotImplementedException();
        }

        void CN.iForm.Nuevo()
        {
         
            llenarGrid();
            loEstatus = null;
            txtNombre.Text = "";
        }

        void CN.iForm.Cancelar()
        {
            throw new NotImplementedException();
        }

        void CN.iForm.Borrar()
        {
            try
            {
                if (CN.DBU.Cnn.State == ConnectionState.Closed)
                    CN.DBU.Cnn.Open();

                SqlCommand _SQLComm = new SqlCommand();

                _SQLComm.CommandText = "BorrarEstatus";
                _SQLComm.CommandType = CommandType.StoredProcedure;
                _SQLComm.Connection = CN.DBU.Cnn;

                int id = Convert.ToInt32(mtbCodigo.Text);

                _SQLComm.Parameters.Add(new SqlParameter("id", id));

                _SQLComm.Parameters.Add(new SqlParameter("Error", SqlDbType.Int, 4));
                _SQLComm.Parameters["Error"].Direction = ParameterDirection.Output;

                _SQLComm.Parameters.Add(new SqlParameter("borro", SqlDbType.Int, 4));
                _SQLComm.Parameters["borro"].Direction = ParameterDirection.Output;

                _SQLComm.ExecuteNonQuery();

                CN.DBU.Cnn.Close();

                if (int.Parse(_SQLComm.Parameters["borro"].Value.ToString()) > 0)
                    throw new Exception("No se puede borrar.");

                MessageBox.Show("El estatus ha sido borrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ((CN.iForm)this).Nuevo();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void CN.iForm.Buscar()
        {
            throw new NotImplementedException();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                llenarGrid();
            }
            catch (Exception exp) {
            
            }

        }

        private void llenarGrid()
        {

            loColloEstatus.Clear();
            if (loColloEstatus.Obtener() > 0)
            {
                dgtEstatus.AutoGenerateColumns = false;
                dgtEstatus.DataSource = loColloEstatus;

            }

        }

        private void dgtEstatus_DoubleClick(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                if (dgtEstatus.SelectedRows.Count > 0)
                {
                    loEstatus = new CN.Estatus();
                    loEstatus.MensajeError += Evento_MensajeError;
                    if (loEstatus.Obtener(Convert.ToInt32(dgtEstatus.SelectedRows[0].Cells[0].Value)))
                    {
                        mtbCodigo.Text = loEstatus.Id.ToString();
                        txtNombre.Text = loEstatus.Estado;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void Evento_MensajeError(object sender, string mensaje)
        {
            MessageBox.Show(mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
