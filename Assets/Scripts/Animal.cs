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
    private protected string helloResponse;
    private protected string foodResponseLeaves;
    private protected string foodResponseMeat;


    public void SayHello(string input_name)
    {
        if (input_name == "" || input_name == animalName)
        {
            Balloon.SetActive(true);
            text.text = helloResponse;
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SayHello("");
        }
    }
}
