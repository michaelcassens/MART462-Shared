# Safety Gear Dress Up Project

## College Simulator
## MART 462, Sect. 50
## 03/22/2021


### Brief Description of Project

Ideally, this project would work like a mostly standard character creation / item equiping menu. The player will choose from a couple different type of garment options and then be able to apply those garments to their character. As this is a program meant to teach welding safety, different garments will come with different safety ratings and the goal is for the player to find a suitable set of garments that will protect them while welding. While the player looks through the different garment options, text should describe each piece and how well suited it is for welding. 

### How Does It Work?

It doesn't. I've spent the past two weeks slowly losing my mind over something that I feel like shouldn't be too difficult to implement. Currently, it is possible to change the stand-in-avatar's appearance by clicking on the next and previous buttons and the toggle switches write a message to the console, but other than that, not much is going on. 

I started with a 2-D avatar as I found a tutorial which I thought would help me get started on this project. Much of the code found in the project is more or less taken directly from that tutorial. [Here is the link for the curious.](https://www.youtube.com/watch?v=kAPIWJJ6NQI)

Because the avatar uses skeletal animation, it is possible to replace each body part with a different sprite without losing any animation or needing to create extensive sprite sheets for cosmetic changes. Everytime the player clicks on a previous or next button, the current sprite is replaced by the next, or previous sprite, in a list of sprite options. 

### How Should It Work?

If I were more competent, there would only be one set of previous / next buttons which would be used to cycle through all different garment types. Choosing one of the toggle options would determine which set of garments to cycle through. Toggles could also load / deload certain array lists depending on which toggle is currently on.

Dynamic text should update to display which garment type is selected, which garment of that garment type is currently selected, and a brief description of that garment should be displayed as well. I thought the best way of doing this would be to use scriptable objects, (I'm assuming they work like JSON files?) which would contain each garments type, name, safety rating, 3-D object, description, etc..

This project currently uses 2-D sprites which isn't ideal as the base game uses 3-D avatars. Originally, I tried using one of the blockhead avatars from the base game, but I couldn't make anything with that work, so I tried with 2-D place-holder-avatars instead. I really hope changing this from a 2-D to 3-D avatar customizer won't be too complicated... 