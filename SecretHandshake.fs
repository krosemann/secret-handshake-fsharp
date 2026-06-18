module secret_handshake.SecretHandshake

open secret_handshake.Actions

let private secretActions =
    Map [ (1, WINK); (2, DOUBLE_BLINK); (4, CLOSE_EYES); (8, JUMP); (16, REVERSAL) ]
    
let private bitsIn handshake (bits: int list) =
    List.map (fun bit -> handshake &&& bit) bits
    |> List.choose (fun bit -> if bit > 0 then Some bit else None)

let private reverseIfNecessary actions =
    if actions |> List.contains REVERSAL then
        List.rev actions
        |> List.filter (fun x -> x <> REVERSAL)
    else
        actions

let execute handshake : string list =
    Seq.toList secretActions.Keys
    |> bitsIn handshake
    |> List.map (fun bit -> secretActions[bit])
    |> reverseIfNecessary
