using System;
using UnityEngine;
using UnityEngine.UI;

namespace Zoo
{
    class Zebra : Animal
    {
        private void Start()
        {
            helloResponse = "zebra zebra";
        }

        public void EatLeaves()
        {
            Balloon.SetActive(true);
            text.text = "munch munch zank yee bra";
        }
    }
}
