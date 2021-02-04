using DataAccess.Absract;
using Entites.Concerete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
   public  class InMemoryCarDal:ICarDal
    {
        List<Car> _car; // global değişken 

        public InMemoryCarDal()
        {
            _car = new List<Car> {
                new Car {CarId=1,BrandId=1,ColorId=1,ModelYear=1995,Description="Toyota"},
            new Car { CarId = 2, BrandId = 1, ColorId = 1, ModelYear = 1995, Description = "Toyota" },
            new Car { CarId = 3, BrandId = 3, ColorId = 1, ModelYear = 1995, Description = "BMW" },
            new Car { CarId = 4, BrandId = 2, ColorId = 1, ModelYear = 1995, Description = "Opel" },
            new Car { CarId = 5, BrandId = 1, ColorId = 1, ModelYear = 1995, Description = "Toyota" },
            new Car { CarId = 6, BrandId = 3, ColorId = 1, ModelYear = 1995, Description = "BMW" },
            new Car { CarId = 7, BrandId = 2, ColorId = 1, ModelYear = 1995, Description = "Toyota" }};

        }
        public void Add(Car car)
        {
            _car.Add(car);
        }



        public void Delete(Car car)
        {
            Car carToDelete = _car.SingleOrDefault(p => p.CarId == car.CarId);
            _car.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetById(int carId)
        {
            return _car.Where(p => p.CarId == carId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _car.SingleOrDefault(p => p.CarId == car.CarId);
            carToUpdate.CarId = car.CarId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.Description = car.Description;
            carToUpdate.DilyPrice = car.DilyPrice;

        }
    }
}
