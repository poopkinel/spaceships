using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyController : MonoBehaviour
{
    EnemyInit enemyInit;

    // Start is called before the first frame update
    void Awake()
    {
        enemyInit = GameObject.Find("Functions").GetComponent<EnemyInit>();
    }

    // Update is called once per frame
    void Update()
    {
           
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log("inside collisionEnter2d");
        Debug.Log("tag = " + collision.gameObject.tag);
        Debug.Log("tag = " + collision.gameObject.name);
        if (collision.gameObject.tag == "Laser")
        {
            Destroy(gameObject);
            enemyInit.enemyCounter--;
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.tag == "Player")
        {
            Destroy(collision.gameObject);
            SceneManager.LoadScene("GameOver");
        }
    }

}
