open System.IO

let words = "my string"
let wordCount (input : string) = 
    let array = input.Split ' '
    array.Length 

File.WriteAllText(__SOURCE_DIRECTORY__ + "\CountWords.txt", sprintf "Words: %s\n Number of words: %d" words (wordCount words))
let txt = File.ReadAllText(__SOURCE_DIRECTORY__ + "\CountWords.txt")
printfn "%s" txt