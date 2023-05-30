using System;
using UnityEngine;
using UnityEngine.UI;

namespace Zoo
{
    class Lion : Animal
    {
        //OnEnable instead of start because events need it
        public override void OnEnable()
        {
            base.OnEnable();
            //Fill in the animal specific fields
            helloResponse = "roooaoaaaaar";
            foodResponseMeat = "nomnomnom thx mate";

            //Subscribe to animal specific events
            GameManager.GiveMeatEvent += EatMeat;
        }

        public override void OnDisable()
        {
            base.OnDisable();
            //Unsubscribe to events to prevent issues
            GameManager.GiveMeatEvent -= EatMeat;
        }
    }
}
