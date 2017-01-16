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
using OC = SD.LLBLGen.Pro.ORMSupportClasses;
using CN = ClasesNegocio;
using EC = ORMDiocesis.EntityClasses;
using CC = ORMDiocesis.CollectionClasses;
using HC = ORMDiocesis.HelperClasses;

namespace ClasesBiblioteca
{
    public partial class frmCatTematicas : Form, CN.iForm
    {        
        CN.Tematica loTematica;
        CN.TematicaCol loColTematicas= new CN.TematicaCol();
        CN.SeccionCol loColSecciones = new CN.SeccionCol();
        CN.RamaCol loColRamas = new CN.RamaCol();

        Boolean puedorefrescar = true;
        Boolean Editar = false;
        Boolean selesccionado = false;
        Dictionary<string, int> list = new Dictionary<string, int>();

        private SqlDataAdapter DtAdap = new SqlDataAdapter();
        private DataSet dtsGral = new DataSet();
        private Boolean lbModificado = false;
        private Boolean[] _ToolBarStatus;

        public frmCatTematicas()
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
            if (loTematica == null) loTematica = new CN.Tematica();

            try
            {
                loTematica.Nombre = txtNombre.Text;
        

                if (loTematica.Guardar())
                {
                    MessageBox.Show("La temática ha sido guardado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ((CN.iForm)this).Nuevo();
                }
                else
                    MessageBox.Show("Error al intentar guardar la temática.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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
                Mensaje = Mensaje + "   * No se ha capturado el nombre de la temática.\n";

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
            if (loTematica == null)
            {
                MessageBox.Show("No se puede borrar una temática que no ha sido guardada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            if (MessageBox.Show("¿Desea borrar la temática?", "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (loTematica.Borrar())
                    {
                        MessageBox.Show("La temática ha sido borrada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ((CN.iForm)this).Nuevo();
                    }
                    //else
                    //    MessageBox.Show("Error al intentar borrar el evento.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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
            loTematica = null;

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
            loColTematicas.Clear();
            if (loColTematicas.Obtener() > 0)
            {
                DataGrid.AutoGenerateColumns = false;
                DataGrid.DataSource = loColTematicas;
            }
        }

        private void DataGrid_DoubleClick(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                if (DataGrid.SelectedRows.Count > 0)
                {
                    loTematica = new CN.Tematica();
                    loTematica.MensajeError += Evento_MensajeError;
                    if (loTematica.Obtener(Convert.ToInt32(DataGrid.SelectedRows[0].Cells[0].Value)))
                    {
                        mtbCodigo.Text = loTematica.Id.ToString();
                        txtNombre.Text = loTematica.Nombre;
   
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

        private void Evento_MensajeError(object sender, string mensaje)
        {
            MessageBox.Show(mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void DataGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 2)
                    e.Value = ((CN.Seccion)e.Value).Nombre;
                if (e.ColumnIndex == 3)
                    e.Value = ((CN.Rama)e.Value).Nombre;
            }
            catch (Exception ex)
            {
                e.Value = e.Value;
            }
        }



    }
}
