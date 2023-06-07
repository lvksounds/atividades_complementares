using AtividadesComplementares.Models;

var aluno = new Aluno("Lucas", "lvksounds@gmail.com");
var curso = new Minicurso("Curso C# completo", DateTime.Now.AddDays(10), 17, "eiokjhfjsdgcwpoihebkwjf");


var RegistroAtividade = new Registro(aluno, curso);

Console.WriteLine(RegistroAtividade.Atividade.Nome);
RegistroAtividade.RegistrarAtividade();


Console.WriteLine(curso.CargaHoraria);
Console.WriteLine(curso.Nome);
Console.WriteLine(curso.Datarealizacao.ToString());


Console.WriteLine(aluno.Nome); 
Console.WriteLine(aluno.Email);
