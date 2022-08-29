using Eacmm.Core.Repositories;
using Eacmm.Core;
using Eacmm.Repositories;
using Eacmm.Repositories.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;

using System.Reflection;
using Eacmm.Services.Mapping;
using Eacmm.Core.Services;
using Eacmm.Services.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//**********************************************************************************************************************
builder.Services.AddScoped<IUnitofWork, UnitofWork>();
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddAutoMapper(typeof(MapProfile));

builder.Services.AddScoped<ICabinetRepository, CabinetRepository>();
builder.Services.AddScoped<ICabinetService, CabinetService>();

builder.Services.AddScoped<IContractRepository, ContractRepository>();
builder.Services.AddScoped<IContractService, ContractService>();

builder.Services.AddScoped<IDepartmentRepository, DepartmentRepository>();
builder.Services.AddScoped<IDepartmentService, DepartmentService>();

builder.Services.AddScoped<IDrawerRepository, DrawerRepository>();
builder.Services.AddScoped<IDrawerService, DrawerService>();

builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
builder.Services.AddScoped<IEmployeeService, EmployeeService>();

builder.Services.AddScoped<IEntranceCardRepository, EntranceCardRepository>();
builder.Services.AddScoped<IEntranceCardService, EntranceCardService>();

builder.Services.AddScoped<IFuelRepository, FuelRepository>();
builder.Services.AddScoped<IFuelService, FuelService>();

builder.Services.AddScoped<IGeneratorUsedTimeRepository, GeneratorUsedTimeRepository>();
builder.Services.AddScoped<IGeneratorUsedTimeService, GeneratorUsedTimeService>();

builder.Services.AddScoped<IGuestCardRepository, GuestCardRepository>();
builder.Services.AddScoped<IGuestCardService, GuestCarService>();

builder.Services.AddScoped<IHeadsetRepository, HeadSetRepository>();
builder.Services.AddScoped<IHeadSetService, HeadsetService>();

builder.Services.AddScoped<IInventoryRepository, InventoryRepository>();
builder.Services.AddScoped<IInventoryService, InventoryService>();

builder.Services.AddScoped<IMaintenanceRepository, MaintenanceRepository>();
builder.Services.AddScoped<IMaintenanceService, MaintenanceService>();

builder.Services.AddScoped<IPasswordNoteRepository, PasswordNoteRepository>();
builder.Services.AddScoped<IPasswordNoteService, PasswordNoteService>();

builder.Services.AddScoped<IPhoneDirectoryRepository, PhoneDirectoryRepository>();
builder.Services.AddScoped<IPhoneDirectoryService, PhoneDirectoryService>();

builder.Services.AddScoped<IRequestRepository, RequestRepository>();
builder.Services.AddScoped<IRequestService, RequestService>();

builder.Services.AddScoped<ISentryDoneRepository, SentryDoneRepository>();
builder.Services.AddScoped<ISentryDoneService, SentryDoneService>();

builder.Services.AddScoped<ISentryToDoRepository, SentryToDoRepository>();
builder.Services.AddScoped<ISentryToDoService, SentryToDoService>();

//************************************************************************************************************************
builder.Services.AddDbContext<EacmmDbContext>(x =>
{
    x.UseSqlServer(builder.Configuration.GetConnectionString("SqlConnection"), option =>
    {
       
        option.MigrationsAssembly(Assembly.GetAssembly(typeof(EacmmDbContext)).GetName().Name);
    });
}); var app = builder.Build();

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
