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
        CN.Lectores Lector;
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

          if (Lector == null) Lector = new CN.Lectores();

          try
          {
              if (txtDiasSuspension.Text.Trim() != "") { Lector.DiasSuspension = Convert.ToInt32(txtDiasSuspension.Text);}
                Lector.Cp = Convert.ToInt32(txtCp.Text);
                Lector.CalleNumero = txtNumero.Text;
                Lector.Matricula = txtMatricula.Text;
                Lector.Matricula = txtMatricula.Text;
                Lector.Nombre = txtNombre.Text;
                Lector.ApellidoPaterno = txtApellidoP.Text;
                Lector.ApellidoMaterno = txtApellidoM.Text;
                Lector.Grupo = txtGrupo.Text;
                Lector.FechaNacimiento = Convert.ToDateTime(dtmFnacimiento.Text);
                Lector.CalleNumero = txtCalle.Text;
                Lector.Ciudad = txtCiudad.Text;
                Lector.Estado = txtEstado.Text;
                Lector.Telefono = txtTelefono.Text;
                Lector.Celular = txtCelular.Text;
                Lector.Facultad = txtFacultad.Text;
                Lector.FechaAlta = Convert.ToDateTime(dtmFAlta.Text);
                Lector.FechaVigencia = Convert.ToDateTime(dtmVijencia.Text);
                Lector.Baja = chkBaja.Checked;
                Lector.Suspendido = chksuspendido.Checked;
                Lector.FechaBaja = Convert.ToDateTime(dtmBaja.Text);
                Lector.MotivoBaja = txtMotivo.Text;
                Lector.MotivoSuspendido = txtMotivoSuspension.Text;
                Lector.InicioSuspension = Convert.ToDateTime(dtmSuspendido.Text);
                Lector.Facebook = txtfb.Text;
                Lector.Observaciones = txtObsevacion.Text;
                Lector.Email = txtEmail.Text;
                Lector.Colonia = txtColonia.Text;
                try { Lector.Numero = Convert.ToInt32(txtNumero.Text); }
                catch (Exception ex) { }
                if (Lector.Guardar())
                {
                    MessageBox.Show("El lector ha sido guardado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ((CN.iForm)this).Nuevo();
                }
                else
                    MessageBox.Show("Error al intentar guardar el lector.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);


          }
          catch (Exception ex) {
              MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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
         Lector = null;

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
             int id = Convert.ToInt32(txtCodigo.Text);
             Lector = new CN.Lectores();
             if (Lector.Obtener(id)) {

                    txtMatricula.Text =   Lector.Matricula;                         
                    txtNombre.Text =   Lector.Nombre;                           
                    txtApellidoP.Text =   Lector.ApellidoPaterno;                          
                    txtApellidoM.Text =   Lector.ApellidoMaterno;                           
                    txtGrupo.Text =   Lector.Grupo;                           
                    dtmFnacimiento.Value = (System.DateTime)Lector.FechaNacimiento;                           
                    txtCalle.Text =   Lector.CalleNumero;                          
                    txtCiudad.Text =   Lector.Ciudad;                           
                    txtEstado.Text =   Lector.Estado;                           
                    txtTelefono.Text =   Lector.Telefono;                          
                    txtCelular.Text =   Lector.Celular;                           
                    txtFacultad.Text =   Lector.Facultad;                           
                    dtmFAlta.Value =   (System.DateTime)Lector.FechaAlta;                          
                    dtmVijencia.Value =   (System.DateTime)Lector.FechaVigencia;                           
                    chkBaja.Checked =   (bool)Lector.Baja;                           
                    chksuspendido.Checked =   (bool)Lector.Suspendido;                          
                    dtmBaja.Value =   (System.DateTime)Lector.FechaBaja;                          
                    txtMotivo.Text =   Lector.MotivoBaja;                           
                    txtMotivoSuspension.Text =   Lector.MotivoSuspendido;                          
                    dtmSuspendido.Value =   (System.DateTime)Lector.InicioSuspension;                                                 
                    txtDiasSuspension.Text =   Lector.DiasSuspension.ToString();                                                                         
                    txtCp.Text =   Lector.Cp.ToString();
                                                                            
                                                                                     
             }
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
