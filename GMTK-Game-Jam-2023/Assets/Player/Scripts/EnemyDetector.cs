using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDetector : MonoBehaviour
{
    public Transform target;
    public LineRenderer lineRenderer;
    public FolowMainCharecter Target;
    public Material material;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Target.distance < 30)
        {
            lineRenderer.SetPosition(
                0,
                new Vector3
                (
                transform.position.x,
                transform.position.y,
                transform.position.z
                )
            );

            lineRenderer.SetPosition(
                1,
                new Vector3(
                target.position.x,
                target.position.y,
                target.position.z
                )
            );
            material.SetColor("_EmissionColor", new Vector4(255,0,0,255) * 0.2f);

            Debug.Log(Target.distance);
        }
        else
        {
            material.color = Color.black;
            material.SetColor("_EmissionColor", new Vector4(255,255,255,255) * 0);

            lineRenderer.SetPosition(
                0,
                new Vector3
                (
                transform.position.x,
                transform.position.y,
                transform.position.z
                )
            );

            lineRenderer.SetPosition(
                1,
                new Vector3
                (
                target.position.x,
                target.position.y,
                target.position.z
                )
            );
        }
    }
}
