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
    public partial class frmCatRamas : Form, CN.iForm
    {        
        CN.Rama loRama;
        CN.RamaCol loColRamas= new CN.RamaCol();
        CN.SeccionCol loColSecciones = new CN.SeccionCol();

        Boolean puedorefrescar = true;
        Boolean Editar = false;
        Boolean selesccionado = false;
        Dictionary<string, int> list = new Dictionary<string, int>();

        private SqlDataAdapter DtAdap = new SqlDataAdapter();
        private DataSet dtsGral = new DataSet();
        private Boolean lbModificado = false;
        private Boolean[] _ToolBarStatus;

        public frmCatRamas()
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
            if (loRama == null) loRama = new CN.Rama();

            try
            {
                loRama.Nombre = txtNombre.Text;
                loRama.IdSeccion = (int)cmbSeccion.SelectedValue;

                if (loRama.Guardar())
                {
                    MessageBox.Show("La rama ha sido guardado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ((CN.iForm)this).Nuevo();
                }
                else
                    MessageBox.Show("Error al intentar guardar la rama.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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
                Mensaje = Mensaje + "   * No se ha capturado el nombre de la rama.\n";

            if (cmbSeccion.SelectedIndex == -1)
                Mensaje = Mensaje + "   * No se ha seleccionado la sección a la que pertenece la rama.\n";
            
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
            if (loRama == null)
            {
                MessageBox.Show("No se puede borrar una rama que no ha sido guardada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (loRama.Tematicas.Count > 0)
            {
                MessageBox.Show("No se puede borrar la rama porque tiene temáticas capturadas", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("¿Desea borrar la rama?", "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (loRama.Borrar())
                    {
                        MessageBox.Show("La rama ha sido borrada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            cmbSeccion.SelectedIndex = -1;
            loRama = null;

            LlenaGrid();
            cmbSeccion.Focus();
        }

        void CN.iForm.Buscar()
        {
        }

        void CN.iForm.Imprimir()
        {
        }

        #endregion

        private void frmCatRamas_Load(object sender, EventArgs e)
        {
            try
            {
                loColSecciones.Obtener();
                cmbSeccion.DisplayMember = "Nombre";
                cmbSeccion.ValueMember = "Id";
                cmbSeccion.DataSource = loColSecciones;
                cmbSeccion.SelectedIndex = -1;
                LlenaGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void frmCatRamas_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void frmCatRamas_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void LlenaGrid()
        {
            loColRamas.Clear();
            if (loColRamas.Obtener() > 0)
            {
                DataGrid.AutoGenerateColumns = false;
                DataGrid.DataSource = loColRamas;
            }
        }

        private void Evento_MensajeError(object sender, string mensaje)
        {
            MessageBox.Show(mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void DataGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                try
                {
                    e.Value = ((CN.Seccion)e.Value).Nombre;
                }
                catch (Exception ex)
                {
                    e.Value = e.Value;
                }
            }
        }

        private void DataGrid_DoubleClick(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                if (DataGrid.SelectedRows.Count > 0)
                {
                    loRama = new CN.Rama();
                    loRama.MensajeError += Evento_MensajeError;
                    if (loRama.Obtener(Convert.ToInt32(DataGrid.SelectedRows[0].Cells[0].Value)))
                    {
                        mtbCodigo.Text = loRama.Id.ToString();
                        txtNombre.Text = loRama.Nombre;
                        cmbSeccion.SelectedValue = loRama.Seccion.Id;
                        this.selesccionado = true;
                        this.LblEstatus.Visible = true;
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

    }
}
