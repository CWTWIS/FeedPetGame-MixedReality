using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonController : MonoBehaviour
{
    public GameObject StopMenu;
    public GameObject ConfirmToExit;
    public Time_recording time_Recording;

    private bool resume = true;
    public Countdown321go countGo;

    // Start is called before the first frame update
    void Start()
    {

        countGo = GameObject.Find("Countdown").GetComponent<Countdown321go>();
    }

    // Update is called once per frame
    void Update()
    {

    }



    public void Resume(bool resume)
    {
        resume = !resume;
        if (resume){
            Time.timeScale = 1f;
            StopMenu.gameObject.SetActive(false);
        }
        else
        {
            StopMenu.gameObject.SetActive(true);

            //time_Record.isstart = false;
            time_Recording = gameObject.GetComponent<Time_recording>();
            time_Recording.isstart = false;
            Debug.Log(time_Recording.isstart);
        }
    }
    public void ConfirmExit()
    {
        ConfirmToExit.gameObject.SetActive(true);
    }

}
