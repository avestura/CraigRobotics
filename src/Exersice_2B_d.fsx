#load "../Prelude.fsx"
#load "AryanUtilities.fsx"

open AryanUtilities.Rotations
open AryanUtilities.Matrix

let ABT = rotx 30. * roty 20. * rotz 10.
let BCT = rotx 0.  * roty 20. * rotz 0.

let ACT = ABT * BCT

let ABT2 = ACT * inv BCT

let BCT2 = inv ABT * ACT

printfn "ACT: \n%A" ACT
printfn "ABT with 2nd Method: \n%A" ABT2
printfn "BCT with 2nd Method: \n%A" BCT2