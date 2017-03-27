using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using Excel = Microsoft.Office.Interop.Excel;
using Cl = ClasesSorteo.helpers;
using System.Collections;


namespace ClasesSorteo.helpers
{
    class leerExcel
    {


        Cl.tarjetaInfo tarjetaInfo;
        ArrayList infoTrajetas;

        public ArrayList getExcelFile(string Ruta)
        {
            infoTrajetas = new ArrayList();
            //Create COM Objects. Create a COM object for everything that is referenced
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(@Ruta);
            Excel._Worksheet xlWorksheet = (Excel.Worksheet)xlWorkbook.Sheets[1];
            Excel.Range xlRange = xlWorksheet.UsedRange;

            int rowCount = xlRange.Rows.Count;
            int colCount = xlRange.Columns.Count;

            //iterate over the rows and columns and print to the console as it appears in the file
            //excel is not zero based!!
            for (int i = 6; i <= rowCount; i++)
            {

                tarjetaInfo = new Cl.tarjetaInfo();
                if (xlRange.Cells[i, 3] != null && (xlRange.Cells[i, 3] as Excel.Range).Value2 != null)
                { tarjetaInfo.Cantidad = (xlRange.Cells[i, 3] as Excel.Range).Value2.ToString(); }

                if (xlRange.Cells[i, 5] != null && (xlRange.Cells[i, 5] as Excel.Range).Value2 != null)
                { tarjetaInfo.Fecha = (xlRange.Cells[i, 5] as Excel.Range).Value2.ToString(); }

                if (xlRange.Cells[i, 6] != null && (xlRange.Cells[i, 6] as Excel.Range).Value2 != null)
                { tarjetaInfo.Status = (xlRange.Cells[i, 6] as Excel.Range).Value2.ToString(); }

                if (xlRange.Cells[i, 7] != null && (xlRange.Cells[i, 7] as Excel.Range).Value2 != null)
                { tarjetaInfo.Descripcion = (xlRange.Cells[i, 7] as Excel.Range).Value2.ToString(); }

                if (xlRange.Cells[i, 14] != null && (xlRange.Cells[i, 14] as Excel.Range).Value2 != null)
                { 
                    tarjetaInfo.Contrato = (xlRange.Cells[i, 14] as Excel.Range).Value2.ToString(); 
                    infoTrajetas.Add(tarjetaInfo);
                }

                
               
            }

            //cleanup
            GC.Collect();
            GC.WaitForPendingFinalizers();

            //rule of thumb for releasing com objects:
            //  never use two dots, all COM objects must be referenced and released individually
            //  ex: [somthing].[something].[something] is bad

            //release com objects to fully kill excel process from running in the background
            Marshal.ReleaseComObject(xlRange);
            Marshal.ReleaseComObject(xlWorksheet);

            //close and release
            xlWorkbook.Close();
            Marshal.ReleaseComObject(xlWorkbook);

            //quit and release
            xlApp.Quit();
            Marshal.ReleaseComObject(xlApp);

            return infoTrajetas;
        }

    }
}
