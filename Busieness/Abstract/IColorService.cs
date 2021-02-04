using Entites.Concerete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Busieness.Abstract
{
   public  interface IColorService
    {
        void Add(Color color);
        void Update(Color color);
        void Delete(Color color);
        List<Color> GetAll();



    }
}
