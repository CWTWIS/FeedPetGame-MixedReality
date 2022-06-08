using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectToEasyMode : MonoBehaviour
{
    public void GoToEasy()
    {
        SceneManager.LoadScene(3);
    }
}
