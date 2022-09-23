using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManiController : MonoBehaviour
{
    //private GameObject gameObject;
    private bool Manipulate = false;
    public Vector3 OriginalPos;
    public GameObject Food;
    public Behaviour objectManipulator;

    private void Start()
    {
        OriginalPos = gameObject.transform.position;

    }
    private void Update()
    {

    }
    public void OnManipulationStarted()
    {
        if (!Manipulate)
        {

            Manipulate = true;
            
            //Debug.Log("OriginalPos = " + OriginalPos);

        }
    }

    public void OnrRelease()
    {
       
        transform.position = new Vector3(OriginalPos.x, OriginalPos.y, OriginalPos.z);
        //Debug.Log("manipulated = " + transform.position);
    }

    // Move objest to the plate when collison the food
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "animal")
        {
            Destroy(gameObject);
            //GameObject NewBone = Instantiate(Food, new Vector3(OriginalPos.x, OriginalPos.y, OriginalPos.z), Quaternion.Euler(90f, 0f, 90f));
            //NewBone.transform.localScale = new Vector3(0.04f, 0.04f, 0.04f);
            //NewBone.name = OriginalName;
        }

    }
}
