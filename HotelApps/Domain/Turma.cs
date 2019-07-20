using HotelApps.Domain.ValueObj;
using System.Collections.Generic;

namespace HotelApps.Domain
{
    public class Turma
    {
        public string Numero { get; set; }
        public Periodo Periodo { get; set; }

        public List<Aluno> Alunos { get; set; }
    }
}
