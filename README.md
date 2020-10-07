#D2 HolyPlugy
Diablo 2 Holy Grail tracker - Reads the player stashes to find items, then tracks them and uploads direct to: 
http://d2-holy-grail.herokuapp.com
Credits: https://github.com/Nasicus/d2-holy-grail
Stash reading logic borrowed and converted from Java to C# - Credits to: https://github.com/Tedris/PlugyTools

Version 1 assume your save files are located in the user directory.


Features:

Grail and EtherialGrail tracker (Correctly tracks on website, includes unobtainable eth items against eth list within app for version 1.0)
Ability to view list of found and remaining items for unique and set items (version 1.0 excludes Rainbow Facets and Runeword Grail).
Automatic upload to https://d2-holy-grail.herokuapp.com/ after providing login details to application. 


Supported files:

.d2s - Diablo 2 save files;
.d2x - PlugY personal stash files;
.sss - PlugY shared stash files.
