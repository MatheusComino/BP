using System;
using QuartoAluguel;
using System.IO;

class Program
{
    static void Main()
    {
        //--Verifica se o existe um arquivo, se não cria um txt
        string path = @"c:\temp\MyTest.txt";
        if (!File.Exists(path))
        {
            using (StreamWriter sw = File.CreateText(path))
            {
            }
        }

        Quarto[] quarto = new Quarto[999];
        Console.WriteLine("[1]. CADASTRAR UM NOVO QUARTO\n[2]. CONSULTAR TODOS OS QUARTOS\n[3]. ALUGAR UM QUARTO\n[4]. DADOS DOS LOCATARIOS\n[5]SAIR");
        int switch_on = int.Parse(Console.ReadLine());
        //Serve para repetir o programa ate o usuario querer parar
        while (switch_on < 5)
        {
            //Cadastra um novo quarto
            if (switch_on == 1)
            {
                List<string> list = new List<string>();

                //--Consulta os valores no documento
                StreamReader sr = new StreamReader(path);
                string line = sr.ReadLine();

                while (line != null)
                {
                    list.Add(line);
                    line = sr.ReadLine();
                }
                sr.Close();

                //-- Adiciona dados no documento
                StreamWriter sw = new StreamWriter(path);
                Console.Write("NUMERO:");
                list.Add(Console.ReadLine());
                Console.Write("TAMANHO DO QUARTO:");
                list.Add(Console.ReadLine());
                Console.Write("PREÇO DA DIARIA:");
                list.Add(Console.ReadLine());

                for (int i = 0; i < list.Count; i++)
                {
                    sw.WriteLine(list[i]);
                }
                sw.Close();
            }
            //Mostra todos os quartos cadastrados
            else if (switch_on == 2)
            {
                StreamReader sr = new StreamReader(path);
                string line = sr.ReadLine();
                if (line == null) Console.WriteLine("NENHUM CARTO DISPONIVEL");
                int i = 0;
                while (line != null)
                {
                    int nome = int.Parse(line);
                    double tamanho = double.Parse(sr.ReadLine());
                    double precoDiaria = double.Parse(sr.ReadLine());
                    line = sr.ReadLine();
                    quarto[i] = new Quarto(nome, tamanho, precoDiaria);
                    Console.WriteLine("[QUARTOS " + i + "]");
                    Console.WriteLine("Numero do Quarto: " + quarto[i].numero);
                    Console.WriteLine("Tamanho do Quarto: " + quarto[i].tamanho + "m²");
                    Console.WriteLine("Preço Diaria: " + quarto[i].precoDiaria.ToString("C2"));
                    i++;
                }
                sr.Close();
            }
            //Serve para o cliente alugar um quarto
            else if (switch_on == 3)
            {
                Console.Write("DIGITE O QUARTO:");
                int numeroQuarto = int.Parse(Console.ReadLine());
                Console.Write("\nNome: ");
                quarto[numeroQuarto].locatario.nome = Console.ReadLine();
                Console.Write("Cpf: ");
                quarto[numeroQuarto].locatario.cpf = Console.ReadLine();
                Console.Write("Idade: ");
                quarto[numeroQuarto].locatario.idade = int.Parse(Console.ReadLine());

                Console.Write("Dias de locação: ");
                quarto[numeroQuarto].quantosDias = int.Parse(Console.ReadLine());
                Console.WriteLine("\nCustara: " + quarto[numeroQuarto].CalculaValorParaAlugar().ToString("C2"));

                string confirmaLocacao;
                Console.WriteLine("Confirmar? [S] ou [N]");
                confirmaLocacao = Console.ReadLine();

                if (confirmaLocacao == "S" || confirmaLocacao == "s")
                {
                    quarto[numeroQuarto].estaAlugado = true;
                    Console.WriteLine("---------");
                    Console.WriteLine(quarto[numeroQuarto]);
                }
                else
                {
                    Console.WriteLine("Obrigado, Até a proxima!!!");
                }
            }
            //Serviria para ver os dados de todas as pessoas cadastradas porem não deu tempo de fazer
            else if (switch_on == 4)
            {
                Console.WriteLine("PROGRAMA EM PRODUÇÃO, FUNCIONALIDADE INDISPONIVEL");
            }

            Console.WriteLine("\n[1]. CADASTRAR UM NOVO QUARTO\n[2]. CONSULTAR TODOS OS QUARTOS\n[3]. ALUGAR UM QUARTO\n[4]. DADOS DOS LOCATARIOS\n[5]SAIR");
            switch_on = int.Parse(Console.ReadLine());
        }
    }
}