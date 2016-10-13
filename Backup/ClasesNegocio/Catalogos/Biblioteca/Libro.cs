using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using EC = ORMDiocesis.EntityClasses;
using CC = ORMDiocesis.CollectionClasses;
using HC = ORMDiocesis.HelperClasses;
using OC = SD.LLBLGen.Pro.ORMSupportClasses;
using CN = ClasesNegocio;
using System.ComponentModel;


namespace ClasesNegocio
{

    public class Libro : CN.ClassBase <EC.LibroEntity>, IEntidad
    {
        public event CN.MensajeErrorHandler MensajeError;
        public event EventHandler Modificado;
        private Seccion _Seccion;
        private Rama _Rama;
        private Tematica _Tematica;
        private Autor _Autor;
        private Editorial _Editorial;
        private Pais _Pais;

    #region Constructores
        public Libro()
        {
            _Entidad = new EC.LibroEntity();
        }

        public Libro(EC.LibroEntity Entity)
        {
            _Entidad = Entity;
        }

    #endregion

    #region Propiedades
        [System.ComponentModel.DisplayName("ID")]
        public int Id
        {
            get { return _Entidad.Id; }
            set { _Entidad.Id = value; if (Modificado!=null) Modificado(this, new EventArgs()); }
        }

        [System.ComponentModel.DisplayName("Titulo")]
        public string Titulo
        {
            get { return _Entidad.Titulo; }
            set { _Entidad.Titulo = value; if (Modificado != null) Modificado(this, new EventArgs()); }
        }

        [System.ComponentModel.DisplayName("ID Autor")]
        public int IdAutor
        {
            get { return _Entidad.IdAutor; }
            set { _Entidad.IdAutor = value; if (Modificado != null) Modificado(this, new EventArgs()); }
        }

        [System.ComponentModel.DisplayName("Autor")]
        public Autor Autor
        {
            get
            {
                if (_Autor == null)
                    _Autor = new Autor(_Entidad.Autor);
                return _Autor;
            }
            set
            {
                _Autor = value;
                _Entidad.IdAutor = value.Id;
                _Entidad.Autor = value.ObtenerEntidad();
                if (Modificado != null) Modificado(this, new EventArgs());
            }
        }

        [System.ComponentModel.DisplayName("Edición")]
        public string Edicion
        {
            get { return _Entidad.Edicion; }
            set { _Entidad.Edicion = value; if (Modificado != null) Modificado(this, new EventArgs()); }
        }

        [System.ComponentModel.DisplayName("ID Editorial")]
        public int IdEditorial
        {
            get { return _Entidad.IdEditorial; }
            set { _Entidad.IdEditorial = value; if (Modificado != null) Modificado(this, new EventArgs()); }
        }

        [System.ComponentModel.DisplayName("Editorial")]
        public Editorial Editorial
        {
            get
            {
                if (_Editorial == null)
                    _Editorial = new Editorial(_Entidad.Editorial);
                return _Editorial;
            }
            set
            {
                _Editorial = value;
                _Entidad.IdEditorial = value.Id;
                _Entidad.Editorial = value.ObtenerEntidad();
                if (Modificado != null) Modificado(this, new EventArgs());
            }
        }

        [System.ComponentModel.DisplayName("ID Sección")]
        public int IdSeccion
        {
            get { return _Entidad.IdSeccion; }
            set { _Entidad.IdSeccion = value; if (Modificado != null) Modificado(this, new EventArgs()); }
        }

        [System.ComponentModel.DisplayName("Seccion")]
        public Seccion Seccion
        {
            get
            {
                if (_Seccion == null)
                    _Seccion = new Seccion(_Entidad.Seccion);
                return _Seccion;
            }
            set
            {
                _Seccion = value;
                _Entidad.IdSeccion = value.Id;
                _Entidad.Seccion = value.ObtenerEntidad();
                if (Modificado != null) Modificado(this, new EventArgs());
            }
        }

        [System.ComponentModel.DisplayName("ID Rama")]
        public int IdRama
        {
            get { return _Entidad.IdRama; }
            set { _Entidad.IdRama = value; if (Modificado != null) Modificado(this, new EventArgs()); }
        }

        [System.ComponentModel.DisplayName("Rama")]
        public Rama Rama
        {
            get
            {
                if (_Rama == null)
                    _Rama = new Rama(_Entidad.Rama);
                return _Rama;
            }
            set
            {
                _Rama = value;
                _Entidad.IdRama = value.Id;
                _Entidad.Rama = value.ObtenerEntidad();
                if (Modificado != null) Modificado(this, new EventArgs());
            }
        }

        [System.ComponentModel.DisplayName("ID Temática")]
        public int IdTematica
        {
            get { return _Entidad.IdTematica; }
            set { _Entidad.IdTematica = value; if (Modificado != null) Modificado(this, new EventArgs()); }
        }

