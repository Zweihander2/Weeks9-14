using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
<<<<<<< HEAD
    public float speed = 5;
    void Update()
    {
       float moving = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
       transform.Translate(moving, 0, 0);
=======
    public float speed;
     void Update()
    {
        //Keyboard controls
        float moving = Input.GetAxis("Horizontal");
        //Movement speed, adjustable with speed value and kept smooth across frames with Time.deltaTime
        float moveAmount = moving * speed * Time.deltaTime;
        //Turns the x value of the player's current location into a float value
        float currentX = transform.position.x;
        //Adds the character's movement speed and the immediate value of x together to ensure the player character doesn't get stuck on collision
        float newX = currentX + moveAmount;

        //Prevents the player from moving beyond these x values, using newX to stop them from getting stuck
        if (newX >= -13f && newX <= 13f)
        {
            transform.Translate(moveAmount, 0f, 0f);
        }
>>>>>>> Tilemap
    }
}
