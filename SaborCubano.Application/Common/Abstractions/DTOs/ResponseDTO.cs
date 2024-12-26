using System;
using SaborCubano.Domain;

namespace SaborCubano.Application.Common.Abstractions.DTOs;

public interface ResponseDto<TModel> : IResponse, IDto where TModel : BaseEntity
{

}
