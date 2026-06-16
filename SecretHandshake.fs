module secret_handshake.SecretHandshake

let private actions = [ "wink"; "double blink"; "close your eyes"; "jump" ]

// This could easily be achieved by using Convert.ToString (number, 2), but I wanted to do it manually for practice
let isBitSet (number: int) (exponent: int) = (number &&& (1 <<< exponent)) > 0

let execute handshake : string list =
    let isActionPartOfHandshake = [ 0..3 ] |> List.map (isBitSet handshake)

    let actionsInHandshake =
        [ 0..3 ]
        |> List.choose (fun x -> if isActionPartOfHandshake[x] then Some actions[x] else None)

    let isReversedOrder = isBitSet handshake 4

    if isReversedOrder then
        List.rev actionsInHandshake
    else
        actionsInHandshake
