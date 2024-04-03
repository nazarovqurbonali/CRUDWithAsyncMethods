using Infrastructure.DataContext;
using Infrastructure.Services;

var builder=WebApplication.CreateBuilder();

builder.Services.AddScoped<IMentorService,MentorService>();
builder.Services.AddScoped<DapperContext>();

builder.Services.AddControllers();
builder.Services.AddSwaggerGen();
builder.Services.AddEndpointsApiExplorer();

var app=builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();
app.Run();