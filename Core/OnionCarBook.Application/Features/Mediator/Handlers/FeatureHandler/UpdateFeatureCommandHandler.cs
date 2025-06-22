using MediatR;
using OnionCarBook.Application.Features.Mediator.Commands.FeatureCommand;
using OnionCarBook.Application.Interfaces;
using OnionCarBook.Domain.Entities;

namespace OnionCarBook.Application.Features.Mediator.Handlers.FeatureHandler;
public class UpdateFeatureCommandHandler : IRequestHandler<UpdateFeatureCommand>
{
    private readonly IRepository<Feature> _repository;

    public UpdateFeatureCommandHandler(IRepository<Feature> repository)
    {
        _repository = repository;
    }

    public async Task Handle(UpdateFeatureCommand request, CancellationToken cancellationToken)
    {
        var values = await _repository.GetByIdAsync(request.FeatureId);
        values.Name = request.Name;
        await _repository.UpdateAsync(values);
    }
}
