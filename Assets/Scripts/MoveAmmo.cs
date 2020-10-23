using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAmmo : MonoBehaviour
{
    public Vector3 Direction;
    public float Speed;

    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(Speed * Direction * Time.deltaTime);
    }
}
