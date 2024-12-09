using System;

namespace SaborCubano.Application.Common.Abstractions.DTOs;

public abstract class CommandGetByIdDTO(int id)
{
    public int Id { get; set;} = id;
}
