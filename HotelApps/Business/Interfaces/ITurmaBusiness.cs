using HotelApps.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelApps.Business.Interfaces
{
    public interface ITurmaBusiness
    {
        bool Add(Turma turma);

        List<Turma> GetList();
    }
}
