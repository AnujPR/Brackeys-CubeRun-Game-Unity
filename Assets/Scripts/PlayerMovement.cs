using System.Threading;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Refference to rigidbody component rb 
    public Rigidbody rb; 
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    // FixedUpdate to mess wit unity physics
    void FixedUpdate()
    {
        //Add a forward force
        rb.AddForce(0, 0, forwardForce*Time.deltaTime);
        
        if( Input.GetKey("d") )
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
