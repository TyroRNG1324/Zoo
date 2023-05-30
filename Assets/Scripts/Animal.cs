using System;
using UnityEngine;
using UnityEngine.UI;

public class Animal : MonoBehaviour
{
    [SerializeField]
    private protected GameObject Balloon;
    [SerializeField]
    private protected Text text;
    public string animalName;

    //Initialize the responses for inheritance
    private protected string helloResponse;
    private protected string foodResponseLeaves;
    private protected string foodResponseMeat;

    //Subscribe the the SayHelloEvent
    public virtual void OnEnable()
    {
        GameManager.SayHelloEvent += SayHello;
    }

    //Unsubscribe from events to prevent issues
    public virtual void OnDisable()
    {
        GameManager.SayHelloEvent -= SayHello;
    }

    //Every animal says hello
    public void SayHello(string input_name)
    {
        if (input_name == "" || input_name == animalName)
        {
            Balloon.SetActive(true);
            text.text = helloResponse;
        }
    }

    //Animals will only eat if subscribed to the event
    //Make the animal eat leaves
    public void EatLeaves()
    {
        Balloon.SetActive(true);
        text.text = foodResponseLeaves;
    }

    //Make the animal eat meat
    public void EatMeat()
    {
        Balloon.SetActive(true);
        text.text = foodResponseMeat;
    }
}
