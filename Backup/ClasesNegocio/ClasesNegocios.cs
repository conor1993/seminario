using System;
using System.Runtime.InteropServices;
using CM=System.ComponentModel;

namespace ClasesNegocio
{

#region "Delegados"
    public delegate void MensajeErrorHandler(object sender, string mensaje);
#endregion


#region "Enumeraciones"

    public enum AceptadoEnum
    {
        SI = 1,
        NO = 2,
        SF = 3,
        ND = 4
    }

    public enum EdoCivilEnum
    {
        DESCONOCIDO = 0,
        MATRIMONIO_CIVIL = 1,
        MATRIMONIO_RELIGIOSO = 2,
        MADRE_SOLTERA = 3,
        DIVORCIADOS = 4,
        SEPARADOS = 5,
        UNION_LIBRE = 6
    }

    public enum SeccionEventoEnum
    {
        MAYOR = 1,
        MENOR = 2,
        SECUNDARIA = 3
    }

    public enum EstatusEnum
    {
        INACTIVO = 0,
        ACTIVO = 1,
        PAGADA = 2,
        ABONADA = 3
    }
    
    public enum EstatusCompraEnum
    {
        CANCELADO = 0,
        VIGENTE = 1
    }

    public enum DiasEnum
    {
        DOMINGO,
        LUNES,
        MARTES,
        MIERCOLES,
        JUEVES,
        VIERNES,
        SABADO
    }

    public enum MesEnum
    {
        ENERO=1,
        FEBRERO,
        MARZO,
        ABRIL,
        MAYO,
        JUNIO,
        JULIO,
        AGOSTO,
        SEPTIEMBRE,
        OCTUBRE,
        NOVIEMBRE,
        DICIEMBRE
    }

    public enum TCambioEnum
    {
        NO = 4,
        SI = 5
    }

    public enum PPagoEnum
    {
        NO = 0,
        SI = 1
    }

    public enum CondicionEnum
    {
        ACTIVOS = 1,
        INACTIVOS = 0,
        TODOS = 2
    }

    public enum CondicionCotizacionEnum
    {
        TODAS = -1,
        CANCELADA = 0,
        VIGENTE = 1
    }

    public enum DireccionEnum
    {
        ENTRADAS,
        SALIDAS
    }

    public enum CondicionDireccionEnum
    {
        ENTRADAS,
        SALIDAS,
        TODAS
    }

    /// <summary>
    /// Sirve para especificar que tipo de dato se esta empleando
    /// </summary>
    /// <remarks></remarks>
    public enum TipoDatoEnum
    {
        FECHA,
        NUMERO,
        CADENA
    }

    public enum AfectaCostoEnum
    {
        SI = 1,
        NO = 0
    }

    public enum SiNoEnum
    {
        NO = 0,
        SI = 1
    }

    public enum AsignadaEnum
    {
        SI = 1,
        NO = 0
    }

    public enum CondicionAsignadaEnum
    {
        SI = 1,
        NO = 0,
        TODOS = 2
    }

    public enum CondicionPendienteFacturarEnum
    {
        NO = 0,
        SI,
        TODOS
    }

    public enum BajaCancelacionEnum
    {
        CANCELACIÓN,
        BAJA,
        TODOS
    }

    public enum TipoMotivoEnum
    {
        CANCELACIÓN,
        BAJA
    }

    public enum ErroresPolizaEnum
    {
        NINGUNO = 0,
        LA_FECHA_DE_LA_POLIZA_NO_ESTA_DENTRO_DEL_EJERCICIO_CONTABLE = 1,
        POLIZA_DESCUADRADA = 2,
        ALGUNAS_DE_LAS_CUENTAS_CONTABLES_DE_PARTIDAS_NO_ESTAN_EN_EL_CATALOGO = 3,
        ALGUNAS_DE_LAS_CUENTAS_CONTABLES_NO_SON_AFECTABLES = 4,
        NO_SE_ENCONTRO_EL_DETALLE_DE_LA_POLIZA = 5
    }

    public enum EstatusFacturasApagar
    {
        PROGRAMADA = 0,
        AUTORIZADA = 1,
        PAGADA = 2
    }

    public enum EstatusFacturasEnum
    {
        CANCELADA = 0,
        VIGENTE = 1,
        PAGADA = 2,
        ABONADA = 3
    }

    public enum CondicionEstatusEnum
    {
        ACTIVO = 1,
        INACTIVO = 0,
        TODOS = 2
    }

    public enum EstatusPagosProveedoresEnum
    {
        CANCELADO,
        VIGENTE
    }

