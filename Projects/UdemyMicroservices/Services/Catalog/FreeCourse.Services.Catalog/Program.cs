using FreeCourse.Services.Catalog.Services;
using FreeCourse.Services.Catalog.Settings;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

#region services

//ICategoryServisle karsılastıgın zaman git Catgory servisten nesne örneği getir bana

builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<ICourseService, CourseService>();

builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddControllers();

#region !!!
// herhangi bir class ctor unda ıoptions geerek kullanabilirim
/* herhangi bir class ctor unda bu interface ile karsılastıgında git degerini al valuesını geri dondur
 * artık IDatabaseSettings bunu cagırdıgımda bana dolu bir databasesettings verecek
 */
#endregion
// database settings
builder.Services.Configure<DatabaseSettings>(builder.Configuration.GetSection("DatabaseSettings"));

builder.Services.AddSingleton<IDatabaseSettings>(sp =>
{
    return sp.GetRequiredService<IOptions<DatabaseSettings>>().Value;
});
#endregion


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

