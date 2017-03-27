using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CN = ClasesNegocio;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;
using Cl = ClasesSorteo.helpers;
using System.IO;
using System.Collections;
using System.Data.SqlClient;

namespace ClasesSorteo
{
    public partial class frmPagos : Form, CN.iForm
    {
        DataView dvwParr;
        SqlDataAdapter DtAdap;
        DataSet dtsPar;
        String Ruta;
        ClasesSorteo.helpers.leerExcel trj;
        ArrayList tarjetasInfo;

        System.DateTime fechacorte;
        String fech;
        int diacorte;

        public frmPagos()
        {
            InitializeComponent();
        }

        private void frmPagos_Load(object sender, EventArgs e)
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

        //metodos generales
        private void ObtenerExcel()
        {
            trj = new Cl.leerExcel();
            tarjetasInfo = new ArrayList();
            Ruta = ObtenerRutaExcel();
            try
            {
                tarjetasInfo = trj.getExcelFile(Ruta);
                //leer datos de las tarjetas
                lerrDatosTarjeta(tarjetasInfo);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }
        }

        //metodo para obtener la ruta del excel (sirve para obtner la ruta de cualquier archivo)
        private String  ObtenerRutaExcel()
        {
            //obtener ruta archivo
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            Ruta = openFileDialog1.FileName;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al tratar de tomar la ruta del archivo: " + ex.Message);
                }
            }

            return Ruta;
        }

        private void lerrDatosTarjeta(ArrayList tarjetasInfo)
        {

            DtAdap = new SqlDataAdapter();
            dtsPar = new DataSet();
            String cons = "";
            foreach(Cl.tarjetaInfo tarj in tarjetasInfo){
                if (tarj.Status.Equals("Aprobado"))
                {

                    try
                    {
                        DtAdap = new SqlDataAdapter();
                        dtsPar = new DataSet();
                        cons = "";
                        cons = "declare @id int "
                               + " select @id= id from SortCatBienechores where Contrato='"+tarj.Contrato.Trim()+"'"
                               + " INSERT INTO [dbo].[SortPagos] ([IdBienechor],[Fecha],[Cantidad],[IdTipopago]) "
                               + " VALUES (@id ,'"+tarj.Fecha+"'," + tarj.Cantidad + "," + 2 + ") ";
                        DtAdap.SelectCommand = new SqlCommand(cons, CN.DBU.Cnn);
                        DtAdap.Fill(dtsPar);

                     
                    }
                    catch (Exception ex)
                    {
                        
                    }

                   
                }
                else {
                     try
                    {
                        DtAdap = new SqlDataAdapter();
                        dtsPar = new DataSet();
                        cons = "";
                        cons = "declare @id int "
                                + "select @id= id from SortCatBienechores where Contrato='" + tarj.Contrato.Trim() + "'"
                                +"INSERT INTO [dbo].[SortTarjetasRechazadas]([idbienechor] ,[Fecha],[Estatus] ,[Descripcion]) "
                                + " VALUES (@id  ,'" + tarj.Fecha + "','"+tarj.Status.ToString()+"','"+tarj.Descripcion.ToString()+"')";

                        DtAdap.SelectCommand = new SqlCommand(cons, CN.DBU.Cnn);
                        DtAdap.Fill(dtsPar);

                     
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    
                }
            }

            MessageBox.Show("Operacion exitosa");
        }

        private void llenargrid()
        {  
            String cons = "";
            String fechin = "";
            String fechci = "";

            fechacorte = dtmcumple.Value;
            fech = dtmcumple.Value.Day.ToString();

            

            try { 
                diacorte = Convert.ToInt32(fech); 
            }
            catch (Exception ex) {
            
            }

            if (diacorte < 15)
            {

                fechin = fechacorte.Year.ToString() + "-" + fechacorte.AddMonths(-1).Month.ToString() + "-" + "15";
                fechci = fechacorte.Year.ToString() + "-" + fechacorte.Month.ToString()+ "-" + "14";

             
                cons = " select  bn.id, Contrato as Referencia , Nombre, ApellidoPaterno+' '+ApellidoMaterno as Apellido"
                    + " from SortCatBienechores as bn join SortPagos as pag on bn.id = pag.IdBienechor where pag.Fecha  BETWEEN '" + fechin + "' and '" + fechci + "'";
            }
            else {

                fechin = fechacorte.Year.ToString() + "-" + fechacorte.AddMonths(1).Month.ToString() + "-" + "15";
                fechci = fechacorte.Year.ToString() + "-" + fechacorte.Month.ToString() + "-" + "14";

               

                cons = " select  bn.id, Contrato as Referencia , Nombre, ApellidoPaterno+' '+ApellidoMaterno as Apellido"
                    + " from SortCatBienechores as bn join SortPagos as pag on bn.id = pag.IdBienechor where pag.Fecha  BETWEEN '" + fechci + "' and '" + fechin + "'";
             
            }



            DtAdap = new SqlDataAdapter();
            DtAdap.SelectCommand = new SqlCommand(cons, CN.DBU.Cnn);
            dtsPar = new DataSet();
            dtsPar.Tables.Clear();
            DtAdap.Fill(dtsPar);
            DtAdap = null;
            dgvBienechores.AutoGenerateColumns = false;
            dvwParr = new DataView(dtsPar.Tables[0]);
            dgvBienechores.DataSource = dvwParr;

        }

        private void btnPago_Click(object sender, EventArgs e)
        {
            ObtenerExcel();
        }

        private void dtmcumple_ValueChanged(object sender, EventArgs e)
        {
            llenargrid();
        }


    }
}
