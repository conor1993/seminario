﻿using System;
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
    public partial class frmCatParrocos : Form, CN.iForm
    {
        private SqlDataAdapter DtAdap = new SqlDataAdapter();
        private DataSet dtsParroquias = new DataSet();
        String procedencia = "";
        String destino     = "";
        private DataSet dtsPar = new DataSet();
        private DataView dvwParr;

        CN.Parrocos Parrocos;
        public frmCatParrocos()
        {
            InitializeComponent();
        }

        #region metodos
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

            if (Parrocos == null)
            {
                Parrocos = new CN.Parrocos();

            }
            else { 
               if(!procedencia.Equals("")){
                   destino = cmbParroquia.Text;
                   if (!procedencia.Equals(destino)) {
                         //se inserta un registro al historial de cambio 
                         agregarcambio();
                   }
                   
               }
            }

            try
            {
            
                Parrocos.Nombre = txtNobre.Text;
                Parrocos.Apellidos = txtApellidos.Text;
                Parrocos.IdParroquia = (int)cmbParroquia.SelectedValue;
                Parrocos.Titulo = txtTtitulo.Text;
                Parrocos.Cargo = txtCargo.Text;
                Parrocos.EMail = txtEmaill.Text;
                Parrocos.NombreParroquia = cmbParroquia.Text;
                Parrocos.Telefono1 = txtTelofono.Text;
                Parrocos.Telefono2 = txtTelefono2.Text;
                Parrocos.TelCural = txtTelCura.Text;
                Parrocos.FechaNac = dtpFecNacim.Value;
                Parrocos.FechaOrdenac = dtmFechaOrden.Value;
                Parrocos.Fecnac = dtpFecNacim.Text;
                Parrocos.FecOrdenacion = dtmFechaOrden.Text;

                if (Parrocos.Guardar())
                {
                    MessageBox.Show("El parroco ha sido guardado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ((CN.iForm)this).Nuevo();
                }
                else
                    MessageBox.Show("Error al intentar guardar el libro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                
            }
        }



        void CN.iForm.Imprimir()
        {
            throw new NotImplementedException();
        }

        void CN.iForm.Nuevo()
        {
            txtNobre.Text="";
            txtApellidos.Text="";
            cmbParroquia.SelectedValue=0;
            txtTtitulo.Text="";
            txtCargo.Text="";
            txtEmaill.Text="";
            cmbParroquia.Text="";
            txtTelofono.Text="";
            txtTelefono2.Text="";
            txtTelCura.Text="";
            Parrocos = null;
            procedencia = "";
        }

        void CN.iForm.Cancelar()
        {
            throw new NotImplementedException();
        }

        void CN.iForm.Borrar()
        {
            if (txtCodigo.Text.Trim() == "") {
                return;
            }

            try
            {
                if (CN.DBU.Cnn.State == ConnectionState.Closed)
                    CN.DBU.Cnn.Open();

                SqlCommand _SQLComm = new SqlCommand();

                _SQLComm.CommandText = "BorrarParroco";
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

                MessageBox.Show("El parroco ha sido borrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                llenarGrid();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        void CN.iForm.Buscar()
        {
            Parrocos = new CN.Parrocos();
            Parrocos.MensajeError += Evento_MensajeError;

            if (txtCodigo.Text.Trim() != "")
            {
                int Codigo = Convert.ToInt32(txtCodigo.Text);

                if (Parrocos.Obtener(Codigo))
                {

                    

                    txtNobre.Text = Parrocos.Nombre;
                    txtApellidos.Text =Parrocos.Apellidos;
                    cmbParroquia.SelectedValue = Parrocos.IdParroquia;
                    txtTtitulo.Text = Parrocos.Titulo;
                    txtCargo.Text = Parrocos.Cargo;
                    txtEmaill.Text = Parrocos.EMail;
                    txtTelofono.Text = Parrocos.Telefono1;
                    txtTelefono2.Text = Parrocos.Telefono2;
                    txtTelCura.Text = Parrocos.TelCural;
                    dtmFechaOrden.Text = Parrocos.FecOrdenacion;
                    dtpFecNacim.Text = Parrocos.Fecnac;
                    procedencia = cmbParroquia.Text;
                    

                }
            }
            else
            {
                MessageBox.Show("No se ha capturado el código.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void agregarcambio()
        {
            //ejecutar procedimiento almacenado  (GuardarHIstorialCmbio) 

            if (CN.DBU.Cnn.State == ConnectionState.Closed)
                CN.DBU.Cnn.Open();

            SqlCommand _SQLComm = new SqlCommand();

            _SQLComm.CommandText = "GuardarHIstorialCmbio";
            _SQLComm.CommandType = CommandType.StoredProcedure;
            _SQLComm.Connection = CN.DBU.Cnn;

            int id = Convert.ToInt32(txtCodigo.Text);

            _SQLComm.Parameters.Add(new SqlParameter("procedencia", procedencia));
            _SQLComm.Parameters.Add(new SqlParameter("destino", destino));
            _SQLComm.Parameters.Add(new SqlParameter("idParroco", id));

            _SQLComm.ExecuteNonQuery();
            CN.DBU.Cnn.Close();   
            
        }
        #endregion

        private void frmCatParrocos_Load(object sender, EventArgs e)
        {
            ((CN.iForm)this).Nuevo();
            DtAdap = new SqlDataAdapter();
            DtAdap.SelectCommand = new SqlCommand("select Idparroquia as id , Nomparr as nombre from CatParroquias where Idparroquia <> 0", CN.DBU.Cnn);
            DtAdap.Fill(dtsParroquias);
            DtAdap.Dispose();
            dtsParroquias.Tables[0].Rows.Add(0, "TODOS");
            cmbParroquia.ValueMember = "id";
            cmbParroquia.DisplayMember = "nombre";
            cmbParroquia.DataSource = dtsParroquias.Tables[0];
            cmbParroquia.SelectedValue = 0;

            try {
                llenarGrid();
            }catch(Exception ex){}
        }

        private void Evento_MensajeError(object sender, string mensaje)
        {
            MessageBox.Show(mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void llenarGrid()
        {
            String cons = "";
            DtAdap = new SqlDataAdapter();
            cons = "SELECT IdParroco, " +
                    "REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(UPPER(NomParroco), 'Á', 'A'), 'É','E'), 'Í', 'I'), 'Ó', 'O'), 'Ú','U') as Nombre, " +
                    "REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(UPPER(ApellParroco), 'Á', 'A'), 'É','E'), 'Í', 'I'), 'Ó', 'O'), 'Ú','U') as Apellidos, " +
                    "REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(UPPER(Cargo), 'Á', 'A'), 'É','E'), 'Í', 'I'), 'Ó', 'O'), 'Ú','U') as Cargo FROM CatParrocos";
            DtAdap.SelectCommand = new SqlCommand(cons, CN.DBU.Cnn);
            DtAdap.Fill(dtsPar);
            DtAdap = null;
            //dttParticip = dtsParticip.Tables[0];
            dvwParr = new DataView(dtsPar.Tables[0]);
            dgvParrocos.DataSource = dvwParr;
        }
        public bool validar() {
            bool validado = true;
            String mensage = "";


            if (txtNobre.Text.Trim() == "") {

                mensage = mensage + "    * No se ha capturado el nombre.\n";
            }

            if (txtApellidos.Text.Trim() == "")
            {

                mensage = mensage + "    * No se ha capturado el apellido.\n";
            }

            if (cmbParroquia.SelectedIndex == -1)
            {

                mensage = mensage + "    * No se ha capturado la parroquia.\n";
            }

            if (mensage != "") {
                validado = false;
                mensage = "Antes de guardar debe corregir lo siguiente:\n\n" + mensage;
                MessageBox.Show(mensage, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return validado;
        }

        private void dgvParrocos_DoubleClick(object sender, EventArgs e)
        {
            Parrocos = new CN.Parrocos();
            Parrocos.MensajeError += Evento_MensajeError;

             if (dgvParrocos.SelectedRows.Count > 0)
                {


                if (Parrocos.Obtener(Convert.ToInt32(dgvParrocos.SelectedRows[0].Cells[0].Value)))
                {
                    txtCodigo.Text = Parrocos.Id.ToString();
                    txtNobre.Text = Parrocos.Nombre;
                    txtApellidos.Text = Parrocos.Apellidos;
                    cmbParroquia.SelectedValue = Parrocos.IdParroquia;
                    txtTtitulo.Text = Parrocos.Titulo;
                    txtCargo.Text = Parrocos.Cargo;
                    txtEmaill.Text = Parrocos.EMail;
                    txtTelofono.Text = Parrocos.Telefono1;
                    txtTelefono2.Text = Parrocos.Telefono2;
                    txtTelCura.Text = Parrocos.TelCural;
                    dtmFechaOrden.Text = Parrocos.FecOrdenacion;
                    dtpFecNacim.Text = Parrocos.Fecnac;
                    procedencia = cmbParroquia.Text;


                }
            }
        }

        private void txtNobre_TextChanged(object sender, EventArgs e)
        {
            if (this.ActiveControl.Name == "txtNobre")
                FiltraParticipantes();
        }

        private void FiltraParticipantes()
        {
            string filtro = "";
            if (txtNobre.Text.Trim() != "")
                filtro = String.Format(" and Nombre Like '%{0}%'", txtNobre.Text.Trim());

            if (txtApellidos.Text.Trim() != "")
                filtro = String.Format(" and Apellidos Like '%{0}%'", txtApellidos.Text.Trim());

            if (filtro.Length > 0)
                dvwParr.RowFilter = filtro.Substring(5, filtro.Length - 5);



            else
                dvwParr.RowFilter = "";
            dgvParrocos.Refresh();
        }

        private void txtApellidos_TextChanged(object sender, EventArgs e)
        {
            if (this.ActiveControl.Name == "txtApellidos")
                FiltraParticipantes();

        }

    }
}