using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAmmo : MonoBehaviour
{
    public float RotateSpeed  = 80;

    public float horVal  = 2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up, RotateSpeed * Time.deltaTime * horVal);
    }
}
