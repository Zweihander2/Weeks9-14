using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Attack : MonoBehaviour
{
    public float baseDamage = 1f;  // Base damage
    public float damageBonus = 0f; // Bonus damage from the gem
    public float attackRange = 1.5f; // Attack range (how close you need to be to the enemy)
    public List<GameObject> enemies;   // List to hold enemies in the scene

    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
        enemies = new List<GameObject>(); // Initialize enemies list
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Mouse click to attack
        {
            animator.SetTrigger("attack");
            Attack();
        }
    }

    void Attack()
    {
        // Calculate total damage (base damage + bonus damage from the gem)
        float totalDamage = baseDamage + damageBonus;

        // Check all enemies and apply damage if within range
        foreach (GameObject enemyObj in enemies)
        {
            if (enemyObj != null)
            {
                float distanceToEnemy = Vector3.Distance(transform.position, enemyObj.transform.position);
                if (distanceToEnemy <= attackRange)
                {
                    // Apply damage to enemy
                    enemyObj.GetComponent<Enemy>().TakeDamage(totalDamage);
                }
            }
        }
    }

    // Method to collect the gem and increase damage
    public void CollectGem(float gemDamageBonus)
    {
        damageBonus = gemDamageBonus; // Increase damage bonus from the gem
    }

    // Method to add enemy to the list
    public void AddEnemy(GameObject enemy)
    {
        if (!enemies.Contains(enemy))
        {
            enemies.Add(enemy);
        }
    }
}


