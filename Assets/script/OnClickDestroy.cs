using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClickDestroy : MonoBehaviour
{

    public Spawner spawner;
    public Scoreing scoring;
    public Time_recording timeRecording;
    float TimeToDestroy;
    int DestrotTime = 6;
    public void Start()
    {
        //get script from time_text
        timeRecording = GameObject.Find("time_text").GetComponent<Time_recording>();

        //get script from score scoring
        scoring = GameObject.Find("scoring").GetComponent<Scoreing>();


        //get timeleft variable from time_recording 
        TimeToDestroy = timeRecording.timeleft;
        Debug.Log(TimeToDestroy);


        if (TimeToDestroy < 301)
        {
            DestrotTime = 6;

            if (TimeToDestroy < 290)
            {
                DestrotTime = 3;

                if (TimeToDestroy < 280)
                {
                    DestrotTime = 1;
                }
            }
        }

        //get spawner script from spawner1
        spawner = GameObject.Find("spawner1").GetComponent<Spawner>();
        Destroy(gameObject, DestrotTime);

    }
    void Update()
    {
    }

    void OnMouseDown()
    {
        Destroy(gameObject);
        spawner.MouseClicked = true;

    }

    //destroy when collision
    void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag != "animal" || collision.collider.name != ("cat(clone)"))
        {
            return;
        }

        Debug.Log(collision.collider.name + " + " + gameObject.name);
        //Output the Collider's GameObject's name
        Debug.Log(collision.collider.name);
        if (gameObject.name == "dog01(Clone)" && collision.collider.name == "Dog_bone_low_poly")
        {
            scoring.totalScore += 1;
        }
        else if (gameObject.name == "Rat(Clone)" && collision.collider.tag == "food")
        {
            scoring.totalScore -= 1 ;
        }
        else if (gameObject.name == "bird01(Clone)" && collision.collider.name == "Sunflower_Seed_High_Poly")
        {
            scoring.totalScore += 1;
        }
        else if (gameObject.name == "cat(Clone)" && collision.collider.name == "Fish")
        {
            scoring.totalScore += 1;
        }

        Debug.Log("colldie");
        Destroy(gameObject);
        spawner.MouseClicked = true;
    }


}
