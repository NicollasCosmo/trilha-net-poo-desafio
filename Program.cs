using DesafioPOO.Models;

class Program
{
    static void Main(string[] args)
    {
        // TODO: Realizar os testes com as classes Nokia e Iphone
        Smartphone nokiaPhone = new Nokia("123456789", "Nokia 9", "Nokia");
        nokiaPhone.Ligar();
        nokiaPhone.ReceberLigacao();
        nokiaPhone.InstalarAplicativo("WhatsApp");

        Smartphone iPhone = new Iphone("987654321", "iPhone 12", "Apple");
        iPhone.Ligar();
        iPhone.ReceberLigacao();
        iPhone.InstalarAplicativo("Instagram");
    }
}
