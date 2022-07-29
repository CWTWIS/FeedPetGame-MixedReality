using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManiController : MonoBehaviour
{
    private GameObject gameObject;
    private bool Manipulate = false;
    public Vector3 OriginalPos;
    public GameObject plate;
    private void Update()
    {


    }
    public void OnManipulationStarted()
    {
        if (!Manipulate)
        {

            OriginalPos = plate.transform.position;
            Manipulate = true;
            
            Debug.Log("OriginalPos = " + OriginalPos);

        }
    }

    public void OnrRelease()
    {
       
        transform.position = new Vector3(OriginalPos.x, OriginalPos.y, OriginalPos.z);
        Debug.Log("manipulated = " + transform.position);
    }
}
