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


        if (TimeToDestroy < 151)
        {
            DestrotTime = 10;

            if (TimeToDestroy < 101)
            {
                DestrotTime = 8;

                if (TimeToDestroy < 51)
                {
                    DestrotTime = 6;
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
        Debug.Log("colldie" + gameObject.name);
        if (collision.collider.tag != "food")
        {
            Debug.Log("return");
            return;
        }


        //Output the Collider's GameObject's name

        if (gameObject.name == "Dog(Clone)" && collision.collider.name == "Dog_bone_low_poly")
        {
            scoring.totalScore += 1;
        }
        else if (gameObject.name == "Rat(Clone)" && collision.collider.tag == "food")
        {
            scoring.totalScore -= 3;
        }
        else if (gameObject.name == "Crane(Clone)" && collision.collider.name == "Sunflower_Seed_High_Poly")
        {
            scoring.totalScore += 1;
        }
        else if (gameObject.name == "cat01(Clone)" && collision.collider.name == "Fish")
        {
            scoring.totalScore += 1;
        }

        Destroy(gameObject);
        spawner.MouseClicked = true;
    }


}
