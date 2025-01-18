using System;
using SaborCubano.Application.Common.Abstractions.Queries;
using SaborCubano.Application.Interfaces;

namespace SaborCubano.Application.Features.Service.Query.GetByIdModel;

public class GetByIdServiceQueryHandler(IServiceRepository repo)
: GetByIdEntityModelQueryHandler<ServiceModel, GetByIdServiceQuery>(repo)
{

}
