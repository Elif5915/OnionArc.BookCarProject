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
public class UpdateSocialMediaCommandHandler : IRequestHandler<UpdateSocialMediaCommand>
{
    private readonly IRepository<SocialMedia> _repository;

    public UpdateSocialMediaCommandHandler(IRepository<SocialMedia> repository)
    {
        _repository = repository;
    }
    public async Task Handle(UpdateSocialMediaCommand request, CancellationToken cancellationToken)
    {
        var values = await _repository.GetByIdAsync(request.SocialMediaId);
        values.Name = request.Name;
        values.Url = request.Url;
        values.Icon = request.Icon;
        values.SocialMediaId = request.SocialMediaId;
        await _repository.UpdateAsync(values);
    }
}
