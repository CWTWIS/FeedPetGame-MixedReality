using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuToSelect : MonoBehaviour
{
    public void GoToSelectLevel()
    {
        SceneManager.LoadScene(1);
    }
}
