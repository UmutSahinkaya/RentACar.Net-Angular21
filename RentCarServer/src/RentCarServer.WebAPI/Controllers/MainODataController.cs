using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using Microsoft.OData.Edm;
using Microsoft.OData.ModelBuilder;
using RentCarServer.Application.Branches;
using RentCarServer.Application.Categories;
using RentCarServer.Application.Customers;
using RentCarServer.Application.Extras;
using RentCarServer.Application.ProtectionPackages;
using RentCarServer.Application.Roles;
using RentCarServer.Application.Users;
using RentCarServer.Application.Vehicles;
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
        _ = builder.EntitySet<CategoryDto>("categories");
        _ = builder.EntitySet<ProtectionPackageDto>("protection-packages");
        _ = builder.EntitySet<RoleDto>("roles");
        _ = builder.EntitySet<UserDto>("users");
        _ = builder.EntitySet<ExtraDto>("extras");
        _ = builder.EntitySet<VehicleDto>("vehicles");
        _ = builder.EntitySet<CustomerDto>("customers");
        return builder.GetEdmModel();
    }

    [HttpGet("branches")]
    public async Task<IQueryable<BranchDto>> Branches(ISender sender, CancellationToken cancellationToken = default)
        => await sender.Send(new BranchGetAllQuery(), cancellationToken);


    [HttpGet("categories")]
    public async Task<IQueryable<CategoryDto>> Categories(ISender sender, CancellationToken cancellationToken = default)
        => await sender.Send(new CategoryGetAllQuery(), cancellationToken);


    [HttpGet("roles")]
    public async Task<IQueryable<RoleDto>> Roles(ISender sender, CancellationToken cancellationToken = default)
        => await sender.Send(new RoleGetAllQuery(), cancellationToken);


    [HttpGet("users")]
    public async Task<IQueryable<UserDto>> Users(ISender sender, CancellationToken cancellationToken = default)
        => await sender.Send(new UserGetAllQuery(), cancellationToken);


    [HttpGet("protection-packages")]
    public IQueryable<ProtectionPackageDto> ProtectionPackages(ISender sender, CancellationToken cancellationToken = default)
        => sender.Send(new ProtectionPackageGetAllQuery(), cancellationToken).Result;

    [HttpGet("extras")]
    public IQueryable<ExtraDto> Extras(ISender sender, CancellationToken cancellationToken = default)
       => sender.Send(new ExtraGetAllQuery(), cancellationToken).Result;

    [HttpGet("vehicles")]
    public IQueryable<VehicleDto> Vehicles(ISender sender, CancellationToken cancellationToken = default)
        => sender.Send(new VehicleGetAllQuery(), cancellationToken).Result;

    [HttpGet("customers")]
    public IQueryable<CustomerDto> Customers(ISender sender, CancellationToken cancellationToken = default)
        => sender.Send(new CustomerGetAllQuery(), cancellationToken).Result;
}
