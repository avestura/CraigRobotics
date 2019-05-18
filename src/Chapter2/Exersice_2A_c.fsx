#load "../Prelude.fsx"
#load "../AryanUtilities.fsx"

// Rotate BP around Y by 20degree

open MathNet.Numerics.LinearAlgebra
open AryanUtilities.Rotations

let BP = matrix [[1.; 0.; 1.]]

let answer = BP * roty 20.

printfn "%A" answer
