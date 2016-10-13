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
using ClasesNegocio;

namespace ClasesNegocio
{
    public class Estatus : CN.ClassBase<EC.LibroEstatusEntity>, IEntidad
    {

        public event CN.MensajeErrorHandler MensajeError;
        public event EventHandler Modificado;

        #region Constructores

            public Estatus(){

                    _Entidad = new EC.LibroEstatusEntity();
                }

            public Estatus(EC.LibroEstatusEntity Entity){

                    _Entidad = Entity;
                }

        #endregion

        #region propiedades

        [System.ComponentModel.DisplayName("Estado")]
        public string Estado
        {
            get { return _Entidad.Estado; }
            set { _Entidad.Estado = value; if (Modificado != null) Modificado(this, new EventArgs()); }
        }

        [System.ComponentModel.DisplayName("Id")]
        public int Id
        {
            get { return _Entidad.Id; }
            set { _Entidad.Id = value; if (Modificado != null) Modificado(this, new EventArgs()); }
        }

        #endregion

        #region metodos
       public new Boolean Guardar()
        {
            ColEstatus Coleccion = new ColEstatus();
            EC.LibroEstatusEntity Entity = new EC.LibroEstatusEntity();
            if (_Entidad.IsNew)
            {
                OC.PredicateExpression filtro = new OC.PredicateExpression();
                filtro.Add(HC.LibroEstatusFields.Id == _Entidad.Id);
                filtro.AddWithOr(HC.LibroEstatusFields.Estado == _Entidad.Estado);
                if (Coleccion.Obtener(filtro) > 0)
                {
                    if (MensajeError != null)
                        MensajeError(this, "El Estado país ya ha sido capturado.");
                    else
                        throw (new Exception("El Estado  ya ha sido capturado."));
                    return false;
                }
            }
            return _Entidad.Save();

        }

        bool IEntidad.Borrar()
        {
            throw new NotImplementedException();
        }

        public Boolean Obtener(object Codigo)
        {
            throw new NotImplementedException();
        }
        #endregion

    }
    public class ColEstatus : CN.ColleccionBase<EC.LibroEstatusEntity, CC.LibroEstatusCollection, CN.Estatus>
    {

        private CC.LibroEstatusCollection Coleccion = new CC.LibroEstatusCollection();
        private OC.PredicateExpression Filtro;
        public event CN.MensajeErrorHandler MensajeError;

        public ColEstatus()
        {

        }

        public int Obtener(Estatus elem)
        {
            try
            {
                this.ClearItems();
                Filtro = new SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression();
                Filtro.Add(HC.LibroEstatusFields.Id == elem.Id);
                Filtro.AddWithOr(HC.LibroEstatusFields.Estado == elem.Estado);
                int Conteo = Coleccion.GetDbCount(Filtro);
                if (Conteo > 0)
                {
                    Coleccion.GetMulti(Filtro);
                    foreach (EC.LibroEstatusEntity entity in Coleccion)
                    {
                        CN.Estatus MiElem = new CN.Estatus();
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
    }
}
