using UnityEngine;
using UnityEngine.UI;

namespace Zoo
{
    class Hippo:Animal
    {
        //OnEnable instead of start because events need it
        public override void OnEnable()
        {
            base.OnEnable();
            //Fill in the animal specific fields
            helloResponse = "splash";
            foodResponseLeaves = "munch munch lovely";

            //Subscribe to animal specific events
            GameManager.GiveLeavesEvent += EatLeaves;
        }

        public override void OnDisable()
        {
            base.OnDisable();
            //Unsubscribe to events to prevent issues
            GameManager.GiveLeavesEvent -= EatLeaves;
        }
    }
}
