using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using System.IO;
using System.Windows.Forms;

namespace Conexao
{
    public partial class frmConfBancoDeDados : Form
    {


        public string pathLocal = System.AppDomain.CurrentDomain.BaseDirectory.ToString();

        public frmConfBancoDeDados()
        {
            InitializeComponent();

            KeyPreview = true;
            foreach (Control control in Controls)
            {
                control.KeyPress += new KeyPressEventHandler(Control_KeyPress);
            }

        }

        private void Control_KeyPress(object sender, KeyPressEventArgs e) //alterar tab para enter
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        configBD configuracaoBancoDeDados = new configBD();

        private void frmConfBancoDeDados_Load(object sender, EventArgs e)
        {
            abrirConfiguracaoBancoDeDados();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtBancoDeDados.Text = configuracaoBancoDeDados.selecionarBanco(opfile);
        }


        private bool  verificaCampos()
        {
            bool retorno = true ;
            
            if (txtBancoDeDados.Text == "")
            {
                MessageBox.Show("Favor informar caminho e bando de dados a ser usado!");
                txtBancoDeDados.Focus();
                retorno = false;
            }
            else if (txtLogin.Text == "")
            {
                MessageBox.Show("Favor informar o Login!");
                txtLogin.Focus();
                retorno = false;
            }
            else if (txtSenha.Text == "")
            {
                MessageBox.Show("Favor informar a senha!");
                txtSenha.Focus();
                retorno = false;
            }
            else if (txtPorta.Text == "")
            {
                MessageBox.Show("Favor informar a Porta");
                txtPorta.Focus();
                retorno = false;
            }
            else if (txtServidor.Text == "")
            {
                MessageBox.Show("Favor informar a Servidor");
                txtServidor.Focus();
                retorno = false;
            }

            return retorno;
        }

        private void confirmarConfiguracao()
        {
            if (verificaCampos())               
            {

                gravarConfiguracaoBancoDeDados();

                MessageBox.Show("Configuracao realizada com sucesso!");
            }

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            confirmarConfiguracao();
        }

        private void btnTestar_Click(object sender, EventArgs e)
        {
            if (verificaCampos())
            {

                testarConexao();
            }
        }

        private void testarConexao()
        {
            FbConnection conn  = null;


            Conection.Banco  conectar = new Conection.Banco ();

            
            conn  = conectar.conectarBanco(txtBancoDeDados.Text, txtServidor.Text,
                               txtLogin.Text , txtSenha.Text, txtPorta.Text);

            if (conn != null)
            {
                picVerde.Visible = true;
                picVermelho.Visible = false;
            }
            else
            {
                picVerde.Visible = false;
                picVermelho.Visible = true ;
            }

        }

        private void gravarConfiguracaoBancoDeDados()
        {
            
            
            string arqConexao = pathLocal + @"\Conexao.xml";
            string arqConexaoOld = pathLocal + @"\Conexao.old";
            string linha = string.Empty;

            string montarXML = string.Empty;

            MetodoseFuncoes.MetodosFuncoes.TraString cryptodescrypto = new MetodoseFuncoes.MetodosFuncoes.TraString();


            montarXML += "<?xml version=" + '"' + "1.0";
            montarXML += '"';
            montarXML += " encoding=";
            montarXML += '"';
            montarXML += "UTF-8";
            montarXML += '"';
            montarXML += "?>" + "\n";
            montarXML += "<Config>" + "\n";
            montarXML += "  <Banco>" + txtBancoDeDados.Text.Trim() + "</Banco>" + "\n";
            montarXML += "  <Servidor>" + txtServidor.Text.Trim() + "</Servidor>" + "\n";
            montarXML += "  <Login>" + txtLogin.Text.Trim() + "</Login>" + "\n";
            montarXML += "  <Senha>" + cryptodescrypto.EncryptStringAES(txtSenha.Text.Trim()) + "</Senha>" + "\n";
            montarXML += "  <Porta>" + txtPorta.Text.Trim() + "</Porta>" + "\n";
            montarXML += "</Config>";

            if (File.Exists(arqConexaoOld))
            {
                File.Delete(arqConexaoOld);
            }


            if (File.Exists(arqConexao))
            {

                File.Move(arqConexao, arqConexaoOld);

            }

            FileStream fs = new FileStream(arqConexao, FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(montarXML);
            sw.Flush();
            sw.Close();
            fs.Close();

            if (File.Exists(arqConexao))
            {

                //MessageBox.Show("Configuração Salva com sucesso");

                if (File.Exists(arqConexaoOld))
                {
                    File.Delete(arqConexaoOld);
                }

                    
            }
            else
            {

                MessageBox.Show("Não foi possível salvar o arquivo de configuração");
                
                if (File.Exists(arqConexaoOld))
                {
                     File.Move(arqConexaoOld, arqConexao);
                }                    
            }      
                        
        }

        private void abrirConfiguracaoBancoDeDados()
        {

            Conection.Banco dadosDoBanco = new Conection.Banco();
            
            txtBancoDeDados.Text = dadosDoBanco.getBanco() ;
            txtServidor.Text = dadosDoBanco.getServidor() ;
            txtLogin.Text =dadosDoBanco.getLogin() ; 
            txtSenha.Text =dadosDoBanco.getSenha() ;
            txtPorta.Text = dadosDoBanco.getPorta() ; 

            
        }
    }
}
