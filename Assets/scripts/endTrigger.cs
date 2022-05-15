using UnityEngine;

public class endTrigger : MonoBehaviour
{   
    public gameManager gameManager;
    void OnTriggerEnter(){
        gameManager.completedLvl();
    }    
}
