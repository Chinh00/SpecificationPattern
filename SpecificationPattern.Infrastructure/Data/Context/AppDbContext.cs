using Microsoft.EntityFrameworkCore;

namespace SpecificationPattern.Infrastructure.Data.Context;

public class AppDbContext(DbContextOptions options) : DbContext(options), IDbFacadeResolver;