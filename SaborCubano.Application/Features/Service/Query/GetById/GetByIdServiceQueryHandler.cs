using System;
using SaborCubano.Application.Common.Abstractions.Queries;
using SaborCubano.Application.Common.Mappers;
using SaborCubano.Application.Interfaces;

namespace SaborCubano.Application.Features.Service.Query.GetById;

public class GetByIdServiceQueryHandler
(IServiceRepository repo, ServiceMapper mapper)
: GetByIdEntityQueryHandler<ServiceModel, GetByIdServiceQuery>(repo, mapper)
{

}
