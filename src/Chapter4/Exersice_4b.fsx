#load "../AryanUtilities.fsx"

open System
open MathNet.Numerics
open MathNet.Numerics.LinearAlgebra
open Operators

let l1, l2, l3 = 4., 3., 2.

let inputCases = 
    [|
        matrix [[1.; 0.; 0.; 9.]
                [0.; 1.; 0.; 0.]
                [0.; 0.; 1.; 0.]
                [0.; 0.; 0.; 1.]], "Case i"

        matrix [[0.5;  -0.866; 0.; 7.5373]
                [0.866; 0.6;   0.; 3.9266]
                [0.;    0.;    1.; 0.    ]
                [0.;    0.;    0.; 1.    ]], "Case ii"
    
        matrix [[0.;  1.; 0.; -3.]
                [-1.; 0.; 0.; 2. ]
                [0.;  0.; 1.; 0. ]
                [0.;  0.; 0.; 1. ]], "Case iii"
    
        matrix [[0.866; 0.5;   0.; -3.1245]
                [0.5;   0.866; 0.; 9.1674 ]
                [0.;    0.;    1.; 0.     ]
                [0.;    0.;    0.; 1.     ]], "Case iiii"
    |]

let transformer = matrix [[1.; 0.; 0.; l3]
                          [0.; 1.; 0.; 0.]
                          [0.; 0.; 1.; 0.]
                          [0.; 0.; 0.; 1.]]

// Solve for each case
inputCases
|> Array.iter (fun (mat, name) -> 
    printfn "Solving for case: %s" name

    let wrist = mat.Solve transformer
    let cosPhi, sinPhi, x, y = wrist.[0, 0], wrist.[1, 0], wrist.[0, 3], wrist.[1, 3]
    let c2 = (x**2. + y**2. - l1**2. - l2**2.) / (2. * l1 * l2)

    if (abs c2) - 1. < Double.Epsilon then
        let s2, phi = (1. - c2**2. |> sqrt), atan2 sinPhi cosPhi
        let k1, k2 = (l1 + l2*c2), l2*s2

        let theta1, theta2 =
            [| atan2 y x - atan2 k2 k1; atan2 y x - atan2 -k2 k1  |],
            [| atan2 s2 c2; atan2 -s2 c2 |]

        let theta3 =
            [| phi - theta1.[0] - theta2.[0], phi - theta1.[1] - theta2.[1] |]

        printfn "Solutions:"
        printfn "theta1: %A" theta1
        printfn "theta2: %A" theta2
        printfn "theta3: %A" theta1
        
    else
        printfn "There is no solution. Calculated value is outside of the bounds of workspace."

    printfn "\n----------------------\n"
)

