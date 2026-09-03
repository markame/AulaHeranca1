using System;
using System.Collections.Generic;
using System.Text;



namespace PrimeiraAula
{
    public abstract class Pessoa
    {
        private string nome;
        private string matricula;
        private DateTime datanascimento;

        public string None
        {
            get => nome;
            set => nome = value;
        }
        public string DataNascimento
        {
            get => datanascimento.ToString("dd/MM/yyyy");
            set => datanascimento = DateTime.Parse(value);
        }

        public virtual string GerarMatricula()
        {
            var matricula = Convert.ToInt64(DateTime.Now.ToString("yyyyMMdd")) * 10;
            return matricula.ToString();
        }
    }
}
