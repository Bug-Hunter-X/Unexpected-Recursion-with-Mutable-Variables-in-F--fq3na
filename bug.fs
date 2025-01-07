let mutable x = 0
let mutable y = 0
let rec loop1 x y = 
    if x > 5 then
        y
    else
        loop1 (x+1) (y+1)

let z = loop1 x y
printf "%i" z