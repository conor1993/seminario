﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CN = ClasesNegocio;
using System.Data.SqlClient;
using System.Globalization;


namespace ClasesSorteo
{
    public partial class frmBienechores : Form, CN.iForm
    {
        DataSet dtsPar2;
        DataView dvwParr;
        SqlDataAdapter DtAdap;

        DataSet dtsPar;
        public frmBienechores()
        {
            InitializeComponent();
        }

        //memtodos interfaz grafica
        private void frmBienechores_Load(object sender, EventArgs e)
        {   
            
            gpxAportacion.Location = new Point(12, 270);
            gpxAportacion.Size = new System.Drawing.Size(854, 100);
            dgvBienechores.Location = new Point(18, 400);

            llenarcombos();
            llenargrid();

        }


   




        //metodos basicos abc
        #region iForm Members

        bool[] CN.iForm.ToolBarStatus
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
               
            }
        }

        void CN.iForm.Guardar()
        {
            if(!validarDatos())
                return;
             

            //-------------------------------------------obtener datos ----------------------------------------------------------------
            int idbn; 
            try { idbn = Convert.ToInt32(txtid.Text); }catch(Exception ex){idbn=0;}
            String contrato = txtContrato.Text.Trim();
            String nombre = txtNombre.Text;
            String apellidop = txtapellidoPaterno.Text;
            String apellidom = txtapellidoMaterno.Text;
            int equipoo = (int)cmbequipo.SelectedValue;
            System.DateTime fecha = dtmcumple.Value;
            bool estatus = rdtestatussi.Checked;
            String dom = txtdomicilio.Text.Trim();
            long telefono;
            long celular = Convert.ToInt64(txtClular.Text);
            String email = txtemail.Text.Trim();
            int programa = (int)cmbPrograma.SelectedValue;
            int cuentac = (int)cmbCuentacobro.SelectedValue;
            int tipopago = (int)cmbTipopago.SelectedValue;
            int cantidad = 0;
            try { cantidad = Convert.ToInt32(txtOtracantidad.Text.Trim());}
            catch (Exception ex)
            {

            }
            //tarjeta
            int idbanco = 0;
            int idTipotarjeta = 0;
            long notarjeta = 0;
            System.DateTime Fechaexpiracion = dtmExpiracion.Value;
            int Codigoseguridad = 0;
            String Clave = "";

            if (cmbTipopago.Text.Equals("TARJETA"))
            {
                idbanco = (int)cmbBanco.SelectedValue;
                idTipotarjeta = (int)cmbtarjeta.SelectedValue;
                notarjeta = Convert.ToInt64(txtNotarjeta.Text);
                Codigoseguridad = Convert.ToInt32(txtcodseguridad.Text);
                Clave = txtclave.Text;
            }
            //recivo impuesto
            String razonsocial = "";
            String rfc = "";
            String domrec = "";
            long telrec = 0;
            if (rdtsi.Checked) {

                 razonsocial = txtrazonSocial.Text;
                rfc = txtrfc.Text;
                domrec = txtdomicilioFiscal.Text;
                telrec = Convert.ToInt64(txttelefonoimpuesto.Text);
            }



            //store procedure--------------------------------------------------------------------------------------------------
            try
            {
                if (CN.DBU.Cnn.State == ConnectionState.Closed)
                    CN.DBU.Cnn.Open();

                SqlCommand _SQLComm = new SqlCommand();

                _SQLComm.CommandText = "SortGuardarBienechores";
                _SQLComm.CommandType = CommandType.StoredProcedure;
                _SQLComm.Connection = CN.DBU.Cnn;

                //bienechores
                _SQLComm.Parameters.Add(new SqlParameter("id", idbn));
                _SQLComm.Parameters.Add(new SqlParameter("contrato", contrato));
                _SQLComm.Parameters.Add(new SqlParameter("nombre", nombre));
                _SQLComm.Parameters.Add(new SqlParameter("apellidoPaterno", apellidop));
                _SQLComm.Parameters.Add(new SqlParameter("apellidoMaterno", apellidom));
                _SQLComm.Parameters.Add(new SqlParameter("equipo", equipoo));
                _SQLComm.Parameters.Add(new SqlParameter("cumpleaños", fecha));
                _SQLComm.Parameters.Add(new SqlParameter("estatus", estatus));
                _SQLComm.Parameters.Add(new SqlParameter("domicilio", dom));

                try { _SQLComm.Parameters.Add(new SqlParameter("telefono", Convert.ToInt64(txtTelefono.Text))); }
                catch (Exception ex) { _SQLComm.Parameters.Add(new SqlParameter("telefono", DBNull.Value)); }

                _SQLComm.Parameters.Add(new SqlParameter("celular", celular));
                _SQLComm.Parameters.Add(new SqlParameter("email", email));
                _SQLComm.Parameters.Add(new SqlParameter("programa", programa));
                _SQLComm.Parameters.Add(new SqlParameter("cuentac", cuentac));
                _SQLComm.Parameters.Add(new SqlParameter("tipopago", tipopago));
                _SQLComm.Parameters.Add(new SqlParameter("cantidad", cantidad));
                //tarjeta
                _SQLComm.Parameters.Add(new SqlParameter("IdBanco", idbanco));
                _SQLComm.Parameters.Add(new SqlParameter("idTipotarjeta", idTipotarjeta));
                _SQLComm.Parameters.Add(new SqlParameter("Notarjeta", notarjeta));
                _SQLComm.Parameters.Add(new SqlParameter("Fechaexpiracion", Fechaexpiracion));
                _SQLComm.Parameters.Add(new SqlParameter("Codigoseguridad", Codigoseguridad));
                _SQLComm.Parameters.Add(new SqlParameter("Clave", Clave));
                //recivo
                _SQLComm.Parameters.Add(new SqlParameter("Razonsocial", razonsocial));
                _SQLComm.Parameters.Add(new SqlParameter("Rfc", rfc));
                _SQLComm.Parameters.Add(new SqlParameter("DomicilioFiscal", domrec));
                _SQLComm.Parameters.Add(new SqlParameter("Telefonofiscal", telrec));


                _SQLComm.Parameters.Add(new SqlParameter("msg", SqlDbType.VarChar, 100));
                _SQLComm.Parameters["msg"].Direction = ParameterDirection.Output;

                _SQLComm.ExecuteNonQuery();

                CN.DBU.Cnn.Close();
                limpiar();
                llenargrid();
                MessageBox.Show(_SQLComm.Parameters["msg"].Value.ToString(), "Aviso error", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Errors.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show(ex.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }




        }

        void CN.iForm.Imprimir()
        {
           
        }

        void CN.iForm.Nuevo()
        {
            limpiar();
        }

        void CN.iForm.Cancelar()
        {
           
        }

        void CN.iForm.Borrar()
        {
           
        }

        void CN.iForm.Buscar()
        {
           
        }

        private bool validarDatos()
        {
            String mensaje = "";
            bool valido = true;

            if (txtContrato.Text.Trim() == "")
            {
                mensaje = mensaje + "    * No se ha capturado el contrato.\n";
            }

            if (txtNombre.Text.Trim() == "") {
                mensaje = mensaje+ "    * No se ha capturado el nombre.\n"; 
            }
            if (txtapellidoPaterno.Text.Trim() == "") {
                mensaje = mensaje + "    * No se ha capturado el apellido paterno.\n"; 
            }
            if (txtapellidoMaterno.Text.Trim() == "")
            {
                mensaje = mensaje + "    * No se ha capturado el apellido materno.\n";
            }

            if (cmbequipo.SelectedIndex == -1) {
                mensaje = mensaje + "    * No se ha capturado el equipo.\n";
            }

            if (txtdomicilio.Text.Trim() == "")
            {
                mensaje = mensaje + "    * No se ha capturado el domicilio.\n";
            }

            if (txtClular.Text.Trim() == "")
            {
                mensaje = mensaje + "    * No se ha capturado el celular.\n";
            }


            if (txtemail.Text.Trim() == "")
            {
                mensaje = mensaje + "    * No se ha capturado el email.\n";
            }

            if (cmbPrograma.SelectedIndex == -1)
            {
                mensaje = mensaje + "    * No se ha capturado el programa.\n";
            }

            if (cmbCuentacobro.SelectedIndex == -1)
            {
                mensaje = mensaje + "    * No se ha capturado la cuenta de cobro.\n";
            }
            if (cmbTipopago.SelectedIndex == -1)
            {
                mensaje = mensaje + "    * No se ha capturado el tipo de pago.\n";
            }

            if (txtOtracantidad.Text.Trim() == "")
            {
                mensaje = mensaje + "    * No se ha capturado la cantidad.\n";
            }

            if (rdtsi.Checked)
            {
                if (txtrazonSocial.Text.Trim() == "")
                {
                    mensaje = mensaje + "    * No se ha capturado la razon social.\n";
                }
                if (txtdomicilioFiscal.Text.Trim() == "")
                {
                    mensaje = mensaje + "    * No se ha capturado el domicilio fiscal.\n";
                }
                if (txtrfc.Text.Trim() == "")
                {
                    mensaje = mensaje + "    * No se ha capturado el rfc.\n";
                }
                if (txttelefonoimpuesto.Text.Trim() == "")
                {
                    mensaje = mensaje + "    * No se ha capturado el telefono.\n";
                }
            }

            if (cmbTipopago.Text.Equals("TARJETA"))
            {
                if (cmbBanco.SelectedIndex == -1)
                {
                    mensaje = mensaje + "    * No se ha capturado el banco.\n";
                }
                if (cmbtarjeta.SelectedIndex == -1)
                {
                    mensaje = mensaje + "    * No se ha capturado el tipo de tarjeta.\n";
                }
                if (txtNotarjeta.Text.Trim() == "")
                {
                    mensaje = mensaje + "    * No se ha capturado el numero de tarjeta.\n";
                }
                if (txtclave.Text.Trim() == "")
                {
                    mensaje = mensaje + "    * No se ha capturado la clave.\n";
                }
                if (txtcodseguridad.Text.Trim() == "")
                {
                    mensaje = mensaje + "    * No se ha capturado el codigo de seguridad.\n";
                }
            }

            if (!mensaje.Equals("")) {

                valido = false;
                mensaje = "Antes de guardar debe corregir lo siguiente:\n\n" + mensaje;
                MessageBox.Show(mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            return valido;
        }

        private void limpiar() {
         
            //datos
            txtid.Text = "";
            txtContrato.Text = "";
            txtNombre.Text = "";
            txtapellidoMaterno.Text = "";
            txtapellidoPaterno.Text = "";
            txtemail.Text = "";
            txtclave.Text = "";
            txtClular.Text = "";
            txtcodseguridad.Text = "";
            txtdomicilio.Text = "";
            txtdomicilioFiscal.Text = "";
            txtemail.Text = "";
            txtNotarjeta.Text = "";
            txtOtracantidad.Text = "";
            txtrazonSocial.Text = "";
            txtrfc.Text = "";
            txtTelefono.Text = "";
            txttelefonoimpuesto.Text = "";
            cmbTipopago.SelectedValue = 0;
            cmbtarjeta.SelectedValue = 0;
            cmbCuentacobro.SelectedValue = 0;
            cmbPrograma.SelectedValue = 0;
            cmbequipo.SelectedValue = 0;
            cmbBanco.SelectedValue = 0;
            rdtno.Checked=true;

           
           
        }

        #endregion

        //eventos
        private void cmbTipopago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipopago.Text.Equals("TARJETA"))
            {
                gpxTarjeta.Visible = true;
                gpxAportacion.Size = new System.Drawing.Size(854, 271);
                if (rdtno.Checked) { dgvBienechores.Location = new Point(18, 550); }
                if (rdtsi.Checked) { dgvBienechores.Location = new Point(18, 645); }
            }

            if (cmbTipopago.Text.Equals("EFECTIVO"))
            {
                gpxTarjeta.Visible = false;
                gpxAportacion.Size = new System.Drawing.Size(854, 100);
                if (rdtno.Checked) { dgvBienechores.Location = new Point(18, 400); }

                if (rdtsi.Checked) { dgvBienechores.Location = new Point(18, 500); }

            }

            if (cmbTipopago.Text.Equals("TRANSFERENCIA") || (int)cmbTipopago.SelectedValue == 0)
            {
                gpxTarjeta.Visible = false;
                gpxAportacion.Size = new System.Drawing.Size(854, 100);
                if (rdtno.Checked) { dgvBienechores.Location = new Point(18, 400); }

                if (rdtsi.Checked) { dgvBienechores.Location = new Point(18, 500); }
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtClular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void txttelefonoimpuesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtOtracantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }

        }

        private void txtNotarjeta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void dgvBienechores_DoubleClick(object sender, EventArgs e)
        {
            if (dgvBienechores.SelectedRows.Count > 0)
            {
               
               
                traerdatosBienechores(Convert.ToInt32(dgvBienechores.SelectedRows[0].Cells[0].Value.ToString()));
                
            }
        }

        private void rdtsi_CheckedChanged(object sender, EventArgs e)
        {
            if (rdtsi.Checked)
            {
                gpxRecibos.Visible = true;
                gpxAportacion.Location = new Point(12, 370);
                if (cmbTipopago.Text.Equals("TARJETA")) { dgvBienechores.Location = new Point(18, 645); }
                if (!cmbTipopago.Text.Equals("TARJETA")) { dgvBienechores.Location = new Point(18, 500); }

            }
        }

        private void rdtno_CheckedChanged(object sender, EventArgs e)
        {
            if (rdtno.Checked)
            {
                gpxRecibos.Visible = false;
                gpxAportacion.Location = new Point(12, 271);
                if (cmbTipopago.Text.Equals("TARJETA")) { dgvBienechores.Location = new Point(18, 550); }
                if (!cmbTipopago.Text.Equals("TARJETA")) { dgvBienechores.Location = new Point(18, 400); }

            }
        }

        private void rdtsi_Click(object sender, EventArgs e)
        {
            gpxRecibos.Visible = true;
            gpxAportacion.Location = new Point(12, 370);
            if (cmbTipopago.Text.Equals("TARJETA")) { dgvBienechores.Location = new Point(18, 645); }
            if (!cmbTipopago.Text.Equals("TARJETA")) { dgvBienechores.Location = new Point(18, 500); }


        }

        private void rdtno_Click(object sender, EventArgs e)
        {

            gpxRecibos.Visible = false;
            gpxAportacion.Location = new Point(12, 271);
            if (cmbTipopago.Text.Equals("TARJETA")) { dgvBienechores.Location = new Point(18, 550); }
            if (!cmbTipopago.Text.Equals("TARJETA")) { dgvBienechores.Location = new Point(18, 400); }
        }
  

 

        // metodos del sistema

        private void llenarcombos()
        {
            try
            {
                if (CN.DBU.Cnn.State == ConnectionState.Closed)
                    CN.DBU.Cnn.Open();

                String cons = "";
                DtAdap = new SqlDataAdapter();
                dtsPar = new DataSet();
                cons = "SELECT [Id] ,[Nombre] FROM [dbo].[SortCatEquipos]  union SELECT 0,'Seleccione una opción'";
                DtAdap.SelectCommand = new SqlCommand(cons, CN.DBU.Cnn);
                DtAdap.Fill(dtsPar);
                DtAdap = null;
                cmbequipo.DisplayMember = "Nombre";
                cmbequipo.ValueMember = "Id";
                cmbequipo.DataSource = dtsPar.Tables[0].DefaultView;
                cmbequipo.SelectedIndex = -1;
                cmbPrograma.Text = "Seleccione una opción";
                dtsPar = null;

                CN.DBU.Cnn.Close();

            }
            catch (Exception ex)
            {

            }


            try
            {
                if (CN.DBU.Cnn.State == ConnectionState.Closed)
                    CN.DBU.Cnn.Open();

                String cons = "";
                DtAdap = new SqlDataAdapter();
                dtsPar = new DataSet();
                cons = "SELECT [Id] ,[Nombre] FROM [dbo].[SortCatProgramas]  union SELECT 0,'Seleccione una opción'";
                DtAdap.SelectCommand = new SqlCommand(cons, CN.DBU.Cnn);
                DtAdap.Fill(dtsPar);
                DtAdap = null;
                cmbPrograma.DisplayMember = "Nombre";
                cmbPrograma.ValueMember = "Id";
                cmbPrograma.DataSource = dtsPar.Tables[0].DefaultView;
                cmbPrograma.SelectedIndex = -1;
                cmbPrograma.Text = "Seleccione una opción";
                dtsPar = null;

                CN.DBU.Cnn.Close();

            }
            catch (Exception ex)
            {

            }


            try
            {
                if (CN.DBU.Cnn.State == ConnectionState.Closed)
                    CN.DBU.Cnn.Open();

                String cons = "";
                DtAdap = new SqlDataAdapter();
                dtsPar = new DataSet();
                cons = "SELECT [Id] ,[Nombre] FROM [dbo].[SortCatTipopago]  union SELECT 0,'Seleccione una opción'";
                DtAdap.SelectCommand = new SqlCommand(cons, CN.DBU.Cnn);
                DtAdap.Fill(dtsPar);
                DtAdap = null;
                cmbTipopago.DisplayMember = "Nombre";
                cmbTipopago.ValueMember = "Id";
                cmbTipopago.DataSource = dtsPar.Tables[0].DefaultView;
                cmbTipopago.SelectedIndex = -1;
                cmbTipopago.Text = "Seleccione una opción";
                dtsPar = null;

                CN.DBU.Cnn.Close();

            }
            catch (Exception ex)
            {

            }


            try
            {
                if (CN.DBU.Cnn.State == ConnectionState.Closed)
                    CN.DBU.Cnn.Open();

                String cons = "";
                DtAdap = new SqlDataAdapter();
                dtsPar = new DataSet();
                cons = "SELECT [Id] ,[Nombre] FROM [dbo].[SortCatCuentacobro]  union SELECT 0,'Seleccione una opción'";
                DtAdap.SelectCommand = new SqlCommand(cons, CN.DBU.Cnn);
                DtAdap.Fill(dtsPar);
                DtAdap = null;
                cmbCuentacobro.DisplayMember = "Nombre";
                cmbCuentacobro.ValueMember = "Id";
                cmbCuentacobro.DataSource = dtsPar.Tables[0].DefaultView;
                cmbCuentacobro.SelectedIndex = -1;
                cmbCuentacobro.Text = "Seleccione una opción";
                dtsPar = null;

                CN.DBU.Cnn.Close();

            }
            catch (Exception ex)
            {

            }

            try
            {
                if (CN.DBU.Cnn.State == ConnectionState.Closed)
                    CN.DBU.Cnn.Open();

                String cons = "";
                DtAdap = new SqlDataAdapter();
                dtsPar = new DataSet();
                cons = "SELECT [Id] ,[Nombre] FROM [dbo].[SortCatBancos]  union SELECT 0,'Seleccione una opción'";
                DtAdap.SelectCommand = new SqlCommand(cons, CN.DBU.Cnn);
                DtAdap.Fill(dtsPar);
                DtAdap = null;
                cmbBanco.DisplayMember = "Nombre";
                cmbBanco.ValueMember = "Id";
                cmbBanco.DataSource = dtsPar.Tables[0].DefaultView;
                cmbBanco.SelectedIndex = -1;
                cmbBanco.Text = "Seleccione una opción";
                dtsPar = null;

                CN.DBU.Cnn.Close();

            }
            catch (Exception ex)
            {

            }

            try
            {
                if (CN.DBU.Cnn.State == ConnectionState.Closed)
                    CN.DBU.Cnn.Open();

                String cons = "";
                DtAdap = new SqlDataAdapter();
                dtsPar = new DataSet();
                cons = "SELECT [Id] ,[Nombre] FROM [dbo].[SortCatTipotarjeta] union SELECT 0,'Seleccione una opción'";
                DtAdap.SelectCommand = new SqlCommand(cons, CN.DBU.Cnn);
                DtAdap.Fill(dtsPar);
                DtAdap = null;
                cmbtarjeta.DisplayMember = "Nombre";
                cmbtarjeta.ValueMember = "Id";
                cmbtarjeta.DataSource = dtsPar.Tables[0].DefaultView;
                cmbtarjeta.SelectedIndex = -1;
                cmbtarjeta.Text = "Seleccione una opción";
                dtsPar = null;

                CN.DBU.Cnn.Close();

            }
            catch (Exception ex)
            {

            }
        }

        private void llenargrid() {

                String cons = "";

                DtAdap = new SqlDataAdapter();
                cons = "select id, Contrato as Referencia , Nombre, ApellidoPaterno+' '+ApellidoMaterno as Apellido from SortCatBienechores where Estatus = 1 ";
                DtAdap.SelectCommand = new SqlCommand(cons, CN.DBU.Cnn);
                dtsPar = new DataSet();
                dtsPar.Tables.Clear();
                DtAdap.Fill(dtsPar);
                DtAdap = null;
                dgvBienechores.AutoGenerateColumns = false;
                dvwParr = new DataView(dtsPar.Tables[0]);
                dgvBienechores.DataSource = dvwParr;
   

        }

        private void traerdatosBienechores(int id)
        {

            DtAdap = new SqlDataAdapter();
            DataSet dtseqp = new DataSet();

            try
            {
                if (CN.DBU.Cnn.State == ConnectionState.Closed)
                    CN.DBU.Cnn.Open();

                String cons ="select  * from SortCatBienechores as bnc "
                                +"left join SortCatTarjetas  as trj   on bnc.id = trj.IdBienechor "
                                +"left join SortCatRecivoImpuesto as rec on rec.IdBienechor = bnc.id where bnc.id= "+id;

                
                DtAdap.SelectCommand = new SqlCommand(cons, CN.DBU.Cnn);
                DtAdap.Fill(dtseqp);
                DtAdap = null;

                limpiar();
                //datos de bienechores
                txtid.Text = dtseqp.Tables[0].Rows[0].ItemArray[0].ToString();
                txtContrato.Text = dtseqp.Tables[0].Rows[0].ItemArray[1].ToString();
                txtNombre.Text = dtseqp.Tables[0].Rows[0].ItemArray[2].ToString();
                txtapellidoPaterno.Text = dtseqp.Tables[0].Rows[0].ItemArray[3].ToString();
                txtapellidoMaterno.Text = dtseqp.Tables[0].Rows[0].ItemArray[4].ToString();
                cmbequipo.SelectedValue = dtseqp.Tables[0].Rows[0].ItemArray[5];
                dtmcumple.Value = (System.DateTime)dtseqp.Tables[0].Rows[0].ItemArray[6];
                txtdomicilio.Text = dtseqp.Tables[0].Rows[0].ItemArray[7].ToString();
                txtTelefono.Text = dtseqp.Tables[0].Rows[0].ItemArray[8].ToString();
                txtClular.Text = dtseqp.Tables[0].Rows[0].ItemArray[9].ToString();                    
                cmbPrograma.SelectedValue = dtseqp.Tables[0].Rows[0].ItemArray[11];
                cmbTipopago.SelectedValue = dtseqp.Tables[0].Rows[0].ItemArray[12];
                cmbCuentacobro.SelectedValue = dtseqp.Tables[0].Rows[0].ItemArray[13];
                txtemail.Text = dtseqp.Tables[0].Rows[0].ItemArray[14].ToString();
                txtOtracantidad.Text = Convert.ToDouble(dtseqp.Tables[0].Rows[0].ItemArray[15]).ToString();
                //tarjeta
                if (DBNull.Value != dtseqp.Tables[0].Rows[0].ItemArray[17]) {
                  cmbBanco.SelectedValue=dtseqp.Tables[0].Rows[0].ItemArray[18];
                  cmbtarjeta.SelectedValue = dtseqp.Tables[0].Rows[0].ItemArray[19];
                  txtNotarjeta.Text = dtseqp.Tables[0].Rows[0].ItemArray[20].ToString();
                  dtmExpiracion.Value=(System.DateTime)dtseqp.Tables[0].Rows[0].ItemArray[21];
                  txtcodseguridad.Text = dtseqp.Tables[0].Rows[0].ItemArray[22].ToString();
                  txtclave.Text = dtseqp.Tables[0].Rows[0].ItemArray[23].ToString();

                }
                if (DBNull.Value != dtseqp.Tables[0].Rows[0].ItemArray[24])
                {
                    rdtsi.Checked=true;
                    txtrazonSocial.Text = dtseqp.Tables[0].Rows[0].ItemArray[25].ToString();
                    txtrfc.Text = dtseqp.Tables[0].Rows[0].ItemArray[26].ToString();
                    txtdomicilioFiscal.Text = dtseqp.Tables[0].Rows[0].ItemArray[27].ToString();
                    txttelefonoimpuesto.Text = dtseqp.Tables[0].Rows[0].ItemArray[28].ToString();
                }

                CN.DBU.Cnn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void txtcodseguridad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }










    }
}
