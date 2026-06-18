module secret_handshake.SecretHandshake

open secret_handshake.Actions

let private secretActions: (int * SecretOps) list =
    [ (0b00001, Action Wink)
      (0b00010, Action DoubleBlink)
      (0b00100, Action CloseYourEyes)
      (0b01000, Action Jump)
      (0b10000, ReverseOrder Reverse) ]

let private applySpecialOp =
    function
    | ReverseOrder _ -> List.rev
    | _ -> id

let private applySpecialActions operations =
    // It seems there is no typesafe way to do this with `List.partition`, so we're splitting the list "by hand"
    let actionsOnly =
        operations
        |> List.choose (function
            | Action a -> Some a
            | _ -> None)

    operations |> List.fold (fun state op -> applySpecialOp op state) actionsOnly


let secretHandshake integerCode : Actions list =
    secretActions
    |> List.filter (fun (bit, _) -> integerCode &&& bit <> 0)
    |> List.map snd
    |> applySpecialActions
