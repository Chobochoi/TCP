using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneMove : MonoBehaviour
{   
    public void SeverGo()
    {
        SceneManager.LoadScene("01.Scenes/03.Bus");
    }

    public void ClientGo()
    {
        SceneManager.LoadScene("01.Scenes/02.Client");
    }
    public void GoBack()
    {
        SceneManager.LoadScene("01.Scenes/01.Main");
    }
    
}
