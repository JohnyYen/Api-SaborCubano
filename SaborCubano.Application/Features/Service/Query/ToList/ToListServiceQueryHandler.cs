using System;
using api.Models;
using SaborCubano.Application.Common.Abstractions.Queries;
using SaborCubano.Application.Common.Mappers;
using SaborCubano.Application.Interfaces;

namespace SaborCubano.Application.Features.Service.Query;

public class ToListServiceQueryHandler
(IServiceRepository repo, ServiceMapper mapper)
:ToListEntityQueryHandler<ServiceModel, ToListServiceQuery>(repo, mapper)
{

}
