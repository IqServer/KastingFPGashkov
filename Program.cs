using Microsoft.EntityFrameworkCore;
using Serilog;
using Services;
using testnet;



var builder = WebApplication.CreateBuilder(args);

IHostBuilder hostBuilder = builder.Host.UseSerilog((ctx, lc) => lc
    .WriteTo.Console()
    .Enrich.WithProperty("Firma", "fir2")
    .WriteTo.Seq("http://localhost:5341")
    );
// Add services to the container.

builder.Services.AddCors(options => options.AddPolicy("AllowAll",
    builder =>
    {
        builder
            .AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader();
    }));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<StudentService>();
builder.Services.AddScoped<UserService>();
builder.Services.AddScoped<MemberService>();
builder.Services.AddScoped<SeasonService>();
builder.Services.AddScoped<FirmService>();
builder.Services.AddScoped<JobService>();
builder.Services.AddScoped<KuratorService>();
ConfigurationManager configuration = builder.Configuration;

builder.Services.AddDbContext<DataContext>(opt =>
{
    opt.UseNpgsql(configuration.GetConnectionString("Db"));
}
);

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI();

app.UseRouting();
app.UseCors("AllowAll");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
