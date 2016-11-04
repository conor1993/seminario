using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CN = ClasesNegocio;
using System.Data.SqlClient;

namespace ClasesSorteo
{
    public partial class frmBienechores : Form, CN.iForm
    {

        SqlDataAdapter DtAdap;
        DataSet dtsPar;
        public frmBienechores()
        {
            InitializeComponent();
        }

        private void frmBienechores_Load(object sender, EventArgs e)
        {
            gpxAportacion.Location = new Point(12, 218);
            gpxAportacion.Size = new System.Drawing.Size(854, 100);
            llenarCombos();
        }

        private void radtarjeta_Click(object sender, EventArgs e)
        {
            gpxTarjeta.Visible = true;
            gpxAportacion.Size = new System.Drawing.Size(854, 271);
        }

        private void rdtefectivo_Click(object sender, EventArgs e)
        {
            gpxTarjeta.Visible = false;
            gpxAportacion.Size = new System.Drawing.Size(854, 100);
        }

        private void rdtrans_Click(object sender, EventArgs e)
        {
            gpxTarjeta.Visible = false;
            gpxAportacion.Size = new System.Drawing.Size(854, 100);
        }

        private void rdtsi_Click(object sender, EventArgs e)
        {
            gpxRecibos.Visible = true;
            gpxAportacion.Location = new Point(12, 331);
        }

        private void rdtno_Click(object sender, EventArgs e)
        {
            gpxRecibos.Visible = false;
            gpxAportacion.Location = new Point(12, 218);
        }

