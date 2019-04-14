#load "../Prelude.fsx"
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
