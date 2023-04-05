using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Conexao
{
    public class configBD
    {
        public  string selecionarBanco(System.Windows.Forms.OpenFileDialog opfile)
        {
            string arqBanco = string.Empty;

            opfile.Title = "Selecione o Banco de Dados";
            opfile.Filter = "Arquivo FDB (*.fdb)| *.fdb|" + "Arquivo FDB (*.fdb)|*.fdb";
            opfile.FilterIndex = 2;
            opfile.RestoreDirectory = true;
            opfile.ReadOnlyChecked = true;
            opfile.ShowReadOnly = true;

            opfile.ShowDialog();

            arqBanco = opfile.FileName;

            return arqBanco;
        }


    }
}
