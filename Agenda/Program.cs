using System;

using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Agenda
{


    class Contacto
    {

        // array.select 

        //file.writeline

        //private List<contacto> contacto

        // contacto.select(c => $"{c.nombre},{c.apellido},{c.edad},{c.telefono},{}")

        public string nombre;
        public string apellido;
        public string telefono;
        public string edad;

        public void presentarme()
        {
            Console.WriteLine("Hola soy {0} ", nombre);
        }
    }
    class Program
    {

       // public List<string> arr = new List<string>();

         



        public class Agenda
        {

           public static void AgregaContacto()
            {
                Console.WriteLine("Ingrese Nombre: ");
                string nombre = Console.ReadLine();

                Console.WriteLine("Ingrese Apellido: ");
                string apellido = Console.ReadLine();

                Console.WriteLine("Ingrese telefono: ");
                string telefono = Console.ReadLine();

                Console.WriteLine("Ingrese edad: ");
                int edad = int.Parse(Console.ReadLine());


            
            }


            public static void  MostrarAgenda()
            {
                // crea un objeto desde mi clase
                // una instancia de Contacto
                List<Contacto> persona = new List<Contacto> { nombre= "ale", apellido ="castel"};
                //  Accedo a una variable publica externa
                persona.nombre= "Juan";
                
                persona.presentarme("juan");  
              //    List<Contacto> persona = new List<Contacto>();

            string path = @"d:\\Agenda\Agenda.txt";

                // This text is added only once to the file.
                if (!File.Exists(path))
                {
                    Console.WriteLine("No existe Archivo");
                    // Create a file to write to.
                    //string[] createText = { "Archivo", "And", "Welcome" };
                    //File.WriteAllLines(path, createText);
                }

                // This text is always added, making the file longer over time
                // if it is not deleted.
               // string appendText = "This is extra text" + Environment.NewLine;
               // File.AppendAllText(path, appendText);

                // Open the file to read from.
                string[] readText = File.ReadAllLines(path);

             

                Console.WriteLine("Nombre      Apellido        Numero de Tel       EDAD");
               
                foreach (string s in readText)
                {
                    string[] items = s.Split(",");
                    foreach (string item in items)
                    {
                        Console.WriteLine(item);
                    }
                  //  persona[0] = items[0];

                   // persona.Add( persona[0] = items[0]);
                    
                    Console.WriteLine(s);

                }



            }


           public static void menu()
            {

                List<string> arr = new List<string>();

                Console.WriteLine(arr);
                Console.WriteLine("1. Agregar Contacto.");
                Console.WriteLine("2. Editar Contacto.");
                Console.WriteLine("3. Editar Contacto.");
                Console.WriteLine("4. Eliminar Contacto");
                Console.WriteLine("Seleccione Opcion:");


                int seleccion = Int32.Parse(Console.ReadLine());

                switch (seleccion)
                {
                    case 1:
                        Console.WriteLine("Agrega Contacto..");
                        AgregaContacto();
                        break;
                    case 2:
                        Console.WriteLine("Case 2");
                        break;
                    case 3:
                        Console.WriteLine("Case 3");
                        break;
                    case 4:
                        Console.WriteLine("Case 4");
                        break;

                    default:
                        //Console.WriteLine("Default case");
                        break;
                }



            }

        }

        

        static void Main(string[] args)
        {
            // mostrar contactos 
            
            // mostrar menu
            Agenda.MostrarAgenda();
            Agenda.menu();
            
            

            
            
        }
    }
}
