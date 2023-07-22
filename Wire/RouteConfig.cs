namespace wire
{
    public class RouteConfig
    {
        public static void ConfigureRoute(IEndpointRouteBuilder routes)
        {
            routes.MapControllerRoute(
                name: "About",
                pattern: "About",
                defaults: new { controller = "Home", action = "About" }
                );
            routes.MapControllerRoute(
                name: "Privacy",
                pattern: "Privacy",
                defaults: new { controller = "Home", action = "Privacy" }
                );
            routes.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
        }
    }
}
