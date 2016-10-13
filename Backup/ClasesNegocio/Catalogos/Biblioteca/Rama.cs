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
    public class Rama : CN.ClassBase <EC.RamaEntity>, IEntidad
    {
        public event CN.MensajeErrorHandler MensajeError;
        public event EventHandler Modificado;

        private TematicaCol _Tematicas;
        private Seccion _Seccion;

    #region Constructores
        public Rama()
        {
            _Entidad = new EC.RamaEntity();
        }

        public Rama(EC.RamaEntity Entity)
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

        [System.ComponentModel.DisplayName("ID Sección")]
        public int IdSeccion
        {
            get { return _Entidad.IdSeccion; }
            set { _Entidad.IdSeccion = value; if (Modificado != null) Modificado(this, new EventArgs()); }
        }

        [System.ComponentModel.DisplayName("Sección")]
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
                if (value==null)
                    _Entidad.Seccion = null;
                else
                    _Entidad.Seccion = value.ObtenerEntidad();
                if (Modificado != null) Modificado(this, new EventArgs());
            }
        }

        [System.ComponentModel.DisplayName("Temáticas")]
        public TematicaCol Tematicas
        {
            get
            {
                if (_Tematicas == null)
                    _Tematicas = new TematicaCol();
                    _Tematicas.RellenarMe(_Entidad.Tematicas);
                return _Tematicas;
            }
            set
            {
                if (_Tematicas != null)
                {
                    _Tematicas.Clear();
                }
                _Tematicas = value;
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
                if (_Entidad.Tematicas.Count > 0)
                {
                    if (MensajeError != null)
                        MensajeError(this, "No se pudo borrar la rama porque tiene temáticas registradas.");
                    else
                        throw (new Exception("No se pudo borrar la rama porque tiene temáticas registradas."));
                    return false;
                }

                if (trans == null)
                {
                    trans = new HC.Transaction(IsolationLevel.ReadCommitted, "Rama");
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
                    MensajeError(this, "La rama no se pudo borrar.");
                else
                    throw (new Exception("La rama no se pudo borrar."));
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
            RamaCol Coleccion = new RamaCol();
            EC.RamaEntity Entity = new EC.RamaEntity();
            if (_Entidad.IsNew)
            {
                OC.PredicateExpression filtro = new OC.PredicateExpression();
                filtro.Add(HC.RamaFields.Nombre == _Entidad.Nombre);
                if (Coleccion.Obtener(filtro) > 0)
                {
                    if (MensajeError != null)
                        MensajeError(this, "La rama ya ha sido capturada.");
                    else
                        throw (new Exception("La rama ya ha sido capturada."));
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
                    MensajeError(this, "La Rama especificada no existe.");
                else
                    throw (new Exception("La Rama especificada no existe."));
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

    public class RamaCol : CN.ColleccionBase<EC.RamaEntity, CC.RamaCollection, CN.Rama>
    {
        private CC.RamaCollection Coleccion = new CC.RamaCollection();
        private OC.PredicateExpression Filtro;
        public event CN.MensajeErrorHandler MensajeError;

        public RamaCol()
        { }

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

        public int Obtener(Rama elem)
        {
            try
            {
                this.ClearItems();
                Filtro = new SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression();
                Filtro.Add(HC.RamaFields.Id == elem.Id);
                Filtro.AddWithOr(HC.RamaFields.Nombre == elem.Nombre);
                int Conteo = Coleccion.GetDbCount(Filtro);
                if (Conteo > 0)
                {
                    Coleccion.GetMulti(Filtro);
                    foreach (EC.RamaEntity entity in Coleccion)
                    {
                        CN.Rama MiElem = new CN.Rama();
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
            foreach (Rama elem in this)
            {
                lista.Add(elem.Nombre);
            }
            return lista.ToArray();
        }
    }
}
