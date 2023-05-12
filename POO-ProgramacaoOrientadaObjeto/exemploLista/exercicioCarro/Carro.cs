//EXERCÍCIO PARA FIXAÇÃO - NÃO PRECISA ENTREGAR

//1 - CRIAR UMA CLASSE "CARRO"
//      - PROPRIEDADES : STRING MARCA, STRING COR

//2 - CRIAR CONSTRUTOR VAZIO E COMPLETO

//3 - CADASTRAR E INSERIR EM UMA LISTA 2 OBJETOS(DINÂMICO)
//      - ENTRADA DE DADOS PELO CONSOLE 

//4 - EXIBIR OS DADOS DOS OBJETOS NO CONSOLE (FOREACH)


namespace exercicioCarro
{
    public class Carro
    {
        public string Marca { get; set; }
        
        public string Cor { get; set; }
        
        public Carro(){
        }

        public Carro(string marca, string cor){
            Marca = marca;
            Cor = cor;
        }
        

        
    }
}