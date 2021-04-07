# Welidng Dress Up Module
# Uses Unity 2019.4.20f1
# 04/07/2021

## How It Works So Far
At the moment, this module is a sort of Frankenstein creation made up of multiple tutorial scripts, some blind guess work, and a little sprinkle of general incompetence. On the left side of the screen there are three sets of previous and next buttons, three toggles, and a toggle test button on the bottom. Clicking on any of the previous/next buttons on the left side of the screen will change what the avatar in the center of the screen is wearing. Clicking on the toggles will write a message to the console and change the text between the previous/next button on the right side of the screen. The Toggle Test button writes a message to the console when clicked - the message changes based on which toggle is currently on. This button is largely unnecessary and exists mainly as a way to test the code I am writing. 

Clicking on the next button on the right side of the screen will change both the hood and torso elements on the central avatar, but only if the hood toggle is selected on the left side of the screen. Ideally, only one element -- either hood, torso, or face -- would change when the next button on the right side of the screen is pressed based on whatever toggle is currently selected. I'll discuss that in more detail in the To Do section.


### OutfitChanger Script
This script uses a public list of Sprites and the Sprite Renderer Component to change the centrally located avatar's appearance. Much of the code was copied more or less directly from [this video.](https://www.youtube.com/watch?v=kAPIWJJ6NQI) The `OutfitChanger` script is attatched to each of the `HoodSelector`, `TorsoSelector`, and `FaceSelector` GameObjects, which themselves are grandchildren of the Canvas GameObject. 

The Next and Previous buttons are children of the different garment selector game objects. These buttons use their built-in OnClick function to then run the `NextOption()` or `PreviousOption()` methods in the `OutfitSelector` script. These methods simply cycle through a list of sprites by increasing or decreasing a variable which corresponds to the Sprite list index number.

There is currently an `If Statement` sitting on the top line of the `NextOption()` method. It does not work as intended, but I'll disscus that in more detail in the To Do section.


### Toggle Selector Script
The functioning bit of this script is mostly straight forward. Using the toggle element's built in `isOn` function, the text on the right side of the screen between the next/previous button changes to match whatever toggle is currently on. The `ToggleSelector` script is attatched to the `ToggleGroup` GameObject which is a grandchild of the `Canvas` GameObject. The toggle GameObject children of the `ToggleGroup` use the On Value Changed (Boolean) method to activate the `ActiveToggle()` method in the `ToggleSelector` script. 


### GarmentType Script
This script is a simple class I am hoping to use to store information about each individual garment. Ideally, each garment would come with a name, a type, a description, an image/3D object, and a safety rating. Currently, it only has two attributes, title and description. Instances of this class are instantiated in the `OutfitChanger` script and because that script is already attatched to the `HoodSelector`, `TorsoSelector`, and `FaceSelector` GameObjects, the class intances are also attatched. Ideally, this class would handle the list of Sprites, which the `OutfitChanger` script does already, but I have not yet figured out how to do that. Will be discussed more in the To Do section.


## To Do
A whole lot! 

### Toggles on the Left, Previous/Next Buttons on the Right
I want the left side of the screen to be populated with different toggles which would correspond to different garment types. Selecting one of these toggles would then determine what the single set of previous/next buttons on the right of the screen would cycle through. Each garment piece would come with a name, image preview, description, and a safety rating. 

My attempts to get the different garment types to share a single set of previous/next buttons has not gone well. At the moment clicking the Next button on the right side of the screen changes both the hood and torso appearance. That is because the built in onClick function calls the `NextOption()` method for both the `HoodSelector` and `TorsoSelector` GameObjects. There probably needs to be some sort of test to see which toggle is active before calling the `NextOption()` method, but I have not yet figured it out. I tried using the variable `currentActiveGarment` in the `ToggleSelector` script to hold onto whichever toggle is currently on, but I don't think this is the best way to go about it.

### GarmentType Class Integration
Rather than use the `OutfitChanger` script to store the list of sprites, I think it would be better handled by a class which could then also hold more information. I have started this process with the `GarmentType` class, but I have not yet been able to integrate it into the rest of the module. 

### Switch to 3D
I started this project with a 2D avatar as there were more tutorials about this kind of thing using 2D sprites. The project we are working in however, is a 3D environment. Initially, I did try to use the BlockHead avatar found in the Base Game assets, but I could not figure out how to fit it into this module. 

### Safety Rating 
Each garment should come with a safety rating. This could be displayed with a slider bar which fills up depending on the sum of safety ratings of the currently equipped garments. I have not started on this bit at all.

### Save States
Should the player be able to save the garments they have equiped for the next welding module they enter into? Should the student be allowed to access more advanced modules if their safety rating is too low? Should the student gain experience for completing this module?



