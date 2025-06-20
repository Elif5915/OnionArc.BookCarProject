﻿using OnionCarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionCarBook.Application.Interfaces.CarInterfaces;
public interface ICarRepository
{
    List<Car> GetCarsListWithBrands();
    List<Car> GetLastFiveCarsWithBrands();
}
