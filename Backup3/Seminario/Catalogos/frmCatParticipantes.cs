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
    public partial class frmCatParticipantes : Form, CN.iForm
    {
        
        CN.Participante Participante = new CN.Participante();
        CN.ParticipanteCol ColParticipante= new CN.ParticipanteCol();
        private DataSet dtsParticip = new DataSet();
        private DataView dvwParticip;
        //Boolean puedorefrescar = true;
        //Boolean Editar = false;
        //Boolean selesccionado = false;
        Dictionary<string, int> lAcept = new Dictionary<string, int>();
        Dictionary<string, int> lEdoCiv = new Dictionary<string, int>();

        //CN.BusquedaClass<CN.Participante> Busqueda = new CN.BusquedaClass<CN.Participante>()

        private SqlDataAdapter DtAdap = new SqlDataAdapter();
        private DataSet dtsGral = new DataSet();
        //private Boolean lbModificado = false;
        private Boolean[] _ToolBarStatus;

        public frmCatParticipantes()
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
            if (Participante == null) Participante = new CN.Participante();

            try
            {
                //Participante.Id = Convert.ToInt32(mtbId.Text);
                Participante.ApellidoPaterno = txtApePaterno.Text;
                Participante.ApellidoMaterno = txtApeMaterno.Text;
                Participante.Nombre = txtNombre.Text;
                Participante.FechaNacim = dtpFecNacim.Value;
                Participante.Aceptado = (CN.AceptadoEnum)cmbAceptado.SelectedValue;
                Participante.NombrePadre = txtNombrePadre.Text;
                Participante.NombreMadre = txtNombreMadre.Text;
                Participante.VivePadre = chkVivePadre.Checked;
                Participante.ViveMadre = chkViveMadre.Checked;
                if (cmbEdoCivilPadres.SelectedIndex==-1)
                    Participante.EdoCivilPadres = CN.EdoCivilEnum.DESCONOCIDO;
                else
                    Participante.EdoCivilPadres = (CN.EdoCivilEnum)cmbEdoCivilPadres.SelectedValue;
                Participante.NumHermanos = (mtbNumHermanos.Text.Trim()=="" ? 0 : Convert.ToInt32(mtbNumHermanos.Text));
                Participante.NumHermanas = (mtbNumHermanas.Text.Trim() == "" ? 0 : Convert.ToInt32(mtbNumHermanas.Text));
                Participante.OrdenNacimiento = (mtbOrdenNacim.Text.Trim() == "" ? 0 : Convert.ToInt32(mtbOrdenNacim.Text));
                Participante.Confirmado = chkConfirmacion.Checked;
                Participante.PrimeraComunion = chkPrimComun.Checked;
                Participante.Deportes = txtDeportes.Text;
                Participante.Instrumentos = txtInstrumentos.Text;

                if (Participante.Guardar())
                {
                    MessageBox.Show("El participante ha sido guardado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ((CN.iForm)this).Nuevo();
                }
                else
                    MessageBox.Show("Error al intentar guardar el participante.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool Validar()
        {
            Boolean Validado = true;
            String Mensaje = "";

            if (mtbId.Text.Trim() == "")
                Mensaje = Mensaje + "   * No se ha capturado el identificador del participante.\n";

            if (txtApeMaterno.Text.Trim() == "")
                Mensaje = Mensaje + "   * No se ha capturado el apellido materno.\n";

            if (txtApePaterno.Text.Trim() == "")
                Mensaje = Mensaje + "   * No se ha capturado el apellido paterno.\n";

            if (txtNombre.Text.Trim() == "")
                Mensaje = Mensaje + "   * No se ha capturado el nombre del participante.\n";

            if (cmbAceptado.SelectedIndex == -1)
                Mensaje = Mensaje + "   * Seleccione si fue aceptado.\n";

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
            if (Participante == null)
            {
                MessageBox.Show("No se puede borrar un participante nuevo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("¿Desea borrar el participante?", "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (Participante.Borrar())
                    {
                        MessageBox.Show("El participante ha sido borrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            mtbId.Text = "";
            txtApePaterno.Text = "";
            txtApeMaterno.Text = "";
            txtNombre.Text = "";
            dtpFecNacim.Value = DateTime.Today;
            cmbAceptado.SelectedIndex = -1;
            txtNombrePadre.Text = "";
            txtNombreMadre.Text = "";
            chkVivePadre.Checked = false;
            chkViveMadre.Checked = false;
            cmbEdoCivilPadres.SelectedIndex = -1;
            mtbNumHermanos.Text = "";
            mtbNumHermanas.Text = "";
            mtbOrdenNacim.Text = "";
            chkConfirmacion.Checked = false;
            chkPrimComun.Checked = false;
            txtDeportes.Text = "";
            txtInstrumentos.Text = "";

            Participante = new CN.Participante();
            
        }

        void CN.iForm.Buscar()
        {


        }

        void CN.iForm.Imprimir()
        {


        }

        #endregion

        private void frmCatParticipantes_Load(object sender, EventArgs e)
        {
            try
            {
                foreach (int enumValue in Enum.GetValues(typeof(CN.AceptadoEnum)))
                    lAcept.Add(Enum.GetName(typeof(CN.AceptadoEnum), enumValue), enumValue);
                
                cmbAceptado.DisplayMember = "Key";
                cmbAceptado.ValueMember = "Value";
                cmbAceptado.DataSource = lAcept.ToList();
                cmbAceptado.SelectedItem = -1;

                foreach (int enumValue in Enum.GetValues(typeof(CN.EdoCivilEnum)))
                    lEdoCiv.Add(Enum.GetName(typeof(CN.EdoCivilEnum), enumValue).Replace("_"," "), enumValue);

                cmbEdoCivilPadres.DisplayMember = "Key";
                cmbEdoCivilPadres.ValueMember = "Value";
                cmbEdoCivilPadres.DataSource = lEdoCiv.ToList();
                cmbEdoCivilPadres.SelectedItem = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            try {

                llenarGrid();
            }
            catch (Exception ex)
            {
            
            }
        }

        private void llenarGrid() {
            String cons = "";
            DtAdap = new SqlDataAdapter();
            cons = "SELECT IdParticipante, " +
                    "REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(UPPER(Nombre), 'Á', 'A'), 'É','E'), 'Í', 'I'), 'Ó', 'O'), 'Ú','U') as Nombre, " +
                    "REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(UPPER(ApellidoPaterno), 'Á', 'A'), 'É','E'), 'Í', 'I'), 'Ó', 'O'), 'Ú','U') as ApellidoPaterno, " +
                    "REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(UPPER(ApellidoMaterno), 'Á', 'A'), 'É','E'), 'Í', 'I'), 'Ó', 'O'), 'Ú','U') as ApellidoMaterno FROM CatParticipantes";
            DtAdap.SelectCommand = new SqlCommand(cons, CN.DBU.Cnn);
            DtAdap.Fill(dtsParticip);
            DtAdap = null;
            //dttParticip = dtsParticip.Tables[0];
            dvwParticip = new DataView(dtsParticip.Tables[0]);
            dgvParticipantes.DataSource = dvwParticip;
        }

        private void frmCatParticipantes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void frmCatParticipantes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void Evento_MensajeError(object sender, string mensaje)
        {
            MessageBox.Show(mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void mtbId_LostFocus(object sender, EventArgs e)
        {
            if (mtbId.Tag != mtbId.Text)
            {
                if (mtbId.Text.Trim() == "")
                {
                    ((CN.iForm)this).Nuevo();
                }
                else
                {
                    int id = int.Parse(mtbId.Text);
                    if (!Participante.Obtener(id))
                    {
                        MessageBox.Show("No existe un participante con ese identificador.");
                        mtbId.Focus();
                        return;
                    }
                    else
                    {
                        txtApePaterno.Text = Participante.ApellidoPaterno;
                        txtApeMaterno.Text = Participante.ApellidoMaterno;
                        txtNombre.Text = Participante.Nombre;
                        dtpFecNacim.Value = Participante.FechaNacim;
                        cmbAceptado.SelectedValue = (int)Participante.Aceptado;
                        if (Participante.Confirmado == null) chkConfirmacion.Checked = false;
                            else chkConfirmacion.Checked = (bool)Participante.Confirmado;
                        if (Participante.PrimeraComunion == null) chkPrimComun.Checked = false;
                            else chkPrimComun.Checked = (bool)Participante.PrimeraComunion;
                        if (Participante.NombrePadre == null) txtNombrePadre.Text = ""; 
                            else txtNombrePadre.Text = Participante.NombrePadre;
                        if (Participante.NombreMadre == null) txtNombreMadre.Text = "";
                            else txtNombreMadre.Text = Participante.NombreMadre;
                        if (Participante.VivePadre == null) chkVivePadre.Checked = false;
                            else chkVivePadre.Checked = (bool)Participante.VivePadre;
                        if (Participante.ViveMadre == null) chkViveMadre.Checked = false;
                            else chkViveMadre.Checked = (bool)Participante.ViveMadre;
                        if (Participante.NumHermanos == null) mtbNumHermanos.Text = "0";
                            else mtbNumHermanos.Text = Participante.NumHermanos.ToString();
                        if (Participante.NumHermanas == null) mtbNumHermanas.Text = "0";
                            else mtbNumHermanas.Text = Participante.NumHermanas.ToString();
                        if (Participante.OrdenNacimiento == null) mtbOrdenNacim.Text = "";
                            else mtbOrdenNacim.Text = Participante.OrdenNacimiento.ToString();
                        if (Participante.EdoCivilPadres == null) cmbEdoCivilPadres.SelectedIndex = -1;
                            else cmbEdoCivilPadres.SelectedValue = (int)Participante.EdoCivilPadres;
                        if (Participante.Deportes == null) txtDeportes.Text = "";
                            else txtDeportes.Text = Participante.Deportes;
                        if (Participante.Instrumentos == null) txtInstrumentos.Text = "";
                        else txtInstrumentos.Text = Participante.Instrumentos;
                    }
                }
            }
        }


        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (this.ActiveControl.Name == "txtNombre")
                FiltraParticipantes();
        }
        private void txtApeMaterno_TextChanged(object sender, EventArgs e)
        {
            if (this.ActiveControl.Name == "txtApeMaterno")
                FiltraParticipantes();
        }

        private void txtApePaterno_TextChanged(object sender, EventArgs e)
        {
            if (this.ActiveControl.Name == "txtApePaterno")
                FiltraParticipantes();
        }

        private void FiltraParticipantes()
        {
            string filtro = "";
            if (txtNombre.Text.Trim() != "")
                filtro = String.Format(" and Nombre Like '%{0}%'", txtNombre.Text.Trim());

            if (txtApePaterno.Text.Trim() != "")
                filtro += String.Format(" and ApellidoPaterno Like '%{0}%'", txtApePaterno.Text.Trim());

            if (txtApeMaterno.Text.Trim() != "")
                filtro += String.Format(" and ApellidoMaterno Like '%{0}%'", txtApeMaterno.Text.Trim());

            if (mtbId.Text.Trim() != "")
                filtro += String.Format(" and IdParticipante Like '%{0}%'", txtApeMaterno.Text.Trim());

 
            if (filtro.Length > 0)
                dvwParticip.RowFilter = filtro.Substring(5, filtro.Length - 5);



            else
                dvwParticip.RowFilter = "";
            dgvParticipantes.Refresh();
        }

        private void dgvParticipantes_DoubleClick(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                if (dgvParticipantes.SelectedRows.Count > 0)
                {
                    Participante = new CN.Participante();
                    Participante.MensajeError += Evento_MensajeError;
                    if (Participante.Obtener(Convert.ToInt32(dgvParticipantes.SelectedRows[0].Cells[0].Value)))
                    {
                        mtbId.Text =  Participante.Id.ToString();
                        txtApePaterno.Text = Participante.ApellidoPaterno;
                        txtApeMaterno.Text = Participante.ApellidoMaterno;
                        txtNombre.Text = Participante.Nombre;
                        dtpFecNacim.Value = Participante.FechaNacim;
                        cmbAceptado.SelectedValue = (int)Participante.Aceptado;
                        if (Participante.Confirmado == null) chkConfirmacion.Checked = false;
                        else chkConfirmacion.Checked = (bool)Participante.Confirmado;
                        if (Participante.PrimeraComunion == null) chkPrimComun.Checked = false;
                        else chkPrimComun.Checked = (bool)Participante.PrimeraComunion;
                        if (Participante.NombrePadre == null) txtNombrePadre.Text = "";
                        else txtNombrePadre.Text = Participante.NombrePadre;
                        if (Participante.NombreMadre == null) txtNombreMadre.Text = "";
                        else txtNombreMadre.Text = Participante.NombreMadre;
                        if (Participante.VivePadre == null) chkVivePadre.Checked = false;
                        else chkVivePadre.Checked = (bool)Participante.VivePadre;
                        if (Participante.ViveMadre == null) chkViveMadre.Checked = false;
                        else chkViveMadre.Checked = (bool)Participante.ViveMadre;
                        if (Participante.NumHermanos == null) mtbNumHermanos.Text = "0";
                        else mtbNumHermanos.Text = Participante.NumHermanos.ToString();
                        if (Participante.NumHermanas == null) mtbNumHermanas.Text = "0";
                        else mtbNumHermanas.Text = Participante.NumHermanas.ToString();
                        if (Participante.OrdenNacimiento == null) mtbOrdenNacim.Text = "";
                        else mtbOrdenNacim.Text = Participante.OrdenNacimiento.ToString();
                        if (Participante.EdoCivilPadres == null) cmbEdoCivilPadres.SelectedIndex = -1;
                        else cmbEdoCivilPadres.SelectedValue = (int)Participante.EdoCivilPadres;
                        if (Participante.Deportes == null) txtDeportes.Text = "";
                        else txtDeportes.Text = Participante.Deportes;
                        if (Participante.Instrumentos == null) txtInstrumentos.Text = "";
                        else txtInstrumentos.Text = Participante.Instrumentos;
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
