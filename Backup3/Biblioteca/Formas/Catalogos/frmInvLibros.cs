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
using BarcodeLib;
using System.Collections;
using System.Drawing.Imaging;
using r = ClasesBiblioteca.reporte;
//using dts = ClasesBiblioteca.dtsetiqueta;
namespace ClasesBiblioteca
{
    public partial class frmInvLibros : Form, CN.iForm
    {
        private DataSet dtsParticip = new DataSet();
        private DataView dvwParticip;

        private DataSet dtsFormato = new DataSet();


        private DataTable tablaEtiquetas = new DataTable();




        OpenFileDialog BuscarImagen = new OpenFileDialog();

        CN.PaisCol loColPaises = new CN.PaisCol();
        CN.EditorialCol loEditorial = new CN.EditorialCol();
        CN.AutorCol loAthor = new CN.AutorCol();
        CN.SeccionCol loSeccion = new CN.SeccionCol();
        CN.RamaCol loRama = new CN.RamaCol();
        CN.TematicaCol loTematica = new CN.TematicaCol();
        CN.EstatusCol loEstatus = new CN.EstatusCol();
        CN.FormatoCol loFormato = new CN.FormatoCol();

        CN.Libro Libro;
        CN.LibroCol ColLibros = new CN.LibroCol();

        CN.Evento Evento;
        CN.EventoCol ColEventos= new CN.EventoCol();

        CN.Libro[] LI;
        Boolean puedorefrescar = true;
        Boolean Editar = false;
        Boolean selesccionado = false;

    
        Dictionary<string, int> list = new Dictionary<string, int>();

        //CN.BusquedaClass<CN.Evento> Busqueda = new CN.BusquedaClass<CN.Evento>()

        private SqlDataAdapter DtAdap = new SqlDataAdapter();
        private DataSet dtsGral = new DataSet();
        private Boolean lbModificado = false;
        private Boolean[] _ToolBarStatus;
        private String lsIdEvento, lsNombreEvento;
        private CN.AceptadoEnum liAceptado;

        public frmInvLibros()
        {
            InitializeComponent();
        }

        #region "iForm"
        Boolean[] CN.iForm.ToolBarStatus
        {
            get { return _ToolBarStatus; }
            set { _ToolBarStatus = value; }
        }

