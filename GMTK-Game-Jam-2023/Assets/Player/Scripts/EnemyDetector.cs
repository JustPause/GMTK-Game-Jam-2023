using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDetector : MonoBehaviour
{

    public FolowMainCharecter folowMainCharecter;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (folowMainCharecter.distance < 30)
        {
            Debug.Log(folowMainCharecter.distance);
        }
    }
}
