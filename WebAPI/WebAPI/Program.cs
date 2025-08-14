//var builder = WebApplication.CreateBuilder(args);
//
//// Add services to the container.
//
//builder.Services.AddControllers();
//// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();
//builder.Services.AddAWSLambdaHosting(LambdaEventSource.RestApi);
//
//
//var app = builder.Build();
//
//// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}
////app.ADDAddSpaStaticFiles(configuration => { configuration.RootPath = "ClientApp/dist"; });
//app.UseHttpsRedirection();
//
//app.UseAuthorization();
//
//app.MapControllers();
//
//app.Run();
using WebAPI;

public class Program
{
    public static void Main(string[] args)
    {
        CreateHostBuilder(args).Build().Run();
    }

    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>(); // This line integrates the Startup class

            });
}