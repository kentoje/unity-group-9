using System.Collections;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    public Vector3 direction;

    // private GlobalVars globalRef;
    public float speed = 5;


    // start est l'équivalent de mounted en vue
    void Start()
    {
      // globalRef = GameObject.FindObjectOfType<GlobalVars>();
        
    }

    // Update is called once per frame
    void Update()
    {
      // transform.Translate(globalRef.speed * direction * Time.deltaTime);
      transform.Translate(speed * direction * Time.deltaTime);
    }
}