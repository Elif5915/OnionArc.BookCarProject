using MediatR;
using OnionCarBook.Application.Features.Mediator.Commands.SocialMediaCommand;
using OnionCarBook.Application.Interfaces;
using OnionCarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionCarBook.Application.Features.Mediator.Handlers.SocialMediaHandler;
public class RemoveSocialMediaCommandHandler : IRequestHandler<RemoveSocialMediaCommand>
{
    private readonly IRepository<SocialMedia> _repository;

    public RemoveSocialMediaCommandHandler(IRepository<SocialMedia> repository)
    {
        this._repository = repository;
    }
    public async Task Handle(RemoveSocialMediaCommand request, CancellationToken cancellationToken)
    {
        var value = await _repository.GetByIdAsync(request.Id);
        await _repository.RemoveAsync(value);
    }
}
