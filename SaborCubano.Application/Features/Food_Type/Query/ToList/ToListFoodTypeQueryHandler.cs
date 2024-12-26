using System;
using SaborCubano.Application.Common.Abstractions.Queries;
using SaborCubano.Application.Common.Mappers;
using SaborCubano.Application.Interfaces;

namespace SaborCubano.Application.Features.Food_Type.Query.ToList;

public class ToListFoodTypeQueryHandler
(IFoodTypesRepository repo, FoodTypeMapper mapper)
:ToListEntityQueryHandler<FoodTypeModel, ToListFoodTypeQuery>(repo, mapper)
{

}
