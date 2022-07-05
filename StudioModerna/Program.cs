using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

using Plugins.Data.InMemory;
using StudioModerna;
using UseCases.DataPluginInterfaces;
using UseCases.Interfaces;
using UseCases.BringInJobs;
using UseCases.Generic;
using UseCases.Assignments;
using UseCases.OnesWhoSupply;
using UseCases.Clients;
using UseCases.WorkOrders;
using UseCases.OutputDatas;
using Plugins.Data.SQL;
using Microsoft.EntityFrameworkCore;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddDbContext<CompanyContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

//dependency injection for in memory data store
builder.Services.AddScoped<ISupplierRepository, SupplierRepository>();
builder.Services.AddScoped<IInputDataRepository, InputDataRepository>();
builder.Services.AddScoped<IAssignmentRepository, AssignmentRepository>(); 
builder.Services.AddScoped<IClientRepository, ClientRepository>();
builder.Services.AddScoped<IWorkOrderRepository, WorkOrderRepository>();
builder.Services.AddScoped<IOutputDataRepository, OutputDataRepository>();

//dependency injection for use cases and repos

builder.Services.AddTransient<IAddSuplier, AddSupplier>();
builder.Services.AddTransient<IDeleteSupplier, DeleteSupplier>();
builder.Services.AddTransient<IEditSupplier, EditSupplier>();
builder.Services.AddTransient<IGetSupplierById, GetSupplierById>();
builder.Services.AddTransient<IViewAllSuppliers, ViewAllSuppliers>();

builder.Services.AddTransient<IAddInputData, AddInputData>();
builder.Services.AddTransient<IDeleteInputData, DeleteInputData>();
builder.Services.AddTransient<IEditInputData, EditInputData>();
builder.Services.AddTransient<IGetInputDataById, GetInputDataById>(); 
builder.Services.AddTransient<IViewAllInputData, ViewAllInputData>();

builder.Services.AddTransient<IMakeBooleanToYesNo, MakeBooleanToYesNo>();

builder.Services.AddTransient<IEditAssignment, EditAssignment>();
builder.Services.AddTransient<IGetAssignmentById, GetAssignmentById>();
builder.Services.AddTransient<IDeleteAssignment, DeleteAssignment>();
builder.Services.AddTransient<IViewAllAssignments, ViewAllAssignments>();
builder.Services.AddTransient<IAddAssignment, AddAssignment>();

builder.Services.AddTransient<IAddClient, AddClient>();
builder.Services.AddTransient<IDeleteClient, DeleteClient>();
builder.Services.AddTransient<IEditClient, EditClient>();
builder.Services.AddTransient<IGetClientById, GetClientById>();
builder.Services.AddTransient<IViewAllClients, ViewAllClients>();

builder.Services.AddTransient<IAddWorkOrder, AddWorkOrder>();
builder.Services.AddTransient<IDeleteWorkOrder, DeleteWorkOrder>();
builder.Services.AddTransient<IEditWorkOrder, EditWorkOrder>();
builder.Services.AddTransient<IGetWorkOrderById, GetWorkOrderById>(); 
builder.Services.AddTransient<IViewAllWorkOrders, ViewAllWorkOrders>();
builder.Services.AddTransient<IViewAllNotDoneWorkOrders, ViewAllNotDoneWorkOrders>();

builder.Services.AddTransient<IAddOutputData, AddOutputData>();
builder.Services.AddTransient<IDeleteOutputData, DeleteOutputData>();
builder.Services.AddTransient<IEditOutputData, EditOutputData>();
builder.Services.AddTransient<IGetOutputDataById, GetOutputDataById>();
builder.Services.AddTransient<IViewAllOutputData, ViewAllOutputData>();
builder.Services.AddTransient<IGetAllOutputDataNotDone, GetAllOutputDataNotDone>();

await builder.Build().RunAsync();
