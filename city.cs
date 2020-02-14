using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class city : MonoBehaviour
{
    public GameObject[] g;

    void Start()
    {
        g = new GameObject[100];
        GameObject mycube = GameObject.Find("myCube");
        for(int ibuild = 0; ibuild<g.Length; ibuild++)
        {
            g[ibuild] = GameObject.Instantiate(mycube);

            Vector3 v = new Vector3();
            v.x = Random.Range(-100, 100);
            v.z = Random.Range(-100, 100);
            v.y = 0;
            g[ibuild].transform.Translate(v);
        }
    }
}
