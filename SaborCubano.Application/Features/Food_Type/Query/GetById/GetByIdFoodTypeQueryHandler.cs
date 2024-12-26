using System;
using SaborCubano.Application.Common.Abstractions.Queries;
using SaborCubano.Application.Common.Mappers;
using SaborCubano.Application.Interfaces;

namespace SaborCubano.Application.Features.Food_Type.Query.GetById;

public class GetByIdFoodTypeQueryHandler
(IFoodTypesRepository repo, FoodTypeMapper mapper)
: GetByIdEntityQueryHandler<FoodTypeModel, GetByIdFoodTypeQuery>(repo, mapper)
{

}
