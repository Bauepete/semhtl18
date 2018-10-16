# Docker Seminar 2018
## Erich Mayer, Gerald Köck

1. Microsoft Visual Studio
1. ASP.net Core Web App (MVC)
1. Data Container Class (Teacher)
1. Contract (ITeacherRepository)
1. Persitence (TeacherRepository)
1. Change Startup.cs
```csharp
public void ConfigureServices(IServiceCollection services)
{
      services.AddMvc();
      services.AddSingleton<ITeacherRepository, TeacherRepository>();
  }```
```csharp
public void Configure(IApplicationBuilder app, IHostingEnvironment env, ITeacherRepository repository)
    {
  repository.ReadFromCSV();
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }
        else
        {
            app.UseExceptionHandler("/Home/Error");
        }

        app.UseStaticFiles();

        app.UseMvc(routes =>
        {
            routes.MapRoute(
                name: "default",
                template: "{controller=Home}/{action=Index}/{id?}");
        });
    }```

1. TeacherController.cs

```csharp
private ITeacherRepository teacherRepository;

public TeachersController(ITeacherRepository teacherRepository)
{
  this.teacherRepository = teacherRepository;
}

    // GET: api/values
    [HttpGet]
    public IEnumerable<Teacher> Get()
    {
  return teacherRepository.Teachers;
    }```
