﻿using ObjCRuntime;
using UIKit;

namespace Tic_tac_toe_Projekt._Jens_og_Kasper;

public class Program
{
	// This is the main entry point of the application.
	static void Main(string[] args)
	{
		// if you want to use a different Application Delegate class from "AppDelegate"
		// you can specify it here.
		UIApplication.Main(args, null, typeof(AppDelegate));
	}
}
