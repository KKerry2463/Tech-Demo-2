using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ClearButtonScript : MonoBehaviour, IInteractable
{
    [SerializeField] private GameObject keypad;
    public void Interact()
    {
        keypad.GetComponent<Keypad>().ClearClicked();
    }
}