    public enum EstatusPagosClienteEnum
    {
        CANCELADO = 0,
        VIGENTE = 1
    }

    public enum CondicionEstatusPagosClienteEnum
    {
        VIGENTE = 1,
        CANCELADO = 0,
        TODOS = 2
    }

    public enum EstatusAutorizada
    {
        SI = 1,
        NO = 0,
        TODAS = 2
    }

    public enum EstatusRecepcionEnum
    {
        CANCELADA,
        RECEPCIONADA,
        PARCIAL,
        TOTAL
    }

    public enum OrdenRepClientes
    {
        CÓDIGO,
        RFC,
        NOMBRE
    }

    public enum FiltroRepClientes
    {
        CÓDIGO,
        RFC,
        NOMBRE,
        COMISIONISTA
    }

    public enum NotaCreditoEnum
    {

        /// <summary>
        /// Indica que ha sido cancelada
        /// </summary>
        /// <remarks></remarks>
        CANCELADA,
        /// <summary>
        /// Indica que esta pendiente por aplicar
        /// </summary>
        /// <remarks></remarks>
        VIGENTE,
        /// <summary>
        /// Indica que ha sido aplicada
        /// </summary>
        /// <remarks></remarks>
        APLICADA,
        /// <summary>
        /// Indica que parte de la nota ha sido aplicada y el resto cancelada
        /// Nota: Solo se aplica en el encabezado
        /// </summary>
        /// <remarks></remarks>
        PARCIALMENTE_APLICADA,
        /// <summary>
        /// Indica que la factura a la cual se destino la nota ya ha sido pagada
        /// y por lo tanto la nota ya no es aplicable
        /// </summary>
        /// <remarks></remarks>
        NO_APLICABLE,
        TODAS

    }

#endregion

//public class TipoPagoClass
//{
//    private TipoPagoFactura _TipoPago;

//    public TipoPagoFactura TipoPago
//    {
//        get {return _TipoPago;}
//        set {_TipoPago = value;}
//    }

//    public TipoPagoClass (TipoPagoFactura TipoPago)
//    {
//        _TipoPago = TipoPago;
//    }
//}

//public class TipoPagoSClass : System.ComponentModel.BindingList <TipoPagoClass>
//{
//    public TipoPagoSClass()
//    {
//        Add(new TipoPagoClass(TipoPagoFactura.EFECTIVO));
//        Add(new TipoPagoClass(TipoPagoFactura.TARJETA));
//        Add(new TipoPagoClass(TipoPagoFactura.CHEQUE));
//        Add(new TipoPagoClass(TipoPagoFactura.DEPOSITO));
//    }
//}

public class DiaClass
{
    private DiasEnum _dia;

    DiasEnum Dia
    {
        get {return _dia;}
        set {_dia = value;}
    }
    
    public DiaClass (DiasEnum dia)
    {
        _dia = dia;
    }
}

public class DiasClass : System.ComponentModel.BindingList <DiaClass>
{
    public DiasClass()
    {
        Add(new DiaClass(DiasEnum.DOMINGO));
        Add(new DiaClass(DiasEnum.LUNES));
        Add(new DiaClass(DiasEnum.MARTES));
        Add(new DiaClass(DiasEnum.MIERCOLES));
        Add(new DiaClass(DiasEnum.JUEVES));
        Add(new DiaClass(DiasEnum.VIERNES));
        Add(new DiaClass(DiasEnum.SABADO));
    }
}

public class MesClass
{
    private MesEnum _Mes;

    public MesEnum Mes
    {
        get {return _Mes;}
        set {_Mes = value;}
    }

