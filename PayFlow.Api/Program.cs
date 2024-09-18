using PayFlow.Infra.Repository;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();

var accessToken = builder.Configuration["MercadoPagoToken:AccessToken"];

builder.Services.AddScoped<MercadoPagoRepository>(sp => new MercadoPagoRepository(accessToken));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();
app.Run();

