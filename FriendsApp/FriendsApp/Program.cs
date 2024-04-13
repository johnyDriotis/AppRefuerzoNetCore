var builder = WebApplication.CreateBuilder(args);

// Se agrega servicio para controladores y vistas junto con RazorRuntimeCompilation para cambios en caliente
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Se define pagina de excepcion para ambiente desarrollo
if (app.Environment.IsDevelopment())
{
	app.UseDeveloperExceptionPage();
}

// Permite que nos muestre por defecto los archivos estaticos. toma por defecto el archivo html llamada default.html
app.UseDefaultFiles();

// Habilita el uso de archivos estaticos
app.UseStaticFiles();

// Se agrega la ruta por defecto para la aplicacion.
//app.MapDefaultControllerRoute();

app.Run();