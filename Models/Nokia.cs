using System;

namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string marca) : base(numero, modelo, marca)
        {
            // Construtor que recebe e repassa os parâmetros para a classe base (Smartphone)
            // TODO: Implementar o construtor da classe Nokia para receber e repassar os parâmetros para a classe base
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} na Nokia Store...");
            // TODO: Implementar a lógica de instalação específica para o Nokia
        }
    }
}
