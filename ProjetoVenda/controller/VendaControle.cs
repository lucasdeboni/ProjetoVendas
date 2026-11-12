using ProjetoVenda.model;
using ProjetoVenda.repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoVenda.controller
{
    internal class VendaControle
    {

        EmployeeController employeeController;
        VendaRepositorio vendaRepositorio;

        public VendaControle()
        {
            employeeController = new EmployeeController();
            vendaRepositorio = new VendaRepositorio();
        }

        public bool cadastrarVenda(List<Item> itens)
        {
            Employee? funcionario = employeeController.usuarioAutenticado();
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
