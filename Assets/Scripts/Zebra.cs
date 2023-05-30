using System;
using UnityEngine;
using UnityEngine.UI;

namespace Zoo
{
    class Zebra : Animal
    {
        //OnEnable instead of start because events need it
        public override void OnEnable()
        {
            base.OnEnable();
            //Fill in the animal specific fields
            helloResponse = "zebra zebra";
            foodResponseLeaves = "munch munch zank yee bra";

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
