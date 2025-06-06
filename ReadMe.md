Consider the following children’s game:

• **n** children stand around a circle.  
• Starting with a given child and working clockwise, each child gets a sequential number, which we will refer to at its id.  
• Then starting with the first child, they count out from 1 until **k**.  The k’th child is now out and leaves the circle.  The count starts again with the child immediately next to the eliminated one.  
• Children are so removed from the circle one by one.  The winner is the last child left standing.

Write some code which, when given n and k, calculates:

• the sequence of children as they are eliminated, and
• the id of the winning child.


The program should use the following API to get game parameters (n and k) and provide game results:

• GET https://7annld7mde.execute-api.ap-southeast2.amazonaws.com/main/game