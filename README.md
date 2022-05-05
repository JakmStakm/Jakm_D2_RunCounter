# Jakm D2 Run Counter
Simple Diablo 2 run counter to keep track of drops and your Holy Grail of found items

![jakmcounter](https://user-images.githubusercontent.com/79934982/165865216-c7dbabe9-32d1-4f71-9b34-130f9eb7eb13.JPG)


# Installation

Go to the releases section to find the latest .ZIP file (https://github.com/JakmStakm/Jakm_D2_RunCounter/releases). Download and unzip/extract the file to run the setup.exe.

# Drag/Drop Overlay

The overlay option enables you to start/stop new runs without alt+tab or having to switch screens and stays on top of the game

(Overlay is resizable and able to be drag/dropped with the "Drag Overlay" option checked)

![overlay](https://user-images.githubusercontent.com/79934982/165865633-856efe04-73be-486d-9298-2cfcd9937b7b.JPG)

# Found Item

Clicking "Found Item" will prompt a pop up for the item name that will stop the current run and add the item to the list with the associated run number

By checking "Grail Only", it only attempts to add the item to your grail, but doesnt add to the runs list of items

![FoundItem](https://user-images.githubusercontent.com/79934982/165865611-427410b9-2247-463c-852d-a1c5f4f3a06d.JPG)

# Save/Load

You can save the current run session statistics to your local computer as a CSV file, which can then be imported any time to resume the session (Holy Grail saves automatically when anything changes to the local profile's database)

# Holy Grail

You can track your progress of the items you've found as well as the date you found them. When you click "Found Item" in a run, it will automatically check your profile's database to see if you have found the item and if not, add it to your collection.

If you're not in a run, you can add an item to your holy grail with "Add to Grail" (Also accessbile from the overlay)

You can filter the list of all items by Found, Not Found, by Catagory (Unique, Set, Runewords, Runes) or search the item
![HolyGrail](https://user-images.githubusercontent.com/79934982/165865001-292de1f2-4ec8-406d-884d-2d7c342e87ce.JPG)

# Profiles

You will be prompted to create a profile when first launching the app. The profile will keep track of your Holy Grail statistics and you can create multiple (Ladder/Non-Ladder etc..)

# Upgrade to newer version (Keep profile's database/items)

Navigate to the install directory (C:\Users\\(username)\AppData\Local\Apps\2.0) and Copy/Paste the Database file of the Profile Names that you would like to save to a another location.

![SaveDatabase](https://user-images.githubusercontent.com/79934982/166843630-b6dace19-2687-4c57-aa7f-1036dc735c63.JPG)

Uninstall the current version, and reinstall the new one and create a new Profile with the new version. Navigate to the install directory above again, and if the Profile name is the same as the old version, overwrite the database of the previous version with this version. If you have a new profile name, delete the database file with the new name, and replace it with your previous database and rename it to the new profile name. 
