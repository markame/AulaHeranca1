using PrimeiraAula;

Aluno aluno = new Aluno();
aluno.None = "Flavio da Silva";
aluno.DataNascimento = "01/01/2000";
aluno.Email = "flavimdopneu@gmail.com";
aluno.Senha = "123456";
aluno.Dataentrada = DateTime.Now;
var matricula = aluno.GerarMatricula();
Console.WriteLine("Dados da Matricula do Aluno:");
Console.WriteLine("Nome: " + aluno.None);
Console.WriteLine("Email: " + aluno.Email);
Console.WriteLine("Matricula: " + matricula);
Console.WriteLine("Data de Nascimento: " + aluno.DataNascimento);
Console.WriteLine("Data de Entrada: " + aluno.Dataentrada.
    ToString("dd/MM/yyyy"));

Professor professor = new Professor();
professor.None = "João da Silva";
professor.Email ="joao@gmail.com";
professor.Senha = "123456";
professor.Titulacao = "Doutor";
var matriculaProfessor = professor.GerarMatricula();
Console.WriteLine("\nDados da Matricula do Professor:");
Console.WriteLine("Nome: " + professor.None);
Console.WriteLine("Email: " + professor.Email);
Console.WriteLine("Matricula: " + matriculaProfessor);
