using System;
class Program
{
    static async Task Main()
    {
        Console.Clear();
        int Z1 = 0;
        int Z2 = 0;
        char Z3 = ' ';
        char R1 = ' ';
        int S1 = 0;
        int H1 = 0;
        string F1 = " ";
        bool P1 = true;
        bool P2 = true;
        bool P3 = true;
        bool P4 = true;

        decimal D1 = 8.00m;
        decimal D2 = 4.50m;

        do{
            List <string> C1 = new List <string> ();
            C1.Add("1-Ver vagas do estacionamento");
            C1.Add("2-Sair");

            Console.WriteLine("Estacionamento 24/7");
            foreach(string C2 in C1)
            {
                Console.WriteLine(C2);
            }

            Z1 = int.Parse(Console.ReadLine());

            switch (Z1)
            {
                case 1:
                    break;
                case 2:
                    Console.WriteLine("Programa finalizado");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Comando não reconhecido");
                    break;
            }
            Console.Clear();
        }while(Z1 != 1);

        Console.Clear();

        do{
            List <string> E1 = new List <string> ();
            E1.Add($"\n1- Vaga: {(P1 ? "Livre" : "Ocupado")}");
            E1.Add($"2- Vaga: {(P2 ? "Livre" : "Ocupado")}");
            E1.Add($"\n3- Vaga: {(P3 ? "Livre" : "Ocupado")}");
            E1.Add($"4- Vaga: {(P4 ? "Livre" : "Ocupado")}");
            
            Console.Clear();
            Console.WriteLine ("Estacionamento 24/7 - Vagas");
            Console.WriteLine ("Preço Inicial: R$ 8,00 | Preço Por Hora: R$ 4,50");
            foreach(string E2 in E1)
            {
                Console.WriteLine(E2);
            }
            Console.Write("\nEscolha uma vaga ou aperte 5 para sair: ");
            Z2 = int.Parse(Console.ReadLine());
            Console.Clear();

            switch(Z2)
            {
                case 1:
                    if(P1 == false)
                    {
                        Console.WriteLine("Deseja retirar o veículo? (S/N)");
                        R1 = char.Parse(Console.ReadLine());
                        switch(R1)
                        {
                            case 'S':
                            case 's':
                                Console.WriteLine("Quantas horas o cliente ficou no estacionamento?");
                                H1 = int.Parse(Console.ReadLine());
                                Console.WriteLine($"Pagamento: {D1 + (H1 * D2)}");
                                await Task.Delay(2500);
                                P1 = !P1;
                                break;
                            case 'N':
                            case 'n':
                            Console.WriteLine("Retornando...");
                            await Task.Delay(2500);
                                break;
                            default:
                                Console.WriteLine("\nComando não reconhecido...");
                                await Task.Delay(2500);
                                break;
                        }
                        break;
                    }
                    Console.Write("Digite a placa no formato do Mercosul: ");
                    F1 = Console.ReadLine();
                    if(F1.Length == 7)
                    {
                        Console.WriteLine("\nCarro estacionado");
                        P1 = !P1;
                        await Task.Delay(2500);
                    }
                    else
                    {
                        Console.WriteLine("Erro. Tente novamente");
                        await Task.Delay(2500);
                    }
                    break;
                case 2:
                    if(P2 == false)
                    {
                        Console.WriteLine("Deseja retirar o veículo? (S/N)");
                        R1 = char.Parse(Console.ReadLine());
                        switch(R1)
                        {
                            case 'S':
                            case 's':
                                Console.WriteLine("Quantas horas o cliente ficou no estacionamento?");
                                H1 = int.Parse(Console.ReadLine());
                                Console.WriteLine($"Pagamento: {D1 + (H1 * D2)}");
                                await Task.Delay(2500);
                                P2 = !P2;
                                break;
                            case 'N':
                            case 'n':
                            Console.WriteLine("Retornando...");
                            await Task.Delay(2500);
                                break;
                            default:
                                Console.WriteLine("\nComando não reconhecido...");
                                await Task.Delay(2500);
                                break;
                        }
                        break;
                    }
                    Console.Write("Digite a placa no formato do Mercosul: ");
                    F1 = Console.ReadLine();
                    if(F1.Length == 7)
                    {
                        Console.WriteLine("\nCarro estacionado");
                        P2 = !P2;
                        await Task.Delay(2500);
                    }
                    else
                    {
                        Console.WriteLine("Erro. Tente novamente");
                        await Task.Delay(2500);
                    }
                    break;
                case 3:
                    if(P3 == false)
                    {
                        Console.WriteLine("Deseja retirar o veículo? (S/N)");
                        R1 = char.Parse(Console.ReadLine());
                        switch(R1)
                        {
                            case 'S':
                            case 's':
                                Console.WriteLine("Quantas horas o cliente ficou no estacionamento?");
                                H1 = int.Parse(Console.ReadLine());
                                Console.WriteLine($"Pagamento: {D1 + (H1 * D2)}");
                                await Task.Delay(2500);
                                P3 = !P3;
                                break;
                            case 'N':
                            case 'n':
                            Console.WriteLine("Retornando...");
                            await Task.Delay(2500);
                                break;
                            default:
                                Console.WriteLine("\nComando não reconhecido...");
                                await Task.Delay(2500);
                                break;
                        }
                        break;
                    }
                    Console.Write("Digite a placa no formato do Mercosul: ");
                    F1 = Console.ReadLine();
                    if(F1.Length == 7)
                    {
                        Console.WriteLine("\nCarro estacionado");
                        P3 = !P3;
                        await Task.Delay(2500);
                    }
                    else
                    {
                        Console.WriteLine("Erro. Tente novamente");
                        await Task.Delay(2500);
                    }
                    break;
                case 4:
                    if(P4 == false)
                    {
                        Console.WriteLine("Deseja retirar o veículo? (S/N)");
                        R1 = char.Parse(Console.ReadLine());
                        switch(R1)
                        {
                            case 'S':
                            case 's':
                                Console.WriteLine("Quantas horas o cliente ficou no estacionamento?");
                                H1 = int.Parse(Console.ReadLine());
                                Console.WriteLine($"Pagamento: {D1 + (H1 * D2)}");
                                await Task.Delay(2500);
                                P4 = !P4;
                                break;
                            case 'N':
                            case 'n':
                            Console.WriteLine("Retornando...");
                            await Task.Delay(2500);
                                break;
                            default:
                                Console.WriteLine("\nComando não reconhecido...");
                                await Task.Delay(2500);
                                break;
                        }
                        break;
                    }
                    Console.Write("Digite a placa no formato do Mercosul: ");
                    F1 = Console.ReadLine();
                    if(F1.Length == 7)
                    {
                        Console.WriteLine("\nCarro estacionado");
                        P4 = !P4;
                        await Task.Delay(2500);
                    }
                    else
                    {
                        Console.WriteLine("Erro. Tente novamente");
                        await Task.Delay(2500);
                    }
                    break;
            }
        }while(Z2 != 5);
        Console.Clear();
        Console.WriteLine("Programa finalizado");
    }
}