#load "../AryanUtilities.fsx"

open AryanUtilities.Math
open MathNet.Numerics.LinearAlgebra
open MathNet.Symbolics
open Operators

let alpha, a, theta, d = 
    symbol "alpha",
    symbol "a",
    symbol "theta",
    symbol "d"

let alphaRotateX = [[one ; zero        ; zero       ; zero]
                    [zero; cos alpha   ; -sin alpha ; zero]
                    [zero; sin alpha   ; cos alpha  ; zero]
                    [zero; zero        ; zero       ; one]]

let xOffset      = [[one ; zero; zero; a   ]
                    [zero; one ; zero; zero]
                    [zero; zero; one ; zero]
                    [zero; zero; zero; one ]]

let thetaRotateZ = [[cos theta   ; -sin theta   ; zero; zero]
                    [sin theta   ;  cos theta   ; zero; zero]
                    [zero        ;  zero        ; one ; zero]
                    [zero        ;  zero        ; zero; one ]]    

let zOffset      = [[one ; zero; zero; zero]
                    [zero; one ; zero; zero]
                    [zero; zero; one ; d   ]
                    [zero; zero; zero; one ]]                       

alphaRotateX * xOffset * thetaRotateZ * zOffset