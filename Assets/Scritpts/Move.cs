using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 3.0f;
    void Start()
    {
        
    }

    
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // (1,0,1)  length    1.414   The slope will go faster
        // (1,0,0)  length    1
        // (0.1f,0,0)  after normalized,turns into (1,0,1),if normalized directly,the smaller input will become bigger

        Vector3 input = new Vector3(horizontal, 0, vertical);
        if(input.magnitude > 1)
        { input = input.normalized; }

        // consider the time factor to offset the influence of frame rate change.
        // If the frame rate becomes higher, the distance traveled per frame becomes smaller

        // transform.position += input * speed * Time.deltaTime;            // 世界坐标系
        transform.Translate(input * speed * Time.deltaTime,Space.Self);     // 自身坐标系
    }
}
