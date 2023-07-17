using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePlayer : MonoBehaviour
{
    public GameObject Player;

    public Rigidbody2D rb;

    public float moveSpeed = 10f;
    public int jumpstrength = 6;
    public int deathZone = -15;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Move left and right
        if(Input.GetKey(KeyCode.A))
        {
            Player.transform.Translate(Vector3.left  * moveSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            Player.transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        }

        //JUMP!!!
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.Space)) 
        {
            rb.AddForce(Vector2.up * jumpstrength, ForceMode2D.Impulse);
        }

        //Kills you if you fall to your death
        if (Player.transform.position.x < deathZone)
        {
            Destroy(Player);
            Debug.Log("Make game over screen");
        }
    }
}
