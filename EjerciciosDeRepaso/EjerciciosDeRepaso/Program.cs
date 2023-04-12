using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosDeRepaso
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Menu();
            



        }
        private static void Menu() {
            string opcion = "";

            while (opcion != "0") {
                Console.WriteLine("EJERCICIOS DE REPASO");
                Console.WriteLine("--------------------");
                Console.WriteLine();
                Console.WriteLine("Menu");
                Console.WriteLine("------");
                Console.WriteLine("1. Mayor y menor de 3");
                Console.WriteLine("2. Tipo de triángulo");
                Console.WriteLine("3. Unión de positivos");
                Console.WriteLine("4. Invertir un número");
                Console.WriteLine("5. Siguiente primo");
                Console.WriteLine("6. Sumatoria de cuadrados");
                Console.WriteLine("7. Primera letra de cada nombre");
                Console.WriteLine();
                Console.WriteLine("0. Salir");
                Console.WriteLine();
                Console.Write("Elija una opcion: ");
                switch (Console.ReadLine()) {
                    case "0": opcion = "0"; 
                        break;
                    case "1": Ejercicio1();
                        break;
                    case "2":
                        Ejercicio2();
                        break;
                    case "3":
                        Ejercicio3();
                        break;
                    case "4":
                        Ejercicio4();
                        break;
                    case "5":
                        Ejercicio5();
                        break;
                    case "6":
                        Ejercicio6();
                        break;
                    case "7":
                        Ejercicio7();
                        break;
                    default: Console.WriteLine("Elija una opcion del menú o 0 para salir");
                        break;
                }
                Console.Clear();
            }
            Console.WriteLine("Chau nos vemos!!!!");
            Console.ReadLine();
        }


        /*
         1. Pedir tres números enteros al usuario y determinar cuál es el mayor y cuál
            es el menor.
         */

        public static void Ejercicio1() {
            Console.Write("Ingrese el primer número entero: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo número entero: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el tercer número entero: ");
            int num3 = int.Parse(Console.ReadLine());
            MayorDeTres(num1, num2, num3);
            Console.Read();
        }
        public static void MayorDeTres(int num1, int num2, int num3) {
            int menor = int.MaxValue;
            int mayor = int.MinValue;
            mayor = Math.Max(num1, mayor);
            mayor = Math.Max(num2, mayor);
            mayor = Math.Max(num3, mayor);
            
            menor = Math.Min(num1, menor);
            menor = Math.Min(num2, menor);
            menor = Math.Min(num3, menor);

            Console.WriteLine($"El mayor número ingresado fue: {mayor}");
            Console.WriteLine($"El menor número ingresado fue: {menor}");
           
        }

        /*
         2. Un triángulo es equilátero si todos sus lados son iguales, isósceles si dos de
            sus lados son iguales y escaleno si todos sus lados son diferentes. Ingresar 3
            números que representen el largo en centímetros de los lados de un
            triángulo, determinar si los lados dados son válidos para formar un triángulo,
            y en caso de ser un triángulo decir si es isósceles, escaleno o equilátero.
         */
        public static void Ejercicio2() {
            Console.Write("Ingrese el primer cateto: ");
            float cat1 = float.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo cateto: ");
            float cat2 = float.Parse(Console.ReadLine());

            Console.Write("Ingrese el tercer cateto: ");
            float cat3 = float.Parse(Console.ReadLine());
            if (cat1 > 0 && cat2 > 0 && cat3 > 0)
            {
                Console.WriteLine(TrianguloTipo(cat1, cat2, cat3));
            }
            else
            {
                Console.WriteLine("Debe ingresar solo números positivos");
            }
            Console.Read();
        }

        public static string TrianguloTipo(float cateto1, float cateto2, float cateto3) { 
           string trianguloTipo = string.Empty;
            if ((cateto1 == cateto2) && (cateto2 == cateto3))
            {
                trianguloTipo = "Equilatero";
            }
            else if (
                 ((cateto1 == cateto2) && (cateto2 != cateto3)) ||
                 ((cateto2 == cateto3) && (cateto1 != cateto3))
                    )
            {
                trianguloTipo = "Isósceles";
            }
            else {
                trianguloTipo = "Escaleno";
            }
            return trianguloTipo;
        }

        /*
         3. Ingresados dos números (numero1 y numero2), controlando que sean
            positivos, obtener un tercer número formado por los dígitos de numero1,
            seguidos de numero2. Ejemplo: numero1=42 y numero2=345; devolvería el
            nuevo número: 42345
         */
        public static void Ejercicio3()
        {
            Console.Write("Ingrese el primer número entero: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo número entero: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine(NumerosPositivosUnidos(num1, num2));
            Console.Read();
        }
        public static string NumerosPositivosUnidos(int num1, int num2) {
            string unionPositiva = "Debe ingresar solo números poisitivos";
              if(num1 > 0 && num2 > 0)
              {
                unionPositiva = $"{num1}{num2}";
              }
            return unionPositiva;
        }

        /*
         4. Invertir los dígitos de un número. Los dígitos más significativos se vuelven los
            menos significativos y viceversa. Ejemplo: Dado el número 4321 devuelve el
            número 1234.
         */
        public static void Ejercicio4()
        {
            Console.Write("Ingrese un número entero: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine(InvertirNumero(num1));
            Console.Read();

        }
        public static int InvertirNumero(int num1) {
            int numeroInvertido = num1;
            while(Math.Abs(num1) > 0)
            {
                if (numeroInvertido == num1)
                {
                    numeroInvertido = num1 % 10;
                   
                }
                else {
                    numeroInvertido *= 10;
                    numeroInvertido += num1 % 10;
                   
                }
                num1 /= 10;
            }

            return numeroInvertido;
            }
        /*
         5. Dado un número determinar el siguiente número primo. Ejemplo: Si ingresa 6
            se devuelve 7. Si ingresa 19 devuelve 23.
         */
        public static void Ejercicio5()
        {
            Console.Write("Ingrese un número entero: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine(SiguientePrimo(num1));
            Console.Read();

        }
        public static int SiguientePrimo(int num) {
            int siguientePrimo = num;
            if (num < 2)
            {
                siguientePrimo = 2;
            }
            else {

                while (!EsPrimo(++siguientePrimo)) ;
            }


            return siguientePrimo;
        }
        public static bool EsPrimo(int num) {
            bool esPrimo = true;
            if (num == 2)
            {
                esPrimo = true;
            }
            else if (num % 2 == 0)
            {
                esPrimo = false;
            }
            else if(num >2) {
              for(int i = 3; i < num && esPrimo; i +=2) {
                    esPrimo = !(num % i == 0);  
              }
            
            }

            
            return esPrimo;
        }

        /*
         6. Hacer un programa que vaya tomando una lista de números preguntando si
            desea agregar un número más y que el usuario responda “SI/NO”, calcule el
            cuadrado de cada número y devuelva la sumatoria de los cuadrados de
            todos los números. 
         */

        public static void Ejercicio6()
        {
            string opcion = "SI";
            List<float> numeros = new List<float>();
            while (opcion == "SI")
            {
                Console.Write("Ingrese un número entero: ");
                numeros.Add( float.Parse(Console.ReadLine()));
                Console.Write("Desea continuar agregando?: ");
                opcion = Console.ReadLine();
            }
            Console.WriteLine(SumatoriaDeCuadrados(numeros));
            Console.Read();
        }
        public static float SumatoriaDeCuadrados(List<float> numeros) {
            float sumaDeCuadrados = 0;
            foreach(float numero in numeros)
            {
                sumaDeCuadrados += numero * numero;
            }

            return sumaDeCuadrados;
        }

        /*
         7. Leer una lista de nombres y devolver un nuevo nombre con la primera letra
            de cada uno (mostrar por pantalla)
        */
        public static void Ejercicio7()
        {
            string opcion = "SI";
            List<string> nombres = new List<string>();
            while (opcion == "SI")
            {
                Console.Write("Ingrese un nombre: ");
                nombres.Add(Console.ReadLine());
                Console.Write("Desea continuar agregando?: ");
                opcion = Console.ReadLine();
            }
            Console.WriteLine(PrimerLetraDeCadaNombre(nombres));
            Console.Read();
        }

        public static string PrimerLetraDeCadaNombre(List<string> nombres) {
            string primerLitraDeCadaNombre = "";
            foreach (string nombre in nombres) {
                primerLitraDeCadaNombre += nombre[0];
            }
            return primerLitraDeCadaNombre;
        }

        /*
         8. Pedir al usuario que ingrese una lista tipo un operando, un operador y otro
            operando. Pudiéndose ingresar la cantidad de (operador – operando) que se
            desee y terminé con =. Operador: /, *, -, +.
            Operando: numero positivo.
            Ejemplo: Ingresa 31, ingresa +, ingresa 4, ingresa -, ingresa 11, ingresa +,
            ingresa 5, ingresa =; devuelve 29.
         */

        public static void Ejercicio8()
        { 

        }
        public static float OperadoresYOperandos(List<string> operadoresYOPerandos) {
            float operando1 = 0;
            float operando2 = 0;
            foreach (string operadorUOperando in operadoresYOPerandos) {
                
                
                if (operadorUOperando == "/") {
                   
                }
            }


            return operaciones;
        } 
    }
}
