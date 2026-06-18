module secret_handshake.Actions

type Actions =
    | Wink
    | DoubleBlink
    | CloseYourEyes
    | Jump

type ReverseOrder =
    | Reverse

type SecretOps =
    | Action of Actions
    | ReverseOrder of ReverseOrder

module Actions =
    let toString =
        function
        | Wink -> "wink"
        | DoubleBlink -> "double blink"
        | CloseYourEyes -> "close your eyes"
        | Jump -> "jump"

