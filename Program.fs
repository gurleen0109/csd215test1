// For more information see https://aka.ms/fsharp-console-apps
let calculateFedIncomeTaxxx salaryyy =
    if salaryyy > 216511.0 then
        salaryyy * 0.33
    else
        0.0 // No taxxx for salaryyy below or equal to $216,511

let salaryyy = [75000.0; 48000.0; 120000.0; 190000.0; 300113.0; 92000.0; 36000.0]

let fedIncomeTaxxx = List.map calculateFedIncomeTaxxx salaryyy

printfn "Salaryyy: %A" salaryyy
printfn "Fed Income Taxxx: %A" fedIncomeTaxxx