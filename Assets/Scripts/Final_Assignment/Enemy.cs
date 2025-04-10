using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 3f;
    public Vector2 direction;
    public float enemyHealth = 3f;
    public GameObject knight;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }
    void Die() {
    if (enemyHealth <= 0) {
        Destroy(gameObject);
    }
}
public void SetDirection(int Direction) {
    direction = new Vector3(Direction, 0, -0.94f);
}
}


