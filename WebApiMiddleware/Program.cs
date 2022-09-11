using WebApiMiddleware.Middlewares;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();


// Run Middleware
// Kendisinden sonraki işlemler gerçekleşmez. Kısa devre yaptırır.
// app.Run(async context => Console.WriteLine("Middleware 1."));
// app.Run(async context => Console.WriteLine("Middleware 2."));

// Use Middleware 
// Kendinden sonraki middleware'ı tetikler ve işi bittikten sonra kaldığı yerden devam eder.
app.Use(async (context, next) => {
    Console.WriteLine("Middleware 1 başladı.");
    await next.Invoke();
    Console.WriteLine("Middleware 1 sonlandırılıyor.");
});

 //Custom Middleware Example 
 app.UseHello();

// app.Run(
//     async context => { Console.WriteLine("Middleware 2 kısa devre yaptırıyor.");
// });

// Map Middleware: Pathe göre middleware oluşturur
app.Map("/example", internalApp => internalApp.Run(async context => {
    Console.WriteLine("Example Middleware tetiklendi.");
    //context içerisindeki response'a mesaj yazar
    context.Response.WriteAsync("Example Middleware tetiklendi.");
}));

//MapWhen ile request'e bağlı olarak her türlü yönlendirme yapılır
app.MapWhen(x => x.Request.Method == "GET", internalApp =>
{
   internalApp.Run(async context => {
        Console.WriteLine("MapWhen ile Middleware Tetiklendi.");
        await context.Response.WriteAsync("MapWhen Middleware tetiklendi.");
   });
});

app.Run();