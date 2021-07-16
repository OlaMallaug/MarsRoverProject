I assumed that a rover can't start outside the plateau and the instructions will not let the rover
drive off the plateau, this could be added to the code to give a warning if rover drives outside the plateau.

The main class for this project is MarsRover that will receive the input from and loop through each
rovers movement and return the final positions.

The ParseInput class will parse the input do some validation and populate the NavigationParam object.

The Navigation class will use the NavigationParam and calculate the movements using the Movement and Rotation classes.

MarsRoverProjectTest has a few simple unit tests in it that is using the MarsRover class as the target.