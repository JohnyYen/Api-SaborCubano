using System;
using SaborCubano.Domain;

namespace SaborCubano.Application.Common.Mappers;

public static class GenericMapper<TModel, TDto>
where TModel : BaseEntity, new()
where TDto : class
{
    public static TModel toModel(this TDto dto){
        var model = new TModel();

        

        return model;
    }
}
