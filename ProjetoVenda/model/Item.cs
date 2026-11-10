using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoVenda.model
{
    internal class Item
    {
        public int cod_item {  get; set; }
        public int cod_produto {  get; set; }
        public int cod_venda {  get; set; }
        public int quantidade {  get; set; }
        public int preco {  get; set; }

        public string nomeProduto { get; set; }
        public string marcaProduto { get; set; }

        public decimal precoReal => preco / 100m;
        public decimal subtotal => precoReal * quantidade;

    }
}
