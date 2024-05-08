using Cotation.Controllers.Cotation;
using Cotation.Data;
using Cotation.Repositories;
using Cotation.Services.Cotation.Delete;
using Cotation.Services.Cotation.Get;
using Cotation.Services.Cotation.Register;
using Cotation.Services.Cotation.Update;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<ICotationRepository, CotationRepository>();
builder.Services.AddScoped<RegisterCotationService>();
builder.Services.AddScoped<ValidatorRegisterCotation>();
builder.Services.AddScoped<UpdateCotationService>();
builder.Services.AddScoped<GetByIdCotationService>();
builder.Services.AddScoped<GetCotationService>();
builder.Services.AddScoped<DeleteCotationService>();


builder.Services.AddDbContext<AppDbContext>(options => {
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment()) {
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
