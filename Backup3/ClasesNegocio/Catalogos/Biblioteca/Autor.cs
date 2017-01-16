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
    public class Autor : CN.ClassBase <EC.AutorEntity>, IEntidad
    {
        public event CN.MensajeErrorHandler MensajeError;
        public event EventHandler Modificado;

        private LibroCol _Libros;
        private Pais _Pais;

    #region Constructores
        public Autor()
        {
            _Entidad = new EC.AutorEntity();
        }

        public Autor(EC.AutorEntity Entity)
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

        [System.ComponentModel.DisplayName("ID País")]
        public int? IdPais
        {
            get { return _Entidad.IdPais; }
            set { _Entidad.IdPais = value; if (Modificado != null) Modificado(this, new EventArgs()); }
        }

        [System.ComponentModel.DisplayName("País")]
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
                if (value == null)
                    _Entidad.Pais = null;
                    //_Entidad.IdPais = null;
                else
                    _Entidad.Pais = value.ObtenerEntidad();
                    //_Entidad.IdPais = value.Id;
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
                        MensajeError(this, "No se pudo borrar el autor porque tiene libros registrados.");
                    else
                        throw (new Exception("No se pudo borrar el autor porque tiene libros registrados."));
                    return false;
                }

                if (trans == null)
                {
                    trans = new HC.Transaction(IsolationLevel.ReadCommitted, "Autor");
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
                    MensajeError(this, "El autor no se pudo borrar.");
                else
                    throw (new Exception("El autor no se pudo borrar."));
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
            AutorCol Coleccion = new AutorCol();
            EC.AutorEntity Entity = new EC.AutorEntity();
            if (_Entidad.IsNew)
            {
                OC.PredicateExpression filtro = new OC.PredicateExpression();
                filtro.Add(HC.AutorFields.Nombre == _Entidad.Nombre);
                if (Coleccion.Obtener(filtro) > 0)
                {
                    if (MensajeError != null)
                        MensajeError(this, "El autor ya ha sido capturado.");
                    else
                        throw (new Exception("El autor ya ha sido capturado."));
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
                    MensajeError(this, "El Autor especificado no existe.");
                else
                    throw (new Exception("El Autor especificado no existe."));
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

    public class AutorCol : CN.ColleccionBase<EC.AutorEntity, CC.AutorCollection, CN.Autor>
    {
        private CC.AutorCollection Coleccion = new CC.AutorCollection();
        private OC.PredicateExpression Filtro;
        public event CN.MensajeErrorHandler MensajeError;
        private OC.SortExpression sort = new OC.SortExpression(new OC.SortClause(HC.AutorFields.Nombre, OC.SortOperator.Ascending));


        public AutorCol()
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

        public int Obtener(Autor elem)
        {
            try
            {
                this.ClearItems();
                Filtro = new SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression();
                Filtro.Add(HC.AutorFields.Id == elem.Id);
                Filtro.AddWithOr(HC.AutorFields.Nombre == elem.Nombre);
                int Conteo = Coleccion.GetDbCount(Filtro);
                if (Conteo > 0)
                {
                    Coleccion.GetMulti(Filtro,0,sort);
                    foreach (EC.AutorEntity entity in Coleccion)
                    {
                        CN.Autor MiElem = new CN.Autor();
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

        public int Obtener(String nombre)
        {
            try
            {
                this.ClearItems();
                Filtro = new SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression();
                Filtro.AddWithOr(HC.AutorFields.Nombre == nombre);
                int Conteo = Coleccion.GetDbCount(Filtro);
                if (Conteo > 0)
                {
                    Coleccion.GetMulti(Filtro);
                    foreach (EC.AutorEntity entity in Coleccion)
                    {
                        CN.Autor MiElem = new CN.Autor();
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
            foreach (Autor elem in this)
            {
                lista.Add(elem.Nombre);
            }
            return lista.ToArray();
        }
    }
}
