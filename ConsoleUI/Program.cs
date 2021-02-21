using Busieness.Concrete;
using DataAccess.Concrete.EntityFrameWork;
using Entites.Concerete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ColorTest();

        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var d in colorManager.GetColorDetailDtos())
            {
                Console.WriteLine(d.Descriptions + "   " + d.ColorName);
            }
        }

        private static void BradTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Delete(new Brand { BrandId = 1 });
            foreach (var b in brandManager.GetAll())
            {
                Console.WriteLine(b.BrandName);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car { BrandId = 1, ColorId = 2, DailyPrice = -300, ModelYear = "2021", Descriptions = "Otomatik Dizel" });

            foreach (var a in carManager.GetAll())
            {
                Console.WriteLine(a.ModelYear);
            }
        }
    }
}
