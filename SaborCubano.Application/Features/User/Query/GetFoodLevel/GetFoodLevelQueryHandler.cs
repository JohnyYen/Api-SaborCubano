using System;
using api.Models;
using SaborCubano.Application.Common.DTOs.AppUser;
using SaborCubano.Application.Interfaces;
using SaborCubano.Domain.Enums;

namespace SaborCubano.Application.Features.User.Query.GetFoodLevel;

public class GetFoodLevelQueryHandler(IUserRepository repo)
:IRequestHandler<GetFoodieLevelQuery, ResponseGetFoodieLevel>
{
    private readonly IUserRepository _repo = repo;

    public async Task<ResponseGetFoodieLevel> Handle(GetFoodieLevelQuery request, CancellationToken cancellationToken)
    {
        var user = await _repo.FindByIdAsync(request.Id);

        if(user is null)
            throw new Exception("APP_USER_NOT_FOUND");

        var appUser = (AppUser)user;
        //var activities = appUser.Activities!.ToList().FindAll(a => a.Id_User == appUser.Id);

        double sumTotal = 0;
        if(appUser.Activities != null)
            foreach (var activity in appUser.Activities)
                sumTotal += activity.Score;
            
        
        FoodieLevel foodieLevel;

        if(sumTotal < 100)
            foodieLevel = FoodieLevel.Basico;
        else if(sumTotal >= 100 && sumTotal < 200)
            foodieLevel = FoodieLevel.Medio;
        else if(sumTotal >= 200 && sumTotal < 300)
            foodieLevel = FoodieLevel.Alto;
        else if(sumTotal >= 300 && sumTotal < 400)
            foodieLevel = FoodieLevel.Experto;
        else
            foodieLevel = FoodieLevel.Comelon;


        return new ResponseGetFoodieLevel{
            Puntuation = sumTotal,
            FoodieLevel = foodieLevel
        };
    }
}
