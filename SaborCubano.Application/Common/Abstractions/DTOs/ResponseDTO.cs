using System;
using SaborCubano.Domain;

namespace SaborCubano.Application.Common.Abstractions.DTOs;

public abstract class ResponseDto<TModel> : IResponse, IDto where TModel : BaseEntity
{
    public int Id {get; set;}
}
