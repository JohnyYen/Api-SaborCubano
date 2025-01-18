using System;
using api.Models;
using SaborCubano.Application.Common.Abstractions.Queries;
using SaborCubano.Application.Interfaces;

namespace SaborCubano.Application.Features.Bussines_Type.Query.GetByIdModel;

public class GetByIdBussinesTypeQueryHandler(IBussinesRepository repo)
: GetByIdEntityModelQueryHandler<BussinesType, GetByIdBussinesTypeQuery>(repo)
{

}
