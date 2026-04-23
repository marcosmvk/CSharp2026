using Estudante.Classes.Dados;
using Microsoft.EntityFrameworkCore;
using Estudante.Classes.Entidades;

using var context = new AlunoContext();

context.Database.EnsureCreated();

Aluno pessoa1 = new Aluno("Cesar", 123456, "DEV");
context.Alunos.Add(pessoa1);
context.SaveChanges();