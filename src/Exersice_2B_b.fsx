#load "../Prelude.fsx"
#load "AryanUtilities.fsx"

open MathNet.Numerics.LinearAlgebra
open AryanUtilities.Rotations

let BP  = matrix [[1.; 0.; 1.]]
let APB = matrix [[3.; 0.; 1.]]

let AP = APB - roty 20. * BP

printfn "%A" AP