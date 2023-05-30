using System;
using System.Collections.Generic;
using UnityEngine;

namespace Zoo
{
    class Spawner : MonoBehaviour
    {
        [SerializeField]
        private GameObject lion, hippo, pig, tiger, zebra;
        private void Start()
        {
            Lion henk = Instantiate(lion, transform).GetComponent<Lion>();
            henk.animalName = "henk";
            //Editor name
            henk.name = "henk";
            Hippo elsa = Instantiate(hippo, transform).GetComponent<Hippo>();
            elsa.animalName = "elsa";
            //Editor name
            elsa.name = "elsa";
            Pig dora = Instantiate(pig, transform).GetComponent<Pig>();
            dora.animalName = "dora";
            //Editor name
            dora.name = "dora";
            Tiger wally = Instantiate(tiger, transform).GetComponent<Tiger>();
            wally.animalName = "wally";
            //Editor name
            wally.name = "wally";
            Zebra marty = Instantiate(zebra, transform).GetComponent<Zebra>();
            marty.animalName = "marty";
            //Editor name
            marty.name = "marty";
        }
    }
}
