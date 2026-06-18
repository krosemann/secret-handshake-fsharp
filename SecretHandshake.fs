module secret_handshake.SecretHandshake

open secret_handshake.Actions

let private secretActions =
    Map
        [ (0b00001, WINK)
          (0b00010, DOUBLE_BLINK)
          (0b00100, CLOSE_EYES)
          (0b01000, JUMP)
          (0b10000, REVERSAL) ]

let private reverseIfNecessary actions =
    if actions |> List.contains REVERSAL then
        List.rev actions |> List.filter (fun x -> x <> REVERSAL)
    else
        actions

let secretHandshake integerCode : string list =
    Seq.toList secretActions.Keys
    |> List.map (fun bit -> integerCode &&& bit)
    |> List.choose (fun bit -> if bit > 0 then Some(secretActions[bit]) else None)
    |> reverseIfNecessary
