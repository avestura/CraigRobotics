#load "../AryanUtilities.fsx"

open AryanUtilities.Rotations
open AryanUtilities.Math

// This script calculates the Inverse (alpha-beta-gamma) of a
// Rotation matrix and shows both possible solutions

let R1 = (rotz 10.) * (roty 20.) * (rotx 30.)
let R2 = (rotz 30.) * (roty 90.) * (rotx -55.)

let beta  = R1.[2, 0] |> asind |> negate
let alpha = R1.[0, 0] / cosd beta |> acosd
let gamma = R1.[2, 2] / cosd beta |> acosd

let answer1 = (alpha, beta, gamma)

let beta2 = R2.[2, 0] |> asind |> negate

let answer2 =
    match (beta, beta2) with
    | (-90. , 90.) ->
      let gamma2 = atan2d R2.[0, 1] R2.[1, 1]
      (0., beta2, gamma2)

    | _ ->
      let alpha2 = R2.[0, 0] / cosd beta2 |> acosd
      let gamma2 = R2.[2, 2] / cosd beta2 |> acosd
      (alpha2, beta2 |> negate, gamma2)

printfn "Answer1: %A" answer1
printfn "Answer2: %A" answer2