        [System.ComponentModel.DisplayName("Temática")]
        public Tematica Tematica
        {
            get
            {
                if (_Tematica == null)
                    _Tematica = new Tematica(_Entidad.Tematica);
                return _Tematica;
            }
            set
            {
                _Tematica = value;
                _Entidad.IdTematica = value.Id;
                _Entidad.Tematica = value.ObtenerEntidad();
                if (Modificado != null) Modificado(this, new EventArgs());
            }
        }

        [System.ComponentModel.DisplayName("ID País")]
        public int? IdPais
        {
            get { return _Entidad.IdPais; }
            set { _Entidad.IdPais = value; if (Modificado != null) Modificado(this, new EventArgs()); }
        }

        [System.ComponentModel.DisplayName("Pais")]
        public Pais Pais
        {
            get
            {
                if (_Pais == null)
                    _Pais = new Pais(_Entidad.Pais);
                return _Pais;
            }
            set
            {
                _Pais = value;
                _Entidad.IdPais = value.Id;
                _Entidad.Pais = value.ObtenerEntidad();
                if (Modificado != null) Modificado(this, new EventArgs());
            }
        }

        [System.ComponentModel.DisplayName("Año")]
        public int? Año
        {
            get { return _Entidad.Año; }
            set { _Entidad.Año = value; if (Modificado != null) Modificado(this, new EventArgs()); }
        }

        [System.ComponentModel.DisplayName("Num Ejemplares")]
        public int NumEjemplares
        {
            get { return _Entidad.NumEjemplares; }
            set { _Entidad.NumEjemplares = value; if (Modificado != null) Modificado(this, new EventArgs()); }
        }

        [System.ComponentModel.DisplayName("Solo Consulta")]
        public bool SoloConsulta
        {
            get { return _Entidad.ExclusivoConsulta; }
            set { _Entidad.ExclusivoConsulta = value; if (Modificado != null) Modificado(this, new EventArgs()); }
        }

        [System.ComponentModel.DisplayName("Pasillo")]
        public int? Pasillo
        {
            get { return _Entidad.Pasillo; }
            set { _Entidad.Pasillo = value; if (Modificado != null) Modificado(this, new EventArgs()); }
        }

        [System.ComponentModel.DisplayName("Estante")]
        public int? Estante
        {
            get { return _Entidad.Estante; }
            set { _Entidad.Estante = value; if (Modificado != null) Modificado(this, new EventArgs()); }
        }

        [System.ComponentModel.DisplayName("Nivel")]
        public int? Nivel
        {
            get { return _Entidad.Nivel; }
            set { _Entidad.Nivel = value; if (Modificado != null) Modificado(this, new EventArgs()); }
        }

        [System.ComponentModel.DisplayName("ISBN")]
        public string ISBN
        {
            get { return _Entidad.Isbn; }
            set { _Entidad.Isbn = value; if (Modificado != null) Modificado(this, new EventArgs()); }
        }

        [System.ComponentModel.DisplayName("DDC")]
        public string DDC
        {
            get { return _Entidad.Ddc; }
            set { _Entidad.Ddc = value; if (Modificado != null) Modificado(this, new EventArgs()); }
        }

        [System.ComponentModel.DisplayName("CDU")]
        public string CDU
        {
            get { return _Entidad.Cdu; }
            set { _Entidad.Cdu = value; if (Modificado != null) Modificado(this, new EventArgs()); }
        }

        [System.ComponentModel.DisplayName("Ilustrado")]
        public bool? Ilustrado
        {
            get { return _Entidad.Ilustrado; }
            set { _Entidad.Ilustrado = value; if (Modificado != null) Modificado(this, new EventArgs()); }
        }

        [System.ComponentModel.DisplayName("Busqueda")]
        public string Busqueda
        {
            get { return _Entidad.Busqueda; }
            set { _Entidad.Busqueda = value; if (Modificado != null) Modificado(this, new EventArgs()); }
        }

        [System.ComponentModel.DisplayName("Portada")]
        public byte[] Portada
        {
            get { return _Entidad.Portada; }
            set { _Entidad.Portada = value; if (Modificado != null) Modificado(this, new EventArgs()); }
        }

        [System.ComponentModel.DisplayName("ContraPortada")]
        public byte[] ContraPortada
        {
            get { return _Entidad.ContraPortada; }
            set { _Entidad.ContraPortada = value; if (Modificado != null) Modificado(this, new EventArgs()); }
        }

        [System.ComponentModel.DisplayName("Materia")]
        public String Materia
        {
            get { return _Entidad.Materia; }
            set { _Entidad.Materia = value; if (Modificado != null) Modificado(this, new EventArgs()); }
        }

       

    #endregion

    #region Metodos

