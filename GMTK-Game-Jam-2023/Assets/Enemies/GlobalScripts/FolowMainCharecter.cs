using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FolowMainCharecter : MonoBehaviour
{

    public Transform playerLongSotry;


    public GameObject player;
    public float speed;
    public float distance;

    // Update is called once per frame
    void Update()
    {
        Debug.DrawLine(new Vector3(
            transform.position.x,
            transform.position.y,
            transform.position.z),

            new Vector3(
                playerLongSotry.position.x,
                playerLongSotry.position.y,
                playerLongSotry.position.z
            )
        );

        distance = Vector3.Distance(transform.position, player.transform.position);
        Vector3 direction = player.transform.position - transform.position;

        transform.position = Vector3.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);
        // rigidbody.AddForce(vector3 * (movementSpeed * 100) * Time.deltaTime);

    }
}
