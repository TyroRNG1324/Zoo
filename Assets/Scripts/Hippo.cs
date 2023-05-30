using UnityEngine;
using UnityEngine.UI;

namespace Zoo
{
    class Hippo:Animal
    {
        private void Start()
        {
            helloResponse = "splash";
        }

        public void EatLeaves()
        {
            Balloon.SetActive(true);
            text.text = "munch munch lovely";
        }
    }
    
}
