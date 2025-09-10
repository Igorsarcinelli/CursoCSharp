using System;

namespace CursoCSharp.ClassesEObjetos
{
    interface Ponto
    {
        void MoverNaDiagonal(int delta);
    }

    struct Coordenada : Ponto
    {
        public int X;
        public int Y;

        public Coordenada(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void MoverNaDiagonal(int delta)
        {
            X += delta;
            Y += delta;
        }
    }

    public class Struct
    {
        public static void Executar()
        {
            Coordenada coordenadaInicial;

            coordenadaInicial.X = 2;
            coordenadaInicial.Y = 3;

            Console.WriteLine("Coordenada Inicial:");
            Console.WriteLine("X = {0}", coordenadaInicial.X);
            Console.WriteLine("Y = {0}", coordenadaInicial.Y);

            coordenadaInicial.MoverNaDiagonal(5);
            Console.WriteLine("Após mover na diagonal:");
            Console.WriteLine("X = {0}", coordenadaInicial.X);
            Console.WriteLine("Y = {0}", coordenadaInicial.Y);
        }
    }
}
