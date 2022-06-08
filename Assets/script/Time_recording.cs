using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Time_recording : MonoBehaviour
{
    public float timeleft = 300.00f;
    float oldtime;
    float miniute;
    float second;
    string[] millisec;
    public Text time_text;
    public bool isstart ;
    public string minString;

    // Start is called before the first frame update
    void Start()
    {
        oldtime = timeleft;
    }

    // Update is called once per frame
    void Update()
    {
        if (isstart)
        {
            timeleft -= Time.deltaTime;
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
                isstart = false;
                Debug.Log("in");
            }

            time_text.text = ((int)miniute).ToString("D2") + ":" + ((int)Mathf.Floor(second)).ToString("D2") + ":" + millisec[1].ToString();
            minString = ((int)miniute).ToString("D2");
         
        }
    }
}
