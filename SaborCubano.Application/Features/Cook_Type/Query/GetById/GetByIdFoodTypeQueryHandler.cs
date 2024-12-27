using System;
using SaborCubano.Application.Common.Abstractions.Queries;
using SaborCubano.Application.Common.Mappers;
using SaborCubano.Application.Features.Cook_Type.Query.GetById;
using SaborCubano.Application.Interfaces;

namespace SaborCubano.Application.Features.Cook_Type.Query.ToList;

public class GetByIdFoodTypeQueryHandler(ICookTypeRepository repo, CookTypeMapper mapper)
: GetByIdEntityQueryHandler<CookTypeModel, GetByIdCookTypeQuery>(repo, mapper)
{

}
