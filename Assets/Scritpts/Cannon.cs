using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    public float hSpeed = 5;
    public float vSpeed = 3;
    public float bulletSpeed = 100;
    public Rigidbody prefabBullet;
    public Transform cannonBody;
    public Transform bulletPos;
    Transform pitch;      // ¸©Ñö¿ØÖÆ
    
    
    void Start()
    {
        pitch = transform.Find("¸©Ñö»ù×¼");
    }

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        
        // ×óÓÒÐý×ª
        transform.Rotate(0, h * hSpeed * Time.deltaTime, 0);
        // ¸©ÑöÐý×ª
        pitch.Rotate(v * vSpeed * Time.deltaTime, 0, 0);

        // ¿ª»ðÂß¼­
        bool fire = Input.GetButtonDown("Fire1");
        if(fire)
        {
            Rigidbody bullet = Instantiate(prefabBullet,bulletPos.position,transform.rotation);
            bullet.velocity = cannonBody.up * bulletSpeed;
        }

    }
}
