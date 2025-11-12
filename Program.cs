class Program
{
    static void Main()
    {
        
        string[] vetor = { "Javascript", "Python", "C#", "Java", "Ruby", "PHP", "C++", "Swift", "Kotlin", "Go" };
        
        Console.Write("Digite a linguagem de programação que deseja buscar: ");
        string busca = Console.ReadLine();

        
        bool encontrado = false;

        
        for (int i = 0; i < vetor.Length; i++)
        {
            if (vetor[i].Equals(busca, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"'{busca}' encontrado na posição {i} do vetor.");
                encontrado = true;
                break; 
            }
        }

        if (!encontrado)
        {
            Console.WriteLine("Linguagem não encontrada no vetor.");
        }

        Console.ReadKey();
    }
}