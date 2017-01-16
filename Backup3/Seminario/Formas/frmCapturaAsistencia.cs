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
using HC = ORMDiocesis.HelperClasses;
using OC = SD.LLBLGen.Pro.ORMSupportClasses;

namespace ClasesSeminario
{
    public partial class frmCapturaAsistencia : Form, CN.iForm
    {
        private SqlDataAdapter DtAdap = new SqlDataAdapter();
        private DataSet dtsGral = new DataSet();
        private DataSet dtsParroquias = new DataSet();
        private DataSet dtsParrocos = new DataSet();
        private DataSet dtsParticip = new DataSet();
        private DataSet dtsCiudades = new DataSet();
        private DataSet dtsEquipos = new DataSet();
        private DataTable dttParrocos;
        private DataTable dttParticip;
        //private DataView dvwParroquias;
        private DataView dvwParrocos;
        private DataView dvwParticip;
        private Boolean lbModificado = false;
        private Boolean[] _ToolBarStatus;
        private String lsIdEvento, lsNombreEvento;
        private int liCodParticipante = 0;
        private CN.AceptadoEnum liAceptado;

        private CN.EventoCol Eventos;

        OpenFileDialog BuscarImagen = new OpenFileDialog();

        public frmCapturaAsistencia()
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
            {
                return;
            }

