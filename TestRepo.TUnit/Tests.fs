module Tests

open FluentAssertions
open TUnit.Core

[<Test>]
[<Arguments(1, 2)>]
let ``Should correctly add two numbers`` x y =
    (x + y).Should().Be(3)