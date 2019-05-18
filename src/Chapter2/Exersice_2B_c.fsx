#load "../AryanUtilities.fsx"

open MathNet.Numerics
open MathNet.Symbolics
open MathNet.Numerics.LinearAlgebra

open Operators

let r11, r12, r13, r21, r22, r23, r31, r32, r33 =
    symbol "r11",
    symbol "r12",
    symbol "r13",
    symbol "r21",
    symbol "r22",
    symbol "r23",
    symbol "r31",
    symbol "r32",
    symbol "r33"

let x, y, z = symbol "x", symbol "y", symbol "z"

let zero = Number BigRational.Zero
let one  = Number BigRational.One

let T = [[r11;  r12;  r13;  x]
         [r21;  r22;  r23;  y]
         [r31;  r32;  r33;  z]
         [zero; zero; zero; one]]

// Note: Inversing a symbolic matrix is tough task, It is possible to do it in Math.NET classic,
// but there is no support for it in the new library.
// I couldn't even make it in MATLAB. Any suggestions for symbolic inverse?
// Send a PR if you have any, thank you.

// let answer = T.Inverse()
// printfn "%A" answer

