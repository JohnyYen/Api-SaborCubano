using System;

namespace SaborCubano.Domain.Commons;

public interface IModel
{
    int Id {get; set;}
    bool Active {get; set;}
}
