using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ThankYou : MonoBehaviour
{

    public static Text t1;
  // public InputField inputField;
    public static string I2;
    // Use this for initialization
    void Start()
    {
        t1 = GetComponent<Text>();

        //I1.text = Submit.userName;


    }
    public void ShowText()
    {
        //  t1.text = inputField.GetComponent<InputField>().text;
        //t1.text = I1.text;
        // t1.text = Submit.userName;
        t1.text = Submit.userName;
        // Debug.Log(t1.text);
        //Debug.Log(t1.text);
    }
}