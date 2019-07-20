using HotelApps.Business.Interfaces;
using HotelApps.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelApps.Services
{
    public class AlunoService
    {
        private readonly IAlunoBusiness _alunoBusiness;
        public AlunoService(IAlunoBusiness alunoBusiness)
        {
            _alunoBusiness = alunoBusiness;
        }

        public List<Aluno> Insert(Aluno aluno)
        {
            _alunoBusiness.Add(aluno);

            return _alunoBusiness.GetList();
        }
    }
}
