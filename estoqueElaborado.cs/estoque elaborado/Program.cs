using System;

namespace estoque_elaborado
{
    class Program
    {
        static void Main(string[] args)
        {
            //TELA DE APRESENTAÇÃO
            Console.WriteLine("=====================================================");
            Console.WriteLine("=================BEM VINDO AO ESTOQUE 1.0=============");
            Console.WriteLine("======================================================");

            Console.WriteLine("                                                     ");
            //TELA DE SELEÇÃO DE OPÇÃO
            Console.WriteLine("===================================================");
            Console.WriteLine("=============SELECIONE UMA OPÇÃO: =================");
            Console.WriteLine("===================================================");

            Console.WriteLine("                                                    ");

            
            Console.WriteLine("--------------1:INSERIR ITEM--------------------");
            Console.WriteLine("--------------2:LISTAR ITENS-------------------");
            Console.WriteLine("--------------3: SAIR DO PROGRAMA--------------");
            //VARIAVEL DE CONTROLE DE OPÇÃO
            string opcao;
            opcao = Convert.ToString(Console.ReadLine());
            //INSTRUÇÃO CONDICIONAL 
            if(opcao == "1")
            {
                Console.WriteLine("==============BEM VINDO AO INSERIR ITEM============");
                Console.WriteLine("                                                   ");
                for (int c = 1; c <= 2; c++)
                {
                    //BLOCO DE COMANDOS PARA A OPÇÃO 1
                    Console.WriteLine("Digite o nome do item: ");
                    string item = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("                             ");
                    Console.WriteLine("Digite a quantidade em estoque: ");
                    int estoque = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("                                ");
                    Console.WriteLine("Digite a quantidade usada: ");
                    int saida = Convert.ToInt32(Console.ReadLine());

                    int total = estoque - saida;

                    if(total >= 5)
                    {
                        Console.WriteLine("Estoque cheio! Não é necessário comprar!");
                    }else if(total <5 && total > 3)
                    {
                        Console.WriteLine("ESTOQUE EM ALERTA! FAVOR VERIFICAR! ");
                    }
                    else
                    {
                        Console.WriteLine("ESTOQUE EM DEFICIT! FAVOR COMPRAR  MAIS ITENS");
                    }


                }
            }else if (opcao == "2")//BLOCO DE COMANDOS PARA OPÇÃO 2
            {
                Console.WriteLine("=========================================");
                Console.WriteLine("===========LISTAR ITENS=================");
                Console.WriteLine("=========================================");
                Console.WriteLine("1" + "- ARROZ");
                Console.WriteLine("2" + " - FEIJÃO");
                Console.WriteLine("3" + " - SAL");
                Console.WriteLine("4" + " - MACARRÃO");
                Console.WriteLine("QUAL SUA ESCOLHA?: ");
                Console.WriteLine("OPÇÃO: ");

                //VARIAVEL DE CONTROLE DE OPÇÃO
                string item = Convert.ToString(Console.ReadLine());
                //CONDICIONAL DO ITEM 1
                if (item == "1")
                {//BLOCO DE COMANDOS DO ITEM 1
                    Console.WriteLine("NOME DO ITEM: ARROZ");
                    Console.WriteLine("ESTOQUE ATUAL EM PACOTES: 5");
                    Console.WriteLine("PACOTES USADOS NA SEMANA: 2");

                }
            }



        }
    }
}
