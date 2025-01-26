
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class PlayerControllerMovie : MonoBehaviour
{
    public GameObject p3;

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Player")
        {
            Debug.Log("Collision detected");
            p3.GetComponent<Renderer>().enabled = false;
        }
    }
}
