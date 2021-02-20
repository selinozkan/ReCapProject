using Busieness.Concrete;
using DataAccess.Concrete.EntiyFrameWork;
using Entites.Concerete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car { BrandId = 1, ColorId = 2, DailyPrice = -300, ModelYear = "2021", Descriptions = "Otomatik Dizel" });
            
                    foreach (var a in carManager.GetAll())
               {
                        Console.WriteLine(a.ModelYear);
               }
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Delete(new Brand { BrandId = 1 });
            foreach (var b in brandManager.GetAll())
            {
                Console.WriteLine(b.BrandName);
            }


        }
    }
}
