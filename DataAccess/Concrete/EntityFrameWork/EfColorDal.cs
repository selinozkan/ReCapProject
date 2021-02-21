using Core.EntityFrameWork;
using DataAccess.Absract;
using Entites.Concerete;
using Entites.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFrameWork
{
    public class EfColorDal : EfEntityRepositoryBase<Color, RentACarContext>, IColorDal
    {
        public List<ColorDetailDto> GetColorDetailDtos()
        {
            using (RentACarContext context=new RentACarContext())
            {
                var result = from c in context.Colors
                             join d in context.Cars
                             on c.ColorId equals d.ColorId
                             select new ColorDetailDto
                             {
                                 CarId = d.CarId,
                                 ModelYear = d.ModelYear,
                                 DailyPrice = d.DailyPrice,
                                 Descriptions = d.Descriptions,
                                 BrandId = d.BrandId,
                                 ColorName = c.ColorName
                             };
                return result.ToList();
            }
        }
    }


}
