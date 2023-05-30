using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snake : Animal
{
    //OnEnable instead of start because events need it
    public override void OnEnable()
    {
        base.OnEnable();
        //Fill in the animal specific fields
        helloResponse = "hisss";
        foodResponseMeat = "that isss tasssty";

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
