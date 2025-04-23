using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Projeto_LIB
{
    public class Usuario
    {
        // Propriedades da classe Usuário
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public int Tipo { get; set; }
        public string Senha { get; set; }

        // Métodos construtores da classe Usuário
        public Usuario() { }
        public Usuario(int id, string nome, string cpf, int tipo, string senha)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Tipo = tipo;
            Senha = senha;
        }
        public Usuario(string nome, string cpf, int tipo, string senha)
        {
            Nome = nome;
            Cpf = cpf;
            Tipo = tipo;
            Senha = senha;
        }

        // Métodos da classe Usuários
        public static Usuario ObterPorId(int id)
        {
            Usuario usuario = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from usuarios where id = {id}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                usuario = new(
                        dr.GetInt32(0),
                        dr.GetString(1),
                        dr.GetString(2),
                        dr.GetInt32(3),
                        dr.GetString(4)
                    );
            }
            return usuario;
        }

        public void Cadastrar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"insert into usuarios (nome, cpf, tipo, senha)" +
                $"values ('{Nome}', '{Cpf}', '{Tipo}', md5('{Senha}'))";
            cmd.ExecuteNonQuery();
            Id = Convert.ToInt32(cmd.ExecuteScalar());
        }

        public static Usuario Logar(string cpf, string senha)
        {
            Usuario usuario = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from usuarios where cpf = @cpf and senha = md5(@senha)";
            cmd.Parameters.AddWithValue("@cpf", cpf);
            cmd.Parameters.AddWithValue("@senha", senha);
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                usuario.Id = dr.GetInt32(0);
                usuario.Nome = dr.GetString(1);
                usuario.Cpf = dr.GetString(2);
                usuario.Tipo = dr.GetInt32(3);
            }

            return usuario;
        }
    }
}
