using System;
using System.Collections.Generic;

namespace Banco
{
    public class Caixa
    {

        public void ExecutaCaixa()
        {
            List<Cliente> clientes = new List<Cliente>();
            Console.WriteLine("Deseja informar pagamento? (sim/nao)");
            var opcao = Console.ReadLine();

            while (opcao == "sim")
            {
                Console.WriteLine("Nome do cliente: ");
                var nome = Console.ReadLine();
                Console.WriteLine("Valor da divida: ");
                var divida = double.Parse(Console.ReadLine());
                Console.WriteLine("Valor do pagamento: ");
                var pagamento = double.Parse(Console.ReadLine());
                var troco = CalcularTroco(pagamento, divida);

                var cliente = new Cliente(nome, pagamento, divida, troco);


               
 if (clientes.Count > 0)
                {
                    clientes.Add(cliente);
                }


                var index = clientes.Count - 1;
                if (nome == clientes[index].nome)
                {
                    Console.WriteLine("Transação não permitida!");
                }
                else
                {
                    clientes.Add(cliente);
                }




                Console.WriteLine("Deseja informar novo pagamento? (sim/nao)");
                opcao = Console.ReadLine();

                foreach (var item in clientes)
                {
                    Console.WriteLine($"{cliente.nome} - {cliente.divida} - {cliente.pagamento} - {cliente.troco} ");
                }

                Console.ReadLine();
            }


            /*var tipoDeposito = Console.ReadLine();

            if (tipoDeposito.ToLower() == "notas")
            {
                Console.WriteLine("Informe valor da Nota: (5, 10, 20, 50, 100)");
                var valor = Int32.Parse(Console.ReadLine());
                deposito += VerificarNota(valor);
            }
            else
            {
                Console.WriteLine("Informe valor da Moeda: (1, 5, 10, 50)");
                var valor = Int32.Parse(Console.ReadLine());
                deposito += VerificarMoeda(valor);
            }

            */



            /*Console.WriteLine("Informe Depositante:");
            var depositante = Console.ReadLine();

            if (deposito <= 500)
            {
                Console.WriteLine("Deposito realizado com sucesso! - R$" + deposito);
            }
            else
            {
                Console.WriteLine("Precisa autorizacao");
            }*/
        }

        private double CalcularTroco(double pagamento, double divida)
        {
            if (pagamento > divida)
            {
                return pagamento - divida;
            }
            return 0;
        }
    }
}
/*
        private static double VerificarMoeda(int valor)
        {
            switch (valor)
            {
                case 1:
                    return 0.01;
                case 5:
                    return 0.05;
                case 10:
                    return 0.1;
                case 50:
                    return 0.5;
                default:
                    Console.WriteLine("Nota invalida!");
                    return 0;
            }
        }

        private static double VerificarNota(int valor)
        {
            switch (valor)
            {
                case 5:
                    return 5;
                case 10:
                    return 10;
                case 50:
                    return 50;
                case 100:
                    return 100;
                default:
                    Console.WriteLine("Nota invalida!");
                    return 0;
            }
        }

    }
*/
