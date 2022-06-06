using Dados_Pessoais;
class Program
{
    static void Main()
    {
        DadosPessoais[] dados = new DadosPessoais[2];
        dados[0] = new DadosPessoais();
        dados[1] = new DadosPessoais();

        Console.WriteLine("Dados da 1º pessoa:");
        Console.Write("Nome: ");
        dados[0].nome = Console.ReadLine();
        Console.Write("Nome: ");
        dados[0].idade = int.Parse(Console.ReadLine());

        Console.WriteLine("Dados da 1º pessoa:");
        Console.Write("Nome: ");
        dados[1].nome = Console.ReadLine();
        Console.Write("Idade: ");
        dados[1].idade = int.Parse(Console.ReadLine());

        Console.WriteLine(dados[0].idade > dados[1].idade ? dados[0].nome + " é mais velhas" : dados[1].nome + " é mais velhos");
    }
}

