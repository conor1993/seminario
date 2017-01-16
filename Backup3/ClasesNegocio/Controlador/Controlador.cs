using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;

using HC = ORMDiocesis.HelperClasses;
//using TV = ORMDiocesis.TypedViewClasses;
using SP = ORMDiocesis.StoredProcedureCallerClasses;

using ECS=Integralab.ORMSeguridad.EntityClasses;
using CCS=Integralab.ORMSeguridad.CollectionClasses;
using HCS=Integralab.ORMSeguridad.HelperClasses;

using OC=SD.LLBLGen.Pro.ORMSupportClasses;
using Integralab.Seguridad.Classes;
using ILTreeViewMenu;


#if FacturaDigital 
    using IntegraLab.FactDigital
    using IntegraLab.FactDigital.ORM
#endif

//using IntegraLab;
using System.IO;
//using ClasesNegocio;

namespace ClasesNegocio
{

    public class ModulosClass
    {
        #region "Miembros"
#if FacturaDigital
        private _FactDigital As ControladorFactDigital
#endif
        #endregion

        #region "Contructores"

        #endregion

        #region "Propiedades"

        //public readonly Property FacturacionDigital() As ControladorFactDigital
        //    get {
        //        if (_FactDigital Is Nothing Then
        //            _FactDigital = New ControladorFactDigital(HC.DbUtils.ActualConnectionString)
        //        End If
        //        return _FactDigital
        //    }
        //}

        #endregion

        #region "Metodos"

        #endregion

    }

    public partial class Controlador
    {

        #region "Miembros"

        private static ECS.SesionesEntity _Sesion;
        private static System.Globalization.CultureInfo _Culture;
        private static Seguridad _Seguridad;
        private static EmpresaClass _Empresa;
        private static ModulosClass _Modulos;
        #endregion

        #region "Constructores"

        public Controlador()
        {
            _Culture = new System.Globalization.CultureInfo("es-mx");
            ClasesNegocio.Properties.Resources.Culture = _Culture;
            Application.CurrentCulture = _Culture;
            _Seguridad = new Integralab.Seguridad.Classes.Seguridad("DIOCESIS");
            HCS.DbUtils.ActualConnectionString = _Seguridad.SeguridadConnectionString;
            _Sesion = new ECS.SesionesEntity();
            _Sesion.Sesfecini = DateTime.Now;
            _Sesion.Usrndx = -1;
            _Sesion.Empndx = -1;
            _Sesion.MiUsuario = new ECS.UsuarioEntity();
            _Sesion.MiEmpresa = new ECS.EmpresasEntity();
            _Modulos = new ModulosClass();
        }

        #endregion

        #region "Propiedades"

        public static ECS.SesionesEntity Sesion
        {
            get { return _Sesion; }
            set { _Sesion = value; }
        }

        public System.Globalization.CultureInfo Culture
        {
            get { return _Culture; }
        }

        public static Integralab.Seguridad.Classes.Seguridad Seguridad
        {
            get { return _Seguridad; }
        }

        public static EmpresaClass Empresa
        {
            get
            {
                if (_Empresa == null || _Empresa.Codigo != _Sesion.MiEmpresa.Empid)
                    _Empresa = new EmpresaClass(_Sesion.MiEmpresa.Empndx);
                return _Empresa;
            }
        }

        public static ModulosClass Modulos
        {
            get { return _Modulos; }
        }

        #endregion

        #region "Metodos Dinamicos"

        ////// <summary>
        ////// Oculta todos los menus
        ////// </summary>
        ////// <remarks></remarks>
        private void OcultarMenus(ToolStripItemCollection Menus)
        {
            //Ocultar menus principales e hijos
            if (Menus != null && Menus.Count > 0)
            {
                foreach (ToolStripItem Item in Menus)
                {
                    if (Item.GetType() == typeof(System.Windows.Forms.ToolStripMenuItem))
                    {
                        if (Item.Tag == null) Item.Tag = "";
                        if (!Item.Tag.ToString().Contains("O"))
                        {
                            ToolStripMenuItem Menu = (ToolStripMenuItem)Item;
                            Menu.Visible = false;
                            OcultarMenus(Menu.DropDownItems);
                        }
                    }
                    //if (Item.GetType() == Type.GetType("System.Windows.Forms.ToolStripMenuItem"))
                    //{
                    //    ToolStripMenuItem Menu = (ToolStripMenuItem)Item;
                    //    Menu.Visible = false;
                    //    OcultarMenus(Menu.DropDownItems);
                    //}
                }
            }
        }

