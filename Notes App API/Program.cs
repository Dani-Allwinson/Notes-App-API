using Notes.Repository.Interface;
using Notes.Repository.ProcedureValidation;
using Notes_App_API.Dependencies;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.ConfigureDBContext(builder.Configuration);
builder.Services.ConfigureSwagger();
builder.Services.ConfigureServices();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
app.ConfigureSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
app.UseCors("CorsPolicy");

app.Run();
