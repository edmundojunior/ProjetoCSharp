using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRUD.Class
{
    public class Usuarios
    {
        public Int32 Id { get; set; }
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Foto { get; set; }
        public string Permissao { get; set; }

    }
}
