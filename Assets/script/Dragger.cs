using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Dragger : MonoBehaviour
{
    private GameObject selectedObject;

    private void Update()
    {
        
        Vector3 camPos = Camera.main.transform.position;

        if (Input.GetMouseButtonDown(0))
        {
            if (selectedObject == null)
            {
                RaycastHit hit = CastRay();
                if (hit.collider != null)
                {
                    if (!hit.collider.CompareTag("drag"))
                    {
                        return;
                    }
                    selectedObject = hit.collider.gameObject;

                }

            }
            else
            {

                Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.WorldToScreenPoint(selectedObject.transform.position).z);
                Vector3 worldPosition = Camera.main.ScreenToWorldPoint(position);
                selectedObject.transform.position = new Vector3(worldPosition.x, worldPosition.y, worldPosition.z);

                selectedObject = null;

  
            }
        }
        if(selectedObject != null)
        {
            


            Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.WorldToScreenPoint(selectedObject.transform.position).z);
            Vector3 worldPosition = Camera.main.ScreenToWorldPoint(position);
            
            selectedObject.transform.position = new Vector3(worldPosition.x, worldPosition.y, worldPosition.z );

            if (Input.mouseScrollDelta.y != 0)
            {
                Vector3 currentPos = selectedObject.transform.position;
                float moveingSpeed = Input.mouseScrollDelta.y * Time.deltaTime * 50f;
                currentPos.z += moveingSpeed;
                selectedObject.transform.position = new Vector3(worldPosition.x, worldPosition.y, currentPos.z);
            }



        }
 
    }
    private RaycastHit CastRay()
    {
        Vector3 ScreenMousePosFar = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.farClipPlane);
        Vector3 ScreenMousePosNear = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.nearClipPlane);
        Vector3 worldMousePosFar = Camera.main.ScreenToWorldPoint(ScreenMousePosFar);
        Vector3 worldMousePosNear = Camera.main.ScreenToWorldPoint(ScreenMousePosNear);

        RaycastHit hit;

        Physics.Raycast(worldMousePosNear, worldMousePosFar - worldMousePosNear, out hit);

        return hit;
    }
}
