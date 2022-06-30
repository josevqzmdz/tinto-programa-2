using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;


// https://www.youtube.com/watch?v=lsv7rAsvYuA 
// 1
// https://www.youtube.com/watch?v=rSIzj2wbVrQ
// 2
namespace tinto_programa_2
{

	internal class MotorExcel
    {
        string Directorio_excel;
        _Application excel = new Excel.Application();
        Workbook wb;
        Worksheet ws;

        public MotorExcel(
            string directorio_excel,
            int Hoja
            )
        {
            this.Directorio_excel = directorio_excel;
            wb = excel.Workbooks.Open(Directorio_excel);
            ws = wb.Worksheets[Hoja];
        }

        /* metodos base */

        public void EscribirEnHoja(
            int i, 
            int j, 
            string info
            )
        {

            ws.Cells[i, j] = info;
        }

        public string LeerHoja(int i, int j)
        {
            if(ws.Cells[i, j].Value2 != null)
            {
                return ws.Cells[i, j];
            }
            else
            {
                return "";
            }
        }

        /* metodos heredados */
        public void AñadirFecha(string fecha)
        {
            EscribirEnHoja(1, 1, fecha);
        }

        public void Guardar()
        {
            wb.Save();
        }

        public void GuardarComo(string directorio_excel)
        {
            wb.SaveAs(directorio_excel);
        }
    }
}