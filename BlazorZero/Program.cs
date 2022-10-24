var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMvc().WithRazorPagesRoot("/Pages/Shared");

/* 
// or
builder.Services.AddRazorPages(options => {
    options.RootDirectory = "/Pages/Shared"; // change _Host.cshtml file path
}); 
// or
services.Configure<RazorPagesOptions>(options => options.RootDirectory = "/MyPages");
*/

builder.Services.AddServerSideBlazor();

var app = builder.Build();

app.UseStaticFiles();

app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}/{id?}");
    endpoints.MapRazorPages();
    endpoints.MapBlazorHub();
    endpoints.MapFallbackToPage("/_Host");
});

app.Run(async (context) => {   
    // This method should NOT be executed if handling of the request is already done.            
    await context.Response.WriteAsync("Application was unable to handle this request.");
});

app.Run();
