using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManiController : MonoBehaviour
{
    private GameObject gameObject;
    private bool Manipulate = false;
    public Vector3 OriginalPos;

    private void Update()
    {


    }
    public void OnManipulationStarted()
    {
        if (!Manipulate)
        {

            Vector3 OriginalPos = gameObject.transform.position;
            Manipulate = true;
            Debug.Log("manipulated = " + Manipulate);
            Debug.Log("OriginalPos = " + OriginalPos);

        }
    }

    public void OnrRelease()
    {
        transform.position = new Vector3(OriginalPos.x, OriginalPos.y, OriginalPos.z);
        Manipulate = false;
    }
}
