using Microsoft.EntityFrameworkCore;
using TataCliq.Extensions;
using ApplicationLayer;
using DataAccessLayer;
using CoreModelss;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IProductRepository, ProductRepository>();
var ConnectionStrings = builder.Configuration.GetConnectionString("ProductDB");
builder.Services.AddDbContext<Dotnet2023Context>(options =>
options.UseSqlServer(ConnectionStrings));


// Add services to the container.
builder.Services.ConfigureCors();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


app.UseCors("CorsPolicy");


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
