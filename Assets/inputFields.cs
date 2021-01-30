using UnityEngine;
using System.Collections;
using UnityEngine.UI; // Required when Using UI elements.

public class inputFields : MonoBehaviour
{
    
    public static string userIDs;
    void update()
    {

    }

    // Invoked when the value of the text field changes.
    public void textr(string s)
    {
        userIDs = s;
        Debug.Log("Barf");
        Debug.Log(userIDs);
        Debug.Log("Value Changed");
    }
}