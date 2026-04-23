using Estudante.Classes.Dados;
using Microsoft.EntityFrameworkCore;
using Estudante.Classes.Entidades;

using var context = new AlunoContext();

context.Database.EnsureCreated();
//Adicionar dados ao Banco de dados
Aluno pessoa1 = new Aluno("Cesar", 123456, "DEV");
context.Alunos.Add(pessoa1);
context.SaveChanges();

//Exibir dados
var pessoas = context.Alunos.FirstOrDefault(c => c.Id == 1);
pessoas.ExibirDados();

//Update 
pessoas  = context.Alunos.FirstOrDefault(c = c => c.Id == 2);
pessoas.Curso = "BackEnd";
context.SaveChanges();