using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour
{
    public Transform target;
    Vector3 offset;
    public float lerpValue = 0.1f;

    void Start()
    {
        offset = transform.position - target.position;
    }

    void Update()
    {
        Vector3 newPos = target.position + offset;

        // Lerp £¨position1,position2,value between 0~1£©
        Vector3 pos = Vector3.Lerp(transform.position, newPos, lerpValue);

        //transform.position = newPos;
        transform.position = pos;

        // turn to target point
        //transform.LookAt(target);

    }
}
