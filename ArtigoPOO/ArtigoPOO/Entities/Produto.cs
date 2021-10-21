using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtigoPOO.Entities
{
    public class Produto
    { //modificador de acesso padrão é private
        private int Codigo;
        public int _codigo
        {
            get { return Codigo; }
            set { Codigo = value; }
        }
        private string Nome;
        public string _nome
        {
            get { return Nome; }
            set { Nome = value; }
        }


        private decimal Preco_Compra;
        public decimal _preco_compra
        {
            get { return Preco_Compra; }
            set { Preco_Compra = value; }
        }

        private decimal Preco_Venda;
        public decimal _preco_venda
        {
            get { return Preco_Venda; }
            set { Preco_Venda = value; }
        }

        private int Quantidade_Estoque;
        public int _quantidade_estoque
        {
            get { return Quantidade_Estoque; }
            set { Quantidade_Estoque = value; }
        }

        private bool Ativo;
        public bool _ativo
        {
            get { return Ativo; }
            set { Ativo = value; }
        }

        private DateTime Data_Cadastro;
        public DateTime _data_cadastro
        {
            get { return Data_Cadastro; }
            set { Data_Cadastro = value; }
        }
        
        public Produto()
        {

        }

        public int inserir(Produto objNovoPRoduto)
        {
            return 20;
        }
        public bool alterar(Produto objAlterarProduto)
        {
            if (true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void excluir(int codExcluirProduto)
        {

        }
       
        public List<Produto> pesquisar(int codProduto, string nomeProduto)
        {
            List<Produto> listaProdutoRetorno = new List<Produto>();
            if (codProduto > 0)
            {
                return listaProdutoRetorno;
            }
            else
            {
                return listaProdutoRetorno;
            }
        }
    }
    
}
