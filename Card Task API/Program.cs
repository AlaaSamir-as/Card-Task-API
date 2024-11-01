using ApplicationLayer.IServices;
using ApplicationLayer.Services;
using InfraStructureLayer.DBContext;
using InfraStructureLayer.IRepository;
using InfraStructureLayer.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add AddDbContext && ConnectionString
var ConnectionString = builder.Configuration.GetConnectionString("MyDB");
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(ConnectionString));
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<ICardItemRepository, CardItemRepository>();
builder.Services.AddScoped<ICardItemServices, CardItemServices>();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<ICategoryServices, CategoryServices>();
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
app.UseCors(options => options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
app.UseAuthorization();

app.MapControllers();

app.Run();
