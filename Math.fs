module CS220.Quiz1.Math

open System

/// Modify the function `collatz` in such a way that the function takes in a
/// 32-bit integer, and returns the number of steps it takes to reach 1 in the
/// Collatz sequence.
let collatz n =
  let rec itr n counter = 
    if n = 1L then counter
    elif n % 2L = 0 then itr (n/2L) (counter+1)
    else itr ((3L*n+1L)/2L) (counter+2)
  itr n 0
