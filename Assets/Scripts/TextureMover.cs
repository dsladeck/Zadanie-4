using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureMover : MonoBehaviour
{
    public float speed = 1.0f;
    private Material material;

    void Start()
    {
       material = GetComponent<Renderer>().material;
    }

    void Update()
    {
        material.SetFloat("_Speed", speed);
    }
}
