module secret_handshake.Actions

[<Literal>]
let WINK = "wink"

[<Literal>]
let DOUBLE_BLINK = "double blink"

[<Literal>]
let CLOSE_EYES = "close your eyes"

[<Literal>]
let JUMP = "jump"

[<Literal>]
let REVERSAL = "reverse"

let DEFAULT_ACTIONS_PER_BIT =
    Map [ (1, WINK); (2, DOUBLE_BLINK); (4, CLOSE_EYES); (8, JUMP); (16, REVERSAL) ]
