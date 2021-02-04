using Busieness.Abstract;
using DataAccess.Absract;
using Entites.Concerete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Busieness.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }
    }
}
