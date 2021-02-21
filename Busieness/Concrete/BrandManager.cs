using Busieness.Abstract;
using DataAccess.Absract;
using Entites.Concerete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Busieness.Concrete
{
    public class BrandManager : IBrandService
    {

        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public void Add(Brand brand)
        {
            if (brand.BrandName.Length > 2)
            {
                _brandDal.Add(brand);
                Console.WriteLine("araba isimin kurallara uygun");
            }
            else
            {
                Console.WriteLine("girdiğiniz araba ismi kurallara uygun değil");
            }
        }

        public void Delete(Brand brand)
        {
            _brandDal.Delete(brand);
            Console.WriteLine("istediğiniz veri başarı ile silindi. silinen arabanın ismi" + brand.BrandName);
        }

        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
        }

        public Brand GetBrandId(int id)
        {
            return _brandDal.Get(c => c.BrandId == id);
        }

 
        
    }
}