        public Boolean Borrar(HC.Transaction trans = null)
        {
            Boolean CierraTrans = false;
            try
            {
                //if (_Entidad.EquiposDeTrabajo.Count > 0)
                //{
                //    if (MensajeError != null)
                //        MensajeError(this, "No se pudo borrar el libro porque tiene equipos de trabajo.");
                //    else
                //        throw (new Exception("No se pudo borrar el autor porque tiene equipos de trabajo."));
                //    return false;
                //}

                //if (_Entidad.Asistencias.Count > 0)
                //{
                //    if (MensajeError != null)
                //        MensajeError(this, "No se pudo borrar el autor porque tiene asistencias registradas.");
                //    else
                //        throw (new Exception("No se pudo borrar el autor porque tiene asistencias registradas."));
                //    return false;
                //}

                if (trans == null)
                {
                    trans = new HC.Transaction(IsolationLevel.ReadCommitted, "Libro");
                    CierraTrans = true;
                }
                trans.Add(_Entidad);

                if (_Entidad.Delete())
                {
                    if (CierraTrans) trans.Commit();
                    return true;
                }
                if (CierraTrans) trans.Rollback();
                if (MensajeError != null)
                    MensajeError(this, "El libro no se pudo borrar.");
                else
                    throw (new Exception("El libro no se pudo borrar."));
            }
            catch (Exception ex)
            {
                if (CierraTrans) trans.Rollback();
                if (MensajeError != null)
                    MensajeError(this, ex.Message);
                else
                    throw (ex);
            }
            return false;
        }

        public new Boolean Guardar()
        {
            LibroCol Coleccion = new LibroCol();
            EC.LibroEntity Entity = new EC.LibroEntity();
            if (_Entidad.IsNew)
            {
                OC.PredicateExpression filtro = new OC.PredicateExpression();
                filtro.Add(HC.LibroFields.Id == _Entidad.Id);
                filtro.AddWithOr(HC.LibroFields.Titulo == _Entidad.Titulo);
                if (Coleccion.Obtener(filtro) > 0)
                {
                    if (MensajeError != null)
                        MensajeError(this, "El libro ya ha sido capturado.");
                    else
                        throw (new Exception("El libro ya ha sido capturado."));
                    return false;
                }
            }
            return _Entidad.Save();
        }

        public Boolean Obtener(object Codigo)
        {
            try
            {
                if (_Entidad.FetchUsingPK((int)Codigo))
                {
                    if (Modificado!=null) Modificado(this, new EventArgs());
                    return true;
                }
                if (MensajeError != null)
                    MensajeError(this, "El Libro especificado no existe.");
                else
                    throw (new Exception("El Libro especificado no existe."));
                return false;
            }
            catch (Exception ex)
            {
                if (MensajeError != null)
                    MensajeError(this, ex.Message);
                else
                    throw (ex);
            }
            return false;
        }

    #endregion

    }

    public class LibroCol : CN.ColleccionBase<EC.LibroEntity, CC.LibroCollection, CN.Libro>
    {
        private CC.LibroCollection Coleccion = new CC.LibroCollection();
        private OC.PredicateExpression Filtro;
        public event CN.MensajeErrorHandler MensajeError;

        public LibroCol()
        {            
        }

        public Object Borrar()
        {
            try
            {
                int Conteo = base.Borrar();
                return Conteo;
            }
                catch (Exception ex)
            {
                if (MensajeError != null)
                    MensajeError(this, ex.Message);
                else
                    throw (ex);
                return -1;
            }
        }

        public object Guardar()
        {
            try
            {
                int Conteo = base.Guardar();
                return Conteo;
            }
            catch (Exception ex)
            {
                if (MensajeError != null)
                    MensajeError(this, ex.Message);
                else
                    throw (ex);
                return -1;
            }
        }

        public int Obtener(Libro elem)
        {
            try
            {
                this.ClearItems();
                Filtro = new SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression();
                Filtro.Add(HC.LibroFields.Id == elem.Id);
                Filtro.AddWithOr(HC.LibroFields.Titulo == elem.Titulo);
                int Conteo = Coleccion.GetDbCount(Filtro);
                if (Conteo > 0)
                {
                    Coleccion.GetMulti(Filtro);
                    foreach (EC.LibroEntity entity in Coleccion)
                    {
                        CN.Libro MiEvento = new CN.Libro();
                        MiEvento.LeerEntidad(entity);
                        this.Add(MiEvento);
                    }
                }
                return Conteo;
            }
            catch (Exception ex)
            {
                if (MensajeError != null)
                    MensajeError(this, ex.Message);
                else
                    throw (ex);
                return -1;
            }
        }

        public String[] Listar()
        {
            List<String> lista = new List<String>();
            foreach (Libro elem in this)
            {
                lista.Add(elem.Titulo);
            }
            return lista.ToArray();
        }
    }


}
