# Builders Club Designer Sequencer ![Builders Club Designer XX](https://habboo-a.akamaihd.net/c_images/album1584/ACH_RoomDecoBC20.gif)

**Problem**: Using Tanji scheduler to place furniture and pick it up often results in crashes because of the packets being sent simultaneously sooner or later.

**Solution**: Sequencing the packets (one at a time, but different packets) using this extension, which cannot be done using the built-in scheduler

Actually my first to GitHub pushed repository, via the GitHub Desktop client which was easier than with the Visual Studio extension.
Feel free to contribute i.e. by adding an option to automatically grab *the packet headers* or *the coordinates to place the furniture*.

# Get going
- *optionally* change the value of `builders_club_borrowed_items_capacity` to match your capacity/limit of items you can place
- make sure the coordinates the furniture is being placed is a tile in the room you are in (x and y coordinates are 5 by default) or change the coordinate integers in the packet
