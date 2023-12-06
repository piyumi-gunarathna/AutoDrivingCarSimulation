# AutoDrivingCarSimulation

## Overview
This project simulates an auto-driving car prototype intended for competition against other vehicles. The prototype operates within a large rectangular field where each position is defined by coordinates. The bottom-left position is represented as (0, 0), while the top-right position is defined as (width, height).

#### Functionality
The auto-driving car prototype possesses limited functionalities:

- Rotations:
-- L: Rotates the car by 90 degrees to the left.
-- R: Rotates the car by 90 degrees to the right.

- Movement:
-- F: Moves the car forward by one grid point in the direction it's facing.

#### Facing Direction
The car has a specific facing direction, adhering to the conventional map convention. For example:
- A car situated at position (1,2) facing North that moves forward will end up at (1, 3) while still facing North.


