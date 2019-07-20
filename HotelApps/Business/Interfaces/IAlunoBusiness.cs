using HotelApps.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelApps.Business.Interfaces
{
    public interface IAlunoBusiness
    {
        bool Add(Aluno aluno);

        List<Aluno> GetList();
    }
}
