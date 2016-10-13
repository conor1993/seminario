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
    
    public class Editorial : CN.ClassBase<EC.EditorialEntity>,IEntidad
    {
        public event CN.MensajeErrorHandler MensajeError;
        public event EventHandler Modificado;
        private LibroCol _Libros;

    #region Constructores
        public Editorial()
        {
            _Entidad = new EC.EditorialEntity();
        }

        public Editorial(EC.EditorialEntity Entity)
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
                        MensajeError(this, "No se pudo borrar la editorial porque tiene libros registrados.");
                    else
                        throw (new Exception("No se pudo borrar la editorial porque tiene libros registrados."));
                    return false;
                }

                if (trans == null)
                {
                    trans = new HC.Transaction(IsolationLevel.ReadCommitted, "Editorial");
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
                    MensajeError(this, "No se pudo borrar la editorial.");
                else
                    throw (new Exception("No se pudo borrar la editorial."));
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
            EditorialCol Coleccion = new EditorialCol();
            EC.EditorialEntity Entity = new EC.EditorialEntity();
            if (_Entidad.IsNew)
            {
                OC.PredicateExpression filtro = new OC.PredicateExpression();
                filtro.Add(HC.EditorialFields.Nombre == _Entidad.Nombre);
                if (Coleccion.Obtener(filtro) > 0)
                {
                    if (MensajeError != null)
                        MensajeError(this, "La editorial ya ha sido capturada.");
                    else
                        throw (new Exception("La editorial ya ha sido capturada."));
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
                    MensajeError(this, "La editorial especificada no existe.");
                else
                    throw (new Exception("La editorial especificada no existe."));
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

    public class EditorialCol : CN.ColleccionBase<EC.EditorialEntity, CC.EditorialCollection, CN.Editorial>
    {
        private CC.EditorialCollection Coleccion = new CC.EditorialCollection();
        private OC.PredicateExpression Filtro;
        public event CN.MensajeErrorHandler MensajeError;
        private OC.SortExpression sort = new OC.SortExpression(new OC.SortClause(HC.EditorialFields.Nombre, OC.SortOperator.Ascending));


        public EditorialCol()
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

        public int Obtener(Editorial elem)
        {
            try
            {
                this.ClearItems();
                Filtro = new SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression();
                Filtro.Add(HC.EditorialFields.Id == elem.Id);
                Filtro.AddWithOr(HC.EditorialFields.Nombre == elem.Nombre);
                int Conteo = Coleccion.GetDbCount(Filtro);
                if (Conteo > 0)
                {
                    Coleccion.GetMulti(Filtro,0,sort);
                    foreach (EC.EditorialEntity entity in Coleccion)
                    {
                        CN.Editorial MiEvento = new CN.Editorial();
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

        public int Obtener(String Nombre)
        {
            try
            {
                this.ClearItems();
                Filtro = new SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression();
                Filtro.AddWithOr(HC.EditorialFields.Nombre == Nombre);
                int Conteo = Coleccion.GetDbCount(Filtro);
                if (Conteo > 0)
                {
                    Coleccion.GetMulti(Filtro, 0, sort);
                    foreach (EC.EditorialEntity entity in Coleccion)
                    {
                        CN.Editorial MiEvento = new CN.Editorial();
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
            foreach (Editorial elem in this)
            {
                lista.Add(elem.Nombre);
            }
            return lista.ToArray();
        }
    }
}
