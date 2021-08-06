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
        int size,position,i,x;
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
            insert();
        }
        private void btnRead_Click(object sender, EventArgs e)
        {
            search("No encontrado");
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(search("No existe") == true)
            {
                persona[i].name = textName.Text;
                persona[i].age = int.Parse(textAge.Text);
                MessageBox.Show("La persona con Id ="+ x +"se actualizo");
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (search("No existe") == true)
            {
                for (int k = i; k <= position - 1; k++)
                {
                    persona[k].id = persona[k + 1].id;
                    persona[k].name = persona[k + 1].name;
                    persona[k].age = persona[k + 1].age;
                }
                position--;
                MessageBox.Show("La persona con id" + x + "se elimino");
            }
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            
        }
        // funciones para validar espacio y buscar
        public void insert()
        {
            if(position<=size-1)
                persona[position].Create(int.Parse(textId.Text),textName.Text,int.Parse(textAge.Text));
            else
                MessageBox.Show("No hay espacio");
        }
        public bool search(string mensaje)
        {
            i = 0;
            x = int.Parse(textId.Text);

            while (i < position && x != persona[position].id)
            {
                i++;
            }
            if (i >= position)
            {
                MessageBox.Show(x+mensaje);
                return false;
            }
            else
                return true;
        }
    }
}
