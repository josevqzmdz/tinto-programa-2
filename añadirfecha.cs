using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tinto_programa_2
{
    public partial class añadirfecha : Form
    {
        string Directorio_excel = "";

        public añadirfecha(string directorio_excel)
        {
            Directorio_excel = directorio_excel;
            InitializeComponent();
        }

        // boton para añadir fecha
        private void fechabtn_Click(object sender, EventArgs e)
        {
            MotorExcel excelfecha = new MotorExcel(Directorio_excel, 1);
            excelfecha.AñadirFecha(DiaTxt.Text + "/ " + MesTxt.Text + "/ " + AñoTxt.Text);
        }

        private void añadirfecha_Load(object sender, EventArgs e)
        {

        }

        private void FechaTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
