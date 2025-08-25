namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    //implementado!!
    public class Nokia : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"
        //implementado!!
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("Instalando aplicativo no Nokia...");
        }
    }
}