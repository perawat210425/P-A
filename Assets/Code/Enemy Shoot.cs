using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EbamyShoot : MonoBehaviour
{
    public GameObject bullet;
    public Transform bulletPos;

    private float timer;
    private GameObject player;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }


    // Update is called once per frame
    void Update()
    {

        float distance = Vector2.Distance(transform.position,player.transform.position);
        Debug.Log(distance);

        if(distance < 25)
        {
            timer += Time.deltaTime;
            if (timer > 3)
            {
                timer = 0;
                shoot();
            }
        }
    }
    void shoot()
    {
        Instantiate(bullet, bulletPos.position, Quaternion.identity);

    }
}
    
