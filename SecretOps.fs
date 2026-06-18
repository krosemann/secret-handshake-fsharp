module secret_handshake.Actions

type Action =
    | Wink
    | DoubleBlink
    | CloseYourEyes
    | Jump

type SpecialOp =
    | Reverse

type SecretOp =
    | Action of Action
    | SpecialOp of SpecialOp

module Action =
    let toString =
        function
        | Wink -> "wink"
        | DoubleBlink -> "double blink"
        | CloseYourEyes -> "close your eyes"
        | Jump -> "jump"

