using Business.Abstract;
using DataAccess.Abstract;
using Entities2.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete;

public class CarManager : ICarService
{
    ICarDal _ıcardal;
    public CarManager(ICarDal carDal) 
    {
        _ıcardal = carDal;
    }
    public List<Car> GetAll()
    {
        return _ıcardal.GetAll();
    }
}
