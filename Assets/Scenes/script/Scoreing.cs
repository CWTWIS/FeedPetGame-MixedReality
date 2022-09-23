using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoreing : MonoBehaviour
{
    static Scoreing score;
    public Text scoring, Ranking, PtNeed;
    private string ranking, ptNeed;
    public int totalScore ,final;
    public static int finalScore = 0;
    private int treshold = 10;
    // Start is called before the first frame update
    void Start()
    {
        totalScore = finalScore;
        score = new Scoreing();




    }

    // Update is called once per frame
    void Update()
    {
        //totalScore += 1;
        //Debug.Log("score = "+ totalScore);
        scoring.text = (totalScore.ToString());
        finalScore = totalScore;
        final = finalScore;


    }
    
}
