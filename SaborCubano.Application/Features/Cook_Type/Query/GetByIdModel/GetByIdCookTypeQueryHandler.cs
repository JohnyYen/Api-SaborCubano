using System;
using SaborCubano.Application.Common.Abstractions.Queries;
using SaborCubano.Application.Interfaces;

namespace SaborCubano.Application.Features.Cook_Type.Query.GetByIdModel;

public class GetByIdCookTypeQueryHandler(ICookTypeRepository repo)
: GetByIdEntityModelQueryHandler<CookTypeModel, GetByIdCookTypeQuery>(repo)
{

}
