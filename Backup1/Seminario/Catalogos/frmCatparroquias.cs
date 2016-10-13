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
    public partial class frmCatparroquias : Form, CN.iForm
    {
        CN.Parroquia Parroquia;
        private SqlDataAdapter DtAdap = new SqlDataAdapter();
        private DataSet dtsZonas = new DataSet();
        private DataSet dtsCiudad = new DataSet();
        private DataSet dtsTparroquia = new DataSet();

        public frmCatparroquias()
        {
            InitializeComponent();
        }



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
            if (!validar())
                return;

            if (Parroquia == null) Parroquia = new CN.Parroquia();

            try
            {


                Parroquia.Id                = Convert.ToInt32(txtCodigo.Text);
                Parroquia.IdTipoParroquia   = (byte)cmbTipoParroquia.SelectedValue;
                Parroquia.Nombre            = txtNobre.Text;
                Parroquia.IdZonaPastoral    = (byte)cmbZonapastoral.SelectedValue;
                Parroquia.IdCiudad          = (byte)cmbCiudad.SelectedValue;
                Parroquia.Tel1              = txtTelofono.Text;
                Parroquia.Tel2              = txtTelefono2.Text;
                Parroquia.Telcural          = txtTelCura.Text;
                Parroquia.Fax               = txtFax.Text;
                Parroquia.EmailComunidad    = txtEmail.Text;
                Parroquia.Calle             = txtCalle.Text; 
                Parroquia.NoExt             = txtNumero.Text;
                Parroquia.Colonia           = txtColonia.Text;
                Parroquia.Cp                =txtCp.Text;
                Parroquia.ApartadoPostal    =txtApartadoP.Text;

                if (Parroquia.Guardar())
                {
                    MessageBox.Show("La parrquia ha sido guardada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ((CN.iForm)this).Nuevo();
                }
                else
                    MessageBox.Show("Error al intentar guardar la parroquia.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex) {
               
            }
       }

        void CN.iForm.Imprimir()
        {
            throw new NotImplementedException();
        }

        void CN.iForm.Nuevo()
        {
            txtCodigo.Text="";
            txtNobre.Text = "";
            cmbTipoParroquia.SelectedValue=0;
            txtNobre.Text="";
            cmbZonapastoral.SelectedValue=0;
            cmbCiudad.SelectedValue=0;
            txtTelofono.Text="";
            txtTelefono2.Text="";
            txtTelCura.Text = ""; 
            txtFax.Text = ""; 
            txtEmail.Text = ""; 
            txtCalle.Text = ""; 
            txtNumero.Text = ""; 
            txtColonia.Text = ""; 
            txtCp.Text = ""; 
            txtApartadoP.Text = ""; 
            Parroquia = null;
        }

        void CN.iForm.Cancelar()
        {
            throw new NotImplementedException();
        }

        void CN.iForm.Borrar()
        {


            try
            {
                if (CN.DBU.Cnn.State == ConnectionState.Closed)
                    CN.DBU.Cnn.Open();

                SqlCommand _SQLComm = new SqlCommand();

                _SQLComm.CommandText = "BorrarParroquia";
                _SQLComm.CommandType = CommandType.StoredProcedure;
                _SQLComm.Connection = CN.DBU.Cnn;

                int id = Convert.ToInt32(txtCodigo.Text);

                _SQLComm.Parameters.Add(new SqlParameter("id", id));

                _SQLComm.Parameters.Add(new SqlParameter("Error", SqlDbType.Int, 4));
                _SQLComm.Parameters["Error"].Direction = ParameterDirection.Output;

                _SQLComm.Parameters.Add(new SqlParameter("borro", SqlDbType.Int, 4));
                _SQLComm.Parameters["borro"].Direction = ParameterDirection.Output;

                _SQLComm.ExecuteNonQuery();

                CN.DBU.Cnn.Close();

                if (int.Parse(_SQLComm.Parameters["borro"].Value.ToString()) > 0)
                    throw new Exception("No se puede borrar.");

                MessageBox.Show("La parroquia ha sido borrada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
              

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        void CN.iForm.Buscar()
        {
            Parroquia = new CN.Parroquia();
            Parroquia.MensajeError += Evento_MensajeError;

            if (txtCodigo.Text.Trim() != "")
            {
                int Codigo = Convert.ToInt32(txtCodigo.Text);

                if (Parroquia.Obtener(Codigo))
                {
                    txtNobre.Text = Parroquia.Nombre;
                    cmbTipoParroquia.SelectedValue = Parroquia.IdTipoParroquia;
                    cmbZonapastoral.SelectedValue = Parroquia.IdZonaPastoral;
                    cmbCiudad.SelectedValue = Parroquia.IdCiudad;
                    txtTelofono.Text = Parroquia.Tel1;
                    txtTelefono2.Text = Parroquia.Tel2;
                    txtTelCura.Text = Parroquia.Telcural;
                    txtFax.Text = Parroquia.Fax;
                    txtEmail.Text = Parroquia.EmailComunidad;
                    txtCalle.Text = Parroquia.Calle;
                    txtNumero.Text = Parroquia.NoExt;
                    txtColonia.Text = Parroquia.Colonia;
                    txtCp.Text = Parroquia.Cp;
                    txtApartadoP.Text = Parroquia.ApartadoPostal;

                }
            }
            else {
                MessageBox.Show("No se ha capturado el código.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
                 
        }

        private void frmCatparroquias_Load(object sender, EventArgs e)
        {
            LlennarCombos();
        }

        private void Evento_MensajeError(object sender, string mensaje)
        {
            MessageBox.Show(mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public void LlennarCombos(){
            //combo de zona pastoral
            DtAdap = new SqlDataAdapter();
            DtAdap.SelectCommand = new SqlCommand("SELECT Idzonapastoral,Nomzonapastoral FROM CatZonaPastoral where Idzonapastoral<>0", CN.DBU.Cnn);
            DtAdap.Fill(dtsZonas);
            DtAdap.Dispose();
            dtsZonas.Tables[0].Rows.Add(0, "TODOS");
            cmbZonapastoral.ValueMember = "Idzonapastoral";
            cmbZonapastoral.DisplayMember = "Nomzonapastoral";
            cmbZonapastoral.DataSource = dtsZonas.Tables[0];
            cmbZonapastoral.SelectedValue = 0;
            //combo de ciudad
            DtAdap = new SqlDataAdapter();
            DtAdap.SelectCommand = new SqlCommand("select Idciudad as ciudad,Nomciudad as nombre from CatCiudades  where Idciudad <> 0", CN.DBU.Cnn);
            DtAdap.Fill(dtsCiudad);
            DtAdap.Dispose();
            dtsCiudad.Tables[0].Rows.Add(0, "TODOS");
            cmbCiudad.ValueMember = "ciudad";
            cmbCiudad.DisplayMember = "nombre";
            cmbCiudad.DataSource = dtsCiudad.Tables[0];
            cmbCiudad.SelectedValue = 0;
            //combo de tipo de parroquias
            DtAdap = new SqlDataAdapter();
            DtAdap.SelectCommand = new SqlCommand("select Idtipoparr as id, Desctipoparr as nombre from CatTipoParroquia where Idtipoparr <> 0", CN.DBU.Cnn);
            DtAdap.Fill(dtsTparroquia);
            DtAdap.Dispose();
            dtsTparroquia.Tables[0].Rows.Add(0, "TODOS");
            cmbTipoParroquia.ValueMember = "id";
            cmbTipoParroquia.DisplayMember = "nombre";
            cmbTipoParroquia.DataSource = dtsTparroquia.Tables[0];
            cmbTipoParroquia.SelectedValue = 0;

        }

        public bool validar() {
            Boolean Validado = true;
            String Mensaje = "";


            if (txtCodigo.Text.Trim() == "")
                Mensaje = Mensaje + "   * No se ha capturado el código.\n";


            if (txtNobre.Text.Trim() == "")
                Mensaje = Mensaje + "   * No se ha capturado el nombre.\n";

            if (cmbCiudad.SelectedIndex == -1)
                Mensaje = Mensaje + "   * No se ha capturado la ciudad.\n";

            if (cmbTipoParroquia.SelectedIndex == -1)
                Mensaje = Mensaje + "   * No se ha cel tipo de parroquia.\n";

            if (cmbZonapastoral.SelectedIndex == -1)
                Mensaje = Mensaje + "   * No se ha capturado la zona pastoral.\n";



            if (Mensaje != "")
            {
                Validado = false;
                Mensaje = "Antes de guardar debe corregir lo siguiente:\n\n" + Mensaje;
                MessageBox.Show(Mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return Validado;
        
       }
    }
}
