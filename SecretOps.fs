module secret_handshake.Actions

type Actions =
    | Wink
    | DoubleBlink
    | CloseYourEyes
    | Jump

type SpecialOps =
    | Reverse

type SecretOps =
    | Action of Actions
    | SpecialOp of SpecialOps

module Actions =
    let toString =
        function
        | Wink -> "wink"
        | DoubleBlink -> "double blink"
        | CloseYourEyes -> "close your eyes"
        | Jump -> "jump"

