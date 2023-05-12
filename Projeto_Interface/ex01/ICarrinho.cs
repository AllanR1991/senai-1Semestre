using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ex01
{
    public interface ICarrinho
    {
        //Definir (declarar) quais os métodos deverão ser implementados
        //na classe que herda desta interface


        //CRUD Creaate / Read / Update / Delete
        void Adicionar(Produto _produto);
        void Listar();

        void Atualizar(int _codigo, Produto _novoproduto);

        void Remover(Produto _produto);

    }
}