using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject pl;
    private Vector3 offset;
    void Start()
    {
        pl = GameObject.Find("Cube (1)");
        offset = transform.position - pl.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = pl.transform.position + offset;
    }
}
