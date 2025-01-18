using System;
using SaborCubano.Application.Common.Abstractions.Commands;
using SaborCubano.Application.Common.DTOs.Restaurant;
using SaborCubano.Application.Common.Mappers;
using SaborCubano.Application.Features.Bussines_Type.Query.GetByIdModel;
using SaborCubano.Application.Features.Food_Type.Query.GetByIdModel;
using SaborCubano.Application.Features.Service.Query.GetByIdModel;
using SaborCubano.Application.Interfaces;

namespace SaborCubano.Application.Features.Restaurant.Command.Create;

public class CreateRestaurantCommandHandler
(IRestaurantRepository repo, RestaurantMapper mapper, IMediator mediator)
: CreateEntityCommandHandler<RestaurantModel, CreateRestaurantDTO>(repo, mapper)
{
    private IMediator _mediator = mediator;
    public override RestaurantModel AddAtributes(RestaurantModel model, CreateRestaurantDTO dto)
    {
        foreach (int item in dto.Ids_Service)
        { 
            var service = _mediator.Send(new GetByIdServiceQuery{Id = item});
            model.Services.Add(service.Result);
        }
        
        foreach (int item in dto.Ids_FoodType)
        {
            var foodType = _mediator.Send(new GetByIdFoodTypeQuery{Id = item});
            model.FoodTypes.Add(foodType.Result);
        }

        foreach (int item in dto.Ids_BussinesType)
        {
            var bussinesType = _mediator.Send(new GetByIdBussinesTypeQuery{Id = item});
            model.BussinesTypes.Add(bussinesType.Result);
        }

        return model;
    }
}
