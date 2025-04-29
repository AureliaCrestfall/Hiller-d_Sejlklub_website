using Hillerød_Sejlklub_website.Repository;
using Hillerød_Sejlklub_website.Service;

namespace Hillerød_Sejlklub_website
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddSingleton<IMemberRepo,MemberRepo>();
            builder.Services.AddSingleton<MemberService>();
            builder.Services.AddSingleton<IBlogRepo, BlogRepo>();
            builder.Services.AddSingleton<BlogService>();
            builder.Services.AddSingleton<IEventRepo, EventRepo>();
            builder.Services.AddSingleton<EventService>();
            builder.Services.AddSingleton<IBoatRepo, BoatRepo>();
            builder.Services.AddSingleton<BoatService>();
            // Add services to the container.
            builder.Services.AddRazorPages();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapRazorPages();

            app.Run();
        }
    }
}
