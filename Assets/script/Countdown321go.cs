using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown321go : MonoBehaviour
{
    public int countdownTime;
    public Text countdownDisplay;
    public bool isstart = false;

    private void Start()
    {
        StartCoroutine(CountdownToStart());
    }
    void Update()
    {
        Debug.Log(isstart);
    }

    IEnumerator CountdownToStart()
    {
        Debug.Log(isstart);
        while (countdownTime > 0)
        {
            countdownDisplay.text = countdownTime.ToString();
            yield return new WaitForSeconds(1f);
            countdownTime--;
        }
        countdownDisplay.text = "GO!";
        //GameController.instance.BeginGame();
        yield return new WaitForSeconds(1f);
        countdownDisplay.gameObject.SetActive(false);
        isstart = true;
        yield return null;


    }

}
