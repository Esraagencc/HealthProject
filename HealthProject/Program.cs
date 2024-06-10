using Health.BLL.Abstract;
using Health.BLL.Concrete;
using Health.DAL.Abstract;
using Health.DAL.Concrete.EfCore;
using Health.DAL.Concrete.EFCore;
using HealthProject.Mapping;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddAutoMapper(typeof(MapProfile));

builder.Services.AddDbContext<DataContext>();

builder.Services.AddScoped<IDoctorDal, EfCoreDoctorDal>();
builder.Services.AddScoped<IMailBoxDal, EfMailBoxDal>();
builder.Services.AddScoped<IBranchDal, EfCoreBranchDal>();


builder.Services.AddScoped<IDoctorService, DoctorManager>();
builder.Services.AddScoped<IMailBoxService, MailBoxManager>();
builder.Services.AddScoped<IBranchService, BranchManager>();






var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
