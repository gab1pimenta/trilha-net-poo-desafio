namespace DesafioPOO.Models
{
    // Herança da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base (numero, modelo, imei, memoria)
        {
        }
        //Sobrescrevendo o método "InstalarAplicativo
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"O aplicativo {nomeApp} foi instalado no Iphone com sucesso.");
        }

    }
}