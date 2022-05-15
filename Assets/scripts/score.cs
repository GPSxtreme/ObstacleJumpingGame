
using System.Net.Mime;
using UnityEngine;
using UnityEngine.UI;


public class score : MonoBehaviour
{   
    public Transform player ; 
    public Text scoreTxt ;

    void Update()
    {
        scoreTxt.text = player.position.z.ToString("0");
    }
}
