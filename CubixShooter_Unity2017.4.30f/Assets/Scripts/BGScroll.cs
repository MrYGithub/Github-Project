using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGScroll : MonoBehaviour {

    public float scrollSpeed = 0.1f;
    Material thisMaterial;

    private void Start()
    {
        thisMaterial = GetComponent<Renderer>().material;
    }

    private void Update()
    {
        Vector2 newOffset = thisMaterial.mainTextureOffset;
        newOffset.Set(0, newOffset.y + (scrollSpeed * Time.deltaTime));
        thisMaterial.mainTextureOffset = newOffset;
    }
}
