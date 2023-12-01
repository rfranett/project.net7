using project.net7.models ;

int quantidadeEmEstoque = 19;
int quantidadeDeCompla = 6;
bool posivelVenda = quantidadeEmEstoque >= quantidadeDeCompla;

Console.WriteLine($"Quantidade Em Estoque:{quantidadeEmEstoque}");
Console.WriteLine($"Quantidade De Compla:{quantidadeDeCompla}");
Console.WriteLine($"É Posivel Realizar Vendas?{posivelVenda}");

if (posivelVenda)
{
    Console.WriteLine("Venda realizada.");
}
else
{
    Console.WriteLine("Desculpe.Não temos a quantidade desejada em estoque.");
}