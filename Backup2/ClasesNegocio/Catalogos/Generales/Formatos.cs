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
    public class Formatos : CN.ClassBase<EC.LibroFormatoEntity>, IEntidad
    {

        public event CN.MensajeErrorHandler MensajeError;
        public event EventHandler Modificado;

        #region Constructores
        public Formatos()
        {
            _Entidad = new EC.LibroFormatoEntity();
        }

        public Formatos(EC.LibroFormatoEntity Entity)
        {
            _Entidad = Entity;
        }
        #endregion

        #region Propiedades
        [System.ComponentModel.DisplayName("ID")]
        public int Id
        {
            get { return _Entidad.Id; }
            set { _Entidad.Id = value; if (Modificado != null) Modificado(this, new EventArgs()); }
        }

        [System.ComponentModel.DisplayName("Nombre")]
        public string Formato
        {
            get { return _Entidad.Formato; }
            set { _Entidad.Formato = value; if (Modificado != null) Modificado(this, new EventArgs()); }
        }
        #endregion


        #region metodos
        public new Boolean Guardar()
        {
          
            FormatoCol Coleccion = new FormatoCol();
            EC.LibroFormatoEntity Entity = new EC.LibroFormatoEntity();
            if (_Entidad.IsNew)
            {
                OC.PredicateExpression filtro = new OC.PredicateExpression();
                filtro.Add(HC.LibroFormatoFields.Formato == _Entidad.Formato);
                if (Coleccion.Obtener(filtro) > 0)
                {
                    if (MensajeError != null)
                    {
                            MensajeError(this, "El F ormato ya ha sido capturado.");
                        
                    }
                    else
                    {
                           throw (new Exception("El Formato ya ha sido capturado."));
                    }
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
                    MensajeError(this, "El Formato especificado no existe.");
                else
                    throw (new Exception("El Formato especificado no existe."));
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

    public class FormatoCol : CN.ColleccionBase<EC.LibroFormatoEntity, CC.LibroFormatoCollection, CN.Formatos>
    {
        private CC.LibroFormatoCollection Coleccion = new CC.LibroFormatoCollection();
        private OC.PredicateExpression Filtro;
        public event CN.MensajeErrorHandler MensajeError;

        public FormatoCol()
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

        public int Obtener(Formatos elem)
        {
           
               
            try
            {
                this.ClearItems();
                Filtro = new SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression();
                Filtro.Add(HC.LibroFormatoFields.Id == elem.Id);
                Filtro.Add(HC.LibroFormatoFields.Formato == elem.Formato);
                int Conteo = Coleccion.GetDbCount(Filtro);
                if (Conteo > 0)
                {
                    Coleccion.GetMulti(Filtro);
                    foreach (EC.LibroFormatoEntity entity in Coleccion)
                    {
                        CN.Formatos MiEvento = new CN.Formatos();
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
