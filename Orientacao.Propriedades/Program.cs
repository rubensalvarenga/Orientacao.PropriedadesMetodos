using System;

namespace Orientacao.Propriedades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pagamento = new Pagamento();
            pagamento.DataPagamento = DateTime.Now;

            var pagamentoCartao = new PagamentoCartao();
            pagamentoCartao.Pagar("12879",
                                  DateTime.UtcNow(),
                                  DateTime.UtcNow());


        }

        public class Pagamento
        {
            // Método Construtor, invocado sempre que instancia, dar new
            public Pagamento() {
                Console.WriteLine("Iniciando o pagamento");

            } 

            private DateTime _dataPagamento;
            public DateTime DataPagamento
            {
                //propriedades
                get
                {
                    Console.WriteLine("Lendo Valor");
                    return _dataPagamento;
                }
                set
                {
                    Console.WriteLine("Atribuindo valor");
                    _dataPagamento = value;
                }
            }

            // sobre carga de método
            public virtual void Pagar(string numero) { }
            public virtual void Pagar(string numero,  DateTime dataPagamento) { }
            public virtual void Pagar(string numero, DateTime dataPagamento, DateTime dataPagamentoCartao) { }


        }
        public class PagamentoCartao : Pagamento
        {
            //sobreescrever o método
            public override void Pagar(string numero)
            {
                Console.WriteLine("Iniciando pagamento do cartão");
            }
        }

    }
}
