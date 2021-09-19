# DrawCanvas
This is console app to create Canvas and draw Line or Rectangle and fill selected area with back color.

Run the Application.
It will show you commands for how to run the application.
After reading these commands, please enter below commands one by one.

# Example 1:

C 20 4

L 1 2 6 2

L 6 3 6 4

R 14 1 18 3

B 10 3 o

# Example 2:

C 20 10

L 1 2 6 2

L 6 3 6 4

R 4 3 18 7

B 10 3 o


--> In this case Background Color will not be printed as the pointer to start color is on the line printed with 'x'

# Example 3:

C 20 10

L 1 2 6 2

L 6 3 6 4

R 4 3 18 7

B 10 4 o


# Note:
Numbers printed on top of Canvas are to indicate the X Axis position.
For e.g. Below numbers on X-Axis should be read vertically to see the correct index number.

 00000000011111111112 
 12345678901234567890 
----------------------
|                    |1
|xxxxxx              |2
|   xxxxxxxxxxxxxxx  |3
|   x x           x  |4
|   x             x  |5
|   x             x  |6
|   xxxxxxxxxxxxxxx  |7
|                    |8
|                    |9
|                    |10
----------------------


