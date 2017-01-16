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
    public enum EstatusEvento
    {
        INACTIVO=0,
        ACTIVO=1,
        ENPROCESO=2,
        CONCLUIDO=3
    }
    
    public class Evento : CN.ClassBase <EC.EventoEntity>, IEntidad
    {
        public event CN.MensajeErrorHandler MensajeError;
        public event EventHandler Modificado;

    #region Constructores
        public Evento()
        {
            _Entidad = new EC.EventoEntity();
        }

        public Evento(EC.EventoEntity Entity)
        {
            _Entidad = Entity;
        }

    #endregion

    #region Propiedades
        [System.ComponentModel.DisplayName("ID")]
        public string Id
        {
            get { return _Entidad.Id; }
            set { _Entidad.Id = value; if (Modificado!=null) Modificado(this, new EventArgs()); }
        }

        [System.ComponentModel.DisplayName("Año")]
        public int Año
        {
            get { return _Entidad.Ano; }
            set { _Entidad.Ano = value; if (Modificado != null) Modificado(this, new EventArgs()); }
        }

        [System.ComponentModel.DisplayName("Fecha Inicio")]
        public DateTime FechaInicio
        {
            get { return _Entidad.FechaInicio; }
            set { _Entidad.FechaInicio = value; if (Modificado != null) Modificado(this, new EventArgs()); }
        }

        [System.ComponentModel.DisplayName("Fecha Fin")]
        public DateTime FechaFin
        {
            get { return _Entidad.FechaFin; }
            set { _Entidad.FechaFin = value; if (Modificado != null) Modificado(this, new EventArgs()); }
        }

        [System.ComponentModel.DisplayName("Nombre")]
        public string Nombre
        {
            get { return _Entidad.Nombre; }
            set { _Entidad.Nombre = value; if (Modificado != null) Modificado(this, new EventArgs()); }
        }

        [System.ComponentModel.DisplayName("Seccion")]
        public Nullable<Boolean> Seccion
        {
            get { return _Entidad.Seccion; }
            set { _Entidad.Seccion = value; if (Modificado != null) Modificado(this, new EventArgs()); }
        }

        [System.ComponentModel.DisplayName("Estatus")]
        public int Estatus
        {
            get { return _Entidad.Estatus; }
            set { _Entidad.Estatus = value; if (Modificado != null) Modificado(this, new EventArgs()); }
        }

        [System.ComponentModel.DisplayName("Lugar")]
        public string Lugar
        {
            get { return _Entidad.LugarEvento; }
            set { _Entidad.LugarEvento = value; if (Modificado != null) Modificado(this, new EventArgs()); }
        }

    #endregion

    #region Metodos

        public Boolean Borrar(HC.Transaction trans = null)
        {
            Boolean CierraTrans = false;
            try
            {
                if (_Entidad.EquiposDeTrabajo.Count > 0)
                {
                    if (MensajeError != null)
                        MensajeError(this, "No se pudo borrar el evento porque tiene equipos de trabajo.");
                    else
                        throw (new Exception("No se pudo borrar el evento porque tiene equipos de trabajo."));
                    return false;
                }

                if (_Entidad.Asistencias.Count > 0)
                {
                    if (MensajeError != null)
                        MensajeError(this, "No se pudo borrar el evento porque tiene asistencias registradas.");
                    else
                        throw (new Exception("No se pudo borrar el evento porque tiene asistencias registradas."));
                    return false;
                }

                if (trans == null)
                {
                    trans = new HC.Transaction(IsolationLevel.ReadCommitted, "Evento");
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
                    MensajeError(this, "El evento no se pudo borrar.");
                else
                    throw (new Exception("El evento no se pudo borrar."));
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
            EventoCol Coleccion = new EventoCol();
            EC.EventoEntity Entity = new EC.EventoEntity();
            if (_Entidad.IsNew)
            {
                OC.PredicateExpression filtro = new OC.PredicateExpression();
                filtro.Add(HC.EventoFields.Id == _Entidad.Id);
                filtro.AddWithOr(HC.EventoFields.Nombre == _Entidad.Nombre);
                if (Coleccion.Obtener(filtro) > 0)
                {
                    if (MensajeError != null)
                        MensajeError(this, "El evento ya ha sido capturado.");
                    else
                        throw (new Exception("El evento ya ha sido capturado."));
                    return false;
                }
            }
            return _Entidad.Save();
        }

        public Boolean Obtener(object Codigo)
        {
            try
            {
                if (_Entidad.FetchUsingPK((string)Codigo))
                {
                    if (Modificado!=null) Modificado(this, new EventArgs());
                    return true;
                }
                if (MensajeError != null)
                    MensajeError(this, "El Evento especificado no existe.");
                else
                    throw (new Exception("El Evento especificado no existe."));
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

    public class EventoCol : CN.ColleccionBase<EC.EventoEntity, CC.EventoCollection, CN.Evento>
    {
        private CC.EventoCollection Coleccion = new CC.EventoCollection();
        private OC.PredicateExpression Filtro;
        public event CN.MensajeErrorHandler MensajeError;

        public EventoCol()
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

        public int Obtener(CN.CondicionEnum FcCondicion)
        {
            try
            {
                this.ClearItems();

                if (FcCondicion == CondicionEnum.TODOS)
                    Coleccion.GetMulti(null);
                else
                    Coleccion.GetMulti(HC.EventoFields.Estatus == FcCondicion);
                
                foreach (EC.EventoEntity entity in Coleccion)
                {
                    Evento evento = new Evento();
                    evento.LeerEntidad(entity);
                    this.Add(evento);
                }
                return this.Count;
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

        public int Obtener(Evento evento)
        {
            try
            {
                this.ClearItems();
                Filtro = new SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression();
                Filtro.Add(HC.EventoFields.Id == evento.Id);
                Filtro.AddWithOr(HC.EventoFields.Nombre == evento.Nombre);
                int Conteo = Coleccion.GetDbCount(Filtro);
                if (Conteo > 0)
                {
                    Coleccion.GetMulti(Filtro);
                    foreach (EC.EventoEntity entity in Coleccion)
                    {
                        CN.Evento MiEvento = new CN.Evento();
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
            foreach (Evento evento in this)
            {
                lista.Add(evento.Id);
            }
            return lista.ToArray();
        }
    }
}
