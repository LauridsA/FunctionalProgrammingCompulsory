module Count

let count myList:list<int> * toBeSearched:int -> int =
    
    let res = List.countBy (fun i -> if (i == toBeSearched) then 1 else 0) myList
    res