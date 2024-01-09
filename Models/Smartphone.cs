namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        // Implementadas as propriedades faltantes de acordo com o diagrama
        private string Modelo {get;}
        private string IMei {get;}
        private int Memoria {get;}
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            // Passados os parâmetros do construtor para as propriedades
            Modelo = modelo;
            IMei = imei;
            Memoria = memoria; 
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}