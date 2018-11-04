# Builders Club Designer Sequencer ![Builders Club Designer XX](https://images.habbo.com/c_images/album1584/ACH_RoomDecoBC20.gif)

**Problem**: Using Tanji scheduler to place furniture and pick it up often results in crashes because of the packets being sent simultaneously sooner or later.

**Solution**: Sequencing the packets (sending them one after the other) using this extension, which cannot be done using the built-in scheduler. Placing your item capacity, then 1 pickallbc packet, then repeat.

**Built for Tanji v1.4.1238**

Actually my first to GitHub pushed repository, via the GitHub Desktop client which was easier than with the Visual Studio extension.
Feel free to contribute i.e. by adding an option to automatically grab *the packet headers* or *the coordinates to place the furniture*.

# Get going
- *optionally* change the value of `builders_club_borrowed_items_capacity` to match your capacity/limit of items you can place
- make sure the coordinates the furniture is being placed is a tile in the room you are in (x and y coordinates are 5 by default) or change the coordinate integers in the packet

# Sequencing interval
The value displayed in the UI = the interval to send the packets in milliseconds

I tested and counted:

| Interval      | furniture being placed per minute |
|---------------|-----------------------------------|
| 285           | 100                               |
| 566 (default) | 101                               |
