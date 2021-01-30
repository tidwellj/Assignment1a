using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextChange : MonoBehaviour
{

    public void Change(float f)
    {
        if ( f == 1)
                {
           //  GetComponent<Text>().text = f.ToString();
          GetComponent<Text>().text = "100";
       }
        else if (f > .8 && f < 1)
        {
            GetComponent<Text>().text = "90";

        }
        else if (f > .7 && f < .9)
       {
            GetComponent<Text>().text = "80";

        }
        else if (f > .6 && f < .8)
        {
            GetComponent<Text>().text = "70";

        }
        else if (f > .5 && f < .7)
        {
            GetComponent<Text>().text = "60";

        }
        else if (f > .4 && f < .6)
        {
            GetComponent<Text>().text = "50";

        }
        else if (f > .3 && f < .5)
        {
            GetComponent<Text>().text = "40";

        }
        else if (f > .2 && f < .4)
        {
            GetComponent<Text>().text = "30";

        }
        else if (f > .1 && f < .3)
        {
            GetComponent<Text>().text = "20";

        }
        else if (f > .0 && f < .2)
        {
            GetComponent<Text>().text = "10";

        }
        else if (f == 0)
        {
            GetComponent<Text>().text = "0";

        } 
    }
}
