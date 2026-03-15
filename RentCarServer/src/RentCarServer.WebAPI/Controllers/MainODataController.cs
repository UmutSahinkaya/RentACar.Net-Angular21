using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using Microsoft.OData.Edm;
using Microsoft.OData.ModelBuilder;
using RentCarServer.Application.Branches;
using RentCarServer.Application.Roles;
using TS.MediatR;

namespace RentCarServer.WebAPI.Controllers;

[Route("odata")]
[ApiController]
[EnableQuery]
public class MainODataController : ODataController
{
    public static IEdmModel GetEdmModel()
    {
        ODataConventionModelBuilder builder = new();
        _ = builder.EnableLowerCamelCase();
        _ = builder.EntitySet<BranchDto>("branches");
        _ = builder.EntitySet<RoleDto>("roles");
        return builder.GetEdmModel();
    }

    [HttpGet("branches")]
    public async Task<IQueryable<BranchDto>> Branches(ISender sender, CancellationToken cancellationToken = default)
        => await sender.Send(new BranchGetAllQuery(), cancellationToken);

    [HttpGet("roles")]
    public async Task<IQueryable<RoleDto>> Roles(ISender sender, CancellationToken cancellationToken = default)
        => await sender.Send(new RoleGetAllQuery(), cancellationToken);
}
