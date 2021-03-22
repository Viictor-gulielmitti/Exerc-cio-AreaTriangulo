using System;

namespace TRIANGULO
{
    class Program
    {
        static void Main(string[] args)
        {
            string entrada1;
            string entrada2;
            Area dobro,   Base , Altura;

            Console.WriteLine ( " Digite abaixo como medidas do triangulo, que serão calculadas " );
            Console.Write ( " Base: " );
            entrada1  =  Console . ReadLine ();
            Base =  Convert.ToDouble ( entrada1 );
            Console.Write ( " Altura: " );
            entrada2 = Console.ReadLine ();
            Altura = Convert.ToDouble ( entrada2 );
            Area  =  Base * Altura / 2 ;
            Console.WriteLine ( " \n Area " );
            Console.WriteLine ( $" A Area é: { Area } " );
            
    }
}
