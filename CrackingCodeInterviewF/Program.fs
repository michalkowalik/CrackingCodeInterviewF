#light

open System
open System.Collections.Generic

// sieve of Eratosthenes
let sieve max =
    let rec next p = 
        match p with
        | [] -> []
        | n :: tail -> n :: next (List.filter(fun x -> x % n <> 0) tail)
    next [2..max]

[<EntryPoint>]
let main argv = 
    printfn "%A" (sieve 1000)
    0 // return an integer exit code
    