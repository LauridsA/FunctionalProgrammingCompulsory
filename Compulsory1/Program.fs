// Learn more about F# at http://fsharp.org

open System

//opg 1
let count(xs:List<int>, x) =
    List.sum(List.filter(fun y -> y=x) xs)

//opg 2
let insert(xs:List<int>, x) =
    let indexToInsertOn = List.findIndex(fun y -> y>x) xs
    let firstList, secondList = List.splitAt indexToInsertOn xs
    let newSecondList = x::secondList
    List.append firstList newSecondList

//opg 2 alternative 
let insertSort(xs:List<int>, x) =
    let appendedList = x::xs
    List.sort appendedList

//opg 3
let Intersect (xslist:List<int>, yslist:List<int>) =
    let result = List.choose(fun elem ->
        match (List.tryFind (fun k -> elem=k) xslist) with
        | Some(k) -> Some(k) 
        | None -> None ) yslist
    result

//opg 4
let plus(xs:List<int>, xs2:List<int>) =
    List.sort(List.concat([xs; xs2]))

//opg 5 (doesn't work properly)
let minus(xs:List<int>, xs2:List<int>) =
    List.except(xs2) xs

//opg5 alternative (not working)
let rec minusv2 conditionIsTrue integersToRemoveFromList =
    match integersToRemoveFromList with
    | head::tail when conditionIsTrue head -> tail
    | head::tail -> head::minusv2 conditionIsTrue tail
    | _ -> []

//Helper to call and increase index in ys for conditional removal (so we will only remove as many times as it's in ys)
let rec minusV2Helper(xs:List<int>, ys:List<int>, index) = 
        let removed = minusV2Helper(minusv2 (fun x -> x=ys.[index]) xs, ys, index+1)
        removed
// Løber out of bounds, vil ikke stoppes.

let weaklyAscendingList = [1; 1; 1; 3; 4; 6; 11; 11; 13; 17; 20]
let weaklyAscendingList2 = [1; 1; 2; 11; 13; 20]

let smallweak = [1; 1; 1; 2; 2; 5;]
let smallweak2 = [1; 1; 2; 4;]

// Runs

let opg1 = count(weaklyAscendingList, 1)
printfn "Opg 1 count of 1's in the:  %i" opg1

let opg2 = insert(weaklyAscendingList, 2)
printfn "Opg 2 list after inserting index 2 List is: %A" opg2

let opg2sort = insertSort(weaklyAscendingList, 2)
printfn "Opg 2 sort list after inserting and sorting the List is: %A" opg2sort

let opg3 = Intersect (weaklyAscendingList, weaklyAscendingList2)
printfn "Opg 3 intersect lists %A" opg3

let opg4 = plus(smallweak, smallweak2)
printfn "Opg 4 plus into one list %A" opg4

let opg5 = minus(smallweak, smallweak2)
printfn "Opg 5 minus into one list %A" opg5

Console.ReadKey |> ignore