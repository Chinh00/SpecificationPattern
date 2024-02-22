using Microsoft.EntityFrameworkCore.Infrastructure;
namespace SpecificationPattern.Infrastructure.Data;

public interface IDbFacadeResolver
{
    DatabaseFacade Database { get; }
}