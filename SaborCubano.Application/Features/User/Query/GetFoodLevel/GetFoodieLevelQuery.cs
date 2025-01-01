using System;
using SaborCubano.Application.Common.DTOs.AppUser;

namespace SaborCubano.Application.Features.User.Query.GetFoodLevel;

public class GetFoodieLevelQuery : IRequest<ResponseGetFoodieLevel>
{
    public string Id {get; set;} = null!;
}
