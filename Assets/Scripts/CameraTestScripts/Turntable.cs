using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turntable : MonoBehaviour
{
    public GameObject TurnLeft1;
    public GameObject TurnLeft2;
    public GameObject TurnLeft3;
    public GameObject TurnLeft4;
    public GameObject TurnRight1;
    public GameObject TurnRight2;
    public GameObject TurnRight3;
    public GameObject TurnRight4;

    // Start is called before the first frame update
    void Start()
    {
        TurnLeft1.SetActive(true);
        TurnLeft2.SetActive(false);
        TurnLeft3.SetActive(false);
        TurnLeft4.SetActive(false);
        TurnRight1.SetActive(false);
        TurnRight2.SetActive(false);
        TurnRight3.SetActive(false);
        TurnRight4.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RotateLeft1()
    {
        transform.Rotate(0, 90, 0);
        transform.position += new Vector3(30, 0, 0);
        TurnLeft1.SetActive(false);
        TurnRight4.SetActive(false);
        TurnLeft2.SetActive(true);
        TurnRight1.SetActive(true);
    }

    public void RotateLeft2()
    {
        transform.Rotate(0, 90, 0);
        transform.position += new Vector3(30, 0, 0);
        TurnLeft2.SetActive(false);
        TurnRight1.SetActive(false);
        TurnLeft3.SetActive(true);
        TurnRight2.SetActive(true);
    }

    public void RotateLeft3()
    {
        transform.Rotate(0, 90, 0);
        transform.position += new Vector3(30, 0, 0);
        TurnLeft3.SetActive(false);
        TurnRight2.SetActive(false);
        TurnLeft4.SetActive(true);
        TurnRight3.SetActive(true);
    }

    public void RotateLeft4()
    {
        transform.Rotate(0, 90, 0);
        transform.position += new Vector3(30, 0, 0);
        TurnLeft4.SetActive(false);
        TurnRight3.SetActive(false);
        TurnLeft1.SetActive(true);
        TurnRight4.SetActive(true);
    }

    public void RotateRight1()
    {
        transform.Rotate(0, -90, 0);
        transform.position -= new Vector3(30, 0, 0);
        TurnRight1.SetActive(false);
        TurnLeft2.SetActive(false);
        TurnLeft1.SetActive(true);
        TurnRight4.SetActive(true);
    }

    public void RotateRight2()
    {
        transform.Rotate(0, -90, 0);
        transform.position -= new Vector3(30, 0, 0);
        TurnRight2.SetActive(false);
        TurnLeft3.SetActive(false);
        TurnLeft2.SetActive(true);
        TurnRight1.SetActive(true);
    }

    public void RotateRight3()
    {
        transform.Rotate(0, -90, 0);
        transform.position -= new Vector3(30, 0, 0);
        TurnRight3.SetActive(false);
        TurnLeft4.SetActive(false);
        TurnLeft3.SetActive(true);
        TurnRight2.SetActive(true);
    }

    public void RotateRight4()
    {
        transform.Rotate(0, -90, 0);
        transform.position -= new Vector3(30, 0, 0);
        TurnRight4.SetActive(false);
        TurnLeft1.SetActive(false);
        TurnLeft4.SetActive(true);
        TurnRight3.SetActive(true);
    }
}
