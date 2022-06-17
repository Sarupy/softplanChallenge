using API_2;
using System.Globalization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHttpClient();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/calculaJuros", async (float valorinicial, int meses) =>
{
    var _mathService = new MathService();
    var _httpClient = new HttpClient();
    var response = await _httpClient.GetStringAsync("https://localhost:8001/taxajuros");
    var juros = float.Parse(response, CultureInfo.InvariantCulture);;

    return _mathService.CalcularJurosCompostos(valorinicial,juros, meses).ToString("N2");
})
.WithName("calculaJuros");

app.MapGet("/showMeTheCode", () =>
{
    return "https://github.com/sarupy/softplanChallenge";
})
.WithName("showMeTheCode");

app.Run();
