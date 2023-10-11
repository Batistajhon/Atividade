using System;
   
namespace Atividade
{
    class Program
    {
        static void Main (string[] arg)
        {
                float val_pag;
                Console.WriteLine("Informar Nome");
                string Var_nome = Console.ReadLine();
                Console.WriteLine("Informar Endereço");
                string Var_Endereco = Console.ReadLine();
                Console.WriteLine("Pessoa Fisica (f) ou Juridica (j)");
                string Var_tipo = Console.ReadLine();
                if (Var_tipo == "f")
                {
                //---Pessoa Fisica----
                Pessoa_Fisica pf = new()
                {
                    Nome = Var_nome,
                    Endereço = Var_Endereco
                };
                Console.WriteLine("Informar CPF");
                    pf.Cpf = Console.ReadLine();
                    Console.WriteLine("Informar RG");
                    pf.Rg = Console.ReadLine();
                    Console.WriteLine("Informar Valor de Compra");
                    val_pag = float.Parse(Console.ReadLine());
                    pf.Pagar_imposto(val_pag);
                    Console.WriteLine("------Pessoa Fisica-----");
                    Console.WriteLine("Nome...........:"+ pf.Nome);
                    Console.WriteLine("Endereco.......:"+ pf.Endereço);
                    Console.WriteLine("CPF............:"+ pf.Cpf);
                    Console.WriteLine("RG.............:"+pf.Rg);
                    Console.WriteLine("Valor de Compra:"+pf.Valor.ToString("C"));
                    Console.WriteLine("Imposto........:"+ pf.Valor_imposto.ToString("C"));
                    Console.WriteLine("Total a pagar..:" + pf.Total.ToString("C"));
                }
                if (Var_tipo == "j")
                {
                    //Pessoa Juridica
                    Pessoa_Juridica pj = new();
                    pj.Nome = Var_nome;
                    pj.Endereço = Var_Endereco;
                    Console.WriteLine("Informar CNPJ");
                    pj.Cnpj = Console.ReadLine();
                    Console.WriteLine("Informar IE");
                    pj.Ie = Console.ReadLine();
                    Console.WriteLine("Informar valor de Compra");
                    val_pag = float.Parse(Console.ReadLine());
                    pj.Pagar_imposto(val_pag);
                    Console.WriteLine("------Pessoa Juridica-----");
                    Console.WriteLine("Nome...........:"+ pj.Nome);
                    Console.WriteLine("Endereco.......:"+ pj.Endereço);
                    Console.WriteLine("Cnpj............:"+ pj.Cnpj);
                    Console.WriteLine("IE.............:"+pj.Ie);
                    Console.WriteLine("Valor de Compra:"+pj.Valor.ToString("C"));
                    Console.WriteLine("Imposto........:"+ pj.Valor_imposto.ToString("C"));
                    Console.WriteLine("Total a pagar..:" + pj.Total.ToString("C"));
                }
          }        
    }
}