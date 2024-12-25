using System;
using Microsoft.EntityFrameworkCore.Metadata;
using SaborCubano.Domain;

namespace SaborCubano.Application.Common.Abstractions.DTOs;

public class UpdateEntityCommandDto<TModel>:IRequest<QueryDto<TModel>?>, IDto
where TModel : BaseEntity
{

}
