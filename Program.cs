using System;

namespace Actividad_3
{
    class Program
    {
        static void Main(string[] args)
        {
           programa();

        }
        public static void programa(){

            //Declarando la variable que manejara la fecha y hora
            DateTime ahora = DateTime.Now;
            // presentacion del programa con los datos pedidos en la planeacion 
            Console.WriteLine("El siguiente programa calcula medidas estadisticas");
            Console.WriteLine("Autor: Jesús Darío Rodríguez");
            Console.WriteLine("Matricula: es1822021661");
            Console.WriteLine("Actividad 3. Resolver problemas con C#");

            //Mostrando la fecha y hora a traves de DateTime
            Console.WriteLine("Fecha actual: {0}", ahora.ToShortDateString());
            Console.WriteLine("Hora actual:{0}", ahora.ToShortTimeString());
            Console.WriteLine("Presione cualquier tecla para continuar...");
            //se agrega la necesidad de presionar una tecla para que la presentacion del programa
            //pueda ser leeida 
            System.Console.ReadKey();
            Console.Clear();
            // requiriendo los datos de x al usuario
            Console.WriteLine("Ingrese el primer parametro de x");
            //convirtiendo el dato ingresado a un double y gardandolo en una variable 
            double num1 = Convert.ToDouble(Console.ReadLine());

            // requiriendo los datos de x al usuario
            Console.WriteLine("Ingrese el Segundo parametro de x");
            //convirtiendo el dato ingresado a un double y gardandolo en una variable 
            double num2 = Convert.ToDouble(Console.ReadLine());

            // requiriendo los datos de x al usuario
            Console.WriteLine("Ingrese el Tercer parametro de x");
            //convirtiendo el dato ingresado a un double y gardandolo en una variable 
            double num3 = Convert.ToDouble(Console.ReadLine());

            //Formula para la media
            double media = (num1 + num2 + num3) / 3;
            //Formula para la varianza 
            double auxVarianza1 = num1 - media;
            double auxVarianza2 = num2 - media;
            double auxVarianza3 = num3 - media;
            double varianza = ((Math.Pow(auxVarianza1, 2)+(Math.Pow(auxVarianza2, 2 )+(Math.Pow(auxVarianza3, 2)))) / 3);
            // calulando la desviacion estandar

            double desviacion = Math.Sqrt(varianza);

            Console.WriteLine("Los resultados son los siguientes: ");
            Console.WriteLine("La media calculada fue :{0}", media);
            Console.WriteLine("La varianza calculada fue :{0}", varianza);
            Console.WriteLine("La desvuacion estandar calculada fue :{0}", desviacion);



        }
        
    }
}
