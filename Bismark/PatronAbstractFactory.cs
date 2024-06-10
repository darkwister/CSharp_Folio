
namespace Bismark{
    public interface IMesa{
        string MesaHaceAlgo();
    }
    public interface ISilla{
        string SillaHaceAlgo();
        string SillaConMesa(IMesa JuegoMesa);
    }   
    
    public interface IMesilla{
        string MesillaHaceAlgo();
        string MesillaAJuego(IMesa JuegoMesa, ISilla JuegoSilla);
    }
    class MesaClasica : IMesa
    {
        public string MesaHaceAlgo()
        {
            return "Una mesa clasica";
        }
    }
    class SillaClasica : ISilla
    {
        public string SillaHaceAlgo(){
            return "Una silla clasica";
        }
        public string SillaConMesa(IMesa MesaJuego){
            var result = MesaJuego.MesaHaceAlgo();

            return $"Resultado de una silla clasica ({result})";
        }
    }
    class MesillaClasica : IMesilla{
        public string MesillaHaceAlgo(){
            return "Tenemos una mesilla clasica :O";
        }
        public string  MesillaAJuego(IMesa MesaJuego, ISilla SillaJuego){
            var resultMesa = MesaJuego.MesaHaceAlgo();
            var resultSilla = SillaJuego.SillaHaceAlgo();

            return $"Esta mesilla esta a juego con {resultSilla} y su {resultMesa}";
        }
    }
    class MesaVictorianana : IMesa
    {
        public string MesaHaceAlgo()
        {
            return "Una mesa de la epoca victoriana, muy pomposa";
        }
    }
    
    class SillaVictoriana: ISilla
    {
        public string SillaHaceAlgo(){
            return "Una silla de la epoca victoriana caching";
        }
        public string SillaConMesa(IMesa MesaJuego){

            var result = MesaJuego.MesaHaceAlgo();
            return $"Resultado de una silla victoriana meow meow ({result})";
        }
    }
    class MesillaVictoriana : IMesilla{
        public string MesillaHaceAlgo(){
            return "Esta es una mesilla bien pomposa";
        }
        public string MesillaAJuego(IMesa MesaJuego, ISilla SillaJuego){
            var resultMesa = MesaJuego.MesaHaceAlgo();
            var resultSilla = SillaJuego.SillaHaceAlgo();

            return $"Esta mesilla es bien pomposa con su {resultMesa} y su {resultSilla}";
        }
    }
    public interface IFabricaMuebles{
        public IMesa CreaMesa();
        public ISilla CreaSilla();
        public IMesilla CrearMesilla();
    }
    class FabricaClasica : IFabricaMuebles{
        public IMesa CreaMesa()
        {
            return new MesaClasica();
        }
        public ISilla CreaSilla()
        {
            return new SillaClasica();
        }
        public IMesilla CrearMesilla(){
            return new MesillaClasica();
        }
    }
    class FabricaVictoriana : IFabricaMuebles{
        public IMesa CreaMesa(){
            return new MesaVictorianana();
        }
        public ISilla CreaSilla(){
            return new SillaVictoriana();
        }
        public IMesilla CrearMesilla(){
            return new MesillaVictoriana();
        }
    }
    class Client
    {
        public void Main()
        {
            // The client code can work with any concrete factory class.
            Console.WriteLine("Client: Probando la fabrica clasica en el metodo de cliente...");
            ClientMethod(new FabricaClasica());
            Console.WriteLine();

            Console.WriteLine("Client: Probando la victoriana en el mismo metodo de cliente...");
            ClientMethod(new FabricaVictoriana());

        }
        public void ClientMethod(IFabricaMuebles factory)
        {
            var productA = factory.CreaMesa();
            var productB = factory.CreaSilla();
            var productC = factory.CrearMesilla();

            Console.WriteLine(productB.SillaHaceAlgo());
            Console.WriteLine(productB.SillaConMesa(productA));
            Console.WriteLine(productC.MesillaAJuego(productA, productB));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            new Client().Main();
        }
    }

}
