using Microsoft.EntityFrameworkCore;
using System.Globalization;
using trackingapi.Data;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//New instance of the dbcontext will be created per request
builder.Services.AddDbContext<IssueDbContext>(
    o => o.UseSqlServer(builder.Configuration.GetConnectionString("SqlServer"))); //Using sqlserver to set the connection string

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

