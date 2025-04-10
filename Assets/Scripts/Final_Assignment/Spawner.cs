using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnTime = 2f;
    public float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawnTime) {
            Spawn();
            timer = 0f;
        }
    }

    private void Spawn() {
       bool leftOrRight = Random.Range(0, 2) == 0;
       Vector3 spawnPos;
       int direction;

        if (leftOrRight) {
            spawnPos = new Vector3(-13f, -1f, -0.94f);
            direction = 1;


        } else {
            spawnPos = new Vector3(13f, -1f, -0.94f);
            direction = -1;

        }
GameObject enemy = Instantiate(enemyPrefab, spawnPos, Quaternion.identity);
enemy.GetComponent<Enemy>().SetDirection(direction);

       
    }
}
