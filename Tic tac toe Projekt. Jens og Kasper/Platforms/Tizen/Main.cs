using System;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace Tic_tac_toe_Projekt._Jens_og_Kasper;

class Program : MauiApplication
{
	protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

	static void Main(string[] args)
	{
		var app = new Program();
		app.Run(args);
	}
}
