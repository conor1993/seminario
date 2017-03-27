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
using System.Collections;

namespace ClasesSorteo
{
    public partial class frmRptCobrotarjetasrechazadas : Form, CN.iForm
    {

        String fechin = "";
        String fechci = "";
        System.DateTime fechacorte;
        DataSet dtsPar2;
        DataView dvwParr;
        SqlDataAdapter DtAdap;
        DataSet dtsPar;

        public frmRptCobrotarjetasrechazadas()
        {
            InitializeComponent();
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
            
        }

        public void Imprimir()
        {
            recorrertabla();
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

        private void frmRptCobrotarjetasrechazadas_Load(object sender, EventArgs e)
        {
            dgvbienechores.AutoGenerateColumns = false;
            llenarcombos();
            llenargrid();
        }

        private void llenarcombos()
        {


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

        private void llenargrid()
        {

            fechacorte = dtmdonaciones.Value;


            fechin = fechacorte.Year.ToString() + "-" + fechacorte.Month.ToString() + "-" + "15";
            fechci = fechacorte.Year.ToString() + "-" + fechacorte.AddMonths(1).Month.ToString() + "-" + "14";


            dgvbienechores.DataSource = null;
            String cons = "";

            DtAdap = new SqlDataAdapter();
            cons = "select Nombre+' '+ApellidoPaterno+' '+ApellidoMaterno as Nombre,Notarjeta,CantidadDonacion,Contrato "
                    +"from SortTarjetasRechazadas as trj "
                    +"join SortCatBienechores bn on trj.idbienechor = bn.id "
                    +"join SortCatTarjetas trjcre on trjcre.IdBienechor = bn.id "
                    + "where trj.Fecha BETWEEN '" + fechin + "' and '" + fechci + "'  and bn.Estatus = 1 ";

            DtAdap.SelectCommand = new SqlCommand(cons, CN.DBU.Cnn);
            dtsPar = new DataSet();
            dtsPar.Tables.Clear();
            DtAdap.Fill(dtsPar);
            DtAdap = null;
            //dgvbienechores.AutoGenerateColumns = false;
            dvwParr = new DataView(dtsPar.Tables[0]);
            dgvbienechores.DataSource = dvwParr;



        }

        private void llenargridcuentacobrofiltro(int p)
        {
            fechacorte = dtmdonaciones.Value;


            fechin = fechacorte.Year.ToString() + "-" + fechacorte.Month.ToString() + "-" + "15";
            fechci = fechacorte.Year.ToString() + "-" + fechacorte.AddMonths(1).Month.ToString() + "-" + "14";

            dgvbienechores.DataSource = null;
            String cons = "";

            DtAdap = new SqlDataAdapter();
            cons = "select Nombre+' '+ApellidoPaterno+' '+ApellidoMaterno as Nombre,Notarjeta,CantidadDonacion,Contrato "
                    + "from SortTarjetasRechazadas as trj "
                    + "join SortCatBienechores bn on trj.idbienechor = bn.id "
                    + "join SortCatTarjetas trjcre on trjcre.IdBienechor = bn.id "
                    + "where trj.Fecha BETWEEN '" + fechin + "' and '" + fechci + "'  and bn.Estatus = 1 and bn.IdCuentacobro= "+p;

            DtAdap.SelectCommand = new SqlCommand(cons, CN.DBU.Cnn);
            dtsPar = new DataSet();
            dtsPar.Tables.Clear();
            DtAdap.Fill(dtsPar);
            DtAdap = null;
            //dgvbienechores.AutoGenerateColumns = false;
            dvwParr = new DataView(dtsPar.Tables[0]);
            dgvbienechores.DataSource = dvwParr;
        }

        private void dtmdonaciones_ValueChanged(object sender, EventArgs e)
        {
            llenargrid();
        }

        private void cmbCuentacobro_SelectionChangeCommitted(object sender, EventArgs e)
        {
            llenargridcuentacobrofiltro((int)cmbCuentacobro.SelectedValue);
            cmbtarjeta.SelectedIndex = 0;
        }

        private void llenargridtarjetafiltro(int p, int c)
        {

            fechacorte = dtmdonaciones.Value;


            fechin = fechacorte.Year.ToString() + "-" + fechacorte.Month.ToString() + "-" + "15";
            fechci = fechacorte.Year.ToString() + "-" + fechacorte.AddMonths(1).Month.ToString() + "-" + "14";

            dgvbienechores.DataSource = null;
            String cons = "";

            DtAdap = new SqlDataAdapter();

            cons = "select Nombre+' '+ApellidoPaterno+' '+ApellidoMaterno as Nombre,Notarjeta,CantidadDonacion,Contrato "
                    + "from SortTarjetasRechazadas as trj "
                    + "join SortCatBienechores bn on trj.idbienechor = bn.id "
                    + "join SortCatTarjetas trjcre on trjcre.IdBienechor = bn.id "
                    + "where trj.Fecha BETWEEN '" + fechin + "' and '" + fechci + "'  and bn.Estatus = 1 and bn.IdCuentacobro= " + c +" and idTipotarjeta = "+p;

            DtAdap.SelectCommand = new SqlCommand(cons, CN.DBU.Cnn);
            dtsPar = new DataSet();
            dtsPar.Tables.Clear();
            DtAdap.Fill(dtsPar);
            DtAdap = null;
            //dgvbienechores.AutoGenerateColumns = false;
            dvwParr = new DataView(dtsPar.Tables[0]);
            dgvbienechores.DataSource = dvwParr;
        }

        private void recorrertabla()
        {
            String cad;
            ArrayList datosCobro = new ArrayList();
            foreach (DataGridViewRow row in dgvbienechores.Rows)
            {

                cad = row.Cells["clmNombre"].Value.ToString() + "  " + row.Cells["clmNotarjeta"].Value.ToString() + " " + Convert.ToDecimal(row.Cells["clmCantidadDonacion"].Value).ToString("N2") + "          " + row.Cells["clmContrato"].Value.ToString();
                datosCobro.Add(cad);

            }

            creararchivoTexto(datosCobro);
        }

        private void creararchivoTexto(ArrayList datosCobro)
        {
            String ruta = "";
            try
            {
                ruta = obtenerruta();
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(ruta))
                {
                    foreach (string line in datosCobro)
                    {
                        if (!line.Contains("Second"))
                        {
                            file.WriteLine(line);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener la ruta");
            }


        }

        private String obtenerruta()
        {
            String ruta = "";
            SaveFileDialog saveRuta = new SaveFileDialog();
            saveRuta.InitialDirectory = @"C:\";
            DateTime thisDay = DateTime.Today;
            saveRuta.Filter = "archivo de texto (.txt)|*.txt";
            saveRuta.Title = "guardando archivo de texto";
            saveRuta.FileName = "reporte de cobro-.txt";
            if (saveRuta.ShowDialog() == DialogResult.OK)
            {
                if (!saveRuta.FileName.Equals(""))
                {
                    ruta = saveRuta.FileName;
                }
            }

            return ruta;
        }

        private void cmbtarjeta_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenargridtarjetafiltro((int)cmbtarjeta.SelectedValue, (int)cmbCuentacobro.SelectedValue);
        }



    }
}
