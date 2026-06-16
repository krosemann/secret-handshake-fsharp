module secret_handshake.SecretHandshake

// This could easily be achieved by using Convert.ToString (number, 2), but I wanted to do it manually for practice
let isBitSet (number: int) (exponent: int) = (number &&& (1 <<< exponent)) > 0

let execute handshake (withActions : string list): string list =
    let isActionPartOfHandshake = [ 0..3 ] |> List.map (isBitSet handshake)

    let actionsInHandshake =
        [ 0..3 ]
        |> List.choose (fun x -> if isActionPartOfHandshake[x] then Some withActions[x] else None)

    let isReversedOrder = isBitSet handshake 4

    if isReversedOrder then
        List.rev actionsInHandshake
    else
        actionsInHandshake
