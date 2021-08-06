using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using System.Windows.Forms;

namespace applicacionDeAlgoritmoUno
{
    public partial class Form1 : Form
    {
        Persona[] persona;
        int size,position,i;
        public Form1()
        {
            InitializeComponent();
        }
        private void btnSet_Click(object sender, EventArgs e)
        {
            size = int.Parse(textQuantity.Text);
            persona = new Persona[size];
            position = 0;
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {

        }

        // funciones para validar espacio y buscar


    }

}
