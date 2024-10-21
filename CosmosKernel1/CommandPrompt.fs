namespace CosmosKernel1

open System

type CommandPrompt() =
    let mutable prompt = String.Empty;
    let mutable currentPath = String.Empty;
    member u.Run() =
        let mutable exit = false;
        while (exit = false) do
            Console.Write($"{currentPath}>");
            prompt <- Console.ReadLine();
            match prompt with
            | "shutdown" -> Cosmos.System.Power.Shutdown();
            | "reboot" -> Cosmos.System.Power.Reboot();
            | _ -> printfn "Unknown command.";