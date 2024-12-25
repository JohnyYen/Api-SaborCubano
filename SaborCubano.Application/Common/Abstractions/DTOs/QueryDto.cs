using System;
using SaborCubano.Domain;

namespace SaborCubano.Application.Common.Abstractions.DTOs;

public abstract class QueryDto<TModel> : IDto where TModel : BaseEntity
{

}
