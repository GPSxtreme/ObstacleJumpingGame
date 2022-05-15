using UnityEngine.SceneManagement;
using UnityEngine;

public class gameManager : MonoBehaviour
{    bool gameHasEnded = false ;
    public float restartDelay = 1.2f;
    public GameObject lvlCompleteUi;
    public void endGame (){
       if(gameHasEnded == false){ 
        gameHasEnded = true ; 
        Invoke("restart",restartDelay);
       }
    }
    void restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void completedLvl(){
        lvlCompleteUi.SetActive(true);   
    }
}
