#r "../packages/MathNet.Numerics/lib/net40/MathNet.Numerics.dll"
#r "../packages/MathNet.Numerics.FSharp/lib/net45/MathNet.Numerics.FSharp.dll"
#r "../packages/MathNet.Spatial/lib/net40/MathNet.Spatial.dll"
#r "../packages/MathNet.Symbolics/lib/net45/MathNet.Symbolics.dll"


open MathNet.Numerics
open MathNet.Numerics.LinearAlgebra
open MathNet.Symbolics


fsi.AddPrinter(fun (matrix:Matrix<float>    ) -> matrix.ToString())
fsi.AddPrinter(fun (matrix:Matrix<float32>  ) -> matrix.ToString())
fsi.AddPrinter(fun (matrix:Matrix<complex>  ) -> matrix.ToString())
fsi.AddPrinter(fun (matrix:Matrix<complex32>) -> matrix.ToString())
fsi.AddPrinter(fun (vector:Vector<float>    ) -> vector.ToString())
fsi.AddPrinter(fun (vector:Vector<float32>  ) -> vector.ToString())
fsi.AddPrinter(fun (vector:Vector<complex>  ) -> vector.ToString())
fsi.AddPrinter(fun (vector:Vector<complex32>) -> vector.ToString())

fsi.AddPrinter Infix.format