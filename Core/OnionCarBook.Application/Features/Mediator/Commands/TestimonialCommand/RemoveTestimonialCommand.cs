﻿using MediatR;

namespace OnionCarBook.Application.Features.Mediator.Commands.TestimonialCommand;
public class RemoveTestimonialCommand : IRequest
{
    public int Id { get; set; }

    public RemoveTestimonialCommand(int id)
    {
        Id = id;
    }
}
