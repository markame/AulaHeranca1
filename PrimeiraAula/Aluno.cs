using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeiraAula
{
    public class Aluno: Pessoa
    {
        private string email;
        private string senha;
        private DateTime dataentrada;

        public string Email { get => email; set => email = value; }
        public string Senha { get => senha; set => senha = value; }
        public DateTime Dataentrada { get => dataentrada; set => dataentrada = value; }

        public override string GerarMatricula()
        {
            var matricula = Convert.ToInt64(DateTime.Now.ToString("yyyyMMdd")) * 10 + 1;
            return matricula.ToString();
        }
    }
}
