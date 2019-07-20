using HotelApps.Business.Interfaces;
using HotelApps.Domain;
using HotelApps.Repository;
using System.Collections.Generic;

namespace HotelApps.Business
{
    public class TurmaBusiness : ITurmaBusiness
    {
        TurmaRepository _turmaRepository;

        public TurmaBusiness()
        {
            _turmaRepository = new TurmaRepository();
        }

        public bool Add(Turma turma)
        {
           return _turmaRepository.Add(turma);
        }

        public List<Turma> GetList()
        {
            return _turmaRepository.GetList();
        }
    }
}
