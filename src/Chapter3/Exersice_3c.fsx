#load "../AryanUtilities.fsx"

open AryanUtilities.DenavitHartenberg

// For case (i):

let caseI =
    let t1 = transformMat 0. 0. 0. 0.
    let t2 = transformMat 0. 4. 0. 0.
    let t3 = transformMat 0. 3. 0. 0.
    let tH = transformMat 0. 2. 0. 0.

    t1 * t2 * t3 * tH

// For case (ii):

let caseII = 
    let t1 = transformMat 0. 0. 10. 0.
    let t2 = transformMat 0. 4. 20. 0.
    let t3 = transformMat 0. 3. 30. 0.
    let tH = transformMat 0. 2. 0.  0.

    t1 * t2 * t3 * tH

// For case (iii):

let caseIII = 
    let t1 = transformMat 0. 0. 90. 0.
    let t2 = transformMat 0. 4. 90. 0.
    let t3 = transformMat 0. 3. 90. 0.
    let tH = transformMat 0. 2. 0.  0.

    t1 * t2 * t3 * tH


printfn "Solve for i: %A"   caseI
printfn "Solve for ii: %A"  caseII
printfn "Solve for iii: %A" caseIII