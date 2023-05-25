using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleMVC.Model
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }
        //Caminho da pasta e do arquivo definido.
        private const string PATH = "Database/Produto.csv";
        

        //Criar um Construtor

        public Produto(){
            string pasta = PATH.Split('/')[0]; //Separa o valor atraves da barra e pega a primeira parte da divisão.
            
            if(!Directory.Exists(pasta)){
                Directory.CreateDirectory(pasta);
            }

            
            if(!File.Exists(PATH)){
                File.Create(PATH);
            }
        }
        

        public List<Produto> Listar(){
            List<Produto> listaDeProduto = new List<Produto>();
            
            //Array de string que recebe cada linha do CSV.
            string[] linhas = File.ReadAllLines(PATH);

            foreach (string linha in linhas)
            {
                string[] atributos = linha.Split(';');
                Produto p = new Produto();
                p.Codigo = int.Parse(atributos[0]);
                p.Nome = atributos[1];
                p.Preco = float.Parse(atributos[2]);
                
                listaDeProduto.Add(p);
            }
            return listaDeProduto;
        }  

        /*Metodo para preparar a linha do csv*/
        public string PrepararLinhaCSV(Produto objProduto){

            return $"{objProduto.Codigo};{objProduto.Nome};{objProduto.Preco}";
        }

        /*Metodo para inserir um produto no CSV*/
        public void Inserir(Produto objProduto){
            //Array que vai armazenar as linhas(cada "objeto")
            string[] linhas = {PrepararLinhaCSV(objProduto)};
            //Vai até o arquivo e insere todas as linhas.
            File.AppendAllLines(PATH, linhas);
        }


    }
}