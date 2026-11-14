using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoVenda.modelo
{
    internal class Venda
    {
        public int cod_venda { get; set; }
        public int cod_funcionario { get; set; }
        public DateTime data { get; set; }

        public List<Item> itens { get; set; }

        public string nomeFuncionario { get; set; }

    }
}
