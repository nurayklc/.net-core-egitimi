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
// app.Run(async context => Console.WriteLine("Middleware 1."));
// app.Run(async context => Console.WriteLine("Middleware 2."));

// Use Middleware
app.Use(
    async (context, next) => { Console.WriteLine("Middleware 1 başladı.");
await next.Invoke();
Console.WriteLine("Middleware 1 sonlandırılıyor.");
});

app.Run(
    async context => { Console.WriteLine("Middleware 2 kısa devre yaptırıyor.");
});

app.Run();