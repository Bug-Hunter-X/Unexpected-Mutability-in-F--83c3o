# F# Mutability Bug
This repository demonstrates a common issue in F#: unexpected behavior arising from the use of mutable variables.

The `bug.fs` file contains code that uses mutable variables (`x` and `y`).  The function `updateXAndY` modifies both variables, but the behavior might not be immediately obvious to someone unfamiliar with F#'s handling of mutability. The `bugSolution.fs` file presents a refactored version with immutable data and explanations.