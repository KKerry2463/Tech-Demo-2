using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Keypad : MonoBehaviour
{
    [SerializeField] private GameObject button1, button2, button3, button4, button5, button6, button7, button8, button9, button0, buttonClear, buttonEnter;
    [SerializeField] private TMP_InputField charHolder;
    public void b0()
    {
        charHolder.text = charHolder.text + "0";
    }
    public void b1()
    {
        charHolder.text = charHolder.text + "1";
    }
    public void b2()
    {
        charHolder.text = charHolder.text + "2";
    }
    public void b3()
    {
        charHolder.text = charHolder.text + "3";
    }
    public void b4()
    {
        charHolder.text = charHolder.text + "4";
    }
    public void b5()
    {
        charHolder.text = charHolder.text + "5";
    }
    public void b6()
    {
        charHolder.text = charHolder.text + "6";
    }
    public void b7()
    {
        charHolder.text = charHolder.text + "7";
    }
    public void b8()
    {
        charHolder.text = charHolder.text + "8";
    }
    public void b9()
    {
        charHolder.text = charHolder.text + "9";
    }
    public void ClearEvent()
    {
        charHolder.text = null;
    }
    public void EnterEvent()
    {
        if (charHolder.text == "2463")
        {
            Debug.Log("Passcode Correct");
            Destroy(gameObject);
        }
        else 
        {
            Debug.Log("Passcode Wrong FUCKO!");
        }
    }


}
