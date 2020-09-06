
using API_Pets.Context;
using API_Pet.Domains;
using API_Pet.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace API_Pet.Repositories
{
    public class TipoPetRepository : ITipoPet
    {   
        //Chamamos a conexao que foi feita lá no Context
        PetsContext conexao = new PetsContext();

        //Chamamos o objeto que poderá receber e executar os comandos do banco
        SqlCommand cmd = new SqlCommand();

        public TipoPet Alterar(int id, TipoPet t)
        {
            throw new NotImplementedException();
        }

        public TipoPet BuscarPorId(int id)
        {
            cmd.Connection = conexao.Conectar();

            // Usamos o comando de Busca do SQL(WHERE)
            cmd.CommandText = "SELECT * FROM TipoPet WHERE IdTipoPet = @id";

            //Atribuimos as variaves que vem como arg, ou seja, é um tipo de pareamento 
            cmd.Parameters.AddWithValue("@id", id);

            //Damos o play
            SqlDataReader dados = cmd.ExecuteReader();

            
            TipoPet t = new TipoPet();

            while (dados.Read())
            {
                t.IdTipoPet = Convert.ToInt32(dados.GetValue(0));
                t.Descricao = dados.GetValue(1).ToString();
            }


            // Desconectamos o banco
            conexao.Desconectar();

            return t;
        }

        public TipoPet Cadastrar(TipoPet t)
        {
            throw new NotImplementedException();
        }

        public TipoPet Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public List<TipoPet> LerTodos()
        {
            //Abrimos conexao
            cmd.Connection = conexao.Conectar();

            // Usamos o msm comando do banco para consultar a tabela tipopet
            cmd.CommandText = "SELECT * FROM TipoPet";

            // Precisamos de um play
            SqlDataReader dados = cmd.ExecuteReader();

            // Criamos uma lista para guardar os tipospets
            List<TipoPet> tipos = new List<TipoPet>();

            //Fazemos uma tratativa com while
            while (dados.Read())
            {
                tipos.Add(
                        new TipoPet()
                        {
                            IdTipoPet = Convert.ToInt32(dados.GetValue(0)),
                            Descricao = dados.GetValue(1).ToString(),
                        }
                    );
            }

            //Fechamos conexao
            conexao.Desconectar();

            return tipos;
        }
    }
}
