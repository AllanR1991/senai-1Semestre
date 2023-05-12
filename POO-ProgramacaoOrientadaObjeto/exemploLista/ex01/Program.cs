using ex01;

//Crair uma lista de objetos de produtos

List<Produto> produtos = new List<Produto>();

//Create

//Inserir objetos de produtos dentro da lista.
/* Não há necessidade de ter uma variavel e atribuila com new produto. */
produtos.Add(
    new Produto(1234, "camiseta lacoste", 19.99f)
);

/* CamisetaArmani é somente uma variavel que esta armazenando um novo objeto de Produtos. */
Produto camisetaArmani = new Produto(1234, "camiseta lacoste", 19.99f);
produtos.Add(camisetaArmani);



//Read -> Leitura;

foreach (var item in produtos)
{
    Console.WriteLine($"Código: {item.Codigo}, Nome: {item.Nome}, Preco: {item.Preco:C}");
}

//Update

Produto produtoEncontrado = produtos.Find(x => x.Codigo == 1234);
/* usando funçao arrow*/
int index = produtos.IndexOf(produtoEncontrado);
Console.WriteLine($"O índice do produto encontrado é o : {index}");

//fazer alterações
produtoEncontrado.Preco = 599f;

//Remover o item antigo da lista
produtos.RemoveAt(index);

//Devolver o item atualizado na lista
produtos.Insert(index, produtoEncontrado);


foreach (var item in produtos)
{
    Console.WriteLine($"Código: {item.Codigo}, Nome: {item.Nome}, Preco: {item.Preco:C}");
}