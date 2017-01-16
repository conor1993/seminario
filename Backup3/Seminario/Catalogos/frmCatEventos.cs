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

namespace ClasesSeminario
{
    public partial class frmCatEventos : Form, CN.iForm
    {
        
        CN.Evento Evento;
        CN.EventoCol ColEventos= new CN.EventoCol();
        Boolean puedorefrescar = true;
        Boolean Editar = false;
        Boolean selesccionado = false;
        Dictionary<string, int> list = new Dictionary<string, int>();

        //CN.BusquedaClass<CN.Evento> Busqueda = new CN.BusquedaClass<CN.Evento>()

        private SqlDataAdapter DtAdap = new SqlDataAdapter();
        private DataSet dtsGral = new DataSet();
        private Boolean lbModificado = false;
        private Boolean[] _ToolBarStatus;
        private String lsIdEvento, lsNombreEvento;
        private CN.AceptadoEnum liAceptado;

        public frmCatEventos()
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
            if (Evento == null) Evento = new CN.Evento();

            try
            {
                Evento.Id = txtCodigo.Text;
                Evento.Año = dtpFecIni.Value.Year;
                Evento.FechaInicio = dtpFecIni.Value;
                Evento.FechaFin = dtpFecFin.Value;
                Evento.Nombre = txtDescripcion.Text;
                Evento.Seccion = chkSeccion.Checked;
                Evento.Estatus = (int)cmbEstatus.SelectedValue;
                Evento.Lugar = txtLugar.Text;

                if (Evento.Guardar())
                {
                    MessageBox.Show("El evento ha sido guardado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ((CN.iForm)this).Nuevo();
                }
                else
                    MessageBox.Show("Error al intentar guardar el evento.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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

            if (txtCodigo.Text.Trim() == "")
                Mensaje = Mensaje + "   * No se ha capturado el identificador del evento.\n";

            if (txtDescripcion.Text.Trim() == "")
                Mensaje = Mensaje + "   * No se ha capturado el nombre del evento.\n";

            if (dtpFecFin.Value<dtpFecIni.Value)
                Mensaje = Mensaje + "   * La fecha inicial es posterior a la fecha final.\n";

            if (cmbEstatus.SelectedIndex == -1)
                Mensaje = Mensaje + "   * Seleccione el estatus del evento.\n";

            if (txtLugar.Text.Trim() == "")
                Mensaje = Mensaje + "   * Capture el lugar donde se lleva a cabo el evento.\n";

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
            if (Evento == null)
            {
                MessageBox.Show("No se puede borrar un evento nuevo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("¿Desea borrar el evento?", "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Evento.Estatus = (int)CN.EstatusEvento.INACTIVO;
                try
                {
                    if (Evento.Borrar())
                    {
                        MessageBox.Show("El evento ha sido borrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            txtCodigo.Text = "";
            txtDescripcion.Text = "";
            dtpFecIni.Value = DateTime.Now.Date;
            dtpFecFin.Value = DateTime.Now.Date;
            cmbEstatus.SelectedItem = -1;
            txtLugar.Text = "";
            chkSeccion.Checked = false;
            Evento = null;

            LlenaGrid();
        }

        void CN.iForm.Buscar()
        {
        }

        void CN.iForm.Imprimir()
        {
        }

        #endregion

        private void frmCatEventos_Load(object sender, EventArgs e)
        {
            try
            {
                foreach (int enumValue in Enum.GetValues(typeof(CN.EstatusEvento)))
                    list.Add(Enum.GetName(typeof(CN.EstatusEvento), enumValue), enumValue);
                //var column = ((DataGridViewComboBoxColumn)dgv.Columns["studentCourseStatus"]);
                //column.DataPropertyName = "StudentStatus";
                cmbEstatus.DisplayMember = "Key";
                cmbEstatus.ValueMember = "Value";
                cmbEstatus.DataSource = list.ToList();
                cmbEstatus.SelectedItem = -1;
                //cmbEstatus.DataSource = Enum.GetValues(typeof(CN.EstatusEvento));
                LlenaGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void frmCatEventos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void frmCatEventos_KeyDown(object sender, KeyEventArgs e)
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
            ColEventos.Clear();
            if (ColEventos.Obtener() > 0)
            {
                DataGrid.AutoGenerateColumns = false;
                DataGrid.DataSource = ColEventos;
            }
        }

        private void DataGrid_DoubleClick(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                if (DataGrid.SelectedRows.Count > 0)
                {
                    Evento = new CN.Evento();
                    Evento.MensajeError += Evento_MensajeError;
                    if (Evento.Obtener(DataGrid.SelectedRows[0].Cells[0].Value.ToString()))
                    {
                        txtCodigo.Text = Evento.Id;
                        txtDescripcion.Text = Evento.Nombre;
                        dtpFecIni.Value = Evento.FechaInicio;
                        dtpFecFin.Value = Evento.FechaFin;
                        cmbEstatus.SelectedValue = Evento.Estatus;
                        txtLugar.Text = Evento.Lugar;
                        chkSeccion.Checked = (bool)Evento.Seccion;
                        cmbEstatus.SelectedValue = Evento.Estatus;
                        //MEAToolBar1.sbCambiarEstadoBotones("Buscar");
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

        private void DataGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 4) // column of the enum
            {
                try
                {
                    e.Value = ((CN.EstatusEvento)e.Value).ToString();
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
