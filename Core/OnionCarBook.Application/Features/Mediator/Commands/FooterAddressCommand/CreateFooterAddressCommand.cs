﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionCarBook.Application.Features.Mediator.Commands.FooterAddressCommand;
public class CreateFooterAddressCommand : IRequest
{
    //public int FooterAddressId { get; set; }
    public string Description { get; set; }
    public string Address { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
}
