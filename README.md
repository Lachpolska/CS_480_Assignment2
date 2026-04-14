# CS_480_Assignment2
# Dot Product: Two of the gargoyles (Gargoyle 1, the gargoyle between the first 2 ghosts on the way starting from the player’s spawnpoint and going through the maze, and Gargoyle 3, a new gargoyle I added to the bathroom immediately above the player’s spawnpoint) now turn to face the player when within range of them (must have the GargoyleFace script). The dot product allows the script to check if the gargoyle is misaligned with the player so that it can then turn to face the player. Also, linear interpolation regulates the rotation of the gargoyle. To see the effect, just be near one of the two gargoyles with the GargoyleFace script and it will turn to face you. Don't get too close, though, or you'll get caught!

# Linear Interpolation: Added an ObjectFlash script and attached it to Gargoyle (actually a child of Gargoyle, GargoyleModel), the gargoyle guarding the room immediately to the left of the player’s spawnpoint, and Ghost (actually a child of Ghost called Ghost), the first ghost encountered by the player on the right and on their way toward the maze. Linear interpolation is applied to the alpha channel of the object so that the object's material linearly fades in and out. Watch as the ghost flickers a bit and the gargoyle’s red flashlight slowly oscillates between getting brighter and darker.

# Particle Effect: A bnuch of red particles are generated while the player is at the edge of the starting room by going directly down from the player’s spawnpoint. The particle effect stops when you leave the collider a the bottom of the starting area. I made use of a box collider with my PlayBeginningPartcile script attached to trigger the particle effect to start and stop.

# Sound Effect: Enjoy the start of a perforamnce by UO Mind the Gap of Genie in a Bottle, which plays on loop while the player is inside the room immediately to the left of the player’s spawnpoint (guarded by the gargoyle). The music stops upon exiting that room. I made use of a box collider with my PlayMusic script attached to trigger the audio to play and stop.



# Lachlan Domst was the only contributor when adding features to this project.
