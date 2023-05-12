namespace ex01
{
    public class Carrinho: ICarrinho
    {
        public float Valor { get; set; }

        //Lista onde vamos manipular os objetos

        List<Produto> carrinho = new List<Produto>();

        public void Adicionar(Produto _produto)
        {
            carrinho.Add(_produto);
        }

        public void Atualizar(int _codigo, Produto _novoproduto)
        {
            PeR.ExibeMensagemPulandoLinha($"carrinho.Find(x => x.Codigo == _codigo) => {carrinho.Find(x => x.Codigo == _codigo)}");
            PeR.ExibeMensagemPulandoLinha($"carrinho.Find(x => x.Codigo == _codigo).Nome => {carrinho.Find(x => x.Codigo == _codigo).Nome}");
            carrinho.Find(x => x.Codigo == _codigo).Nome = _novoproduto.Nome;
            carrinho.Find(x => x.Codigo == _codigo).Preco = _novoproduto.Preco;
            PeR.ExibeMensagemPulandoLinha($"carrinho.Find(x => x.Codigo == _codigo) => {carrinho.Find(x => x.Codigo == _codigo)}");
            PeR.ExibeMensagemPulandoLinha($"carrinho.Find(x => x.Codigo == _codigo).Nome => {carrinho.Find(x => x.Codigo == _codigo).Nome}");
        }

        public void Listar()
        {
            if(carrinho.Count > 0 || carrinho != null){
                PeR.ExibeMensagem("\n\n\n");
                foreach (Produto p in carrinho)
                {    
                    PeR.ExibeMensagemPulandoLinha($"Código : {p.Codigo} - Nome : {p.Nome} - Preço: {p.Preco:C}");
                    
                }
                ValorTotal();
            }
        }

        public void Remover(Produto _produto)
        {
            carrinho.Remove(_produto);
        }

        public void ValorTotal(){
            Valor = 0;
            if(carrinho.Count > 0 || carrinho != null){
                foreach (Produto item in carrinho)
                {
                    Valor += item.Preco;
                }
                PeR.ExibeMensagemPulandoLinha($"Valor total do carrinho é : {Valor:C}");
            }else{
                PeR.ExibeMensagemPulandoLinha($"Seu carrinho esta vazio.");
            }
        }
    }
}