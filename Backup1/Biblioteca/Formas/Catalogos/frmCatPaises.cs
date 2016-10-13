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
    public partial class frmCatPaises : Form, CN.iForm
    {
        
        CN.Pais loPais;
        CN.PaisCol loColSecciones= new CN.PaisCol();
        Boolean puedorefrescar = true;
        Boolean Editar = false;
        Boolean selesccionado = false;
        Dictionary<string, int> list = new Dictionary<string, int>();

        private SqlDataAdapter DtAdap = new SqlDataAdapter();
        private DataSet dtsGral = new DataSet();
        private Boolean lbModificado = false;
        private Boolean[] _ToolBarStatus;
        private String lsIdEvento, lsNombreEvento;

        public frmCatPaises()
        {
            InitializeComponent();
        }

        #region "iForm"
        Boolean[] CN.iForm.ToolBarStatus
        {
            get { return _ToolBarStatus; }
            set { _ToolBarStatus = value; }
        }

        void CN.iForm.Guardar()
        {
            if (!Validar())
                return;
            if (loPais == null) loPais = new CN.Pais();

            try
            {
                loPais.Nombre = txtNombre.Text;

                if (loPais.Guardar())
                {
                    MessageBox.Show("El país ha sido guardado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ((CN.iForm)this).Nuevo();
                }
                else
                    MessageBox.Show("Error al intentar guardar el país.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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

            if (txtNombre.Text.Trim() == "")
                Mensaje = Mensaje + "   * No se ha capturado el nombre del país.\n";

            if (Mensaje != "")
            {
                Validado = false;
                Mensaje = "Antes de guardar debe corregir lo siguiente:\n\n" + Mensaje;
                MessageBox.Show(Mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return Validado;
        }

        void CN.iForm.Borrar()
        {
            if (loPais == null)
            {
                MessageBox.Show("No se puede borrar un país que no ha sido guardado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (loPais.Autores.Count > 0)
            {
                MessageBox.Show("No se puede borrar el país porque tiene autores capturados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (loPais.Libros.Count > 0)
            {
                MessageBox.Show("No se puede borrar el país porque tiene libros capturados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("¿Desea borrar el país?", "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (loPais.Borrar())
                    {
                        MessageBox.Show("El país ha sido borrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ((CN.iForm)this).Nuevo();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        void CN.iForm.Cancelar()
        {
        }

        void CN.iForm.Nuevo()
        {
            mtbCodigo.Text = "";
            txtNombre.Text = "";
            loPais = null;

            LlenaGrid();
        }

        void CN.iForm.Buscar()
        {
        }

        void CN.iForm.Imprimir()
        {
        }

        #endregion

        private void frmCatPaises_Load(object sender, EventArgs e)
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

        private void frmCatPaises_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void frmCatPaises_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void LlenaGrid()
        {
            loColSecciones.Clear();
            if (loColSecciones.Obtener() > 0)
            {
                DataGrid.AutoGenerateColumns = false;
                DataGrid.DataSource = loColSecciones;

            }
        }

        private void DataGrid_DoubleClick(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                if (DataGrid.SelectedRows.Count > 0)
                {
                    loPais = new CN.Pais();
                    loPais.MensajeError += Evento_MensajeError;
                    if (loPais.Obtener(Convert.ToInt32(DataGrid.SelectedRows[0].Cells[0].Value)))
                    {
                        mtbCodigo.Text = loPais.Id.ToString();
                        txtNombre.Text = loPais.Nombre;
                       // this.selesccionado = true;
                      // this.LblEstatus.Visible = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",MessageBoxButtons.OK,MessageBoxIcon.Information);
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
