using PropriedadesMetodos.Models;

Pessoa p1 = new Pessoa();

p1.Nome = "Alan";
p1.Sobrenome = "Ferreira";
p1.Idade = 10;

Pessoa p2 = new Pessoa(nome:"João",sobrenome: "Matheus");

p2.Idade = 10;

p1.Apresentar();

Curso cursoDeInglês = new Curso();
cursoDeInglês.Nome = "Inglês";
cursoDeInglês.Alunos = new List<Pessoa>();

cursoDeInglês.AdicionarAluno(p1);
cursoDeInglês.AdicionarAluno(p2);
cursoDeInglês.ListarAlunos();