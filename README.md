#GAME-EGN PRACTICAL MIDTERM

**Name: Charleen Chu**

**Student number: 100784133**

**_Part 1 - BUBBLE BOBBLE RECREATION_**

Since I am especially bad with timing my work, I've decided to keep it as simplistic as possible. I've only used Unity's primitives like cubes, spheres, and capsule to represent my platforms, bubbles, and characters (enemy and player)

I've successfully made the character move and jump, though I've realized too late to lock my player from moving on the z axis, so please avoid pressing 'W' or 'S', but if you fell off the platform you can restart by pressing 'R.' 

I've also was able to make the player shoot, but the bubble only moves to the right side, and it can kill enemy but that's it. I wasn't able to get the bubble to turn into a food, or anything further since the most important thing to focus for me was to get OOP, Singleton, and Factory done.

However looking back, some adjustment I would make to improve Part 1 is add in a collision check for enemy and a direction variable, this would then changes the direction variable to be 0 when triggered by the enemy, and then overriding the update function to use the move function with said new direction.

I also forgot I changed the bubble to be a trigger, therefore still uses the onCollision. An easy fix would be to just change it into onTrigger. This would mean I need to make an empty object (using getchild function) or give it an offset for the bubble spawner so that the bubble won't spawn inside the player and destroy it. I do prefer the getchild function because it easier.

After finishing the build, I have left a grave error: destroying the player when they died, which means the camera will lose it's target. An easy fix is to simply call the function Respawn() from my SceneManager instead of destroying.



**_Part 2 - OOP_**
The 3 principle I've used are: inheritance, abstraction, and polymorphism

I've used inheritance by having the player and enemy inherit from the Character class. This Character class have the basic stuff like a maxHP and currentHP. There is also function for TakeDamage() and Die() to handle health reduction and GameObject destruction.

There is also inheritance from Bubble class because I intent to have two bubbles: regular bubble and bonus bubble for when player pop the regular bubble, it will spawn in to drop bonus food items. Though I couldn't implement the second bubble, it is an easy implementation because I can just override the Pop() function when it collided with the player by using the base code to destroy, but also instantiate the food I need.

The inheritance in done by replacing the MonoBehavior class with the base class needed, and calls for functions necessary when it is needed, or override the function using override. I can also optionally put base.functionName() if I want to use the base class' default code in the override, this is to add on to the function instead of completely replacing it with the new code.

Abstraction is also used in the base Character and base Bubble classes as public abstract class ClassName. It itself isn't being instantiated, but rather being called upon by others inherited from it. It's basically existed as a script and not a gameObject. This is done by putting public abstract class instead of just public class, it is also not to be instantiated in game. It was done like this because it's a blueprint for other inherited class to inherit by default and allows for simple and clean "cherry picking" of that would need to be used and what not to be used.

Polymorphism is also used with the base Character and base Bubble classes, as they have methods that are shared to multiple child classes and allows customization of the functions using override and virtual keywords. This is done by having a base class, and one or more child classes to inherited from it. This was done to allow for modular and reusable functions/code and allowing different objects to essentially run the same code without having to copy-paste it individually.



**_Part 3 - Singleton_**
I've used singleton for my SceneManager instead, since it needs to be something completely new from what was used in class (which I recall is the GameManager example). The singleton is to handle scenes, like reloading it when player died or the reset key is pressed. This is done by adding the public static SceneManager Instance {get; private set} to make the get accessible to everyone, but the set is public. The instance is also set to this specific class. In a hurry to make a build as I've ran out of time, I completely missed out on destroying this object if it fould others, and also forgot to add the classic: DoNotDestroy. This devastates me as DoNotDestroy is the CLASSIC line of code to make a singleton and I've fumbled it instead. I've used the singleton for SceneManagement because if I were to make multiple levels of this, the singleton would follow me instead of staying in one scene, and this would allow me to perform the same scene restart function for individual level. I would also add in a scene switch function for this if I were to make multiple levels as well.



**_Part 4 - Factory Pattern_**
At this point I couldn't implement the factory pattern because I have ran out of time and cannot push anymore. However, I had planned to use this to spawn my 2 bubbles since this is the main reason I made 2 bubbles after all instead of simply changing the original bubble. The factory would have an Interface for the function AddPoints() because both bubbles would addpoints when it is popped by either the player or the enemy. I would then use the spawner to spawn the bubble appropriately by calling Instantiate based on those conditions, and call AddPoints with which ever float value I wanted.
I picked bubbles to spawn because it is different than the class and lab examples (enemy spawner, and lab example I used a food spawner for my lab assignment).
