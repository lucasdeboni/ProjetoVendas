using System;
using System.Collections.Generic;
using System.Text;
using ProjetoVenda.modelo;
using ProjetoVenda.repositorio;
using ProjetoVenda.formularios;

namespace ProjetoVenda.controle
{
    internal class FuncionarioControle
    {
        public FuncionarioRepositorio repositorio;

        public FuncionarioControle()
        {
            repositorio = new FuncionarioRepositorio();
        }

        public bool autenticar(string nomeDeUsuario, string senha)
        {
            FuncionarioRepositorio repositorio = new FuncionarioRepositorio();
            Funcionario? funcionario = repositorio.pegarPorNomeDeUsuario(nomeDeUsuario);
            if (funcionario == null)
            {
                return false;
            }

            bool validarSenha;

            try
            {
                validarSenha = BCrypt.Net.BCrypt.Verify(senha, funcionario.senha);
            } catch(Exception ex)
            {
                validarSenha = false;
            }

            if( !validarSenha )
            {
                return false;
            }
            // to do: gravar os dados do usuário logado!
            Sessao.usuarioAutenticado = funcionario;

            return true;
        }

        public bool criarFuncionario(Funcionario funcionario)
        {
            // fazer verificação se o usuário não existe
            //solicitar ao repository se o usuário existe
            FuncionarioRepositorio repositorio = new FuncionarioRepositorio();
            Funcionario? resposta = repositorio.pegarPorNomeDeUsuario(funcionario.usuario);

            if(resposta != null)
            {
                return false;
            }

            string senhaCriptografada = BCrypt.Net.BCrypt.HashPassword(funcionario.senha);
            funcionario.senha = senhaCriptografada;

            repositorio.criarFuncionario(funcionario);
            return true;
        }

        public void deslogar()
        {
            Sessao.usuarioAutenticado = null;
        }

        public Funcionario? usuarioAutenticado()
        {
            return Sessao.usuarioAutenticado;
        }

        public List<Funcionario> listarFuncionarios()
        {
            return repositorio.listarFuncionarios();
        }

        public List<Funcionario> listarPorPagina(int quantidade, int pagina)
        {
            return repositorio.listarPorPagina(quantidade, pagina);
        }

        public int quantidadePaginas(int quantidadeItensPorPagina)
        {
            int totalFuncionarios = repositorio.quantidadeFuncionarios();
            return (int)Math.Ceiling((decimal)totalFuncionarios / quantidadeItensPorPagina);
        }

        public bool atualizar(Funcionario funcionario)
        {
            return repositorio.atualizar(funcionario);
        }

        public bool usuarioAdministrador()
        {
            if (Sessao.usuarioAutenticado == null)
                return false;

            return Sessao.usuarioAutenticado.adm;
        }
    }
}
