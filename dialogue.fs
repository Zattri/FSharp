open System

let dia1 = ["Show me your wares"; "Know anything about the Bloody Baron?"; "Let's play Gwent"; "See you [Leave]"]
let res1 = ["[Opens inventory]"; "He lives up in Crow's Perch, moved there a few years ago after he left the Nillfgardian army"; "How much do you want to bet?"; "[Exit]"]
let full = [["Show me your wares"; "Know anything about the Bloody Baron?"; "Let's play Gwent"; "See you [Leave]"];["[Opens inventory]"; "He lives up in Crow's Perch, moved there a few years ago after he left the Nillfgardian army"; "How much do you want to bet?"; "[Exit]"]]

let rec getNth n ls =
    match n, ls with 
    | 1, x::_ -> printfn "> %s" x // Initialised at 1
    | _, _::xs -> getNth (n - 1) xs 
    | _, [] -> invalidArg "n" "n is too long"

let dialogue opts res = 
    opts |> List.iteri(fun i x -> printfn "%i - %s" (i + 1) x)
    let choice = System.Console.ReadLine() |> int; 
    getNth choice res

let outterDia fullDia = 
    match fullDia with
    | x::xs::[] -> dialogue x xs
    | x::xs::_ -> printf "Too many options included"
    | x -> printf "Not enough options included"

[<EntryPoint>]
let main argv = 
    outterDia full
    0