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
    public partial class frmCatFormato : Form, CN.iForm
    {
        CN.Formatos loFormato;
        CN.FormatoCol loColloFormato = new CN.FormatoCol();


        public frmCatFormato() {
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
            if(validar())return;

            if (loFormato == null) loFormato = new CN.Formatos();

            try
            {
                loFormato.Formato = txtNombre.Text;

                if (loFormato.Guardar())
                {
                    MessageBox.Show("El formato ha sido guardado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ((CN.iForm)this).Nuevo();
                }
                else
                    MessageBox.Show("El formato ha sido guardado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool validar()
        {
            String Mensaje = "";
            bool validado = false;

            if(txtNombre.Text.Trim() == ""){
                Mensaje = Mensaje + "   * No se ha capturado el nombre del formato.\n";
            }

            if (Mensaje != "") {
                validado = true;
                Mensaje = "Antes de guardar debe corregir lo siguiente:\n\n" + Mensaje;
                MessageBox.Show(Mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return validado;
        }

        void CN.iForm.Imprimir()
        {
            throw new NotImplementedException();
        }

        void CN.iForm.Nuevo()
        {
            loColloFormato.Clear();
            llenarGrid();
            txtNombre.Text = "";
            loFormato = null;
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

                _SQLComm.CommandText = "BorrarFormato";
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
            catch (Exception ex) {
            
            }
        }

        private void llenarGrid()
        {

            loColloFormato.Clear();
            if (loColloFormato.Obtener() > 0)
            {
                dgtFormato.AutoGenerateColumns = false;
                dgtFormato.DataSource = loColloFormato;

            }
            
        }

        private void dgtFormato_DoubleClick(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                if (dgtFormato.SelectedRows.Count > 0)
                {
                    loFormato = new CN.Formatos();
                    loFormato.MensajeError += Evento_MensajeError;
                    if (loFormato.Obtener(Convert.ToInt32(dgtFormato.SelectedRows[0].Cells[0].Value)))
                    {
                        mtbCodigo.Text = loFormato.Id.ToString();
                        txtNombre.Text = loFormato.Formato;
  
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
