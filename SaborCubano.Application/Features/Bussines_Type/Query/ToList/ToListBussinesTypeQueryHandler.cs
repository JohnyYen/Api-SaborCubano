using System;
using api.Models;
using SaborCubano.Application.Common.Abstractions.Queries;
using SaborCubano.Application.Common.DTOs.Bussines_Type;
using SaborCubano.Application.Common.Mappers;
using SaborCubano.Application.Interfaces;

namespace SaborCubano.Application.Features.Bussines_Type.Query.ToList;

public class ToListBussinesTypeQueryHandler(IBussinesRepository repo, BussinesTypeMapper mapper)
:ToListEntityQueryHandler<BussinesType, ToListBussinesTypeQuery>(repo, mapper)
{

}
