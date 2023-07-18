using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int bulletSpeed = 15;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //moves the bullet once its spawned from the logic script
        transform.Translate(Vector3.left * bulletSpeed * Time.deltaTime);
    }
}
