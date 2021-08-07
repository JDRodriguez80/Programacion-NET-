using System;

namespace U2_A2
{
    class Program
    {
        static void Main(string[] args)
        {
            // presentacion del programa 
            Console.WriteLine("Este programa Realiza un calculo de numeros dados y muestra sus posibles permutaciónes ");
            Console.WriteLine("=======================================================================================");
            Console.WriteLine("Autor: Jesús Darío Rodríguez");
            Console.WriteLine("Matricula: es1822021661");
            Console.WriteLine("=======================================================================================");
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.WriteLine("=======================================================================================");
            System.Console.ReadKey();
            Console.Clear();
            // requiriendo los datos del primer numero  al usuario
            Console.WriteLine("Ingrese el primer número");
            //convirtiendo el dato ingresado a un int y guardandolo en una variable 
            int num1 = (int)Convert.ToInt64(Console.ReadLine());

            // requiriendo los datos del segundo numero  al usuario
            Console.WriteLine("Ingrese el segundo número");
            //convirtiendo el dato ingresado a un int y guardandolo en una variable 
            int num2 = (int)Convert.ToInt64(Console.ReadLine());

            //requiriendo los datos del tercer numero  al usuario
            Console.WriteLine("Ingrese el tercer número");
            //convirtiendo el dato ingresado a un int y guardandolo en una variable 
            int num3 = (int)Convert.ToInt64(Console.ReadLine());

            //llamando al metodo para mostrar las permutaciones posibles
            permuta(num1, num2, num3);
            //llamando al metodo para mostrar la suma acumulativa
            sumas(num1, num2, num3);

        }
        //metodo para mostrar las posibles combinaciones de los numeros ingresados
        static void permuta(int num1, int num2, int num3) {
            Console.Clear();
            Console.WriteLine("Los numeros ingresados fueron: {" + num1 + "," + num2 + "," + num3 + "}");
            Console.WriteLine("Sus posibles combinaciones son: ");
            Console.WriteLine("=======================================================================================");
            Console.WriteLine("Posibles permutaciónes ");
            Console.WriteLine("{"+num1+","+num2+","+num3+"}");
            Console.WriteLine("{"+num1+","+num3+","+num2+"}");
            Console.WriteLine("{"+num2+","+num1+","+num3+"}");
            Console.WriteLine("{"+num2+","+num3+","+num1+"}");
            Console.WriteLine("{"+num3+","+num1+","+num2+"}");
            Console.WriteLine("{"+num3+","+num2+","+num1+"}");
        }
        //metodo para calcular la suma acumulativa 
        static void sumas(int num1, int num2, int num3) {
            //declaración e inicialización de variables auxiliares para guardar las sumas intermedias
            int aux1 = 0;
            int aux2 = 0;
            int aux3 = 0;
            aux1 = num1;
            aux2 = num1 + num2;
            aux3 = aux2 + num3;
            Console.WriteLine("La suama acumulativa es:");
            Console.WriteLine("{" + aux1 + "," + aux2 + "," + aux3 + "}");

        }

    }
}
