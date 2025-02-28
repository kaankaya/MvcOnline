﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ExperienceManager : IExperienceService
    {
        IExperience _experience;

        public ExperienceManager(IExperience experience)
        {
            _experience = experience;
        }

        public void TAdd(Experience t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Experience t)
        {
            throw new NotImplementedException();
        }

        public Experience TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Experience> TGetList()
        {
            return _experience.GetList();
        }

        public void TUpdate(Experience t)
        {
            throw new NotImplementedException();
        }
    }
}
