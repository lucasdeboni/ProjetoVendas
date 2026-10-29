using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoVenda.model
{
    internal class Product
    {
        public int cod_produto { get; set; }
        public int cod_funcionario { get; set; }
        public string nome { get; set; }
        public string marca { get; set; }
        public int preco { get; set; }
        public int quantidade { get; set; }
        public DateTime data_registro { get; set; }

        public void validar()
        {
            if(preco <= 0)
            {
                throw new ArgumentException("O preco nao pode ser Zerado!");
            }

            if(quantidade < 0)
            {
                throw new ArgumentException("A quantidade não pode ser menor que zero!");
            }
        }
    }
}
