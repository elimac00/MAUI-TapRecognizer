using Microsoft.Extensions.Logging;

namespace VorlageStg1511;


// Hier ist kein Code erforderlich.

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>();
		return builder.Build();
	}
}
