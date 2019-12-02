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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Voltar_Click(object sender, EventArgs e)
        {
            DialogResult escolha;
            escolha = MessageBox.Show("Deseja Voltar ?", "Retornar a HOME", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (escolha.ToString().ToLower() == "yes")
            {
                this.Hide();
                Form1 home = new Form1();
                home.ShowDialog();
                this.Close();
            }
        }

        private void Limpar_Click_1(object sender, EventArgs e)
        {
            nome.Clear();
            cpf.Clear();
            rg.Clear();
            email.Clear();
            endereço.Clear();
            bairro.Clear();
            cidade.Clear();
            numero.Clear();
            cep.Clear();
            senha.Clear();
            senha2.Clear();
            estado.SelectedIndex = 0;
            masc.Checked = false;
            feme.Checked = false;
            outro.Checked = false;
            
        }
            private void Cadastrar_Click(object sender, EventArgs e)
            {
            string Nome, Email, RG, CPF, Rua, Bairro, Cidade, CEP, Numero, Estado, Senha, Senha2, Sexo = "";
            Nome = nome.Text;
            Email = email.Text;
            RG = rg.Text;
            CPF = cpf.Text;
            Rua = endereço.Text;
            Bairro = bairro.Text;
            Cidade = cidade.Text;
            CEP = cep.Text;
            Numero = numero.Text;
            Estado = estado.Text;
            Senha = senha.Text;
            Senha2 = senha2.Text;
            try
            {
                if (string.IsNullOrWhiteSpace(Nome))
                {
                    throw new Exception("Campo Nome Vazio");
                }
                if (string.IsNullOrWhiteSpace(Email))
                {
                    throw new Exception("Campo Email Vazio");
                }
                if (string.IsNullOrWhiteSpace(RG))
                {
                    throw new Exception("Campo RG Vazio");
                }
                if (RG.Length != 9)
                {
                    throw new Exception("Formato de RG invalido");
                }
                if (string.IsNullOrWhiteSpace(CPF))
                {
                    throw new Exception("Campo CPF Vazio");
                }
                if (CPF.Length != 11)
                {
                    throw new Exception("Formato de CPF invalido");
                }
                if (string.IsNullOrWhiteSpace(Rua))
                {
                    throw new Exception("Campo Endereço Vazio");
                }
                if (string.IsNullOrWhiteSpace(Bairro))
                {
                    throw new Exception("Campo Bairro Vazio");
                }
                if (string.IsNullOrWhiteSpace(Cidade))
                {
                    throw new Exception("Campo Cidade Vazio");
                }
                if (string.IsNullOrWhiteSpace(CEP))
                {
                    throw new Exception("Campo CEP Vazio");
                }
                try
                {
                    Int64.Parse(CEP);
                }
                catch
                {
                    throw new Exception("Formato de CEP invalido");
                }
                if (CEP.Length != 8)
                {
                    throw new Exception("CEP deve conter 8 digitos");
                }
                if (string.IsNullOrWhiteSpace(Numero))
                {
                    throw new Exception("Campo Número Vazio");
                }
                try
                {
                    int.Parse(Numero);
                }
                catch
                {
                    throw new Exception("Formato de Número invalido");
                }
                if (string.IsNullOrWhiteSpace(Estado) || Estado == "Nenhum")
                {
                    throw new Exception("Campo Estado Vazio");
                }
                if (masc.Checked == true)
                {
                    Sexo = masc.Text;
                }
                if (feme.Checked == true)
                {
                    Sexo = feme.Text;
                }
                if (outro.Checked == true)
                {
                    Sexo = outro.Text;
                }
                if (Sexo == "")
                {
                    throw new Exception("Selecione o Sexo");
                }
                if (string.IsNullOrWhiteSpace(Senha))
                {
                    throw new Exception("Campo Senha Vazio");
                }
                if (string.IsNullOrWhiteSpace(Senha2))
                {
                    throw new Exception("Campo Confirmar Senha Vazio");
                }
                if (Senha.Length <= 8)
                {
                    throw new Exception("Senha deve conter pelo menos 8 Digitos");
                }
                if (Senha != Senha2)
                {
                    throw new Exception("Senha Não Corresponde");
                }

                MessageBox.Show("O Cadastro foi Realizado", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                nome.Clear();
                cpf.Clear();
                rg.Clear();
                email.Clear();
                endereço.Clear();
                bairro.Clear();
                cidade.Clear();
                numero.Clear();
                cep.Clear();
                senha.Clear();
                senha2.Clear();
                estado.SelectedIndex = 0;
                masc.Checked = false;
                feme.Checked = false;
                outro.Checked = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Encontrei um Erro!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
