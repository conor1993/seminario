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
using r = ClasesSorteo.Reportes;
using ClasesNegocio;

namespace ClasesSorteo
{
    public partial class frmRpttarjetasRechazadas : Form, CN.iForm
    {
        String cons = "";
        String fechin = "";
        String fechci = "";

        DataView dvwParr;
        SqlDataAdapter DtAdap;
        DataSet dtsPar;

        DataSet dtsReporte = new DataSet();

        System.DateTime fechacorte;
        String fech;
        int diacorte;

        public frmRpttarjetasRechazadas()
        {
            InitializeComponent();
        }

        private void frmRpttarjetasRechazadas_Load(object sender, EventArgs e)
        {
            llenargrid();
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
            imprimirReporte();
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


        private void llenargrid()
        {


            fechacorte = dtmrechazadas.Value;

          
                fechin = fechacorte.Year.ToString() + "-" + fechacorte.Month.ToString() + "-" + "15";
                fechci = fechacorte.Year.ToString() + "-" + fechacorte.AddMonths(1).Month.ToString() + "-" + "14";

                cons = "select bn. Nombre ,bn.ApellidoPaterno,bn.ApellidoMaterno,  cut.Nombre as cuenta ,trj.Estatus , trj.Descripcion, bn.Contrato "
                        + "from SortTarjetasRechazadas as trj "
                        + "join SortCatBienechores bn on trj.idbienechor = bn.id "
                        + "join SortCatCuentacobro as cut on cut.Id = bn.IdCuentacobro where trj.Fecha BETWEEN '" + fechin + "' and '" + fechci + "'";




            DtAdap = new SqlDataAdapter();
            DtAdap.SelectCommand = new SqlCommand(cons, CN.DBU.Cnn);
            dtsPar = new DataSet();
            dtsPar.Tables.Clear();
            DtAdap.Fill(dtsPar);
            DtAdap = null;
            gridrechazadas.AutoGenerateColumns = false;
            dvwParr = new DataView(dtsPar.Tables[0]);
            gridrechazadas.DataSource = dvwParr;

        }

        private void dtmcumple_ValueChanged(object sender, EventArgs e)
        {

           
            try
            {
                llenargrid();
            }catch(Exception ex){
                MessageBox.Show(ex.Message);
            }
        }

        private void imprimirReporte()
        {
            fechacorte = dtmrechazadas.Value;

            fechin = fechacorte.Year.ToString() + "-" + fechacorte.Month.ToString() + "-" + "15";
            fechci = fechacorte.Year.ToString() + "-" + fechacorte.AddMonths(1).Month.ToString() + "-" + "14";

            SqlCommand cmd = new SqlCommand("exec ListaTarjetasRechazadas '"+fechin+"' , '"+fechci+"'", CN.DBU.Cnn);

            cmd.CommandTimeout = 450;
            DtAdap = new SqlDataAdapter();
            DtAdap.SelectCommand = cmd;
            dtsReporte.Clear();
            DtAdap.Fill(dtsReporte);

            if (dtsReporte.Tables[0].Rows.Count > 0) {
                r.SortTarjetasRechazadas reporte = new r.SortTarjetasRechazadas();
                reporte.SetDataSource(dtsReporte.Tables[0]);
                CN.VisorReportes visor = new CN.VisorReportes();
                visor.Text = "";
                visor.Reporte = reporte;
                visor.ShowDialog();
            }


        }
    }
}
