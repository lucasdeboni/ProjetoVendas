using ProjetoVenda.controle;
using ProjetoVenda.formularios;
using ProjetoVenda.modelo;
using QuestPDF.Infrastructure;

namespace ProjetoVenda
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            QuestPDF.Settings.License = LicenseType.Community;
            
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            //Application.Run(new frmCadastroVenda());
            //Relatorio relatorio = new Relatorio();
            //List<Item> itens = new List<Item>();
            //itens.Add(
            //    new Item
            //    {
            //        nomeProduto = "Pera",
            //        preco = 350,
            //        quantidade = 4
            //    });
            //var documento = relatorio.gerarNota(itens);
            //relatorio.salvarPdf(documento);

            while (true)
            {
                using (frmLogin login = new frmLogin())
                {
                    if (login.ShowDialog() != DialogResult.OK)
                    {
                        break;
                    }
                }
                using (frmPrincipal principal = new frmPrincipal())
                {
                    Application.Run(principal);
                    if (principal.DialogResult != DialogResult.Retry)
                    {
                        break;
                    }
                }

            }


        }
    }
}