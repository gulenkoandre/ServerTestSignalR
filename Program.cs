using ServerTestSignalR;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(); //подключение сервисов CORS на случай работы с сервером клиентами с разных доменных имен

builder.Services.AddSignalR(); //подключение сервисов SignalR

var app = builder.Build();

app.UseDefaultFiles();

app.UseStaticFiles();

//настройка CORS
app.UseCors(builder => builder.AllowAnyOrigin()); //указываем, что приложение может обрабатывать запросы с любых доменов/адресов.

app.Map("/", async context => await context.Response.WriteAsync("The Server is running !!!"));

app.MapHub<ServerHub>("/str"); //класс ServerHub устанавливаем обработчиком запросов по пути (с постфиксом) "/str"

app.Run();

