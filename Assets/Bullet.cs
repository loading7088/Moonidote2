using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int bulletSpeed = 15;
    public int offScreen = 20;

    public GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //moves the bullet once its spawned from the logic script
        transform.Translate(Vector3.right * bulletSpeed * Time.deltaTime);

        if (bullet.transform.position.x > offScreen)
        {
            Destroy(gameObject);
        }
    }
}
