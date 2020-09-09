
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
	public Rigidbody rb;
    // Start is called before the first frame update
	public float ForwardForce = 750f;
	public float SideForce = 100f;
    // Update is called once per frame
    void FixedUpdate()
    {
        // rb.AddForce(0,0,1000 * Time.deltaTime); //1000 on the z axis

        if (Input.GetKey("d")) {
        	rb.AddForce(SideForce * Time.deltaTime,0,0, ForceMode.VelocityChange);
        } 

        if(Input.GetKey("a")) {
        	rb.AddForce(-SideForce * Time.deltaTime,0,0, ForceMode.VelocityChange);
        }

        if(Input.GetKey("w")) {
        	rb.AddForce(0,0,ForwardForce * Time.deltaTime);
        }

        if(Input.GetKey("s")) {
        	rb.AddForce(0,0,-ForwardForce * Time.deltaTime);
        }

        if(rb.position.y < -1f){
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
