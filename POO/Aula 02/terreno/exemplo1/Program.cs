using static System.Console;
using exemplo1;


WriteLine("Entre com so dados do produto: ");
Write("Nome: ");
string nome = ReadLine();
Write("Preço: ");
double preco = double.Parse(ReadLine());
Write("Quantidade: ");
int qtd = int.Parse(ReadLine());

Produto p = new Produto(nome, preco,qtd);

WriteLine($"Dados do produto {p.Dados_do_Produto()}");

Write("Digite a quantidade de produtos a ser adicionado no estoque: ");
qtd = int.Parse(ReadLine());
p.Adicionar_Produtos(qtd);
WriteLine($"Dados aualizados: {p.Dados_do_Produto()}");
Write("Digite a quantidade de produtos a ser removidas do estque: ");
qtd = int.Parse(ReadLine());
p.Remover_Produtos(qtd);
Write($"Dados atualizados: {p.Dados_do_Produto()}");
ReadKey();
