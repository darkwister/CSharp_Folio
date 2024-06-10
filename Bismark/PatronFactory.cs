/*
using System;
namespace Bismark{
    //Este digamos el metodo de transportes, todos hacen envios pero en distintos terrenos
    interface IEnvios{
        void RealizarEnvio();
    }
    //Este es un camion que hace envios
    class Camioneta : IEnvios{
        public void RealizarEnvio()
        {
            Console.WriteLine("Envio en camioneta");
        }
    }
    //Y este es un barco que hace envios
    class Barco : IEnvios{
        public void RealizarEnvio()
        {
            Console.WriteLine("Envio en barco");
        }
    }
    //Esta es la fabrica abstracta.
    abstract class Fabrica{
        public abstract IEnvios FabricarProducto();
    }
    //Esta fabrica solo Camionetas
    class FabricaParaCamiones : Fabrica{
        public override IEnvios FabricarProducto()
        {
            return new Camioneta();
        }
    }
    //Esta solo fabrica Barcos
    class FabricaParaBarcos : Fabrica{
        public override IEnvios FabricarProducto()
        {
            return new Barco();
        }
    }

        class Program
    {
        //Entonces en el main, simplemente se crea las fabricas, una de cada una probar que saca un envio, dependiendo el transporte.
        static void Main(string[] args){
            Fabrica fabricaA = new FabricaParaCamiones();
            IEnvios EnvioA = fabricaA.FabricarProducto();
            EnvioA.RealizarEnvio();
            Fabrica fabricaB = new FabricaParaBarcos();
            IEnvios EnvioB = fabricaB.FabricarProducto();
            EnvioB.RealizarEnvio();

            Console.ReadLine();
        }
    }
}
*/