using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Keypad : MonoBehaviour
{
    [SerializeField] private TextMeshPro displayText;
    [SerializeField] private int maxCodeLength;
    [SerializeField] private string correctCode;
     private bool isCorrectCode;
    [SerializeField] Light ls;

    private void Update()
    {
        if (displayText.text.Length > maxCodeLength)
        {
            isCorrectCode = false;
            Debug.Log("To many numbers!");
            CodeCheck();
        }
    }

    public void CodeCheck()
    {
        if (isCorrectCode)
        {
            Debug.Log("Code Correct");
            gameObject.SetActive(false);
            ls.color = Color.green;
        }
        else
        {
            Debug.Log("Code Wrong");
            displayText.text = null;
            ls.color = Color.red;
        }

    }

    public void EnterClicked()
    {
        if (displayText.text == correctCode)
        {
            isCorrectCode = true;
            CodeCheck();
        }
        else
        {
            isCorrectCode = false;
            CodeCheck() ;
        }
    }
    public void ClearClicked()
    { 
        displayText.text = null;
    }
}
