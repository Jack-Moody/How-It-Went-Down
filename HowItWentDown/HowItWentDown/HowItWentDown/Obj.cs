using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HowItWentDown
{
    /*This will be the basis for ALL objects
     * within the game world. */
    abstract class Obj
    {
        protected Boolean stationary, floating, collision, climbable, pickable; //Boolean Variables: Stationary, can it budge? Floating, is it affected by gravity? 
            //Collision, does it have a physical space? Climbable, can you climb it? Pickable, can you pick it up?
        protected float gravity; //drop of object

            
    }
}
