## How Much is True?

A game of table tennis almost always sounds like Ping! followed by Pong!

You know that Player 2 won if you hear Pong! as the last sound (since Player 1 didn't return the ball back).

Given an array of Ping!, create a function that inserts Pong! in between each element.

Also:

- If win equals true, end the list with Pong!
- If win equals false, end the list with Ping!

### Examples

~~~ javascript
//Example 1
pingPong(["Ping!"], True)
output = ["Ping!", "Pong!"]

//Example 2
pingPong(["Ping!", "Ping!"], False)
output = ["Ping!", "Pong!", "Ping!"]

//Example 3
pingPong(["Ping!", "Ping!", "Ping!"], True)
output = ["Ping!", "Pong!", "Ping!", "Pong!", "Ping!", "Pong!"]
~~~ 

### Notes

- Player 1 serves the ball and makes Ping!.
- Return an array of strings.