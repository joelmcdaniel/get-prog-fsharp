open System

let doStuffWithTwoNumbers(first, second) =
    let added = first + second
    Console.WriteLine("{0} + {1} = {2}", first, second, added)
    let doubled = added * 2
    doubled
(*
// Unmanged scope
let year = DateTime.Now.Year
let age = year - 1971
let estimatedAge = sprintf "You are about %d years old!" age
// rest of application...
*)

// Tightly bound scope
let estimatedAge = 
    let age = 
        let year = DateTime.Now.Year
        year - 1971
    sprintf "You are about %d years old!" age

// Nested (inner) functions
let estimateAges(familyName, year1, year2, year3, year4, year5, year6) = 
    let calculateAge yearOfBirth = 
        let year = System.DateTime.Now.Year
        year - yearOfBirth

    let estimatedAge1 = calculateAge year1
    let estimatedAge2 = calculateAge year2
    let estimatedAge3 = calculateAge year3
    let estimatedAge4 = calculateAge year4
    let estimatedAge5 = calculateAge year5
    let estimatedAge6 = calculateAge year6

    let averageAge = (estimatedAge1 + estimatedAge2 + estimatedAge3 + estimatedAge4 + estimatedAge5 + estimatedAge6) / 6
    sprintf "Average age for family %s is %d" familyName averageAge