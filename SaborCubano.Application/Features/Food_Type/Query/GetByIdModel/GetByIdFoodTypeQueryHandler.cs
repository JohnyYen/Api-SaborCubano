using System;
using SaborCubano.Application.Common.Abstractions.Queries;
using SaborCubano.Application.Interfaces;

namespace SaborCubano.Application.Features.Food_Type.Query.GetByIdModel;

public class GetByIdFoodTypeQueryHandler(IFoodTypesRepository repo)
: GetByIdEntityModelQueryHandler<FoodTypeModel, GetByIdFoodTypeQuery>(repo)
{

}
