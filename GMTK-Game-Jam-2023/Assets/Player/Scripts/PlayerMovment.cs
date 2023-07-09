using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{

    public float movementSpeed = 10;
    public float jumpPowor = 1;
    public float gravity = 9.8f;

    public Rigidbody player;
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
    public SpriteRenderer playerSpriteRenderer;
=======
>>>>>>> 6d303f1 (Gal po pudate UNiversal fixx)
=======
>>>>>>> 20d289d (Gal po pudate UNiversal fixx)
=======
    public SpriteRenderer playerSpriteRenderer;
>>>>>>> 89e2c82 (bEEPbOOP)
    public Vector3 movement;

    void Start()
    {
        playerSpriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        if (Input.GetAxis("Horizontal") < 0)
        {
            playerSpriteRenderer.flipX = true;
        }
        if(Input.GetAxis("Horizontal") > 0){
            playerSpriteRenderer.flipX = false;
        }

    }

    void FixedUpdate()
    {
        moveCharacter(movement);
    }

    void moveCharacter(Vector3 vector3)
    {
        // rigidbody.AddForce(vector3 * (movementSpeed * 100) * Time.deltaTime);
        player.velocity = (vector3 * (movementSpeed * 100) * Time.deltaTime);
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD

=======
>>>>>>> 6d303f1 (Gal po pudate UNiversal fixx)
=======
>>>>>>> 20d289d (Gal po pudate UNiversal fixx)
=======

>>>>>>> 89e2c82 (bEEPbOOP)
    }
}
