using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace repasoCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(bracketmatcher2(Console.ReadLine()));
            //Console.WriteLine(esfactorial(Convert.ToInt32(Console.ReadLine())));

            //int[] arregloOG = { 1, 2, 3, 4, 5 };
            //int[] arregloInvertido = reverseArray(arregloOG);

            //for (int i = 0; i <= arregloInvertido.Length-1; i++)
            //{
            //    Console.WriteLine(arregloInvertido[i]);
            //}

            //Console.WriteLine(FindIntersection(Console.ReadLine()));

            int[] matrizNueva = {1, 2, 3, 4, 5 };

            int[] resultado = matriz(matrizNueva, 3);

            foreach (int n in resultado)
            {
                Console.WriteLine(n);
            }

        }

        //Este es el bueno
        public static int[] matriz(int[] matriz, int nuevoValor)
        {
            int[] matrizinvertida = new int[matriz.Length];

            for (int i = 0, j = matriz.Length - 1; i <= matriz.Length - 1; i++, j--)
            {
                matrizinvertida[i] = matriz[j];
            }

            Array.Resize(ref matrizinvertida, matrizinvertida.Length + 1);

            //Agregar el valor al final
            matrizinvertida[matrizinvertida.Length - 1] = nuevoValor;

            return matrizinvertida;

        }

        //Nuevo intento

        public static int[] inversionNueva(int[] matriz, int nuevoValor)
        {
            
            int[] matrizInvertida = new int[matriz.Length - 1];

            for (int i = 0, j = matriz.Length-1; i < matriz.Length-1; i++, j--)
            {
                matrizInvertida[i] = matriz[j];
            }

            Array.Resize(ref matrizInvertida, matrizInvertida.Length + 1);

            //Agregar el valor al final
            matrizInvertida[matrizInvertida.Length - 1] = nuevoValor;

            return matrizInvertida;
        }

        //BRACKET MATCHER
        public static string BracketMatcher(string str)
        {
            //Verificar que los parentesis cierren correctamente
            //1 = Exito
            //0 = Fallo

            int contador = 0;

            for (int i = 0; i <= str.Length-1; i++)
            {
                if (str[i] == '(')
                {
                    contador += 1;
                } else if (str[i] == ')')
                {
                    contador -= 1;
                }
            }

            return contador == 0 ? "1" : "0";
        }

        //Invertir cadena con arrays
        public static string invertirCadena(string valor)
        {
            char[] convertWord = valor.ToCharArray();

            Array.Reverse(convertWord);

            String word = new string(convertWord);

            return word;

        }

        //Invertir cadena con bucles
        public static string invertString(string str)
        {
            string reversedword = "";

            for (int i = str.Length-1; i >= 0; i++)
            {
                reversedword += str[i];
            }

            return reversedword;
        }

        //Palindromo
        public static string palindromo(string valor1)
        {
            string invertedWord = "";
            string palindromo = "";

            for (int i = valor1.Length - 1; i >= 0; i--)
            {
                invertedWord += valor1[i];
            }

            if(valor1 == invertedWord)
            {
                palindromo = "Es palindromo";
            }
            else
            {
                palindromo = "No lo es";
            }

                return palindromo;
        }

        //Palabra mas larga / Longest word

        public static string longestWord(string sen)
        {

            //Agregar
            //using System;
            //using System.Text.RegularExpressions;
            //using System.Linq;

            Regex rgx = new Regex(@"^\w\s");
            sen = rgx.Replace(sen, "");
            string[] words = sen.Split(' ');

            return words.OrderByDescending(x => x.Length).First();
        }

        

        public static string revertirCadena(string palabra)
        {
            string palabraalrevez = "";

            for (int i = palabra.Length - 1; i <= 0 ; i--)
            {
                palabraalrevez += palabra[i];
            }

            return palabraalrevez;
        }

        //Factorial
        public static int factorial(int num)
        {
            
            for (int i = num - 1; i > 0; i--)
            {
                num = num * i;
            }

            // code goes here  
            return num;
        }

        public static string reverseando(string value)
        {
            string word = "";

            for(int i = value.Length-1; i >= 0; i--)
            {
                word += value[i];
            }

            return word;
        }

        public static string bracketmatcher2(string value)
        {
            int contador = 0;

            for (int i = 0; i <= value.Length-1; i++)
            {
                if (value[i]== '(')
                {
                    contador ++;
                }else if (value[i] == ')')
                {
                    contador--;
                }

            }

            return contador == 0 ? "1" : "0";


        }

        //Es factorial
        public static int esfactorial(int num)
        {
            for (int i = num-1; i >= 1; i--) 
            {
                num *= i;
            }

            return num;
        }

        //Reversear array
        public static int[] reverseArray(int[] value)
        {
            int[] result = new int[value.Length];

            for (int i = 0; i < value.Length; i++)
            {
                result[i] = value[value.Length - 1 - i];
            }

            return value;
        }

        //Find Intersection
        public static string FindIntersection(string[] strArr)
        {
            string resultString = string.Join(",", strArr[0].Split(',').Select(x => x.Trim()).Intersect(strArr[1].Split(',').Select(x => x.Trim())));

            return string.IsNullOrEmpty(resultString) ? "false" : resultString;

        }

        ////Array inverso mas un agregado
        //public static int[] arrayinverso(int[] value)
        //{
        //    int[] resultado;
        //    for (int i = 0; i < value.Length; i++)
        //    {
                
        //    }

        //    Array.
        //}
        
        



        static void ejercicio1()
        {
            //Contar del 1 al 10
            for (int i = 1; i <=10; i++)
            {
                Console.WriteLine(i);
            }
        }

        static void ejercicio2()
        {
            //Mostrar solo numeros pares del 1 al 20
            for (int i = 0; i <= 20; i++)
            {
                if (i%2== 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        static void ejercicio3()
        {
            int suma = 0;
            //Sumar los numeros del 1 al 100
            for (int i = 0; i <=100; i++)
            {
                suma += i;
                
            }
            Console.WriteLine($"La suma de los numeros del 1 al 100 son: " + suma);

        }

        static void ejercicio4()
        {
            Console.WriteLine("Introduzca un numero");
            int variable = Convert.ToInt32(Console.ReadLine());
            int resultado = 0;
            for (int i = 0; i <= 10; i++)
            {
                resultado = variable * i;
                Console.WriteLine($"{variable} x {i} = {resultado}" );
            }

        }

        static void ejercicio5()
        {
            //Invertir una palabra
            string palabra = Console.ReadLine();
            int longitudPalabra = palabra.Length;
            string palabraInvertida = "";

            for (int i = longitudPalabra -1; i >= 0; i--)
            {
                palabraInvertida += palabra[i];
                
            }
            Console.WriteLine(palabra);
            Console.WriteLine(palabraInvertida);

        }

        //INDICES
        static void ejercicio6()
        {
            //Mostrar el primer y ultimo caracter de una palabra
            string palabra = Console.ReadLine();
            //int longitudPalabra = palabra.Length;

            

            Console.WriteLine($"Primera letra: {palabra[0]}");
            Console.WriteLine($"Ultima letra: {palabra[palabra.Length-1]}");

        }

        static void ejercicio7()
        {
            //Recorrer una palabra y mostrar cada caracter
            string palabra = Console.ReadLine();

            for (int i = 0; i <= palabra.Length -1; i++)
            {
                Console.WriteLine($"[{i}] {palabra[i]}");
            }
        }

        static void ejercicio8()
        {
            //Contar cuantas veces aparece una letra en una palabra
            string palabra = Console.ReadLine();
            string letra = Console.ReadLine();
            int contador = 0;
            for (int i = 0; i <= palabra.Length-1; i++)
            {
                if (palabra[i] == Convert.ToChar(letra))
                {
                    contador += 1;

                }
            }
            Console.WriteLine($"La letra {letra} aparece {contador} veces ");
        }

        static void ejercicio9()
        {
            //Mostrar el caracter en la posicion que elija el usuario
            string palabra = Console.ReadLine();
            int indice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"En la posicion {indice} esta la letra {palabra[indice]}");

        }

        static void ejercicio10()
        {
            //Invertir un array de numeros usando solo indices
            int[] numeros = { 1, 2, 3, 4, 5 };
            int temp = 0;

            for (int i = 0, j=numeros.Length-1; i <= j; i++, j--)
            {
                temp = numeros[i];
                    numeros[i] = numeros[j];
                numeros[j] = temp;

            }

            for (int i = 0; i <= numeros.Length-1; i++)
            {
                Console.WriteLine(numeros[i]);
            }


        }

        static void prueba()
        {
            //Revertir una cadena
            string cadena = Console.ReadLine();

            for (int i = cadena.Length-1; i >= 0; i--)
            {
                Console.Write(cadena[i]);
            }
        }

        static void contarVocales()
        {
            string cadena = Console.ReadLine();
            char vocal = Convert.ToChar(Console.ReadLine());
            int contador = 0;
            for (int i = 0; i <= cadena.Length-1; i++)
            {
                if (vocal == cadena[i])
                {
                    contador += 1;
                }

            }
            Console.WriteLine($"La cadena: {cadena} tiene {contador} vocales");
        }

        static void objetoString()
        {
            char[] caracteres = {'H', 'O', 'L', 'A'};

            //Creando una instancia de String
            String palabra = new string(caracteres);

            Console.WriteLine(palabra);
        }

        public static string reversalString(string str)
        {
            StringBuilder sb = new StringBuilder();

            char[] wordReversed = str.ToCharArray();

            Array.Reverse(wordReversed);

            String word = new string(wordReversed);

            //Add a new string
            Console.WriteLine("Would you like to add new text to the string? y/n");
            string decision = Console.ReadLine();

            if (decision == "y")
            {
                
                
                Console.WriteLine("In which way? type 'front' or 'end'");
                decision = Console.ReadLine();
                if (decision == "front")
                {
                    sb.Insert(0, Console.ReadLine());
                    sb.Append(word);
                    return sb.ToString();

                } else if (decision == "end")
                {
                    sb.Append(word);
                    sb.Append(Console.ReadLine());
                    return sb.ToString();

                }

            }

            return sb.ToString();
        }




    }
}
