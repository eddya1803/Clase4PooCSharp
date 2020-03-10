using System;

namespace demo
{
    class Program
    {
         const double PI = 3.141592;
        static void Main(string[] args)
        {
           int[] notas = new int[4];
           notas[0] = 88;
           notas[1] = 78;
           notas[2] = 72;
           notas[3] = 55;
           for (var i = 0; i < notas.Length; i++)
           {
            System.Console.WriteLine(notas[i]);
           }
           System.Console.WriteLine(PI);
        }

        public void Prueba(){
          
        }
    }
}
