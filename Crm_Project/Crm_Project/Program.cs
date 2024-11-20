
using Crm.Config;
using System.Text.Json.Serialization;

namespace Crm_Project
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

          

            builder.Services.AddControllers();

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            ProjectBotstrapper.Init(builder.Services,builder.Configuration.GetConnectionString("DefaultConnection"));


            //  Cycle Erorr Ef
            builder.Services.AddControllers().AddJsonOptions(options =>
            {
                // add this code to prevent cycles when navigating bettven relation
                options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
            });


            var app = builder.Build();
       
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
