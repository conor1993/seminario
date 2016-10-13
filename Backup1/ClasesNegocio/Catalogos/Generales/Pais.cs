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
    
    public class Pais : CN.ClassBase <EC.PaisEntity>, IEntidad
    {
        public event CN.MensajeErrorHandler MensajeError;
        public event EventHandler Modificado;
        private AutorCol _Autores;
        private LibroCol _Libros;

    #region Constructores
        public Pais()
        {
            _Entidad = new EC.PaisEntity();
        }

        public Pais(EC.PaisEntity Entity)
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

        [System.ComponentModel.DisplayName("Nombre")]
        public string Nombre
        {
            get { return _Entidad.Nombre; }
            set { _Entidad.Nombre = value; if (Modificado != null) Modificado(this, new EventArgs()); }
        }

        [System.ComponentModel.DisplayName("Autores")]
        public AutorCol Autores
        {
            get
            {
                if (_Autores == null)
                    _Autores = new AutorCol();
                    _Autores.RellenarMe(_Entidad.Autores);
                return _Autores;
            }
            set
            {
                if (_Autores != null)
                {
                    _Autores.Clear();
                }
                _Autores = value;
                if (Modificado != null) Modificado(this, new EventArgs());
            }
        }

        [System.ComponentModel.DisplayName("Libros")]
        public LibroCol Libros
        {
            get
            {
                if (_Libros == null)
                    _Libros = new LibroCol();
                    _Libros.RellenarMe(_Entidad.Libros);
                return _Libros;
            }
            set
            {
                if (_Libros != null)
                {
                    _Libros.Clear();
                }
                _Libros = value;
                if (Modificado != null) Modificado(this, new EventArgs());
            }
        }

    #endregion

    #region Metodos
        public Boolean Borrar(HC.Transaction trans = null)
        {
            Boolean CierraTrans = false;
            try
            {
                if (_Entidad.Libros.Count > 0)
                {
                    if (MensajeError != null)
                        MensajeError(this, "No se pudo borrar el país porque hay libros de este país.");
                    else
                        throw (new Exception("No se pudo borrar el país porque hay libros de este país."));
                    return false;
                }

                if (_Entidad.Autores.Count > 0)
                {
                    if (MensajeError != null)
                        MensajeError(this, "No se pudo borrar el país porque tiene autores registrados.");
                    else
                        throw (new Exception("No se pudo borrar el país porque tiene autores registrados."));
                    return false;
                }

                if (trans == null)
                {
                    trans = new HC.Transaction(IsolationLevel.ReadCommitted, "Pais");
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
                    MensajeError(this, "El país no se pudo borrar.");
                else
                    throw (new Exception("El país no se pudo borrar."));
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
            PaisCol Coleccion = new PaisCol();
            EC.PaisEntity Entity = new EC.PaisEntity();
            if (_Entidad.IsNew)
            {
                OC.PredicateExpression filtro = new OC.PredicateExpression();
                filtro.Add(HC.PaisFields.Id == _Entidad.Id);
                filtro.AddWithOr(HC.PaisFields.Nombre == _Entidad.Nombre);
                if (Coleccion.Obtener(filtro) > 0)
                {
                    if (MensajeError != null)
                        MensajeError(this, "El país ya ha sido capturado.");
                    else
                        throw (new Exception("El país ya ha sido capturado."));
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
                    MensajeError(this, "El Pais especificado no existe.");
                else
                    throw (new Exception("El Pais especificado no existe."));
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

    public class PaisCol : CN.ColleccionBase<EC.PaisEntity, CC.PaisCollection, CN.Pais>
    {
        private CC.PaisCollection Coleccion = new CC.PaisCollection();
        private OC.PredicateExpression Filtro;
        public event CN.MensajeErrorHandler MensajeError;

        public PaisCol()
        {            
        }

        public int Guardar()
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

        public int Obtener(Pais elem)
        {
            try
            {
                this.ClearItems();
                Filtro = new SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression();
                Filtro.Add(HC.PaisFields.Id == elem.Id);
                Filtro.AddWithOr(HC.PaisFields.Nombre == elem.Nombre);
                int Conteo = Coleccion.GetDbCount(Filtro);
                if (Conteo > 0)
                {
                    Coleccion.GetMulti(Filtro);
                    foreach (EC.PaisEntity entity in Coleccion)
                    {
                        CN.Pais MiElem = new CN.Pais();
                        MiElem.LeerEntidad(entity);
                        this.Add(MiElem);
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
            foreach (Pais elem in this)
            {
                lista.Add(elem.Nombre);
            }
            return lista.ToArray();
        }
    }
}
