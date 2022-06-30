using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;


namespace tinto_programa_2
{
    public partial class UserControl1: UserControl
    {
        
        string Directorio_Excel = @"C:\Users\Jose Miguel\Documents\tinto programa\tinto programa 2\Test3.xlsx";
        
        _Application excel = new Excel.Application();
        Workbook wb;
        Worksheet ws;

        public UserControl1()
        {
            InitializeComponent();
        }

        public void EscribirInfo()
        {

            MotorExcel _excel;
            // nombre, hoja num 
            _excel = new MotorExcel(Directorio_Excel, 1);
            _excel.EscribirEnHoja( 1, 1, "test");
        } 

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private añadirfecha añfecha;
      
        private void button1_Click(object sender, EventArgs e)
        {
            if(excel != null)
            {
                añfecha = new añadirfecha(Directorio_Excel);
                añfecha.Show();
            }
            else
            {
                // https://www.c-sharpcorner.com/UploadFile/mahesh/understanding-message-box-in-windows-forms-using-C-Sharp/
                string message = "No se ha seleccionado una hoja de excel";
                string title = "Error";
                MessageBox.Show(message, title);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            EscribirInfo();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.datagridviewrow.cells
        }
    }
}
