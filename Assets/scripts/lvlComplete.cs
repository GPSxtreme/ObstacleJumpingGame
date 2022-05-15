using UnityEngine;
using UnityEngine.SceneManagement;


public class lvlComplete : MonoBehaviour
{
    public void loadNxtLvl(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
