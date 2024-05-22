using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureTiling : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
        Renderer renderer = GetComponent<Renderer>();
        Vector3 scale = transform.localScale;
        renderer.material.mainTextureScale = new Vector2(scale.z/3, scale.y/3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
