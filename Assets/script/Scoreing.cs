using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoreing : MonoBehaviour
{
    public Text scoring;
    public int totalScore = 0;
    // Start is called before the first frame update
    void Start()
    {
        scoring = GameObject.Find("scoring").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("score = "+ totalScore);
        scoring.text = (totalScore.ToString());
    }
}
