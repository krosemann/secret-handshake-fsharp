module secret_handshake.SecretHandshake

open secret_handshake.Actions

let bitsIn handshake (bits: int list) =
    List.map (fun bit -> handshake &&& bit) bits
    |> List.choose (fun bit -> if bit > 0 then Some bit else None)

let reverseIfNecessary actions =
    if actions |> List.contains REVERSAL then
        List.rev actions
        |> List.filter (fun x -> x <> REVERSAL)
    else
        actions

let execute handshake (actionsPerBit: Map<int, string>) : string list =
    Seq.toList actionsPerBit.Keys
    |> bitsIn handshake
    |> List.map (fun bit -> actionsPerBit[bit])
    |> reverseIfNecessary
