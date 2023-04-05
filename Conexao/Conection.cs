using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;

namespace Conexao
{
    public class Conection
    {   
        public class Banco
        {

            public string pathLocal = System.AppDomain.CurrentDomain.BaseDirectory.ToString();

            public Banco()
            {

                string arqConexao = pathLocal + @"\Conexao.xml";

                MetodoseFuncoes.MetodosFuncoes.arquivos xml = new MetodoseFuncoes.MetodosFuncoes.arquivos();

                MetodoseFuncoes.MetodosFuncoes.TraString cryptodescrypto = new MetodoseFuncoes.MetodosFuncoes.TraString();

                if (File.Exists(arqConexao))
                {

                    setBanco(xml.Ler_XML("Banco", 1, arqConexao));
                    setPorta(xml.Ler_XML("Porta", 1, arqConexao));
                    setServidor(xml.Ler_XML("Servidor", 1, arqConexao));
                    setLogin(xml.Ler_XML("Login", 1, arqConexao));
                    setSenha(cryptodescrypto.DecryptStringAES(xml.Ler_XML("Senha", 1, arqConexao))); 

                }
                else
                {
                    setBanco(null);
                    setPorta(null);
                    setServidor(null);
                    setLogin(null);
                    setSenha(null);
                }

                
            }


            private string banco;
            private string porta;
            private string servidor;
            private string login;
            private string senha;

            public string getBanco()
            {
                return banco;

            }

            public void setBanco(string value)
            {
                banco = value;

            }

            public string getPorta()
            {
                return porta;

            }

            public void setPorta(string value)
            {
                porta = value;

            }

            public string getServidor()
            {
                return servidor;

            }

            public void setServidor(string value)
            {
                servidor = value;

            }


            public string getLogin()
            {
                return login;

            }

            public void setLogin(string value)
            {
                login = value;

            }

            public string getSenha()
            {

                return senha;

            }

            public void setSenha(string value)
            {
                senha = value;

            }


            public FbConnection conectarBanco()
            {
                FbConnection conn;

                conn = null;

                try
                {
                    string strConn = @"DataSource=" + getServidor()  + ";Database=" + getBanco() +
                                                        "; username= " + getLogin() +
                                                        "; password = " + getSenha() +
                                                        "; port = " + getPorta();

                    conn = new FbConnection(strConn);

                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }

                    conn.Open();
                }
                catch (Exception ex)
                {

                }

                return conn;

            }


            public FbConnection conectarBanco(string banco, string servidor, string login,
                                              string senha, string porta)
            {
                FbConnection conn;

                conn = null;

                try
                {
                    string strConn = @"DataSource=" + servidor + ";Database=" + banco+
                                                        "; username= " + login +
                                                        "; password = " + senha +
                                                        "; port = " + porta;

                    conn = new FbConnection(strConn);

                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }

                    conn.Open();
                }
                catch (Exception ex)
                {

                }

                return conn;

            }

        }
        
    }
}
