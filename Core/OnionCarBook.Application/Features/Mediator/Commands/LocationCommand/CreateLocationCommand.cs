using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionCarBook.Application.Features.Mediator.Commands.LocationCommand;
public class CreateLocationCommand : IRequest
{
    //public int LocationId { get; set; }
    public string Name { get; set; }
}
