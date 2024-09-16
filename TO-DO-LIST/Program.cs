namespace todoList;
public class Program
{
    public static void Main()
    {
        var tasks = new List<string>();
        bool isRunning = true;

        while (isRunning)
        {
            Console.WriteLine("Escolha uma opção");
            Console.WriteLine("1 - Adicionar tarefa");
            Console.WriteLine("2 - Ver tarefas");
            Console.WriteLine("3 - Remover Tarefas");
            Console.WriteLine("4 - Sair");

            bool isNumber = int.TryParse(Console.ReadLine(), out int option);

            if (isNumber)
            {
            switch (option)
            {
                case 1:
                Console.WriteLine("Escreva sua tarefa");
                var task = Console.ReadLine();
                tasks.Add(task!);
                break;
                case 2:
                foreach (var item in tasks)
                {
                    Console.WriteLine(item);
                }
                break;
                case 3:
                Console.WriteLine("Escreva a tarefa a ser removida");
                var taskToRemove = Console.ReadLine();
                bool removed = tasks.Remove(taskToRemove!);

                if (removed)
                {
                    Console.WriteLine("Tarefa Removida!");
                }
                else
                {
                    Console.WriteLine("Tarefa não encontrada");
                }
                break;
                case 4:
                    isRunning = false;
                break;
                default:
                Console.WriteLine("Opção inválida!");
                break;
            }
            }
        }
    }
}
