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
    public partial class frmInvLibros : Form, CN.iForm
    {
        private DataSet dtsParticip = new DataSet();
        private DataView dvwParticip;

        private DataSet dtsFormato = new DataSet();
        OpenFileDialog BuscarImagen = new OpenFileDialog();

        CN.PaisCol  loColPaises = new CN.PaisCol();
        CN.EditorialCol loEditorial = new CN.EditorialCol();
        CN.AutorCol loAthor = new CN.AutorCol();
        CN.SeccionCol   loSeccion = new CN.SeccionCol();
        CN.RamaCol loRama = new CN.RamaCol();
        CN.TematicaCol loTematica = new CN.TematicaCol();
        CN.ColEstatus loEstatus = new CN.ColEstatus();


        CN.Libro Libro;
        CN.LibroCol ColLibros = new CN.LibroCol();

        CN.Evento Evento;
        CN.EventoCol ColEventos= new CN.EventoCol();
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
                    Libro.IdSeccion = (int)cmbSeccion.SelectedValue;
                    Libro.IdTematica = (int)cmbTematica.SelectedValue;
                    Libro.Ilustrado = chkIlustrado.Checked;
                    Libro.SoloConsulta = chkSoloConsulta.Checked;
                    Libro.NumEjemplares = Convert.ToInt32(txtEjemplares.Text);
                    Libro.Edicion = txtEdicion.Text;
                    Libro.Año = Convert.ToInt32(txtAño.Text);
                    Libro.Pasillo = Convert.ToInt32(txtpasillo.Text);
                    Libro.Estante = Convert.ToInt32(txtestante.Text);
                    Libro.Nivel = Convert.ToInt32(txtnivel.Text);
                    Libro.ISBN = txtIsbn.Text;
                    Libro.Materia = txtMateria.Text;

                    try { 
                    //portada
                    // Stream usado como buffer
                    System.IO.MemoryStream ms = new System.IO.MemoryStream();
                    // Se guarda la imagen en el buffer
                    picPortada.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    // Se extraen los bytes del buffer para asignarlos como valor para el  parámetro.
                    Libro.Portada = ms.GetBuffer();
                     }
                    catch(Exception ex){}
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
                    catch (Exception ex) { }


                    if (Libro.Guardar())
                    {
                        MessageBox.Show("El libro ha sido guardado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ((CN.iForm)this).Nuevo();
                    }
                    else
                        MessageBox.Show("Error al intentar guardar el libro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                catch (Exception ex)
                {
                
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                Libro = null;
        }

        private bool Validar()
        {
            Boolean Validado = true;
            String Mensaje = "";


            if (txtEjemplares.Text.Trim() == "")
                Mensaje = Mensaje + "   * No se ha capturado el numero de ejemplares.\n";

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

            if (cmbSeccion.SelectedIndex == -1)
                Mensaje = Mensaje + "   * No se ha capturado la seccion.\n";

            if (cmbTematica.SelectedIndex == -1)
                Mensaje = Mensaje + "   * No se ha capturado la tematica.\n";

            if (txtEdicion.Text.Trim() == "")
                Mensaje = Mensaje + "   * No se ha capturado la edicíon.\n";

            if (txtAño.Text.Trim() == "")
                Mensaje = Mensaje + "   * No se ha capturado el año.\n";

            if (txtEjemplares.Text.Trim() == "")
                Mensaje = Mensaje + "   * No se ha capturado el numero de ejemplares.\n";

            if (txtpasillo.Text.Trim() == "")
                Mensaje = Mensaje + "   * No se ha capturado el pasillo.\n";

            if (txtestante.Text.Trim() == "")
                Mensaje = Mensaje + "   * No se ha capturado el estante.\n";

            if (txtnivel.Text.Trim() == "")
                Mensaje = Mensaje + "   * No se ha capturado el nivel.\n";

            if (picPortada.Image == null)
                Mensaje = Mensaje + "   * No se ha capturado la portada.\n";

            if (picContraportada.Image == null)
                Mensaje = Mensaje + "   * No se ha capturado la contraportada.\n";

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
            if (Evento == null)
            {
                MessageBox.Show("No se puede borrar un evento nuevo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("¿Desea borrar el evento?", "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Evento.Estatus = (int)CN.EstatusEvento.INACTIVO;
                try
                {
                    if (Evento.Borrar())
                    {
                        MessageBox.Show("El evento ha sido borrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ((CN.iForm)this).Nuevo();
                    }
                    //else
                    //    MessageBox.Show("Error al intentar borrar el evento.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        void CN.iForm.Cancelar()
        {
        }

        void CN.iForm.Nuevo()
        {
            txtTitulo.Text = "";
            cmbAutor.SelectedValue = -1;
            cmbEditorial.SelectedValue = -1;
            cmbPais.SelectedValue = -1;
            cmbRama.SelectedValue = -1;
            cmbSeccion.SelectedValue = -1;
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

            picPortada.Image = null;
            picContraportada.Image = null;

            Libro = null;
            LlenaGrid();

        }

        void CN.iForm.Buscar()
        {
        }

        void CN.iForm.Imprimir()
        {
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

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            //llenar combo editorial loEditorial  ----------------------------------------
            try
            {
                loEditorial.Obtener();
                cmbEditorial.DisplayMember = "Nombre";
                cmbEditorial.ValueMember = "Id";
                cmbEditorial.DataSource = loEditorial;
                cmbEditorial.SelectedIndex = -1;

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

            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            //LLENAR SECCION   ------------------------------------------------------------ 
            try
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
            }
            //llenar rama
            try
            {
                loRama.Obtener();
                cmbRama.DisplayMember = "Nombre";
                cmbRama.ValueMember = "Id";
                cmbRama.DataSource = loRama;
                cmbRama.SelectedIndex = -1;

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

            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
             
            //llenar estatus
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
            #region comoboFormato
            String cons = "";
            DtAdap = new SqlDataAdapter();
            cons = "SELECT Id, Formato from BCatFormato";
            DtAdap.SelectCommand = new SqlCommand(cons, CN.DBU.Cnn);
            DtAdap.Fill(dtsFormato);
            DtAdap = null;
            cmbFormato.ValueMember = "Id";
            cmbFormato.DisplayMember = "Formato";
            cmbFormato.DataSource = dtsFormato.Tables[0];
            cmbFormato.SelectedIndex = -1;
            #endregion

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
            cons = "select Libro.id as Id, Libro.Titulo as Titulo, Autor.Nombre as Autor from BInvLibros as Libro join BCatAutores as Autor  on Autor.Id = Libro.IdAutor";
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

                        txtTitulo.Text = Libro.Titulo;
                        cmbAutor.SelectedValue = Libro.IdAutor;
                        cmbEditorial.SelectedValue = Libro.IdEditorial;
                        cmbPais.SelectedValue = Libro.IdPais;
                        cmbRama.SelectedValue = Libro.IdRama;
                        cmbSeccion.SelectedValue = Libro.IdSeccion;
                        cmbTematica.SelectedValue = Libro.IdTematica;
                        txtEjemplares.Text = Libro.NumEjemplares.ToString();
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
 
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
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



   

    }
}
