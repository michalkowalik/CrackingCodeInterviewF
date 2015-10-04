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

// fizzbuzz game:
let fizzy num =
    match num % 3, num % 5 with
        | 0, 0 -> "fizzbuzz"
        | 0, _ -> "fizz"
        | _, 0 -> "buzz"
        | _, _ -> num.ToString()

let fizzbuzz max = 
    [1..max]
    |> List.map fizzy
    |> List.iter (fun (s: string) -> printfn "%s" s)


[<EntryPoint>]
let main argv = 
    // primes:
    printfn "%A" (sieve 1000)

    //fizzbuzz:
    fizzbuzz 100

    0 // return an integer exit code    