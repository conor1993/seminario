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
using System.Windows.Forms;
namespace ClasesNegocio
{
    public class Lectores : CN.ClassBase<EC.LectoresEntity>, IEntidad
    {
        public event CN.MensajeErrorHandler MensajeError;
        public event EventHandler Modificado;

        #region constructores
        public Lectores(){
            _Entidad = new EC.LectoresEntity();
        }
        public Lectores(EC.LectoresEntity Entity){
            _Entidad = Entity;
        }
        #endregion

        #region Propiedades
        [System.ComponentModel.DisplayName("ID")]
        public int Id
        {
            get { return _Entidad.IdLectores; }
            set { _Entidad.IdLectores = value; if (Modificado != null) Modificado(this, new EventArgs()); }
        }

        [System.ComponentModel.DisplayName("Matricula")]
        public string Matricula
        {
            get { return _Entidad.Matricula; }
            set { _Entidad.Matricula = value; if (Modificado != null) Modificado(this, new EventArgs()); }
        }

        [System.ComponentModel.DisplayName("Nombre")]
        public string Nombre
        {
            get { return _Entidad.Nombre; }
            set { _Entidad.Nombre = value; if (Modificado != null) Modificado(this, new EventArgs()); }
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

        [System.ComponentModel.DisplayName("Sexo")]
        public string Sexo
        {
            get { return _Entidad.Sexo; }
            set { _Entidad.Sexo = value; if (Modificado != null) Modificado(this, new EventArgs()); }
        }

        [System.ComponentModel.DisplayName("Grupo")]
        public string Grupo
        {
            get { return _Entidad.Grupo; }
            set { _Entidad.Grupo = value; if (Modificado != null) Modificado(this, new EventArgs()); }
        }

        [System.ComponentModel.DisplayName("fecha_nacimiento")]
        public System.DateTime? FechaNacimiento
        {
           
            get { return _Entidad.FechaNacimiento; }
            set { _Entidad.FechaNacimiento = value; if (Modificado != null) Modificado(this, new EventArgs()); }
        }

        [System.ComponentModel.DisplayName("calle")]
        public string CalleNumero
        {
            get { return _Entidad.CalleNumero; }
            set { _Entidad.CalleNumero = value; if (Modificado != null) Modificado(this, new EventArgs()); }
        }

        [System.ComponentModel.DisplayName("ciduad")]
        public string Ciudad
        {
            get { return _Entidad.Ciudad; }
            set { _Entidad.Ciudad = value; if (Modificado != null) Modificado(this, new EventArgs()); }
        }

        [System.ComponentModel.DisplayName("Estado")]
        public string Estado
        {
            get { return _Entidad.Estado; }
            set { _Entidad.Estado = value; if (Modificado != null) Modificado(this, new EventArgs()); }
        }

        [System.ComponentModel.DisplayName("Telefono")]
        public string Telefono
        {
            get { return _Entidad.Telefono; }
            set { _Entidad.Telefono = value; if (Modificado != null) Modificado(this, new EventArgs()); }
        }

        [System.ComponentModel.DisplayName("Celular")]
        public string Celular
        {
            get { return _Entidad.Celular; }
            set { _Entidad.Celular = value; if (Modificado != null) Modificado(this, new EventArgs()); }
        }

        [System.ComponentModel.DisplayName("Facultad")]
        public string Facultad
        {
            get { return _Entidad.Facultad; }
            set { _Entidad.Facultad = value; if (Modificado != null) Modificado(this, new EventArgs()); }
        }

        [System.ComponentModel.DisplayName("fecha_alta")]
        public System.DateTime? FechaAlta
        {

            get { return _Entidad.FechaAlta; }
            set { _Entidad.FechaAlta = value; if (Modificado != null) Modificado(this, new EventArgs()); }
        }

        [System.ComponentModel.DisplayName("fecha_baja")]
        public System.DateTime? FechaBaja
        {

            get { return _Entidad.FechaBaja; }
            set { _Entidad.FechaBaja = value; if (Modificado != null) Modificado(this, new EventArgs()); }
        }

        [System.ComponentModel.DisplayName("fecha_Vijencia")]
        public System.DateTime? FechaVigencia
        {

            get { return _Entidad.FechaVigencia; }
            set { _Entidad.FechaVigencia = value; if (Modificado != null) Modificado(this, new EventArgs()); }
        }

        [System.ComponentModel.DisplayName("baja")]
        public bool? Baja
        {

            get { return _Entidad.Baja; }
            set { _Entidad.Baja = value; if (Modificado != null) Modificado(this, new EventArgs()); }
        }

        [System.ComponentModel.DisplayName("suspendido")]
        public bool? Suspendido
        {

            get { return _Entidad.Suspendido; }
            set { _Entidad.Suspendido = value; if (Modificado != null) Modificado(this, new EventArgs()); }
        }

        [System.ComponentModel.DisplayName("MotivoBaja")]
        public string MotivoBaja
        {
            get { return _Entidad.MotivoBaja; }
            set { _Entidad.MotivoBaja = value; if (Modificado != null) Modificado(this, new EventArgs()); }
        }

        [System.ComponentModel.DisplayName("MotivoSuspendido")]
        public string MotivoSuspendido
        {
            get { return _Entidad.MotivoSuspendido; }
            set { _Entidad.MotivoSuspendido = value; if (Modificado != null) Modificado(this, new EventArgs()); }
        }

        [System.ComponentModel.DisplayName("InicioSuspension")]
        public System.DateTime? InicioSuspension
        {

            get { return _Entidad.InicioSuspension; }
            set { _Entidad.InicioSuspension = value; if (Modificado != null) Modificado(this, new EventArgs()); }
        }

        [System.ComponentModel.DisplayName("DiasSuspension")]
        public int? DiasSuspension
        {
            get { return _Entidad.DiasSuspension; }
            set { _Entidad.DiasSuspension = value; if (Modificado != null) Modificado(this, new EventArgs()); }
        }

        [System.ComponentModel.DisplayName("Observaciones")]
        public string Observaciones
        {
            get { return _Entidad.Observaciones; }
            set { _Entidad.Observaciones = value; if (Modificado != null) Modificado(this, new EventArgs()); }
        }

        [System.ComponentModel.DisplayName("cp")]
        public int? Cp
        {
            get { return _Entidad.Cp; }
            set { _Entidad.Cp = value; if (Modificado != null) Modificado(this, new EventArgs()); }
        }

        [System.ComponentModel.DisplayName("Facebook")]
        public string Facebook
        {
            get { return _Entidad.Facebook; }
            set { _Entidad.Facebook = value; if (Modificado != null) Modificado(this, new EventArgs()); }
        }

        [System.ComponentModel.DisplayName("Numero")]
        public int? Numero
        {
            get { return _Entidad.Numero; }
            set { _Entidad.Numero = value; if (Modificado != null) Modificado(this, new EventArgs()); }
        }

        [System.ComponentModel.DisplayName("email")]
        public string Email
        {
            get { return _Entidad.Email; }
            set { _Entidad.Email = value; if (Modificado != null) Modificado(this, new EventArgs()); }
        }


        [System.ComponentModel.DisplayName("Colonia")]
        public string Colonia
        {
            get { return _Entidad.Colonia; }
            set { _Entidad.Colonia = value; if (Modificado != null) Modificado(this, new EventArgs()); }
        }



        #endregion


        public new Boolean Guardar()
        {
            LectoresCol Coleccion = new LectoresCol();
            EC.LectoresEntity Entity = new EC.LectoresEntity();
            if (_Entidad.IsNew)
            {
                OC.PredicateExpression filtro = new OC.PredicateExpression();
                filtro.Add(HC.LectoresFields.IdLectores == _Entidad.IdLectores);
                if (Coleccion.Obtener(filtro) > 0)
                {
                    if (MensajeError != null)
                        MensajeError(this, "El lector ya ha sido capturado.");
                    else
                        throw (new Exception("El lector ya ha sido capturado."));
                    return false;
                }
            }
            return _Entidad.Save();

        }

       public Boolean Borrar()
        {
            throw new NotImplementedException();
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
                    MensajeError(this, "El lector no existe.");
                else
                    throw (new Exception("El lector no existe."));
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
    }

    public class LectoresCol : CN.ColleccionBase<EC.LectoresEntity, CC.LectoresCollection, CN.Lectores>
    {
        private CC.LectoresCollection Coleccion = new CC.LectoresCollection();
        private OC.PredicateExpression Filtro;
        public event CN.MensajeErrorHandler MensajeError;

        public LectoresCol() {
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

        public int Obtener(Lectores elem)
        {
            try
            {
                this.ClearItems();
                Filtro = new SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression();
                Filtro.Add(HC.LectoresFields.IdLectores == elem.Id);
                int Conteo = Coleccion.GetDbCount(Filtro);
                if (Conteo > 0)
                {
                    Coleccion.GetMulti(Filtro);
                    foreach (EC.LectoresEntity entity in Coleccion)
                    {
                        CN.Lectores MiEvento = new CN.Lectores();
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
    
    }
}
