using Entites.Concerete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Busieness.Abstract
{
    public interface IBrandService
    {
        void Add(Brand brand);
       
        void Delete(Brand brand);
        List<Brand> GetAll();
        Brand GetBrandId(int id);
    }
}
