using ex01;
//Instancia do nosso objeto da classe carrinho
Carrinho carrinho = new Carrinho();
Produto p1 = new Produto(1,"Call Of Duty",400f);
Produto p2 = new Produto(2,"Mineirinho Ultra Adventures",2.30f);
Produto p3 = new Produto(3,"The Last of US",149.99f);


carrinho.Adicionar(p1);
carrinho.Adicionar(p2);
carrinho.Adicionar(p3);

carrinho.Listar();

carrinho.Remover(p1);

carrinho.Listar();

//Atualizat
//Criar um novo objeto com os dados atualizados

Produto produtoAtualizado = new Produto();

produtoAtualizado.Nome = "Diablo IV";
produtoAtualizado.Preco = 459.99f;

carrinho.Atualizar(2,produtoAtualizado);

carrinho.Listar();