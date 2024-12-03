using System;
using api.Models;

namespace SaborCubano.Application.Features.Service.Query.ToList;

public record ToListServiceQueryRequest() : IRequest<IEnumerable<api.Models.Service>>;
