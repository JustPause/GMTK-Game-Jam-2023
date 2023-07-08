using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FolowMainCharecter : MonoBehaviour
{

    public Transform player;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawLine(new Vector3(
            transform.position.x,
            transform.position.y,
            transform.position.z),

            new Vector3(
                player.position.x,
                player.position.y,
                player.position.z
            )
        );

        Vector3 direction = player.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        rb.rotation = new Quaternion(0, 90, 0, 0);
        Debug.Log(angle);
    }
}
