public class Program 
{
  public static void Main() 
  {
    Console.WriteLine("Informe o número de Lados");
    string? siderNumber = Console.ReadLine();
    int numberSide = Convert.ToInt32(siderNumber);

    string name = String.Empty;
    if (numberSide == 3)
    {
      name = "Triangulo";
    } else if (numberSide == 4){
      name = "Quadrado";
    } else if (numberSide == 5) {
      name = "Pentágono";
    } else if (numberSide == 6) {
      name = "Hexágono";
    } else {
      name = "Polígono não especificado";
    }

    Console.WriteLine("O Polígono é um " + name);

    string complexity = String.Empty;

    switch (numberSide)
    {
      case 3:
      case 4:
      case 5:
        complexity = "simples";
        break;
      case > 5:
        complexity = "complexo";
        break;
      default:
        complexity = "impossível";
        break;
    } 

    Console.WriteLine("O Polígono é " + complexity);
  }

}