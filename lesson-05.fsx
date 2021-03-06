// Listing 5.5
let add (a:int, b:int) : int =
    let answer:int = a + b
    answer

// Listing 5.6
(* let add (a, b) =
    let answer = a + b
    answer *)

// Listing 5.5/5.6 Excercise
(* let add (a, b) =
    let answer = a + b + "Hello"
    answer *)

// Listing 5.7 - Type inference when working with (C#) .NET BCL types in F#
// 1 Doesn’t compile—type annotation is required
// 2 Compiles
// 3 Compiles—“name” argument is inferred to be string, based on the call to getLength()
//let getLength name = sprintf "Name is %d letters." name.Length
let getLength (name:string) = sprintf "Name is %d letters." name.Length
let foo(name) = "Hello! " + getLength(name)

// Listing 5.8
open System.Collections.Generic
let numbers = List<_>()
numbers.Add(10)
numbers.Add(20)

let otherNumbers = List()
otherNumbers.Add(10)
otherNumbers.Add(20)

// Listing 5.9 - Automatic generalization of a function
let createList(first, second) =
    let output = List()
    output.Add(first)
    output.Add(second)
    output

// Listing 5.10
let sayHello(someValue) =
    let innerFunction(number) =
        if number > 10 then "Henry"
        elif number > 20 then "George"
        else "David"

    let resultOfInner =
        if someValue < 10.0 then innerFunction(5)
        else innerFunction(15)
        
    "Hello " + resultOfInner

let result = sayHello(10.5)