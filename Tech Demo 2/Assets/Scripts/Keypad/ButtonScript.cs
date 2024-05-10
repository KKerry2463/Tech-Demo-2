using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ButtonScript : MonoBehaviour, IInteractable
{
    [SerializeField] private string buttonText;
    [SerializeField] private TextMeshPro textDisplay;
    public void Interact()
    {
        Debug.Log("Button Clicked");
        textDisplay.text = textDisplay.text + buttonText;
    }
}
