namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class IPhone : Smartphone
    {
        //// Construtor para inicializar propriedades do IPhone
        public IPhone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            
        }
        // TODO: Sobrescrevendo o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} na App Store do iPhone.");
        }
    }
}