using UnityEngine;
using UnityEngine.SceneManagement;


public class menu : MonoBehaviour
{
    public void startGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1 );
    }
    public void exitGame (){
        Application.Quit();
    }
}
