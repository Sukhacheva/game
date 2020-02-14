using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class forCube : MonoBehaviour
{
    private float speed = 30f;
    private Rigidbody rb;
    public GameObject g;
    private int count;
    public Text newText, winText;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        setCount();
        winText.text = "";
        g = GameObject.Find("Cube (1)");
    }


    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

            rb.AddForce(movement * speed);
        //transform.Translate(0.1f, 0, 0);
       // g.transform.Rotate(Vector3.up, 1, Space.World);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Capsule")
        {
            Destroy(other.gameObject);
            count++;
            setCount();
        }
            
    }

    void setCount()
    {
        newText.text = "Собрано: " + count.ToString();
        if (count >= 3)
            winText.text = "Вы выиграли";
    }
}
