using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicManager : MonoBehaviour
{
    public GameObject child;
    public GameObject adult;
    public GameObject player;
    public GameObject gun;
    public GameObject bullet;

    public SpriteRenderer gunRend;
    public SpriteRenderer playerRend;
    public Sprite gunFire;
    public Sprite playerGun;


    public Vector3 bulletOffset = new Vector3(0.4f, 0, 0);

    public int cMoveSpeed = 12;
    public int aMoveSpeed = 8;
    public int aHitStr;
    public int cHitStr;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Moves fS (fast weak)
        child.transform.Translate(Vector3.left * aMoveSpeed * Time.deltaTime);
        //Moves sH (slow hard)
        adult.transform.Translate(Vector3.left * cMoveSpeed * Time.deltaTime);

        //spawns a bullet :D
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(bullet, gun.transform.position + bulletOffset, bullet.transform.rotation);
            gunRend.sprite = gunFire;
            playerRend.sprite = playerGun;
        }         
    }
}
