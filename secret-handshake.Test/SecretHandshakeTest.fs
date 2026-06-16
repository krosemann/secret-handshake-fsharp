module secret_handshake.Test

open NUnit.Framework
open secret_handshake.Actions
open secret_handshake.SecretHandshake

// Maybe using a TestCaseSource would be cleaner here?
[<TestCase(0, ExpectedResult = "")>]
[<TestCase(1, ExpectedResult = WINK)>]
[<TestCase(2, ExpectedResult = DOUBLE_BLINK)>]
[<TestCase(3, ExpectedResult = WINK + DOUBLE_BLINK)>]
[<TestCase(4, ExpectedResult = CLOSE_EYES)>]
[<TestCase(5, ExpectedResult = WINK + CLOSE_EYES)>]
[<TestCase(6, ExpectedResult = DOUBLE_BLINK + CLOSE_EYES)>]
[<TestCase(7, ExpectedResult = WINK + DOUBLE_BLINK + CLOSE_EYES)>]
[<TestCase(8, ExpectedResult = JUMP)>]
[<TestCase(9, ExpectedResult = WINK + JUMP)>]
[<TestCase(10, ExpectedResult = DOUBLE_BLINK + JUMP)>]
[<TestCase(11, ExpectedResult = WINK + DOUBLE_BLINK + JUMP)>]
[<TestCase(12, ExpectedResult = CLOSE_EYES + JUMP)>]
[<TestCase(13, ExpectedResult = WINK + CLOSE_EYES + JUMP)>]
[<TestCase(14, ExpectedResult = DOUBLE_BLINK + CLOSE_EYES + JUMP)>]
[<TestCase(15, ExpectedResult = WINK + DOUBLE_BLINK + CLOSE_EYES + JUMP)>]
[<TestCase(16, ExpectedResult = "")>]
[<TestCase(17, ExpectedResult = WINK)>]
[<TestCase(18, ExpectedResult = DOUBLE_BLINK)>]
[<TestCase(19, ExpectedResult = DOUBLE_BLINK + WINK)>]
[<TestCase(20, ExpectedResult = CLOSE_EYES)>]
[<TestCase(21, ExpectedResult = CLOSE_EYES + WINK)>]
[<TestCase(22, ExpectedResult = CLOSE_EYES + DOUBLE_BLINK)>]
[<TestCase(23, ExpectedResult = CLOSE_EYES + DOUBLE_BLINK + WINK)>]
[<TestCase(24, ExpectedResult = JUMP)>]
[<TestCase(25, ExpectedResult = JUMP + WINK)>]
[<TestCase(26, ExpectedResult = JUMP + DOUBLE_BLINK)>]
[<TestCase(27, ExpectedResult = JUMP + DOUBLE_BLINK + WINK)>]
[<TestCase(28, ExpectedResult = JUMP + CLOSE_EYES)>]
[<TestCase(29, ExpectedResult = JUMP + CLOSE_EYES + WINK)>]
[<TestCase(30, ExpectedResult = JUMP + CLOSE_EYES + DOUBLE_BLINK)>]
[<TestCase(31, ExpectedResult = JUMP + CLOSE_EYES + DOUBLE_BLINK + WINK)>]
let TestSecretHandshake handshake =
    execute handshake DEFAULT_ACTIONS |> String.concat ""
