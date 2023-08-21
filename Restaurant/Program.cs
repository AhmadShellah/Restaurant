using Contracts;
using Contracts.InterFaces;
using Entity;
using Microsoft.EntityFrameworkCore;
using Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString(@"Data Source=DESKTOP-4V00ANF;Initial Catalog=Restaurent;Integrated Security=True;TrustServerCertificate=True")));
builder.Services.AddMemoryCache();


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<IDrinkService,DrinkService>();
builder.Services.AddSingleton<IQRCodeGeneratorByOmar, QRCodeGeneratorByOmarService>();
builder.Services.AddSingleton<IFoodService, FoodService>();
builder.Services.AddTransient<ICocktailService, CocktailService>();
builder.Services.AddScoped<IDesertsService, DesertsService>();

builder.Services.AddAutoMapper(typeof(AutoMapperAPI));

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
