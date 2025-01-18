using System;

namespace SaborCubano.Application.Common.Abstractions.DTOs;

public class SearchByNameEntityDTO<TModel> : IRequest<TModel>
{
    public string Name {get; set;} = null!;
}