    public MesClass (MesEnum mes)
    {
        _Mes = mes;
    }
}

public class MesesClass : System.ComponentModel.BindingList <MesClass>
{
    public MesesClass()
    {
        Add(new MesClass(MesEnum.ENERO));
        Add(new MesClass(MesEnum.FEBRERO));
        Add(new MesClass(MesEnum.MARZO));
        Add(new MesClass(MesEnum.ABRIL));
        Add(new MesClass(MesEnum.MAYO));
        Add(new MesClass(MesEnum.JUNIO));
        Add(new MesClass(MesEnum.JULIO));
        Add(new MesClass(MesEnum.AGOSTO));
        Add(new MesClass(MesEnum.SEPTIEMBRE));
        Add(new MesClass(MesEnum.OCTUBRE));
        Add(new MesClass(MesEnum.NOVIEMBRE));
        Add(new MesClass(MesEnum.DICIEMBRE));
    }
}

//public class ConvertirNumeroALetraClass
//{
//    private static MonedaStrc Moneda;
//    private static int Pointer1 = 0;
//    private static int Pointer2 = 0;

//    /// <summary>
//    /// Convierte numeros de 1 a 9 a letra
//    /// </summary>
//    /// <param name="Digit">Numero a convertir</param>
//    /// <returns></returns>
//    /// <remarks></remarks>
//    private static string GetDigit(string Digit)
//    {
//        switch (int.Parse(Digit))
//        {
//            case 1 : return "Un";
//            case 2 : return "Dos";
//            case 3 : return "Tres";
//            case 4 : return "Cuatro";
//            case 5 : return "Cinco";
//            case 6 : return "Seis";
//            case 7 : return "Siete";
//            case 8 : return "Ocho";
//            case 9 : return "Nueve";
//            default: return "";
//        }
//    }

//    /// <summary>
//    /// Convierte numeros de 10 a 99 a letras
//    /// </summary>
//    /// <param name="TensText">Numero a convertir</param>
//    /// <returns></returns>
//    /// <remarks></remarks>
//    private static string GetTens(int TensText)
//    {
//        string Result, str;

//        Result= "";
//        str = TensText.ToString("00");           // anula el valor temporal de la funcion
//        if (int.Parse(str.Substring(0, 1)) == 1)   // si el valor esta entre 10-19
//        {
//            switch (TensText)
//            {
//                case 10 : 
//                    Result = "Diez";
//                    break;
//                case 11 : 
//                    Result = "Once";
//                    break;
//                case 12 : 
//                    Result = "Doce";
//                    break;
//                case 13 : 
//                    Result = "Trece";
//                    break;
//                case 14 : 
//                    Result = "Catorce";
//                    break;
//                case 15 : 
//                    Result = "Quince";
//                    break;
//                case 16 : 
//                    Result = "Dieciseis";
//                    break;
//                case 17 : 
//                    Result = "Diecisiete";
//                    break;
//                case 18 : 
//                    Result = "Dieciocho";
//                    break;
//                case 19 : 
//                    Result = "Diecinueve";
//                    break;
//            }
//        }
//        else    // Si el valor esta entre 20-99
//        {
//            switch (int.Parse(str.Substring(0, 1)))
//            {
//                case 2 : 
//                    Result = "Veinte ";
//                    break;
//                case 3 : 
//                    Result = "Treinta ";
//                    break;
//                case 4 : 
//                    Result = "Cuarenta ";
//                    break;
//                case 5 : 
//                    Result = "Cincuenta ";
//                    break;
//                case 6 : 
//                    Result = "Sesenta ";
//                    break;
//                case 7 : 
//                    Result = "Setenta ";
//                    break;
//                case 8 : 
//                    Result = "Ochenta ";
//                    break;
//                case 9 : 
//                    Result = "Noventa ";
//                    break;
//            }
//            Result = Result + GetDigit(str.Substring(1,1));  // Retrae el lugar
//        }
//        return Result;
//    }

//    /// <summary>
//    /// Convierte numeros de 100 a 999 a letras
//    /// </summary>
//    /// <param name="MyNumber">Numero a Convertir</param>
//    /// <returns></returns>
//    /// <remarks></remarks>
//    private static string GetHundreds(string MyNumber)
//    {
//        string Result = "";
//        string Quinien = "";
//        string Quinien2 = "";

//        if (int.Parse(MyNumber) == 0)
//        {
//            return "";
//        }
//        MyNumber = int.Parse(MyNumber).ToString("000");

//        // Converte el lugar de las centenas
//        Quinien2 = " Cientos ";
//        if (MyNumber.Substring(1, 1) != "0")
//        {
//            Quinien= GetDigit(MyNumber.Substring(1,1));
//            if (Quinien == "Cinco")
//            {
//                Quinien = "Quinientos ";
//                Quinien2 = "";
//            }
//            if (Quinien == "Un")
//            {
//                Quinien = "";
//                Quinien2 = "Ciento ";
//            }
//            if (Quinien == "Nueve")
//            {
//                Quinien = "Nove";
//                Quinien2 = "cientos ";
//            }
//            if (Quinien == "Siete")
//            {
//                Quinien = "Sete";
//                Quinien2 = "cientos ";
//            }
//            Result = Quinien + Quinien2;     // aca le agrega al numero la palabra
//        }

//        //Convierte el lugar de los miles
//        if (MyNumber.Substring(2, 1) != "0")
//        {
//            Quinien = GetTens(int.Parse(MyNumber.Substring(2)));
//            if (Pointer1 == 0)
//            {
//                Pointer1 = 1;
//                Quinien = Quinien.Replace(" ", " y ");
//            }

//            Result = Result + Quinien;
//        }
//        else
//        {
//            Quinien = GetDigit(MyNumber.Substring(2));
//            Result = Result + Quinien;
//        }

//        return Result;
//    }

//}

#region "Interfaces"
public interface IEntidad
{
    event EventHandler Modificado;
    event MensajeErrorHandler MensajeError;
    Boolean Guardar();
    Boolean Borrar();
    Boolean Obtener(object Codigo);
}

public interface IEntidad2 : IEntidad
{
    void LeerEntidad(Object Entidad);
    Object ObtenerEntidad(); 
}

#endregion


#region "Estructuras"

public struct MonedaStrc
{
    private string Singular;
    private string Plural;
}

#endregion



//public class cNum2Text
//{
//    // Declaradas a nivel de módulo
//    private string[] unidad = new string[9];
//    private string[] decena= new string[9];
//    private string[] centena= new string[10];
//    private string[] deci= new string[9];
//    private string[] otros= new string[15];

//    private string m_Sexo1;
//    private string m_Sexo2;
//    private int m_LenSexo1;

//    public enum eSexo
//    {
//        Femenino=0,
//        Masculino=1
//    }

//    public static string Numero2Letra(string strNum, int NumDecimales, string sMoneda, string sPlural, string sAbreviatura)
//    {
//        string Entero;
//        string Fraccion;
//        string n2l;

//        strNum= strNum.Replace("$", "");

//        strNum = FormatNumber(strNum, NumDecimales);
//        Entero = Mid(strNum, 1, InStr(strNum, ".") - 1);
//        Fraccion = Mid(strNum, InStr(strNum, ".") + 1);
//        if (Entero != "1") 
//        {
//            sMoneda += sPlural;
//            n2l = "Son " + UnNumero(Entero, sMoneda) + " " + sMoneda + " " + Fraccion + "/100 " + sAbreviatura;
//        }
//        else
//        {
//            n2l = "Es " & UnNumero(Entero, sMoneda) & " " & sMoneda & " " & Fraccion & "/100 " & sAbreviatura;
//        }

//        return n2l;
//    }

//    private string UnNumero(string strNum, string Sexo1)
//{
//        //----------------------------------------------------------
//        //Esta es la rutina principal                    (10/Jul/97)
//        //Está separada para poder actuar con decimales
//        //----------------------------------------------------------
//        decimal dblNumero;

//        Boolean Negativo;
//        int L;
//        Boolean Una;
//        Boolean Millon;
//        Boolean Millones;
//        int vez;
//        int MaxVez;
//        int k;
//        string strQ;
//        string strB;
//        string strU;
//        string strD;
//        string strC;
//        int iA;
//        //
//         string[] strN;
//         string Sexo1Ant;

//        //Si se amplia este valor... no se manipularán bien los números
//        const int cAncho = 12;
//        const int cGrupos = 4;

//        //Por si se especifica el sexo, para el caso de los decimales
//        //que siempre será masculino
//        Sexo1Ant = m_Sexo1;
//        m_Sexo1 = Sexo1;

//        m_LenSexo1 = m_Sexo1.Length;
//        //
//        // idea aportada por Harvey Triana
//        // para no tener que estar reinicializando continuamente los arrays
//        //
//        // Se ve que lo anterior fallaba si se usaba varias veces seguidas (05/Mar/99)
//        if (unidad[1] != "un"+Sexo1) 
//            InicializarArrays();
        
//        //
//        //    if m_Sexo1 <> Sexo1Ant Then
//        //        unidad(2) = ""
//        //    End if
//        //    //
//        //    if unidad(2) <> "dos" Then
//        //        InicializarArrays
//        //    End if
//        //

//        //Si se produce un error que se pare el mundo!!!
//        //On Error GoTo 0

//        if (strNum.Length == 0)
//            strNum = "0";
       

//        dblNumero = System.Math.Abs((decimal) strNum.to);
//        Negativo = (dblNumero != CDbl(strNum))
//        strNum = LTrim(RTrim(Str(dblNumero)))
//        L = Len(strNum)

//        if dblNumero < 1 Then
//            UnNumero = "cero"
//            Exit Function
//        End if
//        //
//        Una = True
//        Millon = False
//        Millones = False
//        if L < 4 Then Una = False
//        if dblNumero > 999999 Then Millon = True
//        if dblNumero > 1999999 Then Millones = True
//        strB = ""
//        strQ = strNum
//        vez = 0

//        //UPGRADE_WARNING: El límite inferior de la matriz strN ha cambiado de 1 a 0. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1033"'
//        ReDim strN(cGrupos)
//        strQ = Right(New string("0", cAncho) & strNum, cAncho)
//        For k = Len(strQ) To 1 Step -3
//            vez = vez + 1
//            strN(vez) = Mid(strQ, k - 2, 3)
//        Next
//        MaxVez = cGrupos
//        For k = cGrupos To 1 Step -1
//            if strN(k) = "000" Then
//                MaxVez = MaxVez - 1
//            Else
//                Exit For
//            End if
//        Next
//        For vez = 1 To MaxVez
//            strU = ""
//            strD = ""
//            strC = ""
//            strNum = strN(vez)
//            L = Len(strNum)
//            k = Val(Right(strNum, 2))
//            if Right(strNum, 1) = "0" Then
//                k = k / 10
//                strD = decena(k)
//            ElseIf k > 10 And k < 16 Then
//                k = Val(Mid(strNum, L - 1, 2))
//                strD = otros(k)
//            Else
//                strU = unidad(Val(Right(strNum, 1)))
//                if L - 1 > 0 Then
//                    k = Val(Mid(strNum, L - 1, 1))
//                    strD = deci(k)
//                End if
//            End if
//            //---Parche de Esteve
//            if L - 2 > 0 Then
//                k = Val(Mid(strNum, L - 2, 1))
//                //Con esto funcionará bien el 100100, por ejemplo...
//                if k = 1 Then //Parche
//                    if Val(strNum) = 100 Then //Parche
//                        k = 10 //Parche
//                    End if //Parche
//                End if
//                strC = centena(k) & " "
//            End if
//            //------
//            if strU = "uno" And Left(strB, 4) = " mil" Then strU = ""
//            strB = strC & strD & strU & " " & strB

//            if (vez = 1 Or vez = 3) Then
//                if strN(vez + 1) != "000" Then strB = " mil " & strB
//            End if
//            if vez = 2 And Millon Then
//                if Millones Then
//                    strB = " millones " & strB
//                Else
//                    strB = "un millón " & strB
//                End if
//            End if
//        Next
//        strB = Trim(strB)
//        if Right(strB, 3) = "uno" Then
//            strB = Left(strB, Len(strB) - 1) & m_Sexo1 //"a"
//        End if
//        Do  //Quitar los espacios dobles que haya por medio
//            iA = InStr(strB, "  ")
//            if iA = 0 Then Exit Do
//            strB = Left(strB, iA - 1) & Mid(strB, iA + 1)
//        Loop
//        //
//        if Left(strB, 5 + m_LenSexo1) = "un" & m_Sexo1 & " un" Then
//            strB = Mid(strB, 4 + m_LenSexo1)
//        End if
//        //---Nueva comparación                                     (01:16 25/Ene/99)
//        if Left(strB, 5) = "un un" Then
//            strB = Mid(strB, 4)
//        End if
//        //
//        // Comprobar sólo si se especifica "un* mil ",                   (05/Mar/99)
//        // no "un* mil" ya que puede ser "un* millón"
//        //if Left$(strB, 6 + m_LenSexo1) = "un" & m_Sexo1 & " mil" Then
//        if Left(strB, 7 + m_LenSexo1) = "un" & m_Sexo1 & " mil " Then
//            strB = Mid(strB, 4 + m_LenSexo1)
//            // Puede que el importe sea sólo "un mil" o "una mil"            (19/Ago/00)
//        ElseIf strB = "un" & m_Sexo1 & " mil" Then
//            strB = Mid(strB, 4 + m_LenSexo1)
//        End if
//        //
//        //---Nueva comparación                                     (15:11 25/Ene/99)
//        //if Left$(strB, 6) = "un mil" Then
//        // Que debe estar así, para que no quite "un millón"             (05/Mar/99)
//        if Left(strB, 7) = "un mil " Then
//            strB = Mid(strB, 4)
//        End if
//        //
//        if Right(strB, 15 + m_LenSexo1) != "millones mil un" & m_Sexo1 Then
//            iA = InStr(strB, "millones mil un" & m_Sexo1)
//            if iA Then strB = Left(strB, iA + 8) & Mid(strB, iA + 13)
//        End if
//        //---Nueva comparación                                   (15:13 25/Ene/99)
//        if Right(strB, 15) != "millones mil un" Then
//            iA = InStr(strB, "millones mil un")
//            if iA Then strB = Left(strB, iA + 8) & Mid(strB, iA + 13)
//        End if
//        //
//        // De algo sirve que la gente pruebe las rutinas...              (05/Mar/99)
//        // ¡¡¡ Gracias gente !!!
//        if Millones Then
//            // Comprobación de -as ??? millones
//            // convertir en -os ??? millones
//            // Pero sólo si el sexo es femenino
//            if m_Sexo1 = "a" Then
//                //if (strB Like "*as * millones*") Then
//                // Usar un bucle Do por si hay varias coincidencias      (07/Dic/00)
//                Do While (strB Like "*as * millones*")
//                    // Buscar la primera terminación "as " y cambiar por "os "
//                    k = InStr(strB, "as ")
//                    if k Then
//                        Mid(strB, k) = "os "
//                    End if
//                Loop
//                //End if
//                // La comparación anterior no funciona con x00 millones  (30/Jun/00)
//                //if (strB Like "*as millones*") Then
//                // Usar un bucle Do por si hay varias coincidencias      (07/Dic/00)
//                Do While (strB Like "*as millones*")
//                    // Buscar la primera terminación "as " y cambiar por "os "
//                    k = InStr(strB, "as millones")
//                    if k Then
//                        Mid(strB, k) = "os millones"
//                    End if
//                Loop
//                //End if
//                //
//                //
//                //------------------------------------------------------------------
//                // Comprobar si dice algo así ...una millones            (08/Jul/00)
//                // Por ejemplo en 821.xxx.xxx decia ochocientos veintiuna millones
//                //------------------------------------------------------------------
//                k = InStr(strB, "una mill")
//                if k Then
//                    strB = Left(strB, k + 1) & Mid(strB, k + 3)
//                End if
//                //
//                //
//            End if
//        End if
//        //
//        //
//        //--------------------------------------------------------------------------
//        // Cambiar los veintiun por veintiún, etc por sus acentuadas     (08/Jul/00)
//        Do
//            k = InStr(strB, "veintiun ")
//            if k Then
//                Mid(strB, k) = "veintiún "
//            End if
//        Loop While k
//        // El veintidos creo que nunca lo he acentuado...                (08/Jul/00)
//        // pero en la enciclopedia consultada lo acentúa
//        Do
//            k = InStr(strB, "veintidos ")
//            if k Then
//                Mid(strB, k) = "veintidós "
//            End if
//        Loop While k
//        Do
//            k = InStr(strB, "veintitres ")
//            if k Then
//                Mid(strB, k) = "veintitrés "
//            End if
//        Loop While k
//        Do
//            k = InStr(strB, "veintiseis ")
//            if k Then
//                Mid(strB, k) = "veintiséis "
//            End if
//        Loop While k
//        //--------------------------------------------------------------------------
//        //
//        //
//        if Right(strB, 6) = "ciento" Then
//            strB = Left(strB, Len(strB) - 2)
//        End if
//        if Negativo Then strB = "menos " & strB

//        UnNumero = Trim(strB)

//        // Restablecer el valor anterior
//        m_Sexo1 = Sexo1Ant
//        m_LenSexo1 = Len(m_Sexo1)
//    }


//    private Sub InicializarArrays()
//        //Asignar los valores
//        unidad(1) = "un"
//        unidad(2) = "dos"
//        unidad(3) = "tres"
//        unidad(4) = "cuatro"
//        unidad(5) = "cinco"
//        unidad(6) = "seis"
//        unidad(7) = "siete"
//        unidad(8) = "ocho"
//        unidad(9) = "nueve"
//        //
//        decena(1) = "diez"
//        decena(2) = "veinte"
//        decena(3) = "treinta"
//        decena(4) = "cuarenta"
//        decena(5) = "cincuenta"
//        decena(6) = "sesenta"
//        decena(7) = "setenta"
//        decena(8) = "ochenta"
//        decena(9) = "noventa"
//        //
//        centena(1) = "ciento"
//        centena(2) = "doscient" & m_Sexo2
//        centena(3) = "trescient" & m_Sexo2
//        centena(4) = "cuatrocient" & m_Sexo2
//        centena(5) = "quinient" & m_Sexo2
//        centena(6) = "seiscient" & m_Sexo2
//        centena(7) = "setecient" & m_Sexo2
//        centena(8) = "ochocient" & m_Sexo2
//        centena(9) = "novecient" & m_Sexo2
//        centena(10) = "cien" //Parche
//        //
//        deci(1) = "dieci"
//        deci(2) = "veinti"
//        deci(3) = "treinta y "
//        deci(4) = "cuarenta y "
//        deci(5) = "cincuenta y "
//        deci(6) = "sesenta y "
//        deci(7) = "setenta y "
//        deci(8) = "ochenta y "
//        deci(9) = "noventa y "
//        //
//        otros(1) = "1"
//        otros(2) = "2"
//        otros(3) = "3"
//        otros(4) = "4"
//        otros(5) = "5"
//        otros(6) = "6"
//        otros(7) = "7"
//        otros(8) = "8"
//        otros(9) = "9"
//        otros(10) = "10"
//        otros(11) = "once"
//        otros(12) = "doce"
//        otros(13) = "trece"
//        otros(14) = "catorce"
//        otros(15) = "quince"
//    End Sub
//    //UPGRADE_NOTE: Class_Initialize se actualizó a Class_Initialize_Renamed. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1061"'
//    private Sub Class_Initialize_Renamed()
//        m_Sexo1 = "o"
//        m_Sexo2 = "os"
//    End Sub
//    public Sub New()
//        MyBase.New()
//        Class_Initialize_Renamed()
//    End Sub
//    public Function ConvDecimal(ByVal strNum As string, Optional ByRef sDecimal As string = ",", Optional ByRef sDecimalNo As string = ".") As string
//        // Asigna el signo decimal adecuado (o lo intenta)               (10/Ene/99)
//        // Devuelve una cadena con el signo decimal del sistema
//        private sNumero As string
//        private i As Integer
//        private j As Integer

//        On Error Resume Next // Si se produce un error, continuar (07/Jul/00)

//        // Averiguar el signo decimal
//        sNumero = Format(25.5, "#.#")
//        if InStr(sNumero, ".") Then
//            sDecimal = "."
//            sDecimalNo = ","
//        Else
//            sDecimal = ","
//            sDecimalNo = "."
//        End if

//        strNum = Trim(strNum)
//        if Left(strNum, 1) = sDecimalNo Then
//            Mid(strNum, 1, 1) = sDecimal
//        End if

//        // Si el número introducido contiene signos no decimales
//        j = 0
//        i = 1
//        Do
//            i = InStr(i, strNum, sDecimalNo)
//            if i Then
//                j = j + 1
//                i = i + 1
//            End if
//        Loop While i

//        if j = 1 Then
//            // cambiar ese símbolo por un espacio, si sólo hay uno de esos signos
//            i = InStr(strNum, sDecimalNo)
//            if i Then
//                if InStr(strNum, sDecimal) Then
//                    Mid(strNum, i, 1) = " "
//                Else
//                    Mid(strNum, i, 1) = sDecimal
//                End if
//            End if
//        Else
//            //En caso de que tenga más de uno de estos símbolos
//            //convertirlos de manera adecuada.
//            //Por ejemplo:
//            //si el signo decimal es la coma:
//            //   1,250.45 sería 1.250,45 y quedaría en 1250,45
//            //si el signo decimal es el punto:
//            //   1.250,45 sería 1,250.45 y quedaría en 1250.45
//            //
//            //Aunque no se arreglará un número erróneo:
//            //si el signo decimal es la coma:
//            //   1,250,45 será lo mismo que 1,25
//            //   12,500.25 será lo mismo que 12,50
//            //si el signo decimal es el punto:
//            //   1.250.45 será lo mismo que 1.25
//            //   12.500,25 será lo mismo que 12.50
//            //
//            i = 1
//            Do
//                i = InStr(i, strNum, sDecimalNo)
//                if i Then
//                    j = j - 1
//                    if j = 0 Then
//                        Mid(strNum, i, 1) = sDecimal
//                    Else
//                        Mid(strNum, i, 1) = " "
//                    End if
//                    i = i + 1
//                End if
//            Loop While i
//        End if

//        j = 0
//        // Quitar los espacios que haya por medio
//        Do
//            i = InStr(strNum, " ")
//            if i = 0 Then Exit Do
//            strNum = Left(strNum, i - 1) & Mid(strNum, i + 1)
//        Loop

//        ConvDecimal = strNum

//        Err.Clear()
//    }
//}

//<Security.Permissions.FileIOPermission(Security.Permissions.SecurityAction.Assert)> _
//public class ImpresorClass
//{
//    private string _dir;
//    public string Directorio
//    {
//        get {return _dir;}
//        set {_dir = value;}
//    }

//    private string _puerto;
//    public string Puerto
//    {
//        get {return _puerto;}
//        set {_puerto = value;}
//    }

//    public ImpresorClass (string directorio, string puerto)
//    {
//        _dir = directorio;
//        _puerto = puerto;
//    }

//    public void Imprime(string Texto)
//    {
//        System.IO.FileStream f = new System.IO.FileStream(string.Format("{0}\tmp.txt", _dir), System.IO.FileMode.Create);
//        Texto = "\n" + Texto + "\n";
//        byte[] mensaje = System.Text.Encoding.UTF8.GetBytes(Texto);
//        f.Write(mensaje, 0, mensaje.Length);
//        f.Close();
//        char a = (char)34;
//        //Shell("cmd /Q /U /C " & a & string.Format("type {0}\tmp.txt > {1}", _dir, _puerto) & a, AppWinStyle.NormalFocus, True)
//    }

//}

public class FuncionesClass
{
    public static string QuitarCeros(string Valor)
    {
        int i = 0;
        string tmp;
        if (Valor==null)
            tmp = "0000";
        else
            foreach (char letra in Valor)
            {
                if (letra=='0')
                    i += 1;
                else
                {
                    break;
                }
             }
    
        tmp = Valor.Substring(i-1);
        return tmp;
    }

