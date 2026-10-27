
using System;

namespace Atividade
{
    class Program
    {
        static void Main(string[] args)
        {
            float val_pag;

            Console.WriteLine("=== SISTEMA DE CONTROLE DE CLIENTES ===");

            Console.Write("Informe o nome: ");
            string var_nome = Console.ReadLine() ?? "";

            Console.Write("Informe o endereco: ");
            string var_endereco = Console.ReadLine() ?? "";

            Console.Write("Pessoa Fisica (f) ou Juridica (j)? ");
            string var_tipo = (Console.ReadLine() ?? "").ToLower();

            if (var_tipo == "f")
            {
                Pessoa_Fisica pf = new Pessoa_Fisica();

                pf.nome = var_nome;
                pf.endereco = var_endereco;

                Console.Write("Informe o CPF: ");
                pf.cpf = Console.ReadLine() ?? "";

                Console.Write("Informe o RG: ");
                pf.rg = Console.ReadLine() ?? "";

                Console.Write("Informe o valor da compra: R$ ");
                while (!float.TryParse(Console.ReadLine(), out val_pag) || val_pag < 0)
                {
                    Console.Write("Valor invalido. Digite um valor igual ou maior que zero: R$ ");
                }

                pf.Pagar_Imposto(val_pag);

                Console.WriteLine("\n--- PESSOA FISICA ---");
                Console.WriteLine("Nome: " + pf.nome);
                Console.WriteLine("Endereco: " + pf.endereco);
                Console.WriteLine("CPF: " + pf.cpf);
                Console.WriteLine("RG: " + pf.rg);
                Console.WriteLine("Valor da compra: " + pf.valor.ToString("C"));
                Console.WriteLine("Imposto (10%): " + pf.valor_imposto.ToString("C"));
                Console.WriteLine("Total a pagar: " + pf.total.ToString("C"));
            }
            else if (var_tipo == "j")
            {
                Pessoa_Juridica pj = new Pessoa_Juridica();

                pj.nome = var_nome;
                pj.endereco = var_endereco;

                Console.Write("Informe o CNPJ: ");
                pj.cnpj = Console.ReadLine() ?? "";

                Console.Write("Informe a Inscricao Estadual (IE): ");
                pj.ie = Console.ReadLine() ?? "";

                Console.Write("Informe o valor da compra: R$ ");
                while (!float.TryParse(Console.ReadLine(), out val_pag) || val_pag < 0)
                {
                    Console.Write("Valor invalido. Digite um valor igual ou maior que zero: R$ ");
                }

                pj.Pagar_Imposto(val_pag);

                Console.WriteLine("\n--- PESSOA JURIDICA ---");
                Console.WriteLine("Nome: " + pj.nome);
                Console.WriteLine("Endereco: " + pj.endereco);
                Console.WriteLine("CNPJ: " + pj.cnpj);
                Console.WriteLine("IE: " + pj.ie);
                Console.WriteLine("Valor da compra: " + pj.valor.ToString("C"));
                Console.WriteLine("Imposto (20%): " + pj.valor_imposto.ToString("C"));
                Console.WriteLine("Total a pagar: " + pj.total.ToString("C"));
            }
            else
            {
                Console.WriteLine("Tipo invalido. Digite f para pessoa fisica ou j para pessoa juridica.");
            }

            Console.WriteLine("\nPressione Enter para encerrar.");
            Console.ReadLine();
        }
    }
}
