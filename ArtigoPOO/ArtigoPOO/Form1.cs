using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArtigoPOO.Entities;


namespace ArtigoPOO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Produto objetoProduto = new Produto();

            objetoProduto._codigo = 0001;
            objetoProduto._nome = "Café Maratá";
            objetoProduto._preco_compra = 10.0m;
            objetoProduto._preco_venda = 15.0m;
            objetoProduto._quantidade_estoque = 5;
            objetoProduto._ativo = true;
            objetoProduto._data_cadastro = DateTime.Now;

            MessageBox.Show("----Informações do Produto-----" + "\n" + 
                "Código: " + objetoProduto._codigo + "\n" + 
                "Nome: " + objetoProduto._nome + "\n" + 
                "Preço de compra: " + objetoProduto._preco_compra + "\n" + 
                "Preço de venda: " + objetoProduto._preco_venda + "\n" + 
                "Qnantidade no estoque: "+ objetoProduto._quantidade_estoque+ "\n" +
                "Estatus: "+(objetoProduto._ativo == true ? "Ativo":"Inativo")+"\n"+
                "Data do cadastro: "+objetoProduto._data_cadastro);
        }
    }
}
