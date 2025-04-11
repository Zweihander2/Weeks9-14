using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gem : MonoBehaviour
{
    public float damageBonus = 1f; // Bonus damage the gem provides
    public float pickupRange = 1.5f; // Range at which the gem can be collected
    private GameObject player;

    void Start()
    {
        player = GameObject.FindWithTag("Player"); // Find the player object
    }

    void Update()
    {
        if (player != null)
        {
            // Check if the player is within range of the gem
            float distanceToPlayer = Vector3.Distance(transform.position, player.transform.position);
            if (distanceToPlayer <= pickupRange)
            {
                CollectGem();
            }
        }
    }

    void CollectGem()
    {
        // Increase the player's damage bonus
        player.GetComponent<Player_Attack>().CollectGem(damageBonus);

        // Destroy the gem after it's collected
        Destroy(gameObject);
    }
}
