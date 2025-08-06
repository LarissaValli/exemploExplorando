using exemploExplorando.Models;

Pessoa p1 = new Pessoa(nome:"Luna", sobrenome: "Valli");
Pessoa p2 = new Pessoa(nome: "Alexandre", sobrenome: "Contardi");

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();

































// Pessoa p1 = new Pessoa();
// p1.Nome = "Luna";
// p1.Sobrenome = "Valli";
// p1.Idade = 23;
// p1.Apresentar();