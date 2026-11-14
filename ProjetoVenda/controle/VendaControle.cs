using ProjetoVenda.modelo;
using ProjetoVenda.repositorio;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoVenda.controle
{
    internal class VendaControle
    {

        FuncionarioControle funcionarioControle;
        VendaRepositorio vendaRepositorio;

        public VendaControle()
        {
            funcionarioControle = new FuncionarioControle();
            vendaRepositorio = new VendaRepositorio();
        }

        public bool cadastrarVenda(List<Item> itens)
        {
            Funcionario? funcionario = funcionarioControle.usuarioAutenticado();
            if (funcionario == null)
            {
                throw new Exception("Usuário não autenticado!");
            }
            int cod_funcionario = funcionario.cod_funcionario;
            
            Venda venda = new Venda
            {
                cod_funcionario = cod_funcionario,
                itens = itens

            };

            // repository
            vendaRepositorio.cadastrarVenda(venda);

            return true;
        }

    }
}
