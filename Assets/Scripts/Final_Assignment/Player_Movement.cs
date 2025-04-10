using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
SpriteRenderer sr;
    public float speed;
    void Start() {
        sr = GetComponent<SpriteRenderer>();
    }
     void Update()
    {
        //Keyboard controls
        float moving = Input.GetAxis("Horizontal");

        //Movement speed, adjustable with speed value and kept smooth across frames with Time.deltaTime
        float moveAmount = moving * speed * Time.deltaTime;
                sr.flipX = moving < 0;
        //Turns the x value of the player's current location into a float value
        float currentX = transform.position.x;
        //Adds the character's movement speed and the immediate value of x together to ensure the player character doesn't get stuck on collision
        float newX = currentX + moveAmount;

        //Prevents the player from moving beyond these x values, using newX to stop them from getting stuck
        if (newX >= -13f && newX <= 13f)
        {
            transform.Translate(moveAmount, 0f, 0f);
        }
    }
}
