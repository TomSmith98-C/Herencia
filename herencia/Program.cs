using System;

namespace herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Humano humano = new Humano();
            Console.WriteLine("soy humano:");
            humano.Respira();

            Gorila gorila = new Gorila();
            Console.WriteLine("soy Gorila:");
            gorila.SoyNegro();
            gorila.Comer(); 
          
            Caballo caballo = new Caballo();
            Console.WriteLine("soy un caballo :");
            caballo.CorroRapido();
            caballo.TienenHijos();

            niños niño = new niños();
            niño.lloro();
            niño.Pienso();

            Object obj = new object();
            Console.WriteLine(obj.GetType().ToString()); 
        }
    }

    class Mamiferos:Object
    {
        public void Respira()
        {
            Console.WriteLine("Respiro");
        }
        public void TienenHijos()
        {
            Console.WriteLine("Puedo tener hijos");
        }
        public void Comer()
        {
            Console.WriteLine("Puedo comer");
        }

    }
    class Humano:Mamiferos
    {
        public void Pienso()
        {
            Console.WriteLine("Puedo pensar");
        }
    }
    class Gorila:Mamiferos
    {
        public void SoyNegro()
        {
            Console.WriteLine("Soy de color negro");
        }
    }

    class Caballo:Mamiferos
    {
        public void CorroRapido()
        {
            Console.WriteLine("Puedo correr rapido");
        }
    }
    class niños : Humano
    {
        public void lloro()
        {
            Console.WriteLine("Llloro mucho");

        }
    } 
}
