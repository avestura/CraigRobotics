#load "../Prelude.fsx"
open MathNet.Numerics
open MathNet.Numerics.LinearAlgebra
open MathNet.Spatial.Euclidean
open MathNet.Spatial.Units

module Rotations =

    let rotx degree = Angle.FromDegrees degree |> Matrix3D.RotationAroundXAxis
    let roty degree = Angle.FromDegrees degree |> Matrix3D.RotationAroundYAxis
    let rotz degree = Angle.FromDegrees degree |> Matrix3D.RotationAroundZAxis