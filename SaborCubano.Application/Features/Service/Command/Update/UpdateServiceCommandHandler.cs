using System;
using SaborCubano.Application.Common.Abstractions.Commands;
using SaborCubano.Application.Common.DTOs.Service;
using SaborCubano.Application.Common.Mappers;
using SaborCubano.Application.Interfaces;

namespace SaborCubano.Application.Features.Service.Command.Update;

public class UpdateServiceCommandHandler(IServiceRepository repo, ServiceMapper mapper)
: UpdateEntityCommandHandler<ServiceModel, UpdateServiceDTO>(repo, mapper)
{

}
