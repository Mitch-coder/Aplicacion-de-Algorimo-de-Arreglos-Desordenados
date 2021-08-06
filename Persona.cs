using System;
using System.Collections.Generic;
using System.Text;

namespace applicacionDeAlgoritmoUno
{
    public class Persona
    {
        public int id;
        public int age;
        public string name;
        public  void Create(int id,string name,int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }
    }
}
