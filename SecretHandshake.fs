module secret_handshake.SecretHandshake

open secret_handshake.Actions

let private secretActions =
    [ (0b00001, Action Wink)
      (0b00010, Action DoubleBlink)
      (0b00100, Action CloseYourEyes)
      (0b01000, Action Jump)
      (0b10000, SpecialOp Reverse) ]

let private applySpecialOp =
    function
    | SpecialOp Reverse -> List.rev
    | Action _ -> id

let private applySpecialOps allOperations =
    let actionsOnly =
        allOperations
        |> List.choose (function
            | Action a -> Some a
            | _ -> None)

    allOperations |> List.fold (fun state op -> applySpecialOp op state) actionsOnly


let secretHandshake integerCode : Action list =
    secretActions
    |> List.filter (fun (bit, _) -> integerCode &&& bit <> 0)
    |> List.map snd
    |> applySpecialOps