            try
            {
                if (CN.DBU.Cnn.State == ConnectionState.Closed)
                    CN.DBU.Cnn.Open();

                SqlCommand _SQLComm = new SqlCommand();
                //SqlDataAdapter _DataAdap;
                //SqlDataReader _Reader;

                _SQLComm.CommandText = "UPIM_SemAsistencia";
                _SQLComm.CommandType = CommandType.StoredProcedure;
                _SQLComm.Connection = CN.DBU.Cnn;

                _SQLComm.Parameters.Add(new SqlParameter("CodParticipante", liCodParticipante));
                _SQLComm.Parameters["CodParticipante"].Direction = ParameterDirection.InputOutput;
                _SQLComm.Parameters.Add(new SqlParameter("ApellidoPaterno", txtApePaterno.Text.ToUpper()));
                _SQLComm.Parameters.Add(new SqlParameter("ApellidoMaterno", txtApeMaterno.Text.ToUpper()));
                _SQLComm.Parameters.Add(new SqlParameter("Nombre", txtNombre.Text.ToUpper()));
                _SQLComm.Parameters.Add(new SqlParameter("FechaNacim", dtpFechaNac.Value));
                _SQLComm.Parameters.Add(new SqlParameter("Aceptado", (int)liAceptado));
                _SQLComm.Parameters.Add(new SqlParameter("IdEvento", lsIdEvento));
                _SQLComm.Parameters.Add(new SqlParameter("Domicilio", txtDomicilio.Text.ToUpper()));
                _SQLComm.Parameters.Add(new SqlParameter("IdCiudad", cmbCiudad.SelectedValue));
                _SQLComm.Parameters.Add(new SqlParameter("Telefono", txtTelefono.Text));
                _SQLComm.Parameters.Add(new SqlParameter("Celular", txtCelular.Text));
                _SQLComm.Parameters.Add(new SqlParameter("RedesSociales", txtFacebook.Text));
                _SQLComm.Parameters.Add(new SqlParameter("GradoEscolar", txtEstudios.Text.ToUpper()));
                _SQLComm.Parameters.Add(new SqlParameter("CodParroqia", cmbParroquia.SelectedValue));
                _SQLComm.Parameters.Add(new SqlParameter("CodSacerdote", cmbParroco.SelectedValue));
                _SQLComm.Parameters.Add(new SqlParameter("IdEquipo", (cmbEquipo.SelectedValue == null ? 0 : cmbEquipo.SelectedValue)));
                _SQLComm.Parameters.Add(new SqlParameter("Seccion", (cmbSeccion.SelectedIndex == -1 ? 0 : cmbSeccion.SelectedValue)));
                _SQLComm.Parameters.Add(new SqlParameter("Observaciones", txtObservaciones.Text.ToUpper()));
                _SQLComm.Parameters.Add(new SqlParameter("eMail", txteMail.Text.ToUpper()));


                MemoryStream ms = new MemoryStream();
                picFoto.Image.Save(ms, picFoto.Image.RawFormat);


                _SQLComm.Parameters.Add(new SqlParameter("Foto", ms.ToArray()));
                _SQLComm.Parameters.Add(new SqlParameter("Error", SqlDbType.Int, 4));
                _SQLComm.Parameters["Error"].Direction = ParameterDirection.Output;
                _SQLComm.Parameters.Add(new SqlParameter("CodRetorno", SqlDbType.Int, 4));
                _SQLComm.Parameters["CodRetorno"].Direction = ParameterDirection.ReturnValue;

                _SQLComm.ExecuteNonQuery();
                if (int.Parse(_SQLComm.Parameters["Error"].Value.ToString()) > 0)
                    throw new Exception("Error al intentar guardar la asistencia");

                ((CN.iForm)this).Nuevo();

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

            if (liAceptado == CN.AceptadoEnum.NO)
            {
                Mensaje = Mensaje + "El participante requiere autorización del sacerdote para ser aceptado.";
                MessageBox.Show(Mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cmbParroco.SelectedIndex == -1)
                Mensaje = Mensaje + "   * Seleccione un párroco de la lista.\n";

            if (cmbParroquia.SelectedIndex == -1)
                Mensaje = Mensaje + "   * Seleccione una parroquia de la lista.\n";

            if (txtNombre.Text == "")
                Mensaje = Mensaje + "   * Capture un nombre para el participante.\n";

            //cmbSeccion.SelectedIndex = -1;
            if (dtpFechaNac.Value ==DateTime.Parse("1900-01-01T00:00:00"))
                Mensaje = Mensaje + "   * Capture la fecha de nacimiento del participante.\n";

            //if (txtDomicilio.Text.Trim() == "")
            //    Mensaje = Mensaje + "   * Capture el domicilio del participante.\n";

            if (cmbCiudad.SelectedIndex == -1)
                Mensaje = Mensaje + "   * Seleccione la ciudad del participante.\n";

            //if (txtTelefono.Text.Trim() == "")
            //    Mensaje = Mensaje + "   * Capture el teléfono del participante.\n";

            //if (txtCelular.Text.Trim() == "")
            //    Mensaje = Mensaje + "   * Capture el celular del participante.\n";

            //if (txtFacebook.Text == "")
            //    Mensaje = Mensaje + "   * Capture el perfil de facebook del participante.\n";

            //if (txtEstudios.Text.Trim() == "")
            //    Mensaje = Mensaje + "   * Capture el nivel de estudios del participante.\n";
            
            //if(cmbEquipo.SelectedIndex == -1)
            //Mensaje = Mensaje + "   * Seleccione un equipo de la lista para el participante.\n";

            if (picFoto.Image==null)
                Mensaje = Mensaje + "   * Agregue la fotografía del participante.\n";

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
        }

        void CN.iForm.Cancelar()
        {
        }

        void CN.iForm.Nuevo()
        {
            liCodParticipante = 0;
            cmbParroco.SelectedIndex = -1;
            cmbParroquia.SelectedIndex = -1;
            txtNombre.Text = "";
            txtApePaterno.Text = "";
            txtApeMaterno.Text = "";
            cmbSeccion.SelectedIndex = -1;
            dtpFechaNac.Value = DateTime.Parse ("1900-01-01T00:00:00");
            txtEdad.Text = "";
            txtDomicilio.Text = "";
            cmbCiudad.SelectedIndex = -1;
            txtTelefono.Text = "";
            txtCelular.Text = "";
            txtFacebook.Text = "";
            txteMail.Text = "";
            txtEstudios.Text = "";
            cmbEquipo.SelectedIndex = -1;
            cmbSeccion.Text= "";
            txtObservaciones.Text = "";
            liAceptado = CN.AceptadoEnum.SI;
            lbModificado = false;
            picFoto.Image= null;

            string cons;
            // inicializa el grid de participantes
            DtAdap = new SqlDataAdapter();
            cons = "SELECT IdParticipante, " +
                    "REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(UPPER(Nombre), 'Á', 'A'), 'É','E'), 'Í', 'I'), 'Ó', 'O'), 'Ú','U') as Nombre, " +
                    "REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(UPPER(ApellidoPaterno), 'Á', 'A'), 'É','E'), 'Í', 'I'), 'Ó', 'O'), 'Ú','U') as ApellidoPaterno, " +
                    "REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(UPPER(ApellidoMaterno), 'Á', 'A'), 'É','E'), 'Í', 'I'), 'Ó', 'O'), 'Ú','U') as ApellidoMaterno, " +
                    "FechaNacim, Aceptado FROM CatParticipantes";
            DtAdap.SelectCommand = new SqlCommand(cons, CN.DBU.Cnn);
            dtsParticip.Tables.Clear();
            DtAdap.Fill(dtsParticip);
            DtAdap = null;
            //dttParticip = dtsParticip.Tables[0];
            dvwParticip = new DataView(dtsParticip.Tables[0]);
            dgvParticipantes.DataSource = dvwParticip;
            cmbParroquia.Focus();

        }

        void CN.iForm.Buscar()
        {
        }

        void CN.iForm.Imprimir()
        {
        }

        #endregion

        private void frmCapturaAsistencia_Load(object sender, EventArgs e)
        {
            try
            {
                BuscarImagen.Filter = "Archivos de Imagen|*.jpg"; //Aquí incluiremos los filtros que queramos.
                BuscarImagen.FileName = "";
                BuscarImagen.Title = "Fotografía";
                BuscarImagen.InitialDirectory = "C:\\";
                BuscarImagen.Multiselect = false;
                String cons = "";

                dtpFechaNac.MaxDate = System.DateTime.Now;
                // inicializa el nombre del evento
                //DtAdap = new SqlDataAdapter();
                //DtAdap.SelectCommand = new SqlCommand("SELECT Idevento, Nombreevento FROM CatEventos Where Estatus='A'", CN.DBU.Cnn);
                //DtAdap.Fill(dtsGral);
                //DtAdap = null;
                //lsIdEvento= (string)dtsGral.Tables[0].Rows[0].ItemArray[0];
                //lsNombreEvento = (string)dtsGral.Tables[0].Rows[0].ItemArray[1];
                //txtEvento.Text = lsIdEvento + " " + lsNombreEvento;
                //dtsGral.Clear();
                Eventos=new CN.EventoCol();
                OC.PredicateExpression filtro = new OC.PredicateExpression();
                filtro.Add(HC.EventoFields.Estatus==(int)CN.EstatusEvento.ACTIVO);
                filtro.AddWithOr(HC.EventoFields.Estatus==(int)CN.EstatusEvento.ENPROCESO);
                Eventos.Obtener(filtro);
                cmbEvento.DisplayMember= "Nombre";
                cmbEvento.ValueMember= "Id";
                cmbEvento.DataSource= Eventos;
                lsIdEvento = (string)cmbEvento.SelectedValue;
                lsNombreEvento = cmbEvento.Text;

                // inicializa el combo y el grid de párrocos
                DtAdap = new SqlDataAdapter();
                cons = "SELECT IdParroquia, IdParroco, Titulo, "+
                        "REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(UPPER(RTrim(NomParroco)+' '+RTrim(ApellParroco)), 'Á', 'A'), 'É','E'), 'Í', 'I'), 'Ó', 'O'), 'Ú','U') as Nombre "+
                        "FROM CatParrocos Order By Nombre";
                DtAdap.SelectCommand = new SqlCommand(cons, CN.DBU.Cnn);
                DtAdap.Fill(dtsParrocos);   
                DtAdap = null;
                cmbParroco.ValueMember = "IdParroco";
                cmbParroco.DisplayMember = "Nombre";
                cmbParroco.DataSource = dtsParrocos.Tables[0];
                cmbParroco.SelectedIndex = -1;

                dttParrocos = dtsParrocos.Tables[0];
                dvwParrocos = new DataView(dttParrocos);
                dgvParrocos.DataSource = dvwParrocos;
                dgvParrocos.Columns[0].Visible = false;
                dgvParrocos.Columns[1].Visible = false;

                // inicializa el combo de parroquias
                DtAdap = new SqlDataAdapter();
                cons = "SELECT Idparroquia, " +
                        "REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(UPPER(Nomparr), 'Á', 'A'), 'É','E'), 'Í', 'I'), 'Ó', 'O'), 'Ú','U') as Nomparr, " +
                        "Idciudad FROM CatParroquias Where Idparroquia>0 Order by Nomparr";
                DtAdap.SelectCommand = new SqlCommand(cons, CN.DBU.Cnn);
                DtAdap.Fill(dtsParroquias);
                DtAdap = null;
                cmbParroquia.ValueMember = "Idparroquia";
                cmbParroquia.DisplayMember = "Nomparr";
                //dvwParroquias = new DataView(dtsParroquias.Tables[0]);
                //cmbParroquia.DataSource = dvwParroquias;
                cmbParroquia.DataSource = dtsParroquias.Tables[0];
                cmbParroquia.SelectedIndex = -1;

                // inicializa el grid de participantes
                DtAdap = new SqlDataAdapter();
                cons = "SELECT CatParticipantes.IdParticipante, " +
                        "REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(UPPER(Nombre), 'Á', 'A'), 'É','E'), 'Í', 'I'), 'Ó', 'O'), 'Ú','U') as Nombre, " +
                        "REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(UPPER(ApellidoPaterno), 'Á', 'A'), 'É','E'), 'Í', 'I'), 'Ó', 'O'), 'Ú','U') as ApellidoPaterno, " +
                        "REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(UPPER(ApellidoMaterno), 'Á', 'A'), 'É','E'), 'Í', 'I'), 'Ó', 'O'), 'Ú','U') as ApellidoMaterno, " +
                        "FechaNacim, Aceptado, "+
                        "REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(UPPER(IdEvento), 'Á', 'A'), 'É','E'), 'Í', 'I'), 'Ó', 'O'), 'Ú','U') as Evento " +
                        "FROM CatParticipantes JOIN SemAsistencia ON CatParticipantes.IdParticipante = SemAsistencia.IdParticipante";
                DtAdap.SelectCommand = new SqlCommand(cons, CN.DBU.Cnn);
                DtAdap.Fill(dtsParticip);
                DtAdap = null;
                //dttParticip = dtsParticip.Tables[0];
         
                dvwParticip = new DataView(dtsParticip.Tables[0]);
                dgvParticipantes.AutoGenerateColumns = false;
                dgvParticipantes.DataSource = dvwParticip;


                //dgvParticipantes.Columns[5].ValueType = typeof(CN.AceptadoEnum);
                //dgvParticipantes.Refresh();

                // inicializa el combo de ciudades
                DtAdap = new SqlDataAdapter();  //
                cons = "SELECT Idciudad, " +
                        "REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(UPPER(Nomciudad), 'Á', 'A'), 'É','E'), 'Í', 'I'), 'Ó', 'O'), 'Ú','U') as Nomciudad " +
                        "FROM CatCiudades Where Idciudad>0 Order by Nomciudad";
                DtAdap.SelectCommand = new SqlCommand(cons, CN.DBU.Cnn);
                DtAdap.Fill(dtsCiudades);
                DtAdap = null;
                cmbCiudad.ValueMember = "Idciudad";
                cmbCiudad.DisplayMember = "Nomciudad";
                //dvwCiudad = new DataView(dtsParroquias.Tables[0]);
                cmbCiudad.DataSource = dtsCiudades.Tables[0];
                cmbCiudad.SelectedIndex = -1;

                // inicializa el combo de equipos
                DtAdap = new SqlDataAdapter();
                DtAdap.SelectCommand = new SqlCommand("SELECT Idequipo, Nombreequipo FROM CatEquiposTrabajo Where Idevento='" +lsIdEvento+ "' Order by Nombreequipo", CN.DBU.Cnn);
                DtAdap.Fill(dtsEquipos);
                DtAdap = null;
                cmbEquipo.ValueMember = "Idequipo";
                cmbEquipo.DisplayMember = "Nombreequipo";
                //dvwCiudad = new DataView(dtsParroquias.Tables[0]);
                cmbEquipo.DataSource = dtsEquipos.Tables[0];
                cmbEquipo.SelectedIndex = -1;

                // inicializa combo de secciones
                //cmbSeccion.DisplayMember = "key";
                //cmbSeccion.ValueMember = "value";
                cmbSeccion.DataSource = Enum.GetValues(typeof(CN.SeccionEventoEnum));
                cmbSeccion.SelectedIndex = -1;

                lbModificado = false;
                this.ActiveControl=cmbParroquia;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (this.ActiveControl.Name == "txtNombre")
                FiltraParticipantes();
        }

        private void txtApePaterno_TextChanged(object sender, EventArgs e)
        {
            if (this.ActiveControl.Name == "txtApePaterno")
                FiltraParticipantes();
        }

        private void txtApeMaterno_TextChanged(object sender, EventArgs e)
        {
            if (this.ActiveControl.Name == "txtApeMaterno")
                FiltraParticipantes();
        }

        private void cmbParroquia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbParroquia.SelectedIndex == -1)
                dvwParrocos.RowFilter = "";
            else
            {
                dvwParrocos.RowFilter = "IdParroquia=" + cmbParroquia.SelectedValue.ToString();
                cmbCiudad.SelectedValue = int.Parse(string.Format("{0}", ((DataRowView)cmbParroquia.SelectedItem).Row.ItemArray[2]));
            }
            dgvParrocos.Refresh();
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

            if (filtro.Length > 0)
                dvwParticip.RowFilter = filtro.Substring(5, filtro.Length - 5);

            else
                dvwParticip.RowFilter = "";
            dgvParticipantes.Refresh();
        }

