
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Spawner : MonoBehaviour
{
    public GameObject[] enemies;
    Vector3[] SpawnerPosition;

    int randEnemy;
    int randSpawn;
    private GameObject instantiatedObj;
 

    public bool stop;
    public bool stopspawn = false;
    public bool stopCounting;
    public bool stopCoroutine = false;
    public bool MouseClicked = false;
    public bool isstart;
    private Countdown321go countdown;
    // Start is called before the first frame update
    void Start()
    {
        //Change name of "spawnArea123"
        SpawnerPosition = new Vector3[3];
        SpawnerPosition[0] = getThePosition("spawnArea1");
        SpawnerPosition[1] = getThePosition("spawnArea2");
        SpawnerPosition[2] = getThePosition("spawnArea3");
        countdown = GameObject.Find("Canvas").GetComponent<Countdown321go>();
    }

    // Update is called once per frame
    void Update()
    {
        isstart = countdown.isstart;
        if (isstart)
        {


            //Every update find gameObject with tag "Player" and put in Counter[] 
            GameObject[] Counter = GameObject.FindGameObjectsWithTag("Player");
            Debug.Log("counter" + Counter);
            //Process that have to do if u want to use StopSpawner
            IEnumerator co;
            co = waitSpawner();

            //In case that Object is destroyed other than by themselves
            //Stop every process and start spawning agian.
            if (MouseClicked == true)
            {
                MouseClicked = false;
                StopCoroutine(co);
                StartCoroutine(waitSpawner());
            }

            //In case that it destroyed themselves.
            else if (MouseClicked == false)
            {

                // In case that there is an object in counter array.
                if (Counter.Length > 0)
                {
                    stopspawn = true;
                }
                else if (Counter.Length == 0)
                {
                    stopspawn = false;
                }

                if (stopCoroutine == false && stopspawn == false)
                {

                    stopCoroutine = true;

                    StartCoroutine(waitSpawner());

                }
                //stopspawn = true;
                for (int i = 0; i < Counter.Length; i++)
                {
                    Counter[i] = null;
                }
            }
        }



    }
    private IEnumerator  waitSpawner()
    {
        
        //Debug.Log("spawn 1");

        randEnemy = Random.Range(0, enemies.Length);
        randSpawn = Random.Range(0, SpawnerPosition.Length);


        instantiatedObj = (GameObject)Instantiate(enemies[randEnemy], SpawnerPosition[randSpawn] + transform.TransformPoint(0, 0, 0), gameObject.transform.rotation);

        
        yield return new WaitForSeconds(2);
        //Debug.Log("spawn 5");
        stopCoroutine = false;
        //Destroy(instantiatedObj);
    }
    Vector3 getThePosition(string name)
    {
        Vector3 Pose = new Vector3(
            GameObject.Find(name).transform.position.x,
            GameObject.Find(name).transform.position.y, 
            GameObject.Find(name).transform.position.z);

        return Pose;
    }

}
