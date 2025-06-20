﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionCarBook.Application.Features.CQRS.Results.CarResult;
public class GetLast5CarsWithBrandQueryResult
{
    public int CarId { get; set; }
    public int BrandId { get; set; }
    public string BrandName { get; set; }

    // public Brand Brand { get; set; }
    public string Model { get; set; }
    public string CoverImageuRL { get; set; }
    public int Km { get; set; }
    public string Transmission { get; set; }
    public byte Seat { get; set; }
    public byte Luggage { get; set; }
    public string Fuel { get; set; }
    public string BigImageUrl { get; set; }
}
