using FirstWebApi.InverisionControl;

namespace FirstWebApi.Api
{
	public class Program
	{
		public static void Main(string[] args)
		{

			var app = Startup.InitializeApp(args);
			//var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.
			//builder.Services.AddAuthorization();

			//// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
			//builder.Services.AddFirstWebApiDependencies(builder.Configuration);
			//builder.Services.AddEndpointsApiExplorer();
			//builder.Services.AddSwaggerGen();

			//var app = builder.Build();

			//// Configure the HTTP request pipeline.
			//if (app.Environment.IsDevelopment())
			//{
			//	app.UseSwagger();
			//	app.UseSwaggerUI();
			//}

			//app.UseHttpsRedirection();

			//app.UseAuthorization();

			app.Run();
		}
	}
}