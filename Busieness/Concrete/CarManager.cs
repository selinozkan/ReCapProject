﻿using Busieness.Abstract;
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

        public void Add(Car car)
        {

            if (car.DailyPrice > 0)
            {
                _carDal.Add(car);
                Console.WriteLine("Araba başarıyla eklendi.");
                            }
            else
            {
                Console.WriteLine($"Lütfen günlük fiyat kısmını 0'dan büyük giriniz. Girdiğiniz değer : {car.DailyPrice}");
            }
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }
        public void Delete(Car car)
        {
            _carDal.Delete(car);
           
        }

        public void Update(Car car)
        {
            throw new NotImplementedException();
        }
    }
}
