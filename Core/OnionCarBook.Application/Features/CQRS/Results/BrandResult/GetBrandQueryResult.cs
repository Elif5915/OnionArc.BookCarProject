﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionCarBook.Application.Features.CQRS.Results.BrandResult;
public class GetBrandQueryResult
{
    public int BrandId { get; set; }
    public string Name { get; set; }
}
