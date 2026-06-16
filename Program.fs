module secret_handshake.Program

open secret_handshake.SecretHandshake

let printHandshakeAndResult handshake =
    printfn $"Result for {handshake} is {(execute handshake)}"

printHandshakeAndResult 9
printHandshakeAndResult 26
