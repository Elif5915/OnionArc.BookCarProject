﻿using OnionCarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionCarBook.Application.Features.Mediator.Results.PricingResult;
public class GetPricingQueryResult
{
    public int PricingId { get; set; }
    public string Name { get; set; }
}
