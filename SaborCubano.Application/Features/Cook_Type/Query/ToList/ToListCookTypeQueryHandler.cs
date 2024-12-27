using System;
using SaborCubano.Application.Common.Abstractions.Queries;
using SaborCubano.Application.Common.Mappers;
using SaborCubano.Application.Interfaces;

namespace SaborCubano.Application.Features.Cook_Type.Query.ToList;

public class ToListCookTypeQueryHandler(ICookTypeRepository repo, CookTypeMapper mapper)
: ToListEntityQueryHandler<CookTypeModel, ToListCookTypeQuery>(repo, mapper)
{

}
