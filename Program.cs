var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();
builder.Services.AddControllers();  

var app = builder.Build();

if (!app.Environment.IsDevelopment()) {
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

//app.MapGet("/", () => "Hello World!");
app.UseDefaultFiles();
app.UseHttpsRedirection();
app.UseStaticFiles();   
app.UseRouting();
app.UseAuthorization();

app.MapRazorPages();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=App}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "login",
    pattern: "{controller=App}/{action=Login}/{id?}");


app.Run();
