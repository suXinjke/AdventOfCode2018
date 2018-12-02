open System

[<EntryPoint>]
let main argv =
    let answer =
        match Array.toList argv with
        | [ "1" ] -> day01.testAndSolve
        | [ "2" ] -> day01.testAndSolve2
        | [ "3" ] -> day02.testAndSolve
        | [ "4" ] -> day02.testAndSolve2
        | _ -> "no argument given"

    Console.WriteLine answer
    
    Console.ReadKey() |> ignore

    0
