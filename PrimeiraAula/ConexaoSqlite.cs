using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.Sqlite;

namespace PrimeiraAula
{
    public class ConexaoSqlite : IConexao
    {
        public readonly string _connectionString;
        
        public ConexaoSqlite()
        {
            _connectionString = "Data Source=Academico.db";
            Criarconexao();
        }
        public void Criarconexao()
        {
           using var connection = new SqliteConnection(_connectionString);
            connection.Open();
            using var command = connection.CreateCommand();
            command.CommandText = @"create table if not exists Alunos(
                Id integer primary key autoincrement,
                Nome text not null,
                DataNascimento text not null,
                Email text not null,
                Senha text not null,
                DataEntrada text not null
);";
            command.ExecuteNonQuery();
            connection.Close();
        }

        public string InserirAluno(Aluno alunos)
        {
            using var connection = new SqliteConnection(_connectionString);
            connection.Open();
            using var command = connection.CreateCommand();
            command.CommandText = @"insert into Alunos(Nome, DataNascimento,
                Email, Senha, DataEntrada) 
                values(@nome, @dataNascimento, @email, @senha, @dataEntrada)";
            command.Parameters.AddWithValue("@nome", alunos.None);
            command.Parameters.AddWithValue("@dataNascimento", alunos.DataNascimento);
            command.Parameters.AddWithValue("@email", alunos.Email);
            command.Parameters.AddWithValue("@senha", alunos.Senha);
            command.Parameters.AddWithValue("@dataEntrada", alunos.Dataentrada);
            command.ExecuteNonQuery();
            connection.Close();
            return "Aluno inserido com sucesso!";
        }
    }
}
