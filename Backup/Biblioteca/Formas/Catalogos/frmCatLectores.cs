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

namespace ClasesBiblioteca
{
    public partial class frmCatLectores :Form, CN.iForm
    {

        private DataSet dtsLectores;
        public frmCatLectores()
        {
            InitializeComponent();
        }


    
     public bool[]  ToolBarStatus
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

    #region iform
     void CN.iForm.Guardar()
      {

          if (!validar())
              return;

          int id;
          int dias;
          int cp;
          int numeroext;

          try{id = Convert.ToInt32(txtCodigo.Text);}
          catch (Exception ex){id = 0;}
          try { dias = Convert.ToInt32(txtDiasSuspension.Text); }
          catch (Exception ex) { dias = 0; }
          try { cp = Convert.ToInt32(txtCp.Text); }
          catch (Exception ex) { cp = 0; }
          try { numeroext = Convert.ToInt32(txtNumero.Text); }
          catch { numeroext = 0; }


          try
          {
             // if (!validar())
               //   return;

              if (CN.DBU.Cnn.State == ConnectionState.Closed)
                  CN.DBU.Cnn.Open();

              SqlCommand _SQLComm = new SqlCommand();

              _SQLComm.CommandText = "CbGuardarLectores";
              _SQLComm.CommandType = CommandType.StoredProcedure;
              _SQLComm.Connection = CN.DBU.Cnn;


              String matricula           = txtMatricula.Text;
              String nombre              = txtNombre.Text;
              String apellido_paterno    = txtApellidoP.Text;
              String apellido_materno    = txtApellidoM.Text;
              String grupo               = txtGrupo.Text;
              DateTime fecha_nacimiento  = Convert.ToDateTime(dtmFnacimiento.Text);
              String calle               = txtCalle.Text;
              String ciudad              = txtCiudad.Text;
              String estado              = txtEstado.Text;
              String telefono            = txtTelefono.Text;
              String celular             = txtCelular.Text;
              String facultad            = txtFacultad.Text;
              DateTime fechaalta         = Convert.ToDateTime(dtmFAlta.Text);
              DateTime fechavijencia     = Convert.ToDateTime(dtmVijencia.Text);
              bool baja                  = chkBaja.Checked;
              bool suspendido            = chksuspendido.Checked;
              DateTime fecha_baja        = Convert.ToDateTime(dtmBaja.Text);
              String motivo_baja         = txtMotivo.Text;
              String motivo_suspendido   = txtMotivoSuspension.Text;
              DateTime inicio_suspension = Convert.ToDateTime(dtmSuspendido.Text);
              String fb                  = txtfb.Text;
              String email               = txtEmail.Text;
              String colonia               = txtColonia.Text;
              String observaciones       = txtObsevacion.Text;

              _SQLComm.Parameters.Add(new SqlParameter("Id", id));
              _SQLComm.Parameters.Add(new SqlParameter("matricula", matricula));
              _SQLComm.Parameters.Add(new SqlParameter("nombre", nombre));
              _SQLComm.Parameters.Add(new SqlParameter("apellido_paterno", apellido_paterno));
              _SQLComm.Parameters.Add(new SqlParameter("apellido_materno", apellido_materno));
              _SQLComm.Parameters.Add(new SqlParameter("sexo", "")); //pendiente
              _SQLComm.Parameters.Add(new SqlParameter("grupo", grupo));
              _SQLComm.Parameters.Add(new SqlParameter("fecha_nacimiento", fecha_nacimiento));
              _SQLComm.Parameters.Add(new SqlParameter("calle_numero", calle));
              _SQLComm.Parameters.Add(new SqlParameter("ciudad", ciudad));
              _SQLComm.Parameters.Add(new SqlParameter("estado", estado));
              _SQLComm.Parameters.Add(new SqlParameter("telefono", telefono));
              _SQLComm.Parameters.Add(new SqlParameter("celular", celular));
              _SQLComm.Parameters.Add(new SqlParameter("facultad",facultad ));
              _SQLComm.Parameters.Add(new SqlParameter("fecha_alta", fechaalta));
              _SQLComm.Parameters.Add(new SqlParameter("fecha_vigencia", fechavijencia));
              _SQLComm.Parameters.Add(new SqlParameter("baja", baja));
              _SQLComm.Parameters.Add(new SqlParameter("suspendido", suspendido));
              _SQLComm.Parameters.Add(new SqlParameter("fecha_baja", fecha_baja));
              _SQLComm.Parameters.Add(new SqlParameter("motivo_baja", motivo_baja));
              _SQLComm.Parameters.Add(new SqlParameter("motivo_suspendido", motivo_suspendido));
              _SQLComm.Parameters.Add(new SqlParameter("inicio_suspension", inicio_suspension));
              _SQLComm.Parameters.Add(new SqlParameter("dias_suspension", dias));
              _SQLComm.Parameters.Add(new SqlParameter("observaciones", observaciones));
              _SQLComm.Parameters.Add(new SqlParameter("cp", cp));
              _SQLComm.Parameters.Add(new SqlParameter("fb", fb));
              _SQLComm.Parameters.Add(new SqlParameter("email", email));
              _SQLComm.Parameters.Add(new SqlParameter("colonia", colonia));
              _SQLComm.Parameters.Add(new SqlParameter("numero", numeroext));


              _SQLComm.Parameters.Add(new SqlParameter("Error", SqlDbType.Int, 4));
              _SQLComm.Parameters["Error"].Direction = ParameterDirection.Output;

              _SQLComm.Parameters.Add(new SqlParameter("guardo", SqlDbType.Int, 4));
              _SQLComm.Parameters["guardo"].Direction = ParameterDirection.Output;

              _SQLComm.ExecuteNonQuery();


              if (int.Parse(_SQLComm.Parameters["Error"].Value.ToString()) > 0)
                  throw new Exception("El formato ya ha sido guardado.");


              ((CN.iForm)this).Nuevo();



              CN.DBU.Cnn.Close();



          }
          catch (Exception ex)
          {
              MessageBox.Show(ex.Message, "Avisos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
          }
            
            
      }

     private bool validar()
     {
         bool validado = true;
         String Mensaje = "";

         if (txtNombre.Text == "") {
             Mensaje = Mensaje + "   * No se ha capturado el nombre.\n";
         }

         if (txtGrupo.Text == "") {
             Mensaje = Mensaje + "   * No se ha capturado el grupo.\n";
         }

         if (txtApellidoP.Text == "") {
             Mensaje = Mensaje + "   * No se ha capturado el apellido paterno.\n";
         }

         if (txtApellidoM.Text == "")
         {
             Mensaje = Mensaje + "   * No se ha capturado el apellido materno.\n";
         }
         if (txtMatricula.Text == "") {
             Mensaje = Mensaje + "   * No se ha capturado la matricula.\n";
         }
         if(txtFacultad.Text == ""){
             Mensaje = Mensaje + "   * No se ha capturado la facultad.\n";
         }
         if(dtmFnacimiento.Text == ""){
             Mensaje = Mensaje + "   * No se ha capturado la fecha de nacimiento.\n";
         }
         


         if (Mensaje != "") { 
             Mensaje = "Antes de guardar debe corregir lo siguiente:\n\n" + Mensaje;
             validado = false;
             MessageBox.Show(Mensaje,"aviso",MessageBoxButtons.OK,MessageBoxIcon.Warning);
         }

         return validado;
     }

     void CN.iForm.Borrar()
     {
 	
     }

     void CN.iForm.Nuevo()
     {

         txtNombre.Text = "";
         txtApellidoM.Text = "";
         txtApellidoP.Text = "";
         txtGrupo.Text = "";
         txtMatricula.Text = "";
         txtFacultad.Text = "";

         txtCalle.Text = "";
         txtNumero.Text = "";
         txtColonia.Text = "";
         txtCp.Text = "";
         txtCiudad.Text = "";
         txtEstado.Text = "";
         txtTelefono.Text = "";
         txtCelular.Text = "";
         txtEmail.Text = "";
         txtMotivo.Text = "";
         txtMotivoSuspension.Text = "";
         txtObsevacion.Text="";
         txtDiasSuspension.Text = "";
         chkBaja.Checked = false;
         chksuspendido.Checked = false;


     }

     void CN.iForm.Cancelar()
     {
 	        throw new NotImplementedException();
     }

     void CN.iForm.Imprimir()
     {
   

     }

     void CN.iForm.Buscar()
     {

         if (txtCodigo.Text.Trim() != "") { 
         try
         {
             if (CN.DBU.Cnn.State == ConnectionState.Closed)
                 CN.DBU.Cnn.Open();

             SqlCommand _SQLComm = new SqlCommand();
             SqlDataAdapter _DataAdap;

             _SQLComm.CommandText = "CbObtenerLectoresFiltro";
             _SQLComm.CommandType = CommandType.StoredProcedure;
             _SQLComm.Connection = CN.DBU.Cnn;

             int idd = Convert.ToInt32(txtCodigo.Text);

             _SQLComm.Parameters.Add(new SqlParameter("id", idd));

             _SQLComm.ExecuteNonQuery();
             _DataAdap = new SqlDataAdapter(_SQLComm);
             dtsLectores = new DataSet();
             _DataAdap.Fill(dtsLectores);
             _DataAdap = null;

             if (dtsLectores.Tables[0].Rows.Count > 0)
             {
       
                 txtMatricula.Text = (string)dtsLectores.Tables[0].Rows[0].ItemArray[1];
                 txtNombre.Text = (string)dtsLectores.Tables[0].Rows[0].ItemArray[2];
                 txtApellidoP.Text =  (string)dtsLectores.Tables[0].Rows[0].ItemArray[3];
                 txtApellidoM.Text = (string)dtsLectores.Tables[0].Rows[0].ItemArray[4];
                 txtGrupo.Text = (string)dtsLectores.Tables[0].Rows[0].ItemArray[6];
                 dtmFnacimiento.Value = (System.DateTime)dtsLectores.Tables[0].Rows[0].ItemArray[7]; ;
                 txtCalle.Text = (string)dtsLectores.Tables[0].Rows[0].ItemArray[8];
                 txtCiudad.Text = (string)dtsLectores.Tables[0].Rows[0].ItemArray[9];
                 txtEstado.Text = (string)dtsLectores.Tables[0].Rows[0].ItemArray[10];
                 txtTelefono.Text = (string)dtsLectores.Tables[0].Rows[0].ItemArray[11];
                 txtCelular.Text = (string)dtsLectores.Tables[0].Rows[0].ItemArray[12];
                 txtFacultad.Text = (string)dtsLectores.Tables[0].Rows[0].ItemArray[13];
                 dtmFAlta.Value = (System.DateTime)dtsLectores.Tables[0].Rows[0].ItemArray[14];
                 dtmVijencia.Value = (System.DateTime)dtsLectores.Tables[0].Rows[0].ItemArray[15];
                 chkBaja.Checked = (bool)dtsLectores.Tables[0].Rows[0].ItemArray[16];
                 chksuspendido.Checked = (bool)dtsLectores.Tables[0].Rows[0].ItemArray[17];
                 dtmBaja.Value = (System.DateTime)dtsLectores.Tables[0].Rows[0].ItemArray[18];
                 txtMotivo.Text = (string)dtsLectores.Tables[0].Rows[0].ItemArray[19];
                 txtMotivoSuspension.Text = (string)dtsLectores.Tables[0].Rows[0].ItemArray[20];
                 dtmSuspendido.Value = (System.DateTime)dtsLectores.Tables[0].Rows[0].ItemArray[21];
                 int dias = Convert.ToInt32(dtsLectores.Tables[0].Rows[0].ItemArray[22]);
                 txtDiasSuspension.Text = dias.ToString();
                 txtObsevacion.Text = (String)dtsLectores.Tables[0].Rows[0].ItemArray[23];
                 int cpp = Convert.ToInt32(dtsLectores.Tables[0].Rows[0].ItemArray[24]);
                 txtCp.Text = cpp.ToString();
                 txtfb.Text = (String)dtsLectores.Tables[0].Rows[0].ItemArray[25];
                 int num = Convert.ToInt32(dtsLectores.Tables[0].Rows[0].ItemArray[26]);
                 txtNumero.Text = num.ToString();
                 txtColonia.Text = (String)dtsLectores.Tables[0].Rows[0].ItemArray[27];
                 txtEmail.Text = (String)dtsLectores.Tables[0].Rows[0].ItemArray[28];


             }
             CN.DBU.Cnn.Close();
         }

         catch (Exception ex)
         {
             MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

         }
     }

     }
    #endregion

  }

}
