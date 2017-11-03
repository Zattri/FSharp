(* 
 Things to do   

input 1, input 2, input 3 - double
output - double 

Check the input - 3 of them
Make sure to check the amount of inputs - Error [too many inputs]
Check the type of input on the program, check on each input [Type mismatch error, expecting a number]
Use a parser to check the input type
Parse the correct size of input too


Create a function that multiplies numbers
Get a function that takes in the args    

*)



open System

[<EntryPoint>]
let main argv = 
    if Array.length argv = 3
    then
        let validX, x = argv.[0] |> Int32.TryParse
        let validY, y = argv.[1] |> Int32.TryParse
        let validZ, z = argv.[2] |> Int32.TryParse

        if validX && validY && validZ
        then
            printfn "%i" (x + y + z)
            0 // Return success exit code
        else
            printfn "ERROR: One of more of the inputs is not a valid integer"
            1
    else
        printfn "ERROR: Invalid amount of arguments (expects 3)"
        1 // return failure exit code