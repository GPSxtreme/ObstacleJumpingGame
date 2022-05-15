
using UnityEngine;

public class playerControl : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 1000f;
    public float horizontalForce = 500f;

    
    // Start is called before the first frame update
    

    // Update is called once per frame
    void FixedUpdate()
    {
        
        rb.AddForce(0,0,forwardForce*Time.deltaTime);
        if(Input.GetKey("d")){
            rb.AddForce(horizontalForce*Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
         if(Input.GetKey("a")){
            rb.AddForce(-horizontalForce*Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
        if(rb.position.y < -2f){
            FindObjectOfType<gameManager>().endGame();
        } 
        
         
    }
}
