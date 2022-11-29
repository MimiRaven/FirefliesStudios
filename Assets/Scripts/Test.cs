using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public float smooth = 1f;
    private Quaternion targetRotation;
    void Start()
    {
        targetRotation = transform.rotation;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            targetRotation *= Quaternion.AngleAxis(60, Vector3.up);
        }
        transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, 10 * smooth * Time.deltaTime);
    }
}