        void CN.iForm.Guardar()
        {

                
                String etiqueta; 

                if (!Validar())
                    return;

   
           
               if (Libro == null) Libro = new CN.Libro();
                 
                
                try
                {

                    Libro.Titulo = txtTitulo.Text;
                    Libro.IdAutor = (int)cmbAutor.SelectedValue;
                    Libro.IdEditorial = (int)cmbEditorial.SelectedValue;
                    Libro.IdPais = (int)cmbPais.SelectedValue;
                    Libro.IdRama = (int)cmbRama.SelectedValue;
                    //Libro.IdSeccion = (int)cmbSeccion.SelectedValue;
                    Libro.IdTematica = (int)cmbTematica.SelectedValue;
                    Libro.Ilustrado = chkIlustrado.Checked;
                    Libro.SoloConsulta = chkSoloConsulta.Checked;
                    Libro.NumEjemplares = -1;
                       
                    Libro.Edicion = txtEdicion.Text;
                    Libro.Año = Convert.ToInt32(txtAño.Text);
                    Libro.Pasillo = txtpasillo.Text;
                    Libro.Estante = txtestante.Text;
                    Libro.Nivel = txtnivel.Text;
                    
                    Libro.Materia = txtMateria.Text;
                    Libro.Estatus = (int)cmbEstatus.SelectedValue;
                    Libro.Formato = (int)cmbFormato.SelectedValue;

                    if (txtIsbn.Text.Trim() != "")
                    {
                        Libro.ISBN = txtIsbn.Text;
                        if (LI != null)
                        {
                            
                            int cont = LI.Count()+1;
                            String consecutivo = cont.ToString();
                            Libro.numero = txtIsbn.Text + "" + consecutivo;

                        }
                        else {
                            
                            Libro.numero = txtIsbn.Text+"1"; }
                    }
                    else
                    {

                        int cont = LI.Count()+1;
                        etiqueta =cont.ToString()+ txtTitulo.Text[0].ToString() + txtTitulo.Text[1].ToString() + cmbAutor.Text[0].ToString() + cmbAutor.Text[1].ToString() + cmbEditorial.Text[0].ToString() + cmbEditorial.Text[1].ToString() + cmbEditorial.Text[2].ToString() + cmbRama.Text[0].ToString() + cmbRama.Text[1].ToString() + cmbRama.Text[2].ToString() + txtEdicion.Text.ToString();
                        Libro.numero = etiqueta;
                      
                    }




                    try { 
                    //portada
                    // Stream usado como buffer
                    System.IO.MemoryStream ms = new System.IO.MemoryStream();
                    // Se guarda la imagen en el buffer
                    picPortada.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    // Se extraen los bytes del buffer para asignarlos como valor para el  parámetro.
                    Libro.Portada = ms.GetBuffer();
                     }
                    catch(Exception ex){
                        if (LI != null)
                        {
                            Libro.Portada = LI[0].Portada;
                        }
                    }
                    //contraportada
                    try
                    {
                        // Stream usado como buffer
                        System.IO.MemoryStream mss = new System.IO.MemoryStream();
                        // Se guarda la imagen en el buffer
                        picContraportada.Image.Save(mss, System.Drawing.Imaging.ImageFormat.Jpeg);
                        // Se extraen los bytes del buffer para asignarlos como valor para el  parámetro.
                        Libro.ContraPortada = mss.GetBuffer();
                    }
                    catch (Exception ex) {
                        if (LI != null) {
                            Libro.ContraPortada = LI[0].ContraPortada;
                        }
                       
                    }

                        Libro.Guardar();
                        Libro = null;
                   
                }
                catch (Exception ex)
                {
                
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                
            
                ((CN.iForm)this).Nuevo();
        }

        private bool Validar()
        {
            Boolean Validado = true;
            String Mensaje = "";



            if (txtTitulo.Text.Trim() == "")
                Mensaje = Mensaje + "   * No se ha capturado el Titulo.\n";

            if (cmbAutor.SelectedIndex == -1)
                Mensaje = Mensaje + "   * No se ha capturado el Author.\n";

            if (cmbEditorial.SelectedIndex == -1)
                Mensaje = Mensaje + "   * No se ha capturado la editorial.\n";

            if (cmbPais.SelectedIndex == -1)
                Mensaje = Mensaje + "   * No se ha capturado el pais.\n";

            if (cmbRama.SelectedIndex == -1)
                Mensaje = Mensaje + "   * No se ha capturado la rama.\n";

            if (cmbTematica.SelectedIndex == -1)
                Mensaje = Mensaje + "   * No se ha capturado la tematica.\n";

            if (cmbEstatus.SelectedIndex == -1)
                Mensaje = Mensaje + "   * No se ha capturado el estatus.\n";

            if (cmbFormato.SelectedIndex == -1)
                Mensaje = Mensaje + "   * No se ha capturado el formato.\n";

            if (txtEdicion.Text.Trim() == "")
                Mensaje = Mensaje + "   * No se ha capturado la edicíon.\n";

            if (txtAño.Text.Trim() == "")
                Mensaje = Mensaje + "   * No se ha capturado el año.\n";


            if (txtpasillo.Text.Trim() == "")
                Mensaje = Mensaje + "   * No se ha capturado el pasillo.\n";

            if (txtestante.Text.Trim() == "")
                Mensaje = Mensaje + "   * No se ha capturado el estante.\n";

            if (txtnivel.Text.Trim() == "")
                Mensaje = Mensaje + "   * No se ha capturado el nivel.\n";


            if (Mensaje != "")
            {
                Validado = false;
                Mensaje = "Antes de guardar debe corregir lo siguiente:\n\n" + Mensaje;
                MessageBox.Show(Mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return Validado;
        }

        void CN.iForm.Borrar()
        {
            try
            {
                if (CN.DBU.Cnn.State == ConnectionState.Closed)
                    CN.DBU.Cnn.Open();

                SqlCommand _SQLComm = new SqlCommand();

                _SQLComm.CommandText = "BorrarLibro";
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

                MessageBox.Show("El Libro ha sido borrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ((CN.iForm)this).Nuevo();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void CN.iForm.Cancelar()
        {
            try
            {
                codigoBarras(txtCodigo.Text);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            
            }
        }

        void CN.iForm.Nuevo()
        {
            txtTitulo.Text = "";
            cmbAutor.SelectedValue = -1;
            cmbEditorial.SelectedValue = -1;
            cmbPais.SelectedValue = -1;
            cmbRama.SelectedValue = -1;
            //cmbSeccion.SelectedValue = -1;
            cmbTematica.SelectedValue = -1;
            chkIlustrado.Checked =false;
            chkSoloConsulta.Checked = false;
            txtEjemplares.Text = "";
            txtEdicion.Text = "";
            txtAño.Text = "";
            txtpasillo.Text="";
            txtestante.Text ="";
            txtnivel.Text = "";
            txtIsbn.Text = "";
            txtMateria.Text = "";
            txtNumero.Text = "";
            picPortada.Image = null;
            picContraportada.Image = null;
            txtNumero.Text = "";

            Libro = null;
            LlenaGrid();

        }

        void CN.iForm.Buscar()
        {

            try
            {
                if (txtCodigo.Text != "")
                {
                    Libro = new CN.Libro();
                    Libro.MensajeError += Evento_MensajeError;
                    int i = Convert.ToInt32(txtCodigo.Text);
                    if (Libro.Obtener(i))
                    {

                        txtTitulo.Text = Libro.Titulo;
                        cmbAutor.SelectedValue = Libro.IdAutor;
                        cmbEditorial.SelectedValue = Libro.IdEditorial;

                        if (Libro.IdPais != null) { cmbPais.SelectedValue = Libro.IdPais; }
                        if (Libro.IdRama != null) { cmbRama.SelectedValue = Libro.IdRama; }
                        if (Libro.Formato != null) { cmbFormato.SelectedValue = Libro.Formato; }
                        if (Libro.Estatus != null) { cmbEstatus.SelectedValue = Libro.Estatus; }
                        //if (Libro.IdSeccion != null){cmbSeccion.SelectedValue = Libro.IdSeccion; }
                        if (Libro.IdTematica != null) { cmbTematica.SelectedValue = Libro.IdTematica; }
                        txtEdicion.Text = Libro.Edicion;
                        txtAño.Text = Libro.Año.ToString();
                        txtpasillo.Text = Libro.Pasillo.ToString();
                        txtestante.Text = Libro.Estante.ToString();
                        txtnivel.Text = Libro.Nivel.ToString();
                        txtIsbn.Text = Libro.ISBN;
                        txtMateria.Text = Libro.Materia;
                        chkIlustrado.Checked = (bool)Libro.Ilustrado;
                        chkSoloConsulta.Checked = (bool)Libro.SoloConsulta;

                        

                        //cargar portada
                        try
                        {
                            byte[] arrImag = (byte[])Libro.Portada;
                            MemoryStream ms = new MemoryStream(arrImag);
                            Image img = Image.FromStream(ms);
                            ms.Close();
                            picPortada.Image = img;
                        }
                        catch
                        {
                            picPortada.Image = null;
                        }
                        //cargar contraportada
                        try
                        {
                            byte[] arrImag = (byte[])Libro.ContraPortada;
                            MemoryStream ms = new MemoryStream(arrImag);
                            Image img = Image.FromStream(ms);
                            ms.Close();
                            picContraportada.Image = img;
                        }
                        catch
                        {
                            picContraportada.Image = null;
                        }

                        int cantidadLibros = numeroLibros(txtIsbn.Text);
                        txtEjemplares.Text = cantidadLibros.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        void CN.iForm.Imprimir()
        {
            if (txtNumero.Text.Trim() == "")return;
            crearDirectorio();



            String codigo = txtNumero.Text;
            String tit = txtTitulo.Text;
            codigoBarras(codigo);
            r.listaEtiquetas reporte = new r.listaEtiquetas();
            try{
            string path = @"C:\codigos\i.png";
            reporte.SetParameterValue("picturePath", path);
            reporte.SetParameterValue("etiqueta", tit);
            CN.VisorReportes visor = new CN.VisorReportes();
            visor.Text = "Codigo de barra";
            visor.Reporte = reporte;
            visor.ShowDialog();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            
        }

        private void crearDirectorio()
        {
            string path = @"c:\codigos";
            try
            {
                // Determine whether the directory exists.
                if (!Directory.Exists(path))
                {

                    // Try to create the directory.
                    DirectoryInfo di = Directory.CreateDirectory(path);
                }


            }
            catch (Exception e)
            {
              
            } 
        }

        #endregion
        
        private void frmInvLibros_Load(object sender, EventArgs e)
        {
            //llamar metodo para llenar los combos al iniciar el frame
            try
            {
                LlenaGrid();
                llenarCombos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
        private void llenarCombos()
        {

            //llenar combo de author loAthor ----------------------------------------------
            try
            {
            
                loAthor.Obtener();
                cmbAutor.DisplayMember = "Nombre";
                cmbAutor.ValueMember = "Id";
                cmbAutor.DataSource = loAthor;
                cmbAutor.SelectedIndex = -1;

                string[] autores;
                autores = loAthor.Listar();
                cmbAutor.AutoCompleteCustomSource.AddRange(autores.ToArray());
                cmbAutor.AutoCompleteMode = AutoCompleteMode.Suggest;
                cmbAutor.AutoCompleteSource = AutoCompleteSource.CustomSource;
               
                
                //coleccion.Add(loAthor);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            //llenar combo editorial loEditorial  ----------------------------------------
            try
            {
                loEditorial.Obtener();
                cmbEditorial.SelectedIndex = -1;
                cmbEditorial.DisplayMember = "Nombre";
                cmbEditorial.ValueMember = "Id";
                cmbEditorial.DataSource = loEditorial;
                cmbEditorial.SelectedIndex = -1;

                string[] editorial;
                editorial = loEditorial.Listar();
                cmbEditorial.AutoCompleteCustomSource.AddRange(editorial.ToArray());
                cmbEditorial.AutoCompleteMode = AutoCompleteMode.Suggest;
                cmbEditorial.AutoCompleteSource = AutoCompleteSource.CustomSource;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // llenar el combo de paises ----------------------------------------------
            try
            {
                loColPaises.Obtener();
                cmbPais.DisplayMember = "Nombre";
                cmbPais.ValueMember = "Id";
                cmbPais.DataSource = loColPaises;
                cmbPais.SelectedIndex = -1;

                string[] pais;
                pais = loColPaises.Listar();
                cmbPais.AutoCompleteCustomSource.AddRange(pais.ToArray());
                cmbPais.AutoCompleteMode = AutoCompleteMode.Suggest;
                cmbPais.AutoCompleteSource = AutoCompleteSource.CustomSource;

            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            //LLENAR SECCION   ------------------------------------------------------------ 
           /* try
            {
                loSeccion.Obtener();
                cmbSeccion.DisplayMember = "Nombre";
                cmbSeccion.ValueMember = "Id";
                cmbSeccion.DataSource = loSeccion;
                cmbSeccion.SelectedIndex = -1;

            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }*/
            //llenar rama
            try
            {
                loRama.Obtener();
                cmbRama.DisplayMember = "Nombre";
                cmbRama.ValueMember = "Id";
                cmbRama.DataSource = loRama;
                cmbRama.SelectedIndex = -1;

                string[] rama;
                rama = loRama.Listar();
                cmbRama.AutoCompleteCustomSource.AddRange(rama.ToArray());
                cmbRama.AutoCompleteMode = AutoCompleteMode.Suggest;
                cmbRama.AutoCompleteSource = AutoCompleteSource.CustomSource;

            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //llenar tematica  loTematica cmbTematica

            try
            {
                loTematica.Obtener();
                cmbTematica.DisplayMember = "Nombre";
                cmbTematica.ValueMember = "Id";
                cmbTematica.DataSource = loTematica;
                cmbTematica.SelectedIndex = -1;

                string[] tematica;
                tematica = loTematica.Listar();
                cmbTematica.AutoCompleteCustomSource.AddRange(tematica.ToArray());
                cmbTematica.AutoCompleteMode = AutoCompleteMode.Suggest;
                cmbTematica.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
             
       
            try
            {
                loEstatus.Obtener();
                cmbEstatus.DisplayMember = "Estado";
                cmbEstatus.ValueMember = "Id";
                cmbEstatus.DataSource = loEstatus;
                cmbEstatus.SelectedIndex = -1;


            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
            //llenar formato
            try
            {
                loFormato.Obtener();
                cmbFormato.DisplayMember = "Formato";
                cmbFormato.ValueMember = "Id";
                cmbFormato.DataSource = loFormato;
                cmbFormato.SelectedIndex = -1;

            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void frmInvLibros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void frmInvLibros_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void LlenaGrid()
        {
            String cons = "";
            
            DtAdap = new SqlDataAdapter();
            cons = "select Libro.id ,Libro.ISBN as Isbn, Libro.Titulo as Titulo, Autor.Nombre as Autor from BInvLibros as Libro join BCatAutores as Autor  on Autor.Id = Libro.IdAutor";
            DtAdap.SelectCommand = new SqlCommand(cons, CN.DBU.Cnn);
            dtsParticip.Tables.Clear();
            DtAdap.Fill(dtsParticip);
            DtAdap = null;
            //dttParticip = dtsParticip.Tables[0];
            dvwParticip = new DataView(dtsParticip.Tables[0]);
            dataLibros.DataSource = dvwParticip;
             
        }

        private void DataGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 4) // column of the enum
            {
                try
                {
                    e.Value = ((CN.EstatusEvento)e.Value).ToString();
                }
                catch (Exception ex)
                {
                    e.Value = e.Value;
                }
            }
        }

        private void Evento_MensajeError(object sender, string mensaje)
        {
            MessageBox.Show(mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void mtbId_LostFocus(object sender, EventArgs e)
        {

            /*
            if (txtCodigo.Tag != txtCodigo.Text)
            {
                if (txtCodigo.Text.Trim() == "")
                {
                    ((CN.iForm)this).Nuevo();
                }
                else
                {
                    int id = int.Parse(txtCodigo.Text);
                    if (!Participante.Obtener(id))
                    {
                        MessageBox.Show("No existe un participante con ese identificador.");
                        txtCodigo.Focus();
                        return;
                    }
                    else
                    {
                        txtApePaterno.Text = Participante.ApellidoPaterno;
                        txtApeMaterno.Text = Participante.ApellidoMaterno;
                        txtNombre.Text = Participante.Nombre;
                        dtpFecNacim.Value = Participante.FechaNacim;
                        cmbAceptado.SelectedValue = (int)Participante.Aceptado;
                        if (Participante.Confirmado == null) chkConfirmacion.Checked = false;
                        else chkConfirmacion.Checked = (bool)Participante.Confirmado;
                        if (Participante.PrimeraComunion == null) chkPrimComun.Checked = false;
                        else chkPrimComun.Checked = (bool)Participante.PrimeraComunion;
                        if (Participante.NombrePadre == null) txtNombrePadre.Text = "";
                        else txtNombrePadre.Text = Participante.NombrePadre;
                        if (Participante.NombreMadre == null) txtNombreMadre.Text = "";
                        else txtNombreMadre.Text = Participante.NombreMadre;
                        if (Participante.VivePadre == null) chkVivePadre.Checked = false;
                        else chkVivePadre.Checked = (bool)Participante.VivePadre;
                        if (Participante.ViveMadre == null) chkViveMadre.Checked = false;
                        else chkViveMadre.Checked = (bool)Participante.ViveMadre;
                        if (Participante.NumHermanos == null) mtbNumHermanos.Text = "0";
                        else mtbNumHermanos.Text = Participante.NumHermanos.ToString();
                        if (Participante.NumHermanas == null) mtbNumHermanas.Text = "0";
                        else mtbNumHermanas.Text = Participante.NumHermanas.ToString();
                        if (Participante.OrdenNacimiento == null) mtbOrdenNacim.Text = "";
                        else mtbOrdenNacim.Text = Participante.OrdenNacimiento.ToString();
                        if (Participante.EdoCivilPadres == null) cmbEdoCivilPadres.SelectedIndex = -1;
                        else cmbEdoCivilPadres.SelectedValue = (int)Participante.EdoCivilPadres;
                        if (Participante.Deportes == null) txtDeportes.Text = "";
                        else txtDeportes.Text = Participante.Deportes;
                        if (Participante.Instrumentos == null) txtInstrumentos.Text = "";
                        else txtInstrumentos.Text = Participante.Instrumentos;
                    }
                }
            }
             */
        }

        private void mtbId_GotFocus(object sender, EventArgs e)
        {
            txtCodigo.Tag = txtCodigo.Text;
        }

        private void cmbAutor_KeyPress(object sender, KeyPressEventArgs e)
        { 
          /*  
            var ColAutores = from r in loColAutores
                             where r.Nombre.ToString().Contains("x")
                             select r;
            */
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void dataLibros_DoubleClick(object sender, EventArgs e)
        {

            Cursor = Cursors.WaitCursor;
            try
            {
                if (dataLibros.SelectedRows.Count > 0)
                {
                    Libro = new CN.Libro();
                    Libro.MensajeError += Evento_MensajeError;
                    if (Libro.Obtener(Convert.ToInt32(dataLibros.SelectedRows[0].Cells[0].Value)))
                    {
                           
                        txtCodigo.Text = Libro.Id.ToString();
                        txtTitulo.Text = Libro.Titulo;
                        cmbAutor.SelectedValue = Libro.IdAutor;
                        cmbEditorial.SelectedValue = Libro.IdEditorial;
                        txtNumero.Text = Libro.numero;
                       
                        if (Libro.IdPais != null) {cmbPais.SelectedValue = Libro.IdPais; }
                        if (Libro.IdRama != null) {cmbRama.SelectedValue = Libro.IdRama; }
                        if (Libro.Formato != null){cmbFormato.SelectedValue = Libro.Formato;}
                        if (Libro.Estatus != null){cmbEstatus.SelectedValue = Libro.Estatus; }
                        //if (Libro.IdSeccion != null){cmbSeccion.SelectedValue = Libro.IdSeccion; }
                        if (Libro.IdTematica != null){cmbTematica.SelectedValue = Libro.IdTematica;}
                        txtEdicion.Text = Libro.Edicion;
                        txtAño.Text = Libro.Año.ToString();
                        txtpasillo.Text = Libro.Pasillo.ToString();
                        txtestante.Text = Libro.Estante.ToString();
                        txtnivel.Text = Libro.Nivel.ToString();
                        txtIsbn.Text = Libro.ISBN;
                        txtMateria.Text = Libro.Materia;

                        if (Libro.ISBN != "")
                        {
                            int cantidadLibros = numeroLibros(Libro.ISBN);
                            txtEjemplares.Text = cantidadLibros.ToString();
                        }
                        else
                        {
                            String idaut = Libro.IdAutor.ToString();
                            String idedit = Libro.IdEditorial.ToString();
                            int cantidadLibros = numeroLibros2(Libro.Titulo, Convert.ToInt32(idaut), Convert.ToInt32(idedit));
                            txtEjemplares.Text = cantidadLibros.ToString();
                                 
                        }
                        chkIlustrado.Checked = (bool)Libro.Ilustrado;
                        chkSoloConsulta.Checked = (bool)Libro.SoloConsulta;



                        

                        
                        //cargar portada
                        try
                        {
                            byte[] arrImag = (byte[])Libro.Portada;
                            MemoryStream ms = new MemoryStream(arrImag);
                            Image img = Image.FromStream(ms);
                            ms.Close();
                            picPortada.Image = img;
                        }
                        catch
                        {
                            picPortada.Image = null;
                        }
                        //cargar contraportada
                        try
                        {
                            byte[] arrImag = (byte[])Libro.ContraPortada;
                            MemoryStream ms = new MemoryStream(arrImag);
                            Image img = Image.FromStream(ms);
                            ms.Close();
                            picContraportada.Image = img;
                        }
                        catch
                        {
                            picContraportada.Image = null;
                        }
 
                    }
                }
            }
            catch (Exception ex)
            {
                   }
            finally
            {
                Cursor = Cursors.Default;
            }
        }


        private void btnBuscarPortada_Click(object sender, EventArgs e)
        {
            if (BuscarImagen.ShowDialog() == DialogResult.OK)
            {       /// Si esto se cumple, capturamos la propiedad File Name y la guardamos en el control
                picPortada.ImageLocation = BuscarImagen.FileName;
                picPortada.SizeMode = PictureBoxSizeMode.StretchImage;
                BuscarImagen.InitialDirectory = BuscarImagen.FileName.Substring(0, BuscarImagen.FileName.Length - BuscarImagen.SafeFileName.Length);
                BuscarImagen.FileName = "";
            }
        }

        private void btnContraPortada_Click(object sender, EventArgs e)
        {

            if (BuscarImagen.ShowDialog() == DialogResult.OK)
            {       /// Si esto se cumple, capturamos la propiedad File Name y la guardamos en el control
                picContraportada.ImageLocation = BuscarImagen.FileName;
                picContraportada.SizeMode = PictureBoxSizeMode.StretchImage;
                BuscarImagen.InitialDirectory = BuscarImagen.FileName.Substring(0, BuscarImagen.FileName.Length - BuscarImagen.SafeFileName.Length);
                BuscarImagen.FileName = "";
            }

        }

        private void txtTitulo_TextChanged(object sender, EventArgs e)
        {
            if (this.ActiveControl.Name == "txtTitulo")
                FiltraParticipantes();
        }

        private void FiltraParticipantes()
        {
            string filtro = "";
            if (txtTitulo.Text.Trim() != "")
                filtro = String.Format(" and Titulo Like '%{0}%'", txtTitulo.Text.Trim());

            if (txtIsbn.Text.Trim() != "")
                filtro = String.Format(" and Isbn Like '%{0}%'", txtIsbn.Text.Trim());

            if (filtro.Length > 0)
                dvwParticip.RowFilter = filtro.Substring(5, filtro.Length - 5);



            else
                dvwParticip.RowFilter = "";
            dataLibros.Refresh();
        }

        private void txtIsbn_TextChanged(object sender, EventArgs e)
        {
            if (this.ActiveControl.Name == "txtIsbn")
                FiltraParticipantes();
        }

        private void txtIsbn_Leave(object sender, EventArgs e)
        {
           if(txtIsbn.Text.Trim() != ""){
                CN.LibroCol Libros = new CN.LibroCol();

                if (Libros.Obtener(txtIsbn.Text) > 0)
                {
                    LI = Libros.ListarLibro();
                    llenarCampos(LI);
                    DialogResult result = MessageBox.Show("Libro Existente desea aumentar el numero de ejemplares", "Confirmation", MessageBoxButtons.YesNoCancel);
                    if (result == DialogResult.Yes)
                    {
                        ((CN.iForm)this).Guardar();

                    }

                    ((CN.iForm)this).Nuevo();
                    LI = null;
                }

                Libros = null;
             }
        }

        private void llenarCampos(CN.Libro[] LI)
        {
            txtTitulo.Text = LI[0].Titulo;
            cmbAutor.SelectedValue = LI[0].IdAutor;
            cmbEditorial.SelectedValue = LI[0].IdEditorial;
            if (LI[0].IdPais != null) { cmbPais.SelectedValue = LI[0].IdPais; }
            if (LI[0].IdRama != null) { cmbRama.SelectedValue = LI[0].IdRama; }
            if (LI[0].Formato != null) { cmbFormato.SelectedValue = LI[0].Formato; }
            if (LI[0].Estatus != null) { cmbEstatus.SelectedValue = LI[0].Estatus; }
            //if (Libro.IdSeccion != null){cmbSeccion.SelectedValue = Libro.IdSeccion; }
            if (LI[0].IdTematica != null) { cmbTematica.SelectedValue = LI[0].IdTematica; }
            txtEjemplares.Text ="1";
            txtEdicion.Text = LI[0].Edicion;
            txtAño.Text = LI[0].Año.ToString();
            txtpasillo.Text = LI[0].Pasillo.ToString();
            txtestante.Text = LI[0].Estante.ToString();
            txtnivel.Text = LI[0].Nivel.ToString();
            txtIsbn.Text = LI[0].ISBN;
            txtMateria.Text = LI[0].Materia;
            try
            { chkIlustrado.Checked = (bool)LI[0].Ilustrado; }
            catch (Exception ex) { }
            try { chkSoloConsulta.Checked = (bool)LI[0].SoloConsulta; }
            catch (Exception ex) { }
            //cargar portada
            try
            {
                byte[] arrImag = (byte[])LI[0].Portada;
                MemoryStream ms = new MemoryStream(arrImag);
                Image img = Image.FromStream(ms);
                ms.Close();
                picPortada.Image = img;
            }
            catch
            {
                picPortada.Image = null;
            }
            //cargar contraportada
            try
            {
                byte[] arrImag = (byte[])LI[0].ContraPortada;
                MemoryStream ms = new MemoryStream(arrImag);
                Image img = Image.FromStream(ms);
                ms.Close();
                picContraportada.Image = img;
            }
            catch
            {
                picContraportada.Image = null;
            }
                 
        }

        public int numeroLibros(String isbn) {
            CN.LibroCol Libros = new CN.LibroCol();
            CN.Libro[] LISTA;
            int contador = 1;
            if (Libros.Obtener(isbn) > 0)
            {
                LISTA = Libros.ListarLibro();
                contador = LISTA.Count();
            }

            LISTA = null;
            Libros = null;
            return contador;
        }

        public int numeroLibros2(String titulo, int autor, int editorial)
        {

            CN.LibroCol Libros = new CN.LibroCol();
            CN.Libro[] LISTA;
            int contador = 1;
            if (Libros.Obtener(titulo,autor,editorial) > 0)
            {
                LISTA = Libros.ListarLibro();
                contador = LISTA.Count();
            }

            LISTA = null;
            Libros = null;
            return contador;
        
        }
 

        private void cmbAutor_Leave(object sender, EventArgs e)
        {
            try { comprobarExistencia(); }
            catch (Exception ex)
            {
                }
            
            if (cmbAutor.Text.Trim() != "")
            {
                CN.AutorCol col = new CN.AutorCol();
                if (col.Obtener(cmbAutor.Text) > 0)
                {
                   
                }
                else {

                    DialogResult result = MessageBox.Show("El autor no existe  desea agregarlo", "Confirmation", MessageBoxButtons.YesNoCancel);
                    if (result == DialogResult.Yes)
                    {
                        CN.Autor aut = new CN.Autor();
                        aut.Nombre = cmbAutor.Text;
                        aut.Guardar();

                        loAthor = new CN.AutorCol();
                        loAthor.Obtener();
                        cmbAutor.DisplayMember = "Nombre";
                        cmbAutor.ValueMember = "Id";
                        cmbAutor.DataSource = loAthor;
                        cmbAutor.SelectedIndex = -1;

                        string[] autores;
                        autores = loAthor.Listar();
                        cmbAutor.AutoCompleteCustomSource.AddRange(autores.ToArray());
                        cmbAutor.AutoCompleteMode = AutoCompleteMode.Suggest;
                        cmbAutor.AutoCompleteSource = AutoCompleteSource.CustomSource;
                        cmbAutor.Focus();

                    }
                    else {

                        cmbAutor.Text = "";
                        cmbAutor.SelectedIndex = -1;
                        cmbAutor.Focus();
                    }



                }
            }
        }

        private void cmbEditorial_Leave(object sender, EventArgs e)
        {
            try { comprobarExistencia(); }
            catch (Exception ex)
            {
            }
            if (cmbEditorial.Text.Trim() != "")
            {
                CN.EditorialCol col = new CN.EditorialCol();
                if (col.Obtener(cmbEditorial.Text) > 0)
                {
                    
                }
                else
                {

                    DialogResult result = MessageBox.Show("La editorial no existe  desea agregarla", "Confirmation", MessageBoxButtons.YesNoCancel);
                    if (result == DialogResult.Yes)
                    {

                        CN.Editorial aut = new CN.Editorial();
                        aut.Nombre = cmbEditorial.Text;
                        aut.Guardar();

                        loEditorial = new CN.EditorialCol();
                        loEditorial.Obtener();
                        cmbEditorial.DisplayMember = "Nombre";
                        cmbEditorial.ValueMember = "Id";
                        cmbEditorial.DataSource = loEditorial;
                        cmbEditorial.SelectedIndex = -1;

                        string[] editorial;
                        editorial = loEditorial.Listar();
                        cmbEditorial.AutoCompleteCustomSource.AddRange(editorial.ToArray());
                        cmbEditorial.AutoCompleteMode = AutoCompleteMode.Suggest;
                        cmbEditorial.AutoCompleteSource = AutoCompleteSource.CustomSource;
                        cmbEditorial.Focus();


                    }
                    else
                    {

                        cmbEditorial.Text = "";
                        cmbEditorial.SelectedIndex = -1;
                        cmbEditorial.Focus();
                    }



                }
            }

        }

        private void cmbPais_Leave(object sender, EventArgs e)
        {
            if (cmbPais.Text.Trim() != "") {
                CN.PaisCol col = new CN.PaisCol();

                if (col.Obtener(cmbPais.Text) > 0)
                {
                   
                }
                else {
                        DialogResult result = MessageBox.Show("El pais no existe desea agregarlo", "Confirmation", MessageBoxButtons.YesNoCancel);
                        if (result == DialogResult.Yes)
                        {

                            CN.Pais paiss = new CN.Pais();
                            paiss.Nombre = cmbPais.Text;
                            paiss.Guardar();

                            loColPaises = new CN.PaisCol();
                            loColPaises.Obtener();
                            cmbPais.DisplayMember = "Nombre";
                            cmbPais.ValueMember = "Id";
                            cmbPais.DataSource = loColPaises;
                            cmbPais.SelectedIndex = -1;

                            string[] pais;
                            pais = loColPaises.Listar();
                            cmbPais.AutoCompleteCustomSource.AddRange(pais.ToArray());
                            cmbPais.AutoCompleteMode = AutoCompleteMode.Suggest;
                            cmbPais.AutoCompleteSource = AutoCompleteSource.CustomSource;
                            cmbPais.Focus();
                        }
                        else {

                            cmbPais.Text = "";
                            cmbPais.SelectedIndex = -1;
                            cmbPais.Focus();
                        }
                }
            
            }
        }

        private void cmbRama_Leave(object sender, EventArgs e)
        {

            if (cmbRama.Text.Trim() != "")
            {
                CN.RamaCol col = new CN.RamaCol();

                if (col.Obtener(cmbRama.Text) > 0)
                {

                }
                else
                {
                    DialogResult result = MessageBox.Show("La rama no existe desea agregarla", "Confirmation", MessageBoxButtons.YesNoCancel);
                    if (result == DialogResult.Yes)
                    {

                        CN.Rama ram = new CN.Rama();
                        ram.Nombre = cmbRama.Text;
                        ram.Guardar();

                        loRama = new CN.RamaCol();
                        loRama.Obtener();
                        cmbRama.DisplayMember = "Nombre";
                        cmbRama.ValueMember = "Id";
                        cmbRama.DataSource = loRama;
                        cmbRama.SelectedIndex = -1;

                        string[] rama;
                        rama = loRama.Listar();
                        cmbRama.AutoCompleteCustomSource.AddRange(rama.ToArray());
                        cmbRama.AutoCompleteMode = AutoCompleteMode.Suggest;
                        cmbRama.AutoCompleteSource = AutoCompleteSource.CustomSource;
                        cmbRama.Focus();
                    }
                    else
                    {

                        cmbRama.Text = "";
                        cmbRama.SelectedIndex = -1;
                        cmbRama.Focus();
                    }
                }

            }
        }

        private void cmbTematica_Leave(object sender, EventArgs e)
        {
            try
            {
                if (cmbTematica.Text.Trim() != "")
                {
                    CN.TematicaCol col = new CN.TematicaCol();

                    if (col.Obtener(cmbTematica.Text) > 0)
                    {

                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("La tematica no existe desea agregarla", "Confirmation", MessageBoxButtons.YesNoCancel);
                        if (result == DialogResult.Yes)
                        {

                            CN.Tematica tem = new CN.Tematica();
                            tem.Nombre = cmbTematica.Text;
                            tem.Guardar();

                            loTematica = new CN.TematicaCol();
                            loTematica.Obtener();
                            cmbTematica.DisplayMember = "Nombre";
                            cmbTematica.ValueMember = "Id";
                            cmbTematica.DataSource = loTematica;
                            cmbTematica.SelectedIndex = -1;

                            string[] tematica;
                            tematica = loTematica.Listar();
                            cmbTematica.AutoCompleteCustomSource.AddRange(tematica.ToArray());
                            cmbTematica.AutoCompleteMode = AutoCompleteMode.Suggest;
                            cmbTematica.AutoCompleteSource = AutoCompleteSource.CustomSource;
                            cmbTematica.Focus();
                        }
                        else
                        {

                            cmbTematica.Text = "";
                            cmbTematica.SelectedIndex = -1;
                            cmbTematica.Focus();
                        }
                    }

                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private Image codigoBarras(String codigo) {
            
            Image imgFinal;
            BarcodeLib.Barcode cod = new BarcodeLib.Barcode();
            cod.IncludeLabel = true;
            imgFinal = (Image)cod.Encode(BarcodeLib.TYPE.CODE128, codigo, Color.Black, Color.White, 400, 100);
            String src = @"C:\codigos\i.png";
            imgFinal.Save(src, ImageFormat.Png);
            
               
            return imgFinal;
        
        }


        private void comprobarExistencia(){
            if (txtTitulo.Text.Trim() != "" && cmbAutor.Text.Trim() != "" && cmbEditorial.Text.Trim() != "")
            {
                CN.LibroCol Libros = new CN.LibroCol();

                if (Libros.Obtener(txtTitulo.Text, Convert.ToInt32(cmbAutor.SelectedValue), Convert.ToInt32(cmbEditorial.SelectedValue)) > 0)
                {
                    LI = Libros.ListarLibro();
                    llenarCampos(LI);
                    DialogResult result = MessageBox.Show("Libro Existente desea aumentar el numero de ejemplares", "Confirmation", MessageBoxButtons.YesNoCancel);
                    if (result == DialogResult.Yes)
                    {
                        ((CN.iForm)this).Guardar();

                    }

                    ((CN.iForm)this).Nuevo();
                    LI = null;
                }

                Libros = null;
            }
         
        
        }

        private void txtTitulo_Leave(object sender, EventArgs e)
        {
            try { comprobarExistencia(); }
            catch (Exception ex)
            {
            }
        }

        private void txtIsbn_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números 
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso 
                {
                    e.Handled = false;
                }
                else
                {
                    //el resto de teclas pulsadas se desactivan 
                    e.Handled = true;
                }
        }

    }
}
