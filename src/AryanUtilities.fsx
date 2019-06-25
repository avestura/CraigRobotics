#load "Prelude.fsx"
open MathNet.Numerics
open MathNet.Numerics.LinearAlgebra
open MathNet.Spatial.Euclidean
open MathNet.Spatial.Units

module Rotations =

    let rotx degree = Angle.FromDegrees degree |> Matrix3D.RotationAroundXAxis
    let roty degree = Angle.FromDegrees degree |> Matrix3D.RotationAroundYAxis
    let rotz degree = Angle.FromDegrees degree |> Matrix3D.RotationAroundZAxis

module Math =
    open System

    let pi = Math.PI
    let inline negate x = x * -1.
    let toDegree rad = rad * (180. / pi)
    let toRad deg = deg * (pi / 180.)
    let cosd = toRad >> cos
    let sind = toRad >> sin
    let asind = toRad >> asin
    let acosd = toRad >> acos
    let atand = toRad >> atan
    let atan2d = toRad >> atan2

module Matrix =
    let col1 (m:Matrix<_>) = m.Column 1
    let inv = Matrix.inverse

    let xOffset dx = matrix [[1.; 0.; 0.; dx ]
                             [0.; 1.; 0.; 0. ]
                             [0.; 0.; 1.; 0. ]
                             [0.; 0.; 0.; 1. ]]

    let yOffset dy = matrix [[1.; 0.; 0.; 0. ]
                             [0.; 1.; 0.; dy ]
                             [0.; 0.; 1.; 0. ]
                             [0.; 0.; 0.; 1. ]]

    let zOffset dz = matrix [[1.; 0.; 0.; 0. ]
                             [0.; 1.; 0.; 0. ]
                             [0.; 0.; 1.; dz ]
                             [0.; 0.; 0.; 1. ]]

module DenavitHartenberg =
    open Math
    open Matrix

    let transformMat alpha a theta d =
        let alphaRotateX = matrix [[1.; 0.        ; 0.        ; 0.]
                                   [0.; cosd alpha; -sin alpha; 0.]
                                   [0.; sind alpha; cosd alpha; 0.]
                                   [0.; 0.        ; 0.        ; 1.]]

        let thetaRotateZ = matrix [[cosd theta; -sind theta; 0.; 0.]
                                   [sind theta;  cosd theta; 0.; 0.]
                                   [0.        ;  0.        ; 1.; 0.]
                                   [0.        ;  0.        ; 0.; 1.]]                          

        alphaRotateX * (xOffset a) * thetaRotateZ * (zOffset d)