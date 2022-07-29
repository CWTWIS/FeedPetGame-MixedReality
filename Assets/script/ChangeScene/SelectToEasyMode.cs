using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectToEasyMode : MonoBehaviour
{
    public int SceneNumber;
    public void GoToInstructEasy()
    {
        SceneManager.LoadScene(2);
    }
    public void GoToInstructHardu()
    {
        SceneManager.LoadScene(4);
    }
    public void GoToEasy()
    {
        SceneManager.LoadScene(3);
    }
    public void GoToHard()
    {
        SceneManager.LoadScene(5);
    }
    public void GoToMenu()
    {
        SceneManager.LoadScene(2);
    }

}