        private void cmbParroquia_Validating(object sender, CancelEventArgs e)
        {
            if (cmbParroquia.SelectedIndex == -1 && cmbParroquia.Text!="")
                e.Cancel = true;
        }

        private void cmbParroco_Validating(object sender, CancelEventArgs e)
        {
            if (cmbParroco.SelectedIndex == -1 && cmbParroco.Text != "")
                e.Cancel = true;
        }

        private void dgvParrocos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvParrocos.RowCount > e.RowIndex && cmbParroquia.SelectedIndex != -1)
                cmbParroco.SelectedValue = dgvParrocos.CurrentRow.Cells[1].Value;
            txtNombre.Focus();
        }

        private void dgvParticipantes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvParticipantes.RowCount > e.RowIndex) //&& cmbParroquia.SelectedIndex != -1)
            {
                liCodParticipante = (int)dgvParticipantes.Rows[e.RowIndex].Cells[0].Value;
                txtNombre.Text = (string)dgvParticipantes.Rows[e.RowIndex].Cells[1].Value;
                txtApePaterno.Text = (string)dgvParticipantes.Rows[e.RowIndex].Cells[2].Value;
                txtApeMaterno.Text = (string)dgvParticipantes.Rows[e.RowIndex].Cells[3].Value;
                dtpFechaNac.Value= (DateTime)dgvParticipantes.Rows[e.RowIndex].Cells[4].Value;
                liAceptado = (CN.AceptadoEnum)int.Parse(dgvParticipantes.Rows[e.RowIndex].Cells[5].Value.ToString());
                String even = (string)dgvParticipantes.Rows[e.RowIndex].Cells[6].Value;
                if (liAceptado == CN.AceptadoEnum.NO)
                {
                    MessageBox.Show("El participante requiere autorización del sacerdote para ser aceptado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    try
                    {
                        DataSet dtsVerif = new DataSet();
                        // inicializa el nombre del evento
                        String cons = string.Format("SELECT Domicilio,IdCiudad,Telefono,Celular,RedesSociales,eMail,GradoEscolar," +
                                                    "CodParroqia,CodSacerdote,IdEquipo,Seccion,Observaciones,Foto " +
                                                    "FROM SemAsistencia Where IdParticipante={0} and IdEvento='{1}'", liCodParticipante, even);
                        DtAdap = new SqlDataAdapter();
                        DtAdap.SelectCommand = new SqlCommand(cons, CN.DBU.Cnn);
                        DtAdap.Fill(dtsVerif);
                        DtAdap = null;
                        if (dtsVerif.Tables[0].Rows.Count > 0)
                        {
                            //MessageBox.Show("Ya se ha registrado la asistencia de este participante.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            //((CN.iForm)this).Nuevo();
                            
                            txtDomicilio.Text = (string)dtsVerif.Tables[0].Rows[0].ItemArray[0];
                            cmbCiudad.SelectedValue = int.Parse(dtsVerif.Tables[0].Rows[0].ItemArray[1].ToString());
                            txtTelefono.Text = (string)dtsVerif.Tables[0].Rows[0].ItemArray[2];
                            txtCelular.Text = (string)dtsVerif.Tables[0].Rows[0].ItemArray[3];
                            txtFacebook.Text = (string)dtsVerif.Tables[0].Rows[0].ItemArray[4];
                            try
                            {
                                txteMail.Text = (string)dtsVerif.Tables[0].Rows[0].ItemArray[5];
                            }
                            catch (Exception ex) { txteMail.Text ="";}
                            txtEstudios.Text = (string)dtsVerif.Tables[0].Rows[0].ItemArray[6];
                            cmbParroquia.SelectedValue = int.Parse(dtsVerif.Tables[0].Rows[0].ItemArray[7].ToString());
                            cmbParroco.SelectedValue= int.Parse(dtsVerif.Tables[0].Rows[0].ItemArray[8].ToString());
                   
                            int liIdEquipo = int.Parse(dtsVerif.Tables[0].Rows[0].ItemArray[9].ToString());
                            if (liIdEquipo == 0)
                                cmbEquipo.SelectedIndex = -1;
                            else
                                cmbEquipo.SelectedValue = liIdEquipo;
                         
                            if (dtsVerif.Tables[0].Rows[0].ItemArray[10] == System.DBNull.Value)
                                cmbSeccion.SelectedIndex = -1;
                            else
                            cmbSeccion.SelectedItem = Enum.Parse(typeof(CN.SeccionEventoEnum),dtsVerif.Tables[0].Rows[0].ItemArray[10].ToString());
                            txtObservaciones.Text = (string)dtsVerif.Tables[0].Rows[0].ItemArray[11];
                            try
                            {
                                byte[] img = (byte[])dtsVerif.Tables[0].Rows[0].ItemArray[12];
                                MemoryStream ms = new MemoryStream(img);
                                picFoto.Image = Image.FromStream(ms);
                            }
                            catch (Exception ex) { picFoto.Image = null;}
                        }
                        dtsVerif.Dispose();
                        txtDomicilio.Focus();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void btnBuscarFoto_Click(object sender, EventArgs e)
        {
            if (BuscarImagen.ShowDialog() == DialogResult.OK)
            {       /// Si esto se cumple, capturamos la propiedad File Name y la guardamos en el control
                picFoto.ImageLocation = BuscarImagen.FileName;
                picFoto.SizeMode = PictureBoxSizeMode.StretchImage;
                BuscarImagen.InitialDirectory = BuscarImagen.FileName.Substring(0, BuscarImagen.FileName.Length-BuscarImagen.SafeFileName.Length);
                BuscarImagen.FileName = "";
            }
        }

        private void dtpFechaNac_ValueChanged(object sender, EventArgs e)
        {
            if (dtpFechaNac.Value == DateTime.Parse("1900-01-01T00:00:00"))
                txtEdad.Text = "";
            else
            {
                DateTime Ahora = DateTime.Now;
                txtEdad.Text = (Ahora.Year - dtpFechaNac.Value.Year - (Ahora.DayOfYear >= dtpFechaNac.Value.DayOfYear ? 0 : 1)).ToString();
            }
        }

        private void frmCapturaAsistencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void frmCapturaAsistencia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void cmbEvento_SelectedIndexChanged(object sender, EventArgs e)
        {
            lsIdEvento = (string)cmbEvento.SelectedValue;
            lsNombreEvento = cmbEvento.Text;
            cmbParroquia.Focus();
        }
        
    }
}
