using Classes;

public class Program
{
  public static void Main()
  {
    // Client raphael = new() // uma das formas de instanciar um objeto de classe Client
    var raphael = new Client();
    var leilanne = new Client();
    raphael.Name = "Raphael";
    leilanne.Name = "Leilanne";
    Console.WriteLine("Objeto de Classe Client instanciado implicitamente e atribuido valor: " + raphael.Name);
    Console.WriteLine("Objeto de Classe Client instanciado implicitamente e atribuido valor: " + leilanne.Name);
    User userRaphael = new User("Raphael Lyra Perazzo");
    User userLeilanne = new User("Leilanne Cristina");
    Console.WriteLine("Objeto de Classe Client instanciado explicitamente e atribuido valor: " + userRaphael.Name);
    Console.WriteLine("Objeto de Classe Client instanciado explicitamente e atribuido valor: " + userLeilanne.Name);
  } // Exemplo de inicialização de classe com Constructor Explicito
}