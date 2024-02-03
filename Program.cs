using ServerTestSignalR;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(); //����������� �������� CORS �� ������ ������ � �������� ��������� � ������ �������� ����

builder.Services.AddSignalR(); //����������� �������� SignalR

var app = builder.Build();

app.UseDefaultFiles();

app.UseStaticFiles();

//��������� CORS
app.UseCors(builder => builder.AllowAnyOrigin()); //���������, ��� ���������� ����� ������������ ������� � ����� �������/�������.

app.Map("/", async context => await context.Response.WriteAsync("The Server is running !!!"));

app.MapHub<ServerHub>("/str"); //����� ServerHub ������������� ������������ �������� �� ���� (� ����������) "/str"

app.Run();

