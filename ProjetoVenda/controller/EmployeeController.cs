using System;
using System.Collections.Generic;
using System.Text;
using ProjetoVenda.model;
using ProjetoVenda.repository;
using ProjetoVenda.view;

namespace ProjetoVenda.controller
{
    internal class EmployeeController
    {
        public EmployeeRepository repository;

        public EmployeeController()
        {
            repository = new EmployeeRepository();
        }

        public bool login(string username, string password)
        {
            EmployeeRepository repository = new EmployeeRepository();
            Employee? resp = repository.getByUsername(username);
            if (resp == null)
            {
                return false;
            }

            bool validatePassword;

            try
            {
                validatePassword = BCrypt.Net.BCrypt.Verify(password, resp.senha);
            } catch(Exception ex)
            {
                validatePassword = false;
            }

            if( !validatePassword )
            {
                return false;
            }
            // to do: gravar os dados do usuário logado!
            Session.userAuth = resp;

            return true;
        }

        public bool createEmployee(Employee funcionario)
        {
            // fazer verificação se o usuário não existe
            //solicitar ao repository se o usuário existe
            EmployeeRepository repository = new EmployeeRepository();
            Employee? resp = repository.getByUsername(funcionario.usuario);

            if(resp != null)
            {
                return false;
            }

            string hash = BCrypt.Net.BCrypt.HashPassword(funcionario.senha);
            funcionario.senha = hash;

            repository.createEmployee(funcionario);
            return true;
        }

        public void deslogar()
        {
            Session.userAuth = null;
        }

        public Employee? usuarioAutenticado()
        {
            return Session.userAuth;
        }

        public List<Employee> getAll()
        {
            return repository.getAll();
        }

        public List<Employee> listarPorPagina(int qtd, int pagina)
        {
            return repository.listarPorPagina(qtd, pagina);
        }

        public int quantidadePaginas(int quantidadeItensPorPagina)
        {
            int totalFuncionarios = repository.quantidadeFuncionarios();
            return (int)Math.Ceiling((decimal)totalFuncionarios / quantidadeItensPorPagina);
        }

        public bool atualizar(Employee employee)
        {
            return repository.atualizar(employee);
        }

        public bool usuarioAdministrador()
        {
            if (Session.userAuth == null)
                return false;

            return Session.userAuth.adm;
        }
    }
}
