using UnityEngine;

public class playerCollision : MonoBehaviour
{   public playerControl playerMovement;
    
    public GameObject player ; 
    void OnCollisionEnter(Collision collisionInfo){
        if(collisionInfo.collider.tag == "obstacle")
        {
            playerMovement.enabled = false;
            
            FindObjectOfType<gameManager>().endGame();  
        } 
    }    
}
