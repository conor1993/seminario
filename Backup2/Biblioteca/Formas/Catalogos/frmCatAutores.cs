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
    public partial class frmCatAutores : Form, CN.iForm
    {

    
        CN.Autor loAutor;
        CN.AutorCol loColAutores= new CN.AutorCol();
        CN.PaisCol loColPaises = new CN.PaisCol();

        Boolean puedorefrescar = true;
        Boolean Editar = false;
        Boolean seleccionado = false;
        Dictionary<string, int> list = new Dictionary<string, int>();

        private SqlDataAdapter DtAdap = new SqlDataAdapter();
        private DataSet dtsGral = new DataSet();
        private Boolean lbModificado = false;
        private Boolean[] _ToolBarStatus;

        public frmCatAutores()
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
            if (loAutor == null) loAutor = new CN.Autor();

            try
            {
                loAutor.Nombre= txtNombre.Text;
                loAutor.IdPais = (int)cmbPais.SelectedValue;

                if (loAutor.Guardar())
                {
                    MessageBox.Show("El autor ha sido guardado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ((CN.iForm)this).Nuevo();
                }
                else
                    MessageBox.Show("Error al intentar guardar el autor.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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
                Mensaje = Mensaje + "   * No se ha capturado el nombre de el autor.\n";

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
            if (loAutor == null)
            {
                MessageBox.Show("No se puede borrar un autor que no ha sido guardado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (loAutor.Libros.Count > 0)
            {
                MessageBox.Show("No se puede borrar el autor porque tiene libros capturados.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("¿Desea borrar el autor?", "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (loAutor.Borrar())
                    {
                        MessageBox.Show("El autor ha sido borrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            cmbPais.SelectedIndex = -1;
            loAutor = null;

            LlenaGrid();
        }

        void CN.iForm.Buscar()
        {
        }

        void CN.iForm.Imprimir()
        {
        }

        #endregion

        private void frmCatAutores_Load(object sender, EventArgs e)
        {
            try
            {
                loColPaises.Obtener();
                cmbPais.DisplayMember = "Nombre";
                cmbPais.ValueMember = "Id";
                cmbPais.DataSource = loColPaises;
                cmbPais.SelectedIndex = -1;
                LlenaGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmCatAutores_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void frmCatAutores_KeyDown(object sender, KeyEventArgs e)
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
            loColAutores.Clear();
            if (loColAutores.Obtener() > 0)
            {
                DataGrid.AutoGenerateColumns = false;
                DataGrid.DataSource = loColAutores;
            }
        }

        private void DataGrid_DoubleClick(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                if (DataGrid.SelectedRows.Count > 0)
                {
                    loAutor = new CN.Autor();
                    loAutor.MensajeError += Evento_MensajeError;
                    if (loAutor.Obtener(Convert.ToInt32(DataGrid.SelectedRows[0].Cells[0].Value)))
                    {
                        mtbCodigo.Text = loAutor.Id.ToString();
                        txtNombre.Text = loAutor.Nombre;
                        cmbPais.SelectedValue = loAutor.IdPais;
                        this.seleccionado = true;
                        this.LblEstatus.Visible = true;
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

        private void DataGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                try
                {
                    e.Value = ((CN.Pais)e.Value).Nombre;
                }
                catch (Exception ex)
                {
                    e.Value = e.Value;
                }
            }
        }

        private void Evento_MensajeError(object sender, string mensaje)
        {
            MessageBox.Show(mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

    }
}
