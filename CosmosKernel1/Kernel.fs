namespace CosmosKernel1

open System

type Kernel() =
   inherit Cosmos.System.Kernel();
   override u.BeforeRun() = 
      Kernel.displayLogo();
      Console.WriteLine("CosmosKernel1 v0.0.0 booted successfully. Type \"shutdown\" to shutdown and \"reboot\" to reboot.");
   override u.Run() =
      //u.Init();
      Console.Write(">");
      let input = Console.ReadLine();
      Console.Write("Text typed: ");
      Console.WriteLine(input);
      if (input = "shutdown") then Cosmos.System.Power.Shutdown();
      elif (input = "reboot") then Cosmos.System.Power.Reboot();
   member u.Init() =
      let prompt = new CommandPrompt();
      prompt.Run();
   static member displayLogo () =
      Console.ForegroundColor <- ConsoleColor.Magenta;
      Console.WriteLine("...../_/_/_/...................................................................");
      Console.WriteLine("../_/........../_/_/....../_/_/_/.../_/_/_/./_/_/....../_/_/....../_/_/_/......");
      Console.WriteLine("./_/......../_/.../_/../_/_/......./_/.../_/.../_/../_/.../_/../_/_/...........");
      Console.WriteLine("/_/......../_/.../_/....../_/_/.../_/.../_/.../_/../_/.../_/....../_/_/........");
      Console.WriteLine("./_/_/_/..../_/_/..../_/_/_/...../_/.../_/.../_/..../_/_/..../_/_/_/...........");
      Console.WriteLine("...............................................................................");
      Console.WriteLine(".........../_/.../_/.............................................../_/..../_/..");
      Console.WriteLine("........../_/./_/......./_/_/..../_/./_/_/.../_/_/_/...../_/_/..../_/../_/_/...");
      Console.WriteLine("........./_/_/......./_/_/_/_/../_/_/......./_/.../_/./_/_/_/_/../_/..../_/....");
      Console.WriteLine("......../_/./_/...../_/......../_/........./_/.../_/./_/......../_/..../_/.....");
      Console.WriteLine("......./_/.../_/...../_/_/_/../_/........./_/.../_/.../_/_/_/../_/..../_/......");
      Console.ForegroundColor <- ConsoleColor.White;