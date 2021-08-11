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
            try
            {
                validateNumbers(textQuantity.Text, "Cantidad de elementos");
                size = int.Parse(textQuantity.Text);
                arrayPersona = new Persona[size];
                position = 0;
                clearText(1);
                dtgvRegister.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
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
                try
                {
                    validateDataUser( textName.Text, out int age);
                    arrayPersona[i].name = textName.Text;
                    arrayPersona[i].age = int.Parse(textAge.Text);
                    MessageBox.Show("La persona con Id = " + x + " se actualizo");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);               
                }
               
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
            if (position<=0)
                MessageBox.Show("El registro se encuentra vacio");
            else
            {
                dtgvRegister.Rows.Clear();
                for (int i = 0; i < arrayPersona.Length; i++)
                {
                    dtgvRegister.Rows.Add();
                    dtgvRegister.Rows[i].Cells[0].Value = arrayPersona[i].id;
                    dtgvRegister.Rows[i].Cells[1].Value = arrayPersona[i].name;
                    dtgvRegister.Rows[i].Cells[2].Value = arrayPersona[i].age;
                }
            }
        }
        // funciones para validar espacio y buscar
        public void insert()
        {
            if (position <= size - 1)
            {
                try
                {
                    validateDataUser(textName.Text, out int age);
                    objPersona.Create(int.Parse(textId.Text), textName.Text, int.Parse(textAge.Text));
                    arrayPersona[position] = objPersona;
                    position++;
                    objPersona = new Persona();
                    clearText(1);
                }
                catch (Exception e)
                { 
                    MessageBox.Show(e.Message);
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
                validateNumbers(textId.Text, "id");
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
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
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
        private void validateDataUser( string name, out int age)
        {
            //validacion id
            validateNumbers(textId.Text, "id");
            //validacion de nombre
            if (string.IsNullOrWhiteSpace(name))
                throw new Exception("El nombre es requerido!");
            //validacion de edad
            if (string.IsNullOrWhiteSpace(textAge.Text))
                throw new Exception("La edad es requerida");
            if (!int.TryParse(textAge.Text, out int exi2))
                throw new Exception($"El valor de la edad: \"{textAge.Text}\" es invalido!");
            age = exi2;
            if (age>100||age<0)
                throw new Exception("La edad esta fuera del rango establecido");
        }
        private void validateNumbers(string text,string field)
        {
            if (string.IsNullOrEmpty(text))
                throw new Exception($"El campo {field} es requerido!");
            if (!int.TryParse(text, out int exi))
                throw new Exception($"El valor: \"{text}\" en {field} es invalido!");
            else
            {
                if (field== "Cantidad de elementos" && exi<=0)
                    throw new Exception("Solo puede establecer una cantidad positiva");
            }
   
        }
    }
}