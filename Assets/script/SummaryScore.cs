using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SummaryScore : MonoBehaviour
{
    // Start is called before the first frame update

    private int finalScore;
    public Scoreing scoreing;
    public int treshold = 200;
    private string ptNeed, ranking;
    public Text PtNeed, Ranking;
    void Start()
    {
        scoreing = GameObject.Find("num_score").GetComponent<Scoreing>();
    }

    // Update is called once per frame
    void Update()
    {
        finalScore = scoreing.final;
        if (finalScore < treshold)
        {
            ptNeed = (treshold - finalScore).ToString() + " MORE POINT TO UNLOCK NEW LV.";

            if (finalScore < treshold / 2)
            {
                ranking = "Fine";
            }
            else { ranking = "good!"; }
        }
        else
        {
            ptNeed = "UNLOCK NEW LEVEL";

            if (finalScore > treshold * 1.25)
            {
                ranking = "Perfect!";
            }
            else
            {
                ranking = "great!";
            }
 
        }
        PtNeed.text = ptNeed;
        Ranking.text = ranking;
    }

}
