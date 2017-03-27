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
    public partial class frmPagoefectivo : Form, CN.iForm
    {

        

        DataSet dtsPar2;
        DataView dvwParr;
        SqlDataAdapter DtAdap;

        DataSet dtsPar;

        public frmPagoefectivo()
        {
            InitializeComponent();
        }

        private void frmPagoefectivo_Load(object sender, EventArgs e)
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
            GuardarPago();
        }



        public void Imprimir()
        {
            
        }

        public void Nuevo()
        {
            limpiar();
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
            String cons = "";

            DtAdap = new SqlDataAdapter();
            cons = "select bn.id, bn.Nombre as Nombre , bn.ApellidoPaterno+' '+bn.ApellidoMaterno as Apellido, bn.CantidadDonacion as Cantidad from SortCatBienechores bn join SortCatTipopago as tpp on tpp.Id = bn.IdTipopago   where tpp.Nombre = 'EFECTIVO'";
            DtAdap.SelectCommand = new SqlCommand(cons, CN.DBU.Cnn);
            dtsPar = new DataSet();
            dtsPar.Tables.Clear();
            DtAdap.Fill(dtsPar);
            DtAdap = null;
            dgvBienechores.AutoGenerateColumns = false;
            dvwParr = new DataView(dtsPar.Tables[0]);
            dgvBienechores.DataSource = dvwParr;
        }

        private void dgvBienechores_DoubleClick(object sender, EventArgs e)
        {
            if (dgvBienechores.SelectedRows.Count > 0)
            {


                traerdatosBienechores(Convert.ToInt32(dgvBienechores.SelectedRows[0].Cells[0].Value.ToString()));

            }
        }

        private void traerdatosBienechores(int p)
        {
            DtAdap = new SqlDataAdapter();
            DataSet dtseqp = new DataSet();

            try
            {
                if (CN.DBU.Cnn.State == ConnectionState.Closed)
                    CN.DBU.Cnn.Open();

                String cons = "select bn.id, bn.Nombre , bn.CantidadDonacion   from SortCatBienechores bn join SortCatTipopago as tpp on tpp.Id = bn.IdTipopago   where tpp.Nombre = 'EFECTIVO' and   bn.id = "+p;


                DtAdap.SelectCommand = new SqlCommand(cons, CN.DBU.Cnn);
                DtAdap.Fill(dtseqp);
                DtAdap = null;

                limpiar();

                txtid.Text = dtseqp.Tables[0].Rows[0].ItemArray[0].ToString();
                txtnombre.Text = dtseqp.Tables[0].Rows[0].ItemArray[1].ToString();
                txtOtracantidad.Text = dtseqp.Tables[0].Rows[0].ItemArray[2].ToString();

                CN.DBU.Cnn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void GuardarPago()
        {
            if (!validar())
                return;


            int id;
            double cantidads;

            try
            {
                if (CN.DBU.Cnn.State == ConnectionState.Closed)
                    CN.DBU.Cnn.Open();

                SqlCommand _SQLComm = new SqlCommand();

                _SQLComm.CommandText = "GuardarPagoEfectivo";
                _SQLComm.CommandType = CommandType.StoredProcedure;
                _SQLComm.Connection = CN.DBU.Cnn;

                try
                {
                    id = Convert.ToInt32(txtid.Text);

                    cantidads = Double.Parse(txtOtracantidad.Text);
                }
                catch (Exception ex)
                {
                    id = 0;
                    cantidads = 0;
                    MessageBox.Show(ex.ToString());
                }

                String nombre = txtnombre.Text;
                System.DateTime fecha = dtmfecha.Value;

                _SQLComm.Parameters.Add(new SqlParameter("IdBienechor", id));
                _SQLComm.Parameters.Add(new SqlParameter("Fecha", fecha));
                _SQLComm.Parameters.Add(new SqlParameter("Cantidad", cantidads));



                _SQLComm.ExecuteNonQuery();
                limpiar();
                CN.DBU.Cnn.Close();

                MessageBox.Show("pago realizado exitosamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ((CN.iForm)this).Nuevo();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private bool validar()
        {
            bool validado = true;
            String mensage = "";


            if (txtnombre.Text.Trim() == "")
            {

                mensage = mensage + "    * No se ha capturado el nombre.\n";
            }
            if (txtOtracantidad.Text.Trim() == "")
            {

                mensage = mensage + "    * No se ha capturado la cantidad.\n";
            }
            if (txtid.Text.Trim() == "")
            {

                mensage = mensage + "    * No se ha capturado el id.\n";
            }

            if (mensage != "")
            {
                validado = false;
                mensage = "Antes de guardar debe corregir lo siguiente:\n\n" + mensage;
                MessageBox.Show(mensage, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return validado;
        }

        private void limpiar()
           {
            txtid.Text = "";
            txtnombre.Text = "";
            txtOtracantidad.Text ="";
        }


    }
}
