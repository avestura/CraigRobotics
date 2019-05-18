#load "../AryanUtilities.fsx"

open MathNet.Numerics.LinearAlgebra
open AryanUtilities.Rotations

let BP  = matrix [[1.; 0.; 1.]]
let APB = matrix [[3.; 0.; 1.]]

let AP = APB - BP * roty 20.

printfn "%A" AP