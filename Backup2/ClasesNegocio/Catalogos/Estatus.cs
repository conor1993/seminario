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
    public class Estatus : CN.ClassBase<EC.LibroEstatusEntity>, IEntidad
    {
        public event CN.MensajeErrorHandler MensajeError;
        public event EventHandler Modificado;

            #region Constructores
        public Estatus()
        {
            _Entidad = new EC.LibroEstatusEntity();
        }

        public Estatus(EC.LibroEstatusEntity Entity)
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
        public string Estado
        {
            get { return _Entidad.Estado; }
            set { _Entidad.Estado = value; if (Modificado != null) Modificado(this, new EventArgs()); }
        }
        #endregion

        #region metodos
        public new Boolean Guardar()
        {

            EstatusCol Coleccion = new EstatusCol();
            EC.LibroEstatusEntity Entity = new EC.LibroEstatusEntity();
            if (_Entidad.IsNew)
            {
                OC.PredicateExpression filtro = new OC.PredicateExpression();
                filtro.Add(HC.LibroEstatusFields.Estado == _Entidad.Estado);
                if (Coleccion.Obtener(filtro) > 0)
                {
                    if (MensajeError != null)
                    {
                        MensajeError(this, "El Estatus ya ha sido capturado.");

                    }
                    else
                    {
                        throw (new Exception("El Estatus ya ha sido capturado."));
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

    public class EstatusCol : CN.ColleccionBase<EC.LibroEstatusEntity, CC.LibroEstatusCollection, CN.Estatus>
    {
        private CC.LibroEstatusCollection Coleccion = new CC.LibroEstatusCollection();
        private OC.PredicateExpression Filtro;
        public event CN.MensajeErrorHandler MensajeError;

        public EstatusCol()
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

        public int Obtener(Estatus elem)
        {
           
               
            try
            {
                this.ClearItems();
                Filtro = new SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression();
                Filtro.Add(HC.LibroEstatusFields.Id == elem.Id);
                Filtro.Add(HC.LibroEstatusFields.Estado == elem.Estado);
                int Conteo = Coleccion.GetDbCount(Filtro);
                if (Conteo > 0)
                {
                    Coleccion.GetMulti(Filtro);
                    foreach (EC.LibroEstatusEntity entity in Coleccion)
                    {
                        CN.Estatus MiEvento = new CN.Estatus();
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
            foreach (Estatus elem in this)
            {
                lista.Add(elem.Estado);
            }
            return lista.ToArray();
        }
    }



}
