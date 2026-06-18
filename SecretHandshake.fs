module secret_handshake.SecretHandshake

open secret_handshake.Actions

let private secretActions =
    [ (0b00001, WINK)
      (0b00010, DOUBLE_BLINK)
      (0b00100, CLOSE_EYES)
      (0b01000, JUMP)
      (0b10000, REVERSAL) ]

let private actionFor bit =
    List.filter (fun mapping -> fst mapping = bit) secretActions
    |> List.exactlyOne
    |> snd
    
let private reverseIfNecessary actions =
    if List.contains REVERSAL actions then
        List.rev actions |> List.filter (fun x -> x <> REVERSAL)
    else
        actions

let secretHandshake integerCode : string list =
    List.map fst secretActions
    |> List.map (fun bit -> integerCode &&& bit)
    |> List.choose (fun bit -> if bit > 0 then Some(actionFor bit) else None)
    |> reverseIfNecessary
