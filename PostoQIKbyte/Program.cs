using System;

namespace PostoQIKbyte
{
    class Program
    {
        static void Main(string[] args)
        {
			string nome;
			
			Abastecer carro = new Abastecer();
			carro.setPagamento(new Pagamento());

			Console.WriteLine("Bem vindo ao posto de combustivel inteligente QIKbyte.");
			Console.WriteLine("Por favor, digite o seu nome: ");
			nome = Console.ReadLine();
			//		System.out.println(nome);
			Console.WriteLine($"Olá {nome}, é um prazer atende-lo. Por favor digite se deseja abastecer com "
					+ "gasolina ou etanol: ");
			carro.setTipoCombustivel(Console.ReadLine());
			carro.abastecer(carro.getTipoCombustivel());
			Console.WriteLine($"{nome}, você irá pagar com dinheiro ou cartão: ");
			carro.getPagamento().setFormaDePagamento(Console.ReadLine());
			Console.WriteLine(carro.getPreco());
			Console.WriteLine($"{nome}, por favor, digite quantos litros de {carro.getTipoCombustivel()} deseja abastecer: ");
			carro.setQtdeCombustivel(Convert.ToDouble(Console.ReadLine()));
			carro.getPagamento().pagar(carro.getPreco(), carro.getQtdeCombustivel());


			carro.saidaFinal(nome, carro.getTipoCombustivel(), carro.getPagamento().getFormaDePagamento(), carro.getQtdeCombustivel(), carro.getPagamento().getTotalAPagar());
			Console.WriteLine("Agradecemos a preferência, volte sempre.");
		}
    }
}
