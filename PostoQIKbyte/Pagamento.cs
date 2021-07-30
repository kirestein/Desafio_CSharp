using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostoQIKbyte
{
    class Pagamento : Abastecer
    {
		private String formaDePagamento;
		private double totalAPagar;

		public void pagar(double preco, double litros)
		{
			this.totalAPagar = preco * litros;
			Console.WriteLine($"Valor total: R${totalAPagar}. \n");

		}

		public String getFormaDePagamento()
		{
			return formaDePagamento;
		}

		public void setFormaDePagamento(String formaDePagamento)
		{
			this.formaDePagamento = formaDePagamento;
		}

		public double getTotalAPagar()
		{
			return totalAPagar;
		}


	}
}
