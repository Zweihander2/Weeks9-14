using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public float speed = 5;
    void Update()
    {
       float moving = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
       transform.Translate(moving, 0, 0);
    }
}
