
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{

    //Countdown variable of 3 seconds
    public float timeRemaining = 3f;
    public Rigidbody rb;
    //public float forwardForce = 2000f;  // Variable that determines the forward force
    public float sidewaysForce = 500f;
    public static string fForce;
    

      
    

    void FixedUpdate()
    {
        timeRemaining -= Time.deltaTime;


        //Added countdown
        if (timeRemaining > 0)
        {








        }
        else
        {
            
            fForce = DropD.forwardForce;
            //Original code for forward movement
            
            if (fForce == "Easy")
            {
                rb.AddForce(0, 0, 2000 * Time.deltaTime);

            }
            else if (fForce == "Medium")
            {
                rb.AddForce(0, 0, 4000 * Time.deltaTime);
            }
           else if (fForce == "Difficult")
            {
                rb.AddForce(0, 0, 6000 * Time.deltaTime);
           } 
        }

            if (Input.GetKey("d"))  // If the player is pressing the "d" key
            {
                // Add a force to the right
                rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }

            if (Input.GetKey("a"))  // If the player is pressing the "a" key
            {
                // Add a force to the left
                rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }
            if (rb.position.y < -1f)
            {
                FindObjectOfType<GameManager>().EndGame();
            }
            
        
        Debug.Log(fForce);
    }
}
