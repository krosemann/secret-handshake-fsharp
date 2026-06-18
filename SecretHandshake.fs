module secret_handshake.SecretHandshake

open secret_handshake.Actions

let private secretActions =
    Map [ (1, WINK); (2, DOUBLE_BLINK); (4, CLOSE_EYES); (8, JUMP); (16, REVERSAL) ]

let private reverseIfNecessary actions =
    if actions |> List.contains REVERSAL then
        List.rev actions |> List.filter (fun x -> x <> REVERSAL)
    else
        actions

let execute handshake : string list =
    Seq.toList secretActions.Keys
    |> List.map (fun bit -> handshake &&& bit)
    |> List.choose (fun bit -> if bit > 0 then Some(secretActions[bit]) else None)
    |> reverseIfNecessary
