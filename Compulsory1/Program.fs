// Learn more about F# at http://fsharp.org

open System


//Opg 1.1
let count(xs:List<int>, x) =
    List.sum(List.filter(fun y -> y=x) xs)

let insert(xs:List<int>, x) =
    let indexToInsertOn = List.findIndex(fun y -> y>x) xs
    let firstList, secondList = List.splitAt indexToInsertOn xs
    let newSecondList = x::secondList
    List.append firstList newSecondList

let insertSort(xs:List<int>, x) =
    let appendedList = x::xs
    List.sort appendedList

let intersect(xs:List<int>, xs2:List<int>) =
    let set1 = Set.ofList xs
    let set2 = Set.ofList xs2
    let intersectedSet = Set.intersect set1 set2
    Set.toList intersectedSet

let intersectReal(xs:List<int>, xs2:List<int>) =
    let set1 = Set.ofList xs
    let set2 = Set.ofList xs2
    let intersectedSet = Set.intersect set1 set2
    Set.toList intersectedSet

let plus(xs:List<int>, xs2:List<int>) =
    List.sort(List.concat([xs; xs2]))

//let insertAt index = function
//| xs when index >= 0 && index < List.length xs -> 
//      xs
//      |> List.splitAt index
//      |> fun (x,y) -> y |> List.skip 1 |>  List.append x
//      |> Some
//| ys -> None

let weaklyAscendingList = [1; 1; 1; 3; 4; 6; 11; 11; 13; 17; 20]
let weaklyAscendingList2 = [1; 1; 11; 13; 20]

let smallweak = [1; 1; 3; 4;]
let smallweak2 = [1; 2; 6;]

let opg1 = count(weaklyAscendingList, 1)
printfn "Opg 1 count of 1's in the:  %i" opg1

let opg2 = insert(weaklyAscendingList, 2)
printfn "Opg 2 list after inserting index 2 List is: %A" opg2

let opg2sort = insertSort(weaklyAscendingList, 2)
printfn "Opg 2 sort list after inserting and sorting the List is: %A" opg2sort

let opg3 = intersect(weaklyAscendingList, weaklyAscendingList2)
printfn "Opg 3 Intersect the fucking list %A" opg3

let opg4 = plus(smallweak, smallweak2)
printfn "Opg 4 plus into one list %A" opg4

Console.ReadKey |> ignore