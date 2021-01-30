using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Submit : MonoBehaviour
{
    public static string userName;
    //public static Text T3;
    public void OnButton()
    {
        Debug.Log("Button was pressed!");
        userName = "Player Name is " + inputFields.userIDs;
        Debug.Log(userName);
    }

}
