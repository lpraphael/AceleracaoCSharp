public class Program {
  public static void Main() {
    string textOne = "Bom dia! ";
    string textTwo = "Este é um exercício com strings!";

    var finalText =  string.Concat(textOne, textTwo);

    Console.WriteLine("Estes são os texto1 e texto2 concatenados");
    Console.WriteLine(finalText);

    var arrayOfTexts = finalText.Split(" é ");


    Console.WriteLine(arrayOfTexts[0]);
    Console.WriteLine(arrayOfTexts[1].Replace("com", "de"));

    Console.WriteLine($"o '!' está na {finalText.IndexOf("!")} posição do texto.");
  }
}