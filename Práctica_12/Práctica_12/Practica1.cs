using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

//Maximo Zamora 15/11/19

namespace Práctica_12
{
    class Practica1
    {
        [Serializable]
        public struct Mascota
        {
            public string nombre;
            public string especie;
            public string raza;
            public string sexo;
            public int edad;
        }
        static void Main(string[] args)
        {
            Mascota mascota1 = new Mascota();
            FileStream fs;
            BinaryFormatter formatter = new BinaryFormatter();
            const string Nombre_Archivo = "Mascota.bin";
            try
            {
                Console.WriteLine("Nombre:");
                mascota1.nombre = Console.ReadLine();
                Console.WriteLine("Especie:");
                mascota1.especie = Console.ReadLine();
                Console.WriteLine("Raza:");
                mascota1.raza = Console.ReadLine();
                Console.WriteLine("Sexo: ");
                mascota1.sexo = Console.ReadLine();
                Console.WriteLine("Edad:");
                mascota1.edad = Convert.ToInt32(Console.ReadLine());
                fs = new FileStream(Nombre_Archivo, FileMode.Create, FileAccess.Write);
                formatter.Serialize(fs, mascota1);
                fs.Close();
                Console.WriteLine();
                Console.WriteLine("Su mascota se ha registrado con éxito...");
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            
        }
    }
}
