﻿using Entites.Concerete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Busieness.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        void Add(Car car);
        void Delete(Car car);
       
    }
    
}
