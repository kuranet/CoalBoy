using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;
    public float speed = 500f;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        if (x != 0)
            rb.AddForce(new Vector3(x * speed * Time.deltaTime, 0, 0), ForceMode.Force);
        if (y != 0)
            rb.AddForce(new Vector3(0, 0, y * speed * Time.deltaTime), ForceMode.Force);
    }
}
