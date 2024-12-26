using System;
using SaborCubano.Domain;

namespace SaborCubano.Application.Common.Abstractions.DTOs;

public interface ResponseDto<TModel> : IDto where TModel : BaseEntity
{

}
