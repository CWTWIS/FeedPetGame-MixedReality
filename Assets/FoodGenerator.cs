using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodGenerator : MonoBehaviour
{
    public GameObject[] FoodList;
    private Vector3[] FoodPosList, FoodRotation, FoodScale;


    // Start is called before the first frame update
    void Start()
    {
        FoodPosList = new Vector3[FoodList.Length];
        FoodRotation = new Vector3[FoodList.Length];
        FoodScale = new Vector3[FoodList.Length];

        for(int i = 0; i < FoodList.Length; i ++)
        {

            if(GameObject.Find(FoodList[i].name) != null) {
            
                Vector3 pos = GameObject.Find(FoodList[i].name).transform.position;
                Vector3 rotation = GameObject.Find(FoodList[i].name).transform.rotation.eulerAngles;
                Vector3 scale = GameObject.Find(FoodList[i].name).transform.localScale;
                FoodPosList[i] = pos;
                FoodRotation[i] = rotation;
                FoodScale[i] = scale;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        int i = 0;
        foreach(GameObject food in FoodList)
        {
            if (GameObject.Find(food.name) == null){
                Debug.Log(food.name + "doesn't exist");
                GameObject newFood = Instantiate(food, new Vector3(FoodPosList[i].x, FoodPosList[i].y, FoodPosList[i].z),
                    Quaternion.Euler(FoodRotation[i].x, FoodRotation[i].y, FoodRotation[i].z));
                newFood.transform.localScale = new Vector3(0.2f*FoodScale[i].x, 0.2f*FoodScale[i].y, 0.2f*FoodScale[i].z);
                newFood.name = food.name;
            }
            i++;
        }
    }
}
