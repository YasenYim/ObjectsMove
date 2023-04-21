using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateMove : MonoBehaviour
{
    public float speed = 3.0f;
    public float rotateSpeed = 3.0f;
    void Start()
    {

    }


    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // h controls rotate
        transform.Rotate(new Vector3(0, horizontal * rotateSpeed * Time.deltaTime, 0));

        // v controls forward and backward movement
        transform.Translate(new Vector3(0, 0, vertical) * speed * Time.deltaTime);

    }
}
