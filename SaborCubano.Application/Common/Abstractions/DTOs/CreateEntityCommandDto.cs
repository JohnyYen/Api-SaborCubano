using System;
using Microsoft.EntityFrameworkCore.Metadata;
using SaborCubano.Domain;

namespace SaborCubano.Application.Common.Abstractions.DTOs;

public abstract class CreateEntityCommandDto<TModel> 
: IRequest<ResponseDto<TModel>>, IDto where TModel : BaseEntity
{

}
