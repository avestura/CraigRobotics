#load "../Prelude.fsx"
#load "AryanUtilities.fsx"

open MathNet.Numerics.LinearAlgebra
open AryanUtilities.Rotations
open AryanUtilities.Matrix

let rot1   = rotx 30. * roty 20. * rotz 10.
let trans1 = [[yield! col1 rot1; yield 1.]
              [yield! col1 rot1; yield 2.]
              [yield! col1 rot1; yield 3.]
              [0.; 0.; 0.;             1.]]

let rot2   = rotx 0. * roty 20. * rotz 0.
let trans2 = [[yield! col1 rot2; yield 3.]
              [yield! col1 rot2; yield 0.]
              [yield! col1 rot2; yield 1.]
              [0.; 0.; 0.;             1.]]


printfn "Trans1: "
printfn "%A" trans1

printfn "Trans2: "
printfn "%A" trans2
