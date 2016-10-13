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
    public partial class frmCatSecciones : Form, CN.iForm
    {
        
        CN.Seccion loSeccion;
        CN.SeccionCol loColSecciones= new CN.SeccionCol();
        Boolean puedorefrescar = true;
        Boolean Editar = false;
        Boolean selesccionado = false;
        Dictionary<string, int> list = new Dictionary<string, int>();

        private SqlDataAdapter DtAdap = new SqlDataAdapter();
        private DataSet dtsGral = new DataSet();
        private Boolean lbModificado = false;
        private Boolean[] _ToolBarStatus;
        private String lsIdEvento, lsNombreEvento;

        public frmCatSecciones()
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
            if (loSeccion == null) loSeccion = new CN.Seccion();

            try
            {
                //loSeccion.Id = Convert.ToInt32(mtbCodigo.Text);
                loSeccion.Nombre = txtNombre.Text;

                if (loSeccion.Guardar())
                {
                    MessageBox.Show("La sección ha sido guardado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ((CN.iForm)this).Nuevo();
                }
                else
                    MessageBox.Show("Error al intentar guardar la sección.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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
                Mensaje = Mensaje + "   * No se ha capturado el nombre de la sección.\n";

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
            if (loSeccion == null)
            {
                MessageBox.Show("No se puede borrar una sección que no ha sido guardada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (loSeccion.Ramas.Count > 0)
            {
                MessageBox.Show("No se puede borrar la sección porque tiene ramas capturadas", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("¿Desea borrar la sección?", "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (loSeccion.Borrar())
                    {
                        MessageBox.Show("La sección ha sido borrada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ((CN.iForm)this).Nuevo();
                    }
                    //else
                    //    MessageBox.Show("Error al intentar borrar la sección.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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
            loSeccion = null;

            LlenaGrid();
        }

        void CN.iForm.Buscar()
        {
        }

        void CN.iForm.Imprimir()
        {
        }

        #endregion

        private void frmCatSecciones_Load(object sender, EventArgs e)
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

        private void frmCatSecciones_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void frmCatSecciones_KeyDown(object sender, KeyEventArgs e)
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
                    loSeccion = new CN.Seccion();
                    loSeccion.MensajeError += Evento_MensajeError;
                    if (loSeccion.Obtener(Convert.ToInt32(DataGrid.SelectedRows[0].Cells[0].Value)))
                    {
                        mtbCodigo.Text = loSeccion.Id.ToString();
                        txtNombre.Text = loSeccion.Nombre;
                        this.selesccionado = true;
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

        //private void DataGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        //{
        //    if (e.ColumnIndex == 4) // column of the enum
        //    {
        //        try
        //        {
        //            e.Value = ((CN.EstatusEvento)e.Value).ToString();
        //        }
        //        catch (Exception ex)
        //        {
        //            e.Value = e.Value;
        //        }
        //    }
        //}

        private void Evento_MensajeError(object sender, string mensaje)
        {
            MessageBox.Show(mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

    }
}
