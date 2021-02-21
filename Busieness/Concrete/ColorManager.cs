using Busieness.Abstract;
using DataAccess.Absract;
using Entites.Concerete;
using Entites.DTOs;
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
            return _colorDal.GetAll();
        }

        public List<ColorDetailDto> GetColorDetailDtos()
        {
            return _colorDal.GetColorDetailDtos();
        }
    }
}
