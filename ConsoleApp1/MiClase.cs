using System;

namespace TallerDeLenguajes
{
    public class Pixel
    {
        //atributos encapsulados
        private int x;
        private int y;

        //propiedades
        public int X 
        {
            get => x; 
            set => x = value;
        }
        public int Y
        { 
            get => y;
            set => y = value;
        }
        //constructor por defecto
        public Pixel()
        {
            this.x = 0;
            this.y = 0;
        }

        //constructor parametrizado
        public Pixel(int x, int y)
        {
            this.x = x;
            this.y = y;
        }


        //metodos
        public void MoverPixel(int num1,int num2)
        {
            this.x = num1;
            this.y = num2;
            Console.WriteLine("hola mund ");
        }
    }

    public class Rectangulo
    {
        //atributos
        private int basse;
        private int altura;


        //propiedades
        public int Basse { get => basse; set => basse = value; }
        public int Altura { get => altura; set => altura = value; }

        //metodos

        public int calculoSuperficie()
        {
            return this.basse * this.altura;
        }
        //constructores
        public Rectangulo()
        {

        }
        public Rectangulo(int basse, int altura)
        {
            this.basse = basse;
            this.altura = altura;
        }


    }

}

