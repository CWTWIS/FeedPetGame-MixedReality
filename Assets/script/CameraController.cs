using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Vector3 moveingPosition;
    public Vector3 originalPosition;
    public Vector3 spherePosition;

    GameObject gameObject;
    GameObject sphere;
    

    void Start()
    {
        sphere = GameObject.Find("Sphere");
        spherePosition = sphere.transform.position;
        originalPosition = new Vector3(transform.position.x, transform.position.y, transform.position.z) ;

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 transformPosition = transform.position;
        moveingPosition = transformPosition;

        float moveingSpeed = Input.mouseScrollDelta.y * Time.deltaTime * 50f;
        moveingPosition.z += moveingSpeed;
        transform.position = moveingPosition;

        //rotation
        float roataionSpeedX = Input.GetAxisRaw("Vertical") * Time.deltaTime * 10f;
        transform.Rotate(-roataionSpeedX, 0, 0);

        float roataionSpeed = Input.GetAxisRaw("Horizontal") * Time.deltaTime*10f;
        transform.Rotate(0,roataionSpeed, 0);


        if (Input.GetKey("q"))
        {
            transform.position = new Vector3(originalPosition.x, originalPosition.y, originalPosition.z) ;
            transform.eulerAngles = new Vector3 (0, 0, 0);
            sphere.transform.position = new Vector3(spherePosition.x, spherePosition.y, spherePosition.z);

        }
    }
}
