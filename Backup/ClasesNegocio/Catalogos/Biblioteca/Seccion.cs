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
    
    public class Seccion : CN.ClassBase <EC.SeccionEntity>, IEntidad
    {
        public event CN.MensajeErrorHandler MensajeError;
        public event EventHandler Modificado;
        private RamaCol _Ramas;

    #region Constructores
        public Seccion()
        {
            _Entidad = new EC.SeccionEntity();
        }

        public Seccion(EC.SeccionEntity Entity)
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

        [System.ComponentModel.DisplayName("Ramas")]
        public RamaCol Ramas
        {
            get
            {
                if (_Ramas == null)
                    _Ramas = new RamaCol();
                    _Ramas.RellenarMe(_Entidad.Ramas);
                return _Ramas;
            }
            set
            {
                if (_Ramas != null)
                {
                    _Ramas.Clear();
                }
                _Ramas = value;
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
                if (_Entidad.Ramas.Count > 0)
                {
                    if (MensajeError != null)
                        MensajeError(this, "No se pudo borrar la sección porque tiene ramas registradas.");
                    else
                        throw (new Exception("No se pudo borrar la sección porque tiene ramas registradas."));
                    return false;
                }

                if (trans == null)
                {
                    trans = new HC.Transaction(IsolationLevel.ReadCommitted, "Seccion");
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
                    MensajeError(this, "No se pudo borrar la sección.");
                else
                    throw (new Exception("No se pudo borrar la sección."));
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
            SeccionCol Coleccion = new SeccionCol();
            EC.SeccionEntity Entity = new EC.SeccionEntity();
            if (_Entidad.IsNew)
            {
                OC.PredicateExpression filtro = new OC.PredicateExpression();
                //filtro.Add(HC.EventoFields.Id == _Entidad.Id);
                filtro.Add(HC.SeccionFields.Nombre == _Entidad.Nombre);
                if (Coleccion.Obtener(filtro) > 0)
                {
                    if (MensajeError != null)
                        MensajeError(this, "La sección ya ha sido capturada.");
                    else
                        throw (new Exception("La sección ya ha sido capturada."));
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
                    MensajeError(this, "La sección especificada no existe.");
                else
                    throw (new Exception("La sección especificada no existe."));
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

    public class SeccionCol : CN.ColleccionBase<EC.SeccionEntity, CC.SeccionCollection, CN.Seccion>
    {
        private CC.SeccionCollection Coleccion = new CC.SeccionCollection();
        private OC.PredicateExpression Filtro;
        public event CN.MensajeErrorHandler MensajeError;

        public SeccionCol()
        {            
        }

        public int Borrar()
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

        public int Obtener(Seccion elem)
        {
            try
            {
                this.ClearItems();
                Filtro = new SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression();
                Filtro.Add(HC.EventoFields.Id == elem.Id);
                Filtro.AddWithOr(HC.EventoFields.Nombre == elem.Nombre);
                int Conteo = Coleccion.GetDbCount(Filtro);
                if (Conteo > 0)
                {
                    Coleccion.GetMulti(Filtro);
                    foreach (EC.SeccionEntity entity in Coleccion)
                    {
                        CN.Seccion MiEvento = new CN.Seccion();
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
            foreach (Seccion elem in this)
            {
                lista.Add(elem.Nombre);
            }
            return lista.ToArray();
        }
    }
}
