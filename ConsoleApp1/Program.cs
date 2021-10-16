using System;
using System.Globalization;
using TallerDeLenguajes;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("me llamo gabriel");
            //Pixel mipixel = new Pixel();
            //Console.WriteLine("el valor de x = " + mipixel.X + " el valor de y = " + mipixel.Y);
            //Pixel miPixel2 = new Pixel(99, 98);
            //Console.WriteLine("el valor de x = " + miPixel2.X + " el valor de y = " + miPixel2.Y);
            //mipixel.X = 20;
            //Console.WriteLine("el valor de x = " + mipixel.X);
            //mipixel.MoverPixel(50, 100);
            //Console.WriteLine("el valor de x = " + mipixel.X + " el valor de y = " + mipixel.Y);

            ////crear rectangulo
            //Rectangulo nuevoRecttangulo = new Rectangulo(10, 10);

            //Console.WriteLine("la superficie es : {0} de el rectangulo base : {1} - altura {2} ", nuevoRecttangulo.calculoSuperficie(), nuevoRecttangulo.Basse, nuevoRecttangulo.Altura);
            CultureInfo culture = new CultureInfo("Us-us");//para cambiar fecha

            DateTime miFecha = new DateTime(1991,2,10);
            DateTime hoy = DateTime.Now; // now es una propiedad static que no hace falta usar el new
            int edadA = hoy.Year - miFecha.Year;
            int edadM = hoy.Month - miFecha.Month;
            int edadD = hoy.Day - miFecha.Day;


            Console.WriteLine("la fecha de nacimiento es : " + miFecha.ToShortDateString());
            Console.WriteLine("la fecha de nacimiento es : " + miFecha.ToString(culture));
            Console.WriteLine("la fecha de hoy es : " + hoy.ToLongDateString());

            Console.WriteLine("su edad al dia de hoy es de {0} años y {1} meses con {2} dias " , edadA,edadM,edadD);



        }
    }
}
