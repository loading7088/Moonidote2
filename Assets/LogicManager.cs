using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicManager : MonoBehaviour
{
    public GameObject child;
    public GameObject adult;
    public GameObject gun;
    public GameObject bullet;

    public int fWMoveSpeed = 12;
    public int sHMoveSpeed = 8;
    public int aHitStr;
    public int cHitStr;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Moves fS (fast weal)
        child.transform.Translate(Vector3.left * fWMoveSpeed * Time.deltaTime);
        //Moves sH (slow hard)
        adult.transform.Translate(Vector3.left * sHMoveSpeed * Time.deltaTime);

        //spawns a bullet :D
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(bullet, gun.transform.position, bullet.transform.rotation);
        }

        if (bullet //bullets go off screen and get deletus'd
    }
}
