﻿using DataAccess.Abstract;
using Entities2.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Business.Abstract;

public interface ICarService
{
    
    List<Car> GetAll();
}
