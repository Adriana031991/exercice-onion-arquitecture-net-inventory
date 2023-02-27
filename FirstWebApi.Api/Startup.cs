using FirstWebApi.InverisionControl;

namespace FirstWebApi.Api
{
	public static class Startup
	{
		public static WebApplication InitializeApp(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);
			ConfigureServices(builder);
			var app = builder.Build();
			Configure(app);
			return app;
		}


		private static void ConfigureServices(WebApplicationBuilder builder) {
			builder.Services.AddAuthorization();
			builder.Services.AddFirstWebApiDependencies(builder.Configuration);

			// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
			builder.Services.AddControllers();
			builder.Services.AddEndpointsApiExplorer();
			builder.Services.AddSwaggerGen();
		}

		private static void Configure(WebApplication app)
		{
			// Configure the HTTP request pipeline.
			if (app.Environment.IsDevelopment())
			{
				app.UseSwagger();
				app.UseSwaggerUI();
			}

			app.UseHttpsRedirection();

			app.UseAuthorization();

		}
	}
}
