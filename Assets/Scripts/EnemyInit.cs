using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyInit : MonoBehaviour
{
    public GameObject enemyPrefab;

    float x;
    float y;

    public int enemyCounter;
    public int lvl;

    void Start()
    {
        x = Random.Range(-2f, 2f);
        y = Random.Range(-1.2f, 4.4f);

        Instantiate(enemyPrefab, new Vector2(x, y), enemyPrefab.transform.rotation);

        lvl = 1;
        enemyCounter = 1;
    }

    void Update()
    {
        if (enemyCounter == 0) 
        {
            lvl++;
            int i = lvl;
            while (i > 0)
            {
                x = Random.Range(-2f, 2f);
                y = Random.Range(-1.2f, 4.4f);

                Instantiate(enemyPrefab, new Vector2(x, y), enemyPrefab.transform.rotation);
                i--;
            }
            enemyCounter = lvl;
        }

    }
}
