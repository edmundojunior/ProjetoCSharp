using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Security.Cryptography;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;


namespace MetodoseFuncoes
{
    public class MetodosFuncoes
    {

        #region Componentes
        public class Componetes
        {
            //PictureBox
            public void imagemRedonda(System.Windows.Forms.PictureBox pict)
            {
                
                GraphicsPath gp = new GraphicsPath();
                gp.AddEllipse(0, 0, pict.Width, pict.Height);
                pict.Region = new Region(gp);
            }
        }
        #endregion Componentes

        #region Arquivo
        public class arquivos
        {

            

            #region XML
            public string Ler_XML(string tag, int ocorrencia, string arquivo)
            {
                string retorno;
                int posInicial = 0;
                int posFinal = 0;
                int Ler = 0;
                int apartir = 0;
                StreamReader fluxoTexto;
                string linhaTexto;
                string textolido = String.Empty;

                try
                {
                    retorno = string.Empty;

                    if (File.Exists(arquivo))
                    {
                        fluxoTexto = new StreamReader(arquivo);
                        linhaTexto = fluxoTexto.ReadLine();

                        while (linhaTexto != null)
                        {
                            textolido = linhaTexto + ((char)13);
                            linhaTexto = fluxoTexto.ReadLine();
                        }

                        for (int i = 1; i <= ocorrencia; i++)
                        {
                            posInicial = textolido.IndexOf("<" + tag + ">", posInicial + 1);
                            posFinal = textolido.IndexOf("</" + tag + ">", posFinal + 1);
                            apartir = posInicial + ("</" + tag + ">").Length;
                            Ler = posFinal - (posInicial + ("<" + tag + ">").Length);
                        }

                        retorno = textolido.Substring(apartir - 1, Ler);
                        fluxoTexto.Close();

                        return retorno;

                    }


                }
                catch
                {
                    retorno = string.Empty;

                }
                return retorno;
            }
            #endregion XML

            #region Imagens
            public class Imagens
            {

                #region Base64
                public class Base64
                {

                    public string pathLocal = System.AppDomain.CurrentDomain.BaseDirectory.ToString();

                    public string ImagemParaBase64(string imagem)
                    {

                        try
                        {
                            
                            byte[] imageBytes = File.ReadAllBytes(imagem);
                            string base64String = Convert.ToBase64String(imageBytes);
                            return base64String;

                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show("Ops.Ocorreu um erro ao converter uma imagem para Base64" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            throw;
                        }

                    }

                    public string Base64paraImagem(string dados)
                    {

                        try
                        {

                            Random rnd = new Random();

                            string arqImagem = pathLocal + @"\img" + rnd.Next(1000, 2000) + ".png";

                            string base64String = dados;
                            byte[] imageBytes = Convert.FromBase64String(base64String);
                            using (MemoryStream ms = new MemoryStream(imageBytes))
                            {
                                Image image = Image.FromStream(ms);
                                // faça algo com a imagem
                                image.Save(arqImagem);
                                return arqImagem;

                            }

                            
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ops.Ocorreu um erro ao converter uma Base64 para imagem" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            throw;
                        }
                    }

                }
                #endregion Base64

            }
            #endregion Imagens


        }
        #endregion

        #region TrataString
        
        public class TraString
        {

            #region Crypto/Descryto
            //public static string EncryptStringAES(string plainText, string key, string iv)
            public  string EncryptStringAES(string plainText)
            {
                string key = "MySecretKey12345";
                string iv = "MySecretIV678900";



                byte[] keyBytes = Encoding.UTF8.GetBytes(key);
                byte[] ivBytes = Encoding.UTF8.GetBytes(iv);

                byte[] encrypted;

                using (Aes aes = Aes.Create())
                {
                    aes.Key = keyBytes;
                    aes.IV = ivBytes;

                    ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                    using (MemoryStream ms = new MemoryStream())
                    {
                        using (CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                        {
                            using (StreamWriter sw = new StreamWriter(cs))
                            {
                                sw.Write(plainText);
                            }

                            encrypted = ms.ToArray();
                        }
                    }
                }

                return Convert.ToBase64String(encrypted);
            }

            //public static string DecryptStringAES(string cipherText, string key, string iv)
            public  string DecryptStringAES(string cipherText)
            {
                string key = "MySecretKey12345";
                string iv = "MySecretIV678900";

                byte[] keyBytes = Encoding.UTF8.GetBytes(key);
                byte[] ivBytes = Encoding.UTF8.GetBytes(iv);
                byte[] cipherTextBytes = Convert.FromBase64String(cipherText);

                string plainText = null;

                using (Aes aes = Aes.Create())
                {
                    aes.Key = keyBytes;
                    aes.IV = ivBytes;

                    ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

                    using (MemoryStream ms = new MemoryStream(cipherTextBytes))
                    {
                        using (CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                        {
                            using (StreamReader sr = new StreamReader(cs))
                            {
                                plainText = sr.ReadToEnd();
                            }
                        }
                    }
                }

                return plainText;
            }

        }
        #endregion Crypto/Descryto

       
        #endregion TrataString
    }
    

    
}
