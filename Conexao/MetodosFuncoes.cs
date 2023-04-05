using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Security.Cryptography;

namespace MetodoseFuncoes
{
    public class MetodosFuncoes
    {

        #region Arquivo
        public class arquivos
        {
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
                            textolido += linhaTexto + ((char)13);
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

        #endregion TrataString
    }
    

    
}
