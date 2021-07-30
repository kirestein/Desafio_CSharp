using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostoQIKbyte
{
    class Abastecer
    {
		private String tipoCombustivel;
		private double qtdeCombustivel;
		private double preco;
		private Pagamento pagamento;


		public Abastecer()
		{

		}



		public String getTipoCombustivel()
		{
			return tipoCombustivel;
		}

		public void setTipoCombustivel(String tipoCombustivel)
		{
			this.tipoCombustivel = tipoCombustivel;
		}

		public void abastecer(String tipoCombustivel)
		{

			switch (tipoCombustivel)
			{
				case "gasolina":
					this.preco = 4;
					break;
				case "etanol":
					this.preco = 2.5;
					break;
				default:
					Console.WriteLine("Escolha uma das opções válidas");
					break;
			}

		}

		public double getQtdeCombustivel()
		{
			return qtdeCombustivel;
		}

		public void setQtdeCombustivel(double qtdeCombustivel)
		{
			this.qtdeCombustivel = qtdeCombustivel;
		}

		public Pagamento getPagamento()
		{
			return pagamento;
		}

		public void setPagamento(Pagamento pagamento)
		{
			this.pagamento = pagamento;
		}

		public double getPreco()
		{
			return preco;
		}
		public void saidaFinal(String nome, String combustivel, String formaDePagamento, double litros, double valorTotal)
		{
			Console.WriteLine($"{nome}, você escolheu {combustivel} e abasteceu um total de {litros} litros. \n"
					+ $"O valor total ficou em R${valorTotal} e a forma de pagamento escolhida foi "
					+ $"{formaDePagamento}. \n", nome, combustivel, litros, valorTotal, formaDePagamento);
		}
	}
}
