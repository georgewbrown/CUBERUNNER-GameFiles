using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //This is a refrence to the Rigidbody component called "rb"
    public Rigidbody rb;

    public float fowardForce = 2000f;
    public float sidewaysForce = 500f;
    
    // We marked this as "Fixed"Update because we 
    // are using it to mess with physics.
    void FixedUpdate()
    {
        // Add a foward force
       rb.AddForce(0, 0, fowardForce * Time.deltaTime); 

       if ( Input.GetKey("d") || Input.GetKey("right") )
       {
           // Only executed if condition is met
           rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
       }

       if ( Input.GetKey("a") || Input.GetKey("left") )
       {
           // Only executed if condition is met
           rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
       }

       if (rb.position.y < 0) {
           FindObjectOfType<GameManager>().EndGame();
       }
    }
}
