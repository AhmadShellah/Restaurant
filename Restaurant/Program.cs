using Contracts;
using Contracts.InterFaces;
using Entity;
using Microsoft.EntityFrameworkCore;
using Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<IDrinkService,DrinkService>();
builder.Services.AddTransient<IQRCodeGeneratorByOmar, QRCodeGeneratorByOmarService>();
builder.Services.AddTransient<IFoodService, FoodService>();
builder.Services.AddTransient<ICocktailService, CocktailService>();
builder.Services.AddScoped<IDesertsService, DesertsService>();

builder.Services.AddAutoMapper(typeof(AutoMapperAPI));
builder.Services.AddDbContext<ApplicationDbContext>(x => x.UseSqlServer(@"Data Source=DESKTOP-DLTH8DC;Initial Catalog=Restaurent;Integrated Security=True;TrustServerCertificate=True"));

var app = builder.Build();


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
