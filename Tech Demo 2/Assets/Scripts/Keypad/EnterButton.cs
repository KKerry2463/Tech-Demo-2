using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterButton : MonoBehaviour, IInteractable
{
    [SerializeField] private GameObject keypad;
    public void Interact()
    {
        keypad.GetComponent<Keypad>().EnterClicked();
    }
}
