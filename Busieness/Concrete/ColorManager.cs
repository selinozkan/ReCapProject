﻿using Busieness.Abstract;
using DataAccess.Absract;
using Entites.Concerete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Busieness.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public void Add(Color color)
        {
            
        }

        public void Delete(Color color)
        {
            throw new NotImplementedException();
        }

        public List<Color> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Color color)
        {
            throw new NotImplementedException();
        }
    }
}