using System;
using SaborCubano.Application.Common.Abstractions;
using SaborCubano.Domain.Enums;

namespace SaborCubano.Application.Common.DTOs.AppUser;

public class ResponseGetFoodieLevel : IResponse
{
    public double Puntuation {get; set;}
    public FoodieLevel FoodieLevel {get; set;}
}
