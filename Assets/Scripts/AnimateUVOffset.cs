using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// animation des textures du plan qui défilent
public class AnimateUVOffset : MonoBehaviour
{

    Renderer rend;
    Global globalRef;
    public float multiplicator = 1;

    // Start is called before the first frame update
    void Start()
    {
     rend = GetComponent<Renderer>();   
     globalRef = FindObjectOfType<Global>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 offset = rend.material.GetTextureOffset("_MainTex");

        // x -1 car sinon on déplace le Y dans le mauvais sens
        offset.x +=  multiplicator * -1 * globalRef.Speed * Time.deltaTime;

        rend.material.SetTextureOffset("_MainTex", offset);
    }
}
