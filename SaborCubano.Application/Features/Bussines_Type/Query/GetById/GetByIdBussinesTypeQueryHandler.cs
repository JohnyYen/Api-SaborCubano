using System;
using api.Models;
using SaborCubano.Application.Common.Abstractions.Queries;
using SaborCubano.Application.Common.Mappers;
using SaborCubano.Application.Interfaces;

namespace SaborCubano.Application.Features.Bussines_Type.Query.GetById;

public class GetByIdBussinesTypeQueryHandler(IBussinesRepository repo, BussinesTypeMapper mapper)
: GetByIdEntityQueryHandler<BussinesType, GetByIdBussinesTypeQuery>(repo, mapper) 
{

}
