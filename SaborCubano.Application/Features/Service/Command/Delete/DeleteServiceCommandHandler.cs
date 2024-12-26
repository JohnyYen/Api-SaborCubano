using System;
using SaborCubano.Application.Common.Abstractions.Commands;
using SaborCubano.Application.Common.DTOs.Service;
using SaborCubano.Application.Common.Mappers;
using SaborCubano.Application.Interfaces;

namespace SaborCubano.Application.Features.Service.Command.Delete;

public class DeleteServiceCommandHandler
(IServiceRepository repo, ServiceMapper mapper)
: DeleteEntityCommandHandler<ServiceModel, DeleteServiceDTO>(repo, mapper)
{

}
