module Tests

open FluentAssertions
open Xunit

[<Theory>]
[<InlineData(1, 2)>]
let ``Should correctly add two numbers`` x y =
    (x + y).Should().Be(3)