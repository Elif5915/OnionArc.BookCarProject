using OnionCarBook.Application.Features.CQRS.Results.AboutResult;
using OnionCarBook.Application.Interfaces;
using OnionCarBook.Domain.Entities;

namespace OnionCarBook.Application.Features.CQRS.Handlers.AboutHandlers;
public class GetAboutQueryHandler
{
    private readonly IRepository<About> _repository;

    public GetAboutQueryHandler(IRepository<About> repository)
    {
        _repository = repository;
    }
    public async Task<List<GetAboutQueryResult>> Handle()
    {
        var values = await _repository.GetAllAsync();
        return values.Select(x => new GetAboutQueryResult
        {
            AboutId = x.AboutId,
            Title = x.Title,
            Description = x.Description,
            ImageUrl = x.ImageUrl
        }).ToList();
    }
}

