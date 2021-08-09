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
        Persona objPersona = new Persona();
        Persona []arrayPersona;
        int size,position=0,i,x;
        public Form1()
        {
            InitializeComponent();
        }
        private void btnSet_Click(object sender, EventArgs e)
        {
            size = int.Parse(textQuantity.Text);
            arrayPersona = new Persona[size];
            position = 0;
            clearText(1);
            dtgvRegister.Rows.Clear();
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            insert();
        }
        private void btnRead_Click(object sender, EventArgs e)
        {
            if (search("No fue encontrado ID:") == true)
            {
                dtgvRegister.Rows.Clear();
                dtgvRegister.Rows[0].Cells[0].Value = arrayPersona[i].id;
                dtgvRegister.Rows[0].Cells[1].Value = arrayPersona[i].name;
                dtgvRegister.Rows[0].Cells[2].Value = arrayPersona[i].age;
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(search("No existe ID:") == true)
            {
                arrayPersona[i].name = textName.Text;
                arrayPersona[i].age = int.Parse(textAge.Text);
                MessageBox.Show("La persona con Id = "+ x +" se actualizo");
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (search("No existe ID:") == true)
            {
                for (int k = i; k <position-1; k++)
                {
                    arrayPersona[k] = arrayPersona[k+1];
                }
                position--;
                MessageBox.Show("La persona con id " + x + " se elimino");
            }
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            dtgvRegister.Rows.Clear();
            for(int i =0;i<arrayPersona.Length;i++)
            {
                dtgvRegister.Rows.Add();
                dtgvRegister.Rows[i].Cells[0].Value = arrayPersona[i].id;
                dtgvRegister.Rows[i].Cells[1].Value = arrayPersona[i].name;
                dtgvRegister.Rows[i].Cells[2].Value = arrayPersona[i].age;
            }
        }
        // funciones para validar espacio y buscar
        public void insert()
        {
            if (position <= size - 1)
            {
                try
                {
                    objPersona.Create(int.Parse(textId.Text), textName.Text, int.Parse(textAge.Text));
                    arrayPersona[position] = objPersona;
                    position++;
                    objPersona = new Persona();
                    clearText(1);
                }
                catch (Exception)
                {
                    MessageBox.Show("Todos los campos son requeridos");
                }
            }
            else
            {
                MessageBox.Show("No hay espacio");
                clearText(2);
            }
               
        }
        public bool search(string mensaje)
        {
            i = 0;
            try
            {
                x = int.Parse(textId.Text);
                while (i < position && x != arrayPersona[i].id)
                {
                    i++;
                }
                if (i >= position)
                {
                    MessageBox.Show(mensaje + x);
                    return false;
                }
                else
                    return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Es necesario el ID del usuario");
            }
            return false;
        }
        public void clearText(int focus)
        {
            textId.Clear();
            textName.Clear();
            textAge.Clear();
            if (focus == 1)
                textId.Focus();
            else
                textQuantity.Focus();
        }
    }
}
