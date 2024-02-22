using SpecificationPattern.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCore(builder.Configuration);


var app = builder.Build();

app.UseCore(app.Environment);


app.Run();

