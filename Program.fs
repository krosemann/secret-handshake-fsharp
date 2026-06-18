module secret_handshake.Program

open secret_handshake.SecretHandshake

let printHandshakeAndResult code =
    printfn $"Result for {code} is {secretHandshake code}"

printHandshakeAndResult 3
printHandshakeAndResult 9
printHandshakeAndResult 26
