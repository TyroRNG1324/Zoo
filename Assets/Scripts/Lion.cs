using System;
using UnityEngine;
using UnityEngine.UI;

namespace Zoo
{
    class Lion : Animal
    {
        private void Start()
        {
            helloResponse = "roooaoaaaaar";
        }

        public void EatMeat()
        {
            Balloon.SetActive(true);
            text.text = "nomnomnom thx mate";
        }
    }
}
