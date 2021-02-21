using Entites.Concerete;
using Entites.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Busieness.Abstract
{
   public  interface IColorService
    {
        void Add(Color color);
      
        void Delete(Color color);
        List<Color> GetAll();
        List<ColorDetailDto> GetColorDetailDtos();


    }
}