        private void llenarCombos()
        {
            try
            {
                if (CN.DBU.Cnn.State == ConnectionState.Closed)
                    CN.DBU.Cnn.Open();

                    String cons = "";
                    DtAdap = new SqlDataAdapter();
                    dtsPar = new DataSet();
                    cons = "SELECT [id] ,[NombreEquipio] FROM [dbo].[CatEquipo]";
                    DtAdap.SelectCommand = new SqlCommand(cons, CN.DBU.Cnn);
                    DtAdap.Fill(dtsPar);
                    DtAdap = null;
                    cmbequipo.DisplayMember = "NombreEquipio";
                    cmbequipo.ValueMember = "id";
                    cmbequipo.DataSource = dtsPar.Tables[0].DefaultView;
                    cmbequipo.SelectedIndex = -1;
                    cmbequipo.Text = "Seleccione una opción";
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
                cons = "select * from sortcatbancos";
                DtAdap.SelectCommand = new SqlCommand(cons, CN.DBU.Cnn);
                DtAdap.Fill(dtsPar);
                DtAdap = null;
                cmbBanco.DisplayMember = "nombre";
                cmbBanco.ValueMember = "id";
                cmbBanco.DataSource = dtsPar.Tables[0].DefaultView;
                cmbBanco.SelectedIndex = -1;
                cmbBanco.Text = "Seleccione una opción";
                dtsPar = null;

                CN.DBU.Cnn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                if (CN.DBU.Cnn.State == ConnectionState.Closed)
                    CN.DBU.Cnn.Open();

                String cons = "";
                DtAdap = new SqlDataAdapter();
                dtsPar = new DataSet();
                cons = "select * from sortcattarjeta";
                DtAdap.SelectCommand = new SqlCommand(cons, CN.DBU.Cnn);
                DtAdap.Fill(dtsPar);
                DtAdap = null;
                cmbtarjeta.DisplayMember = "nombre";
                cmbtarjeta.ValueMember = "id";
                cmbtarjeta.DataSource = dtsPar.Tables[0].DefaultView;
                cmbtarjeta.SelectedIndex = -1;
                cmbtarjeta.Text = "Seleccione una opción";
                dtsPar = null;

                CN.DBU.Cnn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        #region iForm Members

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
            if (!validarDatos())
                return;

            //obtener datos ----------------------------------------------------------------
            String nombre     = txtNombre.Text;
            String apellidop  = txtapellidoPaterno.Text;
            String apellidom  = txtapellidoMaterno.Text;
            int equipoo = (int)cmbequipo.SelectedValue;
            System.DateTime fecha = dtmcumple.Value;
            String dom = txtdomicilio.Text;
            int telefono = Convert.ToInt32(txtTelefono.Text);
            int celular = Convert.ToInt32(txtClular.Text);
            String email = txtemail.Text;
            int recibo = 0;
            if (rdtsi.Checked) { recibo =1; }

            //recibo deducible ----------------------------------------------------------
            String razonsocial = "";
            String domfiscal = "";
            String rfc = "";
            int telefonofiscal =0;

            if (rdtsi.Checked) {
             razonsocial = txtrazonSocial.Text;
             domfiscal = txtdomicilioFiscal.Text;
             rfc = txtrfc.Text;
             telefonofiscal = Convert.ToInt32(txtTelefono.Text);
            }
            //----------------------------------------------------------------------------
            //datos aportacion mensual----------------------------------------------------
            int aportacion=0;
            try{
            aportacion = Convert.ToInt32(txtOtracantidad.Text);
            }catch{

            }
            if (rdtaportacion1000.Checked) { aportacion = 1000; }
            if (rdtaportacion1500.Checked) { aportacion = 1500; }
            if (rdtAportacion2000.Checked) { aportacion = 2000; }
            if (rdtaportacion500.Checked) { aportacion =  500; }

            int tarjeta = 0;
            int banco = 0;
            int notarjeta = 0;
            System.DateTime exp = dtmExpiracion.Value;
            String codseg = "";
            String clave = "";


            if (radtarjeta.Checked) {
                tarjeta = Convert.ToInt32(cmbtarjeta.SelectedValue);
                banco = Convert.ToInt32(cmbBanco.SelectedValue);
                notarjeta = Convert.ToInt32(txtNotarjeta.Text);
                codseg = txtcodseguridad.Text;
                clave = txtclave.Text ;

            }

            //sp guardar bienechores--------------------------------------------------------

            try
            {
                if (CN.DBU.Cnn.State == ConnectionState.Closed)
                    CN.DBU.Cnn.Open();

                SqlCommand _SQLComm = new SqlCommand();

                _SQLComm.CommandText = "SortGuardarBienechores";
                _SQLComm.CommandType = CommandType.StoredProcedure;
                _SQLComm.Connection = CN.DBU.Cnn;



                _SQLComm.Parameters.Add(new SqlParameter("nombre", nombre));
                _SQLComm.Parameters.Add(new SqlParameter("apellidoPaterno", apellidop));
                _SQLComm.Parameters.Add(new SqlParameter("apellidoMaterno", apellidom));
                _SQLComm.Parameters.Add(new SqlParameter("equipo", equipoo));
                _SQLComm.Parameters.Add(new SqlParameter("cumpleaños", fecha));
                _SQLComm.Parameters.Add(new SqlParameter("domicilio", dom));
                _SQLComm.Parameters.Add(new SqlParameter("telefono", telefono));
                _SQLComm.Parameters.Add(new SqlParameter("celular", celular));
                _SQLComm.Parameters.Add(new SqlParameter("recibo", recibo));

                if (rdtsi.Checked)
                {
                    _SQLComm.Parameters.Add(new SqlParameter("razonSocial", razonsocial));
                    _SQLComm.Parameters.Add(new SqlParameter("domicilio2", domfiscal));
                    _SQLComm.Parameters.Add(new SqlParameter("rfc", rfc));
                    _SQLComm.Parameters.Add(new SqlParameter("telefono2", telefonofiscal));
                }
                else {
                    _SQLComm.Parameters.Add(new SqlParameter("razonSocial", DBNull.Value));
                    _SQLComm.Parameters.Add(new SqlParameter("domicilio2", DBNull.Value));
                    _SQLComm.Parameters.Add(new SqlParameter("rfc", DBNull.Value));
                    _SQLComm.Parameters.Add(new SqlParameter("telefono2", DBNull.Value));
                
                }

                _SQLComm.Parameters.Add(new SqlParameter("aportacion", aportacion));

                if (radtarjeta.Checked)
                {
                    _SQLComm.Parameters.Add(new SqlParameter("tarjeta", tarjeta));
                    _SQLComm.Parameters.Add(new SqlParameter("banco", banco));
                    _SQLComm.Parameters.Add(new SqlParameter("notarjeta", notarjeta));
                    _SQLComm.Parameters.Add(new SqlParameter("fechaexpiracion", exp));
                    _SQLComm.Parameters.Add(new SqlParameter("codseguridad", codseg));
                    _SQLComm.Parameters.Add(new SqlParameter("clave", clave));


                }
                                   
                else {

                    _SQLComm.Parameters.Add(new SqlParameter("tarjeta", DBNull.Value));
                    _SQLComm.Parameters.Add(new SqlParameter("banco", DBNull.Value));
                    _SQLComm.Parameters.Add(new SqlParameter("notarjeta", DBNull.Value));
                    _SQLComm.Parameters.Add(new SqlParameter("fechaexpiracion", DBNull.Value));
                    _SQLComm.Parameters.Add(new SqlParameter("codseguridad", DBNull.Value));
                    _SQLComm.Parameters.Add(new SqlParameter("clave", DBNull.Value));
         
                
                }

                _SQLComm.Parameters.Add(new SqlParameter("msg", SqlDbType.VarChar,100));
                _SQLComm.Parameters["msg"].Direction = ParameterDirection.Output;

                _SQLComm.ExecuteNonQuery();

                CN.DBU.Cnn.Close();

                MessageBox.Show(_SQLComm.Parameters["msg"].Value.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }


        void CN.iForm.Imprimir()
        {
            throw new NotImplementedException();
        }

        void CN.iForm.Nuevo()
        {
            throw new NotImplementedException();
        }

        void CN.iForm.Cancelar()
        {
            throw new NotImplementedException();
        }

        void CN.iForm.Borrar()
        {
            throw new NotImplementedException();
        }

        void CN.iForm.Buscar()
        {
            throw new NotImplementedException();
        }

        private bool validarDatos()
        {
            String mensaje = "";
            bool valido = true;

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
                    mensaje = mensaje + "    * No se ha capturado el telefono .\n";
                }
            }

            if (radtarjeta.AutoCheck) {
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
                    mensaje = mensaje + "    * No se ha capturado el numero de tarjeta .\n";
                }
                if (txtclave.Text.Trim() == "")
                {
                    mensaje = mensaje + "    * No se ha capturado la clave .\n";
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


        #endregion

    }
}
