using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Cadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                string codBarras, Nome, Descrição, Preço, Estoque, Unidade, Tipo;
                codBarras = codigo.Text; Nome = nome.Text; Descrição = descriçao.Text;  Preço = preço.Text; Estoque = estoque.Text; Unidade = unidade.Text; Tipo = tipo.Text;
                if(string.IsNullOrWhiteSpace(codBarras))
                {
                    throw new Exception("Código de vazio");      
                }
                try
                {
                    Convert.ToInt64(codBarras);
                    
                }
                
                catch
                {
                    throw new Exception("Código de barras inválido");
                }
                if(codBarras.Length != 13)
                {
                        throw new Exception("O código de barras tem 13 digitos");
                }
                if (string.IsNullOrWhiteSpace(Nome))
                {
                    throw new Exception("Nome vazio");
                }
                if (string.IsNullOrWhiteSpace(Descrição))
                {
                    throw new Exception("Descrição vazio");
                }
                if (string.IsNullOrWhiteSpace(Preço))
                {
                    throw new Exception("Preço vazio");
                }
                try
                {
                    Convert.ToDouble(Preço);
                }
                catch
                {
                    throw new Exception("Preço inválido");
                }
                if (string.IsNullOrWhiteSpace(Estoque))
                {
                    throw new Exception("O campo 'Estoque' está vazio");
                }
                try
                {
                    Convert.ToInt16(Estoque);
                }
                catch
                {
                    throw new Exception("Estoque inválido");
                }
                if (string.IsNullOrWhiteSpace(Unidade))
                {
                    throw new Exception("Unidade vazio");
                }
                try
                {
                    Convert.ToInt16(Unidade);
                }
                catch
                {
                    throw new Exception("Unidade inválida");
                }
                if (string.IsNullOrWhiteSpace(Tipo))
                {
                    throw new Exception("Tipo vazio");
                }
                MessageBox.Show("Cadastro efetuado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                codigo.Focus();
                codigo.Clear();
                nome.Clear();
                descriçao.Clear();
                estoque.Clear();
                tipo.SelectedIndex = -1;
                preço.Clear();
                unidade.ResetText();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Voltar_Click(object sender, EventArgs e)
        {
            DialogResult escolha;
            escolha = MessageBox.Show("Deseja Voltar ?", "Retornar a HOME", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(escolha.ToString().ToLower() == "yes")
            {
                this.Hide();
                Form1 home = new Form1();
                home.ShowDialog();
                this.Close();
            }
        }

        private void nome_Enter(object sender, EventArgs e)
        {
            if(nome.Text == "Digite seu nome")
            {
                nome.Text = "";
                nome.ForeColor = Color.Black;
            }
        }
        private void nome_Leave(object sender, EventArgs e)
        {
            if (nome.Text == "")
            {
                nome.Text = "Digite seu nome";
                nome.ForeColor = Color.Silver;
            }
        }

        private void Limpar_Click(object sender, EventArgs e)
        {
            codigo.Clear();
            codigo.Focus();
            nome.Clear();
            descriçao.Clear();
            estoque.Clear();
            tipo.SelectedIndex = 0;
            preço.Clear();
            unidade.ResetText();
        }
    }
}
