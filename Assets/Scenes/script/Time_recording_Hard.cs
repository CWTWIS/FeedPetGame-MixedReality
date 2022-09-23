using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Time_recording_Hard : MonoBehaviour
{
    public float timeleft = 10.00f;
    float oldtime;
    float miniute;
    float second;
    string[] millisec;
    public Text time_text;
    public bool isstart ;
    public string minString;
    public Slider slider;
    public Image fillArea;
    private bool isstop, timeStart;
    public Countdown321go countdown;
    public Text Timeup;
    public buttonController buttonControl;
    // Start is called before the first frame update
    void Start()
    {
        timeStart = true;
        oldtime = timeleft;
        slider = GameObject.Find("Slider").GetComponent<Slider>();
        countdown = GameObject.Find("Canvas").GetComponent<Countdown321go>();
        time_text = GameObject.Find("time_text").GetComponent<Text>();
        buttonControl = GameObject.Find("StopButton").GetComponent<buttonController>();

        slider.maxValue = timeleft;
        //slider.minValue = 0.0f;
        slider.value = oldtime;

    }

    // Update is called once per frame
    public void Update()
    {

        isstart = countdown.isstart;


        if (isstart && timeStart)
        {
      
            timeleft -= Time.deltaTime;
            slider.value = timeleft;

            if (timeleft <= 0.75 * oldtime)
            {

                fillArea.color = Color.yellow;
            }
            if (timeleft <= 0.25 * oldtime)
            {
                fillArea.color = Color.Lerp(Color.red, Color.white, Mathf.PingPong(Time.time, 0.5f));
            }
            if (timeleft <= 0)
            {
                isstop = true;
 
            }

            miniute = Mathf.Floor(timeleft / 60);
            second = timeleft % 60;
            millisec = second.ToString("f2").Split('.');
            if (second > 59)
            {
                second = 59;
            }
            if (miniute < 0)
            {
                miniute = 0;
                second = 0;
                timeStart = false;
                //Debug.Log("in");
            }

            time_text.text = ((int)miniute).ToString("D2") + ":" + ((int)Mathf.Floor(second)).ToString("D2") + ":" + millisec[1].ToString();
            minString = ((int)miniute).ToString("D2");
         
        }

        if (isstop)
        {
            StartCoroutine(EndGame());


        }
        IEnumerator EndGame()
        {
            Timeup.gameObject.SetActive(true);
          
            //GameController.instance.BeginGame();
            yield return new WaitForSeconds(2f);
            SceneManager.LoadScene(7);
        }

    }
    public void Stopclick()
    {
        isstart = false;
    }
}
