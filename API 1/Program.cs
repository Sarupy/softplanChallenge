var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
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

app.MapGet("/taxaJuros", (HttpContext context) =>
{
    context.Response.Headers.Add("Access-Control-Allow-Origin", "*"); //habilitar CORS para testes de integração

    return 0.01;
})
.WithName("taxaJuros");

app.Run();
