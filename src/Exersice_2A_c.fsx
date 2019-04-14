#load "../Prelude.fsx"
#load "AryanUtilities.fsx"

// Rotate BP around Y by 20degree

open MathNet.Numerics.LinearAlgebra
open AryanUtilities.Rotations

let BP = matrix [[1.; 0.; 1.]]

let answer = roty 20. * BP

printfn "%A" answer
