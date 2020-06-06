# Builders Club Designer Sequencer ![Builders Club Designer XX](https://images.habbo.com/c_images/album1584/ACH_RoomDecoBC20.gif)

**Problem**: Using Tanji scheduler to place furniture and pick it up often results in crashes because of the packets being sent simultaneously sooner or later.

**Solution**: Sequencing the packets (sending them one after the other) using this extension, which cannot be done using the built-in scheduler. Placing your item capacity, then 1 pickallbc packet, then repeat.

Actually my first to GitHub pushed repository, via the GitHub Desktop client which was easier than with the Visual Studio extension.
Feel free to contribute e.g. by adding an option to automatically grab *the coordinates to place the furniture*.

# Sequencing interval
The value displayed in the NumericUpDown = the interval to send the packets in milliseconds

I tested and counted:

| Interval      | furniture being placed per minute |
|---------------|-----------------------------------|
| 285           | 100                               |
| 566 (default) | 101                               |
