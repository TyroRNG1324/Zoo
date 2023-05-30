using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Zoo
{
    class Tiger : Animal
    {
        //OnEnable instead of start because events need it
        public override void OnEnable()
        {
            base.OnEnable();
            //Fill in the animal specific fields
            helloResponse = "rraaarww";
            foodResponseMeat = "nomnomnom thx wubalubadubdub";

            //Subscribe to animal specific events
            GameManager.GiveMeatEvent += EatMeat;
            GameManager.DoTricksEvent += PerformTrick;
        }

        public override void OnDisable()
        {
            base.OnDisable();
            //Unsubscribe to events to prevent issues
            GameManager.GiveMeatEvent -= EatMeat;
            GameManager.DoTricksEvent -= PerformTrick;
        }

        public void PerformTrick()
        {
            StartCoroutine(DoTrick());
        }

        IEnumerator DoTrick()
        {
            for (int i = 0; i < 360; i++)
            {
                transform.localRotation = Quaternion.Euler(i, 0, 0);
                yield return new WaitForEndOfFrame();
            }
        }
    }
}
