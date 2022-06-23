using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectToEasyMode : MonoBehaviour
{
    public int SceneNumber;
    public void GoToEasy()
    {
        SceneManager.LoadScene(4);
    }
    public void GoToMenu()
    {
        SceneManager.LoadScene(2);
    }

}
