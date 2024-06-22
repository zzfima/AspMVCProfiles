using Microsoft.EntityFrameworkCore;
using System.Configuration;
using WebApplicationProfiles.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

#region add databases
builder.Services.AddDbContext<ProfileDbContext>(options => options.UseSqlite(builder.Configuration.GetConnectionString("dhpDb")));
builder.Services.AddDbContext<AlignerDbContext>(options => options.UseSqlite(builder.Configuration.GetConnectionString("dhpDb")));
#endregion

//add swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

//while development ensure db scheme created while app started
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
using var scope = app.Services.CreateScope();

#region profiles api
var dbProfile = scope.ServiceProvider.GetRequiredService<ProfileDbContext>();
dbProfile.Database.EnsureCreated();
app.MapGet("/DCP/profiles", () => dbProfile.Profiles.ToList()).WithTags("GET");
#endregion

#region aligners api
var dbAligner = scope.ServiceProvider.GetRequiredService<AlignerDbContext>();
dbAligner.Database.EnsureCreated();
app.MapGet("/DCP/aligners", () => dbAligner.Aligners.ToList()).WithTags("GET");
#endregion

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
