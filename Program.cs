using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace u3A2
{
    class Program
    {


        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            
            int aux = 1;
            while (aux != 0)
            {
                //Presentacion del programa y autor
                Console.WriteLine("Vacunacion contra la covid - 19 ");
                Console.WriteLine("Este programa muestra las fechas disponibles de vaunacion");
                Console.WriteLine("y los efectos secundarios que las diferentes vacunas pudieran provocar");
                Console.WriteLine(" © Jesus Dario Rodriguez | ES1822021661");
                Console.WriteLine("");
                //despliegue del menu
                Console.WriteLine("=======================================");
                Console.WriteLine("1.- Consultar la fechas de vacunación ");
                Console.WriteLine("");
                Console.WriteLine("2.- Consultar los efectos de la vacuna");
                Console.WriteLine("");
                Console.WriteLine("3.- Salir");
                Console.WriteLine("");
                Console.WriteLine("=======================================");
                Console.WriteLine("Seleccione una opcion ...");
                Console.WriteLine("");
                //switch para llamar a la opcion deseada
                int seleccion = (int)Convert.ToInt32(Console.ReadLine());
                switch (seleccion)

                {

                    case 1:
                        fechas();
                        break;
                    case 2:
                        efectos();
                        break;
                    case 3:
                        
                        aux = 0;
                        break;
                    default:
                        Console.WriteLine("Elija una opción valida");
                        break;
                }
            }
        }
        //metodo para indicar los periodos de las fechas de vacunacion de acuerdo con la edad de la persona 
        static void fechas()
        {
            Console.WriteLine("¿Cual es su edad actual");
            int edad = (int)Convert.ToInt32(Console.ReadLine());
            if (edad >= 60)
            {
                Console.WriteLine("Su primer dosis se aplicara el dia 01/01/21");
                Console.WriteLine("Su segunda dosis debera ser aplicada el dia 15/01/21");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("============================================================");
                Console.WriteLine("Presione cualquier tecla para continuar...");
                System.Console.ReadKey();
                Console.Clear();
            }
            else if (edad >= 50 && edad <= 59)
            {
                Console.WriteLine("Su primer dosis se aplicara el dia 01/02/21");
                Console.WriteLine("La segunda dosis debera ser aplicada el dia 15/02/21");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("============================================================");
                Console.WriteLine("Presione cualquier tecla para continuar...");
                System.Console.ReadKey();
                Console.Clear();

            }
            else if (edad >= 40 && edad <= 49)
            {
                Console.WriteLine("Su primer dosis se aplicara el dia 15/02/21");
                Console.WriteLine("La segunda dosis debera ser aplicada el dia 02/03/21");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("============================================================");
                Console.WriteLine("Presione cualquier tecla para continuar...");
                System.Console.ReadKey();
                Console.Clear();
            }
            else if (edad >= 30 && edad <= 39)
            {
                Console.WriteLine("Su primer dosis se aplicara el dia 04/03/21");
                Console.WriteLine("La segunda dosis debera ser aplicada el dia 17/03/21");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("============================================================");
                Console.WriteLine("Presione cualquier tecla para continuar...");
                System.Console.ReadKey();
                Console.Clear();
            }
            else if (edad >= 18 && edad <= 29)
            {
                Console.WriteLine("Su primer dosis se aplicara el dia 30/03/21");
                Console.WriteLine("La segunda dosis debera ser aplicada el dia 14/04/21");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("============================================================");
                Console.WriteLine("Presione cualquier tecla para continuar...");
                System.Console.ReadKey();
                Console.Clear();
            }
        }
        //metodo para indicar los efectos secundarios de recibir tal o cual farmaco
        static void efectos()
        {
             //despliegue del menu de vacunas
            Console.WriteLine("");
            Console.WriteLine("Posibles efectos secundarios segun el farmaco aplicado");

            Console.WriteLine("");
            Console.WriteLine("1 - Sputnik.");
            Console.WriteLine("2 - Pfizer.");
            Console.WriteLine("3 - Astra Zeneca.");
            Console.Write("Seleccione el tipo de vacuna: ");
            int vacuna = (int)Convert.ToInt64(Console.ReadLine());     
            Console.Clear();
            //switch que despliega la informacion seleccionada de acuerdo a la entrada del usuario
            switch (vacuna)

            {

                case 1:
                    Console.WriteLine("");
                    Console.WriteLine("La vacuna Sputnik, de origen ruso fue la primer vacuna en ser lanzada para su uso masivo");
                    Console.WriteLine("El tipo de vacuna es: Vector viral no replicante ");
                    Console.WriteLine("Numero de dosis necesarias: 2 ");
                    Console.WriteLine("Posibles efectos secundarios:" +
                        "Dolor e hinchazón en el sitio de inyección," +
                        "cansancio, dolor de cabeza," +
                        "músculos y articulaciones," +
                        "fiebre, malestar general y escalofríos");
                    Console.WriteLine("");
                    Console.WriteLine("Presione cualquier tecla para continuar...");
                    System.Console.ReadKey();
                    Console.Clear();

                    break;

                case 2:
                    Console.WriteLine("");
                    Console.WriteLine("La vacuna Pfizer/Biontech es la unica hasta la fecha que ha sido" +
                        "aprovada por la FDA para ser aplicada en niños de entre 12 y 15 años ademas de ser la primer vacuna en " +
                        "haber sido aprobada por la WHO para su uso emergente");
                    Console.WriteLine("El tipo de vacuna es: ARN mensajero");
                    Console.WriteLine("Numero de dosis necesarias: 2");
                    Console.WriteLine("Posibles efectos secundarios:");
                    Console.WriteLine("Dolor en el sitio de inyección, " +
                        "cansancio, dolor de cabeza," +
                        " músculos y articulaciones, y fiebre");
                    Console.WriteLine("");
                    Console.WriteLine("Presione cualquier tecla para continuar...");
                    System.Console.ReadKey();
                    Console.Clear();
                    break;

                case 3:
                    Console.WriteLine("");
                    Console.WriteLine("La vacuna AstraZeneca, es desarrollada por la universidad de Oxford en inglaterra y esta autorizada por " +
                        "la agencia de medicinas de europa para su uso emergente ");
                    Console.WriteLine("El tipo de vacuna es: De vector viral");
                    Console.WriteLine("Numero de dosis necesarias: 2");
                    Console.WriteLine("Posibles efectos secundarios:");
                    Console.WriteLine("Dolor en el sitio de inyección, " +
                        "cansancio, dolor de cabeza," +
                        " músculos y articulaciones, y fiebre");
                    Console.WriteLine("");
                    Console.WriteLine("Presione cualquier tecla para continuar...");
                    System.Console.ReadKey();
                    Console.Clear();
                    break;

                default:
                    Console.WriteLine("");
                    Console.WriteLine("Opcion no valida");
                    Console.WriteLine("Presione cualquier tecla para continuar...");
                    System.Console.ReadKey();
                    Console.Clear();
                    break;

            }
        }
    }
}


