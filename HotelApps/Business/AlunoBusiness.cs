using HotelApps.Business.Interfaces;
using HotelApps.Domain;
using HotelApps.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelApps.Business
{
    public class AlunoBusiness : IAlunoBusiness
    {
        AlunoRepository _alunoRepository;
        public AlunoBusiness()
        {
            _alunoRepository = new AlunoRepository();
        }

        public bool Add(Aluno aluno)
        {

            return _alunoRepository.Add(aluno);
        }

        public List<Aluno> GetList()
        {
            return _alunoRepository.GetList();
        }
    }
}
