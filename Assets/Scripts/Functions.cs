using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Functions : MonoBehaviour
{
    public Rigidbody2D playerRB;
    public Transform playerTransform;
    public GameObject laserPrefab;

    float speed;
    float tiltAroundZ;
    float smooth;
    // sound
    public AudioSource audioSource;
    public AudioClip laserEffect;


    void Start()
    {
        playerRB = GameObject.Find("Player").GetComponent<Rigidbody2D>();
        playerTransform = GameObject.Find("Player").transform;

        speed = 4f;
    }

    public void Fire()
    {
        Debug.Log("Fire");
        Instantiate(laserPrefab, new Vector2(playerTransform.position.x, playerTransform.position.y), laserPrefab.transform.rotation);
        audioSource.PlayOneShot(laserEffect);
    }

    public void Move(string cmd)
    {
        if (cmd == "UP")
        {
            playerRB.velocity = new Vector2(0, speed);
        }
        else if (cmd == "RIGHT")
        {
            playerRB.velocity = new Vector2(speed, 0);
        }
        else if (cmd == "DOWN")
        {
            playerRB.velocity = new Vector2(0, -speed);
        }
        else if (cmd == "LEFT")
        {
            playerRB.velocity = new Vector2(-speed, 0);
        }
        else if (cmd == "STOP")
        {
            playerRB.velocity = new Vector2(0, 0);
        }
    }
}
