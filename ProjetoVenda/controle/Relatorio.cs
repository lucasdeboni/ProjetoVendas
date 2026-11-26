using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Imaging.Effects;
using System.Text;
using ProjetoVenda.modelo;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace ProjetoVenda.controle
{
    internal class Relatorio
    {

        public Document gerarNota(List<Item> itens)
        {
            DateTime data = DateTime.Now;

            var documento = Document.Create(conteudo => { // criando o documento

                conteudo.Page(pagina => {
                    pagina.Size(PageSizes.A6);
                    pagina.PageColor(QuestPDF.Infrastructure.Color.FromHex("f7f7c7"));
                    pagina.Margin(1, QuestPDF.Infrastructure.Unit.Centimetre);
                    pagina.DefaultTextStyle(font => font.FontSize(10));

                    //repete em todas as paginas
                    pagina.Header().Column(coluna => {
                        coluna.Item().AlignCenter().Text("Cupom de Venda").FontSize(18);
                        coluna.Item().LineHorizontal(2);
                        coluna.Item().PaddingBottom(10).Text("Mercadinho da Esquina").Bold();
                        coluna.Item().AlignCenter().Text("Rua das Flores - 7070 - Sorocaba/SP").FontSize(5);
                        coluna.Item().LineHorizontal(0.5f);

                    });

                    //conteúdo da página
                    // Cabeçalho dos itens
                    pagina.Content().Column(coluna =>
                    {
                        coluna.Item().Row(linha =>
                        {
                            linha.ConstantItem(20).Text("Item").FontSize(8);
                            linha.RelativeItem(3).Text("Descrição").FontSize(8);
                            linha.ConstantItem(20).Text("Qtd").FontSize(8);
                            linha.RelativeItem().Text("Preço").FontSize(8);
                            linha.RelativeItem().Text("Total").FontSize(8);
                        });
                        coluna.Item().LineHorizontal(0.5f);


                        //os itens descritos
                        for (int i = 0; i < itens.Count; i++)
                        {
                            Item item = itens[i];

                            coluna.Item().Row(linha => {
                                linha.ConstantItem(20).Text($"{i + 1}").FontSize(8);
                                linha.RelativeItem(3).Text(item.nomeProduto).FontSize(8);
                                linha.ConstantItem(20).Text($"{item.quantidade}").FontSize(8);
                                linha.RelativeItem().Text($"{item.precoReal:c2}").FontSize(8);
                                linha.RelativeItem().Text($"{item.subtotal:c2}").FontSize(8).AlignRight();
                            });
                        }
                        coluna.Item().LineHorizontal(0.5f);

                        decimal total = itens.Sum(item => item.subtotal);

                        coluna.Item().Row(linha =>
                        {
                            linha.RelativeItem().Text("Total").FontSize(8);
                            linha.RelativeItem().Text($"{total:c2}").FontSize(8).AlignRight();
                        });

                    });

                    //repete em todas as paginas
                    //Rodapé
                    pagina.Footer().Column(coluna =>
                    {
                        coluna.Item().LineHorizontal(0.5f);
                        coluna.Item().Text($"Data: {data: dd/MM/yyy HH:mm:ss} ").Bold();
                        coluna.Item().Text("Compre mais itálico").Italic();
                        coluna.Item().Text("todos os produtos são de propcedência duvidosa").FontSize(1);
                    });
                });
            });
            return documento;
        }

        public void salvarPdf(Document documento)
        {

            string pasta = Path.GetTempPath();
            string nomeArquivo = $"doc_{Guid.NewGuid()}.pdf";
            string caminho = Path.Combine(pasta, nomeArquivo);

            documento.GeneratePdf(caminho);

            // Abre o documento
            Process.Start(new ProcessStartInfo
            {
                FileName = caminho,
                UseShellExecute = true
            });

            //var dialogo = new SaveFileDialog
            //{
            //    Title = "Salvar Documento",
            //    FileName = "nota.pdf",
            //    Filter = "PDF|*.pdf"
            //};
            //if (dialogo.ShowDialog() == DialogResult.OK)
            //{
            //    var documento = gerarNota();
            //    documento.GeneratePdf(dialogo.FileName);
            //}
        }

    }
}
