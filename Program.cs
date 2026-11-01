
using System.Text;
using System.Collections.Generic;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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

static string GenerateSalesSummary(Dictionary<string, decimal> fileSales)
{
    StringBuilder sb = new StringBuilder();
    decimal totalSales = 0;

    foreach (var sale in fileSales.Values)
    {
        totalSales += sale;
    }

    sb.AppendLine("Sales Summary");
    sb.AppendLine("----------------------------");
    sb.AppendLine($" Total Sales: {totalSales:C}");
    sb.AppendLine();
    sb.AppendLine(" Details:");
    foreach (var entry in fileSales)
    {
        sb.AppendLine($"  {entry.Key}: {entry.Value:C}");
    }

    return sb.ToString();
}