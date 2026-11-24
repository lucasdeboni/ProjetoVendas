using System;
using System.Collections.Generic;
using System.Drawing.Imaging.Effects;
using System.Text;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace ProjetoVenda.controle
{
    internal class Relatorio
    {

        public Document gerarNota()
        {
            var documento = Document.Create(conteudo => { // criando o documento

                conteudo.Page(pagina => {
                    pagina.Size(PageSizes.A6);
                    pagina.PageColor(QuestPDF.Infrastructure.Color.FromHex("f7f7c7"));
                    pagina.Margin(1, QuestPDF.Infrastructure.Unit.Centimetre);
                    pagina.DefaultTextStyle(font => font.FontSize(10));


                    // repete em toda página
                    pagina.Header().Column( coluna => {
                        coluna.Item().AlignCenter().Text("Cupom de Venda");
                        coluna.Item().LineHorizontal(2);
                        coluna.Item().AlignCenter().Text("Mercadinho do Adão");
                        coluna.Item().AlignCenter().Text("Alameda Eden Jardim - S/N - Sorocaba/SP").FontSize(5);
                        coluna.Item().LineHorizontal(0.5f);

                    });


                    // NÃO repete em toda página
                    pagina.Content();


                    // repete em toda página
                    pagina.Footer().Column(coluna => {
                        coluna.Item().LineHorizontal(0.5f);
                        coluna.Item().Text("Data: 23/11/2026");
                        coluna.Item().Text("Compre mais");
                        coluna.Item().Text("todos os produtos são de procedência duvidosa.").FontSize(1);

                    });


                });
            
            });

            return documento;
            //documento.GeneratePdf(@"C:\Users\lucas.asdeboni\Downloads\ProjetoVenda\nota.pdf");
        }

        public void salvarPdf()
        {
            var dialogo = new SaveFileDialog
            {
                Title = "Salvar Documento",
                FileName = "nota.pdf",
                Filter = "PDF|*.pdf"
            };
            if (dialogo.ShowDialog() == DialogResult.OK)
            {
                var documento = gerarNota();
                documento.GeneratePdf(dialogo.FileName);
            }
        }

    }
}
