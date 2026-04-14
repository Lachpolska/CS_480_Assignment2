# CS_480_Assignment2
Audio: Music plays on loop while the player is inside the room immediately to the left of the player’s spawnpoint (guarded by the gargoyle).

Particle Effect: Red particles generated while the player is at the edge of the starting room by going directly down from the player’s spawnpoint.

Dot Product: 2 of the Gargoyles (Gargoyle 1, the gargoyle between the first 2 ghosts on the way starting from the player’s spawnpoint and going through the maze, and Gargoyle 3, a new gargoyle I added to the bathroom immediately above the player’s spawnpoint) now turn to face the player when within range of them. Just be near one of the gargoyles with the GargoyleFace script and it will turn to face you.

Linear Interpolation: Added an ObjectFlash script and attached it to Gargoyle (actually a child of Gargoyle, GargoyleModel), the gargoyle guarding the room immediately to the left of the player’s spawnpoint, and Ghost (actually a child of Ghost called Ghost), the first ghost encountered by the player on the right and on their way toward the maze. Watch as the ghost flickers a bit and the gargoyle’s red flashlight slowly oscillates between getting brighter and darker.

