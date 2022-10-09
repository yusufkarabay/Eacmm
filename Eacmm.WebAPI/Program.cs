using Autofac;
using Autofac.Extensions.DependencyInjection;
using Eacmm.Core;
using Eacmm.Core.Configuration;
using Eacmm.Core.Entities.Abstract;
using Eacmm.Core.Repositories;
using Eacmm.Core.Services;
using Eacmm.Repositories;
using Eacmm.Repositories.Repositories;
using Eacmm.Services.Mapping;
using Eacmm.Services.Services;
using Eacmm.WebAPI.Modules;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSwaggerGen(c =>
{
    var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    c.IncludeXmlComments(xmlPath);
});
//**********************************************************************************************************************
builder.Services.AddAutoMapper(typeof(MapProfile));

//************************************************************************************************************************
builder.Services.AddDbContext<EacmmDBContext>(x =>
{
    x.UseSqlServer(builder.Configuration.GetConnectionString("SqlConnection"), option =>
    {

        option.MigrationsAssembly(Assembly.GetAssembly(typeof(EacmmDBContext)).GetName().Name);
    });
});


//**********************************************************************************************************
builder.Services.Configure<CustomTokenOption>(builder.Configuration.GetSection("TokenOption"));
builder.Services.Configure<List<Client>>(builder.Configuration.GetSection("Clients"));
//**********************************************************************************************************


//bu kýsýmda þifrenin tipini belirleyebilirsin. rakam olsun. büyük küçük olsun gibi
//bu kýsmýn detayý identiy kursunda var!!!!
builder.Services.AddIdentity<User, IdentityRole>(options =>
{
    options.User.RequireUniqueEmail=true;
    options.Password.RequireUppercase=true;
    options.Password.RequiredLength=8;
    options.Password.RequireLowercase=true;
}).AddEntityFrameworkStores<EacmmDBContext>().AddDefaultTokenProviders();



builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
builder.Host.ConfigureContainer<ContainerBuilder>(containerbuilder =>
containerbuilder.RegisterModule(new RepoServiceModule()));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseDeveloperExceptionPage();

app.UseAuthorization();

app.MapControllers();

app.Run();
