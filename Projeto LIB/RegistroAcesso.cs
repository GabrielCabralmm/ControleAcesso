using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Projeto_LIB
{
    public class RegistroAcesso
    {
        // Propriedades da classe RegistroAcesso
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public DateTime DataHora { get; set; }
        public string TipoOperacao { get; set; }

        // Métodos construtores da classe RegistroAcesso
        public RegistroAcesso() { }
        public RegistroAcesso(int id, int usuarioId, DateTime dataHora, string tipoOperacao)
        {
            Id = id;
            UsuarioId = usuarioId;
            DataHora = dataHora;
            TipoOperacao = tipoOperacao;
        }

        // Métodos da classe RegistroAcesso
        public static RegistroAcesso ObterPorId(int id)
        {
            RegistroAcesso registro = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from registro_acessos where id = {id}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                registro = new(
                        dr.GetInt32(0),
                        dr.GetInt32(1),
                        dr.GetDateTime(2),
                        dr.GetString(3)
                    );
            }
            return registro;
        }
        public static List<RegistroAcesso> ObterLista()
        {
            List<RegistroAcesso> lista = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from registro_acessos";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new(
                        dr.GetInt32(0),
                        dr.GetInt32(1),
                        dr.GetDateTime(2),
                        dr.GetString(3)
                    )
                );
            }
            return lista;
        }
        public void RegistrarEntrada()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"insert into registro_acessos (id_usuario, data_hora, tipo_operacao)" +
                $"values ('{UsuarioId}', 'default', 'Entrada')";
            cmd.ExecuteNonQuery();
            Id = Convert.ToInt32(cmd.ExecuteScalar());
        }
        public void RegistrarSaida()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"insert into registro_acessos (id_usuario, data_hora, tipo_operacao)" +
                $"values ('{UsuarioId}', 'default', 'Saída')";
            cmd.ExecuteNonQuery();
            Id = Convert.ToInt32(cmd.ExecuteScalar());
        }
    }
}
