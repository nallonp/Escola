using HotelApps.Business;
using HotelApps.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelApps.Services
{
    public class TurmaService
    {
        private readonly TurmaBusiness _turmaBusiness;
        public TurmaService(TurmaBusiness turmaBusiness)
        {
            _turmaBusiness = turmaBusiness;
        }

        public List<Turma> Insert(Turma turma)
        {
            _turmaBusiness.Add(turma);

            return _turmaBusiness.GetList();
        }
    }
}
