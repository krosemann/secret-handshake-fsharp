module SecretHandshake

type SecretOp =
    | Action of string
    | ListOp of (string list -> string list)
  
let private secretOps =
    [ (0b00001, Action "wink")
      (0b00010, Action "double blink")
      (0b00100, Action "close your eyes")
      (0b01000, Action "jump")
      (0b10000, ListOp List.rev) ]
  
let private identifyOps secretOps number =
    secretOps
    |> List.filter (fun (code, _) -> code &&& number <> 0)
    |> List.map snd

let private toActions ops =
    let actions = ops |> List.choose (function Action a -> Some a | _ -> None)
    let listOps = ops |> List.choose (function ListOp o -> Some o | _ -> None)
    listOps |> List.fold (|>) actions

let secretHandshake : int -> string list =
    identifyOps secretOps >> toActions
