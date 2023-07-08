using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FolowMainCharecter : MonoBehaviour
{

    public float playerRange;
    public Transform player;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawLine(new Vector3(
            transform.position.x + playerRange,
            transform.position.y,
            transform.position.z),

            new Vector3(player.position.x,
             player.position.y,
              player.position.z));
    }
}
