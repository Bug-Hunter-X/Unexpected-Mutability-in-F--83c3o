let mutable x = 0
let mutable y = 0
let updateXAndY () = 
    x <- x + 1
    y <- y + 1

let test () = 
    updateXAndY ()
    printfn "%d %d" x y

test ()