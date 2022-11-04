namespace WebApplication1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            //Add services to the container
            builder.Services.AddControllersWithViews();
            builder.Services.AddMvc();
            builder.Services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(20);
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });

            var app = builder.Build();
            
            //Configure the HTTP request pipeline
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                //The default HSTS value is 30 days, see https://aka.ms/aspnetcore-hsts
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();  //HTML i wwwroot
            app.UseSession();
            app.UseRouting();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
       /*         endpoints.MapControllerRoute(
                    name: "PrefLangCustomRoute",
                    pattern: "PreferdLanguage",
                    defaults: new { controller = "", action = "" }
                );
       */
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}"
                );
            });

            app.Run();
        }
    }
}