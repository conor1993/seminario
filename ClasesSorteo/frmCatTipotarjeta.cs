using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using CN = ClasesNegocio;



namespace ClasesSorteo
{
    public partial class frmCatTipotarjeta : Form, CN.iForm
    {

        DataSet dtsPar;
        DataView dvwParr;
        SqlDataAdapter DtAdap;

        public frmCatTipotarjeta()
        {
            InitializeComponent();
        }

        private void frmCatTipotarjeta_Load(object sender, EventArgs e)
        {
            llenarGrid();
        }

        private void llenarGrid()
        {

            String cons = "";
            DtAdap = new SqlDataAdapter();
            dtsPar = new DataSet();

            cons = "select * from SortCatTipotarjeta";
            DtAdap.SelectCommand = new SqlCommand(cons, CN.DBU.Cnn);
            DtAdap.Fill(dtsPar);
            DtAdap = null;
            dvwParr = new DataView(dtsPar.Tables[0]);
            dgvtarjetas.DataSource = dvwParr;
            
        }

        public bool[] ToolBarStatus
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
               
            }
        }

        public void Guardar()
        {
            if (!validar())
                return;


            int id;

            try
            {
                if (CN.DBU.Cnn.State == ConnectionState.Closed)
                    CN.DBU.Cnn.Open();

                SqlCommand _SQLComm = new SqlCommand();

                _SQLComm.CommandText = "GuardarTipoTrajeta";
                _SQLComm.CommandType = CommandType.StoredProcedure;
                _SQLComm.Connection = CN.DBU.Cnn;

                try
                {
                    id = Convert.ToInt32(mtbCodigo.Text);
                }
                catch (Exception ex)
                {
                    id = 0;
                }

                String nombre = txtNombre.Text;

                _SQLComm.Parameters.Add(new SqlParameter("id", id));
                _SQLComm.Parameters.Add(new SqlParameter("nombreEquipo", nombre));


                _SQLComm.ExecuteNonQuery();
                llenarGrid();
                limpiar();
                CN.DBU.Cnn.Close();

                MessageBox.Show("Se guardo con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ((CN.iForm)this).Nuevo();

            }
            catch (Exception ex)
            {

            }
        }

        public void Imprimir()
        {
           
        }

        public void Nuevo()
        {
           
        }

        public void Cancelar()
        {
           
        }

        public void Borrar()
        {
           
        }

        public void Buscar()
        {
           
        }

        public bool validar()
        {
            bool validado = true;
            String mensage = "";


            if (txtNombre.Text.Trim() == "")
            {

                mensage = mensage + "    * No se ha capturado el nombre.\n";
            }

            if (mensage != "")
            {
                validado = false;
                mensage = "Antes de guardar debe corregir lo siguiente:\n\n" + mensage;
                MessageBox.Show(mensage, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return validado;
        }

        public void limpiar()
        {
            mtbCodigo.Text = "";
            txtNombre.Text = "";

        }

        private void dgvtarjetas_DoubleClick(object sender, EventArgs e)
        {
            if (dgvtarjetas.SelectedRows.Count > 0)
            {
                DtAdap = new SqlDataAdapter();
                DataSet dtseqp = new DataSet();


                String id = dgvtarjetas.SelectedRows[0].Cells[0].Value.ToString();
                String cons = "select * from SortCatTipotarjeta where id = " + id;
                DtAdap.SelectCommand = new SqlCommand(cons, CN.DBU.Cnn);


                DtAdap.Fill(dtseqp);
                DtAdap = null;
                mtbCodigo.Text = dtseqp.Tables[0].Rows[0].ItemArray[0].ToString();
                txtNombre.Text = dtseqp.Tables[0].Rows[0].ItemArray[1].ToString();


            }
        }
    }
}
