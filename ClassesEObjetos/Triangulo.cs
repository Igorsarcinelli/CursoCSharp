namespace CursoCSharp.ClassesEObjetos
{
    public class Triangulo
    {   //Esses são atributos 
        public double A;
        public double B;
        public double C;

        //Esse é método
        public double Area()
        {
            double p = (A + B + C) / 2.0;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}
