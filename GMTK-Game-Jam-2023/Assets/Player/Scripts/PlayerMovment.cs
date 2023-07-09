using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{

    public float movementSpeed = 10;
    public float jumpPowor = 1;
    public float gravity = 9.8f;

    public Rigidbody player;
    public Vector3 movement;

    void Update()
    {
        movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
    }

    void FixedUpdate()
    {
        moveCharacter(movement);
    }

    void moveCharacter(Vector3 vector3)
    {
        // rigidbody.AddForce(vector3 * (movementSpeed * 100) * Time.deltaTime);
        player.velocity = (vector3 * (movementSpeed * 100) * Time.deltaTime);
    }
}
