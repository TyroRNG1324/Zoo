using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //Link the button to the event system
    public static event System.Action GiveLeavesEvent;
    public static event System.Action GiveMeatEvent;
    public static event System.Action DoTricksEvent;
    public static event System.Action<string> SayHelloEvent;

    //Get the input text from the input field
    [SerializeField]
    private Text inputFieldText;

    //Invoke the SayHelloEvent 
    public void SayHello()
    {
        //Invoke using the input text from the input field
        SayHelloEvent?.Invoke(inputFieldText.text);
        //Reset the input field
        inputFieldText.text = "";
    }

    //Invoke the GiveMeatEvent
    public void GiveMeat()
    {
        GiveMeatEvent?.Invoke();
    }

    //Invoke the GiveLeavesEvent
    public void GiveLeaves()
    {
        GiveLeavesEvent?.Invoke();
    }

    //Invoke the DoTricksEvent
    public void DoTricks()
    {
        DoTricksEvent?.Invoke();
    }
}
