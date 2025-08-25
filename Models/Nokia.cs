namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    //implementado!!
    public class Nokia : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"
        //implementado!!

        
        //Direcionamento para usar construtor de Smartphone
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {

        }
        
        public override void InstalarAplicativo(string nomeApp)
        {
            string NomeApp = nomeApp;
            Console.WriteLine($"Instalando o aplicativo {NomeApp} no Nokia...");
        }
    }
}