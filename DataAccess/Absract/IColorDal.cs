using Core.DataAccess;
using Entites.Concerete;
using Entites.DTOs;
using System;
using System.Collections.Generic;

using System.Text;

namespace DataAccess.Absract
{
    public   interface IColorDal :IEntityRepository<Color> 
    {
        List<ColorDetailDto> GetColorDetailDtos();
    }
}
