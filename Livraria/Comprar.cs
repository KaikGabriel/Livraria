using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria
{
    class Compra
    {
        
        private int codigoCompra;
        private int quantidade;
        private decimal valorTotal;
        private string tipoPagamento;
        private DateTime dataCompra;

        public Compra()
        {
            
            AcessarCodigoCompra = 0;
            AcessarQuantidade = 0;
            AcessarValorTotal = 0;
            AcessarTipoPagamento = "";
            AcessarDataCompra = new DateTime();

        }//fim do construtor

        public int AcessarCodigoCompra
        {
            get
            {

                return codigoCompra;

            }
            set
            {

                this.codigoCompra = value;

            }
        }// Fim método AcessarCodigoCompra

        public int AcessarQuantidade
        {
            get
            {

                return quantidade;

            }
            set
            {

                this.quantidade = value;

            }
        }// Fim método AcessarQuantidade

        public decimal AcessarValorTotal
        {
            get
            {

                return valorTotal;

            }
            set
            {

                this.valorTotal = value;

            }
        }// Fim método AcessarValorTotal

        public string AcessarTipoPagamento
        {
            get
            {

                return tipoPagamento;

            }
            set
            {

                this.tipoPagamento = value;

            }
        }// Fim método AcessarTipoPagamento

        public DateTime AcessarDataCompra
        {
            get
            {

                return dataCompra;

            }
            set
            {

                this.dataCompra = value;

            }
        }// Fim método AcessarDataCompra
  
        public void CadastrarCompra(int codigoCompra, DateTime dataCompra, int quantidade, string tipoPagamento, decimal valorTotal)
        {

            AcessarCodigoCompra = codigoCompra;
            AcessarDataCompra = dataCompra;
            AcessarQuantidade = quantidade;
            AcessarTipoPagamento = tipoPagamento;
            AcessarValorTotal = valorTotal;

        }// Fim método CadastrarCompra 

        public string ConsultarCompra(int codigoCompra)
        {

            if (AcessarCodigoCompra == codigoCompra)
            {

                return "\nCodigo da compra: "      + AcessarCodigoCompra    +
                       "\nData da compra: "        + AcessarDataCompra      +
                       "\nQuntidade de livros: "   + AcessarQuantidade      +
                       "\nTipo de pagamento: "     + AcessarTipoPagamento   +
                       "\nValor total: "           + AcessarValorTotal;

            }

            else
            {

                return "Codigo inválido!";

            }

        }// Fim método ConsultarCompra

    }//fim da classe
}//fim do projeto
