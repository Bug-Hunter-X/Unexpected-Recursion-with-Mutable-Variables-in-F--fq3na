let rec loop1 x y =
    if x > 5 then
        y
    else
        loop1 (x+1) (y+1)

let z = loop1 0 0
printf "%i" z