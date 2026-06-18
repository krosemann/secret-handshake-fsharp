module secret_handshake.Test

open NUnit.Framework
open secret_handshake.Actions
open secret_handshake.SecretHandshake

// Maybe using a TestCaseSource would be cleaner here?
[<TestCase(0, ExpectedResult = "")>]
[<TestCase(1, ExpectedResult = "wink")>]
[<TestCase(2, ExpectedResult = "double blink")>]
[<TestCase(3, ExpectedResult = "wink" + "double blink")>]
[<TestCase(4, ExpectedResult = "close your eyes")>]
[<TestCase(5, ExpectedResult = "wink" + "close your eyes")>]
[<TestCase(6, ExpectedResult = "double blink" + "close your eyes")>]
[<TestCase(7, ExpectedResult = "wink" + "double blink" + "close your eyes")>]
[<TestCase(8, ExpectedResult = "jump")>]
[<TestCase(9, ExpectedResult = "wink" + "jump")>]
[<TestCase(10, ExpectedResult = "double blink" + "jump")>]
[<TestCase(11, ExpectedResult = "wink" + "double blink" + "jump")>]
[<TestCase(12, ExpectedResult = "close your eyes" + "jump")>]
[<TestCase(13, ExpectedResult = "wink" + "close your eyes" + "jump")>]
[<TestCase(14, ExpectedResult = "double blink" + "close your eyes" + "jump")>]
[<TestCase(15, ExpectedResult = "wink" + "double blink" + "close your eyes" + "jump")>]
[<TestCase(16, ExpectedResult = "")>]
[<TestCase(17, ExpectedResult = "wink")>]
[<TestCase(18, ExpectedResult = "double blink")>]
[<TestCase(19, ExpectedResult = "double blink" + "wink")>]
[<TestCase(20, ExpectedResult = "close your eyes")>]
[<TestCase(21, ExpectedResult = "close your eyes" + "wink")>]
[<TestCase(22, ExpectedResult = "close your eyes" + "double blink")>]
[<TestCase(23, ExpectedResult = "close your eyes" + "double blink" + "wink")>]
[<TestCase(24, ExpectedResult = "jump")>]
[<TestCase(25, ExpectedResult = "jump" + "wink")>]
[<TestCase(26, ExpectedResult = "jump" + "double blink")>]
[<TestCase(27, ExpectedResult = "jump" + "double blink" + "wink")>]
[<TestCase(28, ExpectedResult = "jump" + "close your eyes")>]
[<TestCase(29, ExpectedResult = "jump" + "close your eyes" + "wink")>]
[<TestCase(30, ExpectedResult = "jump" + "close your eyes" + "double blink")>]
[<TestCase(31, ExpectedResult = "jump" + "close your eyes" + "double blink" + "wink")>]
let TestSecretHandshake handshake =
    secretHandshake handshake
    |> List.map Actions.toString
    |> String.concat ""
