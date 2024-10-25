namespace CosmosKernel1

open System

type CommandPrompt() =
    let mutable prompt = String.Empty;
    let mutable currentPath = String.Empty;
    let parsedLine (line: string)() : string array = line.Split(' ');
    let parsedPath (line: string)() : string array = line.Split('\\');
    member u.Run() =
        let mutable exit = false;
        while (exit = false) do
            Console.Write(currentPath + ">");
            prompt <- Console.ReadLine();
            match prompt with
            | "shutdown" -> Cosmos.System.Power.Shutdown();
            | "reboot" -> Cosmos.System.Power.Reboot();
            | "cls" -> Console.Clear();
            | "echo" -> Console.WriteLine(prompt);
            | _ -> Console.WriteLine("Unknown command.");

type Kernel() =
   inherit Cosmos.System.Kernel();
   override u.BeforeRun() = 
      Console.SetWindowSize(90, 30)
      Kernel.displayLogo()
      Console.WriteLine("CosmosKernel1 v0.0.1 booted successfully. Type \"shutdown\" to shutdown and \"reboot\" to reboot.")
   override u.Run() =
      u.Init()
   member u.Init() =
      let prompt = new CommandPrompt();
      prompt.Run()
   static member displayLogo () =
      Console.ForegroundColor <- ConsoleColor.Magenta
      Console.WriteLine("     ///////")
      Console.WriteLine("  ///          /////      ///////   /////// /////      /////      ///////")
      Console.WriteLine(" ///        ///   ///  /////       ///   ///   ///  ///   ///  /////")
      Console.WriteLine("///        ///   ///      /////   ///   ///   ///  ///   ///      /////")
      Console.WriteLine(" ///////    /////    ///////     ///   ///   ///    /////    ///////")
      Console.WriteLine()
      Console.WriteLine("           ///   ///                                               ///    ///")
      Console.WriteLine("          /// ///       /////    /// /////   ///////     /////    ///  /////")
      Console.WriteLine("         /////       /////////  /////       ///   /// /////////  ///    ///")
      Console.WriteLine("        /// ///     ///        ///         ///   /// ///        ///    ///")
      Console.WriteLine("       ///   ///     ///////  ///         ///   ///   ///////  ///    ///")
      Console.ForegroundColor <- ConsoleColor.White