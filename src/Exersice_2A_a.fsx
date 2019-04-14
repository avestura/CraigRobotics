#load "../Prelude.fsx"
#load "AryanUtilities.fsx"

// This script converts a Z-Y-X(alpha-beta-gamma) euler set to a
// rotation matrix
// i) alpha = 10, beta = 20, gamma = 30
// ii)alpha = 30, beta = 90, gamma = -55

open AryanUtilities.Rotations

let R1 = (rotz 10.) * (roty 20.) * (rotx 30.)
let R2 = (rotz 30.) * (roty 90.) * (rotx -55.)

printfn "R1: \n%A" R1
printfn "R2: \n%A" R2
