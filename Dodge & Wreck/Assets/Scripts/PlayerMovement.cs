using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 2000f;

    public float sidewaysForce = 500f;
    
    // Update is called once per frame and FixedUpdate is preferred by unity when messing with physics
    void FixedUpdate()
        {
            rb.AddForce(0, 0, forwardForce * Time.deltaTime);

      
        //for moving in right direction
        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        //for moving in left direction
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<Manager>().EndGame();
        }
    }
}
