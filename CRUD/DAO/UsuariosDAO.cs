using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FirebirdSql.Data.FirebirdClient;
using System.Windows.Forms;

namespace CRUD.DAO
{
    public class UsuariosDAO
    {
        
        public List<Class.Usuarios> Listar()
        {

            List<Class.Usuarios> lista_usuarios = new List<Class.Usuarios>();
            try
            {


                FbConnection conn = null;

                Conexao.Conection.Banco banco = new Conexao.Conection.Banco();

                conn = banco.conectarBanco();

                if (conn != null)
                {
                    string sql = "SELECT * FROM Usuarios";
                    FbCommand cmd = new FbCommand(sql, conn);
                    FbDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        Class.Usuarios usuarios = new Class.Usuarios();
                        usuarios.Id = Convert.ToInt32(dr["Id"]);
                        usuarios.Nome = dr["Nome"].ToString();
                        usuarios.Login = dr["Login"].ToString();
                        usuarios.Senha = dr["Senha"].ToString();
                        usuarios.Foto = dr["Foto"].ToString();
                        usuarios.Permissao = dr["Permissao"].ToString();
                        lista_usuarios.Add(usuarios);
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("OPS. ocorreu um erro" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

            return lista_usuarios;
            

        }

        public void Insert(Class.Usuarios usuarios)
        {

            try
            {
                FbConnection conn = null;

                Conexao.Conection.Banco banco = new Conexao.Conection.Banco();

                conn = banco.conectarBanco();

                if (conn != null)
                {

                    string sql = "Insert int Usuarios (Nome, Login, Senha, Foto, Permissao) Value (@Nome, @Login, @Senha, @Foto , @Permissao)";

                    using (FbCommand cmd = new FbCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Nome", usuarios.Nome);
                        cmd.Parameters.AddWithValue("@Login", usuarios.Login);
                        cmd.Parameters.AddWithValue("@Senha", usuarios.Senha);
                        cmd.Parameters.AddWithValue("@Foto", usuarios.Foto);
                        cmd.Parameters.AddWithValue("@Permissao", usuarios.Permissao);
                        cmd.ExecuteNonQuery();


                    }

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Ops, ocorreu um erro " + ex.Message, "Erro ao cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

        }

        public void Alterar(Class.Usuarios usuarios)
        {
            try
            {

                FbConnection conn = null;

                Conexao.Conection.Banco banco = new Conexao.Conection.Banco();

                conn = banco.conectarBanco();

                if (conn != null)
                {
                    string sql = "Update Usuarios Set Nome=@Nome, Login = @Login, Login = @Senha, Foto = @Foto , Permissao = @Permissao Where Id = @Id)";

                    using (FbCommand cmd = new FbCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Nome", usuarios.Nome);
                        cmd.Parameters.AddWithValue("@Login", usuarios.Login);
                        cmd.Parameters.AddWithValue("@Senha", usuarios.Senha);
                        cmd.Parameters.AddWithValue("@Foto", usuarios.Foto);
                        cmd.Parameters.AddWithValue("@Permissao", usuarios.Permissao);
                        cmd.Parameters.AddWithValue("@Id", usuarios.Id);
                        cmd.ExecuteNonQuery();


                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ops, ocorreu um erro " + ex.Message, "Erro ao alterar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

        }

        public void Excluir(Int32 id)
        {
            try
            {
                FbConnection conn = null;

                Conexao.Conection.Banco banco = new Conexao.Conection.Banco();

                conn = banco.conectarBanco();

                if (conn != null)
                {
                    string sql = "Delete from Usuarios Where Id = @Id)";

                    using (FbCommand cmd = new FbCommand(sql, conn))
                    {
                       
                        cmd.Parameters.AddWithValue("@Id", id);
                        cmd.ExecuteNonQuery();


                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Ops, ocorreu um erro " + ex.Message, "Erro ao excluir", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

        }



    }
}