        private void MostrarMenusPadres(ToolStripItem Padre)
        {
            if (Padre != null)
                if (Padre.Visible == false && Padre.GetType() == Type.GetType("System.Windows.Forms.ToolStripMenuItem"))
                {
                    Padre.Visible = true;
                    MostrarMenusPadres(Padre.OwnerItem);
                }
        }

        private void HabilitarMenu(string IdMenu, ToolStripItemCollection Menus)
        {
            foreach (ToolStripItem Item in Menus)
            {
                if (Item.Name == IdMenu && Item.GetType() == typeof(System.Windows.Forms.ToolStripMenuItem))
                {
                    if (Item.Tag == null) Item.Tag = "";
                    if (!Item.Tag.ToString().Contains("I"))
                    {
                        Item.Visible = true;
                        MostrarMenusPadres(Item.OwnerItem);
                        break;
                    }
                    
                }
                else
                {
                    if (Item.GetType() == typeof(System.Windows.Forms.ToolStripMenuItem) && ((ToolStripMenuItem)Item).DropDownItems != null)
                        HabilitarMenu(IdMenu, ((ToolStripMenuItem)Item).DropDownItems);
                }
            }
        }

        public void ChecarDerechos(System.Windows.Forms.MenuStrip MenuStrip)
        {
            try
            {
                //checar privilegios de usuarios
                CCS.DetallemenususuariosCollection Privilegios = new CCS.DetallemenususuariosCollection();
                CCS.MenusCollection MenuPrivilegios = new CCS.MenusCollection();

                //sacar nombres de las funciones y menus del sistema
                OcultarMenus(MenuStrip.Items);
                OC.IPredicateExpression filtro = new OC.PredicateExpression(HCS.DetallemenususuariosFields.Usrndx == Controlador.Sesion.MiUsuario.Usrndx);
                filtro.Add(HCS.DetallemenususuariosFields.Empndx == Controlador.Sesion.MiEmpresa.Empndx);
                Privilegios.GetMulti(filtro);
                MenuPrivilegios.GetMulti(null);

                if (Privilegios.Count > 0)
                {
                    foreach (ECS.DetallemenususuariosEntity Privilegio in Privilegios)
                        foreach (ECS.MenusEntity MenuPrivilegio in MenuPrivilegios)
                            if (Privilegio.Mnundx == MenuPrivilegio.Mnundx)
                                HabilitarMenu(MenuPrivilegio.Mnuid, MenuStrip.Items);
                }
                else
                {
                    MessageBox.Show("Su usuario no tiene derechos a ninguna función del sistema", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ActualizarMenu(MenuStrip MenuPrincipal, String Empresa = null)
        {
            HCS.Transaction trans = new HCS.Transaction(IsolationLevel.ReadCommitted, "Menus");
            MenuCollectionClass Menus = new MenuCollectionClass();

            if (Empresa==null || Empresa == String.Empty)
            {
                Empresa = Application.ProductName;
            }
            Menus.LeerMenuStrip(MenuPrincipal);
            GuardarMenu(Empresa, Menus, null, trans);
            trans.Commit();
        }

        private void GuardarMenu(String Empresa, MenuCollectionClass menus, ECS.MenusEntity padre, HCS.Transaction trans)
        {
            foreach (MenuClass menu in menus)
            {
                CCS.MenusCollection menuC = new CCS.MenusCollection();
                ECS.MenusEntity ent;

                trans.Add(menuC);
                menuC.GetMulti(HCS.MenusFields.Mnuid == menu.MnuId);

                if (menuC.Count > 0)
                    ent = menuC[0];
                else
                    ent = new ECS.MenusEntity();

                trans.Add(ent);

                if (padre != null)
                    ent.Mnupad = padre.Mnundx;
                ent.Mnunom = menu.Nombre;
                ent.Mnuid = menu.MnuId;
                ent.Mnuglo = menu.Mnuglo;
                ent.Mnusol = Empresa;
                ent.Save();
                GuardarMenu(Empresa, menu.MisMenus, ent, trans);
            }
        }

        public void IniciarSesion(int IdEmpresa, int IdUsuario)
        {
            _Sesion.Empndx = IdEmpresa;
            _Sesion.Usrndx = IdUsuario;
            _Sesion.Sesfecini = DateTime.Now;
            _Sesion.Sesact = true;
            _Sesion.Save();

            DBU.ConnStr = Controlador.Empresa.BDConnectionString;
            DBU.CmdTimeOut = 300;

            HC.DbUtils.ActualConnectionString = _Empresa.BDConnectionString;
            HC.DbUtils.CommandTimeOut = 90;

        }

        #endregion

        #region "FacturaDigital"
#if FacturaDigital
        public Function RegistrarFactura(ByRef Factura As FacturaNotaVentaClass) As Boolean
            Dim Trans As New HC.Transaction(IsolationLevel.ReadCommitted, "X")
            Dim TransGnt As GTF.Transaction = Nothing
            Dim StrEmitida As String = ""
            Dim ArchivoPDF As String = ""
            Dim PagoCliente As ClasesNegocio.PagosDeClientesClass
            Dim TotalPagos As Decimal

            Try
                if (Factura.Entidad.IsNew Or Factura.Folio = "" Then
                    Dim folioFactura As New CC.CatFoliosCollection

                    //*********************************************
                    //* Obtiene el folio de la factura y la graba *
                    //*********************************************
                    if (Factura.NotasVentas.Count = 0 Then
                        MsgBox("Debe ingresar una nota de venta para facturar", MsgBoxStyle.Exclamation, "Sin Notas de Venta")
                        return False
                    End If

                    if (Factura.Estatus = EstatusFacturasEnum.PAGADA Then
                        Factura.Estatus = EstatusFacturasEnum.PAGADA
                        StrEmitida = "_E"
                    Else
                        Factura.Estatus = EstatusFacturasEnum.VIGENTE
                    End If

                    Trans.Add(folioFactura)

                    folioFactura.GetMulti(HC.CatFoliosFields.IdSucursal = Factura.Sucursal.Codigo)

                    if (folioFactura.Count > 0 Then
                        if (folioFactura(0).Consecutivo > folioFactura(0).NumFolios Then
                            Throw New FactDigitalException("Ha excedido el numero maximo de folios para esa sucursal, por favor revise sus folios de facturacion")
                        End If

                        Factura.Folio = folioFactura(0).StaLetraSerie.Trim & "-" & folioFactura(0).Consecutivo
                        folioFactura(0).Consecutivo += 1
                        folioFactura(0).Save()
                    Else
                        Trans.Rollback()
                        MsgBox("No se a establecido una configuración de folios de factura para esta sucursal", MsgBoxStyle.Exclamation, "Aviso")
                        return False
                    End If

                    Trans.Add(Factura.Entidad)

                    if (Factura.Entidad.Save Then
                        Dim notas As CC.FacturaNotaDetalleCollection = Factura.NotasVentas.ObtenerColeccion

                        //*****************************************************
                        //* Si se grabó la factura, marca como facturados los *
                        //* productos del detalle de la factura y los graba
                        //*****************************************************
                        Trans.Add(notas)

                        if (notas.SaveMulti = 0 Then
                            Trans.Rollback()
                            MsgBox("No se logro guardar, intente de nuevo", MsgBoxStyle.Exclamation, "Aviso")
                            return False
                        End If

                        Dim prod As CC.FacturaNotaProductosDetalleCollection = Factura.Productos.ObtenerColeccion
                        Dim DetalleNotas As New CC.NotaVentaDetalleCollection

                        foreach (Producto As EC.FacturaNotaProductosDetalleEntity In prod
                            Producto.NotaVentaDetalle.Facturada = True
                            DetalleNotas.Add(Producto.NotaVentaDetalle)
                        Next

                        Trans.Add(prod)
                        Trans.Add(DetalleNotas)

                        if (prod.SaveMulti > 0 AndAlso DetalleNotas.SaveMulti > 0 Then
                            Trans.Add(Factura.NotasAFacturar)

                            foreach (Nota As EC.NotaVentaEntity In Factura.NotasAFacturar
                                Dim Alguno As Boolean = False
                                Dim Todos As Boolean = True
                                Dim DetalleN As New CC.NotaVentaDetalleCollection

                                Trans.Add(DetalleN)
                                DetalleN.GetMulti(HC.NotaVentaDetalleFields.NotaVenta = Nota.Codigo)

                                foreach (DetN As EC.NotaVentaDetalleEntity In DetalleN
                                    //if (DetN.Facturada Then
                                    //    Todos = False
                                    //Else
                                    //    Alguno = True
                                    //End If

                                    //if (Not Todos AndAlso Alguno Then
                                    //    Exit For
                                    //End If
                                    DetN.Facturada = True
                                    //Trans.Add(DetN)
                                Next
                                //if (DetalleN.SaveMulti = 0 Then
                                //    Trans.Rollback()
                                //    MsgBox("No se logro guardar, intente de nuevo", MsgBoxStyle.Exclamation, "Aviso")
                                //    return False
                                //End If

                                //if (Todos Then
                                Nota.Facturada = CType(FacturadaEnum.Si, Byte)
                                //ElseIf Alguno Then
                                //    Nota.Facturada = CType(FacturadaEnum.Parcial, Byte)
                                //Else
                                //    Nota.Facturada = CType(FacturadaEnum.No, Byte)
                                //End If
                            Next

                            if (Factura.NotasAFacturar.SaveMulti = 0 Then
                                Trans.Rollback()
                                MsgBox("No se logro guardar, intente de nuevo", MsgBoxStyle.Exclamation, "Aviso")
                                return False
                            End If

                            For i As Integer = 0 To Factura.NotasAFacturar.Count - 1
                                if (Factura.NotasAFacturar(i).Estatus = EstatusEnum.PAGADA Then
                                    Dim _Nota As New IntegraLab.ORM.CollectionClasses.PagoDeCtesNotaVentaCollection
                                    _Nota.GetMulti(HC.PagoDeCtesNotaVentaFields.CodigoNotaVenta = Factura.NotasAFacturar(i).Codigo)
                                    For r As Integer = 0 To _Nota.Count - 1
                                        TotalPagos += _Nota(r).ImpteNotaVenta

                                        Dim PagoClientesFolio As New ClasesNegocio.PagosDeClientesClass
                                        Dim FolioIngreso As String
                                        PagoClientesFolio.GenerarFolio(Trans)
                                        FolioIngreso = PagoClientesFolio.FolioIngreso

                                        PagoCliente = New ClasesNegocio.PagosDeClientesClass
                                        PagoCliente.Cve_cliente = _Nota(r).CveCliente
                                        PagoCliente.FolioIngreso = FolioIngreso
                                        PagoCliente.CodigoFactura = Factura.Codigo
                                        PagoCliente.Fecha_ingreso = _Nota(r).FecIngreso
                                        PagoCliente.NoFactura = Factura.Folio
                                        PagoCliente.ImporteIngreso = _Nota(r).ImpteIngreso
                                        PagoCliente.TipoPago = Asc(_Nota(r).TipoPago)
                                        PagoCliente.Documento = _Nota(r).Documento
                                        PagoCliente.ImporteNotaCredito = 0.0
                                        PagoCliente.ImporteChequePos = 0
                                        PagoCliente.Estatus = EstatusPagosClienteEnum.VIGENTE
                                        PagoCliente.IdUsuario = Me.Sesion.MiUsuario.Usrndx
                                        PagoCliente.IdUsurioCancelacion = 0
                                        PagoCliente.ImporteFactura = Factura.Total.ToString("C2")
                                        PagoCliente.SaldoFactura = Factura.Total.ToString("C2") - TotalPagos
                                        PagoCliente.IdPoliza = _Nota(r).IdPoliza.Value
                                        PagoCliente.ClienteFactura = _Nota(r).CveCliente

                                        Trans.Add(PagoCliente.Entidad)
                                        PagoCliente.Entidad.Save()
                                    Next
                                End If
                            Next

                            Dim FacturaDigital As Boolean = False

                            if (Me.Modulos.FacturacionDigital.Configuracion.Activado Then
                                if (Not Me.Modulos.FacturacionDigital.Configuracion.AutoGenerar Then
                                    if (MessageBox.Show("La factura se ha registrado satisfactoriamente, ¿Desea generar la factura digital?", Me.Sesion.MiEmpresa.Empnom, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                                        FacturaDigital = True
                                    End If
                                Else
                                    FacturaDigital = True
                                End If

                                if (FacturaDigital Then
                                    if (Factura.Cliente.RFC = "" Then
                                        Throw New IntegraLab.FactDigital.FactDigitalException("No se ha establecido el RFC del cliente: " & Factura.Cliente.NombreCompleto & ", debera establecerlo en el catalogo de clientes")
                                    ElseIf Me.Sesion.MiEmpresa.EmpRfc = "" Then
                                        Throw New IntegraLab.FactDigital.FactDigitalException("No se ha establecido el RFC de la empresa, debera establecerlo en el catalogo de empresas")
                                    End If
                                    TransGnt = New GTF.Transaction(IntegraLab.FactDigital.ControladorFactDigital.Conexion)

                                    ArchivoPDF = RegistrarFacturaDigital(Factura, Trans, TransGnt)

                                    //if (Me.Modulos.FacturacionDigital.Configuracion.AutoGenerar Then
                                    Trans.Commit()
                                    TransGnt.Commit()
                                    //End If
                                Else
                                    Trans.Commit()
                                End If
                            Else
                                Trans.Commit()
                            End If
    REIMPRIMIR:
                            if (Me.Modulos.FacturacionDigital.Configuracion.Activado AndAlso FacturaDigital Then
                                if (MessageBox.Show("Deseas abrir el archivo PDF", Me.Sesion.MiEmpresa.Empnom, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                                    System.Diagnostics.Process.Start(ArchivoPDF)
                                End If
                            ElseIf MessageBox.Show("¿Deseas imprimir la Factura?", _
                                "Impresión", Windows.Forms.MessageBoxButtons.YesNo, _
                                Windows.Forms.MessageBoxIcon.Question, _
                                Windows.Forms.MessageBoxDefaultButton.Button1) = _
                                Windows.Forms.DialogResult.Yes Then

                                Me.Imprimir(Factura) // Then
                            End If
                            return True
                        Else
                            Trans.Rollback()
                            MsgBox("No se logro guardar, intente de nuevo", MsgBoxStyle.Exclamation, "Aviso")
                            return False
                        End If
                    Else
                        Trans.Rollback()
                        MsgBox("No se logro guardar, intente de nuevo", MsgBoxStyle.Exclamation, "Aviso")
                        return False
                    End If
                Else
                    Factura.Estatus = EstatusFacturasEnum.VIGENTE
                End If
            Catch ex As Exception
                Trans.Rollback()

                if (TransGnt IsNot Nothing Then
                    TransGnt.Rollback()
                End If

                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
                return False
            End Try
        End Function

        //////// <summary>
        //////// Imprime la factura
        //////// </summary>
        //////// <returns></returns>
        //////// <remarks></remarks>
        public Function Imprimir(ByRef Factura As FacturaNotaVentaClass) As Boolean
            Dim HSD As String = Chr(27) & Chr(35) & Chr(48)
            Dim NPP As String = Chr(27) & Chr(56)
            Dim CNA As String = Chr(15)
            Dim CND As String = Chr(18)
            Dim DWA As String = Chr(27) & Chr(87) & Chr(49)
            Dim DWD As String = Chr(27) & Chr(87) & Chr(48)
            Dim Imp As New EscritorClass(135, 60)

            Try
                Imp.Escribe(HSD & NPP & CNA, 1, 1)

                Imp.Escribe(Factura.FechaFacturacion.ToString("dd/MM/yyyy"), 95, 3)
                Imp.Escribe(Factura.Folio, 90, 5)
                Imp.Escribe(Factura.Cliente.NombreCompleto, 5, 5)
                Imp.Escribe(Factura.DomicilioFiscal.Domicilio, 5, 6)
                Imp.Escribe(Factura.DomicilioFiscal.Colonia, 5, 7)
                Imp.Escribe(Factura.DomicilioFiscal.Ciudad.Descripcion & ", " & Factura.DomicilioFiscal.Estado.DescripcionCorta, 5, 8)
                Imp.Escribe(Factura.Cliente.RFC, 85, 8)

                Dim ini As Integer = 15
                Dim i As Integer

                For i = ini To Factura.Productos.Count + ini - 1
                    Imp.Escribe(Factura.Productos(i - ini).Codigo, 3, i)
                    Imp.Escribe(Factura.Productos(i - ini).Producto.UnidadMedida.DescCorta, 14, i)
                    Imp.Escribe(Factura.Productos(i - ini).Cantidad.ToString("N3"), 25, i)
                    Imp.Escribe(Factura.Productos(i - ini).Producto.Descripcion.Trim, 45, i)
                    Imp.Escribe(Factura.Productos(i - ini).Precio.ToString("N2"), 100, i)
                    if (Factura.Productos(i - ini).Producto.SeAplicaIva Then
                        Imp.Escribe((Factura.Productos(i - ini).Importe * 1.15).ToString("N2"), 120, i)
                    Else
                        Imp.Escribe(Factura.Productos(i - ini).Importe.ToString("N2"), 120, i)
                    End If
                Next

                //Imp.Escribe(String.Format("SUB-TOTAL: " & Me.SubTotal.ToString("N2")), 52, i + 2)
                //Imp.Escribe(String.Format("IVA      : " & Me.IVA.ToString("N2")), 52, i + 3)
                Imp.Escribe(Factura.Total.ToString("N2"), 120, 24 + ini)

                Imp.Imprime()
                return True
            Catch ex As Exception
#if DEBUG
                    MsgBox("Impresora desconectada o apagada" & vbNewLine & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")
#else
                MsgBox("Impresora desconectada o apagada", MsgBoxStyle.Critical, "Error")
#endif
                return False
            End Try
        End Function

        public Function GenerarCFD(ByRef Factura As FacturaNotaVentaClass, ByRef Trans As HC.Transaction) As CFD.Comprobante
            // Inicio V1.1.0.70
            //EMPRESA EMISORA
            Dim DomicilioFiscal As CFD.UbicacionFiscal = New IntegraLab.CFD.UbicacionFiscal()
            DomicilioFiscal.calle = "AV INDEPENDENCIA SUR"
            DomicilioFiscal.noExterior = "1956"
            DomicilioFiscal.noInterior = ""
            DomicilioFiscal.colonia = "CENTRO SINALOA"
            DomicilioFiscal.localidad = "CULIACAN"
            DomicilioFiscal.municipio = "CULIACAN"
            DomicilioFiscal.estado = "SINALOA"
            DomicilioFiscal.pais = "MEXICO"
            DomicilioFiscal.codigoPostal = "80000"
            Dim Emisor As CFD.ComprobanteEmisor = New CFD.ComprobanteEmisor(DomicilioFiscal, Me.Sesion.MiEmpresa.EmpRfc.Replace("-", ""), Me.Sesion.MiEmpresa.Empnom.ToUpper())

            //CLIENTE
            Dim Domicilio As CFD.Ubicacion = New Integralab.CFD.Ubicacion("MEXICO")
            //Domicilio.calle = Factura.DomicilioFiscal.Domicilio.ToUpper
            Domicilio.calle = Factura.DomicilioFiscal.Calle.ToUpper
            Domicilio.codigoPostal = Factura.DomicilioFiscal.CP
            Domicilio.noExterior = Factura.DomicilioFiscal.NumeroExt
            Domicilio.noInterior = Factura.DomicilioFiscal.NumeroInt
            //Domicilio.municipio = "CULIACAN"
            //Domicilio.estado = "SINALOA"
            Domicilio.colonia = Factura.DomicilioFiscal.Colonia.ToUpper
            Domicilio.localidad = Factura.DomicilioFiscal.Poblacion.Descripcion.ToUpper
            Domicilio.municipio = Factura.DomicilioFiscal.Ciudad.Descripcion.ToUpper
            Domicilio.estado = Factura.DomicilioFiscal.Estado.Descripcion.ToUpper
            Domicilio.pais = Factura.DomicilioFiscal.Estado.Pais
            // Fin V1.1.0.70

            Dim Receptor As CFD.ComprobanteReceptor = New CFD.ComprobanteReceptor(Domicilio, Factura.Cliente.RFC.Replace("-", ""))
            Receptor.nombre = Factura.Cliente.NombreCompleto

            //PRODUCTOS O SERVICIOS
            Dim Conceptos As New List(Of Integralab.CFD.ComprobanteConcepto)

            foreach (Producto As FacturaNotaVentaProductoDetalleClass In Factura.Productos
                Dim Concepto As New CFD.ComprobanteConcepto(Producto.Cantidad, Producto.Producto.Descripcion, Producto.Precio, Producto.Importe)
                Concepto.unidad = Producto.Producto.UnidadMedida.Descripcion.ToUpper
                Concepto.noIdentificacion = Producto.Producto.Codigo
                Conceptos.Add(Concepto)
            Next

            //IVA
            Dim Impuestos As New Integralab.CFD.ComprobanteImpuestos()
            Dim Impuesto As New Integralab.CFD.ComprobanteImpuestosTraslado()

            Impuestos.Traslados = New List(Of CFD.ComprobanteImpuestosTraslado)
            Impuesto.impuesto = CFD.ComprobanteImpuestosTrasladoImpuesto.IVA
            Impuesto.importe = Factura.IVA
            Impuestos.Traslados.Add(Impuesto)
            Impuestos.CalcularTotalImpuestosTrasladados()

            Dim FormaDePago As String = "CONTADO"

            foreach (NotaVenta As FacturaNotaVentaDetalleClass In Factura.NotasVentas
                if (NotaVenta.NotaVenta.TipoVenta.EsCredito Then
                    FormaDePago = "CREDITO"
                    Exit For
                End If
            Next

            Dim Serie As String, Folio As String

            if (Factura.Folio.Contains("-") Then
                Dim Arreglo() As String = Factura.Folio.Split(New Char() {"-"})

                Serie = Arreglo(0)
                Folio = Arreglo(1)
            Else
                Serie = ""
                Folio = Factura.Folio
            End If

            Dim Folios As New CC.CatFoliosCollection

            Trans.Add(Folios)
            Folios.GetMulti(HC.CatFoliosFields.IdSucursal = Factura.IdSucursal)

            Dim Comp As New Integralab.CFD.Comprobante(Emisor, Receptor, Conceptos, Impuestos, Folio, Factura.FechaFacturacion, "", Folios(0).NoAprobacion, Folios(0).AnoAprobacion, FormaDePago, "", Factura.SubTotal, Factura.Total, Integralab.CFD.ComprobanteTipoDeComprobante.ingreso)
            Comp.serie = Serie

            return Comp
        End Function

        public void AgregarAddenda(ByRef Comp As CFD.Comprobante, ByVal Contenido As String)
            if (Comp.Addenda Is Nothing Then
                Comp.Addenda = New List(Of Integralab.CFD.ComprobanteAddenda)()
            End If
            Comp.Addenda.Add(New CFD.ComprobanteAddenda(Contenido))
        }

        public Function RegistrarFacturaDigital(ByRef Factura As FacturaNotaVentaClass, ByRef Trans As HC.Transaction, ByRef TransGnt As GTF.Transaction) As String
            Dim ConSelloDigital As Boolean = False
            Dim Comp As CFD.Comprobante
            Dim RutaArchivo As String
            Dim Vendedor As ComisionistaClass = Factura.NotasVentas(0).NotaVenta.Comicionista

            if (Not Me.Modulos.FacturacionDigital.Configuracion.Certificado.Length > 0 Then
                Throw New FactDigitalException("Debe capturar la FIEL en la configuracion digital")
            End If

            if (Factura.Estatus = EstatusFacturasEnum.PAGADA Then
                ConSelloDigital = True
            End If
            Comp = Me.GenerarCFD(Factura, Trans)
            //Me.AgregarAddenda(Comp, "VENDEDOR: Cod. " & Vendedor.Codigo & ", " & Vendedor.NombreCompleto.ToUpper)

            Dim FactDigital As FacturaDigital = Me.Modulos.FacturacionDigital.GenerarFacturaDigital(Factura.Folio, Comp, ConSelloDigital, TransGnt)

            RutaArchivo = Me.Modulos.FacturacionDigital.GenerarArchivoPDF(FactDigital)
            return RutaArchivo
        End Function

        public void GenerarXML(ByVal Factura As FacturaNotaVentaClass)
            //Dim Dialog As New SaveFileDialog

            //Dialog.Filter = "xml files (*.xml)|*.xml"
            //Dialog.RestoreDirectory = True

            //if (Dialog.ShowDialog = DialogResult.OK Then
            Dim Archivo As String = Me.Modulos.FacturacionDigital.GenerarXML(Factura.Folio)

            MessageBox.Show("El archivo Xml se ha generado satisfactoriamente", Me.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Information)

            if (MessageBox.Show("¿Desea abrir el archivo XML?", Me.Sesion.MiEmpresa.Empnom, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                System.Diagnostics.Process.Start(Archivo)
            End If
            //File.WriteAllBytes(Dialog.FileName, Memoria.ToArray)
            //End If
        }

        public void GenerarInformeMensual(ByVal Facturas As IList, ByVal Mes As Integer, ByVal Ano As Integer)
            Dim Archivo As String = Me.Modulos.FacturacionDigital.GenerarInforme(Facturas, Mes, Ano)

            if (MessageBox.Show("¿Desea abrir el archivo generado?", Me.Sesion.MiEmpresa.Empnom, MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                System.Diagnostics.Process.Start(Archivo)
            End If
        }

#endif

        #endregion

    }

}