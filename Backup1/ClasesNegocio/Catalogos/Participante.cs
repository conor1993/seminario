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
    
    public class Participante : CN.ClassBase <EC.ParticipanteEntity>, IEntidad
    {
        public event CN.MensajeErrorHandler MensajeError;
        public event EventHandler Modificado;

    #region Constructores
        public Participante()
        {
            _Entidad = new EC.ParticipanteEntity();
        }

        public Participante(EC.ParticipanteEntity Entity)
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

        [System.ComponentModel.DisplayName("Apellido Paterno")]
        public string ApellidoPaterno
        {
            get { return _Entidad.ApellidoPaterno; }
            set { _Entidad.ApellidoPaterno = value; if (Modificado != null) Modificado(this, new EventArgs()); }
        }

        [System.ComponentModel.DisplayName("Apellido Materno")]
        public string ApellidoMaterno
        {
            get { return _Entidad.ApellidoMaterno; }
            set { _Entidad.ApellidoMaterno = value; if (Modificado != null) Modificado(this, new EventArgs()); }
        }

        [System.ComponentModel.DisplayName("Nombre(s)")]
        public string Nombre
        {
            get { return _Entidad.Nombre; }
            set { _Entidad.Nombre = value; if (Modificado != null) Modificado(this, new EventArgs()); }
        }
        
        [System.ComponentModel.DisplayName("Fecha Inicio")]
        public DateTime FechaNacim
        {
            get { return _Entidad.FechaNacim; }
            set { _Entidad.FechaNacim = value; if (Modificado != null) Modificado(this, new EventArgs()); }
        }

        [System.ComponentModel.DisplayName("Aceptado")]
        public CN.AceptadoEnum Aceptado
        {
            get { return (CN.AceptadoEnum) _Entidad.Aceptado; }
            set { _Entidad.Aceptado = (short)value; if (Modificado != null) Modificado(this, new EventArgs()); }
        }

        [System.ComponentModel.DisplayName("Nombre del Padre")]
        public string NombrePadre
        {
            get { return _Entidad.NombrePadre; }
            set { _Entidad.NombrePadre = value; if (Modificado != null) Modificado(this, new EventArgs()); }
        }

        [System.ComponentModel.DisplayName("Nombre de la Madre")]
        public string NombreMadre
        {
            get { return _Entidad.NombreMadre; }
            set { _Entidad.NombreMadre = value; if (Modificado != null) Modificado(this, new EventArgs()); }
        }

        [System.ComponentModel.DisplayName("Vive el Padre")]
        public bool? VivePadre
        {
            get { return _Entidad.VivePadre; }
            set { _Entidad.VivePadre = value; if (Modificado != null) Modificado(this, new EventArgs()); }
        }

        [System.ComponentModel.DisplayName("Vive la Madre")]
        public bool? ViveMadre
        {
            get { return _Entidad.ViveMadre; }
            set { _Entidad.ViveMadre = value; if (Modificado != null) Modificado(this, new EventArgs()); }
        }

        [System.ComponentModel.DisplayName("Estado Civil Padres")]
        public CN.EdoCivilEnum? EdoCivilPadres
        {
            get { return (CN.EdoCivilEnum)(_Entidad.EdoCivilPadres == null ? 0 : _Entidad.EdoCivilPadres); }
            set { _Entidad.EdoCivilPadres = (int?)value; if (Modificado != null) Modificado(this, new EventArgs()); }
        }

        [System.ComponentModel.DisplayName("Hermanos")]
        public int? NumHermanos
        {
            get { return _Entidad.Hermanos; }
            set { _Entidad.Hermanos = value; if (Modificado != null) Modificado(this, new EventArgs()); }
        }

        [System.ComponentModel.DisplayName("Hermanas")]
        public int? NumHermanas
        {
            get { return _Entidad.Hermanas; }
            set { _Entidad.Hermanas = value; if (Modificado != null) Modificado(this, new EventArgs()); }
        }

        [System.ComponentModel.DisplayName("Lugar en orden de nacimiento")]
        public int? OrdenNacimiento
        {
            get { return _Entidad.OrdenNacimiento; }
            set { _Entidad.OrdenNacimiento = value; if (Modificado != null) Modificado(this, new EventArgs()); }
        }

        [System.ComponentModel.DisplayName("Confirmación")]
        public bool? Confirmado
        {
            get { return _Entidad.Confirmacion; }
            set { _Entidad.Confirmacion = value; if (Modificado != null) Modificado(this, new EventArgs()); }
        }

        [System.ComponentModel.DisplayName("Primera comunión")]
        public bool? PrimeraComunion
        {
            get { return _Entidad.PrimeraComunion; }
            set { _Entidad.PrimeraComunion = value; if (Modificado != null) Modificado(this, new EventArgs()); }
        }

        [System.ComponentModel.DisplayName("Deportes que practica")]
        public string Deportes
        {
            get { return _Entidad.Deportes; }
            set { _Entidad.Deportes = value; if (Modificado != null) Modificado(this, new EventArgs()); }
        }

        [System.ComponentModel.DisplayName("Instrumentos que toca")]
        public string Instrumentos
        {
            get { return _Entidad.Instrumentos; }
            set { _Entidad.Instrumentos = value; if (Modificado != null) Modificado(this, new EventArgs()); }
        }
    #endregion

    #region Metodos

        public Boolean Borrar(HC.Transaction trans = null)
        {
            Boolean CierraTrans = false;
            try
            {
                if (_Entidad.Asistencias.Count > 0)
                {
                    if (MensajeError != null)
                        MensajeError(this, "No se pudo borrar el participante porque tiene registrada asistencia a eventos.");
                    else
                        throw (new Exception("No se pudo borrar el participante porque tiene registrada asistencia a eventos."));
                    return false;
                }

                if (trans == null)
                {
                    trans = new HC.Transaction(IsolationLevel.ReadCommitted, "Participante");
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
                    MensajeError(this, "El participante no se pudo borrar.");
                else
                    throw (new Exception("El participante no se pudo borrar."));
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
            ParticipanteCol Coleccion = new ParticipanteCol();
            EC.ParticipanteEntity Entity = new EC.ParticipanteEntity();
            if (_Entidad.IsNew)
            {
                OC.PredicateExpression filtro = new OC.PredicateExpression();
                filtro.Add(HC.ParticipanteFields.Id == _Entidad.Id);
                if (Coleccion.Obtener(filtro) > 0)
                {
                    if (MensajeError != null)
                        MensajeError(this, "El Id de participante ya existe.");
                    else
                        throw (new Exception("El Id de participante ya existe."));
                    return false;
                }

                filtro = new OC.PredicateExpression();
                filtro.Add(HC.ParticipanteFields.Nombre == _Entidad.Nombre);
                filtro.AddWithAnd(HC.ParticipanteFields.ApellidoPaterno == _Entidad.ApellidoPaterno);
                filtro.AddWithAnd(HC.ParticipanteFields.ApellidoMaterno == _Entidad.ApellidoMaterno);
                if (Coleccion.Obtener(filtro) > 0)
                {
                    if (MensajeError != null)
                        MensajeError(this, "El participante ya ha sido capturado.");
                    else
                        throw (new Exception("El participante ya ha sido capturado."));
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
                    if (Modificado != null) Modificado(this, new EventArgs());
                    return true;
                }
                if (MensajeError != null)
                    MensajeError(this, "El Participante especificado no existe.");
                else
                    throw (new Exception("El Participante especificado no existe."));
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

    public class ParticipanteCol : CN.ColleccionBase<EC.ParticipanteEntity, CC.ParticipanteCollection, CN.Participante>
    {
        private CC.ParticipanteCollection Coleccion = new CC.ParticipanteCollection();
        private OC.PredicateExpression Filtro;
        public event CN.MensajeErrorHandler MensajeError;

        public ParticipanteCol()
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

        public int Obtener(Participante participante)
        {
            try
            {
                this.ClearItems();
                Filtro = new SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression();
                Filtro.Add(HC.ParticipanteFields.Id == participante.Id);
                int Conteo = Coleccion.GetDbCount(Filtro);
                if (Conteo > 0)
                {
                    Coleccion.GetMulti(Filtro);
                    foreach (EC.ParticipanteEntity entity in Coleccion)
                    {
                        CN.Participante MiParticipante = new CN.Participante();
                        MiParticipante.LeerEntidad(entity);
                        this.Add(MiParticipante);
                    }
                    return Conteo;
                }

                Filtro = new SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression();
                Filtro.Add(HC.ParticipanteFields.Nombre == participante.Nombre);
                Filtro.AddWithAnd(HC.ParticipanteFields.ApellidoPaterno == participante.ApellidoPaterno);
                Filtro.AddWithAnd(HC.ParticipanteFields.ApellidoMaterno == participante.ApellidoMaterno);
                Conteo = Coleccion.GetDbCount(Filtro);
                if (Conteo > 0)
                {
                    Coleccion.GetMulti(Filtro);
                    foreach (EC.ParticipanteEntity entity in Coleccion)
                    {
                        CN.Participante MiParticipante = new CN.Participante();
                        MiParticipante.LeerEntidad(entity);
                        this.Add(MiParticipante);
                    }
                    return Conteo;
                }
                return 0;
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
            foreach (Participante participante in this)
            {
                lista.Add(participante.Nombre.Trim()+" "+participante.ApellidoPaterno.Trim()+" "+participante.ApellidoMaterno.Trim());
            }
            return lista.ToArray();
        }
    }
}
