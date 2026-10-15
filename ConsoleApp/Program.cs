public class Program
{
    public static void Main()
    {
        string[] options = { "Entrar", "Sair", "Créditos" };
        int selecao = 0;
        bool exec = true;

        while (exec)
        {
            Console.Clear();
            
            for (int i = 0; i < options.Length; i++)
            {
                if (i == selecao)
                {
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine($">>> {options[i]} <<<");
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine($"{options[i]}");
                }
            }

            ConsoleKeyInfo tecla = Console.ReadKey(true);

            switch (tecla.Key)
            {
                case ConsoleKey.UpArrow:
                    selecao = selecao > 0 ? selecao - 1 : selecao;
                    break;
                case ConsoleKey.DownArrow:
                    selecao = selecao < options.Length - 1 ? selecao + 1 : selecao = 0;
                    break;
                case ConsoleKey.Enter:
                    exec = ProcessarEscolha(selecao);
                    break;
            }
            
        }

        bool ProcessarEscolha(int escolha)
        {
            switch (escolha)
            {
                case 0:
                    Console.WriteLine("Bem-vindo ao terminal!");
                    Console.WriteLine("Pressione qualquer tecla para sair.");
                    Console.ReadKey();
                    return true;
                case 1:
                    return false;
                
                case 2:
                    Console.WriteLine("Desenvolvido por Z :)");
                    Console.WriteLine("Pressiona qualquer tecla para sair.");
                    Console.ReadKey();
                    return true;
            }
            return true;
        }
        
        
        
        
        

    }
}