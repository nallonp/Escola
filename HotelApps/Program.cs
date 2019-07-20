using HotelApps.Business;
using HotelApps.Domain;
using HotelApps.Services;
using System;
using System.Linq;
using System.Collections.Generic;

namespace HotelApps
{
    class Program
    {
        static void Main(string[] args)
        {
            var alunoBusiness = new AlunoBusiness();
            var turmaBusiness = new TurmaBusiness();

            var alunoService = new AlunoService(alunoBusiness);
            var turmaService = new TurmaService(turmaBusiness);

            var alunos = alunoService.Insert(new Aluno { Id = 1, Nome = "AAAA" });
            var turmas = turmaService.Insert(new Turma
            {
                Numero = "101",
                Periodo = Domain.ValueObj.Periodo.noite,
                Alunos = new List<Aluno>()
                {
                    new Aluno { Id = 1, Nome = "AAAA" },
                    new Aluno { Id = 1, Nome = "BBBB" },
                    new Aluno { Id = 1, Nome = "CCCC" }
                }
            });

            Console.WriteLine($"{alunos.Any()} {alunos.Count()} {alunos[0].Nome}");
            Console.WriteLine($"{turmas.Any()} {turmas.Count()} {turmas[0].Numero}");
        }
    }
}
