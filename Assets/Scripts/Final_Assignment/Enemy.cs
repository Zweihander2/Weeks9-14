using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 3f;
    public Vector2 direction;
    public float enemyHealth = 3f;
    public GameObject knight;

    void Update()
    {
        // Enemy movement
        transform.Translate(direction * speed * Time.deltaTime);
    }

    public void TakeDamage(float damageAmount)
    {
        enemyHealth -= damageAmount;
        Debug.Log("Enemy health: " + enemyHealth); // Debugging the damage taken
        if (enemyHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject); // Destroy the enemy when health reaches zero
    }

    public void SetDirection(int Direction)
    {
        direction = new Vector3(Direction, 0, -0.94f); // Set movement direction
    }
}

