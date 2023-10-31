using DataAccess.Abstract;
using Entities2.Concrete;

namespace DataAccess.Concrete.InMemory;

public class InMemoryDal:ICarDal
{
    List<Car> _cars;
    public InMemoryDal() 
    {
        _cars = new List<Car>() 
        { 
            new Car{CarId = 1,BrandId = 1,ColorId = 2,DailyPrice=250000,Description="Çıtır Hasarlı Honda Civic",ModelYear = 2010},
            new Car{CarId = 2,BrandId = 1,ColorId = 1,DailyPrice=300000,Description="Temiz Memurdan Hynduai İ20",ModelYear = 2018},
            new Car{CarId = 3,BrandId = 2,ColorId = 1,DailyPrice=400000,Description="Bayandan Elantra",ModelYear = 2020}

        };
    }
    public void Add(Car car) 
    {
        _cars.Add(car);
    }
    public void Delete(Car car) 
    {
        Car carToDelete = _cars.SingleOrDefault(c=>c.CarId ==car.CarId);
    }
    public List<Car>GetAll() 
    {
        return _cars;
    }
    public void Uptade(Car car) 
    {
        Car carToUptade = _cars.SingleOrDefault(c=>c.ModelYear == car.ModelYear);
        carToUptade.DailyPrice = car.DailyPrice;
        carToUptade.BrandId = car.BrandId;
        carToUptade.ColorId = car.ColorId;
        carToUptade.Description = car.Description;
       
    }
}
