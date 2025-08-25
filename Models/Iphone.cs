namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    //Implementado 
    public class Iphone : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"
        // Implementado


        //Direcionamento para usar construtor de Smartphone
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {

        }
        public override void InstalarAplicativo(string nomeApp)
        {
            string NomeApp = nomeApp;
            Console.WriteLine($"Instalando o aplicativo {NomeApp} no Iphone...");
        }
    }
}