    public static string PonerCeros(string Valor)
    {
        string tmp = "";
        if (Valor==null)
            tmp = "0000";
        else
        {
            tmp = Valor;
            for (int x=Valor.Length; x<=3; x++)
                tmp = "0" + tmp;
        }
        return tmp;
    }
}

//public class PrintDevice
//{
//    public PrintDevice (System.Drawing.Printing.PrinterSettings ps)
//    {
//        string[] s = Imprimir(ps);
//        sDriverName = s[0];
//        sDeviceName = s[1];
//        sOutputPort = s[2];
//    }

//    private string sDriverName;
//    public readonly string DriverName
//    {
//        get {return sDriverName;}
        
//    }

//    private string sDeviceName;
//    public readonly string DeviceName
//    {
//        get {return sDeviceName;}
//    }

//    private string sOutputPort;
//    public readonly string OutputPort
//    {
//        get {return sOutputPort;}
//    }

//    <Runtime.InteropServices.StructLayout(LayoutKind.Sequential)> _
//    private class DEVNAMES
//    {
//        public wDriverOffset As UShort
//        public wDeviceOffset As UShort
//        public wOutputOffset As UShort
//        public wDefault As UShort
//    }

//    <DllImportAttribute("kernel32.dll", EntryPoint:="GlobalLock", _
//    SetLastError:=True, CharSet:=CharSet.Unicode, _
//    ExactSpelling:=True, _
//    CallingConvention:=CallingConvention.StdCall)> _
//    private static Function GlobalLock(ByVal hMem As IntPtr) As IntPtr
//    }

//    <DllImportAttribute("kernel32.dll", EntryPoint:="GlobalUnlock", _
//    SetLastError:=True, CharSet:=CharSet.Unicode, _
//    ExactSpelling:=True, _
//    CallingConvention:=CallingConvention.StdCall)> _
//    private static Function GlobalUnlock(ByVal hMem As IntPtr) As Boolean
//    }

//    <DllImportAttribute("kernel32.dll", EntryPoint:="GlobalFree", _
//    SetLastError:=True, CharSet:=CharSet.Unicode, _
//    ExactSpelling:=True, _
//    CallingConvention:=CallingConvention.StdCall)> _
//    private static Function GlobalFree(ByVal hMem As IntPtr) As Integer
//    }

//    private static string[] Imprimir(System.Drawing.Printing.PrinterSettings ps)
//    {
//        private dev As New DEVNAMES
//        private hDevNames As IntPtr = ps.GetHdevnames
//        private pDevNames As IntPtr = GlobalLock(hDevNames)
//        Marshal.PtrToStructure(pDevNames, dev)
//        private _driverName As string = Marshal.PtrToStringAuto(pDevNames.ToInt32 + dev.wDriverOffset * Marshal.SystemDefaultCharSize)
//        private _deviceName As string = Marshal.PtrToStringAuto(pDevNames.ToInt32 + dev.wDeviceOffset * Marshal.SystemDefaultCharSize)
//        private _outputPort As string = Marshal.PtrToStringAuto(pDevNames.ToInt32 + dev.wOutputOffset * Marshal.SystemDefaultCharSize)
//        GlobalUnlock(hDevNames)
//        GlobalFree(hDevNames)
//        private sArray() As string = {_driverName, _deviceName, _outputPort}
//        return sArray
//    }

}